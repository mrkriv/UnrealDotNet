using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FURL : NativeStructWrapper
	{
		public FURL() : base(E_CreateStruct_FURL(), false)
		{
		}

		internal FURL(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FURL();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FURL_bDefaultsInitialized_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FURL_bDefaultsInitialized_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FURL_Host_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FURL_Host_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FURL_Map_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FURL_Map_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FURL_Port_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FURL_Port_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FURL_Portal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FURL_Portal_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FURL_Protocol_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FURL_Protocol_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FURL_RedirectURL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FURL_RedirectURL_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FURL_Valid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FURL_Valid_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FURL_FilterURLString(FURL Self, string Str);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FURL_IsInternal(FURL Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FURL_IsLocalInternal(FURL Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FURL_StaticExit(FURL Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FURL_StaticInit(FURL Self);
		
		#endregion
		
		#region Property
		public bool bDefaultsInitialized
		{
			get => E_PROP_FURL_bDefaultsInitialized_GET(NativePointer);
			set => E_PROP_FURL_bDefaultsInitialized_SET(NativePointer, value);
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
		/// <para>Static: Removes any special URL characters from the specified string </para>
		/// <param name="Str">String to be filtered </param>
		/// </summary>
		public void FilterURLString(string Str)
			=> E_FURL_FilterURLString(this, Str);
		
		
		/// <summary>
		/// <para>Returns whether this URL corresponds to an internal object, i.e. an Unreal </para>
		/// <para>level which this app can try to connect to locally or on the net. If this </para>
		/// <para>is false, the URL refers to an object that a remote application like Internet </para>
		/// <para>Explorer can execute. </para>
		/// </summary>
		public bool IsInternal()
			=> E_FURL_IsInternal(this);
		
		
		/// <summary>
		/// <para>Returns whether this URL corresponds to an internal object on this local </para>
		/// <para>process. In this case, no Internet use is necessary. </para>
		/// </summary>
		public bool IsLocalInternal()
			=> E_FURL_IsLocalInternal(this);
		
		public void StaticExit()
			=> E_FURL_StaticExit(this);
		
		public void StaticInit()
			=> E_FURL_StaticInit(this);
		
		#endregion
		
		public static implicit operator IntPtr(FURL Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FURL(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FURL(Adress, false);
		}}}
