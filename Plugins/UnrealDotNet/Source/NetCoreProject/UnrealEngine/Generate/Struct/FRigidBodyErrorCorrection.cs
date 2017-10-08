using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRigidBodyErrorCorrection : NativeStructWrapper
	{
		internal FRigidBodyErrorCorrection(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRigidBodyErrorCorrection() :
			base(E_CreateStruct_FRigidBodyErrorCorrection(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRigidBodyErrorCorrection();
		
		#endregion
		
		public static implicit operator IntPtr(FRigidBodyErrorCorrection Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRigidBodyErrorCorrection(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRigidBodyErrorCorrection(Adress, false);
		}}}
