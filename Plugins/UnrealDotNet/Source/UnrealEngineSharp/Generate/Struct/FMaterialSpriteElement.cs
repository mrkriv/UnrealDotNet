// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\MaterialBillboardComponent.h:16

namespace UnrealEngine
{
	public partial class FMaterialSpriteElement : NativeStructWrapper
	{
		public FMaterialSpriteElement(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FMaterialSpriteElement() :
			base(E_CreateStruct_FMaterialSpriteElement(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMaterialSpriteElement_BaseSizeX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMaterialSpriteElement_BaseSizeX_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMaterialSpriteElement_BaseSizeY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMaterialSpriteElement_BaseSizeY_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMaterialSpriteElement();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The base width of the sprite, multiplied with the DistanceToSizeCurve.
		/// </summary>
		public float BaseSizeX
		{
			get => E_PROP_FMaterialSpriteElement_BaseSizeX_GET(NativePointer);
			set => E_PROP_FMaterialSpriteElement_BaseSizeX_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The base height of the sprite, multiplied with the DistanceToSizeCurve.
		/// </summary>
		public float BaseSizeY
		{
			get => E_PROP_FMaterialSpriteElement_BaseSizeY_GET(NativePointer);
			set => E_PROP_FMaterialSpriteElement_BaseSizeY_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FMaterialSpriteElement self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FMaterialSpriteElement(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FMaterialSpriteElement(adress, false);
		}}}
