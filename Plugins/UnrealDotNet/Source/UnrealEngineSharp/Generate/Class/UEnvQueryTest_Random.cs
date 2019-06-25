// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Tests\EnvQueryTest_Random.h:11

namespace UnrealEngine
{
	public partial class UEnvQueryTest_Random : UEnvQueryTest
	{
		public UEnvQueryTest_Random(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryTest_Random(UObject Parent = null, string Name = "EnvQueryTest_Random")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryTest_Random(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryTest_Random(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryTest_Random self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryTest_Random(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryTest_Random>(PtrDesc);
		}}}
