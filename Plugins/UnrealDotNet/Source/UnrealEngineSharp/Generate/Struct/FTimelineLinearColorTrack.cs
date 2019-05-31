// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:152

namespace UnrealEngine
{
	public  partial class FTimelineLinearColorTrack : NativeStructWrapper
	{
		internal FTimelineLinearColorTrack(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FTimelineLinearColorTrack() :
			base(E_CreateStruct_FTimelineLinearColorTrack(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTimelineLinearColorTrack_TrackName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineLinearColorTrack_TrackName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineLinearColorTrack();
		
		#endregion
		
		#region Property
		public string LinearColorPropertyName
		{
			get => E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_GET(NativePointer);
			set => E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_SET(NativePointer, value);
		}

		public string TrackName
		{
			get => E_PROP_FTimelineLinearColorTrack_TrackName_GET(NativePointer);
			set => E_PROP_FTimelineLinearColorTrack_TrackName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FTimelineLinearColorTrack self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTimelineLinearColorTrack(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTimelineLinearColorTrack(adress, false);
		}}}
