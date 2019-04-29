// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\CapsuleComponent.h:16

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
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCapsuleComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleHalfHeight(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleRadius(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetScaledCapsuleSize(IntPtr self, float outRadius, float outHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(IntPtr self, float outRadius, float outHalfHeightWithoutHemisphere);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetShapeScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetUnscaledCapsuleRadius(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetUnscaledCapsuleSize(IntPtr self, float outRadius, float outHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(IntPtr self, float outRadius, float outHalfHeightWithoutHemisphere);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_InitCapsuleSize(IntPtr self, float inRadius, float inHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCapsuleHalfHeight(IntPtr self, float halfHeight, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCapsuleRadius(IntPtr self, float radius, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCapsuleSize(IntPtr self, float inRadius, float inHalfHeight, bool bUpdateOverlaps);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns the capsule half-height scaled by the component scale. This includes both the cylinder and hemisphere cap.
		/// </summary>
		/// <return>The</return>
		public float GetScaledCapsuleHalfHeight()
			=> E_UCapsuleComponent_GetScaledCapsuleHalfHeight(this);
		
		
		/// <summary>
		/// Returns the capsule half-height minus radius (to exclude the hemisphere), scaled by the component scale.
		/// <para>From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins. </para>
		/// </summary>
		/// <return>The</return>
		public float GetScaledCapsuleHalfHeight_WithoutHemisphere()
			=> E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(this);
		
		
		/// <summary>
		/// Returns the capsule radius scaled by the component scale.
		/// </summary>
		/// <return>The</return>
		public float GetScaledCapsuleRadius()
			=> E_UCapsuleComponent_GetScaledCapsuleRadius(this);
		
		
		/// <summary>
		/// Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap.
		/// </summary>
		/// <param name="outRadius">Radius of the capsule, scaled by the component scale.</param>
		/// <param name="outHalfHeight">Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.</param>
		/// <return>The</return>
		public void GetScaledCapsuleSize(float outRadius, float outHalfHeight)
			=> E_UCapsuleComponent_GetScaledCapsuleSize(this, outRadius, outHalfHeight);
		
		
		/// <summary>
		/// Returns the capsule radius and half-height scaled by the component scale. Half-height excludes the hemisphere end cap.
		/// </summary>
		/// <param name="outRadius">Radius of the capsule, ignoring component scaling.</param>
		/// <param name="outHalfHeightWithoutHemisphere">Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.</param>
		/// <return>The</return>
		public void GetScaledCapsuleSize_WithoutHemisphere(float outRadius, float outHalfHeightWithoutHemisphere)
			=> E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(this, outRadius, outHalfHeightWithoutHemisphere);
		
		
		/// <summary>
		/// Get the scale used by this shape. This is a uniform scale that is the minimum of any non-uniform scaling.
		/// </summary>
		/// <return>the</return>
		public float GetShapeScale()
			=> E_UCapsuleComponent_GetShapeScale(this);
		
		
		/// <summary>
		/// Returns the capsule half-height, ignoring component scaling. This includes the hemisphere end cap.
		/// </summary>
		/// <return>The</return>
		public float GetUnscaledCapsuleHalfHeight()
			=> E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(this);
		
		
		/// <summary>
		/// Returns the capsule half-height minus radius (to exclude the hemisphere), ignoring component scaling. This excludes the hemisphere end cap.
		/// <para>From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins. </para>
		/// </summary>
		/// <return>The</return>
		public float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()
			=> E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(this);
		
		
		/// <summary>
		/// Returns the capsule radius, ignoring component scaling.
		/// </summary>
		/// <return>the</return>
		public float GetUnscaledCapsuleRadius()
			=> E_UCapsuleComponent_GetUnscaledCapsuleRadius(this);
		
		
		/// <summary>
		/// Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap.
		/// </summary>
		/// <param name="outRadius">Radius of the capsule, scaled by the component scale.</param>
		/// <param name="outHalfHeight">Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.</param>
		/// <return>The</return>
		public void GetUnscaledCapsuleSize(float outRadius, float outHalfHeight)
			=> E_UCapsuleComponent_GetUnscaledCapsuleSize(this, outRadius, outHalfHeight);
		
		
		/// <summary>
		/// Returns the capsule radius and half-height, ignoring component scaling. Half-height excludes the hemisphere end cap.
		/// </summary>
		/// <param name="outRadius">Radius of the capsule, ignoring component scaling.</param>
		/// <param name="outHalfHeightWithoutHemisphere">Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.</param>
		/// <return>The</return>
		public void GetUnscaledCapsuleSize_WithoutHemisphere(float outRadius, float outHalfHeightWithoutHemisphere)
			=> E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(this, outRadius, outHalfHeightWithoutHemisphere);
		
		public void InitCapsuleSize(float inRadius, float inHalfHeight)
			=> E_UCapsuleComponent_InitCapsuleSize(this, inRadius, inHalfHeight);
		
		
		/// <summary>
		/// Set the capsule half-height. This is the unscaled half-height, before component scale is applied.
		/// <para>If this capsule collides, updates touching array for owner actor. </para>
		/// </summary>
		/// <param name="halfHeight">half-height, from capsule center to end of top or bottom hemisphere.</param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor.</param>
		public void SetCapsuleHalfHeight(float halfHeight, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleHalfHeight(this, halfHeight, bUpdateOverlaps);
		
		
		/// <summary>
		/// Set the capsule radius. This is the unscaled radius, before component scale is applied.
		/// <para>If this capsule collides, updates touching array for owner actor. </para>
		/// </summary>
		/// <param name="radius">radius of end-cap hemispheres and center cylinder.</param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor.</param>
		public void SetCapsuleRadius(float radius, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleRadius(this, radius, bUpdateOverlaps);
		
		
		/// <summary>
		/// Change the capsule size. This is the unscaled size, before component scale is applied.
		/// </summary>
		/// <param name="inRadius">radius of end-cap hemispheres and center cylinder.</param>
		/// <param name="inHalfHeight">half-height, from capsule center to end of top or bottom hemisphere.</param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor.</param>
		public void SetCapsuleSize(float inRadius, float inHalfHeight, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleSize(this, inRadius, inHalfHeight, bUpdateOverlaps);
		
		#endregion
		
		public static implicit operator IntPtr(UCapsuleComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCapsuleComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCapsuleComponent>(PtrDesc);
		}}}
