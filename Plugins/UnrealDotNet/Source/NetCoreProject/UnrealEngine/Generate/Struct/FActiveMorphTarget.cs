using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FActiveMorphTarget : NativeStructWrapper
	{
		internal FActiveMorphTarget(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FActiveMorphTarget() :
			base(E_CreateStruct_FActiveMorphTarget(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActiveMorphTarget();
		
		#endregion
		
		public static implicit operator IntPtr(FActiveMorphTarget Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FActiveMorphTarget(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActiveMorphTarget(Adress, false);
		}}}
