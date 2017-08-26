using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FRotator
	{
		
		public float Pitch { get; set; }
		public float Yaw { get; set; }
		public float Roll { get; set; }
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FRotator_IsNearlyZero(FRotator Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FRotator_IsZero(FRotator Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FRotator_Equals(FRotator Self, FRotator R, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_FRotator_Add(FRotator Self, float DeltaPitch, float DeltaYaw, float DeltaRoll);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FRotator_Vector(FRotator Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FRotator_Quaternion(FRotator Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FRotator_RotateVector(FRotator Self, FVector V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FRotator_Normalize(FRotator Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FRotator_GetWindingAndRemainder(FRotator Self, FRotator Winding, FRotator Remainder);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FRotator_ClampAxis(FRotator Self, float Angle);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern byte E_FRotator_CompressAxisToByte(FRotator Self, float Angle);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_FRotator_MakeFromEuler(FRotator Self, FVector Euler);
		
		#endregion
		
		#region ExternMethods
		public bool IsNearlyZero(float Tolerance)
		{
			return E_FRotator_IsNearlyZero(this, Tolerance);
		}

		public bool IsZero()
		{
			return E_FRotator_IsZero(this);
		}

		public bool Equals(FRotator R, float Tolerance)
		{
			return E_FRotator_Equals(this, R, Tolerance);
		}

		public FRotator Add(float DeltaPitch, float DeltaYaw, float DeltaRoll)
		{
			return E_FRotator_Add(this, DeltaPitch, DeltaYaw, DeltaRoll);
		}

		public FVector Vector()
		{
			return E_FRotator_Vector(this);
		}

		public FQuat Quaternion()
		{
			return E_FRotator_Quaternion(this);
		}

		public FVector RotateVector(FVector V)
		{
			return E_FRotator_RotateVector(this, V);
		}

		public void Normalize()
		{
			E_FRotator_Normalize(this);
		}

		public void GetWindingAndRemainder(FRotator Winding, FRotator Remainder)
		{
			E_FRotator_GetWindingAndRemainder(this, Winding, Remainder);
		}

		public float ClampAxis(float Angle)
		{
			return E_FRotator_ClampAxis(this, Angle);
		}

		public byte CompressAxisToByte(float Angle)
		{
			return E_FRotator_CompressAxisToByte(this, Angle);
		}

		public FRotator MakeFromEuler(FVector Euler)
		{
			return E_FRotator_MakeFromEuler(this, Euler);
		}

		#endregion
		
	}}
