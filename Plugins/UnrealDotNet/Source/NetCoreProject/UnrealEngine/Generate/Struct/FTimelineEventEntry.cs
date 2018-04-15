using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:53

namespace UnrealEngine
{
	public  partial class FTimelineEventEntry : NativeStructWrapper
	{
		internal FTimelineEventEntry(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FTimelineEventEntry() :
			base(E_CreateStruct_FTimelineEventEntry(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimelineEventEntry();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FTimelineEventEntry_Time_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
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
