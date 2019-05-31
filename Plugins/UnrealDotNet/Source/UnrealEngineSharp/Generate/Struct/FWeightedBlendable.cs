// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:543

namespace UnrealEngine
{
	public  partial class FWeightedBlendable : NativeStructWrapper
	{
		internal FWeightedBlendable(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FWeightedBlendable() :
			base(E_CreateStruct_FWeightedBlendable(), false)
		{
		}

		public FWeightedBlendable(float inWeight, UObject inObject) :
			base(E_CreateStruct_FWeightedBlendable_float_UObject(inWeight, inObject), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FWeightedBlendable_Object_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWeightedBlendable_Object_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FWeightedBlendable_Weight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWeightedBlendable_Weight_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWeightedBlendable();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWeightedBlendable_float_UObject(float inWeight, IntPtr inObject);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// should be of the IBlendableInterface* type but UProperties cannot express that
		/// </summary>
		public UObject Object
		{
			get => E_PROP_FWeightedBlendable_Object_GET(NativePointer);
			set => E_PROP_FWeightedBlendable_Object_SET(NativePointer, value);
		}

		
		/// <summary>
		/// 0:no effect .. 1:full effect
		/// </summary>
		public float Weight
		{
			get => E_PROP_FWeightedBlendable_Weight_GET(NativePointer);
			set => E_PROP_FWeightedBlendable_Weight_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FWeightedBlendable self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FWeightedBlendable(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FWeightedBlendable(adress, false);
		}}}
