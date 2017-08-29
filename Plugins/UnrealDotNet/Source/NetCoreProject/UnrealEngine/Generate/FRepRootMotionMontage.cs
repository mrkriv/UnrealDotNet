using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Replicated data when playing a root motion montage.
	/// </summary>
	public partial class FRepRootMotionMontage
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FRepRootMotionMontage()
		{
			NativePointer = E_CreateStruct_FRepRootMotionMontage();
			IsRef = false;
		}

		internal FRepRootMotionMontage(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_CreateStruct_FRepRootMotionMontage();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PROP_FRepRootMotionMontage_bIsActive_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FRepRootMotionMontage_bIsActive_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_FRepRootMotionMontage_Position_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FRepRootMotionMontage_Position_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_PROP_FRepRootMotionMontage_Rotation_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FRepRootMotionMontage_Rotation_SET(IntPtr Ptr, FRotator Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PROP_FRepRootMotionMontage_bRelativePosition_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FRepRootMotionMontage_bRelativePosition_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PROP_FRepRootMotionMontage_bRelativeRotation_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FRepRootMotionMontage_bRelativeRotation_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FRepRootMotionMontage_Clear(FRepRootMotionMontage Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FRepRootMotionMontage_HasRootMotion(FRepRootMotionMontage Self);
		
		#endregion
		
		#region Property
		public bool bIsActive
		{
			get => E_PROP_FRepRootMotionMontage_bIsActive_GET(NativePointer);
			set => E_PROP_FRepRootMotionMontage_bIsActive_SET(NativePointer, value);
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

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Clear root motion sources and root motion montage
		/// </summary>
		public void Clear()
			=> E_FRepRootMotionMontage_Clear(this);
		
		
		/// <summary>
		/// Is Valid - animation root motion only
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
