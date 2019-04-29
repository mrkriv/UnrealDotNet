// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1644

namespace UnrealEngine
{
	public  partial class FLightmassDebugOptions : NativeStructWrapper
	{
		internal FLightmassDebugOptions(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassDebugOptions() :
			base(E_CreateStruct_FLightmassDebugOptions(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassDebugOptions_CoplanarTolerance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassDebugOptions_CoplanarTolerance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassDebugOptions();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The tolerance level used when gathering BSP surfaces.
		/// </summary>
		public float CoplanarTolerance
		{
			get => E_PROP_FLightmassDebugOptions_CoplanarTolerance_GET(NativePointer);
			set => E_PROP_FLightmassDebugOptions_CoplanarTolerance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The amount of time that will be count as full red when bColorByExecutionTime is enabled
		/// </summary>
		public float ExecutionTimeDivisor
		{
			get => E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_GET(NativePointer);
			set => E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLightmassDebugOptions self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FLightmassDebugOptions(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassDebugOptions(Adress, false);
		}}}
