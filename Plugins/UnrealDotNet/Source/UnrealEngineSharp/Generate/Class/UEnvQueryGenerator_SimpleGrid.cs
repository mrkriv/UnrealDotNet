// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_SimpleGrid.h:18

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_SimpleGrid : UEnvQueryGenerator_ProjectedPoints
	{
		public UEnvQueryGenerator_SimpleGrid(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_SimpleGrid(UObject Parent = null, string Name = "EnvQueryGenerator_SimpleGrid")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_SimpleGrid(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_SimpleGrid_GridSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_SimpleGrid_GridSize_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_SimpleGrid_SpaceBetween_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_SimpleGrid_SpaceBetween_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_SimpleGrid(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// half of square's extent, like a radius
		/// </summary>
		public FAIDataProviderFloatValue GridHalfSize
		{
			get => E_PROP_UEnvQueryGenerator_SimpleGrid_GridSize_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_SimpleGrid_GridSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// generation density
		/// </summary>
		public FAIDataProviderFloatValue SpaceBetween
		{
			get => E_PROP_UEnvQueryGenerator_SimpleGrid_SpaceBetween_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_SimpleGrid_SpaceBetween_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_SimpleGrid self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_SimpleGrid(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_SimpleGrid>(PtrDesc);
		}}}
