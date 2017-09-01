using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FStatColorMapEntry
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FStatColorMapEntry()
		{
			NativePointer = E_CreateStruct_FStatColorMapEntry();
			IsRef = false;
		}

		internal FStatColorMapEntry(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FStatColorMapEntry();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FStatColorMapEntry_In_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FStatColorMapEntry_In_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public float In
		{
			get => E_PROP_FStatColorMapEntry_In_GET(NativePointer);
			set => E_PROP_FStatColorMapEntry_In_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FStatColorMapEntry Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FStatColorMapEntry(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStatColorMapEntry(Adress, false);
		}}}
