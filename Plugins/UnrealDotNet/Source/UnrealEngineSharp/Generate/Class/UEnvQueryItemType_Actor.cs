// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Items\EnvQueryItemType_Actor.h:16

namespace UnrealEngine
{
	public partial class UEnvQueryItemType_Actor : UEnvQueryItemType_ActorBase
	{
		public UEnvQueryItemType_Actor(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryItemType_Actor(UObject Parent = null, string Name = "EnvQueryItemType_Actor")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryItemType_Actor(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryItemType_Actor(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UEnvQueryItemType_Actor_GetValue(IntPtr self, byte rawData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryItemType_Actor_SetContextHelper(IntPtr self, IntPtr contextData, IntPtr singleActor);
		
		#endregion
		
		#region ExternMethods
		public AActor GetValue(byte rawData)
			=> E_UEnvQueryItemType_Actor_GetValue(this, rawData);
		
		public void SetContextHelper(FEnvQueryContextData contextData, AActor singleActor)
			=> E_UEnvQueryItemType_Actor_SetContextHelper(this, contextData, singleActor);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryItemType_Actor self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryItemType_Actor(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryItemType_Actor>(PtrDesc);
		}}}
