using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FLevelSimplificationDetails
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FLevelSimplificationDetails()
		{
			NativePointer = E_CreateStruct_FLevelSimplificationDetails();
			IsRef = false;
		}

		internal FLevelSimplificationDetails(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FLevelSimplificationDetails();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bCreatePackagePerAsset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bCreatePackagePerAsset_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FLevelSimplificationDetails_DetailsPercentage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_DetailsPercentage_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bOverrideLandscapeExportLOD_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bOverrideLandscapeExportLOD_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FLevelSimplificationDetails_LandscapeExportLOD_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_LandscapeExportLOD_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bBakeFoliageToLandscape_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bBakeFoliageToLandscape_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bBakeGrassToLandscape_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bBakeGrassToLandscape_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bGenerateMeshNormalMap_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bGenerateMeshNormalMap_DEPRECATED_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bGenerateMeshMetallicMap_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bGenerateMeshMetallicMap_DEPRECATED_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bGenerateMeshRoughnessMap_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bGenerateMeshRoughnessMap_DEPRECATED_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bGenerateMeshSpecularMap_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bGenerateMeshSpecularMap_DEPRECATED_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bGenerateLandscapeNormalMap_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bGenerateLandscapeNormalMap_DEPRECATED_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bGenerateLandscapeMetallicMap_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bGenerateLandscapeMetallicMap_DEPRECATED_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bGenerateLandscapeRoughnessMap_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bGenerateLandscapeRoughnessMap_DEPRECATED_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FLevelSimplificationDetails_bGenerateLandscapeSpecularMap_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLevelSimplificationDetails_bGenerateLandscapeSpecularMap_DEPRECATED_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FLevelSimplificationDetails_PostLoadDeprecated(FLevelSimplificationDetails Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether to create separate packages for each generated asset. All in map package otherwise
		/// </summary>
		public bool bCreatePackagePerAsset
		{
			get => E_PROP_FLevelSimplificationDetails_bCreatePackagePerAsset_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bCreatePackagePerAsset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Percentage of details for static mesh proxy
		/// </summary>
		public float StaticMeshDetailsPercentage
		{
			get => E_PROP_FLevelSimplificationDetails_DetailsPercentage_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_DetailsPercentage_SET(NativePointer, value);
		}

		public bool bOverrideLandscapeExportLOD
		{
			get => E_PROP_FLevelSimplificationDetails_bOverrideLandscapeExportLOD_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bOverrideLandscapeExportLOD_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Landscape LOD to use for static mesh generation, when not specified 'Max LODLevel' from landscape actor will be used
		/// </summary>
		public int LandscapeExportLOD
		{
			get => E_PROP_FLevelSimplificationDetails_LandscapeExportLOD_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_LandscapeExportLOD_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to bake foliage into landscape static mesh texture
		/// </summary>
		public bool bBakeFoliageToLandscape
		{
			get => E_PROP_FLevelSimplificationDetails_bBakeFoliageToLandscape_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bBakeFoliageToLandscape_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to bake grass into landscape static mesh texture
		/// </summary>
		public bool bBakeGrassToLandscape
		{
			get => E_PROP_FLevelSimplificationDetails_bBakeGrassToLandscape_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bBakeGrassToLandscape_SET(NativePointer, value);
		}

		public bool bGenerateMeshNormalMap_DEPRECATED
		{
			get => E_PROP_FLevelSimplificationDetails_bGenerateMeshNormalMap_DEPRECATED_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bGenerateMeshNormalMap_DEPRECATED_SET(NativePointer, value);
		}

		public bool bGenerateMeshMetallicMap_DEPRECATED
		{
			get => E_PROP_FLevelSimplificationDetails_bGenerateMeshMetallicMap_DEPRECATED_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bGenerateMeshMetallicMap_DEPRECATED_SET(NativePointer, value);
		}

		public bool bGenerateMeshRoughnessMap_DEPRECATED
		{
			get => E_PROP_FLevelSimplificationDetails_bGenerateMeshRoughnessMap_DEPRECATED_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bGenerateMeshRoughnessMap_DEPRECATED_SET(NativePointer, value);
		}

		public bool bGenerateMeshSpecularMap_DEPRECATED
		{
			get => E_PROP_FLevelSimplificationDetails_bGenerateMeshSpecularMap_DEPRECATED_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bGenerateMeshSpecularMap_DEPRECATED_SET(NativePointer, value);
		}

		public bool bGenerateLandscapeNormalMap_DEPRECATED
		{
			get => E_PROP_FLevelSimplificationDetails_bGenerateLandscapeNormalMap_DEPRECATED_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bGenerateLandscapeNormalMap_DEPRECATED_SET(NativePointer, value);
		}

		public bool bGenerateLandscapeMetallicMap_DEPRECATED
		{
			get => E_PROP_FLevelSimplificationDetails_bGenerateLandscapeMetallicMap_DEPRECATED_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bGenerateLandscapeMetallicMap_DEPRECATED_SET(NativePointer, value);
		}

		public bool bGenerateLandscapeRoughnessMap_DEPRECATED
		{
			get => E_PROP_FLevelSimplificationDetails_bGenerateLandscapeRoughnessMap_DEPRECATED_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bGenerateLandscapeRoughnessMap_DEPRECATED_SET(NativePointer, value);
		}

		public bool bGenerateLandscapeSpecularMap_DEPRECATED
		{
			get => E_PROP_FLevelSimplificationDetails_bGenerateLandscapeSpecularMap_DEPRECATED_GET(NativePointer);
			set => E_PROP_FLevelSimplificationDetails_bGenerateLandscapeSpecularMap_DEPRECATED_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Handles deprecated properties
		/// </summary>
		public void PostLoadDeprecated()
			=> E_FLevelSimplificationDetails_PostLoadDeprecated(this);
		
		#endregion
		
		public static implicit operator IntPtr(FLevelSimplificationDetails Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLevelSimplificationDetails(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelSimplificationDetails(Adress, false);
		}}}
