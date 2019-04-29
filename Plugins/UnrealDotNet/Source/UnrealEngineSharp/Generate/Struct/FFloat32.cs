// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Float32.h:10

namespace UnrealEngine
{
	public  partial class FFloat32 : NativeStructWrapper
	{
		internal FFloat32(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="inValue">value of the float.</param>
		public FFloat32(float inValue) :
			base(E_CreateStruct_FFloat32_float(inValue), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloat32_float(float inValue);
		
		#endregion
		
		public static implicit operator IntPtr(FFloat32 self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFloat32(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFloat32(Adress, false);
		}}}
