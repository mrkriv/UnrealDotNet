// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Items\EnvQueryItemType_Point.h:14

namespace UnrealEngine
{
	public partial class UEnvQueryItemType_Point : UEnvQueryItemType_VectorBase
	{
		public UEnvQueryItemType_Point(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryItemType_Point(UObject Parent = null, string Name = "EnvQueryItemType_Point")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryItemType_Point(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryItemType_Point(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryItemType_Point_SetContextHelper(IntPtr self, IntPtr contextData, IntPtr singlePoint);
		
		#endregion
		
		#region ExternMethods
		public void SetContextHelper(FEnvQueryContextData contextData, FVector singlePoint)
			=> E_UEnvQueryItemType_Point_SetContextHelper(this, contextData, singlePoint);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryItemType_Point self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryItemType_Point(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryItemType_Point>(PtrDesc);
		}}}
