#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/GameUserSettings.h"
#include "ManageGameUserSettings.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameUserSettings.h:38

UCLASS()
class UNREALDOTNETRUNTIME_API UManageGameUserSettings : public UGameUserSettings, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void ApplyHardwareBenchmarkResults() override;
	virtual void ApplyNonResolutionSettings() override;
	virtual void ApplySettings(bool bCheckForCommandLineOverrides) override;
	virtual void ConfirmVideoMode() override;
	virtual void LoadSettings(bool bForceReload) override;
	virtual void ResetToCurrentSettings() override;
	virtual void RunHardwareBenchmark(int32 WorkScale, float CPUMultiplier, float GPUMultiplier) override;
	virtual void SaveSettings() override;
	virtual void SetOverallScalabilityLevel(int32 Value) override;
	virtual void SetToDefaults() override;
	virtual void SetWindowPosition(int32 WindowPosX, int32 WindowPosY) override;
	virtual void UpdateVersion() override;
	virtual void ValidateSettings() override;
	virtual void BeginDestroy() override;
	virtual void FinishDestroy() override;
	virtual void MarkAsEditorOnlySubobject() override;
	virtual void OverridePerObjectConfigSection(FString& SectionName) override;
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRename(UObject* OldOuter, const FName OldName) override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
