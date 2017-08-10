#include "GenericScriptCodeGenerator.h"
#include "UObject/UnrealType.h"
#include "ScriptGeneratorLog.h"

FGenericScriptCodeGenerator::FGenericScriptCodeGenerator(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& InIncludeBase)
	: FScriptCodeGeneratorBase(RootLocalPath, RootBuildPath, OutputDirectory, InIncludeBase)
{
}

void FGenericScriptCodeGenerator::ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged)
{
	if (!CanExportClass(Class))
	{
		return;
	}
	
	UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("Exporting class %s"), *Class->GetName());

	const FString ClassNameCPP = GetClassNameCPP(Class);
	AllSourceClassHeaders.Add(SourceHeaderFilename);

	FCodeBuilder CodeCPP;
	FString CodeCSClass(TEXT(""));
	FString CodeCSConstructor(TEXT(""));

	CodeCPP
		.AppendLine("#pragma once")
		.AppendLine("#include \"%s\"", *RebaseToBuildPath(SourceHeaderFilename))
		.AppendLine()
		.AppendLine("extern \"C\"")
		.OpenBrace();

	int32 FunctionIndex = 0;
	for (TFieldIterator<UFunction> FuncIt(Class, EFieldIteratorFlags::ExcludeSuper); FuncIt; ++FuncIt, ++FunctionIndex)
	{
		UFunction* Function = *FuncIt;

		if (Function->GetFName() == "ReceivePointDamage")
			continue;

		if (Function->GetFName() == "GetInstigator")
			continue;
		
		if (CanExportFunction(ClassNameCPP, Class, Function))
		{
			UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("  %s %s"), *Function->GetClass()->GetName(), *Function->GetName());

			ExportFunctionCPP(CodeCPP, ClassNameCPP, Class, Function);

			FunctionMapCode.Add(FString::Printf(TEXT("%s::%s"), *ClassNameCPP, *Function->GetName()));
			
			CodeCSConstructor += ExportFunctionCSConstructor(ClassNameCPP, Class, Function);
			CodeCSClass += ExportFunctionCS(ClassNameCPP, Class, Function);
		}
	}

	int32 PropertyIndex = 0;
	for (TFieldIterator<UProperty> PropertyIt(Class, EFieldIteratorFlags::ExcludeSuper); PropertyIt; ++PropertyIt, ++PropertyIndex)
	{
		UProperty* Property = *PropertyIt;
		if (CanExportProperty(ClassNameCPP, Class, Property))
		{
			UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("  %s %s"), *Property->GetClass()->GetName(), *Property->GetName());

			CodeCSClass += ExportPropertyCS(ClassNameCPP, Class, Property, PropertyIndex);
		}
	}

	CodeCPP.CloseBrace();

	FString CodeCS;
	CodeCS += TEXT("using System;\r\n");
	CodeCS += TEXT("using System.Runtime.InteropServices;\r\n");
	CodeCS += TEXT("\r\n");
	CodeCS += TEXT("namespace UnrealEngine\r\n");
	CodeCS += TEXT("{\r\n");
	CodeCS += FString::Printf(TEXT("\tpublic class %s\r\n"), *ClassNameCPP);
	CodeCS += TEXT("\t{\r\n");

	if (!CodeCSConstructor.IsEmpty())
	{
		CodeCS += FString::Printf(TEXT("\t\tstatic %s()\r\n"), *ClassNameCPP);
		CodeCS += TEXT("\t\t{\r\n");
		CodeCS += CodeCSConstructor;
		CodeCS += TEXT("\t\t}\r\n\r\n");
	}

	CodeCS += CodeCSClass;

	CodeCS += TEXT("\t}\r\n");
	CodeCS += TEXT("}\r\n");

	FString CSFilePath = GeneratedCodePath / Class->GetName() + ".cs";
	FString CPPFilePath = GeneratedCodePath / Class->GetName() + "_export.h";

	AllScriptHeaders.Add(CPPFilePath);

	SaveHeaderIfChanged(CPPFilePath, CodeCPP.ToString());
	//SaveHeaderIfChanged(CSFilePath, CodeCS);
}

