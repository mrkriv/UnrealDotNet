#include "GenericScriptCodeGenerator.h"
#include "UObject/UnrealType.h"
#include "ScriptGeneratorLog.h"
#include "Misc/Paths.h"
#include <regex>	//#include "Regex.h" wtf?

#pragma optimize("", off)

static const FString CPP_API_NAME = TEXT("UNREALDOTNETRUNTIME");
static const FString CPP_Function_Prefix = TEXT("Call_");
static const FString CPP_Structure_Postfix = TEXT("_ExternC");
static const FString CPP_OutReturn_Name = TEXT("OutResultValue");
static const FString CPP_TranferBuff = TEXT("StuructTranferBuffer");
static const FString CPP_TranferOffest = TEXT("StuructTranferOffest");
static const FString CS_Namespace_Name = TEXT("UnrealEngine");
static const FString CS_NativeDLL_Name = TEXT("UE4Editor-UnrealDotNetRuntime");
static const FString CS_Project_Path = TEXT("..\\..\\..\\..\\..\\..\\Source\\NetCoreProject\\UnrealEngine\\Generate");
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
		//.AppendLine("#include \"Structs%s\"", *GenerateCppPostfix)
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
	FCodeBuilder CodeCPP;

	CodeCPP
		.AppendLine("#pragma once")
		.AppendLine("#pragma pack(push, 1)")
		.AppendLine()
		.AppendLine("#include \"Engine.h\"")
		.AppendLine("#include \"CoreMinimal.h\"")
		.AppendLine()
		.AppendLine("extern \"C\"")
		.OpenBrace();

	CodeCS
		.AppendLine("using System;")
		.AppendLine("using System.Runtime.CompilerServices;")
		.AppendLine("using System.Runtime.InteropServices;")
		.AppendLine()
		.AppendLine("namespace %s", *CS_Namespace_Name)
		.OpenBrace();

	for (auto& Struct : AllExportStructs)
	{
		//ExportStructCPP(CodeCPP, Struct);
		ExportStructCS(CodeCS, Struct);
	}

	CodeCS.CloseBrace();

	CodeCPP
		.CloseBrace()
		.AppendLine("#pragma pack(pop)");

	SaveCS(CodeCS, "Structs");
	//SaveCPP(CodeCPP, "Structs");
}

