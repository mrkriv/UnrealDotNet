#include "GenericScriptCodeGenerator.h"
#include "UObject/UnrealType.h"
#include "ScriptGeneratorLog.h"
#include "Misc/Paths.h"
#include <regex>	//#include "Regex.h" wtf?

#pragma optimize("", off)

static const FString CPP_API_NAME = TEXT("UNREALDOTNETRUNTIME");
static const FString CPP_Function_Prefix = TEXT("Call_");
static const FString CPP_OtrReturn_Name = TEXT("OutResultValue");
static const FString CS_Namespace_Name = TEXT("UnrealEngine");
static const FString CS_NativeDLL_Name = TEXT("UE4Editor-UnrealDotNetRuntime");
static const FString CS_Project_Path = TEXT("..\\..\\..\\..\\..\\..\\Source\\UnrealDotNetWrapper\\Generate");
static const FString GenerateCppPostfix = TEXT("_export.h");
static const FString GenerateCSPostfix = TEXT(".cs");
static const FString GenerateMainCppName = TEXT("ExportForDotnetGenerated.inl");

FGenericScriptCodeGenerator::FGenericScriptCodeGenerator(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& InIncludeBase)
	: FScriptCodeGeneratorBase(RootLocalPath, RootBuildPath, OutputDirectory, InIncludeBase)
{
}

bool FGenericScriptCodeGenerator::CanExportClass(UClass* Class)
{
	if (!FScriptCodeGeneratorBase::CanExportClass(Class))
		return false;

	const FString ClassNameCPP = GetClassNameCPP(Class);

	if (ClassNameCPP != TEXT("AActor"))
		return false;

	bool found = false;
	for (TFieldIterator<UFunction> FuncIt(Class, EFieldIteratorFlags::ExcludeSuper); FuncIt; ++FuncIt)
	{
		if (CanExportFunction(*FuncIt))
			found = true;
	}

	return found;
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
		if (!CanExportProperty(*It))
			return false;
	}

	return true;
}

bool FGenericScriptCodeGenerator::CanExportProperty(UProperty* Property)
{
	auto typeName = GetPropertyTypeCPP(Property, CPPF_ArgumentOrReturnValue);

	if (typeName != "UObject" && (
		typeName.StartsWith("U", ESearchCase::CaseSensitive) ||
		typeName.StartsWith("A", ESearchCase::CaseSensitive)))
	{
		if (!AllExportClass.ContainsByPredicate([typeName](ClassExportInfo& info) { return GetClassNameCPP(info.Class) == typeName; }))
		{
			return false;
		}
	}

	if (typeName.Contains("<", ESearchCase::CaseSensitive))
	{
		// Template contaner dont support
		return false;
	}
	if (typeName.StartsWith("T", ESearchCase::CaseSensitive))
	{
		// Template contaner dont support
		return false;
	}
	else if (typeName.StartsWith("E", ESearchCase::CaseSensitive))
	{
		// Enumerate dont support
		return false;
	}

	auto StructProp = Cast<UStructProperty>(Property);

	if (StructProp != NULL && StructProp->Struct != NULL)
	{
		auto it = StructProp->Struct->Children;
		while (it != NULL)
		{
			auto p = Cast<UProperty>(it);
			if (p != NULL && !CanExportProperty(p))
				return false;

			it = it->Next;
		}
	}

	return true;
}

void FGenericScriptCodeGenerator::CollectExportInfo(UClass* Class)
{
	for (TFieldIterator<UFunction> FuncIt(Class, EFieldIteratorFlags::ExcludeSuper); FuncIt; ++FuncIt)
	{
		if (CanExportFunction(*FuncIt))
			CollectExportInfo(*FuncIt);
	}
}

void FGenericScriptCodeGenerator::CollectExportInfo(UFunction* Function)
{
	for (TFieldIterator<UProperty> It(Function); It; ++It)
	{
		if (CanExportProperty(*It))
			CollectExportInfo(*It);
	}
}

