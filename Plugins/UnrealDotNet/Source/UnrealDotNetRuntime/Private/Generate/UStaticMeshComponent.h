#pragma once

#include "CoreMinimal.h"
#include "Components/StaticMeshComponent.h"

extern "C"
{
	DOTNET_EXPORT float E_UStaticMeshComponent_GetTextureStreamingTransformScale(INT_PTR Self)
	{
		return ((UStaticMeshComponent*)Self)->GetTextureStreamingTransformScale();
	}

	DOTNET_EXPORT bool E_UStaticMeshComponent_UsesTextureLightmaps(INT_PTR Self, int32 InWidth, int32 InHeight)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		return ((UStaticMeshComponent*)Self)->UsesTextureLightmaps(_p0, _p1);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(INT_PTR Self, int32 InWidth, int32 InHeight, int32 OutLightMapMemoryUsage, int32 OutShadowMapMemoryUsage)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		auto _p2 = OutLightMapMemoryUsage;
		auto _p3 = OutShadowMapMemoryUsage;
		((UStaticMeshComponent*)Self)->GetTextureLightAndShadowMapMemoryUsage(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT bool E_UStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(INT_PTR Self, int32 TextureLightMapMemoryUsage, int32 TextureShadowMapMemoryUsage, int32 VertexLightMapMemoryUsage, int32 VertexShadowMapMemoryUsage, int32 StaticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords)
	{
		auto _p0 = TextureLightMapMemoryUsage;
		auto _p1 = TextureShadowMapMemoryUsage;
		auto _p2 = VertexLightMapMemoryUsage;
		auto _p3 = VertexShadowMapMemoryUsage;
		auto _p4 = StaticLightingResolution;
		auto _p5 = bIsUsingTextureMapping;
		auto _p6 = bHasLightmapTexCoords;
		return ((UStaticMeshComponent*)Self)->GetEstimatedLightAndShadowMapMemoryUsage(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT bool E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(INT_PTR Self, bool bRebuildingStaticMesh)
	{
		auto _p0 = bRebuildingStaticMesh;
		return ((UStaticMeshComponent*)Self)->FixupOverrideColorsIfNecessary(_p0);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(INT_PTR Self, UStaticMeshComponent* SourceComponent)
	{
		auto _p0 = SourceComponent;
		((UStaticMeshComponent*)Self)->CopyInstanceVertexColorsIfCompatible(_p0);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(INT_PTR Self, int32 LODToRemoveColorsFrom)
	{
		auto _p0 = LODToRemoveColorsFrom;
		((UStaticMeshComponent*)Self)->RemoveInstanceVertexColorsFromLOD(_p0);
	}

	DOTNET_EXPORT bool E_UStaticMeshComponent_SetStaticLightingMapping(INT_PTR Self, bool bTextureMapping, int32 ResolutionToUse)
	{
		auto _p0 = bTextureMapping;
		auto _p1 = ResolutionToUse;
		return ((UStaticMeshComponent*)Self)->SetStaticLightingMapping(_p0, _p1);
	}

}
