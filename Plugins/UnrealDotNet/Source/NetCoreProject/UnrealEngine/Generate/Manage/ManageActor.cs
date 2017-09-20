using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageActor : AActor
	{
		public ManageActor(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteActor. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor) { }
		
		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteComponent. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) { }
		
		
		/// <summary>
		/// <para>Called by owning level to shift an actor location and all relevant data structures by specified delta </para>
		/// <param name="InWorldOffset">Offset vector to shift actor location </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift) { }
		
		
		/// <summary>
		/// <para>Overridable native event for when play begins for this actor. </para>
		/// </summary>
		protected override void BeginPlay() { }
		
		
		/// <summary>
		/// <para>Do anything needed to clear out cross level references; Called from ULevel::PreSave </para>
		/// </summary>
		public override void ClearCrossLevelReferences() { }
		
		
		/// <summary>
		/// <para>fills ReplicatedMovement property </para>
		/// </summary>
		public override void GatherCurrentMovement() { }
		
		
		/// <summary>
		/// <para>Invalidates anything produced by the last lighting build. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bTranslationOnly) { }
		
		
		/// <summary>
		/// <para>Destroy the actor </para>
		/// </summary>
		public override void DestroyActor() { }
		
		
		/// <summary>
		/// <para>Called when the lifespan of an actor expires (if he has one). </para>
		/// </summary>
		public override void LifeSpanExpired() { }
		
		public override void MarkComponentsAsPendingKill() { }
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved over it with the clickable interface. </para>
		/// </summary>
		public override void NotifyActorBeginCursorOver() { }
		
		
		/// <summary>
		/// <para>Event when this actor overlaps another actor, for example a player walking into a trigger. </para>
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public override void NotifyActorBeginOverlap(AActor OtherActor) { }
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved off of it with the clickable interface. </para>
		/// </summary>
		public override void NotifyActorEndCursorOver() { }
		
		
		/// <summary>
		/// <para>Event when an actor no longer overlaps another actor, and they have separated. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public override void NotifyActorEndOverlap(AActor OtherActor) { }
		
		
		/// <summary>
		/// <para>Called when an instance of this class is placed (in editor) or spawned. </para>
		/// <param name="Transform">The transform the actor was constructed at. </param>
		/// </summary>
		public override void OnConstruction(FTransform Transform) { }
		
		public override void OnRep_AttachmentReplication() { }
		
		public override void OnRep_Instigator() { }
		
		protected override void OnRep_Owner() { }
		
		public override void OnRep_ReplicatedMovement() { }
		
		public override void OnRep_ReplicateMovement() { }
		
		
		/// <summary>
		/// <para>Called on the client when the replication paused value is changed </para>
		/// </summary>
		public override void OnReplicationPausedChanged(bool bIsReplicationPaused) { }
		
		
		/// <summary>
		/// <para>Called on the actor when a new subobject is dynamically created via replication </para>
		/// </summary>
		public override void OnSubobjectCreatedFromReplication(UObject NewSubobject) { }
		
		
		/// <summary>
		/// <para>Called on the actor when a subobject is dynamically destroyed via replication </para>
		/// </summary>
		public override void OnSubobjectDestroyFromReplication(UObject Subobject) { }
		
		
		/// <summary>
		/// <para>Called when an actor is done spawning into the world (from UWorld::SpawnActor). </para>
		/// <para>For actors with a root component, the location and rotation will have already been set. </para>
		/// <para>Takes place after any construction scripts have been called </para>
		/// </summary>
		public override void PostActorCreated() { }
		
		public override void PostInitializeComponents() { }
		
		public override void PostNetInit() { }
		
		
		/// <summary>
		/// <para>Update and smooth location, not called for simulated physics! </para>
		/// </summary>
		public override void PostNetReceiveLocation() { }
		
		
		/// <summary>
		/// <para>Update location and rotation from ReplicatedMovement. Not called for simulated physics! </para>
		/// </summary>
		public override void PostNetReceiveLocationAndRotation() { }
		
		
		/// <summary>
		/// <para>Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity() </para>
		/// </summary>
		public override void PostNetReceivePhysicState() { }
		
		
		/// <summary>
		/// <para>Update velocity - typically from ReplicatedMovement, not called for simulated physics! </para>
		/// </summary>
		public override void PostNetReceiveVelocity(FVector NewVelocity) { }
		
		
		/// <summary>
		/// <para>Called after all the components in the Components array are registered </para>
		/// </summary>
		public override void PostRegisterAllComponents() { }
		
		
		/// <summary>
		/// <para>Called after all currently registered components are cleared </para>
		/// </summary>
		public override void PostUnregisterAllComponents() { }
		
		
		/// <summary>
		/// <para>Called immediately before gameplay begins. </para>
		/// </summary>
		public override void PreInitializeComponents() { }
		
		
		/// <summary>
		/// <para>Ensure that all the components in the Components array are registered </para>
		/// </summary>
		public override void RegisterAllComponents() { }
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor) { }
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent) { }
		
		
		/// <summary>
		/// <para>Will reregister all components on this actor. Does a lot of work - should only really be used in editor, generally use UpdateComponentTransforms or MarkComponentsRenderStateDirty. </para>
		/// </summary>
		public override void ReregisterAllComponents() { }
		
		
		/// <summary>
		/// <para>Rerun construction scripts, destroying all autogenerated components; will attempt to preserve the root component location. </para>
		/// </summary>
		public override void RerunConstructionScripts() { }
		
		
		/// <summary>
		/// <para>Sets the actor to be hidden in the game </para>
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components </param>
		/// </summary>
		public override void SetActorHiddenInGame(bool bNewHidden) { }
		
		
		/// <summary>
		/// <para>Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed. </para>
		/// </summary>
		public override void SetLifeSpan(float InLifespan) { }
		
		
		/// <summary>
		/// <para>Set the owner of this Actor, used primarily for network replication. </para>
		/// <param name="NewOwner">The Actor whom takes over ownership of this Actor </param>
		/// </summary>
		public override void SetOwner(AActor NewOwner) { }
		
		
		/// <summary>
		/// <para>Set whether this actor's movement replicates to network clients. </para>
		/// <param name="bInReplicateMovement">Whether this Actor's movement replicates to clients. </param>
		/// </summary>
		public override void SetReplicateMovement(bool bInReplicateMovement) { }
		
		
		/// <summary>
		/// <para>Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true. </para>
		/// </summary>
		public override void TearOff() { }
		
		
		/// <summary>
		/// <para>Called from TeleportTo() when teleport succeeds </para>
		/// </summary>
		public override void TeleportSucceeded(bool bIsATest) { }
		
		
		/// <summary>
		/// <para>Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame. </para>
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// <param name="DeltaSeconds">Game time elapsed during last frame modified by the time dilation </param>
		/// </summary>
		public override void Tick(float DeltaSeconds) { }
		
		
		/// <summary>
		/// <para>Unregister all currently registered components </para>
		/// </summary>
		public override void UnregisterAllComponents(bool bForReregister) { }
		
		public static implicit operator IntPtr(ManageActor Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageActor(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageActor>(PtrDesc);
		}}}
