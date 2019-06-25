// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Contexts\EnvQueryContext_BlueprintBase.h:15

namespace UnrealEngine
{
	public partial class UEnvQueryContext_BlueprintBase : UEnvQueryContext
	{
		public UEnvQueryContext_BlueprintBase(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryContext_BlueprintBase(UObject Parent = null, string Name = "EnvQueryContext_BlueprintBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryContext_BlueprintBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UEnvQueryContext_BlueprintBase_CallMode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryContext_BlueprintBase_CallMode_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryContext_BlueprintBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryContext_BlueprintBase_ProvideSingleLocation(IntPtr self, IntPtr querierObject, IntPtr querierActor, IntPtr resultingLocation);
		
		#endregion
		
		#region Property
		public ECallMode CallMode
		{
			get => (ECallMode)E_PROP_UEnvQueryContext_BlueprintBase_CallMode_GET(NativePointer);
			set => E_PROP_UEnvQueryContext_BlueprintBase_CallMode_SET(NativePointer, (byte)value);
		}

		#endregion
		
		#region ExternMethods
		public void ProvideSingleLocation(UObject querierObject, AActor querierActor, FVector resultingLocation)
			=> E_UEnvQueryContext_BlueprintBase_ProvideSingleLocation(this, querierObject, querierActor, resultingLocation);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryContext_BlueprintBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryContext_BlueprintBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryContext_BlueprintBase>(PtrDesc);
		}}}
