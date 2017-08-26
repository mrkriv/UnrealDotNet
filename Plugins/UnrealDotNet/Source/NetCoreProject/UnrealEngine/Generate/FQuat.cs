using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FQuat
	{
		
		public float X { get; set; }
		public float Y { get; set; }
		public float Z { get; set; }
		public float W { get; set; }
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FQuat_Equals(FQuat Self, FQuat Q, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FQuat_IsIdentity(FQuat Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FQuat_MakeFromEuler(FQuat Self, FVector Euler);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FQuat_Euler(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_Normalize(FQuat Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FQuat_GetNormalized(FQuat Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FQuat_IsNormalized(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FQuat_Size(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_ToAxisAndAngle(FQuat Self, FVector Axis, float Angle);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_ToSwingTwist(FQuat Self, FVector InTwistAxis, FQuat OutSwing, FQuat OutTwist);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FQuat_RotateVector(FQuat Self, FVector V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FQuat_Log(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_EnforceShortestArcWith(FQuat Self, FQuat OtherQuat);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_FQuat_Rotator(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FQuat_FindBetween(FQuat Self, FVector Vector1, FVector Vector2);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FQuat_Error(FQuat Self, FQuat Q1, FQuat Q2);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FQuat_FastLerp(FQuat Self, FQuat A, FQuat B, float Alpha);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FQuat_FastBilerp(FQuat Self, FQuat P00, FQuat P10, FQuat P01, FQuat P11, float FracX, float FracY);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FQuat_Slerp_NotNormalized(FQuat Self, FQuat Quat1, FQuat Quat2, float Slerp);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FQuat_Squad(FQuat Self, FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, float Alpha);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_CalcTangents(FQuat Self, FQuat PrevP, FQuat P, FQuat NextP, float Tension, FQuat OutTan);
		
		#endregion
		
		#region ExternMethods
		public bool Equals(FQuat Q, float Tolerance)
		{
			return E_FQuat_Equals(this, Q, Tolerance);
		}

		public bool IsIdentity(float Tolerance)
		{
			return E_FQuat_IsIdentity(this, Tolerance);
		}

		public FQuat MakeFromEuler(FVector Euler)
		{
			return E_FQuat_MakeFromEuler(this, Euler);
		}

		public FVector Euler()
		{
			return E_FQuat_Euler(this);
		}

		public void Normalize(float Tolerance)
		{
			E_FQuat_Normalize(this, Tolerance);
		}

		public FQuat GetNormalized(float Tolerance)
		{
			return E_FQuat_GetNormalized(this, Tolerance);
		}

		public bool IsNormalized()
		{
			return E_FQuat_IsNormalized(this);
		}

		public float Size()
		{
			return E_FQuat_Size(this);
		}

		public void ToAxisAndAngle(FVector Axis, float Angle)
		{
			E_FQuat_ToAxisAndAngle(this, Axis, Angle);
		}

		public void ToSwingTwist(FVector InTwistAxis, FQuat OutSwing, FQuat OutTwist)
		{
			E_FQuat_ToSwingTwist(this, InTwistAxis, OutSwing, OutTwist);
		}

		public FVector RotateVector(FVector V)
		{
			return E_FQuat_RotateVector(this, V);
		}

		public FQuat Log()
		{
			return E_FQuat_Log(this);
		}

		public void EnforceShortestArcWith(FQuat OtherQuat)
		{
			E_FQuat_EnforceShortestArcWith(this, OtherQuat);
		}

		public FRotator Rotator()
		{
			return E_FQuat_Rotator(this);
		}

		public FQuat FindBetween(FVector Vector1, FVector Vector2)
		{
			return E_FQuat_FindBetween(this, Vector1, Vector2);
		}

		public float Error(FQuat Q1, FQuat Q2)
		{
			return E_FQuat_Error(this, Q1, Q2);
		}

		public FQuat FastLerp(FQuat A, FQuat B, float Alpha)
		{
			return E_FQuat_FastLerp(this, A, B, Alpha);
		}

		public FQuat FastBilerp(FQuat P00, FQuat P10, FQuat P01, FQuat P11, float FracX, float FracY)
		{
			return E_FQuat_FastBilerp(this, P00, P10, P01, P11, FracX, FracY);
		}

		public FQuat Slerp_NotNormalized(FQuat Quat1, FQuat Quat2, float Slerp)
		{
			return E_FQuat_Slerp_NotNormalized(this, Quat1, Quat2, Slerp);
		}

		public FQuat Squad(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, float Alpha)
		{
			return E_FQuat_Squad(this, quat1, tang1, quat2, tang2, Alpha);
		}

		public void CalcTangents(FQuat PrevP, FQuat P, FQuat NextP, float Tension, FQuat OutTan)
		{
			E_FQuat_CalcTangents(this, PrevP, P, NextP, Tension, OutTan);
		}

		#endregion
		
	}}
