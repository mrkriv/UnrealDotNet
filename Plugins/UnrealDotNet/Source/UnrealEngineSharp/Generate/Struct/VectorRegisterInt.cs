// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\UnrealMathFPU.h:22

namespace UnrealEngine
{
	public  partial class VectorRegisterInt : NativeStructWrapper
	{
		internal VectorRegisterInt(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public VectorRegisterInt() :
			base(E_CreateStruct_VectorRegisterInt(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_VectorRegisterInt();
		
		#endregion
		
		public static implicit operator IntPtr(VectorRegisterInt self)
		{
			return self.NativePointer;
		}

		public static implicit operator VectorRegisterInt(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new VectorRegisterInt(Adress, false);
		}}}
