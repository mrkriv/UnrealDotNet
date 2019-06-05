// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ShapeComponent.h:24

namespace UnrealEngine
{
	public partial class UShapeComponent : UPrimitiveComponent
	{
		public UShapeComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UShapeComponent(UObject Parent = null, string Name = "ShapeComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UShapeComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UShapeComponent_bDrawOnlyIfSelected_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UShapeComponent_bDrawOnlyIfSelected_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UShapeComponent_bDynamicObstacle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UShapeComponent_bDynamicObstacle_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UShapeComponent_bShouldCollideWhenPlacing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UShapeComponent_bShouldCollideWhenPlacing_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UShapeComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UShapeComponent_UpdateBodySetup(IntPtr self);
		
		#endregion
		
		#region Property
		public byte bDrawOnlyIfSelected
		{
			get => E_PROP_UShapeComponent_bDrawOnlyIfSelected_GET(NativePointer);
			set => E_PROP_UShapeComponent_bDrawOnlyIfSelected_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If set, shape will be exported for navigation as dynamic modifier instead of using regular collision data
		/// </summary>
		public byte bDynamicObstacle
		{
			get => E_PROP_UShapeComponent_bDynamicObstacle_GET(NativePointer);
			set => E_PROP_UShapeComponent_bDynamicObstacle_SET(NativePointer, value);
		}

		public byte bShouldCollideWhenPlacing
		{
			get => E_PROP_UShapeComponent_bShouldCollideWhenPlacing_GET(NativePointer);
			set => E_PROP_UShapeComponent_bShouldCollideWhenPlacing_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Update the body setup parameters based on shape information
		/// </summary>
		public virtual void UpdateBodySetup()
			=> E_UShapeComponent_UpdateBodySetup(this);
		
		#endregion
		
		public static implicit operator IntPtr(UShapeComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UShapeComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UShapeComponent>(PtrDesc);
		}}}
