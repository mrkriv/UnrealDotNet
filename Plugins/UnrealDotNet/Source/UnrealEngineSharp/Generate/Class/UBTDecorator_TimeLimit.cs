// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_TimeLimit.h:14

namespace UnrealEngine
{
	public partial class UBTDecorator_TimeLimit : UBTDecorator
	{
		public UBTDecorator_TimeLimit(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_TimeLimit(UObject Parent = null, string Name = "BTDecorator_TimeLimit")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_TimeLimit(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTDecorator_TimeLimit_TimeLimit_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_TimeLimit_TimeLimit_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_TimeLimit(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// max allowed time for execution of underlying node
		/// </summary>
		public float TimeLimit
		{
			get => E_PROP_UBTDecorator_TimeLimit_TimeLimit_GET(NativePointer);
			set => E_PROP_UBTDecorator_TimeLimit_TimeLimit_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_TimeLimit self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_TimeLimit(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_TimeLimit>(PtrDesc);
		}}}
