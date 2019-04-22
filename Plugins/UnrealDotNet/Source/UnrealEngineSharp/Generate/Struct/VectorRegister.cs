// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\UnrealMathFPU.h:14

namespace UnrealEngine
{
	public  partial class VectorRegister : NativeStructWrapper
	{
		internal VectorRegister(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public VectorRegister() :
			base(E_CreateStruct_VectorRegister(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_VectorRegister();
		
		#endregion
		
		public static implicit operator IntPtr(VectorRegister self)
		{
			return self.NativePointer;
		}

		public static implicit operator VectorRegister(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new VectorRegister(Adress, false);
		}}}
