#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageSkeletalMeshComponent.h"
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

	DOTNET_EXPORT auto E_USkeletalMeshComponent_AllowAnimCurveEvaluation(USkeletalMeshComponent* Self, char* NameOfCurve, bool bAllow)
	{
		auto _p0 = ConvertFromManage_FName(NameOfCurve);
		auto _p1 = bAllow;
		Self->AllowAnimCurveEvaluation(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_BindClothToMasterPoseComponent(USkeletalMeshComponent* Self)
	{
		Self->BindClothToMasterPoseComponent();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ClearMorphTargets(USkeletalMeshComponent* Self)
	{
		Self->ClearMorphTargets();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_CreateBodySetup(USkeletalMeshComponent* Self)
	{
		Self->CreateBodySetup();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ForceClothNextUpdateTeleport(USkeletalMeshComponent* Self)
	{
		Self->ForceClothNextUpdateTeleport();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ForceClothNextUpdateTeleportAndReset(USkeletalMeshComponent* Self)
	{
		Self->ForceClothNextUpdateTeleportAndReset();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetAllowedAnimCurveEvaluate(USkeletalMeshComponent* Self)
	{
		return Self->GetAllowedAnimCurveEvaluate();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetClothMaxDistanceScale(USkeletalMeshComponent* Self)
	{
		return Self->GetClothMaxDistanceScale();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_GetDisableAnimCurves(USkeletalMeshComponent* Self)
	{
		return Self->GetDisableAnimCurves();
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

	DOTNET_EXPORT auto E_USkeletalMeshComponent_InitializeAnimScriptInstance(USkeletalMeshComponent* Self, bool bForceReinit)
	{
		auto _p0 = bForceReinit;
		return Self->InitializeAnimScriptInstance(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsClothingSimulationSuspended(USkeletalMeshComponent* Self)
	{
		return Self->IsClothingSimulationSuspended();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsPlaying(USkeletalMeshComponent* Self)
	{
		return Self->IsPlaying();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_IsWindEnabled(USkeletalMeshComponent* Self)
	{
		return Self->IsWindEnabled();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_Play(USkeletalMeshComponent* Self, bool bLooping)
	{
		auto _p0 = bLooping;
		Self->Play(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ResetAllowedAnimCurveEvaluation(USkeletalMeshComponent* Self)
	{
		Self->ResetAllowedAnimCurveEvaluation();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ResetAnimInstanceDynamics(USkeletalMeshComponent* Self, ETeleportType InTeleportType)
	{
		auto _p0 = InTeleportType;
		Self->ResetAnimInstanceDynamics(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ResetClothTeleportMode(USkeletalMeshComponent* Self)
	{
		Self->ResetClothTeleportMode();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ResumeClothingSimulation(USkeletalMeshComponent* Self)
	{
		Self->ResumeClothingSimulation();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetAllowAnimCurveEvaluation(USkeletalMeshComponent* Self, bool bInAllow)
	{
		auto _p0 = bInAllow;
		Self->SetAllowAnimCurveEvaluation(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetClothMaxDistanceScale(USkeletalMeshComponent* Self, float Scale)
	{
		auto _p0 = Scale;
		Self->SetClothMaxDistanceScale(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetDisableAnimCurves(USkeletalMeshComponent* Self, bool bInDisableAnimCurves)
	{
		auto _p0 = bInDisableAnimCurves;
		Self->SetDisableAnimCurves(_p0);
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

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SetUpdateAnimationInEditor(USkeletalMeshComponent* Self, bool NewUpdateState)
	{
		auto _p0 = NewUpdateState;
		Self->SetUpdateAnimationInEditor(_p0);
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_Stop(USkeletalMeshComponent* Self)
	{
		Self->Stop();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_SuspendClothingSimulation(USkeletalMeshComponent* Self)
	{
		Self->SuspendClothingSimulation();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_ToggleDisablePostProcessBlueprint(USkeletalMeshComponent* Self)
	{
		Self->ToggleDisablePostProcessBlueprint();
	}

	DOTNET_EXPORT auto E_USkeletalMeshComponent_UnbindClothFromMasterPoseComponent(USkeletalMeshComponent* Self, bool bRestoreSimulationSpace)
	{
		auto _p0 = bRestoreSimulationSpace;
		Self->UnbindClothFromMasterPoseComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PrestreamTextures(UMeshComponent* Self, float Seconds, bool bPrioritizeCharacterTextures, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bPrioritizeCharacterTextures;
		auto _p2 = CinematicTextureGroups;
		((UManageSkeletalMeshComponent*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetTextureForceResidentFlag(UMeshComponent* Self, bool bForceMiplevelsToBeResident)
	{
		auto _p0 = bForceMiplevelsToBeResident;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetTextureForceResidentFlag(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageSkeletalMeshComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageSkeletalMeshComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageSkeletalMeshComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_Deactivate(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageSkeletalMeshComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageSkeletalMeshComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnRegister(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageSkeletalMeshComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSkeletalMeshComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_BeginDestroy(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_FinishDestroy(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PostCDOContruct(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PostEditImport(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PostInitProperties(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PostLoad(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PostNetReceive(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PostRepNotifies(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageSkeletalMeshComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_PreNetReceive(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__USkeletalMeshComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageSkeletalMeshComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
