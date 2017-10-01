#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/StaticMeshComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UStaticMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UStaticMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_AddSpeedTreeWind(UStaticMeshComponent* Self)
	{
		(Self)->AddSpeedTreeWind();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_CachePaintedDataIfNecessary(UStaticMeshComponent* Self)
	{
		(Self)->CachePaintedDataIfNecessary();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(UStaticMeshComponent* Self, UStaticMeshComponent* SourceComponent)
	{
		auto _p0 = SourceComponent;
		(Self)->CopyInstanceVertexColorsIfCompatible(_p0);
	}

	DOTNET_EXPORT bool E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(UStaticMeshComponent* Self, bool bRebuildingStaticMesh)
	{
		auto _p0 = bRebuildingStaticMesh;
		return (Self)->FixupOverrideColorsIfNecessary(_p0);
	}

	DOTNET_EXPORT int32 E_UStaticMeshComponent_GetBlueprintCreatedComponentIndex(UStaticMeshComponent* Self)
	{
		return (Self)->GetBlueprintCreatedComponentIndex();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_GetEstimatedLightMapResolution(UStaticMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		(Self)->GetEstimatedLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(UStaticMeshComponent* Self, int32 InWidth, int32 InHeight, int32 OutLightMapMemoryUsage, int32 OutShadowMapMemoryUsage)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		auto _p2 = OutLightMapMemoryUsage;
		auto _p3 = OutShadowMapMemoryUsage;
		(Self)->GetTextureLightAndShadowMapMemoryUsage(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_ReleaseResources(UStaticMeshComponent* Self)
	{
		(Self)->ReleaseResources();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_RemoveInstanceVertexColors(UStaticMeshComponent* Self)
	{
		(Self)->RemoveInstanceVertexColors();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(UStaticMeshComponent* Self, int32 LODToRemoveColorsFrom)
	{
		auto _p0 = LODToRemoveColorsFrom;
		(Self)->RemoveInstanceVertexColorsFromLOD(_p0);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_RemoveSpeedTreeWind(UStaticMeshComponent* Self)
	{
		(Self)->RemoveSpeedTreeWind();
	}

	DOTNET_EXPORT bool E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(UStaticMeshComponent* Self)
	{
		return (Self)->RequiresOverrideVertexColorsFixup();
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_SetMaterialPreview(UStaticMeshComponent* Self, int32 InMaterialIndexPreview)
	{
		auto _p0 = InMaterialIndexPreview;
		(Self)->SetMaterialPreview(_p0);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_SetSectionPreview(UStaticMeshComponent* Self, int32 InSectionIndexPreview)
	{
		auto _p0 = InSectionIndexPreview;
		(Self)->SetSectionPreview(_p0);
	}

	DOTNET_EXPORT void E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(UStaticMeshComponent* Self)
	{
		(Self)->UpdateCollisionFromStaticMesh();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
