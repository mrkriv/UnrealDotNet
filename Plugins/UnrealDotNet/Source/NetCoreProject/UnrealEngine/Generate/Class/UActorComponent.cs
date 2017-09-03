using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageActorComponent
	/// <para>ActorComponent is the base class for components that define reusable behavior that can be added to different types of Actors. </para>
	/// <para>ActorComponents that have a transform are known as SceneComponents and those that can be rendered are PrimitiveComponents. </para>
	/// <para>@see [ActorComponent](https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/Components/index.html#actorcomponents) </para>
	/// <para>@see USceneComponent </para>
	/// <para>@see UPrimitiveComponent </para>
	/// </summary>
	public  partial class UActorComponent : UObject
	{
		public UActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_UActorComponent_PrimaryComponentTick_GET(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_Activate(IntPtr Self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_AllowReregistration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_CanEverAffectNavigation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_ComponentHasTag(IntPtr Self, string Tag);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_ComponentIsInPersistentLevel(IntPtr Self, bool bIncludeLevelStreamingPersistent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_CreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_CreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_Deactivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_DestroyComponent(IntPtr Self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_DestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_DestroyRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_DetermineUCSModifiedProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_DoDeferredRenderUpdates_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UActorComponent_GetComponentTickInterval(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_GetIsReplicated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UActorComponent_GetOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_HandleCanEverAffectNavigationChange(IntPtr Self, bool bForceUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_HasBeenCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_HasBeenInitialized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_HasBegunPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_InitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_InvalidateLightingCache(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_InvalidateLightingCacheDetailed(IntPtr Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsBeingDestroyed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsComponentTickEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsCreatedByConstructionScript(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsEditableWhenInherited(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsNetSimulating(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsNetStartupComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsOwnerRunningUserConstructionScript(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsOwnerSelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsPhysicsStateCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsRegistered(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsRenderStateCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsRenderStateDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UActorComponent_IsRenderTransformDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_K2_DestroyComponent(IntPtr Self, IntPtr Object);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_MarkForNeededEndOfFrameRecreate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_MarkForNeededEndOfFrameUpdate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_MarkRenderDynamicDataDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_MarkRenderStateDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_MarkRenderTransformDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_OnActorEnableCollisionChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_OnComponentCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_OnComponentDestroyed(IntPtr Self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_OnCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_OnDestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_OnRegister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_OnRep_IsActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_OnUnregister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_ReceiveBeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_RecreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_RecreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_RegisterAllComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_RegisterComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_RegisterComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_RegisterComponentWithWorld(IntPtr Self, IntPtr InWorld);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_ReregisterComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SendRenderDynamicData_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SendRenderTransform_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetActive(IntPtr Self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetAutoActivate(IntPtr Self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetCanEverAffectNavigation(IntPtr Self, bool bRelevant);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetComponentTickEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetComponentTickEnabledAsync(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetComponentTickInterval(IntPtr Self, float TickInterval);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetIsNetStartupComponent(IntPtr Self, bool bInIsNetStartupComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetIsReplicated(IntPtr Self, bool ShouldReplicate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetNetAddressable(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_SetTickableWhenPaused(IntPtr Self, bool bTickableWhenPaused);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_ToggleActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_UninitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UActorComponent_UnregisterComponent(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Main tick function for the Actor </para>
		/// </summary>
		public FActorComponentTickFunction PrimaryComponentTick
		{
			get => E_PROP_UActorComponent_PrimaryComponentTick_GET(NativePointer);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Activates the SceneComponent </para>
		/// <param name="bReset">- The value to assign to HiddenGame. </param>
		/// </summary>
		public virtual void Activate(bool bReset)
			=> E_UActorComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public virtual void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UActorComponent_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public virtual void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UActorComponent_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Checked whether the component class allows reregistration </para>
		/// </summary>
		public bool AllowReregistration()
			=> E_UActorComponent_AllowReregistration(this);
		
		
		/// <summary>
		/// <para>Called by owner actor on position shifting </para>
		/// <para>Component should update all relevant data structures to reflect new actor location </para>
		/// <param name="InWorldOffset">Offset vector the actor shifted by </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public virtual void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_UActorComponent_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		
		/// <summary>
		/// <para>BeginsPlay for the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// <para>Actor/Component gets BeginPlay. </para>
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public virtual void BeginPlay()
			=> E_UActorComponent_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Can this component potentially influence navigation </para>
		/// </summary>
		public bool CanEverAffectNavigation()
			=> E_UActorComponent_CanEverAffectNavigation(this);
		
		
		/// <summary>
		/// <para>See if this component contains the supplied tag </para>
		/// </summary>
		public bool ComponentHasTag(string Tag)
			=> E_UActorComponent_ComponentHasTag(this, Tag);
		
		
		/// <summary>
		/// <para>See if this component is in the persistent level </para>
		/// </summary>
		public bool ComponentIsInPersistentLevel(bool bIncludeLevelStreamingPersistent)
			=> E_UActorComponent_ComponentIsInPersistentLevel(this, bIncludeLevelStreamingPersistent);
		
		
		/// <summary>
		/// <para>Create any physics engine information for this component </para>
		/// </summary>
		public void CreatePhysicsState()
			=> E_UActorComponent_CreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to create any rendering thread information for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected virtual void CreateRenderState_Concurrent()
			=> E_UActorComponent_CreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>Deactivates the SceneComponent. </para>
		/// </summary>
		public virtual void Deactivate()
			=> E_UActorComponent_Deactivate(this);
		
		
		/// <summary>
		/// <para>Unregister the component, remove it from its outer Actor's Components array and mark for pending kill. </para>
		/// </summary>
		public virtual void DestroyComponent(bool bPromoteChildren)
			=> E_UActorComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// <para>Shut down any physics engine structure for this component </para>
		/// </summary>
		public void DestroyPhysicsState()
			=> E_UActorComponent_DestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected virtual void DestroyRenderState_Concurrent()
			=> E_UActorComponent_DestroyRenderState_Concurrent(this);
		
		public void DetermineUCSModifiedProperties()
			=> E_UActorComponent_DetermineUCSModifiedProperties(this);
		
		
		/// <summary>
		/// <para>Uses the bRenderStateDirty/bRenderTransformDirty to perform any necessary work on this component. </para>
		/// <para>Do not call this directly, call MarkRenderStateDirty, MarkRenderDynamicDataDirty, </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public void DoDeferredRenderUpdates_Concurrent()
			=> E_UActorComponent_DoDeferredRenderUpdates_Concurrent(this);
		
		
		/// <summary>
		/// <para>Returns whether this component has tick enabled or not </para>
		/// </summary>
		public float GetComponentTickInterval()
			=> E_UActorComponent_GetComponentTickInterval(this);
		
		
		/// <summary>
		/// <para>Returns whether replication is enabled or not. </para>
		/// </summary>
		public bool GetIsReplicated()
			=> E_UActorComponent_GetIsReplicated(this);
		
		
		/// <summary>
		/// <para>Follow the Outer chain to get the  AActor  that 'Owns' this component </para>
		/// </summary>
		public AActor GetOwner()
			=> E_UActorComponent_GetOwner(this);
		
		
		/// <summary>
		/// <para>Makes sure navigation system has up to date information regarding component's navigation relevancy </para>
		/// <para>and if it can affect navigation at all </para>
		/// <param name="bForceUpdate">by default updating navigation system will take place only if the component has </param>
		/// <para>already been registered. Setting bForceUpdate to true overrides that check </para>
		/// </summary>
		protected void HandleCanEverAffectNavigationChange(bool bForceUpdate = false)
			=> E_UActorComponent_HandleCanEverAffectNavigationChange(this, bForceUpdate);
		
		public bool HasBeenCreated()
			=> E_UActorComponent_HasBeenCreated(this);
		
		public bool HasBeenInitialized()
			=> E_UActorComponent_HasBeenInitialized(this);
		
		public bool HasBegunPlay()
			=> E_UActorComponent_HasBegunPlay(this);
		
		
		/// <summary>
		/// <para>Initializes the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components in the level will be Initialized on load before any Actor/Component gets BeginPlay </para>
		/// <para>Requires component to be registered, and bWantsInitializeComponent to be true. </para>
		/// </summary>
		public virtual void InitializeComponent()
			=> E_UActorComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// <para>Invalidate lighting cache with default options. </para>
		/// </summary>
		public void InvalidateLightingCache()
			=> E_UActorComponent_InvalidateLightingCache(this);
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E_UActorComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns whether the component is in the process of being destroyed. </para>
		/// </summary>
		public bool IsComponentBeingDestroyed()
			=> E_UActorComponent_IsBeingDestroyed(this);
		
		
		/// <summary>
		/// <para>Returns whether this component has tick enabled or not </para>
		/// </summary>
		public bool IsComponentTickEnabled()
			=> E_UActorComponent_IsComponentTickEnabled(this);
		
		public bool IsCreatedByConstructionScript()
			=> E_UActorComponent_IsCreatedByConstructionScript(this);
		
		public bool IsEditableWhenInherited()
			=> E_UActorComponent_IsEditableWhenInherited(this);
		
		
		/// <summary>
		/// <para>Returns true if we are replicating and not authorative </para>
		/// </summary>
		public bool IsNetSimulating()
			=> E_UActorComponent_IsNetSimulating(this);
		
		
		/// <summary>
		/// <para>Returns true if this component was owned by a net startup actor during level load. </para>
		/// </summary>
		public bool IsNetStartupComponent()
			=> E_UActorComponent_IsNetStartupComponent(this);
		
		
		/// <summary>
		/// <para>See if the owning Actor is currently running the UCS </para>
		/// </summary>
		public bool IsOwnerRunningUserConstructionScript()
			=> E_UActorComponent_IsOwnerRunningUserConstructionScript(this);
		
		
		/// <summary>
		/// <para>Returns whether the component's owner is selected. </para>
		/// </summary>
		public bool IsOwnerSelected()
			=> E_UActorComponent_IsOwnerSelected(this);
		
		
		/// <summary>
		/// <return>true if the physics 'state' (e.g. physx bodies) are created for this component </return>
		/// </summary>
		public bool IsPhysicsStateCreated()
			=> E_UActorComponent_IsPhysicsStateCreated(this);
		
		
		/// <summary>
		/// <para>See if this component is currently registered </para>
		/// </summary>
		public bool IsRegistered()
			=> E_UActorComponent_IsRegistered(this);
		
		
		/// <summary>
		/// <return>true if the render 'state' (e.g. scene proxy) is created for this component </return>
		/// </summary>
		public bool IsRenderStateCreated()
			=> E_UActorComponent_IsRenderStateCreated(this);
		
		public bool IsRenderStateDirty()
			=> E_UActorComponent_IsRenderStateDirty(this);
		
		public bool IsRenderTransformDirty()
			=> E_UActorComponent_IsRenderTransformDirty(this);
		
		
		/// <summary>
		/// <para>Unregister and mark for pending kill a component.  This may not be used to destroy a component is owned by an actor other than the one calling the function. </para>
		/// </summary>
		public void K2_DestroyComponent(UObject Object)
			=> E_UActorComponent_K2_DestroyComponent(this, Object);
		
		
		/// <summary>
		/// <para>If we belong to a world, mark this for a deferred update, otherwise do it now. </para>
		/// </summary>
		public void MarkForNeededEndOfFrameRecreate()
			=> E_UActorComponent_MarkForNeededEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>If we belong to a world, mark this for a deferred update, otherwise do it now. </para>
		/// </summary>
		public void MarkForNeededEndOfFrameUpdate()
			=> E_UActorComponent_MarkForNeededEndOfFrameUpdate(this);
		
		
		/// <summary>
		/// <para>Indicate that dynamic data for this component needs to be sent at the end of the frame. </para>
		/// </summary>
		public void MarkRenderDynamicDataDirty()
			=> E_UActorComponent_MarkRenderDynamicDataDirty(this);
		
		
		/// <summary>
		/// <para>Mark the render state as dirty - will be sent to the render thread at the end of the frame. </para>
		/// </summary>
		public void MarkRenderStateDirty()
			=> E_UActorComponent_MarkRenderStateDirty(this);
		
		
		/// <summary>
		/// <para>Marks the transform as dirty - will be sent to the render thread at the end of the frame </para>
		/// </summary>
		public void MarkRenderTransformDirty()
			=> E_UActorComponent_MarkRenderTransformDirty(this);
		
		
		/// <summary>
		/// <para>Called on each component when the Actor's bEnableCollisionChanged flag changes </para>
		/// </summary>
		public virtual void OnActorEnableCollisionChanged()
			=> E_UActorComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public virtual void OnComponentCreated()
			=> E_UActorComponent_OnComponentCreated(this);
		
		
		/// <summary>
		/// <para>Called when a component is destroyed </para>
		/// <param name="bDestroyingHierarchy">- True if the entire component hierarchy is being torn down, allows avoiding expensive operations </param>
		/// </summary>
		public virtual void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E_UActorComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		
		/// <summary>
		/// <para>Used to create any physics engine information for this component </para>
		/// </summary>
		protected virtual void OnCreatePhysicsState()
			=> E_UActorComponent_OnCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down and physics engine structure for this component </para>
		/// </summary>
		protected virtual void OnDestroyPhysicsState()
			=> E_UActorComponent_OnDestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Called when a component is registered, after Scene is set, but before CreateRenderState_Concurrent or OnCreatePhysicsState are called. </para>
		/// </summary>
		protected virtual void OnRegister()
			=> E_UActorComponent_OnRegister(this);
		
		public void OnRep_IsActive()
			=> E_UActorComponent_OnRep_IsActive(this);
		
		
		/// <summary>
		/// <para>Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called. </para>
		/// </summary>
		protected virtual void OnUnregister()
			=> E_UActorComponent_OnUnregister(this);
		
		
		/// <summary>
		/// <para>Blueprint implementable event for when the component is beginning play, called before its Owner's BeginPlay on Actor BeginPlay </para>
		/// <para>or when the component is dynamically created if the Actor has already BegunPlay. </para>
		/// </summary>
		public void ReceiveBeginPlay()
			=> E_UActorComponent_ReceiveBeginPlay(this);
		
		
		/// <summary>
		/// <para>Event called every frame </para>
		/// </summary>
		public void Tick(float DeltaSeconds)
			=> E_UActorComponent_ReceiveTick(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Recreate the physics state right way. </para>
		/// </summary>
		public void RecreatePhysicsState()
			=> E_UActorComponent_RecreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Recreate the render state right away. Generally you always want to call MarkRenderStateDirty instead. </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public void RecreateRenderState_Concurrent()
			=> E_UActorComponent_RecreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>When called, will call the virtual call chain to register all of the tick functions </para>
		/// <para>Do not override this function or make it virtual </para>
		/// <param name="bRegister">- true to register, false, to unregister </param>
		/// </summary>
		public void RegisterAllComponentTickFunctions(bool bRegister)
			=> E_UActorComponent_RegisterAllComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Register this component, creating any rendering/physics state. Will also adds to outer Actor's Components array, if not already present. </para>
		/// </summary>
		public void RegisterComponent()
			=> E_UActorComponent_RegisterComponent(this);
		
		
		/// <summary>
		/// <para>Virtual call chain to register all tick functions </para>
		/// <param name="bRegister">- true to register, false, to unregister </param>
		/// </summary>
		protected virtual void RegisterComponentTickFunctions(bool bRegister)
			=> E_UActorComponent_RegisterComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <param name="InWorld">- The world to register the component with. </param>
		/// </summary>
		public void RegisterComponentWithWorld(UWorld InWorld)
			=> E_UActorComponent_RegisterComponentWithWorld(this, InWorld);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public virtual void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UActorComponent_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public virtual void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UActorComponent_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Unregisters and immediately re-registers component.  Handles bWillReregister properly. </para>
		/// </summary>
		public void ReregisterComponent()
			=> E_UActorComponent_ReregisterComponent(this);
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected virtual void SendRenderDynamicData_Concurrent()
			=> E_UActorComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the rendering thread </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected virtual void SendRenderTransform_Concurrent()
			=> E_UActorComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">- The new active state of the component </param>
		/// </summary>
		public virtual void SetActive(bool bNewActive, bool bReset)
			=> E_UActorComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">- The new auto activate state of the component </param>
		/// </summary>
		public virtual void SetAutoActivate(bool bNewAutoActivate)
			=> E_UActorComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// <para>set value of bCanEverAffectNavigation flag and update navigation octree if needed </para>
		/// </summary>
		public void SetCanEverAffectNavigation(bool bRelevant)
			=> E_UActorComponent_SetCanEverAffectNavigation(this, bRelevant);
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">- Whether it should be enabled or not </param>
		/// </summary>
		public virtual void SetComponentTickEnabled(bool bEnabled)
			=> E_UActorComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">- Whether it should be enabled or not </param>
		/// </summary>
		public virtual void SetComponentTickEnabledAsync(bool bEnabled)
			=> E_UActorComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// <para>Sets the tick interval for this component's primary tick function. Does not enable the tick interval. Takes effect on next tick. </para>
		/// <param name="TickInterval">The duration between ticks for this component's primary tick function </param>
		/// </summary>
		public void SetComponentTickInterval(float TickInterval)
			=> E_UActorComponent_SetComponentTickInterval(this, TickInterval);
		
		
		/// <summary>
		/// <para>This should only be called by the engine in ULevel::InitializeNetworkActors to initialize bIsNetStartupComponent. </para>
		/// </summary>
		public void SetIsNetStartupComponent(bool bInIsNetStartupComponent)
			=> E_UActorComponent_SetIsNetStartupComponent(this, bInIsNetStartupComponent);
		
		
		/// <summary>
		/// <para>Enable or disable replication. This is the equivalent of RemoteRole for actors (only a bool is required for components) </para>
		/// </summary>
		public void SetIsReplicated(bool ShouldReplicate)
			=> E_UActorComponent_SetIsReplicated(this, ShouldReplicate);
		
		
		/// <summary>
		/// <para>This signifies the component can be ID'd by name over the network. This only needs to be called by engine code when constructing blueprint components. </para>
		/// </summary>
		public void SetNetAddressable()
			=> E_UActorComponent_SetNetAddressable(this);
		
		
		/// <summary>
		/// <para>Sets whether this component can tick when paused. </para>
		/// </summary>
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
			=> E_UActorComponent_SetTickableWhenPaused(this, bTickableWhenPaused);
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public virtual void ToggleActive()
			=> E_UActorComponent_ToggleActive(this);
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public virtual void UninitializeComponent()
			=> E_UActorComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// <para>Unregister this component, destroying any rendering/physics state. </para>
		/// </summary>
		public void UnregisterComponent()
			=> E_UActorComponent_UnregisterComponent(this);
		
		#endregion
		
		public static implicit operator IntPtr(UActorComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UActorComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UActorComponent ?? new UActorComponent(Adress);
		}}}
