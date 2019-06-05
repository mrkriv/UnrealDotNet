// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:37

namespace UnrealEngine
{
	public partial class FPaintedVertex : NativeStructWrapper
	{
		public FPaintedVertex(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPaintedVertex() :
			base(E_CreateStruct_FPaintedVertex(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPaintedVertex_Normal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPaintedVertex_Normal_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPaintedVertex_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPaintedVertex_Position_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPaintedVertex();
		
		#endregion
		
		#region Property
		public FVector4 Normal
		{
			get => E_PROP_FPaintedVertex_Normal_GET(NativePointer);
			set => E_PROP_FPaintedVertex_Normal_SET(NativePointer, value);
		}

		public FVector Position
		{
			get => E_PROP_FPaintedVertex_Position_GET(NativePointer);
			set => E_PROP_FPaintedVertex_Position_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPaintedVertex self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPaintedVertex(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPaintedVertex(adress, false);
		}}}
