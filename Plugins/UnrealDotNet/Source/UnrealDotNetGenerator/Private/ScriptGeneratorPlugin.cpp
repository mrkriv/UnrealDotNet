#include "CoreMinimal.h"
#include "ScriptGeneratorLog.h"
#include "ScriptCodeGeneratorBase.h"
#include "GenericScriptCodeGenerator.h"
#include "IProjectManager.h"
#include "Features/IModularFeatures.h"
#include "UniquePtr.h"
#include "ProjectDescriptor.h"

DEFINE_LOG_CATEGORY(LogUnrealDotNetGenerator);

class FScriptGeneratorPlugin : public IScriptGeneratorPlugin
{
	/** Specialized script code generator */
	TUniquePtr<FScriptCodeGeneratorBase> CodeGenerator;

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;

	/** IScriptGeneratorPlugin interface */
	virtual FString GetGeneratedCodeModuleName() const override { return TEXT("UnrealDotNetRuntime"); }
	virtual bool ShouldExportClassesForModule(const FString& ModuleName, EBuildModuleType::Type ModuleType, const FString& ModuleGeneratedIncludeDirectory) const override;
	virtual bool SupportsTarget(const FString& TargetName) const override;
	virtual void Initialize(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& IncludeBase) override;
	virtual void ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged) override;
	virtual void FinishExport() override;
	virtual FString GetGeneratorName() const override;
};

IMPLEMENT_MODULE(FScriptGeneratorPlugin, ScriptGeneratorPlugin)

void FScriptGeneratorPlugin::StartupModule()
{
	// Register ourselves as an editor feature
	IModularFeatures::Get().RegisterModularFeature(TEXT("ScriptGenerator"), this);
}

void FScriptGeneratorPlugin::ShutdownModule()
{
	CodeGenerator.Reset();

	// Unregister our feature
	IModularFeatures::Get().UnregisterModularFeature(TEXT("ScriptGenerator"), this);
}

FString FScriptGeneratorPlugin::GetGeneratorName() const
{
	return TEXT("Example Code Generator Plugin");
}

void FScriptGeneratorPlugin::Initialize(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& IncludeBase)
{
	UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("Using code generator for dotnet support"));
	CodeGenerator = MakeUnique<FGenericScriptCodeGenerator>(RootLocalPath, RootBuildPath, OutputDirectory, IncludeBase);

	UE_LOG(LogUnrealDotNetGenerator, Log, TEXT("Output directory: %s"), *OutputDirectory);
}

bool FScriptGeneratorPlugin::ShouldExportClassesForModule(const FString& ModuleName, EBuildModuleType::Type ModuleType, const FString& ModuleGeneratedIncludeDirectory) const
{
	return (ModuleType == EBuildModuleType::EngineRuntime || ModuleType == EBuildModuleType::GameRuntime);
}

void FScriptGeneratorPlugin::ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged)
{
	CodeGenerator->ExportClass(Class, SourceHeaderFilename, GeneratedHeaderFilename, bHasChanged);
}

void FScriptGeneratorPlugin::FinishExport()
{
	CodeGenerator->FinishExport();
}

bool FScriptGeneratorPlugin::SupportsTarget(const FString& TargetName) const
{
	return true;
}
