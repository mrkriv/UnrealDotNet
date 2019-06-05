#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePawn.h"
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

class E_PROTECTED_WRAP_APawn : protected APawn
{
public:
	UInputComponent* CreatePlayerInputComponent_WRAP()
	{
		return CreatePlayerInputComponent();
	}

	void DestroyPlayerInputComponent_WRAP()
	{
		DestroyPlayerInputComponent();
	}

	void SetupPlayerInputComponent_WRAP(UInputComponent* PlayerInputComponent)
	{
		SetupPlayerInputComponent(PlayerInputComponent);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_APawn_AllowedYawError_GET(APawn* Ptr) { return Ptr->AllowedYawError; }
	DOTNET_EXPORT void E_PROP_APawn_AllowedYawError_SET(APawn* Ptr, float Value) { Ptr->AllowedYawError = Value; }
	
	DOTNET_EXPORT auto E_PROP_APawn_AutoPossessAI_GET(APawn* Ptr) { return Ptr->AutoPossessAI; }
	DOTNET_EXPORT void E_PROP_APawn_AutoPossessAI_SET(APawn* Ptr, EAutoPossessAI Value) { Ptr->AutoPossessAI = Value; }
	
	DOTNET_EXPORT auto E_PROP_APawn_BaseEyeHeight_GET(APawn* Ptr) { return Ptr->BaseEyeHeight; }
	DOTNET_EXPORT void E_PROP_APawn_BaseEyeHeight_SET(APawn* Ptr, float Value) { Ptr->BaseEyeHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_APawn_BlendedReplayViewPitch_GET(APawn* Ptr) { return Ptr->BlendedReplayViewPitch; }
	DOTNET_EXPORT void E_PROP_APawn_BlendedReplayViewPitch_SET(APawn* Ptr, float Value) { Ptr->BlendedReplayViewPitch = Value; }
	
	DOTNET_EXPORT auto E_PROP_APawn_Controller_GET(APawn* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Controller); }
	DOTNET_EXPORT void E_PROP_APawn_Controller_SET(APawn* Ptr, AController* Value) { Ptr->Controller = Value; }
	
	DOTNET_EXPORT auto E_PROP_APawn_LastHitBy_GET(APawn* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->LastHitBy); }
	DOTNET_EXPORT void E_PROP_APawn_LastHitBy_SET(APawn* Ptr, AController* Value) { Ptr->LastHitBy = Value; }
	
	DOTNET_EXPORT auto E_PROP_APawn_RemoteViewPitch_GET(APawn* Ptr) { return Ptr->RemoteViewPitch; }
	DOTNET_EXPORT void E_PROP_APawn_RemoteViewPitch_SET(APawn* Ptr, uint8 Value) { Ptr->RemoteViewPitch = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_APawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<APawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_APawn_AddControllerPitchInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT auto E_APawn_AddControllerRollInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT auto E_APawn_AddControllerYawInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT auto E_APawn_AddMovementInput(APawn* Self, INT_PTR WorldDirection, float ScaleValue, bool bForce)
	{
		auto _p0 = *(FVector*)WorldDirection;
		auto _p1 = ScaleValue;
		auto _p2 = bForce;
		Self->AddMovementInput(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APawn_ConsumeMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->ConsumeMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_CreatePlayerInputComponent(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(((E_PROTECTED_WRAP_APawn*)Self)->CreatePlayerInputComponent_WRAP());
	}

	DOTNET_EXPORT auto E_APawn_DestroyPlayerInputComponent(APawn* Self)
	{
		((E_PROTECTED_WRAP_APawn*)Self)->DestroyPlayerInputComponent_WRAP();
	}

	DOTNET_EXPORT auto E_APawn_DetachFromControllerPendingDestroy(APawn* Self)
	{
		Self->DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT auto E_APawn_FaceRotation(APawn* Self, INT_PTR NewControlRotation, float DeltaTime)
	{
		auto _p0 = *(FRotator*)NewControlRotation;
		auto _p1 = DeltaTime;
		Self->FaceRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_GetBaseAimRotation(APawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetBaseAimRotation());
	}

	DOTNET_EXPORT auto E_APawn_GetController(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetController());
	}

	DOTNET_EXPORT auto E_APawn_GetControlRotation(APawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetControlRotation());
	}

	DOTNET_EXPORT auto E_APawn_GetDefaultHalfHeight(APawn* Self)
	{
		return Self->GetDefaultHalfHeight();
	}

	DOTNET_EXPORT auto E_APawn_GetGravityDirection(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetGravityDirection());
	}

	DOTNET_EXPORT auto E_APawn_GetLastMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetLastMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_GetMovementBase(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementBase());
	}

