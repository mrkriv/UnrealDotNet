// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\World.h:300

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageLevelViewportInfo
	/// <para>Static array of level packages that have been marked by PrepareStreamedOutLevelsForGC </para>
	/// </summary>
	public  partial class FLevelViewportInfo : NativeStructWrapper
	{
		internal FLevelViewportInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLevelViewportInfo() :
			base(E_CreateStruct_FLevelViewportInfo(), false)
		{
		}

		public FLevelViewportInfo(FVector inCamPosition, FRotator inCamRotation, float inCamOrthoZoom) :
			base(E_CreateStruct_FLevelViewportInfo_FVector_FRotator_float(inCamPosition, inCamRotation, inCamOrthoZoom), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelViewportInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelViewportInfo_FVector_FRotator_float(IntPtr inCamPosition, IntPtr inCamRotation, float inCamOrthoZoom);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLevelViewportInfo_CamOrthoZoom_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLevelViewportInfo_CamOrthoZoom_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLevelViewportInfo_CamPosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLevelViewportInfo_CamPosition_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLevelViewportInfo_CamRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLevelViewportInfo_CamRotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FLevelViewportInfo_CamUpdated_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLevelViewportInfo_CamUpdated_SET(IntPtr Ptr, bool Value);
		
		#endregion
		
		#region Property
		public float CamOrthoZoom
		{
			get => E_PROP_FLevelViewportInfo_CamOrthoZoom_GET(NativePointer);
			set => E_PROP_FLevelViewportInfo_CamOrthoZoom_SET(NativePointer, value);
		}

		public FVector CamPosition
		{
			get => E_PROP_FLevelViewportInfo_CamPosition_GET(NativePointer);
			set => E_PROP_FLevelViewportInfo_CamPosition_SET(NativePointer, value);
		}

		public FRotator CamRotation
		{
			get => E_PROP_FLevelViewportInfo_CamRotation_GET(NativePointer);
			set => E_PROP_FLevelViewportInfo_CamRotation_SET(NativePointer, value);
		}

		public bool CamUpdated
		{
			get => E_PROP_FLevelViewportInfo_CamUpdated_GET(NativePointer);
			set => E_PROP_FLevelViewportInfo_CamUpdated_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLevelViewportInfo self)
		{
			return self.NativePointer;
		}

		public static implicit operator FLevelViewportInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelViewportInfo(Adress, false);
		}}}
