// This file was created automatically, do not modify the contents of this file.

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageCheatManager.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

void UManageCheatManager::SetManageType(const FDotnetTypeName& ManageType)
{
	ManageClassName = ManageType;
}

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

void UManageCheatManager::BugItGo(float X, float Y, float Z, float Pitch, float Yaw, float Roll)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BugItGo", X, Y, Z, Pitch, Yaw, Roll);
	else
		Super::BugItGo(X, Y, Z, Pitch, Yaw, Roll);
}

void UManageCheatManager::_Supper__BugItGo(float X, float Y, float Z, float Pitch, float Yaw, float Roll)
{
	Super::BugItGo(X, Y, Z, Pitch, Yaw, Roll);
}

void UManageCheatManager::ChangeSize(float F)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ChangeSize", F);
	else
		Super::ChangeSize(F);
}

void UManageCheatManager::_Supper__ChangeSize(float F)
{
	Super::ChangeSize(F);
}

void UManageCheatManager::DamageTarget(float DamageAmount)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DamageTarget", DamageAmount);
	else
		Super::DamageTarget(DamageAmount);
}

void UManageCheatManager::_Supper__DamageTarget(float DamageAmount)
{
	Super::DamageTarget(DamageAmount);
}

void UManageCheatManager::DebugCapsuleSweep()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweep");
	else
		Super::DebugCapsuleSweep();
}

void UManageCheatManager::_Supper__DebugCapsuleSweep()
{
	Super::DebugCapsuleSweep();
}

void UManageCheatManager::DebugCapsuleSweepCapture()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepCapture");
	else
		Super::DebugCapsuleSweepCapture();
}

void UManageCheatManager::_Supper__DebugCapsuleSweepCapture()
{
	Super::DebugCapsuleSweepCapture();
}

void UManageCheatManager::DebugCapsuleSweepClear()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepClear");
	else
		Super::DebugCapsuleSweepClear();
}

void UManageCheatManager::_Supper__DebugCapsuleSweepClear()
{
	Super::DebugCapsuleSweepClear();
}

void UManageCheatManager::DebugCapsuleSweepComplex(bool bTraceComplex)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepComplex", bTraceComplex);
	else
		Super::DebugCapsuleSweepComplex(bTraceComplex);
}

void UManageCheatManager::_Supper__DebugCapsuleSweepComplex(bool bTraceComplex)
{
	Super::DebugCapsuleSweepComplex(bTraceComplex);
}

void UManageCheatManager::DebugCapsuleSweepPawn()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepPawn");
	else
		Super::DebugCapsuleSweepPawn();
}

void UManageCheatManager::_Supper__DebugCapsuleSweepPawn()
{
	Super::DebugCapsuleSweepPawn();
}

void UManageCheatManager::DebugCapsuleSweepSize(float HalfHeight, float Radius)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepSize", HalfHeight, Radius);
	else
		Super::DebugCapsuleSweepSize(HalfHeight, Radius);
}

void UManageCheatManager::_Supper__DebugCapsuleSweepSize(float HalfHeight, float Radius)
{
	Super::DebugCapsuleSweepSize(HalfHeight, Radius);
}

void UManageCheatManager::DestroyAllPawnsExceptTarget()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyAllPawnsExceptTarget");
	else
		Super::DestroyAllPawnsExceptTarget();
}

void UManageCheatManager::_Supper__DestroyAllPawnsExceptTarget()
{
	Super::DestroyAllPawnsExceptTarget();
}

void UManageCheatManager::DestroyTarget()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyTarget");
	else
		Super::DestroyTarget();
}

void UManageCheatManager::_Supper__DestroyTarget()
{
	Super::DestroyTarget();
}

void UManageCheatManager::DisableDebugCamera()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableDebugCamera");
	else
		Super::DisableDebugCamera();
}

void UManageCheatManager::_Supper__DisableDebugCamera()
{
	Super::DisableDebugCamera();
}

