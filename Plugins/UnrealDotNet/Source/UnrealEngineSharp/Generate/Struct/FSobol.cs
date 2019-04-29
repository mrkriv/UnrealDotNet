// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Sobol.h:12

namespace UnrealEngine
{
	public  partial class FSobol : NativeStructWrapper
	{
		internal FSobol(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSobol() :
			base(E_CreateStruct_FSobol(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSobol();
		
		#endregion
		
		public static implicit operator IntPtr(FSobol self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSobol(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSobol(Adress, false);
		}}}
