// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:53

namespace UnrealEngine
{
	public partial class FTimelineEventEntry : NativeStructWrapper
	{
		public FTimelineEventEntry(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FTimelineEventEntry() :
			base(E_CreateStruct_FTimelineEventEntry(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FTimelineEventEntry_Time_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTimelineEventEntry_Time_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineEventEntry();
		
		#endregion
		
		#region Property
		public float Time
		{
			get => E_PROP_FTimelineEventEntry_Time_GET(NativePointer);
			set => E_PROP_FTimelineEventEntry_Time_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FTimelineEventEntry self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTimelineEventEntry(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTimelineEventEntry(adress, false);
		}}}
