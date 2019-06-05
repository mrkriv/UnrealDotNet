// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:106

namespace UnrealEngine
{
	public partial class USceneComponent : UActorComponent
	{
		public USceneComponent(IntPtr adress)
			: base(adress)
		{
		}

		public USceneComponent(UObject Parent = null, string Name = "SceneComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USceneComponent_bAbsoluteLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_bAbsoluteLocation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USceneComponent_bAbsoluteRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_bAbsoluteRotation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USceneComponent_bAbsoluteScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_bAbsoluteScale_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USceneComponent_bBoundsChangeTriggersStreamingDataRebuild_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_bBoundsChangeTriggersStreamingDataRebuild_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USceneComponent_bHiddenInGame_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_bHiddenInGame_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_Bounds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_Bounds_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USceneComponent_bUseAttachParentBound_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_bUseAttachParentBound_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USceneComponent_bVisible_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_bVisible_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_ComponentVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_ComponentVelocity_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_RelativeLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_RelativeLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_RelativeRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_RelativeRotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_RelativeScale3D_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_RelativeScale3D_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USceneComponent_SkipUpdateOverlapsOptimEnabled_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddLocalOffset(IntPtr self, IntPtr deltaLocation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddLocalRotation(IntPtr self, IntPtr deltaRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddLocalRotation_o1(IntPtr self, IntPtr deltaRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddLocalTransform(IntPtr self, IntPtr deltaTransform, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddRelativeLocation(IntPtr self, IntPtr deltaLocation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddRelativeRotation(IntPtr self, IntPtr deltaRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddRelativeRotation_o1(IntPtr self, IntPtr deltaRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddWorldOffset(IntPtr self, IntPtr deltaLocation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddWorldRotation(IntPtr self, IntPtr deltaRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddWorldRotation_o1(IntPtr self, IntPtr deltaRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_AddWorldTransform(IntPtr self, IntPtr deltaTransform, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_AreDynamicDataChangesAllowed(IntPtr self, bool bIgnoreStationary);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_AttachToComponent(IntPtr self, IntPtr inParent, IntPtr attachmentRules, string inSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_CalcBoundingCylinder(IntPtr self, float cylinderRadius, float cylinderHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_CalcBounds(IntPtr self, IntPtr localToWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_CalcNewComponentToWorld(IntPtr self, IntPtr newRelativeTransform, IntPtr parent, string socketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_CalcNewComponentToWorld_GeneralCase(IntPtr self, IntPtr newRelativeTransform, IntPtr parent, string socketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_CanAttachAsChild(IntPtr self, IntPtr childComponent, string socketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_CanEverRender(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_CanHaveStaticMobility(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_CheckStaticMobilityAndWarn(IntPtr self, string actionText);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_ClearSkipUpdateOverlaps(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_ConditionalUpdateComponentToWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_DetachFromComponent(IntPtr self, IntPtr detachmentRules);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_DetachFromParent(IntPtr self, bool bMaintainWorldPosition, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_DoesSocketExist(IntPtr self, string inSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetAttachmentRoot(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetAttachmentRootActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetAttachParent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USceneComponent_GetAttachSocketName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetChildComponent(IntPtr self, int childIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USceneComponent_GetCollisionObjectType(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USceneComponent_GetCollisionResponseToChannel(IntPtr self, byte channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetCollisionResponseToChannels(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USceneComponent_GetCollisionResponseToComponent(IntPtr self, IntPtr otherComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentQuat(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentToWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentTransform(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentVelocity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USceneComponent_GetDefaultSceneRootVariableName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetForwardVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USceneComponent_GetNumChildrenComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetPlacementExtent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetRelativeRotationCache(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetRelativeRotationFromWorld(IntPtr self, IntPtr worldRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetRelativeTransform(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetRightVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_GetShouldUpdatePhysicsVolume(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetSocketLocation(IntPtr self, string inSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetSocketQuaternion(IntPtr self, string inSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetSocketRotation(IntPtr self, string inSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetSocketTransform(IntPtr self, string inSocketName, byte transformSpace);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_GetSocketWorldLocationAndRotation(IntPtr self, string inSocketName, IntPtr outLocation, IntPtr outRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_GetSocketWorldLocationAndRotation_o1(IntPtr self, string inSocketName, IntPtr outLocation, IntPtr outRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetUpVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_HasAnySockets(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_InternalSetWorldLocationAndRotation(IntPtr self, IntPtr newLocation, IntPtr newQuat, bool bNoPhysics, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsAnySimulatingPhysics(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsAttachedTo(IntPtr self, IntPtr testComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsCollisionEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsDeferringMovementUpdates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsPhysicsCollisionEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsPrecomputedLightingValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsQueryCollisionEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsSimulatingPhysics(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsVisible(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsVisibleInEditor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsWorldGeometry(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddLocalOffset(IntPtr self, IntPtr deltaLocation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddLocalRotation(IntPtr self, IntPtr deltaRotation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddLocalTransform(IntPtr self, IntPtr deltaTransform, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddRelativeLocation(IntPtr self, IntPtr deltaLocation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddRelativeRotation(IntPtr self, IntPtr deltaRotation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddWorldOffset(IntPtr self, IntPtr deltaLocation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddWorldRotation(IntPtr self, IntPtr deltaRotation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_AddWorldTransform(IntPtr self, IntPtr deltaTransform, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_K2_AttachToComponent(IntPtr self, IntPtr parent, string socketName, byte locationRule, byte rotationRule, byte scaleRule, bool bWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_DetachFromComponent(IntPtr self, byte locationRule, byte rotationRule, byte scaleRule, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentToWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetRelativeLocation(IntPtr self, IntPtr newLocation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetRelativeLocationAndRotation(IntPtr self, IntPtr newLocation, IntPtr newRotation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetRelativeRotation(IntPtr self, IntPtr newRotation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetRelativeTransform(IntPtr self, IntPtr newTransform, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetWorldLocation(IntPtr self, IntPtr newLocation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetWorldLocationAndRotation(IntPtr self, IntPtr newLocation, IntPtr newRotation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetWorldRotation(IntPtr self, IntPtr newRotation, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_K2_SetWorldTransform(IntPtr self, IntPtr newTransform, bool bSweep, IntPtr sweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_MoveComponent(IntPtr self, IntPtr delta, IntPtr newRotation, bool bSweep, IntPtr hit, byte moveFlags, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_MoveComponent_o1(IntPtr self, IntPtr delta, IntPtr newRotation, bool bSweep, IntPtr hit, byte moveFlags, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_MoveComponentImpl(IntPtr self, IntPtr delta, IntPtr newRotation, bool bSweep, IntPtr hit, byte moveFlags, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnAttachmentChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnChildAttached(IntPtr self, IntPtr childComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnChildDetached(IntPtr self, IntPtr childComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnHiddenInGameChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnUpdateTransform(IntPtr self, byte updateTransformFlags, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnVisibilityChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_PostUpdateNavigationData(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_PropagateLightingScenarioChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_ResetRelativeTransform(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetAbsolute(IntPtr self, bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetComponentToWorld(IntPtr self, IntPtr newComponentToWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetHiddenInGame(IntPtr self, bool newHidden, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeLocation(IntPtr self, IntPtr newLocation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeLocationAndRotation(IntPtr self, IntPtr newLocation, IntPtr newRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeLocationAndRotation_o1(IntPtr self, IntPtr newLocation, IntPtr newRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeRotation(IntPtr self, IntPtr newRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeRotation_o1(IntPtr self, IntPtr newRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeRotationCache(IntPtr self, IntPtr inCache);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeRotationExact(IntPtr self, IntPtr newRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeScale3D(IntPtr self, IntPtr newScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeTransform(IntPtr self, IntPtr newTransform, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetShouldUpdatePhysicsVolume(IntPtr self, bool bInShouldUpdatePhysicsVolume);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetupAttachment(IntPtr self, IntPtr inParent, string inSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetVisibility(IntPtr self, bool bNewVisibility, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldLocation(IntPtr self, IntPtr newLocation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldLocationAndRotation(IntPtr self, IntPtr newLocation, IntPtr newRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldLocationAndRotation_o1(IntPtr self, IntPtr newLocation, IntPtr newRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldLocationAndRotationNoPhysics(IntPtr self, IntPtr newLocation, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldRotation(IntPtr self, IntPtr newRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldRotation_o1(IntPtr self, IntPtr newRotation, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldScale3D(IntPtr self, IntPtr newScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldTransform(IntPtr self, IntPtr newTransform, bool bSweep, IntPtr outSweepHitResult, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldCollideWhenPlacing(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldComponentAddToScene(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldRender(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldSkipUpdateOverlaps(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_SnapTo(IntPtr self, IntPtr inParent, string inSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_ToggleVisibility(IntPtr self, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_UpdateBounds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_UpdateChildTransforms(IntPtr self, byte updateTransformFlags, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_UpdateNavigationData(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_UpdatePhysicsVolume(IntPtr self, bool bTriggerNotifiers);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// If RelativeLocation should be considered relative to the world, rather than the parent
		/// </summary>
		public byte bAbsoluteLocation
		{
			get => E_PROP_USceneComponent_bAbsoluteLocation_GET(NativePointer);
			set => E_PROP_USceneComponent_bAbsoluteLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If RelativeRotation should be considered relative to the world, rather than the parent
		/// </summary>
		public byte bAbsoluteRotation
		{
			get => E_PROP_USceneComponent_bAbsoluteRotation_GET(NativePointer);
			set => E_PROP_USceneComponent_bAbsoluteRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If RelativeScale3D should be considered relative to the world, rather than the parent
		/// </summary>
		public byte bAbsoluteScale
		{
			get => E_PROP_USceneComponent_bAbsoluteScale_GET(NativePointer);
			set => E_PROP_USceneComponent_bAbsoluteScale_SET(NativePointer, value);
		}

		public byte bBoundsChangeTriggersStreamingDataRebuild
		{
			get => E_PROP_USceneComponent_bBoundsChangeTriggersStreamingDataRebuild_GET(NativePointer);
			set => E_PROP_USceneComponent_bBoundsChangeTriggersStreamingDataRebuild_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to hide the primitive in game, if the primitive is Visible.
		/// </summary>
		public byte bHiddenInGame
		{
			get => E_PROP_USceneComponent_bHiddenInGame_GET(NativePointer);
			set => E_PROP_USceneComponent_bHiddenInGame_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current bounds of the component
		/// </summary>
		public FBoxSphereBounds Bounds
		{
			get => E_PROP_USceneComponent_Bounds_GET(NativePointer);
			set => E_PROP_USceneComponent_Bounds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this component uses its parents bounds when attached.
		/// <para>This can be a significant optimization with many components attached together. </para>
		/// </summary>
		public byte bUseAttachParentBound
		{
			get => E_PROP_USceneComponent_bUseAttachParentBound_GET(NativePointer);
			set => E_PROP_USceneComponent_bUseAttachParentBound_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to completely draw the primitive; if false, the primitive is not drawn, does not cast a shadow.
		/// </summary>
		public byte bVisible
		{
			get => E_PROP_USceneComponent_bVisible_GET(NativePointer);
			set => E_PROP_USceneComponent_bVisible_SET(NativePointer, value);
		}

		public FVector ComponentVelocity
		{
			get => E_PROP_USceneComponent_ComponentVelocity_GET(NativePointer);
			set => E_PROP_USceneComponent_ComponentVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Location of the component relative to its parent
		/// </summary>
		public FVector RelativeLocation
		{
			get => E_PROP_USceneComponent_RelativeLocation_GET(NativePointer);
			set => E_PROP_USceneComponent_RelativeLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Rotation of the component relative to its parent
		/// </summary>
		public FRotator RelativeRotation
		{
			get => E_PROP_USceneComponent_RelativeRotation_GET(NativePointer);
			set => E_PROP_USceneComponent_RelativeRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Non-uniform scaling of the component relative to its parent.
		/// <para>Note that scaling is always applied in local space (no shearing etc) </para>
		/// </summary>
		public FVector RelativeScale3D
		{
			get => E_PROP_USceneComponent_RelativeScale3D_GET(NativePointer);
			set => E_PROP_USceneComponent_RelativeScale3D_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Global flag to enable/disable overlap optimizations, settable with p.SkipUpdateOverlapsOptimEnabled cvar
		/// </summary>
		public static int SkipUpdateOverlapsOptimEnabled
		{
			get => E_PROP_USceneComponent_SkipUpdateOverlapsOptimEnabled_GET();
		}

		#endregion
		
		#region ExternMethods
		public void AddLocalOffset(FVector deltaLocation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddLocalOffset(this, deltaLocation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddLocalRotation(FRotator deltaRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddLocalRotation(this, deltaRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddLocalRotation(FQuat deltaRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddLocalRotation_o1(this, deltaRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddLocalTransform(FTransform deltaTransform, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddLocalTransform(this, deltaTransform, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddRelativeLocation(FVector deltaLocation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddRelativeLocation(this, deltaLocation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddRelativeRotation(FRotator deltaRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddRelativeRotation(this, deltaRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddRelativeRotation(FQuat deltaRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddRelativeRotation_o1(this, deltaRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddWorldOffset(FVector deltaLocation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddWorldOffset(this, deltaLocation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddWorldRotation(FRotator deltaRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddWorldRotation(this, deltaRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddWorldRotation(FQuat deltaRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddWorldRotation_o1(this, deltaRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void AddWorldTransform(FTransform deltaTransform, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_AddWorldTransform(this, deltaTransform, bSweep, outSweepHitResult, (byte)teleport);
		
		
		/// <summary>
		/// Determine if dynamic data is allowed to be changed.
		/// </summary>
		/// <param name="bIgnoreStationary">Whether or not to ignore stationary mobility when checking. Default is true (i.e. - check for static mobility only).</param>
		/// <return>Whether</return>
		protected bool AreDynamicDataChangesAllowed(bool bIgnoreStationary = true)
			=> E_USceneComponent_AreDynamicDataChangesAllowed(this, bIgnoreStationary);
		
		
		/// <summary>
		/// Attach this component to another scene component, optionally at a named socket. It is valid to call this on components whether or not they have been Registered, however from
		/// <para>constructor or when not registered it is preferable to use SetupAttachment. </para>
		/// </summary>
		/// <param name="parent">Parent to attach to.</param>
		/// <param name="attachmentRules">How to handle transforms & welding when attaching.</param>
		/// <param name="socketName">Optional socket to attach to on the parent.</param>
		/// <return>True</return>
		public bool AttachToComponent(USceneComponent inParent, FAttachmentTransformRules attachmentRules, string inSocketName)
			=> E_USceneComponent_AttachToComponent(this, inParent, attachmentRules, inSocketName);
		
		
		/// <summary>
		/// Calculate the axis-aligned bounding cylinder of the component (radius in X-Y, half-height along Z axis).
		/// <para>Default behavior is just a cylinder around the box of the cached BoxSphereBounds. </para>
		/// </summary>
		public virtual void CalcBoundingCylinder(float cylinderRadius, float cylinderHalfHeight)
			=> E_USceneComponent_CalcBoundingCylinder(this, cylinderRadius, cylinderHalfHeight);
		
		
		/// <summary>
		/// Calculate the bounds of the component. Default behavior is a bounding box/sphere of zero size.
		/// </summary>
		public virtual FBoxSphereBounds CalcBounds(FTransform localToWorld)
			=> E_USceneComponent_CalcBounds(this, localToWorld);
		
		
		/// <summary>
		/// Calculate the new ComponentToWorld transform for this component.
		/// <para>Parent is optional and can be used for computing ComponentToWorld based on arbitrary USceneComponent. </para>
		/// If Parent is not passed in we use the component's AttachParent
		/// </summary>
		protected FTransform CalcNewComponentToWorld(FTransform newRelativeTransform, USceneComponent parent, string socketName)
			=> E_USceneComponent_CalcNewComponentToWorld(this, newRelativeTransform, parent, socketName);
		
		
		/// <summary>
		/// Utility function to handle calculating transform with a parent
		/// </summary>
		protected FTransform CalcNewComponentToWorld_GeneralCase(FTransform newRelativeTransform, USceneComponent parent, string socketName)
			=> E_USceneComponent_CalcNewComponentToWorld_GeneralCase(this, newRelativeTransform, parent, socketName);
		
		
		/// <summary>
		/// Called to see if it's possible to attach another scene component as a child.
		/// <para>Note: This can be called on template component as well! </para>
		/// </summary>
		public virtual bool CanAttachAsChild(USceneComponent childComponent, string socketName)
			=> E_USceneComponent_CanAttachAsChild(this, childComponent, socketName);
		
		
		/// <summary>
		/// return true if it can ever render
		/// </summary>
		public bool CanEverRender()
			=> E_USceneComponent_CanEverRender(this);
		
		
		/// <summary>
		/// Determines whether or not the component can have its mobility set to static
		/// </summary>
		public virtual bool CanHaveStaticMobility()
			=> E_USceneComponent_CanHaveStaticMobility(this);
		
		
		/// <summary>
		/// Check if mobility is set to non-static. If it's static we trigger a PIE warning and return true
		/// </summary>
		protected bool CheckStaticMobilityAndWarn(string actionText)
			=> E_USceneComponent_CheckStaticMobilityAndWarn(this, actionText);
		
		
		/// <summary>
		/// Clears the skip update overlaps flag. This should be called any time a change to state would prevent the result of UpdateOverlaps. For example attachment, changing collision settings, etc...
		/// </summary>
		public void ClearSkipUpdateOverlaps()
			=> E_USceneComponent_ClearSkipUpdateOverlaps(this);
		
		
		/// <summary>
		/// Call UpdateComponentToWorld if bComponentToWorldUpdated is false.
		/// </summary>
		public void ConditionalUpdateComponentToWorld()
			=> E_USceneComponent_ConditionalUpdateComponentToWorld(this);
		
		
		/// <summary>
		/// Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo)
		/// </summary>
		/// <param name="detachmentRules">How to handle transforms & modification when detaching.</param>
		public virtual void DetachFromComponent(FDetachmentTransformRules detachmentRules)
			=> E_USceneComponent_DetachFromComponent(this, detachmentRules);
		
		
		/// <summary>
		/// DEPRECATED - Use DetachFromComponent() instead
		/// </summary>
		public virtual void DetachFromParentDeprecated(bool bMaintainWorldPosition, bool bCallModify)
			=> E_USceneComponent_DetachFromParent(this, bMaintainWorldPosition, bCallModify);
		
		
		/// <summary>
		/// Return true if socket with the given name exists
		/// </summary>
		/// <param name="inSocketName">Name of the socket or the bone to get the transform</param>
		public virtual bool DoesSocketExist(string inSocketName)
			=> E_USceneComponent_DoesSocketExist(this, inSocketName);
		
		
		/// <summary>
		/// Walks up the attachment chain from this SceneComponent and returns the SceneComponent at the top. If AttachParent is NULL, returns this.
		/// </summary>
		public USceneComponent GetAttachmentRoot()
			=> E_USceneComponent_GetAttachmentRoot(this);
		
		
		/// <summary>
		/// Walks up the attachment chain from this SceneComponent and returns the top-level actor it's attached to.  Returns Owner if unattached.
		/// </summary>
		public AActor GetAttachmentRootActor()
			=> E_USceneComponent_GetAttachmentRootActor(this);
		
		
		/// <summary>
		/// Get the SceneComponent we are attached to.
		/// </summary>
		public USceneComponent GetAttachParent()
			=> E_USceneComponent_GetAttachParent(this);
		
		
		/// <summary>
		/// Get the socket we are attached to.
		/// </summary>
		public string GetAttachSocketName()
			=> E_USceneComponent_GetAttachSocketName(this);
		
		
		/// <summary>
		/// Gets the attached child component at the specified location
		/// </summary>
		public USceneComponent GetChildComponent(int childIndex)
			=> E_USceneComponent_GetChildComponent(this, childIndex);
		
		
		/// <summary>
		/// Returns the channel that this component belongs to when it moves.
		/// </summary>
		public virtual ECollisionChannel GetCollisionObjectType()
			=> (ECollisionChannel)E_USceneComponent_GetCollisionObjectType(this);
		
		
		/// <summary>
		/// Returns the response that this component has to a specific collision channel.
		/// </summary>
		public virtual ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel channel)
			=> (ECollisionResponse)E_USceneComponent_GetCollisionResponseToChannel(this, (byte)channel);
		
		
		/// <summary>
		/// Return const reference to CollsionResponseContainer
		/// </summary>
		public virtual FCollisionResponseContainer GetCollisionResponseToChannels()
			=> E_USceneComponent_GetCollisionResponseToChannels(this);
		
		
		/// <summary>
		/// Compares the CollisionObjectType of each component against the Response of the other, to see what kind of response we should generate
		/// </summary>
		public ECollisionResponse GetCollisionResponseToComponent(USceneComponent otherComponent)
			=> (ECollisionResponse)E_USceneComponent_GetCollisionResponseToComponent(this, otherComponent);
		
		
		/// <summary>
		/// Return location of the component, in world space
		/// </summary>
		public FVector GetComponentLocation()
			=> E_USceneComponent_GetComponentLocation(this);
		
		
		/// <summary>
		/// Return rotation quaternion of the component, in world space
		/// </summary>
		public FQuat GetComponentQuat()
			=> E_USceneComponent_GetComponentQuat(this);
		
		
		/// <summary>
		/// Return rotation of the component, in world space
		/// </summary>
		public FRotator GetComponentRotation()
			=> E_USceneComponent_GetComponentRotation(this);
		
		
		/// <summary>
		/// Return scale of the component, in world space
		/// </summary>
		public FVector GetComponentScale()
			=> E_USceneComponent_GetComponentScale(this);
		
		
		/// <summary>
		/// Get the current component-to-world transform for this component
		/// <para>TODO: probably deprecate this in favor of GetComponentTransform </para>
		/// </summary>
		public FTransform GetComponentToWorld()
			=> E_USceneComponent_GetComponentToWorld(this);
		
		
		/// <summary>
		/// Get the current component-to-world transform for this component
		/// </summary>
		public FTransform GetComponentTransform()
			=> E_USceneComponent_GetComponentTransform(this);
		
		
		/// <summary>
		/// Get velocity of the component: either ComponentVelocity, or the velocity of the physics body if simulating physics.
		/// </summary>
		/// <return>Velocity</return>
		public virtual FVector GetComponentVelocity()
			=> E_USceneComponent_GetComponentVelocity(this);
		
		
		/// <summary>
		/// The name to use for the default scene root variable
		/// </summary>
		public string GetDefaultSceneRootVariableName()
			=> E_USceneComponent_GetDefaultSceneRootVariableName(this);
		
		
		/// <summary>
		/// Get the forward (X) unit direction vector from this component, in world space.
		/// </summary>
		public FVector GetForwardVector()
			=> E_USceneComponent_GetForwardVector(this);
		
		
		/// <summary>
		/// Gets the number of attached children components
		/// </summary>
		public int GetNumChildrenComponents()
			=> E_USceneComponent_GetNumChildrenComponents(this);
		
		
		/// <summary>
		/// Get the extent used when placing this component in the editor, used for 'pulling back' hit.
		/// </summary>
		public virtual FBoxSphereBounds GetPlacementExtent()
			=> E_USceneComponent_GetPlacementExtent(this);
		
		
		/// <summary>
		/// Get the RelativeRotationCache.
		/// </summary>
		public FRotationConversionCache GetRelativeRotationCache()
			=> E_USceneComponent_GetRelativeRotationCache(this);
		
		
		/// <summary>
		/// Convenience function to get the relative rotation from the passed in world rotation
		/// </summary>
		/// <param name="worldRotation">World rotation that we want to convert to relative to the components parent</param>
		/// <return>Returns</return>
		public FQuat GetRelativeRotationFromWorld(FQuat worldRotation)
			=> E_USceneComponent_GetRelativeRotationFromWorld(this, worldRotation);
		
		
		/// <summary>
		/// Returns the transform of the component relative to its parent
		/// </summary>
		public FTransform GetRelativeTransform()
			=> E_USceneComponent_GetRelativeTransform(this);
		
		
		/// <summary>
		/// Get the right (Y) unit direction vector from this component, in world space.
		/// </summary>
		public FVector GetRightVector()
			=> E_USceneComponent_GetRightVector(this);
		
		public bool GetShouldUpdatePhysicsVolume()
			=> E_USceneComponent_GetShouldUpdatePhysicsVolume(this);
		
		
		/// <summary>
		/// Get world-space socket or bone location.
		/// </summary>
		/// <param name="inSocketName">Name of the socket or the bone to get the transform</param>
		/// <return>Socket</return>
		public virtual FVector GetSocketLocation(string inSocketName)
			=> E_USceneComponent_GetSocketLocation(this, inSocketName);
		
		
		/// <summary>
		/// Get world-space socket or bone FQuat rotation.
		/// </summary>
		/// <param name="inSocketName">Name of the socket or the bone to get the transform</param>
		/// <return>Socket</return>
		public virtual FQuat GetSocketQuaternion(string inSocketName)
			=> E_USceneComponent_GetSocketQuaternion(this, inSocketName);
		
		
		/// <summary>
		/// Get world-space socket or bone  FRotator rotation.
		/// </summary>
		/// <param name="inSocketName">Name of the socket or the bone to get the transform</param>
		/// <return>Socket</return>
		public virtual FRotator GetSocketRotation(string inSocketName)
			=> E_USceneComponent_GetSocketRotation(this, inSocketName);
		
		
		/// <summary>
		/// Get world-space socket transform.
		/// </summary>
		/// <param name="inSocketName">Name of the socket or the bone to get the transform</param>
		/// <return>Socket</return>
		public virtual FTransform GetSocketTransform(string inSocketName, ERelativeTransformSpace transformSpace)
			=> E_USceneComponent_GetSocketTransform(this, inSocketName, (byte)transformSpace);
		
		
		/// <summary>
		/// Find the world-space location and rotation of the given named socket.
		/// <para>If the socket is not found, then it returns the component's location and rotation in world space. </para>
		/// </summary>
		/// <param name="inSocketName">the name of the socket to find</param>
		/// <param name="outLocation">out) set to the world space location of the socket</param>
		/// <param name="outRotation">out) set to the world space rotation of the socket</param>
		/// <return>whether</return>
		public void GetSocketWorldLocationAndRotation(string inSocketName, FVector outLocation, FRotator outRotation)
			=> E_USceneComponent_GetSocketWorldLocationAndRotation(this, inSocketName, outLocation, outRotation);
		
		public void GetSocketWorldLocationAndRotation(string inSocketName, FVector outLocation, FQuat outRotation)
			=> E_USceneComponent_GetSocketWorldLocationAndRotation_o1(this, inSocketName, outLocation, outRotation);
		
		
		/// <summary>
		/// Get the up (Z) unit direction vector from this component, in world space.
		/// </summary>
		public FVector GetUpVector()
			=> E_USceneComponent_GetUpVector(this);
		
		
		/// <summary>
		/// Returns true if this component has any sockets
		/// </summary>
		public virtual bool HasAnySockets()
			=> E_USceneComponent_HasAnySockets(this);
		
		
		/// <summary>
		/// Internal helper, for use from MoveComponent().  Special codepath since the normal setters call MoveComponent.
		/// </summary>
		/// <return>true</return>
		protected bool InternalSetWorldLocationAndRotation(FVector newLocation, FQuat newQuat, bool bNoPhysics, ETeleportType teleport)
			=> E_USceneComponent_InternalSetWorldLocationAndRotation(this, newLocation, newQuat, bNoPhysics, (byte)teleport);
		
		
		/// <summary>
		/// Returns whether the specified body is currently using physics simulation
		/// </summary>
		public virtual bool IsAnySimulatingPhysics()
			=> E_USceneComponent_IsAnySimulatingPhysics(this);
		
		
		/// <summary>
		/// Walks up the attachment chain to see if this component is attached to the supplied component. If TestComp == this, returns false.
		/// </summary>
		public bool IsAttachedTo(USceneComponent testComp)
			=> E_USceneComponent_IsAttachedTo(this, testComp);
		
		
		/// <summary>
		/// Utility to see if there is any form of collision (query or physics) enabled on this component.
		/// </summary>
		public bool IsCollisionEnabled()
			=> E_USceneComponent_IsCollisionEnabled(this);
		
		
		/// <summary>
		/// Returns true if movement is currently within the scope of an FScopedMovementUpdate.
		/// </summary>
		public bool IsDeferringMovementUpdates()
			=> E_USceneComponent_IsDeferringMovementUpdates(this);
		
		
		/// <summary>
		/// Utility to see if there is any physics collision enabled on this component.
		/// </summary>
		public bool IsPhysicsCollisionEnabled()
			=> E_USceneComponent_IsPhysicsCollisionEnabled(this);
		
		
		/// <summary>
		/// True if our precomputed lighting is up to date
		/// </summary>
		public virtual bool IsPrecomputedLightingValid()
			=> E_USceneComponent_IsPrecomputedLightingValid(this);
		
		
		/// <summary>
		/// Utility to see if there is any query collision enabled on this component.
		/// </summary>
		public bool IsQueryCollisionEnabled()
			=> E_USceneComponent_IsQueryCollisionEnabled(this);
		
		
		/// <summary>
		/// Returns whether the specified body is currently using physics simulation
		/// </summary>
		public virtual bool IsSimulatingPhysics(string boneName)
			=> E_USceneComponent_IsSimulatingPhysics(this, boneName);
		
		
		/// <summary>
		/// Returns true if this component is visible in the current context
		/// </summary>
		public virtual bool IsVisible()
			=> E_USceneComponent_IsVisible(this);
		
		
		/// <summary>
		/// Return true if visible in editor
		/// </summary>
		public virtual bool IsVisibleInEditor()
			=> E_USceneComponent_IsVisibleInEditor(this);
		
		
		/// <summary>
		/// Is this component considered 'world' geometry, by default checks if this uses the WorldStatic collision channel
		/// </summary>
		public virtual bool IsWorldGeometry()
			=> E_USceneComponent_IsWorldGeometry(this);
		
		
		/// <summary>
		/// Adds a delta to the location of the component in its local reference frame
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="deltaLocation">Change in location of the component in its local reference frame.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_AddLocalOffset(FVector deltaLocation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddLocalOffset(this, deltaLocation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Adds a delta to the rotation of the component in its local reference frame
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </summary>
		/// <param name="deltaRotation">Change in rotation of the component in its local reference frame.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation).</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_AddLocalRotation(FRotator deltaRotation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddLocalRotation(this, deltaRotation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Adds a delta to the transform of the component in its local reference frame. Scale is unchanged.
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="deltaTransform">Change in transform of the component in its local reference frame. Scale is unchanged.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_AddLocalTransform(FTransform deltaTransform, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddLocalTransform(this, deltaTransform, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Adds a delta to the translation of the component relative to its parent
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="deltaLocation">Change in location of the component relative to its parent</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_AddRelativeLocation(FVector deltaLocation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddRelativeLocation(this, deltaLocation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Adds a delta the rotation of the component relative to its parent
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </summary>
		/// <param name="deltaRotation">Change in rotation of the component relative to is parent.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation).</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_AddRelativeRotation(FRotator deltaRotation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddRelativeRotation(this, deltaRotation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Adds a delta to the location of the component in world space.
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="deltaLocation">Change in location in world space for the component.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_AddWorldOffset(FVector deltaLocation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddWorldOffset(this, deltaLocation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Adds a delta to the rotation of the component in world space.
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire sweep volume. </para>
		/// </summary>
		/// <param name="deltaRotation">Change in rotation in world space for the component.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation).</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_AddWorldRotation(FRotator deltaRotation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddWorldRotation(this, deltaRotation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Adds a delta to the transform of the component in world space. Scale is unchanged.
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="deltaTransform">Change in transform in world space for the component. Scale is unchanged.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_AddWorldTransform(FTransform deltaTransform, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_AddWorldTransform(this, deltaTransform, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Attach this component to another scene component, optionally at a named socket. It is valid to call this on components whether or not they have been Registered.
		/// </summary>
		/// <param name="parent">Parent to attach to.</param>
		/// <param name="socketName">Optional socket to attach to on the parent.</param>
		/// <param name="locationRule">How to handle translation when attaching.</param>
		/// <param name="rotationRule">How to handle rotation when attaching.</param>
		/// <param name="scaleRule">How to handle scale when attaching.</param>
		/// <param name="bWeldSimulatedBodies">Whether to weld together simulated physics bodies.</param>
		/// <return>True</return>
		public bool K2_AttachToComponent(USceneComponent parent, string socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
			=> E_USceneComponent_K2_AttachToComponent(this, parent, socketName, (byte)locationRule, (byte)rotationRule, (byte)scaleRule, bWeldSimulatedBodies);
		
		
		/// <summary>
		/// Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo)
		/// </summary>
		/// <param name="locationRule">How to handle translations when detaching.</param>
		/// <param name="rotationRule">How to handle rotation when detaching.</param>
		/// <param name="scaleRule">How to handle scales when detaching.</param>
		/// <param name="bCallModify">If true, call Modify() on the component and the current attach parent component</param>
		public void K2_DetachFromComponent(EDetachmentRule locationRule, EDetachmentRule rotationRule, EDetachmentRule scaleRule, bool bCallModify = true)
			=> E_USceneComponent_K2_DetachFromComponent(this, (byte)locationRule, (byte)rotationRule, (byte)scaleRule, bCallModify);
		
		
		/// <summary>
		/// Return location of the component, in world space
		/// </summary>
		public FVector GetWorldLocation()
			=> E_USceneComponent_K2_GetComponentLocation(this);
		
		
		/// <summary>
		/// Returns rotation of the component, in world space.
		/// </summary>
		public FRotator GetWorldRotation()
			=> E_USceneComponent_K2_GetComponentRotation(this);
		
		
		/// <summary>
		/// Returns scale of the component, in world space.
		/// </summary>
		public FVector GetWorldScale()
			=> E_USceneComponent_K2_GetComponentScale(this);
		
		
		/// <summary>
		/// Get the current component-to-world transform for this component
		/// </summary>
		public FTransform GetWorldTransform()
			=> E_USceneComponent_K2_GetComponentToWorld(this);
		
		
		/// <summary>
		/// Set the location of the component relative to its parent
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="newLocation">New location of the component relative to its parent.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_SetRelativeLocation(FVector newLocation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetRelativeLocation(this, newLocation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Set the location and rotation of the component relative to its parent
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="newLocation">New location of the component relative to its parent.</param>
		/// <param name="newRotation">New rotation of the component relative to its parent.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_SetRelativeLocationAndRotation(FVector newLocation, FRotator newRotation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetRelativeLocationAndRotation(this, newLocation, newRotation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Set the rotation of the component relative to its parent
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </summary>
		/// <param name="newRotation">New rotation of the component relative to its parent</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation).</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_SetRelativeRotation(FRotator newRotation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetRelativeRotation(this, newRotation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Set the transform of the component relative to its parent
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </summary>
		/// <param name="newTransform">New transform of the component relative to its parent.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation).</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_SetRelativeTransform(FTransform newTransform, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetRelativeTransform(this, newTransform, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Put this component at the specified location in world space. Updates relative location to achieve the final world location.
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="newLocation">New location in world space for the component.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_SetWorldLocation(FVector newLocation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetWorldLocation(this, newLocation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Set the relative location and rotation of the component to put it at the supplied pose in world space.
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="newLocation">New location in world space for the component.</param>
		/// <param name="newRotation">New rotation in world space for the component.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_SetWorldLocationAndRotation(FVector newLocation, FRotator newRotation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetWorldLocationAndRotation(this, newLocation, newRotation, bSweep, sweepHitResult, bTeleport);
		
		public void K2_SetWorldRotation(FRotator newRotation, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetWorldRotation(this, newRotation, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Set the transform of the component in world space.
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire sweep volume.
		/// </summary>
		/// <param name="newTransform">New transform in world space for the component.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void K2_SetWorldTransform(FTransform newTransform, bool bSweep, FHitResult sweepHitResult, bool bTeleport)
			=> E_USceneComponent_K2_SetWorldTransform(this, newTransform, bSweep, sweepHitResult, bTeleport);
		
		
		/// <summary>
		/// Tries to move the component by a movement vector (Delta) and sets rotation to NewRotation.
		/// <para>Assumes that the component's current location is valid and that the component does fit in its current Location. </para>
		/// Dispatches blocking hit notifications (if bSweep is true), and calls UpdateOverlaps() after movement to update overlap state.
		/// <para>@note This simply calls the virtual MoveComponentImpl() which can be overridden to implement custom behavior. </para>
		/// @note The overload taking rotation as an FQuat is slightly faster than the version using FRotator (which will be converted to an FQuat)..
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// If TeleportPhysics, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// <para>If None, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// If CCD is on and not teleporting, this will affect objects along the entire swept volume.
		/// </summary>
		/// <param name="delta">The desired location change in world space.</param>
		/// <param name="newRotation">The new desired rotation in world space.</param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something.</param>
		/// <param name="teleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		/// <param name="hit">Optional output describing the blocking hit that stopped the move, if any.</param>
		/// <param name="moveFlags">Flags controlling behavior of the move. @see EMoveComponentFlags</param>
		/// <param name="teleport">Determines whether to teleport the physics body or not. Teleporting will maintain constant velocity and avoid collisions along the path</param>
		/// <return>True</return>
		public bool MoveComponent(FVector delta, FQuat newRotation, bool bSweep, FHitResult hit, EMoveComponentFlags moveFlags, ETeleportType teleport)
			=> E_USceneComponent_MoveComponent(this, delta, newRotation, bSweep, hit, (byte)moveFlags, (byte)teleport);
		
		public bool MoveComponent(FVector delta, FRotator newRotation, bool bSweep, FHitResult hit, EMoveComponentFlags moveFlags, ETeleportType teleport)
			=> E_USceneComponent_MoveComponent_o1(this, delta, newRotation, bSweep, hit, (byte)moveFlags, (byte)teleport);
		
		
		/// <summary>
		/// Override this method for custom behavior for MoveComponent
		/// </summary>
		protected virtual bool MoveComponentImpl(FVector delta, FQuat newRotation, bool bSweep, FHitResult hit, EMoveComponentFlags moveFlags, ETeleportType teleport)
			=> E_USceneComponent_MoveComponentImpl(this, delta, newRotation, bSweep, hit, (byte)moveFlags, (byte)teleport);
		
		
		/// <summary>
		/// Called when AttachParent changes, to allow the scene to update its attachment state.
		/// </summary>
		public virtual void OnAttachmentChanged()
			=> E_USceneComponent_OnAttachmentChanged(this);
		
		
		/// <summary>
		/// Called after a child scene component is attached to this component.
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected virtual void OnChildAttached(USceneComponent childComponent)
			=> E_USceneComponent_OnChildAttached(this, childComponent);
		
		
		/// <summary>
		/// Called after a child scene component is detached from this component.
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected virtual void OnChildDetached(USceneComponent childComponent)
			=> E_USceneComponent_OnChildDetached(this, childComponent);
		
		
		/// <summary>
		/// Overridable internal function to respond to changes in the hidden in game value of the component.
		/// </summary>
		protected virtual void OnHiddenInGameChanged()
			=> E_USceneComponent_OnHiddenInGameChanged(this);
		
		
		/// <summary>
		/// Native callback when this component is moved
		/// </summary>
		protected virtual void OnUpdateTransform(EUpdateTransformFlags updateTransformFlags, ETeleportType teleport)
			=> E_USceneComponent_OnUpdateTransform(this, (byte)updateTransformFlags, (byte)teleport);
		
		
		/// <summary>
		/// Overridable internal function to respond to changes in the visibility of the component.
		/// </summary>
		protected virtual void OnVisibilityChanged()
			=> E_USceneComponent_OnVisibilityChanged(this);
		
		
		/// <summary>
		/// Called after changing transform, tries to update navigation octree for owner
		/// </summary>
		protected void PostUpdateNavigationData()
			=> E_USceneComponent_PostUpdateNavigationData(this);
		
		
		/// <summary>
		/// Updates any visuals after the lighting has changed
		/// </summary>
		public virtual void PropagateLightingScenarioChange()
			=> E_USceneComponent_PropagateLightingScenarioChange(this);
		
		
		/// <summary>
		/// Reset the transform of the component relative to its parent. Sets relative location to zero, relative rotation to no rotation, and Scale to 1.
		/// </summary>
		public void ResetRelativeTransform()
			=> E_USceneComponent_ResetRelativeTransform(this);
		
		
		/// <summary>
		/// Set which parts of the relative transform should be relative to parent, and which should be relative to world
		/// </summary>
		public void SetAbsolute(bool bNewAbsoluteLocation = false, bool bNewAbsoluteRotation = false, bool bNewAbsoluteScale = false)
			=> E_USceneComponent_SetAbsolute(this, bNewAbsoluteLocation, bNewAbsoluteRotation, bNewAbsoluteScale);
		
		
		/// <summary>
		/// Sets the cached component to world directly. This should be used very rarely.
		/// </summary>
		public void SetComponentToWorld(FTransform newComponentToWorld)
			=> E_USceneComponent_SetComponentToWorld(this, newComponentToWorld);
		
		
		/// <summary>
		/// Changes the value of bHiddenInGame, if false this will disable Visibility during gameplay
		/// </summary>
		public void SetHiddenInGame(bool newHidden, bool bPropagateToChildren = false)
			=> E_USceneComponent_SetHiddenInGame(this, newHidden, bPropagateToChildren);
		
		public void SetRelativeLocation(FVector newLocation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetRelativeLocation(this, newLocation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void SetRelativeLocationAndRotation(FVector newLocation, FRotator newRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetRelativeLocationAndRotation(this, newLocation, newRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void SetRelativeLocationAndRotation(FVector newLocation, FQuat newRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetRelativeLocationAndRotation_o1(this, newLocation, newRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void SetRelativeRotation(FRotator newRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetRelativeRotation(this, newRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void SetRelativeRotation(FQuat newRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetRelativeRotation_o1(this, newRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		
		/// <summary>
		/// Sets the RelativeRotationCache. Used to ensure component ends up with the same RelativeRotation after calling SetWorldTransform().
		/// </summary>
		public void SetRelativeRotationCache(FRotationConversionCache inCache)
			=> E_USceneComponent_SetRelativeRotationCache(this, inCache);
		
		
		/// <summary>
		/// Set the rotation of the component relative to its parent and force RelativeRotation to be equal to new rotation.
		/// <para>This allows us to set and save Rotators with angles out side the normalized range, Note that doing so may break the </para>
		/// RotatorCache so use with care.
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// </summary>
		/// <param name="newRotation">New rotation of the component relative to its parent. We will force RelativeRotation to this value.</param>
		/// <param name="sweepHitResult">Hit result from any impact if sweep is true.</param>
		/// <param name="bSweep">Whether we sweep to the destination (currently not supported for rotation).</param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object).</param>
		public void SetRelativeRotationExact(FRotator newRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetRelativeRotationExact(this, newRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		
		/// <summary>
		/// Set the non-uniform scale of the component relative to its parent
		/// </summary>
		public virtual void SetRelativeScale3D(FVector newScale3D)
			=> E_USceneComponent_SetRelativeScale3D(this, newScale3D);
		
		public void SetRelativeTransform(FTransform newTransform, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetRelativeTransform(this, newTransform, bSweep, outSweepHitResult, (byte)teleport);
		
		public void SetShouldUpdatePhysicsVolume(bool bInShouldUpdatePhysicsVolume)
			=> E_USceneComponent_SetShouldUpdatePhysicsVolume(this, bInShouldUpdatePhysicsVolume);
		
		
		/// <summary>
		/// Initializes desired Attach Parent and SocketName to be attached to when the component is registered.
		/// <para>Generally intended to be called from its Owning Actor's constructor and should be preferred over AttachToComponent when </para>
		/// a component is not registered.
		/// </summary>
		/// <param name="inParent">Parent to attach to.</param>
		/// <param name="inSocketName">Optional socket to attach to on the parent.</param>
		public void SetupAttachment(USceneComponent inParent, string inSocketName)
			=> E_USceneComponent_SetupAttachment(this, inParent, inSocketName);
		
		
		/// <summary>
		/// Set visibility of the component, if during game use this to turn on/off
		/// </summary>
		public void SetVisibility(bool bNewVisibility, bool bPropagateToChildren = false)
			=> E_USceneComponent_SetVisibility(this, bNewVisibility, bPropagateToChildren);
		
		public void SetWorldLocation(FVector newLocation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetWorldLocation(this, newLocation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void SetWorldLocationAndRotation(FVector newLocation, FRotator newRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetWorldLocationAndRotation(this, newLocation, newRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		
		/// <summary>
		/// Set the relative location and FQuat rotation of the component to put it at the supplied pose in world space.
		/// </summary>
		public void SetWorldLocationAndRotation(FVector newLocation, FQuat newRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetWorldLocationAndRotation_o1(this, newLocation, newRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		
		/// <summary>
		/// Special version of SetWorldLocationAndRotation that does not affect physics.
		/// </summary>
		public void SetWorldLocationAndRotationNoPhysics(FVector newLocation, FRotator newRotation)
			=> E_USceneComponent_SetWorldLocationAndRotationNoPhysics(this, newLocation, newRotation);
		
		public void SetWorldRotation(FRotator newRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetWorldRotation(this, newRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		public void SetWorldRotation(FQuat newRotation, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetWorldRotation_o1(this, newRotation, bSweep, outSweepHitResult, (byte)teleport);
		
		
		/// <summary>
		/// Set the relative scale of the component to put it at the supplied scale in world space.
		/// </summary>
		/// <param name="newScale">New scale in world space for this component.</param>
		public void SetWorldScale3D(FVector newScale)
			=> E_USceneComponent_SetWorldScale3D(this, newScale);
		
		public void SetWorldTransform(FTransform newTransform, bool bSweep, FHitResult outSweepHitResult, ETeleportType teleport)
			=> E_USceneComponent_SetWorldTransform(this, newTransform, bSweep, outSweepHitResult, (byte)teleport);
		
		
		/// <summary>
		/// If true, bounds should be used when placing component/actor in level. Does not affect spawning.
		/// </summary>
		public virtual bool ShouldCollideWhenPlacing()
			=> E_USceneComponent_ShouldCollideWhenPlacing(this);
		
		
		/// <summary>
		/// Looking at various values of the component, determines if this
		/// <para>component should be added to the scene </para>
		/// </summary>
		/// <return>true</return>
		public bool ShouldComponentAddToScene()
			=> E_USceneComponent_ShouldComponentAddToScene(this);
		
		
		/// <summary>
		/// return true if it should render
		/// </summary>
		public bool ShouldRender()
			=> E_USceneComponent_ShouldRender(this);
		
		
		/// <summary>
		/// If true, we can use the old computed overlaps
		/// </summary>
		public bool ShouldSkipUpdateOverlaps()
			=> E_USceneComponent_ShouldSkipUpdateOverlaps(this);
		
		
		/// <summary>
		/// DEPRECATED - Use AttachToComponent() instead
		/// </summary>
		public bool SnapTo(USceneComponent inParent, string inSocketName)
			=> E_USceneComponent_SnapTo(this, inParent, inSocketName);
		
		
		/// <summary>
		/// Toggle visibility of the component
		/// </summary>
		public void ToggleVisibility(bool bPropagateToChildren = false)
			=> E_USceneComponent_ToggleVisibility(this, bPropagateToChildren);
		
		
		/// <summary>
		/// Update the Bounds of the component.
		/// </summary>
		public virtual void UpdateBounds()
			=> E_USceneComponent_UpdateBounds(this);
		
		
		/// <summary>
		/// Update transforms of any components attached to this one.
		/// </summary>
		public void UpdateChildTransforms(EUpdateTransformFlags updateTransformFlags, ETeleportType teleport)
			=> E_USceneComponent_UpdateChildTransforms(this, (byte)updateTransformFlags, (byte)teleport);
		
		
		/// <summary>
		/// Called after changing transform, tries to update navigation octree for this component
		/// </summary>
		protected void UpdateNavigationData()
			=> E_USceneComponent_UpdateNavigationData(this);
		
		
		/// <summary>
		/// Updates the PhysicsVolume of this SceneComponent, if bShouldUpdatePhysicsVolume is true.
		/// </summary>
		/// <param name="bTriggerNotifiers">if true, send zone/volume change events</param>
		public virtual void UpdatePhysicsVolume(bool bTriggerNotifiers)
			=> E_USceneComponent_UpdatePhysicsVolume(this, bTriggerNotifiers);
		
		#endregion
		
		public static implicit operator IntPtr(USceneComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator USceneComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneComponent>(PtrDesc);
		}}}
