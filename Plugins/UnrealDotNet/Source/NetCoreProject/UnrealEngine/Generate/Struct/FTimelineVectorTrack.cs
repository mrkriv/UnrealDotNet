using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Struct that contains one entry for each vector interpolation performed by the timeline
	/// </summary>
	public partial class FTimelineVectorTrack
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FTimelineVectorTrack()
		{
			NativePointer = E_CreateStruct_FTimelineVectorTrack();
			IsRef = false;
		}

		internal FTimelineVectorTrack(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FTimelineVectorTrack();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FTimelineVectorTrack_TrackName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FTimelineVectorTrack_TrackName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FTimelineVectorTrack_VectorPropertyName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FTimelineVectorTrack_VectorPropertyName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string TrackName
		{
			get => E_PROP_FTimelineVectorTrack_TrackName_GET(NativePointer);
			set => E_PROP_FTimelineVectorTrack_TrackName_SET(NativePointer, value);
		}

		public string VectorPropertyName
		{
			get => E_PROP_FTimelineVectorTrack_VectorPropertyName_GET(NativePointer);
			set => E_PROP_FTimelineVectorTrack_VectorPropertyName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FTimelineVectorTrack Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTimelineVectorTrack(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimelineVectorTrack(Adress, false);
		}}}
