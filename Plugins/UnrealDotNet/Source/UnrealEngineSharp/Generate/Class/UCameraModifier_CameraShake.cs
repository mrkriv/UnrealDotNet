// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraModifier_CameraShake.h:33

namespace UnrealEngine
{
	public partial class UCameraModifier_CameraShake : UCameraModifier
	{
		public UCameraModifier_CameraShake(IntPtr adress)
			: base(adress)
		{
		}

		public UCameraModifier_CameraShake(UObject Parent = null, string Name = "CameraModifier_CameraShake")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCameraModifier_CameraShake(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCameraModifier_CameraShake(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_CameraShake_RemoveAllCameraShakes(IntPtr self, bool bImmediately);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_CameraShake_RemoveCameraShake(IntPtr self, IntPtr shakeInst, bool bImmediately);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_CameraShake_SaveShakeInExpiredPool(IntPtr self, IntPtr shakeInst);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Stops and removes all camera shakes from the camera.
		/// </summary>
		/// <param name="bImmediately">If true, shake stops right away regardless of blend out settings. If false, shake may blend out according to its settings.</param>
		public virtual void RemoveAllCameraShakes(bool bImmediately)
			=> E_UCameraModifier_CameraShake_RemoveAllCameraShakes(this, bImmediately);
		
		
		/// <summary>
		/// Stops and removes the camera shake of the given class from the camera.
		/// </summary>
		/// <param name="shake">the camera shake class to remove.</param>
		/// <param name="bImmediately">If true, shake stops right away regardless of blend out settings. If false, shake may blend out according to its settings.</param>
		public virtual void RemoveCameraShake(UCameraShake shakeInst, bool bImmediately)
			=> E_UCameraModifier_CameraShake_RemoveCameraShake(this, shakeInst, bImmediately);
		
		public void SaveShakeInExpiredPool(UCameraShake shakeInst)
			=> E_UCameraModifier_CameraShake_SaveShakeInExpiredPool(this, shakeInst);
		
		#endregion
		
		public static implicit operator IntPtr(UCameraModifier_CameraShake self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCameraModifier_CameraShake(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCameraModifier_CameraShake>(PtrDesc);
		}}}
