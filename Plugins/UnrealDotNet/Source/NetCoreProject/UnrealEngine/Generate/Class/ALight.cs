using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

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
		private static extern float E_ALight_GetBrightness(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ALight_GetLightComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsToggleable(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnRep_bEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetAffectTranslucentLighting(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetBrightness(IntPtr Self, float NewBrightness);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetCastShadows(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetEnabled(IntPtr Self, bool bSetEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetLightFunctionFadeDistance(IntPtr Self, float NewLightFunctionFadeDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetLightFunctionScale(IntPtr Self, IntPtr NewLightFunctionScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_ToggleEnabled(IntPtr Self);
		
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
		
		public void SetBrightness(float NewBrightness)
			=> E_ALight_SetBrightness(this, NewBrightness);
		
		public void SetCastShadows(bool bNewValue)
			=> E_ALight_SetCastShadows(this, bNewValue);
		
		public void SetEnabled(bool bSetEnabled)
			=> E_ALight_SetEnabled(this, bSetEnabled);
		
		public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
			=> E_ALight_SetLightFunctionFadeDistance(this, NewLightFunctionFadeDistance);
		
		public void SetLightFunctionScale(FVector NewLightFunctionScale)
			=> E_ALight_SetLightFunctionScale(this, NewLightFunctionScale);
		
		public void ToggleEnabled()
			=> E_ALight_ToggleEnabled(this);
		
		#endregion
		
		public static implicit operator IntPtr(ALight Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ALight(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ALight>(PtrDesc);
		}}}
