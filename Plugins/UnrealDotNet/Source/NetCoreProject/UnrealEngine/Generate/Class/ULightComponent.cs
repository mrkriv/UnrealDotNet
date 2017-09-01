using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ULightComponent : ULightComponentBase
	{
		public ULightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ULightComponent_SetIntensity(IntPtr Self, float NewIntensity);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ULightComponent_SetLightFunctionScale(IntPtr Self, IntPtr NewLightFunctionScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ULightComponent_SetAffectDynamicIndirectLighting(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_ULightComponent_AffectsPrimitive(IntPtr Self, IntPtr Primitive);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_ULightComponent_GetBoundingBox(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_ULightComponent_GetLightPosition(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Set intensity of the light
		/// </summary>
		public void SetIntensity(float NewIntensity)
			=> E_ULightComponent_SetIntensity(NativePointer, NewIntensity);
		
		public void SetLightFunctionScale(FVector NewLightFunctionScale)
			=> E_ULightComponent_SetLightFunctionScale(NativePointer, NewLightFunctionScale);
		
		public void SetAffectDynamicIndirectLighting(bool bNewValue)
			=> E_ULightComponent_SetAffectDynamicIndirectLighting(NativePointer, bNewValue);
		
		
		/// <summary>
		/// Test whether this light affects the given primitive.  This checks both the primitive and light settings for light relevance
		/// and also calls AffectsBounds.
		/// @param PrimitiveSceneInfo - The primitive to test.
		/// @return True if the light affects the primitive.
		/// </summary>
		public bool AffectsPrimitive(UPrimitiveComponent Primitive)
			=> E_ULightComponent_AffectsPrimitive(NativePointer, Primitive);
		
		
		/// <summary>
		/// Return the world-space bounding box of the light's influence.
		/// </summary>
		public FBox GetBoundingBox()
			=> E_ULightComponent_GetBoundingBox(NativePointer);
		
		
		/// <summary>
		/// Return the homogenous position of the light.
		/// </summary>
		public FVector4 GetLightPosition()
			=> E_ULightComponent_GetLightPosition(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(ULightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULightComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new ULightComponent(Adress);
		}}}
