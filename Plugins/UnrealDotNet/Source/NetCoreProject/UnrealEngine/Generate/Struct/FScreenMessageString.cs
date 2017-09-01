using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Helper struct for tracking on screen messages.
	/// </summary>
	public partial class FScreenMessageString
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FScreenMessageString()
		{
			NativePointer = E_CreateStruct_FScreenMessageString();
			IsRef = false;
		}

		internal FScreenMessageString(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FScreenMessageString();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FScreenMessageString_ScreenMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FScreenMessageString_ScreenMessage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FScreenMessageString_TimeToDisplay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FScreenMessageString_TimeToDisplay_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FScreenMessageString_CurrentTimeDisplayed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FScreenMessageString_CurrentTimeDisplayed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector2D E_PROP_FScreenMessageString_TextScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FScreenMessageString_TextScale_SET(IntPtr Ptr, FVector2D Value);
		
		#endregion
		
		#region Property
		public string ScreenMessage
		{
			get => E_PROP_FScreenMessageString_ScreenMessage_GET(NativePointer);
			set => E_PROP_FScreenMessageString_ScreenMessage_SET(NativePointer, value);
		}

		public float TimeToDisplay
		{
			get => E_PROP_FScreenMessageString_TimeToDisplay_GET(NativePointer);
			set => E_PROP_FScreenMessageString_TimeToDisplay_SET(NativePointer, value);
		}

		public float CurrentTimeDisplayed
		{
			get => E_PROP_FScreenMessageString_CurrentTimeDisplayed_GET(NativePointer);
			set => E_PROP_FScreenMessageString_CurrentTimeDisplayed_SET(NativePointer, value);
		}

		public FVector2D TextScale
		{
			get => E_PROP_FScreenMessageString_TextScale_GET(NativePointer);
			set => E_PROP_FScreenMessageString_TextScale_SET(NativePointer, value);
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
