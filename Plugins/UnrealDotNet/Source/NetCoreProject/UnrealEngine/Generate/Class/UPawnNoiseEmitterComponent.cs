using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// PawnNoiseEmitterComponent tracks noise event data used by SensingComponents to hear a Pawn.
	/// This component is intended to exist on either a Pawn or its Controller. It does nothing on network clients.
	/// </summary>
	public partial class UPawnNoiseEmitterComponent : UActorComponent
	{
		public UPawnNoiseEmitterComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UPawnNoiseEmitterComponent_MakeNoise(IntPtr Self, IntPtr NoiseMaker, float Loudness, IntPtr NoiseLocation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(IntPtr Self, bool bSourceWithinNoiseEmitter);
		
		#endregion
		
		#region Property
		public FVector LastRemoteNoisePosition
		{
			get => E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_GET(NativePointer);
			set => E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_SET(NativePointer, value);
		}

		public float NoiseLifetime
		{
			get => E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_GET(NativePointer);
			set => E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Cache noises instigated by the owning pawn for AI sensing
		/// @param NoiseMaker - is the actual actor which made the noise
		/// @param Loudness - is the relative loudness of the noise (0.0 to 1.0)
		/// @param NoiseLocation - is the position of the noise
		/// </summary>
		public void MakeNoise(AActor NoiseMaker, float Loudness, FVector NoiseLocation)
			=> E_UPawnNoiseEmitterComponent_MakeNoise(NativePointer, NoiseMaker, Loudness, NoiseLocation);
		
		public float GetLastNoiseVolume(bool bSourceWithinNoiseEmitter)
			=> E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(NativePointer, bSourceWithinNoiseEmitter);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnNoiseEmitterComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPawnNoiseEmitterComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UPawnNoiseEmitterComponent(Adress);
		}}}