void UManageCheatManager::DumpChatState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DumpChatState");
	else
		Super::DumpChatState();
}

void UManageCheatManager::_Supper__DumpChatState()
{
	Super::DumpChatState();
}

void UManageCheatManager::DumpOnlineSessionState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DumpOnlineSessionState");
	else
		Super::DumpOnlineSessionState();
}

void UManageCheatManager::_Supper__DumpOnlineSessionState()
{
	Super::DumpOnlineSessionState();
}

void UManageCheatManager::DumpPartyState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DumpPartyState");
	else
		Super::DumpPartyState();
}

void UManageCheatManager::_Supper__DumpPartyState()
{
	Super::DumpPartyState();
}

void UManageCheatManager::DumpVoiceMutingState()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DumpVoiceMutingState");
	else
		Super::DumpVoiceMutingState();
}

void UManageCheatManager::_Supper__DumpVoiceMutingState()
{
	Super::DumpVoiceMutingState();
}

void UManageCheatManager::EnableDebugCamera()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableDebugCamera");
	else
		Super::EnableDebugCamera();
}

void UManageCheatManager::_Supper__EnableDebugCamera()
{
	Super::EnableDebugCamera();
}

void UManageCheatManager::FlushLog()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FlushLog");
	else
		Super::FlushLog();
}

void UManageCheatManager::_Supper__FlushLog()
{
	Super::FlushLog();
}

void UManageCheatManager::Fly()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Fly");
	else
		Super::Fly();
}

void UManageCheatManager::_Supper__Fly()
{
	Super::Fly();
}

void UManageCheatManager::FreezeFrame(float Delay)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FreezeFrame", Delay);
	else
		Super::FreezeFrame(Delay);
}

void UManageCheatManager::_Supper__FreezeFrame(float Delay)
{
	Super::FreezeFrame(Delay);
}

void UManageCheatManager::Ghost()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Ghost");
	else
		Super::Ghost();
}

void UManageCheatManager::_Supper__Ghost()
{
	Super::Ghost();
}

void UManageCheatManager::God()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "God");
	else
		Super::God();
}

void UManageCheatManager::_Supper__God()
{
	Super::God();
}

void UManageCheatManager::InitCheatManager()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitCheatManager");
	else
		Super::InitCheatManager();
}

void UManageCheatManager::_Supper__InitCheatManager()
{
	Super::InitCheatManager();
}

void UManageCheatManager::InvertMouse()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvertMouse");
	else
		Super::InvertMouse();
}

void UManageCheatManager::_Supper__InvertMouse()
{
	Super::InvertMouse();
}

void UManageCheatManager::LogLoc()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LogLoc");
	else
		Super::LogLoc();
}

void UManageCheatManager::_Supper__LogLoc()
{
	Super::LogLoc();
}

void UManageCheatManager::PlayersOnly()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PlayersOnly");
	else
		Super::PlayersOnly();
}

void UManageCheatManager::_Supper__PlayersOnly()
{
	Super::PlayersOnly();
}

void UManageCheatManager::ServerToggleAILogging()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ServerToggleAILogging");
	else
		Super::ServerToggleAILogging();
}

void UManageCheatManager::_Supper__ServerToggleAILogging()
{
	Super::ServerToggleAILogging();
}

void UManageCheatManager::SetMouseSensitivityToDefault()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMouseSensitivityToDefault");
	else
		Super::SetMouseSensitivityToDefault();
}

void UManageCheatManager::_Supper__SetMouseSensitivityToDefault()
{
	Super::SetMouseSensitivityToDefault();
}

void UManageCheatManager::Slomo(float NewTimeDilation)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Slomo", NewTimeDilation);
	else
		Super::Slomo(NewTimeDilation);
}

void UManageCheatManager::_Supper__Slomo(float NewTimeDilation)
{
	Super::Slomo(NewTimeDilation);
}

void UManageCheatManager::Teleport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Teleport");
	else
		Super::Teleport();
}

void UManageCheatManager::_Supper__Teleport()
{
	Super::Teleport();
}

