// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1490

namespace UnrealEngine
{
	public  partial class FSubtitleCue : NativeStructWrapper
	{
		internal FSubtitleCue(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSubtitleCue() :
			base(E_CreateStruct_FSubtitleCue(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FSubtitleCue_Text_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSubtitleCue_Text_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FSubtitleCue_Time_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSubtitleCue_Time_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSubtitleCue();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The text to appear in the subtitle.
		/// </summary>
		public string Text
		{
			get => E_PROP_FSubtitleCue_Text_GET(NativePointer);
			set => E_PROP_FSubtitleCue_Text_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The time at which the subtitle is to be displayed, in seconds relative to the beginning of the line.
		/// </summary>
		public float Time
		{
			get => E_PROP_FSubtitleCue_Time_GET(NativePointer);
			set => E_PROP_FSubtitleCue_Time_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSubtitleCue self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSubtitleCue(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSubtitleCue(Adress, false);
		}}}
