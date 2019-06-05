// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageGameUserSettings.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameUserSettings.h:38

bool UManageGameUserSettings::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageGameUserSettings::ApplyHardwareBenchmarkResults()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyHardwareBenchmarkResults");
	else
		Super::ApplyHardwareBenchmarkResults();
}

void UManageGameUserSettings::_Supper__ApplyHardwareBenchmarkResults()
{
	Super::ApplyHardwareBenchmarkResults();
}

void UManageGameUserSettings::ApplyNonResolutionSettings()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyNonResolutionSettings");
	else
		Super::ApplyNonResolutionSettings();
}

void UManageGameUserSettings::_Supper__ApplyNonResolutionSettings()
{
	Super::ApplyNonResolutionSettings();
}

void UManageGameUserSettings::ApplySettings(bool bCheckForCommandLineOverrides)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplySettings", bCheckForCommandLineOverrides);
	else
		Super::ApplySettings(bCheckForCommandLineOverrides);
}

void UManageGameUserSettings::_Supper__ApplySettings(bool bCheckForCommandLineOverrides)
{
	Super::ApplySettings(bCheckForCommandLineOverrides);
}

void UManageGameUserSettings::ConfirmVideoMode()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ConfirmVideoMode");
	else
		Super::ConfirmVideoMode();
}

void UManageGameUserSettings::_Supper__ConfirmVideoMode()
{
	Super::ConfirmVideoMode();
}

void UManageGameUserSettings::LoadSettings(bool bForceReload)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LoadSettings", bForceReload);
	else
		Super::LoadSettings(bForceReload);
}

void UManageGameUserSettings::_Supper__LoadSettings(bool bForceReload)
{
	Super::LoadSettings(bForceReload);
}

void UManageGameUserSettings::ResetToCurrentSettings()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetToCurrentSettings");
	else
		Super::ResetToCurrentSettings();
}

void UManageGameUserSettings::_Supper__ResetToCurrentSettings()
{
	Super::ResetToCurrentSettings();
}

void UManageGameUserSettings::RunHardwareBenchmark(int32 WorkScale, float CPUMultiplier, float GPUMultiplier)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RunHardwareBenchmark", WorkScale, CPUMultiplier, GPUMultiplier);
	else
		Super::RunHardwareBenchmark(WorkScale, CPUMultiplier, GPUMultiplier);
}

void UManageGameUserSettings::_Supper__RunHardwareBenchmark(int32 WorkScale, float CPUMultiplier, float GPUMultiplier)
{
	Super::RunHardwareBenchmark(WorkScale, CPUMultiplier, GPUMultiplier);
}

void UManageGameUserSettings::SaveSettings()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SaveSettings");
	else
		Super::SaveSettings();
}

void UManageGameUserSettings::_Supper__SaveSettings()
{
	Super::SaveSettings();
}

void UManageGameUserSettings::SetOverallScalabilityLevel(int32 Value)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetOverallScalabilityLevel", Value);
	else
		Super::SetOverallScalabilityLevel(Value);
}

void UManageGameUserSettings::_Supper__SetOverallScalabilityLevel(int32 Value)
{
	Super::SetOverallScalabilityLevel(Value);
}

void UManageGameUserSettings::SetToDefaults()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetToDefaults");
	else
		Super::SetToDefaults();
}

void UManageGameUserSettings::_Supper__SetToDefaults()
{
	Super::SetToDefaults();
}

void UManageGameUserSettings::SetWindowPosition(int32 WindowPosX, int32 WindowPosY)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetWindowPosition", WindowPosX, WindowPosY);
	else
		Super::SetWindowPosition(WindowPosX, WindowPosY);
}

void UManageGameUserSettings::_Supper__SetWindowPosition(int32 WindowPosX, int32 WindowPosY)
{
	Super::SetWindowPosition(WindowPosX, WindowPosY);
}

void UManageGameUserSettings::UpdateVersion()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateVersion");
	else
		Super::UpdateVersion();
}

void UManageGameUserSettings::_Supper__UpdateVersion()
{
	Super::UpdateVersion();
}

void UManageGameUserSettings::ValidateSettings()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ValidateSettings");
	else
		Super::ValidateSettings();
}

void UManageGameUserSettings::_Supper__ValidateSettings()
{
	Super::ValidateSettings();
}

void UManageGameUserSettings::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageGameUserSettings::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageGameUserSettings::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageGameUserSettings::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageGameUserSettings::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageGameUserSettings::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageGameUserSettings::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageGameUserSettings::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageGameUserSettings::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageGameUserSettings::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageGameUserSettings::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageGameUserSettings::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageGameUserSettings::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageGameUserSettings::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageGameUserSettings::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageGameUserSettings::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageGameUserSettings::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageGameUserSettings::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageGameUserSettings::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageGameUserSettings::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageGameUserSettings::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageGameUserSettings::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageGameUserSettings::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageGameUserSettings::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageGameUserSettings::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageGameUserSettings::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageGameUserSettings::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageGameUserSettings::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageGameUserSettings::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageGameUserSettings::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
