using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Base class of the heads-up display. This has a canvas and a debug canvas on which primitives can be drawn.
	/// It also contains a list of simple hit boxes that can be used for simple item click detection.
	/// A method of rendering debug text is also included.
	/// Provides some simple methods for rendering text, textures, rectangles and materials which can also be accessed from blueprints.
	/// @see UCanvas
	/// @see FHUDHitBox
	/// @see FDebugTextInfo
	/// </summary>
	public partial class AHUD : AActor
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
		private static extern void E_AHUD_ShowHUD(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ShowDebug(IntPtr Self, string DebugType);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_RemoveDebugText(IntPtr Self, IntPtr SrcActor, bool bLeaveDurationText);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ReceiveDrawHUD(IntPtr Self, int SizeX, int SizeY);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ReceiveHitBoxClick(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AHUD_Project(IntPtr Self, IntPtr Location);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_Deproject(IntPtr Self, float ScreenX, float ScreenY, IntPtr WorldPosition, IntPtr WorldDirection);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_AddHitBox(IntPtr Self, IntPtr Position, IntPtr Size, string InName, bool bConsumesInput, int Priority);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_AHUD_GetOwningPawn(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_DrawActorOverlays(IntPtr Self, IntPtr Viewpoint, IntPtr ViewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_RemovePostRenderedActor(IntPtr Self, IntPtr A);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AHUD_ShouldDisplayDebug(IntPtr Self, string DebugType);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_ShowDebugInfo(IntPtr Self, float YL, float YPos);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_AHUD_OnLostFocusPause(IntPtr Self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_AHUD_AnyCurrentHitBoxHits(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Used to calculate delta time between HUD rendering.
		/// </summary>
		public float LastHUDRenderTime
		{
			get => E_PROP_AHUD_LastHUDRenderTime_GET(NativePointer);
			set => E_PROP_AHUD_LastHUDRenderTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time since last HUD render.
		/// </summary>
		public float RenderDelta
		{
			get => E_PROP_AHUD_RenderDelta_GET(NativePointer);
			set => E_PROP_AHUD_RenderDelta_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ShowHUD()
			=> E_AHUD_ShowHUD(NativePointer);
		
		public void ShowDebug(string DebugType)
			=> E_AHUD_ShowDebug(NativePointer, DebugType);
		
		public void RemoveDebugText(AActor SrcActor, bool bLeaveDurationText = false)
			=> E_AHUD_RemoveDebugText(NativePointer, SrcActor, bLeaveDurationText);
		
		public void ReceiveDrawHUD(int SizeX, int SizeY)
			=> E_AHUD_ReceiveDrawHUD(NativePointer, SizeX, SizeY);
		
		
		/// <summary>
		/// Called when a hit box is clicked on. Provides the name associated with that box.
		/// </summary>
		public void HitBoxClicked(string BoxName)
			=> E_AHUD_ReceiveHitBoxClick(NativePointer, BoxName);
		
		
		/// <summary>
		/// Transforms a 3D world-space vector into 2D screen coordinates
		/// </summary>
		public FVector Project(FVector Location)
			=> E_AHUD_Project(NativePointer, Location);
		
		
		/// <summary>
		/// Transforms a 2D screen location into a 3D location and direction
		/// </summary>
		public void Deproject(float ScreenX, float ScreenY, FVector WorldPosition, FVector WorldDirection)
			=> E_AHUD_Deproject(NativePointer, ScreenX, ScreenY, WorldPosition, WorldDirection);
		
		
		/// <summary>
		/// Add a hitbox to the hud
		/// @param Position			Coordinates of the top left of the hit box.
		/// @param Size				Size of the hit box.
		/// @param Name				Name of the hit box.
		/// @param bConsumesInput	Whether click processing should continue if this hit box is clicked.
		/// @param Priority			The priority of the box used for layering. Larger values are considered first.  Equal values are considered in the order they were added.
		/// </summary>
		public void AddHitBox(FVector2D Position, FVector2D Size, string InName, bool bConsumesInput, int Priority = 0)
			=> E_AHUD_AddHitBox(NativePointer, Position, Size, InName, bConsumesInput, Priority);
		
		
		/// <summary>
		/// Returns the Pawn for this HUD's player.
		/// </summary>
		protected APawn GetOwningPawn()
			=> E_AHUD_GetOwningPawn(NativePointer);
		
		
		/// <summary>
		/// draw overlays for actors that were rendered this tick and have added themselves to the PostRenderedActors array
		/// </summary>
		public void DrawActorOverlays(FVector Viewpoint, FRotator ViewRotation)
			=> E_AHUD_DrawActorOverlays(NativePointer, Viewpoint, ViewRotation);
		
		
		/// <summary>
		/// remove an actor from the PostRenderedActors array
		/// </summary>
		public void RemovePostRenderedActor(AActor A)
			=> E_AHUD_RemovePostRenderedActor(NativePointer, A);
		
		
		/// <summary>
		/// check if we should be display debug information for particular types of debug messages.
		/// @param DebugType - type of debug message.
		/// @return true if it should be displayed, false otherwise.
		/// </summary>
		public bool ShouldDisplayDebug(string DebugType)
			=> E_AHUD_ShouldDisplayDebug(NativePointer, DebugType);
		
		
		/// <summary>
		/// Entry point for basic debug rendering on the HUD.  Activated and controlled via the "showdebug" console command.
		/// Can be overridden to display custom debug per-game.
		/// </summary>
		public void ShowDebugInfo(float YL, float YPos)
			=> E_AHUD_ShowDebugInfo(NativePointer, YL, YPos);
		
		
		/// <summary>
		/// Pauses or unpauses the game due to main window's focus being lost.
		/// @param Enable - tells whether to enable or disable the pause state
		/// </summary>
		public void OnLostFocusPause(bool bEnable)
			=> E_AHUD_OnLostFocusPause(NativePointer, bEnable);
		
		
		/// <summary>
		/// Have any hitboxes been hit this frame.
		/// </summary>
		public bool AnyCurrentHitBoxHits()
			=> E_AHUD_AnyCurrentHitBoxHits(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(AHUD Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator AHUD(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new AHUD(Adress);
		}}}
