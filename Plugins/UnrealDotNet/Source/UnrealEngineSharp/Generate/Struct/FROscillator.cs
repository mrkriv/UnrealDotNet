// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraShake.h:81

namespace UnrealEngine
{
	public partial class FROscillator : NativeStructWrapper
	{
		public FROscillator(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FROscillator() :
			base(E_CreateStruct_FROscillator(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FROscillator_Pitch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FROscillator_Pitch_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FROscillator_Roll_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FROscillator_Roll_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FROscillator_Yaw_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FROscillator_Yaw_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FROscillator();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Pitch oscillation.
		/// </summary>
		public FFOscillator Pitch
		{
			get => E_PROP_FROscillator_Pitch_GET(NativePointer);
			set => E_PROP_FROscillator_Pitch_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Roll oscillation.
		/// </summary>
		public FFOscillator Roll
		{
			get => E_PROP_FROscillator_Roll_GET(NativePointer);
			set => E_PROP_FROscillator_Roll_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Yaw oscillation.
		/// </summary>
		public FFOscillator Yaw
		{
			get => E_PROP_FROscillator_Yaw_GET(NativePointer);
			set => E_PROP_FROscillator_Yaw_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FROscillator self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FROscillator(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FROscillator(adress, false);
		}}}
