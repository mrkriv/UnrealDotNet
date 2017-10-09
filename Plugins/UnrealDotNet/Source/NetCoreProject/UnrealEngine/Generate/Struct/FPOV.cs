using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2411

namespace UnrealEngine
{
	public  partial class FPOV : NativeStructWrapper
	{
		internal FPOV(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPOV() :
			base(E_CreateStruct_FPOV(), false)
		{
		}

		public FPOV(FVector InLocation, FRotator InRotation, float InFOV) :
			base(E_CreateStruct_FPOV_FVector_FRotator_float(InLocation, InRotation, InFOV), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPOV();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPOV_FVector_FRotator_float(IntPtr InLocation, IntPtr InRotation, float InFOV);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPOV_FOV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPOV_FOV_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPOV_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPOV_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPOV_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPOV_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>FOV angle </para>
		/// </summary>
		public float FOV
		{
			get => E_PROP_FPOV_FOV_GET(NativePointer);
			set => E_PROP_FPOV_FOV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Location </para>
		/// </summary>
		public FVector Location
		{
			get => E_PROP_FPOV_Location_GET(NativePointer);
			set => E_PROP_FPOV_Location_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Rotation </para>
		/// </summary>
		public FRotator Rotation
		{
			get => E_PROP_FPOV_Rotation_GET(NativePointer);
			set => E_PROP_FPOV_Rotation_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPOV Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPOV(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPOV(Adress, false);
		}}}
