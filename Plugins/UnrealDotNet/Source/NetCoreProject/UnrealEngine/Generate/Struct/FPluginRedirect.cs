using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPluginRedirect : NativeStructWrapper
	{
		internal FPluginRedirect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPluginRedirect() :
			base(E_CreateStruct_FPluginRedirect(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPluginRedirect();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_FPluginRedirect_NewPluginName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPluginRedirect_NewPluginName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_FPluginRedirect_OldPluginName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPluginRedirect_OldPluginName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string NewPluginName
		{
			get => E_PROP_FPluginRedirect_NewPluginName_GET(NativePointer);
			set => E_PROP_FPluginRedirect_NewPluginName_SET(NativePointer, value);
		}

		public string OldPluginName
		{
			get => E_PROP_FPluginRedirect_OldPluginName_GET(NativePointer);
			set => E_PROP_FPluginRedirect_OldPluginName_SET(NativePointer, value);
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
