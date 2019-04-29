// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:171

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

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bCastDistanceFieldIndirectShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bCastDistanceFieldIndirectShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bDisallowMeshPaintPerInstance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bDisallowMeshPaintPerInstance_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfComplex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfComplex_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfSimple_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfSimple_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bForceNavigationObstacle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bForceNavigationObstacle_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bIgnoreInstanceForTextureStreaming_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bIgnoreInstanceForTextureStreaming_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bOverrideDistanceFieldSelfShadowBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bOverrideDistanceFieldSelfShadowBias_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bOverrideLightMapRes_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bOverrideLightMapRes_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bOverrideMinLOD_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bOverrideMinLOD_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bOverrideNavigationExport_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bOverrideNavigationExport_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bOverrideWireframeColor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bOverrideWireframeColor_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bReverseCulling_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bReverseCulling_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bUseDefaultCollision_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bUseDefaultCollision_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UStaticMeshComponent_bUseSubDivisions_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_bUseSubDivisions_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UStaticMeshComponent_DistanceFieldIndirectShadowMinVisibility_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_DistanceFieldIndirectShadowMinVisibility_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UStaticMeshComponent_DistanceFieldSelfShadowBias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_DistanceFieldSelfShadowBias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UStaticMeshComponent_ForcedLodModel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_ForcedLodModel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UStaticMeshComponent_LightmassSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_LightmassSettings_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UStaticMeshComponent_MinLOD_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_MinLOD_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UStaticMeshComponent_OverriddenLightMapRes_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_OverriddenLightMapRes_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UStaticMeshComponent_PreviousLODLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_PreviousLODLevel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UStaticMeshComponent_StreamingDistanceMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_StreamingDistanceMultiplier_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UStaticMeshComponent_SubDivisionStepSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UStaticMeshComponent_SubDivisionStepSize_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UStaticMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_CachePaintedDataIfNecessary(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(IntPtr self, IntPtr sourceComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(IntPtr self, bool bRebuildingStaticMesh);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UStaticMeshComponent_GetBlueprintCreatedComponentIndex(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(IntPtr self, int textureLightMapMemoryUsage, int textureShadowMapMemoryUsage, int vertexLightMapMemoryUsage, int vertexShadowMapMemoryUsage, int staticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_GetEstimatedLightMapResolution(IntPtr self, int width, int height);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_GetLocalBounds(IntPtr self, IntPtr min, IntPtr max);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UStaticMeshComponent_GetMemberNameChecked_StaticMesh(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(IntPtr self, int inWidth, int inHeight, int outLightMapMemoryUsage, int outShadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UStaticMeshComponent_GetTextureStreamingTransformScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_HasLightmapTextureCoordinates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_ReleaseResources(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_RemoveInstanceVertexColors(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(IntPtr self, int lODToRemoveColorsFrom);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_SetDistanceFieldSelfShadowBias(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_SetForcedLodModel(IntPtr self, int newForcedLodModel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_SetMaterialPreview(IntPtr self, int inMaterialIndexPreview);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_SetReverseCulling(IntPtr self, bool reverseCulling);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_SetSectionPreview(IntPtr self, int inSectionIndexPreview);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_SetStaticLightingMapping(IntPtr self, bool bTextureMapping, int resolutionToUse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_SupportsDefaultCollision(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UStaticMeshComponent_UsesTextureLightmaps(IntPtr self, int inWidth, int inHeight);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether to use the mesh distance field representation (when present) for shadowing indirect lighting (from lightmaps or skylight) on Movable components.
		/// <para>This works like capsule shadows on skeletal meshes, except using the mesh distance field so no physics asset is required. </para>
		/// The StaticMesh must have 'Generate Mesh Distance Field' enabled, or the project must have 'Generate Mesh Distance Fields' enabled for this feature to work.
		/// </summary>
		public byte DistanceFieldIndirectShadow
		{
			get => E_PROP_UStaticMeshComponent_bCastDistanceFieldIndirectShadow_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bCastDistanceFieldIndirectShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, mesh painting is disallowed on this instance. Set if vertex colors are overridden in a construction script.
		/// </summary>
		public byte bDisallowMeshPaintPerInstance
		{
			get => E_PROP_UStaticMeshComponent_bDisallowMeshPaintPerInstance_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bDisallowMeshPaintPerInstance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Draw mesh collision if used for complex collision
		/// </summary>
		public byte bDrawMeshCollisionIfComplex
		{
			get => E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfComplex_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfComplex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Draw mesh collision if used for simple collision
		/// </summary>
		public byte bDrawMeshCollisionIfSimple
		{
			get => E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfSimple_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfSimple_SET(NativePointer, value);
		}

		public byte bForceNavigationObstacle
		{
			get => E_PROP_UStaticMeshComponent_bForceNavigationObstacle_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bForceNavigationObstacle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Ignore this instance of this static mesh when calculating streaming information.
		/// <para>This can be useful when doing things like applying character textures to static geometry, </para>
		/// to avoid them using distance-based streaming.
		/// </summary>
		public byte bIgnoreInstanceForTextureStreaming
		{
			get => E_PROP_UStaticMeshComponent_bIgnoreInstanceForTextureStreaming_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bIgnoreInstanceForTextureStreaming_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to override the DistanceFieldSelfShadowBias setting of the static mesh asset with the DistanceFieldSelfShadowBias of this component.
		/// </summary>
		public byte bOverrideDistanceFieldSelfShadowBias
		{
			get => E_PROP_UStaticMeshComponent_bOverrideDistanceFieldSelfShadowBias_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bOverrideDistanceFieldSelfShadowBias_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to override the lightmap resolution defined in the static mesh.
		/// </summary>
		public byte bOverrideLightMapRes
		{
			get => E_PROP_UStaticMeshComponent_bOverrideLightMapRes_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bOverrideLightMapRes_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to override the MinLOD setting of the static mesh asset with the MinLOD of this component.
		/// </summary>
		public byte bOverrideMinLOD
		{
			get => E_PROP_UStaticMeshComponent_bOverrideMinLOD_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bOverrideMinLOD_SET(NativePointer, value);
		}

		public byte bOverrideNavigationExport
		{
			get => E_PROP_UStaticMeshComponent_bOverrideNavigationExport_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bOverrideNavigationExport_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, WireframeColorOverride will be used. If false, color is determined based on mobility and physics simulation settings
		/// </summary>
		public byte bOverrideWireframeColor
		{
			get => E_PROP_UStaticMeshComponent_bOverrideWireframeColor_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bOverrideWireframeColor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls whether the static mesh component's backface culling should be reversed
		/// </summary>
		public byte bReverseCulling
		{
			get => E_PROP_UStaticMeshComponent_bReverseCulling_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bReverseCulling_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Use the collision profile specified in the StaticMesh asset.
		/// </summary>
		public byte bUseDefaultCollision
		{
			get => E_PROP_UStaticMeshComponent_bUseDefaultCollision_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bUseDefaultCollision_SET(NativePointer, value);
		}

		public byte bUseSubDivisions
		{
			get => E_PROP_UStaticMeshComponent_bUseSubDivisions_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_bUseSubDivisions_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls how dark the dynamic indirect shadow can be.
		/// </summary>
		public float DistanceFieldIndirectShadowMinVisibility
		{
			get => E_PROP_UStaticMeshComponent_DistanceFieldIndirectShadowMinVisibility_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_DistanceFieldIndirectShadowMinVisibility_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Useful for reducing self shadowing from distance field methods when using world position offset to animate the mesh's vertices.
		/// </summary>
		public float DistanceFieldSelfShadowBias
		{
			get => E_PROP_UStaticMeshComponent_DistanceFieldSelfShadowBias_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_DistanceFieldSelfShadowBias_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If 0, auto-select LOD level. if >0, force to (ForcedLodModel-1).
		/// </summary>
		public int ForcedLodModel
		{
			get => E_PROP_UStaticMeshComponent_ForcedLodModel_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_ForcedLodModel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The Lightmass settings for this object.
		/// </summary>
		public FLightmassPrimitiveSettings LightmassSettings
		{
			get => E_PROP_UStaticMeshComponent_LightmassSettings_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_LightmassSettings_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Specifies the smallest LOD that will be used for this component.
		/// <para>This is ignored if ForcedLodModel is enabled. </para>
		/// </summary>
		public int MinLOD
		{
			get => E_PROP_UStaticMeshComponent_MinLOD_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_MinLOD_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Light map resolution to use on this component, used if bOverrideLightMapRes is true and there is a valid StaticMesh.
		/// </summary>
		public int OverriddenLightMapRes
		{
			get => E_PROP_UStaticMeshComponent_OverriddenLightMapRes_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_OverriddenLightMapRes_SET(NativePointer, value);
		}

		public int PreviousLODLevel
		{
			get => E_PROP_UStaticMeshComponent_PreviousLODLevel_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_PreviousLODLevel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Allows adjusting the desired streaming distance of streaming textures that uses UV 0.
		/// <para>1.0 is the default, whereas a higher value makes the textures stream in sooner from far away. </para>
		/// A lower value (0.0-1.0) makes the textures stream in later (you have to be closer).
		/// <para>Value can be < 0 (from legcay content, or code changes) </para>
		/// </summary>
		public float StreamingDistanceMultiplier
		{
			get => E_PROP_UStaticMeshComponent_StreamingDistanceMultiplier_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_StreamingDistanceMultiplier_SET(NativePointer, value);
		}

		public int SubDivisionStepSize
		{
			get => E_PROP_UStaticMeshComponent_SubDivisionStepSize_GET(NativePointer);
			set => E_PROP_UStaticMeshComponent_SubDivisionStepSize_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Save off the data painted on to this mesh per LOD if necessary
		/// </summary>
		public void CachePaintedDataIfNecessary()
			=> E_UStaticMeshComponent_CachePaintedDataIfNecessary(this);
		
		
		/// <summary>
		/// Copies instance vertex colors from the SourceComponent into this component
		/// </summary>
		/// <param name="sourceComponent">The component to copy vertex colors from</param>
		public void CopyInstanceVertexColorsIfCompatible(UStaticMeshComponent sourceComponent)
			=> E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(this, sourceComponent);
		
		
		/// <summary>
		/// Update the vertex override colors if necessary (i.e. vertices from source mesh have changed from override colors)
		/// <para>@returns true if any fixup was performed. </para>
		/// </summary>
		/// <param name="bRebuildingStaticMesh">true if we are rebuilding the static mesh used by this component</param>
		public bool FixupOverrideColorsIfNecessary(bool bRebuildingStaticMesh = false)
			=> E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(this, bRebuildingStaticMesh);
		
		
		/// <summary>
		/// Get this components index in its parents blueprint created components array (used for matching instance data)
		/// </summary>
		public int GetBlueprintCreatedComponentIndex()
			=> E_UStaticMeshComponent_GetBlueprintCreatedComponentIndex(this);
		
		
		/// <summary>
		/// Returns the light and shadow map memory for this primite in its out variables.
		/// <para>Shadow map memory usage is per light whereof lightmap data is independent of number of lights, assuming at least one. </para>
		/// </summary>
		/// <param name="@out">TextureLightMapMemoryUsage		Estimated memory usage in bytes for light map texel data</param>
		/// <param name="@out">TextureShadowMapMemoryUsage		Estimated memory usage in bytes for shadow map texel data</param>
		/// <param name="@out">VertexLightMapMemoryUsage		Estimated memory usage in bytes for light map vertex data</param>
		/// <param name="@out">VertexShadowMapMemoryUsage		Estimated memory usage in bytes for shadow map vertex data</param>
		/// <param name="@out">StaticLightingResolution		The StaticLightingResolution used for Texture estimates</param>
		/// <param name="@out">bIsUsingTextureMapping			Set to true if the mesh is using texture mapping currently; false if vertex</param>
		/// <param name="@out">bHasLightmapTexCoords			Set to true if the mesh has the proper UV channels</param>
		/// <return>bool</return>
		public virtual bool GetEstimatedLightAndShadowMapMemoryUsage(int textureLightMapMemoryUsage, int textureShadowMapMemoryUsage, int vertexLightMapMemoryUsage, int vertexShadowMapMemoryUsage, int staticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords)
			=> E_UStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(this, textureLightMapMemoryUsage, textureShadowMapMemoryUsage, vertexLightMapMemoryUsage, vertexShadowMapMemoryUsage, staticLightingResolution, bIsUsingTextureMapping, bHasLightmapTexCoords);
		
		
		/// <summary>
		/// Returns the lightmap resolution used for this primitive instance in the case of it supporting texture light/ shadow maps.
		/// <para>This will return the value assuming the primitive will be automatically switched to use texture mapping. </para>
		/// </summary>
		/// <param name="width">out]	Width of light/shadow map</param>
		/// <param name="height">out]	Height of light/shadow map</param>
		public virtual void GetEstimatedLightMapResolution(int width, int height)
			=> E_UStaticMeshComponent_GetEstimatedLightMapResolution(this, width, height);
		
		
		/// <summary>
		/// Get Local bounds
		/// </summary>
		public void GetLocalBounds(FVector min, FVector max)
			=> E_UStaticMeshComponent_GetLocalBounds(this, min, max);
		
		
		/// <summary>
		/// Helper function to get the FName of the private static mesh member
		/// </summary>
		public string GetMemberNameChecked_StaticMesh()
			=> E_UStaticMeshComponent_GetMemberNameChecked_StaticMesh(this);
		
		
		/// <summary>
		/// Get the memory used for texture-based light and shadow maps of the given width and height
		/// </summary>
		/// <param name="inWidth">The desired width of the light/shadow map</param>
		/// <param name="inHeight">The desired height of the light/shadow map</param>
		/// <param name="outLightMapMemoryUsage">The resulting lightmap memory used</param>
		/// <param name="outShadowMapMemoryUsage">The resulting shadowmap memory used</param>
		public virtual void GetTextureLightAndShadowMapMemoryUsage(int inWidth, int inHeight, int outLightMapMemoryUsage, int outShadowMapMemoryUsage)
			=> E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(this, inWidth, inHeight, outLightMapMemoryUsage, outShadowMapMemoryUsage);
		
		
		/// <summary>
		/// Get the scale comming form the component, when computing StreamingTexture data. Used to support instanced meshes.
		/// </summary>
		public virtual float GetTextureStreamingTransformScale()
			=> E_UStaticMeshComponent_GetTextureStreamingTransformScale(this);
		
		
		/// <summary>
		/// Returns true if the static mesh the component uses has valid lightmap texture coordinates
		/// </summary>
		public virtual bool HasLightmapTextureCoordinates()
			=> E_UStaticMeshComponent_HasLightmapTextureCoordinates(this);
		
		public void ReleaseResources()
			=> E_UStaticMeshComponent_ReleaseResources(this);
		
		
		/// <summary>
		/// Removes instance vertex colors from all LODs
		/// </summary>
		public void RemoveInstanceVertexColors()
			=> E_UStaticMeshComponent_RemoveInstanceVertexColors(this);
		
		
		/// <summary>
		/// Removes instance vertex colors from the specified LOD
		/// </summary>
		/// <param name="lODToRemoveColorsFrom">Index of the LOD to remove instance colors from</param>
		public void RemoveInstanceVertexColorsFromLOD(int lODToRemoveColorsFrom)
			=> E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(this, lODToRemoveColorsFrom);
		
		
		/// <summary>
		/// Determines whether any of the component's LODs require override vertex color fixups
		/// </summary>
		/// <return>true</return>
		public bool RequiresOverrideVertexColorsFixup()
			=> E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(this);
		
		
		/// <summary>
		/// Sets the component's DistanceFieldSelfShadowBias.  bOverrideDistanceFieldSelfShadowBias must be enabled for this to have an effect.
		/// </summary>
		public void SetDistanceFieldSelfShadowBias(float newValue)
			=> E_UStaticMeshComponent_SetDistanceFieldSelfShadowBias(this, newValue);
		
		public void SetForcedLodModel(int newForcedLodModel)
			=> E_UStaticMeshComponent_SetForcedLodModel(this, newForcedLodModel);
		
		
		/// <summary>
		/// Sets the value of the MaterialIndexPreview flag and reattaches the component as necessary.
		/// </summary>
		/// <param name="inMaterialIndexPreview">New value of MaterialIndexPreview.</param>
		public void SetMaterialPreview(int inMaterialIndexPreview)
			=> E_UStaticMeshComponent_SetMaterialPreview(this, inMaterialIndexPreview);
		
		
		/// <summary>
		/// Set forced reverse culling
		/// </summary>
		public void SetReverseCulling(bool reverseCulling)
			=> E_UStaticMeshComponent_SetReverseCulling(this, reverseCulling);
		
		
		/// <summary>
		/// Sets the value of the SectionIndexPreview flag and reattaches the component as necessary.
		/// </summary>
		/// <param name="inSectionIndexPreview">New value of SectionIndexPreview.</param>
		public void SetSectionPreview(int inSectionIndexPreview)
			=> E_UStaticMeshComponent_SetSectionPreview(this, inSectionIndexPreview);
		
		
		/// <summary>
		/// Switches the static mesh component to use either Texture or Vertex static lighting.
		/// <para>If false, set it to use vertex light mapping. </para>
		/// If false, set it to use vertex light mapping.
		/// </summary>
		/// <param name="bTextureMapping">If true, set the component to use texture light mapping.</param>
		/// <param name="resolutionToUse">If != 0, set the resolution to the given value.</param>
		/// <return>bool</return>
		public virtual bool SetStaticLightingMapping(bool bTextureMapping, int resolutionToUse)
			=> E_UStaticMeshComponent_SetStaticLightingMapping(this, bTextureMapping, resolutionToUse);
		
		
		/// <summary>
		/// Whether or not the component supports default collision from its static mesh asset
		/// </summary>
		public virtual bool SupportsDefaultCollision()
			=> E_UStaticMeshComponent_SupportsDefaultCollision(this);
		
		
		/// <summary>
		/// Sets the BodyInstance to use the mesh's body setup for external collision information
		/// </summary>
		public void UpdateCollisionFromStaticMesh()
			=> E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(this);
		
		
		/// <summary>
		/// Returns true if the component uses texture lightmaps
		/// </summary>
		/// <param name="inWidth">in]	The width of the light/shadow map</param>
		/// <param name="inHeight">in]	The width of the light/shadow map</param>
		/// <return>bool</return>
		public virtual bool UsesTextureLightmaps(int inWidth, int inHeight)
			=> E_UStaticMeshComponent_UsesTextureLightmaps(this, inWidth, inHeight);
		
		#endregion
		
		public static implicit operator IntPtr(UStaticMeshComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UStaticMeshComponent>(PtrDesc);
		}}}
