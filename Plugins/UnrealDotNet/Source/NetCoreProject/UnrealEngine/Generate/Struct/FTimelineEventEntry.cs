using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Struct that contains one entry for an 'event' during the timeline
	/// </summary>
	public partial class FTimelineEventEntry
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FTimelineEventEntry()
		{
			NativePointer = E_CreateStruct_FTimelineEventEntry();
			IsRef = false;
		}

		internal FTimelineEventEntry(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FTimelineEventEntry();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FTimelineEventEntry_Time_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FTimelineEventEntry_Time_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public float Time
		{
			get => E_PROP_FTimelineEventEntry_Time_GET(NativePointer);
			set => E_PROP_FTimelineEventEntry_Time_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FTimelineEventEntry Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTimelineEventEntry(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimelineEventEntry(Adress, false);
		}}}
