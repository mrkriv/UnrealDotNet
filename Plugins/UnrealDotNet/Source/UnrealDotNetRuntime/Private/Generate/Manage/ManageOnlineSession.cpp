// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageOnlineSession.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\OnlineSession.h:18

bool UManageOnlineSession::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageOnlineSession::ClearOnlineDelegates()
{
	Super::ClearOnlineDelegates();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ClearOnlineDelegates");
}

void UManageOnlineSession::EndOnlineSession(FName SessionName)
{
	Super::EndOnlineSession(SessionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EndOnlineSession", SessionName);
}

void UManageOnlineSession::RegisterOnlineDelegates()
{
	Super::RegisterOnlineDelegates();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RegisterOnlineDelegates");
}

void UManageOnlineSession::StartOnlineSession(FName SessionName)
{
	Super::StartOnlineSession(SessionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StartOnlineSession", SessionName);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
