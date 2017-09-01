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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FLevelViewportInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FLevelViewportInfo_CamPosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelViewportInfo_CamPosition_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FRotator E_PROP_FLevelViewportInfo_CamRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelViewportInfo_CamRotation_SET(IntPtr Ptr, FRotator Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FLevelViewportInfo_CamOrthoZoom_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelViewportInfo_CamOrthoZoom_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelViewportInfo_CamUpdated_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelViewportInfo_CamUpdated_SET(IntPtr Ptr, bool Value);
		
		#endregion
		
		#region Property
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

		public float CamOrthoZoom
		{
			get => E_PROP_FLevelViewportInfo_CamOrthoZoom_GET(NativePointer);
			set => E_PROP_FLevelViewportInfo_CamOrthoZoom_SET(NativePointer, value);
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
