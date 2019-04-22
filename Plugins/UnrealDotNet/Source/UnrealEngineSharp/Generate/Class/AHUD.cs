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
	public  partial class AHUD : AActor
	{
		public AHUD(IntPtr Adress)
			: base(Adress)
		{
		}

		public AHUD(UObject Parent = null, string Name = "HUD")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AHUD(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_AHUD_DebugDisplay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AHUD_DebugDisplay_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AHUD_LastHUDRenderTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AHUD_LastHUDRenderTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_AHUD_PostRenderedActors_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AHUD_PostRenderedActors_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AHUD_RenderDelta_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AHUD_RenderDelta_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_AHUD_ToggledDebugCategories_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AHUD_ToggledDebugCategories_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AHUD(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_AddActorToDebugList(IntPtr self, IntPtr inActor, IntPtr inOutList, IntPtr inWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_AddComponentOwnerToDebugList(IntPtr self, IntPtr inComponent, IntPtr inOutList, IntPtr inWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_AddHitBox(IntPtr self, IntPtr position, IntPtr size, string inName, bool bConsumesInput, int priority);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_AddPostRenderedActor(IntPtr self, IntPtr a);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_AnyCurrentHitBoxHits(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_Deproject(IntPtr self, float screenX, float screenY, IntPtr worldPosition, IntPtr worldDirection);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_DrawActorOverlays(IntPtr self, IntPtr viewpoint, IntPtr viewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_DrawDebugTextList(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_DrawHUD(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_DrawSafeZoneOverlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AHUD_GetCurrentDebugTargetActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_GetDebugActorList(IntPtr self, IntPtr inOutList);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AHUD_GetOwningPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_HandleBugScreenShot(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsCanvasValid_WarnIfNot(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NextDebugTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyBindPostProcessEffects(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyHitBoxBeginCursorOver(IntPtr self, string boxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyHitBoxClick(IntPtr self, string boxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyHitBoxEndCursorOver(IntPtr self, string boxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyHitBoxRelease(IntPtr self, string boxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnLostFocusPause(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostRender(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PreviousDebugTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AHUD_Project(IntPtr self, IntPtr location);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveDrawHUD(IntPtr self, int sizeX, int sizeY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveHitBoxBeginCursorOver(IntPtr self, string boxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveHitBoxClick(IntPtr self, string boxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveHitBoxEndCursorOver(IntPtr self, string boxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveHitBoxRelease(IntPtr self, string boxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RemoveAllDebugStrings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RemoveDebugText(IntPtr self, IntPtr srcActor, bool bLeaveDurationText);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RemovePostRenderedActor(IntPtr self, IntPtr a);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_ShouldDisplayDebug(IntPtr self, string debugType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ShowDebug(IntPtr self, string debugType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ShowDebugInfo(IntPtr self, float yL, float yPos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ShowDebugToggleSubCategory(IntPtr self, string category);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ShowHUD(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_UpdateAndDispatchHitBoxClickEvents(IntPtr self, IntPtr clickLocation, byte inEventType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_UpdateHitBoxCandidates(IntPtr self, IntPtr inContactPoints);
		
		#endregion
		
		#region Property
		public TArray<string> DebugDisplay
		{
			get => E_PROP_AHUD_DebugDisplay_GET(NativePointer);
			set => E_PROP_AHUD_DebugDisplay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Used to calculate delta time between HUD rendering. </para>
		/// </summary>
		public float LastHUDRenderTime
		{
			get => E_PROP_AHUD_LastHUDRenderTime_GET(NativePointer);
			set => E_PROP_AHUD_LastHUDRenderTime_SET(NativePointer, value);
		}

		public TArray<AActor> PostRenderedActors
		{
			get => E_PROP_AHUD_PostRenderedActors_GET(NativePointer);
			set => E_PROP_AHUD_PostRenderedActors_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Time since last HUD render. </para>
		/// </summary>
		public float RenderDelta
		{
			get => E_PROP_AHUD_RenderDelta_GET(NativePointer);
			set => E_PROP_AHUD_RenderDelta_SET(NativePointer, value);
		}

		public TArray<string> ToggledDebugCategories
		{
			get => E_PROP_AHUD_ToggledDebugCategories_GET(NativePointer);
			set => E_PROP_AHUD_ToggledDebugCategories_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Utility function to add an actor to our consideration list for 'showdebug' </para>
		/// <para>Only consider visible, non destroyed Actors in the same world the player is in. </para>
		/// </summary>
		public void AddActorToDebugList(AActor inActor, TArray<AActor> inOutList, UWorld inWorld)
			=> E_AHUD_AddActorToDebugList(this, inActor, inOutList, inWorld);
		
		
		/// <summary>
		/// <para>Utility function to add a component's owner to our consideration list for 'showdebug' </para>
		/// </summary>
		public void AddComponentOwnerToDebugList(UActorComponent inComponent, TArray<AActor> inOutList, UWorld inWorld)
			=> E_AHUD_AddComponentOwnerToDebugList(this, inComponent, inOutList, inWorld);
		
		
		/// <summary>
		/// <para>Add a hitbox to the hud </para>
		/// <param name="Position">Coordinates of the top left of the hit box. </param>
		/// <param name="Size">Size of the hit box. </param>
		/// <param name="Name">Name of the hit box. </param>
		/// <param name="bConsumesInput">Whether click processing should continue if this hit box is clicked. </param>
		/// <param name="Priority">The priority of the box used for layering. Larger values are considered first.  Equal values are considered in the order they were added. </param>
		/// </summary>
		public void AddHitBox(FVector2D position, FVector2D size, string inName, bool bConsumesInput, int priority = 0)
			=> E_AHUD_AddHitBox(this, position, size, inName, bConsumesInput, priority);
		
		
		/// <summary>
		/// <para>add an actor to the PostRenderedActors array </para>
		/// </summary>
		public virtual void AddPostRenderedActor(AActor a)
			=> E_AHUD_AddPostRenderedActor(this, a);
		
		
		/// <summary>
		/// <para>Have any hitboxes been hit this frame. </para>
		/// </summary>
		public bool AnyCurrentHitBoxHits()
			=> E_AHUD_AnyCurrentHitBoxHits(this);
		
		
		/// <summary>
		/// <para>Transforms a 2D screen location into a 3D location and direction </para>
		/// </summary>
		public void Deproject(float screenX, float screenY, FVector worldPosition, FVector worldDirection)
			=> E_AHUD_Deproject(this, screenX, screenY, worldPosition, worldDirection);
		
		
		/// <summary>
		/// <para>draw overlays for actors that were rendered this tick and have added themselves to the PostRenderedActors array </para>
		/// </summary>
		public virtual void DrawActorOverlays(FVector viewpoint, FRotator viewRotation)
			=> E_AHUD_DrawActorOverlays(this, viewpoint, viewRotation);
		
		
		/// <summary>
		/// <para>Iterate through list of debug text and draw it over the associated actors in world space. </para>
		/// <para>Also handles culling null entries, and reducing the duration for timed debug text. </para>
		/// </summary>
		public void DrawDebugTextList()
			=> E_AHUD_DrawDebugTextList(this);
		
		
		/// <summary>
		/// <para>The Main Draw loop for the hud.  Gets called before any messaging.  Should be subclassed </para>
		/// </summary>
		public virtual void DrawHUD()
			=> E_AHUD_DrawHUD(this);
		
		
		/// <summary>
		/// <para>Draw the safe zone debugging overlay when enabled </para>
		/// </summary>
		public virtual void DrawSafeZoneOverlay()
			=> E_AHUD_DrawSafeZoneOverlay(this);
		
		
		/// <summary>
		/// <para>Get Target to view 'showdebug' on </para>
		/// </summary>
		public virtual AActor GetCurrentDebugTargetActor()
			=> E_AHUD_GetCurrentDebugTargetActor(this);
		
		
		/// <summary>
		/// <para>Get list of considered targets for 'showdebug' </para>
		/// <para>This list is built contextually based on which 'showdebug' flags have been enabled. </para>
		/// </summary>
		public virtual void GetDebugActorList(TArray<AActor> inOutList)
			=> E_AHUD_GetDebugActorList(this, inOutList);
		
		
		/// <summary>
		/// <para>Returns the Pawn for this HUD's player. </para>
		/// </summary>
		public APawn GetOwningPawn()
			=> E_AHUD_GetOwningPawn(this);
		
		
		/// <summary>
		/// <para>Gives the HUD a chance to display project-specific data when taking a "bug" screen shot. </para>
		/// </summary>
		public virtual void HandleBugScreenShot()
			=> E_AHUD_HandleBugScreenShot(this);
		
		protected bool IsCanvasValid_WarnIfNot()
			=> E_AHUD_IsCanvasValid_WarnIfNot(this);
		
		public virtual void NextDebugTarget()
			=> E_AHUD_NextDebugTarget(this);
		
		
		/// <summary>
		/// <para>Called in PostInitializeComponents or postprocessing chain has changed (happens because of the worldproperties can define it's own chain and this one is set late). </para>
		/// </summary>
		public virtual void NotifyBindPostProcessEffects()
			=> E_AHUD_NotifyBindPostProcessEffects(this);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is moused over. </para>
		/// </summary>
		public virtual void NotifyHitBoxBeginCursorOver(string boxName)
			=> E_AHUD_NotifyHitBoxBeginCursorOver(this, boxName);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is clicked on. Provides the name associated with that box. </para>
		/// </summary>
		public virtual void NotifyHitBoxClick(string boxName)
			=> E_AHUD_NotifyHitBoxClick(this, boxName);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box no longer has the mouse over it. </para>
		/// </summary>
		public virtual void NotifyHitBoxEndCursorOver(string boxName)
			=> E_AHUD_NotifyHitBoxEndCursorOver(this, boxName);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is unclicked. Provides the name associated with that box. </para>
		/// </summary>
		public virtual void NotifyHitBoxRelease(string boxName)
			=> E_AHUD_NotifyHitBoxRelease(this, boxName);
		
		
		/// <summary>
		/// <para>Pauses or unpauses the game due to main window's focus being lost. </para>
		/// <param name="Enable">tells whether to enable or disable the pause state </param>
		/// </summary>
		public virtual void OnLostFocusPause(bool bEnable)
			=> E_AHUD_OnLostFocusPause(this, bEnable);
		
		
		/// <summary>
		/// <para>PostRender is the main draw loop. </para>
		/// </summary>
		public virtual void PostRender()
			=> E_AHUD_PostRender(this);
		
		public virtual void PreviousDebugTarget()
			=> E_AHUD_PreviousDebugTarget(this);
		
		
		/// <summary>
		/// <para>Transforms a 3D world-space vector into 2D screen coordinates </para>
		/// </summary>
		public FVector Project(FVector location)
			=> E_AHUD_Project(this, location);
		
		public void ReceiveDrawHUD(int sizeX, int sizeY)
			=> E_AHUD_ReceiveDrawHUD(this, sizeX, sizeY);
		
		
		/// <summary>
		/// <para>Called when a hit box is moused over. </para>
		/// </summary>
		public void HitBoxBeginCursorOver(string boxName)
			=> E_AHUD_ReceiveHitBoxBeginCursorOver(this, boxName);
		
		
		/// <summary>
		/// <para>Called when a hit box is clicked on. Provides the name associated with that box. </para>
		/// </summary>
		public void HitBoxClicked(string boxName)
			=> E_AHUD_ReceiveHitBoxClick(this, boxName);
		
		
		/// <summary>
		/// <para>Called when a hit box no longer has the mouse over it. </para>
		/// </summary>
		public void HitBoxEndCursorOver(string boxName)
			=> E_AHUD_ReceiveHitBoxEndCursorOver(this, boxName);
		
		
		/// <summary>
		/// <para>Called when a hit box is unclicked. Provides the name associated with that box. </para>
		/// </summary>
		public void HitBoxReleased(string boxName)
			=> E_AHUD_ReceiveHitBoxRelease(this, boxName);
		
		public void RemoveAllDebugStrings()
			=> E_AHUD_RemoveAllDebugStrings(this);
		
		public void RemoveDebugText(AActor srcActor, bool bLeaveDurationText = false)
			=> E_AHUD_RemoveDebugText(this, srcActor, bLeaveDurationText);
		
		
		/// <summary>
		/// <para>remove an actor from the PostRenderedActors array </para>
		/// </summary>
		public virtual void RemovePostRenderedActor(AActor a)
			=> E_AHUD_RemovePostRenderedActor(this, a);
		
		
		/// <summary>
		/// <para>check if we should be display debug information for particular types of debug messages. </para>
		/// <param name="DebugType">type of debug message. </param>
		/// <return>true if it should be displayed, false otherwise. </return>
		/// </summary>
		public virtual bool ShouldDisplayDebug(string debugType)
			=> E_AHUD_ShouldDisplayDebug(this, debugType);
		
		public virtual void ShowDebug(string debugType)
			=> E_AHUD_ShowDebug(this, debugType);
		
		
		/// <summary>
		/// <para>Entry point for basic debug rendering on the HUD.  Activated and controlled via the "showdebug" console command. </para>
		/// <para>Can be overridden to display custom debug per-game. </para>
		/// </summary>
		public virtual void ShowDebugInfo(float yL, float yPos)
			=> E_AHUD_ShowDebugInfo(this, yL, yPos);
		
		public void ShowDebugToggleSubCategory(string category)
			=> E_AHUD_ShowDebugToggleSubCategory(this, category);
		
		public virtual void ShowHUD()
			=> E_AHUD_ShowHUD(this);
		
		
		/// <summary>
		/// <para>Update the list of hitboxes and dispatch events for any hits. </para>
		/// <param name="ClickLocation">Location of the click event </param>
		/// <param name="InEventType">Type of input event that triggered the call. </param>
		/// </summary>
		public bool UpdateAndDispatchHitBoxClickEvents(FVector2D clickLocation, EInputEvent inEventType)
			=> E_AHUD_UpdateAndDispatchHitBoxClickEvents(this, clickLocation, (byte)inEventType);
		
		
		/// <summary>
		/// <para>Update a the list of hitboxes that have been hit this frame. </para>
		/// <param name="Canvas">Canvas on which to render debug boxes. </param>
		/// </summary>
		public void UpdateHitBoxCandidates(TArray<FVector2D> inContactPoints)
			=> E_AHUD_UpdateHitBoxCandidates(this, inContactPoints);
		
		#endregion
		
		public static implicit operator IntPtr(AHUD self)
		{
			return self.NativePointer;
		}

		public static implicit operator AHUD(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AHUD>(PtrDesc);
		}}}
