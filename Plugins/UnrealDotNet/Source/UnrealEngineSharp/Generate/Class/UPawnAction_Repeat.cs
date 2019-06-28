// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_Repeat.h:11

namespace UnrealEngine
{
	public partial class UPawnAction_Repeat : UPawnAction
	{
		public UPawnAction_Repeat(IntPtr adress)
			: base(adress)
		{
		}

		public UPawnAction_Repeat(UObject Parent = null, string Name = "PawnAction_Repeat")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnAction_Repeat(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UPawnAction_Repeat_ActionToRepeat_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnAction_Repeat_ActionToRepeat_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UPawnAction_Repeat_RecentActionCopy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnAction_Repeat_RecentActionCopy_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPawnAction_Repeat_RepeatsLeft_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnAction_Repeat_RepeatsLeft_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnAction_Repeat(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnAction_Repeat_CreateAction(IntPtr self, IntPtr world, IntPtr actionToRepeat, int numberOfRepeats);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Repeat_PushSubAction(IntPtr self);
		
		#endregion
		
		#region Property
		public UPawnAction ActionToRepeat
		{
			get => E_PROP_UPawnAction_Repeat_ActionToRepeat_GET(NativePointer);
			set => E_PROP_UPawnAction_Repeat_ActionToRepeat_SET(NativePointer, value);
		}

		public UPawnAction RecentActionCopy
		{
			get => E_PROP_UPawnAction_Repeat_RecentActionCopy_GET(NativePointer);
			set => E_PROP_UPawnAction_Repeat_RecentActionCopy_SET(NativePointer, value);
		}

		public int RepeatsLeft
		{
			get => E_PROP_UPawnAction_Repeat_RepeatsLeft_GET(NativePointer);
			set => E_PROP_UPawnAction_Repeat_RepeatsLeft_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// </summary>
		/// <param name="numberOfRepeats">number of times to repeat action. UPawnAction_Repeat::LoopForever loops forever</param>
		public UPawnAction_Repeat CreateAction(UWorld world, UPawnAction actionToRepeat, int numberOfRepeats)
			=> E_UPawnAction_Repeat_CreateAction(this, world, actionToRepeat, numberOfRepeats);
		
		protected bool PushSubAction()
			=> E_UPawnAction_Repeat_PushSubAction(this);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnAction_Repeat self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPawnAction_Repeat(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnAction_Repeat>(PtrDesc);
		}}}
