// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:229

namespace UnrealEngine
{
	public  partial class FNetViewer : NativeStructWrapper
	{
		internal FNetViewer(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FNetViewer() :
			base(E_CreateStruct_FNetViewer(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FNetViewer_InViewer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FNetViewer_InViewer_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FNetViewer_ViewDir_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FNetViewer_ViewDir_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FNetViewer_ViewLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FNetViewer_ViewLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FNetViewer_ViewTarget_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FNetViewer_ViewTarget_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FNetViewer();
		
		#endregion
		
		#region Property
		public AActor InViewer
		{
			get => E_PROP_FNetViewer_InViewer_GET(NativePointer);
			set => E_PROP_FNetViewer_InViewer_SET(NativePointer, value);
		}

		public FVector ViewDir
		{
			get => E_PROP_FNetViewer_ViewDir_GET(NativePointer);
			set => E_PROP_FNetViewer_ViewDir_SET(NativePointer, value);
		}

		public FVector ViewLocation
		{
			get => E_PROP_FNetViewer_ViewLocation_GET(NativePointer);
			set => E_PROP_FNetViewer_ViewLocation_SET(NativePointer, value);
		}

		public AActor ViewTarget
		{
			get => E_PROP_FNetViewer_ViewTarget_GET(NativePointer);
			set => E_PROP_FNetViewer_ViewTarget_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FNetViewer self)
		{
			return self.NativePointer;
		}

		public static implicit operator FNetViewer(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FNetViewer(Adress, false);
		}}}
