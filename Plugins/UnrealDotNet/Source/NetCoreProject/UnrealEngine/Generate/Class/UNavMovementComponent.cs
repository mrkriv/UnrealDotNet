using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

namespace UnrealEngine
{
	public  partial class UNavMovementComponent : UMovementComponent
	{
		public UNavMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UNavMovementComponent(UObject Parent = null, string Name = "NavMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UNavMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UNavMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverCrouch(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverFly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverJump(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverMoveOnGround(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanEverSwim(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanStartPathFollowing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanStopPathFollowing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_ClearFixedBrakingDistance(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorFeetLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorFeetLocationBased(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetActorNavLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_GetPathFollowingBrakingDistance(IntPtr Self, float MaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsCrouching(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsFalling(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsFlying(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsJumpAllowed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsMovingOnGround(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsSwimming(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_RequestDirectMove(IntPtr Self, IntPtr MoveVelocity, bool bForceMaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_RequestPathMove(IntPtr Self, IntPtr MoveInput);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_ResetMoveState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetFixedBrakingDistance(IntPtr Self, float DistanceToEndOfPath);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetJumpAllowed(IntPtr Self, bool bAllowed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetUpdateNavAgentWithOwnersCollisions(IntPtr Self, bool bUpdateWithOwner);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_ShouldUpdateNavAgentWithOwnersCollision(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_StopActiveMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_StopMovementImmediately(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_StopMovementKeepPathing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_UseAccelerationForPathFollowing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_AddRadialForce(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_AddRadialImpulse(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_ComputeSlideVector(IntPtr Self, IntPtr Delta, float Time, IntPtr Normal, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_ConstrainDirectionToPlane(IntPtr Self, IntPtr Direction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_ConstrainLocationToPlane(IntPtr Self, IntPtr Location);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_ConstrainNormalToPlane(IntPtr Self, IntPtr Normal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_Deactivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_GetGravityZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_GetMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_GetMaxSpeedModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_GetModifiedMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UNavMovementComponent_GetPenetrationAdjustment(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_HandleImpact(IntPtr Self, IntPtr Hit, float TimeSlice, IntPtr MoveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_InitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsExceedingMaxSpeed(IntPtr Self, float MaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsInWater(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_K2_GetMaxSpeedModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_K2_GetModifiedMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_MoveUpdatedComponentImpl(IntPtr Self, IntPtr Delta, IntPtr NewRotation, bool bSweep, IntPtr OutHit, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_OnRegister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_OnTeleported(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_RegisterComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_ResolvePenetrationImpl(IntPtr Self, IntPtr Adjustment, IntPtr Hit, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetPlaneConstraintAxisSetting(IntPtr Self, byte NewAxisSetting);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetPlaneConstraintEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetPlaneConstraintFromVectors(IntPtr Self, IntPtr Forward, IntPtr Up);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetPlaneConstraintNormal(IntPtr Self, IntPtr PlaneNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetPlaneConstraintOrigin(IntPtr Self, IntPtr PlaneOrigin);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetUpdatedComponent(IntPtr Self, IntPtr NewUpdatedComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_ShouldSkipUpdate(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavMovementComponent_SlideAlongSurface(IntPtr Self, IntPtr Delta, float Time, IntPtr Normal, IntPtr Hit, bool bHandleImpact);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SnapUpdatedComponentToPlane(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_TwoWallAdjust(IntPtr Self, IntPtr Delta, IntPtr Hit, IntPtr OldHitNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_UpdateComponentVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_UpdateTickRegistration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_Activate(IntPtr Self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_CreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_DestroyComponent(IntPtr Self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_DestroyRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_GetComponentClassCanReplicate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UNavMovementComponent_GetReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_HasValidPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_InvalidateLightingCacheDetailed(IntPtr Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsNavigationRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsReadyForOwnerToAutoDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_OnActorEnableCollisionChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_OnComponentCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_OnComponentDestroyed(IntPtr Self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_OnCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_OnDestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_OnUnregister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_RequiresGameThreadEndOfFrameRecreate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_RequiresGameThreadEndOfFrameUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SendRenderDynamicData_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SendRenderTransform_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetActive(IntPtr Self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetAutoActivate(IntPtr Self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetComponentTickEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_SetComponentTickEnabledAsync(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_ShouldActivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_ShouldCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_ShouldCreateRenderState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_ToggleActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_UninitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_UpdateComponentToWorld(IntPtr Self, byte UpdateTransformFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UNavMovementComponent_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UNavMovementComponent_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavMovementComponent_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavMovementComponent_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <return>true if component can crouch </return>
		/// </summary>
		public bool CanEverCrouch()
			=> E_UNavMovementComponent_CanEverCrouch(this);
		
		
		/// <summary>
		/// <return>true if component can fly </return>
		/// </summary>
		public bool CanEverFly()
			=> E_UNavMovementComponent_CanEverFly(this);
		
		
		/// <summary>
		/// <return>true if component can jump </return>
		/// </summary>
		public bool CanEverJump()
			=> E_UNavMovementComponent_CanEverJump(this);
		
		
		/// <summary>
		/// <return>true if component can move along the ground (walk, drive, etc) </return>
		/// </summary>
		public bool CanEverMoveOnGround()
			=> E_UNavMovementComponent_CanEverMoveOnGround(this);
		
		
		/// <summary>
		/// <return>true if component can swim </return>
		/// </summary>
		public bool CanEverSwim()
			=> E_UNavMovementComponent_CanEverSwim(this);
		
		
		/// <summary>
		/// <return>true if path following can start </return>
		/// </summary>
		public virtual bool CanStartPathFollowing()
			=> E_UNavMovementComponent_CanStartPathFollowing(this);
		
		
		/// <summary>
		/// <para>check if current move target can be reached right now if positions are matching </para>
		/// <para>(e.g. performing scripted move and can't stop) </para>
		/// </summary>
		public virtual bool CanStopPathFollowing()
			=> E_UNavMovementComponent_CanStopPathFollowing(this);
		
		
		/// <summary>
		/// <para>clears fixed braking distance </para>
		/// </summary>
		public void ClearFixedBrakingDistance()
			=> E_UNavMovementComponent_ClearFixedBrakingDistance(this);
		
		
		/// <summary>
		/// <para>@returns location of controlled actor's "feet" meaning center of bottom of collision bounding box </para>
		/// </summary>
		public FVector GetActorFeetLocation()
			=> E_UNavMovementComponent_GetActorFeetLocation(this);
		
		
		/// <summary>
		/// <para>@returns based location of controlled actor </para>
		/// </summary>
		public virtual FBasedPosition GetActorFeetLocationBased()
			=> E_UNavMovementComponent_GetActorFeetLocationBased(this);
		
		
		/// <summary>
		/// <para>@returns location of controlled actor - meaning center of collision bounding box </para>
		/// </summary>
		public FVector GetActorLocation()
			=> E_UNavMovementComponent_GetActorLocation(this);
		
		
		/// <summary>
		/// <para>@returns navigation location of controlled actor </para>
		/// </summary>
		public FVector GetActorNavLocation()
			=> E_UNavMovementComponent_GetActorNavLocation(this);
		
		
		/// <summary>
		/// <para>@returns braking distance for acceleration driven path following </para>
		/// </summary>
		public virtual float GetPathFollowingBrakingDistance(float MaxSpeed)
			=> E_UNavMovementComponent_GetPathFollowingBrakingDistance(this, MaxSpeed);
		
		
		/// <summary>
		/// <return>true if currently crouching </return>
		/// </summary>
		public virtual bool IsCrouching()
			=> E_UNavMovementComponent_IsCrouching(this);
		
		
		/// <summary>
		/// <return>true if currently falling (not flying, in a non-fluid volume, and not on the ground) </return>
		/// </summary>
		public virtual bool IsFalling()
			=> E_UNavMovementComponent_IsFalling(this);
		
		
		/// <summary>
		/// <return>true if currently flying (moving through a non-fluid volume without resting on the ground) </return>
		/// </summary>
		public virtual bool IsFlying()
			=> E_UNavMovementComponent_IsFlying(this);
		
		
		/// <summary>
		/// <return>true if component is allowed to jump </return>
		/// </summary>
		public bool IsJumpAllowed()
			=> E_UNavMovementComponent_IsJumpAllowed(this);
		
		
		/// <summary>
		/// <return>true if currently moving on the ground (e.g. walking or driving) </return>
		/// </summary>
		public virtual bool IsMovingOnGround()
			=> E_UNavMovementComponent_IsMovingOnGround(this);
		
		
		/// <summary>
		/// <return>true if currently swimming (moving through a fluid volume) </return>
		/// </summary>
		public virtual bool IsSwimming()
			=> E_UNavMovementComponent_IsSwimming(this);
		
		
		/// <summary>
		/// <para>path following: request new velocity </para>
		/// </summary>
		public virtual void RequestDirectMove(FVector MoveVelocity, bool bForceMaxSpeed)
			=> E_UNavMovementComponent_RequestDirectMove(this, MoveVelocity, bForceMaxSpeed);
		
		
		/// <summary>
		/// <para>path following: request new move input (normal vector = full strength) </para>
		/// </summary>
		public virtual void RequestPathMove(FVector MoveInput)
			=> E_UNavMovementComponent_RequestPathMove(this, MoveInput);
		
		
		/// <summary>
		/// <para>Resets runtime movement state to character's movement capabilities </para>
		/// </summary>
		public void ResetMoveState()
			=> E_UNavMovementComponent_ResetMoveState(this);
		
		
		/// <summary>
		/// <para>set fixed braking distance </para>
		/// </summary>
		public void SetFixedBrakingDistance(float DistanceToEndOfPath)
			=> E_UNavMovementComponent_SetFixedBrakingDistance(this, DistanceToEndOfPath);
		
		
		/// <summary>
		/// <param name="bAllowed">true if component is allowed to jump </param>
		/// </summary>
		public void SetJumpAllowed(bool bAllowed)
			=> E_UNavMovementComponent_SetJumpAllowed(this, bAllowed);
		
		public void SetUpdateNavAgentWithOwnersCollisions(bool bUpdateWithOwner)
			=> E_UNavMovementComponent_SetUpdateNavAgentWithOwnersCollisions(this, bUpdateWithOwner);
		
		public bool ShouldUpdateNavAgentWithOwnersCollision()
			=> E_UNavMovementComponent_ShouldUpdateNavAgentWithOwnersCollision(this);
		
		
		/// <summary>
		/// <para>Stops applying further movement (usually zeros acceleration). </para>
		/// </summary>
		public virtual void StopActiveMovement()
			=> E_UNavMovementComponent_StopActiveMovement(this);
		
		public override void StopMovementImmediately()
			=> E_UNavMovementComponent_StopMovementImmediately(this);
		
		
		/// <summary>
		/// <para>Stops movement immediately (reset velocity) but keeps following current path </para>
		/// </summary>
		public void StopMovementKeepPathing()
			=> E_UNavMovementComponent_StopMovementKeepPathing(this);
		
		public bool UseAccelerationForPathFollowing()
			=> E_UNavMovementComponent_UseAccelerationForPathFollowing(this);
		
		
		/// <summary>
		/// <para>Adds force from radial force components. </para>
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// <param name="Origin">The origin of the force </param>
		/// <param name="Radius">The radius in which the force will be applied </param>
		/// <param name="Strength">The strength of the force </param>
		/// <param name="Falloff">The falloff from the force's origin </param>
		/// </summary>
		public override void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
			=> E_UNavMovementComponent_AddRadialForce(this, Origin, Radius, Strength, (byte)Falloff);
		
		
		/// <summary>
		/// <para>Adds impulse from radial force components. </para>
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// <param name="Origin">The origin of the force </param>
		/// <param name="Radius">The radius in which the force will be applied </param>
		/// <param name="Strength">The strength of the force </param>
		/// <param name="Falloff">The falloff from the force's origin </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
			=> E_UNavMovementComponent_AddRadialImpulse(this, Origin, Radius, Strength, (byte)Falloff, bVelChange);
		
		
		/// <summary>
		/// <para>Compute a vector to slide along a surface, given an attempted move, time, and normal. </para>
		/// <param name="Delta">Attempted move. </param>
		/// <param name="Time">Amount of move to apply (between 0 and 1). </param>
		/// <param name="Normal">Normal opposed to movement. Not necessarily equal to Hit.Normal. </param>
		/// <param name="Hit">HitResult of the move that resulted in the slide. </param>
		/// </summary>
		public override FVector ComputeSlideVector(FVector Delta, float Time, FVector Normal, FHitResult Hit)
			=> E_UNavMovementComponent_ComputeSlideVector(this, Delta, Time, Normal, Hit);
		
		
		/// <summary>
		/// <para>Constrain a direction vector to the plane constraint, if enabled. </para>
		/// <para>@see SetPlaneConstraint </para>
		/// </summary>
		public override FVector ConstrainDirectionToPlane(FVector Direction)
			=> E_UNavMovementComponent_ConstrainDirectionToPlane(this, Direction);
		
		
		/// <summary>
		/// <para>Constrain a position vector to the plane constraint, if enabled. </para>
		/// </summary>
		public override FVector ConstrainLocationToPlane(FVector Location)
			=> E_UNavMovementComponent_ConstrainLocationToPlane(this, Location);
		
		
		/// <summary>
		/// <para>Constrain a normal vector (of unit length) to the plane constraint, if enabled. </para>
		/// </summary>
		public override FVector ConstrainNormalToPlane(FVector Normal)
			=> E_UNavMovementComponent_ConstrainNormalToPlane(this, Normal);
		
		public override void Deactivate()
			=> E_UNavMovementComponent_Deactivate(this);
		
		
		/// <summary>
		/// <return>gravity that affects this component </return>
		/// </summary>
		public override float GetGravityZ()
			=> E_UNavMovementComponent_GetGravityZ(this);
		
		
		/// <summary>
		/// <return>Maximum speed of component in current movement mode. </return>
		/// </summary>
		public override float GetMaxSpeed()
			=> E_UNavMovementComponent_GetMaxSpeed(this);
		
		
		/// <summary>
		/// <return>a scalar applied to the maximum velocity that the component can currently move. </return>
		/// </summary>
		public override float GetMaxSpeedModifier()
			=> E_UNavMovementComponent_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// <return>the result of GetMaxSpeed() * GetMaxSpeedModifier(). </return>
		/// </summary>
		public override float GetModifiedMaxSpeed()
			=> E_UNavMovementComponent_GetModifiedMaxSpeed(this);
		
		
		/// <summary>
		/// <para>Calculate a movement adjustment to try to move out of a penetration from a failed move. </para>
		/// <param name="Hit">the result of the failed move </param>
		/// <return>The adjustment to use after a failed move, or a zero vector if no attempt should be made. </return>
		/// </summary>
		public override FVector GetPenetrationAdjustment(FHitResult Hit)
			=> E_UNavMovementComponent_GetPenetrationAdjustment(this, Hit);
		
		
		/// <summary>
		/// <para>Called for Blocking impact </para>
		/// <param name="Hit">Describes the collision. </param>
		/// <param name="TimeSlice">Time period for the simulation that produced this hit.  Useful for </param>
		/// <para>putting Hit.Time in context.  Can be zero in certain situations where it's not appropriate, </para>
		/// <para>be sure to handle that. </para>
		/// <param name="MoveDelta">Attempted move that resulted in the hit. </param>
		/// </summary>
		public override void HandleImpact(FHitResult Hit, float TimeSlice, FVector MoveDelta)
			=> E_UNavMovementComponent_HandleImpact(this, Hit, TimeSlice, MoveDelta);
		
		
		/// <summary>
		/// <para>Overridden to auto-register the updated component if it starts NULL, and we can find a root component on our owner. </para>
		/// </summary>
		public override void InitializeComponent()
			=> E_UNavMovementComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// <para>Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance. </para>
		/// <para>Note that under normal circumstances updates cause by acceleration will not cause this to be true, however external forces or changes in the max speed limit </para>
		/// <para>can cause the max speed to be violated. </para>
		/// </summary>
		public override bool IsExceedingMaxSpeed(float MaxSpeed)
			=> E_UNavMovementComponent_IsExceedingMaxSpeed(this, MaxSpeed);
		
		
		/// <summary>
		/// <para>return true if it's in PhysicsVolume with water flag </para>
		/// </summary>
		public override bool IsInWater()
			=> E_UNavMovementComponent_IsInWater(this);
		
		
		/// <summary>
		/// <return>a scalar applied to the maximum velocity that the component can currently move. </return>
		/// </summary>
		public override float K2_GetMaxSpeedModifier()
			=> E_UNavMovementComponent_K2_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// <return>the result of GetMaxSpeed() * GetMaxSpeedModifier(). </return>
		/// </summary>
		public override float K2_GetModifiedMaxSpeed()
			=> E_UNavMovementComponent_K2_GetModifiedMaxSpeed(this);
		
		protected override bool MoveUpdatedComponentImpl(FVector Delta, FQuat NewRotation, bool bSweep, FHitResult OutHit, ETeleportType Teleport)
			=> E_UNavMovementComponent_MoveUpdatedComponentImpl(this, Delta, NewRotation, bSweep, OutHit, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Overridden to update component properties that should be updated while being edited. </para>
		/// </summary>
		public override void OnRegister()
			=> E_UNavMovementComponent_OnRegister(this);
		
		
		/// <summary>
		/// <para>Called by owning Actor upon successful teleport from AActor::TeleportTo(). </para>
		/// </summary>
		public override void OnTeleported()
			=> E_UNavMovementComponent_OnTeleported(this);
		
		public override void PostLoad()
			=> E_UNavMovementComponent_PostLoad(this);
		
		public override void RegisterComponentTickFunctions(bool bRegister)
			=> E_UNavMovementComponent_RegisterComponentTickFunctions(this, bRegister);
		
		protected override bool ResolvePenetrationImpl(FVector Adjustment, FHitResult Hit, FQuat NewRotation)
			=> E_UNavMovementComponent_ResolvePenetrationImpl(this, Adjustment, Hit, NewRotation);
		
		
		/// <summary>
		/// <para>Set the plane constraint axis setting. </para>
		/// <para>Changing this setting will modify the current value of PlaneConstraintNormal. </para>
		/// <param name="NewAxisSetting">New plane constraint axis setting. </param>
		/// </summary>
		public override void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
			=> E_UNavMovementComponent_SetPlaneConstraintAxisSetting(this, (byte)NewAxisSetting);
		
		
		/// <summary>
		/// <para>Sets whether or not the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintEnabled(bool bEnabled)
			=> E_UNavMovementComponent_SetPlaneConstraintEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
			=> E_UNavMovementComponent_SetPlaneConstraintFromVectors(this, Forward, Up);
		
		
		/// <summary>
		/// <para>Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// <para>Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom". </para>
		/// <param name="PlaneNormal">The normal of the plane. If non-zero in length, it will be normalized. </param>
		/// </summary>
		public override void SetPlaneConstraintNormal(FVector PlaneNormal)
			=> E_UNavMovementComponent_SetPlaneConstraintNormal(this, PlaneNormal);
		
		
		/// <summary>
		/// <para>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintOrigin(FVector PlaneOrigin)
			=> E_UNavMovementComponent_SetPlaneConstraintOrigin(this, PlaneOrigin);
		
		
		/// <summary>
		/// <para>Assign the component we move and update. </para>
		/// </summary>
		public override void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
			=> E_UNavMovementComponent_SetUpdatedComponent(this, NewUpdatedComponent);
		
		
		/// <summary>
		/// <para>Possibly skip update if moved component is not rendered or can't move. </para>
		/// <param name="DeltaTime">todo this parameter is not used in the function. </param>
		/// <return>true if component movement update should be skipped </return>
		/// </summary>
		public override bool ShouldSkipUpdate(float DeltaTime)
			=> E_UNavMovementComponent_ShouldSkipUpdate(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Slide smoothly along a surface, and slide away from multiple impacts using TwoWallAdjust if necessary. Calls HandleImpact for each surface hit, if requested. </para>
		/// <para>Uses SafeMoveUpdatedComponent() for movement, and ComputeSlideVector() to determine the slide direction. </para>
		/// <param name="Delta">Attempted movement vector. </param>
		/// <param name="Time">Percent of Delta to apply (between 0 and 1). Usually equal to the remaining time after a collision: (1.0 - Hit.Time). </param>
		/// <param name="Normal">Normal opposing movement, along which we will slide. </param>
		/// <param name="Hit">In] HitResult of the attempted move that resulted in the impact triggering the slide. [Out] HitResult of last attempted move. </param>
		/// <param name="bHandleImpact">Whether to call HandleImpact on each hit. </param>
		/// <return>The percentage of requested distance (Delta * Percent) actually applied (between 0 and 1). 0 if no movement occurred, non-zero if movement occurred. </return>
		/// </summary>
		public override float SlideAlongSurface(FVector Delta, float Time, FVector Normal, FHitResult Hit, bool bHandleImpact)
			=> E_UNavMovementComponent_SlideAlongSurface(this, Delta, Time, Normal, Hit, bHandleImpact);
		
		
		/// <summary>
		/// <para>Snap the updated component to the plane constraint, if enabled. </para>
		/// </summary>
		public override void SnapUpdatedComponentToPlane()
			=> E_UNavMovementComponent_SnapUpdatedComponentToPlane(this);
		
		
		/// <summary>
		/// <para>Compute a movement direction when contacting two surfaces. </para>
		/// <param name="Delta">In] Amount of move attempted before impact. [Out] Computed adjustment based on impacts. </param>
		/// <param name="Hit">Impact from last attempted move </param>
		/// <param name="OldHitNormal">Normal of impact before last attempted move </param>
		/// <return>Result in Delta that is the direction to move when contacting two surfaces. </return>
		/// </summary>
		public override void TwoWallAdjust(FVector Delta, FHitResult Hit, FVector OldHitNormal)
			=> E_UNavMovementComponent_TwoWallAdjust(this, Delta, Hit, OldHitNormal);
		
		
		/// <summary>
		/// <para>Update ComponentVelocity of UpdatedComponent. This needs to be called by derived classes at the end of an update whenever Velocity has changed. </para>
		/// </summary>
		public override void UpdateComponentVelocity()
			=> E_UNavMovementComponent_UpdateComponentVelocity(this);
		
		
		/// <summary>
		/// <para>Update tick registration state, determined by bAutoUpdateTickRegistration. Called by SetUpdatedComponent. </para>
		/// </summary>
		public override void UpdateTickRegistration()
			=> E_UNavMovementComponent_UpdateTickRegistration(this);
		
		
		/// <summary>
		/// <para>Activates the SceneComponent </para>
		/// <param name="bReset">The value to assign to HiddenGame. </param>
		/// </summary>
		public override void Activate(bool bReset)
			=> E_UNavMovementComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UNavMovementComponent_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UNavMovementComponent_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Called by owner actor on position shifting </para>
		/// <para>Component should update all relevant data structures to reflect new actor location </para>
		/// <param name="InWorldOffset">Offset vector the actor shifted by </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_UNavMovementComponent_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		public override void BeginDestroy()
			=> E_UNavMovementComponent_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>BeginsPlay for the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// <para>Actor/Component gets BeginPlay. </para>
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public override void BeginPlay()
			=> E_UNavMovementComponent_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Used to create any rendering thread information for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void CreateRenderState_Concurrent()
			=> E_UNavMovementComponent_CreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>Unregister the component, remove it from its outer Actor's Components array and mark for pending kill. </para>
		/// </summary>
		public override void DestroyComponent(bool bPromoteChildren)
			=> E_UNavMovementComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void DestroyRenderState_Concurrent()
			=> E_UNavMovementComponent_DestroyRenderState_Concurrent(this);
		
		public override bool GetComponentClassCanReplicate()
			=> E_UNavMovementComponent_GetComponentClassCanReplicate(this);
		
		
		/// <summary>
		/// <para>Returns a readable name for this component, including the asset name if applicable </para>
		/// <para>By default this appends a space plus AdditionalStatObject() </para>
		/// </summary>
		public override string GetReadableName()
			=> E_UNavMovementComponent_GetReadableName(this);
		
		
		/// <summary>
		/// <para>Used to check that DestroyPhysicsState() is working correctly </para>
		/// </summary>
		public override bool HasValidPhysicsState()
			=> E_UNavMovementComponent_HasValidPhysicsState(this);
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E_UNavMovementComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns whether the component is active or not </para>
		/// <return>The active state of the component. </return>
		/// </summary>
		public override bool IsActive()
			=> E_UNavMovementComponent_IsActive(this);
		
		
		/// <summary>
		/// <para>Returns whether this component is an editor-only object or not </para>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_UNavMovementComponent_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_UNavMovementComponent_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>override to supply actual logic </para>
		/// </summary>
		public override bool IsNavigationRelevant()
			=> E_UNavMovementComponent_IsNavigationRelevant(this);
		
		
		/// <summary>
		/// <para>Overridable check for a component to indicate to its Owner that it should prevent the Actor from auto destroying when finished </para>
		/// </summary>
		public override bool IsReadyForOwnerToAutoDestroy()
			=> E_UNavMovementComponent_IsReadyForOwnerToAutoDestroy(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_UNavMovementComponent_IsSupportedForNetworking(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_UNavMovementComponent_MarkAsEditorOnlySubobject(this);
		
		public override bool NeedsLoadForClient()
			=> E_UNavMovementComponent_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_UNavMovementComponent_NeedsLoadForEditorGame(this);
		
		public override bool NeedsLoadForServer()
			=> E_UNavMovementComponent_NeedsLoadForServer(this);
		
		
		/// <summary>
		/// <para>Called on each component when the Actor's bEnableCollisionChanged flag changes </para>
		/// </summary>
		public override void OnActorEnableCollisionChanged()
			=> E_UNavMovementComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public override void OnComponentCreated()
			=> E_UNavMovementComponent_OnComponentCreated(this);
		
		
		/// <summary>
		/// <para>Called when a component is destroyed </para>
		/// <param name="bDestroyingHierarchy">True if the entire component hierarchy is being torn down, allows avoiding expensive operations </param>
		/// </summary>
		public override void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E_UNavMovementComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		
		/// <summary>
		/// <para>Used to create any physics engine information for this component </para>
		/// </summary>
		protected override void OnCreatePhysicsState()
			=> E_UNavMovementComponent_OnCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down and physics engine structure for this component </para>
		/// </summary>
		protected override void OnDestroyPhysicsState()
			=> E_UNavMovementComponent_OnDestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called. </para>
		/// </summary>
		public override void OnUnregister()
			=> E_UNavMovementComponent_OnUnregister(this);
		
		public override void PostInitProperties()
			=> E_UNavMovementComponent_PostInitProperties(this);
		
		public override void PostNetReceive()
			=> E_UNavMovementComponent_PostNetReceive(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_UNavMovementComponent_PostRename(this, OldOuter, OldName);
		
		public override void PreNetReceive()
			=> E_UNavMovementComponent_PreNetReceive(this);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UNavMovementComponent_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UNavMovementComponent_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame recreates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameRecreate()
			=> E_UNavMovementComponent_RequiresGameThreadEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame updates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameUpdates()
			=> E_UNavMovementComponent_RequiresGameThreadEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected override void SendRenderDynamicData_Concurrent()
			=> E_UNavMovementComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the rendering thread </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void SendRenderTransform_Concurrent()
			=> E_UNavMovementComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// </summary>
		public override void SetActive(bool bNewActive, bool bReset)
			=> E_UNavMovementComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public override void SetAutoActivate(bool bNewAutoActivate)
			=> E_UNavMovementComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabled(bool bEnabled)
			=> E_UNavMovementComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabledAsync(bool bEnabled)
			=> E_UNavMovementComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// <para>"Trigger" related function. Return true if it should activate </para>
		/// </summary>
		protected override bool ShouldActivate()
			=> E_UNavMovementComponent_ShouldActivate(this);
		
		
		/// <summary>
		/// <para>Return true if CreatePhysicsState() should be called. </para>
		/// <para>Ideally CreatePhysicsState() should always succeed if this returns true, but this isn't currently the case </para>
		/// </summary>
		public override bool ShouldCreatePhysicsState()
			=> E_UNavMovementComponent_ShouldCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Return true if CreateRenderState() should be called </para>
		/// </summary>
		public override bool ShouldCreateRenderState()
			=> E_UNavMovementComponent_ShouldCreateRenderState(this);
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public override void ToggleActive()
			=> E_UNavMovementComponent_ToggleActive(this);
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent()
			=> E_UNavMovementComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// <para>Recalculate the value of our component to world transform </para>
		/// </summary>
		public override void UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
			=> E_UNavMovementComponent_UpdateComponentToWorld(this, (byte)UpdateTransformFlags, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_UNavMovementComponent_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public override bool CheckDefaultSubobjectsInternal()
			=> E_UNavMovementComponent_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E_UNavMovementComponent_FinishDestroy(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_UNavMovementComponent_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_UNavMovementComponent_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_UNavMovementComponent_IsAsset(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_UNavMovementComponent_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_UNavMovementComponent_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_UNavMovementComponent_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the </para>
		/// <para>potentially asynchronous object cleanup. </para>
		/// <return>True if the object's asynchronous cleanup has completed and it is ready for FinishDestroy to be called. </return>
		/// </summary>
		public override bool IsReadyForFinishDestroy()
			=> E_UNavMovementComponent_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_UNavMovementComponent_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_UNavMovementComponent_Modify(this, bAlwaysMarkDirty);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_UNavMovementComponent_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_UNavMovementComponent_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_UNavMovementComponent_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies()
			=> E_UNavMovementComponent_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UNavMovementComponent_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_UNavMovementComponent_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_UNavMovementComponent_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_UNavMovementComponent_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_UNavMovementComponent_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public override bool CanBeInCluster()
			=> E_UNavMovementComponent_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_UNavMovementComponent_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_UNavMovementComponent_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(UNavMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UNavMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UNavMovementComponent>(PtrDesc);
		}}}
