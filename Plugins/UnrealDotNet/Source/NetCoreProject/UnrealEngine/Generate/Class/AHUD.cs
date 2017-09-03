using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageHUD
	/// <para>Base class of the heads-up display. This has a canvas and a debug canvas on which primitives can be drawn. </para>
	/// <para>It also contains a list of simple hit boxes that can be used for simple item click detection. </para>
	/// <para>A method of rendering debug text is also included. </para>
	/// <para>Provides some simple methods for rendering text, textures, rectangles and materials which can also be accessed from blueprints. </para>
	/// <para>@see UCanvas </para>
	/// <para>@see FHUDHitBox </para>
	/// <para>@see FDebugTextInfo </para>
	/// </summary>
	public  partial class AHUD : AActor
	{
		public AHUD(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AHUD_LastHUDRenderTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AHUD_LastHUDRenderTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_AHUD_RenderDelta_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_AHUD_RenderDelta_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_AddHitBox(IntPtr Self, IntPtr Position, IntPtr Size, string InName, bool bConsumesInput, int Priority);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_AddPostRenderedActor(IntPtr Self, IntPtr A);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AHUD_AnyCurrentHitBoxHits(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_Deproject(IntPtr Self, float ScreenX, float ScreenY, IntPtr WorldPosition, IntPtr WorldDirection);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_DrawActorOverlays(IntPtr Self, IntPtr Viewpoint, IntPtr ViewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_DrawDebugTextList(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_DrawHUD(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_DrawSafeZoneOverlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AHUD_GetOwningPawn(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_HandleBugScreenShot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AHUD_IsCanvasValid_WarnIfNot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_NotifyBindPostProcessEffects(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_NotifyHitBoxBeginCursorOver(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_NotifyHitBoxClick(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_NotifyHitBoxEndCursorOver(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_NotifyHitBoxRelease(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_OnLostFocusPause(IntPtr Self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_PostRender(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AHUD_Project(IntPtr Self, IntPtr Location);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ReceiveDrawHUD(IntPtr Self, int SizeX, int SizeY);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ReceiveHitBoxBeginCursorOver(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ReceiveHitBoxClick(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ReceiveHitBoxEndCursorOver(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ReceiveHitBoxRelease(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_RemoveAllDebugStrings(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_RemoveDebugText(IntPtr Self, IntPtr SrcActor, bool bLeaveDurationText);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_RemovePostRenderedActor(IntPtr Self, IntPtr A);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ShowDebug(IntPtr Self, string DebugType);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ShowDebugInfo(IntPtr Self, float YL, float YPos);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ShowDebugToggleSubCategory(IntPtr Self, string Category);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ShowHUD(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Used to calculate delta time between HUD rendering. </para>
		/// </summary>
		public float LastHUDRenderTime
		{
			get => E_PROP_AHUD_LastHUDRenderTime_GET(NativePointer);
			set => E_PROP_AHUD_LastHUDRenderTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Time since last HUD render. </para>
		/// </summary>
		public float RenderDelta
		{
			get => E_PROP_AHUD_RenderDelta_GET(NativePointer);
			set => E_PROP_AHUD_RenderDelta_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add a hitbox to the hud </para>
		/// <param name="Position">Coordinates of the top left of the hit box. </param>
		/// <param name="Size">Size of the hit box. </param>
		/// <param name="Name">Name of the hit box. </param>
		/// <param name="bConsumesInput">Whether click processing should continue if this hit box is clicked. </param>
		/// <param name="Priority">The priority of the box used for layering. Larger values are considered first.  Equal values are considered in the order they were added. </param>
		/// </summary>
		public void AddHitBox(FVector2D Position, FVector2D Size, string InName, bool bConsumesInput, int Priority = 0)
			=> E_AHUD_AddHitBox(this, Position, Size, InName, bConsumesInput, Priority);
		
		
		/// <summary>
		/// <para>add an actor to the PostRenderedActors array </para>
		/// </summary>
		public virtual void AddPostRenderedActor(AActor A)
			=> E_AHUD_AddPostRenderedActor(this, A);
		
		
		/// <summary>
		/// <para>Have any hitboxes been hit this frame. </para>
		/// </summary>
		public bool AnyCurrentHitBoxHits()
			=> E_AHUD_AnyCurrentHitBoxHits(this);
		
		
		/// <summary>
		/// <para>Transforms a 2D screen location into a 3D location and direction </para>
		/// </summary>
		public void Deproject(float ScreenX, float ScreenY, FVector WorldPosition, FVector WorldDirection)
			=> E_AHUD_Deproject(this, ScreenX, ScreenY, WorldPosition, WorldDirection);
		
		
		/// <summary>
		/// <para>draw overlays for actors that were rendered this tick and have added themselves to the PostRenderedActors array </para>
		/// </summary>
		public virtual void DrawActorOverlays(FVector Viewpoint, FRotator ViewRotation)
			=> E_AHUD_DrawActorOverlays(this, Viewpoint, ViewRotation);
		
		
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
		/// <para>Returns the Pawn for this HUD's player. </para>
		/// </summary>
		protected APawn GetOwningPawn()
			=> E_AHUD_GetOwningPawn(this);
		
		
		/// <summary>
		/// <para>Gives the HUD a chance to display project-specific data when taking a "bug" screen shot. </para>
		/// </summary>
		public virtual void HandleBugScreenShot()
			=> E_AHUD_HandleBugScreenShot(this);
		
		protected bool IsCanvasValid_WarnIfNot()
			=> E_AHUD_IsCanvasValid_WarnIfNot(this);
		
		
		/// <summary>
		/// <para>Called in PostInitializeComponents or postprocessing chain has changed (happens because of the worldproperties can define it's own chain and this one is set late). </para>
		/// </summary>
		public virtual void NotifyBindPostProcessEffects()
			=> E_AHUD_NotifyBindPostProcessEffects(this);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is moused over. </para>
		/// </summary>
		public virtual void NotifyHitBoxBeginCursorOver(string BoxName)
			=> E_AHUD_NotifyHitBoxBeginCursorOver(this, BoxName);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is clicked on. Provides the name associated with that box. </para>
		/// </summary>
		public virtual void NotifyHitBoxClick(string BoxName)
			=> E_AHUD_NotifyHitBoxClick(this, BoxName);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box no longer has the mouse over it. </para>
		/// </summary>
		public virtual void NotifyHitBoxEndCursorOver(string BoxName)
			=> E_AHUD_NotifyHitBoxEndCursorOver(this, BoxName);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is unclicked. Provides the name associated with that box. </para>
		/// </summary>
		public virtual void NotifyHitBoxRelease(string BoxName)
			=> E_AHUD_NotifyHitBoxRelease(this, BoxName);
		
		
		/// <summary>
		/// <para>Pauses or unpauses the game due to main window's focus being lost. </para>
		/// <param name="Enable">- tells whether to enable or disable the pause state </param>
		/// </summary>
		public virtual void OnLostFocusPause(bool bEnable)
			=> E_AHUD_OnLostFocusPause(this, bEnable);
		
		
		/// <summary>
		/// <para>PostRender is the main draw loop. </para>
		/// </summary>
		public virtual void PostRender()
			=> E_AHUD_PostRender(this);
		
		
		/// <summary>
		/// <para>Transforms a 3D world-space vector into 2D screen coordinates </para>
		/// </summary>
		public FVector Project(FVector Location)
			=> E_AHUD_Project(this, Location);
		
		public void ReceiveDrawHUD(int SizeX, int SizeY)
			=> E_AHUD_ReceiveDrawHUD(this, SizeX, SizeY);
		
		
		/// <summary>
		/// <para>Called when a hit box is moused over. </para>
		/// </summary>
		public void HitBoxBeginCursorOver(string BoxName)
			=> E_AHUD_ReceiveHitBoxBeginCursorOver(this, BoxName);
		
		
		/// <summary>
		/// <para>Called when a hit box is clicked on. Provides the name associated with that box. </para>
		/// </summary>
		public void HitBoxClicked(string BoxName)
			=> E_AHUD_ReceiveHitBoxClick(this, BoxName);
		
		
		/// <summary>
		/// <para>Called when a hit box no longer has the mouse over it. </para>
		/// </summary>
		public void HitBoxEndCursorOver(string BoxName)
			=> E_AHUD_ReceiveHitBoxEndCursorOver(this, BoxName);
		
		
		/// <summary>
		/// <para>Called when a hit box is unclicked. Provides the name associated with that box. </para>
		/// </summary>
		public void HitBoxReleased(string BoxName)
			=> E_AHUD_ReceiveHitBoxRelease(this, BoxName);
		
		public void RemoveAllDebugStrings()
			=> E_AHUD_RemoveAllDebugStrings(this);
		
		public void RemoveDebugText(AActor SrcActor, bool bLeaveDurationText = false)
			=> E_AHUD_RemoveDebugText(this, SrcActor, bLeaveDurationText);
		
		
		/// <summary>
		/// <para>remove an actor from the PostRenderedActors array </para>
		/// </summary>
		public virtual void RemovePostRenderedActor(AActor A)
			=> E_AHUD_RemovePostRenderedActor(this, A);
		
		public virtual void ShowDebug(string DebugType)
			=> E_AHUD_ShowDebug(this, DebugType);
		
		
		/// <summary>
		/// <para>Entry point for basic debug rendering on the HUD.  Activated and controlled via the "showdebug" console command. </para>
		/// <para>Can be overridden to display custom debug per-game. </para>
		/// </summary>
		public virtual void ShowDebugInfo(float YL, float YPos)
			=> E_AHUD_ShowDebugInfo(this, YL, YPos);
		
		public void ShowDebugToggleSubCategory(string Category)
			=> E_AHUD_ShowDebugToggleSubCategory(this, Category);
		
		public virtual void ShowHUD()
			=> E_AHUD_ShowHUD(this);
		
		#endregion
		
		public static implicit operator IntPtr(AHUD Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator AHUD(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as AHUD ?? new AHUD(Adress);
		}}}
