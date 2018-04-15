using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SplineMeshComponent.h:33

namespace UnrealEngine
{
	public  partial class FSplineMeshParams : NativeStructWrapper
	{
		internal FSplineMeshParams(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSplineMeshParams() :
			base(E_CreateStruct_FSplineMeshParams(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplineMeshParams();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplineMeshParams_EndOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_EndOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplineMeshParams_EndPos_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_EndPos_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FSplineMeshParams_EndRoll_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_EndRoll_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplineMeshParams_EndScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_EndScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplineMeshParams_EndTangent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_EndTangent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplineMeshParams_StartOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_StartOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplineMeshParams_StartPos_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_StartPos_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FSplineMeshParams_StartRoll_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_StartRoll_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplineMeshParams_StartScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_StartScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSplineMeshParams_StartTangent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSplineMeshParams_StartTangent_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Ending offset of the mesh from the spline, in component space. </para>
		/// </summary>
		public FVector2D EndOffset
		{
			get => E_PROP_FSplineMeshParams_EndOffset_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>End location of spline, in component space. </para>
		/// </summary>
		public FVector EndPos
		{
			get => E_PROP_FSplineMeshParams_EndPos_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndPos_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Roll around spline applied at end. </para>
		/// </summary>
		public float EndRoll
		{
			get => E_PROP_FSplineMeshParams_EndRoll_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndRoll_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>X and Y scale applied to mesh at end of spline. </para>
		/// </summary>
		public FVector2D EndScale
		{
			get => E_PROP_FSplineMeshParams_EndScale_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>End tangent of spline, in component space. </para>
		/// </summary>
		public FVector EndTangent
		{
			get => E_PROP_FSplineMeshParams_EndTangent_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndTangent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Starting offset of the mesh from the spline, in component space. </para>
		/// </summary>
		public FVector2D StartOffset
		{
			get => E_PROP_FSplineMeshParams_StartOffset_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Start location of spline, in component space. </para>
		/// </summary>
		public FVector StartPos
		{
			get => E_PROP_FSplineMeshParams_StartPos_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartPos_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Roll around spline applied at start </para>
		/// </summary>
		public float StartRoll
		{
			get => E_PROP_FSplineMeshParams_StartRoll_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartRoll_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>X and Y scale applied to mesh at start of spline. </para>
		/// </summary>
		public FVector2D StartScale
		{
			get => E_PROP_FSplineMeshParams_StartScale_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Start tangent of spline, in component space. </para>
		/// </summary>
		public FVector StartTangent
		{
			get => E_PROP_FSplineMeshParams_StartTangent_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartTangent_SET(NativePointer, value);
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
