// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:134

namespace UnrealEngine
{
	public  partial class FDynamicResolutionStateInfos : NativeStructWrapper
	{
		internal FDynamicResolutionStateInfos(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDynamicResolutionStateInfos() :
			base(E_CreateStruct_FDynamicResolutionStateInfos(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDynamicResolutionStateInfos_ResolutionFractionApproximation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDynamicResolutionStateInfos_ResolutionFractionApproximation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDynamicResolutionStateInfos_ResolutionFractionUpperBound_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDynamicResolutionStateInfos_ResolutionFractionUpperBound_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FDynamicResolutionStateInfos_Status_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDynamicResolutionStateInfos_Status_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDynamicResolutionStateInfos();
		
		#endregion
		
		#region Property
		public float ResolutionFractionApproximation
		{
			get => E_PROP_FDynamicResolutionStateInfos_ResolutionFractionApproximation_GET(NativePointer);
			set => E_PROP_FDynamicResolutionStateInfos_ResolutionFractionApproximation_SET(NativePointer, value);
		}

		public float ResolutionFractionUpperBound
		{
			get => E_PROP_FDynamicResolutionStateInfos_ResolutionFractionUpperBound_GET(NativePointer);
			set => E_PROP_FDynamicResolutionStateInfos_ResolutionFractionUpperBound_SET(NativePointer, value);
		}

		public EDynamicResolutionStatus Status
		{
			get => (EDynamicResolutionStatus)E_PROP_FDynamicResolutionStateInfos_Status_GET(NativePointer);
			set => E_PROP_FDynamicResolutionStateInfos_Status_SET(NativePointer, (byte)value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDynamicResolutionStateInfos self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FDynamicResolutionStateInfos(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FDynamicResolutionStateInfos(adress, false);
		}}}
