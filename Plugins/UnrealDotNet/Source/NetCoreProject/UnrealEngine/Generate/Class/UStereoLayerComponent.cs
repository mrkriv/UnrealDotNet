using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A geometry layer within the stereo rendered viewport.
	/// </summary>
	public partial class UStereoLayerComponent : USceneComponent
	{
		public UStereoLayerComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector2D E_PROP_UStereoLayerComponent_QuadSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UStereoLayerComponent_QuadSize_SET(IntPtr Ptr, FVector2D Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FBox2D E_PROP_UStereoLayerComponent_UVRect_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UStereoLayerComponent_UVRect_SET(IntPtr Ptr, FBox2D Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UStereoLayerComponent_CylinderRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UStereoLayerComponent_CylinderRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_UStereoLayerComponent_CylinderOverlayArc_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UStereoLayerComponent_CylinderOverlayArc_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_UStereoLayerComponent_CylinderHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UStereoLayerComponent_CylinderHeight_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_UStereoLayerComponent_Priority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UStereoLayerComponent_Priority_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStereoLayerComponent_SetQuadSize(IntPtr Self, IntPtr InQuadSize);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UStereoLayerComponent_GetQuadSize(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStereoLayerComponent_SetUVRect(IntPtr Self, IntPtr InUVRect);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UStereoLayerComponent_GetUVRect(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStereoLayerComponent_SetPriority(IntPtr Self, int InPriority);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_UStereoLayerComponent_GetPriority(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Size of the rendered stereo layer quad
		/// </summary>
		protected FVector2D QuadSize
		{
			get => E_PROP_UStereoLayerComponent_QuadSize_GET(NativePointer);
			set => E_PROP_UStereoLayerComponent_QuadSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// UV coordinates mapped to the quad face
		/// </summary>
		protected FBox2D UVRect
		{
			get => E_PROP_UStereoLayerComponent_UVRect_GET(NativePointer);
			set => E_PROP_UStereoLayerComponent_UVRect_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Radial size of the rendered stereo layer cylinder
		/// </summary>
		protected float CylinderRadius
		{
			get => E_PROP_UStereoLayerComponent_CylinderRadius_GET(NativePointer);
			set => E_PROP_UStereoLayerComponent_CylinderRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Arc angle for the stereo layer cylinder
		/// </summary>
		protected float CylinderOverlayArc
		{
			get => E_PROP_UStereoLayerComponent_CylinderOverlayArc_GET(NativePointer);
			set => E_PROP_UStereoLayerComponent_CylinderOverlayArc_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Height of the stereo layer cylinder
		/// </summary>
		protected int CylinderHeight
		{
			get => E_PROP_UStereoLayerComponent_CylinderHeight_GET(NativePointer);
			set => E_PROP_UStereoLayerComponent_CylinderHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Render priority among all stereo layers, higher priority render on top of lower priority
		/// </summary>
		protected int Priority
		{
			get => E_PROP_UStereoLayerComponent_Priority_GET(NativePointer);
			set => E_PROP_UStereoLayerComponent_Priority_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Change the quad size. This is the unscaled height and width, before component scale is applied.
		/// @param	InQuadSize: new quad size.
		/// </summary>
		public void SetQuadSize(FVector2D InQuadSize)
			=> E_UStereoLayerComponent_SetQuadSize(NativePointer, InQuadSize);
		
		public FVector2D GetQuadSize()
			=> E_UStereoLayerComponent_GetQuadSize(NativePointer);
		
		
		/// <summary>
		/// Change the UV coordinates mapped to the quad face
		/// @param	InUVRect: Min and Max UV coordinates
		/// </summary>
		public void SetUVRect(FBox2D InUVRect)
			=> E_UStereoLayerComponent_SetUVRect(NativePointer, InUVRect);
		
		public FBox2D GetUVRect()
			=> E_UStereoLayerComponent_GetUVRect(NativePointer);
		
		
		/// <summary>
		/// Change the layer's render priority, higher priorities render on top of lower priorities
		/// @param	InPriority: Priority value
		/// </summary>
		public void SetPriority(int InPriority)
			=> E_UStereoLayerComponent_SetPriority(NativePointer, InPriority);
		
		public int GetPriority()
			=> E_UStereoLayerComponent_GetPriority(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(UStereoLayerComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UStereoLayerComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UStereoLayerComponent(Adress);
		}}}
