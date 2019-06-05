// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraAnim.h:17

namespace UnrealEngine
{
	public  partial class UCameraAnim : UObject
	{
		public UCameraAnim(IntPtr adress)
			: base(adress)
		{
		}

		public UCameraAnim(UObject Parent = null, string Name = "CameraAnim")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCameraAnim(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraAnim_AnimLength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnim_AnimLength_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraAnim_BaseFOV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnim_BaseFOV_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCameraAnim_BasePostProcessBlendWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnim_BasePostProcessBlendWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCameraAnim_BasePostProcessSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnim_BasePostProcessSettings_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCameraAnim_BoundingBox_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnim_BoundingBox_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCameraAnim_bRelativeToInitialFOV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnim_bRelativeToInitialFOV_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCameraAnim_bRelativeToInitialTransform_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraAnim_bRelativeToInitialTransform_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCameraAnim(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraAnim_CalcLocalAABB(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCameraAnim_GetAABB(IntPtr self, IntPtr baseLoc, IntPtr baseRot, float scale);
		
		#endregion
		
		#region Property
		public float AnimLength
		{
			get => E_PROP_UCameraAnim_AnimLength_GET(NativePointer);
			set => E_PROP_UCameraAnim_AnimLength_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The base FOV that all FOV keys are relative to.
		/// </summary>
		public float BaseFOV
		{
			get => E_PROP_UCameraAnim_BaseFOV_GET(NativePointer);
			set => E_PROP_UCameraAnim_BaseFOV_SET(NativePointer, value);
		}

		public float BasePostProcessBlendWeight
		{
			get => E_PROP_UCameraAnim_BasePostProcessBlendWeight_GET(NativePointer);
			set => E_PROP_UCameraAnim_BasePostProcessBlendWeight_SET(NativePointer, value);
		}

		public FPostProcessSettings BasePostProcessSettings
		{
			get => E_PROP_UCameraAnim_BasePostProcessSettings_GET(NativePointer);
			set => E_PROP_UCameraAnim_BasePostProcessSettings_SET(NativePointer, value);
		}

		public FBox BoundingBox
		{
			get => E_PROP_UCameraAnim_BoundingBox_GET(NativePointer);
			set => E_PROP_UCameraAnim_BoundingBox_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, assume all FOV keys are intended be offsets from the start of the animation.
		/// <para>If false, assume all FOV keys are authored relative to the current FOV of the camera at the start of the animation. </para>
		/// </summary>
		public byte bRelativeToInitialFOV
		{
			get => E_PROP_UCameraAnim_bRelativeToInitialFOV_GET(NativePointer);
			set => E_PROP_UCameraAnim_bRelativeToInitialFOV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, assume all transform keys are intended be offsets from the start of the animation. This allows the animation to be authored at any world location and be applied as a delta to the camera.
		/// <para>If false, assume all transform keys are authored relative to the world origin. Positions will be directly applied as deltas to the camera. </para>
		/// </summary>
		public byte bRelativeToInitialTransform
		{
			get => E_PROP_UCameraAnim_bRelativeToInitialTransform_GET(NativePointer);
			set => E_PROP_UCameraAnim_bRelativeToInitialTransform_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Internal. Computes and stores the local AABB of the camera's motion.
		/// </summary>
		protected void CalcLocalAABB()
			=> E_UCameraAnim_CalcLocalAABB(this);
		
		
		/// <summary>
		/// Gets AABB of the camera's path. Useful for rough testing if you can play an animation at a certain
		/// <para>location in the world without penetrating geometry. </para>
		/// </summary>
		/// <return>Returns</return>
		public FBox GetAABB(FVector baseLoc, FRotator baseRot, float scale)
			=> E_UCameraAnim_GetAABB(this, baseLoc, baseRot, scale);
		
		#endregion
		
		public static implicit operator IntPtr(UCameraAnim self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCameraAnim(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCameraAnim>(PtrDesc);
		}}}
