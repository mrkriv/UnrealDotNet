using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SceneComponent.h:103

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
		private static extern void E_USceneComponent_CalcBoundingCylinder(IntPtr Self, float CylinderRadius, float CylinderHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_CanEverRender(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_CheckStaticMobilityAndWarn(IntPtr Self, string ActionText);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_ConditionalUpdateComponentToWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_DetachFromParent(IntPtr Self, bool bMaintainWorldPosition, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_DoesSocketExist(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USceneComponent_GetAttachSocketName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USceneComponent_GetCollisionObjectType(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USceneComponent_GetCollisionResponseToChannel(IntPtr Self, byte Channel);
		
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
		private static extern bool E_USceneComponent_IsAnySimulatingPhysics(IntPtr Self);
		
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
		private static extern void E_USceneComponent_SetHiddenInGame(IntPtr Self, bool NewHidden, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetRelativeScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetVisibility(IntPtr Self, bool bNewVisibility, bool bPropagateToChildren);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneComponent_SetWorldScale3D(IntPtr Self, IntPtr NewScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldCollideWhenPlacing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldComponentAddToScene(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USceneComponent_ShouldRender(IntPtr Self);
		
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
		/// <para>Calculate the axis-aligned bounding cylinder of the component (radius in X-Y, half-height along Z axis). </para>
		/// <para>Default behavior is just a cylinder around the box of the cached BoxSphereBounds. </para>
		/// </summary>
		public virtual void CalcBoundingCylinder(float CylinderRadius, float CylinderHalfHeight)
			=> E_USceneComponent_CalcBoundingCylinder(this, CylinderRadius, CylinderHalfHeight);
		
		
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
		/// <para>Get the socket we are attached to. </para>
		/// </summary>
		public string GetAttachSocketName()
			=> E_USceneComponent_GetAttachSocketName(this);
		
		
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
		/// <para>Returns whether the specified body is currently using physics simulation </para>
		/// </summary>
		public virtual bool IsAnySimulatingPhysics()
			=> E_USceneComponent_IsAnySimulatingPhysics(this);
		
		
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
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="LocationRule">How to handle translations when detaching. </param>
		/// <param name="RotationRule">How to handle rotation when detaching. </param>
		/// <param name="ScaleRule">How to handle scales when detaching. </param>
		/// <param name="bCallModify">If true, call Modify() on the component and the current attach parent component </param>
		/// </summary>
		public void DetachFromComponent(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, bool bCallModify = true)
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
		/// <para>Set visibility of the component, if during game use this to turn on/off </para>
		/// </summary>
		public void SetVisibility(bool bNewVisibility, bool bPropagateToChildren = false)
			=> E_USceneComponent_SetVisibility(this, bNewVisibility, bPropagateToChildren);
		
		
		/// <summary>
		/// <para>Set the relative scale of the component to put it at the supplied scale in world space. </para>
		/// <param name="NewScale">New scale in world space for this component. </param>
		/// </summary>
		public void SetWorldScale3D(FVector NewScale)
			=> E_USceneComponent_SetWorldScale3D(this, NewScale);
		
		
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
