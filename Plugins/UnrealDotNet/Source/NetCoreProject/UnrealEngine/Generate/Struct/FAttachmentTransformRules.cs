using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:80

namespace UnrealEngine
{
	public  partial class FAttachmentTransformRules : NativeStructWrapper
	{
		internal FAttachmentTransformRules(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAttachmentTransformRules(EAttachmentRule InRule, bool bInWeldSimulatedBodies) :
			base(E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool((byte)InRule, bInWeldSimulatedBodies), false)
		{
		}

		public FAttachmentTransformRules(EAttachmentRule InLocationRule, EAttachmentRule InRotationRule, EAttachmentRule InScaleRule, bool bInWeldSimulatedBodies) :
			base(E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool((byte)InLocationRule, (byte)InRotationRule, (byte)InScaleRule, bInWeldSimulatedBodies), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool(byte InRule, bool bInWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool(byte InLocationRule, byte InRotationRule, byte InScaleRule, bool bInWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAttachmentTransformRules_KeepRelativeTransform_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAttachmentTransformRules_KeepWorldTransform_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FAttachmentTransformRules_LocationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_LocationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FAttachmentTransformRules_RotationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_RotationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FAttachmentTransformRules_ScaleRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_ScaleRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAttachmentTransformRules_SnapToTargetIncludingScale_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAttachmentTransformRules_SnapToTargetNotIncludingScale_GET();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Whether to weld simulated bodies together when attaching </para>
		/// </summary>
		public bool bWeldSimulatedBodies
		{
			get => E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_GET(NativePointer);
			set => E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Various preset attachment rules. Note that these default rules do NOT by default weld simulated bodies </para>
		/// </summary>
		public static FAttachmentTransformRules KeepRelativeTransform
		{
			get => E_PROP_FAttachmentTransformRules_KeepRelativeTransform_GET();
		}

		public static FAttachmentTransformRules KeepWorldTransform
		{
			get => E_PROP_FAttachmentTransformRules_KeepWorldTransform_GET();
		}

		
		/// <summary>
		/// <para>The rule to apply to location when attaching </para>
		/// </summary>
		public EAttachmentRule LocationRule
		{
			get => (EAttachmentRule)E_PROP_FAttachmentTransformRules_LocationRule_GET(NativePointer);
			set => E_PROP_FAttachmentTransformRules_LocationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>The rule to apply to rotation when attaching </para>
		/// </summary>
		public EAttachmentRule RotationRule
		{
			get => (EAttachmentRule)E_PROP_FAttachmentTransformRules_RotationRule_GET(NativePointer);
			set => E_PROP_FAttachmentTransformRules_RotationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>The rule to apply to scale when attaching </para>
		/// </summary>
		public EAttachmentRule ScaleRule
		{
			get => (EAttachmentRule)E_PROP_FAttachmentTransformRules_ScaleRule_GET(NativePointer);
			set => E_PROP_FAttachmentTransformRules_ScaleRule_SET(NativePointer, (byte)value);
		}

		public static FAttachmentTransformRules SnapToTargetIncludingScale
		{
			get => E_PROP_FAttachmentTransformRules_SnapToTargetIncludingScale_GET();
		}

		public static FAttachmentTransformRules SnapToTargetNotIncludingScale
		{
			get => E_PROP_FAttachmentTransformRules_SnapToTargetNotIncludingScale_GET();
		}

		#endregion
		
		public static implicit operator IntPtr(FAttachmentTransformRules Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAttachmentTransformRules(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAttachmentTransformRules(Adress, false);
		}}}
