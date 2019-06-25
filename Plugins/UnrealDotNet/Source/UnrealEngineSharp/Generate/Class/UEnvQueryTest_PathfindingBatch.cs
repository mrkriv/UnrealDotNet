// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Tests\EnvQueryTest_PathfindingBatch.h:12

namespace UnrealEngine
{
	public partial class UEnvQueryTest_PathfindingBatch : UEnvQueryTest_Pathfinding
	{
		public UEnvQueryTest_PathfindingBatch(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryTest_PathfindingBatch(UObject Parent = null, string Name = "EnvQueryTest_PathfindingBatch")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryTest_PathfindingBatch(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_PathfindingBatch_ScanRangeMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_PathfindingBatch_ScanRangeMultiplier_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryTest_PathfindingBatch(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// multiplier for max distance between point and context
		/// </summary>
		public FAIDataProviderFloatValue ScanRangeMultiplier
		{
			get => E_PROP_UEnvQueryTest_PathfindingBatch_ScanRangeMultiplier_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_PathfindingBatch_ScanRangeMultiplier_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UEnvQueryTest_PathfindingBatch self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryTest_PathfindingBatch(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryTest_PathfindingBatch>(PtrDesc);
		}}}
