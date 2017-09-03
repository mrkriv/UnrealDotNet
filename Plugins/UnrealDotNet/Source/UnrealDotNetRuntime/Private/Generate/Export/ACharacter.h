#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
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

	void CheckResetJumpCount_WRAP()
	{
		CheckResetJumpCount();
	}

	void ResetJumpState_WRAP()
	{
		ResetJumpState();
	}

}
;

extern "C"
{
	DOTNET_EXPORT char* E_PROP_ACharacter_CapsuleComponentName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((ACharacter*)Ptr)->CapsuleComponentName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_ACharacter_CapsuleComponentName_SET(INT_PTR Ptr, char* Value) { ((ACharacter*)Ptr)->CapsuleComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_ACharacter_CharacterMovementComponentName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((ACharacter*)Ptr)->CharacterMovementComponentName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_ACharacter_CharacterMovementComponentName_SET(INT_PTR Ptr, char* Value) { ((ACharacter*)Ptr)->CharacterMovementComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT float E_PROP_ACharacter_CrouchedEyeHeight_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->CrouchedEyeHeight; }
	DOTNET_EXPORT void E_PROP_ACharacter_CrouchedEyeHeight_SET(INT_PTR Ptr, float Value) { ((ACharacter*)Ptr)->CrouchedEyeHeight = Value; }
	
	DOTNET_EXPORT int32 E_PROP_ACharacter_JumpCurrentCount_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->JumpCurrentCount; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpCurrentCount_SET(INT_PTR Ptr, int32 Value) { ((ACharacter*)Ptr)->JumpCurrentCount = Value; }
	
	DOTNET_EXPORT float E_PROP_ACharacter_JumpKeyHoldTime_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->JumpKeyHoldTime; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpKeyHoldTime_SET(INT_PTR Ptr, float Value) { ((ACharacter*)Ptr)->JumpKeyHoldTime = Value; }
	
	DOTNET_EXPORT int32 E_PROP_ACharacter_JumpMaxCount_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->JumpMaxCount; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpMaxCount_SET(INT_PTR Ptr, int32 Value) { ((ACharacter*)Ptr)->JumpMaxCount = Value; }
	
	DOTNET_EXPORT float E_PROP_ACharacter_JumpMaxHoldTime_GET(INT_PTR Ptr) { return ((ACharacter*)Ptr)->JumpMaxHoldTime; }
	DOTNET_EXPORT void E_PROP_ACharacter_JumpMaxHoldTime_SET(INT_PTR Ptr, float Value) { ((ACharacter*)Ptr)->JumpMaxHoldTime = Value; }
	
	DOTNET_EXPORT char* E_PROP_ACharacter_MeshComponentName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((ACharacter*)Ptr)->MeshComponentName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_ACharacter_MeshComponentName_SET(INT_PTR Ptr, char* Value) { ((ACharacter*)Ptr)->MeshComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT INT_PTR E_PROP_ACharacter_RepRootMotion_GET(INT_PTR Ptr) { return (INT_PTR)&((ACharacter*)Ptr)->RepRootMotion; }
	DOTNET_EXPORT void E_PROP_ACharacter_RepRootMotion_SET(INT_PTR Ptr, INT_PTR Value) { ((ACharacter*)Ptr)->RepRootMotion = *(FRepRootMotionMontage*)Value; }
	
	DOTNET_EXPORT void E_ACharacter_BaseChange(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->BaseChange_WRAP();
	}

	DOTNET_EXPORT void E_ACharacter_CacheInitialMeshOffset(INT_PTR Self, INT_PTR MeshRelativeLocation, INT_PTR MeshRelativeRotation)
	{
		auto _p0 = *(FVector*)MeshRelativeLocation;
		auto _p1 = *(FRotator*)MeshRelativeRotation;
		((ACharacter*)Self)->CacheInitialMeshOffset(_p0, _p1);
	}

	DOTNET_EXPORT bool E_ACharacter_CanJump(INT_PTR Self)
	{
		return ((ACharacter*)Self)->CanJump();
	}

	DOTNET_EXPORT bool E_ACharacter_CanJumpInternal(INT_PTR Self)
	{
		return ((E_PROTECTED_WRAP_ACharacter*)Self)->CanJumpInternal_WRAP();
	}

	DOTNET_EXPORT void E_ACharacter_CheckJumpInput(INT_PTR Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((ACharacter*)Self)->CheckJumpInput(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_CheckResetJumpCount(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->CheckResetJumpCount_WRAP();
	}

	DOTNET_EXPORT void E_ACharacter_ClearJumpInput(INT_PTR Self)
	{
		((ACharacter*)Self)->ClearJumpInput();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatFly(INT_PTR Self)
	{
		((ACharacter*)Self)->ClientCheatFly();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatFly_Implementation(INT_PTR Self)
	{
		((ACharacter*)Self)->ClientCheatFly_Implementation();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatGhost(INT_PTR Self)
	{
		((ACharacter*)Self)->ClientCheatGhost();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatGhost_Implementation(INT_PTR Self)
	{
		((ACharacter*)Self)->ClientCheatGhost_Implementation();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatWalk(INT_PTR Self)
	{
		((ACharacter*)Self)->ClientCheatWalk();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatWalk_Implementation(INT_PTR Self)
	{
		((ACharacter*)Self)->ClientCheatWalk_Implementation();
	}

	DOTNET_EXPORT void E_ACharacter_Crouch(INT_PTR Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		((ACharacter*)Self)->Crouch(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_Falling(INT_PTR Self)
	{
		((ACharacter*)Self)->Falling();
	}

	DOTNET_EXPORT float E_ACharacter_GetAnimRootMotionTranslationScale(INT_PTR Self)
	{
		return ((ACharacter*)Self)->GetAnimRootMotionTranslationScale();
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseRotationOffsetRotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((ACharacter*)Self)->GetBaseRotationOffsetRotator());
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseTranslationOffset(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((ACharacter*)Self)->GetBaseTranslationOffset());
	}

	DOTNET_EXPORT UCapsuleComponent* E_ACharacter_GetCapsuleComponent(INT_PTR Self)
	{
		return ((ACharacter*)Self)->GetCapsuleComponent();
	}

	DOTNET_EXPORT uint8 E_ACharacter_GetReplicatedMovementMode(INT_PTR Self)
	{
		return ((ACharacter*)Self)->GetReplicatedMovementMode();
	}

	DOTNET_EXPORT float E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(INT_PTR Self)
	{
		return ((ACharacter*)Self)->GetReplicatedServerLastTransformUpdateTimeStamp();
	}

	DOTNET_EXPORT bool E_ACharacter_IsPlayingNetworkedRootMotionMontage(INT_PTR Self)
	{
		return ((ACharacter*)Self)->IsPlayingNetworkedRootMotionMontage();
	}

	DOTNET_EXPORT bool E_ACharacter_IsPlayingRootMotion(INT_PTR Self)
	{
		return ((ACharacter*)Self)->IsPlayingRootMotion();
	}

	DOTNET_EXPORT void E_ACharacter_Jump(INT_PTR Self)
	{
		((ACharacter*)Self)->Jump();
	}

	DOTNET_EXPORT void E_ACharacter_K2_OnEndCrouch(INT_PTR Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		((ACharacter*)Self)->K2_OnEndCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_K2_OnStartCrouch(INT_PTR Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		((ACharacter*)Self)->K2_OnStartCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_K2_UpdateCustomMovement(INT_PTR Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((ACharacter*)Self)->K2_UpdateCustomMovement(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_LaunchCharacter(INT_PTR Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		((ACharacter*)Self)->LaunchCharacter(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_NotifyJumpApex(INT_PTR Self)
	{
		((ACharacter*)Self)->NotifyJumpApex();
	}

	DOTNET_EXPORT void E_ACharacter_OnEndCrouch(INT_PTR Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		((ACharacter*)Self)->OnEndCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_OnJumped(INT_PTR Self)
	{
		((ACharacter*)Self)->OnJumped();
	}

	DOTNET_EXPORT void E_ACharacter_OnJumped_Implementation(INT_PTR Self)
	{
		((ACharacter*)Self)->OnJumped_Implementation();
	}

	DOTNET_EXPORT void E_ACharacter_OnLaunched(INT_PTR Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		((ACharacter*)Self)->OnLaunched(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_OnRep_IsCrouched(INT_PTR Self)
	{
		((ACharacter*)Self)->OnRep_IsCrouched();
	}

	DOTNET_EXPORT void E_ACharacter_OnRep_ReplicatedBasedMovement(INT_PTR Self)
	{
		((ACharacter*)Self)->OnRep_ReplicatedBasedMovement();
	}

	DOTNET_EXPORT void E_ACharacter_OnRep_RootMotion(INT_PTR Self)
	{
		((ACharacter*)Self)->OnRep_RootMotion();
	}

	DOTNET_EXPORT void E_ACharacter_OnStartCrouch(INT_PTR Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		((ACharacter*)Self)->OnStartCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_OnUpdateSimulatedPosition(INT_PTR Self, INT_PTR OldLocation, INT_PTR OldRotation)
	{
		auto _p0 = *(FVector*)OldLocation;
		auto _p1 = *(FQuat*)OldRotation;
		((ACharacter*)Self)->OnUpdateSimulatedPosition(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_ResetJumpState(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->ResetJumpState_WRAP();
	}

	DOTNET_EXPORT bool E_ACharacter_RestoreReplicatedMove(INT_PTR Self, INT_PTR RootMotionRepMove)
	{
		auto _p0 = *(FSimulatedRootMotionReplicatedMove*)RootMotionRepMove;
		return ((ACharacter*)Self)->RestoreReplicatedMove(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_RootMotionDebugClientPrintOnScreen(INT_PTR Self, char* InString)
	{
		auto _p0 = FString(InString);
		((ACharacter*)Self)->RootMotionDebugClientPrintOnScreen(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_RootMotionDebugClientPrintOnScreen_Implementation(INT_PTR Self, char* InString)
	{
		auto _p0 = FString(InString);
		((ACharacter*)Self)->RootMotionDebugClientPrintOnScreen_Implementation(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_SaveRelativeBasedMovement(INT_PTR Self, INT_PTR NewRelativeLocation, INT_PTR NewRotation, bool bRelativeRotation)
	{
		auto _p0 = *(FVector*)NewRelativeLocation;
		auto _p1 = *(FRotator*)NewRotation;
		auto _p2 = bRelativeRotation;
		((ACharacter*)Self)->SaveRelativeBasedMovement(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_SetAnimRootMotionTranslationScale(INT_PTR Self, float InAnimRootMotionTranslationScale)
	{
		auto _p0 = InAnimRootMotionTranslationScale;
		((ACharacter*)Self)->SetAnimRootMotionTranslationScale(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_SetBase(INT_PTR Self, UPrimitiveComponent* NewBase, char* BoneName, bool bNotifyActor)
	{
		auto _p0 = NewBase;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bNotifyActor;
		((ACharacter*)Self)->SetBase(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_SimulatedRootMotionPositionFixup(INT_PTR Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((ACharacter*)Self)->SimulatedRootMotionPositionFixup(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_StopJumping(INT_PTR Self)
	{
		((ACharacter*)Self)->StopJumping();
	}

	DOTNET_EXPORT void E_ACharacter_UnCrouch(INT_PTR Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		((ACharacter*)Self)->UnCrouch(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_UpdateFromCompressedFlags(INT_PTR Self, uint8 Flags)
	{
		auto _p0 = Flags;
		((ACharacter*)Self)->UpdateFromCompressedFlags(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_UpdateSimulatedPosition(INT_PTR Self, INT_PTR Location, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)NewRotation;
		((ACharacter*)Self)->UpdateSimulatedPosition(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
