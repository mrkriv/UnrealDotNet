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
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_ComponentToWorld_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_ComponentToWorld_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_ComponentVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_ComponentVelocity_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_RelativeLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_RelativeLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_RelativeRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_RelativeRotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_RelativeScale3D_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_RelativeScale3D_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_SET(IntPtr Ptr, IntPtr Value);
		
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
		private static extern ObjectPointerDescription E_USceneComponent_GetAttachmentRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetAttachmentRootActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetAttachParent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetAttachSocketName(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneComponent_GetChildComponent(IntPtr Self, int ChildIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentQuat(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetComponentScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetDefaultSceneRootVariableName(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetForwardVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USceneComponent_GetNumChildrenComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetRelativeTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetRightVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USceneComponent_GetUpVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsAttachedTo(IntPtr Self, IntPtr TestComp);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsDeferringMovementUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsPhysicsCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_IsQueryCollisionEnabled(IntPtr Self);
		
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
		private static extern void E_USceneComponent_OnAttachmentChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnChildAttached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnChildDetached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_OnHiddenInGameChanged(IntPtr Self);
		
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
		private static extern void E_USceneComponent_SetRelativeScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetupAttachment(IntPtr Self, IntPtr InParent, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetVisibility(IntPtr Self, bool bNewVisibility, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldLocationAndRotationNoPhysics(IntPtr Self, IntPtr NewLocation, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldScale3D(IntPtr Self, IntPtr NewScale);
		
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
		private static extern void E_USceneComponent_UpdateNavigationData(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_UpdatePhysicsVolume(IntPtr Self, bool bTriggerNotifiers);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Current transform of the component, relative to the world </para>
		/// </summary>
		public FTransform ComponentToWorld
		{
			get => E_PROP_USceneComponent_ComponentToWorld_GET(NativePointer);
			set => E_PROP_USceneComponent_ComponentToWorld_SET(NativePointer, value);
		}

		public FVector ComponentVelocity
		{
			get => E_PROP_USceneComponent_ComponentVelocity_GET(NativePointer);
			set => E_PROP_USceneComponent_ComponentVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Location of the component relative to its parent </para>
		/// </summary>
		public FVector RelativeLocation
		{
			get => E_PROP_USceneComponent_RelativeLocation_GET(NativePointer);
			set => E_PROP_USceneComponent_RelativeLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Rotation of the component relative to its parent </para>
		/// </summary>
		public FRotator RelativeRotation
		{
			get => E_PROP_USceneComponent_RelativeRotation_GET(NativePointer);
			set => E_PROP_USceneComponent_RelativeRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Non-uniform scaling of the component relative to its parent. </para>
		/// <para>Note that scaling is always applied in local space (no shearing etc) </para>
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

		#endregion
		
		#region ExternMethods
		
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
			=> Marshal.PtrToStringUTF8(E_USceneComponent_GetAttachSocketName(this, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// <para>Gets the attached child component at the specified location </para>
		/// </summary>
		public USceneComponent GetChildComponent(int ChildIndex)
			=> E_USceneComponent_GetChildComponent(this, ChildIndex);
		
		
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
		/// <para>The name to use for the default scene root variable </para>
		/// </summary>
		public string GetDefaultSceneRootVariableName()
			=> Marshal.PtrToStringUTF8(E_USceneComponent_GetDefaultSceneRootVariableName(this, out int ResultStringLen), ResultStringLen);
		
		
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
		/// <para>Get the up (Z) unit direction vector from this component, in world space. </para>
		/// </summary>
		public FVector GetUpVector()
			=> E_USceneComponent_GetUpVector(this);
		
		
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
		
		
		/// <summary>
		/// <para>Utility to see if there is any query collision enabled on this component. </para>
		/// </summary>
		public bool IsQueryCollisionEnabled()
			=> E_USceneComponent_IsQueryCollisionEnabled(this);
		
		
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
		
		
		/// <summary>
		/// <para>Set the non-uniform scale of the component relative to its parent </para>
		/// </summary>
		public virtual void SetRelativeScale3D(FVector NewScale3D)
			=> E_USceneComponent_SetRelativeScale3D(this, NewScale3D);
		
		
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
