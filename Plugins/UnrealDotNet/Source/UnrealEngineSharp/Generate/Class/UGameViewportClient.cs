// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\GameViewportClient.h:55

namespace UnrealEngine
{
	public partial class UGameViewportClient : UScriptViewportClient
	{
		public UGameViewportClient(IntPtr adress)
			: base(adress)
		{
		}

		public UGameViewportClient(UObject Parent = null, string Name = "GameViewportClient")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UGameViewportClient(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UGameViewportClient_MaxSplitscreenPlayers_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UGameViewportClient_MaxSplitscreenPlayers_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UGameViewportClient_ViewModeIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UGameViewportClient_ViewModeIndex_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UGameViewportClient(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_CalculateDeadZoneForAllSides(IntPtr self, IntPtr lPlayer, IntPtr canvas, float fTopSafeZone, float fBottomSafeZone, float fLeftSafeZone, float fRightSafeZone, bool bUseMaxPercent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UGameViewportClient_ConsoleCommand(IntPtr self, string command);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameViewportClient_ConvertLocalPlayerToGamePlayerIndex(IntPtr self, IntPtr lPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_DetachViewportClient(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_DrawTitleSafeArea(IntPtr self, IntPtr canvas);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_DrawTransition(IntPtr self, IntPtr canvas);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_DrawTransitionMessage(IntPtr self, IntPtr canvas, string message);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_GetDisableSplitscreenOverride(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_GetMousePosition(IntPtr self, IntPtr mousePosition);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_GetPixelSizeOfScreen(IntPtr self, float width, float height, IntPtr canvas, int localPlayerIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_GetSubtitleRegion(IntPtr self, IntPtr minPos, IntPtr maxPos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_GetUseMouseForTouch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_GetViewportSize(IntPtr self, IntPtr viewportSize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_HandleToggleFullscreenCommand(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_HasBottomSafeZone(IntPtr self, int localPlayerIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_HasLeftSafeZone(IntPtr self, int localPlayerIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_HasRightSafeZone(IntPtr self, int localPlayerIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_HasTopSafeZone(IntPtr self, int localPlayerIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_IsExclusiveFullscreenViewport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_IsFullScreenViewport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_IsSimulateInEditorViewport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_LayoutPlayers(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_NotifyPlayerAdded(IntPtr self, int playerIndex, IntPtr addedPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_NotifyPlayerRemoved(IntPtr self, int playerIndex, IntPtr removedPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_PostRender(IntPtr self, IntPtr canvas);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_RebuildCursors(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_RemoveAllViewportWidgets(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetCaptureMouseOnClick(IntPtr self, byte mode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetConsoleTarget(IntPtr self, int playerIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetDisableSplitscreenOverride(IntPtr self, bool bDisabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetDropDetail(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetHideCursorDuringCapture(IntPtr self, bool inHideCursorDuringCapture);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetIgnoreInput(IntPtr self, bool ignore);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetLockDuringCapture(IntPtr self, bool inLockDuringCapture);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetMouseLockMode(IntPtr self, byte inMouseLockMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetSuppressTransitionMessage(IntPtr self, bool bSuppress);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UGameViewportClient_SetupInitialLocalPlayer(IntPtr self, string outError);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SetUseSoftwareCursorWidgets(IntPtr self, bool bInUseSoftwareCursorWidgets);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameViewportClient_ShouldForceFullscreenViewport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_ShowTitleSafeArea(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_SSSwapControllers(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_Tick(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_UpdateActiveSplitscreenType(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameViewportClient_VerifyPathRenderingComponents(IntPtr self);
		
		#endregion
		
		#region Property
		public int MaxSplitscreenPlayers
		{
			get => E_PROP_UGameViewportClient_MaxSplitscreenPlayers_GET(NativePointer);
			set => E_PROP_UGameViewportClient_MaxSplitscreenPlayers_SET(NativePointer, value);
		}

		
		/// <summary>
		/// see enum EViewModeIndex
		/// </summary>
		public int ViewModeIndex
		{
			get => E_PROP_UGameViewportClient_ViewModeIndex_GET(NativePointer);
			set => E_PROP_UGameViewportClient_ViewModeIndex_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// pixel size of the deadzone for all sides (right/left/top/bottom) based on which local player it is
		/// </summary>
		/// <return>true</return>
		public bool CalculateDeadZoneForAllSides(ULocalPlayer lPlayer, UCanvas canvas, float fTopSafeZone, float fBottomSafeZone, float fLeftSafeZone, float fRightSafeZone, bool bUseMaxPercent = false)
			=> E_UGameViewportClient_CalculateDeadZoneForAllSides(this, lPlayer, canvas, fTopSafeZone, fBottomSafeZone, fLeftSafeZone, fRightSafeZone, bUseMaxPercent);
		
		
		/// <summary>
		/// Process Console Command
		/// </summary>
		/// <param name="command">command to process</param>
		public virtual string ConsoleCommand(string command)
			=> E_UGameViewportClient_ConsoleCommand(this, command);
		
		
		/// <summary>
		/// Convert a LocalPlayer to it's index in the GamePlayer array
		/// <para>@returns -1 if the index could not be found. </para>
		/// </summary>
		/// <param name="lPlayer">Player to get the index of</param>
		public int ConvertLocalPlayerToGamePlayerIndex(ULocalPlayer lPlayer)
			=> E_UGameViewportClient_ConvertLocalPlayerToGamePlayerIndex(this, lPlayer);
		
		
		/// <summary>
		/// Cleans up all rooted or referenced objects created or managed by the GameViewportClient.  This method is called
		/// <para>when this GameViewportClient has been disassociated with the game engine (i.e. is no longer the engine's GameViewport). </para>
		/// </summary>
		public virtual void DetachViewportClient()
			=> E_UGameViewportClient_DetachViewportClient(this);
		
		
		/// <summary>
		/// Draw the safe area using the current TitleSafeZone settings.
		/// </summary>
		/// <param name="canvas">Canvas on which to draw</param>
		public virtual void DrawTitleSafeArea(UCanvas canvas)
			=> E_UGameViewportClient_DrawTitleSafeArea(this, canvas);
		
		
		/// <summary>
		/// Displays the transition screen.
		/// </summary>
		/// <param name="canvas">The canvas to use for rendering.</param>
		public virtual void DrawTransition(UCanvas canvas)
			=> E_UGameViewportClient_DrawTransition(this, canvas);
		
		
		/// <summary>
		/// Print a centered transition message with a drop shadow.
		/// </summary>
		/// <param name="canvas">The canvas to use for rendering.</param>
		/// <param name="message">Transition message</param>
		public virtual void DrawTransitionMessage(UCanvas canvas, string message)
			=> E_UGameViewportClient_DrawTransitionMessage(this, canvas, message);
		
		
		/// <summary>
		/// Determines whether splitscreen is forced to be turned off
		/// </summary>
		public bool GetDisableSplitscreenOverride()
			=> E_UGameViewportClient_GetDisableSplitscreenOverride(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>mouse</return>
		public bool GetMousePosition(FVector2D mousePosition)
			=> E_UGameViewportClient_GetMousePosition(this, mousePosition);
		
		
		/// <summary>
		/// Get the total pixel size of the screen.
		/// <para>This is different from the pixel size of the viewport since we could be in splitscreen </para>
		/// </summary>
		public void GetPixelSizeOfScreen(float width, float height, UCanvas canvas, int localPlayerIndex)
			=> E_UGameViewportClient_GetPixelSizeOfScreen(this, width, height, canvas, localPlayerIndex);
		
		
		/// <summary>
		/// called before rending subtitles to allow the game viewport to determine the size of the subtitle area
		/// </summary>
		/// <param name="min">top left bounds of subtitle region (0 to 1)</param>
		/// <param name="max">bottom right bounds of subtitle region (0 to 1)</param>
		public virtual void GetSubtitleRegion(FVector2D minPos, FVector2D maxPos)
			=> E_UGameViewportClient_GetSubtitleRegion(this, minPos, maxPos);
		
		protected bool GetUseMouseForTouch()
			=> E_UGameViewportClient_GetUseMouseForTouch(this);
		
		
		/// <summary>
		/// Retrieve the size of the main viewport.
		/// </summary>
		/// <param name="out_ViewportSize">out] will be filled in with the size of the main viewport</param>
		public void GetViewportSize(FVector2D viewportSize)
			=> E_UGameViewportClient_GetViewportSize(this, viewportSize);
		
		public bool HandleToggleFullscreenCommand()
			=> E_UGameViewportClient_HandleToggleFullscreenCommand(this);
		
		
		/// <summary>
		/// Whether the player at LocalPlayerIndex's viewport has a "bottom of viewport" safezone or not.
		/// </summary>
		public bool HasBottomSafeZone(int localPlayerIndex)
			=> E_UGameViewportClient_HasBottomSafeZone(this, localPlayerIndex);
		
		
		/// <summary>
		/// Whether the player at LocalPlayerIndex's viewport has a "left of viewport" safezone or not.
		/// </summary>
		public bool HasLeftSafeZone(int localPlayerIndex)
			=> E_UGameViewportClient_HasLeftSafeZone(this, localPlayerIndex);
		
		
		/// <summary>
		/// Whether the player at LocalPlayerIndex's viewport has a "right of viewport" safezone or not.
		/// </summary>
		public bool HasRightSafeZone(int localPlayerIndex)
			=> E_UGameViewportClient_HasRightSafeZone(this, localPlayerIndex);
		
		
		/// <summary>
		/// Whether the player at LocalPlayerIndex's viewport has a "top of viewport" safezone or not.
		/// </summary>
		public bool HasTopSafeZone(int localPlayerIndex)
			=> E_UGameViewportClient_HasTopSafeZone(this, localPlayerIndex);
		
		
		/// <summary>
		/// </summary>
		/// <return>If</return>
		public bool IsExclusiveFullscreenViewport()
			=> E_UGameViewportClient_IsExclusiveFullscreenViewport(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>Whether</return>
		public bool IsFullScreenViewport()
			=> E_UGameViewportClient_IsFullScreenViewport(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsSimulateInEditorViewport()
			=> E_UGameViewportClient_IsSimulateInEditorViewport(this);
		
		
		/// <summary>
		/// Called before rendering to allow the game viewport to allocate subregions to players.
		/// </summary>
		public virtual void LayoutPlayers()
			=> E_UGameViewportClient_LayoutPlayers(this);
		
		
		/// <summary>
		/// Notifies all interactions that a new player has been added to the list of active players.
		/// </summary>
		/// <param name="playerIndex">the index [into the GamePlayers array] where the player was inserted</param>
		/// <param name="addedPlayer">the player that was added</param>
		public virtual void NotifyPlayerAdded(int playerIndex, ULocalPlayer addedPlayer)
			=> E_UGameViewportClient_NotifyPlayerAdded(this, playerIndex, addedPlayer);
		
		
		/// <summary>
		/// Notifies all interactions that a new player has been added to the list of active players.
		/// </summary>
		/// <param name="playerIndex">the index [into the GamePlayers array] where the player was located</param>
		/// <param name="removedPlayer">the player that was removed</param>
		public virtual void NotifyPlayerRemoved(int playerIndex, ULocalPlayer removedPlayer)
			=> E_UGameViewportClient_NotifyPlayerRemoved(this, playerIndex, removedPlayer);
		
		
		/// <summary>
		/// Called after rendering the player views and HUDs to render menus, the console, etc.
		/// <para>This is the last rendering call in the render loop </para>
		/// </summary>
		/// <param name="canvas">The canvas to use for rendering.</param>
		public virtual void PostRender(UCanvas canvas)
			=> E_UGameViewportClient_PostRender(this, canvas);
		
		
		/// <summary>
		/// Recreates cursor widgets from UISettings class.
		/// </summary>
		public void RebuildCursors()
			=> E_UGameViewportClient_RebuildCursors(this);
		
		
		/// <summary>
		/// This function removes all widgets from the viewport overlay
		/// </summary>
		public void RemoveAllViewportWidgets()
			=> E_UGameViewportClient_RemoveAllViewportWidgets(this);
		
		
		/// <summary>
		/// Set the mouse capture behavior when the viewport is clicked
		/// </summary>
		public void SetCaptureMouseOnClick(EMouseCaptureMode mode)
			=> E_UGameViewportClient_SetCaptureMouseOnClick(this, (byte)mode);
		
		public virtual void SetConsoleTarget(int playerIndex)
			=> E_UGameViewportClient_SetConsoleTarget(this, playerIndex);
		
		
		/// <summary>
		/// Allows game code to disable splitscreen (useful when in menus)
		/// </summary>
		public void SetDisableSplitscreenOverride(bool bDisabled)
			=> E_UGameViewportClient_SetDisableSplitscreenOverride(this, bDisabled);
		
		
		/// <summary>
		/// Sets bDropDetail and other per-frame detail level flags on the current WorldSettings
		/// <para>@see UWorld </para>
		/// </summary>
		/// <param name="deltaSeconds">amount of time passed since last tick</param>
		public virtual void SetDropDetail(float deltaSeconds)
			=> E_UGameViewportClient_SetDropDetail(this, deltaSeconds);
		
		
		/// <summary>
		/// Sets whether or not the cursor is hidden when the viewport captures the mouse
		/// </summary>
		public void SetHideCursorDuringCapture(bool inHideCursorDuringCapture)
			=> E_UGameViewportClient_SetHideCursorDuringCapture(this, inHideCursorDuringCapture);
		
		
		/// <summary>
		/// Set whether to ignore input.
		/// </summary>
		public void SetIgnoreInput(bool ignore)
			=> E_UGameViewportClient_SetIgnoreInput(this, ignore);
		
		
		/// <summary>
		/// Sets whether or not the cursor is locked to the viewport when the viewport captures the mouse
		/// </summary>
		public void SetLockDuringCapture(bool inLockDuringCapture)
			=> E_UGameViewportClient_SetLockDuringCapture(this, inLockDuringCapture);
		
		
		/// <summary>
		/// Sets the current mouse cursor lock mode when the viewport is clicked
		/// </summary>
		public void SetMouseLockMode(EMouseLockMode inMouseLockMode)
			=> E_UGameViewportClient_SetMouseLockMode(this, (byte)inMouseLockMode);
		
		
		/// <summary>
		/// Controls suppression of the blue transition text messages
		/// </summary>
		/// <param name="bSuppress">Pass true to suppress messages</param>
		public void SetSuppressTransitionMessage(bool bSuppress)
			=> E_UGameViewportClient_SetSuppressTransitionMessage(this, bSuppress);
		
		
		/// <summary>
		/// Initialize the game viewport.
		/// </summary>
		/// <param name="outError">If an error occurs, returns the error description.</param>
		/// <return>False</return>
		public virtual ULocalPlayer SetupInitialLocalPlayer(string outError)
			=> E_UGameViewportClient_SetupInitialLocalPlayer(this, outError);
		
		
		/// <summary>
		/// Sets whether or not the software cursor widgets are used.
		/// <para>If no software cursor widgets are set this setting has no meaningful effect. </para>
		/// </summary>
		public void SetUseSoftwareCursorWidgets(bool bInUseSoftwareCursorWidgets)
			=> E_UGameViewportClient_SetUseSoftwareCursorWidgets(this, bInUseSoftwareCursorWidgets);
		
		
		/// <summary>
		/// Determine whether a fullscreen viewport should be used in cases where there are multiple players.
		/// </summary>
		/// <return>true</return>
		public bool ShouldForceFullscreenViewport()
			=> E_UGameViewportClient_ShouldForceFullscreenViewport(this);
		
		public virtual void ShowTitleSafeArea()
			=> E_UGameViewportClient_ShowTitleSafeArea(this);
		
		public virtual void SSSwapControllers()
			=> E_UGameViewportClient_SSSwapControllers(this);
		
		
		/// <summary>
		/// Called every frame to allow the game viewport to update time based state.
		/// </summary>
		/// <param name="deltaTime">The time since the last call to Tick.</param>
		public virtual void Tick(float deltaTime)
			=> E_UGameViewportClient_Tick(this, deltaTime);
		
		
		/// <summary>
		/// Sets the value of ActiveSplitscreenConfiguration based on the desired split-screen layout type, current number of players, and any other
		/// <para>factors that might affect the way the screen should be laid out. </para>
		/// </summary>
		public virtual void UpdateActiveSplitscreenType()
			=> E_UGameViewportClient_UpdateActiveSplitscreenType(this);
		
		
		/// <summary>
		/// Make sure all navigation objects have appropriate path rendering components set.  Called when EngineShowFlags.Navigation is set.
		/// </summary>
		public virtual void VerifyPathRenderingComponents()
			=> E_UGameViewportClient_VerifyPathRenderingComponents(this);
		
		#endregion
		
		public static implicit operator IntPtr(UGameViewportClient self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UGameViewportClient(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UGameViewportClient>(PtrDesc);
		}}}
