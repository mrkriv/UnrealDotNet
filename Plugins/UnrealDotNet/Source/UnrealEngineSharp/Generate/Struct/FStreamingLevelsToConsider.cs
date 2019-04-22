// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\World.h:716

namespace UnrealEngine
{
	public  partial class FStreamingLevelsToConsider : NativeStructWrapper
	{
		internal FStreamingLevelsToConsider(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FStreamingLevelsToConsider() :
			base(E_CreateStruct_FStreamingLevelsToConsider(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FStreamingLevelsToConsider_StreamingLevels_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FStreamingLevelsToConsider_StreamingLevels_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStreamingLevelsToConsider();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FStreamingLevelsToConsider_BeginConsideration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FStreamingLevelsToConsider_EndConsideration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FStreamingLevelsToConsider_Reset(IntPtr self);
		
		#endregion
		
		#region Property
		public TArray<FLevelStreamingWrapper> StreamingLevels
		{
			get => E_PROP_FStreamingLevelsToConsider_StreamingLevels_GET(NativePointer);
			set => E_PROP_FStreamingLevelsToConsider_StreamingLevels_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void BeginConsideration()
			=> E_FStreamingLevelsToConsider_BeginConsideration(this);
		
		public void EndConsideration()
			=> E_FStreamingLevelsToConsider_EndConsideration(this);
		
		public void Reset()
			=> E_FStreamingLevelsToConsider_Reset(this);
		
		#endregion
		
		public static implicit operator IntPtr(FStreamingLevelsToConsider self)
		{
			return self.NativePointer;
		}

		public static implicit operator FStreamingLevelsToConsider(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStreamingLevelsToConsider(Adress, false);
		}}}
