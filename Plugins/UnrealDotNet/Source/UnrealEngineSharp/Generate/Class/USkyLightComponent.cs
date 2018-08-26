// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkyLightComponent.h:92

namespace UnrealEngine
{
	public  partial class USkyLightComponent : ULightComponentBase
	{
		public USkyLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USkyLightComponent(UObject Parent = null, string Name = "SkyLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USkyLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USkyLightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkyLightComponent_IsOcclusionSupported(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_RecaptureSky(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SanitizeCubemapSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetCaptureIsDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_UpdateLimitedRenderingStateFast(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_UpdateOcclusionRenderingStateFast(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Whether sky occlusion is supported by current feature level </para>
		/// </summary>
		public bool IsOcclusionSupported()
			=> E_USkyLightComponent_IsOcclusionSupported(this);
		
		
		/// <summary>
		/// <para>Recaptures the scene for the skylight. </para>
		/// <para>This is useful for making sure the sky light is up to date after changing something in the world that it would capture. </para>
		/// <para>Warning: this is very costly and will definitely cause a hitch. </para>
		/// </summary>
		public void RecaptureSky()
			=> E_USkyLightComponent_RecaptureSky(this);
		
		public void SanitizeCubemapSize()
			=> E_USkyLightComponent_SanitizeCubemapSize(this);
		
		public void SetBlendDestinationCaptureIsDirty()
			=> E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(this);
		
		
		/// <summary>
		/// <para>Indicates that the capture needs to recapture the scene, adds it to the recapture queue. </para>
		/// </summary>
		public void SetCaptureIsDirty()
			=> E_USkyLightComponent_SetCaptureIsDirty(this);
		
		protected void UpdateLimitedRenderingStateFast()
			=> E_USkyLightComponent_UpdateLimitedRenderingStateFast(this);
		
		protected void UpdateOcclusionRenderingStateFast()
			=> E_USkyLightComponent_UpdateOcclusionRenderingStateFast(this);
		
		#endregion
		
		public static implicit operator IntPtr(USkyLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USkyLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkyLightComponent>(PtrDesc);
		}}}
