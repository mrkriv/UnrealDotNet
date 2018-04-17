#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SkeletalMeshComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:254

class E_PROTECTED_WRAP_USkeletalMeshComponent : protected USkeletalMeshComponent
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
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bAnimTreeInitialised_GET(USkeletalMeshComponent* Ptr) { return Ptr->bAnimTreeInitialised; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bAnimTreeInitialised_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bAnimTreeInitialised = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bBlendPhysics_GET(USkeletalMeshComponent* Ptr) { return Ptr->bBlendPhysics; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bBlendPhysics_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bBlendPhysics = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_GET(USkeletalMeshComponent* Ptr) { return Ptr->bCollideWithAttachedChildren; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bCollideWithAttachedChildren = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_GET(USkeletalMeshComponent* Ptr) { return Ptr->bCollideWithEnvironment; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bCollideWithEnvironment = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bDeferMovementFromSceneQueries_GET(USkeletalMeshComponent* Ptr) { return Ptr->bDeferMovementFromSceneQueries; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bDeferMovementFromSceneQueries_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bDeferMovementFromSceneQueries = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bDeferredKinematicUpdate_GET(USkeletalMeshComponent* Ptr) { return Ptr->bDeferredKinematicUpdate; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bDeferredKinematicUpdate_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bDeferredKinematicUpdate = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bDisableClothSimulation_GET(USkeletalMeshComponent* Ptr) { return Ptr->bDisableClothSimulation; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bDisableClothSimulation_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bDisableClothSimulation = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bEnableLineCheckWithBounds_GET(USkeletalMeshComponent* Ptr) { return Ptr->bEnableLineCheckWithBounds; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bEnableLineCheckWithBounds_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bEnableLineCheckWithBounds = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bEnablePerPolyCollision_GET(USkeletalMeshComponent* Ptr) { return Ptr->bEnablePerPolyCollision; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bEnablePerPolyCollision_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bEnablePerPolyCollision = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bEnablePhysicsOnDedicatedServer_GET(USkeletalMeshComponent* Ptr) { return Ptr->bEnablePhysicsOnDedicatedServer; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bEnablePhysicsOnDedicatedServer_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bEnablePhysicsOnDedicatedServer = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bForceRefpose_GET(USkeletalMeshComponent* Ptr) { return Ptr->bForceRefpose; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bForceRefpose_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bForceRefpose = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bHasValidBodies_GET(USkeletalMeshComponent* Ptr) { return Ptr->bHasValidBodies; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bHasValidBodies_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bHasValidBodies = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bIncludeComponentLocationIntoBounds_GET(USkeletalMeshComponent* Ptr) { return Ptr->bIncludeComponentLocationIntoBounds; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bIncludeComponentLocationIntoBounds_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bIncludeComponentLocationIntoBounds = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bIsAutonomousTickPose_GET(USkeletalMeshComponent* Ptr) { return Ptr->bIsAutonomousTickPose; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bIsAutonomousTickPose_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bIsAutonomousTickPose = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_GET(USkeletalMeshComponent* Ptr) { return Ptr->bLocalSpaceKinematics; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bLocalSpaceKinematics = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bLocalSpaceSimulation_GET(USkeletalMeshComponent* Ptr) { return Ptr->bLocalSpaceSimulation; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bLocalSpaceSimulation_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bLocalSpaceSimulation = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bNoSkeletonUpdate_GET(USkeletalMeshComponent* Ptr) { return Ptr->bNoSkeletonUpdate; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bNoSkeletonUpdate_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bNoSkeletonUpdate = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bOldForceRefPose_GET(USkeletalMeshComponent* Ptr) { return Ptr->bOldForceRefPose; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bOldForceRefPose_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bOldForceRefPose = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bOnlyAllowAutonomousTickPose_GET(USkeletalMeshComponent* Ptr) { return Ptr->bOnlyAllowAutonomousTickPose; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bOnlyAllowAutonomousTickPose_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bOnlyAllowAutonomousTickPose = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bPauseAnims_GET(USkeletalMeshComponent* Ptr) { return Ptr->bPauseAnims; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bPauseAnims_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bPauseAnims = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bPrevDisableClothSimulation_GET(USkeletalMeshComponent* Ptr) { return Ptr->bPrevDisableClothSimulation; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bPrevDisableClothSimulation_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bPrevDisableClothSimulation = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bRequiredBonesUpToDate_GET(USkeletalMeshComponent* Ptr) { return Ptr->bRequiredBonesUpToDate; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bRequiredBonesUpToDate_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bRequiredBonesUpToDate = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bResetAfterTeleport_GET(USkeletalMeshComponent* Ptr) { return Ptr->bResetAfterTeleport; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bResetAfterTeleport_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bResetAfterTeleport = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bShowPrePhysBones_GET(USkeletalMeshComponent* Ptr) { return Ptr->bShowPrePhysBones; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bShowPrePhysBones_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bShowPrePhysBones = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUpdateJointsFromAnimation; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUpdateJointsFromAnimation = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUseRefPoseOnInitAnim; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUseRefPoseOnInitAnim = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_ClothBlendWeight_GET(USkeletalMeshComponent* Ptr) { return Ptr->ClothBlendWeight; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_ClothBlendWeight_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->ClothBlendWeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_GET(USkeletalMeshComponent* Ptr) { return Ptr->ClothMaxDistanceScale; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->ClothMaxDistanceScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_GET(USkeletalMeshComponent* Ptr) { return Ptr->GlobalAnimRateScale; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->GlobalAnimRateScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_GET(USkeletalMeshComponent* Ptr) { return (INT_PTR)&(Ptr->LineCheckBoundsScale); }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_SET(USkeletalMeshComponent* Ptr, INT_PTR Value) { Ptr->LineCheckBoundsScale = *(FVector*)Value; }
	
	DOTNET_EXPORT void E_EVENT_ADD_USkeletalMeshComponent_OnConstraintBroken(USkeletalMeshComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnConstraintBroken";
		wrapper->SourceObject = Obj;
		Obj->OnConstraintBroken.AddDynamic(wrapper, &UManageEventSender::Wrapper_FConstraintBrokenSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_USkeletalMeshComponent_OnConstraintBroken(USkeletalMeshComponent* Obj)
	{
	}

	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_GET(USkeletalMeshComponent* Ptr) { return Ptr->RagdollAggregateThreshold; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_SET(USkeletalMeshComponent* Ptr, int32 Value) { Ptr->RagdollAggregateThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_RootBoneTranslation_GET(USkeletalMeshComponent* Ptr) { return (INT_PTR)&(Ptr->RootBoneTranslation); }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_RootBoneTranslation_SET(USkeletalMeshComponent* Ptr, INT_PTR Value) { Ptr->RootBoneTranslation = *(FVector*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USkeletalMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USkeletalMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ClearMorphTargets(USkeletalMeshComponent* Self)
	{
		Self->ClearMorphTargets();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CreateBodySetup(USkeletalMeshComponent* Self)
	{
		Self->CreateBodySetup();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetDisablePostProcessBlueprint(USkeletalMeshComponent* Self)
	{
		return Self->GetDisablePostProcessBlueprint();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetMorphTarget(USkeletalMeshComponent* Self, char* MorphTargetName)
	{
		auto _p0 = ConvertFromManage_FName(MorphTargetName);
		return Self->GetMorphTarget(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetPlayRate(USkeletalMeshComponent* Self)
	{
		return Self->GetPlayRate();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetPosition(USkeletalMeshComponent* Self)
	{
		return Self->GetPosition();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsPlaying(USkeletalMeshComponent* Self)
	{
		return Self->IsPlaying();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_Play(USkeletalMeshComponent* Self, bool bLooping)
	{
		auto _p0 = bLooping;
		Self->Play(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetDisablePostProcessBlueprint(USkeletalMeshComponent* Self, bool bInDisablePostProcess)
	{
		auto _p0 = bInDisablePostProcess;
		Self->SetDisablePostProcessBlueprint(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetMorphTarget(USkeletalMeshComponent* Self, char* MorphTargetName, float Value, bool bRemoveZeroWeight)
	{
		auto _p0 = ConvertFromManage_FName(MorphTargetName);
		auto _p1 = Value;
		auto _p2 = bRemoveZeroWeight;
		Self->SetMorphTarget(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetPlayRate(USkeletalMeshComponent* Self, float Rate)
	{
		auto _p0 = Rate;
		Self->SetPlayRate(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetPosition(USkeletalMeshComponent* Self, float InPos, bool bFireNotifies)
	{
		auto _p0 = InPos;
		auto _p1 = bFireNotifies;
		Self->SetPosition(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_Stop(USkeletalMeshComponent* Self)
	{
		Self->Stop();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ToggleDisablePostProcessBlueprint(USkeletalMeshComponent* Self)
	{
		Self->ToggleDisablePostProcessBlueprint();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_BeginDestroy(USkeletalMeshComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ClearRefPoseOverride(USkeletalMeshComponent* Self)
	{
		Self->ClearRefPoseOverride();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CreateRenderState_Concurrent(USkeletalMeshComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_DestroyRenderState_Concurrent(USkeletalMeshComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_DoesSocketExist(USkeletalMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetDetailedInfoInternal(USkeletalMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetMaterialIndex(USkeletalMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->GetMaterialIndex(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetNumMaterials(USkeletalMeshComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetSocketTransform(USkeletalMeshComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_HasAnySockets(USkeletalMeshComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsMaterialSlotNameValid(USkeletalMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->IsMaterialSlotNameValid(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnRegister(USkeletalMeshComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnUnregister(USkeletalMeshComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_RequiresGameThreadEndOfFrameRecreate(USkeletalMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SendRenderDynamicData_Concurrent(USkeletalMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ShouldCPUSkin(USkeletalMeshComponent* Self)
	{
		return Self->ShouldCPUSkin();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddAngularImpulse(USkeletalMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddAngularImpulseInRadians(USkeletalMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddForce(USkeletalMeshComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddForceAtLocation(USkeletalMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddForceAtLocationLocal(USkeletalMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddImpulse(USkeletalMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddImpulseAtLocation(USkeletalMeshComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddRadialForce(USkeletalMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddRadialImpulse(USkeletalMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AreAllCollideableDescendantsRelative(USkeletalMeshComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AreSymmetricRotations(USkeletalMeshComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_BeginPlay(USkeletalMeshComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CalculateMass(USkeletalMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CanCharacterStepUp(USkeletalMeshComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CanEditSimulatePhysics(USkeletalMeshComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_FinishDestroy(USkeletalMeshComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetAngularDamping(USkeletalMeshComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetCollisionObjectType(USkeletalMeshComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetCollisionResponseToChannel(USkeletalMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetComponentVelocity(USkeletalMeshComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetDiffuseBoost(USkeletalMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetEmissiveBoost(USkeletalMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetInertiaTensor(USkeletalMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetLightAndShadowMapMemoryUsage(USkeletalMeshComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetLightMapResolution(USkeletalMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetLinearDamping(USkeletalMeshComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetMass(USkeletalMeshComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetMassScale(USkeletalMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetNavigationBounds(USkeletalMeshComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetShadowIndirectOnly(USkeletalMeshComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetSquaredDistanceToCollision(USkeletalMeshComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetStaticDepthPriorityGroup(USkeletalMeshComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetStaticLightMapResolution(USkeletalMeshComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_HasValidPhysicsState(USkeletalMeshComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_HasValidSettingsForStaticLighting(USkeletalMeshComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_InvalidateLightingCacheDetailed(USkeletalMeshComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsAnyRigidBodyAwake(USkeletalMeshComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsEditorOnly(USkeletalMeshComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsGravityEnabled(USkeletalMeshComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsNavigationRelevant(USkeletalMeshComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsReadyForFinishDestroy(USkeletalMeshComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsSimulatingPhysics(USkeletalMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsWorldGeometry(USkeletalMeshComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsZeroExtent(USkeletalMeshComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_MoveComponentImpl(USkeletalMeshComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_NeedsLoadForClient(USkeletalMeshComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_NeedsLoadForServer(USkeletalMeshComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnActorEnableCollisionChanged(USkeletalMeshComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnAttachmentChanged(USkeletalMeshComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnComponentCollisionSettingsChanged(USkeletalMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnComponentDestroyed(USkeletalMeshComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnCreatePhysicsState(USkeletalMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnDestroyPhysicsState(USkeletalMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnUpdateTransform(USkeletalMeshComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PostDuplicate(USkeletalMeshComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PostLoad(USkeletalMeshComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PutAllRigidBodiesToSleep(USkeletalMeshComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_RegisterComponentTickFunctions(USkeletalMeshComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ScaleByMomentOfInertia(USkeletalMeshComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SendRenderTransform_Concurrent(USkeletalMeshComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetAllMassScale(USkeletalMeshComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetAllPhysicsAngularVelocity(USkeletalMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetAllPhysicsAngularVelocityInRadians(USkeletalMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetAllPhysicsLinearVelocity(USkeletalMeshComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetAllPhysicsPosition(USkeletalMeshComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetAllUseCCD(USkeletalMeshComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetAngularDamping(USkeletalMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetCollisionObjectType(USkeletalMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetCollisionProfileName(USkeletalMeshComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetCollisionResponseToAllChannels(USkeletalMeshComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetCollisionResponseToChannel(USkeletalMeshComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetCollisionResponseToChannels(USkeletalMeshComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetEnableGravity(USkeletalMeshComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetLinearDamping(USkeletalMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetMassOverrideInKg(USkeletalMeshComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetMassScale(USkeletalMeshComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetNotifyRigidBodyCollision(USkeletalMeshComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetSimulatePhysics(USkeletalMeshComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetUseCCD(USkeletalMeshComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ShouldCreatePhysicsState(USkeletalMeshComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ShouldRecreateProxyOnUpdateTransform(USkeletalMeshComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ShouldRenderSelected(USkeletalMeshComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SupportsStaticLighting(USkeletalMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_UnWeldChildren(USkeletalMeshComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_UnWeldFromParent(USkeletalMeshComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_UpdatePhysicsToRBChannels(USkeletalMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_UpdatePhysicsVolume(USkeletalMeshComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_UsesOnlyUnlitMaterials(USkeletalMeshComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_WakeAllRigidBodies(USkeletalMeshComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_WakeRigidBody(USkeletalMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_WeldTo(USkeletalMeshComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_WeldToImplementation(USkeletalMeshComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ApplyWorldOffset(USkeletalMeshComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CalcBoundingCylinder(USkeletalMeshComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CanAttachAsChild(USkeletalMeshComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_DestroyComponent(USkeletalMeshComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_DetachFromComponent(USkeletalMeshComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_DetachFromParent(USkeletalMeshComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetSocketLocation(USkeletalMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetSocketQuaternion(USkeletalMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetSocketRotation(USkeletalMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsAnySimulatingPhysics(USkeletalMeshComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsPrecomputedLightingValid(USkeletalMeshComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsVisible(USkeletalMeshComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsVisibleInEditor(USkeletalMeshComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnChildAttached(USkeletalMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnChildDetached(USkeletalMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnHiddenInGameChanged(USkeletalMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnVisibilityChanged(USkeletalMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PostNetReceive(USkeletalMeshComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PostRepNotifies(USkeletalMeshComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PreNetReceive(USkeletalMeshComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PropagateLightingScenarioChange(USkeletalMeshComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetRelativeScale3D(USkeletalMeshComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ShouldCollideWhenPlacing(USkeletalMeshComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ShouldCreateRenderState(USkeletalMeshComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_Activate(USkeletalMeshComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddTickPrerequisiteActor(USkeletalMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddTickPrerequisiteComponent(USkeletalMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_Deactivate(USkeletalMeshComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetComponentClassCanReplicate(USkeletalMeshComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetReadableName(USkeletalMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_InitializeComponent(USkeletalMeshComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsActive(USkeletalMeshComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsNameStableForNetworking(USkeletalMeshComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsReadyForOwnerToAutoDestroy(USkeletalMeshComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsSupportedForNetworking(USkeletalMeshComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_MarkAsEditorOnlySubobject(USkeletalMeshComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_NeedsLoadForEditorGame(USkeletalMeshComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnComponentCreated(USkeletalMeshComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PostInitProperties(USkeletalMeshComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PostRename(USkeletalMeshComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_RemoveTickPrerequisiteActor(USkeletalMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_RemoveTickPrerequisiteComponent(USkeletalMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_RequiresGameThreadEndOfFrameUpdates(USkeletalMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetActive(USkeletalMeshComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetAutoActivate(USkeletalMeshComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetComponentTickEnabled(USkeletalMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetComponentTickEnabledAsync(USkeletalMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ShouldActivate(USkeletalMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USkeletalMeshComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ToggleActive(USkeletalMeshComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_UninitializeComponent(USkeletalMeshComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AreNativePropertiesIdenticalTo(USkeletalMeshComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CheckDefaultSubobjectsInternal(USkeletalMeshComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetDesc(USkeletalMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsAsset(USkeletalMeshComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsFullNameStableForNetworking(USkeletalMeshComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsLocalizedResource(USkeletalMeshComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsPostLoadThreadSafe(USkeletalMeshComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsSafeForRootSet(USkeletalMeshComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_Modify(USkeletalMeshComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_NotifyObjectReferenceEliminated(USkeletalMeshComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PostCDOContruct(USkeletalMeshComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PostEditImport(USkeletalMeshComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PostSaveRoot(USkeletalMeshComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_PreDestroyFromReplication(USkeletalMeshComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ShutdownAfterError(USkeletalMeshComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AddToCluster(USkeletalMeshComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CanBeClusterRoot(USkeletalMeshComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CanBeInCluster(USkeletalMeshComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CreateCluster(USkeletalMeshComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_OnClusterMarkedAsPendingKill(USkeletalMeshComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
