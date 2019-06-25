// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Services\BTService_BlackboardBase.h:12

namespace UnrealEngine
{
	public partial class UBTService_BlackboardBase : UBTService
	{
		public UBTService_BlackboardBase(IntPtr adress)
			: base(adress)
		{
		}

		public UBTService_BlackboardBase(UObject Parent = null, string Name = "BTService_BlackboardBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTService_BlackboardBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTService_BlackboardBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBTService_BlackboardBase_GetSelectedBlackboardKey(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// get name of selected blackboard key
		/// </summary>
		public string GetSelectedBlackboardKey()
			=> E_UBTService_BlackboardBase_GetSelectedBlackboardKey(this);
		
		#endregion
		
		public static implicit operator IntPtr(UBTService_BlackboardBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTService_BlackboardBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTService_BlackboardBase>(PtrDesc);
		}}}
