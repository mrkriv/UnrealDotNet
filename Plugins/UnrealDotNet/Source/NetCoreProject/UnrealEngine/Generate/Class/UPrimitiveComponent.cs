using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// PrimitiveComponents are SceneComponents that contain or generate some sort of geometry, generally to be rendered or used as collision data.
	/// There are several subclasses for the various types of geometry, but the most common by far are the ShapeComponents (Capsule, Sphere, Box), StaticMeshComponent, and SkeletalMeshComponent.
	/// ShapeComponents generate geometry that is used for collision detection but are not rendered, while StaticMeshComponents and SkeletalMeshComponents contain pre-built geometry that is rendered, but can also be used for collision detection.
	/// </summary>
	public partial class UPrimitiveComponent : USceneComponent
	{
		public UPrimitiveComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPrimitiveComponent_MinDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_MinDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_UPrimitiveComponent_VisibilityId_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_VisibilityId_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPrimitiveComponent_LastCheckedAllCollideableDescendantsTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_LastCheckedAllCollideableDescendantsTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPrimitiveComponent_BoundsScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_BoundsScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPrimitiveComponent_LastSubmitTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_LastSubmitTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPrimitiveComponent_LastRenderTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_LastRenderTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_UPrimitiveComponent_CurrentTag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPrimitiveComponent_CurrentTag_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UPrimitiveComponent_IsAttachedToStreamingManager(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(IntPtr Self, bool bAllowCachedValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_IgnoreActorWhenMoving(IntPtr Self, IntPtr Actor, bool bShouldIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_IgnoreComponentWhenMoving(IntPtr Self, IntPtr Component, bool bShouldIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_BeginComponentOverlap(IntPtr Self, IntPtr OtherOverlap, bool bDoNotifies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_EndComponentOverlap(IntPtr Self, IntPtr OtherOverlap, bool bDoNotifies, bool bSkipNotifySelf);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UPrimitiveComponent_IsOverlappingActor(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetBoundsScale(IntPtr Self, float NewBoundsScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UPrimitiveComponent_CanEditSimulatePhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_AddImpulse(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_AddImpulseAtLocation(IntPtr Self, IntPtr Impulse, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetPhysicsLinearVelocity(IntPtr Self, IntPtr NewVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsLinearVelocity(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(IntPtr Self, IntPtr Point, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(IntPtr Self, IntPtr NewVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(IntPtr Self, float NewMaxAngVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UPrimitiveComponent_GetCenterOfMass(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetCenterOfMass(IntPtr Self, IntPtr CenterOfMassOffset, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_WakeRigidBody(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetTranslucentSortPriority(IntPtr Self, int NewTranslucentSortPriority);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UPrimitiveComponent_GetCollisionProfileName(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetLODParentPrimitive(IntPtr Self, IntPtr InLODParentPrimitive);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UPrimitiveComponent_GetLODParentPrimitive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UPrimitiveComponent_GetLightMapResolution(IntPtr Self, int Width, int Height);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_UPrimitiveComponent_GetStaticLightMapResolution(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(IntPtr Self, int LightMapMemoryUsage, int ShadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_UPrimitiveComponent_GetStaticDepthPriorityGroup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UPrimitiveComponent_GetSquaredDistanceToCollision(IntPtr Self, IntPtr Point, float OutSquaredDistance, IntPtr OutClosestPointOnCollision);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UPrimitiveComponent_GetDistanceToCollision(IntPtr Self, IntPtr Point, IntPtr ClosestPointOnCollision);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UPrimitiveComponent_GetClosestPointOnCollision(IntPtr Self, IntPtr Point, IntPtr OutPointOnBody, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_WeldTo(IntPtr Self, IntPtr InParent, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UPrimitiveComponent_WeldToImplementation(IntPtr Self, IntPtr InParent, string ParentSocketName, bool bWeldSimulatedChild);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_DispatchWakeEvents(IntPtr Self, int WakeEvent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UPrimitiveComponent_AreSymmetricRotations(IntPtr Self, IntPtr A, IntPtr B, IntPtr Scale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_PushHoveredToProxy(IntPtr Self, bool bInHovered);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UPrimitiveComponent_GetEmissiveBoost(IntPtr Self, int ElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsAngularVelocity(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsPosition(IntPtr Self, IntPtr NewPos);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UPrimitiveComponent_GetLinearDamping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetMassScale(IntPtr Self, string BoneName, float InMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UPrimitiveComponent_GetMassScale(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetMassOverrideInKg(IntPtr Self, string BoneName, float MassInKg, bool bOverrideMass);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UPrimitiveComponent_ScaleByMomentOfInertia(IntPtr Self, IntPtr InputVector, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UPrimitiveComponent_CalculateMass(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_SetCachedMaxDrawDistance(IntPtr Self, float NewCachedMaxDrawDistance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UPrimitiveComponent_CanBeBaseForCharacter(IntPtr Self, IntPtr Pawn);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPrimitiveComponent_DispatchMouseOverEvents(IntPtr Self, IntPtr CurrentComponent, IntPtr NewComponent);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The minimum distance at which the primitive should be rendered,
		/// measured in world space units from the center of the primitive's bounding sphere to the camera position.
		/// </summary>
		public float MinDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_MinDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_MinDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object.
		/// </summary>
		public float DesiredMaxDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The distance to cull this primitive at.
		/// A CachedMaxDrawDistance of 0 indicates that the primitive should not be culled by distance.
		/// </summary>
		public float CurrentMaxDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)
		/// </summary>
		public int CustomDepthStencilValue
		{
			get => E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Translucent objects with a lower sort priority draw behind objects with a higher priority.
		/// Translucent objects with the same priority are rendered from back-to-front based on their bounds origin.
		/// Ignored if the object is not translucent.  The default priority is zero.
		/// Warning: This should never be set to a non-default value unless you know what you are doing, as it will prevent the renderer from sorting correctly.
		/// It is especially problematic on dynamic gameplay effects.
		/// </summary>
		public int TranslucencySortPriority
		{
			get => E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(NativePointer, value);
		}

		public int VisibilityId
		{
			get => E_PROP_UPrimitiveComponent_VisibilityId_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_VisibilityId_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Multiplier used to scale the Light Propagation Volume light injection bias, to reduce light bleeding.
		/// Set to 0 for no bias, 1 for default or higher for increased biasing (e.g. for
		/// thin geometry such as walls)
		/// </summary>
		public float LpvBiasMultiplier
		{
			get => E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Last time we checked AreAllCollideableDescendantsRelative(), so we can throttle those tests since it rarely changes once false.
		/// </summary>
		protected float LastCheckedAllCollideableDescendantsTime
		{
			get => E_PROP_UPrimitiveComponent_LastCheckedAllCollideableDescendantsTime_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastCheckedAllCollideableDescendantsTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scales the bounds of the object.
		/// This is useful when using World Position Offset to animate the vertices of the object outside of its bounds.
		/// Warning: Increasing the bounds of an object will reduce performance and shadow quality!
		/// Currently only used by StaticMeshComponent and SkeletalMeshComponent.
		/// </summary>
		public float BoundsScale
		{
			get => E_PROP_UPrimitiveComponent_BoundsScale_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_BoundsScale_SET(NativePointer, value);
		}

		public float LastSubmitTime
		{
			get => E_PROP_UPrimitiveComponent_LastSubmitTime_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastSubmitTime_SET(NativePointer, value);
		}

		public float LastRenderTime
		{
			get => E_PROP_UPrimitiveComponent_LastRenderTime_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastRenderTime_SET(NativePointer, value);
		}

		public float LastRenderTimeOnScreen
		{
			get => E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(NativePointer, value);
		}

		public int CurrentTag
		{
			get => E_PROP_UPrimitiveComponent_CurrentTag_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CurrentTag_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Whether this primitive is referenced by the streaming manager and should sent callbacks when detached or destroyed
		/// </summary>
		public bool IsAttachedToStreamingManager()
			=> E_UPrimitiveComponent_IsAttachedToStreamingManager(NativePointer);
		
		
		/// <summary>
		/// Returns true if all descendant components that we can possibly overlap with use relative location and rotation.
		/// </summary>
		protected bool AreAllCollideableDescendantsRelative(bool bAllowCachedValue = true)
			=> E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(NativePointer, bAllowCachedValue);
		
		
		/// <summary>
		/// Tells this component whether to ignore collision with all components of a specific Actor when this component is moved.
		/// Components on the other Actor may also need to be told to do the same when they move.
		/// Does not affect movement of this component when simulating physics.
		/// </summary>
		public void IgnoreActorWhenMoving(AActor Actor, bool bShouldIgnore)
			=> E_UPrimitiveComponent_IgnoreActorWhenMoving(NativePointer, Actor, bShouldIgnore);
		
		
		/// <summary>
		/// Tells this component whether to ignore collision with another component when this component is moved.
		/// The other components may also need to be told to do the same when they move.
		/// Does not affect movement of this component when simulating physics.
		/// </summary>
		public void IgnoreComponentWhenMoving(UPrimitiveComponent Component, bool bShouldIgnore)
			=> E_UPrimitiveComponent_IgnoreComponentWhenMoving(NativePointer, Component, bShouldIgnore);
		
		
		/// <summary>
		/// Begin tracking an overlap interaction with the component specified.
		/// @param OtherComp - The component of the other actor that this component is now overlapping
		/// @param bDoNotifies - True to dispatch appropriate begin/end overlap notifications when these events occur.
		/// @see [Overlap Events](https://docs.unrealengine.com/latest/INT/Engine/Physics/Collision/index.html#overlapandgenerateoverlapevents)
		/// </summary>
		public void BeginComponentOverlap(FOverlapInfo OtherOverlap, bool bDoNotifies)
			=> E_UPrimitiveComponent_BeginComponentOverlap(NativePointer, OtherOverlap, bDoNotifies);
		
		
		/// <summary>
		/// Finish tracking an overlap interaction that is no longer occurring between this component and the component specified.
		/// @param OtherComp The component of the other actor to stop overlapping
		/// @param bDoNotifies True to dispatch appropriate begin/end overlap notifications when these events occur.
		/// @param bSkipNotifySelf True to skip end overlap notifications to this component's.  Does not affect notifications to OtherComp's actor.
		/// @see [Overlap Events](https://docs.unrealengine.com/latest/INT/Engine/Physics/Collision/index.html#overlapandgenerateoverlapevents)
		/// </summary>
		public void EndComponentOverlap(FOverlapInfo OtherOverlap, bool bDoNotifies = true, bool bSkipNotifySelf = false)
			=> E_UPrimitiveComponent_EndComponentOverlap(NativePointer, OtherOverlap, bDoNotifies, bSkipNotifySelf);
		
		
		/// <summary>
		/// Check whether this component is overlapping any component of the given Actor.
		/// @param Other Actor to test this component against.
		/// @return Whether this component is overlapping any component of the given Actor.
		/// </summary>
		public bool IsOverlappingActor(AActor Other)
			=> E_UPrimitiveComponent_IsOverlappingActor(NativePointer, Other);
		
		
		/// <summary>
		/// Scale the bounds of this object, used for frustum culling. Useful for features like WorldPositionOffset.
		/// </summary>
		public void SetBoundsScale(float NewBoundsScale)
			=> E_UPrimitiveComponent_SetBoundsScale(NativePointer, NewBoundsScale);
		
		
		/// <summary>
		/// Determines whether or not the simulate physics setting can be edited interactively on this component
		/// </summary>
		public bool CanEditSimulatePhysics()
			=> E_UPrimitiveComponent_CanEditSimulatePhysics(NativePointer);
		
		
		/// <summary>
		/// Add an impulse to a single rigid body. Good for one time instant burst.
		/// @param	Impulse		Magnitude and direction of impulse to apply.
		/// @param	BoneName	If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.
		/// @param	bVelChange	If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no affect).
		/// </summary>
		public void AddImpulse(FVector Impulse, string BoneName, bool bVelChange = false)
			=> E_UPrimitiveComponent_AddImpulse(NativePointer, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// Add an impulse to a single rigid body at a specific location.
		/// @param	Impulse		Magnitude and direction of impulse to apply.
		/// @param	Location	Point in world space to apply impulse at.
		/// @param	BoneName	If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body.
		/// </summary>
		public void AddImpulseAtLocation(FVector Impulse, FVector Location, string BoneName)
			=> E_UPrimitiveComponent_AddImpulseAtLocation(NativePointer, Impulse, Location, BoneName);
		
		
		/// <summary>
		/// Set the linear velocity of a single body.
		/// This should be used cautiously - it may be better to use AddForce or AddImpulse.
		/// @param NewVel			New linear velocity to apply to physics.
		/// @param bAddToCurrent	If true, NewVel is added to the existing velocity of the body.
		/// @param BoneName			If a SkeletalMeshComponent, name of body to modify velocity of. 'None' indicates root body.
		/// </summary>
		public void SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsLinearVelocity(NativePointer, NewVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// Get the linear velocity of a single body.
		/// @param BoneName			If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
		/// </summary>
		public FVector GetPhysicsLinearVelocity(string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsLinearVelocity(NativePointer, BoneName);
		
		
		/// <summary>
		/// Get the linear velocity of a point on a single body.
		/// @param Point			Point is specified in world space.
		/// @param BoneName			If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.
		/// </summary>
		public FVector GetPhysicsLinearVelocityAtPoint(FVector Point, string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(NativePointer, Point, BoneName);
		
		
		/// <summary>
		/// Set the linear velocity of all bodies in this component.
		/// @param NewVel			New linear velocity to apply to physics.
		/// @param bAddToCurrent	If true, NewVel is added to the existing velocity of the body.
		/// </summary>
		public void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent = false)
			=> E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(NativePointer, NewVel, bAddToCurrent);
		
		
		/// <summary>
		/// Set the maximum angular velocity of a single body.
		/// @param NewMaxAngVel		New maximum angular velocity to apply to body, in degrees per second.
		/// @param bAddToCurrent	If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.
		/// @param BoneName			If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.
		/// </summary>
		public void SetPhysicsMaxAngularVelocity(float NewMaxAngVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(NativePointer, NewMaxAngVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// Get the center of mass of a single body. In the case of a welded body this will return the center of mass of the entire welded body (including its parent and children)
		/// Objects that are not simulated return (0,0,0) as they do not have COM
		/// @param BoneName			If a SkeletalMeshComponent, name of body to get center of mass of. 'None' indicates root body.
		/// </summary>
		public FVector GetCenterOfMass(string BoneName)
			=> E_UPrimitiveComponent_GetCenterOfMass(NativePointer, BoneName);
		
		
		/// <summary>
		/// Set the center of mass of a single body. This will offset the physx-calculated center of mass.
		/// Note that in the case where multiple bodies are attached together, the center of mass will be set for the entire group.
		/// @param CenterOfMassOffset		User specified offset for the center of mass of this object, from the calculated location.
		/// @param BoneName			If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
		/// </summary>
		public void SetCenterOfMass(FVector CenterOfMassOffset, string BoneName)
			=> E_UPrimitiveComponent_SetCenterOfMass(NativePointer, CenterOfMassOffset, BoneName);
		
		
		/// <summary>
		/// 'Wake' physics simulation for a single body.
		/// @param	BoneName	If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body.
		/// </summary>
		public void WakeRigidBody(string BoneName)
			=> E_UPrimitiveComponent_WakeRigidBody(NativePointer, BoneName);
		
		
		/// <summary>
		/// Changes the value of TranslucentSortPriority.
		/// </summary>
		public void SetTranslucentSortPriority(int NewTranslucentSortPriority)
			=> E_UPrimitiveComponent_SetTranslucentSortPriority(NativePointer, NewTranslucentSortPriority);
		
		
		/// <summary>
		/// Get the collision profile name
		/// </summary>
		public string GetCollisionProfileName()
			=> Marshal.PtrToStringUTF8(E_UPrimitiveComponent_GetCollisionProfileName(NativePointer, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// LOD parent primitive to draw instead of this one (multiple UPrim's will point to the same LODParent )
		/// </summary>
		public void SetLODParentPrimitive(UPrimitiveComponent InLODParentPrimitive)
			=> E_UPrimitiveComponent_SetLODParentPrimitive(NativePointer, InLODParentPrimitive);
		
		public UPrimitiveComponent GetLODParentPrimitive()
			=> E_UPrimitiveComponent_GetLODParentPrimitive(NativePointer);
		
		
		/// <summary>
		/// Returns the lightmap resolution used for this primitive instance in the case of it supporting texture light/ shadow maps.
		/// 0 if not supported or no static shadowing.
		/// @param	Width	[out]	Width of light/shadow map
		/// @param	Height	[out]	Height of light/shadow map
		/// @return	bool			true if LightMap values are padded, false if not
		/// </summary>
		public bool GetLightMapResolution(int Width, int Height)
			=> E_UPrimitiveComponent_GetLightMapResolution(NativePointer, Width, Height);
		
		
		/// <summary>
		/// Returns the static lightmap resolution used for this primitive.
		/// 0 if not supported or no static shadowing.
		/// @return	int32		The StaticLightmapResolution for the component
		/// </summary>
		public int GetStaticLightMapResolution()
			=> E_UPrimitiveComponent_GetStaticLightMapResolution(NativePointer);
		
		
		/// <summary>
		/// Returns the light and shadow map memory for this primitive in its out variables.
		/// Shadow map memory usage is per light whereof lightmap data is independent of number of lights, assuming at least one.
		/// @param [out] LightMapMemoryUsage		Memory usage in bytes for light map (either texel or vertex) data
		/// @param [out]	ShadowMapMemoryUsage	Memory usage in bytes for shadow map (either texel or vertex) data
		/// </summary>
		public void GetLightAndShadowMapMemoryUsage(int LightMapMemoryUsage, int ShadowMapMemoryUsage)
			=> E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(NativePointer, LightMapMemoryUsage, ShadowMapMemoryUsage);
		
		
		/// <summary>
		/// Determines the DPG the primitive's primary elements are drawn in.
		/// Even if the primitive's elements are drawn in multiple DPGs, a primary DPG is needed for occlusion culling and shadow projection.
		/// @return The DPG the primitive's primary elements will be drawn in.
		/// </summary>
		public byte GetStaticDepthPriorityGroup()
			=> E_UPrimitiveComponent_GetStaticDepthPriorityGroup(NativePointer);
		
		
		/// <summary>
		/// returns The square of the distance to closest Body Instance surface.
		/// @param Point				World 3D vector
		/// @param OutSquaredDistance The squared distance to closest Body Instance surface. 0 if inside of the body
		/// @param OutPointOnBody	Point on the surface of collision closest to Point
		/// @return		true if a distance to the body was found and OutDistanceSquared has been populated
		/// </summary>
		public bool GetSquaredDistanceToCollision(FVector Point, float OutSquaredDistance, FVector OutClosestPointOnCollision)
			=> E_UPrimitiveComponent_GetSquaredDistanceToCollision(NativePointer, Point, OutSquaredDistance, OutClosestPointOnCollision);
		
		
		/// <summary>
		/// returns Distance to closest Body Instance surface.
		/// @param Point				World 3D vector
		/// @param OutPointOnBody	Point on the surface of collision closest to Point
		/// @return		Success if returns > 0.f, if returns 0.f, point is inside the geometry
		/// If returns < 0.f, this primitive does not have collsion or if geometry is not supported
		/// </summary>
		public float GetDistanceToCollision(FVector Point, FVector ClosestPointOnCollision)
			=> E_UPrimitiveComponent_GetDistanceToCollision(NativePointer, Point, ClosestPointOnCollision);
		
		
		/// <summary>
		/// Returns the distance and closest point to the collision surface.
		/// Component must have simple collision to be queried for closest point.
		/// @param Point				World 3D vector
		/// @param OutPointOnBody		Point on the surface of collision closest to Point
		/// @param BoneName			If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.
		/// @return		Success if returns > 0.f, if returns 0.f, it is either not convex or inside of the point
		/// If returns < 0.f, this primitive does not have collsion
		/// </summary>
		public float GetClosestPointOnCollision(FVector Point, FVector OutPointOnBody, string BoneName)
			=> E_UPrimitiveComponent_GetClosestPointOnCollision(NativePointer, Point, OutPointOnBody, BoneName);
		
		
		/// <summary>
		/// Welds this component to another scene component, optionally at a named socket. Component is automatically attached if not already
		/// Welding allows the child physics object to become physically connected to its parent. This is useful for creating compound rigid bodies with correct mass distribution.
		/// @param InParent the component to be physically attached to
		/// @param InSocketName optional socket to attach component to
		/// </summary>
		public void WeldTo(USceneComponent InParent, string InSocketName)
			=> E_UPrimitiveComponent_WeldTo(NativePointer, InParent, InSocketName);
		
		
		/// <summary>
		/// Does the actual work for welding.
		/// @return true if did a true weld of shapes, meaning body initialization is not needed
		/// </summary>
		public bool WeldToImplementation(USceneComponent InParent, string ParentSocketName, bool bWeldSimulatedChild = true)
			=> E_UPrimitiveComponent_WeldToImplementation(NativePointer, InParent, ParentSocketName, bWeldSimulatedChild);
		
		
		/// <summary>
		/// Dispatch notification for wake events and propagate to any welded bodies
		/// </summary>
		public void DispatchWakeEvents(int WakeEvent, string BoneName)
			=> E_UPrimitiveComponent_DispatchWakeEvents(NativePointer, WakeEvent, BoneName);
		
		
		/// <summary>
		/// Returns true if the given transforms result in the same bounds, due to rotational symmetry.
		/// For example, this is true for a sphere with uniform scale undergoing any rotation.
		/// This is NOT intended to detect every case where this is true, only the common cases to aid optimizations.
		/// </summary>
		public bool AreSymmetricRotations(FQuat A, FQuat B, FVector Scale3D)
			=> E_UPrimitiveComponent_AreSymmetricRotations(NativePointer, A, B, Scale3D);
		
		
		/// <summary>
		/// Pushes new hover state to the render thread primitive proxy
		/// @param bInHovered - true if the proxy should display as if hovered
		/// </summary>
		public void PushHoveredToProxy(bool bInHovered)
			=> E_UPrimitiveComponent_PushHoveredToProxy(NativePointer, bInHovered);
		
		
		/// <summary>
		/// Gets the emissive boost for the primitive component.
		/// </summary>
		public float GetEmissiveBoost(int ElementIndex)
			=> E_UPrimitiveComponent_GetEmissiveBoost(NativePointer, ElementIndex);
		
		
		/// <summary>
		/// Set the angular velocity of all bodies in this component.
		/// @param NewAngVel		New angular velocity to apply to physics, in degrees per second.
		/// @param bAddToCurrent	If true, NewAngVel is added to the existing angular velocity of all bodies.
		/// </summary>
		public void SetAllPhysicsAngularVelocity(FVector NewAngVel, bool bAddToCurrent = false)
			=> E_UPrimitiveComponent_SetAllPhysicsAngularVelocity(NativePointer, NewAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// Set the position of all bodies in this component.
		/// If a SkeletalMeshComponent, the root body will be placed at the desired position, and the same delta is applied to all other bodies.
		/// @param	NewPos		New position for the body
		/// </summary>
		public void SetAllPhysicsPosition(FVector NewPos)
			=> E_UPrimitiveComponent_SetAllPhysicsPosition(NativePointer, NewPos);
		
		
		/// <summary>
		/// Returns the linear damping of this component.
		/// </summary>
		public float GetLinearDamping()
			=> E_UPrimitiveComponent_GetLinearDamping(NativePointer);
		
		
		/// <summary>
		/// Change the mass scale used to calculate the mass of a single physics body
		/// </summary>
		public void SetMassScale(string BoneName, float InMassScale)
			=> E_UPrimitiveComponent_SetMassScale(NativePointer, BoneName, InMassScale);
		
		
		/// <summary>
		/// Returns the mass scale used to calculate the mass of a single physics body
		/// </summary>
		public float GetMassScale(string BoneName)
			=> E_UPrimitiveComponent_GetMassScale(NativePointer, BoneName);
		
		
		/// <summary>
		/// Override the mass (in Kg) of a single physics body.
		/// Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group.
		/// Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass.
		/// </summary>
		public void SetMassOverrideInKg(string BoneName, float MassInKg, bool bOverrideMass = true)
			=> E_UPrimitiveComponent_SetMassOverrideInKg(NativePointer, BoneName, MassInKg, bOverrideMass);
		
		
		/// <summary>
		/// Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object.
		/// </summary>
		public FVector ScaleByMomentOfInertia(FVector InputVector, string BoneName)
			=> E_UPrimitiveComponent_ScaleByMomentOfInertia(NativePointer, InputVector, BoneName);
		
		
		/// <summary>
		/// Returns the calculated mass in kg. This is not 100% exactly the mass physx will calculate, but it is very close ( difference < 0.1kg ).
		/// </summary>
		public float CalculateMass(string BoneName)
			=> E_UPrimitiveComponent_CalculateMass(NativePointer, BoneName);
		
		
		/// <summary>
		/// Utility to cache the max draw distance based on cull distance volumes or the desired max draw distance
		/// </summary>
		public void SetCachedMaxDrawDistance(float NewCachedMaxDrawDistance)
			=> E_UPrimitiveComponent_SetCachedMaxDrawDistance(NativePointer, NewCachedMaxDrawDistance);
		
		
		/// <summary>
		/// Return true if the given Pawn can step up onto this component.
		/// @param APawn is the pawn that wants to step onto this component.
		/// </summary>
		public bool CanBeBaseForCharacter(APawn Pawn)
			=> E_UPrimitiveComponent_CanBeBaseForCharacter(NativePointer, Pawn);
		
		public void DispatchMouseOverEvents(UPrimitiveComponent CurrentComponent, UPrimitiveComponent NewComponent)
			=> E_UPrimitiveComponent_DispatchMouseOverEvents(NativePointer, CurrentComponent, NewComponent);
		
		#endregion
		
		public static implicit operator IntPtr(UPrimitiveComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPrimitiveComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UPrimitiveComponent(Adress);
		}}}
