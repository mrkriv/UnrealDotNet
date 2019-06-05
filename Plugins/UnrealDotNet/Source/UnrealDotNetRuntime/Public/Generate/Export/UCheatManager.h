#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCheatManager.h"
#include "Runtime/Engine/Classes/GameFramework/CheatManager.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

class E_PROTECTED_WRAP_UCheatManager : protected UCheatManager
{
public:
	void DisableDebugCamera_WRAP()
	{
		DisableDebugCamera();
	}

	void EnableDebugCamera_WRAP()
	{
		EnableDebugCamera();
	}

	AActor* GetTarget_WRAP(APlayerController* PlayerController, FHitResult& OutHit)
	{
		return GetTarget(PlayerController, OutHit);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UCheatManager_bDebugCapsuleSweepPawn_GET() { return UCheatManager::bDebugCapsuleSweepPawn; }
	
	DOTNET_EXPORT auto E_PROP_UCheatManager_CurrentTraceIndex_GET(UCheatManager* Ptr) { return Ptr->CurrentTraceIndex; }
	DOTNET_EXPORT void E_PROP_UCheatManager_CurrentTraceIndex_SET(UCheatManager* Ptr, int32 Value) { Ptr->CurrentTraceIndex = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCheatManager_CurrentTracePawnIndex_GET(UCheatManager* Ptr) { return Ptr->CurrentTracePawnIndex; }
	DOTNET_EXPORT void E_PROP_UCheatManager_CurrentTracePawnIndex_SET(UCheatManager* Ptr, int32 Value) { Ptr->CurrentTracePawnIndex = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCheatManager_DebugCapsuleHalfHeight_GET(UCheatManager* Ptr) { return Ptr->DebugCapsuleHalfHeight; }
	DOTNET_EXPORT void E_PROP_UCheatManager_DebugCapsuleHalfHeight_SET(UCheatManager* Ptr, float Value) { Ptr->DebugCapsuleHalfHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCheatManager_DebugCapsuleRadius_GET(UCheatManager* Ptr) { return Ptr->DebugCapsuleRadius; }
	DOTNET_EXPORT void E_PROP_UCheatManager_DebugCapsuleRadius_SET(UCheatManager* Ptr, float Value) { Ptr->DebugCapsuleRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCheatManager_DebugTraceDistance_GET(UCheatManager* Ptr) { return Ptr->DebugTraceDistance; }
	DOTNET_EXPORT void E_PROP_UCheatManager_DebugTraceDistance_SET(UCheatManager* Ptr, float Value) { Ptr->DebugTraceDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCheatManager_DebugTraceDrawNormalLength_GET(UCheatManager* Ptr) { return Ptr->DebugTraceDrawNormalLength; }
	DOTNET_EXPORT void E_PROP_UCheatManager_DebugTraceDrawNormalLength_SET(UCheatManager* Ptr, float Value) { Ptr->DebugTraceDrawNormalLength = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCheatManager(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCheatManager>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCheatManager_AddCapsuleSweepDebugInfo(UCheatManager* Self, INT_PTR LineTraceStart, INT_PTR LineTraceEnd, INT_PTR HitImpactLocation, INT_PTR HitNormal, INT_PTR HitImpactNormal, INT_PTR HitLocation, float CapsuleHalfheight, float CapsuleRadius, bool bTracePawn, bool bInsideOfObject)
	{
		auto& _p0 = *(FVector*)LineTraceStart;
		auto& _p1 = *(FVector*)LineTraceEnd;
		auto& _p2 = *(FVector*)HitImpactLocation;
		auto& _p3 = *(FVector*)HitNormal;
		auto& _p4 = *(FVector*)HitImpactNormal;
		auto& _p5 = *(FVector*)HitLocation;
		auto _p6 = CapsuleHalfheight;
		auto _p7 = CapsuleRadius;
		auto _p8 = bTracePawn;
		auto _p9 = bInsideOfObject;
		Self->AddCapsuleSweepDebugInfo(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7, _p8, _p9);
	}

	DOTNET_EXPORT auto E_UCheatManager_BugIt(UCheatManager* Self, char* ScreenShotDescription)
	{
		auto _p0 = ConvertFromManage_FString(ScreenShotDescription);
		Self->BugIt(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_BugItGo(UCheatManager* Self, float X, float Y, float Z, float Pitch, float Yaw, float Roll)
	{
		auto _p0 = X;
		auto _p1 = Y;
		auto _p2 = Z;
		auto _p3 = Pitch;
		auto _p4 = Yaw;
		auto _p5 = Roll;
		Self->BugItGo(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UCheatManager_BugItGoString(UCheatManager* Self, char* TheLocation, char* TheRotation)
	{
		auto _p0 = ConvertFromManage_FString(TheLocation);
		auto _p1 = ConvertFromManage_FString(TheRotation);
		Self->BugItGoString(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCheatManager_BugItStringCreator(UCheatManager* Self, INT_PTR ViewLocation, INT_PTR ViewRotation, char* GoString, char* LocString)
	{
		auto _p0 = *(FVector*)ViewLocation;
		auto _p1 = *(FRotator*)ViewRotation;
		auto _p2 = ConvertFromManage_FString(GoString);
		auto _p3 = ConvertFromManage_FString(LocString);
		Self->BugItStringCreator(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UCheatManager_BugItWorker(UCheatManager* Self, INT_PTR TheLocation, INT_PTR TheRotation)
	{
		auto _p0 = *(FVector*)TheLocation;
		auto _p1 = *(FRotator*)TheRotation;
		Self->BugItWorker(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCheatManager_ChangeSize(UCheatManager* Self, float F)
	{
		auto _p0 = F;
		Self->ChangeSize(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_CheatScript(UCheatManager* Self, char* ScriptName)
	{
		auto _p0 = ConvertFromManage_FString(ScriptName);
		Self->CheatScript(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_DamageTarget(UCheatManager* Self, float DamageAmount)
	{
		auto _p0 = DamageAmount;
		Self->DamageTarget(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_DebugCapsuleSweep(UCheatManager* Self)
	{
		Self->DebugCapsuleSweep();
	}

	DOTNET_EXPORT auto E_UCheatManager_DebugCapsuleSweepCapture(UCheatManager* Self)
	{
		Self->DebugCapsuleSweepCapture();
	}

	DOTNET_EXPORT auto E_UCheatManager_DebugCapsuleSweepChannel(UCheatManager* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->DebugCapsuleSweepChannel(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_DebugCapsuleSweepClear(UCheatManager* Self)
	{
		Self->DebugCapsuleSweepClear();
	}

	DOTNET_EXPORT auto E_UCheatManager_DebugCapsuleSweepComplex(UCheatManager* Self, bool bTraceComplex)
	{
		auto _p0 = bTraceComplex;
		Self->DebugCapsuleSweepComplex(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_DebugCapsuleSweepPawn(UCheatManager* Self)
	{
		Self->DebugCapsuleSweepPawn();
	}

	DOTNET_EXPORT auto E_UCheatManager_DebugCapsuleSweepSize(UCheatManager* Self, float HalfHeight, float Radius)
	{
		auto _p0 = HalfHeight;
		auto _p1 = Radius;
		Self->DebugCapsuleSweepSize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCheatManager_DestroyAllPawnsExceptTarget(UCheatManager* Self)
	{
		Self->DestroyAllPawnsExceptTarget();
	}

	DOTNET_EXPORT auto E_UCheatManager_DestroyServerStatReplicator(UCheatManager* Self)
	{
		Self->DestroyServerStatReplicator();
	}

	DOTNET_EXPORT auto E_UCheatManager_DestroyTarget(UCheatManager* Self)
	{
		Self->DestroyTarget();
	}

	DOTNET_EXPORT auto E_UCheatManager_DisableDebugCamera(UCheatManager* Self)
	{
		((E_PROTECTED_WRAP_UCheatManager*)Self)->DisableDebugCamera_WRAP();
	}

	DOTNET_EXPORT auto E_UCheatManager_DumpChatState(UCheatManager* Self)
	{
		Self->DumpChatState();
	}

	DOTNET_EXPORT auto E_UCheatManager_DumpOnlineSessionState(UCheatManager* Self)
	{
		Self->DumpOnlineSessionState();
	}

	DOTNET_EXPORT auto E_UCheatManager_DumpPartyState(UCheatManager* Self)
	{
		Self->DumpPartyState();
	}

	DOTNET_EXPORT auto E_UCheatManager_DumpVoiceMutingState(UCheatManager* Self)
	{
		Self->DumpVoiceMutingState();
	}

	DOTNET_EXPORT auto E_UCheatManager_EnableDebugCamera(UCheatManager* Self)
	{
		((E_PROTECTED_WRAP_UCheatManager*)Self)->EnableDebugCamera_WRAP();
	}

	DOTNET_EXPORT auto E_UCheatManager_FlushLog(UCheatManager* Self)
	{
		Self->FlushLog();
	}

	DOTNET_EXPORT auto E_UCheatManager_Fly(UCheatManager* Self)
	{
		Self->Fly();
	}

	DOTNET_EXPORT auto E_UCheatManager_FreezeFrame(UCheatManager* Self, float Delay)
	{
		auto _p0 = Delay;
		Self->FreezeFrame(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_GetTarget(UCheatManager* Self, APlayerController* PlayerController, INT_PTR OutHit)
	{
		auto _p0 = PlayerController;
		auto& _p1 = *(FHitResult*)OutHit;
		return ConvertToManage_ObjectPointerDescription(((E_PROTECTED_WRAP_UCheatManager*)Self)->GetTarget_WRAP(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UCheatManager_Ghost(UCheatManager* Self)
	{
		Self->Ghost();
	}

	DOTNET_EXPORT auto E_UCheatManager_God(UCheatManager* Self)
	{
		Self->God();
	}

	DOTNET_EXPORT auto E_UCheatManager_InitCheatManager(UCheatManager* Self)
	{
		Self->InitCheatManager();
	}

	DOTNET_EXPORT auto E_UCheatManager_InvertMouse(UCheatManager* Self)
	{
		Self->InvertMouse();
	}

	DOTNET_EXPORT auto E_UCheatManager_IsDebugCapsuleSweepPawnEnabled(UCheatManager* Self)
	{
		return Self->IsDebugCapsuleSweepPawnEnabled();
	}

	DOTNET_EXPORT auto E_UCheatManager_LogLoc(UCheatManager* Self)
	{
		Self->LogLoc();
	}

	DOTNET_EXPORT auto E_UCheatManager_LogOutBugItGoToLogFile(UCheatManager* Self, char* InScreenShotDesc, char* InScreenShotPath, char* InGoString, char* InLocString)
	{
		auto _p0 = ConvertFromManage_FString(InScreenShotDesc);
		auto _p1 = ConvertFromManage_FString(InScreenShotPath);
		auto _p2 = ConvertFromManage_FString(InGoString);
		auto _p3 = ConvertFromManage_FString(InLocString);
		Self->LogOutBugItGoToLogFile(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UCheatManager_OnlyLoadLevel(UCheatManager* Self, char* PackageName)
	{
		auto _p0 = ConvertFromManage_FName(PackageName);
		Self->OnlyLoadLevel(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_PlayersOnly(UCheatManager* Self)
	{
		Self->PlayersOnly();
	}

	DOTNET_EXPORT auto E_UCheatManager_ReceiveEndPlay(UCheatManager* Self)
	{
		Self->ReceiveEndPlay();
	}

	DOTNET_EXPORT auto E_UCheatManager_ReceiveInitCheatManager(UCheatManager* Self)
	{
		Self->ReceiveInitCheatManager();
	}

	DOTNET_EXPORT auto E_UCheatManager_ServerToggleAILogging(UCheatManager* Self)
	{
		Self->ServerToggleAILogging();
	}

	DOTNET_EXPORT auto E_UCheatManager_SetLevelStreamingStatus(UCheatManager* Self, char* PackageName, bool bShouldBeLoaded, bool bShouldBeVisible)
	{
		auto _p0 = ConvertFromManage_FName(PackageName);
		auto _p1 = bShouldBeLoaded;
		auto _p2 = bShouldBeVisible;
		Self->SetLevelStreamingStatus(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCheatManager_SetMouseSensitivityToDefault(UCheatManager* Self)
	{
		Self->SetMouseSensitivityToDefault();
	}

	DOTNET_EXPORT auto E_UCheatManager_SetWorldOrigin(UCheatManager* Self)
	{
		Self->SetWorldOrigin();
	}

	DOTNET_EXPORT auto E_UCheatManager_Slomo(UCheatManager* Self, float NewTimeDilation)
	{
		auto _p0 = NewTimeDilation;
		Self->Slomo(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_SpawnServerStatReplicator(UCheatManager* Self)
	{
		Self->SpawnServerStatReplicator();
	}

	DOTNET_EXPORT auto E_UCheatManager_StreamLevelIn(UCheatManager* Self, char* PackageName)
	{
		auto _p0 = ConvertFromManage_FName(PackageName);
		Self->StreamLevelIn(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_StreamLevelOut(UCheatManager* Self, char* PackageName)
	{
		auto _p0 = ConvertFromManage_FName(PackageName);
		Self->StreamLevelOut(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_Summon(UCheatManager* Self, char* ClassName)
	{
		auto _p0 = ConvertFromManage_FString(ClassName);
		Self->Summon(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_Teleport(UCheatManager* Self)
	{
		Self->Teleport();
	}

	DOTNET_EXPORT auto E_UCheatManager_TestCollisionDistance(UCheatManager* Self)
	{
		Self->TestCollisionDistance();
	}

	DOTNET_EXPORT auto E_UCheatManager_TickCollisionDebug(UCheatManager* Self)
	{
		Self->TickCollisionDebug();
	}

	DOTNET_EXPORT auto E_UCheatManager_ToggleAILogging(UCheatManager* Self)
	{
		Self->ToggleAILogging();
	}

	DOTNET_EXPORT auto E_UCheatManager_ToggleDebugCamera(UCheatManager* Self)
	{
		Self->ToggleDebugCamera();
	}

	DOTNET_EXPORT auto E_UCheatManager_ToggleServerStatReplicatorClientOverwrite(UCheatManager* Self)
	{
		Self->ToggleServerStatReplicatorClientOverwrite();
	}

	DOTNET_EXPORT auto E_UCheatManager_ToggleServerStatReplicatorUpdateStatNet(UCheatManager* Self)
	{
		Self->ToggleServerStatReplicatorUpdateStatNet();
	}

	DOTNET_EXPORT auto E_UCheatManager_UpdateSafeArea(UCheatManager* Self)
	{
		Self->UpdateSafeArea();
	}

	DOTNET_EXPORT auto E_UCheatManager_ViewActor(UCheatManager* Self, char* ActorName)
	{
		auto _p0 = ConvertFromManage_FName(ActorName);
		Self->ViewActor(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_ViewPlayer(UCheatManager* Self, char* S)
	{
		auto _p0 = ConvertFromManage_FString(S);
		Self->ViewPlayer(_p0);
	}

	DOTNET_EXPORT auto E_UCheatManager_ViewSelf(UCheatManager* Self)
	{
		Self->ViewSelf();
	}

	DOTNET_EXPORT auto E_UCheatManager_Walk(UCheatManager* Self)
	{
		Self->Walk();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_BugItGo(UCheatManager* Self, float X, float Y, float Z, float Pitch, float Yaw, float Roll)
	{
		auto _p0 = X;
		auto _p1 = Y;
		auto _p2 = Z;
		auto _p3 = Pitch;
		auto _p4 = Yaw;
		auto _p5 = Roll;
		((UManageCheatManager*)Self)->_Supper__BugItGo(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_ChangeSize(UCheatManager* Self, float F)
	{
		auto _p0 = F;
		((UManageCheatManager*)Self)->_Supper__ChangeSize(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DamageTarget(UCheatManager* Self, float DamageAmount)
	{
		auto _p0 = DamageAmount;
		((UManageCheatManager*)Self)->_Supper__DamageTarget(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DebugCapsuleSweep(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DebugCapsuleSweep();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DebugCapsuleSweepCapture(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DebugCapsuleSweepCapture();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DebugCapsuleSweepClear(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DebugCapsuleSweepClear();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DebugCapsuleSweepComplex(UCheatManager* Self, bool bTraceComplex)
	{
		auto _p0 = bTraceComplex;
		((UManageCheatManager*)Self)->_Supper__DebugCapsuleSweepComplex(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DebugCapsuleSweepPawn(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DebugCapsuleSweepPawn();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DebugCapsuleSweepSize(UCheatManager* Self, float HalfHeight, float Radius)
	{
		auto _p0 = HalfHeight;
		auto _p1 = Radius;
		((UManageCheatManager*)Self)->_Supper__DebugCapsuleSweepSize(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DestroyAllPawnsExceptTarget(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DestroyAllPawnsExceptTarget();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DestroyTarget(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DestroyTarget();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DisableDebugCamera(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DisableDebugCamera();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DumpChatState(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DumpChatState();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DumpOnlineSessionState(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DumpOnlineSessionState();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DumpPartyState(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DumpPartyState();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_DumpVoiceMutingState(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__DumpVoiceMutingState();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_EnableDebugCamera(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__EnableDebugCamera();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_FlushLog(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__FlushLog();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_Fly(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__Fly();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_FreezeFrame(UCheatManager* Self, float Delay)
	{
		auto _p0 = Delay;
		((UManageCheatManager*)Self)->_Supper__FreezeFrame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_Ghost(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__Ghost();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_God(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__God();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_InitCheatManager(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__InitCheatManager();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_InvertMouse(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__InvertMouse();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_LogLoc(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__LogLoc();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PlayersOnly(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__PlayersOnly();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_ServerToggleAILogging(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__ServerToggleAILogging();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_SetMouseSensitivityToDefault(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__SetMouseSensitivityToDefault();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_Slomo(UCheatManager* Self, float NewTimeDilation)
	{
		auto _p0 = NewTimeDilation;
		((UManageCheatManager*)Self)->_Supper__Slomo(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_Teleport(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__Teleport();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_TestCollisionDistance(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__TestCollisionDistance();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_ToggleAILogging(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__ToggleAILogging();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_ToggleDebugCamera(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__ToggleDebugCamera();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_ViewSelf(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__ViewSelf();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_Walk(UCheatManager* Self)
	{
		((UManageCheatManager*)Self)->_Supper__Walk();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_BeginDestroy(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_FinishDestroy(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PostCDOContruct(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PostEditImport(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PostInitProperties(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PostLoad(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PostNetReceive(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PostRepNotifies(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageCheatManager*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PreDestroyFromReplication(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_PreNetReceive(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_ShutdownAfterError(UObject* Self)
	{
		((UManageCheatManager*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageCheatManager*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UCheatManager_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageCheatManager*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
