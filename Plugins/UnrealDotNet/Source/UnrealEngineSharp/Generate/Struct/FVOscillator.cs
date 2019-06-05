// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraShake.h:101

namespace UnrealEngine
{
	public partial class FVOscillator : NativeStructWrapper
	{
		public FVOscillator(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FVOscillator() :
			base(E_CreateStruct_FVOscillator(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVOscillator_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVOscillator_X_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVOscillator_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVOscillator_Y_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVOscillator_Z_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVOscillator_Z_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVOscillator();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Oscillation in the X axis.
		/// </summary>
		public FFOscillator X
		{
			get => E_PROP_FVOscillator_X_GET(NativePointer);
			set => E_PROP_FVOscillator_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Oscillation in the Y axis.
		/// </summary>
		public FFOscillator Y
		{
			get => E_PROP_FVOscillator_Y_GET(NativePointer);
			set => E_PROP_FVOscillator_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Oscillation in the Z axis.
		/// </summary>
		public FFOscillator Z
		{
			get => E_PROP_FVOscillator_Z_GET(NativePointer);
			set => E_PROP_FVOscillator_Z_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FVOscillator self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FVOscillator(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FVOscillator(adress, false);
		}}}
