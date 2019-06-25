// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:623

namespace UnrealEngine
{
	public partial class FEnvQueryOptionInstance : NativeStructWrapper
	{
		public FEnvQueryOptionInstance(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryOptionInstance() :
			base(E_CreateStruct_FEnvQueryOptionInstance(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FEnvQueryOptionInstance_Generator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryOptionInstance_Generator_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryOptionInstance_SourceOptionIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryOptionInstance_SourceOptionIndex_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryOptionInstance();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// generator object, raw pointer can be used safely because it will be always referenced by EnvQueryManager
		/// </summary>
		public UEnvQueryGenerator Generator
		{
			get => E_PROP_FEnvQueryOptionInstance_Generator_GET(NativePointer);
			set => E_PROP_FEnvQueryOptionInstance_Generator_SET(NativePointer, value);
		}

		
		/// <summary>
		/// index of option in source asset
		/// </summary>
		public int SourceOptionIndex
		{
			get => E_PROP_FEnvQueryOptionInstance_SourceOptionIndex_GET(NativePointer);
			set => E_PROP_FEnvQueryOptionInstance_SourceOptionIndex_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEnvQueryOptionInstance self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryOptionInstance(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryOptionInstance(adress, false);
		}}}
