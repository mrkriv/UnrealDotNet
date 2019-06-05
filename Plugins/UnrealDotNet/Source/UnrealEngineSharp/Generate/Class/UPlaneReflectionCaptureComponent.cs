// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PlaneReflectionCaptureComponent.h:13

namespace UnrealEngine
{
	public partial class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public UPlaneReflectionCaptureComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UPlaneReflectionCaptureComponent(UObject Parent = null, string Name = "PlaneReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPlaneReflectionCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPlaneReflectionCaptureComponent_InfluenceRadiusScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlaneReflectionCaptureComponent_InfluenceRadiusScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UPlaneReflectionCaptureComponent_PreviewCaptureBox_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlaneReflectionCaptureComponent_PreviewCaptureBox_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UPlaneReflectionCaptureComponent_PreviewInfluenceRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlaneReflectionCaptureComponent_PreviewInfluenceRadius_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPlaneReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Radius of the area that can receive reflections from this capture.
		/// </summary>
		public float InfluenceRadiusScale
		{
			get => E_PROP_UPlaneReflectionCaptureComponent_InfluenceRadiusScale_GET(NativePointer);
			set => E_PROP_UPlaneReflectionCaptureComponent_InfluenceRadiusScale_SET(NativePointer, value);
		}

		public UBoxComponent PreviewCaptureBox
		{
			get => E_PROP_UPlaneReflectionCaptureComponent_PreviewCaptureBox_GET(NativePointer);
			set => E_PROP_UPlaneReflectionCaptureComponent_PreviewCaptureBox_SET(NativePointer, value);
		}

		public UDrawSphereComponent PreviewInfluenceRadius
		{
			get => E_PROP_UPlaneReflectionCaptureComponent_PreviewInfluenceRadius_GET(NativePointer);
			set => E_PROP_UPlaneReflectionCaptureComponent_PreviewInfluenceRadius_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UPlaneReflectionCaptureComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPlaneReflectionCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPlaneReflectionCaptureComponent>(PtrDesc);
		}}}
