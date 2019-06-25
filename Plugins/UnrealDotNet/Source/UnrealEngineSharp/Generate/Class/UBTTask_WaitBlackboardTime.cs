// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_WaitBlackboardTime.h:16

namespace UnrealEngine
{
	public partial class UBTTask_WaitBlackboardTime : UBTTask_Wait
	{
		public UBTTask_WaitBlackboardTime(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_WaitBlackboardTime(UObject Parent = null, string Name = "BTTask_WaitBlackboardTime")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_WaitBlackboardTime(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_WaitBlackboardTime(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBTTask_WaitBlackboardTime_GetSelectedBlackboardKey(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// get name of selected blackboard key
		/// </summary>
		public string GetSelectedBlackboardKey()
			=> E_UBTTask_WaitBlackboardTime_GetSelectedBlackboardKey(this);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_WaitBlackboardTime self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_WaitBlackboardTime(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_WaitBlackboardTime>(PtrDesc);
		}}}
