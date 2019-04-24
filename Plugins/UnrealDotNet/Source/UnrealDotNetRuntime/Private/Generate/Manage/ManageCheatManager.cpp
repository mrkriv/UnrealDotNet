// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCheatManager.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

bool UManageCheatManager::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageCheatManager::DisableDebugCamera()
{
	Super::DisableDebugCamera();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableDebugCamera");
}

void UManageCheatManager::EnableDebugCamera()
{
	Super::EnableDebugCamera();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableDebugCamera");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
