using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageTimelineEventEntry
	/// <para>Struct that contains one entry for an 'event' during the timeline </para>
	/// </summary>
	public  partial class FTimelineEventEntry : NativeStructWrapper
	{
		public FTimelineEventEntry() : base(E_CreateStruct_FTimelineEventEntry(), false)
		{
		}

		internal FTimelineEventEntry(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FTimelineEventEntry();
		
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
