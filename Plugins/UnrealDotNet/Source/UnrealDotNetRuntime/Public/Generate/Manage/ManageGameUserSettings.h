#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageObject.h"
#include "TypeConvertor.h"
#include "Runtime/Engine/Classes/GameFramework/GameUserSettings.h"
#include "ManageGameUserSettings.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameUserSettings.h:38

UCLASS()
class UNREALDOTNETRUNTIME_API UManageGameUserSettings : public UGameUserSettings, public IManageObject
{
	GENERATED_BODY()
	
public:
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach() override;
	void SetManageType(const FDotnetTypeName& ManageType) override;
	
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
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
	
	void _Supper__ApplyHardwareBenchmarkResults();
	void _Supper__ApplyNonResolutionSettings();
	void _Supper__ApplySettings(bool bCheckForCommandLineOverrides);
	void _Supper__ConfirmVideoMode();
	void _Supper__LoadSettings(bool bForceReload);
	void _Supper__ResetToCurrentSettings();
	void _Supper__RunHardwareBenchmark(int32 WorkScale, float CPUMultiplier, float GPUMultiplier);
	void _Supper__SaveSettings();
	void _Supper__SetOverallScalabilityLevel(int32 Value);
	void _Supper__SetToDefaults();
	void _Supper__SetWindowPosition(int32 WindowPosX, int32 WindowPosY);
	void _Supper__UpdateVersion();
	void _Supper__ValidateSettings();
	void _Supper__BeginDestroy();
	void _Supper__FinishDestroy();
	void _Supper__MarkAsEditorOnlySubobject();
	void _Supper__PostCDOContruct();
	void _Supper__PostEditImport();
	void _Supper__PostInitProperties();
	void _Supper__PostLoad();
	void _Supper__PostNetReceive();
	void _Supper__PostRepNotifies();
	void _Supper__PostSaveRoot(bool bCleanupIsRequired);
	void _Supper__PreDestroyFromReplication();
	void _Supper__PreNetReceive();
	void _Supper__ShutdownAfterError();
	void _Supper__CreateCluster();
	void _Supper__OnClusterMarkedAsPendingKill();
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
