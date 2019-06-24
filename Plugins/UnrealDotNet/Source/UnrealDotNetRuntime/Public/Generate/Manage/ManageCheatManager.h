#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageObject.h"
#include "TypeConvertor.h"
#include "Runtime/Engine/Classes/GameFramework/CheatManager.h"
#include "ManageCheatManager.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

UCLASS()
class UNREALDOTNETRUNTIME_API UManageCheatManager : public UCheatManager, public IManageObject
{
	GENERATED_BODY()
	
public:
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach() override;
	void SetManageType(const FDotnetTypeName& ManageType) override;
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void BugItGo(float X, float Y, float Z, float Pitch, float Yaw, float Roll) override;
	virtual void ChangeSize(float F) override;
	virtual void DamageTarget(float DamageAmount) override;
	virtual void DebugCapsuleSweep() override;
	virtual void DebugCapsuleSweepCapture() override;
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
	virtual void PlayersOnly() override;
	virtual void ServerToggleAILogging() override;
	virtual void SetMouseSensitivityToDefault() override;
	virtual void Slomo(float NewTimeDilation) override;
	virtual void Teleport() override;
	virtual void TestCollisionDistance() override;
	virtual void ToggleAILogging() override;
	virtual void ToggleDebugCamera() override;
	virtual void ViewSelf() override;
	virtual void Walk() override;
	virtual void BeginDestroy() override;
	virtual void FinishDestroy() override;
	virtual void MarkAsEditorOnlySubobject() override;
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
	
	void _Supper__BugItGo(float X, float Y, float Z, float Pitch, float Yaw, float Roll);
	void _Supper__ChangeSize(float F);
	void _Supper__DamageTarget(float DamageAmount);
	void _Supper__DebugCapsuleSweep();
	void _Supper__DebugCapsuleSweepCapture();
	void _Supper__DebugCapsuleSweepClear();
	void _Supper__DebugCapsuleSweepComplex(bool bTraceComplex);
	void _Supper__DebugCapsuleSweepPawn();
	void _Supper__DebugCapsuleSweepSize(float HalfHeight, float Radius);
	void _Supper__DestroyAllPawnsExceptTarget();
	void _Supper__DestroyTarget();
	void _Supper__DisableDebugCamera();
	void _Supper__DumpChatState();
	void _Supper__DumpOnlineSessionState();
	void _Supper__DumpPartyState();
	void _Supper__DumpVoiceMutingState();
	void _Supper__EnableDebugCamera();
	void _Supper__FlushLog();
	void _Supper__Fly();
	void _Supper__FreezeFrame(float Delay);
	void _Supper__Ghost();
	void _Supper__God();
	void _Supper__InitCheatManager();
	void _Supper__InvertMouse();
	void _Supper__LogLoc();
	void _Supper__PlayersOnly();
	void _Supper__ServerToggleAILogging();
	void _Supper__SetMouseSensitivityToDefault();
	void _Supper__Slomo(float NewTimeDilation);
	void _Supper__Teleport();
	void _Supper__TestCollisionDistance();
	void _Supper__ToggleAILogging();
	void _Supper__ToggleDebugCamera();
	void _Supper__ViewSelf();
	void _Supper__Walk();
	void _Supper__BeginDestroy();
	void _Supper__FinishDestroy();
	void _Supper__MarkAsEditorOnlySubobject();
	void _Supper__PostCDOContruct();
	void _Supper__PostEditImport();
	void _Supper__PostInitProperties();
	void _Supper__PostLoad();
	void _Supper__PostNetReceive();
	void _Supper__PostRepNotifies();
	void _Supper__PostSaveRoot(bool bCleanupIsRequired);
	void _Supper__PreDestroyFromReplication();
	void _Supper__PreNetReceive();
	void _Supper__ShutdownAfterError();
	void _Supper__CreateCluster();
	void _Supper__OnClusterMarkedAsPendingKill();
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
