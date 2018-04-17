using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

namespace UnrealEngine
{
	public partial class ManageRotatingMovementComponent : URotatingMovementComponent
	{
		public ManageRotatingMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Adds force from radial force components. </para>
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// <param name="Origin">The origin of the force </param>
		/// <param name="Radius">The radius in which the force will be applied </param>
		/// <param name="Strength">The strength of the force </param>
		/// <param name="Falloff">The falloff from the force's origin </param>
		/// </summary>
		public override void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff) { }
		
		
		/// <summary>
		/// <para>Adds impulse from radial force components. </para>
		/// <para>Intended to be overridden by subclasses; default implementation does nothing. </para>
		/// <param name="Origin">The origin of the force </param>
		/// <param name="Radius">The radius in which the force will be applied </param>
		/// <param name="Strength">The strength of the force </param>
		/// <param name="Falloff">The falloff from the force's origin </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange) { }
		
		public override void Deactivate() { }
		
		
		/// <summary>
		/// <para>Called for Blocking impact </para>
		/// <param name="Hit">Describes the collision. </param>
		/// <param name="TimeSlice">Time period for the simulation that produced this hit.  Useful for </param>
		/// <para>putting Hit.Time in context.  Can be zero in certain situations where it's not appropriate, </para>
		/// <para>be sure to handle that. </para>
		/// <param name="MoveDelta">Attempted move that resulted in the hit. </param>
		/// </summary>
		public override void HandleImpact(FHitResult Hit, float TimeSlice, FVector MoveDelta) { }
		
		
		/// <summary>
		/// <para>Overridden to auto-register the updated component if it starts NULL, and we can find a root component on our owner. </para>
		/// </summary>
		public override void InitializeComponent() { }
		
		
		/// <summary>
		/// <para>Overridden to update component properties that should be updated while being edited. </para>
		/// </summary>
		public override void OnRegister() { }
		
		
		/// <summary>
		/// <para>Called by owning Actor upon successful teleport from AActor::TeleportTo(). </para>
		/// </summary>
		public override void OnTeleported() { }
		
		public override void PostLoad() { }
		
		public override void RegisterComponentTickFunctions(bool bRegister) { }
		
		
		/// <summary>
		/// <para>Set the plane constraint axis setting. </para>
		/// <para>Changing this setting will modify the current value of PlaneConstraintNormal. </para>
		/// <param name="NewAxisSetting">New plane constraint axis setting. </param>
		/// </summary>
		public override void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting) { }
		
		
		/// <summary>
		/// <para>Sets whether or not the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintEnabled(bool bEnabled) { }
		
		
		/// <summary>
		/// <para>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintFromVectors(FVector Forward, FVector Up) { }
		
		
		/// <summary>
		/// <para>Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// <para>Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom". </para>
		/// <param name="PlaneNormal">The normal of the plane. If non-zero in length, it will be normalized. </param>
		/// </summary>
		public override void SetPlaneConstraintNormal(FVector PlaneNormal) { }
		
		
		/// <summary>
		/// <para>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintOrigin(FVector PlaneOrigin) { }
		
		
		/// <summary>
		/// <para>Assign the component we move and update. </para>
		/// </summary>
		public override void SetUpdatedComponent(USceneComponent NewUpdatedComponent) { }
		
		
		/// <summary>
		/// <para>Snap the updated component to the plane constraint, if enabled. </para>
		/// </summary>
		public override void SnapUpdatedComponentToPlane() { }
		
		
		/// <summary>
		/// <para>Stops movement immediately (zeroes velocity, usually zeros acceleration for components with acceleration). </para>
		/// </summary>
		public override void StopMovementImmediately() { }
		
		
		/// <summary>
		/// <para>Update ComponentVelocity of UpdatedComponent. This needs to be called by derived classes at the end of an update whenever Velocity has changed. </para>
		/// </summary>
		public override void UpdateComponentVelocity() { }
		
		
		/// <summary>
		/// <para>Update tick registration state, determined by bAutoUpdateTickRegistration. Called by SetUpdatedComponent. </para>
		/// </summary>
		public override void UpdateTickRegistration() { }
		
		
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
		
		public override void BeginDestroy() { }
		
		
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
		public override void CreateRenderState_Concurrent() { }
		
		
		/// <summary>
		/// <para>Unregister the component, remove it from its outer Actor's Components array and mark for pending kill. </para>
		/// </summary>
		public override void DestroyComponent(bool bPromoteChildren) { }
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void DestroyRenderState_Concurrent() { }
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) { }
		
		public override void MarkAsEditorOnlySubobject() { }
		
		
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
		/// <para>Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called. </para>
		/// </summary>
		public override void OnUnregister() { }
		
		public override void PostInitProperties() { }
		
		public override void PostNetReceive() { }
		
		public override void PostRename(UObject OldOuter, string OldName) { }
		
		public override void PreNetReceive() { }
		
		
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
		public override void SendRenderTransform_Concurrent() { }
		
		
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
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy() { }
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct() { }
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport() { }
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies() { }
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired) { }
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication() { }
		
		public override void ShutdownAfterError() { }
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject) { }
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster() { }
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill() { }
		
		public static implicit operator IntPtr(ManageRotatingMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageRotatingMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageRotatingMovementComponent>(PtrDesc);
		}}}
