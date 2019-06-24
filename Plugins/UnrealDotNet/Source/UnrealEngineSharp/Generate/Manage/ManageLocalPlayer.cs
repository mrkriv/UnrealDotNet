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
	[ManageType("ManageLocalPlayer")]
	public partial class ManageLocalPlayer : ULocalPlayer, IManageWrapper
	{
		public ManageLocalPlayer(IntPtr adress)
			: base(adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_InitOnlineSession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PlayerRemoved(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_SendSplitJoin(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_SetControllerId(IntPtr self, int newControllerId);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_BeginDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_FinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_MarkAsEditorOnlySubobject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PostCDOContruct(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PostEditImport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PostInitProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PostNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PostRepNotifies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PostSaveRoot(IntPtr self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PreDestroyFromReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_PreNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_ShutdownAfterError(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_CreateCluster(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__ULocalPlayer_OnClusterMarkedAsPendingKill(IntPtr self);
		
		#endregion
		
		#region Methods
		
		/// <summary>
		/// Called to initialize the online delegates
		/// </summary>
		public override void InitOnlineSession()
			=> E__Supper__ULocalPlayer_InitOnlineSession(this);
		
		
		/// <summary>
		/// Called when the player is removed from the viewport client
		/// </summary>
		public override void PlayerRemoved()
			=> E__Supper__ULocalPlayer_PlayerRemoved(this);
		
		
		/// <summary>
		/// Send a splitscreen join command to the server to allow a splitscreen player to connect to the game
		/// <para>the client must already be connected to a server for this function to work </para>
		/// @note this happens automatically for all viewports that exist during the initial server connect
		/// <para>so it's only necessary to manually call this for viewports created after that </para>
		/// if the join fails (because the server was full, for example) all viewports on this client will be disconnected
		/// </summary>
		public override void SendSplitJoin()
			=> E__Supper__ULocalPlayer_SendSplitJoin(this);
		
		
		/// <summary>
		/// Change the ControllerId for this player; if the specified ControllerId is already taken by another player, changes the ControllerId
		/// <para>for the other player to the ControllerId currently in use by this player. </para>
		/// </summary>
		/// <param name="newControllerId">the ControllerId to assign to this player.</param>
		public override void SetControllerId(int newControllerId)
			=> E__Supper__ULocalPlayer_SetControllerId(this, newControllerId);
		
		
		/// <summary>
		/// Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy()
			=> E__Supper__ULocalPlayer_BeginDestroy(this);
		
		
		/// <summary>
		/// Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed.
		/// <para>@warning Because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E__Supper__ULocalPlayer_FinishDestroy(this);
		
		
		/// <summary>
		/// Called during subobject creation to mark this component as editor only, which causes it to get stripped in packaged builds
		/// </summary>
		public override void MarkAsEditorOnlySubobject()
			=> E__Supper__ULocalPlayer_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E__Supper__ULocalPlayer_PostCDOContruct(this);
		
		
		/// <summary>
		/// Called after importing property values for this object (paste, duplicate or .t3d import)
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// are unsupported by the script serialization
		/// </summary>
		public override void PostEditImport()
			=> E__Supper__ULocalPlayer_PostEditImport(this);
		
		
		/// <summary>
		/// Called after the C++ constructor and after the properties have been initialized, including those loaded from config.
		/// <para>This is called before any serialization or other setup has happened. </para>
		/// </summary>
		public override void PostInitProperties()
			=> E__Supper__ULocalPlayer_PostInitProperties(this);
		
		
		/// <summary>
		/// Do any object-specific cleanup required immediately after loading an object.
		/// <para>This is not called for newly-created objects, and by default will always execute on the game thread. </para>
		/// </summary>
		public override void PostLoad()
			=> E__Supper__ULocalPlayer_PostLoad(this);
		
		
		/// <summary>
		/// Called right after receiving a bunch
		/// </summary>
		public override void PostNetReceive()
			=> E__Supper__ULocalPlayer_PostNetReceive(this);
		
		
		/// <summary>
		/// Called right after calling all OnRep notifies (called even when there are no notifies)
		/// </summary>
		public override void PostRepNotifies()
			=> E__Supper__ULocalPlayer_PostRepNotifies(this);
		
		
		/// <summary>
		/// Called from within SavePackage on the passed in base/root object.
		/// <para>This function is called after the package has been saved and can perform cleanup. </para>
		/// </summary>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up</param>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E__Supper__ULocalPlayer_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// Called right before being marked for destruction due to network replication
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E__Supper__ULocalPlayer_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// Called right before receiving a bunch
		/// </summary>
		public override void PreNetReceive()
			=> E__Supper__ULocalPlayer_PreNetReceive(this);
		
		
		/// <summary>
		/// After a critical error, perform any mission-critical cleanup, such as restoring the video mode orreleasing hardware resources.
		/// </summary>
		public override void ShutdownAfterError()
			=> E__Supper__ULocalPlayer_ShutdownAfterError(this);
		
		
		/// <summary>
		/// Called after PostLoad to create UObject cluster
		/// </summary>
		public override void CreateCluster()
			=> E__Supper__ULocalPlayer_CreateCluster(this);
		
		
		/// <summary>
		/// Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it.
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E__Supper__ULocalPlayer_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(ManageLocalPlayer self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageLocalPlayer(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLocalPlayer>(PtrDesc);
		}}}
