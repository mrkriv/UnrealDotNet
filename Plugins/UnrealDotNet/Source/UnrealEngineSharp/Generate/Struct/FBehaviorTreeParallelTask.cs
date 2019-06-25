// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:171

namespace UnrealEngine
{
	public partial class FBehaviorTreeParallelTask : NativeStructWrapper
	{
		public FBehaviorTreeParallelTask(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBehaviorTreeParallelTask() :
			base(E_CreateStruct_FBehaviorTreeParallelTask(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeParallelTask();
		
		#endregion
		
		public static implicit operator IntPtr(FBehaviorTreeParallelTask self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBehaviorTreeParallelTask(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBehaviorTreeParallelTask(adress, false);
		}}}
