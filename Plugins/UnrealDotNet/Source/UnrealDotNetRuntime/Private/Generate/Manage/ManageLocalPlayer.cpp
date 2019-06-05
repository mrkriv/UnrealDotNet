// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageLocalPlayer.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\LocalPlayer.h:163

bool UManageLocalPlayer::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageLocalPlayer::InitOnlineSession()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitOnlineSession");
	else
		Super::InitOnlineSession();
}

void UManageLocalPlayer::_Supper__InitOnlineSession()
{
	Super::InitOnlineSession();
}

void UManageLocalPlayer::PlayerRemoved()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PlayerRemoved");
	else
		Super::PlayerRemoved();
}

void UManageLocalPlayer::_Supper__PlayerRemoved()
{
	Super::PlayerRemoved();
}

void UManageLocalPlayer::SendSplitJoin()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SendSplitJoin");
	else
		Super::SendSplitJoin();
}

void UManageLocalPlayer::_Supper__SendSplitJoin()
{
	Super::SendSplitJoin();
}

void UManageLocalPlayer::SetControllerId(int32 NewControllerId)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetControllerId", NewControllerId);
	else
		Super::SetControllerId(NewControllerId);
}

void UManageLocalPlayer::_Supper__SetControllerId(int32 NewControllerId)
{
	Super::SetControllerId(NewControllerId);
}

void UManageLocalPlayer::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageLocalPlayer::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageLocalPlayer::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageLocalPlayer::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageLocalPlayer::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageLocalPlayer::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageLocalPlayer::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageLocalPlayer::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageLocalPlayer::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageLocalPlayer::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageLocalPlayer::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageLocalPlayer::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageLocalPlayer::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageLocalPlayer::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageLocalPlayer::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageLocalPlayer::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageLocalPlayer::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageLocalPlayer::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageLocalPlayer::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageLocalPlayer::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageLocalPlayer::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageLocalPlayer::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageLocalPlayer::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageLocalPlayer::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageLocalPlayer::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageLocalPlayer::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageLocalPlayer::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageLocalPlayer::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageLocalPlayer::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageLocalPlayer::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
