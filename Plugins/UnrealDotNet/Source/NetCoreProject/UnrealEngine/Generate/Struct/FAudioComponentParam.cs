using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FAudioComponentParam : NativeStructWrapper
	{
		internal FAudioComponentParam(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAudioComponentParam(string Name) :
			base(E_CreateStruct_FAudioComponentParam_FName(Name), false)
		{
		}

		public FAudioComponentParam() :
			base(E_CreateStruct_FAudioComponentParam(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAudioComponentParam_FName(string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAudioComponentParam();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FAudioComponentParam_BoolParam_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAudioComponentParam_BoolParam_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAudioComponentParam_FloatParam_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAudioComponentParam_FloatParam_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FAudioComponentParam_IntParam_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAudioComponentParam_IntParam_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_FAudioComponentParam_ParamName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAudioComponentParam_ParamName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public bool BoolParam
		{
			get => E_PROP_FAudioComponentParam_BoolParam_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_BoolParam_SET(NativePointer, value);
		}

		public float FloatParam
		{
			get => E_PROP_FAudioComponentParam_FloatParam_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_FloatParam_SET(NativePointer, value);
		}

		public int IntParam
		{
			get => E_PROP_FAudioComponentParam_IntParam_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_IntParam_SET(NativePointer, value);
		}

		public string ParamName
		{
			get => E_PROP_FAudioComponentParam_ParamName_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_ParamName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FAudioComponentParam Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAudioComponentParam(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAudioComponentParam(Adress, false);
		}}}
