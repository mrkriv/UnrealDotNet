using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2448

namespace UnrealEngine
{
	public  partial class FMeshBuildSettings : NativeStructWrapper
	{
		internal FMeshBuildSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default settings. </para>
		/// </summary>
		public FMeshBuildSettings() :
			base(E_CreateStruct_FMeshBuildSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMeshBuildSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bRecomputeNormals_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bRecomputeNormals_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bRecomputeTangents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bRecomputeTangents_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bRemoveDegenerates_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bRemoveDegenerates_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMeshBuildSettings_BuildScale_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_BuildScale_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FMeshBuildSettings_BuildScale3D_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_BuildScale3D_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FMeshBuildSettings_bUseMikkTSpace_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_bUseMikkTSpace_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMeshBuildSettings_DistanceFieldBias_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_DistanceFieldBias_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FMeshBuildSettings_DistanceFieldResolutionScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_DistanceFieldResolutionScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FMeshBuildSettings_DstLightmapIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_DstLightmapIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FMeshBuildSettings_MinLightmapResolution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_MinLightmapResolution_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FMeshBuildSettings_SrcLightmapIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FMeshBuildSettings_SrcLightmapIndex_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Required for PNT tessellation but can be slow. Recommend disabling for larger meshes. </para>
		/// </summary>
		public bool bBuildAdjacencyBuffer
		{
			get => E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Required to optimize mesh in mirrored transform. Double index buffer size. </para>
		/// </summary>
		public bool bBuildReversedIndexBuffer
		{
			get => E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to generate the distance field treating every triangle hit as a front face. </para>
		/// <para>When enabled prevents the distance field from being discarded due to the mesh being open, but also lowers Distance Field AO quality. </para>
		/// </summary>
		public bool TwoSidedDistanceFieldGeneration
		{
			get => E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_SET(NativePointer, value);
		}

		public bool bGenerateLightmapUVs
		{
			get => E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, normals in the raw mesh are ignored and recomputed. </para>
		/// </summary>
		public bool bRecomputeNormals
		{
			get => E_PROP_FMeshBuildSettings_bRecomputeNormals_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bRecomputeNormals_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, tangents in the raw mesh are ignored and recomputed. </para>
		/// </summary>
		public bool bRecomputeTangents
		{
			get => E_PROP_FMeshBuildSettings_bRecomputeTangents_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bRecomputeTangents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, degenerate triangles will be removed. </para>
		/// </summary>
		public bool bRemoveDegenerates
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
		/// <para>The local scale applied when building the mesh </para>
		/// </summary>
		public FVector BuildScale
		{
			get => E_PROP_FMeshBuildSettings_BuildScale3D_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_BuildScale3D_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, UVs will be stored at full floating point precision. </para>
		/// </summary>
		public bool bUseFullPrecisionUVs
		{
			get => E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, Tangents will be stored at 16 bit vs 8 bit precision. </para>
		/// </summary>
		public bool bUseHighPrecisionTangentBasis
		{
			get => E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, degenerate triangles will be removed. </para>
		/// </summary>
		public bool bUseMikkTSpace
		{
			get => E_PROP_FMeshBuildSettings_bUseMikkTSpace_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_bUseMikkTSpace_SET(NativePointer, value);
		}

		public float DistanceFieldBias_DEPRECATED
		{
			get => E_PROP_FMeshBuildSettings_DistanceFieldBias_DEPRECATED_GET(NativePointer);
			set => E_PROP_FMeshBuildSettings_DistanceFieldBias_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Scale to apply to the mesh when allocating the distance field volume texture. </para>
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
		
		public static implicit operator IntPtr(FMeshBuildSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FMeshBuildSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FMeshBuildSettings(Adress, false);
		}}}
