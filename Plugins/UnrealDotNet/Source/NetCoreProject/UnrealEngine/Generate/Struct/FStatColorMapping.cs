using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FStatColorMapping : NativeStructWrapper
	{
		internal FStatColorMapping(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FStatColorMapping() :
			base(E_CreateStruct_FStatColorMapping(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStatColorMapping();
		
		#endregion
		
		public static implicit operator IntPtr(FStatColorMapping Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FStatColorMapping(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStatColorMapping(Adress, false);
		}}}
