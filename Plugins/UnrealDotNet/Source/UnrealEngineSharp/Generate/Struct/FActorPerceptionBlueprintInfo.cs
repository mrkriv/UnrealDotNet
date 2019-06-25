// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionComponent.h:139

namespace UnrealEngine
{
	public partial class FActorPerceptionBlueprintInfo : NativeStructWrapper
	{
		public FActorPerceptionBlueprintInfo(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FActorPerceptionBlueprintInfo() :
			base(E_CreateStruct_FActorPerceptionBlueprintInfo(), false)
		{
		}

		public FActorPerceptionBlueprintInfo(FActorPerceptionInfo info) :
			base(E_CreateStruct_FActorPerceptionBlueprintInfo_FActorPerceptionInfo(info), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FActorPerceptionBlueprintInfo_Target_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActorPerceptionBlueprintInfo_Target_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorPerceptionBlueprintInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorPerceptionBlueprintInfo_FActorPerceptionInfo(IntPtr info);
		
		#endregion
		
		#region Property
		public AActor Target
		{
			get => E_PROP_FActorPerceptionBlueprintInfo_Target_GET(NativePointer);
			set => E_PROP_FActorPerceptionBlueprintInfo_Target_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FActorPerceptionBlueprintInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FActorPerceptionBlueprintInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FActorPerceptionBlueprintInfo(adress, false);
		}}}
