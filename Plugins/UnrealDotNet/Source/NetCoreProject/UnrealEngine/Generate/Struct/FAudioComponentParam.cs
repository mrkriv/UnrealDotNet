using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Struct used for storing one per-instance named parameter for this AudioComponent.
	/// Certain nodes in the SoundCue may reference parameters by name so they can be adjusted per-instance.
	/// </summary>
	public partial class FAudioComponentParam
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FAudioComponentParam()
		{
			NativePointer = E_CreateStruct_FAudioComponentParam();
			IsRef = false;
		}

		internal FAudioComponentParam(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FAudioComponentParam();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FAudioComponentParam_ParamName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FAudioComponentParam_ParamName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FAudioComponentParam_FloatParam_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FAudioComponentParam_FloatParam_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FAudioComponentParam_BoolParam_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FAudioComponentParam_BoolParam_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FAudioComponentParam_IntParam_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FAudioComponentParam_IntParam_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		public string ParamName
		{
			get => E_PROP_FAudioComponentParam_ParamName_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_ParamName_SET(NativePointer, value);
		}

		public float FloatParam
		{
			get => E_PROP_FAudioComponentParam_FloatParam_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_FloatParam_SET(NativePointer, value);
		}

		public bool BoolParam
		{
			get => E_PROP_FAudioComponentParam_BoolParam_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_BoolParam_SET(NativePointer, value);
		}

		public int IntParam
		{
			get => E_PROP_FAudioComponentParam_IntParam_GET(NativePointer);
			set => E_PROP_FAudioComponentParam_IntParam_SET(NativePointer, value);
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
