#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/Character.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

class E_PROTECTED_WRAP_ACharacter : protected ACharacter
{
public:
	void BaseChange_WRAP()
	{
		BaseChange();
	}

	bool CanJumpInternal_WRAP()
	{
		return CanJumpInternal();
	}

	bool CanJumpInternal_Implementation_WRAP()
	{
		return CanJumpInternal_Implementation();
	}

	void DestroyPlayerInputComponent_WRAP()
	{
		DestroyPlayerInputComponent();
	}

	bool HasNetOwner_WRAP()
	{
		return HasNetOwner();
	}

	void OnRep_Owner_WRAP()
	{
		OnRep_Owner();
	}

	void RegisterActorTickFunctions_WRAP(bool bRegister)
	{
		RegisterActorTickFunctions(bRegister);
	}

}
;

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ACharacter_CapsuleComponentName_GET() { return ConvertToManage_StringWrapper(ACharacter::CapsuleComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_CharacterMovementComponentName_GET() { return ConvertToManage_StringWrapper(ACharacter::CharacterMovementComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_CrouchedEyeHeight_GET(ACharacter* Ptr) { return Ptr->CrouchedEyeHeight; }
	DOTNET_EXPORT void E_PROP_ACharacter_CrouchedEyeHeight_SET(ACharacter* Ptr, float Value) { Ptr->CrouchedEyeHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_JumpCurrentCount_GET(ACharacter* Ptr) { return Ptr->JumpCurrentCount; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpCurrentCount_SET(ACharacter* Ptr, int32 Value) { Ptr->JumpCurrentCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_JumpKeyHoldTime_GET(ACharacter* Ptr) { return Ptr->JumpKeyHoldTime; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpKeyHoldTime_SET(ACharacter* Ptr, float Value) { Ptr->JumpKeyHoldTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_JumpMaxCount_GET(ACharacter* Ptr) { return Ptr->JumpMaxCount; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpMaxCount_SET(ACharacter* Ptr, int32 Value) { Ptr->JumpMaxCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_JumpMaxHoldTime_GET(ACharacter* Ptr) { return Ptr->JumpMaxHoldTime; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpMaxHoldTime_SET(ACharacter* Ptr, float Value) { Ptr->JumpMaxHoldTime = Value; }
	
	DOTNET_EXPORT void E_EVENT_ADD_ACharacter_LandedDelegate(ACharacter* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_LandedDelegate";
		wrapper->SourceObject = Obj;
		Obj->LandedDelegate.AddDynamic(wrapper, &UManageEventSender::Wrapper_FLandedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_ACharacter_LandedDelegate(ACharacter* Obj)
	{
	}

	DOTNET_EXPORT auto E_PROP_ACharacter_MeshComponentName_GET() { return ConvertToManage_StringWrapper(ACharacter::MeshComponentName); }
	
	DOTNET_EXPORT void E_EVENT_ADD_ACharacter_MovementModeChangedDelegate(ACharacter* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_MovementModeChangedDelegate";
		wrapper->SourceObject = Obj;
		Obj->MovementModeChangedDelegate.AddDynamic(wrapper, &UManageEventSender::Wrapper_FMovementModeChangedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_ACharacter_MovementModeChangedDelegate(ACharacter* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_ACharacter_OnCharacterMovementUpdated(ACharacter* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnCharacterMovementUpdated";
		wrapper->SourceObject = Obj;
		Obj->OnCharacterMovementUpdated.AddDynamic(wrapper, &UManageEventSender::Wrapper_FCharacterMovementUpdatedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_ACharacter_OnCharacterMovementUpdated(ACharacter* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_ACharacter_OnReachedJumpApex(ACharacter* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnReachedJumpApex";
		wrapper->SourceObject = Obj;
		Obj->OnReachedJumpApex.AddDynamic(wrapper, &UManageEventSender::Wrapper_FCharacterReachedApexSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_ACharacter_OnReachedJumpApex(ACharacter* Obj)
	{
	}

	DOTNET_EXPORT auto E_PROP_ACharacter_RepRootMotion_GET(ACharacter* Ptr) { return (INT_PTR)&(Ptr->RepRootMotion); }
	DOTNET_EXPORT void E_PROP_ACharacter_RepRootMotion_SET(ACharacter* Ptr, INT_PTR Value) { Ptr->RepRootMotion = *(FRepRootMotionMontage*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ACharacter(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ACharacter>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ACharacter_ApplyDamageMomentum(ACharacter* Self, float DamageTaken, INT_PTR DamageEvent, APawn* PawnInstigator, AActor* DamageCauser)
	{
		auto _p0 = DamageTaken;
		auto _p1 = *(FDamageEvent*)DamageEvent;
		auto _p2 = PawnInstigator;
		auto _p3 = DamageCauser;
		Self->ApplyDamageMomentum(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ACharacter_BaseChange(ACharacter* Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->BaseChange_WRAP();
	}

	DOTNET_EXPORT auto E_ACharacter_BeginPlay(ACharacter* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_ACharacter_CacheInitialMeshOffset(ACharacter* Self, INT_PTR MeshRelativeLocation, INT_PTR MeshRelativeRotation)
	{
		auto _p0 = *(FVector*)MeshRelativeLocation;
		auto _p1 = *(FRotator*)MeshRelativeRotation;
		Self->CacheInitialMeshOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_CanCrouch(ACharacter* Self)
	{
		return Self->CanCrouch();
	}

	DOTNET_EXPORT auto E_ACharacter_CanJump(ACharacter* Self)
	{
		return Self->CanJump();
	}

	DOTNET_EXPORT auto E_ACharacter_CanJumpInternal(ACharacter* Self)
	{
		return ((E_PROTECTED_WRAP_ACharacter*)Self)->CanJumpInternal_WRAP();
	}

	DOTNET_EXPORT auto E_ACharacter_CanJumpInternal_Implementation(ACharacter* Self)
	{
		return ((E_PROTECTED_WRAP_ACharacter*)Self)->CanJumpInternal_Implementation_WRAP();
	}

	DOTNET_EXPORT auto E_ACharacter_CheckJumpInput(ACharacter* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		Self->CheckJumpInput(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_ClearCrossLevelReferences(ACharacter* Self)
	{
		Self->ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E_ACharacter_ClearJumpInput(ACharacter* Self)
	{
		Self->ClearJumpInput();
	}

	DOTNET_EXPORT auto E_ACharacter_ClientAckGoodMove(ACharacter* Self, float TimeStamp)
	{
		auto _p0 = TimeStamp;
		Self->ClientAckGoodMove(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_ClientAckGoodMove_Implementation(ACharacter* Self, float TimeStamp)
	{
		auto _p0 = TimeStamp;
		Self->ClientAckGoodMove_Implementation(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_ClientAdjustPosition(ACharacter* Self, float TimeStamp, INT_PTR NewLoc, INT_PTR NewVel, UPrimitiveComponent* NewBase, char* NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FVector*)NewLoc;
		auto _p2 = *(FVector*)NewVel;
		auto _p3 = NewBase;
		auto _p4 = ConvertFromManage_FName(NewBaseBoneName);
		auto _p5 = bHasBase;
		auto _p6 = bBaseRelativePosition;
		auto _p7 = ServerMovementMode;
		Self->ClientAdjustPosition(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_ACharacter_ClientAdjustPosition_Implementation(ACharacter* Self, float TimeStamp, INT_PTR NewLoc, INT_PTR NewVel, UPrimitiveComponent* NewBase, char* NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FVector*)NewLoc;
		auto _p2 = *(FVector*)NewVel;
		auto _p3 = NewBase;
		auto _p4 = ConvertFromManage_FName(NewBaseBoneName);
		auto _p5 = bHasBase;
		auto _p6 = bBaseRelativePosition;
		auto _p7 = ServerMovementMode;
		Self->ClientAdjustPosition_Implementation(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_ACharacter_ClientCheatFly(ACharacter* Self)
	{
		Self->ClientCheatFly();
	}

	DOTNET_EXPORT auto E_ACharacter_ClientCheatFly_Implementation(ACharacter* Self)
	{
		Self->ClientCheatFly_Implementation();
	}

	DOTNET_EXPORT auto E_ACharacter_ClientCheatGhost(ACharacter* Self)
	{
		Self->ClientCheatGhost();
	}

	DOTNET_EXPORT auto E_ACharacter_ClientCheatGhost_Implementation(ACharacter* Self)
	{
		Self->ClientCheatGhost_Implementation();
	}

	DOTNET_EXPORT auto E_ACharacter_ClientCheatWalk(ACharacter* Self)
	{
		Self->ClientCheatWalk();
	}

	DOTNET_EXPORT auto E_ACharacter_ClientCheatWalk_Implementation(ACharacter* Self)
	{
		Self->ClientCheatWalk_Implementation();
	}

	DOTNET_EXPORT auto E_ACharacter_ClientVeryShortAdjustPosition(ACharacter* Self, float TimeStamp, INT_PTR NewLoc, UPrimitiveComponent* NewBase, char* NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FVector*)NewLoc;
		auto _p2 = NewBase;
		auto _p3 = ConvertFromManage_FName(NewBaseBoneName);
		auto _p4 = bHasBase;
		auto _p5 = bBaseRelativePosition;
		auto _p6 = ServerMovementMode;
		Self->ClientVeryShortAdjustPosition(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_ACharacter_ClientVeryShortAdjustPosition_Implementation(ACharacter* Self, float TimeStamp, INT_PTR NewLoc, UPrimitiveComponent* NewBase, char* NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FVector*)NewLoc;
		auto _p2 = NewBase;
		auto _p3 = ConvertFromManage_FName(NewBaseBoneName);
		auto _p4 = bHasBase;
		auto _p5 = bBaseRelativePosition;
		auto _p6 = ServerMovementMode;
		Self->ClientVeryShortAdjustPosition_Implementation(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_ACharacter_Crouch(ACharacter* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		Self->Crouch(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_Falling(ACharacter* Self)
	{
		Self->Falling();
	}

	DOTNET_EXPORT auto E_ACharacter_GetAnimRootMotionTranslationScale(ACharacter* Self)
	{
		return Self->GetAnimRootMotionTranslationScale();
	}

	DOTNET_EXPORT auto E_ACharacter_GetBaseRotationOffset(ACharacter* Self)
	{
		return (INT_PTR) new FQuat(Self->GetBaseRotationOffset());
	}

	DOTNET_EXPORT auto E_ACharacter_GetBaseRotationOffsetRotator(ACharacter* Self)
	{
		return (INT_PTR) new FRotator(Self->GetBaseRotationOffsetRotator());
	}

	DOTNET_EXPORT auto E_ACharacter_GetBaseTranslationOffset(ACharacter* Self)
	{
		return (INT_PTR) new FVector(Self->GetBaseTranslationOffset());
	}

	DOTNET_EXPORT auto E_ACharacter_GetCapsuleComponent(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCapsuleComponent());
	}

	DOTNET_EXPORT auto E_ACharacter_GetCharacterMovement(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCharacterMovement());
	}

	DOTNET_EXPORT auto E_ACharacter_GetDefaultHalfHeight(ACharacter* Self)
	{
		return Self->GetDefaultHalfHeight();
	}

	DOTNET_EXPORT auto E_ACharacter_GetJumpMaxHoldTime(ACharacter* Self)
	{
		return Self->GetJumpMaxHoldTime();
	}

	DOTNET_EXPORT auto E_ACharacter_GetMesh(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMesh());
	}

	DOTNET_EXPORT auto E_ACharacter_GetMovementBase(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementBase());
	}

	DOTNET_EXPORT auto E_ACharacter_GetMovementComponent(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMovementComponent());
	}

	DOTNET_EXPORT auto E_ACharacter_GetNavAgentLocation(ACharacter* Self)
	{
		return (INT_PTR) new FVector(Self->GetNavAgentLocation());
	}

	DOTNET_EXPORT auto E_ACharacter_GetReplicatedMovementMode(ACharacter* Self)
	{
		return Self->GetReplicatedMovementMode();
	}

	DOTNET_EXPORT auto E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(ACharacter* Self)
	{
		return Self->GetReplicatedServerLastTransformUpdateTimeStamp();
	}

	DOTNET_EXPORT auto E_ACharacter_GetSimpleCollisionCylinder(ACharacter* Self, float CollisionRadius, float CollisionHalfHeight)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		Self->GetSimpleCollisionCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_IsJumpProvidingForce(ACharacter* Self)
	{
		return Self->IsJumpProvidingForce();
	}

	DOTNET_EXPORT auto E_ACharacter_IsPlayingNetworkedRootMotionMontage(ACharacter* Self)
	{
		return Self->IsPlayingNetworkedRootMotionMontage();
	}

	DOTNET_EXPORT auto E_ACharacter_IsPlayingRootMotion(ACharacter* Self)
	{
		return Self->IsPlayingRootMotion();
	}

	DOTNET_EXPORT auto E_ACharacter_Jump(ACharacter* Self)
	{
		Self->Jump();
	}

	DOTNET_EXPORT auto E_ACharacter_K2_OnEndCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		Self->K2_OnEndCrouch(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_K2_OnMovementModeChanged(ACharacter* Self, EMovementMode PrevMovementMode, EMovementMode NewMovementMode, uint8 PrevCustomMode, uint8 NewCustomMode)
	{
		auto _p0 = PrevMovementMode;
		auto _p1 = NewMovementMode;
		auto _p2 = PrevCustomMode;
		auto _p3 = NewCustomMode;
		Self->K2_OnMovementModeChanged(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ACharacter_K2_OnStartCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		Self->K2_OnStartCrouch(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_K2_UpdateCustomMovement(ACharacter* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		Self->K2_UpdateCustomMovement(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_Landed(ACharacter* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		Self->Landed(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_LaunchCharacter(ACharacter* Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		Self->LaunchCharacter(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_MoveBlockedBy(ACharacter* Self, INT_PTR Impact)
	{
		auto _p0 = *(FHitResult*)Impact;
		Self->MoveBlockedBy(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_NotifyJumpApex(ACharacter* Self)
	{
		Self->NotifyJumpApex();
	}

	DOTNET_EXPORT auto E_ACharacter_OnEndCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		Self->OnEndCrouch(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_OnJumped(ACharacter* Self)
	{
		Self->OnJumped();
	}

	DOTNET_EXPORT auto E_ACharacter_OnJumped_Implementation(ACharacter* Self)
	{
		Self->OnJumped_Implementation();
	}

	DOTNET_EXPORT auto E_ACharacter_OnLanded(ACharacter* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		Self->OnLanded(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_OnLaunched(ACharacter* Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		Self->OnLaunched(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_OnMovementModeChanged(ACharacter* Self, EMovementMode PrevMovementMode, uint8 PreviousCustomMode)
	{
		auto _p0 = PrevMovementMode;
		auto _p1 = PreviousCustomMode;
		Self->OnMovementModeChanged(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_IsCrouched(ACharacter* Self)
	{
		Self->OnRep_IsCrouched();
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_ReplicatedBasedMovement(ACharacter* Self)
	{
		Self->OnRep_ReplicatedBasedMovement();
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_ReplicatedMovement(ACharacter* Self)
	{
		Self->OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_RootMotion(ACharacter* Self)
	{
		Self->OnRep_RootMotion();
	}

	DOTNET_EXPORT auto E_ACharacter_OnStartCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		Self->OnStartCrouch(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_OnUpdateSimulatedPosition(ACharacter* Self, INT_PTR OldLocation, INT_PTR OldRotation)
	{
		auto _p0 = *(FVector*)OldLocation;
		auto _p1 = *(FQuat*)OldRotation;
		Self->OnUpdateSimulatedPosition(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_OnWalkingOffLedge(ACharacter* Self, INT_PTR PreviousFloorImpactNormal, INT_PTR PreviousFloorContactNormal, INT_PTR PreviousLocation, float TimeDelta)
	{
		auto _p0 = *(FVector*)PreviousFloorImpactNormal;
		auto _p1 = *(FVector*)PreviousFloorContactNormal;
		auto _p2 = *(FVector*)PreviousLocation;
		auto _p3 = TimeDelta;
		Self->OnWalkingOffLedge(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ACharacter_OnWalkingOffLedge_Implementation(ACharacter* Self, INT_PTR PreviousFloorImpactNormal, INT_PTR PreviousFloorContactNormal, INT_PTR PreviousLocation, float TimeDelta)
	{
		auto _p0 = *(FVector*)PreviousFloorImpactNormal;
		auto _p1 = *(FVector*)PreviousFloorContactNormal;
		auto _p2 = *(FVector*)PreviousLocation;
		auto _p3 = TimeDelta;
		Self->OnWalkingOffLedge_Implementation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ACharacter_PawnClientRestart(ACharacter* Self)
	{
		Self->PawnClientRestart();
	}

	DOTNET_EXPORT auto E_ACharacter_PostInitializeComponents(ACharacter* Self)
	{
		Self->PostInitializeComponents();
	}

	DOTNET_EXPORT auto E_ACharacter_PostNetReceive(ACharacter* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_ACharacter_PostNetReceiveLocationAndRotation(ACharacter* Self)
	{
		Self->PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E_ACharacter_PreNetReceive(ACharacter* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_ACharacter_RecalculateBaseEyeHeight(ACharacter* Self)
	{
		Self->RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT auto E_ACharacter_ResetJumpState(ACharacter* Self)
	{
		Self->ResetJumpState();
	}

	DOTNET_EXPORT auto E_ACharacter_Restart(ACharacter* Self)
	{
		Self->Restart();
	}

	DOTNET_EXPORT auto E_ACharacter_RestoreReplicatedMove(ACharacter* Self, INT_PTR RootMotionRepMove)
	{
		auto _p0 = *(FSimulatedRootMotionReplicatedMove*)RootMotionRepMove;
		return Self->RestoreReplicatedMove(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_RootMotionDebugClientPrintOnScreen(ACharacter* Self, char* InString)
	{
		auto _p0 = ConvertFromManage_FString(InString);
		Self->RootMotionDebugClientPrintOnScreen(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_RootMotionDebugClientPrintOnScreen_Implementation(ACharacter* Self, char* InString)
	{
		auto _p0 = ConvertFromManage_FString(InString);
		Self->RootMotionDebugClientPrintOnScreen_Implementation(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_SaveRelativeBasedMovement(ACharacter* Self, INT_PTR NewRelativeLocation, INT_PTR NewRotation, bool bRelativeRotation)
	{
		auto _p0 = *(FVector*)NewRelativeLocation;
		auto _p1 = *(FRotator*)NewRotation;
		auto _p2 = bRelativeRotation;
		Self->SaveRelativeBasedMovement(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_SetAnimRootMotionTranslationScale(ACharacter* Self, float InAnimRootMotionTranslationScale)
	{
		auto _p0 = InAnimRootMotionTranslationScale;
		Self->SetAnimRootMotionTranslationScale(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_SetBase(ACharacter* Self, UPrimitiveComponent* NewBase, char* BoneName, bool bNotifyActor)
	{
		auto _p0 = NewBase;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bNotifyActor;
		Self->SetBase(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_SetReplicateMovement(ACharacter* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		Self->SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_ShouldNotifyLanded(ACharacter* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return Self->ShouldNotifyLanded(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_SimulatedRootMotionPositionFixup(ACharacter* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->SimulatedRootMotionPositionFixup(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_StopJumping(ACharacter* Self)
	{
		Self->StopJumping();
	}

	DOTNET_EXPORT auto E_ACharacter_TornOff(ACharacter* Self)
	{
		Self->TornOff();
	}

	DOTNET_EXPORT auto E_ACharacter_TurnOff(ACharacter* Self)
	{
		Self->TurnOff();
	}

	DOTNET_EXPORT auto E_ACharacter_UnCrouch(ACharacter* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		Self->UnCrouch(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_UnPossessed(ACharacter* Self)
	{
		Self->UnPossessed();
	}

	DOTNET_EXPORT auto E_ACharacter_UpdateNavigationRelevance(ACharacter* Self)
	{
		Self->UpdateNavigationRelevance();
	}

	DOTNET_EXPORT auto E_ACharacter_AddControllerPitchInput(ACharacter* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_AddControllerRollInput(ACharacter* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_AddControllerYawInput(ACharacter* Self, float Val)
	{
		auto _p0 = Val;
		Self->AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_AddMovementInput(ACharacter* Self, INT_PTR WorldDirection, float ScaleValue, bool bForce)
	{
		auto _p0 = *(FVector*)WorldDirection;
		auto _p1 = ScaleValue;
		auto _p2 = bForce;
		Self->AddMovementInput(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_CanBeBaseForCharacter(ACharacter* Self, APawn* APawn)
	{
		auto _p0 = APawn;
		return Self->CanBeBaseForCharacter(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_ConsumeMovementInputVector(ACharacter* Self)
	{
		return (INT_PTR) new FVector(Self->ConsumeMovementInputVector());
	}

	DOTNET_EXPORT auto E_ACharacter_Destroyed(ACharacter* Self)
	{
		Self->Destroyed();
	}

	DOTNET_EXPORT auto E_ACharacter_DestroyPlayerInputComponent(ACharacter* Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->DestroyPlayerInputComponent_WRAP();
	}

	DOTNET_EXPORT auto E_ACharacter_DetachFromControllerPendingDestroy(ACharacter* Self)
	{
		Self->DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT auto E_ACharacter_FaceRotation(ACharacter* Self, INT_PTR NewControlRotation, float DeltaTime)
	{
		auto _p0 = *(FRotator*)NewControlRotation;
		auto _p1 = DeltaTime;
		Self->FaceRotation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_GetActorEyesViewPoint(ACharacter* Self, INT_PTR Location, INT_PTR Rotation)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)Rotation;
		Self->GetActorEyesViewPoint(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_GetBaseAimRotation(ACharacter* Self)
	{
		return (INT_PTR) new FRotator(Self->GetBaseAimRotation());
	}

	DOTNET_EXPORT auto E_ACharacter_GetHumanReadableName(ACharacter* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetHumanReadableName());
	}

	DOTNET_EXPORT auto E_ACharacter_GetMoveGoalReachTest(ACharacter* Self, AActor* MovingActor, INT_PTR MoveOffset, INT_PTR GoalOffset, float GoalRadius, float GoalHalfHeight)
	{
		auto _p0 = MovingActor;
		auto _p1 = *(FVector*)MoveOffset;
		auto _p2 = *(FVector*)GoalOffset;
		auto _p3 = GoalRadius;
		auto _p4 = GoalHalfHeight;
		Self->GetMoveGoalReachTest(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_ACharacter_GetNetOwningPlayer(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetNetOwningPlayer());
	}

	DOTNET_EXPORT auto E_ACharacter_GetPawnNoiseEmitterComponent(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawnNoiseEmitterComponent());
	}

	DOTNET_EXPORT auto E_ACharacter_GetPawnViewLocation(ACharacter* Self)
	{
		return (INT_PTR) new FVector(Self->GetPawnViewLocation());
	}

	DOTNET_EXPORT auto E_ACharacter_GetVelocity(ACharacter* Self)
	{
		return (INT_PTR) new FVector(Self->GetVelocity());
	}

	DOTNET_EXPORT auto E_ACharacter_GetViewRotation(ACharacter* Self)
	{
		return (INT_PTR) new FRotator(Self->GetViewRotation());
	}

	DOTNET_EXPORT auto E_ACharacter_InFreeCam(ACharacter* Self)
	{
		return Self->InFreeCam();
	}

	DOTNET_EXPORT auto E_ACharacter_IsBasedOnActor(ACharacter* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsBasedOnActor(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_IsLocallyControlled(ACharacter* Self)
	{
		return Self->IsLocallyControlled();
	}

	DOTNET_EXPORT auto E_ACharacter_IsMoveInputIgnored(ACharacter* Self)
	{
		return Self->IsMoveInputIgnored();
	}

	DOTNET_EXPORT auto E_ACharacter_IsNetRelevantFor(ACharacter* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		return Self->IsNetRelevantFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_IsPlayerControlled(ACharacter* Self)
	{
		return Self->IsPlayerControlled();
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_Controller(ACharacter* Self)
	{
		Self->OnRep_Controller();
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_PlayerState(ACharacter* Self)
	{
		Self->OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E_ACharacter_OutsideWorldBounds(ACharacter* Self)
	{
		Self->OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E_ACharacter_PawnStartFire(ACharacter* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		Self->PawnStartFire(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_PostLoad(ACharacter* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_ACharacter_PostNetReceiveVelocity(ACharacter* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		Self->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_PostRegisterAllComponents(ACharacter* Self)
	{
		Self->PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E_ACharacter_PreInitializeComponents(ACharacter* Self)
	{
		Self->PreInitializeComponents();
	}

	DOTNET_EXPORT auto E_ACharacter_ReachedDesiredRotation(ACharacter* Self)
	{
		return Self->ReachedDesiredRotation();
	}

	DOTNET_EXPORT auto E_ACharacter_Reset(ACharacter* Self)
	{
		Self->Reset();
	}

	DOTNET_EXPORT auto E_ACharacter_SetPlayerDefaults(ACharacter* Self)
	{
		Self->SetPlayerDefaults();
	}

	DOTNET_EXPORT auto E_ACharacter_ShouldTickIfViewportsOnly(ACharacter* Self)
	{
		return Self->ShouldTickIfViewportsOnly();
	}

	DOTNET_EXPORT auto E_ACharacter_SpawnDefaultController(ACharacter* Self)
	{
		Self->SpawnDefaultController();
	}

	DOTNET_EXPORT auto E_ACharacter_TeleportSucceeded(ACharacter* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		Self->TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_AddTickPrerequisiteActor(ACharacter* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_AddTickPrerequisiteComponent(ACharacter* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_ApplyWorldOffset(ACharacter* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_BeginDestroy(ACharacter* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_ACharacter_CalculateComponentsBoundingBoxInLocalSpace(ACharacter* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->CalculateComponentsBoundingBoxInLocalSpace(_p0));
	}

	DOTNET_EXPORT auto E_ACharacter_CanBeInCluster(ACharacter* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_ACharacter_CheckDefaultSubobjectsInternal(ACharacter* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_ACharacter_CheckStillInWorld(ACharacter* Self)
	{
		return Self->CheckStillInWorld();
	}

	DOTNET_EXPORT auto E_ACharacter_DestroyNetworkActorHandled(ACharacter* Self)
	{
		return Self->DestroyNetworkActorHandled();
	}

	DOTNET_EXPORT auto E_ACharacter_ForceNetRelevant(ACharacter* Self)
	{
		Self->ForceNetRelevant();
	}

	DOTNET_EXPORT auto E_ACharacter_ForceNetUpdate(ACharacter* Self)
	{
		Self->ForceNetUpdate();
	}

	DOTNET_EXPORT auto E_ACharacter_GatherCurrentMovement(ACharacter* Self)
	{
		Self->GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E_ACharacter_GetComponentsBoundingBox(ACharacter* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->GetComponentsBoundingBox(_p0));
	}

	DOTNET_EXPORT auto E_ACharacter_GetComponentsBoundingCylinder(ACharacter* Self, float CollisionRadius, float CollisionHalfHeight, bool bNonColliding)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		auto _p2 = bNonColliding;
		Self->GetComponentsBoundingCylinder(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_GetComponentsCollisionResponseToChannel(ACharacter* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetComponentsCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_GetDefaultAttachComponent(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetDefaultAttachComponent());
	}

	DOTNET_EXPORT auto E_ACharacter_GetLastRenderTime(ACharacter* Self)
	{
		return Self->GetLastRenderTime();
	}

	DOTNET_EXPORT auto E_ACharacter_GetLifeSpan(ACharacter* Self)
	{
		return Self->GetLifeSpan();
	}

	DOTNET_EXPORT auto E_ACharacter_GetTargetLocation(ACharacter* Self, AActor* RequestedBy)
	{
		auto _p0 = RequestedBy;
		return (INT_PTR) new FVector(Self->GetTargetLocation(_p0));
	}

	DOTNET_EXPORT auto E_ACharacter_GetWorld(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_ACharacter_HasActiveCameraComponent(ACharacter* Self)
	{
		return Self->HasActiveCameraComponent();
	}

	DOTNET_EXPORT auto E_ACharacter_HasActivePawnControlCameraComponent(ACharacter* Self)
	{
		return Self->HasActivePawnControlCameraComponent();
	}

	DOTNET_EXPORT auto E_ACharacter_HasNetOwner(ACharacter* Self)
	{
		return ((E_PROTECTED_WRAP_ACharacter*)Self)->HasNetOwner_WRAP();
	}

	DOTNET_EXPORT auto E_ACharacter_InvalidateLightingCacheDetailed(ACharacter* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_IsAttachedTo(ACharacter* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsAttachedTo(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_IsComponentRelevantForNavigation(ACharacter* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		return Self->IsComponentRelevantForNavigation(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_IsLevelBoundsRelevant(ACharacter* Self)
	{
		return Self->IsLevelBoundsRelevant();
	}

	DOTNET_EXPORT auto E_ACharacter_IsNameStableForNetworking(ACharacter* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ACharacter_IsReadyForFinishDestroy(ACharacter* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_ACharacter_IsRelevancyOwnerFor(ACharacter* Self, AActor* ReplicatedActor, AActor* ActorOwner, AActor* ConnectionActor)
	{
		auto _p0 = ReplicatedActor;
		auto _p1 = ActorOwner;
		auto _p2 = ConnectionActor;
		return Self->IsRelevancyOwnerFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_IsReplayRelevantFor(ACharacter* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation, float CullDistanceSquared)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		auto _p3 = CullDistanceSquared;
		return Self->IsReplayRelevantFor(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ACharacter_IsRootComponentCollisionRegistered(ACharacter* Self)
	{
		return Self->IsRootComponentCollisionRegistered();
	}

	DOTNET_EXPORT auto E_ACharacter_IsSupportedForNetworking(ACharacter* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_ACharacter_K2_DestroyActor(ACharacter* Self)
	{
		Self->K2_DestroyActor();
	}

	DOTNET_EXPORT auto E_ACharacter_LifeSpanExpired(ACharacter* Self)
	{
		Self->LifeSpanExpired();
	}

	DOTNET_EXPORT auto E_ACharacter_MarkComponentsAsPendingKill(ACharacter* Self)
	{
		Self->MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E_ACharacter_Modify(ACharacter* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_NotifyActorBeginCursorOver(ACharacter* Self)
	{
		Self->NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E_ACharacter_NotifyActorBeginOverlap(ACharacter* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_NotifyActorEndCursorOver(ACharacter* Self)
	{
		Self->NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E_ACharacter_NotifyActorEndOverlap(ACharacter* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorEndOverlap(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_NotifyHit(ACharacter* Self, UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, INT_PTR HitLocation, INT_PTR HitNormal, INT_PTR NormalImpulse, INT_PTR Hit)
	{
		auto _p0 = MyComp;
		auto _p1 = Other;
		auto _p2 = OtherComp;
		auto _p3 = bSelfMoved;
		auto _p4 = *(FVector*)HitLocation;
		auto _p5 = *(FVector*)HitNormal;
		auto _p6 = *(FVector*)NormalImpulse;
		auto _p7 = *(FHitResult*)Hit;
		Self->NotifyHit(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_ACharacter_OnConstruction(ACharacter* Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		Self->OnConstruction(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_AttachmentReplication(ACharacter* Self)
	{
		Self->OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_Instigator(ACharacter* Self)
	{
		Self->OnRep_Instigator();
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_Owner(ACharacter* Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->OnRep_Owner_WRAP();
	}

	DOTNET_EXPORT auto E_ACharacter_OnRep_ReplicateMovement(ACharacter* Self)
	{
		Self->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E_ACharacter_OnReplicationPausedChanged(ACharacter* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		Self->OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_OnSubobjectCreatedFromReplication(ACharacter* Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		Self->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_OnSubobjectDestroyFromReplication(ACharacter* Self, UObject* Subobject)
	{
		auto _p0 = Subobject;
		Self->OnSubobjectDestroyFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_PostActorCreated(ACharacter* Self)
	{
		Self->PostActorCreated();
	}

	DOTNET_EXPORT auto E_ACharacter_PostInitProperties(ACharacter* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_ACharacter_PostNetInit(ACharacter* Self)
	{
		Self->PostNetInit();
	}

	DOTNET_EXPORT auto E_ACharacter_PostNetReceivePhysicState(ACharacter* Self)
	{
		Self->PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E_ACharacter_PostRename(ACharacter* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_PostUnregisterAllComponents(ACharacter* Self)
	{
		Self->PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E_ACharacter_PrestreamTextures(ACharacter* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		Self->PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_RegisterActorTickFunctions(ACharacter* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((E_PROTECTED_WRAP_ACharacter*)Self)->RegisterActorTickFunctions_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_RegisterAllComponents(ACharacter* Self)
	{
		Self->RegisterAllComponents();
	}

	DOTNET_EXPORT auto E_ACharacter_RemoveTickPrerequisiteActor(ACharacter* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_RemoveTickPrerequisiteComponent(ACharacter* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_ReregisterAllComponents(ACharacter* Self)
	{
		Self->ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E_ACharacter_RerunConstructionScripts(ACharacter* Self)
	{
		Self->RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E_ACharacter_SetActorHiddenInGame(ACharacter* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		Self->SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_SetLifeSpan(ACharacter* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_SetOwner(ACharacter* Self, AActor* NewOwner)
	{
		auto _p0 = NewOwner;
		Self->SetOwner(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_TearOff(ACharacter* Self)
	{
		Self->TearOff();
	}

	DOTNET_EXPORT auto E_ACharacter_TeleportTo(ACharacter* Self, INT_PTR DestLocation, INT_PTR DestRotation, bool bIsATest, bool bNoCheck)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		auto _p2 = bIsATest;
		auto _p3 = bNoCheck;
		return Self->TeleportTo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ACharacter_Tick(ACharacter* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->Tick(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_TickActor(ACharacter* Self, float DeltaTime, ELevelTick TickType, INT_PTR ThisTickFunction)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickType;
		auto _p2 = *(FActorTickFunction*)ThisTickFunction;
		Self->TickActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_UnregisterAllComponents(ACharacter* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		Self->UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_UseShortConnectTimeout(ACharacter* Self)
	{
		return Self->UseShortConnectTimeout();
	}

	DOTNET_EXPORT auto E_ACharacter_AreNativePropertiesIdenticalTo(ACharacter* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_FinishDestroy(ACharacter* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_ACharacter_GetDesc(ACharacter* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_ACharacter_GetDetailedInfoInternal(ACharacter* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_ACharacter_IsAsset(ACharacter* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_ACharacter_IsEditorOnly(ACharacter* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_ACharacter_IsFullNameStableForNetworking(ACharacter* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ACharacter_IsLocalizedResource(ACharacter* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_ACharacter_IsPostLoadThreadSafe(ACharacter* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_ACharacter_IsSafeForRootSet(ACharacter* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_ACharacter_MarkAsEditorOnlySubobject(ACharacter* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_ACharacter_NeedsLoadForClient(ACharacter* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_ACharacter_NeedsLoadForEditorGame(ACharacter* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_ACharacter_NeedsLoadForServer(ACharacter* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_ACharacter_NotifyObjectReferenceEliminated(ACharacter* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_ACharacter_PostCDOContruct(ACharacter* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_ACharacter_PostEditImport(ACharacter* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_ACharacter_PostRepNotifies(ACharacter* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_ACharacter_PostSaveRoot(ACharacter* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_PreDestroyFromReplication(ACharacter* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_ACharacter_ShutdownAfterError(ACharacter* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_ACharacter_AddToCluster(ACharacter* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_CanBeClusterRoot(ACharacter* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_ACharacter_CreateCluster(ACharacter* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_ACharacter_OnClusterMarkedAsPendingKill(ACharacter* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
