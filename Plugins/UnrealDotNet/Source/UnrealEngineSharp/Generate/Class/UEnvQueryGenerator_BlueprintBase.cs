// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_BlueprintBase.h:17

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_BlueprintBase : UEnvQueryGenerator
	{
		public UEnvQueryGenerator_BlueprintBase(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_BlueprintBase(UObject Parent = null, string Name = "EnvQueryGenerator_BlueprintBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_BlueprintBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEnvQueryGenerator_BlueprintBase_GeneratorsActionDescription_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_BlueprintBase_GeneratorsActionDescription_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_BlueprintBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryGenerator_BlueprintBase_AddGeneratedActor(IntPtr self, IntPtr generatedActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryGenerator_BlueprintBase_AddGeneratedVector(IntPtr self, IntPtr generatedVector);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UEnvQueryGenerator_BlueprintBase_GetQuerier(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// A short description of what test does, like "Generate pawn named Joe"
		/// </summary>
		public string GeneratorsActionDescription
		{
			get => E_PROP_UEnvQueryGenerator_BlueprintBase_GeneratorsActionDescription_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_BlueprintBase_GeneratorsActionDescription_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void AddGeneratedActor(AActor generatedActor)
			=> E_UEnvQueryGenerator_BlueprintBase_AddGeneratedActor(this, generatedActor);
		
		public void AddGeneratedVector(FVector generatedVector)
			=> E_UEnvQueryGenerator_BlueprintBase_AddGeneratedVector(this, generatedVector);
		
		public UObject GetQuerier()
			=> E_UEnvQueryGenerator_BlueprintBase_GetQuerier(this);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_BlueprintBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_BlueprintBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_BlueprintBase>(PtrDesc);
		}}}
