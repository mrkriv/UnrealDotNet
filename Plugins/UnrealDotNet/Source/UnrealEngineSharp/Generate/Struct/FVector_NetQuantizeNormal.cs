// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\NetSerialization.h:1498

namespace UnrealEngine
{
	public partial class FVector_NetQuantizeNormal : FVector
	{
		public FVector_NetQuantizeNormal(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FVector_NetQuantizeNormal() :
			base(E_CreateStruct_FVector_NetQuantizeNormal(), false)
		{
		}

		public FVector_NetQuantizeNormal(float inX, float inY, float inZ) :
			base(E_CreateStruct_FVector_NetQuantizeNormal_float_float_float(inX, inY, inZ), false)
		{
		}

		public FVector_NetQuantizeNormal(FVector inVec) :
			base(E_CreateStruct_FVector_NetQuantizeNormal_FVector(inVec), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_NetQuantizeNormal();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_NetQuantizeNormal_float_float_float(float inX, float inY, float inZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_NetQuantizeNormal_FVector(IntPtr inVec);
		
		#endregion
		
		public static implicit operator IntPtr(FVector_NetQuantizeNormal self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FVector_NetQuantizeNormal(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FVector_NetQuantizeNormal(adress, false);
		}}}
