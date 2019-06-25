// This file was created automatically, do not modify the contents of this file.

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManagePawnAction_Repeat.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_Repeat.h:11

void UManagePawnAction_Repeat::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManagePawnAction_Repeat::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManagePawnAction_Repeat::Tick(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaTime);
	else
		Super::Tick(DeltaTime);
}

void UManagePawnAction_Repeat::_Supper__Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

void UManagePawnAction_Repeat::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManagePawnAction_Repeat::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManagePawnAction_Repeat::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManagePawnAction_Repeat::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManagePawnAction_Repeat::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManagePawnAction_Repeat::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManagePawnAction_Repeat::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManagePawnAction_Repeat::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManagePawnAction_Repeat::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManagePawnAction_Repeat::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManagePawnAction_Repeat::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManagePawnAction_Repeat::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManagePawnAction_Repeat::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManagePawnAction_Repeat::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManagePawnAction_Repeat::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManagePawnAction_Repeat::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManagePawnAction_Repeat::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManagePawnAction_Repeat::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManagePawnAction_Repeat::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManagePawnAction_Repeat::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManagePawnAction_Repeat::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManagePawnAction_Repeat::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManagePawnAction_Repeat::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManagePawnAction_Repeat::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManagePawnAction_Repeat::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManagePawnAction_Repeat::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManagePawnAction_Repeat::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManagePawnAction_Repeat::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManagePawnAction_Repeat::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManagePawnAction_Repeat::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