void FGenericScriptCodeGenerator::CollectExportInfo(UField* Property)
{
	auto StructProp = Cast<UStructProperty>(Property);

	if (StructProp != NULL && StructProp->Struct != NULL)
	{
		auto it = StructProp->Struct->Children;
		while (it != NULL)
		{
			auto p = Cast<UProperty>(it);
			if (p != NULL)
			{
				if (!CanExportProperty(p))
					return;

				CollectExportInfo(it);
			}
			it = it->Next;
		}

		AllExportStructs.AddUnique(StructProp->Struct);
	}
}

void FGenericScriptCodeGenerator::ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged)
{
	if (CanExportClass(Class))
	{
		AllExportClass.Add({ Class, SourceHeaderFilename, GeneratedHeaderFilename });
		CollectExportInfo(Class);
	}
}

void FGenericScriptCodeGenerator::ExportClass_Real(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename)
{
	UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("Exporting class %s"), *Class->GetName());

	const FString ClassNameCPP = GetClassNameCPP(Class);
	FCodeBuilder CodeCPP;
	FCodeBuilder CodeCS;

	CodeCPP
		.AppendLine("#pragma once")
		.AppendLine("#include \"%s\"", *RebaseToBuildPath(SourceHeaderFilename))
		.AppendLine()
		.AppendLine("#pragma warning(push)")
		.AppendLine("#pragma warning(disable:4996)")
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
		.AppendLine("public partial class %s : %s", *ClassNameCPP, TEXT("UObject"))	// *GetClassNameCPP(Class->GetOwnerClass())
		.OpenBrace()
		.AppendLine("private readonly IntPtr NativePointer;")
		.AppendLine()
		.AppendLine("public %s(IntPtr Adress)", *ClassNameCPP)
		.OpenBrace()
		.Append("NativePointer = Adress;")
		.CloseBrace()
		.AppendLine()
		.AppendLine();

	for (TFieldIterator<UFunction> FuncIt(Class, EFieldIteratorFlags::ExcludeSuper); FuncIt; ++FuncIt)
	{
		UFunction* Function = *FuncIt;

		if (CanExportFunction(Function))
		{
			UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("Export for dotnet %s.%s"), *ClassNameCPP, *Function->GetName());

			ExportFunctionCPP(CodeCPP, ClassNameCPP, Class, Function);
			ExportFunctionCS(CodeCS, ClassNameCPP, Class, Function);
		}
	}

	CodeCPP
		.CloseBrace()
		.AppendLine()
		.AppendLine("#pragma warning(pop)");

	CodeCS
		.AppendLine("public static explicit operator IntPtr(%s Self)", *ClassNameCPP)
		.OpenBrace()
		.Append("return Self.NativePointer;")
		.CloseBrace()
		.AppendLine()
		.AppendLine("public static implicit operator %s(IntPtr Adress)", *ClassNameCPP)
		.OpenBrace()
		.Append("return Adress == IntPtr.Zero ? null : new %s(Adress);", *ClassNameCPP)
		.CloseBrace()
		.CloseBrace()
		.CloseBrace();

	SaveCPP(CodeCPP, Class->GetName());
	SaveCS(CodeCS, Class->GetName());
}

void FGenericScriptCodeGenerator::ExportStruct()
{
	FCodeBuilder CodeCS;

	CodeCS
		.AppendLine("using System;")
		.AppendLine("using System.Runtime.CompilerServices;")
		.AppendLine("using System.Runtime.InteropServices;")
		.AppendLine()
		.AppendLine("namespace %s", *CS_Namespace_Name)
		.OpenBrace();

	for (auto& Struct : AllExportStructs)
	{
		ExportStructCS(CodeCS, Struct);
	}

	CodeCS.CloseBrace();

	SaveCS(CodeCS, "Structs");
}

void FGenericScriptCodeGenerator::ExportStructCS(FCodeBuilder& code, UScriptStruct* Struct)
{
	ExportSummaryCS(code, Struct->GetToolTipText());

	code
		.AppendLine("[StructLayout(LayoutKind.Explicit, Size = %d)]", Struct->GetStructureSize())
		.AppendLine("public struct %s", *Struct->GetStructCPPName())
		.OpenBrace();

	auto it = Struct->Children;
	while (it != NULL)
	{
		auto prop = (UProperty*)it;
		if (prop)
		{
			ExportSummaryCS(code, prop->GetToolTipText());

			code.AppendLine("[FieldOffset(%d)]", prop->GetSize());
			code.AppendLine("public %s %s;", *ReplaceCppTypeToCS(prop->GetCPPType()), *prop->GetNameCPP());
			code.AppendLine();
		}
		it = it->Next;
	}

	code
		.CloseBrace()
		.AppendLine();
}

