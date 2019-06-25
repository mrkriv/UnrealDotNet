// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_BlackboardBase.h:13

namespace UnrealEngine
{
	public partial class UBTTask_BlackboardBase : UBTTaskNode
	{
		public UBTTask_BlackboardBase(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_BlackboardBase(UObject Parent = null, string Name = "BTTask_BlackboardBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_BlackboardBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_BlackboardBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBTTask_BlackboardBase_GetSelectedBlackboardKey(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// get name of selected blackboard key
		/// </summary>
		public string GetSelectedBlackboardKey()
			=> E_UBTTask_BlackboardBase_GetSelectedBlackboardKey(this);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_BlackboardBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_BlackboardBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_BlackboardBase>(PtrDesc);
		}}}
