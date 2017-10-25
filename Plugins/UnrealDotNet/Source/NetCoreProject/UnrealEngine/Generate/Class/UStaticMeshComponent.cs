using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:153

namespace UnrealEngine
{
	public  partial class UStaticMeshComponent : UMeshComponent
	{
		public UStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UStaticMeshComponent(UObject Parent = null, string Name = "StaticMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UStaticMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UStaticMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_AddSpeedTreeWind(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_CachePaintedDataIfNecessary(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(IntPtr Self, IntPtr SourceComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(IntPtr Self, bool bRebuildingStaticMesh);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UStaticMeshComponent_GetBlueprintCreatedComponentIndex(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(IntPtr Self, int TextureLightMapMemoryUsage, int TextureShadowMapMemoryUsage, int VertexLightMapMemoryUsage, int VertexShadowMapMemoryUsage, int StaticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_GetEstimatedLightMapResolution(IntPtr Self, int Width, int Height);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(IntPtr Self, int InWidth, int InHeight, int OutLightMapMemoryUsage, int OutShadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UStaticMeshComponent_GetTextureStreamingTransformScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_HasLightmapTextureCoordinates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_ReleaseResources(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_RemoveInstanceVertexColors(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(IntPtr Self, int LODToRemoveColorsFrom);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_RemoveSpeedTreeWind(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_SetMaterialPreview(IntPtr Self, int InMaterialIndexPreview);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_SetSectionPreview(IntPtr Self, int InSectionIndexPreview);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_SetStaticLightingMapping(IntPtr Self, bool bTextureMapping, int ResolutionToUse);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_SupportsDefaultCollision(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_SupportsDitheredLODTransitions(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_UsesTextureLightmaps(IntPtr Self, int InWidth, int InHeight);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Register this component's render data with the scene for SpeedTree wind </para>
		/// </summary>
		public void AddSpeedTreeWind()
			=> E_UStaticMeshComponent_AddSpeedTreeWind(this);
		
		
		/// <summary>
		/// <para>Save off the data painted on to this mesh per LOD if necessary </para>
		/// </summary>
		public void CachePaintedDataIfNecessary()
			=> E_UStaticMeshComponent_CachePaintedDataIfNecessary(this);
		
		
		/// <summary>
		/// <para>Copies instance vertex colors from the SourceComponent into this component </para>
		/// <param name="SourceComponent">The component to copy vertex colors from </param>
		/// </summary>
		public void CopyInstanceVertexColorsIfCompatible(UStaticMeshComponent SourceComponent)
			=> E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(this, SourceComponent);
		
		
		/// <summary>
		/// <para>Update the vertex override colors if necessary (i.e. vertices from source mesh have changed from override colors) </para>
		/// <param name="bRebuildingStaticMesh">true if we are rebuilding the static mesh used by this component </param>
		/// <para>@returns true if any fixup was performed. </para>
		/// </summary>
		public bool FixupOverrideColorsIfNecessary(bool bRebuildingStaticMesh = false)
			=> E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(this, bRebuildingStaticMesh);
		
		
		/// <summary>
		/// <para>Get this components index in its parents blueprint created components array (used for matching instance data) </para>
		/// </summary>
		public int GetBlueprintCreatedComponentIndex()
			=> E_UStaticMeshComponent_GetBlueprintCreatedComponentIndex(this);
		
		
		/// <summary>
		/// <para>Returns the light and shadow map memory for this primite in its out variables. </para>
		/// <para>Shadow map memory usage is per light whereof lightmap data is independent of number of lights, assuming at least one. </para>
		/// <param name="out">TextureLightMapMemoryUsage		Estimated memory usage in bytes for light map texel data </param>
		/// <param name="out">TextureShadowMapMemoryUsage		Estimated memory usage in bytes for shadow map texel data </param>
		/// <param name="out">VertexLightMapMemoryUsage		Estimated memory usage in bytes for light map vertex data </param>
		/// <param name="out">VertexShadowMapMemoryUsage		Estimated memory usage in bytes for shadow map vertex data </param>
		/// <param name="out">StaticLightingResolution		The StaticLightingResolution used for Texture estimates </param>
		/// <param name="out">bIsUsingTextureMapping			Set to true if the mesh is using texture mapping currently; false if vertex </param>
		/// <param name="out">bHasLightmapTexCoords			Set to true if the mesh has the proper UV channels </param>
		/// <return>bool							true if the mesh has static lighting; false if not </return>
		/// </summary>
		public virtual bool GetEstimatedLightAndShadowMapMemoryUsage(int TextureLightMapMemoryUsage, int TextureShadowMapMemoryUsage, int VertexLightMapMemoryUsage, int VertexShadowMapMemoryUsage, int StaticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords)
			=> E_UStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(this, TextureLightMapMemoryUsage, TextureShadowMapMemoryUsage, VertexLightMapMemoryUsage, VertexShadowMapMemoryUsage, StaticLightingResolution, bIsUsingTextureMapping, bHasLightmapTexCoords);
		
		
		/// <summary>
		/// <para>Returns the lightmap resolution used for this primitive instance in the case of it supporting texture light/ shadow maps. </para>
		/// <para>This will return the value assuming the primitive will be automatically switched to use texture mapping. </para>
		/// <param name="Width">out]	Width of light/shadow map </param>
		/// <param name="Height">out]	Height of light/shadow map </param>
		/// </summary>
		public virtual void GetEstimatedLightMapResolution(int Width, int Height)
			=> E_UStaticMeshComponent_GetEstimatedLightMapResolution(this, Width, Height);
		
		
		/// <summary>
		/// <para>Get the memory used for texture-based light and shadow maps of the given width and height </para>
		/// <param name="InWidth">The desired width of the light/shadow map </param>
		/// <param name="InHeight">The desired height of the light/shadow map </param>
		/// <param name="OutLightMapMemoryUsage">The resulting lightmap memory used </param>
		/// <param name="OutShadowMapMemoryUsage">The resulting shadowmap memory used </param>
		/// </summary>
		public virtual void GetTextureLightAndShadowMapMemoryUsage(int InWidth, int InHeight, int OutLightMapMemoryUsage, int OutShadowMapMemoryUsage)
			=> E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(this, InWidth, InHeight, OutLightMapMemoryUsage, OutShadowMapMemoryUsage);
		
		
		/// <summary>
		/// <para>Get the scale comming form the component, when computing StreamingTexture data. Used to support instanced meshes. </para>
		/// </summary>
		public virtual float GetTextureStreamingTransformScale()
			=> E_UStaticMeshComponent_GetTextureStreamingTransformScale(this);
		
		
		/// <summary>
		/// <para>Returns true if the static mesh the component uses has valid lightmap texture coordinates </para>
		/// </summary>
		public virtual bool HasLightmapTextureCoordinates()
			=> E_UStaticMeshComponent_HasLightmapTextureCoordinates(this);
		
		public void ReleaseResources()
			=> E_UStaticMeshComponent_ReleaseResources(this);
		
		
		/// <summary>
		/// <para>Removes instance vertex colors from all LODs </para>
		/// </summary>
		public void RemoveInstanceVertexColors()
			=> E_UStaticMeshComponent_RemoveInstanceVertexColors(this);
		
		
		/// <summary>
		/// <para>Removes instance vertex colors from the specified LOD </para>
		/// <param name="LODToRemoveColorsFrom">Index of the LOD to remove instance colors from </param>
		/// </summary>
		public void RemoveInstanceVertexColorsFromLOD(int LODToRemoveColorsFrom)
			=> E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(this, LODToRemoveColorsFrom);
		
		
		/// <summary>
		/// <para>Unregister this component's render data with the scene for SpeedTree wind </para>
		/// </summary>
		public void RemoveSpeedTreeWind()
			=> E_UStaticMeshComponent_RemoveSpeedTreeWind(this);
		
		
		/// <summary>
		/// <para>Determines whether any of the component's LODs require override vertex color fixups </para>
		/// <return>true if any LODs require override vertex color fixups </return>
		/// </summary>
		public bool RequiresOverrideVertexColorsFixup()
			=> E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(this);
		
		
		/// <summary>
		/// <para>Sets the value of the MaterialIndexPreview flag and reattaches the component as necessary. </para>
		/// <param name="InMaterialIndexPreview">New value of MaterialIndexPreview. </param>
		/// </summary>
		public void SetMaterialPreview(int InMaterialIndexPreview)
			=> E_UStaticMeshComponent_SetMaterialPreview(this, InMaterialIndexPreview);
		
		
		/// <summary>
		/// <para>Sets the value of the SectionIndexPreview flag and reattaches the component as necessary. </para>
		/// <param name="InSectionIndexPreview">New value of SectionIndexPreview. </param>
		/// </summary>
		public void SetSectionPreview(int InSectionIndexPreview)
			=> E_UStaticMeshComponent_SetSectionPreview(this, InSectionIndexPreview);
		
		
		/// <summary>
		/// <para>Switches the static mesh component to use either Texture or Vertex static lighting. </para>
		/// <param name="bTextureMapping">If true, set the component to use texture light mapping. </param>
		/// <para>If false, set it to use vertex light mapping. </para>
		/// <param name="ResolutionToUse">If != 0, set the resolution to the given value. </param>
		/// <return>bool				true if successfully set; false if not </return>
		/// <para>If false, set it to use vertex light mapping. </para>
		/// </summary>
		public virtual bool SetStaticLightingMapping(bool bTextureMapping, int ResolutionToUse)
			=> E_UStaticMeshComponent_SetStaticLightingMapping(this, bTextureMapping, ResolutionToUse);
		
		
		/// <summary>
		/// <para>Whether or not the component supports default collision from its static mesh asset </para>
		/// </summary>
		public virtual bool SupportsDefaultCollision()
			=> E_UStaticMeshComponent_SupportsDefaultCollision(this);
		
		
		/// <summary>
		/// <para>Whether we can support dithered LOD transitions (default behavior checks all materials). Used for HISMC LOD. </para>
		/// </summary>
		public virtual bool SupportsDitheredLODTransitions()
			=> E_UStaticMeshComponent_SupportsDitheredLODTransitions(this);
		
		
		/// <summary>
		/// <para>Sets the BodyInstance to use the mesh's body setup for external collision information </para>
		/// </summary>
		public void UpdateCollisionFromStaticMesh()
			=> E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(this);
		
		
		/// <summary>
		/// <para>Returns true if the component uses texture lightmaps </para>
		/// <param name="InWidth">in]	The width of the light/shadow map </param>
		/// <param name="InHeight">in]	The width of the light/shadow map </param>
		/// <return>bool				true if texture lightmaps are used, false if not </return>
		/// </summary>
		public virtual bool UsesTextureLightmaps(int InWidth, int InHeight)
			=> E_UStaticMeshComponent_UsesTextureLightmaps(this, InWidth, InHeight);
		
		#endregion
		
		public static implicit operator IntPtr(UStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UStaticMeshComponent>(PtrDesc);
		}}}
