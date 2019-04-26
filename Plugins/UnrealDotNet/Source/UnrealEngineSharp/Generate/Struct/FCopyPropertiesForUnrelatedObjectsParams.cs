// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:2610

namespace UnrealEngine
{
	public  partial class FCopyPropertiesForUnrelatedObjectsParams : NativeStructWrapper
	{
		internal FCopyPropertiesForUnrelatedObjectsParams(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCopyPropertiesForUnrelatedObjectsParams() :
			base(E_CreateStruct_FCopyPropertiesForUnrelatedObjectsParams(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bAggressiveDefaultSubobjectReplacement_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bAggressiveDefaultSubobjectReplacement_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bClearReferences_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bClearReferences_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bCopyDeprecatedProperties_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bCopyDeprecatedProperties_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bDoDelta_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bDoDelta_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bNotifyObjectReplacement_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bNotifyObjectReplacement_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bPreserveRootComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bPreserveRootComponent_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bReplaceObjectClassReferences_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bReplaceObjectClassReferences_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bSkipCompilerGeneratedDefaults_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bSkipCompilerGeneratedDefaults_SET(IntPtr Ptr, bool Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCopyPropertiesForUnrelatedObjectsParams();
		
		#endregion
		
		#region Property
		public bool bAggressiveDefaultSubobjectReplacement
		{
			get => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bAggressiveDefaultSubobjectReplacement_GET(NativePointer);
			set => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bAggressiveDefaultSubobjectReplacement_SET(NativePointer, value);
		}

		public bool bClearReferences
		{
			get => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bClearReferences_GET(NativePointer);
			set => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bClearReferences_SET(NativePointer, value);
		}

		public bool bCopyDeprecatedProperties
		{
			get => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bCopyDeprecatedProperties_GET(NativePointer);
			set => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bCopyDeprecatedProperties_SET(NativePointer, value);
		}

		public bool bDoDelta
		{
			get => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bDoDelta_GET(NativePointer);
			set => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bDoDelta_SET(NativePointer, value);
		}

		public bool bNotifyObjectReplacement
		{
			get => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bNotifyObjectReplacement_GET(NativePointer);
			set => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bNotifyObjectReplacement_SET(NativePointer, value);
		}

		public bool bPreserveRootComponent
		{
			get => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bPreserveRootComponent_GET(NativePointer);
			set => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bPreserveRootComponent_SET(NativePointer, value);
		}

		public bool bReplaceObjectClassReferences
		{
			get => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bReplaceObjectClassReferences_GET(NativePointer);
			set => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bReplaceObjectClassReferences_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Skips copying properties with BlueprintCompilerGeneratedDefaults metadata </para>
		/// </summary>
		public bool bSkipCompilerGeneratedDefaults
		{
			get => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bSkipCompilerGeneratedDefaults_GET(NativePointer);
			set => E_PROP_FCopyPropertiesForUnrelatedObjectsParams_bSkipCompilerGeneratedDefaults_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCopyPropertiesForUnrelatedObjectsParams self)
		{
			return self.NativePointer;
		}

		public static implicit operator FCopyPropertiesForUnrelatedObjectsParams(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCopyPropertiesForUnrelatedObjectsParams(Adress, false);
		}}}
