using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USceneComponent : UActorComponent
	{
		public USceneComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USceneComponent(UObject Parent = null, string Name = "SceneComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddLocalOffset(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddLocalTransform(IntPtr Self, IntPtr DeltaTransform, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddRelativeLocation(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddWorldOffset(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddWorldTransform(IntPtr Self, IntPtr DeltaTransform, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_AreDynamicDataChangesAllowed(IntPtr Self, bool bIgnoreStationary);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_AttachToComponent(IntPtr Self, IntPtr InParent, IntPtr AttachmentRules, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_CalcBoundingCylinder(IntPtr Self, float CylinderRadius, float CylinderHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_CalcNewComponentToWorld(IntPtr Self, IntPtr NewRelativeTransform, IntPtr Parent, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_CalcNewComponentToWorld_GeneralCase(IntPtr Self, IntPtr NewRelativeTransform, IntPtr Parent, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_CanAttachAsChild(IntPtr Self, IntPtr ChildComponent, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_CanEverRender(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_CheckStaticMobilityAndWarn(IntPtr Self, string ActionText);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_ConditionalUpdateComponentToWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_DetachFromComponent(IntPtr Self, IntPtr DetachmentRules);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_DetachFromParent(IntPtr Self, bool bMaintainWorldPosition, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_DoesSocketExist(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetAttachmentRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetAttachmentRootActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetAttachParent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USceneComponent_GetAttachSocketName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetChildComponent(IntPtr Self, int ChildIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USceneComponent_GetCollisionObjectType(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USceneComponent_GetCollisionResponseToChannel(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USceneComponent_GetCollisionResponseToComponent(IntPtr Self, IntPtr OtherComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentQuat(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USceneComponent_GetDefaultSceneRootVariableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetForwardVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USceneComponent_GetNumChildrenComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetRelativeTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetRightVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetSocketLocation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetSocketQuaternion(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetSocketRotation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetSocketTransform(IntPtr Self, string InSocketName, byte TransformSpace);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetUpVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_HasAnySockets(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_InternalSetWorldLocationAndRotation(IntPtr Self, IntPtr NewLocation, IntPtr NewQuat, bool bNoPhysics, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsAnySimulatingPhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsAttachedTo(IntPtr Self, IntPtr TestComp);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsDeferringMovementUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsPhysicsCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsPrecomputedLightingValid(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsQueryCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsSimulatingPhysics(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsVisible(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsVisibleInEditor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsWorldGeometry(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddLocalOffset(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddLocalRotation(IntPtr Self, IntPtr DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddLocalTransform(IntPtr Self, IntPtr DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddRelativeLocation(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddRelativeRotation(IntPtr Self, IntPtr DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddWorldOffset(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddWorldRotation(IntPtr Self, IntPtr DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddWorldTransform(IntPtr Self, IntPtr DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_K2_AttachToComponent(IntPtr Self, IntPtr Parent, string SocketName, byte LocationRule, byte RotationRule, byte ScaleRule, bool bWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_DetachFromComponent(IntPtr Self, byte LocationRule, byte RotationRule, byte ScaleRule, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentToWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetRelativeLocation(IntPtr Self, IntPtr NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetRelativeLocationAndRotation(IntPtr Self, IntPtr NewLocation, IntPtr NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetRelativeRotation(IntPtr Self, IntPtr NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetRelativeTransform(IntPtr Self, IntPtr NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetWorldLocation(IntPtr Self, IntPtr NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetWorldLocationAndRotation(IntPtr Self, IntPtr NewLocation, IntPtr NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetWorldRotation(IntPtr Self, IntPtr NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetWorldTransform(IntPtr Self, IntPtr NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_MoveComponentImpl(IntPtr Self, IntPtr Delta, IntPtr NewRotation, bool bSweep, IntPtr Hit, byte MoveFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnAttachmentChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnChildAttached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnChildDetached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnHiddenInGameChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnUpdateTransform(IntPtr Self, byte UpdateTransformFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnVisibilityChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_PostUpdateNavigationData(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_PropagateLightingScenarioChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_ResetRelativeTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetAbsolute(IntPtr Self, bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetComponentToWorld(IntPtr Self, IntPtr NewComponentToWorld);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetHiddenInGame(IntPtr Self, bool NewHidden, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeLocation(IntPtr Self, IntPtr NewLocation, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeRotationCache(IntPtr Self, IntPtr InCache);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeTransform(IntPtr Self, IntPtr NewTransform, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetupAttachment(IntPtr Self, IntPtr InParent, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetVisibility(IntPtr Self, bool bNewVisibility, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldLocation(IntPtr Self, IntPtr NewLocation, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldLocationAndRotationNoPhysics(IntPtr Self, IntPtr NewLocation, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldScale3D(IntPtr Self, IntPtr NewScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldTransform(IntPtr Self, IntPtr NewTransform, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldCollideWhenPlacing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldComponentAddToScene(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldRender(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_SnapTo(IntPtr Self, IntPtr InParent, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_ToggleVisibility(IntPtr Self, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_UpdateBounds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_UpdateChildTransforms(IntPtr Self, byte UpdateTransformFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_UpdateNavigationData(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_UpdatePhysicsVolume(IntPtr Self, bool bTriggerNotifiers);
		
		#endregion
		
		#region ExternMethods
		public void AddLocalOffset(FVector DeltaLocation, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_USceneComponent_AddLocalOffset(this, DeltaLocation, bSweep, OutSweepHitResult, (byte)Teleport);
		
		public void AddLocalTransform(FTransform DeltaTransform, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_USceneComponent_AddLocalTransform(this, DeltaTransform, bSweep, OutSweepHitResult, (byte)Teleport);
		
		public void AddRelativeLocation(FVector DeltaLocation, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_USceneComponent_AddRelativeLocation(this, DeltaLocation, bSweep, OutSweepHitResult, (byte)Teleport);
		
		public void AddWorldOffset(FVector DeltaLocation, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_USceneComponent_AddWorldOffset(this, DeltaLocation, bSweep, OutSweepHitResult, (byte)Teleport);
		
		public void AddWorldTransform(FTransform DeltaTransform, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_USceneComponent_AddWorldTransform(this, DeltaTransform, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Determine if dynamic data is allowed to be changed. </para>
		/// <param name="bIgnoreStationary">Whether or not to ignore stationary mobility when checking. Default is true (i.e. - check for static mobility only). </param>
		/// <return>Whether or not dynamic data is allowed to be changed. </return>
		/// </summary>
		protected bool AreDynamicDataChangesAllowed(bool bIgnoreStationary = true)
			=> E_USceneComponent_AreDynamicDataChangesAllowed(this, bIgnoreStationary);
		
		
		/// <summary>
		/// <para>Attach this component to another scene component, optionally at a named socket. It is valid to call this on components whether or not they have been Registered, however from </para>
		/// <para>constructor or when not registered it is preferable to use SetupAttachment. </para>
		/// <param name="Parent">Parent to attach to. </param>
		/// <param name="AttachmentRules">How to handle transforms & welding when attaching. </param>
		/// <param name="SocketName">Optional socket to attach to on the parent. </param>
		/// <return>True if attachment is successful (or already attached to requested parent/socket), false if attachment is rejected and there is no change in AttachParent. </return>
		/// </summary>
		public bool AttachToComponent(USceneComponent InParent, FAttachmentTransformRules AttachmentRules, string InSocketName)
			=> E_USceneComponent_AttachToComponent(this, InParent, AttachmentRules, InSocketName);
		
		
		/// <summary>
		/// <para>Calculate the axis-aligned bounding cylinder of the component (radius in X-Y, half-height along Z axis). </para>
		/// <para>Default behavior is just a cylinder around the box of the cached BoxSphereBounds. </para>
		/// </summary>
		public virtual void CalcBoundingCylinder(float CylinderRadius, float CylinderHalfHeight)
			=> E_USceneComponent_CalcBoundingCylinder(this, CylinderRadius, CylinderHalfHeight);
		
		
		/// <summary>
		/// <para>Calculate the new ComponentToWorld transform for this component. </para>
		/// <para>Parent is optional and can be used for computing ComponentToWorld based on arbitrary USceneComponent. </para>
		/// <para>If Parent is not passed in we use the component's AttachParent </para>
		/// </summary>
		protected FTransform CalcNewComponentToWorld(FTransform NewRelativeTransform, USceneComponent Parent, string SocketName)
			=> E_USceneComponent_CalcNewComponentToWorld(this, NewRelativeTransform, Parent, SocketName);
		
		protected FTransform CalcNewComponentToWorld_GeneralCase(FTransform NewRelativeTransform, USceneComponent Parent, string SocketName)
			=> E_USceneComponent_CalcNewComponentToWorld_GeneralCase(this, NewRelativeTransform, Parent, SocketName);
		
		
		/// <summary>
		/// <para>Called to see if it's possible to attach another scene component as a child. </para>
		/// <para>Note: This can be called on template component as well! </para>
		/// </summary>
		public virtual bool CanAttachAsChild(USceneComponent ChildComponent, string SocketName)
			=> E_USceneComponent_CanAttachAsChild(this, ChildComponent, SocketName);
		
		
		/// <summary>
		/// <para>return true if it can ever render </para>
		/// </summary>
		public bool CanEverRender()
			=> E_USceneComponent_CanEverRender(this);
		
		
		/// <summary>
		/// <para>Check if mobility is set to non-static. If it's static we trigger a PIE warning and return true </para>
		/// </summary>
		protected bool CheckStaticMobilityAndWarn(string ActionText)
			=> E_USceneComponent_CheckStaticMobilityAndWarn(this, ActionText);
		
		public void ConditionalUpdateComponentToWorld()
			=> E_USceneComponent_ConditionalUpdateComponentToWorld(this);
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="DetachmentRules">How to handle transforms & modification when detaching. </param>
		/// </summary>
		public virtual void DetachFromComponent(FDetachmentTransformRules DetachmentRules)
			=> E_USceneComponent_DetachFromComponent(this, DetachmentRules);
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="bMaintainWorldPosition">If true, update the relative location of the component to keep its world position the same </param>
		/// <param name="bCallModify">If true, call Modify() on the component and the current attach parent component </param>
		/// </summary>
		public virtual void DetachFromParentDeprecated(bool bMaintainWorldPosition, bool bCallModify)
			=> E_USceneComponent_DetachFromParent(this, bMaintainWorldPosition, bCallModify);
		
		
		/// <summary>
		/// <para>return true if socket with the given name exists </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>true if the socket with the given name exists. Otherwise, return false </return>
		/// </summary>
		public virtual bool DoesSocketExist(string InSocketName)
			=> E_USceneComponent_DoesSocketExist(this, InSocketName);
		
		
		/// <summary>
		/// <para>Walks up the attachment chain from this SceneComponent and returns the SceneComponent at the top. If AttachParent is NULL, returns this. </para>
		/// </summary>
		public USceneComponent GetAttachmentRoot()
			=> E_USceneComponent_GetAttachmentRoot(this);
		
		
		/// <summary>
		/// <para>Walks up the attachment chain from this SceneComponent and returns the top-level actor it's attached to.  Returns Owner if unattached. </para>
		/// </summary>
		public AActor GetAttachmentRootActor()
			=> E_USceneComponent_GetAttachmentRootActor(this);
		
		
		/// <summary>
		/// <para>Get the SceneComponent we are attached to. </para>
		/// </summary>
		public USceneComponent GetAttachParent()
			=> E_USceneComponent_GetAttachParent(this);
		
		
		/// <summary>
		/// <para>Get the socket we are attached to. </para>
		/// </summary>
		public string GetAttachSocketName()
			=> E_USceneComponent_GetAttachSocketName(this);
		
		
		/// <summary>
		/// <para>Gets the attached child component at the specified location </para>
		/// </summary>
		public USceneComponent GetChildComponent(int ChildIndex)
			=> E_USceneComponent_GetChildComponent(this, ChildIndex);
		
		
		/// <summary>
		/// <para>Returns the channel that this component belongs to when it moves. </para>
		/// </summary>
		public virtual ECollisionChannel GetCollisionObjectType()
			=> (ECollisionChannel)E_USceneComponent_GetCollisionObjectType(this);
		
		
		/// <summary>
		/// <para>Returns the response that this component has to a specific collision channel. </para>
		/// </summary>
		public virtual ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel)
			=> (ECollisionResponse)E_USceneComponent_GetCollisionResponseToChannel(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Compares the CollisionObjectType of each component against the Response of the other, to see what kind of response we should generate </para>
		/// </summary>
		public ECollisionResponse GetCollisionResponseToComponent(USceneComponent OtherComponent)
			=> (ECollisionResponse)E_USceneComponent_GetCollisionResponseToComponent(this, OtherComponent);
		
		
		/// <summary>
		/// <para>Return location of the component, in world space </para>
		/// </summary>
		public FVector GetComponentLocation()
			=> E_USceneComponent_GetComponentLocation(this);
		
		
		/// <summary>
		/// <para>Return rotation quaternion of the component, in world space </para>
		/// </summary>
		public FQuat GetComponentQuat()
			=> E_USceneComponent_GetComponentQuat(this);
		
		
		/// <summary>
		/// <para>Return rotation of the component, in world space </para>
		/// </summary>
		public FRotator GetComponentRotation()
			=> E_USceneComponent_GetComponentRotation(this);
		
		
		/// <summary>
		/// <para>Return scale of the component, in world space </para>
		/// </summary>
		public FVector GetComponentScale()
			=> E_USceneComponent_GetComponentScale(this);
		
		
		/// <summary>
		/// <para>Get velocity of the component: either ComponentVelocity, or the velocity of the physics body if simulating physics. </para>
		/// <return>Velocity of the component </return>
		/// </summary>
		public virtual FVector GetComponentVelocity()
			=> E_USceneComponent_GetComponentVelocity(this);
		
		
		/// <summary>
		/// <para>The name to use for the default scene root variable </para>
		/// </summary>
		public string GetDefaultSceneRootVariableName()
			=> E_USceneComponent_GetDefaultSceneRootVariableName(this);
		
		
		/// <summary>
		/// <para>Get the forward (X) unit direction vector from this component, in world space. </para>
		/// </summary>
		public FVector GetForwardVector()
			=> E_USceneComponent_GetForwardVector(this);
		
		
		/// <summary>
		/// <para>Gets the number of attached children components </para>
		/// </summary>
		public int GetNumChildrenComponents()
			=> E_USceneComponent_GetNumChildrenComponents(this);
		
		
		/// <summary>
		/// <para>Returns the transform of the component relative to its parent </para>
		/// </summary>
		public FTransform GetRelativeTransform()
			=> E_USceneComponent_GetRelativeTransform(this);
		
		
		/// <summary>
		/// <para>Get the right (Y) unit direction vector from this component, in world space. </para>
		/// </summary>
		public FVector GetRightVector()
			=> E_USceneComponent_GetRightVector(this);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone location. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public virtual FVector GetSocketLocation(string InSocketName)
			=> E_USceneComponent_GetSocketLocation(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone FQuat rotation. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public virtual FQuat GetSocketQuaternion(string InSocketName)
			=> E_USceneComponent_GetSocketQuaternion(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone  FRotator rotation. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public virtual FRotator GetSocketRotation(string InSocketName)
			=> E_USceneComponent_GetSocketRotation(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket transform. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public virtual FTransform GetSocketTransform(string InSocketName, ERelativeTransformSpace TransformSpace)
			=> E_USceneComponent_GetSocketTransform(this, InSocketName, (byte)TransformSpace);
		
		
		/// <summary>
		/// <para>Get the up (Z) unit direction vector from this component, in world space. </para>
		/// </summary>
		public FVector GetUpVector()
			=> E_USceneComponent_GetUpVector(this);
		
		
		/// <summary>
		/// <para>Returns true if this component has any sockets </para>
		/// </summary>
		public virtual bool HasAnySockets()
			=> E_USceneComponent_HasAnySockets(this);
		
		
		/// <summary>
		/// <para>Internal helper, for use from MoveComponent().  Special codepath since the normal setters call MoveComponent. </para>
		/// <return>true if location or rotation was changed. </return>
		/// </summary>
		protected bool InternalSetWorldLocationAndRotation(FVector NewLocation, FQuat NewQuat, bool bNoPhysics, ETeleportType Teleport)
			=> E_USceneComponent_InternalSetWorldLocationAndRotation(this, NewLocation, NewQuat, bNoPhysics, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Returns whether the specified body is currently using physics simulation </para>
		/// </summary>
		public virtual bool IsAnySimulatingPhysics()
			=> E_USceneComponent_IsAnySimulatingPhysics(this);
		
		
		/// <summary>
		/// <para>Walks up the attachment chain to see if this component is attached to the supplied component. If TestComp == this, returns false. </para>
		/// </summary>
		public bool IsAttachedTo(USceneComponent TestComp)
			=> E_USceneComponent_IsAttachedTo(this, TestComp);
		
		
		/// <summary>
		/// <para>Utility to see if there is any form of collision (query or physics) enabled on this component. </para>
		/// </summary>
		public bool IsCollisionEnabled()
			=> E_USceneComponent_IsCollisionEnabled(this);
		
		
		/// <summary>
		/// <para>Returns true if movement is currently within the scope of an FScopedMovementUpdate. </para>
		/// </summary>
		public bool IsDeferringMovementUpdates()
			=> E_USceneComponent_IsDeferringMovementUpdates(this);
		
		
		/// <summary>
		/// <para>Utility to see if there is any physics collision enabled on this component. </para>
		/// </summary>
		public bool IsPhysicsCollisionEnabled()
			=> E_USceneComponent_IsPhysicsCollisionEnabled(this);
		
		public virtual bool IsPrecomputedLightingValid()
			=> E_USceneComponent_IsPrecomputedLightingValid(this);
		
		
		/// <summary>
		/// <para>Utility to see if there is any query collision enabled on this component. </para>
		/// </summary>
		public bool IsQueryCollisionEnabled()
			=> E_USceneComponent_IsQueryCollisionEnabled(this);
		
		
		/// <summary>
		/// <para>Returns whether the specified body is currently using physics simulation </para>
		/// </summary>
		public virtual bool IsSimulatingPhysics(string BoneName)
			=> E_USceneComponent_IsSimulatingPhysics(this, BoneName);
		
		
		/// <summary>
		/// <para>Is this component visible or not in game </para>
		/// <return>true if visible </return>
		/// </summary>
		public virtual bool IsVisible()
			=> E_USceneComponent_IsVisible(this);
		
		
		/// <summary>
		/// <para>Return true if visible in editor </para>
		/// </summary>
		public virtual bool IsVisibleInEditor()
			=> E_USceneComponent_IsVisibleInEditor(this);
		
		
		/// <summary>
		/// <para>Is this component considered 'world' geometry </para>
		/// </summary>
		public virtual bool IsWorldGeometry()
			=> E_USceneComponent_IsWorldGeometry(this);
		
		
		/// <summary>
		/// <para>Adds a delta to the location of the component in its local reference frame </para>
		/// <param name="DeltaLocation">Change in location of the component in its local reference frame. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void K2_AddLocalOffset(FVector DeltaLocation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddLocalOffset(this, DeltaLocation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the rotation of the component in its local reference frame </para>
		/// <param name="DeltaRotation">Change in rotation of the component in its local reference frame. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation). </param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// </summary>
		public void AddLocalRotation(FRotator DeltaRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddLocalRotation(this, DeltaRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the transform of the component in its local reference frame. Scale is unchanged. </para>
		/// <param name="DeltaTransform">Change in transform of the component in its local reference frame. Scale is unchanged. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void K2_AddLocalTransform(FTransform DeltaTransform, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddLocalTransform(this, DeltaTransform, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the translation of the component relative to its parent </para>
		/// <param name="DeltaLocation">Change in location of the component relative to its parent </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void K2_AddRelativeLocation(FVector DeltaLocation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddRelativeLocation(this, DeltaLocation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta the rotation of the component relative to its parent </para>
		/// <param name="DeltaRotation">Change in rotation of the component relative to is parent. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation). </param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// </summary>
		public void AddRelativeRotation(FRotator DeltaRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddRelativeRotation(this, DeltaRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the location of the component in world space. </para>
		/// <param name="DeltaLocation">Change in location in world space for the component. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void K2_AddWorldOffset(FVector DeltaLocation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddWorldOffset(this, DeltaLocation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the rotation of the component in world space. </para>
		/// <param name="DeltaRotation">Change in rotation in world space for the component. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation). </param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void AddWorldRotation(FRotator DeltaRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddWorldRotation(this, DeltaRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the transform of the component in world space. Scale is unchanged. </para>
		/// <param name="DeltaTransform">Change in transform in world space for the component. Scale is unchanged. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void K2_AddWorldTransform(FTransform DeltaTransform, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddWorldTransform(this, DeltaTransform, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Attach this component to another scene component, optionally at a named socket. It is valid to call this on components whether or not they have been Registered. </para>
		/// <param name="Parent">Parent to attach to. </param>
		/// <param name="SocketName">Optional socket to attach to on the parent. </param>
		/// <param name="LocationRule">How to handle translation when attaching. </param>
		/// <param name="RotationRule">How to handle rotation when attaching. </param>
		/// <param name="ScaleRule">How to handle scale when attaching. </param>
		/// <param name="bWeldSimulatedBodies">Whether to weld together simulated physics bodies. </param>
		/// <return>True if attachment is successful (or already attached to requested parent/socket), false if attachment is rejected and there is no change in AttachParent. </return>
		/// </summary>
		public bool K2_AttachToComponent(USceneComponent Parent, string SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
			=> E_USceneComponent_K2_AttachToComponent(this, Parent, SocketName, (byte)LocationRule, (byte)RotationRule, (byte)ScaleRule, bWeldSimulatedBodies);
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="LocationRule">How to handle translations when detaching. </param>
		/// <param name="RotationRule">How to handle rotation when detaching. </param>
		/// <param name="ScaleRule">How to handle scales when detaching. </param>
		/// <param name="bCallModify">If true, call Modify() on the component and the current attach parent component </param>
		/// </summary>
		public void K2_DetachFromComponent(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, bool bCallModify = true)
			=> E_USceneComponent_K2_DetachFromComponent(this, (byte)LocationRule, (byte)RotationRule, (byte)ScaleRule, bCallModify);
		
		
		/// <summary>
		/// <para>Return location of the component, in world space </para>
		/// </summary>
		public FVector GetWorldLocation()
			=> E_USceneComponent_K2_GetComponentLocation(this);
		
		
		/// <summary>
		/// <para>Returns rotation of the component, in world space. </para>
		/// </summary>
		public FRotator GetWorldRotation()
			=> E_USceneComponent_K2_GetComponentRotation(this);
		
		
		/// <summary>
		/// <para>Returns scale of the component, in world space. </para>
		/// </summary>
		public FVector GetWorldScale()
			=> E_USceneComponent_K2_GetComponentScale(this);
		
		
		/// <summary>
		/// <para>Get the current component-to-world transform for this component </para>
		/// </summary>
		public FTransform GetWorldTransform()
			=> E_USceneComponent_K2_GetComponentToWorld(this);
		
		
		/// <summary>
		/// <para>Set the location of the component relative to its parent </para>
		/// <param name="NewLocation">New location of the component relative to its parent. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void K2_SetRelativeLocation(FVector NewLocation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetRelativeLocation(this, NewLocation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Set the location and rotation of the component relative to its parent </para>
		/// <param name="NewLocation">New location of the component relative to its parent. </param>
		/// <param name="NewRotation">New rotation of the component relative to its parent. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void SetRelativeLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetRelativeLocationAndRotation(this, NewLocation, NewRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Set the rotation of the component relative to its parent </para>
		/// <param name="NewRotation">New rotation of the component relative to its parent </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation). </param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// </summary>
		public void SetRelativeRotation(FRotator NewRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetRelativeRotation(this, NewRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Set the transform of the component relative to its parent </para>
		/// <param name="NewTransform">New transform of the component relative to its parent. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation). </param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// </summary>
		public void K2_SetRelativeTransform(FTransform NewTransform, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetRelativeTransform(this, NewTransform, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Put this component at the specified location in world space. Updates relative location to achieve the final world location. </para>
		/// <param name="NewLocation">New location in world space for the component. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void K2_SetWorldLocation(FVector NewLocation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetWorldLocation(this, NewLocation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Set the relative location and rotation of the component to put it at the supplied pose in world space. </para>
		/// <param name="NewLocation">New location in world space for the component. </param>
		/// <param name="NewRotation">New rotation in world space for the component. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void SetWorldLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetWorldLocationAndRotation(this, NewLocation, NewRotation, bSweep, SweepHitResult, bTeleport);
		
		public void SetWorldRotation(FRotator NewRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetWorldRotation(this, NewRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Set the transform of the component in world space. </para>
		/// <param name="NewTransform">New transform in world space for the component. </param>
		/// <param name="SweepHitResult">Hit result from any impact if sweep is true. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		public void K2_SetWorldTransform(FTransform NewTransform, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetWorldTransform(this, NewTransform, bSweep, SweepHitResult, bTeleport);
		
		protected virtual bool MoveComponentImpl(FVector Delta, FQuat NewRotation, bool bSweep, FHitResult Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
			=> E_USceneComponent_MoveComponentImpl(this, Delta, NewRotation, bSweep, Hit, (byte)MoveFlags, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Called when AttachParent changes, to allow the scene to update its attachment state. </para>
		/// </summary>
		public virtual void OnAttachmentChanged()
			=> E_USceneComponent_OnAttachmentChanged(this);
		
		
		/// <summary>
		/// <para>Called after a child scene component is attached to this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected virtual void OnChildAttached(USceneComponent ChildComponent)
			=> E_USceneComponent_OnChildAttached(this, ChildComponent);
		
		
		/// <summary>
		/// <para>Called after a child scene component is detached from this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected virtual void OnChildDetached(USceneComponent ChildComponent)
			=> E_USceneComponent_OnChildDetached(this, ChildComponent);
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the hidden in game value of the component. </para>
		/// </summary>
		protected virtual void OnHiddenInGameChanged()
			=> E_USceneComponent_OnHiddenInGameChanged(this);
		
		protected virtual void OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
			=> E_USceneComponent_OnUpdateTransform(this, (byte)UpdateTransformFlags, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the visibility of the component. </para>
		/// </summary>
		protected virtual void OnVisibilityChanged()
			=> E_USceneComponent_OnVisibilityChanged(this);
		
		
		/// <summary>
		/// <para>Called after changing transform, tries to update navigation octree for owner </para>
		/// </summary>
		protected void PostUpdateNavigationData()
			=> E_USceneComponent_PostUpdateNavigationData(this);
		
		public virtual void PropagateLightingScenarioChange()
			=> E_USceneComponent_PropagateLightingScenarioChange(this);
		
		
		/// <summary>
		/// <para>Reset the transform of the component relative to its parent. Sets relative location to zero, relative rotation to no rotation, and Scale to 1. </para>
		/// </summary>
		public void ResetRelativeTransform()
			=> E_USceneComponent_ResetRelativeTransform(this);
		
		
		/// <summary>
		/// <para>Set which parts of the relative transform should be relative to parent, and which should be relative to world </para>
		/// </summary>
		public void SetAbsolute(bool bNewAbsoluteLocation = false, bool bNewAbsoluteRotation = false, bool bNewAbsoluteScale = false)
			=> E_USceneComponent_SetAbsolute(this, bNewAbsoluteLocation, bNewAbsoluteRotation, bNewAbsoluteScale);
		
		
		/// <summary>
		/// <para>Sets the cached component to world directly. This should be used very rarely. </para>
		/// </summary>
		public void SetComponentToWorld(FTransform NewComponentToWorld)
			=> E_USceneComponent_SetComponentToWorld(this, NewComponentToWorld);
		
		
		/// <summary>
		/// <para>Changes the value of HiddenGame. </para>
		/// <param name="NewHidden">The value to assign to HiddenGame. </param>
		/// </summary>
		public void SetHiddenInGame(bool NewHidden, bool bPropagateToChildren = false)
			=> E_USceneComponent_SetHiddenInGame(this, NewHidden, bPropagateToChildren);
		
		public void SetRelativeLocation(FVector NewLocation, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_USceneComponent_SetRelativeLocation(this, NewLocation, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Sets the RelativeRotationCache. Used to ensure component ends up with the same RelativeRotation after calling SetWorldTransform(). </para>
		/// </summary>
		public void SetRelativeRotationCache(FRotationConversionCache InCache)
			=> E_USceneComponent_SetRelativeRotationCache(this, InCache);
		
		
		/// <summary>
		/// <para>Set the non-uniform scale of the component relative to its parent </para>
		/// </summary>
		public virtual void SetRelativeScale3D(FVector NewScale3D)
			=> E_USceneComponent_SetRelativeScale3D(this, NewScale3D);
		
		public void SetRelativeTransform(FTransform NewTransform, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_USceneComponent_SetRelativeTransform(this, NewTransform, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Initializes desired Attach Parent and SocketName to be attached to when the component is registered. </para>
		/// <para>Generally intended to be called from its Owning Actor's constructor and should be preferred over AttachToComponent when </para>
		/// <para>a component is not registered. </para>
		/// <param name="InParent">Parent to attach to. </param>
		/// <param name="InSocketName">Optional socket to attach to on the parent. </param>
		/// </summary>
		public void SetupAttachment(USceneComponent InParent, string InSocketName)
			=> E_USceneComponent_SetupAttachment(this, InParent, InSocketName);
		
		
		/// <summary>
		/// <para>Set visibility of the component, if during game use this to turn on/off </para>
		/// </summary>
		public void SetVisibility(bool bNewVisibility, bool bPropagateToChildren = false)
			=> E_USceneComponent_SetVisibility(this, bNewVisibility, bPropagateToChildren);
		
		public void SetWorldLocation(FVector NewLocation, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_USceneComponent_SetWorldLocation(this, NewLocation, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Special version of SetWorldLocationAndRotation that does not affect physics. </para>
		/// </summary>
		public void SetWorldLocationAndRotationNoPhysics(FVector NewLocation, FRotator NewRotation)
			=> E_USceneComponent_SetWorldLocationAndRotationNoPhysics(this, NewLocation, NewRotation);
		
		
		/// <summary>
		/// <para>Set the relative scale of the component to put it at the supplied scale in world space. </para>
		/// <param name="NewScale">New scale in world space for this component. </param>
		/// </summary>
		public void SetWorldScale3D(FVector NewScale)
			=> E_USceneComponent_SetWorldScale3D(this, NewScale);
		
		public void SetWorldTransform(FTransform NewTransform, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_USceneComponent_SetWorldTransform(this, NewTransform, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>If true, bounds should be used when placing component/actor in level. Does not affect spawning. </para>
		/// </summary>
		public virtual bool ShouldCollideWhenPlacing()
			=> E_USceneComponent_ShouldCollideWhenPlacing(this);
		
		
		/// <summary>
		/// <para>Looking at various values of the component, determines if this </para>
		/// <para>component should be added to the scene </para>
		/// <return>true if the component is visible and should be added to the scene, false otherwise </return>
		/// </summary>
		public bool ShouldComponentAddToScene()
			=> E_USceneComponent_ShouldComponentAddToScene(this);
		
		
		/// <summary>
		/// <para>return true if it should render </para>
		/// </summary>
		public bool ShouldRender()
			=> E_USceneComponent_ShouldRender(this);
		
		
		/// <summary>
		/// <para>Zeroes out the relative transform of the component, and calls AttachTo(). Useful for attaching directly to a scene component or socket location </para>
		/// </summary>
		public bool SnapTo(USceneComponent InParent, string InSocketName)
			=> E_USceneComponent_SnapTo(this, InParent, InSocketName);
		
		
		/// <summary>
		/// <para>Toggle visibility of the component </para>
		/// </summary>
		public void ToggleVisibility(bool bPropagateToChildren = false)
			=> E_USceneComponent_ToggleVisibility(this, bPropagateToChildren);
		
		
		/// <summary>
		/// <para>Update the Bounds of the component. </para>
		/// </summary>
		public void UpdateBounds()
			=> E_USceneComponent_UpdateBounds(this);
		
		
		/// <summary>
		/// <para>Update transforms of any components attached to this one. </para>
		/// </summary>
		public void UpdateChildTransforms(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
			=> E_USceneComponent_UpdateChildTransforms(this, (byte)UpdateTransformFlags, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Called after changing transform, tries to update navigation octree for this component </para>
		/// </summary>
		protected void UpdateNavigationData()
			=> E_USceneComponent_UpdateNavigationData(this);
		
		
		/// <summary>
		/// <para>Updates the PhysicsVolume of this SceneComponent, if bShouldUpdatePhysicsVolume is true. </para>
		/// <param name="bTriggerNotifiers">if true, send zone/volume change events </param>
		/// </summary>
		public virtual void UpdatePhysicsVolume(bool bTriggerNotifiers)
			=> E_USceneComponent_UpdatePhysicsVolume(this, bTriggerNotifiers);
		
		#endregion
		
		public static implicit operator IntPtr(USceneComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneComponent>(PtrDesc);
		}}}
