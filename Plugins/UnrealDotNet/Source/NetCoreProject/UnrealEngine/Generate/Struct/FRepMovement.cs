using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRepMovement : NativeStructWrapper
	{
		internal FRepMovement(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRepMovement() :
			base(E_CreateStruct_FRepMovement(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRepMovement();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepMovement_AngularVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_AngularVelocity_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_bRepPhysics_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_bRepPhysics_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_bSimulatedPhysicSleep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_bSimulatedPhysicSleep_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FRepMovement_EnableMultiplayerWorldOriginRebasing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_EnableMultiplayerWorldOriginRebasing_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepMovement_LinearVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_LinearVelocity_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepMovement_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_LocationQuantizationLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_LocationQuantizationLevel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepMovement_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_RotationQuantizationLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_RotationQuantizationLevel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_VelocityQuantizationLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_VelocityQuantizationLevel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRepMovement_CopyTo(IntPtr Self, IntPtr RBState, IntPtr Actor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRepMovement_FillFrom(IntPtr Self, IntPtr RBState, IntPtr Actor);
		
		#endregion
		
		#region Property
		public FVector AngularVelocity
		{
			get => E_PROP_FRepMovement_AngularVelocity_GET(NativePointer);
			set => E_PROP_FRepMovement_AngularVelocity_SET(NativePointer, value);
		}

		public byte bRepPhysics
		{
			get => E_PROP_FRepMovement_bRepPhysics_GET(NativePointer);
			set => E_PROP_FRepMovement_bRepPhysics_SET(NativePointer, value);
		}

		public byte bSimulatedPhysicSleep
		{
			get => E_PROP_FRepMovement_bSimulatedPhysicSleep_GET(NativePointer);
			set => E_PROP_FRepMovement_bSimulatedPhysicSleep_SET(NativePointer, value);
		}

		public int EnableMultiplayerWorldOriginRebasing
		{
			get => E_PROP_FRepMovement_EnableMultiplayerWorldOriginRebasing_GET(NativePointer);
			set => E_PROP_FRepMovement_EnableMultiplayerWorldOriginRebasing_SET(NativePointer, value);
		}

		public FVector LinearVelocity
		{
			get => E_PROP_FRepMovement_LinearVelocity_GET(NativePointer);
			set => E_PROP_FRepMovement_LinearVelocity_SET(NativePointer, value);
		}

		public FVector Location
		{
			get => E_PROP_FRepMovement_Location_GET(NativePointer);
			set => E_PROP_FRepMovement_Location_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Allows tuning the compression level for the replicated location vector. You should only need to change this from the default if you see visual artifacts. </para>
		/// </summary>
		public EVectorQuantization LocationQuantizationLevel
		{
			get => (EVectorQuantization)E_PROP_FRepMovement_LocationQuantizationLevel_GET(NativePointer);
			set => E_PROP_FRepMovement_LocationQuantizationLevel_SET(NativePointer, (byte)value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FRepMovement_Rotation_GET(NativePointer);
			set => E_PROP_FRepMovement_Rotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Allows tuning the compression level for replicated rotation. You should only need to change this from the default if you see visual artifacts. </para>
		/// </summary>
		public ERotatorQuantization RotationQuantizationLevel
		{
			get => (ERotatorQuantization)E_PROP_FRepMovement_RotationQuantizationLevel_GET(NativePointer);
			set => E_PROP_FRepMovement_RotationQuantizationLevel_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Allows tuning the compression level for the replicated velocity vectors. You should only need to change this from the default if you see visual artifacts. </para>
		/// </summary>
		public EVectorQuantization VelocityQuantizationLevel
		{
			get => (EVectorQuantization)E_PROP_FRepMovement_VelocityQuantizationLevel_GET(NativePointer);
			set => E_PROP_FRepMovement_VelocityQuantizationLevel_SET(NativePointer, (byte)value);
		}

		#endregion
		
		#region ExternMethods
		public void CopyTo(FRigidBodyState RBState, AActor Actor = null)
			=> E_FRepMovement_CopyTo(this, RBState, Actor);
		
		public void FillFrom(FRigidBodyState RBState, AActor Actor = null)
			=> E_FRepMovement_FillFrom(this, RBState, Actor);
		
		#endregion
		
		public static implicit operator IntPtr(FRepMovement Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRepMovement(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRepMovement(Adress, false);
		}}}
