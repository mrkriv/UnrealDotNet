#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCharacter.h"
#include "Runtime/Engine/Classes/GameFramework/Character.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

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
	
	DOTNET_EXPORT auto E_PROP_ACharacter_SavedRootMotion_GET(ACharacter* Ptr) { return (INT_PTR)&(Ptr->SavedRootMotion); }
	DOTNET_EXPORT void E_PROP_ACharacter_SavedRootMotion_SET(ACharacter* Ptr, INT_PTR Value) { Ptr->SavedRootMotion = *(FRootMotionSourceGroup*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ACharacter(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ACharacter>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ACharacter_ApplyDamageMomentum(ACharacter* Self, float DamageTaken, INT_PTR DamageEvent, APawn* PawnInstigator, AActor* DamageCauser)
	{
		auto _p0 = DamageTaken;
		auto& _p1 = *(FDamageEvent*)DamageEvent;
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

	DOTNET_EXPORT auto E_ACharacter_ClientAdjustRootMotionPosition(ACharacter* Self, float TimeStamp, float ServerMontageTrackPosition, INT_PTR ServerLoc, INT_PTR ServerRotation, float ServerVelZ, UPrimitiveComponent* ServerBase, char* ServerBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = ServerMontageTrackPosition;
		auto _p2 = *(FVector*)ServerLoc;
		auto _p3 = *(FVector_NetQuantizeNormal*)ServerRotation;
		auto _p4 = ServerVelZ;
		auto _p5 = ServerBase;
		auto _p6 = ConvertFromManage_FName(ServerBoneName);
		auto _p7 = bHasBase;
		auto _p8 = bBaseRelativePosition;
		auto _p9 = ServerMovementMode;
		Self->ClientAdjustRootMotionPosition(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7, _p8, _p9);
	}

	DOTNET_EXPORT auto E_ACharacter_ClientAdjustRootMotionPosition_Implementation(ACharacter* Self, float TimeStamp, float ServerMontageTrackPosition, INT_PTR ServerLoc, INT_PTR ServerRotation, float ServerVelZ, UPrimitiveComponent* ServerBase, char* ServerBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = ServerMontageTrackPosition;
		auto _p2 = *(FVector*)ServerLoc;
		auto _p3 = *(FVector_NetQuantizeNormal*)ServerRotation;
		auto _p4 = ServerVelZ;
		auto _p5 = ServerBase;
		auto _p6 = ConvertFromManage_FName(ServerBoneName);
		auto _p7 = bHasBase;
		auto _p8 = bBaseRelativePosition;
		auto _p9 = ServerMovementMode;
		Self->ClientAdjustRootMotionPosition_Implementation(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7, _p8, _p9);
	}

	DOTNET_EXPORT auto E_ACharacter_ClientAdjustRootMotionSourcePosition(ACharacter* Self, float TimeStamp, INT_PTR ServerRootMotion, bool bHasAnimRootMotion, float ServerMontageTrackPosition, INT_PTR ServerLoc, INT_PTR ServerRotation, float ServerVelZ, UPrimitiveComponent* ServerBase, char* ServerBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FRootMotionSourceGroup*)ServerRootMotion;
		auto _p2 = bHasAnimRootMotion;
		auto _p3 = ServerMontageTrackPosition;
		auto _p4 = *(FVector*)ServerLoc;
		auto _p5 = *(FVector_NetQuantizeNormal*)ServerRotation;
		auto _p6 = ServerVelZ;
		auto _p7 = ServerBase;
		auto _p8 = ConvertFromManage_FName(ServerBoneName);
		auto _p9 = bHasBase;
		auto _p10 = bBaseRelativePosition;
		auto _p11 = ServerMovementMode;
		Self->ClientAdjustRootMotionSourcePosition(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7, _p8, _p9, _p10, _p11);
	}

	DOTNET_EXPORT auto E_ACharacter_ClientAdjustRootMotionSourcePosition_Implementation(ACharacter* Self, float TimeStamp, INT_PTR ServerRootMotion, bool bHasAnimRootMotion, float ServerMontageTrackPosition, INT_PTR ServerLoc, INT_PTR ServerRotation, float ServerVelZ, UPrimitiveComponent* ServerBase, char* ServerBoneName, bool bHasBase, bool bBaseRelativePosition, uint8 ServerMovementMode)
	{
		auto _p0 = TimeStamp;
		auto _p1 = *(FRootMotionSourceGroup*)ServerRootMotion;
		auto _p2 = bHasAnimRootMotion;
		auto _p3 = ServerMontageTrackPosition;
		auto _p4 = *(FVector*)ServerLoc;
		auto _p5 = *(FVector_NetQuantizeNormal*)ServerRotation;
		auto _p6 = ServerVelZ;
		auto _p7 = ServerBase;
		auto _p8 = ConvertFromManage_FName(ServerBoneName);
		auto _p9 = bHasBase;
		auto _p10 = bBaseRelativePosition;
		auto _p11 = ServerMovementMode;
		Self->ClientAdjustRootMotionSourcePosition_Implementation(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7, _p8, _p9, _p10, _p11);
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

	DOTNET_EXPORT auto E_ACharacter_GetBasedMovement(ACharacter* Self)
	{
		return (INT_PTR) const_cast<FBasedMovementInfo*>(&(Self->GetBasedMovement()));
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

	DOTNET_EXPORT auto E_ACharacter_GetReplicatedBasedMovement(ACharacter* Self)
	{
		return (INT_PTR) const_cast<FBasedMovementInfo*>(&(Self->GetReplicatedBasedMovement()));
	}

	DOTNET_EXPORT auto E_ACharacter_GetReplicatedMovementMode(ACharacter* Self)
	{
		return Self->GetReplicatedMovementMode();
	}

	DOTNET_EXPORT auto E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(ACharacter* Self)
	{
		return Self->GetReplicatedServerLastTransformUpdateTimeStamp();
	}

	DOTNET_EXPORT auto E_ACharacter_HasAnyRootMotion(ACharacter* Self)
	{
		return Self->HasAnyRootMotion();
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
		auto& _p0 = *(FHitResult*)Hit;
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
		auto& _p0 = *(FHitResult*)Impact;
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
		auto& _p0 = *(FHitResult*)Hit;
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

	DOTNET_EXPORT auto E_ACharacter_OnRep_ReplayLastTransformUpdateTimeStamp(ACharacter* Self)
	{
		Self->OnRep_ReplayLastTransformUpdateTimeStamp();
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
		auto& _p0 = *(FVector*)OldLocation;
		auto& _p1 = *(FQuat*)OldRotation;
		Self->OnUpdateSimulatedPosition(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ACharacter_OnWalkingOffLedge(ACharacter* Self, INT_PTR PreviousFloorImpactNormal, INT_PTR PreviousFloorContactNormal, INT_PTR PreviousLocation, float TimeDelta)
	{
		auto& _p0 = *(FVector*)PreviousFloorImpactNormal;
		auto& _p1 = *(FVector*)PreviousFloorContactNormal;
		auto& _p2 = *(FVector*)PreviousLocation;
		auto _p3 = TimeDelta;
		Self->OnWalkingOffLedge(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ACharacter_OnWalkingOffLedge_Implementation(ACharacter* Self, INT_PTR PreviousFloorImpactNormal, INT_PTR PreviousFloorContactNormal, INT_PTR PreviousLocation, float TimeDelta)
	{
		auto& _p0 = *(FVector*)PreviousFloorImpactNormal;
		auto& _p1 = *(FVector*)PreviousFloorContactNormal;
		auto& _p2 = *(FVector*)PreviousLocation;
		auto _p3 = TimeDelta;
		Self->OnWalkingOffLedge_Implementation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ACharacter_ResetJumpState(ACharacter* Self)
	{
		Self->ResetJumpState();
	}

	DOTNET_EXPORT auto E_ACharacter_RestoreReplicatedMove(ACharacter* Self, INT_PTR RootMotionRepMove)
	{
		auto& _p0 = *(FSimulatedRootMotionReplicatedMove*)RootMotionRepMove;
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
		auto& _p0 = *(FVector*)NewRelativeLocation;
		auto& _p1 = *(FRotator*)NewRotation;
		auto _p2 = bRelativeRotation;
		Self->SaveRelativeBasedMovement(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_ServerMoveOld(ACharacter* Self, float OldTimeStamp, INT_PTR OldAccel, uint8 OldMoveFlags)
	{
		auto _p0 = OldTimeStamp;
		auto _p1 = *(FVector_NetQuantize10*)OldAccel;
		auto _p2 = OldMoveFlags;
		Self->ServerMoveOld(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_ServerMoveOld_Implementation(ACharacter* Self, float OldTimeStamp, INT_PTR OldAccel, uint8 OldMoveFlags)
	{
		auto _p0 = OldTimeStamp;
		auto _p1 = *(FVector_NetQuantize10*)OldAccel;
		auto _p2 = OldMoveFlags;
		Self->ServerMoveOld_Implementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ACharacter_ServerMoveOld_Validate(ACharacter* Self, float OldTimeStamp, INT_PTR OldAccel, uint8 OldMoveFlags)
	{
		auto _p0 = OldTimeStamp;
		auto _p1 = *(FVector_NetQuantize10*)OldAccel;
		auto _p2 = OldMoveFlags;
		return Self->ServerMoveOld_Validate(_p0, _p1, _p2);
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
		auto& _p0 = *(FHitResult*)Hit;
		return Self->ShouldNotifyLanded(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_SimulatedRootMotionPositionFixup(ACharacter* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->SimulatedRootMotionPositionFixup(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_StopAnimMontage(ACharacter* Self)
	{
		Self->StopAnimMontage();
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

	DOTNET_EXPORT auto E__Supper__ACharacter_BaseChange(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__BaseChange();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_CheckJumpInput(ACharacter* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((AManageCharacter*)Self)->_Supper__CheckJumpInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ClearJumpInput(ACharacter* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((AManageCharacter*)Self)->_Supper__ClearJumpInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ClientCheatFly_Implementation(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__ClientCheatFly_Implementation();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ClientCheatGhost_Implementation(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__ClientCheatGhost_Implementation();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ClientCheatWalk_Implementation(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__ClientCheatWalk_Implementation();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_Crouch(ACharacter* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		((AManageCharacter*)Self)->_Supper__Crouch(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_Falling(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__Falling();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_Jump(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__Jump();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_NotifyJumpApex(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__NotifyJumpApex();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnEndCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		((AManageCharacter*)Self)->_Supper__OnEndCrouch(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnJumped_Implementation(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnJumped_Implementation();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnRep_IsCrouched(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnRep_IsCrouched();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnRep_ReplicatedBasedMovement(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnRep_ReplicatedBasedMovement();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnStartCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		((AManageCharacter*)Self)->_Supper__OnStartCrouch(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ResetJumpState(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__ResetJumpState();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_StopJumping(ACharacter* Self)
	{
		((AManageCharacter*)Self)->_Supper__StopJumping();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_UnCrouch(ACharacter* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		((AManageCharacter*)Self)->_Supper__UnCrouch(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_AddControllerPitchInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageCharacter*)Self)->_Supper__AddControllerPitchInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_AddControllerRollInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageCharacter*)Self)->_Supper__AddControllerRollInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_AddControllerYawInput(APawn* Self, float Val)
	{
		auto _p0 = Val;
		((AManageCharacter*)Self)->_Supper__AddControllerYawInput(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_DestroyPlayerInputComponent(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__DestroyPlayerInputComponent();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_DetachFromControllerPendingDestroy(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__DetachFromControllerPendingDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnRep_Controller(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnRep_Controller();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnRep_PlayerState(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnRep_PlayerState();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PawnClientRestart(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__PawnClientRestart();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PawnStartFire(APawn* Self, uint8 FireModeNum)
	{
		auto _p0 = FireModeNum;
		((AManageCharacter*)Self)->_Supper__PawnStartFire(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_RecalculateBaseEyeHeight(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__RecalculateBaseEyeHeight();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_Restart(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__Restart();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_SetPlayerDefaults(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__SetPlayerDefaults();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_SpawnDefaultController(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__SpawnDefaultController();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_TurnOff(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__TurnOff();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_UnPossessed(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__UnPossessed();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_UpdateNavigationRelevance(APawn* Self)
	{
		((AManageCharacter*)Self)->_Supper__UpdateNavigationRelevance();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_BeginPlay(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_Destroyed(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ForceNetRelevant(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ForceNetUpdate(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_GatherCurrentMovement(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageCharacter*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_K2_DestroyActor(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_LifeSpanExpired(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnRep_Instigator(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnRep_Owner(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageCharacter*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OutsideWorldBounds(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostActorCreated(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostInitializeComponents(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostNetInit(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostNetReceiveRole(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostRegisterAllComponents(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PreInitializeComponents(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PreRegisterAllComponents(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageCharacter*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageCharacter*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_RegisterAllComponents(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ReregisterAllComponents(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_RerunConstructionScripts(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_Reset(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_RewindForReplay(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageCharacter*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageCharacter*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageCharacter*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_TearOff(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageCharacter*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageCharacter*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_TornOff(AActor* Self)
	{
		((AManageCharacter*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageCharacter*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_BeginDestroy(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_FinishDestroy(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostCDOContruct(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostEditImport(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostInitProperties(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostLoad(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostNetReceive(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostRepNotifies(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageCharacter*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PreDestroyFromReplication(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_PreNetReceive(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_ShutdownAfterError(UObject* Self)
	{
		((AManageCharacter*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageCharacter*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__ACharacter_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageCharacter*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
