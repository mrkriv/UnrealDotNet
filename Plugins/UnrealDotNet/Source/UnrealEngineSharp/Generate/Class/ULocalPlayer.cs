// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\LocalPlayer.h:163

namespace UnrealEngine
{
	public partial class ULocalPlayer : UPlayer
	{
		public ULocalPlayer(IntPtr adress)
			: base(adress)
		{
		}

		public ULocalPlayer(UObject Parent = null, string Name = "LocalPlayer")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULocalPlayer(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_ULocalPlayer_LastViewLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULocalPlayer_LastViewLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_ULocalPlayer_Origin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULocalPlayer_Origin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_ULocalPlayer_Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULocalPlayer_Size_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_ULocalPlayer_ViewportClient_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULocalPlayer_ViewportClient_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULocalPlayer(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_ULocalPlayer_GetControllerId(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_ULocalPlayer_GetGameLoginOptions(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_ULocalPlayer_GetNickname(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULocalPlayer_GetPixelBoundingBox(IntPtr self, IntPtr actorBox, IntPtr outLowerLeft, IntPtr outUpperRight, IntPtr optionalAllotedSize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULocalPlayer_GetPixelPoint(IntPtr self, IntPtr inPoint, IntPtr outPoint, IntPtr optionalAllotedSize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULocalPlayer_InitOnlineSession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULocalPlayer_IsCachedUniqueNetIdPairedWithControllerId(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULocalPlayer_IsPrimaryPlayer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULocalPlayer_PlayerAdded(IntPtr self, IntPtr inViewportClient, int inControllerID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULocalPlayer_PlayerRemoved(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULocalPlayer_SendSplitJoin(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULocalPlayer_SetControllerId(IntPtr self, int newControllerId);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ULocalPlayer_SpawnPlayActor(IntPtr self, string uRL, string outError, IntPtr inWorld);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The location of the player's view the previous frame.
		/// </summary>
		public FVector LastViewLocation
		{
			get => E_PROP_ULocalPlayer_LastViewLocation_GET(NativePointer);
			set => E_PROP_ULocalPlayer_LastViewLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The coordinates for the upper left corner of the master viewport subregion allocated to this player. 0-1
		/// </summary>
		public FVector2D Origin
		{
			get => E_PROP_ULocalPlayer_Origin_GET(NativePointer);
			set => E_PROP_ULocalPlayer_Origin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The size of the master viewport subregion allocated to this player. 0-1
		/// </summary>
		public FVector2D Size
		{
			get => E_PROP_ULocalPlayer_Size_GET(NativePointer);
			set => E_PROP_ULocalPlayer_Size_SET(NativePointer, value);
		}

		public UGameViewportClient ViewportClient
		{
			get => E_PROP_ULocalPlayer_ViewportClient_GET(NativePointer);
			set => E_PROP_ULocalPlayer_ViewportClient_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns the controller ID for the player
		/// </summary>
		public int GetControllerId()
			=> E_ULocalPlayer_GetControllerId(this);
		
		
		/// <summary>
		/// Retrieves any game-specific login options for this player
		/// <para>if this function returns a non-empty string, the returned option or options be added </para>
		/// passed in to the level loading and connection code.  Options are in URL format,
		/// <para>key=value, with multiple options concatenated together with an & between each key/value pair </para>
		/// </summary>
		/// <return>URL</return>
		public virtual string GetGameLoginOptions()
			=> E_ULocalPlayer_GetGameLoginOptions(this);
		
		
		/// <summary>
		/// Retrieves this player's name/tag from the online subsystem
		/// <para>if this function returns a non-empty string, the returned name will replace the "Name" URL parameter </para>
		/// passed around in the level loading and connection code, which normally comes from DefaultEngine.ini
		/// </summary>
		/// <return>Name</return>
		public virtual string GetNickname()
			=> E_ULocalPlayer_GetNickname(this);
		
		
		/// <summary>
		/// This function will give you two points in Pixel Space that surround the World Space box.
		/// </summary>
		/// <param name="actorBox">The World Space Box</param>
		/// <param name="outLowerLeft">The Lower Left corner of the Pixel Space box</param>
		/// <param name="outUpperRight">The Upper Right corner of the pixel space box</param>
		/// <return>False</return>
		public bool GetPixelBoundingBox(FBox actorBox, FVector2D outLowerLeft, FVector2D outUpperRight, FVector2D optionalAllotedSize = null)
			=> E_ULocalPlayer_GetPixelBoundingBox(this, actorBox, outLowerLeft, outUpperRight, optionalAllotedSize);
		
		
		/// <summary>
		/// This function will give you a point in Pixel Space from a World Space position
		/// </summary>
		/// <param name="inPoint">The point in world space</param>
		/// <param name="outPoint">The point in pixel space</param>
		/// <return>False</return>
		public bool GetPixelPoint(FVector inPoint, FVector2D outPoint, FVector2D optionalAllotedSize = null)
			=> E_ULocalPlayer_GetPixelPoint(this, inPoint, outPoint, optionalAllotedSize);
		
		
		/// <summary>
		/// Called to initialize the online delegates
		/// </summary>
		public virtual void InitOnlineSession()
			=> E_ULocalPlayer_InitOnlineSession(this);
		
		
		/// <summary>
		/// Returns true if the cached unique net id, is the one assigned to the controller id from the OSS
		/// </summary>
		public bool IsCachedUniqueNetIdPairedWithControllerId()
			=> E_ULocalPlayer_IsCachedUniqueNetIdPairedWithControllerId(this);
		
		
		/// <summary>
		/// Determines whether this player is the first and primary player on their machine.
		/// </summary>
		/// <return>true</return>
		public bool IsPrimaryPlayer()
			=> E_ULocalPlayer_IsPrimaryPlayer(this);
		
		
		/// <summary>
		/// Called at creation time for internal setup
		/// </summary>
		public virtual void PlayerAdded(UGameViewportClient inViewportClient, int inControllerID)
			=> E_ULocalPlayer_PlayerAdded(this, inViewportClient, inControllerID);
		
		
		/// <summary>
		/// Called when the player is removed from the viewport client
		/// </summary>
		public virtual void PlayerRemoved()
			=> E_ULocalPlayer_PlayerRemoved(this);
		
		
		/// <summary>
		/// Send a splitscreen join command to the server to allow a splitscreen player to connect to the game
		/// <para>the client must already be connected to a server for this function to work </para>
		/// @note this happens automatically for all viewports that exist during the initial server connect
		/// <para>so it's only necessary to manually call this for viewports created after that </para>
		/// if the join fails (because the server was full, for example) all viewports on this client will be disconnected
		/// </summary>
		public virtual void SendSplitJoin()
			=> E_ULocalPlayer_SendSplitJoin(this);
		
		
		/// <summary>
		/// Change the ControllerId for this player; if the specified ControllerId is already taken by another player, changes the ControllerId
		/// <para>for the other player to the ControllerId currently in use by this player. </para>
		/// </summary>
		/// <param name="newControllerId">the ControllerId to assign to this player.</param>
		public virtual void SetControllerId(int newControllerId)
			=> E_ULocalPlayer_SetControllerId(this, newControllerId);
		
		
		/// <summary>
		/// Create an actor for this player.
		/// </summary>
		/// <param name="uRL">The URL the player joined with.</param>
		/// <param name="outError">If an error occurred, returns the error description.</param>
		/// <param name="inWorld">World in which to spawn the play actor</param>
		/// <return>False</return>
		public virtual bool SpawnPlayActor(string uRL, string outError, UWorld inWorld)
			=> E_ULocalPlayer_SpawnPlayActor(this, uRL, outError, inWorld);
		
		#endregion
		
		public static implicit operator IntPtr(ULocalPlayer self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ULocalPlayer(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULocalPlayer>(PtrDesc);
		}}}
