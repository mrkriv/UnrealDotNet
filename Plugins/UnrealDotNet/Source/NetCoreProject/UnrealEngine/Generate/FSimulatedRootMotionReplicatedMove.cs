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
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_CreateStruct_FSimulatedRootMotionReplicatedMove();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_FSimulatedRootMotionReplicatedMove_Time_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FSimulatedRootMotionReplicatedMove_Time_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRepRootMotionMontage E_Struct_FSimulatedRootMotionReplicatedMove_RootMotion_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FSimulatedRootMotionReplicatedMove_RootMotion_SET(IntPtr Ptr, FRepRootMotionMontage Value);
		
		#endregion
		
		#region Property
		public float Time
		{
			get => E_Struct_FSimulatedRootMotionReplicatedMove_Time_GET(NativePointer);
			set => E_Struct_FSimulatedRootMotionReplicatedMove_Time_SET(NativePointer, value);
		}

		public FRepRootMotionMontage RootMotion
		{
			get => E_Struct_FSimulatedRootMotionReplicatedMove_RootMotion_GET(NativePointer);
			set => E_Struct_FSimulatedRootMotionReplicatedMove_RootMotion_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		#endregion
		
		public static implicit operator IntPtr(FSimulatedRootMotionReplicatedMove Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSimulatedRootMotionReplicatedMove(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSimulatedRootMotionReplicatedMove(Adress, false);
		}}}
