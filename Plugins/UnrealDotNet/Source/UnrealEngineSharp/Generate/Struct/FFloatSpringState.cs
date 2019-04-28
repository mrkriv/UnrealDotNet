// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Kismet\KismetMathLibrary.h:90

namespace UnrealEngine
{
	public  partial class FFloatSpringState : NativeStructWrapper
	{
		internal FFloatSpringState(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFloatSpringState() :
			base(E_CreateStruct_FFloatSpringState(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFloatSpringState_PrevError_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFloatSpringState_PrevError_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFloatSpringState_Velocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFloatSpringState_Velocity_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloatSpringState();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFloatSpringState_Reset(IntPtr self);
		
		#endregion
		
		#region Property
		public float PrevError
		{
			get => E_PROP_FFloatSpringState_PrevError_GET(NativePointer);
			set => E_PROP_FFloatSpringState_PrevError_SET(NativePointer, value);
		}

		public float Velocity
		{
			get => E_PROP_FFloatSpringState_Velocity_GET(NativePointer);
			set => E_PROP_FFloatSpringState_Velocity_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Reset()
			=> E_FFloatSpringState_Reset(this);
		
		#endregion
		
		public static implicit operator IntPtr(FFloatSpringState self)
		{
			return self.NativePointer;
		}

		public static implicit operator FFloatSpringState(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFloatSpringState(Adress, false);
		}}}