void FGenericScriptCodeGenerator::ExportStructCS(FCodeBuilder& code, UScriptStruct* Struct)
{
	ExportSummaryCS(code, Struct->GetToolTipText());

	code
		.AppendLine("[StructLayout(LayoutKind.Explicit, Size = %d, Pack = %d)]", Struct->GetStructureSize(), Struct->MinAlignment)
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

void FGenericScriptCodeGenerator::ExportStructCPP(FCodeBuilder& code, UScriptStruct* Struct)
{
	auto name = Struct->GetStructCPPName() + CPP_Structure_Postfix;

	code
		.AppendLine("struct %s", *name)
		.OpenBrace();

	FCodeBuilder constr(code);

	constr
		.AppendLine("%s(const %s&& _copy_val)", *name, *Struct->GetStructCPPName())
		.OpenBrace();

	auto it = Struct->Children;
	while (it != NULL)
	{
		auto prop = (UProperty*)it;
		if (prop)
		{
			code.AppendLine("%s %s;", *prop->GetCPPType(), *prop->GetNameCPP());
			constr.AppendLine("%s = _copy_val.%s", *prop->GetNameCPP(), *prop->GetNameCPP());
		}
		it = it->Next;
	}

	constr
		.CloseBrace()
		.AppendLine();

	code 
		.Append(constr.ToString())
		.CloseBrace()
		.AppendLine(";")
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
	bool returnStruct = false;
	size_t offest = 0;

	for (TFieldIterator<UProperty> It(Function); It; ++It)
	{
		auto typeName_orig = GetPropertyTypeCPP(*It, CPPF_ArgumentOrReturnValue);
		auto typeName = typeName_orig;
		bool isNameOrText = false;
		bool isStruct = false;
		bool isPointer = false;

		if (typeName.EndsWith("*"))
		{
			typeName = "INT_PTR";
			isPointer = true;
		}
		else if (typeName == "FName" || typeName == "FString")
		{
			typeName = "char*";
			isNameOrText = true;
		}
		else if (typeName.StartsWith(TEXT("F"), ESearchCase::CaseSensitive))
		{
			isStruct = true;
		}

		if (It->GetPropertyFlags() & CPF_ReturnParm)
		{
			returnNameOrText = isNameOrText;
			returnPointer = isPointer;
			returnStruct = isStruct;
			returnType = typeName;
			returnVoid = false;
		}
		else
		{
			CallFragment.AppendIF(!CallFragment.IsEmpty(), ", ");

			if (isStruct)
			{
				CallFragment.AppendIF(isStruct, "*(%s*)(void*)(&%s[%s+%d])", *typeName_orig, *CPP_TranferBuff, *CPP_TranferOffest, offest);
				offest += Cast<UStructProperty>(*It)->Struct->GetStructureSize();
			}
			else
			{
				CallFragment.AppendIF(isPointer, "(class %s)", *typeName_orig);
				CallFragment.Append(It->GetName());

				DeclareFragment.Append(", %s %s", *typeName, *It->GetName());
			}
		}
	}

	auto returnRype_Real = returnStruct ? TEXT("INT_PTR") : returnType;

	code.AppendLine("%s_API %s %s%s(INT_PTR Self%s)", *CPP_API_NAME, *returnRype_Real, *CPP_Function_Prefix, *Function->GetFName().ToString(), *DeclareFragment.ToString());
	code.OpenBrace();

	if (returnStruct)
	{
		code.AppendLine("auto _result_ptr = (%s*)(void*)(&%s[%s+%d]);", *returnType, *CPP_TranferBuff, *CPP_TranferOffest, offest);
		code.Append("*_result_ptr = ");
	}
	else
	{
		code.AppendIF(!returnVoid, "return ");
		code.AppendIF(returnPointer, "(INT_PTR)");
		code.AppendIF(returnNameOrText, "TCHAR_TO_ANSI(*");
	}

	code.Append(TEXT("((%s*)Self)->%s(%s)"), *ClassNameCPP, *Function->GetFName().ToString(), *CallFragment);

	if (returnStruct)
	{
		code.AppendLine(";");
		code.Append("return (INT_PTR)_result_ptr;");
	}
	else
	{
		code.AppendIF(returnNameOrText, ".ToString())");
		code.Append(";");
	}

	code.CloseBrace();
	code.AppendLine();
	code.AppendLine();
}

void FGenericScriptCodeGenerator::ExportFunctionCS(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function)
{
	FCodeBuilder DeclareExternFragment(code);
	FCodeBuilder DeclareCSFragment(code);
	FCodeBuilder CallFragment(code);
	FCodeBuilder MethodFragment(code);

	FString returnType = TEXT("void");
	MethodFragment.Tab();

	bool returnVoid = true;
	bool returnPointer = false;
	bool returnStruct = false;
	size_t offest = 0;

	for (TFieldIterator<UProperty> It(Function); It; ++It)
	{
		auto typeName_orig = GetPropertyTypeCPP(*It, CPPF_ArgumentOrReturnValue);
		auto typeName = typeName_orig;
		bool isPointer = false;
		bool isStruct = false;
		
		if (typeName.EndsWith("*"))
		{
			typeName.RemoveFromEnd("*");
			isPointer = true;
		}
		else
			typeName = ReplaceCppTypeToCS(typeName);

		if (typeName.StartsWith(TEXT("F"), ESearchCase::CaseSensitive))
		{
			isStruct = true;
		}

		if (It->GetPropertyFlags() & CPF_ReturnParm)
		{
			returnType = typeName;
			returnPointer = isPointer;
			returnStruct = isStruct;
			returnVoid = false;
		}
		else
		{
			if (isStruct)
			{
				MethodFragment.AppendLine("Marshal.StructureToPtr(%s, GetTranferBufferPtr()+%d, false);", *It->GetName(), offest);
				offest += Cast<UStructProperty>(*It)->Struct->GetStructureSize();
			}
			else
			{
				CallFragment
					.Append(", ")
					.AppendIF(isPointer, "(IntPtr)")
					.Append(It->GetName());

				DeclareExternFragment
					.AppendIF(!DeclareExternFragment.IsEmpty(), ", ")
					.Append("%s %s", *typeName, *It->GetName());
			}

			DeclareCSFragment
				.AppendIF(!DeclareCSFragment.IsEmpty(), ", ")
				.Append("%s %s", *typeName, *It->GetName());
		}
	}
	
	auto cpp_name = Function->GetFName().ToString();
	auto returnRype_Real = returnStruct ? TEXT("IntPtr") : returnType;

	code.AppendLine("[DllImport(\"%s\")]", *CS_NativeDLL_Name);
	code.Append("private static extern %s %s%s(IntPtr Self", *returnRype_Real, *CPP_Function_Prefix, *cpp_name);
	code.AppendIF(!DeclareExternFragment.IsEmpty(), ", %s", *DeclareExternFragment.ToString());
	code.AppendLine(");");
	code.AppendLine();

	ExportSummaryCS(code, Function->GetToolTipText());

	code.AppendLine("public %s %s(%s)", *returnType, *GetFieldName(Function), *DeclareCSFragment);
	code.OpenBrace();

	code.AppendLineIF(!MethodFragment.IsEmpty(), MethodFragment.ToString());

	code.AppendIF(!returnVoid, "return ");
	code.AppendIF(returnPointer, "new %s(", *returnType);
	code.AppendIF(returnStruct, "Marshal.PtrToStructure<%s>(", *returnType);

	code.Append(TEXT("%s%s((IntPtr)this%s)"), *CPP_Function_Prefix, *cpp_name, *CallFragment);

	code.AppendIF(returnPointer, ")");
	code.AppendIF(returnStruct, ")");

	code.Append(";");

	code.CloseBrace();
	code.AppendLine();
	code.AppendLine();
}

void FGenericScriptCodeGenerator::ExportPropertyCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UProperty* Property, int32 PropertyIndex)
{
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