// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:57

namespace UnrealEngine
{
	public  partial class FBatchedPoint : NativeStructWrapper
	{
		internal FBatchedPoint(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBatchedPoint() :
			base(E_CreateStruct_FBatchedPoint(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBatchedPoint_DepthPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedPoint_DepthPriority_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBatchedPoint_PointSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedPoint_PointSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBatchedPoint_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedPoint_Position_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBatchedPoint_RemainingLifeTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedPoint_RemainingLifeTime_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBatchedPoint();
		
		#endregion
		
		#region Property
		public byte DepthPriority
		{
			get => E_PROP_FBatchedPoint_DepthPriority_GET(NativePointer);
			set => E_PROP_FBatchedPoint_DepthPriority_SET(NativePointer, value);
		}

		public float PointSize
		{
			get => E_PROP_FBatchedPoint_PointSize_GET(NativePointer);
			set => E_PROP_FBatchedPoint_PointSize_SET(NativePointer, value);
		}

		public FVector Position
		{
			get => E_PROP_FBatchedPoint_Position_GET(NativePointer);
			set => E_PROP_FBatchedPoint_Position_SET(NativePointer, value);
		}

		public float RemainingLifeTime
		{
			get => E_PROP_FBatchedPoint_RemainingLifeTime_GET(NativePointer);
			set => E_PROP_FBatchedPoint_RemainingLifeTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBatchedPoint self)
		{
			return self.NativePointer;
		}

		public static implicit operator FBatchedPoint(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBatchedPoint(Adress, false);
		}}}
