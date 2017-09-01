using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FStatColorMapping
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FStatColorMapping()
		{
			NativePointer = E_CreateStruct_FStatColorMapping();
			IsRef = false;
		}

		internal FStatColorMapping(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FStatColorMapping();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FStatColorMapping_StatName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FStatColorMapping_StatName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string StatName
		{
			get => E_PROP_FStatColorMapping_StatName_GET(NativePointer);
			set => E_PROP_FStatColorMapping_StatName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FStatColorMapping Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FStatColorMapping(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStatColorMapping(Adress, false);
		}}}
