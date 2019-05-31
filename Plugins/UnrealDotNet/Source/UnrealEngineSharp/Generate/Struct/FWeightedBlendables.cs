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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWeightedBlendables();
		
		#endregion
		
		public static implicit operator IntPtr(FWeightedBlendables self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FWeightedBlendables(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FWeightedBlendables(adress, false);
		}}}
