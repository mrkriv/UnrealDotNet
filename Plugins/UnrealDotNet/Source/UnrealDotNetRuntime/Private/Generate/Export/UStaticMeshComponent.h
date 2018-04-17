#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/StaticMeshComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:154

class E_PROTECTED_WRAP_UStaticMeshComponent : protected UStaticMeshComponent
{
public:
	void OnCreatePhysicsState_WRAP()
	{
		OnCreatePhysicsState();
	}

	void OnDestroyPhysicsState_WRAP()
	{
		OnDestroyPhysicsState();
	}

	bool SupportsStaticLighting_WRAP()
	{
		return SupportsStaticLighting();
	}

	bool AreAllCollideableDescendantsRelative_WRAP(bool bAllowCachedValue)
	{
		return AreAllCollideableDescendantsRelative(bAllowCachedValue);
	}

	bool MoveComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		return MoveComponentImpl(Delta, NewRotation, bSweep, OutHit, MoveFlags, Teleport);
	}

	void OnComponentCollisionSettingsChanged_WRAP()
	{
		OnComponentCollisionSettingsChanged();
	}

	void UpdatePhysicsToRBChannels_WRAP()
	{
		UpdatePhysicsToRBChannels();
	}

	void OnChildAttached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildAttached(ChildComponent);
	}

	void OnChildDetached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildDetached(ChildComponent);
	}

	void OnHiddenInGameChanged_WRAP()
	{
		OnHiddenInGameChanged();
	}

	void OnVisibilityChanged_WRAP()
	{
		OnVisibilityChanged();
	}

	void SendRenderDynamicData_Concurrent_WRAP()
	{
		SendRenderDynamicData_Concurrent();
	}

	bool ShouldActivate_WRAP()
	{
		return ShouldActivate();
	}

}
;

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

	DOTNET_EXPORT auto E_UStaticMeshComponent_AreNativePropertiesIdenticalTo(UStaticMeshComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_BeginDestroy(UStaticMeshComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CachePaintedDataIfNecessary(UStaticMeshComponent* Self)
	{
		Self->CachePaintedDataIfNecessary();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CanEditSimulatePhysics(UStaticMeshComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(UStaticMeshComponent* Self, UStaticMeshComponent* SourceComponent)
	{
		auto _p0 = SourceComponent;
		Self->CopyInstanceVertexColorsIfCompatible(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_DoesSocketExist(UStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
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

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetDetailedInfoInternal(UStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetDiffuseBoost(UStaticMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetEmissiveBoost(UStaticMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
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

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetLightAndShadowMapMemoryUsage(UStaticMeshComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetLightMapResolution(UStaticMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetLocalBounds(UStaticMeshComponent* Self, INT_PTR Min, INT_PTR Max)
	{
		auto _p0 = *(FVector*)Min;
		auto _p1 = *(FVector*)Max;
		Self->GetLocalBounds(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetMaterialIndex(UStaticMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->GetMaterialIndex(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetNumMaterials(UStaticMeshComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetShadowIndirectOnly(UStaticMeshComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetSocketTransform(UStaticMeshComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetStaticLightMapResolution(UStaticMeshComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
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

	DOTNET_EXPORT auto E_UStaticMeshComponent_HasAnySockets(UStaticMeshComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_HasLightmapTextureCoordinates(UStaticMeshComponent* Self)
	{
		return Self->HasLightmapTextureCoordinates();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_HasValidSettingsForStaticLighting(UStaticMeshComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_InvalidateLightingCacheDetailed(UStaticMeshComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsMaterialSlotNameValid(UStaticMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->IsMaterialSlotNameValid(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsNavigationRelevant(UStaticMeshComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsPrecomputedLightingValid(UStaticMeshComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_NotifyObjectReferenceEliminated(UStaticMeshComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnCreatePhysicsState(UStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnDestroyPhysicsState(UStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnRegister(UStaticMeshComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnUnregister(UStaticMeshComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PostInitProperties(UStaticMeshComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PostLoad(UStaticMeshComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PropagateLightingScenarioChange(UStaticMeshComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
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

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetCollisionProfileName(UStaticMeshComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
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

	DOTNET_EXPORT auto E_UStaticMeshComponent_ShouldCollideWhenPlacing(UStaticMeshComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ShouldRecreateProxyOnUpdateTransform(UStaticMeshComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SupportsDefaultCollision(UStaticMeshComponent* Self)
	{
		return Self->SupportsDefaultCollision();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SupportsDitheredLODTransitions(UStaticMeshComponent* Self)
	{
		return Self->SupportsDitheredLODTransitions();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SupportsStaticLighting(UStaticMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(UStaticMeshComponent* Self)
	{
		Self->UpdateCollisionFromStaticMesh();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UsesOnlyUnlitMaterials(UStaticMeshComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UsesTextureLightmaps(UStaticMeshComponent* Self, int32 InWidth, int32 InHeight)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		return Self->UsesTextureLightmaps(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddAngularImpulse(UStaticMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddAngularImpulseInRadians(UStaticMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddForce(UStaticMeshComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddForceAtLocation(UStaticMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddForceAtLocationLocal(UStaticMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddImpulse(UStaticMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddImpulseAtLocation(UStaticMeshComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddRadialForce(UStaticMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddRadialImpulse(UStaticMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AreAllCollideableDescendantsRelative(UStaticMeshComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AreSymmetricRotations(UStaticMeshComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_BeginPlay(UStaticMeshComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CalculateMass(UStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CanCharacterStepUp(UStaticMeshComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CreateRenderState_Concurrent(UStaticMeshComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_DestroyRenderState_Concurrent(UStaticMeshComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_FinishDestroy(UStaticMeshComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetAngularDamping(UStaticMeshComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetCollisionObjectType(UStaticMeshComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetCollisionResponseToChannel(UStaticMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetComponentVelocity(UStaticMeshComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetInertiaTensor(UStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetLinearDamping(UStaticMeshComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetMass(UStaticMeshComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetMassScale(UStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetNavigationBounds(UStaticMeshComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetSquaredDistanceToCollision(UStaticMeshComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetStaticDepthPriorityGroup(UStaticMeshComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_HasValidPhysicsState(UStaticMeshComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsAnyRigidBodyAwake(UStaticMeshComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsEditorOnly(UStaticMeshComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsGravityEnabled(UStaticMeshComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsReadyForFinishDestroy(UStaticMeshComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsSimulatingPhysics(UStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsWorldGeometry(UStaticMeshComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsZeroExtent(UStaticMeshComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_MoveComponentImpl(UStaticMeshComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_NeedsLoadForClient(UStaticMeshComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_NeedsLoadForServer(UStaticMeshComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnActorEnableCollisionChanged(UStaticMeshComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnAttachmentChanged(UStaticMeshComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnComponentCollisionSettingsChanged(UStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnComponentDestroyed(UStaticMeshComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnUpdateTransform(UStaticMeshComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PostDuplicate(UStaticMeshComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PutAllRigidBodiesToSleep(UStaticMeshComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_RegisterComponentTickFunctions(UStaticMeshComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ScaleByMomentOfInertia(UStaticMeshComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SendRenderTransform_Concurrent(UStaticMeshComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetAllMassScale(UStaticMeshComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetAllPhysicsAngularVelocity(UStaticMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetAllPhysicsAngularVelocityInRadians(UStaticMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetAllPhysicsLinearVelocity(UStaticMeshComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetAllPhysicsPosition(UStaticMeshComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetAllUseCCD(UStaticMeshComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetAngularDamping(UStaticMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetCollisionObjectType(UStaticMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetCollisionResponseToAllChannels(UStaticMeshComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetCollisionResponseToChannel(UStaticMeshComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetCollisionResponseToChannels(UStaticMeshComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetEnableGravity(UStaticMeshComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetLinearDamping(UStaticMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetMassOverrideInKg(UStaticMeshComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetMassScale(UStaticMeshComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetNotifyRigidBodyCollision(UStaticMeshComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetSimulatePhysics(UStaticMeshComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetUseCCD(UStaticMeshComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ShouldCreatePhysicsState(UStaticMeshComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ShouldRenderSelected(UStaticMeshComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UnWeldChildren(UStaticMeshComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UnWeldFromParent(UStaticMeshComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UpdatePhysicsToRBChannels(UStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UpdatePhysicsVolume(UStaticMeshComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_WakeAllRigidBodies(UStaticMeshComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_WakeRigidBody(UStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_WeldTo(UStaticMeshComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_WeldToImplementation(UStaticMeshComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ApplyWorldOffset(UStaticMeshComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CalcBoundingCylinder(UStaticMeshComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CanAttachAsChild(UStaticMeshComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_DestroyComponent(UStaticMeshComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_DetachFromComponent(UStaticMeshComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_DetachFromParent(UStaticMeshComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetSocketLocation(UStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetSocketQuaternion(UStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetSocketRotation(UStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsAnySimulatingPhysics(UStaticMeshComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsVisible(UStaticMeshComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsVisibleInEditor(UStaticMeshComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnChildAttached(UStaticMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnChildDetached(UStaticMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnHiddenInGameChanged(UStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnVisibilityChanged(UStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PostNetReceive(UStaticMeshComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PostRepNotifies(UStaticMeshComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PreNetReceive(UStaticMeshComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetRelativeScale3D(UStaticMeshComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ShouldCreateRenderState(UStaticMeshComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_Activate(UStaticMeshComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddTickPrerequisiteActor(UStaticMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddTickPrerequisiteComponent(UStaticMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_Deactivate(UStaticMeshComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetComponentClassCanReplicate(UStaticMeshComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetReadableName(UStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_InitializeComponent(UStaticMeshComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsActive(UStaticMeshComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsNameStableForNetworking(UStaticMeshComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsReadyForOwnerToAutoDestroy(UStaticMeshComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsSupportedForNetworking(UStaticMeshComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_MarkAsEditorOnlySubobject(UStaticMeshComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_NeedsLoadForEditorGame(UStaticMeshComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnComponentCreated(UStaticMeshComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PostRename(UStaticMeshComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_RemoveTickPrerequisiteActor(UStaticMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_RemoveTickPrerequisiteComponent(UStaticMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_RequiresGameThreadEndOfFrameRecreate(UStaticMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_RequiresGameThreadEndOfFrameUpdates(UStaticMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SendRenderDynamicData_Concurrent(UStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetActive(UStaticMeshComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetAutoActivate(UStaticMeshComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetComponentTickEnabled(UStaticMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_SetComponentTickEnabledAsync(UStaticMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ShouldActivate(UStaticMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UStaticMeshComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ToggleActive(UStaticMeshComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_UninitializeComponent(UStaticMeshComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CheckDefaultSubobjectsInternal(UStaticMeshComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_GetDesc(UStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsAsset(UStaticMeshComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsFullNameStableForNetworking(UStaticMeshComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsLocalizedResource(UStaticMeshComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsPostLoadThreadSafe(UStaticMeshComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_IsSafeForRootSet(UStaticMeshComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_Modify(UStaticMeshComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PostCDOContruct(UStaticMeshComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PostEditImport(UStaticMeshComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PostSaveRoot(UStaticMeshComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_PreDestroyFromReplication(UStaticMeshComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_ShutdownAfterError(UStaticMeshComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_AddToCluster(UStaticMeshComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CanBeClusterRoot(UStaticMeshComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CanBeInCluster(UStaticMeshComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_CreateCluster(UStaticMeshComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UStaticMeshComponent_OnClusterMarkedAsPendingKill(UStaticMeshComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
