using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:75

namespace UnrealEngine
{
	public  partial class FTimelineVectorTrack : NativeStructWrapper
	{
		internal FTimelineVectorTrack(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FTimelineVectorTrack() :
			base(E_CreateStruct_FTimelineVectorTrack(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineVectorTrack();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTimelineVectorTrack_TrackName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineVectorTrack_TrackName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTimelineVectorTrack_VectorPropertyName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
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
