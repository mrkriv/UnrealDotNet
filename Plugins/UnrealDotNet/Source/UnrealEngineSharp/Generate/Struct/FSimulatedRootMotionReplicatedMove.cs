// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:105

namespace UnrealEngine
{
	public partial class FSimulatedRootMotionReplicatedMove : NativeStructWrapper
	{
		public FSimulatedRootMotionReplicatedMove(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FSimulatedRootMotionReplicatedMove() :
			base(E_CreateStruct_FSimulatedRootMotionReplicatedMove(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FSimulatedRootMotionReplicatedMove_Time_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSimulatedRootMotionReplicatedMove_Time_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSimulatedRootMotionReplicatedMove();
		
		#endregion
		
		#region Property
		public FRepRootMotionMontage RootMotion
		{
			get => E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_GET(NativePointer);
			set => E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_SET(NativePointer, value);
		}

		public float Time
		{
			get => E_PROP_FSimulatedRootMotionReplicatedMove_Time_GET(NativePointer);
			set => E_PROP_FSimulatedRootMotionReplicatedMove_Time_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSimulatedRootMotionReplicatedMove self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSimulatedRootMotionReplicatedMove(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FSimulatedRootMotionReplicatedMove(adress, false);
		}}}
