// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:16

namespace UnrealEngine
{
	public partial class FBatchedLine : NativeStructWrapper
	{
		public FBatchedLine(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBatchedLine() :
			base(E_CreateStruct_FBatchedLine(), false)
		{
		}

		public FBatchedLine(FVector inStart, FVector inEnd, FLinearColor inColor, float inLifeTime, float inThickness, byte inDepthPriority) :
			base(E_CreateStruct_FBatchedLine_FVector_FVector_FLinearColor_float_float_uint8(inStart, inEnd, inColor, inLifeTime, inThickness, inDepthPriority), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBatchedLine_Color_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_Color_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBatchedLine_DepthPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_DepthPriority_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBatchedLine_End_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_End_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBatchedLine_RemainingLifeTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_RemainingLifeTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBatchedLine_Start_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_Start_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBatchedLine_Thickness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBatchedLine_Thickness_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBatchedLine();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBatchedLine_FVector_FVector_FLinearColor_float_float_uint8(IntPtr inStart, IntPtr inEnd, IntPtr inColor, float inLifeTime, float inThickness, byte inDepthPriority);
		
		#endregion
		
		#region Property
		public FLinearColor Color
		{
			get => E_PROP_FBatchedLine_Color_GET(NativePointer);
			set => E_PROP_FBatchedLine_Color_SET(NativePointer, value);
		}

		public byte DepthPriority
		{
			get => E_PROP_FBatchedLine_DepthPriority_GET(NativePointer);
			set => E_PROP_FBatchedLine_DepthPriority_SET(NativePointer, value);
		}

		public FVector End
		{
			get => E_PROP_FBatchedLine_End_GET(NativePointer);
			set => E_PROP_FBatchedLine_End_SET(NativePointer, value);
		}

		public float RemainingLifeTime
		{
			get => E_PROP_FBatchedLine_RemainingLifeTime_GET(NativePointer);
			set => E_PROP_FBatchedLine_RemainingLifeTime_SET(NativePointer, value);
		}

		public FVector Start
		{
			get => E_PROP_FBatchedLine_Start_GET(NativePointer);
			set => E_PROP_FBatchedLine_Start_SET(NativePointer, value);
		}

		public float Thickness
		{
			get => E_PROP_FBatchedLine_Thickness_GET(NativePointer);
			set => E_PROP_FBatchedLine_Thickness_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBatchedLine self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBatchedLine(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBatchedLine(adress, false);
		}}}
