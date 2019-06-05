// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraShake.h:42

namespace UnrealEngine
{
	public partial class FFOscillator : NativeStructWrapper
	{
		public FFOscillator(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FFOscillator() :
			base(E_CreateStruct_FFOscillator(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFOscillator_Amplitude_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFOscillator_Amplitude_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFOscillator_Frequency_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFOscillator_Frequency_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FFOscillator_Waveform_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFOscillator_Waveform_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFOscillator();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FFOscillator_GetInitialOffset(IntPtr self, IntPtr osc);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FFOscillator_GetOffsetAtTime(IntPtr self, IntPtr osc, float initialOffset, float time);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FFOscillator_UpdateOffset(IntPtr self, IntPtr osc, float currentOffset, float deltaTime);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Amplitude of the sinusoidal oscillation.
		/// </summary>
		public float Amplitude
		{
			get => E_PROP_FFOscillator_Amplitude_GET(NativePointer);
			set => E_PROP_FFOscillator_Amplitude_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Frequency of the sinusoidal oscillation.
		/// </summary>
		public float Frequency
		{
			get => E_PROP_FFOscillator_Frequency_GET(NativePointer);
			set => E_PROP_FFOscillator_Frequency_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Type of waveform to use for oscillation.
		/// </summary>
		public EOscillatorWaveform Waveform
		{
			get => (EOscillatorWaveform)E_PROP_FFOscillator_Waveform_GET(NativePointer);
			set => E_PROP_FFOscillator_Waveform_SET(NativePointer, (byte)value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns the initial value of the oscillator.
		/// </summary>
		public float GetInitialOffset(FFOscillator osc)
			=> E_FFOscillator_GetInitialOffset(this, osc);
		
		
		/// <summary>
		/// Returns the offset at the given time
		/// </summary>
		public float GetOffsetAtTime(FFOscillator osc, float initialOffset, float time)
			=> E_FFOscillator_GetOffsetAtTime(this, osc, initialOffset, time);
		
		
		/// <summary>
		/// Advances the oscillation time and returns the current value.
		/// </summary>
		public float UpdateOffset(FFOscillator osc, float currentOffset, float deltaTime)
			=> E_FFOscillator_UpdateOffset(this, osc, currentOffset, deltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(FFOscillator self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFOscillator(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FFOscillator(adress, false);
		}}}
