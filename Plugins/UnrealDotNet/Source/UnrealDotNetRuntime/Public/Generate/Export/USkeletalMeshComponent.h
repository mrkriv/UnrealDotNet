#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SkeletalMeshComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:279

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_AreaStiffness_GET(USkeletalMeshComponent* Ptr) { return Ptr->AreaStiffness; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_AreaStiffness_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->AreaStiffness = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bAnimTreeInitialised_GET(USkeletalMeshComponent* Ptr) { return Ptr->bAnimTreeInitialised; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bAnimTreeInitialised_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bAnimTreeInitialised = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bBlendPhysics_GET(USkeletalMeshComponent* Ptr) { return Ptr->bBlendPhysics; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bBlendPhysics_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bBlendPhysics = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_GET(USkeletalMeshComponent* Ptr) { return Ptr->bCollideWithAttachedChildren; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bCollideWithAttachedChildren = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_GET(USkeletalMeshComponent* Ptr) { return Ptr->bCollideWithEnvironment; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bCollideWithEnvironment = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bDeferKinematicBoneUpdate_GET(USkeletalMeshComponent* Ptr) { return Ptr->bDeferKinematicBoneUpdate; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bDeferKinematicBoneUpdate_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bDeferKinematicBoneUpdate = Value; }
	
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
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_BendingStiffness_GET(USkeletalMeshComponent* Ptr) { return Ptr->BendingStiffness; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_BendingStiffness_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->BendingStiffness = Value; }
	
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
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bPropagateCurvesToSlaves_GET(USkeletalMeshComponent* Ptr) { return Ptr->bPropagateCurvesToSlaves; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bPropagateCurvesToSlaves_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bPropagateCurvesToSlaves = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bRequiredBonesUpToDate_GET(USkeletalMeshComponent* Ptr) { return Ptr->bRequiredBonesUpToDate; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bRequiredBonesUpToDate_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bRequiredBonesUpToDate = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bResetAfterTeleport_GET(USkeletalMeshComponent* Ptr) { return Ptr->bResetAfterTeleport; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bResetAfterTeleport_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bResetAfterTeleport = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bShowPrePhysBones_GET(USkeletalMeshComponent* Ptr) { return Ptr->bShowPrePhysBones; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bShowPrePhysBones_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bShowPrePhysBones = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bSimulationUpdatesChildTransforms_GET(USkeletalMeshComponent* Ptr) { return Ptr->bSimulationUpdatesChildTransforms; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bSimulationUpdatesChildTransforms_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bSimulationUpdatesChildTransforms = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bSkipBoundsUpdateWhenInterpolating_GET(USkeletalMeshComponent* Ptr) { return Ptr->bSkipBoundsUpdateWhenInterpolating; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bSkipBoundsUpdateWhenInterpolating_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bSkipBoundsUpdateWhenInterpolating = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bSkipKinematicUpdateWhenInterpolating_GET(USkeletalMeshComponent* Ptr) { return Ptr->bSkipKinematicUpdateWhenInterpolating; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bSkipKinematicUpdateWhenInterpolating_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bSkipKinematicUpdateWhenInterpolating = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUpdateJointsFromAnimation; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUpdateJointsFromAnimation = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUpdateOverlapsOnAnimationFinalize_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUpdateOverlapsOnAnimationFinalize; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUpdateOverlapsOnAnimationFinalize_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUpdateOverlapsOnAnimationFinalize = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUseBendingElements_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUseBendingElements; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUseBendingElements_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUseBendingElements = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUseContinuousCollisionDetection_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUseContinuousCollisionDetection; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUseContinuousCollisionDetection_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUseContinuousCollisionDetection = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUseRefPoseOnInitAnim; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUseRefPoseOnInitAnim = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUseSelfCollisions_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUseSelfCollisions; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUseSelfCollisions_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUseSelfCollisions = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUseTetrahedralConstraints_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUseTetrahedralConstraints; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUseTetrahedralConstraints_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUseTetrahedralConstraints = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_bUseThinShellVolumeConstraints_GET(USkeletalMeshComponent* Ptr) { return Ptr->bUseThinShellVolumeConstraints; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUseThinShellVolumeConstraints_SET(USkeletalMeshComponent* Ptr, uint8 Value) { Ptr->bUseThinShellVolumeConstraints = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_ClothBlendWeight_GET(USkeletalMeshComponent* Ptr) { return Ptr->ClothBlendWeight; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_ClothBlendWeight_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->ClothBlendWeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_GET(USkeletalMeshComponent* Ptr) { return Ptr->ClothMaxDistanceScale; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->ClothMaxDistanceScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_EdgeStiffness_GET(USkeletalMeshComponent* Ptr) { return Ptr->EdgeStiffness; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_EdgeStiffness_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->EdgeStiffness = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_GET(USkeletalMeshComponent* Ptr) { return Ptr->GlobalAnimRateScale; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->GlobalAnimRateScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_GET(USkeletalMeshComponent* Ptr) { return (INT_PTR)&(Ptr->LineCheckBoundsScale); }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_SET(USkeletalMeshComponent* Ptr, INT_PTR Value) { Ptr->LineCheckBoundsScale = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_GET(USkeletalMeshComponent* Ptr) { return Ptr->RagdollAggregateThreshold; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_SET(USkeletalMeshComponent* Ptr, int32 Value) { Ptr->RagdollAggregateThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_RootBoneTranslation_GET(USkeletalMeshComponent* Ptr) { return (INT_PTR)&(Ptr->RootBoneTranslation); }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_RootBoneTranslation_SET(USkeletalMeshComponent* Ptr, INT_PTR Value) { Ptr->RootBoneTranslation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_ShapeTargetStiffness_GET(USkeletalMeshComponent* Ptr) { return Ptr->ShapeTargetStiffness; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_ShapeTargetStiffness_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->ShapeTargetStiffness = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_StrainLimitingStiffness_GET(USkeletalMeshComponent* Ptr) { return Ptr->StrainLimitingStiffness; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_StrainLimitingStiffness_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->StrainLimitingStiffness = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkeletalMeshComponent_VolumeStiffness_GET(USkeletalMeshComponent* Ptr) { return Ptr->VolumeStiffness; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_VolumeStiffness_SET(USkeletalMeshComponent* Ptr, float Value) { Ptr->VolumeStiffness = Value; }
	
	
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

	DOTNET_EXPORT auto E_USkeletalMeshComponent_HasValidAnimationInstance(USkeletalMeshComponent* Self)
	{
		return Self->HasValidAnimationInstance();
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

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ResetAnimInstanceDynamics(USkeletalMeshComponent* Self, ETeleportType InTeleportType)
	{
		auto _p0 = InTeleportType;
		Self->ResetAnimInstanceDynamics(_p0);
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

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
