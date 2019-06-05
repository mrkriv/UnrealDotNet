// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraShake.h:136

namespace UnrealEngine
{
	public partial class UCameraShake : UObject
	{
		public UCameraShake(IntPtr adress)
			: base(adress)
		{
		}

		public UCameraShake(UObject Parent = null, string Name = "CameraShake")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCameraShake(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_AnimBlendInTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_AnimBlendInTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_AnimBlendOutTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_AnimBlendOutTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UCameraShake_AnimInst_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_AnimInst_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_AnimPlayRate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_AnimPlayRate_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_AnimScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_AnimScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCameraShake_FOVOscillation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_FOVOscillation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCameraShake_LocOscillation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_LocOscillation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_OscillationBlendInTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_OscillationBlendInTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_OscillationBlendOutTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_OscillationBlendOutTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_OscillationDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_OscillationDuration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_OscillatorTimeRemaining_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_OscillatorTimeRemaining_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_RandomAnimSegmentDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_RandomAnimSegmentDuration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCameraShake_RotOscillation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_RotOscillation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraShake_ShakeScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraShake_ShakeScale_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCameraShake(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraShake_BlueprintUpdateCameraShake(IntPtr self, float deltaTime, float alpha, IntPtr pOV, IntPtr modifiedPOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCameraShake_IsFinished(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCameraShake_IsLooping(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCameraShake_ReceiveIsFinished(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraShake_ReceivePlayShake(IntPtr self, float scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraShake_ReceiveStopShake(IntPtr self, bool bImmediately);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraShake_SetCurrentTimeAndApplyShake(IntPtr self, float newTime, IntPtr pOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraShake_SetTempCameraAnimActor(IntPtr self, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraShake_StopShake(IntPtr self, bool bImmediately);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraShake_UpdateAndApplyCameraShake(IntPtr self, float deltaTime, float alpha, IntPtr inOutPOV);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Linear blend-in time.
		/// </summary>
		public float AnimBlendInTime
		{
			get => E_PROP_UCameraShake_AnimBlendInTime_GET(NativePointer);
			set => E_PROP_UCameraShake_AnimBlendInTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Linear blend-out time.
		/// </summary>
		public float AnimBlendOutTime
		{
			get => E_PROP_UCameraShake_AnimBlendOutTime_GET(NativePointer);
			set => E_PROP_UCameraShake_AnimBlendOutTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The playing instance of the CameraAnim-based shake, if any.
		/// </summary>
		public UCameraAnimInst AnimInst
		{
			get => E_PROP_UCameraShake_AnimInst_GET(NativePointer);
			set => E_PROP_UCameraShake_AnimInst_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scalar defining how fast to play the anim.
		/// </summary>
		public float AnimPlayRate
		{
			get => E_PROP_UCameraShake_AnimPlayRate_GET(NativePointer);
			set => E_PROP_UCameraShake_AnimPlayRate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scalar defining how "intense" to play the anim.
		/// </summary>
		public float AnimScale
		{
			get => E_PROP_UCameraShake_AnimScale_GET(NativePointer);
			set => E_PROP_UCameraShake_AnimScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// FOV oscillation
		/// </summary>
		public FFOscillator FOVOscillation
		{
			get => E_PROP_UCameraShake_FOVOscillation_GET(NativePointer);
			set => E_PROP_UCameraShake_FOVOscillation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Positional oscillation
		/// </summary>
		public FVOscillator LocOscillation
		{
			get => E_PROP_UCameraShake_LocOscillation_GET(NativePointer);
			set => E_PROP_UCameraShake_LocOscillation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Duration of the blend-in, where the oscillation scales from 0 to 1.
		/// </summary>
		public float OscillationBlendInTime
		{
			get => E_PROP_UCameraShake_OscillationBlendInTime_GET(NativePointer);
			set => E_PROP_UCameraShake_OscillationBlendInTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Duration of the blend-out, where the oscillation scales from 1 to 0.
		/// </summary>
		public float OscillationBlendOutTime
		{
			get => E_PROP_UCameraShake_OscillationBlendOutTime_GET(NativePointer);
			set => E_PROP_UCameraShake_OscillationBlendOutTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Duration in seconds of current screen shake. Less than 0 means indefinite, 0 means no oscillation.
		/// </summary>
		public float OscillationDuration
		{
			get => E_PROP_UCameraShake_OscillationDuration_GET(NativePointer);
			set => E_PROP_UCameraShake_OscillationDuration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time remaining for oscillation shakes. Less than 0.f means shake infinitely.
		/// </summary>
		public float OscillatorTimeRemaining
		{
			get => E_PROP_UCameraShake_OscillatorTimeRemaining_GET(NativePointer);
			set => E_PROP_UCameraShake_OscillatorTimeRemaining_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When bRandomAnimSegment is true, this defines how long the anim should play.
		/// </summary>
		public float RandomAnimSegmentDuration
		{
			get => E_PROP_UCameraShake_RandomAnimSegmentDuration_GET(NativePointer);
			set => E_PROP_UCameraShake_RandomAnimSegmentDuration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Rotational oscillation
		/// </summary>
		public FROscillator RotOscillation
		{
			get => E_PROP_UCameraShake_RotOscillation_GET(NativePointer);
			set => E_PROP_UCameraShake_RotOscillation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Overall intensity scale for this shake instance.
		/// </summary>
		public float ShakeScale
		{
			get => E_PROP_UCameraShake_ShakeScale_GET(NativePointer);
			set => E_PROP_UCameraShake_ShakeScale_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Called every tick to let the shake modify the point of view
		/// </summary>
		public void BlueprintUpdateCameraShake(float deltaTime, float alpha, FMinimalViewInfo pOV, FMinimalViewInfo modifiedPOV)
			=> E_UCameraShake_BlueprintUpdateCameraShake(this, deltaTime, alpha, pOV, modifiedPOV);
		
		public virtual bool IsFinished()
			=> E_UCameraShake_IsFinished(this);
		
		public bool IsLooping()
			=> E_UCameraShake_IsLooping(this);
		
		
		/// <summary>
		/// Called to allow a shake to decide when it's finished playing.
		/// </summary>
		public bool ReceiveIsFinished()
			=> E_UCameraShake_ReceiveIsFinished(this);
		
		
		/// <summary>
		/// Called when the shake starts playing
		/// </summary>
		public void ReceivePlayShake(float scale)
			=> E_UCameraShake_ReceivePlayShake(this, scale);
		
		
		/// <summary>
		/// Called when the shake is explicitly stopped.
		/// </summary>
		/// <param name="bImmediatly">If true, shake stops right away regardless of blend out settings. If false, shake may blend out according to its settings.</param>
		public void ReceiveStopShake(bool bImmediately)
			=> E_UCameraShake_ReceiveStopShake(this, bImmediately);
		
		
		/// <summary>
		/// Sets current playback time and applies the shake (both oscillation and cameraanim) to the given POV.
		/// </summary>
		public void SetCurrentTimeAndApplyShake(float newTime, FMinimalViewInfo pOV)
			=> E_UCameraShake_SetCurrentTimeAndApplyShake(this, newTime, pOV);
		
		public void SetTempCameraAnimActor(AActor actor)
			=> E_UCameraShake_SetTempCameraAnimActor(this, actor);
		
		
		/// <summary>
		/// Stops this shake from playing.
		/// </summary>
		/// <param name="bImmediatly">If true, shake stops right away regardless of blend out settings. If false, shake may blend out according to its settings.</param>
		public virtual void StopShake(bool bImmediately)
			=> E_UCameraShake_StopShake(this, bImmediately);
		
		public virtual void UpdateAndApplyCameraShake(float deltaTime, float alpha, FMinimalViewInfo inOutPOV)
			=> E_UCameraShake_UpdateAndApplyCameraShake(this, deltaTime, alpha, inOutPOV);
		
		#endregion
		
		public static implicit operator IntPtr(UCameraShake self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCameraShake(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCameraShake>(PtrDesc);
		}}}
