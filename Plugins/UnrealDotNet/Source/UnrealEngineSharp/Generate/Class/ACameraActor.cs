// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraActor.h:18

namespace UnrealEngine
{
	public partial class ACameraActor : AActor
	{
		public ACameraActor(IntPtr adress)
			: base(adress)
		{
		}

		public ACameraActor(UObject Parent = null, string Name = "CameraActor")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ACameraActor(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ACameraActor(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_ACameraActor_GetAutoActivatePlayerIndex(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACameraActor_GetCameraComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACameraActor_NotifyCameraCut(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns index of the player for whom we auto-activate, or INDEX_NONE (-1) if disabled.
		/// </summary>
		public int GetAutoActivatePlayerIndex()
			=> E_ACameraActor_GetAutoActivatePlayerIndex(this);
		
		
		/// <summary>
		/// Returns CameraComponent subobject
		/// </summary>
		public UCameraComponent GetCameraComponent()
			=> E_ACameraActor_GetCameraComponent(this);
		
		
		/// <summary>
		/// Called to notify that this camera was cut to, so it can update things like interpolation if necessary.
		/// <para>Typically called by the camera component. </para>
		/// </summary>
		public virtual void NotifyCameraCut()
			=> E_ACameraActor_NotifyCameraCut(this);
		
		#endregion
		
		public static implicit operator IntPtr(ACameraActor self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ACameraActor(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ACameraActor>(PtrDesc);
		}}}
