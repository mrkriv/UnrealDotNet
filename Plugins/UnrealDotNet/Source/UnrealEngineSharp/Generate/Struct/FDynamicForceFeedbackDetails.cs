// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerController.h:67

namespace UnrealEngine
{
	public  partial class FDynamicForceFeedbackDetails : NativeStructWrapper
	{
		internal FDynamicForceFeedbackDetails(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDynamicForceFeedbackDetails() :
			base(E_CreateStruct_FDynamicForceFeedbackDetails(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDynamicForceFeedbackDetails_Intensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDynamicForceFeedbackDetails_Intensity_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDynamicForceFeedbackDetails();
		
		#endregion
		
		#region Property
		public float Intensity
		{
			get => E_PROP_FDynamicForceFeedbackDetails_Intensity_GET(NativePointer);
			set => E_PROP_FDynamicForceFeedbackDetails_Intensity_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDynamicForceFeedbackDetails self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FDynamicForceFeedbackDetails(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDynamicForceFeedbackDetails(Adress, false);
		}}}
