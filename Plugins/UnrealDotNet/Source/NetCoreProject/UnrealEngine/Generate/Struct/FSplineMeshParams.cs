using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Structure that holds info about spline, passed to renderer to deform UStaticMesh.
	/// Also used by Lightmass, so be sure to update Lightmass::FSplineMeshParams and the static lighting code if this changes!
	/// </summary>
	public partial class FSplineMeshParams
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FSplineMeshParams()
		{
			NativePointer = E_CreateStruct_FSplineMeshParams();
			IsRef = false;
		}

		internal FSplineMeshParams(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FSplineMeshParams();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FSplineMeshParams_StartPos_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_StartPos_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FSplineMeshParams_StartTangent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_StartTangent_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector2D E_PROP_FSplineMeshParams_StartScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_StartScale_SET(IntPtr Ptr, FVector2D Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FSplineMeshParams_StartRoll_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_StartRoll_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector2D E_PROP_FSplineMeshParams_StartOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_StartOffset_SET(IntPtr Ptr, FVector2D Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FSplineMeshParams_EndPos_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_EndPos_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FSplineMeshParams_EndTangent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_EndTangent_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector2D E_PROP_FSplineMeshParams_EndScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_EndScale_SET(IntPtr Ptr, FVector2D Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FSplineMeshParams_EndRoll_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_EndRoll_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector2D E_PROP_FSplineMeshParams_EndOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FSplineMeshParams_EndOffset_SET(IntPtr Ptr, FVector2D Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Start location of spline, in component space.
		/// </summary>
		public FVector StartPos
		{
			get => E_PROP_FSplineMeshParams_StartPos_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartPos_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Start tangent of spline, in component space.
		/// </summary>
		public FVector StartTangent
		{
			get => E_PROP_FSplineMeshParams_StartTangent_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartTangent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// X and Y scale applied to mesh at start of spline.
		/// </summary>
		public FVector2D StartScale
		{
			get => E_PROP_FSplineMeshParams_StartScale_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Roll around spline applied at start
		/// </summary>
		public float StartRoll
		{
			get => E_PROP_FSplineMeshParams_StartRoll_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartRoll_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Starting offset of the mesh from the spline, in component space.
		/// </summary>
		public FVector2D StartOffset
		{
			get => E_PROP_FSplineMeshParams_StartOffset_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// End location of spline, in component space.
		/// </summary>
		public FVector EndPos
		{
			get => E_PROP_FSplineMeshParams_EndPos_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndPos_SET(NativePointer, value);
		}

		
		/// <summary>
		/// End tangent of spline, in component space.
		/// </summary>
		public FVector EndTangent
		{
			get => E_PROP_FSplineMeshParams_EndTangent_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndTangent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// X and Y scale applied to mesh at end of spline.
		/// </summary>
		public FVector2D EndScale
		{
			get => E_PROP_FSplineMeshParams_EndScale_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Roll around spline applied at end.
		/// </summary>
		public float EndRoll
		{
			get => E_PROP_FSplineMeshParams_EndRoll_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndRoll_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Ending offset of the mesh from the spline, in component space.
		/// </summary>
		public FVector2D EndOffset
		{
			get => E_PROP_FSplineMeshParams_EndOffset_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndOffset_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSplineMeshParams Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSplineMeshParams(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSplineMeshParams(Adress, false);
		}}}
