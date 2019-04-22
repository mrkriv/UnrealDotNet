// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:69

namespace UnrealEngine
{
	public  partial class FAttachmentTransformRules : NativeStructWrapper
	{
		internal FAttachmentTransformRules(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAttachmentTransformRules(EAttachmentRule inRule, bool bInWeldSimulatedBodies) :
			base(E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool((byte)inRule, bInWeldSimulatedBodies), false)
		{
		}

		public FAttachmentTransformRules(EAttachmentRule inLocationRule, EAttachmentRule inRotationRule, EAttachmentRule inScaleRule, bool bInWeldSimulatedBodies) :
			base(E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool((byte)inLocationRule, (byte)inRotationRule, (byte)inScaleRule, bInWeldSimulatedBodies), false)
		{
		}

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
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool(byte inRule, bool bInWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool(byte inLocationRule, byte inRotationRule, byte inScaleRule, bool bInWeldSimulatedBodies);
		
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
		
		public static implicit operator IntPtr(FAttachmentTransformRules self)
		{
			return self.NativePointer;
		}

		public static implicit operator FAttachmentTransformRules(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAttachmentTransformRules(Adress, false);
		}}}
