// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:476

namespace UnrealEngine
{
	public partial class FBlackboardKeySelector : NativeStructWrapper
	{
		public FBlackboardKeySelector(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBlackboardKeySelector() :
			base(E_CreateStruct_FBlackboardKeySelector(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FBlackboardKeySelector_SelectedKeyName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBlackboardKeySelector_SelectedKeyName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBlackboardKeySelector();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// name of selected key
		/// </summary>
		public string SelectedKeyName
		{
			get => E_PROP_FBlackboardKeySelector_SelectedKeyName_GET(NativePointer);
			set => E_PROP_FBlackboardKeySelector_SelectedKeyName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBlackboardKeySelector self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBlackboardKeySelector(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBlackboardKeySelector(adress, false);
		}}}
