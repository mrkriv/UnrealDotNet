// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_TagCooldown.h:21

namespace UnrealEngine
{
	public partial class UBTDecorator_TagCooldown : UBTDecorator
	{
		public UBTDecorator_TagCooldown(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_TagCooldown(UObject Parent = null, string Name = "BTDecorator_TagCooldown")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_TagCooldown(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UBTDecorator_TagCooldown_bActivatesCooldown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_TagCooldown_bActivatesCooldown_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UBTDecorator_TagCooldown_bAddToExistingDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_TagCooldown_bAddToExistingDuration_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTDecorator_TagCooldown_CooldownDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_TagCooldown_CooldownDuration_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_TagCooldown(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether or not we are adding/setting to the cooldown tag's value when the decorator deactivates.
		/// </summary>
		public bool AddsSetsCooldownonDeactivation
		{
			get => E_PROP_UBTDecorator_TagCooldown_bActivatesCooldown_GET(NativePointer);
			set => E_PROP_UBTDecorator_TagCooldown_bActivatesCooldown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True if we are adding to any existing duration, false if we are setting the duration (potentially invalidating an existing end time).
		/// </summary>
		public bool bAddToExistingDuration
		{
			get => E_PROP_UBTDecorator_TagCooldown_bAddToExistingDuration_GET(NativePointer);
			set => E_PROP_UBTDecorator_TagCooldown_bAddToExistingDuration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Value we will add or set to the Cooldown tag when this node is deactivated.
		/// </summary>
		public float CooldownDuration
		{
			get => E_PROP_UBTDecorator_TagCooldown_CooldownDuration_GET(NativePointer);
			set => E_PROP_UBTDecorator_TagCooldown_CooldownDuration_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_TagCooldown self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_TagCooldown(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_TagCooldown>(PtrDesc);
		}}}
