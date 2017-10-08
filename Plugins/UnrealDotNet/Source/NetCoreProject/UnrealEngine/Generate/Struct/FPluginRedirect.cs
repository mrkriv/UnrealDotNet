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
		
		#endregion
		
		public static implicit operator IntPtr(FPluginRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPluginRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPluginRedirect(Adress, false);
		}}}
