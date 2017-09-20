using System;
using System.Runtime.InteropServices;

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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool(byte InRule, bool bInWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool(byte InLocationRule, byte InRotationRule, byte InScaleRule, bool bInWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAttachmentTransformRules_KeepRelativeTransform_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_KeepRelativeTransform_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAttachmentTransformRules_KeepWorldTransform_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_KeepWorldTransform_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FAttachmentTransformRules_LocationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_LocationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FAttachmentTransformRules_RotationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_RotationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FAttachmentTransformRules_ScaleRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_ScaleRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAttachmentTransformRules_SnapToTargetIncludingScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_SnapToTargetIncludingScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAttachmentTransformRules_SnapToTargetNotIncludingScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAttachmentTransformRules_SnapToTargetNotIncludingScale_SET(IntPtr Ptr, IntPtr Value);
		
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
		public FAttachmentTransformRules KeepRelativeTransform
		{
			get => E_PROP_FAttachmentTransformRules_KeepRelativeTransform_GET(NativePointer);
			set => E_PROP_FAttachmentTransformRules_KeepRelativeTransform_SET(NativePointer, value);
		}

		public FAttachmentTransformRules KeepWorldTransform
		{
			get => E_PROP_FAttachmentTransformRules_KeepWorldTransform_GET(NativePointer);
			set => E_PROP_FAttachmentTransformRules_KeepWorldTransform_SET(NativePointer, value);
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

		public FAttachmentTransformRules SnapToTargetIncludingScale
		{
			get => E_PROP_FAttachmentTransformRules_SnapToTargetIncludingScale_GET(NativePointer);
			set => E_PROP_FAttachmentTransformRules_SnapToTargetIncludingScale_SET(NativePointer, value);
		}

		public FAttachmentTransformRules SnapToTargetNotIncludingScale
		{
			get => E_PROP_FAttachmentTransformRules_SnapToTargetNotIncludingScale_GET(NativePointer);
			set => E_PROP_FAttachmentTransformRules_SnapToTargetNotIncludingScale_SET(NativePointer, value);
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
