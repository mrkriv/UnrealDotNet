using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FEngineShowFlagsSetting : NativeStructWrapper
	{
		internal FEngineShowFlagsSetting(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FEngineShowFlagsSetting() :
			base(E_CreateStruct_FEngineShowFlagsSetting(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEngineShowFlagsSetting();
		
		#endregion
		
		public static implicit operator IntPtr(FEngineShowFlagsSetting Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FEngineShowFlagsSetting(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FEngineShowFlagsSetting(Adress, false);
		}}}
