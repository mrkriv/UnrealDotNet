#include "GenericScriptCodeGenerator.h"
#include "UObject/UnrealType.h"
#include "ScriptGeneratorLog.h"
#include "Misc/Paths.h"
#include <regex>	//#include "Regex.h" wtf?

static const FString CPP_API_NAME = TEXT("UNREALDOTNETRUNTIME");
static const FString CPP_Function_Prefix = TEXT("Call_");
static const FString CPP_OtrReturn_Name = TEXT("OutResultValue");
static const FString CS_Namespace_Name = TEXT("UnrealEngine");
static const FString CS_NativeDLL_Name = TEXT("UE4Editor-UnrealDotNetRuntime");
static const FString CS_Project_Path = TEXT("Source\\UnrealDotNetWrapper\\Generate");

FGenericScriptCodeGenerator::FGenericScriptCodeGenerator(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& InIncludeBase)
	: FScriptCodeGeneratorBase(RootLocalPath, RootBuildPath, OutputDirectory, InIncludeBase)
{
}

void FGenericScriptCodeGenerator::ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged)
{
	if (CanExportClass(Class))
	{
		AllExportClass.Add({ Class, SourceHeaderFilename, GeneratedHeaderFilename });
		return;
	}
}

void FGenericScriptCodeGenerator::ExportClass_Real(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename)
{
	UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("Exporting class %s"), *Class->GetName());

	const FString ClassNameCPP = GetClassNameCPP(Class);
	AllSourceClassHeaders.Add(SourceHeaderFilename);

	FCodeBuilder CodeCPP;
	FCodeBuilder CodeCS;

	CodeCPP
		.AppendLine("#pragma once")
		.AppendLine("#include \"%s\"", *RebaseToBuildPath(SourceHeaderFilename))
		.AppendLine()
		.AppendLine("extern \"C\"")
		.OpenBrace();

	CodeCS
		.AppendLine("using System;")
		.AppendLine("using System.Runtime.InteropServices;")
		.AppendLine()
		.AppendLine("namespace %s", *CS_Namespace_Name)
		.OpenBrace();

	ExportSummaryCS(CodeCS, Class->GetToolTipText());

	CodeCS
		.AppendLine("public class %s : %s", *ClassNameCPP, TEXT("UObject"))	// *GetClassNameCPP(Class->GetOwnerClass())
		.OpenBrace()
		.AppendLine("private readonly IntPtr NativePointer;")
		.AppendLine()
		.AppendLine("internal %s(IntPtr Adress)", *ClassNameCPP)
		.OpenBrace()
		.Append("NativePointer = Adress;")
		.CloseBrace()
		.AppendLine()
		.AppendLine();

	bool canExport = false;
	for (TFieldIterator<UFunction> FuncIt(Class, EFieldIteratorFlags::ExcludeSuper); FuncIt; ++FuncIt, canExport = true)
	{
		UFunction* Function = *FuncIt;

		if (CanExportFunction(Function))
		{
			UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("Export for dotnet %s.%s"), *ClassNameCPP, *Function->GetName());

			FString DeclareExternFragment;
			ExportFunctionCPP(CodeCPP, ClassNameCPP, Class, Function, DeclareExternFragment);
			ExportFunctionCS(CodeCS, ClassNameCPP, Class, Function, DeclareExternFragment);
		}
	}

	if (!canExport)
	{
		return;
	}

	CodeCPP.CloseBrace();

	CodeCS
		.AppendLine("public static explicit operator IntPtr(%s Self)", *ClassNameCPP)
		.OpenBrace()
		.Append("return Self.NativePointer;")
		.CloseBrace()
		.CloseBrace()
		.CloseBrace();

	FString CPPFilePath = FPaths::Combine(GeneratedCodePath, Class->GetName() + "_export.h");
	FString CSFilePath = FPaths::Combine(GeneratedCodePath, TEXT("..\\..\\..\\..\\..\\..\\"), CS_Project_Path, Class->GetName() + ".cs");

	AllScriptHeaders.Add(CPPFilePath);

	SaveHeaderIfChanged(CPPFilePath, CodeCPP.ToString());
	SaveHeaderIfChanged(CSFilePath, CodeCS.ToString());
}

bool FGenericScriptCodeGenerator::CanExportFunction(UFunction* Function)
{
	if (!FScriptCodeGeneratorBase::CanExportFunction(Function))
		return false;

	if (Function->GetFName() == "ReceivePointDamage")
		return false;

	if (Function->GetFName() == "GetInstigator")
		return false;

	for (TFieldIterator<UProperty> It(Function); It; ++It)
	{
		auto typeName = GetPropertyTypeCPP(*It, CPPF_ArgumentOrReturnValue);

		if (typeName != "UObject" && (
			typeName.StartsWith("U", ESearchCase::CaseSensitive) ||
			typeName.StartsWith("A", ESearchCase::CaseSensitive)))
		{
			if (!AllExportClass.ContainsByPredicate([typeName](ClassExportInfo& info) { return GetClassNameCPP(info.Class) == typeName; }))
			{
				return false;
			}
		}
		
		if (typeName.StartsWith("F", ESearchCase::CaseSensitive))
		{
			// Struct dont support
			return false;
		}
		else if (typeName.StartsWith("T", ESearchCase::CaseSensitive))
		{
			// Template contaner dont support
			return false;
		}
		else if (typeName.StartsWith("E", ESearchCase::CaseSensitive))
		{
			// Enumerate dont support
			return false;
		}
	}

	return true;
}

