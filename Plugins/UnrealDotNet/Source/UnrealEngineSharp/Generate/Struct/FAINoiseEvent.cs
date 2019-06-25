// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Hearing.h:15

namespace UnrealEngine
{
	public partial class FAINoiseEvent : NativeStructWrapper
	{
		public FAINoiseEvent(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAINoiseEvent() :
			base(E_CreateStruct_FAINoiseEvent(), false)
		{
		}

		public FAINoiseEvent(AActor inInstigator, FVector inNoiseLocation, float inLoudness, float inMaxRange, string tag) :
			base(E_CreateStruct_FAINoiseEvent_AActor_FVector_float_float_FName(inInstigator, inNoiseLocation, inLoudness, inMaxRange, tag), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAINoiseEvent_Age_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAINoiseEvent_Age_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAINoiseEvent_Instigator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAINoiseEvent_Instigator_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAINoiseEvent_Loudness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAINoiseEvent_Loudness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAINoiseEvent_MaxRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAINoiseEvent_MaxRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAINoiseEvent_NoiseLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAINoiseEvent_NoiseLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FAINoiseEvent_Tag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAINoiseEvent_Tag_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAINoiseEvent_TeamIdentifier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAINoiseEvent_TeamIdentifier_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAINoiseEvent();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAINoiseEvent_AActor_FVector_float_float_FName(IntPtr inInstigator, IntPtr inNoiseLocation, float inLoudness, float inMaxRange, string tag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAINoiseEvent_Compile(IntPtr self);
		
		#endregion
		
		#region Property
		public float Age
		{
			get => E_PROP_FAINoiseEvent_Age_GET(NativePointer);
			set => E_PROP_FAINoiseEvent_Age_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Actor triggering the sound.
		/// </summary>
		public AActor Instigator
		{
			get => E_PROP_FAINoiseEvent_Instigator_GET(NativePointer);
			set => E_PROP_FAINoiseEvent_Instigator_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Loudness modifier of the sound.
		/// <para>If MaxRange is non-zero, this modifies the range (by multiplication). </para>
		/// If there is no MaxRange, then if Square(DistanceToSound) <= Square(HearingRange) * Loudness, the sound is heard, false otherwise.
		/// </summary>
		public float Loudness
		{
			get => E_PROP_FAINoiseEvent_Loudness_GET(NativePointer);
			set => E_PROP_FAINoiseEvent_Loudness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max range at which the sound can be heard. Multiplied by Loudness.
		/// <para>A value of 0 indicates that there is no range limit, though listeners are still limited by their own hearing range. </para>
		/// </summary>
		public float MaxRange
		{
			get => E_PROP_FAINoiseEvent_MaxRange_GET(NativePointer);
			set => E_PROP_FAINoiseEvent_MaxRange_SET(NativePointer, value);
		}

		
		/// <summary>
		/// if not set Instigator's location will be used
		/// </summary>
		public FVector NoiseLocation
		{
			get => E_PROP_FAINoiseEvent_NoiseLocation_GET(NativePointer);
			set => E_PROP_FAINoiseEvent_NoiseLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Named identifier for the noise.
		/// </summary>
		public string Tag
		{
			get => E_PROP_FAINoiseEvent_Tag_GET(NativePointer);
			set => E_PROP_FAINoiseEvent_Tag_SET(NativePointer, value);
		}

		public FGenericTeamId TeamIdentifier
		{
			get => E_PROP_FAINoiseEvent_TeamIdentifier_GET(NativePointer);
			set => E_PROP_FAINoiseEvent_TeamIdentifier_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Verifies and calculates derived data
		/// </summary>
		public void Compile()
			=> E_FAINoiseEvent_Compile(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAINoiseEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAINoiseEvent(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAINoiseEvent(adress, false);
		}}}
