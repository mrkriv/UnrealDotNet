// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:573

namespace UnrealEngine
{
	public  partial class FWeightedBlendables : NativeStructWrapper
	{
		internal FWeightedBlendables(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FWeightedBlendables() :
			base(E_CreateStruct_FWeightedBlendables(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FWeightedBlendables_Array_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWeightedBlendables_Array_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWeightedBlendables();
		
		#endregion
		
		#region Property
		public TArray<FWeightedBlendable> Array
		{
			get => E_PROP_FWeightedBlendables_Array_GET(NativePointer);
			set => E_PROP_FWeightedBlendables_Array_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FWeightedBlendables self)
		{
			return self.NativePointer;
		}

		public static implicit operator FWeightedBlendables(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWeightedBlendables(Adress, false);
		}}}
