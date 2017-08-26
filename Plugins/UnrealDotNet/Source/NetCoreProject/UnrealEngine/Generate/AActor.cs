using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class AActor : UObject
	{
		public AActor(IntPtr Adress)
			: base(Adress)
		{
		}

		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_OnRep_ReplicateMovement(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetReplicates(IntPtr Self, bool bInReplicates);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetAutonomousProxy(IntPtr Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare = true);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_CopyRemoteRoleFrom(IntPtr Self, AActor CopyFromActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_OnSubobjectCreatedFromReplication(IntPtr Self, UObject NewSubobject);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_AllowReceiveTickEventOnDedicatedServer(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FTransform E_AActor_GetTransform(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_AActor_K2_GetActorLocation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_AActor_K2_GetActorRotation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_GetActorBounds(IntPtr Self, bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_K2_SetActorRotation(IntPtr Self, FRotator NewRotation, bool bTeleportPhysics);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetActorScale3D(IntPtr Self, FVector NewScale3D);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_AActor_GetDistanceTo(IntPtr Self, AActor OtherActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_AActor_GetActorTimeDilation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetTickPrerequisite(IntPtr Self, AActor PrerequisiteActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_GetTickableWhenPaused(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_AActor_GetGameTimeSinceCreation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_Destroy(IntPtr Self, bool bNetForce = false, bool bShouldModifyLevel = true);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IsOwnedBy(IntPtr Self, AActor TestOwner);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_AActor_GetActorQuat(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_ApplyWorldOffset(IntPtr Self, FVector InOffset, bool bWorldShift);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_RegisterAllActorTickFunctions(IntPtr Self, bool bRegister, bool bDoComponents);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_PostNetReceiveVelocity(IntPtr Self, FVector NewVelocity);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern AActor E_AActor_GetOwner(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IsReplayRelevantFor(IntPtr Self, AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IsRelevancyOwnerFor(IntPtr Self, AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IncrementalRegisterComponents(IntPtr Self, int NumComponentsToRegister);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_TeleportTo(IntPtr Self, FVector DestLocation, FRotator DestRotation, bool bIsATest = false, bool bNoCheck = false);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_K2_TeleportTo(IntPtr Self, FVector DestLocation, FRotator DestRotation);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_DebugShowComponentHierarchy(IntPtr Self, string Info, bool bShowPosition = true);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_OnConstruction(IntPtr Self, FTransform Transform);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Called on client when updated bReplicateMovement value is received for this actor.
		/// </summary>
		public void OnRep_ReplicateMovement()
		{
			E_AActor_OnRep_ReplicateMovement(NativePointer);
		}

		
		/// <summary>
		/// 
		/// Set whether this actor replicates to network clients. When this actor is spawned on the server it will be sent to clients as well.
		/// Properties flagged for replication will update on clients if they change on the server.
		/// Internally changes the RemoteRole property and handles the cases where the actor needs to be added to the network actor list.
		/// @param bInReplicates Whether this Actor replicates to network clients.
		/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication
		/// 
		/// </summary>
		public void SetReplicates(bool bInReplicates)
		{
			E_AActor_SetReplicates(NativePointer, bInReplicates);
		}

		
		/// <summary>
		/// Sets whether or not this Actor is an autonomous proxy, which is an actor on a network client that is controlled by a user on that client.
		/// </summary>
		public void SetAutonomousProxy(bool bInAutonomousProxy, bool bAllowForcePropertyCompare = true)
		{
			E_AActor_SetAutonomousProxy(NativePointer, bInAutonomousProxy, bAllowForcePropertyCompare);
		}

		
		/// <summary>
		/// Copies RemoteRole from another Actor and adds this actor to the list of network actors if necessary.
		/// </summary>
		public void CopyRemoteRoleFrom(AActor CopyFromActor)
		{
			E_AActor_CopyRemoteRoleFrom(NativePointer, CopyFromActor);
		}

		
		/// <summary>
		/// Called on the actor when a new subobject is dynamically created via replication
		/// </summary>
		public void OnSubobjectCreatedFromReplication(UObject NewSubobject)
		{
			E_AActor_OnSubobjectCreatedFromReplication(NativePointer, NewSubobject);
		}

		
		/// <summary>
		/// Return the value of bAllowReceiveTickEventOnDedicatedServer, indicating whether the Blueprint ReceiveTick() event will occur on dedicated servers.
		/// </summary>
		public bool AllowReceiveTickEventOnDedicatedServer()
		{
			return E_AActor_AllowReceiveTickEventOnDedicatedServer(NativePointer);
		}

		
		/// <summary>
		/// 
		/// Get the actor-to-world transform.
		/// @return The transform that transforms from actor space to world space.
		/// 
		/// </summary>
		public FTransform GetActorTransform()
		{
			return E_AActor_GetTransform(NativePointer);
		}

		
		/// <summary>
		/// Returns the location of the RootComponent of this Actor
		/// </summary>
		public FVector GetActorLocation()
		{
			return E_AActor_K2_GetActorLocation(NativePointer);
		}

		
		/// <summary>
		/// Returns rotation of the RootComponent of this Actor.
		/// </summary>
		public FRotator GetActorRotation()
		{
			return E_AActor_K2_GetActorRotation(NativePointer);
		}

		
		/// <summary>
		/// 
		/// Returns the bounding box of all components that make up this Actor (excluding ChildActorComponents).
		/// @param	bOnlyCollidingComponents	If true, will only return the bounding box for components with collision enabled.
		/// 
		/// </summary>
		public void GetActorBounds(bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent)
		{
			E_AActor_GetActorBounds(NativePointer, bOnlyCollidingComponents, Origin, BoxExtent);
		}

		
		/// <summary>
		/// 
		/// Set the Actor's rotation instantly to the specified rotation.
		/// 
		/// @param	NewRotation	The new rotation for the Actor.
		/// @param	bTeleportPhysics Whether we teleport the physics state (if physics collision is enabled for this object).
		/// If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location).
		/// If false, physics velocity is updated based on the change in position (affecting ragdoll parts).
		/// @return	Whether the rotation was successfully set.
		/// 
		/// </summary>
		public bool SetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
		{
			return E_AActor_K2_SetActorRotation(NativePointer, NewRotation, bTeleportPhysics);
		}

		
		/// <summary>
		/// Set the Actor's world-space scale.
		/// </summary>
		public void SetActorScale3D(FVector NewScale3D)
		{
			E_AActor_SetActorScale3D(NativePointer, NewScale3D);
		}

		
		/// <summary>
		/// Returns the distance from this Actor to OtherActor.
		/// </summary>
		public float GetDistanceTo(AActor OtherActor)
		{
			return E_AActor_GetDistanceTo(NativePointer, OtherActor);
		}

		
		/// <summary>
		/// 
		/// Get CustomTimeDilation - this can be used for input control or speed control for slomo.
		/// We don't want to scale input globally because input can be used for UI, which do not care for TimeDilation.
		/// 
		/// </summary>
		public float GetActorTimeDilation()
		{
			return E_AActor_GetActorTimeDilation(NativePointer);
		}

		public void SetTickPrerequisite(AActor PrerequisiteActor)
		{
			E_AActor_SetTickPrerequisite(NativePointer, PrerequisiteActor);
		}

		
		/// <summary>
		/// Gets whether this actor can tick when paused.
		/// </summary>
		public bool GetTickableWhenPaused()
		{
			return E_AActor_GetTickableWhenPaused(NativePointer);
		}

		
		/// <summary>
		/// The number of seconds (in game time) since this Actor was created, relative to Get Game Time In Seconds.
		/// </summary>
		public float GetGameTimeSinceCreation()
		{
			return E_AActor_GetGameTimeSinceCreation(NativePointer);
		}

		
		/// <summary>
		/// Event called every frame
		/// </summary>
		public void Tick(float DeltaSeconds)
		{
			E_AActor_ReceiveTick(NativePointer, DeltaSeconds);
		}

		
		/// <summary>
		/// 
		/// Destroy this actor. Returns true the actor is destroyed or already marked for destruction, false if indestructible.
		/// Destruction is latent. It occurs at the end of the tick.
		/// @param	bNetForce				[opt] Ignored unless called during play.  Default is false.
		/// @param	bShouldModifyLevel		[opt] If true, Modify() the level before removing the actor.  Default is true.
		/// returns	true if destroyed or already marked for destruction, false if indestructible.
		/// 
		/// </summary>
		public bool Destroy(bool bNetForce = false, bool bShouldModifyLevel = true)
		{
			return E_AActor_Destroy(NativePointer, bNetForce, bShouldModifyLevel);
		}

		
		/// <summary>
		/// 
		/// See if this actor is owned by TestOwner.
		/// 
		/// </summary>
		public bool IsOwnedBy(AActor TestOwner)
		{
			return E_AActor_IsOwnedBy(NativePointer, TestOwner);
		}

		
		/// <summary>
		/// Returns the quaternion of the RootComponent of this Actor
		/// </summary>
		public FQuat GetActorQuat()
		{
			return E_AActor_GetActorQuat(NativePointer);
		}

		
		/// <summary>
		/// 
		/// Called by owning level to shift an actor location and all relevant data structures by specified delta
		/// 
		/// @param InWorldOffset	 Offset vector to shift actor location
		/// @param bWorldShift	 Whether this call is part of whole world shifting
		/// 
		/// </summary>
		public void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
		{
			E_AActor_ApplyWorldOffset(NativePointer, InOffset, bWorldShift);
		}

		
		/// <summary>
		/// 
		/// When called, will call the virtual call chain to register all of the tick functions for both the actor and optionally all components
		/// Do not override this function or make it virtual
		/// @param bRegister - true to register, false, to unregister
		/// @param bDoComponents - true to also apply the change to all components
		/// 
		/// </summary>
		public void RegisterAllActorTickFunctions(bool bRegister, bool bDoComponents)
		{
			E_AActor_RegisterAllActorTickFunctions(NativePointer, bRegister, bDoComponents);
		}

		
		/// <summary>
		/// Update velocity - typically from ReplicatedMovement, not called for simulated physics!
		/// </summary>
		public void PostNetReceiveVelocity(FVector NewVelocity)
		{
			E_AActor_PostNetReceiveVelocity(NativePointer, NewVelocity);
		}

		
		/// <summary>
		/// 
		/// Get the owner of this Actor, used primarily for network replication.
		/// @return Actor that owns this Actor
		/// 
		/// </summary>
		public AActor GetOwner()
		{
			return E_AActor_GetOwner(NativePointer);
		}

		
		/// <summary>
		/// 
		/// @param RealViewer - is the "controlling net object" associated with the client for which network relevancy is being checked (typically player controller)
		/// @param ViewTarget - is the Actor being used as the point of view for the RealViewer
		/// @param SrcLocation - is the viewing location
		/// 
		/// @return bool - true if this actor is replay relevant to the client associated with RealViewer
		/// 
		/// </summary>
		public bool IsReplayRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared)
		{
			return E_AActor_IsReplayRelevantFor(NativePointer, RealViewer, ViewTarget, SrcLocation, CullDistanceSquared);
		}

		
		/// <summary>
		/// 
		/// Check if this actor is the owner when doing relevancy checks for actors marked bOnlyRelevantToOwner
		/// 
		/// @param ReplicatedActor - the actor we're doing a relevancy test on
		/// @param ActorOwner - the owner of ReplicatedActor
		/// @param ConnectionActor - the controller of the connection that we're doing relevancy checks for
		/// 
		/// @return bool - true if this actor should be considered the owner
		/// 
		/// </summary>
		public bool IsRelevancyOwnerFor(AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor)
		{
			return E_AActor_IsRelevancyOwnerFor(NativePointer, ReplicatedActor, ActorOwner, ConnectionActor);
		}

		
		/// <summary>
		/// 
		/// Incrementally registers components associated with this actor
		/// 
		/// @param NumComponentsToRegister  Number of components to register in this run, 0 for all
		/// @return true when all components were registered for this actor
		/// 
		/// </summary>
		public bool IncrementalRegisterComponents(int NumComponentsToRegister)
		{
			return E_AActor_IncrementalRegisterComponents(NativePointer, NumComponentsToRegister);
		}

		
		/// <summary>
		/// 
		/// Used for adding actors to levels or teleporting them to a new location.
		/// The result of this function is independent of the actor's current location and rotation.
		/// If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such if bNoCheck is false.
		/// 
		/// @param DestLocation The target destination point
		/// @param DestRotation The target rotation at the destination
		/// @param bIsATest is true if this is a test movement, which shouldn't cause any notifications (used by AI pathfinding, for example)
		/// @param bNoCheck is true if we should skip checking for encroachment in the world or other actors
		/// @return true if the actor has been successfully moved, or false if it couldn't fit.
		/// 
		/// </summary>
		public bool TeleportTo(FVector DestLocation, FRotator DestRotation, bool bIsATest = false, bool bNoCheck = false)
		{
			return E_AActor_TeleportTo(NativePointer, DestLocation, DestRotation, bIsATest, bNoCheck);
		}

		
		/// <summary>
		/// 
		/// Teleport this actor to a new location. If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such.
		/// 
		/// @param DestLocation The target destination point
		/// @param DestRotation The target rotation at the destination
		/// @return true if the actor has been successfully moved, or false if it couldn't fit.
		/// 
		/// </summary>
		public bool Teleport(FVector DestLocation, FRotator DestRotation)
		{
			return E_AActor_K2_TeleportTo(NativePointer, DestLocation, DestRotation);
		}

		
		/// <summary>
		/// 
		/// Debug helper to show the component hierarchy of this actor.
		/// @param Info	Optional String to display at top of info
		/// 
		/// </summary>
		public void DebugShowComponentHierarchy(string Info, bool bShowPosition = true)
		{
			E_AActor_DebugShowComponentHierarchy(NativePointer, Info, bShowPosition);
		}

		
		/// <summary>
		/// 
		/// Called when an instance of this class is placed (in editor) or spawned.
		/// @param	Transform			The transform the actor was constructed at.
		/// 
		/// </summary>
		public void OnConstruction(FTransform Transform)
		{
			E_AActor_OnConstruction(NativePointer, Transform);
		}

		#endregion
		
		public static explicit operator IntPtr(AActor Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator AActor(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new AActor(Adress);
		}}}
