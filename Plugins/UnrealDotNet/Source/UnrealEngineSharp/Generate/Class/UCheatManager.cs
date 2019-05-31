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
	public  partial class UCheatManager : UObject
	{
		public UCheatManager(IntPtr adress)
			: base(adress)
		{
		}

		public UCheatManager(UObject Parent = null, string Name = "CheatManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCheatManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UCheatManager_bDebugCapsuleSweepPawn_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCheatManager_CurrentTraceIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCheatManager_CurrentTraceIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCheatManager_CurrentTracePawnIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCheatManager_CurrentTracePawnIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCheatManager_DebugCapsuleHalfHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCheatManager_DebugCapsuleHalfHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCheatManager_DebugCapsuleRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCheatManager_DebugCapsuleRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCheatManager_DebugTraceDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCheatManager_DebugTraceDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCheatManager_DebugTraceDrawNormalLength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCheatManager_DebugTraceDrawNormalLength_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCheatManager(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_AddCapsuleSweepDebugInfo(IntPtr self, IntPtr lineTraceStart, IntPtr lineTraceEnd, IntPtr hitImpactLocation, IntPtr hitNormal, IntPtr hitImpactNormal, IntPtr hitLocation, float capsuleHalfheight, float capsuleRadius, bool bTracePawn, bool bInsideOfObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_BugIt(IntPtr self, string screenShotDescription);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_BugItGo(IntPtr self, float x, float y, float z, float pitch, float yaw, float roll);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_BugItGoString(IntPtr self, string theLocation, string theRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_BugItStringCreator(IntPtr self, IntPtr viewLocation, IntPtr viewRotation, string goString, string locString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_BugItWorker(IntPtr self, IntPtr theLocation, IntPtr theRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ChangeSize(IntPtr self, float f);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_CheatScript(IntPtr self, string scriptName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DamageTarget(IntPtr self, float damageAmount);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DebugCapsuleSweep(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DebugCapsuleSweepCapture(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DebugCapsuleSweepChannel(IntPtr self, byte channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DebugCapsuleSweepClear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DebugCapsuleSweepComplex(IntPtr self, bool bTraceComplex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DebugCapsuleSweepPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DebugCapsuleSweepSize(IntPtr self, float halfHeight, float radius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DestroyAllPawnsExceptTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DestroyServerStatReplicator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DestroyTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DisableDebugCamera(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DumpChatState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DumpOnlineSessionState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DumpPartyState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DumpVoiceMutingState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_EnableDebugCamera(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_FlushLog(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_Fly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_FreezeFrame(IntPtr self, float delay);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UCheatManager_GetTarget(IntPtr self, IntPtr playerController, IntPtr outHit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_Ghost(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_God(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_InitCheatManager(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_InvertMouse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCheatManager_IsDebugCapsuleSweepPawnEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_LogLoc(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_LogOutBugItGoToLogFile(IntPtr self, string inScreenShotDesc, string inScreenShotPath, string inGoString, string inLocString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_OnlyLoadLevel(IntPtr self, string packageName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_PlayersOnly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ReceiveEndPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ReceiveInitCheatManager(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ServerToggleAILogging(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_SetLevelStreamingStatus(IntPtr self, string packageName, bool bShouldBeLoaded, bool bShouldBeVisible);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_SetMouseSensitivityToDefault(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_SetWorldOrigin(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_Slomo(IntPtr self, float newTimeDilation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_SpawnServerStatReplicator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_StreamLevelIn(IntPtr self, string packageName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_StreamLevelOut(IntPtr self, string packageName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_Summon(IntPtr self, string className);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_Teleport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_TestCollisionDistance(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_TickCollisionDebug(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ToggleAILogging(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ToggleDebugCamera(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ToggleServerStatReplicatorClientOverwrite(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ToggleServerStatReplicatorUpdateStatNet(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_UpdateSafeArea(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ViewActor(IntPtr self, string actorName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ViewPlayer(IntPtr self, string s);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_ViewSelf(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_Walk(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// If we should should perform a debug capsule trace for pawns and draw results. Toggled with DebugCapsuleSweepPawn()
		/// </summary>
		public static bool bDebugCapsuleSweepPawn
		{
			get => E_PROP_UCheatManager_bDebugCapsuleSweepPawn_GET();
		}

		
		/// <summary>
		/// Index of the array for current trace to overwrite.  Whenever you capture, this index will be increased
		/// </summary>
		public int CurrentTraceIndex
		{
			get => E_PROP_UCheatManager_CurrentTraceIndex_GET(NativePointer);
			set => E_PROP_UCheatManager_CurrentTraceIndex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Index of the array for current trace to overwrite.  Whenever you capture, this index will be increased
		/// </summary>
		public int CurrentTracePawnIndex
		{
			get => E_PROP_UCheatManager_CurrentTracePawnIndex_GET(NativePointer);
			set => E_PROP_UCheatManager_CurrentTracePawnIndex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Half distance between debug capsule sphere ends. Total heigh of capsule is 2*(this + DebugCapsuleRadius).
		/// </summary>
		public float DebugCapsuleHalfHeight
		{
			get => E_PROP_UCheatManager_DebugCapsuleHalfHeight_GET(NativePointer);
			set => E_PROP_UCheatManager_DebugCapsuleHalfHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Radius of debug capsule
		/// </summary>
		public float DebugCapsuleRadius
		{
			get => E_PROP_UCheatManager_DebugCapsuleRadius_GET(NativePointer);
			set => E_PROP_UCheatManager_DebugCapsuleRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How far debug trace should go out from player viewpoint
		/// </summary>
		public float DebugTraceDistance
		{
			get => E_PROP_UCheatManager_DebugTraceDistance_GET(NativePointer);
			set => E_PROP_UCheatManager_DebugTraceDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How long to draw the normal result
		/// </summary>
		public float DebugTraceDrawNormalLength
		{
			get => E_PROP_UCheatManager_DebugTraceDrawNormalLength_GET(NativePointer);
			set => E_PROP_UCheatManager_DebugTraceDrawNormalLength_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Add Debug Trace info into current index - used when DebugCapsuleSweepPawn is on
		/// </summary>
		public void AddCapsuleSweepDebugInfo(FVector lineTraceStart, FVector lineTraceEnd, FVector hitImpactLocation, FVector hitNormal, FVector hitImpactNormal, FVector hitLocation, float capsuleHalfheight, float capsuleRadius, bool bTracePawn, bool bInsideOfObject)
			=> E_UCheatManager_AddCapsuleSweepDebugInfo(this, lineTraceStart, lineTraceEnd, hitImpactLocation, hitNormal, hitImpactNormal, hitLocation, capsuleHalfheight, capsuleRadius, bTracePawn, bInsideOfObject);
		
		public virtual void BugIt(string screenShotDescription)
			=> E_UCheatManager_BugIt(this, screenShotDescription);
		
		public virtual void BugItGo(float x, float y, float z, float pitch, float yaw, float roll)
			=> E_UCheatManager_BugItGo(this, x, y, z, pitch, yaw, roll);
		
		
		/// <summary>
		/// This will move the player and set their rotation to the passed in values.
		/// <para>We have this version of the BugIt family strings can be passed in from the game ?options easily </para>
		/// </summary>
		public virtual void BugItGoString(string theLocation, string theRotation)
			=> E_UCheatManager_BugItGoString(this, theLocation, theRotation);
		
		public virtual void BugItStringCreator(FVector viewLocation, FRotator viewRotation, string goString, string locString)
			=> E_UCheatManager_BugItStringCreator(this, viewLocation, viewRotation, goString, locString);
		
		
		/// <summary>
		/// This will move the player and set their rotation to the passed in values.
		/// <para>This actually does the location / rotation setting.  Additionally it will set you as ghost as the level may have </para>
		/// changed since the last time you were here.  And the bug may actually be inside of something.
		/// </summary>
		public virtual void BugItWorker(FVector theLocation, FRotator theRotation)
			=> E_UCheatManager_BugItWorker(this, theLocation, theRotation);
		
		public virtual void ChangeSize(float f)
			=> E_UCheatManager_ChangeSize(this, f);
		
		public void CheatScript(string scriptName)
			=> E_UCheatManager_CheatScript(this, scriptName);
		
		
		/// <summary>
		/// Damage the actor you're looking at (sourced from the player).
		/// </summary>
		public virtual void DamageTarget(float damageAmount)
			=> E_UCheatManager_DamageTarget(this, damageAmount);
		
		public virtual void DebugCapsuleSweep()
			=> E_UCheatManager_DebugCapsuleSweep(this);
		
		public virtual void DebugCapsuleSweepCapture()
			=> E_UCheatManager_DebugCapsuleSweepCapture(this);
		
		public virtual void DebugCapsuleSweepChannel(ECollisionChannel channel)
			=> E_UCheatManager_DebugCapsuleSweepChannel(this, (byte)channel);
		
		public virtual void DebugCapsuleSweepClear()
			=> E_UCheatManager_DebugCapsuleSweepClear(this);
		
		public virtual void DebugCapsuleSweepComplex(bool bTraceComplex)
			=> E_UCheatManager_DebugCapsuleSweepComplex(this, bTraceComplex);
		
		public virtual void DebugCapsuleSweepPawn()
			=> E_UCheatManager_DebugCapsuleSweepPawn(this);
		
		public virtual void DebugCapsuleSweepSize(float halfHeight, float radius)
			=> E_UCheatManager_DebugCapsuleSweepSize(this, halfHeight, radius);
		
		public virtual void DestroyAllPawnsExceptTarget()
			=> E_UCheatManager_DestroyAllPawnsExceptTarget(this);
		
		public void DestroyServerStatReplicator()
			=> E_UCheatManager_DestroyServerStatReplicator(this);
		
		
		/// <summary>
		/// Destroy the actor you're looking at.
		/// </summary>
		public virtual void DestroyTarget()
			=> E_UCheatManager_DestroyTarget(this);
		
		
		/// <summary>
		/// Switch controller from debug camera back to normal controller
		/// </summary>
		protected virtual void DisableDebugCamera()
			=> E_UCheatManager_DisableDebugCamera(this);
		
		public virtual void DumpChatState()
			=> E_UCheatManager_DumpChatState(this);
		
		public virtual void DumpOnlineSessionState()
			=> E_UCheatManager_DumpOnlineSessionState(this);
		
		public virtual void DumpPartyState()
			=> E_UCheatManager_DumpPartyState(this);
		
		public virtual void DumpVoiceMutingState()
			=> E_UCheatManager_DumpVoiceMutingState(this);
		
		
		/// <summary>
		/// Switch controller to debug camera without locking gameplay and with locking local player controller input
		/// </summary>
		protected virtual void EnableDebugCamera()
			=> E_UCheatManager_EnableDebugCamera(this);
		
		public virtual void FlushLog()
			=> E_UCheatManager_FlushLog(this);
		
		
		/// <summary>
		/// Pawn can fly.
		/// </summary>
		public virtual void Fly()
			=> E_UCheatManager_Fly(this);
		
		
		/// <summary>
		/// Pause the game for Delay seconds.
		/// </summary>
		public virtual void FreezeFrame(float delay)
			=> E_UCheatManager_FreezeFrame(this, delay);
		
		
		/// <summary>
		/// Retrieve the given PlayerContoller's current "target" AActor.
		/// </summary>
		protected virtual AActor GetTarget(APlayerController playerController, FHitResult outHit)
			=> E_UCheatManager_GetTarget(this, playerController, outHit);
		
		
		/// <summary>
		/// Pawn no longer collides with the world, and can fly
		/// </summary>
		public virtual void Ghost()
			=> E_UCheatManager_Ghost(this);
		
		
		/// <summary>
		/// Invulnerability cheat.
		/// </summary>
		public virtual void God()
			=> E_UCheatManager_God(this);
		
		
		/// <summary>
		/// Called when CheatManager is created to allow any needed initialization.
		/// </summary>
		public virtual void InitCheatManager()
			=> E_UCheatManager_InitCheatManager(this);
		
		public virtual void InvertMouse()
			=> E_UCheatManager_InvertMouse(this);
		
		
		/// <summary>
		/// Return true if debug sweeps are enabled for pawns.
		/// </summary>
		public bool IsDebugCapsuleSweepPawnEnabled()
			=> E_UCheatManager_IsDebugCapsuleSweepPawnEnabled(this);
		
		public virtual void LogLoc()
			=> E_UCheatManager_LogLoc(this);
		
		
		/// <summary>
		/// Bug it log to file
		/// </summary>
		public virtual void LogOutBugItGoToLogFile(string inScreenShotDesc, string inScreenShotPath, string inGoString, string inLocString)
			=> E_UCheatManager_LogOutBugItGoToLogFile(this, inScreenShotDesc, inScreenShotPath, inGoString, inLocString);
		
		public virtual void OnlyLoadLevel(string packageName)
			=> E_UCheatManager_OnlyLoadLevel(this, packageName);
		
		
		/// <summary>
		/// Freeze everything in the level except for players.
		/// </summary>
		public virtual void PlayersOnly()
			=> E_UCheatManager_PlayersOnly(this);
		
		
		/// <summary>
		/// This is the End Play event for the CheatManager
		/// </summary>
		public void Shutdown()
			=> E_UCheatManager_ReceiveEndPlay(this);
		
		
		/// <summary>
		/// BP implementable event for when CheatManager is created to allow any needed initialization.
		/// </summary>
		public void ReceiveInitCheatManager()
			=> E_UCheatManager_ReceiveInitCheatManager(this);
		
		public virtual void ServerToggleAILogging()
			=> E_UCheatManager_ServerToggleAILogging(this);
		
		
		/// <summary>
		/// streaming level debugging
		/// </summary>
		public virtual void SetLevelStreamingStatus(string packageName, bool bShouldBeLoaded, bool bShouldBeVisible)
			=> E_UCheatManager_SetLevelStreamingStatus(this, packageName, bShouldBeLoaded, bShouldBeVisible);
		
		public virtual void SetMouseSensitivityToDefault()
			=> E_UCheatManager_SetMouseSensitivityToDefault(this);
		
		public void SetWorldOrigin()
			=> E_UCheatManager_SetWorldOrigin(this);
		
		
		/// <summary>
		/// Modify time dilation to change apparent speed of passage of time. e.g. "Slomo 0.1" makes everything move very slowly, while "Slomo 10" makes everything move very fast.
		/// </summary>
		public virtual void Slomo(float newTimeDilation)
			=> E_UCheatManager_Slomo(this, newTimeDilation);
		
		public void SpawnServerStatReplicator()
			=> E_UCheatManager_SpawnServerStatReplicator(this);
		
		public virtual void StreamLevelIn(string packageName)
			=> E_UCheatManager_StreamLevelIn(this, packageName);
		
		public virtual void StreamLevelOut(string packageName)
			=> E_UCheatManager_StreamLevelOut(this, packageName);
		
		public virtual void Summon(string className)
			=> E_UCheatManager_Summon(this, className);
		
		public virtual void Teleport()
			=> E_UCheatManager_Teleport(this);
		
		public virtual void TestCollisionDistance()
			=> E_UCheatManager_TestCollisionDistance(this);
		
		
		/// <summary>
		/// Do any trace debugging that is currently enabled
		/// </summary>
		public void TickCollisionDebug()
			=> E_UCheatManager_TickCollisionDebug(this);
		
		public virtual void ToggleAILogging()
			=> E_UCheatManager_ToggleAILogging(this);
		
		public virtual void ToggleDebugCamera()
			=> E_UCheatManager_ToggleDebugCamera(this);
		
		public void ToggleServerStatReplicatorClientOverwrite()
			=> E_UCheatManager_ToggleServerStatReplicatorClientOverwrite(this);
		
		public void ToggleServerStatReplicatorUpdateStatNet()
			=> E_UCheatManager_ToggleServerStatReplicatorUpdateStatNet(this);
		
		public void UpdateSafeArea()
			=> E_UCheatManager_UpdateSafeArea(this);
		
		public virtual void ViewActor(string actorName)
			=> E_UCheatManager_ViewActor(this, actorName);
		
		public virtual void ViewPlayer(string s)
			=> E_UCheatManager_ViewPlayer(this, s);
		
		public virtual void ViewSelf()
			=> E_UCheatManager_ViewSelf(this);
		
		
		/// <summary>
		/// Return to walking movement mode from Fly or Ghost cheat.
		/// </summary>
		public virtual void Walk()
			=> E_UCheatManager_Walk(this);
		
		#endregion
		
		public static implicit operator IntPtr(UCheatManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCheatManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCheatManager>(PtrDesc);
		}}}
