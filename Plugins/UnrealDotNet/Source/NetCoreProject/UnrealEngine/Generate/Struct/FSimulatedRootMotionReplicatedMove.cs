using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FSimulatedRootMotionReplicatedMove
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FSimulatedRootMotionReplicatedMove()
		{
			NativePointer = E_CreateStruct_FSimulatedRootMotionReplicatedMove();
			IsRef = false;
		}

		internal FSimulatedRootMotionReplicatedMove(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FSimulatedRootMotionReplicatedMove();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FSimulatedRootMotionReplicatedMove_Time_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSimulatedRootMotionReplicatedMove_Time_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FRepRootMotionMontage E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_SET(IntPtr Ptr, FRepRootMotionMontage Value);
		
		#endregion
		
		#region Property
		public float Time
		{
			get => E_PROP_FSimulatedRootMotionReplicatedMove_Time_GET(NativePointer);
			set => E_PROP_FSimulatedRootMotionReplicatedMove_Time_SET(NativePointer, value);
		}

		public FRepRootMotionMontage RootMotion
		{
			get => E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_GET(NativePointer);
			set => E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSimulatedRootMotionReplicatedMove Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSimulatedRootMotionReplicatedMove(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSimulatedRootMotionReplicatedMove(Adress, false);
		}}}
