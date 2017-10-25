#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageGameUserSettings.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\GameUserSettings.h:38

void UManageGameUserSettings::ApplyHardwareBenchmarkResults()
{
	Super::ApplyHardwareBenchmarkResults();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyHardwareBenchmarkResults");
}

void UManageGameUserSettings::ApplyNonResolutionSettings()
{
	Super::ApplyNonResolutionSettings();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyNonResolutionSettings");
}

void UManageGameUserSettings::ApplySettings(bool bCheckForCommandLineOverrides)
{
	Super::ApplySettings(bCheckForCommandLineOverrides);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplySettings", bCheckForCommandLineOverrides);
}

void UManageGameUserSettings::LoadSettings(bool bForceReload)
{
	Super::LoadSettings(bForceReload);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "LoadSettings", bForceReload);
}

void UManageGameUserSettings::ResetToCurrentSettings()
{
	Super::ResetToCurrentSettings();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ResetToCurrentSettings");
}

void UManageGameUserSettings::RunHardwareBenchmark(int32 WorkScale, float CPUMultiplier, float GPUMultiplier)
{
	Super::RunHardwareBenchmark(WorkScale, CPUMultiplier, GPUMultiplier);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RunHardwareBenchmark", WorkScale, CPUMultiplier, GPUMultiplier);
}

void UManageGameUserSettings::SaveSettings()
{
	Super::SaveSettings();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SaveSettings");
}

void UManageGameUserSettings::SetOverallScalabilityLevel(int32 Value)
{
	Super::SetOverallScalabilityLevel(Value);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetOverallScalabilityLevel", Value);
}

void UManageGameUserSettings::SetToDefaults()
{
	Super::SetToDefaults();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetToDefaults");
}

void UManageGameUserSettings::SetWindowPosition(int32 WindowPosX, int32 WindowPosY)
{
	Super::SetWindowPosition(WindowPosX, WindowPosY);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "SetWindowPosition", WindowPosX, WindowPosY);
}

void UManageGameUserSettings::UpdateVersion()
{
	Super::UpdateVersion();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateVersion");
}

void UManageGameUserSettings::ValidateSettings()
{
	Super::ValidateSettings();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ValidateSettings");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