	DOTNET_EXPORT auto E_APawn_GetMovementBaseActor(APawn* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementBaseActor(_p0));
	}

	DOTNET_EXPORT auto E_APawn_GetMovementComponent(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementComponent());
	}

	DOTNET_EXPORT auto E_APawn_GetPawnNoiseEmitterComponent(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawnNoiseEmitterComponent());
	}

	DOTNET_EXPORT auto E_APawn_GetPawnViewLocation(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetPawnViewLocation());
	}

	DOTNET_EXPORT auto E_APawn_GetPendingMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->GetPendingMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_GetPlayerState(APawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPlayerState());
	}

	DOTNET_EXPORT auto E_APawn_GetViewRotation(APawn* Self)
	{
		return (INT_PTR) new FRotator(Self->GetViewRotation());
	}

	DOTNET_EXPORT auto E_APawn_InFreeCam(APawn* Self)
	{
		return Self->InFreeCam();
	}

	DOTNET_EXPORT auto E_APawn_InputEnabled(APawn* Self)
	{
		return Self->InputEnabled();
	}

	DOTNET_EXPORT auto E_APawn_Internal_AddMovementInput(APawn* Self, INT_PTR WorldAccel, bool bForce)
	{
		auto _p0 = *(FVector*)WorldAccel;
		auto _p1 = bForce;
		Self->Internal_AddMovementInput(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_Internal_ConsumeMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->Internal_ConsumeMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_Internal_GetLastMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->Internal_GetLastMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_Internal_GetPendingMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->Internal_GetPendingMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_IsBotControlled(APawn* Self)
	{
		return Self->IsBotControlled();
	}

	DOTNET_EXPORT auto E_APawn_IsControlled(APawn* Self)
	{
		return Self->IsControlled();
	}

	DOTNET_EXPORT auto E_APawn_IsLocallyControlled(APawn* Self)
	{
		return Self->IsLocallyControlled();
	}

	DOTNET_EXPORT auto E_APawn_IsMoveInputIgnored(APawn* Self)
	{
		return Self->IsMoveInputIgnored();
	}

	DOTNET_EXPORT auto E_APawn_IsPlayerControlled(APawn* Self)
	{
		return Self->IsPlayerControlled();
	}

	DOTNET_EXPORT auto E_APawn_K2_GetMovementInputVector(APawn* Self)
	{
		return (INT_PTR) new FVector(Self->K2_GetMovementInputVector());
	}

	DOTNET_EXPORT auto E_APawn_LaunchPawn(APawn* Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		Self->LaunchPawn(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_APawn_MoveIgnoreActorAdd(APawn* Self, AActor* ActorToIgnore)
	{
		auto _p0 = ActorToIgnore;
		Self->MoveIgnoreActorAdd(_p0);
	}

	DOTNET_EXPORT auto E_APawn_MoveIgnoreActorRemove(APawn* Self, AActor* ActorToIgnore)
	{
		auto _p0 = ActorToIgnore;
		Self->MoveIgnoreActorRemove(_p0);
	}

	DOTNET_EXPORT auto E_APawn_OnRep_Controller(APawn* Self)
	{
		Self->OnRep_Controller();
	}

	DOTNET_EXPORT auto E_APawn_OnRep_PlayerState(APawn* Self)
	{
		Self->OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E_APawn_PawnClientRestart(APawn* Self)
	{
		Self->PawnClientRestart();
	}

	DOTNET_EXPORT auto E_APawn_PawnMakeNoise(APawn* Self, float Loudness, INT_PTR NoiseLocation, bool bUseNoiseMakerLocation, AActor* NoiseMaker)
	{
		auto _p0 = Loudness;
		auto _p1 = *(FVector*)NoiseLocation;
		auto _p2 = bUseNoiseMakerLocation;
		auto _p3 = NoiseMaker;
		Self->PawnMakeNoise(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APawn_PawnStartFire(APawn* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		Self->PawnStartFire(_p0);
	}

	DOTNET_EXPORT auto E_APawn_PossessedBy(APawn* Self, AController* NewController)
	{
		auto _p0 = NewController;
		Self->PossessedBy(_p0);
	}

	DOTNET_EXPORT auto E_APawn_ReachedDesiredRotation(APawn* Self)
	{
		return Self->ReachedDesiredRotation();
	}

	DOTNET_EXPORT auto E_APawn_RecalculateBaseEyeHeight(APawn* Self)
	{
		Self->RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT auto E_APawn_ReceivePossessed(APawn* Self, AController* NewController)
	{
		auto _p0 = NewController;
		Self->ReceivePossessed(_p0);
	}

	DOTNET_EXPORT auto E_APawn_ReceiveUnpossessed(APawn* Self, AController* OldController)
	{
		auto _p0 = OldController;
		Self->ReceiveUnpossessed(_p0);
	}

	DOTNET_EXPORT auto E_APawn_Restart(APawn* Self)
	{
		Self->Restart();
	}

	DOTNET_EXPORT auto E_APawn_SetCanAffectNavigationGeneration(APawn* Self, bool bNewValue, bool bForceUpdate)
	{
		auto _p0 = bNewValue;
		auto _p1 = bForceUpdate;
		Self->SetCanAffectNavigationGeneration(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APawn_SetPlayerDefaults(APawn* Self)
	{
		Self->SetPlayerDefaults();
	}

	DOTNET_EXPORT auto E_APawn_SetPlayerState(APawn* Self, APlayerState* NewPlayerState)
	{
		auto _p0 = NewPlayerState;
		Self->SetPlayerState(_p0);
	}

	DOTNET_EXPORT auto E_APawn_SetRemoteViewPitch(APawn* Self, float NewRemoteViewPitch)
	{
		auto _p0 = NewRemoteViewPitch;
		Self->SetRemoteViewPitch(_p0);
	}

	DOTNET_EXPORT auto E_APawn_SetupPlayerInputComponent(APawn* Self, UInputComponent* PlayerInputComponent)
	{
		auto _p0 = PlayerInputComponent;
		((E_PROTECTED_WRAP_APawn*)Self)->SetupPlayerInputComponent_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_APawn_ShouldTakeDamage(APawn* Self, float Damage, INT_PTR DamageEvent, AController* EventInstigator, AActor* DamageCauser)
	{
		auto _p0 = Damage;
		auto& _p1 = *(FDamageEvent*)DamageEvent;
		auto _p2 = EventInstigator;
		auto _p3 = DamageCauser;
		return Self->ShouldTakeDamage(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_APawn_SpawnDefaultController(APawn* Self)
	{
		Self->SpawnDefaultController();
	}

	DOTNET_EXPORT auto E_APawn_TurnOff(APawn* Self)
	{
		Self->TurnOff();
	}

	DOTNET_EXPORT auto E_APawn_UnPossessed(APawn* Self)
	{
		Self->UnPossessed();
	}

	DOTNET_EXPORT auto E_APawn_UpdateNavAgent(APawn* Self)
	{
		Self->UpdateNavAgent();
	}

	DOTNET_EXPORT auto E_APawn_UpdateNavigationRelevance(APawn* Self)
	{
		Self->UpdateNavigationRelevance();
	}

	DOTNET_EXPORT auto E__Supper__APawn_AddControllerPitchInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManagePawn*)Self)->_Supper__AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_AddControllerRollInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManagePawn*)Self)->_Supper__AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_AddControllerYawInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManagePawn*)Self)->_Supper__AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_DestroyPlayerInputComponent(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__DestroyPlayerInputComponent();
	}

	DOTNET_EXPORT auto E__Supper__APawn_DetachFromControllerPendingDestroy(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT auto E__Supper__APawn_OnRep_Controller(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__OnRep_Controller();
	}

	DOTNET_EXPORT auto E__Supper__APawn_OnRep_PlayerState(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PawnClientRestart(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__PawnClientRestart();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PawnStartFire(APawn* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		((AManagePawn*)Self)->_Supper__PawnStartFire(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_RecalculateBaseEyeHeight(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT auto E__Supper__APawn_Restart(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__Restart();
	}

	DOTNET_EXPORT auto E__Supper__APawn_SetPlayerDefaults(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__SetPlayerDefaults();
	}

	DOTNET_EXPORT auto E__Supper__APawn_SpawnDefaultController(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__SpawnDefaultController();
	}

	DOTNET_EXPORT auto E__Supper__APawn_TurnOff(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__TurnOff();
	}

	DOTNET_EXPORT auto E__Supper__APawn_UnPossessed(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__UnPossessed();
	}

	DOTNET_EXPORT auto E__Supper__APawn_UpdateNavigationRelevance(APawn* Self)
	{
		((AManagePawn*)Self)->_Supper__UpdateNavigationRelevance();
	}

	DOTNET_EXPORT auto E__Supper__APawn_BeginPlay(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__APawn_ClearCrossLevelReferences(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__APawn_Destroyed(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__APawn_ForceNetRelevant(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__APawn_ForceNetUpdate(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__APawn_GatherCurrentMovement(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__APawn_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManagePawn*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_K2_DestroyActor(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__APawn_LifeSpanExpired(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__APawn_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__APawn_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__APawn_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__APawn_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__APawn_OnRep_Instigator(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__APawn_OnRep_Owner(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__APawn_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__APawn_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__APawn_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManagePawn*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_OutsideWorldBounds(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostActorCreated(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostInitializeComponents(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostNetInit(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostNetReceivePhysicState(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostNetReceiveRole(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostRegisterAllComponents(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostUnregisterAllComponents(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PreInitializeComponents(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PreRegisterAllComponents(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManagePawn*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__APawn_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManagePawn*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_RegisterAllComponents(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APawn_ReregisterAllComponents(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APawn_RerunConstructionScripts(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__APawn_Reset(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__APawn_RewindForReplay(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__APawn_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManagePawn*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManagePawn*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManagePawn*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_TearOff(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__APawn_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManagePawn*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManagePawn*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_TornOff(AActor* Self)
	{
		((AManagePawn*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__APawn_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManagePawn*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_BeginDestroy(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__APawn_FinishDestroy(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__APawn_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostCDOContruct(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostEditImport(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostInitProperties(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostLoad(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostNetReceive(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostRepNotifies(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManagePawn*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APawn_PreDestroyFromReplication(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__APawn_PreNetReceive(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__APawn_ShutdownAfterError(UObject* Self)
	{
		((AManagePawn*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__APawn_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManagePawn*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__APawn_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManagePawn*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
