// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryOption.h:14

namespace UnrealEngine
{
	public partial class UEnvQueryOption : UObject
	{
		public UEnvQueryOption(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryOption(UObject Parent = null, string Name = "EnvQueryOption")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryOption(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UEnvQueryOption_Generator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryOption_Generator_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryOption(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEnvQueryOption_GetDescriptionDetails(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEnvQueryOption_GetDescriptionTitle(IntPtr self);
		
		#endregion
		
		#region Property
		public UEnvQueryGenerator Generator
		{
			get => E_PROP_UEnvQueryOption_Generator_GET(NativePointer);
			set => E_PROP_UEnvQueryOption_Generator_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public string GetDescriptionDetails()
			=> E_UEnvQueryOption_GetDescriptionDetails(this);
		
		public string GetDescriptionTitle()
			=> E_UEnvQueryOption_GetDescriptionTitle(this);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryOption self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryOption(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryOption>(PtrDesc);
		}}}
