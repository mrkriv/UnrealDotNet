// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_Sequence.h:11

namespace UnrealEngine
{
	public partial class UPawnAction_Sequence : UPawnAction
	{
		public UPawnAction_Sequence(IntPtr adress)
			: base(adress)
		{
		}

		public UPawnAction_Sequence(UObject Parent = null, string Name = "PawnAction_Sequence")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnAction_Sequence(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UPawnAction_Sequence_RecentActionCopy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnAction_Sequence_RecentActionCopy_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnAction_Sequence(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Sequence_PushNextActionCopy(IntPtr self);
		
		#endregion
		
		#region Property
		public UPawnAction RecentActionCopy
		{
			get => E_PROP_UPawnAction_Sequence_RecentActionCopy_GET(NativePointer);
			set => E_PROP_UPawnAction_Sequence_RecentActionCopy_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected bool PushNextActionCopy()
			=> E_UPawnAction_Sequence_PushNextActionCopy(this);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnAction_Sequence self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPawnAction_Sequence(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnAction_Sequence>(PtrDesc);
		}}}
