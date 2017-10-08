using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRigidBodyErrorCorrection : NativeStructWrapper
	{
		internal FRigidBodyErrorCorrection(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRigidBodyErrorCorrection() :
			base(E_CreateStruct_FRigidBodyErrorCorrection(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRigidBodyErrorCorrection();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_AngularDeltaThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_AngularDeltaThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_AngularInterpAlpha_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_AngularInterpAlpha_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_AngularRecipFixTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_AngularRecipFixTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_BodySpeedThresholdSq_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_BodySpeedThresholdSq_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_LinearDeltaThresholdSq_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_LinearDeltaThresholdSq_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_LinearInterpAlpha_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_LinearInterpAlpha_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_LinearRecipFixTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_LinearRecipFixTime_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public float AngularDeltaThreshold
		{
			get => E_PROP_FRigidBodyErrorCorrection_AngularDeltaThreshold_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_AngularDeltaThreshold_SET(NativePointer, value);
		}

		public float AngularInterpAlpha
		{
			get => E_PROP_FRigidBodyErrorCorrection_AngularInterpAlpha_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_AngularInterpAlpha_SET(NativePointer, value);
		}

		public float AngularRecipFixTime
		{
			get => E_PROP_FRigidBodyErrorCorrection_AngularRecipFixTime_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_AngularRecipFixTime_SET(NativePointer, value);
		}

		public float BodySpeedThresholdSq
		{
			get => E_PROP_FRigidBodyErrorCorrection_BodySpeedThresholdSq_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_BodySpeedThresholdSq_SET(NativePointer, value);
		}

		public float LinearDeltaThresholdSq
		{
			get => E_PROP_FRigidBodyErrorCorrection_LinearDeltaThresholdSq_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_LinearDeltaThresholdSq_SET(NativePointer, value);
		}

		public float LinearInterpAlpha
		{
			get => E_PROP_FRigidBodyErrorCorrection_LinearInterpAlpha_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_LinearInterpAlpha_SET(NativePointer, value);
		}

		public float LinearRecipFixTime
		{
			get => E_PROP_FRigidBodyErrorCorrection_LinearRecipFixTime_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_LinearRecipFixTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRigidBodyErrorCorrection Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRigidBodyErrorCorrection(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRigidBodyErrorCorrection(Adress, false);
		}}}
