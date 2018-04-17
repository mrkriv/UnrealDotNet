#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/InstancedStaticMeshComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:74

class E_PROTECTED_WRAP_UInstancedStaticMeshComponent : protected UInstancedStaticMeshComponent
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
	DOTNET_EXPORT auto E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_GET(UInstancedStaticMeshComponent* Ptr) { return Ptr->bPerInstanceRenderDataWasPrebuilt; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_bPerInstanceRenderDataWasPrebuilt_SET(UInstancedStaticMeshComponent* Ptr, bool Value) { Ptr->bPerInstanceRenderDataWasPrebuilt = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInstancedStaticMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInstancedStaticMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AreNativePropertiesIdenticalTo(UInstancedStaticMeshComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_BeginDestroy(UInstancedStaticMeshComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CanEditSimulatePhysics(UInstancedStaticMeshComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_DoesSocketExist(UInstancedStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetDetailedInfoInternal(UInstancedStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetDiffuseBoost(UInstancedStaticMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetEmissiveBoost(UInstancedStaticMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetEstimatedLightAndShadowMapMemoryUsage(UInstancedStaticMeshComponent* Self, int32 TextureLightMapMemoryUsage, int32 TextureShadowMapMemoryUsage, int32 VertexLightMapMemoryUsage, int32 VertexShadowMapMemoryUsage, int32 StaticLightingResolution, bool bIsUsingTextureMapping, bool bHasLightmapTexCoords)
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

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetEstimatedLightMapResolution(UInstancedStaticMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		Self->GetEstimatedLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetLightAndShadowMapMemoryUsage(UInstancedStaticMeshComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetLightMapResolution(UInstancedStaticMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetMaterialIndex(UInstancedStaticMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->GetMaterialIndex(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetNumMaterials(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetShadowIndirectOnly(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetSocketTransform(UInstancedStaticMeshComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetStaticLightMapResolution(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(UInstancedStaticMeshComponent* Self, int32 InWidth, int32 InHeight, int32 OutLightMapMemoryUsage, int32 OutShadowMapMemoryUsage)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		auto _p2 = OutLightMapMemoryUsage;
		auto _p3 = OutShadowMapMemoryUsage;
		Self->GetTextureLightAndShadowMapMemoryUsage(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetTextureStreamingTransformScale(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetTextureStreamingTransformScale();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_HasAnySockets(UInstancedStaticMeshComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_HasLightmapTextureCoordinates(UInstancedStaticMeshComponent* Self)
	{
		return Self->HasLightmapTextureCoordinates();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_HasValidSettingsForStaticLighting(UInstancedStaticMeshComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_InvalidateLightingCacheDetailed(UInstancedStaticMeshComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsMaterialSlotNameValid(UInstancedStaticMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->IsMaterialSlotNameValid(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsNavigationRelevant(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsPrecomputedLightingValid(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_NotifyObjectReferenceEliminated(UInstancedStaticMeshComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnCreatePhysicsState(UInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnDestroyPhysicsState(UInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnRegister(UInstancedStaticMeshComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnUnregister(UInstancedStaticMeshComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PostInitProperties(UInstancedStaticMeshComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PostLoad(UInstancedStaticMeshComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PropagateLightingScenarioChange(UInstancedStaticMeshComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetCollisionProfileName(UInstancedStaticMeshComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetStaticLightingMapping(UInstancedStaticMeshComponent* Self, bool bTextureMapping, int32 ResolutionToUse)
	{
		auto _p0 = bTextureMapping;
		auto _p1 = ResolutionToUse;
		return Self->SetStaticLightingMapping(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ShouldCollideWhenPlacing(UInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ShouldRecreateProxyOnUpdateTransform(UInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SupportsDefaultCollision(UInstancedStaticMeshComponent* Self)
	{
		return Self->SupportsDefaultCollision();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SupportsDitheredLODTransitions(UInstancedStaticMeshComponent* Self)
	{
		return Self->SupportsDitheredLODTransitions();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SupportsStaticLighting(UInstancedStaticMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_UsesOnlyUnlitMaterials(UInstancedStaticMeshComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_UsesTextureLightmaps(UInstancedStaticMeshComponent* Self, int32 InWidth, int32 InHeight)
	{
		auto _p0 = InWidth;
		auto _p1 = InHeight;
		return Self->UsesTextureLightmaps(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddAngularImpulse(UInstancedStaticMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddAngularImpulseInRadians(UInstancedStaticMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddForce(UInstancedStaticMeshComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddForceAtLocation(UInstancedStaticMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddForceAtLocationLocal(UInstancedStaticMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddImpulse(UInstancedStaticMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddImpulseAtLocation(UInstancedStaticMeshComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddRadialForce(UInstancedStaticMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddRadialImpulse(UInstancedStaticMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AreAllCollideableDescendantsRelative(UInstancedStaticMeshComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AreSymmetricRotations(UInstancedStaticMeshComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_BeginPlay(UInstancedStaticMeshComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CalculateMass(UInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CanCharacterStepUp(UInstancedStaticMeshComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CreateRenderState_Concurrent(UInstancedStaticMeshComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_DestroyRenderState_Concurrent(UInstancedStaticMeshComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_FinishDestroy(UInstancedStaticMeshComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetAngularDamping(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetCollisionObjectType(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetCollisionResponseToChannel(UInstancedStaticMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetComponentVelocity(UInstancedStaticMeshComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetInertiaTensor(UInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetLinearDamping(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetMass(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetMassScale(UInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetNavigationBounds(UInstancedStaticMeshComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetSquaredDistanceToCollision(UInstancedStaticMeshComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetStaticDepthPriorityGroup(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_HasValidPhysicsState(UInstancedStaticMeshComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsAnyRigidBodyAwake(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsEditorOnly(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsGravityEnabled(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsReadyForFinishDestroy(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsSimulatingPhysics(UInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsWorldGeometry(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsZeroExtent(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_MoveComponentImpl(UInstancedStaticMeshComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_NeedsLoadForClient(UInstancedStaticMeshComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_NeedsLoadForServer(UInstancedStaticMeshComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnActorEnableCollisionChanged(UInstancedStaticMeshComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnAttachmentChanged(UInstancedStaticMeshComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnComponentCollisionSettingsChanged(UInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnComponentDestroyed(UInstancedStaticMeshComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnUpdateTransform(UInstancedStaticMeshComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PostDuplicate(UInstancedStaticMeshComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PutAllRigidBodiesToSleep(UInstancedStaticMeshComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_RegisterComponentTickFunctions(UInstancedStaticMeshComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ScaleByMomentOfInertia(UInstancedStaticMeshComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SendRenderTransform_Concurrent(UInstancedStaticMeshComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetAllMassScale(UInstancedStaticMeshComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetAllPhysicsAngularVelocity(UInstancedStaticMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetAllPhysicsAngularVelocityInRadians(UInstancedStaticMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetAllPhysicsLinearVelocity(UInstancedStaticMeshComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetAllPhysicsPosition(UInstancedStaticMeshComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetAllUseCCD(UInstancedStaticMeshComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetAngularDamping(UInstancedStaticMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetCollisionObjectType(UInstancedStaticMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetCollisionResponseToAllChannels(UInstancedStaticMeshComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetCollisionResponseToChannel(UInstancedStaticMeshComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetCollisionResponseToChannels(UInstancedStaticMeshComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetEnableGravity(UInstancedStaticMeshComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetLinearDamping(UInstancedStaticMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetMassOverrideInKg(UInstancedStaticMeshComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetMassScale(UInstancedStaticMeshComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetNotifyRigidBodyCollision(UInstancedStaticMeshComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetSimulatePhysics(UInstancedStaticMeshComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetUseCCD(UInstancedStaticMeshComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ShouldCreatePhysicsState(UInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ShouldRenderSelected(UInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_UnWeldChildren(UInstancedStaticMeshComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_UnWeldFromParent(UInstancedStaticMeshComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_UpdatePhysicsToRBChannels(UInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_UpdatePhysicsVolume(UInstancedStaticMeshComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_WakeAllRigidBodies(UInstancedStaticMeshComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_WakeRigidBody(UInstancedStaticMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_WeldTo(UInstancedStaticMeshComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_WeldToImplementation(UInstancedStaticMeshComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ApplyWorldOffset(UInstancedStaticMeshComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CalcBoundingCylinder(UInstancedStaticMeshComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CanAttachAsChild(UInstancedStaticMeshComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_DestroyComponent(UInstancedStaticMeshComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_DetachFromComponent(UInstancedStaticMeshComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_DetachFromParent(UInstancedStaticMeshComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetSocketLocation(UInstancedStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetSocketQuaternion(UInstancedStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetSocketRotation(UInstancedStaticMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsAnySimulatingPhysics(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsVisible(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsVisibleInEditor(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnChildAttached(UInstancedStaticMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnChildDetached(UInstancedStaticMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnHiddenInGameChanged(UInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnVisibilityChanged(UInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PostNetReceive(UInstancedStaticMeshComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PostRepNotifies(UInstancedStaticMeshComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PreNetReceive(UInstancedStaticMeshComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetRelativeScale3D(UInstancedStaticMeshComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ShouldCreateRenderState(UInstancedStaticMeshComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_Activate(UInstancedStaticMeshComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddTickPrerequisiteActor(UInstancedStaticMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddTickPrerequisiteComponent(UInstancedStaticMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_Deactivate(UInstancedStaticMeshComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetComponentClassCanReplicate(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetReadableName(UInstancedStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_InitializeComponent(UInstancedStaticMeshComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsActive(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsNameStableForNetworking(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsReadyForOwnerToAutoDestroy(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsSupportedForNetworking(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_MarkAsEditorOnlySubobject(UInstancedStaticMeshComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_NeedsLoadForEditorGame(UInstancedStaticMeshComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnComponentCreated(UInstancedStaticMeshComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PostRename(UInstancedStaticMeshComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_RemoveTickPrerequisiteActor(UInstancedStaticMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_RemoveTickPrerequisiteComponent(UInstancedStaticMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_RequiresGameThreadEndOfFrameRecreate(UInstancedStaticMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_RequiresGameThreadEndOfFrameUpdates(UInstancedStaticMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SendRenderDynamicData_Concurrent(UInstancedStaticMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetActive(UInstancedStaticMeshComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetAutoActivate(UInstancedStaticMeshComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetComponentTickEnabled(UInstancedStaticMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetComponentTickEnabledAsync(UInstancedStaticMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ShouldActivate(UInstancedStaticMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UInstancedStaticMeshComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ToggleActive(UInstancedStaticMeshComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_UninitializeComponent(UInstancedStaticMeshComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CheckDefaultSubobjectsInternal(UInstancedStaticMeshComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetDesc(UInstancedStaticMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsAsset(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsFullNameStableForNetworking(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsLocalizedResource(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsPostLoadThreadSafe(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_IsSafeForRootSet(UInstancedStaticMeshComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_Modify(UInstancedStaticMeshComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PostCDOContruct(UInstancedStaticMeshComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PostEditImport(UInstancedStaticMeshComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PostSaveRoot(UInstancedStaticMeshComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PreDestroyFromReplication(UInstancedStaticMeshComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ShutdownAfterError(UInstancedStaticMeshComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddToCluster(UInstancedStaticMeshComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CanBeClusterRoot(UInstancedStaticMeshComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CanBeInCluster(UInstancedStaticMeshComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_CreateCluster(UInstancedStaticMeshComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_OnClusterMarkedAsPendingKill(UInstancedStaticMeshComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
