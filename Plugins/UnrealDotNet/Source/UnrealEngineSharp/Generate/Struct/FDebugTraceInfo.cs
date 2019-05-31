// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:21

namespace UnrealEngine
{
	public  partial class FDebugTraceInfo : NativeStructWrapper
	{
		internal FDebugTraceInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDebugTraceInfo() :
			base(E_CreateStruct_FDebugTraceInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugTraceInfo_CapsuleHalfHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTraceInfo_CapsuleHalfHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugTraceInfo_CapsuleRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTraceInfo_CapsuleRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugTraceInfo_HitImpactNormalEnd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTraceInfo_HitImpactNormalEnd_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugTraceInfo_HitLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTraceInfo_HitLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugTraceInfo_HitNormalEnd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTraceInfo_HitNormalEnd_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugTraceInfo_HitNormalStart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTraceInfo_HitNormalStart_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugTraceInfo_LineTraceEnd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTraceInfo_LineTraceEnd_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugTraceInfo_LineTraceStart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTraceInfo_LineTraceStart_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDebugTraceInfo();
		
		#endregion
		
		#region Property
		public float CapsuleHalfHeight
		{
			get => E_PROP_FDebugTraceInfo_CapsuleHalfHeight_GET(NativePointer);
			set => E_PROP_FDebugTraceInfo_CapsuleHalfHeight_SET(NativePointer, value);
		}

		public float CapsuleRadius
		{
			get => E_PROP_FDebugTraceInfo_CapsuleRadius_GET(NativePointer);
			set => E_PROP_FDebugTraceInfo_CapsuleRadius_SET(NativePointer, value);
		}

		public FVector HitImpactNormalEnd
		{
			get => E_PROP_FDebugTraceInfo_HitImpactNormalEnd_GET(NativePointer);
			set => E_PROP_FDebugTraceInfo_HitImpactNormalEnd_SET(NativePointer, value);
		}

		public FVector HitLocation
		{
			get => E_PROP_FDebugTraceInfo_HitLocation_GET(NativePointer);
			set => E_PROP_FDebugTraceInfo_HitLocation_SET(NativePointer, value);
		}

		public FVector HitNormalEnd
		{
			get => E_PROP_FDebugTraceInfo_HitNormalEnd_GET(NativePointer);
			set => E_PROP_FDebugTraceInfo_HitNormalEnd_SET(NativePointer, value);
		}

		public FVector HitNormalStart
		{
			get => E_PROP_FDebugTraceInfo_HitNormalStart_GET(NativePointer);
			set => E_PROP_FDebugTraceInfo_HitNormalStart_SET(NativePointer, value);
		}

		public FVector LineTraceEnd
		{
			get => E_PROP_FDebugTraceInfo_LineTraceEnd_GET(NativePointer);
			set => E_PROP_FDebugTraceInfo_LineTraceEnd_SET(NativePointer, value);
		}

		public FVector LineTraceStart
		{
			get => E_PROP_FDebugTraceInfo_LineTraceStart_GET(NativePointer);
			set => E_PROP_FDebugTraceInfo_LineTraceStart_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDebugTraceInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FDebugTraceInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FDebugTraceInfo(adress, false);
		}}}
