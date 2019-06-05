// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraAnimInst.h:18

namespace UnrealEngine
{
	public partial class UCameraAnimInst : UObject
	{
		public UCameraAnimInst(IntPtr adress)
			: base(adress)
		{
		}

		public UCameraAnimInst(UObject Parent = null, string Name = "CameraAnimInst")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCameraAnimInst(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraAnimInst_BasePlayScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnimInst_BasePlayScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraAnimInst_CurrentBlendWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnimInst_CurrentBlendWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraAnimInst_CurTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnimInst_CurTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCameraAnimInst_InitialCamToWorld_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnimInst_InitialCamToWorld_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraAnimInst_InitialFOV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnimInst_InitialFOV_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCameraAnimInst_LastCameraLoc_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnimInst_LastCameraLoc_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraAnimInst_PlayRate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnimInst_PlayRate_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraAnimInst_TransientScaleModifier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnimInst_TransientScaleModifier_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCameraAnimInst_UserPlaySpaceMatrix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnimInst_UserPlaySpaceMatrix_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCameraAnimInst(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnimInst_AdvanceAnim(IntPtr self, float deltaTime, bool bJump);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnimInst_ApplyToView(IntPtr self, IntPtr inOutPOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnimInst_ApplyTransientScaling(IntPtr self, float scalar);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCameraAnimInst_GetCurrentTime(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnimInst_SetCurrentTime(IntPtr self, float newTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnimInst_SetDuration(IntPtr self, float newDuration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnimInst_SetScale(IntPtr self, float newDuration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnimInst_SetStopAutomatically(IntPtr self, bool bNewStopAutoMatically);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnimInst_Stop(IntPtr self, bool bImmediate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnimInst_Update(IntPtr self, float newRate, float newScale, float newBlendInTime, float newBlendOutTime, float newDuration);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// "Intensity" value used to scale keyframe values.
		/// </summary>
		public float BasePlayScale
		{
			get => E_PROP_UCameraAnimInst_BasePlayScale_GET(NativePointer);
			set => E_PROP_UCameraAnimInst_BasePlayScale_SET(NativePointer, value);
		}

		public float CurrentBlendWeight
		{
			get => E_PROP_UCameraAnimInst_CurrentBlendWeight_GET(NativePointer);
			set => E_PROP_UCameraAnimInst_CurrentBlendWeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current time for the animation
		/// </summary>
		public float CurTime
		{
			get => E_PROP_UCameraAnimInst_CurTime_GET(NativePointer);
			set => E_PROP_UCameraAnimInst_CurTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// transform of initial anim key, used for treating anim keys as offsets from initial key
		/// </summary>
		public FTransform InitialCamToWorld
		{
			get => E_PROP_UCameraAnimInst_InitialCamToWorld_GET(NativePointer);
			set => E_PROP_UCameraAnimInst_InitialCamToWorld_SET(NativePointer, value);
		}

		
		/// <summary>
		/// FOV of the initial anim key, used for treating fov keys as offsets from initial key.
		/// </summary>
		public float InitialFOV
		{
			get => E_PROP_UCameraAnimInst_InitialFOV_GET(NativePointer);
			set => E_PROP_UCameraAnimInst_InitialFOV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Camera Anim debug variable to trace back to previous location
		/// </summary>
		public FVector LastCameraLoc
		{
			get => E_PROP_UCameraAnimInst_LastCameraLoc_GET(NativePointer);
			set => E_PROP_UCameraAnimInst_LastCameraLoc_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Multiplier for playback rate.  1.0 = normal.
		/// </summary>
		public float PlayRate
		{
			get => E_PROP_UCameraAnimInst_PlayRate_GET(NativePointer);
			set => E_PROP_UCameraAnimInst_PlayRate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// A supplemental scale factor, allowing external systems to scale this anim as necessary.  This is reset to 1.f each frame.
		/// </summary>
		public float TransientScaleModifier
		{
			get => E_PROP_UCameraAnimInst_TransientScaleModifier_GET(NativePointer);
			set => E_PROP_UCameraAnimInst_TransientScaleModifier_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The user-defined space for UserDefined PlaySpace
		/// </summary>
		public FMatrix UserPlaySpaceMatrix
		{
			get => E_PROP_UCameraAnimInst_UserPlaySpaceMatrix_GET(NativePointer);
			set => E_PROP_UCameraAnimInst_UserPlaySpaceMatrix_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// advances the animation by the specified time - updates any modified interp properties, moves the group actor, etc
		/// </summary>
		public void AdvanceAnim(float deltaTime, bool bJump)
			=> E_UCameraAnimInst_AdvanceAnim(this, deltaTime, bJump);
		
		
		/// <summary>
		/// Takes the given view and applies the camera anim transform and fov changes to it. Does not affect PostProcess.
		/// </summary>
		public void ApplyToView(FMinimalViewInfo inOutPOV)
			=> E_UCameraAnimInst_ApplyToView(this, inOutPOV);
		
		
		/// <summary>
		/// Applies given scaling factor to the playing animation for the next update only.
		/// </summary>
		public void ApplyTransientScaling(float scalar)
			=> E_UCameraAnimInst_ApplyTransientScaling(this, scalar);
		
		
		/// <summary>
		/// Returns the current playback time.
		/// </summary>
		public float GetCurrentTime()
			=> E_UCameraAnimInst_GetCurrentTime(this);
		
		
		/// <summary>
		/// Jumps he camera anim to the given (unscaled) time.
		/// </summary>
		public void SetCurrentTime(float newTime)
			=> E_UCameraAnimInst_SetCurrentTime(this, newTime);
		
		
		/// <summary>
		/// Changes the running duration of this active anim, while maintaining playback position.
		/// </summary>
		public void SetDuration(float newDuration)
			=> E_UCameraAnimInst_SetDuration(this, newDuration);
		
		
		/// <summary>
		/// Changes the scale of the animation while playing.
		/// </summary>
		public void SetScale(float newDuration)
			=> E_UCameraAnimInst_SetScale(this, newDuration);
		
		
		/// <summary>
		/// Sets whether this anim instance should automatically stop when finished.
		/// </summary>
		public void SetStopAutomatically(bool bNewStopAutoMatically)
			=> E_UCameraAnimInst_SetStopAutomatically(this, bNewStopAutoMatically);
		
		
		/// <summary>
		/// Stops this instance playing whatever animation it is playing.
		/// </summary>
		public void Stop(bool bImmediate = false)
			=> E_UCameraAnimInst_Stop(this, bImmediate);
		
		
		/// <summary>
		/// Updates this active instance with new parameters.
		/// </summary>
		public void Update(float newRate, float newScale, float newBlendInTime, float newBlendOutTime, float newDuration)
			=> E_UCameraAnimInst_Update(this, newRate, newScale, newBlendInTime, newBlendOutTime, newDuration);
		
		#endregion
		
		public static implicit operator IntPtr(UCameraAnimInst self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCameraAnimInst(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCameraAnimInst>(PtrDesc);
		}}}
