// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCameraModifier_CameraShake.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraModifier_CameraShake.h:33

void UManageCameraModifier_CameraShake::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManageCameraModifier_CameraShake::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageCameraModifier_CameraShake::RemoveAllCameraShakes(bool bImmediately)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RemoveAllCameraShakes", bImmediately);
	else
		Super::RemoveAllCameraShakes(bImmediately);
}

void UManageCameraModifier_CameraShake::_Supper__RemoveAllCameraShakes(bool bImmediately)
{
	Super::RemoveAllCameraShakes(bImmediately);
}

void UManageCameraModifier_CameraShake::DisableModifier(bool bImmediate)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableModifier", bImmediate);
	else
		Super::DisableModifier(bImmediate);
}

void UManageCameraModifier_CameraShake::_Supper__DisableModifier(bool bImmediate)
{
	Super::DisableModifier(bImmediate);
}

void UManageCameraModifier_CameraShake::EnableModifier()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableModifier");
	else
		Super::EnableModifier();
}

void UManageCameraModifier_CameraShake::_Supper__EnableModifier()
{
	Super::EnableModifier();
}

void UManageCameraModifier_CameraShake::ToggleModifier()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleModifier");
	else
		Super::ToggleModifier();
}

void UManageCameraModifier_CameraShake::_Supper__ToggleModifier()
{
	Super::ToggleModifier();
}

void UManageCameraModifier_CameraShake::UpdateAlpha(float DeltaTime)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateAlpha", DeltaTime);
	else
		Super::UpdateAlpha(DeltaTime);
}

void UManageCameraModifier_CameraShake::_Supper__UpdateAlpha(float DeltaTime)
{
	Super::UpdateAlpha(DeltaTime);
}

void UManageCameraModifier_CameraShake::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageCameraModifier_CameraShake::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageCameraModifier_CameraShake::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageCameraModifier_CameraShake::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageCameraModifier_CameraShake::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageCameraModifier_CameraShake::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageCameraModifier_CameraShake::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageCameraModifier_CameraShake::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageCameraModifier_CameraShake::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageCameraModifier_CameraShake::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageCameraModifier_CameraShake::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageCameraModifier_CameraShake::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageCameraModifier_CameraShake::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageCameraModifier_CameraShake::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageCameraModifier_CameraShake::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageCameraModifier_CameraShake::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageCameraModifier_CameraShake::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageCameraModifier_CameraShake::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageCameraModifier_CameraShake::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageCameraModifier_CameraShake::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageCameraModifier_CameraShake::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageCameraModifier_CameraShake::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageCameraModifier_CameraShake::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageCameraModifier_CameraShake::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageCameraModifier_CameraShake::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageCameraModifier_CameraShake::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageCameraModifier_CameraShake::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageCameraModifier_CameraShake::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageCameraModifier_CameraShake::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageCameraModifier_CameraShake::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
