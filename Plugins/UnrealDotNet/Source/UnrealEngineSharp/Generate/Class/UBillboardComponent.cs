// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BillboardComponent.h:19

namespace UnrealEngine
{
	public  partial class UBillboardComponent : UPrimitiveComponent
	{
		public UBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UBillboardComponent(UObject Parent = null, string Name = "BillboardComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBillboardComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBillboardComponent_ScreenSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBillboardComponent_ScreenSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBillboardComponent_U_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBillboardComponent_U_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBillboardComponent_UL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBillboardComponent_UL_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBillboardComponent_V_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBillboardComponent_V_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBillboardComponent_VL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBillboardComponent_VL_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBillboardComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBillboardComponent_SetUV(IntPtr self, int newU, int newUL, int newV, int newVL);
		
		#endregion
		
		#region Property
		public float ScreenSize
		{
			get => E_PROP_UBillboardComponent_ScreenSize_GET(NativePointer);
			set => E_PROP_UBillboardComponent_ScreenSize_SET(NativePointer, value);
		}

		public float U
		{
			get => E_PROP_UBillboardComponent_U_GET(NativePointer);
			set => E_PROP_UBillboardComponent_U_SET(NativePointer, value);
		}

		public float UL
		{
			get => E_PROP_UBillboardComponent_UL_GET(NativePointer);
			set => E_PROP_UBillboardComponent_UL_SET(NativePointer, value);
		}

		public float V
		{
			get => E_PROP_UBillboardComponent_V_GET(NativePointer);
			set => E_PROP_UBillboardComponent_V_SET(NativePointer, value);
		}

		public float VL
		{
			get => E_PROP_UBillboardComponent_VL_GET(NativePointer);
			set => E_PROP_UBillboardComponent_VL_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Change the sprite's UVs
		/// </summary>
		public virtual void SetUV(int newU, int newUL, int newV, int newVL)
			=> E_UBillboardComponent_SetUV(this, newU, newUL, newV, newVL);
		
		#endregion
		
		public static implicit operator IntPtr(UBillboardComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBillboardComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBillboardComponent>(PtrDesc);
		}}}
