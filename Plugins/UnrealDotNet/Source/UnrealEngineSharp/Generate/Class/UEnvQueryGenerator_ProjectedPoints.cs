// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_ProjectedPoints.h:13

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_ProjectedPoints : UEnvQueryGenerator
	{
		public UEnvQueryGenerator_ProjectedPoints(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_ProjectedPoints(UObject Parent = null, string Name = "EnvQueryGenerator_ProjectedPoints")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_ProjectedPoints(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_ProjectedPoints_ProjectionData_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_ProjectedPoints_ProjectionData_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_ProjectedPoints(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// trace params
		/// </summary>
		public FEnvTraceData ProjectionData
		{
			get => E_PROP_UEnvQueryGenerator_ProjectedPoints_ProjectionData_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_ProjectedPoints_ProjectionData_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_ProjectedPoints self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_ProjectedPoints(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_ProjectedPoints>(PtrDesc);
		}}}
