// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EQSRenderingComponent.h:84

namespace UnrealEngine
{
	public partial class UEQSRenderingComponent : UPrimitiveComponent
	{
		public UEQSRenderingComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UEQSRenderingComponent(UObject Parent = null, string Name = "EQSRenderingComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEQSRenderingComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEQSRenderingComponent_DrawFlagName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEQSRenderingComponent_DrawFlagName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEQSRenderingComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEQSRenderingComponent_ClearStoredDebugData(IntPtr self);
		
		#endregion
		
		#region Property
		public string DrawFlagName
		{
			get => E_PROP_UEQSRenderingComponent_DrawFlagName_GET(NativePointer);
			set => E_PROP_UEQSRenderingComponent_DrawFlagName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ClearStoredDebugData()
			=> E_UEQSRenderingComponent_ClearStoredDebugData(this);
		
		#endregion
		
		public static implicit operator IntPtr(UEQSRenderingComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEQSRenderingComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEQSRenderingComponent>(PtrDesc);
		}}}
