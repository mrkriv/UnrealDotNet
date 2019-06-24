// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCameraModifier.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraModifier.h:22

void UManageCameraModifier::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManageCameraModifier::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageCameraModifier::DisableModifier(bool bImmediate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableModifier", bImmediate);
	else
		Super::DisableModifier(bImmediate);
}

void UManageCameraModifier::_Supper__DisableModifier(bool bImmediate)
{
	Super::DisableModifier(bImmediate);
}

void UManageCameraModifier::EnableModifier()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableModifier");
	else
		Super::EnableModifier();
}

void UManageCameraModifier::_Supper__EnableModifier()
{
	Super::EnableModifier();
}

void UManageCameraModifier::ToggleModifier()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleModifier");
	else
		Super::ToggleModifier();
}

void UManageCameraModifier::_Supper__ToggleModifier()
{
	Super::ToggleModifier();
}

void UManageCameraModifier::UpdateAlpha(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateAlpha", DeltaTime);
	else
		Super::UpdateAlpha(DeltaTime);
}

void UManageCameraModifier::_Supper__UpdateAlpha(float DeltaTime)
{
	Super::UpdateAlpha(DeltaTime);
}

void UManageCameraModifier::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageCameraModifier::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageCameraModifier::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageCameraModifier::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageCameraModifier::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageCameraModifier::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageCameraModifier::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageCameraModifier::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageCameraModifier::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageCameraModifier::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageCameraModifier::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageCameraModifier::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageCameraModifier::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageCameraModifier::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageCameraModifier::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageCameraModifier::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageCameraModifier::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageCameraModifier::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageCameraModifier::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageCameraModifier::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageCameraModifier::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageCameraModifier::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageCameraModifier::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageCameraModifier::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageCameraModifier::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageCameraModifier::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageCameraModifier::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageCameraModifier::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageCameraModifier::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageCameraModifier::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
