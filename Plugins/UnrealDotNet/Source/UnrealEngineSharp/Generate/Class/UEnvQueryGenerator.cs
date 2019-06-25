// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryGenerator.h:21

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator : UEnvQueryNode
	{
		public UEnvQueryGenerator(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator(UObject Parent = null, string Name = "EnvQueryGenerator")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEnvQueryGenerator_OptionName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OptionName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryGenerator_GenerateItems(IntPtr self, IntPtr queryInstance);
		
		#endregion
		
		#region Property
		public string OptionName
		{
			get => E_PROP_UEnvQueryGenerator_OptionName_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OptionName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public virtual void GenerateItems(FEnvQueryInstance queryInstance)
			=> E_UEnvQueryGenerator_GenerateItems(this, queryInstance);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator>(PtrDesc);
		}}}
