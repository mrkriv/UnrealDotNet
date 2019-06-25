// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:357

namespace UnrealEngine
{
	public partial class FBTNodeIndex : NativeStructWrapper
	{
		public FBTNodeIndex(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTNodeIndex() :
			base(E_CreateStruct_FBTNodeIndex(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTNodeIndex();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FBTNodeIndex_Describe(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBTNodeIndex_IsSet(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBTNodeIndex_TakesPriorityOver(IntPtr self, IntPtr other);
		
		#endregion
		
		#region ExternMethods
		public string Describe()
			=> E_FBTNodeIndex_Describe(this);
		
		public bool IsSet()
			=> E_FBTNodeIndex_IsSet(this);
		
		public bool TakesPriorityOver(FBTNodeIndex other)
			=> E_FBTNodeIndex_TakesPriorityOver(this, other);
		
		#endregion
		
		public static implicit operator IntPtr(FBTNodeIndex self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTNodeIndex(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTNodeIndex(adress, false);
		}}}
