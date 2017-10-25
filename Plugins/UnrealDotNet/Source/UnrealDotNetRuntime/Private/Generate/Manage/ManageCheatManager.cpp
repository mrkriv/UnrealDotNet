#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageCheatManager.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

void UManageCheatManager::DisableDebugCamera()
{
	Super::DisableDebugCamera();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "DisableDebugCamera");
}

void UManageCheatManager::EnableDebugCamera()
{
	Super::EnableDebugCamera();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "EnableDebugCamera");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
