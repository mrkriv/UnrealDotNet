using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UCapsuleComponent : UShapeComponent
	{
		public UCapsuleComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UCapsuleComponent(UObject Parent = null, string Name = "CapsuleComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCapsuleComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCapsuleComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCapsuleComponent_CapsuleHalfHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCapsuleComponent_CapsuleHalfHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCapsuleComponent_CapsuleHeight_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCapsuleComponent_CapsuleHeight_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCapsuleComponent_CapsuleRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCapsuleComponent_CapsuleRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleHalfHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetScaledCapsuleSize(IntPtr Self, float OutRadius, float OutHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(IntPtr Self, float OutRadius, float OutHalfHeightWithoutHemisphere);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetShapeScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetUnscaledCapsuleRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetUnscaledCapsuleSize(IntPtr Self, float OutRadius, float OutHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(IntPtr Self, float OutRadius, float OutHalfHeightWithoutHemisphere);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_InitCapsuleSize(IntPtr Self, float InRadius, float InHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCapsuleHalfHeight(IntPtr Self, float HalfHeight, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCapsuleRadius(IntPtr Self, float Radius, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCapsuleSize(IntPtr Self, float InRadius, float InHalfHeight, bool bUpdateOverlaps);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Half-height, from center of capsule to the end of top or bottom hemisphere. </para>
		/// <para>This cannot be less than CapsuleRadius. </para>
		/// </summary>
		protected float CapsuleHalfHeight
		{
			get => E_PROP_UCapsuleComponent_CapsuleHalfHeight_GET(NativePointer);
			set => E_PROP_UCapsuleComponent_CapsuleHalfHeight_SET(NativePointer, value);
		}

		protected float CapsuleHeight_DEPRECATED
		{
			get => E_PROP_UCapsuleComponent_CapsuleHeight_DEPRECATED_GET(NativePointer);
			set => E_PROP_UCapsuleComponent_CapsuleHeight_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Radius of cap hemispheres and center cylinder. </para>
		/// <para>This cannot be more than CapsuleHalfHeight. </para>
		/// </summary>
		protected float CapsuleRadius
		{
			get => E_PROP_UCapsuleComponent_CapsuleRadius_GET(NativePointer);
			set => E_PROP_UCapsuleComponent_CapsuleRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns the capsule half-height scaled by the component scale. This includes both the cylinder and hemisphere cap. </para>
		/// <return>The capsule half-height scaled by the component scale. </return>
		/// </summary>
		public float GetScaledCapsuleHalfHeight()
			=> E_UCapsuleComponent_GetScaledCapsuleHalfHeight(this);
		
		
		/// <summary>
		/// <para>Returns the capsule half-height minus radius (to exclude the hemisphere), scaled by the component scale. </para>
		/// <para>From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins. </para>
		/// <return>The capsule half-height minus radius, scaled by the component scale. </return>
		/// </summary>
		public float GetScaledCapsuleHalfHeight_WithoutHemisphere()
			=> E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(this);
		
		
		/// <summary>
		/// <para>Returns the capsule radius scaled by the component scale. </para>
		/// <return>The capsule radius scaled by the component scale. </return>
		/// </summary>
		public float GetScaledCapsuleRadius()
			=> E_UCapsuleComponent_GetScaledCapsuleRadius(this);
		
		
		/// <summary>
		/// <para>Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap. </para>
		/// <param name="OutRadius">Radius of the capsule, scaled by the component scale. </param>
		/// <param name="OutHalfHeight">Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap. </param>
		/// <return>The capsule radius and half-height scaled by the component scale. </return>
		/// </summary>
		public void GetScaledCapsuleSize(float OutRadius, float OutHalfHeight)
			=> E_UCapsuleComponent_GetScaledCapsuleSize(this, OutRadius, OutHalfHeight);
		
		
		/// <summary>
		/// <para>Returns the capsule radius and half-height scaled by the component scale. Half-height excludes the hemisphere end cap. </para>
		/// <param name="OutRadius">Radius of the capsule, ignoring component scaling. </param>
		/// <param name="OutHalfHeightWithoutHemisphere">Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap. </param>
		/// <return>The capsule radius and half-height scaled by the component scale. </return>
		/// </summary>
		public void GetScaledCapsuleSize_WithoutHemisphere(float OutRadius, float OutHalfHeightWithoutHemisphere)
			=> E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(this, OutRadius, OutHalfHeightWithoutHemisphere);
		
		
		/// <summary>
		/// <para>Get the scale used by this shape. This is a uniform scale that is the minimum of any non-uniform scaling. </para>
		/// <return>the scale used by this shape. </return>
		/// </summary>
		public float GetShapeScale()
			=> E_UCapsuleComponent_GetShapeScale(this);
		
		
		/// <summary>
		/// <para>Returns the capsule half-height, ignoring component scaling. This includes the hemisphere end cap. </para>
		/// <return>The capsule radius, ignoring component scaling. </return>
		/// </summary>
		public float GetUnscaledCapsuleHalfHeight()
			=> E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(this);
		
		
		/// <summary>
		/// <para>Returns the capsule half-height minus radius (to exclude the hemisphere), ignoring component scaling. This excludes the hemisphere end cap. </para>
		/// <para>From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins. </para>
		/// <return>The capsule half-height minus radius, ignoring component scaling. </return>
		/// </summary>
		public float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()
			=> E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(this);
		
		
		/// <summary>
		/// <para>Returns the capsule radius, ignoring component scaling. </para>
		/// <return>the capsule radius, ignoring component scaling. </return>
		/// </summary>
		public float GetUnscaledCapsuleRadius()
			=> E_UCapsuleComponent_GetUnscaledCapsuleRadius(this);
		
		
		/// <summary>
		/// <para>Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap. </para>
		/// <param name="OutRadius">Radius of the capsule, scaled by the component scale. </param>
		/// <param name="OutHalfHeight">Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap. </param>
		/// <return>The capsule radius and half-height scaled by the component scale. </return>
		/// </summary>
		public void GetUnscaledCapsuleSize(float OutRadius, float OutHalfHeight)
			=> E_UCapsuleComponent_GetUnscaledCapsuleSize(this, OutRadius, OutHalfHeight);
		
		
		/// <summary>
		/// <para>Returns the capsule radius and half-height, ignoring component scaling. Half-height excludes the hemisphere end cap. </para>
		/// <param name="OutRadius">Radius of the capsule, ignoring component scaling. </param>
		/// <param name="OutHalfHeightWithoutHemisphere">Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap. </param>
		/// <return>The capsule radius and half-height (excluding hemisphere end cap), ignoring component scaling. </return>
		/// </summary>
		public void GetUnscaledCapsuleSize_WithoutHemisphere(float OutRadius, float OutHalfHeightWithoutHemisphere)
			=> E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(this, OutRadius, OutHalfHeightWithoutHemisphere);
		
		public void InitCapsuleSize(float InRadius, float InHalfHeight)
			=> E_UCapsuleComponent_InitCapsuleSize(this, InRadius, InHalfHeight);
		
		
		/// <summary>
		/// <para>Set the capsule half-height. This is the unscaled half-height, before component scale is applied. </para>
		/// <para>If this capsule collides, updates touching array for owner actor. </para>
		/// <param name="HalfHeight">: half-height, from capsule center to end of top or bottom hemisphere. </param>
		/// <para>@param	bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor. </para>
		/// </summary>
		public void SetCapsuleHalfHeight(float HalfHeight, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleHalfHeight(this, HalfHeight, bUpdateOverlaps);
		
		
		/// <summary>
		/// <para>Set the capsule radius. This is the unscaled radius, before component scale is applied. </para>
		/// <para>If this capsule collides, updates touching array for owner actor. </para>
		/// <param name="Radius">: radius of end-cap hemispheres and center cylinder. </param>
		/// <para>@param	bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor. </para>
		/// </summary>
		public void SetCapsuleRadius(float Radius, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleRadius(this, Radius, bUpdateOverlaps);
		
		
		/// <summary>
		/// <para>Change the capsule size. This is the unscaled size, before component scale is applied. </para>
		/// <param name="InRadius">: radius of end-cap hemispheres and center cylinder. </param>
		/// <param name="InHalfHeight">: half-height, from capsule center to end of top or bottom hemisphere. </param>
		/// <para>@param	bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor. </para>
		/// </summary>
		public void SetCapsuleSize(float InRadius, float InHalfHeight, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleSize(this, InRadius, InHalfHeight, bUpdateOverlaps);
		
		#endregion
		
		public static implicit operator IntPtr(UCapsuleComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UCapsuleComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UCapsuleComponent ?? new UCapsuleComponent(Adress);
		}
}
}
