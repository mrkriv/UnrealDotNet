// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:110

namespace UnrealEngine
{
	public  partial class UAudioComponent : USceneComponent
	{
		public UAudioComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UAudioComponent(UObject Parent = null, string Name = "AudioComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAudioComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UAudioComponent_ActiveCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_ActiveCount_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UAudioComponent_AudioComponentUserID_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AudioComponentUserID_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_AutoAttachLocationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachLocationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_AutoAttachRotationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachRotationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_AutoAttachScaleRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachScaleRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UAudioComponent_AutoAttachSocketName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachSocketName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bAllowSpatialization_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bAllowSpatialization_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bAlwaysPlay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bAlwaysPlay_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bAutoDestroy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bAutoDestroy_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bAutoManageAttachment_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bAutoManageAttachment_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bCenterChannelOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bCenterChannelOnly_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bEnableLowPassFilter_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bEnableLowPassFilter_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bEQFilterApplied_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bEQFilterApplied_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bIgnoreForFlushing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bIgnoreForFlushing_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bIsMusic_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bIsMusic_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bIsPaused_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bIsPaused_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bIsPreviewSound_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bIsPreviewSound_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bIsUISound_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bIsUISound_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bOverrideAttenuation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bOverrideAttenuation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bOverridePriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bOverridePriority_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bOverrideSubtitlePriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bOverrideSubtitlePriority_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bPreviewComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bPreviewComponent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bReverb_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bReverb_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bShouldRemainActiveIfDropped_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bShouldRemainActiveIfDropped_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bStopWhenOwnerDestroyed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bStopWhenOwnerDestroyed_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bSuppressSubtitles_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bSuppressSubtitles_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UAudioComponent_EnvelopeFollowerAttackTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_EnvelopeFollowerAttackTime_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UAudioComponent_EnvelopeFollowerReleaseTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_EnvelopeFollowerReleaseTime_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_LowPassFilterFrequency_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_LowPassFilterFrequency_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_OcclusionCheckInterval_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_OcclusionCheckInterval_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UAudioComponent_OnAudioFinished(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UAudioComponent_OnAudioFinished(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UAudioComponent_OnAudioMultiEnvelopeValue(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UAudioComponent_OnAudioMultiEnvelopeValue(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_PitchModulationMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_PitchModulationMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_PitchModulationMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_PitchModulationMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_PitchMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_PitchMultiplier_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_Priority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_Priority_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_SubtitlePriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_SubtitlePriority_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_VolumeModulationMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_VolumeModulationMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_VolumeModulationMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_VolumeModulationMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAudioComponent_VolumeMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_VolumeMultiplier_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAudioComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_AdjustVolume(IntPtr self, float adjustVolumeDuration, float adjustVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_CancelAutoAttachment(IntPtr self, bool bDetachFromParent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_FadeIn(IntPtr self, float fadeInDuration, float fadeVolumeLevel, float startTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_FadeOut(IntPtr self, float fadeOutDuration, float fadeVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAudioComponent_GetAudioComponentUserID(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_GetCookedEnvelopeData(IntPtr self, float outEnvelopeData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_HasCookedAmplitudeEnvelopeData(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_HasCookedFFTData(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsPlaying(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_Play(IntPtr self, float startTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PlayInternal(IntPtr self, float startTime, float fadeInDuration, float fadeVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetBoolParameter(IntPtr self, string inName, bool inBool);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetFloatParameter(IntPtr self, string inName, float inFloat);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetIntParameter(IntPtr self, string inName, int inInt);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetLowPassFilterEnabled(IntPtr self, bool inLowPassFilterEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetLowPassFilterFrequency(IntPtr self, float inLowPassFilterFrequency);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetPaused(IntPtr self, bool bPause);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetPitchMultiplier(IntPtr self, float newPitchMultiplier);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetSoundParameter(IntPtr self, IntPtr param);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetUISound(IntPtr self, bool bInUISound);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetVolumeMultiplier(IntPtr self, float newVolumeMultiplier);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_Stop(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// A count of how many times we've started playing
		/// </summary>
		public int ActiveCount
		{
			get => E_PROP_UAudioComponent_ActiveCount_GET(NativePointer);
			set => E_PROP_UAudioComponent_ActiveCount_SET(NativePointer, value);
		}

		public string AudioComponentUserID
		{
			get => E_PROP_UAudioComponent_AudioComponentUserID_GET(NativePointer);
			set => E_PROP_UAudioComponent_AudioComponentUserID_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Options for how we handle our location when we attach to the AutoAttachParent, if bAutoManageAttachment is true.
		/// <see cref="bAutoManageAttachment"/>
		/// </summary>
		public EAttachmentRule AutoAttachLocationRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachLocationRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachLocationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Options for how we handle our rotation when we attach to the AutoAttachParent, if bAutoManageAttachment is true.
		/// <see cref="bAutoManageAttachment"/>
		/// </summary>
		public EAttachmentRule AutoAttachRotationRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachRotationRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachRotationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Options for how we handle our scale when we attach to the AutoAttachParent, if bAutoManageAttachment is true.
		/// <see cref="bAutoManageAttachment"/>
		/// </summary>
		public EAttachmentRule AutoAttachScaleRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachScaleRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachScaleRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true.
		/// <para>@see bAutoManageAttachment </para>
		/// </summary>
		public string AutoAttachSocketName
		{
			get => E_PROP_UAudioComponent_AutoAttachSocketName_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachSocketName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Overrides spatialization enablement in either the attenuation asset or on this audio component's attenuation settings override.
		/// </summary>
		public byte bAllowSpatialization
		{
			get => E_PROP_UAudioComponent_bAllowSpatialization_GET(NativePointer);
			set => E_PROP_UAudioComponent_bAllowSpatialization_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to artificially prioritize the component to play
		/// </summary>
		public byte bAlwaysPlay
		{
			get => E_PROP_UAudioComponent_bAlwaysPlay_GET(NativePointer);
			set => E_PROP_UAudioComponent_bAlwaysPlay_SET(NativePointer, value);
		}

		public byte bAutoDestroy
		{
			get => E_PROP_UAudioComponent_bAutoDestroy_GET(NativePointer);
			set => E_PROP_UAudioComponent_bAutoDestroy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True if we should automatically attach to AutoAttachParent when Played, and detach from our parent when playback is completed.
		/// <para>This overrides any current attachment that may be present at the time of activation (deferring initial attachment until activation, if AutoAttachParent is null). </para>
		/// If enabled, this AudioComponent's WorldLocation will no longer be reliable when not currently playing audio, and any attach children will also be detached/attached along with it.
		/// <para>When enabled, detachment occurs regardless of whether AutoAttachParent is assigned, and the relative transform from the time of activation is restored. </para>
		/// This also disables attachment on dedicated servers, where we don't actually activate even if bAutoActivate is true.
		/// <see cref="AutoAttachParent"/>
		/// </summary>
		public byte bAutoManageAttachment
		{
			get => E_PROP_UAudioComponent_bAutoManageAttachment_GET(NativePointer);
			set => E_PROP_UAudioComponent_bAutoManageAttachment_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not this sound class forces sounds to the center channel
		/// </summary>
		public byte bCenterChannelOnly
		{
			get => E_PROP_UAudioComponent_bCenterChannelOnly_GET(NativePointer);
			set => E_PROP_UAudioComponent_bCenterChannelOnly_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not to apply a low-pass filter to the sound that plays in this audio component.
		/// </summary>
		public byte bEnableLowPassFilter
		{
			get => E_PROP_UAudioComponent_bEnableLowPassFilter_GET(NativePointer);
			set => E_PROP_UAudioComponent_bEnableLowPassFilter_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether audio effects are applied
		/// </summary>
		public byte bEQFilterApplied
		{
			get => E_PROP_UAudioComponent_bEQFilterApplied_GET(NativePointer);
			set => E_PROP_UAudioComponent_bEQFilterApplied_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this sound will not be stopped when flushing the audio device.
		/// </summary>
		public byte bIgnoreForFlushing
		{
			get => E_PROP_UAudioComponent_bIgnoreForFlushing_GET(NativePointer);
			set => E_PROP_UAudioComponent_bIgnoreForFlushing_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not this audio component is a music clip
		/// </summary>
		public byte bIsMusic
		{
			get => E_PROP_UAudioComponent_bIsMusic_GET(NativePointer);
			set => E_PROP_UAudioComponent_bIsMusic_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not this audio component has been paused
		/// </summary>
		public byte bIsPaused
		{
			get => E_PROP_UAudioComponent_bIsPaused_GET(NativePointer);
			set => E_PROP_UAudioComponent_bIsPaused_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not this sound is a preview sound
		/// </summary>
		public byte bIsPreviewSound
		{
			get => E_PROP_UAudioComponent_bIsPreviewSound_GET(NativePointer);
			set => E_PROP_UAudioComponent_bIsPreviewSound_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not this sound plays when the game is paused in the UI
		/// </summary>
		public byte bIsUISound
		{
			get => E_PROP_UAudioComponent_bIsUISound_GET(NativePointer);
			set => E_PROP_UAudioComponent_bIsUISound_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Allows defining attenuation settings directly on this audio component without using an attenuation settings asset.
		/// </summary>
		public byte bOverrideAttenuation
		{
			get => E_PROP_UAudioComponent_bOverrideAttenuation_GET(NativePointer);
			set => E_PROP_UAudioComponent_bOverrideAttenuation_SET(NativePointer, value);
		}

		public byte bOverridePriority
		{
			get => E_PROP_UAudioComponent_bOverridePriority_GET(NativePointer);
			set => E_PROP_UAudioComponent_bOverridePriority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not to override the sound's subtitle priority.
		/// </summary>
		public byte bOverrideSubtitlePriority
		{
			get => E_PROP_UAudioComponent_bOverrideSubtitlePriority_GET(NativePointer);
			set => E_PROP_UAudioComponent_bOverrideSubtitlePriority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this audio component is previewing a sound
		/// </summary>
		public byte bPreviewComponent
		{
			get => E_PROP_UAudioComponent_bPreviewComponent_GET(NativePointer);
			set => E_PROP_UAudioComponent_bPreviewComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not the audio component should be excluded from reverb EQ processing
		/// </summary>
		public byte bReverb
		{
			get => E_PROP_UAudioComponent_bReverb_GET(NativePointer);
			set => E_PROP_UAudioComponent_bReverb_SET(NativePointer, value);
		}

		public byte bShouldRemainActiveIfDropped
		{
			get => E_PROP_UAudioComponent_bShouldRemainActiveIfDropped_GET(NativePointer);
			set => E_PROP_UAudioComponent_bShouldRemainActiveIfDropped_SET(NativePointer, value);
		}

		public byte bStopWhenOwnerDestroyed
		{
			get => E_PROP_UAudioComponent_bStopWhenOwnerDestroyed_GET(NativePointer);
			set => E_PROP_UAudioComponent_bStopWhenOwnerDestroyed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, subtitles in the sound data will be ignored.
		/// </summary>
		public byte bSuppressSubtitles
		{
			get => E_PROP_UAudioComponent_bSuppressSubtitles_GET(NativePointer);
			set => E_PROP_UAudioComponent_bSuppressSubtitles_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The attack time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this audio component. Only used in audio mixer.
		/// </summary>
		public int EnvelopeFollowerAttackTime
		{
			get => E_PROP_UAudioComponent_EnvelopeFollowerAttackTime_GET(NativePointer);
			set => E_PROP_UAudioComponent_EnvelopeFollowerAttackTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The release time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this audio component. Only used in audio mixer.
		/// </summary>
		public int EnvelopeFollowerReleaseTime
		{
			get => E_PROP_UAudioComponent_EnvelopeFollowerReleaseTime_GET(NativePointer);
			set => E_PROP_UAudioComponent_EnvelopeFollowerReleaseTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The frequency of the lowpass filter (in hertz) to apply to this voice. A frequency of 0.0 is the device sample rate and will bypass the filter.
		/// </summary>
		public float LowPassFilterFrequency
		{
			get => E_PROP_UAudioComponent_LowPassFilterFrequency_GET(NativePointer);
			set => E_PROP_UAudioComponent_LowPassFilterFrequency_SET(NativePointer, value);
		}

		
		/// <summary>
		/// while playing, this component will check for occlusion from its closest listener every this many seconds
		/// </summary>
		public float OcclusionCheckInterval
		{
			get => E_PROP_UAudioComponent_OcclusionCheckInterval_GET(NativePointer);
			set => E_PROP_UAudioComponent_OcclusionCheckInterval_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The upper bound to use when randomly determining a pitch multiplier
		/// </summary>
		public float PitchModulationMax
		{
			get => E_PROP_UAudioComponent_PitchModulationMax_GET(NativePointer);
			set => E_PROP_UAudioComponent_PitchModulationMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The lower bound to use when randomly determining a pitch multiplier
		/// </summary>
		public float PitchModulationMin
		{
			get => E_PROP_UAudioComponent_PitchModulationMin_GET(NativePointer);
			set => E_PROP_UAudioComponent_PitchModulationMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// A pitch multiplier to apply to sounds generated by this component
		/// </summary>
		public float PitchMultiplier
		{
			get => E_PROP_UAudioComponent_PitchMultiplier_GET(NativePointer);
			set => E_PROP_UAudioComponent_PitchMultiplier_SET(NativePointer, value);
		}

		
		/// <summary>
		/// A priority value that is used for sounds that play on this component that scales against final output volume.
		/// </summary>
		public float Priority
		{
			get => E_PROP_UAudioComponent_Priority_GET(NativePointer);
			set => E_PROP_UAudioComponent_Priority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Used by the subtitle manager to prioritize subtitles wave instances spawned by this component.
		/// </summary>
		public float SubtitlePriority
		{
			get => E_PROP_UAudioComponent_SubtitlePriority_GET(NativePointer);
			set => E_PROP_UAudioComponent_SubtitlePriority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The upper bound to use when randomly determining a volume multiplier
		/// </summary>
		public float VolumeModulationMax
		{
			get => E_PROP_UAudioComponent_VolumeModulationMax_GET(NativePointer);
			set => E_PROP_UAudioComponent_VolumeModulationMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The lower bound to use when randomly determining a volume multiplier
		/// </summary>
		public float VolumeModulationMin
		{
			get => E_PROP_UAudioComponent_VolumeModulationMin_GET(NativePointer);
			set => E_PROP_UAudioComponent_VolumeModulationMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// A volume multiplier to apply to sounds generated by this component
		/// </summary>
		public float VolumeMultiplier
		{
			get => E_PROP_UAudioComponent_VolumeMultiplier_GET(NativePointer);
			set => E_PROP_UAudioComponent_VolumeMultiplier_SET(NativePointer, value);
		}

		#endregion
		
		#region Events
		public event FOnAudioFinished OnAudioFinished
		{
			add
			{
				E_EVENT_ADD_UAudioComponent_OnAudioFinished(NativePointer);
				_Event_OnAudioFinished += value;
			}

			remove
			{
				E_EVENT_DEL_UAudioComponent_OnAudioFinished(NativePointer);
				_Event_OnAudioFinished -= value;
			}

		}

		private event FOnAudioFinished _Event_OnAudioFinished;
		
		internal void InvokeEvent_OnAudioFinished()
		{
			_Event_OnAudioFinished?.Invoke();
		}

		public event FOnAudioMultiEnvelopeValue OnAudioMultiEnvelopeValue
		{
			add
			{
				E_EVENT_ADD_UAudioComponent_OnAudioMultiEnvelopeValue(NativePointer);
				_Event_OnAudioMultiEnvelopeValue += value;
			}

			remove
			{
				E_EVENT_DEL_UAudioComponent_OnAudioMultiEnvelopeValue(NativePointer);
				_Event_OnAudioMultiEnvelopeValue -= value;
			}

		}

		private event FOnAudioMultiEnvelopeValue _Event_OnAudioMultiEnvelopeValue;
		
		internal void InvokeEvent_OnAudioMultiEnvelopeValue(float averageEnvelopeValue, float maxEnvelope, int numWaveInstances)
		{
			_Event_OnAudioMultiEnvelopeValue?.Invoke(averageEnvelopeValue, maxEnvelope, numWaveInstances);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// This will allow one to adjust the volume of an AudioComponent on the fly
		/// </summary>
		public void AdjustVolume(float adjustVolumeDuration, float adjustVolumeLevel)
			=> E_UAudioComponent_AdjustVolume(this, adjustVolumeDuration, adjustVolumeLevel);
		
		
		/// <summary>
		/// Restore relative transform from auto attachment and optionally detach from parent (regardless of whether it was an auto attachment).
		/// </summary>
		private void CancelAutoAttachment(bool bDetachFromParent)
			=> E_UAudioComponent_CancelAutoAttachment(this, bDetachFromParent);
		
		
		/// <summary>
		/// This can be used in place of "play" when it is desired to fade in the sound over time.
		/// <para>If FadeTime is 0.0, the change in volume is instant. </para>
		/// If FadeTime is > 0.0, the multiplier will be increased from 0 to FadeVolumeLevel over FadeIn seconds.
		/// </summary>
		/// <param name="fadeInDuration">how long it should take to reach the FadeVolumeLevel</param>
		/// <param name="fadeVolumeLevel">the percentage of the AudioComponents's calculated volume to fade to</param>
		public virtual void FadeIn(float fadeInDuration, float fadeVolumeLevel, float startTime)
			=> E_UAudioComponent_FadeIn(this, fadeInDuration, fadeVolumeLevel, startTime);
		
		
		/// <summary>
		/// This is used in place of "stop" when it is desired to fade the volume of the sound before stopping.
		/// <para>If FadeTime is 0.0, this is the same as calling Stop(). </para>
		/// If FadeTime is > 0.0, this will adjust the volume multiplier to FadeVolumeLevel over FadeInTime seconds
		/// <para>and then stop the sound. </para>
		/// </summary>
		/// <param name="fadeOutDuration">how long it should take to reach the FadeVolumeLevel</param>
		/// <param name="fadeVolumeLevel">the percentage of the AudioComponents's calculated volume in which to fade to</param>
		public virtual void FadeOut(float fadeOutDuration, float fadeVolumeLevel)
			=> E_UAudioComponent_FadeOut(this, fadeOutDuration, fadeVolumeLevel);
		
		public string GetAudioComponentUserID()
			=> E_UAudioComponent_GetAudioComponentUserID(this);
		
		
		/// <summary>
		/// Returns the current cooked envelope data of the playing audio component. Returns true if there is data and the audio component is playing.
		/// </summary>
		public bool GetCookedEnvelopeData(float outEnvelopeData)
			=> E_UAudioComponent_GetCookedEnvelopeData(this, outEnvelopeData);
		
		
		/// <summary>
		/// Queries if the sound wave playing in this audio component has cooked amplitude analyses.
		/// </summary>
		public bool HasCookedAmplitudeEnvelopeData()
			=> E_UAudioComponent_HasCookedAmplitudeEnvelopeData(this);
		
		
		/// <summary>
		/// Queries if the sound wave playing in this audio component has cooked FFT data.
		/// </summary>
		public bool HasCookedFFTData()
			=> E_UAudioComponent_HasCookedFFTData(this);
		
		
		/// <summary>
		/// Returns true if this component is currently playing a SoundCue.
		/// </summary>
		public virtual bool IsPlaying()
			=> E_UAudioComponent_IsPlaying(this);
		
		
		/// <summary>
		/// Start a sound playing on an audio component
		/// </summary>
		public virtual void Play(float startTime)
			=> E_UAudioComponent_Play(this, startTime);
		
		
		/// <summary>
		/// Utility function called by Play and FadeIn to start a sound playing.
		/// </summary>
		protected void PlayInternal(float startTime, float fadeInDuration, float fadeVolumeLevel)
			=> E_UAudioComponent_PlayInternal(this, startTime, fadeInDuration, fadeVolumeLevel);
		
		
		/// <summary>
		/// Set a boolean instance parameter for use in sound cues played by this audio component
		/// </summary>
		public void SetBooleanParameter(string inName, bool inBool)
			=> E_UAudioComponent_SetBoolParameter(this, inName, inBool);
		
		
		/// <summary>
		/// Set a float instance parameter for use in sound cues played by this audio component
		/// </summary>
		public void SetFloatParameter(string inName, float inFloat)
			=> E_UAudioComponent_SetFloatParameter(this, inName, inFloat);
		
		
		/// <summary>
		/// Set an integer instance parameter for use in sound cues played by this audio component
		/// </summary>
		public void SetIntegerParameter(string inName, int inInt)
			=> E_UAudioComponent_SetIntParameter(this, inName, inInt);
		
		
		/// <summary>
		/// Sets whether or not the low pass filter is enabled on the audio component.
		/// </summary>
		public void SetLowPassFilterEnabled(bool inLowPassFilterEnabled)
			=> E_UAudioComponent_SetLowPassFilterEnabled(this, inLowPassFilterEnabled);
		
		
		/// <summary>
		/// Sets lowpass filter frequency of the audio component.
		/// </summary>
		public void SetLowPassFilterFrequency(float inLowPassFilterFrequency)
			=> E_UAudioComponent_SetLowPassFilterFrequency(this, inLowPassFilterFrequency);
		
		
		/// <summary>
		/// Pause an audio component playing its sound cue, issue any delegates if needed
		/// </summary>
		public void SetPaused(bool bPause)
			=> E_UAudioComponent_SetPaused(this, bPause);
		
		
		/// <summary>
		/// Set a new pitch multiplier
		/// </summary>
		public void SetPitchMultiplier(float newPitchMultiplier)
			=> E_UAudioComponent_SetPitchMultiplier(this, newPitchMultiplier);
		
		
		/// <summary>
		/// Sets the sound instance parameter.
		/// </summary>
		public void SetSoundParameter(FAudioComponentParam param)
			=> E_UAudioComponent_SetSoundParameter(this, param);
		
		
		/// <summary>
		/// Set whether sounds generated by this audio component should be considered UI sounds
		/// </summary>
		public void SetUISound(bool bInUISound)
			=> E_UAudioComponent_SetUISound(this, bInUISound);
		
		
		/// <summary>
		/// Set a new volume multiplier
		/// </summary>
		public void SetVolumeMultiplier(float newVolumeMultiplier)
			=> E_UAudioComponent_SetVolumeMultiplier(this, newVolumeMultiplier);
		
		
		/// <summary>
		/// Stop an audio component playing its sound cue, issue any delegates if needed
		/// </summary>
		public virtual void Stop()
			=> E_UAudioComponent_Stop(this);
		
		#endregion
		
		public static implicit operator IntPtr(UAudioComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UAudioComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAudioComponent>(PtrDesc);
		}}}
