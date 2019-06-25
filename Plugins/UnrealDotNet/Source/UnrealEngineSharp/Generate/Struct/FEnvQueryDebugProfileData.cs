// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:649

namespace UnrealEngine
{
	public partial class FEnvQueryDebugProfileData : NativeStructWrapper
	{
		public FEnvQueryDebugProfileData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryDebugProfileData() :
			base(E_CreateStruct_FEnvQueryDebugProfileData(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryDebugProfileData();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryDebugProfileData_Add(IntPtr self, IntPtr other);
		
		#endregion
		
		#region ExternMethods
		public void Add(FEnvQueryDebugProfileData other)
			=> E_FEnvQueryDebugProfileData_Add(this, other);
		
		#endregion
		
		public static implicit operator IntPtr(FEnvQueryDebugProfileData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryDebugProfileData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryDebugProfileData(adress, false);
		}}}