void FGenericScriptCodeGenerator::ExportFunctionCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function, FString& DeclareExternFragment)
{
	FCodeBuilder CallFragment;
	FCodeBuilder DeclareFragment;
	FString returnType = TEXT("void");

	bool returnVoid = true;
	bool returnNameOrText = false;
	bool returnPointer = false;

	for (TFieldIterator<UProperty> It(Function); It; ++It)
	{
		auto typeName_orig = GetPropertyTypeCPP(*It, CPPF_ArgumentOrReturnValue);
		auto typeName = typeName_orig;

		if (typeName.EndsWith("*"))
		{
			typeName = "INT_PTR";
		}
		else if (typeName == "FName" || typeName == "FString")
		{
			typeName = "char*";
		}

		if (It->GetPropertyFlags() & CPF_ReturnParm)
		{
			returnNameOrText = typeName == "char*";
			returnPointer = typeName == "INT_PTR";
			returnType = typeName;
			returnVoid = false;
		}
		else
		{
			CallFragment.AppendIF(!CallFragment.IsEmpty(), ", ");
			
			if (typeName == "INT_PTR")
			{
				CallFragment.Append("(class %s)", *typeName_orig);
			}

			CallFragment.Append(It->GetName());
			DeclareFragment.Append(", %s %s", *typeName, *It->GetName());
		}
	}

	DeclareExternFragment =
		FString::Printf(TEXT("%s %s%s(INT_PTR Self%s)"), *returnType, *CPP_Function_Prefix, *Function->GetFName().ToString(), *DeclareFragment.ToString());
	
	code.AppendLine("%s_API %s", *CPP_API_NAME, *DeclareExternFragment);
	code.OpenBrace();

	code.AppendIF(!returnVoid, "return ");
	code.AppendIF(returnPointer, "(INT_PTR)");
	code.AppendIF(returnNameOrText, "TCHAR_TO_ANSI(*");

	code.Append(TEXT("((%s*)Self)->%s(%s)"), *ClassNameCPP, *Function->GetFName().ToString(), *CallFragment);

	code.AppendIF(returnNameOrText, ".ToString())");

	code.Append(";");

	code.CloseBrace();
	code.AppendLine();
	code.AppendLine();
}

void FGenericScriptCodeGenerator::ExportPropertyCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UProperty* Property, int32 PropertyIndex)
{
}

void FGenericScriptCodeGenerator::ExportFunctionCS(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function, const FString& DeclareExternFragment)
{
	FCodeBuilder DeclareFragment;
	FCodeBuilder CallFragment;

	FString returnCSType = TEXT("void");

	bool returnVoid = true;
	bool returnPointer = false;

	for (TFieldIterator<UProperty> It(Function); It; ++It)
	{
		auto typeName_orig = GetPropertyTypeCPP(*It, CPPF_ArgumentOrReturnValue);
		auto typeName = typeName_orig;
		bool isPointer = false;

		if (typeName.EndsWith("*"))
		{
			typeName.RemoveFromEnd("*");
			isPointer = true;
		}
		else if (typeName == "FName" || typeName == "FString")
		{
			typeName = "string";
		}

		if (It->GetPropertyFlags() & CPF_ReturnParm)
		{
			returnCSType = typeName;
			returnPointer = isPointer;
			returnVoid = false;
		}
		else
		{
			CallFragment
				.Append(", ")
				.AppendIF(isPointer, "(IntPtr)")
				.Append(It->GetName());

			DeclareFragment
				.AppendIF(!DeclareFragment.IsEmpty(), ", ")
				.Append("%s %s", *typeName, *It->GetName());
		}
	}

	code.AppendLine("[DllImport(\"%s\")]", *CS_NativeDLL_Name);
	code.AppendLine("private static extern %s;", *DeclareExternFragment.Replace(TEXT("INT_PTR"), TEXT("IntPtr")));
	code.AppendLine();

	ExportSummaryCS(code, Function->GetToolTipText());

	code.AppendLine("public %s %s(%s)", *returnCSType, *Function->GetFName().ToString(), *DeclareFragment);
	code.OpenBrace();

	code.AppendIF(!returnVoid, "return ");
	code.AppendIF(returnPointer, "new %s(", *returnCSType);

	code.Append(TEXT("%s%s((IntPtr)this%s)"), *CPP_Function_Prefix, *Function->GetFName().ToString(), *CallFragment);

	code.AppendIF(returnPointer, ")");

	code.Append(";");

	code.CloseBrace();
	code.AppendLine();
	code.AppendLine();
}

