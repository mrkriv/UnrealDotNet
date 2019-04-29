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
	public  partial class UOnlineSession : UObject
	{
		public UOnlineSession(IntPtr Adress)
			: base(Adress)
		{
		}

		public UOnlineSession(UObject Parent = null, string Name = "OnlineSession")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UOnlineSession(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UOnlineSession(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UOnlineSession_ClearOnlineDelegates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UOnlineSession_EndOnlineSession(IntPtr self, string sessionName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UOnlineSession_RegisterOnlineDelegates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UOnlineSession_StartOnlineSession(IntPtr self, string sessionName);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Tear down all delegates used to manage online sessions.
		/// </summary>
		public virtual void ClearOnlineDelegates()
			=> E_UOnlineSession_ClearOnlineDelegates(this);
		
		
		/// <summary>
		/// End the online session specified
		/// </summary>
		public virtual void EndOnlineSession(string sessionName)
			=> E_UOnlineSession_EndOnlineSession(this, sessionName);
		
		
		/// <summary>
		/// Register all delegates needed to manage online sessions.
		/// </summary>
		public virtual void RegisterOnlineDelegates()
			=> E_UOnlineSession_RegisterOnlineDelegates(this);
		
		
		/// <summary>
		/// Start the online session specified
		/// </summary>
		public virtual void StartOnlineSession(string sessionName)
			=> E_UOnlineSession_StartOnlineSession(this, sessionName);
		
		#endregion
		
		public static implicit operator IntPtr(UOnlineSession self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UOnlineSession(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UOnlineSession>(PtrDesc);
		}}}
