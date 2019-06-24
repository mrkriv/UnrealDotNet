// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

namespace UnrealEngine
{
	[ManageType("ManageCheatManager")]
	public partial class ManageCheatManager : UCheatManager, IManageWrapper
	{
		public ManageCheatManager(IntPtr adress)
			: base(adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_BugItGo(IntPtr self, float x, float y, float z, float pitch, float yaw, float roll);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_ChangeSize(IntPtr self, float f);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DamageTarget(IntPtr self, float damageAmount);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DebugCapsuleSweep(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DebugCapsuleSweepCapture(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DebugCapsuleSweepClear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DebugCapsuleSweepComplex(IntPtr self, bool bTraceComplex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DebugCapsuleSweepPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DebugCapsuleSweepSize(IntPtr self, float halfHeight, float radius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DestroyAllPawnsExceptTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DestroyTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DisableDebugCamera(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DumpChatState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DumpOnlineSessionState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DumpPartyState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_DumpVoiceMutingState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_EnableDebugCamera(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_FlushLog(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_Fly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_FreezeFrame(IntPtr self, float delay);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_Ghost(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_God(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_InitCheatManager(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_InvertMouse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_LogLoc(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PlayersOnly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_ServerToggleAILogging(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_SetMouseSensitivityToDefault(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_Slomo(IntPtr self, float newTimeDilation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_Teleport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_TestCollisionDistance(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_ToggleAILogging(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_ToggleDebugCamera(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_ViewSelf(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_Walk(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_BeginDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_FinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_MarkAsEditorOnlySubobject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PostCDOContruct(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PostEditImport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PostInitProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PostNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PostRepNotifies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PostSaveRoot(IntPtr self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PreDestroyFromReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_PreNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_ShutdownAfterError(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_CreateCluster(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UCheatManager_OnClusterMarkedAsPendingKill(IntPtr self);
		
		#endregion
		
		#region Methods
		public override void BugItGo(float x, float y, float z, float pitch, float yaw, float roll)
			=> E__Supper__UCheatManager_BugItGo(this, x, y, z, pitch, yaw, roll);
		
		public override void ChangeSize(float f)
			=> E__Supper__UCheatManager_ChangeSize(this, f);
		
		
		/// <summary>
		/// Damage the actor you're looking at (sourced from the player).
		/// </summary>
		public override void DamageTarget(float damageAmount)
			=> E__Supper__UCheatManager_DamageTarget(this, damageAmount);
		
		public override void DebugCapsuleSweep()
			=> E__Supper__UCheatManager_DebugCapsuleSweep(this);
		
		public override void DebugCapsuleSweepCapture()
			=> E__Supper__UCheatManager_DebugCapsuleSweepCapture(this);
		
		public override void DebugCapsuleSweepClear()
			=> E__Supper__UCheatManager_DebugCapsuleSweepClear(this);
		
		public override void DebugCapsuleSweepComplex(bool bTraceComplex)
			=> E__Supper__UCheatManager_DebugCapsuleSweepComplex(this, bTraceComplex);
		
		public override void DebugCapsuleSweepPawn()
			=> E__Supper__UCheatManager_DebugCapsuleSweepPawn(this);
		
		public override void DebugCapsuleSweepSize(float halfHeight, float radius)
			=> E__Supper__UCheatManager_DebugCapsuleSweepSize(this, halfHeight, radius);
		
		public override void DestroyAllPawnsExceptTarget()
			=> E__Supper__UCheatManager_DestroyAllPawnsExceptTarget(this);
		
		
		/// <summary>
		/// Destroy the actor you're looking at.
		/// </summary>
		public override void DestroyTarget()
			=> E__Supper__UCheatManager_DestroyTarget(this);
		
		
		/// <summary>
		/// Switch controller from debug camera back to normal controller
		/// </summary>
		protected override void DisableDebugCamera()
			=> E__Supper__UCheatManager_DisableDebugCamera(this);
		
		public override void DumpChatState()
			=> E__Supper__UCheatManager_DumpChatState(this);
		
		public override void DumpOnlineSessionState()
			=> E__Supper__UCheatManager_DumpOnlineSessionState(this);
		
		public override void DumpPartyState()
			=> E__Supper__UCheatManager_DumpPartyState(this);
		
		public override void DumpVoiceMutingState()
			=> E__Supper__UCheatManager_DumpVoiceMutingState(this);
		
		
		/// <summary>
		/// Switch controller to debug camera without locking gameplay and with locking local player controller input
		/// </summary>
		protected override void EnableDebugCamera()
			=> E__Supper__UCheatManager_EnableDebugCamera(this);
		
		public override void FlushLog()
			=> E__Supper__UCheatManager_FlushLog(this);
		
		
		/// <summary>
		/// Pawn can fly.
		/// </summary>
		public override void Fly()
			=> E__Supper__UCheatManager_Fly(this);
		
		
		/// <summary>
		/// Pause the game for Delay seconds.
		/// </summary>
		public override void FreezeFrame(float delay)
			=> E__Supper__UCheatManager_FreezeFrame(this, delay);
		
		
		/// <summary>
		/// Pawn no longer collides with the world, and can fly
		/// </summary>
		public override void Ghost()
			=> E__Supper__UCheatManager_Ghost(this);
		
		
		/// <summary>
		/// Invulnerability cheat.
		/// </summary>
		public override void God()
			=> E__Supper__UCheatManager_God(this);
		
		
		/// <summary>
		/// Called when CheatManager is created to allow any needed initialization.
		/// </summary>
		public override void InitCheatManager()
			=> E__Supper__UCheatManager_InitCheatManager(this);
		
		public override void InvertMouse()
			=> E__Supper__UCheatManager_InvertMouse(this);
		
		public override void LogLoc()
			=> E__Supper__UCheatManager_LogLoc(this);
		
		
		/// <summary>
		/// Freeze everything in the level except for players.
		/// </summary>
		public override void PlayersOnly()
			=> E__Supper__UCheatManager_PlayersOnly(this);
		
		public override void ServerToggleAILogging()
			=> E__Supper__UCheatManager_ServerToggleAILogging(this);
		
		public override void SetMouseSensitivityToDefault()
			=> E__Supper__UCheatManager_SetMouseSensitivityToDefault(this);
		
		
		/// <summary>
		/// Modify time dilation to change apparent speed of passage of time. e.g. "Slomo 0.1" makes everything move very slowly, while "Slomo 10" makes everything move very fast.
		/// </summary>
		public override void Slomo(float newTimeDilation)
			=> E__Supper__UCheatManager_Slomo(this, newTimeDilation);
		
		public override void Teleport()
			=> E__Supper__UCheatManager_Teleport(this);
		
		public override void TestCollisionDistance()
			=> E__Supper__UCheatManager_TestCollisionDistance(this);
		
		public override void ToggleAILogging()
			=> E__Supper__UCheatManager_ToggleAILogging(this);
		
		public override void ToggleDebugCamera()
			=> E__Supper__UCheatManager_ToggleDebugCamera(this);
		
		public override void ViewSelf()
			=> E__Supper__UCheatManager_ViewSelf(this);
		
		
		/// <summary>
		/// Return to walking movement mode from Fly or Ghost cheat.
		/// </summary>
		public override void Walk()
			=> E__Supper__UCheatManager_Walk(this);
		
		
		/// <summary>
		/// Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy()
			=> E__Supper__UCheatManager_BeginDestroy(this);
		
		
		/// <summary>
		/// Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed.
		/// <para>@warning Because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E__Supper__UCheatManager_FinishDestroy(this);
		
		
		/// <summary>
		/// Called during subobject creation to mark this component as editor only, which causes it to get stripped in packaged builds
		/// </summary>
		public override void MarkAsEditorOnlySubobject()
			=> E__Supper__UCheatManager_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E__Supper__UCheatManager_PostCDOContruct(this);
		
		
		/// <summary>
		/// Called after importing property values for this object (paste, duplicate or .t3d import)
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// are unsupported by the script serialization
		/// </summary>
		public override void PostEditImport()
			=> E__Supper__UCheatManager_PostEditImport(this);
		
		
		/// <summary>
		/// Called after the C++ constructor and after the properties have been initialized, including those loaded from config.
		/// <para>This is called before any serialization or other setup has happened. </para>
		/// </summary>
		public override void PostInitProperties()
			=> E__Supper__UCheatManager_PostInitProperties(this);
		
		
		/// <summary>
		/// Do any object-specific cleanup required immediately after loading an object.
		/// <para>This is not called for newly-created objects, and by default will always execute on the game thread. </para>
		/// </summary>
		public override void PostLoad()
			=> E__Supper__UCheatManager_PostLoad(this);
		
		
		/// <summary>
		/// Called right after receiving a bunch
		/// </summary>
		public override void PostNetReceive()
			=> E__Supper__UCheatManager_PostNetReceive(this);
		
		
		/// <summary>
		/// Called right after calling all OnRep notifies (called even when there are no notifies)
		/// </summary>
		public override void PostRepNotifies()
			=> E__Supper__UCheatManager_PostRepNotifies(this);
		
		
		/// <summary>
		/// Called from within SavePackage on the passed in base/root object.
		/// <para>This function is called after the package has been saved and can perform cleanup. </para>
		/// </summary>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up</param>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E__Supper__UCheatManager_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// Called right before being marked for destruction due to network replication
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E__Supper__UCheatManager_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// Called right before receiving a bunch
		/// </summary>
		public override void PreNetReceive()
			=> E__Supper__UCheatManager_PreNetReceive(this);
		
		
		/// <summary>
		/// After a critical error, perform any mission-critical cleanup, such as restoring the video mode orreleasing hardware resources.
		/// </summary>
		public override void ShutdownAfterError()
			=> E__Supper__UCheatManager_ShutdownAfterError(this);
		
		
		/// <summary>
		/// Called after PostLoad to create UObject cluster
		/// </summary>
		public override void CreateCluster()
			=> E__Supper__UCheatManager_CreateCluster(this);
		
		
		/// <summary>
		/// Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it.
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E__Supper__UCheatManager_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(ManageCheatManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageCheatManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCheatManager>(PtrDesc);
		}}}
