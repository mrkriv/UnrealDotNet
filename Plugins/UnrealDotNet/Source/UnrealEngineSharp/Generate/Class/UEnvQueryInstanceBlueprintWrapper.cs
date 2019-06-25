// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryInstanceBlueprintWrapper.h:19

namespace UnrealEngine
{
	public partial class UEnvQueryInstanceBlueprintWrapper : UObject
	{
		public UEnvQueryInstanceBlueprintWrapper(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryInstanceBlueprintWrapper(UObject Parent = null, string Name = "EnvQueryInstanceBlueprintWrapper")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryInstanceBlueprintWrapper(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryInstanceBlueprintWrapper(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UEnvQueryInstanceBlueprintWrapper_GetItemScore(IntPtr self, int itemIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryInstanceBlueprintWrapper_SetInstigator(IntPtr self, IntPtr @object);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryInstanceBlueprintWrapper_SetNamedParam(IntPtr self, string paramName, float value);
		
		#endregion
		
		#region ExternMethods
		public float GetItemScore(int itemIndex)
			=> E_UEnvQueryInstanceBlueprintWrapper_GetItemScore(this, itemIndex);
		
		public void SetInstigator(UObject @object)
			=> E_UEnvQueryInstanceBlueprintWrapper_SetInstigator(this, @object);
		
		public void SetNamedParam(string paramName, float value)
			=> E_UEnvQueryInstanceBlueprintWrapper_SetNamedParam(this, paramName, value);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryInstanceBlueprintWrapper self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryInstanceBlueprintWrapper(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryInstanceBlueprintWrapper>(PtrDesc);
		}}}
