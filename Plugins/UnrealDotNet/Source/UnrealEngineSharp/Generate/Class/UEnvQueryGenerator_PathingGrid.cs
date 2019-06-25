// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_PathingGrid.h:20

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_PathingGrid : UEnvQueryGenerator_SimpleGrid
	{
		public UEnvQueryGenerator_PathingGrid(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_PathingGrid(UObject Parent = null, string Name = "EnvQueryGenerator_PathingGrid")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_PathingGrid(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_PathingGrid_PathToItem_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_PathingGrid_PathToItem_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_PathingGrid_ScanRangeMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_PathingGrid_ScanRangeMultiplier_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_PathingGrid(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// pathfinding direction
		/// </summary>
		public FAIDataProviderBoolValue PathToItem
		{
			get => E_PROP_UEnvQueryGenerator_PathingGrid_PathToItem_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_PathingGrid_PathToItem_SET(NativePointer, value);
		}

		
		/// <summary>
		/// multiplier for max distance between point and context
		/// </summary>
		public FAIDataProviderFloatValue ScanRangeMultiplier
		{
			get => E_PROP_UEnvQueryGenerator_PathingGrid_ScanRangeMultiplier_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_PathingGrid_ScanRangeMultiplier_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_PathingGrid self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_PathingGrid(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_PathingGrid>(PtrDesc);
		}}}
