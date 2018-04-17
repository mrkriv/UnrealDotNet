#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/HierarchicalInstancedStaticMeshComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\HierarchicalInstancedStaticMeshComponent.h:60

class E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent : protected UHierarchicalInstancedStaticMeshComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UHierarchicalInstancedStaticMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UHierarchicalInstancedStaticMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AreNativePropertiesIdenticalTo(UHierarchicalInstancedStaticMeshComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_BeginDestroy(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CanEditSimulatePhysics(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_DoesSocketExist(UHierarchicalInstancedStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetDetailedInfoInternal(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetDiffuseBoost(UHierarchicalInstancedStaticMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetEmissiveBoost(UHierarchicalInstancedStaticMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(UHierarchicalInstancedStaticMeshComponent* Self, int32 TextureLightMapMemoryUsage, int32 TextureShadowMapMemoryUsage, int32 VertexLightMapMemoryUsage, int32 VertexShadowMapMemoryUsage, int32 StaticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords)
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

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetEstimatedLightMapResolution(UHierarchicalInstancedStaticMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		Self->GetEstimatedLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetLightAndShadowMapMemoryUsage(UHierarchicalInstancedStaticMeshComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetLightMapResolution(UHierarchicalInstancedStaticMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetMaterialIndex(UHierarchicalInstancedStaticMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->GetMaterialIndex(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetNumMaterials(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetShadowIndirectOnly(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetSocketTransform(UHierarchicalInstancedStaticMeshComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetStaticLightMapResolution(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(UHierarchicalInstancedStaticMeshComponent* Self, int32 InWidth, int32 InHeight, int32 OutLightMapMemoryUsage, int32 OutShadowMapMemoryUsage)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		auto _p2 = OutLightMapMemoryUsage;
		auto _p3 = OutShadowMapMemoryUsage;
		Self->GetTextureLightAndShadowMapMemoryUsage(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetTextureStreamingTransformScale(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetTextureStreamingTransformScale();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_HasAnySockets(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_HasLightmapTextureCoordinates(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->HasLightmapTextureCoordinates();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_HasValidSettingsForStaticLighting(UHierarchicalInstancedStaticMeshComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_InvalidateLightingCacheDetailed(UHierarchicalInstancedStaticMeshComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsMaterialSlotNameValid(UHierarchicalInstancedStaticMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->IsMaterialSlotNameValid(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsNavigationRelevant(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsPrecomputedLightingValid(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_NotifyObjectReferenceEliminated(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnCreatePhysicsState(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnDestroyPhysicsState(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnRegister(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnUnregister(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PostInitProperties(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PostLoad(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PropagateLightingScenarioChange(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetCollisionProfileName(UHierarchicalInstancedStaticMeshComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetStaticLightingMapping(UHierarchicalInstancedStaticMeshComponent* Self, bool bTextureMapping, int32 ResolutionToUse)
	{
		auto _p0 = bTextureMapping;
		auto _p1 = ResolutionToUse;
		return Self->SetStaticLightingMapping(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ShouldCollideWhenPlacing(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ShouldRecreateProxyOnUpdateTransform(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SupportsDefaultCollision(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->SupportsDefaultCollision();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SupportsDitheredLODTransitions(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->SupportsDitheredLODTransitions();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SupportsStaticLighting(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_UsesOnlyUnlitMaterials(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_UsesTextureLightmaps(UHierarchicalInstancedStaticMeshComponent* Self, int32 InWidth, int32 InHeight)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		return Self->UsesTextureLightmaps(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddAngularImpulse(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddAngularImpulseInRadians(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddForce(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddForceAtLocation(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddForceAtLocationLocal(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddImpulse(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddImpulseAtLocation(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddRadialForce(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddRadialImpulse(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AreAllCollideableDescendantsRelative(UHierarchicalInstancedStaticMeshComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AreSymmetricRotations(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_BeginPlay(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CalculateMass(UHierarchicalInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CanCharacterStepUp(UHierarchicalInstancedStaticMeshComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CreateRenderState_Concurrent(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_DestroyRenderState_Concurrent(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_FinishDestroy(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetAngularDamping(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetCollisionObjectType(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetCollisionResponseToChannel(UHierarchicalInstancedStaticMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetComponentVelocity(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetInertiaTensor(UHierarchicalInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetLinearDamping(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetMass(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetMassScale(UHierarchicalInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetNavigationBounds(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetSquaredDistanceToCollision(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetStaticDepthPriorityGroup(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_HasValidPhysicsState(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsAnyRigidBodyAwake(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsEditorOnly(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsGravityEnabled(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsReadyForFinishDestroy(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsSimulatingPhysics(UHierarchicalInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsWorldGeometry(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsZeroExtent(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_MoveComponentImpl(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_NeedsLoadForClient(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_NeedsLoadForServer(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnActorEnableCollisionChanged(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnAttachmentChanged(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnComponentCollisionSettingsChanged(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnComponentDestroyed(UHierarchicalInstancedStaticMeshComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnUpdateTransform(UHierarchicalInstancedStaticMeshComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PostDuplicate(UHierarchicalInstancedStaticMeshComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PutAllRigidBodiesToSleep(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_RegisterComponentTickFunctions(UHierarchicalInstancedStaticMeshComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ScaleByMomentOfInertia(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SendRenderTransform_Concurrent(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetAllMassScale(UHierarchicalInstancedStaticMeshComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetAllPhysicsAngularVelocity(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetAllPhysicsAngularVelocityInRadians(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetAllPhysicsLinearVelocity(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetAllPhysicsPosition(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetAllUseCCD(UHierarchicalInstancedStaticMeshComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetAngularDamping(UHierarchicalInstancedStaticMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetCollisionObjectType(UHierarchicalInstancedStaticMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetCollisionResponseToAllChannels(UHierarchicalInstancedStaticMeshComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetCollisionResponseToChannel(UHierarchicalInstancedStaticMeshComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetCollisionResponseToChannels(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetEnableGravity(UHierarchicalInstancedStaticMeshComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetLinearDamping(UHierarchicalInstancedStaticMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetMassOverrideInKg(UHierarchicalInstancedStaticMeshComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetMassScale(UHierarchicalInstancedStaticMeshComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetNotifyRigidBodyCollision(UHierarchicalInstancedStaticMeshComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetSimulatePhysics(UHierarchicalInstancedStaticMeshComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetUseCCD(UHierarchicalInstancedStaticMeshComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ShouldCreatePhysicsState(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ShouldRenderSelected(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_UnWeldChildren(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_UnWeldFromParent(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_UpdatePhysicsToRBChannels(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_UpdatePhysicsVolume(UHierarchicalInstancedStaticMeshComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_WakeAllRigidBodies(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_WakeRigidBody(UHierarchicalInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_WeldTo(UHierarchicalInstancedStaticMeshComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_WeldToImplementation(UHierarchicalInstancedStaticMeshComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ApplyWorldOffset(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CalcBoundingCylinder(UHierarchicalInstancedStaticMeshComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CanAttachAsChild(UHierarchicalInstancedStaticMeshComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_DestroyComponent(UHierarchicalInstancedStaticMeshComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_DetachFromComponent(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_DetachFromParent(UHierarchicalInstancedStaticMeshComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetSocketLocation(UHierarchicalInstancedStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetSocketQuaternion(UHierarchicalInstancedStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetSocketRotation(UHierarchicalInstancedStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsAnySimulatingPhysics(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsVisible(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsVisibleInEditor(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnChildAttached(UHierarchicalInstancedStaticMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnChildDetached(UHierarchicalInstancedStaticMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnHiddenInGameChanged(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnVisibilityChanged(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PostNetReceive(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PostRepNotifies(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PreNetReceive(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetRelativeScale3D(UHierarchicalInstancedStaticMeshComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ShouldCreateRenderState(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_Activate(UHierarchicalInstancedStaticMeshComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddTickPrerequisiteActor(UHierarchicalInstancedStaticMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddTickPrerequisiteComponent(UHierarchicalInstancedStaticMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_Deactivate(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetComponentClassCanReplicate(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetReadableName(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_InitializeComponent(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsActive(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsNameStableForNetworking(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsReadyForOwnerToAutoDestroy(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsSupportedForNetworking(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_MarkAsEditorOnlySubobject(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_NeedsLoadForEditorGame(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnComponentCreated(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PostRename(UHierarchicalInstancedStaticMeshComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_RemoveTickPrerequisiteActor(UHierarchicalInstancedStaticMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_RemoveTickPrerequisiteComponent(UHierarchicalInstancedStaticMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_RequiresGameThreadEndOfFrameRecreate(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_RequiresGameThreadEndOfFrameUpdates(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SendRenderDynamicData_Concurrent(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetActive(UHierarchicalInstancedStaticMeshComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetAutoActivate(UHierarchicalInstancedStaticMeshComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetComponentTickEnabled(UHierarchicalInstancedStaticMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_SetComponentTickEnabledAsync(UHierarchicalInstancedStaticMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ShouldActivate(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UHierarchicalInstancedStaticMeshComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ToggleActive(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_UninitializeComponent(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CheckDefaultSubobjectsInternal(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_GetDesc(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsAsset(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsFullNameStableForNetworking(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsLocalizedResource(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsPostLoadThreadSafe(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_IsSafeForRootSet(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_Modify(UHierarchicalInstancedStaticMeshComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PostCDOContruct(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PostEditImport(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PostSaveRoot(UHierarchicalInstancedStaticMeshComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_PreDestroyFromReplication(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_ShutdownAfterError(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_AddToCluster(UHierarchicalInstancedStaticMeshComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CanBeClusterRoot(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CanBeInCluster(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_CreateCluster(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UHierarchicalInstancedStaticMeshComponent_OnClusterMarkedAsPendingKill(UHierarchicalInstancedStaticMeshComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
