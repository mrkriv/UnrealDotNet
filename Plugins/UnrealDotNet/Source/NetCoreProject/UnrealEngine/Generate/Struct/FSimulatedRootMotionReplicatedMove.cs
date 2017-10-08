using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSimulatedRootMotionReplicatedMove : NativeStructWrapper
	{
		internal FSimulatedRootMotionReplicatedMove(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSimulatedRootMotionReplicatedMove() :
			base(E_CreateStruct_FSimulatedRootMotionReplicatedMove(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSimulatedRootMotionReplicatedMove();
		
		#endregion
		
		public static implicit operator IntPtr(FSimulatedRootMotionReplicatedMove Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSimulatedRootMotionReplicatedMove(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSimulatedRootMotionReplicatedMove(Adress, false);
		}}}