void FGenericScriptCodeGenerator::ExportFunctionCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function)
{
	FString returnType = TEXT("void");

	bool returnVoid = true;
	bool returnNameOrText = false;
	bool returnStruct = false;

	for (TFieldIterator<UProperty> It(Function); It; ++It)
	{
		if (It->GetPropertyFlags() & CPF_ReturnParm)
		{
			auto typeName = GetPropertyTypeCPP(*It, CPPF_ArgumentOrReturnValue);
			returnVoid = false;

			if (typeName == "FName" || typeName == "FString")
			{
				returnNameOrText = true;
				typeName = "char*";
			}
			else if (typeName == "FVector" || typeName == "FTransform" || typeName == "FRotator")
			{
				returnStruct = true;
				return;
			}

			returnType = typeName;
			break;
		}
	}

	code.Append("UNREALDOTNETRUNTIME_API ");
	code.Append(TEXT("%s Call_%s(%s* Self"), *returnType, *Function->GetFName().ToString(), *ClassNameCPP);

	bool first = true;
	FString CallFragment;

	for (TFieldIterator<UProperty> It(Function); It; ++It)
	{
		if ((It->GetPropertyFlags() & CPF_ReturnParm) == 0)
		{
			if (first)
			{
				first = false;
			}
			else
			{
				CallFragment += TEXT(", ");
			}

			CallFragment += It->GetName();
			code.Append(TEXT(", %s %s"), *GetPropertyTypeCPP(*It, CPPF_ArgumentOrReturnValue), *It->GetName());
		}
	}

	if (returnStruct)
	{
		if (!CallFragment.IsEmpty())
			CallFragment += ", ";

		code.Append(", %s& _OutResultValue", *returnType);
		CallFragment += "_OutResultValue";
	}

	code.AppendLine(")");
	code.OpenBrace();

	if (!returnVoid)
		code.Append("return ");

	if (returnNameOrText)
		code.Append("TCHAR_TO_ANSI(*");

	code.Append(TEXT("Self->%s(%s)"), *Function->GetFName().ToString(), *CallFragment);

	if (returnNameOrText)
		code.Append(".ToString())");

	code.Append(";");

	code.CloseBrace();
	code.AppendLine();
}

void FGenericScriptCodeGenerator::ExportPropertyCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UProperty* Property, int32 PropertyIndex)
{
}

void FGenericScriptCodeGenerator::ExportFunctionCS(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function)
{

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

		bool bHasMembersToExport = false;
		for (TFieldIterator<UFunction> FuncIt(Class, EFieldIteratorFlags::ExcludeSuper); !bHasMembersToExport && FuncIt; ++FuncIt)
		{
			UFunction* Function = *FuncIt;
			if (CanExportFunction(ClassNameCPP, Class, Function))
			{
				bHasMembersToExport = true;
				break;
			}
		}

		if (!bHasMembersToExport)
		{
			for (TFieldIterator<UProperty> PropertyIt(Class, EFieldIteratorFlags::ExcludeSuper); !bHasMembersToExport && PropertyIt; ++PropertyIt)
			{
				UProperty* Property = *PropertyIt;
				if (CanExportProperty(ClassNameCPP, Class, Property))
				{
					bHasMembersToExport = true;
					break;
				}
			}
		}

		bCanExport = bHasMembersToExport;
	}
	return bCanExport;
}

void FGenericScriptCodeGenerator::FinishExport()
{
	GenerateMainCpp();
	//GeneratedDotnetMap();
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

void FGenericScriptCodeGenerator::GeneratedDotnetMap()
{
	FString Filename = GeneratedCodePath / TEXT("DotnetMap.inl");
	FString Code;

	for (auto& Header : AllSourceClassHeaders)
	{
		Code += FString::Printf(TEXT("#include \"%s\"\r\n"), *RebaseToBuildPath(Header));
	}

	Code += TEXT("\r\n");
	Code += TEXT("template<typename T>\r\n");
	Code += TEXT("INT_PTR ConvertToIntPtr(T MethodPointer)\r\n");
	Code += TEXT("{\r\n");
	Code += TEXT("	return *(INT_PTR*)&MethodPointer;\r\n");
	Code += TEXT("}\r\n\r\n");	

	Code += TEXT("static INT_PTR DotnetMap[] = \r\n");
	Code += TEXT("{\r\n");

	for (auto& func : FunctionMapCode)
	{
		Code += FString::Printf(TEXT("\tConvertToIntPtr(&%s),\r\n"), *func);
	}

	Code += TEXT("};\r\n");

	SaveHeaderIfChanged(Filename, Code);
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