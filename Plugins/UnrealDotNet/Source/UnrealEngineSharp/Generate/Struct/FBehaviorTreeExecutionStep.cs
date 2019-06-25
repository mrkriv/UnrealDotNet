// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:248

namespace UnrealEngine
{
	public partial class FBehaviorTreeExecutionStep : NativeStructWrapper
	{
		public FBehaviorTreeExecutionStep(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBehaviorTreeExecutionStep() :
			base(E_CreateStruct_FBehaviorTreeExecutionStep(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FBehaviorTreeExecutionStep_StepIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeExecutionStep_StepIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBehaviorTreeExecutionStep_TimeStamp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeExecutionStep_TimeStamp_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeExecutionStep();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// index of execution step
		/// </summary>
		public int StepIndex
		{
			get => E_PROP_FBehaviorTreeExecutionStep_StepIndex_GET(NativePointer);
			set => E_PROP_FBehaviorTreeExecutionStep_StepIndex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Game world's time stamp of this step
		/// </summary>
		public float TimeStamp
		{
			get => E_PROP_FBehaviorTreeExecutionStep_TimeStamp_GET(NativePointer);
			set => E_PROP_FBehaviorTreeExecutionStep_TimeStamp_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBehaviorTreeExecutionStep self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBehaviorTreeExecutionStep(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBehaviorTreeExecutionStep(adress, false);
		}}}
