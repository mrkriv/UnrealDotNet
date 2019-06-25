// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Items\EnvQueryItemType_Direction.h:14

namespace UnrealEngine
{
	public partial class UEnvQueryItemType_Direction : UEnvQueryItemType_VectorBase
	{
		public UEnvQueryItemType_Direction(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryItemType_Direction(UObject Parent = null, string Name = "EnvQueryItemType_Direction")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryItemType_Direction(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryItemType_Direction(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UEnvQueryItemType_Direction_GetValue(IntPtr self, byte rawData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UEnvQueryItemType_Direction_GetValueRot(IntPtr self, byte rawData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryItemType_Direction_SetContextHelper(IntPtr self, IntPtr contextData, IntPtr singleDirection);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryItemType_Direction_SetContextHelper_o1(IntPtr self, IntPtr contextData, IntPtr singleRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryItemType_Direction_SetValue(IntPtr self, byte rawData, IntPtr value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryItemType_Direction_SetValueRot(IntPtr self, byte rawData, IntPtr value);
		
		#endregion
		
		#region ExternMethods
		public FVector GetValue(byte rawData)
			=> E_UEnvQueryItemType_Direction_GetValue(this, rawData);
		
		public FRotator GetValueRot(byte rawData)
			=> E_UEnvQueryItemType_Direction_GetValueRot(this, rawData);
		
		public void SetContextHelper(FEnvQueryContextData contextData, FVector singleDirection)
			=> E_UEnvQueryItemType_Direction_SetContextHelper(this, contextData, singleDirection);
		
		public void SetContextHelper(FEnvQueryContextData contextData, FRotator singleRotation)
			=> E_UEnvQueryItemType_Direction_SetContextHelper_o1(this, contextData, singleRotation);
		
		public void SetValue(byte rawData, FVector value)
			=> E_UEnvQueryItemType_Direction_SetValue(this, rawData, value);
		
		public void SetValueRot(byte rawData, FRotator value)
			=> E_UEnvQueryItemType_Direction_SetValueRot(this, rawData, value);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryItemType_Direction self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryItemType_Direction(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryItemType_Direction>(PtrDesc);
		}}}
