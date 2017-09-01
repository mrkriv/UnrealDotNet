using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A box generally used for simple collision. Bounds are rendered as lines in the editor.
	/// </summary>
	public partial class UBoxComponent : UShapeComponent
	{
		public UBoxComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_UBoxComponent_BoxExtent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UBoxComponent_BoxExtent_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UBoxComponent_SetBoxExtent(IntPtr Self, IntPtr InBoxExtent, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UBoxComponent_GetScaledBoxExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UBoxComponent_InitBoxExtent(IntPtr Self, IntPtr InBoxExtent);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The extents (radii dimensions) of the box
		/// </summary>
		protected FVector BoxExtent
		{
			get => E_PROP_UBoxComponent_BoxExtent_GET(NativePointer);
			set => E_PROP_UBoxComponent_BoxExtent_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Change the box extent size. This is the unscaled size, before component scale is applied.
		/// @param	InBoxExtent: new extent (radius) for the box.
		/// @param	bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
		/// </summary>
		public void SetBoxExtent(FVector InBoxExtent, bool bUpdateOverlaps = true)
			=> E_UBoxComponent_SetBoxExtent(NativePointer, InBoxExtent, bUpdateOverlaps);
		
		public FVector GetScaledBoxExtent()
			=> E_UBoxComponent_GetScaledBoxExtent(NativePointer);
		
		public void InitBoxExtent(FVector InBoxExtent)
			=> E_UBoxComponent_InitBoxExtent(NativePointer, InBoxExtent);
		
		#endregion
		
		public static implicit operator IntPtr(UBoxComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UBoxComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UBoxComponent(Adress);
		}}}
