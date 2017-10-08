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
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRigidBodyState_Flags_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyState_Flags_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRigidBodyState_Quaternion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyState_Quaternion_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public byte Flags
		{
			get => E_PROP_FRigidBodyState_Flags_GET(NativePointer);
			set => E_PROP_FRigidBodyState_Flags_SET(NativePointer, value);
		}

		public FQuat Quaternion
		{
			get => E_PROP_FRigidBodyState_Quaternion_GET(NativePointer);
			set => E_PROP_FRigidBodyState_Quaternion_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRigidBodyState Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRigidBodyState(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRigidBodyState(Adress, false);
		}}}
