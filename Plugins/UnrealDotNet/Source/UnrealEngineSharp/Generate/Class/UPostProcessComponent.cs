// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PostProcessComponent.h:21

namespace UnrealEngine
{
	public  partial class UPostProcessComponent : USceneComponent
	{
		public UPostProcessComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPostProcessComponent(UObject Parent = null, string Name = "PostProcessComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPostProcessComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPostProcessComponent_BlendRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPostProcessComponent_BlendRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPostProcessComponent_BlendWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPostProcessComponent_BlendWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPostProcessComponent_Priority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPostProcessComponent_Priority_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UPostProcessComponent_Settings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPostProcessComponent_Settings_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPostProcessComponent(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>World space radius around the volume that is used for blending (only if not unbound). </para>
		/// </summary>
		public float BlendRadius
		{
			get => E_PROP_UPostProcessComponent_BlendRadius_GET(NativePointer);
			set => E_PROP_UPostProcessComponent_BlendRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>0:no effect, 1:full effect </para>
		/// </summary>
		public float BlendWeight
		{
			get => E_PROP_UPostProcessComponent_BlendWeight_GET(NativePointer);
			set => E_PROP_UPostProcessComponent_BlendWeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Priority of this volume. In the case of overlapping volumes the one with the highest priority </para>
		/// <para>overrides the lower priority ones. The order is undefined if two or more overlapping volumes have the same priority. </para>
		/// </summary>
		public float Priority
		{
			get => E_PROP_UPostProcessComponent_Priority_GET(NativePointer);
			set => E_PROP_UPostProcessComponent_Priority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Post process settings to use for this volume. </para>
		/// </summary>
		public FPostProcessSettings Settings
		{
			get => E_PROP_UPostProcessComponent_Settings_GET(NativePointer);
			set => E_PROP_UPostProcessComponent_Settings_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UPostProcessComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UPostProcessComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPostProcessComponent>(PtrDesc);
		}}}
