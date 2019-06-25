// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AIController.h:56

namespace UnrealEngine
{
	public partial class FFocusKnowledge : NativeStructWrapper
	{
		public FFocusKnowledge(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FFocusKnowledge() :
			base(E_CreateStruct_FFocusKnowledge(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFocusKnowledge();
		
		#endregion
		
		public static implicit operator IntPtr(FFocusKnowledge self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFocusKnowledge(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FFocusKnowledge(adress, false);
		}}}
