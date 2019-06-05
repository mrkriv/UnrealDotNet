// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraModifier_CameraShake.h:19

namespace UnrealEngine
{
	public partial class FPooledCameraShakes : NativeStructWrapper
	{
		public FPooledCameraShakes(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPooledCameraShakes() :
			base(E_CreateStruct_FPooledCameraShakes(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPooledCameraShakes();
		
		#endregion
		
		public static implicit operator IntPtr(FPooledCameraShakes self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPooledCameraShakes(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPooledCameraShakes(adress, false);
		}}}
