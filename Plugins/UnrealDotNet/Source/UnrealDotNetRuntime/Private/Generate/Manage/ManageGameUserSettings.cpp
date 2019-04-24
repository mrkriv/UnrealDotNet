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
	Super::ApplyHardwareBenchmarkResults();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyHardwareBenchmarkResults");
}

void UManageGameUserSettings::ApplyNonResolutionSettings()
{
	Super::ApplyNonResolutionSettings();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplyNonResolutionSettings");
}

void UManageGameUserSettings::ApplySettings(bool bCheckForCommandLineOverrides)
{
	Super::ApplySettings(bCheckForCommandLineOverrides);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ApplySettings", bCheckForCommandLineOverrides);
}

void UManageGameUserSettings::ConfirmVideoMode()
{
	Super::ConfirmVideoMode();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ConfirmVideoMode");
}

void UManageGameUserSettings::LoadSettings(bool bForceReload)
{
	Super::LoadSettings(bForceReload);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LoadSettings", bForceReload);
}

void UManageGameUserSettings::ResetToCurrentSettings()
{
	Super::ResetToCurrentSettings();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ResetToCurrentSettings");
}

void UManageGameUserSettings::RunHardwareBenchmark(int32 WorkScale, float CPUMultiplier, float GPUMultiplier)
{
	Super::RunHardwareBenchmark(WorkScale, CPUMultiplier, GPUMultiplier);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RunHardwareBenchmark", WorkScale, CPUMultiplier, GPUMultiplier);
}

void UManageGameUserSettings::SaveSettings()
{
	Super::SaveSettings();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SaveSettings");
}

void UManageGameUserSettings::SetOverallScalabilityLevel(int32 Value)
{
	Super::SetOverallScalabilityLevel(Value);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetOverallScalabilityLevel", Value);
}

void UManageGameUserSettings::SetToDefaults()
{
	Super::SetToDefaults();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetToDefaults");
}

void UManageGameUserSettings::SetWindowPosition(int32 WindowPosX, int32 WindowPosY)
{
	Super::SetWindowPosition(WindowPosX, WindowPosY);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetWindowPosition", WindowPosX, WindowPosY);
}

void UManageGameUserSettings::UpdateVersion()
{
	Super::UpdateVersion();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateVersion");
}

void UManageGameUserSettings::ValidateSettings()
{
	Super::ValidateSettings();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ValidateSettings");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
