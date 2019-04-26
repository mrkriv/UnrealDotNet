// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\HUD.h:36

namespace UnrealEngine
{
	[ManageType("ManageHUD")]
	public partial class ManageHUD : AHUD
	{
		public ManageHUD(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>add an actor to the PostRenderedActors array </para>
		/// </summary>
		public override void AddPostRenderedActor(AActor a) { }
		
		
		/// <summary>
		/// <para>draw overlays for actors that were rendered this tick and have added themselves to the PostRenderedActors array </para>
		/// </summary>
		public override void DrawActorOverlays(FVector viewpoint, FRotator viewRotation) { }
		
		
		/// <summary>
		/// <para>The Main Draw loop for the hud.  Gets called before any messaging.  Should be subclassed </para>
		/// </summary>
		public override void DrawHUD() { }
		
		
		/// <summary>
		/// <para>Draw the safe zone debugging overlay when enabled </para>
		/// </summary>
		public override void DrawSafeZoneOverlay() { }
		
		
		/// <summary>
		/// <para>Gives the HUD a chance to display project-specific data when taking a "bug" screen shot. </para>
		/// </summary>
		public override void HandleBugScreenShot() { }
		
		public override void NextDebugTarget() { }
		
		
		/// <summary>
		/// <para>Called in PostInitializeComponents or postprocessing chain has changed (happens because of the worldproperties can define it's own chain and this one is set late). </para>
		/// </summary>
		public override void NotifyBindPostProcessEffects() { }
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is moused over. </para>
		/// </summary>
		public override void NotifyHitBoxBeginCursorOver(string boxName) { }
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is clicked on. Provides the name associated with that box. </para>
		/// </summary>
		public override void NotifyHitBoxClick(string boxName) { }
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box no longer has the mouse over it. </para>
		/// </summary>
		public override void NotifyHitBoxEndCursorOver(string boxName) { }
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is unclicked. Provides the name associated with that box. </para>
		/// </summary>
		public override void NotifyHitBoxRelease(string boxName) { }
		
		
		/// <summary>
		/// <para>Pauses or unpauses the game due to main window's focus being lost. </para>
		/// <param name="Enable">tells whether to enable or disable the pause state </param>
		/// </summary>
		public override void OnLostFocusPause(bool bEnable) { }
		
		
		/// <summary>
		/// <para>PostRender is the main draw loop. </para>
		/// </summary>
		public override void PostRender() { }
		
		public override void PreviousDebugTarget() { }
		
		
		/// <summary>
		/// <para>remove an actor from the PostRenderedActors array </para>
		/// </summary>
		public override void RemovePostRenderedActor(AActor a) { }
		
		public override void ShowDebug(string debugType) { }
		
		
		/// <summary>
		/// <para>Entry point for basic debug rendering on the HUD.  Activated and controlled via the "showdebug" console command. </para>
		/// <para>Can be overridden to display custom debug per-game. </para>
		/// </summary>
		public override void ShowDebugInfo(float yL, float yPos) { }
		
		public override void ShowHUD() { }
		
		public static implicit operator IntPtr(ManageHUD self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageHUD(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageHUD>(PtrDesc);
		}}}
