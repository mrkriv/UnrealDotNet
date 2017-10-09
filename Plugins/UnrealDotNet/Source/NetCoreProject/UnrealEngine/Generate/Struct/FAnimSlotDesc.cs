using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2191

namespace UnrealEngine
{
	public  partial class FAnimSlotDesc : NativeStructWrapper
	{
		internal FAnimSlotDesc(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAnimSlotDesc() :
			base(E_CreateStruct_FAnimSlotDesc(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAnimSlotDesc();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FAnimSlotDesc_NumChannels_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimSlotDesc_NumChannels_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FAnimSlotDesc_SlotName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimSlotDesc_SlotName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public int NumChannels
		{
			get => E_PROP_FAnimSlotDesc_NumChannels_GET(NativePointer);
			set => E_PROP_FAnimSlotDesc_NumChannels_SET(NativePointer, value);
		}

		public string SlotName
		{
			get => E_PROP_FAnimSlotDesc_SlotName_GET(NativePointer);
			set => E_PROP_FAnimSlotDesc_SlotName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FAnimSlotDesc Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAnimSlotDesc(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAnimSlotDesc(Adress, false);
		}}}
