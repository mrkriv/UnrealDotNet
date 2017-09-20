using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FStatColorMapping : NativeStructWrapper
	{
		internal FStatColorMapping(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FStatColorMapping() :
			base(E_CreateStruct_FStatColorMapping(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStatColorMapping();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_FStatColorMapping_StatName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
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
