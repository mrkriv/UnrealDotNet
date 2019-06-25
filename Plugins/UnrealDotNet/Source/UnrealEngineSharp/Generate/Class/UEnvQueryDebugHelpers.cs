// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryDebugHelpers.h:157

namespace UnrealEngine
{
	public partial class UEnvQueryDebugHelpers : UObject
	{
		public UEnvQueryDebugHelpers(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryDebugHelpers(UObject Parent = null, string Name = "EnvQueryDebugHelpers")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryDebugHelpers(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryDebugHelpers(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryDebugHelpers self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryDebugHelpers(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryDebugHelpers>(PtrDesc);
		}}}
