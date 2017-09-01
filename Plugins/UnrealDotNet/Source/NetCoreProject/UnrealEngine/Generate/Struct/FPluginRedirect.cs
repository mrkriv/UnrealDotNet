using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FPluginRedirect
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FPluginRedirect()
		{
			NativePointer = E_CreateStruct_FPluginRedirect();
			IsRef = false;
		}

		internal FPluginRedirect(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FPluginRedirect();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FPluginRedirect_OldPluginName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FPluginRedirect_OldPluginName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FPluginRedirect_NewPluginName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FPluginRedirect_NewPluginName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string OldPluginName
		{
			get => E_PROP_FPluginRedirect_OldPluginName_GET(NativePointer);
			set => E_PROP_FPluginRedirect_OldPluginName_SET(NativePointer, value);
		}

		public string NewPluginName
		{
			get => E_PROP_FPluginRedirect_NewPluginName_GET(NativePointer);
			set => E_PROP_FPluginRedirect_NewPluginName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPluginRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPluginRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPluginRedirect(Adress, false);
		}}}
