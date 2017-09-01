using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FEngineShowFlagsSetting
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FEngineShowFlagsSetting()
		{
			NativePointer = E_CreateStruct_FEngineShowFlagsSetting();
			IsRef = false;
		}

		internal FEngineShowFlagsSetting(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FEngineShowFlagsSetting();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FEngineShowFlagsSetting_ShowFlagName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FEngineShowFlagsSetting_ShowFlagName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FEngineShowFlagsSetting_Enabled_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FEngineShowFlagsSetting_Enabled_SET(IntPtr Ptr, bool Value);
		
		#endregion
		
		#region Property
		public string ShowFlagName
		{
			get => E_PROP_FEngineShowFlagsSetting_ShowFlagName_GET(NativePointer);
			set => E_PROP_FEngineShowFlagsSetting_ShowFlagName_SET(NativePointer, value);
		}

		public bool Enabled
		{
			get => E_PROP_FEngineShowFlagsSetting_Enabled_GET(NativePointer);
			set => E_PROP_FEngineShowFlagsSetting_Enabled_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEngineShowFlagsSetting Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FEngineShowFlagsSetting(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FEngineShowFlagsSetting(Adress, false);
		}}}
