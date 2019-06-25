// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:605

namespace UnrealEngine
{
	public partial class FEnvQueryContextData : NativeStructWrapper
	{
		public FEnvQueryContextData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryContextData() :
			base(E_CreateStruct_FEnvQueryContextData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryContextData_NumValues_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryContextData_NumValues_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryContextData();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// number of stored values
		/// </summary>
		public int NumValues
		{
			get => E_PROP_FEnvQueryContextData_NumValues_GET(NativePointer);
			set => E_PROP_FEnvQueryContextData_NumValues_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEnvQueryContextData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryContextData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryContextData(adress, false);
		}}}
