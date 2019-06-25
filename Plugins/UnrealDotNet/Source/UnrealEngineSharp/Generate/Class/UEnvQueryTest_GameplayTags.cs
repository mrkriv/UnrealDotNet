// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Tests\EnvQueryTest_GameplayTags.h:14

namespace UnrealEngine
{
	public partial class UEnvQueryTest_GameplayTags : UEnvQueryTest
	{
		public UEnvQueryTest_GameplayTags(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryTest_GameplayTags(UObject Parent = null, string Name = "EnvQueryTest_GameplayTags")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryTest_GameplayTags(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryTest_GameplayTags(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryTest_GameplayTags self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryTest_GameplayTags(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryTest_GameplayTags>(PtrDesc);
		}}}
