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

void UManageCheatManager::BugIt(const FString& ScreenShotDescription)
{
	Super::BugIt(ScreenShotDescription);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BugIt", ScreenShotDescription);
}

void UManageCheatManager::BugItGo(float X, float Y, float Z, float Pitch, float Yaw, float Roll)
{
	Super::BugItGo(X, Y, Z, Pitch, Yaw, Roll);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BugItGo", X, Y, Z, Pitch, Yaw, Roll);
}

void UManageCheatManager::BugItGoString(const FString& TheLocation, const FString& TheRotation)
{
	Super::BugItGoString(TheLocation, TheRotation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BugItGoString", TheLocation, TheRotation);
}

void UManageCheatManager::BugItStringCreator(FVector ViewLocation, FRotator ViewRotation, FString& GoString, FString& LocString)
{
	Super::BugItStringCreator(ViewLocation, ViewRotation, GoString, LocString);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BugItStringCreator", ViewLocation, ViewRotation, GoString, LocString);
}

void UManageCheatManager::BugItWorker(FVector TheLocation, FRotator TheRotation)
{
	Super::BugItWorker(TheLocation, TheRotation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BugItWorker", TheLocation, TheRotation);
}

void UManageCheatManager::ChangeSize(float F)
{
	Super::ChangeSize(F);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ChangeSize", F);
}

void UManageCheatManager::DamageTarget(float DamageAmount)
{
	Super::DamageTarget(DamageAmount);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DamageTarget", DamageAmount);
}

void UManageCheatManager::DebugCapsuleSweep()
{
	Super::DebugCapsuleSweep();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweep");
}

void UManageCheatManager::DebugCapsuleSweepCapture()
{
	Super::DebugCapsuleSweepCapture();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepCapture");
}

void UManageCheatManager::DebugCapsuleSweepChannel(ECollisionChannel Channel)
{
	Super::DebugCapsuleSweepChannel(Channel);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepChannel", Channel);
}

void UManageCheatManager::DebugCapsuleSweepClear()
{
	Super::DebugCapsuleSweepClear();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepClear");
}

void UManageCheatManager::DebugCapsuleSweepComplex(bool bTraceComplex)
{
	Super::DebugCapsuleSweepComplex(bTraceComplex);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepComplex", bTraceComplex);
}

void UManageCheatManager::DebugCapsuleSweepPawn()
{
	Super::DebugCapsuleSweepPawn();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepPawn");
}

void UManageCheatManager::DebugCapsuleSweepSize(float HalfHeight, float Radius)
{
	Super::DebugCapsuleSweepSize(HalfHeight, Radius);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DebugCapsuleSweepSize", HalfHeight, Radius);
}

void UManageCheatManager::DestroyAllPawnsExceptTarget()
{
	Super::DestroyAllPawnsExceptTarget();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyAllPawnsExceptTarget");
}

void UManageCheatManager::DestroyTarget()
{
	Super::DestroyTarget();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyTarget");
}

void UManageCheatManager::DisableDebugCamera()
{
	Super::DisableDebugCamera();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DisableDebugCamera");
}

void UManageCheatManager::DumpChatState()
{
	Super::DumpChatState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DumpChatState");
}

void UManageCheatManager::DumpOnlineSessionState()
{
	Super::DumpOnlineSessionState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DumpOnlineSessionState");
}

void UManageCheatManager::DumpPartyState()
{
	Super::DumpPartyState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DumpPartyState");
}

void UManageCheatManager::DumpVoiceMutingState()
{
	Super::DumpVoiceMutingState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DumpVoiceMutingState");
}

void UManageCheatManager::EnableDebugCamera()
{
	Super::EnableDebugCamera();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "EnableDebugCamera");
}

void UManageCheatManager::FlushLog()
{
	Super::FlushLog();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FlushLog");
}

void UManageCheatManager::Fly()
{
	Super::Fly();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Fly");
}

void UManageCheatManager::FreezeFrame(float Delay)
{
	Super::FreezeFrame(Delay);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FreezeFrame", Delay);
}

void UManageCheatManager::Ghost()
{
	Super::Ghost();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Ghost");
}

void UManageCheatManager::God()
{
	Super::God();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "God");
}

void UManageCheatManager::InitCheatManager()
{
	Super::InitCheatManager();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InitCheatManager");
}

void UManageCheatManager::InvertMouse()
{
	Super::InvertMouse();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "InvertMouse");
}

void UManageCheatManager::LogLoc()
{
	Super::LogLoc();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LogLoc");
}

void UManageCheatManager::LogOutBugItGoToLogFile(const FString& InScreenShotDesc, const FString& InScreenShotPath, const FString& InGoString, const FString& InLocString)
{
	Super::LogOutBugItGoToLogFile(InScreenShotDesc, InScreenShotPath, InGoString, InLocString);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "LogOutBugItGoToLogFile", InScreenShotDesc, InScreenShotPath, InGoString, InLocString);
}

