// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2450

namespace UnrealEngine
{
	public partial class FMeshBuildSettings : NativeStructWrapper
	{
		public FMeshBuildSettings(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default settings.
		/// </summary>
		public FMeshBuildSettings() :
			base(E_CreateStruct_FMeshBuildSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bRecomputeNormals_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bRecomputeNormals_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bRecomputeTangents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bRecomputeTangents_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bRemoveDegenerates_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bRemoveDegenerates_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMeshBuildSettings_BuildScale_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_BuildScale_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FMeshBuildSettings_BuildScale3D_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_BuildScale3D_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FMeshBuildSettings_bUseMikkTSpace_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bUseMikkTSpace_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMeshBuildSettings_DistanceFieldResolutionScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_DistanceFieldResolutionScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FMeshBuildSettings_DstLightmapIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_DstLightmapIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FMeshBuildSettings_MinLightmapResolution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_MinLightmapResolution_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FMeshBuildSettings_SrcLightmapIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_SrcLightmapIndex_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMeshBuildSettings();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Required for PNT tessellation but can be slow. Recommend disabling for larger meshes.
		/// </summary>
		public byte bBuildAdjacencyBuffer
		{
			get => E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Required to optimize mesh in mirrored transform. Double index buffer size.
		/// </summary>
		public byte bBuildReversedIndexBuffer
		{
			get => E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to generate the distance field treating every triangle hit as a front face.
		/// <para>When enabled prevents the distance field from being discarded due to the mesh being open, but also lowers Distance Field AO quality. </para>
		/// </summary>
		public byte TwoSidedDistanceFieldGeneration
		{
			get => E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_SET(NativePointer, value);
		}

		public byte bGenerateLightmapUVs
		{
			get => E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, normals in the raw mesh are ignored and recomputed.
		/// </summary>
		public byte bRecomputeNormals
		{
			get => E_PROP_FMeshBuildSettings_bRecomputeNormals_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bRecomputeNormals_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, tangents in the raw mesh are ignored and recomputed.
		/// </summary>
		public byte bRecomputeTangents
		{
			get => E_PROP_FMeshBuildSettings_bRecomputeTangents_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bRecomputeTangents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, degenerate triangles will be removed.
		/// </summary>
		public byte bRemoveDegenerates
		{
			get => E_PROP_FMeshBuildSettings_bRemoveDegenerates_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bRemoveDegenerates_SET(NativePointer, value);
		}

		public float BuildScale_DEPRECATED
		{
			get => E_PROP_FMeshBuildSettings_BuildScale_DEPRECATED_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_BuildScale_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The local scale applied when building the mesh
		/// </summary>
		public FVector BuildScale
		{
			get => E_PROP_FMeshBuildSettings_BuildScale3D_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_BuildScale3D_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, UVs will be stored at full floating point precision.
		/// </summary>
		public byte bUseFullPrecisionUVs
		{
			get => E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, Tangents will be stored at 16 bit vs 8 bit precision.
		/// </summary>
		public byte bUseHighPrecisionTangentBasis
		{
			get => E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, degenerate triangles will be removed.
		/// </summary>
		public byte bUseMikkTSpace
		{
			get => E_PROP_FMeshBuildSettings_bUseMikkTSpace_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bUseMikkTSpace_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scale to apply to the mesh when allocating the distance field volume texture.
		/// <para>The default scale is 1, which is assuming that the mesh will be placed unscaled in the world. </para>
		/// </summary>
		public float DistanceFieldResolutionScale
		{
			get => E_PROP_FMeshBuildSettings_DistanceFieldResolutionScale_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_DistanceFieldResolutionScale_SET(NativePointer, value);
		}

		public int DestinationLightmapIndex
		{
			get => E_PROP_FMeshBuildSettings_DstLightmapIndex_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_DstLightmapIndex_SET(NativePointer, value);
		}

		public int MinLightmapResolution
		{
			get => E_PROP_FMeshBuildSettings_MinLightmapResolution_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_MinLightmapResolution_SET(NativePointer, value);
		}

		public int SourceLightmapIndex
		{
			get => E_PROP_FMeshBuildSettings_SrcLightmapIndex_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_SrcLightmapIndex_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FMeshBuildSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FMeshBuildSettings(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FMeshBuildSettings(adress, false);
		}}}
