using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:361

namespace UnrealEngine
{
	public  partial class FLightingChannels : NativeStructWrapper
	{
		internal FLightingChannels(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightingChannels() :
			base(E_CreateStruct_FLightingChannels(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightingChannels();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FLightingChannels_bChannel0_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightingChannels_bChannel0_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FLightingChannels_bChannel1_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightingChannels_bChannel1_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FLightingChannels_bChannel2_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightingChannels_bChannel2_SET(IntPtr Ptr, bool Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Default channel for all primitives and lights. </para>
		/// </summary>
		public bool bChannel0
		{
			get => E_PROP_FLightingChannels_bChannel0_GET(NativePointer);
			set => E_PROP_FLightingChannels_bChannel0_SET(NativePointer, value);
		}

		public bool bChannel1
		{
			get => E_PROP_FLightingChannels_bChannel1_GET(NativePointer);
			set => E_PROP_FLightingChannels_bChannel1_SET(NativePointer, value);
		}

		public bool bChannel2
		{
			get => E_PROP_FLightingChannels_bChannel2_GET(NativePointer);
			set => E_PROP_FLightingChannels_bChannel2_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLightingChannels Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightingChannels(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightingChannels(Adress, false);
		}}}
