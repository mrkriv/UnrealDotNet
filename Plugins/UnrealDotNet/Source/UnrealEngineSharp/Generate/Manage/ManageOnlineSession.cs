// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\OnlineSession.h:18

namespace UnrealEngine
{
	[ManageType("ManageOnlineSession")]
	public partial class ManageOnlineSession : UOnlineSession
	{
		public ManageOnlineSession(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Tear down all delegates used to manage online sessions.
		/// </summary>
		public override void ClearOnlineDelegates() { }
		
		
		/// <summary>
		/// End the online session specified
		/// </summary>
		public override void EndOnlineSession(string sessionName) { }
		
		
		/// <summary>
		/// Register all delegates needed to manage online sessions.
		/// </summary>
		public override void RegisterOnlineDelegates() { }
		
		
		/// <summary>
		/// Start the online session specified
		/// </summary>
		public override void StartOnlineSession(string sessionName) { }
		
		public static implicit operator IntPtr(ManageOnlineSession self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageOnlineSession(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageOnlineSession>(PtrDesc);
		}}}
