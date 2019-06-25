// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_CurrentLocation.h:13

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_CurrentLocation : UEnvQueryGenerator
	{
		public UEnvQueryGenerator_CurrentLocation(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_CurrentLocation(UObject Parent = null, string Name = "EnvQueryGenerator_CurrentLocation")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_CurrentLocation(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_CurrentLocation(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_CurrentLocation self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_CurrentLocation(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_CurrentLocation>(PtrDesc);
		}}}
