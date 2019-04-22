// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1343

namespace UnrealEngine
{
	public  partial class FFractureEffect : NativeStructWrapper
	{
		internal FFractureEffect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFractureEffect() :
			base(E_CreateStruct_FFractureEffect(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFractureEffect();
		
		#endregion
		
		public static implicit operator IntPtr(FFractureEffect self)
		{
			return self.NativePointer;
		}

		public static implicit operator FFractureEffect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFractureEffect(Adress, false);
		}}}
