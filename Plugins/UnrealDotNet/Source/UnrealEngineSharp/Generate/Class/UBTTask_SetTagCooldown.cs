// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_SetTagCooldown.h:15

namespace UnrealEngine
{
	public partial class UBTTask_SetTagCooldown : UBTTaskNode
	{
		public UBTTask_SetTagCooldown(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_SetTagCooldown(UObject Parent = null, string Name = "BTTask_SetTagCooldown")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_SetTagCooldown(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UBTTask_SetTagCooldown_bAddToExistingDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_SetTagCooldown_bAddToExistingDuration_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTTask_SetTagCooldown_CooldownDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_SetTagCooldown_CooldownDuration_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_SetTagCooldown(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// True if we are adding to any existing duration, false if we are setting the duration (potentially invalidating an existing end time).
		/// </summary>
		public bool bAddToExistingDuration
		{
			get => E_PROP_UBTTask_SetTagCooldown_bAddToExistingDuration_GET(NativePointer);
			set => E_PROP_UBTTask_SetTagCooldown_bAddToExistingDuration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Value we will add or set to the Cooldown tag when this task runs.
		/// </summary>
		public float CooldownDuration
		{
			get => E_PROP_UBTTask_SetTagCooldown_CooldownDuration_GET(NativePointer);
			set => E_PROP_UBTTask_SetTagCooldown_CooldownDuration_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBTTask_SetTagCooldown self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_SetTagCooldown(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_SetTagCooldown>(PtrDesc);
		}}}
