using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A sphere generally used for simple collision. Bounds are rendered as lines in the editor.
	/// </summary>
	public partial class USphereComponent : UShapeComponent
	{
		public USphereComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USphereComponent_SphereRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USphereComponent_SphereRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USphereComponent_SetSphereRadius(IntPtr Self, float InSphereRadius, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USphereComponent_GetScaledSphereRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USphereComponent_InitSphereRadius(IntPtr Self, float InSphereRadius);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The radius of the sphere
		/// </summary>
		protected float SphereRadius
		{
			get => E_PROP_USphereComponent_SphereRadius_GET(NativePointer);
			set => E_PROP_USphereComponent_SphereRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Change the sphere radius. This is the unscaled radius, before component scale is applied.
		/// @param	InSphereRadius: the new sphere radius
		/// @param	bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
		/// </summary>
		public void SetSphereRadius(float InSphereRadius, bool bUpdateOverlaps = true)
			=> E_USphereComponent_SetSphereRadius(NativePointer, InSphereRadius, bUpdateOverlaps);
		
		public float GetScaledSphereRadius()
			=> E_USphereComponent_GetScaledSphereRadius(NativePointer);
		
		public void InitSphereRadius(float InSphereRadius)
			=> E_USphereComponent_InitSphereRadius(NativePointer, InSphereRadius);
		
		#endregion
		
		public static implicit operator IntPtr(USphereComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USphereComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new USphereComponent(Adress);
		}}}
