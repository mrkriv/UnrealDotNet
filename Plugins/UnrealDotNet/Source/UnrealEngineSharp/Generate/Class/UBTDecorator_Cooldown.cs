// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_Cooldown.h:21

namespace UnrealEngine
{
	public partial class UBTDecorator_Cooldown : UBTDecorator
	{
		public UBTDecorator_Cooldown(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_Cooldown(UObject Parent = null, string Name = "BTDecorator_Cooldown")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_Cooldown(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTDecorator_Cooldown_CoolDownTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_Cooldown_CoolDownTime_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_Cooldown(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// max allowed time for execution of underlying node
		/// </summary>
		public float CoolDownTime
		{
			get => E_PROP_UBTDecorator_Cooldown_CoolDownTime_GET(NativePointer);
			set => E_PROP_UBTDecorator_Cooldown_CoolDownTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_Cooldown self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_Cooldown(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_Cooldown>(PtrDesc);
		}}}
