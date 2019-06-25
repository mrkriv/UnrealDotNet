// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryManager.h:24

namespace UnrealEngine
{
	public partial class FEnvQueryRequest : NativeStructWrapper
	{
		public FEnvQueryRequest(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryRequest() :
			base(E_CreateStruct_FEnvQueryRequest(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryRequest();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FEnvQueryRequest_SetBoolParam(IntPtr self, string paramName, bool value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FEnvQueryRequest_SetFloatParam(IntPtr self, string paramName, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FEnvQueryRequest_SetIntParam(IntPtr self, string paramName, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FEnvQueryRequest_SetNamedParam(IntPtr self, IntPtr paramData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FEnvQueryRequest_SetWorldOverride(IntPtr self, IntPtr inWorld);
		
		#endregion
		
		#region ExternMethods
		public FEnvQueryRequest SetBoolParam(string paramName, bool value)
			=> E_FEnvQueryRequest_SetBoolParam(this, paramName, value);
		
		public FEnvQueryRequest SetFloatParam(string paramName, float value)
			=> E_FEnvQueryRequest_SetFloatParam(this, paramName, value);
		
		public FEnvQueryRequest SetIntParam(string paramName, int value)
			=> E_FEnvQueryRequest_SetIntParam(this, paramName, value);
		
		public FEnvQueryRequest SetNamedParam(FEnvNamedValue paramData)
			=> E_FEnvQueryRequest_SetNamedParam(this, paramData);
		
		public FEnvQueryRequest SetWorldOverride(UWorld inWorld)
			=> E_FEnvQueryRequest_SetWorldOverride(this, inWorld);
		
		#endregion
		
		public static implicit operator IntPtr(FEnvQueryRequest self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryRequest(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryRequest(adress, false);
		}}}
