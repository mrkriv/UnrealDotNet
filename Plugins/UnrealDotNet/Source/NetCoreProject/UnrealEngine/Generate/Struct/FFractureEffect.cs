using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FFractureEffect : NativeStructWrapper
	{
		internal FFractureEffect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFractureEffect() :
			base(E_CreateStruct_FFractureEffect(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFractureEffect();
		
		#endregion
		
		public static implicit operator IntPtr(FFractureEffect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFractureEffect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFractureEffect(Adress, false);
		}}}
