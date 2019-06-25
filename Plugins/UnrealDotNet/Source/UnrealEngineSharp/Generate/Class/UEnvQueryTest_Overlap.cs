// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Tests\EnvQueryTest_Overlap.h:16

namespace UnrealEngine
{
	public partial class UEnvQueryTest_Overlap : UEnvQueryTest
	{
		public UEnvQueryTest_Overlap(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryTest_Overlap(UObject Parent = null, string Name = "EnvQueryTest_Overlap")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryTest_Overlap(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_Overlap_OverlapData_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_Overlap_OverlapData_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryTest_Overlap(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Overlap data
		/// </summary>
		public FEnvOverlapData OverlapData
		{
			get => E_PROP_UEnvQueryTest_Overlap_OverlapData_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_Overlap_OverlapData_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UEnvQueryTest_Overlap self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryTest_Overlap(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryTest_Overlap>(PtrDesc);
		}}}
