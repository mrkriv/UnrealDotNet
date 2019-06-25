// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionTypes.h:128

namespace UnrealEngine
{
	public partial class FAIStimulus : NativeStructWrapper
	{
		public FAIStimulus(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// this is the recommended constructor. Use others if you know what you're doing.
		/// </summary>
		public FAIStimulus(UAISense sense, float stimulusStrength, FVector inStimulusLocation, FVector inReceiverLocation, FResult result, string inStimulusTag) :
			base(E_CreateStruct_FAIStimulus_UAISense_float_FVector_FVector_FResult_FName(sense, stimulusStrength, inStimulusLocation, inReceiverLocation, (byte)result, inStimulusTag), false)
		{
		}

		public FAIStimulus() :
			base(E_CreateStruct_FAIStimulus(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAIStimulus_ReceiverLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIStimulus_ReceiverLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAIStimulus_StimulusLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIStimulus_StimulusLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAIStimulus_Strength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIStimulus_Strength_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FAIStimulus_Tag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIStimulus_Tag_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIStimulus_UAISense_float_FVector_FVector_FResult_FName(IntPtr sense, float stimulusStrength, IntPtr inStimulusLocation, IntPtr inReceiverLocation, byte result, string inStimulusTag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIStimulus();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIStimulus_AgeStimulus(IntPtr self, float constPerceptionAgingRate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FAIStimulus_GetAge(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FAIStimulus_GetDebugDescription(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIStimulus_IsActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIStimulus_IsExpired(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIStimulus_IsValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIStimulus_MarkExpired(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIStimulus_MarkNoLongerSensed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIStimulus_SetExpirationAge(IntPtr self, float inExpirationAge);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIStimulus_SetStimulusAge(IntPtr self, float stimulusAge);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIStimulus_SetWantsNotifyOnlyOnValueChange(IntPtr self, bool inEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIStimulus_WantsToNotifyOnlyOnPerceptionChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIStimulus_WasSuccessfullySensed(IntPtr self);
		
		#endregion
		
		#region Property
		public FVector ReceiverLocation
		{
			get => E_PROP_FAIStimulus_ReceiverLocation_GET(NativePointer);
			set => E_PROP_FAIStimulus_ReceiverLocation_SET(NativePointer, value);
		}

		public FVector StimulusLocation
		{
			get => E_PROP_FAIStimulus_StimulusLocation_GET(NativePointer);
			set => E_PROP_FAIStimulus_StimulusLocation_SET(NativePointer, value);
		}

		public float Strength
		{
			get => E_PROP_FAIStimulus_Strength_GET(NativePointer);
			set => E_PROP_FAIStimulus_Strength_SET(NativePointer, value);
		}

		public string Tag
		{
			get => E_PROP_FAIStimulus_Tag_GET(NativePointer);
			set => E_PROP_FAIStimulus_Tag_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// </summary>
		/// <return>false</return>
		public bool AgeStimulus(float constPerceptionAgingRate)
			=> E_FAIStimulus_AgeStimulus(this, constPerceptionAgingRate);
		
		public float GetAge()
			=> E_FAIStimulus_GetAge(this);
		
		public string GetDebugDescription()
			=> E_FAIStimulus_GetDebugDescription(this);
		
		public bool IsActive()
			=> E_FAIStimulus_IsActive(this);
		
		public bool IsExpired()
			=> E_FAIStimulus_IsExpired(this);
		
		public bool IsValid()
			=> E_FAIStimulus_IsValid(this);
		
		public void MarkExpired()
			=> E_FAIStimulus_MarkExpired(this);
		
		public void MarkNoLongerSensed()
			=> E_FAIStimulus_MarkNoLongerSensed(this);
		
		public FAIStimulus SetExpirationAge(float inExpirationAge)
			=> E_FAIStimulus_SetExpirationAge(this, inExpirationAge);
		
		public FAIStimulus SetStimulusAge(float stimulusAge)
			=> E_FAIStimulus_SetStimulusAge(this, stimulusAge);
		
		public FAIStimulus SetWantsNotifyOnlyOnValueChange(bool inEnable)
			=> E_FAIStimulus_SetWantsNotifyOnlyOnValueChange(this, inEnable);
		
		public bool WantsToNotifyOnlyOnPerceptionChange()
			=> E_FAIStimulus_WantsToNotifyOnlyOnPerceptionChange(this);
		
		public bool WasSuccessfullySensed()
			=> E_FAIStimulus_WasSuccessfullySensed(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAIStimulus self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIStimulus(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIStimulus(adress, false);
		}}}
