// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Contexts\EnvQueryContext_Item.h:11

namespace UnrealEngine
{
	public partial class UEnvQueryContext_Item : UEnvQueryContext
	{
		public UEnvQueryContext_Item(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryContext_Item(UObject Parent = null, string Name = "EnvQueryContext_Item")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryContext_Item(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryContext_Item(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryContext_Item self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryContext_Item(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryContext_Item>(PtrDesc);
		}}}
