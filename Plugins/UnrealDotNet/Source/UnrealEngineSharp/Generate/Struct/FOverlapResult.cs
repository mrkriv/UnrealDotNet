// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2107

namespace UnrealEngine
{
	public  partial class FOverlapResult : NativeStructWrapper
	{
		internal FOverlapResult(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FOverlapResult() :
			base(E_CreateStruct_FOverlapResult(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FOverlapResult_ItemIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOverlapResult_ItemIndex_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapResult();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FOverlapResult_GetActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FOverlapResult_GetComponent(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>This is the index of the overlapping item. </para>
		/// <para>For DestructibleComponents, this is the ChunkInfo index. </para>
		/// <para>For SkeletalMeshComponents this is the Body index or INDEX_NONE for single body </para>
		/// </summary>
		public int ItemIndex
		{
			get => E_PROP_FOverlapResult_ItemIndex_GET(NativePointer);
			set => E_PROP_FOverlapResult_ItemIndex_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Utility to return the Actor that owns the Component that was hit </para>
		/// </summary>
		public AActor GetActor()
			=> E_FOverlapResult_GetActor(this);
		
		
		/// <summary>
		/// <para>Utility to return the Component that was hit </para>
		/// </summary>
		public UPrimitiveComponent GetComponent()
			=> E_FOverlapResult_GetComponent(this);
		
		#endregion
		
		public static implicit operator IntPtr(FOverlapResult self)
		{
			return self.NativePointer;
		}

		public static implicit operator FOverlapResult(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FOverlapResult(Adress, false);
		}}}
