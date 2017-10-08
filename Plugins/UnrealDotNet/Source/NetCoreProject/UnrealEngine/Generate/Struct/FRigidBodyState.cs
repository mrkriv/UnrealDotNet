using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRigidBodyState : NativeStructWrapper
	{
		internal FRigidBodyState(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRigidBodyState() :
			base(E_CreateStruct_FRigidBodyState(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRigidBodyState();
		
		#endregion
		
		public static implicit operator IntPtr(FRigidBodyState Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRigidBodyState(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRigidBodyState(Adress, false);
		}}}
