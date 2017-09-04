using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UAudioComponent : USceneComponent
	{
		public UAudioComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UAudioComponent_GetAudioComponentUserID(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UAudioComponent_PlayInternal(IntPtr Self, float StartTime, float FadeInDuration, float FadeVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UAudioComponent_SetSoundParameter(IntPtr Self, IntPtr Param);
		
		#endregion
		
		#region ExternMethods
		public string GetAudioComponentUserID()
			=> Marshal.PtrToStringUTF8(E_UAudioComponent_GetAudioComponentUserID(this, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// <para>Utility function called by Play and FadeIn to start a sound playing. </para>
		/// </summary>
		protected void PlayInternal(float StartTime, float FadeInDuration, float FadeVolumeLevel)
			=> E_UAudioComponent_PlayInternal(this, StartTime, FadeInDuration, FadeVolumeLevel);
		
		
		/// <summary>
		/// <para>Sets the sound instance parameter. </para>
		/// </summary>
		public void SetSoundParameter(FAudioComponentParam Param)
			=> E_UAudioComponent_SetSoundParameter(this, Param);
		
		#endregion
		
		public static implicit operator IntPtr(UAudioComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UAudioComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UAudioComponent ?? new UAudioComponent(Adress);
		}}}
