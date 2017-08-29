using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Struct to hold information about the "base" object the character is standing on.
	/// </summary>
	public partial class FBasedMovementInfo
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FBasedMovementInfo()
		{
			NativePointer = E_CreateStruct_FBasedMovementInfo();
			IsRef = false;
		}

		internal FBasedMovementInfo(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FBasedMovementInfo();
		
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
		private static extern FRotator E_PROP_FBasedMovementInfo_Rotation_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FBasedMovementInfo_Rotation_SET(IntPtr Ptr, FRotator Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PROP_FBasedMovementInfo_bServerHasBaseComponent_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FBasedMovementInfo_bServerHasBaseComponent_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PROP_FBasedMovementInfo_bRelativeRotation_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FBasedMovementInfo_bRelativeRotation_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PROP_FBasedMovementInfo_bServerHasVelocity_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FBasedMovementInfo_bServerHasVelocity_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FBasedMovementInfo_HasRelativeLocation(FBasedMovementInfo Self);
		
		#endregion
		
		#region Property
		public FRotator Rotation
		{
			get => E_PROP_FBasedMovementInfo_Rotation_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_Rotation_SET(NativePointer, value);
		}

		public bool bServerHasBaseComponent
		{
			get => E_PROP_FBasedMovementInfo_bServerHasBaseComponent_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_bServerHasBaseComponent_SET(NativePointer, value);
		}

		public bool bRelativeRotation
		{
			get => E_PROP_FBasedMovementInfo_bRelativeRotation_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_bRelativeRotation_SET(NativePointer, value);
		}

		public bool bServerHasVelocity
		{
			get => E_PROP_FBasedMovementInfo_bServerHasVelocity_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_bServerHasVelocity_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Is location relative?
		/// </summary>
		public bool HasRelativeLocation()
			=> E_FBasedMovementInfo_HasRelativeLocation(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBasedMovementInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBasedMovementInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBasedMovementInfo(Adress, false);
		}}}
