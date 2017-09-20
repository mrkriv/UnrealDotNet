using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRepRootMotionMontage : NativeStructWrapper
	{
		internal FRepRootMotionMontage(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRepRootMotionMontage() :
			base(E_CreateStruct_FRepRootMotionMontage(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRepRootMotionMontage();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRepRootMotionMontage_bIsActive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_bIsActive_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRepRootMotionMontage_bRelativePosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_bRelativePosition_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRepRootMotionMontage_bRelativeRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_bRelativeRotation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FRepRootMotionMontage_MovementBase_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_MovementBase_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_FRepRootMotionMontage_MovementBaseBoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_MovementBaseBoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRepRootMotionMontage_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_Position_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepRootMotionMontage_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepRootMotionMontage_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRepRootMotionMontage_Clear(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRepRootMotionMontage_HasRootMotion(IntPtr Self);
		
		#endregion
		
		#region Property
		public bool bIsActive
		{
			get => E_PROP_FRepRootMotionMontage_bIsActive_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_bIsActive_SET(NativePointer, value);
		}

		public bool bRelativePosition
		{
			get => E_PROP_FRepRootMotionMontage_bRelativePosition_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_bRelativePosition_SET(NativePointer, value);
		}

		public bool bRelativeRotation
		{
			get => E_PROP_FRepRootMotionMontage_bRelativeRotation_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_bRelativeRotation_SET(NativePointer, value);
		}

		public UPrimitiveComponent MovementBase
		{
			get => E_PROP_FRepRootMotionMontage_MovementBase_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_MovementBase_SET(NativePointer, value);
		}

		public string MovementBaseBoneName
		{
			get => E_PROP_FRepRootMotionMontage_MovementBaseBoneName_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_MovementBaseBoneName_SET(NativePointer, value);
		}

		public float Position
		{
			get => E_PROP_FRepRootMotionMontage_Position_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_Position_SET(NativePointer, value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FRepRootMotionMontage_Rotation_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_Rotation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Clear root motion sources and root motion montage </para>
		/// </summary>
		public void Clear()
			=> E_FRepRootMotionMontage_Clear(this);
		
		
		/// <summary>
		/// <para>Is Valid - animation root motion only </para>
		/// </summary>
		public bool HasRootMotion()
			=> E_FRepRootMotionMontage_HasRootMotion(this);
		
		#endregion
		
		public static implicit operator IntPtr(FRepRootMotionMontage Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRepRootMotionMontage(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRepRootMotionMontage(Adress, false);
		}}}