void UManageCheatManager::OnlyLoadLevel(FName PackageName)
{
	Super::OnlyLoadLevel(PackageName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnlyLoadLevel", PackageName);
}

void UManageCheatManager::PlayersOnly()
{
	Super::PlayersOnly();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PlayersOnly");
}

void UManageCheatManager::ServerToggleAILogging()
{
	Super::ServerToggleAILogging();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ServerToggleAILogging");
}

void UManageCheatManager::SetLevelStreamingStatus(FName PackageName, bool bShouldBeLoaded, bool bShouldBeVisible)
{
	Super::SetLevelStreamingStatus(PackageName, bShouldBeLoaded, bShouldBeVisible);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetLevelStreamingStatus", PackageName, bShouldBeLoaded, bShouldBeVisible);
}

void UManageCheatManager::SetMouseSensitivityToDefault()
{
	Super::SetMouseSensitivityToDefault();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetMouseSensitivityToDefault");
}

void UManageCheatManager::Slomo(float NewTimeDilation)
{
	Super::Slomo(NewTimeDilation);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Slomo", NewTimeDilation);
}

void UManageCheatManager::StreamLevelIn(FName PackageName)
{
	Super::StreamLevelIn(PackageName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StreamLevelIn", PackageName);
}

void UManageCheatManager::StreamLevelOut(FName PackageName)
{
	Super::StreamLevelOut(PackageName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "StreamLevelOut", PackageName);
}

void UManageCheatManager::Summon(const FString& ClassName)
{
	Super::Summon(ClassName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Summon", ClassName);
}

void UManageCheatManager::Teleport()
{
	Super::Teleport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Teleport");
}

void UManageCheatManager::TestCollisionDistance()
{
	Super::TestCollisionDistance();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TestCollisionDistance");
}

void UManageCheatManager::ToggleAILogging()
{
	Super::ToggleAILogging();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleAILogging");
}

void UManageCheatManager::ToggleDebugCamera()
{
	Super::ToggleDebugCamera();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ToggleDebugCamera");
}

void UManageCheatManager::ViewActor(FName ActorName)
{
	Super::ViewActor(ActorName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ViewActor", ActorName);
}

void UManageCheatManager::ViewPlayer(const FString& S)
{
	Super::ViewPlayer(S);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ViewPlayer", S);
}

void UManageCheatManager::ViewSelf()
{
	Super::ViewSelf();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ViewSelf");
}

void UManageCheatManager::Walk()
{
	Super::Walk();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Walk");
}

void UManageCheatManager::BeginDestroy()
{
	Super::BeginDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "BeginDestroy");
}

void UManageCheatManager::FinishDestroy()
{
	Super::FinishDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FinishDestroy");
}

void UManageCheatManager::MarkAsEditorOnlySubobject()
{
	Super::MarkAsEditorOnlySubobject();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "MarkAsEditorOnlySubobject");
}

void UManageCheatManager::OverridePerObjectConfigSection(FString& SectionName)
{
	Super::OverridePerObjectConfigSection(SectionName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OverridePerObjectConfigSection", SectionName);
}

void UManageCheatManager::PostCDOContruct()
{
	Super::PostCDOContruct();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostCDOContruct");
}

void UManageCheatManager::PostEditImport()
{
	Super::PostEditImport();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostEditImport");
}

void UManageCheatManager::PostInitProperties()
{
	Super::PostInitProperties();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostInitProperties");
}

void UManageCheatManager::PostLoad()
{
	Super::PostLoad();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostLoad");
}

void UManageCheatManager::PostNetReceive()
{
	Super::PostNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostNetReceive");
}

void UManageCheatManager::PostRename(UObject* OldOuter, const FName OldName)
{
	Super::PostRename(OldOuter, OldName);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRename", OldOuter, OldName);
}

void UManageCheatManager::PostRepNotifies()
{
	Super::PostRepNotifies();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostRepNotifies");
}

void UManageCheatManager::PostSaveRoot(bool bCleanupIsRequired)
{
	Super::PostSaveRoot(bCleanupIsRequired);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PostSaveRoot", bCleanupIsRequired);
}

void UManageCheatManager::PreDestroyFromReplication()
{
	Super::PreDestroyFromReplication();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreDestroyFromReplication");
}

void UManageCheatManager::PreNetReceive()
{
	Super::PreNetReceive();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PreNetReceive");
}

void UManageCheatManager::ShutdownAfterError()
{
	Super::ShutdownAfterError();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAfterError");
}

void UManageCheatManager::CreateCluster()
{
	Super::CreateCluster();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "CreateCluster");
}

void UManageCheatManager::OnClusterMarkedAsPendingKill()
{
	Super::OnClusterMarkedAsPendingKill();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnClusterMarkedAsPendingKill");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
