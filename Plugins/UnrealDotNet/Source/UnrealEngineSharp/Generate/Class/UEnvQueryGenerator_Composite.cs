// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_Composite.h:16

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_Composite : UEnvQueryGenerator
	{
		public UEnvQueryGenerator_Composite(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_Composite(UObject Parent = null, string Name = "EnvQueryGenerator_Composite")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_Composite(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_Composite(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryGenerator_Composite_VerifyItemTypes(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public void VerifyItemTypes()
			=> E_UEnvQueryGenerator_Composite_VerifyItemTypes(this);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_Composite self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_Composite(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_Composite>(PtrDesc);
		}}}
