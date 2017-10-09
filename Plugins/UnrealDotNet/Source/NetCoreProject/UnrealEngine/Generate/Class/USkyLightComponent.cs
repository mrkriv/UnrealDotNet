using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SkyLightComponent.h:99

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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USkyLightComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_RecaptureSky(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SanitizeCubemapSize(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_SetCaptureIsDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkyLightComponent_UpdateLimitedRenderingStateFast(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
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
		
		#endregion
		
		public static implicit operator IntPtr(USkyLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USkyLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkyLightComponent>(PtrDesc);
		}}}
