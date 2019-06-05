// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\DebugTextInfo.h:19

namespace UnrealEngine
{
	public partial class FDebugTextInfo : NativeStructWrapper
	{
		public FDebugTextInfo(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FDebugTextInfo() :
			base(E_CreateStruct_FDebugTextInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FDebugTextInfo_DebugText_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTextInfo_DebugText_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugTextInfo_Duration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTextInfo_Duration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugTextInfo_FontScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTextInfo_FontScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugTextInfo_OrigActorLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTextInfo_OrigActorLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FDebugTextInfo_SrcActor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTextInfo_SrcActor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugTextInfo_SrcActorDesiredOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTextInfo_SrcActorDesiredOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDebugTextInfo_SrcActorOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTextInfo_SrcActorOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugTextInfo_TimeRemaining_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugTextInfo_TimeRemaining_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDebugTextInfo();
		
		#endregion
		
		#region Property
		public string DebugText
		{
			get => E_PROP_FDebugTextInfo_DebugText_GET(NativePointer);
			set => E_PROP_FDebugTextInfo_DebugText_SET(NativePointer, value);
		}

		public float Duration
		{
			get => E_PROP_FDebugTextInfo_Duration_GET(NativePointer);
			set => E_PROP_FDebugTextInfo_Duration_SET(NativePointer, value);
		}

		public float FontScale
		{
			get => E_PROP_FDebugTextInfo_FontScale_GET(NativePointer);
			set => E_PROP_FDebugTextInfo_FontScale_SET(NativePointer, value);
		}

		public FVector OrigActorLocation
		{
			get => E_PROP_FDebugTextInfo_OrigActorLocation_GET(NativePointer);
			set => E_PROP_FDebugTextInfo_OrigActorLocation_SET(NativePointer, value);
		}

		public AActor SrcActor
		{
			get => E_PROP_FDebugTextInfo_SrcActor_GET(NativePointer);
			set => E_PROP_FDebugTextInfo_SrcActor_SET(NativePointer, value);
		}

		public FVector SrcActorDesiredOffset
		{
			get => E_PROP_FDebugTextInfo_SrcActorDesiredOffset_GET(NativePointer);
			set => E_PROP_FDebugTextInfo_SrcActorDesiredOffset_SET(NativePointer, value);
		}

		public FVector SrcActorOffset
		{
			get => E_PROP_FDebugTextInfo_SrcActorOffset_GET(NativePointer);
			set => E_PROP_FDebugTextInfo_SrcActorOffset_SET(NativePointer, value);
		}

		public float TimeRemaining
		{
			get => E_PROP_FDebugTextInfo_TimeRemaining_GET(NativePointer);
			set => E_PROP_FDebugTextInfo_TimeRemaining_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDebugTextInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FDebugTextInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FDebugTextInfo(adress, false);
		}}}
