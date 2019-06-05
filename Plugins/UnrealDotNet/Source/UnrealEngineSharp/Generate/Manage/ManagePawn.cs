// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

namespace UnrealEngine
{
	[ManageType("ManagePawn")]
	public partial class ManagePawn : APawn
	{
		public ManagePawn(IntPtr adress)
			: base(adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_AddControllerPitchInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_AddControllerRollInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_AddControllerYawInput(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_DestroyPlayerInputComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_DetachFromControllerPendingDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OnRep_Controller(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OnRep_PlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PawnClientRestart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PawnStartFire(IntPtr self, byte fireModeNum);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_RecalculateBaseEyeHeight(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_Restart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_SetPlayerDefaults(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_SpawnDefaultController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_TurnOff(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_UnPossessed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_UpdateNavigationRelevance(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_BeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_ClearCrossLevelReferences(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_Destroyed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_ForceNetRelevant(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_ForceNetUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_GatherCurrentMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_InvalidateLightingCacheDetailed(IntPtr self, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_K2_DestroyActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_LifeSpanExpired(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_MarkComponentsAsPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_NotifyActorBeginCursorOver(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_NotifyActorEndCursorOver(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OnRep_AttachmentReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OnRep_Instigator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OnRep_Owner(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OnRep_ReplicatedMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OnRep_ReplicateMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OnReplicationPausedChanged(IntPtr self, bool bIsReplicationPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OutsideWorldBounds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostActorCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostInitializeComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostNetInit(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostNetReceiveLocationAndRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostNetReceivePhysicState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostNetReceiveRole(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostRegisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostUnregisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PreInitializeComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PreRegisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PrestreamTextures(IntPtr self, float seconds, bool bEnableStreaming, int cinematicTextureGroups);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_RegisterActorTickFunctions(IntPtr self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_RegisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_ReregisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_RerunConstructionScripts(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_Reset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_RewindForReplay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_SetActorHiddenInGame(IntPtr self, bool bNewHidden);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_SetLifeSpan(IntPtr self, float inLifespan);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_SetReplicateMovement(IntPtr self, bool bInReplicateMovement);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_TearOff(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_TeleportSucceeded(IntPtr self, bool bIsATest);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_Tick(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_TornOff(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_UnregisterAllComponents(IntPtr self, bool bForReregister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_BeginDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_FinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_MarkAsEditorOnlySubobject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostCDOContruct(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostEditImport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostInitProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostRepNotifies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PostSaveRoot(IntPtr self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PreDestroyFromReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_PreNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_ShutdownAfterError(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_CreateCluster(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__APawn_OnClusterMarkedAsPendingKill(IntPtr self);
		
		#endregion
		
		#region Methods
		
		/// <summary>
		/// Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController.
		/// <para>This value is multiplied by the PlayerController's InputPitchScale value. </para>
		/// <see cref="PlayerController"/>
		/// </summary>
		/// <param name="val">Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value.</param>
		public override void AddControllerPitchInput(float val)
			=> E__Supper__APawn_AddControllerPitchInput(this, val);
		
		
		/// <summary>
		/// Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController.
		/// <para>This value is multiplied by the PlayerController's InputRollScale value. </para>
		/// <see cref="PlayerController"/>
		/// </summary>
		/// <param name="val">Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value.</param>
		public override void AddControllerRollInput(float val)
			=> E__Supper__APawn_AddControllerRollInput(this, val);
		
		
		/// <summary>
		/// Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController.
		/// <para>This value is multiplied by the PlayerController's InputYawScale value. </para>
		/// <see cref="PlayerController"/>
		/// </summary>
		/// <param name="val">Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value.</param>
		public override void AddControllerYawInput(float val)
			=> E__Supper__APawn_AddControllerYawInput(this, val);
		
		
		/// <summary>
		/// Destroys the player input component and removes any references to it.
		/// </summary>
		protected override void DestroyPlayerInputComponent()
			=> E__Supper__APawn_DestroyPlayerInputComponent(this);
		
		
		/// <summary>
		/// Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon.
		/// </summary>
		public override void DetachFromControllerPendingDestroy()
			=> E__Supper__APawn_DetachFromControllerPendingDestroy(this);
		
		public override void OnRep_Controller()
			=> E__Supper__APawn_OnRep_Controller(this);
		
		public override void OnRep_PlayerState()
			=> E__Supper__APawn_OnRep_PlayerState(this);
		
		
		/// <summary>
		/// Tell client that the Pawn is begin restarted. Calls Restart().
		/// </summary>
		public override void PawnClientRestart()
			=> E__Supper__APawn_PawnClientRestart(this);
		
		
		/// <summary>
		/// Handle StartFire() passed from PlayerController
		/// </summary>
		public override void PawnStartFire(byte fireModeNum)
			=> E__Supper__APawn_PawnStartFire(this, fireModeNum);
		
		
		/// <summary>
		/// Set BaseEyeHeight based on current state.
		/// </summary>
		public override void RecalculateBaseEyeHeight()
			=> E__Supper__APawn_RecalculateBaseEyeHeight(this);
		
		
		/// <summary>
		/// Called when the Pawn is being restarted (usually by being possessed by a Controller).
		/// </summary>
		public override void Restart()
			=> E__Supper__APawn_Restart(this);
		
		
		/// <summary>
		/// Make sure pawn properties are back to default.
		/// </summary>
		public override void SetPlayerDefaults()
			=> E__Supper__APawn_SetPlayerDefaults(this);
		
		
		/// <summary>
		/// Spawn default controller for this Pawn, and get possessed by it.
		/// </summary>
		public override void SpawnDefaultController()
			=> E__Supper__APawn_SpawnDefaultController(this);
		
		
		/// <summary>
		/// Freeze pawn - stop sounds, animations, physics, weapon firing
		/// </summary>
		public override void TurnOff()
			=> E__Supper__APawn_TurnOff(this);
		
		
		/// <summary>
		/// Called when our Controller no longer possesses us.
		/// </summary>
		public override void UnPossessed()
			=> E__Supper__APawn_UnPossessed(this);
		
		
		/// <summary>
		/// Update all components relevant for navigation generators to match bCanAffectNavigationGeneration flag
		/// </summary>
		public override void UpdateNavigationRelevance()
			=> E__Supper__APawn_UpdateNavigationRelevance(this);
		
		
		/// <summary>
		/// Overridable native event for when play begins for this actor.
		/// </summary>
		protected override void BeginPlay()
			=> E__Supper__APawn_BeginPlay(this);
		
		
		/// <summary>
		/// Do anything needed to clear out cross level references; Called from ULevel::PreSave
		/// </summary>
		public override void ClearCrossLevelReferences()
			=> E__Supper__APawn_ClearCrossLevelReferences(this);
		
		
		/// <summary>
		/// Called when this actor is explicitly being destroyed during gameplay or in the editor, not called during level streaming or gameplay ending
		/// </summary>
		public override void Destroyed()
			=> E__Supper__APawn_Destroyed(this);
		
		
		/// <summary>
		/// Forces this actor to be net relevant if it is not already by default
		/// </summary>
		public override void ForceNetRelevant()
			=> E__Supper__APawn_ForceNetRelevant(this);
		
		
		/// <summary>
		/// Force actor to be updated to clients/demo net drivers
		/// </summary>
		public override void ForceNetUpdate()
			=> E__Supper__APawn_ForceNetUpdate(this);
		
		
		/// <summary>
		/// Fills ReplicatedMovement property
		/// </summary>
		public override void GatherCurrentMovement()
			=> E__Supper__APawn_GatherCurrentMovement(this);
		
		
		/// <summary>
		/// Invalidates anything produced by the last lighting build.
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bTranslationOnly)
			=> E__Supper__APawn_InvalidateLightingCacheDetailed(this, bTranslationOnly);
		
		
		/// <summary>
		/// Destroy the actor
		/// </summary>
		public override void DestroyActor()
			=> E__Supper__APawn_K2_DestroyActor(this);
		
		
		/// <summary>
		/// Called when the lifespan of an actor expires (if he has one).
		/// </summary>
		public override void LifeSpanExpired()
			=> E__Supper__APawn_LifeSpanExpired(this);
		
		
		/// <summary>
		/// Called to mark all components as pending kill when the actor is being destroyed
		/// </summary>
		public override void MarkComponentsAsPendingKill()
			=> E__Supper__APawn_MarkComponentsAsPendingKill(this);
		
		
		/// <summary>
		/// Event when this actor has the mouse moved over it with the clickable interface.
		/// </summary>
		public override void NotifyActorBeginCursorOver()
			=> E__Supper__APawn_NotifyActorBeginCursorOver(this);
		
		
		/// <summary>
		/// Event when this actor has the mouse moved off of it with the clickable interface.
		/// </summary>
		public override void NotifyActorEndCursorOver()
			=> E__Supper__APawn_NotifyActorEndCursorOver(this);
		
		public override void OnRep_AttachmentReplication()
			=> E__Supper__APawn_OnRep_AttachmentReplication(this);
		
		public override void OnRep_Instigator()
			=> E__Supper__APawn_OnRep_Instigator(this);
		
		protected override void OnRep_Owner()
			=> E__Supper__APawn_OnRep_Owner(this);
		
		public override void OnRep_ReplicatedMovement()
			=> E__Supper__APawn_OnRep_ReplicatedMovement(this);
		
		public override void OnRep_ReplicateMovement()
			=> E__Supper__APawn_OnRep_ReplicateMovement(this);
		
		
		/// <summary>
		/// Called on the client when the replication paused value is changed
		/// </summary>
		public override void OnReplicationPausedChanged(bool bIsReplicationPaused)
			=> E__Supper__APawn_OnReplicationPausedChanged(this, bIsReplicationPaused);
		
		
		/// <summary>
		/// Called when the Actor is outside the hard limit on world bounds
		/// </summary>
		public override void OutsideWorldBounds()
			=> E__Supper__APawn_OutsideWorldBounds(this);
		
		
		/// <summary>
		/// Called when an actor is done spawning into the world (from UWorld::SpawnActor), both in the editor and during gameplay
		/// <para>For actors with a root component, the location and rotation will have already been set. </para>
		/// This is called before calling construction scripts, but after native components have been created
		/// </summary>
		public override void PostActorCreated()
			=> E__Supper__APawn_PostActorCreated(this);
		
		
		/// <summary>
		/// Allow actors to initialize themselves on the C++ side after all of their components have been initialized, only called during gameplay
		/// </summary>
		public override void PostInitializeComponents()
			=> E__Supper__APawn_PostInitializeComponents(this);
		
		
		/// <summary>
		/// Always called immediately after spawning and reading in replicated properties
		/// </summary>
		public override void PostNetInit()
			=> E__Supper__APawn_PostNetInit(this);
		
		
		/// <summary>
		/// Update location and rotation from ReplicatedMovement. Not called for simulated physics!
		/// </summary>
		public override void PostNetReceiveLocationAndRotation()
			=> E__Supper__APawn_PostNetReceiveLocationAndRotation(this);
		
		
		/// <summary>
		/// Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity()
		/// </summary>
		public override void PostNetReceivePhysicState()
			=> E__Supper__APawn_PostNetReceivePhysicState(this);
		
		
		/// <summary>
		/// Always called immediately after a new Role is received from the remote.
		/// </summary>
		public override void PostNetReceiveRole()
			=> E__Supper__APawn_PostNetReceiveRole(this);
		
		
		/// <summary>
		/// Called after all the components in the Components array are registered, called both in editor and during gameplay
		/// </summary>
		public override void PostRegisterAllComponents()
			=> E__Supper__APawn_PostRegisterAllComponents(this);
		
		
		/// <summary>
		/// Called after all currently registered components are cleared
		/// </summary>
		public override void PostUnregisterAllComponents()
			=> E__Supper__APawn_PostUnregisterAllComponents(this);
		
		
		/// <summary>
		/// Called right before components are initialized, only called during gameplay
		/// </summary>
		public override void PreInitializeComponents()
			=> E__Supper__APawn_PreInitializeComponents(this);
		
		
		/// <summary>
		/// Called before all the components in the Components array are registered, called both in editor and during gameplay
		/// </summary>
		public override void PreRegisterAllComponents()
			=> E__Supper__APawn_PreRegisterAllComponents(this);
		
		
		/// <summary>
		/// Calls PrestreamTextures() for all the actor's meshcomponents.
		/// </summary>
		/// <param name="seconds">Number of seconds to force all mip-levels to be resident</param>
		/// <param name="bEnableStreaming">Whether to start (true) or stop (false) streaming</param>
		/// <param name="cinematicTextureGroups">Bitfield indicating which texture groups that use extra high-resolution mips</param>
		public override void PrestreamTextures(float seconds, bool bEnableStreaming, int cinematicTextureGroups)
			=> E__Supper__APawn_PrestreamTextures(this, seconds, bEnableStreaming, cinematicTextureGroups);
		
		
		/// <summary>
		/// Virtual call chain to register all tick functions for the actor class hierarchy
		/// </summary>
		/// <param name="bRegister">true to register, false, to unregister</param>
		protected override void RegisterActorTickFunctions(bool bRegister)
			=> E__Supper__APawn_RegisterActorTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// Ensure that all the components in the Components array are registered
		/// </summary>
		public override void RegisterAllComponents()
			=> E__Supper__APawn_RegisterAllComponents(this);
		
		
		/// <summary>
		/// Will reregister all components on this actor. Does a lot of work - should only really be used in editor, generally use UpdateComponentTransforms or MarkComponentsRenderStateDirty.
		/// </summary>
		public override void ReregisterAllComponents()
			=> E__Supper__APawn_ReregisterAllComponents(this);
		
		
		/// <summary>
		/// Rerun construction scripts, destroying all autogenerated components; will attempt to preserve the root component location.
		/// </summary>
		public override void RerunConstructionScripts()
			=> E__Supper__APawn_RerunConstructionScripts(this);
		
		
		/// <summary>
		/// Reset actor to initial state - used when restarting level without reloading.
		/// </summary>
		public override void Reset()
			=> E__Supper__APawn_Reset(this);
		
		
		/// <summary>
		/// Called on the actor before checkpoint data is applied during a replay.
		/// <para>Only called if bReplayRewindable is set. </para>
		/// </summary>
		public override void RewindForReplay()
			=> E__Supper__APawn_RewindForReplay(this);
		
		
		/// <summary>
		/// Sets the actor to be hidden in the game
		/// </summary>
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components</param>
		public override void SetActorHiddenInGame(bool bNewHidden)
			=> E__Supper__APawn_SetActorHiddenInGame(this, bNewHidden);
		
		
		/// <summary>
		/// Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed.
		/// </summary>
		public override void SetLifeSpan(float inLifespan)
			=> E__Supper__APawn_SetLifeSpan(this, inLifespan);
		
		
		/// <summary>
		/// Set whether this actor's movement replicates to network clients.
		/// </summary>
		/// <param name="bInReplicateMovement">Whether this Actor's movement replicates to clients.</param>
		public override void SetReplicateMovement(bool bInReplicateMovement)
			=> E__Supper__APawn_SetReplicateMovement(this, bInReplicateMovement);
		
		
		/// <summary>
		/// Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true.
		/// </summary>
		public override void TearOff()
			=> E__Supper__APawn_TearOff(this);
		
		
		/// <summary>
		/// Called from TeleportTo() when teleport succeeds
		/// </summary>
		public override void TeleportSucceeded(bool bIsATest)
			=> E__Supper__APawn_TeleportSucceeded(this, bIsATest);
		
		
		/// <summary>
		/// Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame.
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// </summary>
		/// <param name="deltaSeconds">Game time elapsed during last frame modified by the time dilation</param>
		public override void Tick(float deltaSeconds)
			=> E__Supper__APawn_Tick(this, deltaSeconds);
		
		
		/// <summary>
		/// Networking - called on client when actor is torn off (bTearOff==true), meaning it's no longer replicated to clients.
		/// <para>@see bTearOff </para>
		/// </summary>
		public override void TornOff()
			=> E__Supper__APawn_TornOff(this);
		
		
		/// <summary>
		/// Unregister all currently registered components
		/// </summary>
		/// <param name="bForReregister">If true, RegisterAllComponents will be called immediately after this so some slow operations can be avoided</param>
		public override void UnregisterAllComponents(bool bForReregister)
			=> E__Supper__APawn_UnregisterAllComponents(this, bForReregister);
		
		
		/// <summary>
		/// Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy()
			=> E__Supper__APawn_BeginDestroy(this);
		
		
		/// <summary>
		/// Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed.
		/// <para>@warning Because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E__Supper__APawn_FinishDestroy(this);
		
		
		/// <summary>
		/// Called during subobject creation to mark this component as editor only, which causes it to get stripped in packaged builds
		/// </summary>
		public override void MarkAsEditorOnlySubobject()
			=> E__Supper__APawn_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E__Supper__APawn_PostCDOContruct(this);
		
		
		/// <summary>
		/// Called after importing property values for this object (paste, duplicate or .t3d import)
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// are unsupported by the script serialization
		/// </summary>
		public override void PostEditImport()
			=> E__Supper__APawn_PostEditImport(this);
		
		
		/// <summary>
		/// Called after the C++ constructor and after the properties have been initialized, including those loaded from config.
		/// <para>This is called before any serialization or other setup has happened. </para>
		/// </summary>
		public override void PostInitProperties()
			=> E__Supper__APawn_PostInitProperties(this);
		
		
		/// <summary>
		/// Do any object-specific cleanup required immediately after loading an object.
		/// <para>This is not called for newly-created objects, and by default will always execute on the game thread. </para>
		/// </summary>
		public override void PostLoad()
			=> E__Supper__APawn_PostLoad(this);
		
		
		/// <summary>
		/// Called right after receiving a bunch
		/// </summary>
		public override void PostNetReceive()
			=> E__Supper__APawn_PostNetReceive(this);
		
		
		/// <summary>
		/// Called right after calling all OnRep notifies (called even when there are no notifies)
		/// </summary>
		public override void PostRepNotifies()
			=> E__Supper__APawn_PostRepNotifies(this);
		
		
		/// <summary>
		/// Called from within SavePackage on the passed in base/root object.
		/// <para>This function is called after the package has been saved and can perform cleanup. </para>
		/// </summary>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up</param>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E__Supper__APawn_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// Called right before being marked for destruction due to network replication
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E__Supper__APawn_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// Called right before receiving a bunch
		/// </summary>
		public override void PreNetReceive()
			=> E__Supper__APawn_PreNetReceive(this);
		
		
		/// <summary>
		/// After a critical error, perform any mission-critical cleanup, such as restoring the video mode orreleasing hardware resources.
		/// </summary>
		public override void ShutdownAfterError()
			=> E__Supper__APawn_ShutdownAfterError(this);
		
		
		/// <summary>
		/// Called after PostLoad to create UObject cluster
		/// </summary>
		public override void CreateCluster()
			=> E__Supper__APawn_CreateCluster(this);
		
		
		/// <summary>
		/// Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it.
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E__Supper__APawn_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(ManagePawn self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManagePawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePawn>(PtrDesc);
		}}}
