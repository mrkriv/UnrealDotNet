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
	public  partial class FMaterialSpriteElement : NativeStructWrapper
	{
		internal FMaterialSpriteElement(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
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
		/// <para>The base width of the sprite, multiplied with the DistanceToSizeCurve. </para>
		/// </summary>
		public float BaseSizeX
		{
			get => E_PROP_FMaterialSpriteElement_BaseSizeX_GET(NativePointer);
			set => E_PROP_FMaterialSpriteElement_BaseSizeX_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The base height of the sprite, multiplied with the DistanceToSizeCurve. </para>
		/// </summary>
		public float BaseSizeY
		{
			get => E_PROP_FMaterialSpriteElement_BaseSizeY_GET(NativePointer);
			set => E_PROP_FMaterialSpriteElement_BaseSizeY_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FMaterialSpriteElement self)
		{
			return self.NativePointer;
		}

		public static implicit operator FMaterialSpriteElement(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FMaterialSpriteElement(Adress, false);
		}}}
