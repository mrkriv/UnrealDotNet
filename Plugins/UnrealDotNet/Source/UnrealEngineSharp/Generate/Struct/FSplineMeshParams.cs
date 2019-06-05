// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SplineMeshComponent.h:33

namespace UnrealEngine
{
	public partial class FSplineMeshParams : NativeStructWrapper
	{
		public FSplineMeshParams(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FSplineMeshParams() :
			base(E_CreateStruct_FSplineMeshParams(), false)
		{
		}

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
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplineMeshParams();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Ending offset of the mesh from the spline, in component space.
		/// </summary>
		public FVector2D EndOffset
		{
			get => E_PROP_FSplineMeshParams_EndOffset_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndOffset_SET(NativePointer, value);
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
		/// Roll around spline applied at end.
		/// </summary>
		public float EndRoll
		{
			get => E_PROP_FSplineMeshParams_EndRoll_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndRoll_SET(NativePointer, value);
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
		/// End tangent of spline, in component space.
		/// </summary>
		public FVector EndTangent
		{
			get => E_PROP_FSplineMeshParams_EndTangent_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_EndTangent_SET(NativePointer, value);
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
		/// Start location of spline, in component space.
		/// </summary>
		public FVector StartPos
		{
			get => E_PROP_FSplineMeshParams_StartPos_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartPos_SET(NativePointer, value);
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
		/// X and Y scale applied to mesh at start of spline.
		/// </summary>
		public FVector2D StartScale
		{
			get => E_PROP_FSplineMeshParams_StartScale_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Start tangent of spline, in component space.
		/// </summary>
		public FVector StartTangent
		{
			get => E_PROP_FSplineMeshParams_StartTangent_GET(NativePointer);
			set => E_PROP_FSplineMeshParams_StartTangent_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSplineMeshParams self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSplineMeshParams(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FSplineMeshParams(adress, false);
		}}}
