// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DrawFrustumComponent.h:18

namespace UnrealEngine
{
	public  partial class UDrawFrustumComponent : UPrimitiveComponent
	{
		public UDrawFrustumComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UDrawFrustumComponent(UObject Parent = null, string Name = "DrawFrustumComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDrawFrustumComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDrawFrustumComponent_FrustumAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDrawFrustumComponent_FrustumAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDrawFrustumComponent_FrustumAspectRatio_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDrawFrustumComponent_FrustumAspectRatio_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDrawFrustumComponent_FrustumEndDist_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDrawFrustumComponent_FrustumEndDist_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDrawFrustumComponent_FrustumStartDist_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDrawFrustumComponent_FrustumStartDist_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDrawFrustumComponent(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Angle of longest dimension of view shape.
		/// <para>If the angle is 0 then an orthographic projection is used </para>
		/// </summary>
		public float FrustumAngle
		{
			get => E_PROP_UDrawFrustumComponent_FrustumAngle_GET(NativePointer);
			set => E_PROP_UDrawFrustumComponent_FrustumAngle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Ratio of horizontal size over vertical size.
		/// </summary>
		public float FrustumAspectRatio
		{
			get => E_PROP_UDrawFrustumComponent_FrustumAspectRatio_GET(NativePointer);
			set => E_PROP_UDrawFrustumComponent_FrustumAspectRatio_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance from origin to stop drawing the frustum.
		/// </summary>
		public float FrustumEndDist
		{
			get => E_PROP_UDrawFrustumComponent_FrustumEndDist_GET(NativePointer);
			set => E_PROP_UDrawFrustumComponent_FrustumEndDist_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Distance from origin to start drawing the frustum.
		/// </summary>
		public float FrustumStartDist
		{
			get => E_PROP_UDrawFrustumComponent_FrustumStartDist_GET(NativePointer);
			set => E_PROP_UDrawFrustumComponent_FrustumStartDist_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UDrawFrustumComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UDrawFrustumComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UDrawFrustumComponent>(PtrDesc);
		}}}
