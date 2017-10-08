using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FColorGradePerRangeSettings : NativeStructWrapper
	{
		internal FColorGradePerRangeSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FColorGradePerRangeSettings() :
			base(E_CreateStruct_FColorGradePerRangeSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FColorGradePerRangeSettings();
		
		#endregion
		
		public static implicit operator IntPtr(FColorGradePerRangeSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FColorGradePerRangeSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FColorGradePerRangeSettings(Adress, false);
		}}}