void UManageCheatManager::TestCollisionDistance()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TestCollisionDistance");
	else
		Super::TestCollisionDistance();
}

void UManageCheatManager::_Supper__TestCollisionDistance()
{
	Super::TestCollisionDistance();
}

void UManageCheatManager::ToggleAILogging()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleAILogging");
	else
		Super::ToggleAILogging();
}

void UManageCheatManager::_Supper__ToggleAILogging()
{
	Super::ToggleAILogging();
}

void UManageCheatManager::ToggleDebugCamera()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleDebugCamera");
	else
		Super::ToggleDebugCamera();
}

void UManageCheatManager::_Supper__ToggleDebugCamera()
{
	Super::ToggleDebugCamera();
}

void UManageCheatManager::ViewSelf()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ViewSelf");
	else
		Super::ViewSelf();
}

void UManageCheatManager::_Supper__ViewSelf()
{
	Super::ViewSelf();
}

void UManageCheatManager::Walk()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Walk");
	else
		Super::Walk();
}

void UManageCheatManager::_Supper__Walk()
{
	Super::Walk();
}

void UManageCheatManager::BeginDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
	else
		Super::BeginDestroy();
}

void UManageCheatManager::_Supper__BeginDestroy()
{
	Super::BeginDestroy();
}

void UManageCheatManager::FinishDestroy()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
	else
		Super::FinishDestroy();
}

void UManageCheatManager::_Supper__FinishDestroy()
{
	Super::FinishDestroy();
}

void UManageCheatManager::MarkAsEditorOnlySubobject()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
	else
		Super::MarkAsEditorOnlySubobject();
}

void UManageCheatManager::_Supper__MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
}

void UManageCheatManager::PostCDOContruct()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
	else
		Super::PostCDOContruct();
}

void UManageCheatManager::_Supper__PostCDOContruct()
{
	Super::PostCDOContruct();
}

void UManageCheatManager::PostEditImport()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
	else
		Super::PostEditImport();
}

void UManageCheatManager::_Supper__PostEditImport()
{
	Super::PostEditImport();
}

void UManageCheatManager::PostInitProperties()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
	else
		Super::PostInitProperties();
}

void UManageCheatManager::_Supper__PostInitProperties()
{
	Super::PostInitProperties();
}

void UManageCheatManager::PostLoad()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
	else
		Super::PostLoad();
}

void UManageCheatManager::_Supper__PostLoad()
{
	Super::PostLoad();
}

void UManageCheatManager::PostNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
	else
		Super::PostNetReceive();
}

void UManageCheatManager::_Supper__PostNetReceive()
{
	Super::PostNetReceive();
}

void UManageCheatManager::PostRepNotifies()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
	else
		Super::PostRepNotifies();
}

void UManageCheatManager::_Supper__PostRepNotifies()
{
	Super::PostRepNotifies();
}

void UManageCheatManager::PostSaveRoot(bool bCleanupIsRequired)
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
	else
		Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageCheatManager::_Supper__PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
}

void UManageCheatManager::PreDestroyFromReplication()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
	else
		Super::PreDestroyFromReplication();
}

void UManageCheatManager::_Supper__PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
}

void UManageCheatManager::PreNetReceive()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
	else
		Super::PreNetReceive();
}

void UManageCheatManager::_Supper__PreNetReceive()
{
	Super::PreNetReceive();
}

void UManageCheatManager::ShutdownAfterError()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
	else
		Super::ShutdownAfterError();
}

void UManageCheatManager::_Supper__ShutdownAfterError()
{
	Super::ShutdownAfterError();
}

void UManageCheatManager::CreateCluster()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
	else
		Super::CreateCluster();
}

void UManageCheatManager::_Supper__CreateCluster()
{
	Super::CreateCluster();
}

void UManageCheatManager::OnClusterMarkedAsPendingKill()
{
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
	else
		Super::OnClusterMarkedAsPendingKill();
}

void UManageCheatManager::_Supper__OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
