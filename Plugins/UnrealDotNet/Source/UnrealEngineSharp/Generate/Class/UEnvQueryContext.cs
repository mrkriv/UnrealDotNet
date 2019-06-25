// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryContext.h:14

namespace UnrealEngine
{
	public partial class UEnvQueryContext : UObject
	{
		public UEnvQueryContext(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryContext(UObject Parent = null, string Name = "EnvQueryContext")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryContext(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryContext(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryContext_ProvideContext(IntPtr self, IntPtr queryInstance, IntPtr contextData);
		
		#endregion
		
		#region ExternMethods
		public virtual void ProvideContext(FEnvQueryInstance queryInstance, FEnvQueryContextData contextData)
			=> E_UEnvQueryContext_ProvideContext(this, queryInstance, contextData);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryContext self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryContext(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryContext>(PtrDesc);
		}}}
