// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2915

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRepMovement();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepMovement_AngularVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_AngularVelocity_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_bRepPhysics_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_bRepPhysics_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_bSimulatedPhysicSleep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_bSimulatedPhysicSleep_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FRepMovement_EnableMultiplayerWorldOriginRebasing_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepMovement_LinearVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_LinearVelocity_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepMovement_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_LocationQuantizationLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_LocationQuantizationLevel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepMovement_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_RotationQuantizationLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_RotationQuantizationLevel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRepMovement_VelocityQuantizationLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepMovement_VelocityQuantizationLevel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRepMovement_CopyTo(IntPtr self, IntPtr rBState, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRepMovement_FillFrom(IntPtr self, IntPtr rBState, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRepMovement_RebaseOntoLocalOrigin(IntPtr self, IntPtr location, IntPtr worldContextActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRepMovement_RebaseOntoLocalOrigin_o1(IntPtr self, IntPtr location, IntPtr worldContextActorComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRepMovement_RebaseOntoZeroOrigin(IntPtr self, IntPtr location, IntPtr worldContextActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRepMovement_RebaseOntoZeroOrigin_o1(IntPtr self, IntPtr location, IntPtr worldContextActorComponent);
		
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

		public static int EnableMultiplayerWorldOriginRebasing
		{
			get => E_PROP_FRepMovement_EnableMultiplayerWorldOriginRebasing_GET();
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
		public void CopyTo(FRigidBodyState rBState, AActor actor = null)
			=> E_FRepMovement_CopyTo(this, rBState, actor);
		
		public void FillFrom(FRigidBodyState rBState, AActor actor = null)
			=> E_FRepMovement_FillFrom(this, rBState, actor);
		
		
		/// <summary>
		/// <para>Rebase zero-origin position onto an Actor's local world origin. </para>
		/// </summary>
		public FVector RebaseOntoLocalOrigin(FVector location, AActor worldContextActor)
			=> E_FRepMovement_RebaseOntoLocalOrigin(this, location, worldContextActor);
		
		
		/// <summary>
		/// <para>Rebase zero-origin position onto local world origin value based on an actor component's world. </para>
		/// </summary>
		public FVector RebaseOntoLocalOrigin(FVector location, UActorComponent worldContextActorComponent)
			=> E_FRepMovement_RebaseOntoLocalOrigin_o1(this, location, worldContextActorComponent);
		
		
		/// <summary>
		/// <para>Rebase an Actor's local-origin position onto zero world origin value. </para>
		/// </summary>
		public FVector RebaseOntoZeroOrigin(FVector location, AActor worldContextActor)
			=> E_FRepMovement_RebaseOntoZeroOrigin(this, location, worldContextActor);
		
		
		/// <summary>
		/// <para>Rebase local-origin position onto zero world origin value based on an actor component's world. </para>
		/// </summary>
		public FVector RebaseOntoZeroOrigin(FVector location, UActorComponent worldContextActorComponent)
			=> E_FRepMovement_RebaseOntoZeroOrigin_o1(this, location, worldContextActorComponent);
		
		#endregion
		
		public static implicit operator IntPtr(FRepMovement self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRepMovement(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRepMovement(Adress, false);
		}}}
