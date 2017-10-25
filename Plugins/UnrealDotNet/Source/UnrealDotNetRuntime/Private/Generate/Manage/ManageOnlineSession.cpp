#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageOnlineSession.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\OnlineSession.h:18

void UManageOnlineSession::ClearOnlineDelegates()
{
	Super::ClearOnlineDelegates();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearOnlineDelegates");
}

void UManageOnlineSession::EndOnlineSession(FName SessionName)
{
	Super::EndOnlineSession(SessionName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "EndOnlineSession", SessionName);
}

void UManageOnlineSession::RegisterOnlineDelegates()
{
	Super::RegisterOnlineDelegates();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "RegisterOnlineDelegates");
}

void UManageOnlineSession::StartOnlineSession(FName SessionName)
{
	Super::StartOnlineSession(SessionName);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "StartOnlineSession", SessionName);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
