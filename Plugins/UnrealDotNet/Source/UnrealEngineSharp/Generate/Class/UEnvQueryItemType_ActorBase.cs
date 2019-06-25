// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Items\EnvQueryItemType_ActorBase.h:15

namespace UnrealEngine
{
	public partial class UEnvQueryItemType_ActorBase : UEnvQueryItemType_VectorBase
	{
		public UEnvQueryItemType_ActorBase(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryItemType_ActorBase(UObject Parent = null, string Name = "EnvQueryItemType_ActorBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryItemType_ActorBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryItemType_ActorBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UEnvQueryItemType_ActorBase_GetActor(IntPtr self, byte rawData);
		
		#endregion
		
		#region ExternMethods
		public virtual AActor GetActor(byte rawData)
			=> E_UEnvQueryItemType_ActorBase_GetActor(this, rawData);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryItemType_ActorBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryItemType_ActorBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryItemType_ActorBase>(PtrDesc);
		}}}
