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
	virtual void ValidateSettings() override;
	
protected:
	virtual void UpdateVersion() override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
