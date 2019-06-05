// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\PlayerCameraManager.h:63

namespace UnrealEngine
{
	public partial class FTViewTarget : NativeStructWrapper
	{
		public FTViewTarget(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FTViewTarget() :
			base(E_CreateStruct_FTViewTarget(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FTViewTarget_POV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTViewTarget_POV_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FTViewTarget_Target_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTViewTarget_Target_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTViewTarget();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTViewTarget_CheckViewTarget(IntPtr self, IntPtr owningController);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTViewTarget_Equal(IntPtr self, IntPtr otherTarget);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FTViewTarget_GetTargetPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTViewTarget_SetNewTarget(IntPtr self, IntPtr newTarget);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Computed point of view
		/// </summary>
		public FMinimalViewInfo POV
		{
			get => E_PROP_FTViewTarget_POV_GET(NativePointer);
			set => E_PROP_FTViewTarget_POV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Target Actor used to compute POV
		/// </summary>
		public AActor Target
		{
			get => E_PROP_FTViewTarget_Target_GET(NativePointer);
			set => E_PROP_FTViewTarget_Target_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Make sure ViewTarget is valid
		/// </summary>
		public void CheckViewTarget(APlayerController owningController)
			=> E_FTViewTarget_CheckViewTarget(this, owningController);
		
		public bool Equal(FTViewTarget otherTarget)
			=> E_FTViewTarget_Equal(this, otherTarget);
		
		public APawn GetTargetPawn()
			=> E_FTViewTarget_GetTargetPawn(this);
		
		public void SetNewTarget(AActor newTarget)
			=> E_FTViewTarget_SetNewTarget(this, newTarget);
		
		#endregion
		
		public static implicit operator IntPtr(FTViewTarget self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTViewTarget(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTViewTarget(adress, false);
		}}}