void FGenericScriptCodeGenerator::ExportFunctionCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function)
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

	code.AppendLine("%s_API %s %s%s(INT_PTR Self%s)", *CPP_API_NAME, *returnType, *CPP_Function_Prefix, *Function->GetFName().ToString(), *DeclareFragment.ToString());
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

void FGenericScriptCodeGenerator::ExportFunctionCS(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function)
{
	FCodeBuilder DeclareFragment;
	FCodeBuilder CallFragment;

	FString returnType = TEXT("void");

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
		else
			typeName = ReplaceCppTypeToCS(typeName);

		if (It->GetPropertyFlags() & CPF_ReturnParm)
		{
			returnType = typeName;
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
	
	auto cpp_name = Function->GetFName().ToString();

	code.AppendLine("[DllImport(\"%s\")]", *CS_NativeDLL_Name);
	code.Append("private static extern %s %s%s(IntPtr Self", *returnType, *CPP_Function_Prefix, *cpp_name);
	code.AppendIF(!DeclareFragment.IsEmpty(), ", %s", *DeclareFragment.ToString());
	code.AppendLine(");");
	code.AppendLine();

	ExportSummaryCS(code, Function->GetToolTipText());

	code.AppendLine("public %s %s(%s)", *returnType, *GetFieldName(Function), *DeclareFragment);
	code.OpenBrace();

	code.AppendIF(!returnVoid, "return ");
	code.AppendIF(returnPointer, "new %s(", *returnType);

	code.Append(TEXT("%s%s((IntPtr)this%s)"), *CPP_Function_Prefix, *cpp_name, *CallFragment);

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

void FGenericScriptCodeGenerator::FinishExport()
{
	ExportStruct();

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

	for (auto& HeaderFilename : AllCppHeaders)
	{
		FString NewFilename(FPaths::GetCleanFilename(HeaderFilename));
		code.AppendLine(TEXT("#include \"%s\""), *NewFilename);
	}

	FString Filename = GeneratedCodePath / GenerateMainCppName;
	SaveHeaderIfChanged(Filename, code.ToString());
}

void FGenericScriptCodeGenerator::SaveCPP(FCodeBuilder& code, const FString Name)
{
	auto Path = FPaths::Combine(GeneratedCodePath, Name + GenerateCppPostfix);
	AllCppHeaders.Add(FPaths::GetCleanFilename(Path));

	SaveHeaderIfChanged(Path, code.ToString());
}

void FGenericScriptCodeGenerator::SaveCS(FCodeBuilder& code, const FString Name)
{
	auto Path = FPaths::Combine(GeneratedCodePath, CS_Project_Path, Name + GenerateCSPostfix);;
	SaveHeaderIfChanged(Path, code.ToString());
}

FString FGenericScriptCodeGenerator::ReplaceCppTypeToCS(const FString& CPPType)
{
	if (CPPType == "FString") return "string";
	if (CPPType == "FName") return "string";
	if (CPPType == "uint8") return "byte";
	if (CPPType == "uint16") return "UInt16";
	if (CPPType == "uint32") return "UInt32";
	if (CPPType == "uint64") return "UInt64";
	if (CPPType == "int16") return "Int16";
	if (CPPType == "int32") return "Int32";
	if (CPPType == "int64") return "Int64";

	return CPPType;
}

FString FGenericScriptCodeGenerator::GetFieldName(UField* Field)
{
	if (Field->HasMetaData("DisplayName"))
	{
		auto name = Field->GetMetaData("DisplayName");
		return name.Replace(TEXT(" "), TEXT("")).Replace(TEXT("("), TEXT("")).Replace(TEXT(")"), TEXT(""));
	}
	else
	{
		return Field->GetFName().ToString();
	}
}

#pragma optimize("", on)