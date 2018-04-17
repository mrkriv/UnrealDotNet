using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

namespace UnrealEngine
{
	public partial class ManagePawn : APawn
	{
		public ManagePawn(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputPitchScale value. </para>
		/// <param name="Val">Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value. </param>
		/// <para>@see PlayerController::InputPitchScale </para>
		/// </summary>
		public override void AddControllerPitchInput(float Val) { }
		
		
		/// <summary>
		/// <para>Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputRollScale value. </para>
		/// <param name="Val">Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value. </param>
		/// <para>@see PlayerController::InputRollScale </para>
		/// </summary>
		public override void AddControllerRollInput(float Val) { }
		
		
		/// <summary>
		/// <para>Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputYawScale value. </para>
		/// <param name="Val">Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value. </param>
		/// <para>@see PlayerController::InputYawScale </para>
		/// </summary>
		public override void AddControllerYawInput(float Val) { }
		
		
		/// <summary>
		/// <para>Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'. If ScaleValue < 0, movement will be in the opposite direction. </para>
		/// <para>Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move. </para>
		/// <param name="WorldDirection">Direction in world space to apply input </param>
		/// <param name="ScaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction. </param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored(). </param>
		/// <para>@see GetPendingMovementInputVector(), GetLastMovementInputVector(), ConsumeMovementInputVector() </para>
		/// </summary>
		public override void AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce) { }
		
		public override void Destroyed() { }
		
		
		/// <summary>
		/// <para>Destroys the player input component and removes any references to it. </para>
		/// </summary>
		protected override void DestroyPlayerInputComponent() { }
		
		
		/// <summary>
		/// <para>Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon. </para>
		/// </summary>
		public override void DetachFromControllerPendingDestroy() { }
		
		
		/// <summary>
		/// <para>Updates Pawn's rotation to the given rotation, assumed to be the Controller's ControlRotation. Respects the bUseControllerRotation* settings. </para>
		/// </summary>
		public override void FaceRotation(FRotator NewControlRotation, float DeltaTime) { }
		
		public override void OnRep_Controller() { }
		
		public override void OnRep_PlayerState() { }
		
		public override void OutsideWorldBounds() { }
		
		
		/// <summary>
		/// <para>Tell client that the Pawn is begin restarted. Calls Restart(). </para>
		/// </summary>
		public override void PawnClientRestart() { }
		
		
		/// <summary>
		/// <para>Handle StartFire() passed from PlayerController </para>
		/// </summary>
		public override void PawnStartFire(byte FireModeNum) { }
		
		public override void PostInitializeComponents() { }
		
		public override void PostLoad() { }
		
		public override void PostNetReceiveLocationAndRotation() { }
		
		public override void PostNetReceiveVelocity(FVector NewVelocity) { }
		
		public override void PostRegisterAllComponents() { }
		
		public override void PreInitializeComponents() { }
		
		
		/// <summary>
		/// <para>Set BaseEyeHeight based on current state. </para>
		/// </summary>
		public override void RecalculateBaseEyeHeight() { }
		
		public override void Reset() { }
		
		
		/// <summary>
		/// <para>Called when the Pawn is being restarted (usually by being possessed by a Controller). </para>
		/// </summary>
		public override void Restart() { }
		
		
		/// <summary>
		/// <para>Make sure pawn properties are back to default. </para>
		/// </summary>
		public override void SetPlayerDefaults() { }
		
		
		/// <summary>
		/// <para>Spawn default controller for this Pawn, and get possessed by it. </para>
		/// </summary>
		public override void SpawnDefaultController() { }
		
		public override void TeleportSucceeded(bool bIsATest) { }
		
		
		/// <summary>
		/// <para>Freeze pawn - stop sounds, animations, physics, weapon firing </para>
		/// </summary>
		public override void TurnOff() { }
		
		
		/// <summary>
		/// <para>Called when our Controller no longer possesses us. </para>
		/// </summary>
		public override void UnPossessed() { }
		
		
		/// <summary>
		/// <para>Update all components relevant for navigation generators to match bCanAffectNavigationGeneration flag </para>
		/// </summary>
		public override void UpdateNavigationRelevance() { }
		
		
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
		
