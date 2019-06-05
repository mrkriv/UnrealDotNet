// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\RectLightComponent.h:20

namespace UnrealEngine
{
	public partial class URectLightComponent : ULocalLightComponent
	{
		public URectLightComponent(IntPtr adress)
			: base(adress)
		{
		}

		public URectLightComponent(UObject Parent = null, string Name = "RectLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_URectLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_URectLightComponent_BarnDoorAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_URectLightComponent_BarnDoorAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_URectLightComponent_BarnDoorLength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_URectLightComponent_BarnDoorLength_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_URectLightComponent_SourceHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_URectLightComponent_SourceHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_URectLightComponent_SourceWidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_URectLightComponent_SourceWidth_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_URectLightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URectLightComponent_SetBarnDoorAngle(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URectLightComponent_SetBarnDoorLength(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URectLightComponent_SetSourceHeight(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_URectLightComponent_SetSourceWidth(IntPtr self, float bNewValue);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Angle of barn door attached to the light source rect.
		/// </summary>
		public float BarnDoorAngle
		{
			get => E_PROP_URectLightComponent_BarnDoorAngle_GET(NativePointer);
			set => E_PROP_URectLightComponent_BarnDoorAngle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Length of barn door attached to the light source rect.
		/// </summary>
		public float BarnDoorLength
		{
			get => E_PROP_URectLightComponent_BarnDoorLength_GET(NativePointer);
			set => E_PROP_URectLightComponent_BarnDoorLength_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Height of light source rect.
		/// <para>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts. </para>
		/// </summary>
		public float SourceHeight
		{
			get => E_PROP_URectLightComponent_SourceHeight_GET(NativePointer);
			set => E_PROP_URectLightComponent_SourceHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Width of light source rect.
		/// <para>Note that light sources shapes which intersect shadow casting geometry can cause shadowing artifacts. </para>
		/// </summary>
		public float SourceWidth
		{
			get => E_PROP_URectLightComponent_SourceWidth_GET(NativePointer);
			set => E_PROP_URectLightComponent_SourceWidth_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void SetBarnDoorAngle(float newValue)
			=> E_URectLightComponent_SetBarnDoorAngle(this, newValue);
		
		public void SetBarnDoorLength(float newValue)
			=> E_URectLightComponent_SetBarnDoorLength(this, newValue);
		
		public void SetSourceHeight(float newValue)
			=> E_URectLightComponent_SetSourceHeight(this, newValue);
		
		public void SetSourceWidth(float bNewValue)
			=> E_URectLightComponent_SetSourceWidth(this, bNewValue);
		
		#endregion
		
		public static implicit operator IntPtr(URectLightComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator URectLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<URectLightComponent>(PtrDesc);
		}}}
