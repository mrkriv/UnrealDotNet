// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SphereReflectionCaptureComponent.h:13

namespace UnrealEngine
{
	public  partial class USphereReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public USphereReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USphereReflectionCaptureComponent(UObject Parent = null, string Name = "SphereReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USphereReflectionCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USphereReflectionCaptureComponent_CaptureDistanceScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USphereReflectionCaptureComponent_CaptureDistanceScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USphereReflectionCaptureComponent_InfluenceRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USphereReflectionCaptureComponent_InfluenceRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_USphereReflectionCaptureComponent_PreviewInfluenceRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USphereReflectionCaptureComponent_PreviewInfluenceRadius_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USphereReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		public float CaptureDistanceScale
		{
			get => E_PROP_USphereReflectionCaptureComponent_CaptureDistanceScale_GET(NativePointer);
			set => E_PROP_USphereReflectionCaptureComponent_CaptureDistanceScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Radius of the area that can receive reflections from this capture.
		/// </summary>
		public float InfluenceRadius
		{
			get => E_PROP_USphereReflectionCaptureComponent_InfluenceRadius_GET(NativePointer);
			set => E_PROP_USphereReflectionCaptureComponent_InfluenceRadius_SET(NativePointer, value);
		}

		public UDrawSphereComponent PreviewInfluenceRadius
		{
			get => E_PROP_USphereReflectionCaptureComponent_PreviewInfluenceRadius_GET(NativePointer);
			set => E_PROP_USphereReflectionCaptureComponent_PreviewInfluenceRadius_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(USphereReflectionCaptureComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USphereReflectionCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USphereReflectionCaptureComponent>(PtrDesc);
		}}}
