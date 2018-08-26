// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

namespace UnrealEngine
{
	public  partial class ALight : AActor
	{
		public ALight(IntPtr Adress)
			: base(Adress)
		{
		}

		public ALight(UObject Parent = null, string Name = "Light")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ALight(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ALight(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ALight_GetBrightness(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ALight_GetLightComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsToggleable(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnRep_bEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetAffectTranslucentLighting(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetBrightness(IntPtr self, float newBrightness);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetCastShadows(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetEnabled(IntPtr self, bool bSetEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetLightFunctionFadeDistance(IntPtr self, float newLightFunctionFadeDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetLightFunctionScale(IntPtr self, IntPtr newLightFunctionScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_ToggleEnabled(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public float GetBrightness()
			=> E_ALight_GetBrightness(this);
		
		
		/// <summary>
		/// <para>Returns LightComponent subobject </para>
		/// </summary>
		public ULightComponent GetLightComponent()
			=> E_ALight_GetLightComponent(this);
		
		public bool IsEnabled()
			=> E_ALight_IsEnabled(this);
		
		
		/// <summary>
		/// <para>Return whether the light supports being toggled off and on on-the-fly. </para>
		/// </summary>
		public bool IsToggleable()
			=> E_ALight_IsToggleable(this);
		
		public virtual void OnRep_bEnabled()
			=> E_ALight_OnRep_bEnabled(this);
		
		public void SetAffectTranslucentLighting(bool bNewValue)
			=> E_ALight_SetAffectTranslucentLighting(this, bNewValue);
		
		public void SetBrightness(float newBrightness)
			=> E_ALight_SetBrightness(this, newBrightness);
		
		public void SetCastShadows(bool bNewValue)
			=> E_ALight_SetCastShadows(this, bNewValue);
		
		public void SetEnabled(bool bSetEnabled)
			=> E_ALight_SetEnabled(this, bSetEnabled);
		
		public void SetLightFunctionFadeDistance(float newLightFunctionFadeDistance)
			=> E_ALight_SetLightFunctionFadeDistance(this, newLightFunctionFadeDistance);
		
		public void SetLightFunctionScale(FVector newLightFunctionScale)
			=> E_ALight_SetLightFunctionScale(this, newLightFunctionScale);
		
		public void ToggleEnabled()
			=> E_ALight_ToggleEnabled(this);
		
		#endregion
		
		public static implicit operator IntPtr(ALight self)
		{
			return self.NativePointer;
		}

		public static implicit operator ALight(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ALight>(PtrDesc);
		}}}
