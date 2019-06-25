// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryDebugHelpers.h:23

namespace UnrealEngine
{
	public partial class FItemData : NativeStructWrapper
	{
		public FItemData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FItemData() :
			base(E_CreateStruct_FItemData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FItemData_Desc_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FItemData_Desc_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FItemData_ItemIdx_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FItemData_ItemIdx_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FItemData_TotalScore_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FItemData_TotalScore_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FItemData();
		
		#endregion
		
		#region Property
		public string Desc
		{
			get => E_PROP_FItemData_Desc_GET(NativePointer);
			set => E_PROP_FItemData_Desc_SET(NativePointer, value);
		}

		public int ItemIdx
		{
			get => E_PROP_FItemData_ItemIdx_GET(NativePointer);
			set => E_PROP_FItemData_ItemIdx_SET(NativePointer, value);
		}

		public float TotalScore
		{
			get => E_PROP_FItemData_TotalScore_GET(NativePointer);
			set => E_PROP_FItemData_TotalScore_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FItemData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FItemData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FItemData(adress, false);
		}}}
