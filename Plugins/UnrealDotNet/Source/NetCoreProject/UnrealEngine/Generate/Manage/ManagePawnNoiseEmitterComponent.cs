using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManagePawnNoiseEmitterComponent : UPawnNoiseEmitterComponent
	{
		public ManagePawnNoiseEmitterComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Cache noises instigated by the owning pawn for AI sensing </para>
		/// <param name="NoiseMaker">- is the actual actor which made the noise </param>
		/// <param name="Loudness">- is the relative loudness of the noise (0.0 to 1.0) </param>
		/// <param name="NoiseLocation">- is the position of the noise </param>
		/// </summary>
		public override void MakeNoise(AActor NoiseMaker, float Loudness, FVector NoiseLocation) { }
		
		public static implicit operator IntPtr(ManagePawnNoiseEmitterComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManagePawnNoiseEmitterComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ManagePawnNoiseEmitterComponent ?? new ManagePawnNoiseEmitterComponent(Adress);
		}}}
