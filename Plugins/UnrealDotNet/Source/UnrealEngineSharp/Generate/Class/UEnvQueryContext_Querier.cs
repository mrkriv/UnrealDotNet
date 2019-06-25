// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Contexts\EnvQueryContext_Querier.h:14

namespace UnrealEngine
{
	public partial class UEnvQueryContext_Querier : UEnvQueryContext
	{
		public UEnvQueryContext_Querier(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryContext_Querier(UObject Parent = null, string Name = "EnvQueryContext_Querier")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryContext_Querier(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryContext_Querier(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryContext_Querier self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryContext_Querier(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryContext_Querier>(PtrDesc);
		}}}
