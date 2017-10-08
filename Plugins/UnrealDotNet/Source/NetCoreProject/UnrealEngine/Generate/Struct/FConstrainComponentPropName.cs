using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FConstrainComponentPropName : NativeStructWrapper
	{
		internal FConstrainComponentPropName(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FConstrainComponentPropName() :
			base(E_CreateStruct_FConstrainComponentPropName(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FConstrainComponentPropName();
		
		#endregion
		
		public static implicit operator IntPtr(FConstrainComponentPropName Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FConstrainComponentPropName(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FConstrainComponentPropName(Adress, false);
		}}}
