// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Items\EnvQueryItemType_VectorBase.h:14

namespace UnrealEngine
{
	public partial class UEnvQueryItemType_VectorBase : UEnvQueryItemType
	{
		public UEnvQueryItemType_VectorBase(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryItemType_VectorBase(UObject Parent = null, string Name = "EnvQueryItemType_VectorBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryItemType_VectorBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryItemType_VectorBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UEnvQueryItemType_VectorBase_GetItemLocation(IntPtr self, byte rawData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UEnvQueryItemType_VectorBase_GetItemRotation(IntPtr self, byte rawData);
		
		#endregion
		
		#region ExternMethods
		public virtual FVector GetItemLocation(byte rawData)
			=> E_UEnvQueryItemType_VectorBase_GetItemLocation(this, rawData);
		
		public virtual FRotator GetItemRotation(byte rawData)
			=> E_UEnvQueryItemType_VectorBase_GetItemRotation(this, rawData);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryItemType_VectorBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryItemType_VectorBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryItemType_VectorBase>(PtrDesc);
		}}}
