using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1687

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassDebugOptions();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassDebugOptions_CoplanarTolerance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassDebugOptions_CoplanarTolerance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The tolerance level used when gathering BSP surfaces. </para>
		/// </summary>
		public float CoplanarTolerance
		{
			get => E_PROP_FLightmassDebugOptions_CoplanarTolerance_GET(NativePointer);
			set => E_PROP_FLightmassDebugOptions_CoplanarTolerance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The amount of time that will be count as full red when bColorByExecutionTime is enabled </para>
		/// </summary>
		public float ExecutionTimeDivisor
		{
			get => E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_GET(NativePointer);
			set => E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLightmassDebugOptions Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightmassDebugOptions(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassDebugOptions(Adress, false);
		}}}
