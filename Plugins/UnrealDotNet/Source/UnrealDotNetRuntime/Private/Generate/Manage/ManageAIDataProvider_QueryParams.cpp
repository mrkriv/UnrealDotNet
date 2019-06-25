// This file was created automatically, do not modify the contents of this file.

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageAIDataProvider_QueryParams.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider_QueryParams.h:19

void UManageAIDataProvider_QueryParams::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

bool UManageAIDataProvider_QueryParams::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageAIDataProvider_QueryParams::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageAIDataProvider_QueryParams::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageAIDataProvider_QueryParams::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageAIDataProvider_QueryParams::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageAIDataProvider_QueryParams::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageAIDataProvider_QueryParams::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageAIDataProvider_QueryParams::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageAIDataProvider_QueryParams::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageAIDataProvider_QueryParams::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageAIDataProvider_QueryParams::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageAIDataProvider_QueryParams::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageAIDataProvider_QueryParams::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageAIDataProvider_QueryParams::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageAIDataProvider_QueryParams::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageAIDataProvider_QueryParams::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageAIDataProvider_QueryParams::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageAIDataProvider_QueryParams::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageAIDataProvider_QueryParams::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageAIDataProvider_QueryParams::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageAIDataProvider_QueryParams::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageAIDataProvider_QueryParams::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageAIDataProvider_QueryParams::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageAIDataProvider_QueryParams::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageAIDataProvider_QueryParams::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageAIDataProvider_QueryParams::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageAIDataProvider_QueryParams::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageAIDataProvider_QueryParams::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageAIDataProvider_QueryParams::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageAIDataProvider_QueryParams::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageAIDataProvider_QueryParams::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
