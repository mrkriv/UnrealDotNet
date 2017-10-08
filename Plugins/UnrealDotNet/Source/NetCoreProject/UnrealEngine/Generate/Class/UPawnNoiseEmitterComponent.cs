using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPawnNoiseEmitterComponent : UActorComponent
	{
		public UPawnNoiseEmitterComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPawnNoiseEmitterComponent(UObject Parent = null, string Name = "PawnNoiseEmitterComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnNoiseEmitterComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnNoiseEmitterComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPawnNoiseEmitterComponent_GetLastNoiseTime(IntPtr Self, bool bSourceWithinNoiseEmitter);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(IntPtr Self, bool bSourceWithinNoiseEmitter);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnNoiseEmitterComponent_MakeNoise(IntPtr Self, IntPtr NoiseMaker, float Loudness, IntPtr NoiseLocation);
		
		#endregion
		
		#region ExternMethods
		public float GetLastNoiseTime(bool bSourceWithinNoiseEmitter)
			=> E_UPawnNoiseEmitterComponent_GetLastNoiseTime(this, bSourceWithinNoiseEmitter);
		
		public float GetLastNoiseVolume(bool bSourceWithinNoiseEmitter)
			=> E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(this, bSourceWithinNoiseEmitter);
		
		
		/// <summary>
		/// <para>Cache noises instigated by the owning pawn for AI sensing </para>
		/// <param name="NoiseMaker">is the actual actor which made the noise </param>
		/// <param name="Loudness">is the relative loudness of the noise (0.0 to 1.0) </param>
		/// <param name="NoiseLocation">is the position of the noise </param>
		/// </summary>
		public virtual void MakeNoise(AActor NoiseMaker, float Loudness, FVector NoiseLocation)
			=> E_UPawnNoiseEmitterComponent_MakeNoise(this, NoiseMaker, Loudness, NoiseLocation);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnNoiseEmitterComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPawnNoiseEmitterComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnNoiseEmitterComponent>(PtrDesc);
		}}}
