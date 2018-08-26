#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/StaticMeshComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:171

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bCastDistanceFieldIndirectShadow_GET(UStaticMeshComponent* Ptr) { return Ptr->bCastDistanceFieldIndirectShadow; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bCastDistanceFieldIndirectShadow_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bCastDistanceFieldIndirectShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bDisallowMeshPaintPerInstance_GET(UStaticMeshComponent* Ptr) { return Ptr->bDisallowMeshPaintPerInstance; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bDisallowMeshPaintPerInstance_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bDisallowMeshPaintPerInstance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfComplex_GET(UStaticMeshComponent* Ptr) { return Ptr->bDrawMeshCollisionIfComplex; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfComplex_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bDrawMeshCollisionIfComplex = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfSimple_GET(UStaticMeshComponent* Ptr) { return Ptr->bDrawMeshCollisionIfSimple; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bDrawMeshCollisionIfSimple_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bDrawMeshCollisionIfSimple = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bForceNavigationObstacle_GET(UStaticMeshComponent* Ptr) { return Ptr->bForceNavigationObstacle; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bForceNavigationObstacle_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bForceNavigationObstacle = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bIgnoreInstanceForTextureStreaming_GET(UStaticMeshComponent* Ptr) { return Ptr->bIgnoreInstanceForTextureStreaming; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bIgnoreInstanceForTextureStreaming_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bIgnoreInstanceForTextureStreaming = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bOverrideDistanceFieldSelfShadowBias_GET(UStaticMeshComponent* Ptr) { return Ptr->bOverrideDistanceFieldSelfShadowBias; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bOverrideDistanceFieldSelfShadowBias_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bOverrideDistanceFieldSelfShadowBias = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bOverrideLightMapRes_GET(UStaticMeshComponent* Ptr) { return Ptr->bOverrideLightMapRes; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bOverrideLightMapRes_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bOverrideLightMapRes = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bOverrideMinLOD_GET(UStaticMeshComponent* Ptr) { return Ptr->bOverrideMinLOD; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bOverrideMinLOD_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bOverrideMinLOD = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bOverrideNavigationExport_GET(UStaticMeshComponent* Ptr) { return Ptr->bOverrideNavigationExport; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bOverrideNavigationExport_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bOverrideNavigationExport = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bOverrideWireframeColor_GET(UStaticMeshComponent* Ptr) { return Ptr->bOverrideWireframeColor; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bOverrideWireframeColor_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bOverrideWireframeColor = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bReverseCulling_GET(UStaticMeshComponent* Ptr) { return Ptr->bReverseCulling; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bReverseCulling_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bReverseCulling = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bUseDefaultCollision_GET(UStaticMeshComponent* Ptr) { return Ptr->bUseDefaultCollision; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bUseDefaultCollision_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bUseDefaultCollision = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_bUseSubDivisions_GET(UStaticMeshComponent* Ptr) { return Ptr->bUseSubDivisions; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_bUseSubDivisions_SET(UStaticMeshComponent* Ptr, uint8 Value) { Ptr->bUseSubDivisions = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_DistanceFieldIndirectShadowMinVisibility_GET(UStaticMeshComponent* Ptr) { return Ptr->DistanceFieldIndirectShadowMinVisibility; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_DistanceFieldIndirectShadowMinVisibility_SET(UStaticMeshComponent* Ptr, float Value) { Ptr->DistanceFieldIndirectShadowMinVisibility = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_DistanceFieldSelfShadowBias_GET(UStaticMeshComponent* Ptr) { return Ptr->DistanceFieldSelfShadowBias; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_DistanceFieldSelfShadowBias_SET(UStaticMeshComponent* Ptr, float Value) { Ptr->DistanceFieldSelfShadowBias = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_LightmassSettings_GET(UStaticMeshComponent* Ptr) { return (INT_PTR)&(Ptr->LightmassSettings); }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_LightmassSettings_SET(UStaticMeshComponent* Ptr, INT_PTR Value) { Ptr->LightmassSettings = *(FLightmassPrimitiveSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_OverriddenLightMapRes_GET(UStaticMeshComponent* Ptr) { return Ptr->OverriddenLightMapRes; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_OverriddenLightMapRes_SET(UStaticMeshComponent* Ptr, int32 Value) { Ptr->OverriddenLightMapRes = Value; }
	
	DOTNET_EXPORT auto E_PROP_UStaticMeshComponent_StreamingDistanceMultiplier_GET(UStaticMeshComponent* Ptr) { return Ptr->StreamingDistanceMultiplier; }
	DOTNET_EXPORT void E_PROP_UStaticMeshComponent_StreamingDistanceMultiplier_SET(UStaticMeshComponent* Ptr, float Value) { Ptr->StreamingDistanceMultiplier = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UStaticMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UStaticMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CachePaintedDataIfNecessary(UStaticMeshComponent* Self)
	{
		Self->CachePaintedDataIfNecessary();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(UStaticMeshComponent* Self, UStaticMeshComponent* SourceComponent)
	{
		auto _p0 = SourceComponent;
		Self->CopyInstanceVertexColorsIfCompatible(_p0);
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
		auto& _p0 = TextureLightMapMemoryUsage;
		auto& _p1 = TextureShadowMapMemoryUsage;
		auto& _p2 = VertexLightMapMemoryUsage;
		auto& _p3 = VertexShadowMapMemoryUsage;
		auto& _p4 = StaticLightingResolution;
		auto& _p5 = bIsUsingTextureMapping;
		auto& _p6 = bHasLightmapTexCoords;
		return Self->GetEstimatedLightAndShadowMapMemoryUsage(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetEstimatedLightMapResolution(UStaticMeshComponent* Self, int32 Width, int32 Height)
	{
		auto& _p0 = Width;
		auto& _p1 = Height;
		Self->GetEstimatedLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetLocalBounds(UStaticMeshComponent* Self, INT_PTR Min, INT_PTR Max)
	{
		auto& _p0 = *(FVector*)Min;
		auto& _p1 = *(FVector*)Max;
		Self->GetLocalBounds(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetMemberNameChecked_StaticMesh(UStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetMemberNameChecked_StaticMesh());
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(UStaticMeshComponent* Self, int32 InWidth, int32 InHeight, int32 OutLightMapMemoryUsage, int32 OutShadowMapMemoryUsage)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		auto& _p2 = OutLightMapMemoryUsage;
		auto& _p3 = OutShadowMapMemoryUsage;
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

	DOTNET_EXPORT auto E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(UStaticMeshComponent* Self)
	{
		return Self->RequiresOverrideVertexColorsFixup();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetDistanceFieldSelfShadowBias(UStaticMeshComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetDistanceFieldSelfShadowBias(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetForcedLodModel(UStaticMeshComponent* Self, int32 NewForcedLodModel)
	{
		auto _p0 = NewForcedLodModel;
		Self->SetForcedLodModel(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetMaterialPreview(UStaticMeshComponent* Self, int32 InMaterialIndexPreview)
	{
		auto _p0 = InMaterialIndexPreview;
		Self->SetMaterialPreview(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetReverseCulling(UStaticMeshComponent* Self, bool ReverseCulling)
	{
		auto _p0 = ReverseCulling;
		Self->SetReverseCulling(_p0);
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
