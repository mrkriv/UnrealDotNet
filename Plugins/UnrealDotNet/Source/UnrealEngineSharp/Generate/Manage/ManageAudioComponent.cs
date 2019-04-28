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
	[ManageType("ManageAudioComponent")]
	public partial class ManageAudioComponent : UAudioComponent
	{
		public ManageAudioComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// This can be used in place of "play" when it is desired to fade in the sound over time.
		/// <para>If FadeTime is 0.0, the change in volume is instant. </para>
		/// If FadeTime is > 0.0, the multiplier will be increased from 0 to FadeVolumeLevel over FadeIn seconds.
		/// </summary>
		/// <param name="fadeInDuration">how long it should take to reach the FadeVolumeLevel</param>
		/// <param name="fadeVolumeLevel">the percentage of the AudioComponents's calculated volume to fade to</param>
		public override void FadeIn(float fadeInDuration, float fadeVolumeLevel, float startTime) { }
		
		
		/// <summary>
		/// This is used in place of "stop" when it is desired to fade the volume of the sound before stopping.
		/// <para>If FadeTime is 0.0, this is the same as calling Stop(). </para>
		/// If FadeTime is > 0.0, this will adjust the volume multiplier to FadeVolumeLevel over FadeInTime seconds
		/// <para>and then stop the sound. </para>
		/// </summary>
		/// <param name="fadeOutDuration">how long it should take to reach the FadeVolumeLevel</param>
		/// <param name="fadeVolumeLevel">the percentage of the AudioComponents's calculated volume in which to fade to</param>
		public override void FadeOut(float fadeOutDuration, float fadeVolumeLevel) { }
		
		
		/// <summary>
		/// Start a sound playing on an audio component
		/// </summary>
		public override void Play(float startTime) { }
		
		
		/// <summary>
		/// Stop an audio component playing its sound cue, issue any delegates if needed
		/// </summary>
		public override void Stop() { }
		
		public static implicit operator IntPtr(ManageAudioComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageAudioComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageAudioComponent>(PtrDesc);
		}}}
