// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\NetSerialization.h:1362

namespace UnrealEngine
{
	public partial class FVector_NetQuantize : FVector
	{
		public FVector_NetQuantize(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FVector_NetQuantize() :
			base(E_CreateStruct_FVector_NetQuantize(), false)
		{
		}

		public FVector_NetQuantize(float inX, float inY, float inZ) :
			base(E_CreateStruct_FVector_NetQuantize_float_float_float(inX, inY, inZ), false)
		{
		}

		public FVector_NetQuantize(FVector inVec) :
			base(E_CreateStruct_FVector_NetQuantize_FVector(inVec), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_NetQuantize();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_NetQuantize_float_float_float(float inX, float inY, float inZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_NetQuantize_FVector(IntPtr inVec);
		
		#endregion
		
		public static implicit operator IntPtr(FVector_NetQuantize self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FVector_NetQuantize(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FVector_NetQuantize(adress, false);
		}}}
