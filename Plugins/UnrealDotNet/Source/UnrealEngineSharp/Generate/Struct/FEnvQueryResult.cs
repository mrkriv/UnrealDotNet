// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:503

namespace UnrealEngine
{
	public partial class FEnvQueryResult : NativeStructWrapper
	{
		public FEnvQueryResult(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryResult() :
			base(E_CreateStruct_FEnvQueryResult(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryResult_OptionIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryResult_OptionIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryResult_QueryID_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryResult_QueryID_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryResult();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FEnvQueryResult_GetItemAsActor(IntPtr self, int index);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FEnvQueryResult_GetItemAsLocation(IntPtr self, int index);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FEnvQueryResult_GetItemScore(IntPtr self, int index);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FEnvQueryResult_IsAborted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FEnvQueryResult_IsFinished(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FEnvQueryResult_IsSuccsessful(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryResult_MarkAsAborted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryResult_MarkAsFailed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryResult_MarkAsFinishedWithoutIssues(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryResult_MarkAsMissingParam(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryResult_MarkAsOwnerLost(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// index of query option, that generated items
		/// </summary>
		public int OptionIndex
		{
			get => E_PROP_FEnvQueryResult_OptionIndex_GET(NativePointer);
			set => E_PROP_FEnvQueryResult_OptionIndex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// instance ID
		/// </summary>
		public int QueryID
		{
			get => E_PROP_FEnvQueryResult_QueryID_GET(NativePointer);
			set => E_PROP_FEnvQueryResult_QueryID_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// item accessors for basic types
		/// </summary>
		public AActor GetItemAsActor(int index)
			=> E_FEnvQueryResult_GetItemAsActor(this, index);
		
		public FVector GetItemAsLocation(int index)
			=> E_FEnvQueryResult_GetItemAsLocation(this, index);
		
		public float GetItemScore(int index)
			=> E_FEnvQueryResult_GetItemScore(this, index);
		
		public bool IsAborted()
			=> E_FEnvQueryResult_IsAborted(this);
		
		public bool IsFinished()
			=> E_FEnvQueryResult_IsFinished(this);
		
		public bool IsSuccsessful()
			=> E_FEnvQueryResult_IsSuccsessful(this);
		
		public void MarkAsAborted()
			=> E_FEnvQueryResult_MarkAsAborted(this);
		
		public void MarkAsFailed()
			=> E_FEnvQueryResult_MarkAsFailed(this);
		
		public void MarkAsFinishedWithoutIssues()
			=> E_FEnvQueryResult_MarkAsFinishedWithoutIssues(this);
		
		public void MarkAsMissingParam()
			=> E_FEnvQueryResult_MarkAsMissingParam(this);
		
		public void MarkAsOwnerLost()
			=> E_FEnvQueryResult_MarkAsOwnerLost(this);
		
		#endregion
		
		public static implicit operator IntPtr(FEnvQueryResult self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryResult(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryResult(adress, false);
		}}}
