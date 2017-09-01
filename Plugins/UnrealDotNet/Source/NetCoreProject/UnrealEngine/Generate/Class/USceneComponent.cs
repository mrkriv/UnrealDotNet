using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A SceneComponent has a transform and supports attachment, but has no rendering or collision capabilities.
	/// Useful as a 'dummy' component in the hierarchy to offset others.
	/// @see [Scene Components](https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/Components/index.html#scenecomponents)
	/// </summary>
	public partial class USceneComponent : UActorComponent
	{
		public USceneComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FTransform E_PROP_USceneComponent_ComponentToWorld_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USceneComponent_ComponentToWorld_SET(IntPtr Ptr, FTransform Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_USceneComponent_RelativeLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USceneComponent_RelativeLocation_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FRotator E_PROP_USceneComponent_RelativeRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USceneComponent_RelativeRotation_SET(IntPtr Ptr, FRotator Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_USceneComponent_RelativeScale3D_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USceneComponent_RelativeScale3D_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_USceneComponent_ComponentVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USceneComponent_ComponentVelocity_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetDefaultSceneRootVariableName(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetRelativeTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneComponent_SetRelativeScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_K2_GetComponentRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_USceneComponent_IsSimulatingPhysics(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_USceneComponent_IsAnySimulatingPhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetAttachParent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetAttachSocketName(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_USceneComponent_GetNumChildrenComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetChildComponent(IntPtr Self, int ChildIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneComponent_SetupAttachment(IntPtr Self, IntPtr InParent, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_USceneComponent_SnapTo(IntPtr Self, IntPtr InParent, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneComponent_DetachFromParent(IntPtr Self, bool bMaintainWorldPosition, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetSocketLocation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetSocketRotation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetSocketQuaternion(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneComponent_ToggleVisibility(IntPtr Self, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_USceneComponent_CheckStaticMobilityAndWarn(IntPtr Self, string ActionText);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetComponentQuat(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneComponent_SetComponentToWorld(IntPtr Self, IntPtr NewComponentToWorld);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneComponent_CalcBoundingCylinder(IntPtr Self, float CylinderRadius, float CylinderHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_CalcNewComponentToWorld(IntPtr Self, IntPtr NewRelativeTransform, IntPtr Parent, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneComponent_SetAbsolute(IntPtr Self, bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneComponent_SetWorldLocationAndRotationNoPhysics(IntPtr Self, IntPtr NewLocation, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USceneComponent_GetAttachmentRootActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_USceneComponent_IsAttachedTo(IntPtr Self, IntPtr TestComp);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_USceneComponent_CanAttachAsChild(IntPtr Self, IntPtr ChildComponent, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneComponent_OnChildAttached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_USceneComponent_AreDynamicDataChangesAllowed(IntPtr Self, bool bIgnoreStationary);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Current transform of the component, relative to the world
		/// </summary>
		public FTransform ComponentToWorld
		{
			get => E_PROP_USceneComponent_ComponentToWorld_GET(NativePointer);
			set => E_PROP_USceneComponent_ComponentToWorld_SET(NativePointer, value);
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
		/// Note that scaling is always applied in local space (no shearing etc)
		/// </summary>
		public FVector RelativeScale3D
		{
			get => E_PROP_USceneComponent_RelativeScale3D_GET(NativePointer);
			set => E_PROP_USceneComponent_RelativeScale3D_SET(NativePointer, value);
		}

		public FVector RelativeTranslation_DEPRECATED
		{
			get => E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_GET(NativePointer);
			set => E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_SET(NativePointer, value);
		}

		public FVector ComponentVelocity
		{
			get => E_PROP_USceneComponent_ComponentVelocity_GET(NativePointer);
			set => E_PROP_USceneComponent_ComponentVelocity_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// The name to use for the default scene root variable
		/// </summary>
		public string GetDefaultSceneRootVariableName()
			=> Marshal.PtrToStringUTF8(E_USceneComponent_GetDefaultSceneRootVariableName(NativePointer, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// Returns the transform of the component relative to its parent
		/// </summary>
		public FTransform GetRelativeTransform()
			=> E_USceneComponent_GetRelativeTransform(NativePointer);
		
		
		/// <summary>
		/// Set the non-uniform scale of the component relative to its parent
		/// </summary>
		public void SetRelativeScale3D(FVector NewScale3D)
			=> E_USceneComponent_SetRelativeScale3D(NativePointer, NewScale3D);
		
		
		/// <summary>
		/// Return location of the component, in world space
		/// </summary>
		public FVector GetWorldLocation()
			=> E_USceneComponent_K2_GetComponentLocation(NativePointer);
		
		
		/// <summary>
		/// Returns rotation of the component, in world space.
		/// </summary>
		public FRotator GetWorldRotation()
			=> E_USceneComponent_K2_GetComponentRotation(NativePointer);
		
		
		/// <summary>
		/// Returns whether the specified body is currently using physics simulation
		/// </summary>
		public bool IsSimulatingPhysics(string BoneName)
			=> E_USceneComponent_IsSimulatingPhysics(NativePointer, BoneName);
		
		
		/// <summary>
		/// Returns whether the specified body is currently using physics simulation
		/// </summary>
		public bool IsAnySimulatingPhysics()
			=> E_USceneComponent_IsAnySimulatingPhysics(NativePointer);
		
		
		/// <summary>
		/// Get the SceneComponent we are attached to.
		/// </summary>
		public USceneComponent GetAttachParent()
			=> E_USceneComponent_GetAttachParent(NativePointer);
		
		
		/// <summary>
		/// Get the socket we are attached to.
		/// </summary>
		public string GetAttachSocketName()
			=> Marshal.PtrToStringUTF8(E_USceneComponent_GetAttachSocketName(NativePointer, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// Gets the number of attached children components
		/// </summary>
		public int GetNumChildrenComponents()
			=> E_USceneComponent_GetNumChildrenComponents(NativePointer);
		
		
		/// <summary>
		/// Gets the attached child component at the specified location
		/// </summary>
		public USceneComponent GetChildComponent(int ChildIndex)
			=> E_USceneComponent_GetChildComponent(NativePointer, ChildIndex);
		
		
		/// <summary>
		/// Initializes desired Attach Parent and SocketName to be attached to when the component is registered.
		/// Generally intended to be called from its Owning Actor's constructor and should be preferred over AttachToComponent when
		/// a component is not registered.
		/// @param  InParent				Parent to attach to.
		/// @param  InSocketName			Optional socket to attach to on the parent.
		/// </summary>
		public void SetupAttachment(USceneComponent InParent, string InSocketName)
			=> E_USceneComponent_SetupAttachment(NativePointer, InParent, InSocketName);
		
		
		/// <summary>
		/// Zeroes out the relative transform of the component, and calls AttachTo(). Useful for attaching directly to a scene component or socket location
		/// </summary>
		public bool SnapTo(USceneComponent InParent, string InSocketName)
			=> E_USceneComponent_SnapTo(NativePointer, InParent, InSocketName);
		
		
		/// <summary>
		/// Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo)
		/// @param bMaintainWorldPosition	If true, update the relative location of the component to keep its world position the same
		/// @param bCallModify				If true, call Modify() on the component and the current attach parent component
		/// </summary>
		public void DetachFromParentDeprecated(bool bMaintainWorldPosition = false, bool bCallModify = true)
			=> E_USceneComponent_DetachFromParent(NativePointer, bMaintainWorldPosition, bCallModify);
		
		
		/// <summary>
		/// Get world-space socket or bone location.
		/// @param InSocketName Name of the socket or the bone to get the transform
		/// @return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
		/// </summary>
		public FVector GetSocketLocation(string InSocketName)
			=> E_USceneComponent_GetSocketLocation(NativePointer, InSocketName);
		
		
		/// <summary>
		/// Get world-space socket or bone  FRotator rotation.
		/// @param InSocketName Name of the socket or the bone to get the transform
		/// @return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
		/// </summary>
		public FRotator GetSocketRotation(string InSocketName)
			=> E_USceneComponent_GetSocketRotation(NativePointer, InSocketName);
		
		
		/// <summary>
		/// Get world-space socket or bone FQuat rotation.
		/// @param InSocketName Name of the socket or the bone to get the transform
		/// @return Socket transform in world space if socket if found. Otherwise it will return component's transform in world space.
		/// </summary>
		public FQuat GetSocketQuaternion(string InSocketName)
			=> E_USceneComponent_GetSocketQuaternion(NativePointer, InSocketName);
		
		
		/// <summary>
		/// Toggle visibility of the component
		/// </summary>
		public void ToggleVisibility(bool bPropagateToChildren = false)
			=> E_USceneComponent_ToggleVisibility(NativePointer, bPropagateToChildren);
		
		
		/// <summary>
		/// Check if mobility is set to non-static. If it's static we trigger a PIE warning and return true
		/// </summary>
		protected bool CheckStaticMobilityAndWarn(string ActionText)
			=> E_USceneComponent_CheckStaticMobilityAndWarn(NativePointer, ActionText);
		
		
		/// <summary>
		/// Return rotation quaternion of the component, in world space
		/// </summary>
		public FQuat GetComponentQuat()
			=> E_USceneComponent_GetComponentQuat(NativePointer);
		
		
		/// <summary>
		/// Sets the cached component to world directly. This should be used very rarely.
		/// </summary>
		public void SetComponentToWorld(FTransform NewComponentToWorld)
			=> E_USceneComponent_SetComponentToWorld(NativePointer, NewComponentToWorld);
		
		
		/// <summary>
		/// Calculate the axis-aligned bounding cylinder of the component (radius in X-Y, half-height along Z axis).
		/// Default behavior is just a cylinder around the box of the cached BoxSphereBounds.
		/// </summary>
		public void CalcBoundingCylinder(float CylinderRadius, float CylinderHalfHeight)
			=> E_USceneComponent_CalcBoundingCylinder(NativePointer, CylinderRadius, CylinderHalfHeight);
		
		
		/// <summary>
		/// Calculate the new ComponentToWorld transform for this component.
		/// Parent is optional and can be used for computing ComponentToWorld based on arbitrary USceneComponent.
		/// If Parent is not passed in we use the component's AttachParent
		/// </summary>
		protected FTransform CalcNewComponentToWorld(FTransform NewRelativeTransform, USceneComponent Parent, string SocketName)
			=> E_USceneComponent_CalcNewComponentToWorld(NativePointer, NewRelativeTransform, Parent, SocketName);
		
		
		/// <summary>
		/// Set which parts of the relative transform should be relative to parent, and which should be relative to world
		/// </summary>
		public void SetAbsolute(bool bNewAbsoluteLocation = false, bool bNewAbsoluteRotation = false, bool bNewAbsoluteScale = false)
			=> E_USceneComponent_SetAbsolute(NativePointer, bNewAbsoluteLocation, bNewAbsoluteRotation, bNewAbsoluteScale);
		
		
		/// <summary>
		/// Special version of SetWorldLocationAndRotation that does not affect physics.
		/// </summary>
		public void SetWorldLocationAndRotationNoPhysics(FVector NewLocation, FRotator NewRotation)
			=> E_USceneComponent_SetWorldLocationAndRotationNoPhysics(NativePointer, NewLocation, NewRotation);
		
		
		/// <summary>
		/// Walks up the attachment chain from this SceneComponent and returns the top-level actor it's attached to.  Returns Owner if unattached.
		/// </summary>
		public AActor GetAttachmentRootActor()
			=> E_USceneComponent_GetAttachmentRootActor(NativePointer);
		
		
		/// <summary>
		/// Walks up the attachment chain to see if this component is attached to the supplied component. If TestComp == this, returns false.
		/// </summary>
		public bool IsAttachedTo(USceneComponent TestComp)
			=> E_USceneComponent_IsAttachedTo(NativePointer, TestComp);
		
		
		/// <summary>
		/// Called to see if it's possible to attach another scene component as a child.
		/// Note: This can be called on template component as well!
		/// </summary>
		public bool CanAttachAsChild(USceneComponent ChildComponent, string SocketName)
			=> E_USceneComponent_CanAttachAsChild(NativePointer, ChildComponent, SocketName);
		
		
		/// <summary>
		/// Called after a child scene component is attached to this component.
		/// Note: Do not change the attachment state of the child during this call.
		/// </summary>
		protected void OnChildAttached(USceneComponent ChildComponent)
			=> E_USceneComponent_OnChildAttached(NativePointer, ChildComponent);
		
		
		/// <summary>
		/// Determine if dynamic data is allowed to be changed.
		/// @param bIgnoreStationary Whether or not to ignore stationary mobility when checking. Default is true (i.e. - check for static mobility only).
		/// @return Whether or not dynamic data is allowed to be changed.
		/// </summary>
		protected bool AreDynamicDataChangesAllowed(bool bIgnoreStationary = true)
			=> E_USceneComponent_AreDynamicDataChangesAllowed(NativePointer, bIgnoreStationary);
		
		#endregion
		
		public static implicit operator IntPtr(USceneComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new USceneComponent(Adress);
		}}}
