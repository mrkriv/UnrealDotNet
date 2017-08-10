#pragma once

#include "CoreMinimal.h"
#include "ScriptCodeGeneratorBase.h"
#include "CodeBuilder.h"

struct ClassExportInfo
{
	UClass* Class;
	const FString SourceHeaderFilename;
	const FString GeneratedHeaderFilename;
};

class FGenericScriptCodeGenerator : public FScriptCodeGeneratorBase
{
protected:

	TArray<FString> AllScriptHeaders;
	TArray<FString> AllSourceClassHeaders;
	TArray<ClassExportInfo> AllExportClass;
	
	void GenerateMainCpp();
	
	void ExportClass_Real(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename);
	void ExportFunctionCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function, FString& DeclareExternFragment);
	void ExportFunctionCS(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function, const FString& DeclareExternFragment);

	void ExportPropertyCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UProperty* Property, int32 PropertyIndex);
	void ExportPropertyCS(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UProperty* Property, int32 PropertyIndex);

	FString GenerateWrapperFunctionDeclaration(const FString& ClassNameCPP, UClass* Class, UFunction* Function);
	FString GenerateWrapperFunctionDeclaration(const FString& ClassNameCPP, UClass* Class, const FString& FunctionName);
	FString GenerateFunctionParamDeclaration(const FString& ClassNameCPP, UClass* Class, UFunction* Function, UProperty* Param);
	FString GenerateObjectDeclarationFromContext(const FString& ClassNameCPP, UClass* Class);
	FString GenerateReturnValueHandler(const FString& ClassNameCPP, UClass* Class, UFunction* Function, UProperty* ReturnValue);

	virtual bool CanExportClass(UClass* Class) override;
	virtual bool CanExportFunction(UFunction* Function) override;

public:

	FGenericScriptCodeGenerator(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& InIncludeBase);

	// FScriptCodeGeneratorBase interface
	virtual void ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged) override;
	virtual void FinishExport() override;
};
