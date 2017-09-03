#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/StaticMeshComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UStaticMeshComponent_AddSpeedTreeWind(INT_PTR Self)
	{
		((UStaticMeshComponent*)Self)->AddSpeedTreeWind();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_CachePaintedDataIfNecessary(INT_PTR Self)
	{
		((UStaticMeshComponent*)Self)->CachePaintedDataIfNecessary();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(INT_PTR Self, UStaticMeshComponent* SourceComponent)
	{
		auto _p0 = SourceComponent;
		((UStaticMeshComponent*)Self)->CopyInstanceVertexColorsIfCompatible(_p0);
	}

	DOTNET_EXPORT bool E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(INT_PTR Self, bool bRebuildingStaticMesh)
	{
		auto _p0 = bRebuildingStaticMesh;
		return ((UStaticMeshComponent*)Self)->FixupOverrideColorsIfNecessary(_p0);
	}

	DOTNET_EXPORT int32 E_UStaticMeshComponent_GetBlueprintCreatedComponentIndex(INT_PTR Self)
	{
		return ((UStaticMeshComponent*)Self)->GetBlueprintCreatedComponentIndex();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_GetEstimatedLightMapResolution(INT_PTR Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		((UStaticMeshComponent*)Self)->GetEstimatedLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(INT_PTR Self, int32 InWidth, int32 InHeight, int32 OutLightMapMemoryUsage, int32 OutShadowMapMemoryUsage)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		auto _p2 = OutLightMapMemoryUsage;
		auto _p3 = OutShadowMapMemoryUsage;
		((UStaticMeshComponent*)Self)->GetTextureLightAndShadowMapMemoryUsage(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_ReleaseResources(INT_PTR Self)
	{
		((UStaticMeshComponent*)Self)->ReleaseResources();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_RemoveInstanceVertexColors(INT_PTR Self)
	{
		((UStaticMeshComponent*)Self)->RemoveInstanceVertexColors();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(INT_PTR Self, int32 LODToRemoveColorsFrom)
	{
		auto _p0 = LODToRemoveColorsFrom;
		((UStaticMeshComponent*)Self)->RemoveInstanceVertexColorsFromLOD(_p0);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_RemoveSpeedTreeWind(INT_PTR Self)
	{
		((UStaticMeshComponent*)Self)->RemoveSpeedTreeWind();
	}

	DOTNET_EXPORT bool E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(INT_PTR Self)
	{
		return ((UStaticMeshComponent*)Self)->RequiresOverrideVertexColorsFixup();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_SetMaterialPreview(INT_PTR Self, int32 InMaterialIndexPreview)
	{
		auto _p0 = InMaterialIndexPreview;
		((UStaticMeshComponent*)Self)->SetMaterialPreview(_p0);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_SetSectionPreview(INT_PTR Self, int32 InSectionIndexPreview)
	{
		auto _p0 = InSectionIndexPreview;
		((UStaticMeshComponent*)Self)->SetSectionPreview(_p0);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(INT_PTR Self)
	{
		((UStaticMeshComponent*)Self)->UpdateCollisionFromStaticMesh();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
