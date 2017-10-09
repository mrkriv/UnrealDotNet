#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/StaticMeshComponent.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\StaticMeshComponent.h:153

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UStaticMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UStaticMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddSpeedTreeWind(UStaticMeshComponent* Self)
	{
		Self->AddSpeedTreeWind();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CachePaintedDataIfNecessary(UStaticMeshComponent* Self)
	{
		Self->CachePaintedDataIfNecessary();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(UStaticMeshComponent* Self, bool bRebuildingStaticMesh)
	{
		auto _p0 = bRebuildingStaticMesh;
		return Self->FixupOverrideColorsIfNecessary(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetBlueprintCreatedComponentIndex(UStaticMeshComponent* Self)
	{
		return Self->GetBlueprintCreatedComponentIndex();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(UStaticMeshComponent* Self, int32 TextureLightMapMemoryUsage, int32 TextureShadowMapMemoryUsage, int32 VertexLightMapMemoryUsage, int32 VertexShadowMapMemoryUsage, int32 StaticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords)
	{
		auto _p0 = TextureLightMapMemoryUsage;
		auto _p1 = TextureShadowMapMemoryUsage;
		auto _p2 = VertexLightMapMemoryUsage;
		auto _p3 = VertexShadowMapMemoryUsage;
		auto _p4 = StaticLightingResolution;
		auto _p5 = bIsUsingTextureMapping;
		auto _p6 = bHasLightmapTexCoords;
		return Self->GetEstimatedLightAndShadowMapMemoryUsage(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetEstimatedLightMapResolution(UStaticMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		Self->GetEstimatedLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(UStaticMeshComponent* Self, int32 InWidth, int32 InHeight, int32 OutLightMapMemoryUsage, int32 OutShadowMapMemoryUsage)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		auto _p2 = OutLightMapMemoryUsage;
		auto _p3 = OutShadowMapMemoryUsage;
		Self->GetTextureLightAndShadowMapMemoryUsage(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetTextureStreamingTransformScale(UStaticMeshComponent* Self)
	{
		return Self->GetTextureStreamingTransformScale();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_HasLightmapTextureCoordinates(UStaticMeshComponent* Self)
	{
		return Self->HasLightmapTextureCoordinates();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ReleaseResources(UStaticMeshComponent* Self)
	{
		Self->ReleaseResources();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_RemoveInstanceVertexColors(UStaticMeshComponent* Self)
	{
		Self->RemoveInstanceVertexColors();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(UStaticMeshComponent* Self, int32 LODToRemoveColorsFrom)
	{
		auto _p0 = LODToRemoveColorsFrom;
		Self->RemoveInstanceVertexColorsFromLOD(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_RemoveSpeedTreeWind(UStaticMeshComponent* Self)
	{
		Self->RemoveSpeedTreeWind();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(UStaticMeshComponent* Self)
	{
		return Self->RequiresOverrideVertexColorsFixup();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetMaterialPreview(UStaticMeshComponent* Self, int32 InMaterialIndexPreview)
	{
		auto _p0 = InMaterialIndexPreview;
		Self->SetMaterialPreview(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetSectionPreview(UStaticMeshComponent* Self, int32 InSectionIndexPreview)
	{
		auto _p0 = InSectionIndexPreview;
		Self->SetSectionPreview(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetStaticLightingMapping(UStaticMeshComponent* Self, bool bTextureMapping, int32 ResolutionToUse)
	{
		auto _p0 = bTextureMapping;
		auto _p1 = ResolutionToUse;
		return Self->SetStaticLightingMapping(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SupportsDefaultCollision(UStaticMeshComponent* Self)
	{
		return Self->SupportsDefaultCollision();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SupportsDitheredLODTransitions(UStaticMeshComponent* Self)
	{
		return Self->SupportsDitheredLODTransitions();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(UStaticMeshComponent* Self)
	{
		Self->UpdateCollisionFromStaticMesh();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UsesTextureLightmaps(UStaticMeshComponent* Self, int32 InWidth, int32 InHeight)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		return Self->UsesTextureLightmaps(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
