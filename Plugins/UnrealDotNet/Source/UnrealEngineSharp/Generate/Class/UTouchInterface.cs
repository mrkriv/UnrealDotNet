// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\TouchInterface.h:56

namespace UnrealEngine
{
	public partial class UTouchInterface : UObject
	{
		public UTouchInterface(IntPtr adress)
			: base(adress)
		{
		}

		public UTouchInterface(UObject Parent = null, string Name = "TouchInterface")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UTouchInterface(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTouchInterface_ActivationDelay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTouchInterface_ActivationDelay_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTouchInterface_ActiveOpacity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTouchInterface_ActiveOpacity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UTouchInterface_bPreventRecenter_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTouchInterface_bPreventRecenter_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTouchInterface_InactiveOpacity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTouchInterface_InactiveOpacity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTouchInterface_StartupDelay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTouchInterface_StartupDelay_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTouchInterface_TimeUntilDeactive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTouchInterface_TimeUntilDeactive_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTouchInterface_TimeUntilReset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTouchInterface_TimeUntilReset_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UTouchInterface(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		public float ActivationDelay
		{
			get => E_PROP_UTouchInterface_ActivationDelay_GET(NativePointer);
			set => E_PROP_UTouchInterface_ActivationDelay_SET(NativePointer, value);
		}

		public float ActiveOpacity
		{
			get => E_PROP_UTouchInterface_ActiveOpacity_GET(NativePointer);
			set => E_PROP_UTouchInterface_ActiveOpacity_SET(NativePointer, value);
		}

		public bool bPreventRecenter
		{
			get => E_PROP_UTouchInterface_bPreventRecenter_GET(NativePointer);
			set => E_PROP_UTouchInterface_bPreventRecenter_SET(NativePointer, value);
		}

		public float InactiveOpacity
		{
			get => E_PROP_UTouchInterface_InactiveOpacity_GET(NativePointer);
			set => E_PROP_UTouchInterface_InactiveOpacity_SET(NativePointer, value);
		}

		public float StartupDelay
		{
			get => E_PROP_UTouchInterface_StartupDelay_GET(NativePointer);
			set => E_PROP_UTouchInterface_StartupDelay_SET(NativePointer, value);
		}

		public float TimeUntilDeactive
		{
			get => E_PROP_UTouchInterface_TimeUntilDeactive_GET(NativePointer);
			set => E_PROP_UTouchInterface_TimeUntilDeactive_SET(NativePointer, value);
		}

		public float TimeUntilReset
		{
			get => E_PROP_UTouchInterface_TimeUntilReset_GET(NativePointer);
			set => E_PROP_UTouchInterface_TimeUntilReset_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UTouchInterface self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UTouchInterface(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UTouchInterface>(PtrDesc);
		}}}
