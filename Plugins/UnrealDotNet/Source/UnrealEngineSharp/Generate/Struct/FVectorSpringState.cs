// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Kismet\KismetMathLibrary.h:111

namespace UnrealEngine
{
	public  partial class FVectorSpringState : NativeStructWrapper
	{
		internal FVectorSpringState(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FVectorSpringState() :
			base(E_CreateStruct_FVectorSpringState(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVectorSpringState_PrevError_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVectorSpringState_PrevError_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVectorSpringState_Velocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVectorSpringState_Velocity_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVectorSpringState();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVectorSpringState_Reset(IntPtr self);
		
		#endregion
		
		#region Property
		public FVector PrevError
		{
			get => E_PROP_FVectorSpringState_PrevError_GET(NativePointer);
			set => E_PROP_FVectorSpringState_PrevError_SET(NativePointer, value);
		}

		public FVector Velocity
		{
			get => E_PROP_FVectorSpringState_Velocity_GET(NativePointer);
			set => E_PROP_FVectorSpringState_Velocity_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Reset()
			=> E_FVectorSpringState_Reset(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVectorSpringState self)
		{
			return self.NativePointer;
		}

		public static implicit operator FVectorSpringState(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVectorSpringState(Adress, false);
		}}}
