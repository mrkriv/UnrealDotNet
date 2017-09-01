using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// StaticMeshComponent is used to create an instance of a UStaticMesh.
	/// A static mesh is a piece of geometry that consists of a static set of polygons.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/StaticMeshes
	/// @see UStaticMesh
	/// </summary>
	public partial class UStaticMeshComponent : UMeshComponent
	{
		public UStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UStaticMeshComponent_GetTextureStreamingTransformScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UStaticMeshComponent_UsesTextureLightmaps(IntPtr Self, int InWidth, int InHeight);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(IntPtr Self, int InWidth, int InHeight, int OutLightMapMemoryUsage, int OutShadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(IntPtr Self, int TextureLightMapMemoryUsage, int TextureShadowMapMemoryUsage, int VertexLightMapMemoryUsage, int VertexShadowMapMemoryUsage, int StaticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(IntPtr Self, bool bRebuildingStaticMesh);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(IntPtr Self, IntPtr SourceComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(IntPtr Self, int LODToRemoveColorsFrom);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UStaticMeshComponent_SetStaticLightingMapping(IntPtr Self, bool bTextureMapping, int ResolutionToUse);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Get the scale comming form the component, when computing StreamingTexture data. Used to support instanced meshes.
		/// </summary>
		public float GetTextureStreamingTransformScale()
			=> E_UStaticMeshComponent_GetTextureStreamingTransformScale(NativePointer);
		
		
		/// <summary>
		/// Returns true if the component uses texture lightmaps
		/// @param	InWidth		[in]	The width of the light/shadow map
		/// @param	InHeight	[in]	The width of the light/shadow map
		/// @return	bool				true if texture lightmaps are used, false if not
		/// </summary>
		public bool UsesTextureLightmaps(int InWidth, int InHeight)
			=> E_UStaticMeshComponent_UsesTextureLightmaps(NativePointer, InWidth, InHeight);
		
		
		/// <summary>
		/// Get the memory used for texture-based light and shadow maps of the given width and height
		/// @param	InWidth						The desired width of the light/shadow map
		/// @param	InHeight					The desired height of the light/shadow map
		/// @param	OutLightMapMemoryUsage		The resulting lightmap memory used
		/// @param	OutShadowMapMemoryUsage		The resulting shadowmap memory used
		/// </summary>
		public void GetTextureLightAndShadowMapMemoryUsage(int InWidth, int InHeight, int OutLightMapMemoryUsage, int OutShadowMapMemoryUsage)
			=> E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(NativePointer, InWidth, InHeight, OutLightMapMemoryUsage, OutShadowMapMemoryUsage);
		
		
		/// <summary>
		/// Returns the light and shadow map memory for this primite in its out variables.
		/// Shadow map memory usage is per light whereof lightmap data is independent of number of lights, assuming at least one.
		/// @param [out]	TextureLightMapMemoryUsage		Estimated memory usage in bytes for light map texel data
		/// @param [out]	TextureShadowMapMemoryUsage		Estimated memory usage in bytes for shadow map texel data
		/// @param [out]	VertexLightMapMemoryUsage		Estimated memory usage in bytes for light map vertex data
		/// @param [out]	VertexShadowMapMemoryUsage		Estimated memory usage in bytes for shadow map vertex data
		/// @param [out]	StaticLightingResolution		The StaticLightingResolution used for Texture estimates
		/// @param [out]	bIsUsingTextureMapping			Set to true if the mesh is using texture mapping currently; false if vertex
		/// @param [out]	bHasLightmapTexCoords			Set to true if the mesh has the proper UV channels
		/// @return			bool							true if the mesh has static lighting; false if not
		/// </summary>
		public bool GetEstimatedLightAndShadowMapMemoryUsage(int TextureLightMapMemoryUsage, int TextureShadowMapMemoryUsage, int VertexLightMapMemoryUsage, int VertexShadowMapMemoryUsage, int StaticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords)
			=> E_UStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(NativePointer, TextureLightMapMemoryUsage, TextureShadowMapMemoryUsage, VertexLightMapMemoryUsage, VertexShadowMapMemoryUsage, StaticLightingResolution, bIsUsingTextureMapping, bHasLightmapTexCoords);
		
		
		/// <summary>
		/// Update the vertex override colors if necessary (i.e. vertices from source mesh have changed from override colors)
		/// @param bRebuildingStaticMesh	true if we are rebuilding the static mesh used by this component
		/// @returns true if any fixup was performed.
		/// </summary>
		public bool FixupOverrideColorsIfNecessary(bool bRebuildingStaticMesh = false)
			=> E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(NativePointer, bRebuildingStaticMesh);
		
		
		/// <summary>
		/// Copies instance vertex colors from the SourceComponent into this component
		/// @param SourceComponent The component to copy vertex colors from
		/// </summary>
		public void CopyInstanceVertexColorsIfCompatible(UStaticMeshComponent SourceComponent)
			=> E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(NativePointer, SourceComponent);
		
		
		/// <summary>
		/// Removes instance vertex colors from the specified LOD
		/// @param LODToRemoveColorsFrom Index of the LOD to remove instance colors from
		/// </summary>
		public void RemoveInstanceVertexColorsFromLOD(int LODToRemoveColorsFrom)
			=> E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(NativePointer, LODToRemoveColorsFrom);
		
		
		/// <summary>
		/// Switches the static mesh component to use either Texture or Vertex static lighting.
		/// @param	bTextureMapping		If true, set the component to use texture light mapping.
		/// If false, set it to use vertex light mapping.
		/// @param	ResolutionToUse		If != 0, set the resolution to the given value.
		/// @return	bool				true if successfully set; false if not
		/// If false, set it to use vertex light mapping.
		/// </summary>
		public bool SetStaticLightingMapping(bool bTextureMapping, int ResolutionToUse)
			=> E_UStaticMeshComponent_SetStaticLightingMapping(NativePointer, bTextureMapping, ResolutionToUse);
		
		#endregion
		
		public static implicit operator IntPtr(UStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UStaticMeshComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UStaticMeshComponent(Adress);
		}}}
