// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ArrowComponent.h:19

namespace UnrealEngine
{
	public  partial class UArrowComponent : UPrimitiveComponent
	{
		public UArrowComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UArrowComponent(UObject Parent = null, string Name = "ArrowComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UArrowComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UArrowComponent_ArrowSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UArrowComponent_ArrowSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UArrowComponent_bIsScreenSizeScaled_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UArrowComponent_bIsScreenSizeScaled_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UArrowComponent_ScreenSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UArrowComponent_ScreenSize_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UArrowComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UArrowComponent_SetArrowColor(IntPtr self, IntPtr newColor);
		
		#endregion
		
		#region Property
		public float ArrowSize
		{
			get => E_PROP_UArrowComponent_ArrowSize_GET(NativePointer);
			set => E_PROP_UArrowComponent_ArrowSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Set to limit the screen size of this arrow
		/// </summary>
		public bool bIsScreenSizeScaled
		{
			get => E_PROP_UArrowComponent_bIsScreenSizeScaled_GET(NativePointer);
			set => E_PROP_UArrowComponent_bIsScreenSizeScaled_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The size on screen to limit this arrow to (in screen space)
		/// </summary>
		public float ScreenSize
		{
			get => E_PROP_UArrowComponent_ScreenSize_GET(NativePointer);
			set => E_PROP_UArrowComponent_ScreenSize_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Updates the arrow's colour, and tells it to refresh
		/// </summary>
		public virtual void SetArrowColor(FLinearColor newColor)
			=> E_UArrowComponent_SetArrowColor(this, newColor);
		
		#endregion
		
		public static implicit operator IntPtr(UArrowComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UArrowComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UArrowComponent>(PtrDesc);
		}}}
