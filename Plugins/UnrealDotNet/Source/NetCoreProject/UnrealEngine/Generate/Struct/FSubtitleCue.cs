using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:1466

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSubtitleCue();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FSubtitleCue_Text_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSubtitleCue_Text_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FSubtitleCue_Time_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSubtitleCue_Time_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The text to appear in the subtitle. </para>
		/// </summary>
		public string Text
		{
			get => E_PROP_FSubtitleCue_Text_GET(NativePointer);
			set => E_PROP_FSubtitleCue_Text_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The time at which the subtitle is to be displayed, in seconds relative to the beginning of the line. </para>
		/// </summary>
		public float Time
		{
			get => E_PROP_FSubtitleCue_Time_GET(NativePointer);
			set => E_PROP_FSubtitleCue_Time_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSubtitleCue Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSubtitleCue(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSubtitleCue(Adress, false);
		}}}
