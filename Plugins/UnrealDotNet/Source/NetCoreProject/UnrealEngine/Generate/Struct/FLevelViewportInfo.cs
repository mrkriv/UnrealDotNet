using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\World.h:298

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelViewportInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLevelViewportInfo_CamOrthoZoom_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLevelViewportInfo_CamOrthoZoom_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLevelViewportInfo_CamPosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLevelViewportInfo_CamPosition_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLevelViewportInfo_CamRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLevelViewportInfo_CamRotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FLevelViewportInfo_CamUpdated_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
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
		
		public static implicit operator IntPtr(FLevelViewportInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLevelViewportInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelViewportInfo(Adress, false);
		}}}
