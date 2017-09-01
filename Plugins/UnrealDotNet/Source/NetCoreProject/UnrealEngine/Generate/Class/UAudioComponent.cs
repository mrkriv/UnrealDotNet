using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// AudioComponent is used to play a Sound
	/// @see https://docs.unrealengine.com/latest/INT/Audio/Overview/index.html
	/// @see USoundBase
	/// </summary>
	public partial class UAudioComponent : USceneComponent
	{
		public UAudioComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UAudioComponent_SetSoundParameter(IntPtr Self, IntPtr Param);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UAudioComponent_GetAudioComponentUserID(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UAudioComponent_PlayInternal(IntPtr Self, float StartTime, float FadeInDuration, float FadeVolumeLevel);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Sets the sound instance parameter.
		/// </summary>
		public void SetSoundParameter(FAudioComponentParam Param)
			=> E_UAudioComponent_SetSoundParameter(NativePointer, Param);
		
		public string GetAudioComponentUserID()
			=> Marshal.PtrToStringUTF8(E_UAudioComponent_GetAudioComponentUserID(NativePointer, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// Utility function called by Play and FadeIn to start a sound playing.
		/// </summary>
		protected void PlayInternal(float StartTime, float FadeInDuration, float FadeVolumeLevel)
			=> E_UAudioComponent_PlayInternal(NativePointer, StartTime, FadeInDuration, FadeVolumeLevel);
		
		#endregion
		
		public static implicit operator IntPtr(UAudioComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UAudioComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UAudioComponent(Adress);
		}}}
