using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Saved editor viewport state information
	/// </summary>
	public partial class FLevelViewportInfo
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FLevelViewportInfo()
		{
			NativePointer = E_CreateStruct_FLevelViewportInfo();
			IsRef = false;
		}

		internal FLevelViewportInfo(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_CreateStruct_FLevelViewportInfo();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_Struct_FLevelViewportInfo_CamPosition_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FLevelViewportInfo_CamPosition_SET(IntPtr Ptr, FVector Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_Struct_FLevelViewportInfo_CamRotation_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FLevelViewportInfo_CamRotation_SET(IntPtr Ptr, FRotator Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_FLevelViewportInfo_CamOrthoZoom_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FLevelViewportInfo_CamOrthoZoom_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Struct_FLevelViewportInfo_CamUpdated_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FLevelViewportInfo_CamUpdated_SET(IntPtr Ptr, bool Value);
		
		#endregion
		
		#region Property
		public FVector CamPosition
		{
			get => E_Struct_FLevelViewportInfo_CamPosition_GET(NativePointer);
			set => E_Struct_FLevelViewportInfo_CamPosition_SET(NativePointer, value);
		}

		public FRotator CamRotation
		{
			get => E_Struct_FLevelViewportInfo_CamRotation_GET(NativePointer);
			set => E_Struct_FLevelViewportInfo_CamRotation_SET(NativePointer, value);
		}

		public float CamOrthoZoom
		{
			get => E_Struct_FLevelViewportInfo_CamOrthoZoom_GET(NativePointer);
			set => E_Struct_FLevelViewportInfo_CamOrthoZoom_SET(NativePointer, value);
		}

		public bool CamUpdated
		{
			get => E_Struct_FLevelViewportInfo_CamUpdated_GET(NativePointer);
			set => E_Struct_FLevelViewportInfo_CamUpdated_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		#endregion
		
		public static implicit operator IntPtr(FLevelViewportInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLevelViewportInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelViewportInfo(Adress, false);
		}}}
