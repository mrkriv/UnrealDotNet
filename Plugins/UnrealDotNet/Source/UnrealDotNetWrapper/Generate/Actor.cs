using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	/// <summary>
	/// Actor is the base class for an Object that can be placed or spawned in a level.
	/// Actors may contain a collection of ActorComponents, which can be used to control how actors move, how they are rendered, etc.
	/// The other main function of an Actor is the replication of properties and function calls across the network during play.
	/// See: https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/
	/// See: UActorComponent
	/// </summary>
	public class AActor : UObject
	{
		private readonly IntPtr NativePointer;
		
		public AActor(IntPtr Adress)
		{
			NativePointer = Adress;
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ForceNetUpdate(IntPtr Self);
		
		/// <summary>
		/// Force actor to be updated to clients
		/// </summary>
		public void ForceNetUpdate()
		{
			Call_ForceNetUpdate((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_WasRecentlyRendered(IntPtr Self, float Tolerance);
		
		/// <summary>
		/// Returns true if this actor has been rendered "recently", with a tolerance in seconds to define what "recent" means.
		/// e.g.: If a tolerance of 0.1 is used, this function will return true only if the actor was rendered in the last 0.1 seconds of game time.
		/// <param name="Tolerance">How many seconds ago the actor last render time can be and still count as having been "recently" rendered.</param>
		/// <returns>Whether this actor was recently rendered.</returns>
		/// </summary>
		public bool WasRecentlyRendered(float Tolerance)
		{
			return Call_WasRecentlyRendered((IntPtr)this, Tolerance);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_K2_OnReset(IntPtr Self);
		
		/// <summary>
		/// Event called when this Actor is reset to its initial state - used when restarting level without reloading.
		/// </summary>
		public void K2_OnReset()
		{
			Call_K2_OnReset((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsChildActor(IntPtr Self);
		
		/// <summary>
		/// Returns whether this Actor was spawned by a child actor component
		/// </summary>
		public bool IsChildActor()
		{
			return Call_IsChildActor((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_FlushNetDormancy(IntPtr Self);
		
		/// <summary>
		/// Forces dormant actor to replicate but doesn't change NetDormancy state (i.e., they will go dormant again if left dormant)
		/// </summary>
		public void FlushNetDormancy()
		{
			Call_FlushNetDormancy((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_ReplicatedMovement(IntPtr Self);
		
		/// <summary>
		/// ReplicatedMovement struct replication event
		/// </summary>
		public void OnRep_ReplicatedMovement()
		{
			Call_OnRep_ReplicatedMovement((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetActorTickInterval(IntPtr Self);
		
		/// <summary>
		/// Returns the tick interval of this actor's primary tick function
		/// </summary>
		public float GetActorTickInterval()
		{
			return Call_GetActorTickInterval((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorTickInterval(IntPtr Self, float TickInterval);
		
		/// <summary>
		/// Sets the tick interval of this actor's primary tick function. Will not enable a disabled tick function. Takes effect on next tick.
		/// <param name="TickInterval">The rate at which this actor should be ticking</param>
		/// </summary>
		public void SetActorTickInterval(float TickInterval)
		{
			Call_SetActorTickInterval((IntPtr)this, TickInterval);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsActorTickEnabled(IntPtr Self);
		
		/// <summary>
		/// Returns whether this actor has tick enabled or not
		/// </summary>
		public bool IsActorTickEnabled()
		{
			return Call_IsActorTickEnabled((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorTickEnabled(IntPtr Self, bool bEnabled);
		
		/// <summary>
		/// Set this actor's tick functions to be enabled or disabled. Only has an effect if the function is registered
		/// This only modifies the tick function on actor itself
		/// <param name="bEnabled">Whether it should be enabled or not</param>
		/// </summary>
		public void SetActorTickEnabled(bool bEnabled)
		{
			Call_SetActorTickEnabled((IntPtr)this, bEnabled);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsSelectable(IntPtr Self);
		
		/// <summary>
		/// <returns>??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????</returns>
		/// </summary>
		public bool IsSelectable()
		{
			return Call_IsSelectable((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsEditable(IntPtr Self);
		
		/// <summary>
		/// <returns>Returns true if this actor is allowed to be displayed, selected and manipulated by the editor.</returns>
		/// </summary>
		public bool IsEditable()
		{
			return Call_IsEditable((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsTemporarilyHiddenInEditor(IntPtr Self, bool bIncludeParent);
		
		/// <summary>
		/// <param name="bIncludeParent">- Whether to recurse up child actor hierarchy or not</param>
		/// <returns>Whether or not this actor is hidden in the editor for the duration of the current editor session</returns>
		/// </summary>
		public bool IsTemporarilyHiddenInEditor(bool bIncludeParent)
		{
			return Call_IsTemporarilyHiddenInEditor((IntPtr)this, bIncludeParent);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetIsTemporarilyHiddenInEditor(IntPtr Self, bool bIsHidden);
		
		/// <summary>
		/// Sets whether or not this actor is hidden in the editor for the duration of the current editor session
		/// <param name="bIsHidden">True if the actor is hidden</param>
		/// </summary>
		public void SetIsTemporarilyHiddenInEditor(bool bIsHidden)
		{
			Call_SetIsTemporarilyHiddenInEditor((IntPtr)this, bIsHidden);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsHiddenEd(IntPtr Self);
		
		/// <summary>
		/// Returns true if this actor is hidden in the editor viewports.
		/// </summary>
		public bool IsHiddenEd()
		{
			return Call_IsHiddenEd((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsHiddenEdAtStartup(IntPtr Self);
		
		/// <summary>
		/// Simple accessor to check if the actor is hidden upon editor startup
		/// <returns>true if the actor is hidden upon editor startup; false if it is not</returns>
		/// </summary>
		public bool IsHiddenEdAtStartup()
		{
			return Call_IsHiddenEdAtStartup((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveDestroyed(IntPtr Self);
		
		/// <summary>
		/// Receive Destroyed
		/// </summary>
		public void ReceiveDestroyed()
		{
			Call_ReceiveDestroyed((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_UserConstructionScript(IntPtr Self);
		
		/// <summary>
		/// Construction script, the place to spawn components and do other setup.
		/// @note Name used in CreateBlueprint function
		/// <param name="Location">The location.</param>
		/// <param name="Rotation">The rotation.</param>
		/// </summary>
		public void UserConstructionScript()
		{
			Call_UserConstructionScript((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetLifeSpan(IntPtr Self);
		
		/// <summary>
		/// Get the remaining lifespan of this actor. If zero is returned the actor lives forever.
		/// </summary>
		public float GetLifeSpan()
		{
			return Call_GetLifeSpan((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetLifeSpan(IntPtr Self, float InLifespan);
		
		/// <summary>
		/// Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed.
		/// </summary>
		public void SetLifeSpan(float InLifespan)
		{
			Call_SetLifeSpan((IntPtr)this, InLifespan);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveActorEndCursorOver(IntPtr Self);
		
		/// <summary>
		/// Event when this actor has the mouse moved off of it with the clickable interface.
		/// </summary>
		public void ReceiveActorEndCursorOver()
		{
			Call_ReceiveActorEndCursorOver((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveActorBeginCursorOver(IntPtr Self);
		
		/// <summary>
		/// Event when this actor has the mouse moved over it with the clickable interface.
		/// </summary>
		public void ReceiveActorBeginCursorOver()
		{
			Call_ReceiveActorBeginCursorOver((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		/// <summary>
		/// Event called every frame
		/// </summary>
		public void ReceiveTick(float DeltaSeconds)
		{
			Call_ReceiveTick((IntPtr)this, DeltaSeconds);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsActorBeingDestroyed(IntPtr Self);
		
		/// <summary>
		/// Is Actor Being Destroyed
		/// </summary>
		public bool IsActorBeingDestroyed()
		{
			return Call_IsActorBeingDestroyed((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetGameTimeSinceCreation(IntPtr Self);
		
		/// <summary>
		/// The number of seconds (in game time) since this Actor was created, relative to Get Game Time In Seconds.
		/// </summary>
		public float GetGameTimeSinceCreation()
		{
			return Call_GetGameTimeSinceCreation((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetTickableWhenPaused(IntPtr Self, bool bTickableWhenPaused);
		
		/// <summary>
		/// Sets whether this actor can tick when paused.
		/// </summary>
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
		{
			Call_SetTickableWhenPaused((IntPtr)this, bTickableWhenPaused);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_GetTickableWhenPaused(IntPtr Self);
		
		/// <summary>
		/// Gets whether this actor can tick when paused.
		/// </summary>
		public bool GetTickableWhenPaused()
		{
			return Call_GetTickableWhenPaused((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetActorTimeDilation(IntPtr Self);
		
		/// <summary>
		/// Get CustomTimeDilation - this can be used for input control or speed control for slomo.
		/// We don't want to scale input globally because input can be used for UI, which do not care for TimeDilation.
		/// </summary>
		public float GetActorTimeDilation()
		{
			return Call_GetActorTimeDilation((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_DetachRootComponentFromParent(IntPtr Self, bool bMaintainWorldPosition);
		
		/// <summary>
		/// Detach Root Component from Parent
		/// </summary>
		public void DetachRootComponentFromParent(bool bMaintainWorldPosition)
		{
			Call_DetachRootComponentFromParent((IntPtr)this, bMaintainWorldPosition);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_HasAuthority(IntPtr Self);
		
		/// <summary>
		/// Returns whether this actor has network authority
		/// </summary>
		public bool HasAuthority()
		{
			return Call_HasAuthority((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_K2_DestroyActor(IntPtr Self);
		
		/// <summary>
		/// Destroy the actor
		/// </summary>
		public void K2_DestroyActor()
		{
			Call_K2_DestroyActor((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_GetActorEnableCollision(IntPtr Self);
		
		/// <summary>
		/// Get current state of collision for the whole actor
		/// </summary>
		public bool GetActorEnableCollision()
		{
			return Call_GetActorEnableCollision((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorEnableCollision(IntPtr Self, bool bNewActorEnableCollision);
		
		/// <summary>
		/// Allows enabling/disabling collision for the whole actor
		/// </summary>
		public void SetActorEnableCollision(bool bNewActorEnableCollision)
		{
			Call_SetActorEnableCollision((IntPtr)this, bNewActorEnableCollision);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorHiddenInGame(IntPtr Self, bool bNewHidden);
		
		/// <summary>
		/// Sets the actor to be hidden in the game
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components</param>
		/// </summary>
		public void SetActorHiddenInGame(bool bNewHidden)
		{
			Call_SetActorHiddenInGame((IntPtr)this, bNewHidden);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_Instigator(IntPtr Self);
		
		/// <summary>
		/// Called on clients when Instigator is replicated.
		/// </summary>
		public void OnRep_Instigator()
		{
			Call_OnRep_Instigator((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_AttachmentReplication(IntPtr Self);
		
		/// <summary>
		/// Called on client when updated AttachmentReplication value is received for this actor.
		/// </summary>
		public void OnRep_AttachmentReplication()
		{
			Call_OnRep_AttachmentReplication((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetReplicateMovement(IntPtr Self, bool bInReplicateMovement);
		
		/// <summary>
		/// Set whether this actor's movement replicates to network clients.
		/// <param name="bInReplicateMovement">Whether this Actor's movement replicates to clients.</param>
		/// </summary>
		public void SetReplicateMovement(bool bInReplicateMovement)
		{
			Call_SetReplicateMovement((IntPtr)this, bInReplicateMovement);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetReplicates(IntPtr Self, bool bInReplicates);
		
		/// <summary>
		/// Set whether this actor replicates to network clients. When this actor is spawned on the server it will be sent to clients as well.
		/// Properties flagged for replication will update on clients if they change on the server.
		/// Internally changes the RemoteRole property and handles the cases where the actor needs to be added to the network actor list.
		/// <param name="bInReplicates">Whether this Actor replicates to network clients.</param>
		/// See: https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication/
		/// </summary>
		public void SetReplicates(bool bInReplicates)
		{
			Call_SetReplicates((IntPtr)this, bInReplicates);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_TearOff(IntPtr Self);
		
		/// <summary>
		/// Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true.
		/// </summary>
		public void TearOff()
		{
			Call_TearOff((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_ReplicateMovement(IntPtr Self);
		
		/// <summary>
		/// Called on client when updated bReplicateMovement value is received for this actor.
		/// </summary>
		public void OnRep_ReplicateMovement()
		{
			Call_OnRep_ReplicateMovement((IntPtr)this);
		}
		
		public static explicit operator IntPtr(AActor Self)
		{
			return Self.NativePointer;
		}
	}
}