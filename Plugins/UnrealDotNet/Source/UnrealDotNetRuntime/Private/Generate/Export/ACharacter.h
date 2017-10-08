#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "GameFramework/Character.h"

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

	void CheckResetJumpCount_WRAP()
	{
		CheckResetJumpCount();
	}

	bool DoJump_WRAP(bool bReplayingMoves)
	{
		return DoJump(bReplayingMoves);
	}

	void ResetJumpState_WRAP()
	{
		ResetJumpState();
	}

}
;

extern "C"
{
	
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

	DOTNET_EXPORT auto E_ACharacter_CheckResetJumpCount(ACharacter* Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->CheckResetJumpCount_WRAP();
	}

	DOTNET_EXPORT auto E_ACharacter_ClearJumpInput(ACharacter* Self)
	{
		Self->ClearJumpInput();
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

	DOTNET_EXPORT auto E_ACharacter_Crouch(ACharacter* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		Self->Crouch(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_DoJump(ACharacter* Self, bool bReplayingMoves)
	{
		auto _p0 = bReplayingMoves;
		return ((E_PROTECTED_WRAP_ACharacter*)Self)->DoJump_WRAP(_p0);
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

	DOTNET_EXPORT auto E_ACharacter_IsJumping(ACharacter* Self)
	{
		return Self->IsJumping();
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

	DOTNET_EXPORT auto E_ACharacter_NotifyLanded(ACharacter* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return Self->NotifyLanded(_p0);
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

	DOTNET_EXPORT auto E_ACharacter_ResetJumpState(ACharacter* Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->ResetJumpState_WRAP();
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

	DOTNET_EXPORT auto E_ACharacter_UpdateFromCompressedFlags(ACharacter* Self, uint8 Flags)
	{
		auto _p0 = Flags;
		Self->UpdateFromCompressedFlags(_p0);
	}

	DOTNET_EXPORT auto E_ACharacter_UpdateSimulatedPosition(ACharacter* Self, INT_PTR Location, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)NewRotation;
		Self->UpdateSimulatedPosition(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
