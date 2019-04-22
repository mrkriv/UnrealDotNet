// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\IntVector.h:460

namespace UnrealEngine
{
	public  partial class FIntVector4 : NativeStructWrapper
	{
		internal FIntVector4(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FIntVector4() :
			base(E_CreateStruct_FIntVector4(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntVector4();
		
		#endregion
		
		public static implicit operator IntPtr(FIntVector4 self)
		{
			return self.NativePointer;
		}

		public static implicit operator FIntVector4(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FIntVector4(Adress, false);
		}}}
