using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageActorComponent : UActorComponent
	{
		public ManageActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Activates the SceneComponent </para>
		/// <param name="bReset">The value to assign to HiddenGame. </param>
		/// </summary>
		public override void Activate(bool bReset) { }
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor) { }
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) { }
		
		
		/// <summary>
		/// <para>Called by owner actor on position shifting </para>
		/// <para>Component should update all relevant data structures to reflect new actor location </para>
		/// <param name="InWorldOffset">Offset vector the actor shifted by </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift) { }
		
		
		/// <summary>
		/// <para>BeginsPlay for the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// <para>Actor/Component gets BeginPlay. </para>
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public override void BeginPlay() { }
		
		
		/// <summary>
		/// <para>Used to create any rendering thread information for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected override void CreateRenderState_Concurrent() { }
		
		
		/// <summary>
		/// <para>Deactivates the SceneComponent. </para>
		/// </summary>
		public override void Deactivate() { }
		
		
		/// <summary>
		/// <para>Unregister the component, remove it from its outer Actor's Components array and mark for pending kill. </para>
		/// </summary>
		public override void DestroyComponent(bool bPromoteChildren) { }
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected override void DestroyRenderState_Concurrent() { }
		
		
		/// <summary>
		/// <para>Initializes the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components in the level will be Initialized on load before any Actor/Component gets BeginPlay </para>
		/// <para>Requires component to be registered, and bWantsInitializeComponent to be true. </para>
		/// </summary>
		public override void InitializeComponent() { }
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) { }
		
		
		/// <summary>
		/// <para>Called on each component when the Actor's bEnableCollisionChanged flag changes </para>
		/// </summary>
		public override void OnActorEnableCollisionChanged() { }
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public override void OnComponentCreated() { }
		
		
		/// <summary>
		/// <para>Called when a component is destroyed </para>
		/// <param name="bDestroyingHierarchy">True if the entire component hierarchy is being torn down, allows avoiding expensive operations </param>
		/// </summary>
		public override void OnComponentDestroyed(bool bDestroyingHierarchy) { }
		
		
		/// <summary>
		/// <para>Used to create any physics engine information for this component </para>
		/// </summary>
		protected override void OnCreatePhysicsState() { }
		
		
		/// <summary>
		/// <para>Used to shut down and physics engine structure for this component </para>
		/// </summary>
		protected override void OnDestroyPhysicsState() { }
		
		
		/// <summary>
		/// <para>Called when a component is registered, after Scene is set, but before CreateRenderState_Concurrent or OnCreatePhysicsState are called. </para>
		/// </summary>
		protected override void OnRegister() { }
		
		
		/// <summary>
		/// <para>Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called. </para>
		/// </summary>
		protected override void OnUnregister() { }
		
		
		/// <summary>
		/// <para>Virtual call chain to register all tick functions </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		protected override void RegisterComponentTickFunctions(bool bRegister) { }
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor) { }
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) { }
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected override void SendRenderDynamicData_Concurrent() { }
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the rendering thread </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected override void SendRenderTransform_Concurrent() { }
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// </summary>
		public override void SetActive(bool bNewActive, bool bReset) { }
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public override void SetAutoActivate(bool bNewAutoActivate) { }
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabled(bool bEnabled) { }
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabledAsync(bool bEnabled) { }
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public override void ToggleActive() { }
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent() { }
		
		
		/// <summary>
		/// <para>Recalculate the value of our component to world transform </para>
		/// </summary>
		public override void UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport) { }
		
		public static implicit operator IntPtr(ManageActorComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageActorComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageActorComponent>(PtrDesc);
		}}}
