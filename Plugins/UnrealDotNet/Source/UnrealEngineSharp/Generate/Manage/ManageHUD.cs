using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\HUD.h:36

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
		public override void AddPostRenderedActor(AActor A) { }
		
		
		/// <summary>
		/// <para>draw overlays for actors that were rendered this tick and have added themselves to the PostRenderedActors array </para>
		/// </summary>
		public override void DrawActorOverlays(FVector Viewpoint, FRotator ViewRotation) { }
		
		
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
		public override void NotifyHitBoxBeginCursorOver(string BoxName) { }
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is clicked on. Provides the name associated with that box. </para>
		/// </summary>
		public override void NotifyHitBoxClick(string BoxName) { }
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box no longer has the mouse over it. </para>
		/// </summary>
		public override void NotifyHitBoxEndCursorOver(string BoxName) { }
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is unclicked. Provides the name associated with that box. </para>
		/// </summary>
		public override void NotifyHitBoxRelease(string BoxName) { }
		
		
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
		public override void RemovePostRenderedActor(AActor A) { }
		
		public override void ShowDebug(string DebugType) { }
		
		
		/// <summary>
		/// <para>Entry point for basic debug rendering on the HUD.  Activated and controlled via the "showdebug" console command. </para>
		/// <para>Can be overridden to display custom debug per-game. </para>
		/// </summary>
		public override void ShowDebugInfo(float YL, float YPos) { }
		
		public override void ShowHUD() { }
		
		public static implicit operator IntPtr(ManageHUD Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageHUD(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageHUD>(PtrDesc);
		}}}
