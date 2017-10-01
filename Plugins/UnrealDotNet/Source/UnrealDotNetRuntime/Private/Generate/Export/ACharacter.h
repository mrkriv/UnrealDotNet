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

	DOTNET_EXPORT INT_PTR E_PROP_ACharacter_RepRootMotion_GET(INT_PTR Ptr) { return (INT_PTR)&((ACharacter*)Ptr)->RepRootMotion; }
	DOTNET_EXPORT void E_PROP_ACharacter_RepRootMotion_SET(INT_PTR Ptr, INT_PTR Value) { ((ACharacter*)Ptr)->RepRootMotion = *(FRepRootMotionMontage*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ACharacter(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ACharacter>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_ACharacter_BaseChange(ACharacter* Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->BaseChange_WRAP();
	}

	DOTNET_EXPORT void E_ACharacter_CacheInitialMeshOffset(ACharacter* Self, INT_PTR MeshRelativeLocation, INT_PTR MeshRelativeRotation)
	{
		auto _p0 = *(FVector*)MeshRelativeLocation;
		auto _p1 = *(FRotator*)MeshRelativeRotation;
		(Self)->CacheInitialMeshOffset(_p0, _p1);
	}

	DOTNET_EXPORT bool E_ACharacter_CanJump(ACharacter* Self)
	{
		return (Self)->CanJump();
	}

	DOTNET_EXPORT bool E_ACharacter_CanJumpInternal(ACharacter* Self)
	{
		return ((E_PROTECTED_WRAP_ACharacter*)Self)->CanJumpInternal_WRAP();
	}

	DOTNET_EXPORT void E_ACharacter_CheckJumpInput(ACharacter* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		(Self)->CheckJumpInput(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_CheckResetJumpCount(ACharacter* Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->CheckResetJumpCount_WRAP();
	}

	DOTNET_EXPORT void E_ACharacter_ClearJumpInput(ACharacter* Self)
	{
		(Self)->ClearJumpInput();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatFly(ACharacter* Self)
	{
		(Self)->ClientCheatFly();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatFly_Implementation(ACharacter* Self)
	{
		(Self)->ClientCheatFly_Implementation();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatGhost(ACharacter* Self)
	{
		(Self)->ClientCheatGhost();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatGhost_Implementation(ACharacter* Self)
	{
		(Self)->ClientCheatGhost_Implementation();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatWalk(ACharacter* Self)
	{
		(Self)->ClientCheatWalk();
	}

	DOTNET_EXPORT void E_ACharacter_ClientCheatWalk_Implementation(ACharacter* Self)
	{
		(Self)->ClientCheatWalk_Implementation();
	}

	DOTNET_EXPORT void E_ACharacter_Crouch(ACharacter* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		(Self)->Crouch(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_Falling(ACharacter* Self)
	{
		(Self)->Falling();
	}

	DOTNET_EXPORT float E_ACharacter_GetAnimRootMotionTranslationScale(ACharacter* Self)
	{
		return (Self)->GetAnimRootMotionTranslationScale();
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseRotationOffsetRotator(ACharacter* Self)
	{
		return (INT_PTR) new FRotator((Self)->GetBaseRotationOffsetRotator());
	}

	DOTNET_EXPORT INT_PTR E_ACharacter_GetBaseTranslationOffset(ACharacter* Self)
	{
		return (INT_PTR) new FVector((Self)->GetBaseTranslationOffset());
	}

	DOTNET_EXPORT ObjectPointerDescription E_ACharacter_GetCapsuleComponent(ACharacter* Self)
	{
		return MakePrtDesc((Self)->GetCapsuleComponent());
	}

	DOTNET_EXPORT ObjectPointerDescription E_ACharacter_GetMesh(ACharacter* Self)
	{
		return MakePrtDesc((Self)->GetMesh());
	}

	DOTNET_EXPORT uint8 E_ACharacter_GetReplicatedMovementMode(ACharacter* Self)
	{
		return (Self)->GetReplicatedMovementMode();
	}

	DOTNET_EXPORT float E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(ACharacter* Self)
	{
		return (Self)->GetReplicatedServerLastTransformUpdateTimeStamp();
	}

	DOTNET_EXPORT bool E_ACharacter_IsPlayingNetworkedRootMotionMontage(ACharacter* Self)
	{
		return (Self)->IsPlayingNetworkedRootMotionMontage();
	}

	DOTNET_EXPORT bool E_ACharacter_IsPlayingRootMotion(ACharacter* Self)
	{
		return (Self)->IsPlayingRootMotion();
	}

	DOTNET_EXPORT void E_ACharacter_Jump(ACharacter* Self)
	{
		(Self)->Jump();
	}

	DOTNET_EXPORT void E_ACharacter_K2_OnEndCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		(Self)->K2_OnEndCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_K2_OnMovementModeChanged(ACharacter* Self, EMovementMode PrevMovementMode, EMovementMode NewMovementMode, uint8 PrevCustomMode, uint8 NewCustomMode)
	{
		auto _p0 = PrevMovementMode;
		auto _p1 = NewMovementMode;
		auto _p2 = PrevCustomMode;
		auto _p3 = NewCustomMode;
		(Self)->K2_OnMovementModeChanged(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_ACharacter_K2_OnStartCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		(Self)->K2_OnStartCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_K2_UpdateCustomMovement(ACharacter* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		(Self)->K2_UpdateCustomMovement(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_LaunchCharacter(ACharacter* Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		(Self)->LaunchCharacter(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_NotifyJumpApex(ACharacter* Self)
	{
		(Self)->NotifyJumpApex();
	}

	DOTNET_EXPORT void E_ACharacter_OnEndCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		(Self)->OnEndCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_OnJumped(ACharacter* Self)
	{
		(Self)->OnJumped();
	}

	DOTNET_EXPORT void E_ACharacter_OnJumped_Implementation(ACharacter* Self)
	{
		(Self)->OnJumped_Implementation();
	}

	DOTNET_EXPORT void E_ACharacter_OnLaunched(ACharacter* Self, INT_PTR LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		auto _p0 = *(FVector*)LaunchVelocity;
		auto _p1 = bXYOverride;
		auto _p2 = bZOverride;
		(Self)->OnLaunched(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_OnMovementModeChanged(ACharacter* Self, EMovementMode PrevMovementMode, uint8 PreviousCustomMode)
	{
		auto _p0 = PrevMovementMode;
		auto _p1 = PreviousCustomMode;
		(Self)->OnMovementModeChanged(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_OnRep_IsCrouched(ACharacter* Self)
	{
		(Self)->OnRep_IsCrouched();
	}

	DOTNET_EXPORT void E_ACharacter_OnRep_ReplicatedBasedMovement(ACharacter* Self)
	{
		(Self)->OnRep_ReplicatedBasedMovement();
	}

	DOTNET_EXPORT void E_ACharacter_OnRep_RootMotion(ACharacter* Self)
	{
		(Self)->OnRep_RootMotion();
	}

	DOTNET_EXPORT void E_ACharacter_OnStartCrouch(ACharacter* Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		auto _p0 = HalfHeightAdjust;
		auto _p1 = ScaledHalfHeightAdjust;
		(Self)->OnStartCrouch(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_OnUpdateSimulatedPosition(ACharacter* Self, INT_PTR OldLocation, INT_PTR OldRotation)
	{
		auto _p0 = *(FVector*)OldLocation;
		auto _p1 = *(FQuat*)OldRotation;
		(Self)->OnUpdateSimulatedPosition(_p0, _p1);
	}

	DOTNET_EXPORT void E_ACharacter_ResetJumpState(ACharacter* Self)
	{
		((E_PROTECTED_WRAP_ACharacter*)Self)->ResetJumpState_WRAP();
	}

	DOTNET_EXPORT bool E_ACharacter_RestoreReplicatedMove(ACharacter* Self, INT_PTR RootMotionRepMove)
	{
		auto _p0 = *(FSimulatedRootMotionReplicatedMove*)RootMotionRepMove;
		return (Self)->RestoreReplicatedMove(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_RootMotionDebugClientPrintOnScreen(ACharacter* Self, char* InString)
	{
		auto _p0 = FString(InString);
		(Self)->RootMotionDebugClientPrintOnScreen(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_RootMotionDebugClientPrintOnScreen_Implementation(ACharacter* Self, char* InString)
	{
		auto _p0 = FString(InString);
		(Self)->RootMotionDebugClientPrintOnScreen_Implementation(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_SaveRelativeBasedMovement(ACharacter* Self, INT_PTR NewRelativeLocation, INT_PTR NewRotation, bool bRelativeRotation)
	{
		auto _p0 = *(FVector*)NewRelativeLocation;
		auto _p1 = *(FRotator*)NewRotation;
		auto _p2 = bRelativeRotation;
		(Self)->SaveRelativeBasedMovement(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_SetAnimRootMotionTranslationScale(ACharacter* Self, float InAnimRootMotionTranslationScale)
	{
		auto _p0 = InAnimRootMotionTranslationScale;
		(Self)->SetAnimRootMotionTranslationScale(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_SetBase(ACharacter* Self, UPrimitiveComponent* NewBase, char* BoneName, bool bNotifyActor)
	{
		auto _p0 = NewBase;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bNotifyActor;
		(Self)->SetBase(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_ACharacter_SimulatedRootMotionPositionFixup(ACharacter* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		(Self)->SimulatedRootMotionPositionFixup(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_StopJumping(ACharacter* Self)
	{
		(Self)->StopJumping();
	}

	DOTNET_EXPORT void E_ACharacter_UnCrouch(ACharacter* Self, bool bClientSimulation)
	{
		auto _p0 = bClientSimulation;
		(Self)->UnCrouch(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_UpdateFromCompressedFlags(ACharacter* Self, uint8 Flags)
	{
		auto _p0 = Flags;
		(Self)->UpdateFromCompressedFlags(_p0);
	}

	DOTNET_EXPORT void E_ACharacter_UpdateSimulatedPosition(ACharacter* Self, INT_PTR Location, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)NewRotation;
		(Self)->UpdateSimulatedPosition(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
