using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:22

namespace UnrealEngine
{
	public  partial class FOverlapInfo : NativeStructWrapper
	{
		internal FOverlapInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FOverlapInfo() :
			base(E_CreateStruct_FOverlapInfo(), false)
		{
		}

		public FOverlapInfo(FHitResult InSweepResult) :
			base(E_CreateStruct_FOverlapInfo_FHitResult(InSweepResult), false)
		{
		}

		public FOverlapInfo(UPrimitiveComponent InComponent, int InBodyIndex) :
			base(E_CreateStruct_FOverlapInfo_UPrimitiveComponent_int32(InComponent, InBodyIndex), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapInfo_FHitResult(IntPtr InSweepResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapInfo_UPrimitiveComponent_int32(IntPtr InComponent, int InBodyIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FOverlapInfo_bFromSweep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOverlapInfo_bFromSweep_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FOverlapInfo_OverlapInfo_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOverlapInfo_OverlapInfo_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FOverlapInfo_GetBodyIndex(IntPtr Self);
		
		#endregion
		
		#region Property
		public bool bFromSweep
		{
			get => E_PROP_FOverlapInfo_bFromSweep_GET(NativePointer);
			set => E_PROP_FOverlapInfo_bFromSweep_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Information for both sweep and overlap queries. Different parts are valid depending on bFromSweep. </para>
		/// <para>If bFromSweep is true then FHitResult is completely valid just like a regular sweep result. </para>
		/// <para>If bFromSweep is false only FHitResult::Component, FHitResult::Actor, FHitResult::Item are valid as this is really just an FOverlapResult </para>
		/// </summary>
		public FHitResult OverlapInfo
		{
			get => E_PROP_FOverlapInfo_OverlapInfo_GET(NativePointer);
			set => E_PROP_FOverlapInfo_OverlapInfo_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public int GetBodyIndex()
			=> E_FOverlapInfo_GetBodyIndex(this);
		
		#endregion
		
		public static implicit operator IntPtr(FOverlapInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FOverlapInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FOverlapInfo(Adress, false);
		}}}
