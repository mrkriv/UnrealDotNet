// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_BlackboardBase.h:15

namespace UnrealEngine
{
	public partial class UBTDecorator_BlackboardBase : UBTDecorator
	{
		public UBTDecorator_BlackboardBase(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_BlackboardBase(UObject Parent = null, string Name = "BTDecorator_BlackboardBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_BlackboardBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_BlackboardBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBTDecorator_BlackboardBase_GetSelectedBlackboardKey(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// get name of selected blackboard key
		/// </summary>
		public string GetSelectedBlackboardKey()
			=> E_UBTDecorator_BlackboardBase_GetSelectedBlackboardKey(this);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_BlackboardBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_BlackboardBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_BlackboardBase>(PtrDesc);
		}}}
