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
	public partial class ManageCheatManager : UCheatManager
	{
		public ManageCheatManager(IntPtr Adress)
			: base(Adress)
		{
		}

		public override void BugIt(string screenShotDescription) { }
		
		public override void BugItGo(float x, float y, float z, float pitch, float yaw, float roll) { }
		
		
		/// <summary>
		/// <para>This will move the player and set their rotation to the passed in values. </para>
		/// <para>We have this version of the BugIt family strings can be passed in from the game ?options easily </para>
		/// </summary>
		public override void BugItGoString(string theLocation, string theRotation) { }
		
		public override void BugItStringCreator(FVector viewLocation, FRotator viewRotation, string goString, string locString) { }
		
		
		/// <summary>
		/// <para>This will move the player and set their rotation to the passed in values. </para>
		/// <para>This actually does the location / rotation setting.  Additionally it will set you as ghost as the level may have </para>
		/// <para>changed since the last time you were here.  And the bug may actually be inside of something. </para>
		/// </summary>
		public override void BugItWorker(FVector theLocation, FRotator theRotation) { }
		
		public override void ChangeSize(float f) { }
		
		
		/// <summary>
		/// <para>Damage the actor you're looking at (sourced from the player). </para>
		/// </summary>
		public override void DamageTarget(float damageAmount) { }
		
		public override void DebugCapsuleSweep() { }
		
		public override void DebugCapsuleSweepCapture() { }
		
		public override void DebugCapsuleSweepChannel(ECollisionChannel channel) { }
		
		public override void DebugCapsuleSweepClear() { }
		
		public override void DebugCapsuleSweepComplex(bool bTraceComplex) { }
		
		public override void DebugCapsuleSweepPawn() { }
		
		public override void DebugCapsuleSweepSize(float halfHeight, float radius) { }
		
		public override void DestroyAllPawnsExceptTarget() { }
		
		
		/// <summary>
		/// <para>Destroy the actor you're looking at. </para>
		/// </summary>
		public override void DestroyTarget() { }
		
		
		/// <summary>
		/// <para>Switch controller from debug camera back to normal controller </para>
		/// </summary>
		protected override void DisableDebugCamera() { }
		
		public override void DumpChatState() { }
		
		public override void DumpOnlineSessionState() { }
		
		public override void DumpPartyState() { }
		
		public override void DumpVoiceMutingState() { }
		
		
		/// <summary>
		/// <para>Switch controller to debug camera without locking gameplay and with locking local player controller input </para>
		/// </summary>
		protected override void EnableDebugCamera() { }
		
		public override void FlushLog() { }
		
		
		/// <summary>
		/// <para>Pawn can fly. </para>
		/// </summary>
		public override void Fly() { }
		
		
		/// <summary>
		/// <para>Pause the game for Delay seconds. </para>
		/// </summary>
		public override void FreezeFrame(float delay) { }
		
		
		/// <summary>
		/// <para>Pawn no longer collides with the world, and can fly </para>
		/// </summary>
		public override void Ghost() { }
		
		
		/// <summary>
		/// <para>Invulnerability cheat. </para>
		/// </summary>
		public override void God() { }
		
		
		/// <summary>
		/// <para>Called when CheatManager is created to allow any needed initialization. </para>
		/// </summary>
		public override void InitCheatManager() { }
		
		public override void InvertMouse() { }
		
		public override void LogLoc() { }
		
		
		/// <summary>
		/// <para>Bug it log to file </para>
		/// </summary>
		public override void LogOutBugItGoToLogFile(string inScreenShotDesc, string inScreenShotPath, string inGoString, string inLocString) { }
		
		public override void OnlyLoadLevel(string packageName) { }
		
		
		/// <summary>
		/// <para>Freeze everything in the level except for players. </para>
		/// </summary>
		public override void PlayersOnly() { }
		
		public override void ServerToggleAILogging() { }
		
		
		/// <summary>
		/// <para>streaming level debugging </para>
		/// </summary>
		public override void SetLevelStreamingStatus(string packageName, bool bShouldBeLoaded, bool bShouldBeVisible) { }
		
		public override void SetMouseSensitivityToDefault() { }
		
		
		/// <summary>
		/// <para>Modify time dilation to change apparent speed of passage of time. e.g. "Slomo 0.1" makes everything move very slowly, while "Slomo 10" makes everything move very fast. </para>
		/// </summary>
		public override void Slomo(float newTimeDilation) { }
		
		public override void StreamLevelIn(string packageName) { }
		
		public override void StreamLevelOut(string packageName) { }
		
		public override void Summon(string className) { }
		
		public override void Teleport() { }
		
		public override void TestCollisionDistance() { }
		
		public override void ToggleAILogging() { }
		
		public override void ToggleDebugCamera() { }
		
		public override void ViewActor(string actorName) { }
		
		public override void ViewPlayer(string s) { }
		
		public override void ViewSelf() { }
		
		
		/// <summary>
		/// <para>Return to walking movement mode from Fly or Ghost cheat. </para>
		/// </summary>
		public override void Walk() { }
		
		public static implicit operator IntPtr(ManageCheatManager self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageCheatManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCheatManager>(PtrDesc);
		}}}