void FGenericScriptCodeGenerator::ExportSummaryCS(FCodeBuilder& code, const FText& ToolTipText)
{
	if (ToolTipText.IsEmpty())
		return;

	TArray<FString> Rows;

	FString ToolTipTextString = ToolTipText.ToString().Replace(TEXT("\r"), TEXT(""));
	ToolTipTextString.ParseIntoArray(Rows, TEXT("\n"), true);

	code.AppendLine("/// <summary>");

	for (auto& row : Rows)
	{
		const std::regex ParamPattern("\\@param\\s+(\\w+)\\s+(.*)");	// \@param\s+(\w+)\s+(.*)
		const std::regex ReturnPattern("\\@return\\s+(.*)");			// \@return\s+(.*)
		std::cmatch math;

		UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("%s"), *row);

		if (std::regex_match(TCHAR_TO_UTF8(*row), math, ParamPattern))
		{
			code.AppendLine("/// <param name=\"%s\">%s</param>", 
				UTF8_TO_TCHAR(std::string(math[1].first, math[1].second).c_str()),
				UTF8_TO_TCHAR(std::string(math[2].first, math[2].second).c_str()));
		}
		else if (std::regex_match(TCHAR_TO_UTF8(*row), math, ReturnPattern))
		{
			code.AppendLine("/// <returns>%s</returns>", 
				UTF8_TO_TCHAR(std::string(math[1].first, math[1].second).c_str()));
		}
		else
			code.AppendLine("/// %s", *row);
	}

	code.AppendLine("/// </summary>");
}

void FGenericScriptCodeGenerator::ExportPropertyCS(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UProperty* Property, int32 PropertyIndex)
{

}

bool FGenericScriptCodeGenerator::CanExportClass(UClass* Class)
{
	bool bCanExport = FScriptCodeGeneratorBase::CanExportClass(Class);
	if (bCanExport)
	{
		const FString ClassNameCPP = GetClassNameCPP(Class);

		if (ClassNameCPP != TEXT("AActor"))
			return false;

	}
	return bCanExport;
}

void FGenericScriptCodeGenerator::FinishExport()
{
	for (auto& info : AllExportClass)
	{
		ExportClass_Real(info.Class, info.SourceHeaderFilename, info.GeneratedHeaderFilename);
	}

	GenerateMainCpp();
	RenameTempFiles();
}

void FGenericScriptCodeGenerator::GenerateMainCpp()
{
	FCodeBuilder code;

	for (auto& HeaderFilename : AllScriptHeaders)
	{
		FString NewFilename(FPaths::GetCleanFilename(HeaderFilename));
		code.AppendLine(TEXT("#include \"%s\""), *NewFilename);
	}

	FString Filename = GeneratedCodePath / TEXT("ExportForDotnetLib.inl");
	SaveHeaderIfChanged(Filename, code.ToString());
}

FString FGenericScriptCodeGenerator::GenerateWrapperFunctionDeclaration(const FString& ClassNameCPP, UClass* Class, UFunction* Function)
{
	return GenerateWrapperFunctionDeclaration(ClassNameCPP, Class, Function->GetName());
}

FString FGenericScriptCodeGenerator::GenerateWrapperFunctionDeclaration(const FString& ClassNameCPP, UClass* Class, const FString& FunctionName)
{
	return FString::Printf(TEXT("int32 %s_%s(void* InScriptContext)"), *Class->GetName(), *FunctionName);
}

FString FGenericScriptCodeGenerator::GenerateFunctionParamDeclaration(const FString& ClassNameCPP, UClass* Class, UFunction* Function, UProperty* Param)
{
	FString ParamDecl;
	if (Param->IsA(UObjectPropertyBase::StaticClass()) || Param->IsA(UClassProperty::StaticClass()))
	{
		ParamDecl = FString::Printf(TEXT("UObject* %s = nullptr;"), *Param->GetName());
	}
	else
	{
		ParamDecl = FString::Printf(TEXT("%s %s = %s();"), *GetPropertyTypeCPP(Param, CPPF_ArgumentOrReturnValue), *Param->GetName(), *GetPropertyTypeCPP(Param, CPPF_ArgumentOrReturnValue));
	}
	return ParamDecl;
}

FString FGenericScriptCodeGenerator::GenerateObjectDeclarationFromContext(const FString& ClassNameCPP, UClass* Class)
{
	return FString::Printf(TEXT("UObject* Obj = (UObject*)InScriptContext;"));
}

FString FGenericScriptCodeGenerator::GenerateReturnValueHandler(const FString& ClassNameCPP, UClass* Class, UFunction* Function, UProperty* ReturnValue)
{
	return TEXT("return 0;");
}