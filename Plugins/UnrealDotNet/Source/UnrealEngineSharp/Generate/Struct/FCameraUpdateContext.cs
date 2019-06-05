// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraStackTypes.h:33

namespace UnrealEngine
{
	public partial class FCameraUpdateContext : NativeStructWrapper
	{
		public FCameraUpdateContext(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FCameraUpdateContext(APlayerCameraManager inCamera, float inDeltaTime) :
			base(E_CreateStruct_FCameraUpdateContext_APlayerCameraManager_float(inCamera, inDeltaTime), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCameraUpdateContext_APlayerCameraManager_float(IntPtr inCamera, float inDeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FCameraUpdateContext_FractionalWeight(IntPtr self, float multiplier, bool bFromDebugNode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FCameraUpdateContext_GetCameraManager(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FCameraUpdateContext_GetDeltaTime(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FCameraUpdateContext_GetNonDebugWeight(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FCameraUpdateContext_GetTrueWeight(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public FCameraUpdateContext FractionalWeight(float multiplier, bool bFromDebugNode)
			=> E_FCameraUpdateContext_FractionalWeight(this, multiplier, bFromDebugNode);
		
		public APlayerCameraManager GetCameraManager()
			=> E_FCameraUpdateContext_GetCameraManager(this);
		
		public float GetDeltaTime()
			=> E_FCameraUpdateContext_GetDeltaTime(this);
		
		public float GetNonDebugWeight()
			=> E_FCameraUpdateContext_GetNonDebugWeight(this);
		
		public float GetTrueWeight()
			=> E_FCameraUpdateContext_GetTrueWeight(this);
		
		#endregion
		
		public static implicit operator IntPtr(FCameraUpdateContext self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCameraUpdateContext(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FCameraUpdateContext(adress, false);
		}}}
