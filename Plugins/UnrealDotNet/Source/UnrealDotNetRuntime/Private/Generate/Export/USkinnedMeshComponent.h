#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SkinnedMeshComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:182

class E_PROTECTED_WRAP_USkinnedMeshComponent : protected USkinnedMeshComponent
{
public:
	void SendRenderDynamicData_Concurrent_WRAP()
	{
		SendRenderDynamicData_Concurrent();
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

	bool ShouldActivate_WRAP()
	{
		return ShouldActivate();
	}

}
;

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bCanHighlightSelectedSections_GET(USkinnedMeshComponent* Ptr) { return Ptr->bCanHighlightSelectedSections; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bCanHighlightSelectedSections_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bCanHighlightSelectedSections = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bCastCapsuleDirectShadow_GET(USkinnedMeshComponent* Ptr) { return Ptr->bCastCapsuleDirectShadow; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bCastCapsuleDirectShadow_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bCastCapsuleDirectShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bCastCapsuleIndirectShadow_GET(USkinnedMeshComponent* Ptr) { return Ptr->bCastCapsuleIndirectShadow; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bCastCapsuleIndirectShadow_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bCastCapsuleIndirectShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bComponentUseFixedSkelBounds_GET(USkinnedMeshComponent* Ptr) { return Ptr->bComponentUseFixedSkelBounds; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bComponentUseFixedSkelBounds_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bComponentUseFixedSkelBounds = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bConsiderAllBodiesForBounds_GET(USkinnedMeshComponent* Ptr) { return Ptr->bConsiderAllBodiesForBounds; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bConsiderAllBodiesForBounds_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bConsiderAllBodiesForBounds = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bCPUSkinning_GET(USkinnedMeshComponent* Ptr) { return Ptr->bCPUSkinning; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bCPUSkinning_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bCPUSkinning = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bDisableMorphTarget_GET(USkinnedMeshComponent* Ptr) { return Ptr->bDisableMorphTarget; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bDisableMorphTarget_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bDisableMorphTarget = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bDisplayBones_DEPRECATED_GET(USkinnedMeshComponent* Ptr) { return Ptr->bDisplayBones_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bDisplayBones_DEPRECATED_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bDisplayBones_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bDisplayDebugUpdateRateOptimizations_GET(USkinnedMeshComponent* Ptr) { return Ptr->bDisplayDebugUpdateRateOptimizations; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bDisplayDebugUpdateRateOptimizations_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bDisplayDebugUpdateRateOptimizations = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bEnableUpdateRateOptimizations_GET(USkinnedMeshComponent* Ptr) { return Ptr->bEnableUpdateRateOptimizations; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bEnableUpdateRateOptimizations_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bEnableUpdateRateOptimizations = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bForceWireframe_GET(USkinnedMeshComponent* Ptr) { return Ptr->bForceWireframe; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bForceWireframe_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bForceWireframe = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bHideSkin_GET(USkinnedMeshComponent* Ptr) { return Ptr->bHideSkin; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bHideSkin_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bHideSkin = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bPerBoneMotionBlur_GET(USkinnedMeshComponent* Ptr) { return Ptr->bPerBoneMotionBlur; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bPerBoneMotionBlur_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bPerBoneMotionBlur = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bRecentlyRendered_GET(USkinnedMeshComponent* Ptr) { return Ptr->bRecentlyRendered; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bRecentlyRendered_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bRecentlyRendered = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_bUseBoundsFromMasterPoseComponent_GET(USkinnedMeshComponent* Ptr) { return Ptr->bUseBoundsFromMasterPoseComponent; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_bUseBoundsFromMasterPoseComponent_SET(USkinnedMeshComponent* Ptr, uint8 Value) { Ptr->bUseBoundsFromMasterPoseComponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_GET(USkinnedMeshComponent* Ptr) { return Ptr->CapsuleIndirectShadowMinVisibility; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_SET(USkinnedMeshComponent* Ptr, float Value) { Ptr->CapsuleIndirectShadowMinVisibility = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_ForcedLodModel_GET(USkinnedMeshComponent* Ptr) { return Ptr->ForcedLodModel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_ForcedLodModel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->ForcedLodModel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_MaxDistanceFactor_GET(USkinnedMeshComponent* Ptr) { return Ptr->MaxDistanceFactor; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_MaxDistanceFactor_SET(USkinnedMeshComponent* Ptr, float Value) { Ptr->MaxDistanceFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_MinLodModel_GET(USkinnedMeshComponent* Ptr) { return Ptr->MinLodModel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_MinLodModel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->MinLodModel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_GET(USkinnedMeshComponent* Ptr) { return Ptr->OldPredictedLODLevel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->OldPredictedLODLevel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_PredictedLODLevel_GET(USkinnedMeshComponent* Ptr) { return Ptr->PredictedLODLevel; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_PredictedLODLevel_SET(USkinnedMeshComponent* Ptr, int32 Value) { Ptr->PredictedLODLevel = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_GET(USkinnedMeshComponent* Ptr) { return Ptr->StreamingDistanceMultiplier; }
	DOTNET_EXPORT void E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_SET(USkinnedMeshComponent* Ptr, float Value) { Ptr->StreamingDistanceMultiplier = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USkinnedMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USkinnedMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_BeginDestroy(USkinnedMeshComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ClearRefPoseOverride(USkinnedMeshComponent* Self)
	{
		Self->ClearRefPoseOverride();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ClearSkinWeightOverride(USkinnedMeshComponent* Self, int32 LODIndex)
	{
		auto _p0 = LODIndex;
		Self->ClearSkinWeightOverride(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ClearVertexColorOverride(USkinnedMeshComponent* Self, int32 LODIndex)
	{
		auto _p0 = LODIndex;
		Self->ClearVertexColorOverride(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CreateRenderState_Concurrent(USkinnedMeshComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_DestroyRenderState_Concurrent(USkinnedMeshComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_DoesSocketExist(USkinnedMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetBoneIndex(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetBoneIndex(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetBoneName(USkinnedMeshComponent* Self, int32 BoneIndex)
	{
		auto _p0 = BoneIndex;
		return ConvertToManage_StringWrapper(Self->GetBoneName(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetDetailedInfoInternal(USkinnedMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetMaterialIndex(USkinnedMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->GetMaterialIndex(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetNumBones(USkinnedMeshComponent* Self)
	{
		return Self->GetNumBones();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetNumLODs(USkinnedMeshComponent* Self)
	{
		return Self->GetNumLODs();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetNumMaterials(USkinnedMeshComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetParentBone(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return ConvertToManage_StringWrapper(Self->GetParentBone(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetSocketBoneName(USkinnedMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return ConvertToManage_StringWrapper(Self->GetSocketBoneName(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetSocketTransform(USkinnedMeshComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_HasAnySockets(USkinnedMeshComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsMaterialSlotNameValid(USkinnedMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->IsMaterialSlotNameValid(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnRegister(USkinnedMeshComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnUnregister(USkinnedMeshComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_RequiresGameThreadEndOfFrameRecreate(USkinnedMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SendRenderDynamicData_Concurrent(USkinnedMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCapsuleIndirectShadowMinVisibility(USkinnedMeshComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetCapsuleIndirectShadowMinVisibility(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCastCapsuleDirectShadow(USkinnedMeshComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastCapsuleDirectShadow(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCastCapsuleIndirectShadow(USkinnedMeshComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastCapsuleIndirectShadow(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetForcedLOD(USkinnedMeshComponent* Self, int32 InNewForcedLOD)
	{
		auto _p0 = InNewForcedLOD;
		Self->SetForcedLOD(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetForceWireframe(USkinnedMeshComponent* Self, bool InForceWireframe)
	{
		auto _p0 = InForceWireframe;
		Self->SetForceWireframe(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetMinLOD(USkinnedMeshComponent* Self, int32 InNewMinLOD)
	{
		auto _p0 = InNewMinLOD;
		Self->SetMinLOD(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShouldCPUSkin(USkinnedMeshComponent* Self)
	{
		return Self->ShouldCPUSkin();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddAngularImpulse(USkinnedMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddAngularImpulseInRadians(USkinnedMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddForce(USkinnedMeshComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddForceAtLocation(USkinnedMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddForceAtLocationLocal(USkinnedMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddImpulse(USkinnedMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddImpulseAtLocation(USkinnedMeshComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddRadialForce(USkinnedMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddRadialImpulse(USkinnedMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AreAllCollideableDescendantsRelative(USkinnedMeshComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AreSymmetricRotations(USkinnedMeshComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_BeginPlay(USkinnedMeshComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CalculateMass(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CanCharacterStepUp(USkinnedMeshComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CanEditSimulatePhysics(USkinnedMeshComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_FinishDestroy(USkinnedMeshComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetAngularDamping(USkinnedMeshComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetCollisionObjectType(USkinnedMeshComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetCollisionResponseToChannel(USkinnedMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetComponentVelocity(USkinnedMeshComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetDiffuseBoost(USkinnedMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetEmissiveBoost(USkinnedMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetInertiaTensor(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetLightAndShadowMapMemoryUsage(USkinnedMeshComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetLightMapResolution(USkinnedMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetLinearDamping(USkinnedMeshComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetMass(USkinnedMeshComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetMassScale(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetNavigationBounds(USkinnedMeshComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetShadowIndirectOnly(USkinnedMeshComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetSquaredDistanceToCollision(USkinnedMeshComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetStaticDepthPriorityGroup(USkinnedMeshComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetStaticLightMapResolution(USkinnedMeshComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_HasValidPhysicsState(USkinnedMeshComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_HasValidSettingsForStaticLighting(USkinnedMeshComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_InvalidateLightingCacheDetailed(USkinnedMeshComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsAnyRigidBodyAwake(USkinnedMeshComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsEditorOnly(USkinnedMeshComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsGravityEnabled(USkinnedMeshComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsNavigationRelevant(USkinnedMeshComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsReadyForFinishDestroy(USkinnedMeshComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsSimulatingPhysics(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsWorldGeometry(USkinnedMeshComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsZeroExtent(USkinnedMeshComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_MoveComponentImpl(USkinnedMeshComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_NeedsLoadForClient(USkinnedMeshComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_NeedsLoadForServer(USkinnedMeshComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnActorEnableCollisionChanged(USkinnedMeshComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnAttachmentChanged(USkinnedMeshComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnComponentCollisionSettingsChanged(USkinnedMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnComponentDestroyed(USkinnedMeshComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnCreatePhysicsState(USkinnedMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnDestroyPhysicsState(USkinnedMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnUpdateTransform(USkinnedMeshComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PostDuplicate(USkinnedMeshComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PostLoad(USkinnedMeshComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PutAllRigidBodiesToSleep(USkinnedMeshComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_RegisterComponentTickFunctions(USkinnedMeshComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ScaleByMomentOfInertia(USkinnedMeshComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SendRenderTransform_Concurrent(USkinnedMeshComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetAllMassScale(USkinnedMeshComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetAllPhysicsAngularVelocity(USkinnedMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetAllPhysicsAngularVelocityInRadians(USkinnedMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetAllPhysicsLinearVelocity(USkinnedMeshComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetAllPhysicsPosition(USkinnedMeshComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetAllUseCCD(USkinnedMeshComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetAngularDamping(USkinnedMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCollisionObjectType(USkinnedMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCollisionProfileName(USkinnedMeshComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCollisionResponseToAllChannels(USkinnedMeshComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCollisionResponseToChannel(USkinnedMeshComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetCollisionResponseToChannels(USkinnedMeshComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetEnableGravity(USkinnedMeshComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetLinearDamping(USkinnedMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetMassOverrideInKg(USkinnedMeshComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetMassScale(USkinnedMeshComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetNotifyRigidBodyCollision(USkinnedMeshComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetSimulatePhysics(USkinnedMeshComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetUseCCD(USkinnedMeshComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShouldCreatePhysicsState(USkinnedMeshComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShouldRecreateProxyOnUpdateTransform(USkinnedMeshComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShouldRenderSelected(USkinnedMeshComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SupportsStaticLighting(USkinnedMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_UnWeldChildren(USkinnedMeshComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_UnWeldFromParent(USkinnedMeshComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_UpdatePhysicsToRBChannels(USkinnedMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_UpdatePhysicsVolume(USkinnedMeshComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_UsesOnlyUnlitMaterials(USkinnedMeshComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_WakeAllRigidBodies(USkinnedMeshComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_WakeRigidBody(USkinnedMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_WeldTo(USkinnedMeshComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_WeldToImplementation(USkinnedMeshComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ApplyWorldOffset(USkinnedMeshComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CalcBoundingCylinder(USkinnedMeshComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CanAttachAsChild(USkinnedMeshComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_DestroyComponent(USkinnedMeshComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_DetachFromComponent(USkinnedMeshComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_DetachFromParent(USkinnedMeshComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetSocketLocation(USkinnedMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetSocketQuaternion(USkinnedMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetSocketRotation(USkinnedMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsAnySimulatingPhysics(USkinnedMeshComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsPrecomputedLightingValid(USkinnedMeshComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsVisible(USkinnedMeshComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsVisibleInEditor(USkinnedMeshComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnChildAttached(USkinnedMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnChildDetached(USkinnedMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnHiddenInGameChanged(USkinnedMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnVisibilityChanged(USkinnedMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PostNetReceive(USkinnedMeshComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PostRepNotifies(USkinnedMeshComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PreNetReceive(USkinnedMeshComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PropagateLightingScenarioChange(USkinnedMeshComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetRelativeScale3D(USkinnedMeshComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShouldCollideWhenPlacing(USkinnedMeshComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShouldCreateRenderState(USkinnedMeshComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_Activate(USkinnedMeshComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddTickPrerequisiteActor(USkinnedMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddTickPrerequisiteComponent(USkinnedMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_Deactivate(USkinnedMeshComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetComponentClassCanReplicate(USkinnedMeshComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetReadableName(USkinnedMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_InitializeComponent(USkinnedMeshComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsActive(USkinnedMeshComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsNameStableForNetworking(USkinnedMeshComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsReadyForOwnerToAutoDestroy(USkinnedMeshComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsSupportedForNetworking(USkinnedMeshComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_MarkAsEditorOnlySubobject(USkinnedMeshComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_NeedsLoadForEditorGame(USkinnedMeshComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnComponentCreated(USkinnedMeshComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PostInitProperties(USkinnedMeshComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PostRename(USkinnedMeshComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_RemoveTickPrerequisiteActor(USkinnedMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_RemoveTickPrerequisiteComponent(USkinnedMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_RequiresGameThreadEndOfFrameUpdates(USkinnedMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetActive(USkinnedMeshComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetAutoActivate(USkinnedMeshComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetComponentTickEnabled(USkinnedMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_SetComponentTickEnabledAsync(USkinnedMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShouldActivate(USkinnedMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USkinnedMeshComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ToggleActive(USkinnedMeshComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_UninitializeComponent(USkinnedMeshComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AreNativePropertiesIdenticalTo(USkinnedMeshComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CheckDefaultSubobjectsInternal(USkinnedMeshComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_GetDesc(USkinnedMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsAsset(USkinnedMeshComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsFullNameStableForNetworking(USkinnedMeshComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsLocalizedResource(USkinnedMeshComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsPostLoadThreadSafe(USkinnedMeshComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_IsSafeForRootSet(USkinnedMeshComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_Modify(USkinnedMeshComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_NotifyObjectReferenceEliminated(USkinnedMeshComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PostCDOContruct(USkinnedMeshComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PostEditImport(USkinnedMeshComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PostSaveRoot(USkinnedMeshComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_PreDestroyFromReplication(USkinnedMeshComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_ShutdownAfterError(USkinnedMeshComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_AddToCluster(USkinnedMeshComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CanBeClusterRoot(USkinnedMeshComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CanBeInCluster(USkinnedMeshComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_CreateCluster(USkinnedMeshComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USkinnedMeshComponent_OnClusterMarkedAsPendingKill(USkinnedMeshComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
