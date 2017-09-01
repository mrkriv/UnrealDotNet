using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ALight : AActor
	{
		public ALight(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ALight_OnRep_bEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ALight_SetEnabled(IntPtr Self, bool bSetEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_ALight_IsEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ALight_SetBrightness(IntPtr Self, float NewBrightness);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_ALight_GetBrightness(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ALight_SetLightFunctionScale(IntPtr Self, IntPtr NewLightFunctionScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_ALight_GetLightComponent(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public void OnRep_bEnabled()
			=> E_ALight_OnRep_bEnabled(NativePointer);
		
		public void SetEnabled(bool bSetEnabled)
			=> E_ALight_SetEnabled(NativePointer, bSetEnabled);
		
		public bool IsEnabled()
			=> E_ALight_IsEnabled(NativePointer);
		
		public void SetBrightness(float NewBrightness)
			=> E_ALight_SetBrightness(NativePointer, NewBrightness);
		
		public float GetBrightness()
			=> E_ALight_GetBrightness(NativePointer);
		
		public void SetLightFunctionScale(FVector NewLightFunctionScale)
			=> E_ALight_SetLightFunctionScale(NativePointer, NewLightFunctionScale);
		
		
		/// <summary>
		/// Returns LightComponent subobject
		/// </summary>
		public ULightComponent GetLightComponent()
			=> E_ALight_GetLightComponent(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(ALight Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ALight(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new ALight(Adress);
		}}}
