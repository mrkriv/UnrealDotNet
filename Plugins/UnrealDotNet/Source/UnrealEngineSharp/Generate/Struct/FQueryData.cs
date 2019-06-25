// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryDebugHelpers.h:53

namespace UnrealEngine
{
	public partial class FQueryData : NativeStructWrapper
	{
		public FQueryData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FQueryData() :
			base(E_CreateStruct_FQueryData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FQueryData_Id_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQueryData_Id_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FQueryData_Name_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQueryData_Name_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FQueryData_NumValidItems_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQueryData_NumValidItems_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQueryData_Timestamp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQueryData_Timestamp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FQueryData_UsedOption_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQueryData_UsedOption_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQueryData();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQueryData_Reset(IntPtr self);
		
		#endregion
		
		#region Property
		public int Id
		{
			get => E_PROP_FQueryData_Id_GET(NativePointer);
			set => E_PROP_FQueryData_Id_SET(NativePointer, value);
		}

		public string Name
		{
			get => E_PROP_FQueryData_Name_GET(NativePointer);
			set => E_PROP_FQueryData_Name_SET(NativePointer, value);
		}

		public int NumValidItems
		{
			get => E_PROP_FQueryData_NumValidItems_GET(NativePointer);
			set => E_PROP_FQueryData_NumValidItems_SET(NativePointer, value);
		}

		public float Timestamp
		{
			get => E_PROP_FQueryData_Timestamp_GET(NativePointer);
			set => E_PROP_FQueryData_Timestamp_SET(NativePointer, value);
		}

		public int UsedOption
		{
			get => E_PROP_FQueryData_UsedOption_GET(NativePointer);
			set => E_PROP_FQueryData_UsedOption_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Reset()
			=> E_FQueryData_Reset(this);
		
		#endregion
		
		public static implicit operator IntPtr(FQueryData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FQueryData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FQueryData(adress, false);
		}}}
