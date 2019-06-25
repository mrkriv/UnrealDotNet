// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_ConditionalLoop.h:18

namespace UnrealEngine
{
	public partial class UBTDecorator_ConditionalLoop : UBTDecorator_Blackboard
	{
		public UBTDecorator_ConditionalLoop(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_ConditionalLoop(UObject Parent = null, string Name = "BTDecorator_ConditionalLoop")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_ConditionalLoop(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_ConditionalLoop(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_ConditionalLoop self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_ConditionalLoop(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_ConditionalLoop>(PtrDesc);
		}}}
