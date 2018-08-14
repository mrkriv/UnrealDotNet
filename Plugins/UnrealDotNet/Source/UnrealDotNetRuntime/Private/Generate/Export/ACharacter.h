#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/Character.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

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

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_ACharacter_CapsuleComponentName_GET() { return ConvertToManage_StringWrapper(ACharacter::CapsuleComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_CharacterMovementComponentName_GET() { return ConvertToManage_StringWrapper(ACharacter::CharacterMovementComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_CrouchedEyeHeight_GET(ACharacter* Ptr) { return Ptr->CrouchedEyeHeight; }
	DOTNET_EXPORT void E_PROP_ACharacter_CrouchedEyeHeight_SET(ACharacter* Ptr, float Value) { Ptr->CrouchedEyeHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_JumpCurrentCount_GET(ACharacter* Ptr) { return Ptr->JumpCurrentCount; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpCurrentCount_SET(ACharacter* Ptr, int32 Value) { Ptr->JumpCurrentCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_JumpForceTimeRemaining_GET(ACharacter* Ptr) { return Ptr->JumpForceTimeRemaining; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpForceTimeRemaining_SET(ACharacter* Ptr, float Value) { Ptr->JumpForceTimeRemaining = Value; }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_JumpKeyHoldTime_GET(ACharacter* Ptr) { return Ptr->JumpKeyHoldTime; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpKeyHoldTime_SET(ACharacter* Ptr, float Value) { Ptr->JumpKeyHoldTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_JumpMaxCount_GET(ACharacter* Ptr) { return Ptr->JumpMaxCount; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpMaxCount_SET(ACharacter* Ptr, int32 Value) { Ptr->JumpMaxCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_ACharacter_JumpMaxHoldTime_GET(ACharacter* Ptr) { return Ptr->JumpMaxHoldTime; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpMaxHoldTime_SET(ACharacter* Ptr, float Value) { Ptr->JumpMaxHoldTime = Value; }
	
	DOTNET_EXPORT void E_EVENT_ADD_ACharacter_LandedDelegate(ACharacter* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
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
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_MovementModeChangedDelegate";
		wrapper->SourceObject = Obj;
		Obj->MovementModeChangedDelegate.AddDynamic(wrapper, &UManageEventSender::Wrapper_FMovementModeChangedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_ACharacter_MovementModeChangedDelegate(ACharacter* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_ACharacter_OnCharacterMovementUpdated(ACharacter* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnCharacterMovementUpdated";
		wrapper->SourceObject = Obj;
		Obj->OnCharacterMovementUpdated.AddDynamic(wrapper, &UManageEventSender::Wrapper_FCharacterMovementUpdatedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_ACharacter_OnCharacterMovementUpdated(ACharacter* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_ACharacter_OnReachedJumpApex(ACharacter* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnReachedJumpApex";
		wrapper->SourceObject = Obj;
		Obj->OnReachedJumpApex.AddDynamic(wrapper, &UManageEventSender::Wrapper_FCharacterReachedApexSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_ACharacter_OnReachedJumpApex(ACharacter* Obj)
	{
	}

	DOTNET_EXPORT auto E_PROP_ACharacter_ProxyJumpForceStartedTime_GET(ACharacter* Ptr) { return Ptr->ProxyJumpForceStartedTime; }
	DOTNET_EXPORT void E_PROP_ACharacter_ProxyJumpForceStartedTime_SET(ACharacter* Ptr, float Value) { Ptr->ProxyJumpForceStartedTime = Value; }
	
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

	DOTNET_EXPORT auto E_ACharacter_ClearJumpInput(ACharacter* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		Self->ClearJumpInput(_p0);
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

	DOTNET_EXPORT auto E_ACharacter_GetJumpMaxHoldTime(ACharacter* Self)
	{
		return Self->GetJumpMaxHoldTime();
	}

	DOTNET_EXPORT auto E_ACharacter_GetMesh(ACharacter* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMesh());
	}

	DOTNET_EXPORT auto E_ACharacter_GetReplicatedMovementMode(ACharacter* Self)
	{
		return Self->GetReplicatedMovementMode();
	}

	DOTNET_EXPORT auto E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(ACharacter* Self)
	{
		return Self->GetReplicatedServerLastTransformUpdateTimeStamp();
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

	DOTNET_EXPORT auto E_ACharacter_NotifyActorBeginOverlap(ACharacter* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_NotifyActorEndOverlap(ACharacter* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorEndOverlap(_p0);
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

	DOTNET_EXPORT auto E_ACharacter_ResetJumpState(ACharacter* Self)
	{
		Self->ResetJumpState();
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

	DOTNET_EXPORT auto E_ACharacter_UnCrouch(ACharacter* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		Self->UnCrouch(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
