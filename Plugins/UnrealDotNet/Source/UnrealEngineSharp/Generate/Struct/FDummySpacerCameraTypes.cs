// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraStackTypes.h:15

namespace UnrealEngine
{
	public partial class FDummySpacerCameraTypes : NativeStructWrapper
	{
		public FDummySpacerCameraTypes(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FDummySpacerCameraTypes() :
			base(E_CreateStruct_FDummySpacerCameraTypes(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDummySpacerCameraTypes();
		
		#endregion
		
		public static implicit operator IntPtr(FDummySpacerCameraTypes self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FDummySpacerCameraTypes(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FDummySpacerCameraTypes(adress, false);
		}}}
