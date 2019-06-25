// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_Blackboard.h:35

namespace UnrealEngine
{
	public partial class UBTDecorator_Blackboard : UBTDecorator_BlackboardBase
	{
		public UBTDecorator_Blackboard(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_Blackboard(UObject Parent = null, string Name = "BTDecorator_Blackboard")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_Blackboard(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_Blackboard(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_Blackboard_EvaluateOnBlackboard(IntPtr self, IntPtr blackboardComp);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// take blackboard value and evaluate decorator's condition
		/// </summary>
		protected bool EvaluateOnBlackboard(UBlackboardComponent blackboardComp)
			=> E_UBTDecorator_Blackboard_EvaluateOnBlackboard(this, blackboardComp);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_Blackboard self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_Blackboard(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_Blackboard>(PtrDesc);
		}}}
