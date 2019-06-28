// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:771

namespace UnrealEngine
{
	public partial class FURL : NativeStructWrapper
	{
		public FURL(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Construct a purely default, local URL from an optional filename.
		/// </summary>
		public FURL() :
			base(E_CreateStruct_FURL(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FURL_bDefaultsInitialized_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_Host_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Host_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_Map_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Map_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FURL_Port_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Port_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_Portal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Portal_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_Protocol_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Protocol_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FURL_RedirectURL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_RedirectURL_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FURL_Valid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FURL_Valid_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FURL();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FURL_FilterURLString(IntPtr self, string str);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FURL_IsInternal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FURL_IsLocalInternal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FURL_StaticExit(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FURL_StaticInit(IntPtr self);
		
		#endregion
		
		#region Property
		public static bool bDefaultsInitialized
		{
			get => E_PROP_FURL_bDefaultsInitialized_GET();
		}

		public string Host
		{
			get => E_PROP_FURL_Host_GET(NativePointer);
			set => E_PROP_FURL_Host_SET(NativePointer, value);
		}

		public string Map
		{
			get => E_PROP_FURL_Map_GET(NativePointer);
			set => E_PROP_FURL_Map_SET(NativePointer, value);
		}

		public int Port
		{
			get => E_PROP_FURL_Port_GET(NativePointer);
			set => E_PROP_FURL_Port_SET(NativePointer, value);
		}

		public string Portal
		{
			get => E_PROP_FURL_Portal_GET(NativePointer);
			set => E_PROP_FURL_Portal_SET(NativePointer, value);
		}

		public string Protocol
		{
			get => E_PROP_FURL_Protocol_GET(NativePointer);
			set => E_PROP_FURL_Protocol_SET(NativePointer, value);
		}

		public string RedirectURL
		{
			get => E_PROP_FURL_RedirectURL_GET(NativePointer);
			set => E_PROP_FURL_RedirectURL_SET(NativePointer, value);
		}

		public int Valid
		{
			get => E_PROP_FURL_Valid_GET(NativePointer);
			set => E_PROP_FURL_Valid_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Static: Removes any special URL characters from the specified string
		/// </summary>
		/// <param name="str">String to be filtered</param>
		public void FilterURLString(string str)
			=> E_FURL_FilterURLString(this, str);
		
		
		/// <summary>
		/// Returns whether this URL corresponds to an internal object, i.e. an Unreal
		/// <para>level which this app can try to connect to locally or on the net. If this </para>
		/// is false, the URL refers to an object that a remote application like Internet
		/// <para>Explorer can execute. </para>
		/// </summary>
		public bool IsInternal()
			=> E_FURL_IsInternal(this);
		
		
		/// <summary>
		/// Returns whether this URL corresponds to an internal object on this local
		/// <para>process. In this case, no Internet use is necessary. </para>
		/// </summary>
		public bool IsLocalInternal()
			=> E_FURL_IsLocalInternal(this);
		
		public void StaticExit()
			=> E_FURL_StaticExit(this);
		
		public void StaticInit()
			=> E_FURL_StaticInit(this);
		
		#endregion
		
		public static implicit operator IntPtr(FURL self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FURL(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FURL(adress, false);
		}}}
