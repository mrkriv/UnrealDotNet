using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// View state needed to create a scene capture renderer
	/// </summary>
	public partial class FSceneCaptureViewInfo
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FSceneCaptureViewInfo()
		{
			NativePointer = E_CreateStruct_FSceneCaptureViewInfo();
			IsRef = false;
		}

		internal FSceneCaptureViewInfo(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FSceneCaptureViewInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSceneCaptureViewInfo_ViewLocation_SET(IntPtr Ptr, FVector Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// View state needed to create a scene capture renderer
		/// </summary>
		public FVector ViewLocation
		{
			get => E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(NativePointer);
			set => E_PROP_FSceneCaptureViewInfo_ViewLocation_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSceneCaptureViewInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSceneCaptureViewInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSceneCaptureViewInfo(Adress, false);
		}}}
