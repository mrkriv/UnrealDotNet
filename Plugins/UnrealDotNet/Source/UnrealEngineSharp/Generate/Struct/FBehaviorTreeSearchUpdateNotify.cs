// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:400

namespace UnrealEngine
{
	public partial class FBehaviorTreeSearchUpdateNotify : NativeStructWrapper
	{
		public FBehaviorTreeSearchUpdateNotify(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBehaviorTreeSearchUpdateNotify() :
			base(E_CreateStruct_FBehaviorTreeSearchUpdateNotify(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeSearchUpdateNotify();
		
		#endregion
		
		public static implicit operator IntPtr(FBehaviorTreeSearchUpdateNotify self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBehaviorTreeSearchUpdateNotify(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBehaviorTreeSearchUpdateNotify(adress, false);
		}}}
