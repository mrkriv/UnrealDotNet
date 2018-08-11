using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:108

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAudioComponent(IntPtr Parent, string Name);
		
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
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_AdjustVolume(IntPtr Self, float AdjustVolumeDuration, float AdjustVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_FadeIn(IntPtr Self, float FadeInDuration, float FadeVolumeLevel, float StartTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_FadeOut(IntPtr Self, float FadeOutDuration, float FadeVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAudioComponent_GetAudioComponentUserID(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsPlaying(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_Play(IntPtr Self, float StartTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PlayInternal(IntPtr Self, float StartTime, float FadeInDuration, float FadeVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetBoolParameter(IntPtr Self, string InName, bool InBool);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetFloatParameter(IntPtr Self, string InName, float InFloat);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetIntParameter(IntPtr Self, string InName, int InInt);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetLowPassFilterEnabled(IntPtr Self, bool InLowPassFilterEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetLowPassFilterFrequency(IntPtr Self, float InLowPassFilterFrequency);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetPaused(IntPtr Self, bool bPause);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetPitchMultiplier(IntPtr Self, float NewPitchMultiplier);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetSoundParameter(IntPtr Self, IntPtr Param);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetUISound(IntPtr Self, bool bInUISound);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetVolumeMultiplier(IntPtr Self, float NewVolumeMultiplier);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_Stop(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>A count of how many times we've started playing </para>
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
		/// <para>Options for how we handle our location when we attach to the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment, EAttachmentRule </para>
		/// </summary>
		public EAttachmentRule AutoAttachLocationRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachLocationRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachLocationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Options for how we handle our rotation when we attach to the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment, EAttachmentRule </para>
		/// </summary>
		public EAttachmentRule AutoAttachRotationRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachRotationRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachRotationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Options for how we handle our scale when we attach to the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment, EAttachmentRule </para>
		/// </summary>
		public EAttachmentRule AutoAttachScaleRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachScaleRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachScaleRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment </para>
		/// </summary>
		public string AutoAttachSocketName
		{
			get => E_PROP_UAudioComponent_AutoAttachSocketName_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachSocketName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The attack time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this audio component. Only used in audio mixer. </para>
		/// </summary>
		public int EnvelopeFollowerAttackTime
		{
			get => E_PROP_UAudioComponent_EnvelopeFollowerAttackTime_GET(NativePointer);
			set => E_PROP_UAudioComponent_EnvelopeFollowerAttackTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The release time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this audio component. Only used in audio mixer. </para>
		/// </summary>
		public int EnvelopeFollowerReleaseTime
		{
			get => E_PROP_UAudioComponent_EnvelopeFollowerReleaseTime_GET(NativePointer);
			set => E_PROP_UAudioComponent_EnvelopeFollowerReleaseTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The frequency of the lowpass filter (in hertz) to apply to this voice. A frequency of 0.0 is the device sample rate and will bypass the filter. </para>
		/// </summary>
		public float LowPassFilterFrequency
		{
			get => E_PROP_UAudioComponent_LowPassFilterFrequency_GET(NativePointer);
			set => E_PROP_UAudioComponent_LowPassFilterFrequency_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>while playing, this component will check for occlusion from its closest listener every this many seconds </para>
		/// </summary>
		public float OcclusionCheckInterval
		{
			get => E_PROP_UAudioComponent_OcclusionCheckInterval_GET(NativePointer);
			set => E_PROP_UAudioComponent_OcclusionCheckInterval_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The upper bound to use when randomly determining a pitch multiplier </para>
		/// </summary>
		public float PitchModulationMax
		{
			get => E_PROP_UAudioComponent_PitchModulationMax_GET(NativePointer);
			set => E_PROP_UAudioComponent_PitchModulationMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The lower bound to use when randomly determining a pitch multiplier </para>
		/// </summary>
		public float PitchModulationMin
		{
			get => E_PROP_UAudioComponent_PitchModulationMin_GET(NativePointer);
			set => E_PROP_UAudioComponent_PitchModulationMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>A pitch multiplier to apply to sounds generated by this component </para>
		/// </summary>
		public float PitchMultiplier
		{
			get => E_PROP_UAudioComponent_PitchMultiplier_GET(NativePointer);
			set => E_PROP_UAudioComponent_PitchMultiplier_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>A priority value that is used for sounds that play on this component that scales against final output volume. </para>
		/// </summary>
		public float Priority
		{
			get => E_PROP_UAudioComponent_Priority_GET(NativePointer);
			set => E_PROP_UAudioComponent_Priority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Used by the subtitle manager to prioritize subtitles wave instances spawned by this component. </para>
		/// </summary>
		public float SubtitlePriority
		{
			get => E_PROP_UAudioComponent_SubtitlePriority_GET(NativePointer);
			set => E_PROP_UAudioComponent_SubtitlePriority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The upper bound to use when randomly determining a volume multiplier </para>
		/// </summary>
		public float VolumeModulationMax
		{
			get => E_PROP_UAudioComponent_VolumeModulationMax_GET(NativePointer);
			set => E_PROP_UAudioComponent_VolumeModulationMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The lower bound to use when randomly determining a volume multiplier </para>
		/// </summary>
		public float VolumeModulationMin
		{
			get => E_PROP_UAudioComponent_VolumeModulationMin_GET(NativePointer);
			set => E_PROP_UAudioComponent_VolumeModulationMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>A volume multiplier to apply to sounds generated by this component </para>
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
		
		internal void InvokeEvent_OnAudioMultiEnvelopeValue(float AverageEnvelopeValue, float MaxEnvelope, int NumWaveInstances)
		{
			_Event_OnAudioMultiEnvelopeValue?.Invoke(AverageEnvelopeValue, MaxEnvelope, NumWaveInstances);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>This will allow one to adjust the volume of an AudioComponent on the fly </para>
		/// </summary>
		public void AdjustVolume(float AdjustVolumeDuration, float AdjustVolumeLevel)
			=> E_UAudioComponent_AdjustVolume(this, AdjustVolumeDuration, AdjustVolumeLevel);
		
		
		/// <summary>
		/// <para>This can be used in place of "play" when it is desired to fade in the sound over time. </para>
		/// <para>If FadeTime is 0.0, the change in volume is instant. </para>
		/// <para>If FadeTime is > 0.0, the multiplier will be increased from 0 to FadeVolumeLevel over FadeIn seconds. </para>
		/// <param name="FadeInDuration">how long it should take to reach the FadeVolumeLevel </param>
		/// <param name="FadeVolumeLevel">the percentage of the AudioComponents's calculated volume to fade to </param>
		/// </summary>
		public virtual void FadeIn(float FadeInDuration, float FadeVolumeLevel, float StartTime)
			=> E_UAudioComponent_FadeIn(this, FadeInDuration, FadeVolumeLevel, StartTime);
		
		
		/// <summary>
		/// <para>This is used in place of "stop" when it is desired to fade the volume of the sound before stopping. </para>
		/// <para>If FadeTime is 0.0, this is the same as calling Stop(). </para>
		/// <para>If FadeTime is > 0.0, this will adjust the volume multiplier to FadeVolumeLevel over FadeInTime seconds </para>
		/// <para>and then stop the sound. </para>
		/// <param name="FadeOutDuration">how long it should take to reach the FadeVolumeLevel </param>
		/// <param name="FadeVolumeLevel">the percentage of the AudioComponents's calculated volume in which to fade to </param>
		/// </summary>
		public virtual void FadeOut(float FadeOutDuration, float FadeVolumeLevel)
			=> E_UAudioComponent_FadeOut(this, FadeOutDuration, FadeVolumeLevel);
		
		public string GetAudioComponentUserID()
			=> E_UAudioComponent_GetAudioComponentUserID(this);
		
		
		/// <summary>
		/// <return>true if this component is currently playing a SoundCue. </return>
		/// </summary>
		public virtual bool IsPlaying()
			=> E_UAudioComponent_IsPlaying(this);
		
		
		/// <summary>
		/// <para>Start a sound playing on an audio component </para>
		/// </summary>
		public virtual void Play(float StartTime)
			=> E_UAudioComponent_Play(this, StartTime);
		
		
		/// <summary>
		/// <para>Utility function called by Play and FadeIn to start a sound playing. </para>
		/// </summary>
		protected void PlayInternal(float StartTime, float FadeInDuration, float FadeVolumeLevel)
			=> E_UAudioComponent_PlayInternal(this, StartTime, FadeInDuration, FadeVolumeLevel);
		
		
		/// <summary>
		/// <para>Set a boolean instance parameter for use in sound cues played by this audio component </para>
		/// </summary>
		public void SetBooleanParameter(string InName, bool InBool)
			=> E_UAudioComponent_SetBoolParameter(this, InName, InBool);
		
		
		/// <summary>
		/// <para>Set a float instance parameter for use in sound cues played by this audio component </para>
		/// </summary>
		public void SetFloatParameter(string InName, float InFloat)
			=> E_UAudioComponent_SetFloatParameter(this, InName, InFloat);
		
		
		/// <summary>
		/// <para>Set an integer instance parameter for use in sound cues played by this audio component </para>
		/// </summary>
		public void SetIntegerParameter(string InName, int InInt)
			=> E_UAudioComponent_SetIntParameter(this, InName, InInt);
		
		
		/// <summary>
		/// <para>Sets whether or not the low pass filter is enabled on the audio component. </para>
		/// </summary>
		public void SetLowPassFilterEnabled(bool InLowPassFilterEnabled)
			=> E_UAudioComponent_SetLowPassFilterEnabled(this, InLowPassFilterEnabled);
		
		
		/// <summary>
		/// <para>Sets lowpass filter frequency of the audio component. </para>
		/// </summary>
		public void SetLowPassFilterFrequency(float InLowPassFilterFrequency)
			=> E_UAudioComponent_SetLowPassFilterFrequency(this, InLowPassFilterFrequency);
		
		
		/// <summary>
		/// <para>Pause an audio component playing its sound cue, issue any delegates if needed </para>
		/// </summary>
		public void SetPaused(bool bPause)
			=> E_UAudioComponent_SetPaused(this, bPause);
		
		
		/// <summary>
		/// <para>Set a new pitch multiplier </para>
		/// </summary>
		public void SetPitchMultiplier(float NewPitchMultiplier)
			=> E_UAudioComponent_SetPitchMultiplier(this, NewPitchMultiplier);
		
		
		/// <summary>
		/// <para>Sets the sound instance parameter. </para>
		/// </summary>
		public void SetSoundParameter(FAudioComponentParam Param)
			=> E_UAudioComponent_SetSoundParameter(this, Param);
		
		
		/// <summary>
		/// <para>Set whether sounds generated by this audio component should be considered UI sounds </para>
		/// </summary>
		public void SetUISound(bool bInUISound)
			=> E_UAudioComponent_SetUISound(this, bInUISound);
		
		
		/// <summary>
		/// <para>Set a new volume multiplier </para>
		/// </summary>
		public void SetVolumeMultiplier(float NewVolumeMultiplier)
			=> E_UAudioComponent_SetVolumeMultiplier(this, NewVolumeMultiplier);
		
		
		/// <summary>
		/// <para>Stop an audio component playing its sound cue, issue any delegates if needed </para>
		/// </summary>
		public virtual void Stop()
			=> E_UAudioComponent_Stop(this);
		
		#endregion
		
		public static implicit operator IntPtr(UAudioComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UAudioComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAudioComponent>(PtrDesc);
		}}}
