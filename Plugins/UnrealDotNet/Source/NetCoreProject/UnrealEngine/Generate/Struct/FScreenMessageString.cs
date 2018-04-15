using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:475

namespace UnrealEngine
{
	public  partial class FScreenMessageString : NativeStructWrapper
	{
		internal FScreenMessageString(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FScreenMessageString() :
			base(E_CreateStruct_FScreenMessageString(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScreenMessageString();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FScreenMessageString_CurrentTimeDisplayed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FScreenMessageString_CurrentTimeDisplayed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FScreenMessageString_ScreenMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FScreenMessageString_ScreenMessage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FScreenMessageString_TextScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FScreenMessageString_TextScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FScreenMessageString_TimeToDisplay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FScreenMessageString_TimeToDisplay_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public float CurrentTimeDisplayed
		{
			get => E_PROP_FScreenMessageString_CurrentTimeDisplayed_GET(NativePointer);
			set => E_PROP_FScreenMessageString_CurrentTimeDisplayed_SET(NativePointer, value);
		}

		public string ScreenMessage
		{
			get => E_PROP_FScreenMessageString_ScreenMessage_GET(NativePointer);
			set => E_PROP_FScreenMessageString_ScreenMessage_SET(NativePointer, value);
		}

		public FVector2D TextScale
		{
			get => E_PROP_FScreenMessageString_TextScale_GET(NativePointer);
			set => E_PROP_FScreenMessageString_TextScale_SET(NativePointer, value);
		}

		public float TimeToDisplay
		{
			get => E_PROP_FScreenMessageString_TimeToDisplay_GET(NativePointer);
			set => E_PROP_FScreenMessageString_TimeToDisplay_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FScreenMessageString Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FScreenMessageString(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScreenMessageString(Adress, false);
		}}}
