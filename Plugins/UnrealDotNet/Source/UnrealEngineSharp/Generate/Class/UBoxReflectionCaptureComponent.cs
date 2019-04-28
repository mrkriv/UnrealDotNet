// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BoxReflectionCaptureComponent.h:13

namespace UnrealEngine
{
	public  partial class UBoxReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public UBoxReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UBoxReflectionCaptureComponent(UObject Parent = null, string Name = "BoxReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBoxReflectionCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBoxReflectionCaptureComponent_BoxTransitionDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBoxReflectionCaptureComponent_BoxTransitionDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UBoxReflectionCaptureComponent_PreviewCaptureBox_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBoxReflectionCaptureComponent_PreviewCaptureBox_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UBoxReflectionCaptureComponent_PreviewInfluenceBox_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBoxReflectionCaptureComponent_PreviewInfluenceBox_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBoxReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Adjust capture transition distance
		/// </summary>
		public float BoxTransitionDistance
		{
			get => E_PROP_UBoxReflectionCaptureComponent_BoxTransitionDistance_GET(NativePointer);
			set => E_PROP_UBoxReflectionCaptureComponent_BoxTransitionDistance_SET(NativePointer, value);
		}

		public UBoxComponent PreviewCaptureBox
		{
			get => E_PROP_UBoxReflectionCaptureComponent_PreviewCaptureBox_GET(NativePointer);
			set => E_PROP_UBoxReflectionCaptureComponent_PreviewCaptureBox_SET(NativePointer, value);
		}

		public UBoxComponent PreviewInfluenceBox
		{
			get => E_PROP_UBoxReflectionCaptureComponent_PreviewInfluenceBox_GET(NativePointer);
			set => E_PROP_UBoxReflectionCaptureComponent_PreviewInfluenceBox_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBoxReflectionCaptureComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UBoxReflectionCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBoxReflectionCaptureComponent>(PtrDesc);
		}}}
