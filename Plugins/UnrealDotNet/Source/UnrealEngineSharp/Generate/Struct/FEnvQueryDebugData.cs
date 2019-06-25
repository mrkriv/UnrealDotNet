// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:691

namespace UnrealEngine
{
	public partial class FEnvQueryDebugData : FEnvQueryDebugProfileData
	{
		public FEnvQueryDebugData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryDebugData() :
			base(E_CreateStruct_FEnvQueryDebugData(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryDebugData();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryDebugData_Store(IntPtr self, IntPtr queryInstance, float executionTime, bool bStepDone);
		
		#endregion
		
		#region ExternMethods
		public void Store(FEnvQueryInstance queryInstance, float executionTime, bool bStepDone)
			=> E_FEnvQueryDebugData_Store(this, queryInstance, executionTime, bStepDone);
		
		#endregion
		
		public static implicit operator IntPtr(FEnvQueryDebugData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryDebugData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryDebugData(adress, false);
		}}}
