// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:75

namespace UnrealEngine
{
	public partial class FTimelineVectorTrack : NativeStructWrapper
	{
		public FTimelineVectorTrack(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FTimelineVectorTrack() :
			base(E_CreateStruct_FTimelineVectorTrack(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTimelineVectorTrack_TrackName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineVectorTrack_TrackName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FTimelineVectorTrack_VectorPropertyName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineVectorTrack_VectorPropertyName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineVectorTrack();
		
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
		
		public static implicit operator IntPtr(FTimelineVectorTrack self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTimelineVectorTrack(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTimelineVectorTrack(adress, false);
		}}}
