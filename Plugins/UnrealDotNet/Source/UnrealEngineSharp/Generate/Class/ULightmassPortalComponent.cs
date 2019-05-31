// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightmassPortalComponent.h:12

namespace UnrealEngine
{
	public  partial class ULightmassPortalComponent : USceneComponent
	{
		public ULightmassPortalComponent(IntPtr adress)
			: base(adress)
		{
		}

		public ULightmassPortalComponent(UObject Parent = null, string Name = "LightmassPortalComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULightmassPortalComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_ULightmassPortalComponent_PreviewBox_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULightmassPortalComponent_PreviewBox_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULightmassPortalComponent(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		public UBoxComponent PreviewBox
		{
			get => E_PROP_ULightmassPortalComponent_PreviewBox_GET(NativePointer);
			set => E_PROP_ULightmassPortalComponent_PreviewBox_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(ULightmassPortalComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ULightmassPortalComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULightmassPortalComponent>(PtrDesc);
		}}}
