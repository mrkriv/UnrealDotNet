// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\CrowdManager.h:67

namespace UnrealEngine
{
	public partial class FCrowdAvoidanceConfig : NativeStructWrapper
	{
		public FCrowdAvoidanceConfig(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FCrowdAvoidanceConfig() :
			base(E_CreateStruct_FCrowdAvoidanceConfig(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FCrowdAvoidanceConfig_AdaptiveDepth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_AdaptiveDepth_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FCrowdAvoidanceConfig_AdaptiveDivisions_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_AdaptiveDivisions_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FCrowdAvoidanceConfig_AdaptiveRings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_AdaptiveRings_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCrowdAvoidanceConfig_CurrentVelocityWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_CurrentVelocityWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FCrowdAvoidanceConfig_CustomPatternIdx_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_CustomPatternIdx_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCrowdAvoidanceConfig_DesiredVelocityWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_DesiredVelocityWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCrowdAvoidanceConfig_ImpactTimeRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_ImpactTimeRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCrowdAvoidanceConfig_ImpactTimeWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_ImpactTimeWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCrowdAvoidanceConfig_SideBiasWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_SideBiasWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCrowdAvoidanceConfig_VelocityBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAvoidanceConfig_VelocityBias_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCrowdAvoidanceConfig();
		
		#endregion
		
		#region Property
		public byte AdaptiveDepth
		{
			get => E_PROP_FCrowdAvoidanceConfig_AdaptiveDepth_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_AdaptiveDepth_SET(NativePointer, value);
		}

		public byte AdaptiveDivisions
		{
			get => E_PROP_FCrowdAvoidanceConfig_AdaptiveDivisions_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_AdaptiveDivisions_SET(NativePointer, value);
		}

		public byte AdaptiveRings
		{
			get => E_PROP_FCrowdAvoidanceConfig_AdaptiveRings_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_AdaptiveRings_SET(NativePointer, value);
		}

		public float CurrentVelocityWeight
		{
			get => E_PROP_FCrowdAvoidanceConfig_CurrentVelocityWeight_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_CurrentVelocityWeight_SET(NativePointer, value);
		}

		public byte CustomPatternIdx
		{
			get => E_PROP_FCrowdAvoidanceConfig_CustomPatternIdx_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_CustomPatternIdx_SET(NativePointer, value);
		}

		public float DesiredVelocityWeight
		{
			get => E_PROP_FCrowdAvoidanceConfig_DesiredVelocityWeight_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_DesiredVelocityWeight_SET(NativePointer, value);
		}

		public float ImpactTimeRange
		{
			get => E_PROP_FCrowdAvoidanceConfig_ImpactTimeRange_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_ImpactTimeRange_SET(NativePointer, value);
		}

		public float ImpactTimeWeight
		{
			get => E_PROP_FCrowdAvoidanceConfig_ImpactTimeWeight_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_ImpactTimeWeight_SET(NativePointer, value);
		}

		public float SideBiasWeight
		{
			get => E_PROP_FCrowdAvoidanceConfig_SideBiasWeight_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_SideBiasWeight_SET(NativePointer, value);
		}

		public float VelocityBias
		{
			get => E_PROP_FCrowdAvoidanceConfig_VelocityBias_GET(NativePointer);
			set => E_PROP_FCrowdAvoidanceConfig_VelocityBias_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCrowdAvoidanceConfig self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCrowdAvoidanceConfig(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FCrowdAvoidanceConfig(adress, false);
		}}}
