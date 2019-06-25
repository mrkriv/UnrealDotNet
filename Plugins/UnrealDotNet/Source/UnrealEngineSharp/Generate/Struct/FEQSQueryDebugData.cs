// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:708

namespace UnrealEngine
{
	public partial class FEQSQueryDebugData : FEnvQueryDebugData
	{
		public FEQSQueryDebugData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEQSQueryDebugData() :
			base(E_CreateStruct_FEQSQueryDebugData(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEQSQueryDebugData();
		
		#endregion
		
		public static implicit operator IntPtr(FEQSQueryDebugData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEQSQueryDebugData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEQSQueryDebugData(adress, false);
		}}}