		public override void BeginDestroy() { }
		
		
		/// <summary>
		/// <para>Overridable native event for when play begins for this actor. </para>
		/// </summary>
		public override void BeginPlay() { }
		
		
		/// <summary>
		/// <para>Do anything needed to clear out cross level references; Called from ULevel::PreSave </para>
		/// </summary>
		public override void ClearCrossLevelReferences() { }
		
		
		/// <summary>
		/// <para>Forces this actor to be net relevant if it is not already by default </para>
		/// </summary>
		public override void ForceNetRelevant() { }
		
		
		/// <summary>
		/// <para>Force actor to be updated to clients </para>
		/// </summary>
		public override void ForceNetUpdate() { }
		
		
		/// <summary>
		/// <para>Fills ReplicatedMovement property </para>
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
		
		
		/// <summary>
		/// <para>Called to mark all components as pending kill when the actor is being destroyed </para>
		/// </summary>
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
		/// <para>Event when this actor bumps into a blocking object, or blocks another actor that bumps into it. </para>
		/// <para>This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation. </para>
		/// <para>For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event. </para>
		/// <para>@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled. </para>
		/// <para>@note When receiving a hit from another object's movement (bSelfMoved is false), the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// <para>will be adjusted to indicate force from the other object against this object. </para>
		/// </summary>
		public override void NotifyHit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, FHitResult Hit) { }
		
		
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
		
		public override void PostInitProperties() { }
		
		
		/// <summary>
		/// <para>Always called immediately after spawning and reading in replicated properties </para>
		/// </summary>
		public override void PostNetInit() { }
		
		
		/// <summary>
		/// <para>Always called immediately after properties are received from the remote. </para>
		/// </summary>
		public override void PostNetReceive() { }
		
		
		/// <summary>
		/// <para>Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity() </para>
		/// </summary>
		public override void PostNetReceivePhysicState() { }
		
		public override void PostRename(UObject OldOuter, string OldName) { }
		
		
		/// <summary>
		/// <para>Called after all currently registered components are cleared </para>
		/// </summary>
		public override void PostUnregisterAllComponents() { }
		
		
		/// <summary>
		/// <para>Always called immediately before properties are received from the remote. </para>
		/// </summary>
		public override void PreNetReceive() { }
		
		
		/// <summary>
		/// <para>Calls PrestreamTextures() for all the actor's meshcomponents. </para>
		/// <param name="Seconds">Number of seconds to force all mip-levels to be resident </param>
		/// <param name="bEnableStreaming">Whether to start (true) or stop (false) streaming </param>
		/// <param name="CinematicTextureGroups">Bitfield indicating which texture groups that use extra high-resolution mips </param>
		/// </summary>
		public override void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups) { }
		
		
		/// <summary>
		/// <para>Virtual call chain to register all tick functions for the actor class hierarchy </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		protected override void RegisterActorTickFunctions(bool bRegister) { }
		
		
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
		/// <para>Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame. </para>
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// <param name="DeltaSeconds">Game time elapsed during last frame modified by the time dilation </param>
		/// </summary>
		public override void Tick(float DeltaSeconds) { }
		
		
		/// <summary>
		/// <para>Networking - called on client when actor is torn off (bTearOff==true), meaning it's no longer replicated to clients. </para>
		/// <para>@see bTearOff </para>
		/// </summary>
		public override void TornOff() { }
		
		
		/// <summary>
		/// <para>Unregister all currently registered components </para>
		/// </summary>
		public override void UnregisterAllComponents(bool bForReregister) { }
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy() { }
		
		public override void MarkAsEditorOnlySubobject() { }
		
		
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
		
		public static implicit operator IntPtr(ManagePawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManagePawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePawn>(PtrDesc);
		}}}
