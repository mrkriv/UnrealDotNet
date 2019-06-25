// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:563

namespace UnrealEngine
{
	public partial class FEnvQuerySpatialData : NativeStructWrapper
	{
		public FEnvQuerySpatialData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQuerySpatialData() :
			base(E_CreateStruct_FEnvQuerySpatialData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FEnvQuerySpatialData_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQuerySpatialData_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FEnvQuerySpatialData_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQuerySpatialData_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQuerySpatialData();
		
		#endregion
		
		#region Property
		public FVector Location
		{
			get => E_PROP_FEnvQuerySpatialData_Location_GET(NativePointer);
			set => E_PROP_FEnvQuerySpatialData_Location_SET(NativePointer, value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FEnvQuerySpatialData_Rotation_GET(NativePointer);
			set => E_PROP_FEnvQuerySpatialData_Rotation_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEnvQuerySpatialData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQuerySpatialData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQuerySpatialData(adress, false);
		}}}
