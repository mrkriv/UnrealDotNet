// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:417

namespace UnrealEngine
{
	public partial class FEnvOverlapData : NativeStructWrapper
	{
		public FEnvOverlapData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvOverlapData() :
			base(E_CreateStruct_FEnvOverlapData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvOverlapData_ExtentX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvOverlapData_ExtentX_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvOverlapData_ExtentY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvOverlapData_ExtentY_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvOverlapData_ExtentZ_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvOverlapData_ExtentZ_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FEnvOverlapData_ShapeOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvOverlapData_ShapeOffset_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvOverlapData();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// shape parameter for overlap
		/// </summary>
		public float ExtentX
		{
			get => E_PROP_FEnvOverlapData_ExtentX_GET(NativePointer);
			set => E_PROP_FEnvOverlapData_ExtentX_SET(NativePointer, value);
		}

		
		/// <summary>
		/// shape parameter for overlap
		/// </summary>
		public float ExtentY
		{
			get => E_PROP_FEnvOverlapData_ExtentY_GET(NativePointer);
			set => E_PROP_FEnvOverlapData_ExtentY_SET(NativePointer, value);
		}

		
		/// <summary>
		/// shape parameter for overlap
		/// </summary>
		public float ExtentZ
		{
			get => E_PROP_FEnvOverlapData_ExtentZ_GET(NativePointer);
			set => E_PROP_FEnvOverlapData_ExtentZ_SET(NativePointer, value);
		}

		public FVector ShapeOffset
		{
			get => E_PROP_FEnvOverlapData_ShapeOffset_GET(NativePointer);
			set => E_PROP_FEnvOverlapData_ShapeOffset_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEnvOverlapData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvOverlapData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvOverlapData(adress, false);
		}}}
