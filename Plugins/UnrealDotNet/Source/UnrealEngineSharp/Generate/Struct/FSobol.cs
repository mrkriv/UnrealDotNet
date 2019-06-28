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
	public partial class FSobol : NativeStructWrapper
	{
		public FSobol(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FSobol() :
			base(E_CreateStruct_FSobol(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FSobol_MaxCell2DBits_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FSobol_MaxCell3DBits_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FSobol_MaxDimension_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSobol();
		
		#endregion
		
		#region Property
		public static int MaxCell2DBits
		{
			get => E_PROP_FSobol_MaxCell2DBits_GET();
		}

		public static int MaxCell3DBits
		{
			get => E_PROP_FSobol_MaxCell3DBits_GET();
		}

		public static int MaxDimension
		{
			get => E_PROP_FSobol_MaxDimension_GET();
		}

		#endregion
		
		public static implicit operator IntPtr(FSobol self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSobol(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FSobol(adress, false);
		}}}
