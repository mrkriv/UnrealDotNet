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

	TArray<FString> AllCppHeaders;
	TArray<ClassExportInfo> AllExportClass;
	TArray<UScriptStruct*> AllExportStructs;

	void GenerateMainCpp();
	void ExportStruct();
	
	void ExportClass_Real(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename);
	void ExportFunctionCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function);
	void ExportFunctionCS(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UFunction* Function);

	void ExportStructCS(FCodeBuilder& code, UScriptStruct* Struct);

	void ExportPropertyCPP(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UProperty* Property, int32 PropertyIndex);
	void ExportPropertyCS(FCodeBuilder& code, const FString& ClassNameCPP, UClass* Class, UProperty* Property, int32 PropertyIndex);

	void ExportSummaryCS(FCodeBuilder& code, const FText& ToolTipText); 
	
	FString ReplaceCppTypeToCS(const FString& CPPType);

	void SaveCPP(FCodeBuilder& code, const FString Name);
	void SaveCS(FCodeBuilder& code, const FString Name);

	void CollectExportInfo(UClass* Class);
	void CollectExportInfo(UFunction* Function);
	void CollectExportInfo(UField* Property);

	bool CanExportProperty(UProperty* Property);
	virtual bool CanExportClass(UClass* Class) override;
	virtual bool CanExportFunction(UFunction* Function) override;

public:

	FGenericScriptCodeGenerator(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& InIncludeBase);

	// FScriptCodeGeneratorBase interface
	virtual void ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged) override;
	virtual void FinishExport() override;
};
