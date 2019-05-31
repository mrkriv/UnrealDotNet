#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/CheatManager.h"
#include "ManageCheatManager.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

UCLASS()
class UNREALDOTNETRUNTIME_API UManageCheatManager : public UCheatManager, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void BugIt(const FString& ScreenShotDescription) override;
	virtual void BugItGo(float X, float Y, float Z, float Pitch, float Yaw, float Roll) override;
	virtual void BugItGoString(const FString& TheLocation, const FString& TheRotation) override;
	virtual void BugItStringCreator(FVector ViewLocation, FRotator ViewRotation, FString& GoString, FString& LocString) override;
	virtual void BugItWorker(FVector TheLocation, FRotator TheRotation) override;
	virtual void ChangeSize(float F) override;
	virtual void DamageTarget(float DamageAmount) override;
	virtual void DebugCapsuleSweep() override;
	virtual void DebugCapsuleSweepCapture() override;
	virtual void DebugCapsuleSweepChannel(ECollisionChannel Channel) override;
	virtual void DebugCapsuleSweepClear() override;
	virtual void DebugCapsuleSweepComplex(bool bTraceComplex) override;
	virtual void DebugCapsuleSweepPawn() override;
	virtual void DebugCapsuleSweepSize(float HalfHeight, float Radius) override;
	virtual void DestroyAllPawnsExceptTarget() override;
	virtual void DestroyTarget() override;
	virtual void DisableDebugCamera() override;
	virtual void DumpChatState() override;
	virtual void DumpOnlineSessionState() override;
	virtual void DumpPartyState() override;
	virtual void DumpVoiceMutingState() override;
	virtual void EnableDebugCamera() override;
	virtual void FlushLog() override;
	virtual void Fly() override;
	virtual void FreezeFrame(float Delay) override;
	virtual void Ghost() override;
	virtual void God() override;
	virtual void InitCheatManager() override;
	virtual void InvertMouse() override;
	virtual void LogLoc() override;
	virtual void LogOutBugItGoToLogFile(const FString& InScreenShotDesc, const FString& InScreenShotPath, const FString& InGoString, const FString& InLocString) override;
	virtual void OnlyLoadLevel(FName PackageName) override;
	virtual void PlayersOnly() override;
	virtual void ServerToggleAILogging() override;
	virtual void SetLevelStreamingStatus(FName PackageName, bool bShouldBeLoaded, bool bShouldBeVisible) override;
	virtual void SetMouseSensitivityToDefault() override;
	virtual void Slomo(float NewTimeDilation) override;
	virtual void StreamLevelIn(FName PackageName) override;
	virtual void StreamLevelOut(FName PackageName) override;
	virtual void Summon(const FString& ClassName) override;
	virtual void Teleport() override;
	virtual void TestCollisionDistance() override;
	virtual void ToggleAILogging() override;
	virtual void ToggleDebugCamera() override;
	virtual void ViewActor(FName ActorName) override;
	virtual void ViewPlayer(const FString& S) override;
	virtual void ViewSelf() override;
	virtual void Walk() override;
	virtual void BeginDestroy() override;
	virtual void FinishDestroy() override;
	virtual void MarkAsEditorOnlySubobject() override;
	virtual void OverridePerObjectConfigSection(FString& SectionName) override;
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRename(UObject* OldOuter, const FName OldName) override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
