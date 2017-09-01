using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A capsule generally used for simple collision. Bounds are rendered as lines in the editor.
	/// </summary>
	public partial class UCapsuleComponent : UShapeComponent
	{
		public UCapsuleComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UCapsuleComponent_CapsuleHalfHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UCapsuleComponent_CapsuleHalfHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UCapsuleComponent_CapsuleRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UCapsuleComponent_CapsuleRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UCapsuleComponent_CapsuleHeight_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UCapsuleComponent_CapsuleHeight_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UCapsuleComponent_SetCapsuleSize(IntPtr Self, float InRadius, float InHalfHeight, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UCapsuleComponent_SetCapsuleRadius(IntPtr Self, float Radius, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UCapsuleComponent_InitCapsuleSize(IntPtr Self, float InRadius, float InHalfHeight);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Half-height, from center of capsule to the end of top or bottom hemisphere.
		/// This cannot be less than CapsuleRadius.
		/// </summary>
		protected float CapsuleHalfHeight
		{
			get => E_PROP_UCapsuleComponent_CapsuleHalfHeight_GET(NativePointer);
			set => E_PROP_UCapsuleComponent_CapsuleHalfHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Radius of cap hemispheres and center cylinder.
		/// This cannot be more than CapsuleHalfHeight.
		/// </summary>
		protected float CapsuleRadius
		{
			get => E_PROP_UCapsuleComponent_CapsuleRadius_GET(NativePointer);
			set => E_PROP_UCapsuleComponent_CapsuleRadius_SET(NativePointer, value);
		}

		protected float CapsuleHeight_DEPRECATED
		{
			get => E_PROP_UCapsuleComponent_CapsuleHeight_DEPRECATED_GET(NativePointer);
			set => E_PROP_UCapsuleComponent_CapsuleHeight_DEPRECATED_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Change the capsule size. This is the unscaled size, before component scale is applied.
		/// @param	InRadius : radius of end-cap hemispheres and center cylinder.
		/// @param	InHalfHeight : half-height, from capsule center to end of top or bottom hemisphere.
		/// @param	bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
		/// </summary>
		public void SetCapsuleSize(float InRadius, float InHalfHeight, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleSize(NativePointer, InRadius, InHalfHeight, bUpdateOverlaps);
		
		
		/// <summary>
		/// Set the capsule radius. This is the unscaled radius, before component scale is applied.
		/// If this capsule collides, updates touching array for owner actor.
		/// @param	Radius : radius of end-cap hemispheres and center cylinder.
		/// @param	bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
		/// </summary>
		public void SetCapsuleRadius(float Radius, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleRadius(NativePointer, Radius, bUpdateOverlaps);
		
		
		/// <summary>
		/// Returns the capsule radius scaled by the component scale.
		/// @return The capsule radius scaled by the component scale.
		/// </summary>
		public float GetScaledCapsuleRadius()
			=> E_UCapsuleComponent_GetScaledCapsuleRadius(NativePointer);
		
		public void InitCapsuleSize(float InRadius, float InHalfHeight)
			=> E_UCapsuleComponent_InitCapsuleSize(NativePointer, InRadius, InHalfHeight);
		
		#endregion
		
		public static implicit operator IntPtr(UCapsuleComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UCapsuleComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UCapsuleComponent(Adress);
		}}}
