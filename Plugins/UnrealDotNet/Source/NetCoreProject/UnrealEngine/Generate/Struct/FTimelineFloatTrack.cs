using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FTimelineFloatTrack : NativeStructWrapper
	{
		internal FTimelineFloatTrack(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FTimelineFloatTrack() :
			base(E_CreateStruct_FTimelineFloatTrack(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineFloatTrack();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_FTimelineFloatTrack_FloatPropertyName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineFloatTrack_FloatPropertyName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_FTimelineFloatTrack_TrackName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineFloatTrack_TrackName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string FloatPropertyName
		{
			get => E_PROP_FTimelineFloatTrack_FloatPropertyName_GET(NativePointer);
			set => E_PROP_FTimelineFloatTrack_FloatPropertyName_SET(NativePointer, value);
		}

		public string TrackName
		{
			get => E_PROP_FTimelineFloatTrack_TrackName_GET(NativePointer);
			set => E_PROP_FTimelineFloatTrack_TrackName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FTimelineFloatTrack Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTimelineFloatTrack(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimelineFloatTrack(Adress, false);
		}}}
