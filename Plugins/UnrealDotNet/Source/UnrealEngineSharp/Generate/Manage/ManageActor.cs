// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:109

namespace UnrealEngine
{
	[ManageType("ManageActor")]
	public partial class ManageActor : AActor
	{
		public ManageActor(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Make this actor tick after PrerequisiteActor. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired.
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor prerequisiteActor) { }
		
		
		/// <summary>
		/// Make this actor tick after PrerequisiteComponent. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired.
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent prerequisiteComponent) { }
		
		
		/// <summary>
		/// Called by owning level to shift an actor location and all relevant data structures by specified delta
		/// </summary>
		/// <param name="inOffset">Offset vector to shift actor location</param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting</param>
		public override void ApplyWorldOffset(FVector inOffset, bool bWorldShift) { }
		
		
		/// <summary>
		/// Called when this actor becomes the given PlayerController's ViewTarget. Triggers the Blueprint event K2_OnBecomeViewTarget.
		/// </summary>
		public override void BecomeViewTarget(APlayerController pC) { }
		
		
		/// <summary>
		/// Overridable native event for when play begins for this actor.
		/// </summary>
		protected override void BeginPlay() { }
		
		
		/// <summary>
		/// Do anything needed to clear out cross level references; Called from ULevel::PreSave
		/// </summary>
		public override void ClearCrossLevelReferences() { }
		
		
		/// <summary>
		/// Called when this actor is explicitly being destroyed during gameplay or in the editor, not called during level streaming or gameplay ending
		/// </summary>
		public override void Destroyed() { }
		
		
		/// <summary>
		/// Removes this actor from the stack of input being handled by a PlayerController.
		/// </summary>
		/// <param name="playerController">The PlayerController whose input events we no longer want to receive. If null, this actor will stop receiving input from all PlayerControllers.</param>
		public override void DisableInput(APlayerController playerController) { }
		
		
		/// <summary>
		/// Pushes this actor on to the stack of input being handled by a PlayerController.
		/// </summary>
		/// <param name="playerController">The PlayerController whose input events we want to receive.</param>
		public override void EnableInput(APlayerController playerController) { }
		
		
		/// <summary>
		/// Called when this actor is no longer the given PlayerController's ViewTarget. Also triggers the Blueprint event K2_OnEndViewTarget.
		/// </summary>
		public override void EndViewTarget(APlayerController pC) { }
		
		
		/// <summary>
		/// Forces this actor to be net relevant if it is not already by default
		/// </summary>
		public override void ForceNetRelevant() { }
		
		
		/// <summary>
		/// Force actor to be updated to clients/demo net drivers
		/// </summary>
		public override void ForceNetUpdate() { }
		
		
		/// <summary>
		/// Fills ReplicatedMovement property
		/// </summary>
		public override void GatherCurrentMovement() { }
		
		
		/// <summary>
		/// Invalidates anything produced by the last lighting build.
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bTranslationOnly) { }
		
		
		/// <summary>
		/// Destroy the actor
		/// </summary>
		public override void DestroyActor() { }
		
		
		/// <summary>
		/// Called when the lifespan of an actor expires (if he has one).
		/// </summary>
		public override void LifeSpanExpired() { }
		
		
		/// <summary>
		/// Called to mark all components as pending kill when the actor is being destroyed
		/// </summary>
		public override void MarkComponentsAsPendingKill() { }
		
		
		/// <summary>
		/// Event when this actor has the mouse moved over it with the clickable interface.
		/// </summary>
		public override void NotifyActorBeginCursorOver() { }
		
		
		/// <summary>
		/// Event when this actor overlaps another actor, for example a player walking into a trigger.
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// @note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events.
		/// </summary>
		public override void NotifyActorBeginOverlap(AActor otherActor) { }
		
		
		/// <summary>
		/// Event when this actor has the mouse moved off of it with the clickable interface.
		/// </summary>
		public override void NotifyActorEndCursorOver() { }
		
		
		/// <summary>
		/// Event when an actor no longer overlaps another actor, and they have separated.
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public override void NotifyActorEndOverlap(AActor otherActor) { }
		
		
		/// <summary>
		/// Event when this actor bumps into a blocking object, or blocks another actor that bumps into it.
		/// <para>This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation. </para>
		/// For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event.
		/// <para>@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled. </para>
		/// @note When receiving a hit from another object's movement (bSelfMoved is false), the directions of 'Hit.Normal' and 'Hit.ImpactNormal'
		/// <para>will be adjusted to indicate force from the other object against this object. </para>
		/// </summary>
		public override void NotifyHit(UPrimitiveComponent myComp, AActor other, UPrimitiveComponent otherComp, bool bSelfMoved, FVector hitLocation, FVector hitNormal, FVector normalImpulse, FHitResult hit) { }
		
		
		/// <summary>
		/// Called when an instance of this class is placed (in editor) or spawned.
		/// </summary>
		/// <param name="transform">The transform the actor was constructed at.</param>
		public override void OnConstruction(FTransform transform) { }
		
		public override void OnRep_AttachmentReplication() { }
		
		public override void OnRep_Instigator() { }
		
		protected override void OnRep_Owner() { }
		
		public override void OnRep_ReplicatedMovement() { }
		
		public override void OnRep_ReplicateMovement() { }
		
		
		/// <summary>
		/// Called on the client when the replication paused value is changed
		/// </summary>
		public override void OnReplicationPausedChanged(bool bIsReplicationPaused) { }
		
		
		/// <summary>
		/// Called on the actor when a new subobject is dynamically created via replication
		/// </summary>
		public override void OnSubobjectCreatedFromReplication(UObject newSubobject) { }
		
		
		/// <summary>
		/// Called on the actor when a subobject is dynamically destroyed via replication
		/// </summary>
		public override void OnSubobjectDestroyFromReplication(UObject subobject) { }
		
		
		/// <summary>
		/// Called when the Actor is outside the hard limit on world bounds
		/// </summary>
		public override void OutsideWorldBounds() { }
		
		
		/// <summary>
		/// Called when an actor is done spawning into the world (from UWorld::SpawnActor), both in the editor and during gameplay
		/// <para>For actors with a root component, the location and rotation will have already been set. </para>
		/// This is called before calling construction scripts, but after native components have been created
		/// </summary>
		public override void PostActorCreated() { }
		
		
		/// <summary>
		/// Allow actors to initialize themselves on the C++ side after all of their components have been initialized, only called during gameplay
		/// </summary>
		public override void PostInitializeComponents() { }
		
		
		/// <summary>
		/// Always called immediately after spawning and reading in replicated properties
		/// </summary>
		public override void PostNetInit() { }
		
		
		/// <summary>
		/// Update location and rotation from ReplicatedMovement. Not called for simulated physics!
		/// </summary>
		public override void PostNetReceiveLocationAndRotation() { }
		
		
		/// <summary>
		/// Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity()
		/// </summary>
		public override void PostNetReceivePhysicState() { }
		
		
		/// <summary>
		/// Always called immediately after a new Role is received from the remote.
		/// </summary>
		public override void PostNetReceiveRole() { }
		
		
		/// <summary>
		/// Update velocity - typically from ReplicatedMovement, not called for simulated physics!
		/// </summary>
		public override void PostNetReceiveVelocity(FVector newVelocity) { }
		
		
		/// <summary>
		/// Called after all the components in the Components array are registered, called both in editor and during gameplay
		/// </summary>
		public override void PostRegisterAllComponents() { }
		
		
		/// <summary>
		/// Hook to allow actors to render HUD overlays for themselves.  Called from AHUD::DrawActorOverlays().
		/// </summary>
		/// <param name="pC">is the PlayerController on whose view this overlay is rendered</param>
		/// <param name="canvas">is the Canvas on which to draw the overlay</param>
		/// <param name="cameraPosition">Position of Camera</param>
		/// <param name="cameraDir">direction camera is pointing in.</param>
		public override void PostRenderFor(APlayerController pC, UCanvas canvas, FVector cameraPosition, FVector cameraDir) { }
		
		
		/// <summary>
		/// Called after all currently registered components are cleared
		/// </summary>
		public override void PostUnregisterAllComponents() { }
		
		
		/// <summary>
		/// Called right before components are initialized, only called during gameplay
		/// </summary>
		public override void PreInitializeComponents() { }
		
		
		/// <summary>
		/// Called before all the components in the Components array are registered, called both in editor and during gameplay
		/// </summary>
		public override void PreRegisterAllComponents() { }
		
		
		/// <summary>
		/// Calls PrestreamTextures() for all the actor's meshcomponents.
		/// </summary>
		/// <param name="seconds">Number of seconds to force all mip-levels to be resident</param>
		/// <param name="bEnableStreaming">Whether to start (true) or stop (false) streaming</param>
		/// <param name="cinematicTextureGroups">Bitfield indicating which texture groups that use extra high-resolution mips</param>
		public override void PrestreamTextures(float seconds, bool bEnableStreaming, int cinematicTextureGroups) { }
		
		
		/// <summary>
		/// Virtual call chain to register all tick functions for the actor class hierarchy
		/// </summary>
		/// <param name="bRegister">true to register, false, to unregister</param>
		protected override void RegisterActorTickFunctions(bool bRegister) { }
		
		
		/// <summary>
		/// Ensure that all the components in the Components array are registered
		/// </summary>
		public override void RegisterAllComponents() { }
		
		
		/// <summary>
		/// Remove tick dependency on PrerequisiteActor.
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor prerequisiteActor) { }
		
		
		/// <summary>
		/// Remove tick dependency on PrerequisiteComponent.
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent prerequisiteComponent) { }
		
		
		/// <summary>
		/// Will reregister all components on this actor. Does a lot of work - should only really be used in editor, generally use UpdateComponentTransforms or MarkComponentsRenderStateDirty.
		/// </summary>
		public override void ReregisterAllComponents() { }
		
		
		/// <summary>
		/// Rerun construction scripts, destroying all autogenerated components; will attempt to preserve the root component location.
		/// </summary>
		public override void RerunConstructionScripts() { }
		
		
		/// <summary>
		/// Reset actor to initial state - used when restarting level without reloading.
		/// </summary>
		public override void Reset() { }
		
		
		/// <summary>
		/// Called on the actor before checkpoint data is applied during a replay.
		/// <para>Only called if bReplayRewindable is set. </para>
		/// </summary>
		public override void RewindForReplay() { }
		
		
		/// <summary>
		/// Sets the actor to be hidden in the game
		/// </summary>
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components</param>
		public override void SetActorHiddenInGame(bool bNewHidden) { }
		
		
		/// <summary>
		/// Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed.
		/// </summary>
		public override void SetLifeSpan(float inLifespan) { }
		
		
		/// <summary>
		/// Set the owner of this Actor, used primarily for network replication.
		/// </summary>
		/// <param name="newOwner">The Actor whom takes over ownership of this Actor</param>
		public override void SetOwner(AActor newOwner) { }
		
		
		/// <summary>
		/// Set whether this actor's movement replicates to network clients.
		/// </summary>
		/// <param name="bInReplicateMovement">Whether this Actor's movement replicates to clients.</param>
		public override void SetReplicateMovement(bool bInReplicateMovement) { }
		
		
		/// <summary>
		/// Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true.
		/// </summary>
		public override void TearOff() { }
		
		
		/// <summary>
		/// Called from TeleportTo() when teleport succeeds
		/// </summary>
		public override void TeleportSucceeded(bool bIsATest) { }
		
		
		/// <summary>
		/// Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame.
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// </summary>
		/// <param name="deltaSeconds">Game time elapsed during last frame modified by the time dilation</param>
		public override void Tick(float deltaSeconds) { }
		
		
		/// <summary>
		/// Networking - called on client when actor is torn off (bTearOff==true), meaning it's no longer replicated to clients.
		/// <para>@see bTearOff </para>
		/// </summary>
		public override void TornOff() { }
		
		
		/// <summary>
		/// Unregister all currently registered components
		/// </summary>
		/// <param name="bForReregister">If true, RegisterAllComponents will be called immediately after this so some slow operations can be avoided</param>
		public override void UnregisterAllComponents(bool bForReregister) { }
		
		public static implicit operator IntPtr(ManageActor self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageActor(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageActor>(PtrDesc);
		}}}
