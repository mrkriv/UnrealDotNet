// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageGameViewportClient.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\GameViewportClient.h:55

void UManageGameViewportClient::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManageGameViewportClient::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageGameViewportClient::DetachViewportClient()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachViewportClient");
	else
		Super::DetachViewportClient();
}

void UManageGameViewportClient::_Supper__DetachViewportClient()
{
	Super::DetachViewportClient();
}

void UManageGameViewportClient::LayoutPlayers()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LayoutPlayers");
	else
		Super::LayoutPlayers();
}

void UManageGameViewportClient::_Supper__LayoutPlayers()
{
	Super::LayoutPlayers();
}

void UManageGameViewportClient::SetConsoleTarget(int32 PlayerIndex)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetConsoleTarget", PlayerIndex);
	else
		Super::SetConsoleTarget(PlayerIndex);
}

void UManageGameViewportClient::_Supper__SetConsoleTarget(int32 PlayerIndex)
{
	Super::SetConsoleTarget(PlayerIndex);
}

void UManageGameViewportClient::SetDropDetail(float DeltaSeconds)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetDropDetail", DeltaSeconds);
	else
		Super::SetDropDetail(DeltaSeconds);
}

void UManageGameViewportClient::_Supper__SetDropDetail(float DeltaSeconds)
{
	Super::SetDropDetail(DeltaSeconds);
}

void UManageGameViewportClient::ShowTitleSafeArea()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShowTitleSafeArea");
	else
		Super::ShowTitleSafeArea();
}

void UManageGameViewportClient::_Supper__ShowTitleSafeArea()
{
	Super::ShowTitleSafeArea();
}

void UManageGameViewportClient::SSSwapControllers()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SSSwapControllers");
	else
		Super::SSSwapControllers();
}

void UManageGameViewportClient::_Supper__SSSwapControllers()
{
	Super::SSSwapControllers();
}

void UManageGameViewportClient::Tick(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaTime);
	else
		Super::Tick(DeltaTime);
}

void UManageGameViewportClient::_Supper__Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

void UManageGameViewportClient::UpdateActiveSplitscreenType()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateActiveSplitscreenType");
	else
		Super::UpdateActiveSplitscreenType();
}

void UManageGameViewportClient::_Supper__UpdateActiveSplitscreenType()
{
	Super::UpdateActiveSplitscreenType();
}

void UManageGameViewportClient::VerifyPathRenderingComponents()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "VerifyPathRenderingComponents");
	else
		Super::VerifyPathRenderingComponents();
}

void UManageGameViewportClient::_Supper__VerifyPathRenderingComponents()
{
	Super::VerifyPathRenderingComponents();
}

void UManageGameViewportClient::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageGameViewportClient::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageGameViewportClient::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageGameViewportClient::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageGameViewportClient::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageGameViewportClient::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageGameViewportClient::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageGameViewportClient::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageGameViewportClient::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageGameViewportClient::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageGameViewportClient::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageGameViewportClient::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageGameViewportClient::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageGameViewportClient::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageGameViewportClient::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageGameViewportClient::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageGameViewportClient::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageGameViewportClient::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageGameViewportClient::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageGameViewportClient::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageGameViewportClient::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageGameViewportClient::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageGameViewportClient::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageGameViewportClient::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageGameViewportClient::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageGameViewportClient::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageGameViewportClient::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageGameViewportClient::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageGameViewportClient::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageGameViewportClient::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
