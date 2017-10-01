#pragma once

#include "CoreMinimal.h"
#include "Components/SkinnedMeshComponent.h"
#include "Engine/EngineBaseTypes.h"
#include "Engine/World.h"
#include "Components/SkeletalMeshComponent.h"
#include "Engine/EngineTypes.h"
#include "Components/AudioComponent.h"
#include "GameFramework/Character.h"
#include "Components/LineBatchComponent.h"
#include "Math/Box.h"
#include "Math/Box2D.h"
#include "Engine/Scene.h"
#include "Engine/Engine.h"
#include "Components/HierarchicalInstancedStaticMeshComponent.h"
#include "Components/DestructibleComponent.h"
#include "Components/SceneComponent.h"
#include "Components/SceneCaptureComponent.h"
#include "Components/InstancedStaticMeshComponent.h"
#include "Components/InterpToMovementComponent.h"
#include "Components/MaterialBillboardComponent.h"
#include "Components/StaticMeshComponent.h"
#include "Math/Plane.h"
#include "Math/Quat.h"
#include "Components/ReflectionCaptureComponent.h"
#include "Components/PrimitiveComponent.h"
#include "Math/Rotator.h"
#include "Components/SplineComponent.h"
#include "Components/SplineMeshComponent.h"
#include "Components/TimelineComponent.h"
#include "Math/TransformVectorized.h"
#include "Math/Vector.h"
#include "Math/Vector2D.h"
#include "Math/Vector4.h"

extern "C"
{
	
	/*	FActiveMorphTarget	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActiveMorphTarget() { return (INT_PTR) new FActiveMorphTarget(); }
	
	DOTNET_EXPORT int32 E_PROP_FActiveMorphTarget_WeightIndex_GET(INT_PTR Ptr) { return ((FActiveMorphTarget*)Ptr)->WeightIndex; }
	DOTNET_EXPORT void E_PROP_FActiveMorphTarget_WeightIndex_SET(INT_PTR Ptr, int32 Value) { ((FActiveMorphTarget*)Ptr)->WeightIndex = Value; }
	
	
	/*	FActorComponentTickFunction	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActorComponentTickFunction() { return (INT_PTR) new FActorComponentTickFunction(); }
	
	DOTNET_EXPORT UActorComponent* E_PROP_FActorComponentTickFunction_Target_GET(INT_PTR Ptr) { return ((FActorComponentTickFunction*)Ptr)->Target; }
	DOTNET_EXPORT void E_PROP_FActorComponentTickFunction_Target_SET(INT_PTR Ptr, UActorComponent* Value) { ((FActorComponentTickFunction*)Ptr)->Target = Value; }
	
	
	/*	FActorSpawnParameters	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActorSpawnParameters() { return (INT_PTR) new FActorSpawnParameters(); }
	
	DOTNET_EXPORT APawn* E_PROP_FActorSpawnParameters_Instigator_GET(INT_PTR Ptr) { return ((FActorSpawnParameters*)Ptr)->Instigator; }
	DOTNET_EXPORT void E_PROP_FActorSpawnParameters_Instigator_SET(INT_PTR Ptr, APawn* Value) { ((FActorSpawnParameters*)Ptr)->Instigator = Value; }
	
	DOTNET_EXPORT char* E_PROP_FActorSpawnParameters_Name_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FActorSpawnParameters*)Ptr)->Name.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FActorSpawnParameters_Name_SET(INT_PTR Ptr, char* Value) { ((FActorSpawnParameters*)Ptr)->Name = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT AActor* E_PROP_FActorSpawnParameters_Owner_GET(INT_PTR Ptr) { return ((FActorSpawnParameters*)Ptr)->Owner; }
	DOTNET_EXPORT void E_PROP_FActorSpawnParameters_Owner_SET(INT_PTR Ptr, AActor* Value) { ((FActorSpawnParameters*)Ptr)->Owner = Value; }
	
	DOTNET_EXPORT AActor* E_PROP_FActorSpawnParameters_Template_GET(INT_PTR Ptr) { return ((FActorSpawnParameters*)Ptr)->Template; }
	DOTNET_EXPORT void E_PROP_FActorSpawnParameters_Template_SET(INT_PTR Ptr, AActor* Value) { ((FActorSpawnParameters*)Ptr)->Template = Value; }
	
	DOTNET_EXPORT auto E_FActorSpawnParameters_IsRemoteOwned(FActorSpawnParameters* Self)
	{
		return ConvertForManage(Self->IsRemoteOwned());
	}

	
	/*	FActorTickFunction	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActorTickFunction() { return (INT_PTR) new FActorTickFunction(); }
	
	DOTNET_EXPORT AActor* E_PROP_FActorTickFunction_Target_GET(INT_PTR Ptr) { return ((FActorTickFunction*)Ptr)->Target; }
	DOTNET_EXPORT void E_PROP_FActorTickFunction_Target_SET(INT_PTR Ptr, AActor* Value) { ((FActorTickFunction*)Ptr)->Target = Value; }
	
	
	/*	FAnimationEvaluationContext	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAnimationEvaluationContext() { return (INT_PTR) new FAnimationEvaluationContext(); }
	
	DOTNET_EXPORT bool E_PROP_FAnimationEvaluationContext_bDoEvaluation_GET(INT_PTR Ptr) { return ((FAnimationEvaluationContext*)Ptr)->bDoEvaluation; }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_bDoEvaluation_SET(INT_PTR Ptr, bool Value) { ((FAnimationEvaluationContext*)Ptr)->bDoEvaluation = Value; }
	
	DOTNET_EXPORT bool E_PROP_FAnimationEvaluationContext_bDoInterpolation_GET(INT_PTR Ptr) { return ((FAnimationEvaluationContext*)Ptr)->bDoInterpolation; }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_bDoInterpolation_SET(INT_PTR Ptr, bool Value) { ((FAnimationEvaluationContext*)Ptr)->bDoInterpolation = Value; }
	
	DOTNET_EXPORT bool E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_GET(INT_PTR Ptr) { return ((FAnimationEvaluationContext*)Ptr)->bDuplicateToCacheBones; }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_SET(INT_PTR Ptr, bool Value) { ((FAnimationEvaluationContext*)Ptr)->bDuplicateToCacheBones = Value; }
	
	DOTNET_EXPORT bool E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_GET(INT_PTR Ptr) { return ((FAnimationEvaluationContext*)Ptr)->bDuplicateToCacheCurve; }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_SET(INT_PTR Ptr, bool Value) { ((FAnimationEvaluationContext*)Ptr)->bDuplicateToCacheCurve = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FAnimationEvaluationContext_RootBoneTranslation_GET(INT_PTR Ptr) { return (INT_PTR)&((FAnimationEvaluationContext*)Ptr)->RootBoneTranslation; }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_RootBoneTranslation_SET(INT_PTR Ptr, INT_PTR Value) { ((FAnimationEvaluationContext*)Ptr)->RootBoneTranslation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_FAnimationEvaluationContext_Clear(FAnimationEvaluationContext* Self)
	{
		Self->Clear();
	}

	DOTNET_EXPORT auto E_FAnimationEvaluationContext_Copy(FAnimationEvaluationContext* Self, INT_PTR Other)
	{
		auto _p0 = *(FAnimationEvaluationContext*)Other;
		Self->Copy(_p0);
	}

	
	/*	FAttachmentTransformRules	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool(EAttachmentRule InRule, bool bInWeldSimulatedBodies) { return (INT_PTR) new FAttachmentTransformRules(InRule, bInWeldSimulatedBodies); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool(EAttachmentRule InLocationRule, EAttachmentRule InRotationRule, EAttachmentRule InScaleRule, bool bInWeldSimulatedBodies) { return (INT_PTR) new FAttachmentTransformRules(InLocationRule, InRotationRule, InScaleRule, bInWeldSimulatedBodies); }
	
	DOTNET_EXPORT bool E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_GET(INT_PTR Ptr) { return ((FAttachmentTransformRules*)Ptr)->bWeldSimulatedBodies; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_SET(INT_PTR Ptr, bool Value) { ((FAttachmentTransformRules*)Ptr)->bWeldSimulatedBodies = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FAttachmentTransformRules_KeepRelativeTransform_GET(INT_PTR Ptr) { return (INT_PTR)&((FAttachmentTransformRules*)Ptr)->KeepRelativeTransform; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_KeepRelativeTransform_SET(INT_PTR Ptr, INT_PTR Value) { ((FAttachmentTransformRules*)Ptr)->KeepRelativeTransform = *(FAttachmentTransformRules*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FAttachmentTransformRules_KeepWorldTransform_GET(INT_PTR Ptr) { return (INT_PTR)&((FAttachmentTransformRules*)Ptr)->KeepWorldTransform; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_KeepWorldTransform_SET(INT_PTR Ptr, INT_PTR Value) { ((FAttachmentTransformRules*)Ptr)->KeepWorldTransform = *(FAttachmentTransformRules*)Value; }
	
	DOTNET_EXPORT EAttachmentRule E_PROP_FAttachmentTransformRules_LocationRule_GET(INT_PTR Ptr) { return ((FAttachmentTransformRules*)Ptr)->LocationRule; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_LocationRule_SET(INT_PTR Ptr, EAttachmentRule Value) { ((FAttachmentTransformRules*)Ptr)->LocationRule = Value; }
	
	DOTNET_EXPORT EAttachmentRule E_PROP_FAttachmentTransformRules_RotationRule_GET(INT_PTR Ptr) { return ((FAttachmentTransformRules*)Ptr)->RotationRule; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_RotationRule_SET(INT_PTR Ptr, EAttachmentRule Value) { ((FAttachmentTransformRules*)Ptr)->RotationRule = Value; }
	
	DOTNET_EXPORT EAttachmentRule E_PROP_FAttachmentTransformRules_ScaleRule_GET(INT_PTR Ptr) { return ((FAttachmentTransformRules*)Ptr)->ScaleRule; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_ScaleRule_SET(INT_PTR Ptr, EAttachmentRule Value) { ((FAttachmentTransformRules*)Ptr)->ScaleRule = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FAttachmentTransformRules_SnapToTargetIncludingScale_GET(INT_PTR Ptr) { return (INT_PTR)&((FAttachmentTransformRules*)Ptr)->SnapToTargetIncludingScale; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_SnapToTargetIncludingScale_SET(INT_PTR Ptr, INT_PTR Value) { ((FAttachmentTransformRules*)Ptr)->SnapToTargetIncludingScale = *(FAttachmentTransformRules*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FAttachmentTransformRules_SnapToTargetNotIncludingScale_GET(INT_PTR Ptr) { return (INT_PTR)&((FAttachmentTransformRules*)Ptr)->SnapToTargetNotIncludingScale; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_SnapToTargetNotIncludingScale_SET(INT_PTR Ptr, INT_PTR Value) { ((FAttachmentTransformRules*)Ptr)->SnapToTargetNotIncludingScale = *(FAttachmentTransformRules*)Value; }
	
	
	/*	FAudioComponentParam	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAudioComponentParam_FName(char* Name) { return (INT_PTR) new FAudioComponentParam(ConvertFromManage_FName(Name)); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAudioComponentParam() { return (INT_PTR) new FAudioComponentParam(); }
	
	DOTNET_EXPORT bool E_PROP_FAudioComponentParam_BoolParam_GET(INT_PTR Ptr) { return ((FAudioComponentParam*)Ptr)->BoolParam; }
	DOTNET_EXPORT void E_PROP_FAudioComponentParam_BoolParam_SET(INT_PTR Ptr, bool Value) { ((FAudioComponentParam*)Ptr)->BoolParam = Value; }
	
	DOTNET_EXPORT float E_PROP_FAudioComponentParam_FloatParam_GET(INT_PTR Ptr) { return ((FAudioComponentParam*)Ptr)->FloatParam; }
	DOTNET_EXPORT void E_PROP_FAudioComponentParam_FloatParam_SET(INT_PTR Ptr, float Value) { ((FAudioComponentParam*)Ptr)->FloatParam = Value; }
	
	DOTNET_EXPORT int32 E_PROP_FAudioComponentParam_IntParam_GET(INT_PTR Ptr) { return ((FAudioComponentParam*)Ptr)->IntParam; }
	DOTNET_EXPORT void E_PROP_FAudioComponentParam_IntParam_SET(INT_PTR Ptr, int32 Value) { ((FAudioComponentParam*)Ptr)->IntParam = Value; }
	
	DOTNET_EXPORT char* E_PROP_FAudioComponentParam_ParamName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FAudioComponentParam*)Ptr)->ParamName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FAudioComponentParam_ParamName_SET(INT_PTR Ptr, char* Value) { ((FAudioComponentParam*)Ptr)->ParamName = FName(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FBasedMovementInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBasedMovementInfo() { return (INT_PTR) new FBasedMovementInfo(); }
	
	DOTNET_EXPORT char* E_PROP_FBasedMovementInfo_BoneName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FBasedMovementInfo*)Ptr)->BoneName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_BoneName_SET(INT_PTR Ptr, char* Value) { ((FBasedMovementInfo*)Ptr)->BoneName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT bool E_PROP_FBasedMovementInfo_bRelativeRotation_GET(INT_PTR Ptr) { return ((FBasedMovementInfo*)Ptr)->bRelativeRotation; }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_bRelativeRotation_SET(INT_PTR Ptr, bool Value) { ((FBasedMovementInfo*)Ptr)->bRelativeRotation = Value; }
	
	DOTNET_EXPORT bool E_PROP_FBasedMovementInfo_bServerHasBaseComponent_GET(INT_PTR Ptr) { return ((FBasedMovementInfo*)Ptr)->bServerHasBaseComponent; }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_bServerHasBaseComponent_SET(INT_PTR Ptr, bool Value) { ((FBasedMovementInfo*)Ptr)->bServerHasBaseComponent = Value; }
	
	DOTNET_EXPORT bool E_PROP_FBasedMovementInfo_bServerHasVelocity_GET(INT_PTR Ptr) { return ((FBasedMovementInfo*)Ptr)->bServerHasVelocity; }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_bServerHasVelocity_SET(INT_PTR Ptr, bool Value) { ((FBasedMovementInfo*)Ptr)->bServerHasVelocity = Value; }
	
	DOTNET_EXPORT UPrimitiveComponent* E_PROP_FBasedMovementInfo_MovementBase_GET(INT_PTR Ptr) { return ((FBasedMovementInfo*)Ptr)->MovementBase; }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_MovementBase_SET(INT_PTR Ptr, UPrimitiveComponent* Value) { ((FBasedMovementInfo*)Ptr)->MovementBase = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBasedMovementInfo_Rotation_GET(INT_PTR Ptr) { return (INT_PTR)&((FBasedMovementInfo*)Ptr)->Rotation; }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FBasedMovementInfo*)Ptr)->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_FBasedMovementInfo_HasRelativeLocation(FBasedMovementInfo* Self)
	{
		return ConvertForManage(Self->HasRelativeLocation());
	}

	DOTNET_EXPORT auto E_FBasedMovementInfo_HasRelativePosition(FBasedMovementInfo* Self)
	{
		return ConvertForManage(Self->HasRelativePosition());
	}

	DOTNET_EXPORT auto E_FBasedMovementInfo_HasRelativeRotation(FBasedMovementInfo* Self)
	{
		return ConvertForManage(Self->HasRelativeRotation());
	}

	DOTNET_EXPORT auto E_FBasedMovementInfo_IsBaseUnresolved(FBasedMovementInfo* Self)
	{
		return ConvertForManage(Self->IsBaseUnresolved());
	}

	
	/*	FBatchedLine	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBatchedLine() { return (INT_PTR) new FBatchedLine(); }
	
	DOTNET_EXPORT uint8 E_PROP_FBatchedLine_DepthPriority_GET(INT_PTR Ptr) { return ((FBatchedLine*)Ptr)->DepthPriority; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_DepthPriority_SET(INT_PTR Ptr, uint8 Value) { ((FBatchedLine*)Ptr)->DepthPriority = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBatchedLine_End_GET(INT_PTR Ptr) { return (INT_PTR)&((FBatchedLine*)Ptr)->End; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_End_SET(INT_PTR Ptr, INT_PTR Value) { ((FBatchedLine*)Ptr)->End = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FBatchedLine_RemainingLifeTime_GET(INT_PTR Ptr) { return ((FBatchedLine*)Ptr)->RemainingLifeTime; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_RemainingLifeTime_SET(INT_PTR Ptr, float Value) { ((FBatchedLine*)Ptr)->RemainingLifeTime = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBatchedLine_Start_GET(INT_PTR Ptr) { return (INT_PTR)&((FBatchedLine*)Ptr)->Start; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_Start_SET(INT_PTR Ptr, INT_PTR Value) { ((FBatchedLine*)Ptr)->Start = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FBatchedLine_Thickness_GET(INT_PTR Ptr) { return ((FBatchedLine*)Ptr)->Thickness; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_Thickness_SET(INT_PTR Ptr, float Value) { ((FBatchedLine*)Ptr)->Thickness = Value; }
	
	
	/*	FBatchedMesh	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBatchedMesh() { return (INT_PTR) new FBatchedMesh(); }
	
	DOTNET_EXPORT uint8 E_PROP_FBatchedMesh_DepthPriority_GET(INT_PTR Ptr) { return ((FBatchedMesh*)Ptr)->DepthPriority; }
	DOTNET_EXPORT void E_PROP_FBatchedMesh_DepthPriority_SET(INT_PTR Ptr, uint8 Value) { ((FBatchedMesh*)Ptr)->DepthPriority = Value; }
	
	DOTNET_EXPORT float E_PROP_FBatchedMesh_RemainingLifeTime_GET(INT_PTR Ptr) { return ((FBatchedMesh*)Ptr)->RemainingLifeTime; }
	DOTNET_EXPORT void E_PROP_FBatchedMesh_RemainingLifeTime_SET(INT_PTR Ptr, float Value) { ((FBatchedMesh*)Ptr)->RemainingLifeTime = Value; }
	
	
	/*	FBatchedPoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBatchedPoint() { return (INT_PTR) new FBatchedPoint(); }
	
	DOTNET_EXPORT uint8 E_PROP_FBatchedPoint_DepthPriority_GET(INT_PTR Ptr) { return ((FBatchedPoint*)Ptr)->DepthPriority; }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_DepthPriority_SET(INT_PTR Ptr, uint8 Value) { ((FBatchedPoint*)Ptr)->DepthPriority = Value; }
	
	DOTNET_EXPORT float E_PROP_FBatchedPoint_PointSize_GET(INT_PTR Ptr) { return ((FBatchedPoint*)Ptr)->PointSize; }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_PointSize_SET(INT_PTR Ptr, float Value) { ((FBatchedPoint*)Ptr)->PointSize = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBatchedPoint_Position_GET(INT_PTR Ptr) { return (INT_PTR)&((FBatchedPoint*)Ptr)->Position; }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_Position_SET(INT_PTR Ptr, INT_PTR Value) { ((FBatchedPoint*)Ptr)->Position = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FBatchedPoint_RemainingLifeTime_GET(INT_PTR Ptr) { return ((FBatchedPoint*)Ptr)->RemainingLifeTime; }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_RemainingLifeTime_SET(INT_PTR Ptr, float Value) { ((FBatchedPoint*)Ptr)->RemainingLifeTime = Value; }
	
	
	/*	FBox	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox() { return (INT_PTR) new FBox(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox_int32(int32 _p0) { return (INT_PTR) new FBox(_p0); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox_FVector_FVector(INT_PTR InMin, INT_PTR InMax) { return (INT_PTR) new FBox(*(FVector*)InMin, *(FVector*)InMax); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox_FVector_int32(INT_PTR Points, int32 Count) { return (INT_PTR) new FBox((FVector*)Points, Count); }
	
	DOTNET_EXPORT uint8 E_PROP_FBox_IsValid_GET(INT_PTR Ptr) { return ((FBox*)Ptr)->IsValid; }
	DOTNET_EXPORT void E_PROP_FBox_IsValid_SET(INT_PTR Ptr, uint8 Value) { ((FBox*)Ptr)->IsValid = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBox_Max_GET(INT_PTR Ptr) { return (INT_PTR)&((FBox*)Ptr)->Max; }
	DOTNET_EXPORT void E_PROP_FBox_Max_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox*)Ptr)->Max = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBox_Min_GET(INT_PTR Ptr) { return (INT_PTR)&((FBox*)Ptr)->Min; }
	DOTNET_EXPORT void E_PROP_FBox_Min_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox*)Ptr)->Min = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_FBox_BuildAABB(FBox* Self, INT_PTR Origin, INT_PTR Extent)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = *(FVector*)Extent;
		return (INT_PTR) new FBox(Self->BuildAABB(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FBox_ComputeSquaredDistanceToPoint(FBox* Self, INT_PTR Point)
	{
		auto _p0 = *(FVector*)Point;
		return ConvertForManage(Self->ComputeSquaredDistanceToPoint(_p0));
	}

	DOTNET_EXPORT auto E_FBox_GetCenter(FBox* Self)
	{
		return (INT_PTR) new FVector(Self->GetCenter());
	}

	DOTNET_EXPORT auto E_FBox_GetCenterAndExtents(FBox* Self, INT_PTR center, INT_PTR Extents)
	{
		auto _p0 = *(FVector*)center;
		auto _p1 = *(FVector*)Extents;
		Self->GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FBox_GetClosestPointTo(FBox* Self, INT_PTR Point)
	{
		auto _p0 = *(FVector*)Point;
		return (INT_PTR) new FVector(Self->GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT auto E_FBox_GetExtent(FBox* Self)
	{
		return (INT_PTR) new FVector(Self->GetExtent());
	}

	DOTNET_EXPORT auto E_FBox_GetSize(FBox* Self)
	{
		return (INT_PTR) new FVector(Self->GetSize());
	}

	DOTNET_EXPORT auto E_FBox_GetVolume(FBox* Self)
	{
		return ConvertForManage(Self->GetVolume());
	}

	DOTNET_EXPORT auto E_FBox_Init(FBox* Self)
	{
		Self->Init();
	}

	DOTNET_EXPORT auto E_FBox_Intersect(FBox* Self, INT_PTR other)
	{
		auto _p0 = *(FBox*)other;
		return ConvertForManage(Self->Intersect(_p0));
	}

	DOTNET_EXPORT auto E_FBox_IntersectXY(FBox* Self, INT_PTR Other)
	{
		auto _p0 = *(FBox*)Other;
		return ConvertForManage(Self->IntersectXY(_p0));
	}

	DOTNET_EXPORT auto E_FBox_InverseTransformBy(FBox* Self, INT_PTR M)
	{
		auto _p0 = *(FTransform*)M;
		return (INT_PTR) new FBox(Self->InverseTransformBy(_p0));
	}

	DOTNET_EXPORT auto E_FBox_IsInsideOrOn(FBox* Self, INT_PTR In)
	{
		auto _p0 = *(FVector*)In;
		return ConvertForManage(Self->IsInsideOrOn(_p0));
	}

	DOTNET_EXPORT auto E_FBox_MoveTo(FBox* Self, INT_PTR Destination)
	{
		auto _p0 = *(FVector*)Destination;
		return (INT_PTR) new FBox(Self->MoveTo(_p0));
	}

	DOTNET_EXPORT auto E_FBox_Overlap(FBox* Self, INT_PTR Other)
	{
		auto _p0 = *(FBox*)Other;
		return (INT_PTR) new FBox(Self->Overlap(_p0));
	}

	DOTNET_EXPORT auto E_FBox_ShiftBy(FBox* Self, INT_PTR Offset)
	{
		auto _p0 = *(FVector*)Offset;
		return (INT_PTR) new FBox(Self->ShiftBy(_p0));
	}

	DOTNET_EXPORT auto E_FBox_ToString(FBox* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	
	/*	FBox2D	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D() { return (INT_PTR) new FBox2D(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D_int32(int32 _p0) { return (INT_PTR) new FBox2D(_p0); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D_FVector2D_FVector2D(INT_PTR InMin, INT_PTR InMax) { return (INT_PTR) new FBox2D(*(FVector2D*)InMin, *(FVector2D*)InMax); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D_FVector2D_int32(INT_PTR Points, int32 Count) { return (INT_PTR) new FBox2D((FVector2D*)Points, Count); }
	
	DOTNET_EXPORT bool E_PROP_FBox2D_bIsValid_GET(INT_PTR Ptr) { return ((FBox2D*)Ptr)->bIsValid; }
	DOTNET_EXPORT void E_PROP_FBox2D_bIsValid_SET(INT_PTR Ptr, bool Value) { ((FBox2D*)Ptr)->bIsValid = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBox2D_Max_GET(INT_PTR Ptr) { return (INT_PTR)&((FBox2D*)Ptr)->Max; }
	DOTNET_EXPORT void E_PROP_FBox2D_Max_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox2D*)Ptr)->Max = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBox2D_Min_GET(INT_PTR Ptr) { return (INT_PTR)&((FBox2D*)Ptr)->Min; }
	DOTNET_EXPORT void E_PROP_FBox2D_Min_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox2D*)Ptr)->Min = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_FBox2D_ComputeSquaredDistanceToPoint(FBox2D* Self, INT_PTR Point)
	{
		auto _p0 = *(FVector2D*)Point;
		return ConvertForManage(Self->ComputeSquaredDistanceToPoint(_p0));
	}

	DOTNET_EXPORT auto E_FBox2D_ExpandBy(FBox2D* Self, float W)
	{
		auto _p0 = W;
		return (INT_PTR) new FBox2D(Self->ExpandBy(_p0));
	}

	DOTNET_EXPORT auto E_FBox2D_GetArea(FBox2D* Self)
	{
		return ConvertForManage(Self->GetArea());
	}

	DOTNET_EXPORT auto E_FBox2D_GetCenter(FBox2D* Self)
	{
		return (INT_PTR) new FVector2D(Self->GetCenter());
	}

	DOTNET_EXPORT auto E_FBox2D_GetCenterAndExtents(FBox2D* Self, INT_PTR center, INT_PTR Extents)
	{
		auto _p0 = *(FVector2D*)center;
		auto _p1 = *(FVector2D*)Extents;
		Self->GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FBox2D_GetClosestPointTo(FBox2D* Self, INT_PTR Point)
	{
		auto _p0 = *(FVector2D*)Point;
		return (INT_PTR) new FVector2D(Self->GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT auto E_FBox2D_GetExtent(FBox2D* Self)
	{
		return (INT_PTR) new FVector2D(Self->GetExtent());
	}

	DOTNET_EXPORT auto E_FBox2D_GetSize(FBox2D* Self)
	{
		return (INT_PTR) new FVector2D(Self->GetSize());
	}

	DOTNET_EXPORT auto E_FBox2D_Init(FBox2D* Self)
	{
		Self->Init();
	}

	DOTNET_EXPORT auto E_FBox2D_Intersect(FBox2D* Self, INT_PTR other)
	{
		auto _p0 = *(FBox2D*)other;
		return ConvertForManage(Self->Intersect(_p0));
	}

	DOTNET_EXPORT auto E_FBox2D_ShiftBy(FBox2D* Self, INT_PTR Offset)
	{
		auto _p0 = *(FVector2D*)Offset;
		return (INT_PTR) new FBox2D(Self->ShiftBy(_p0));
	}

	DOTNET_EXPORT auto E_FBox2D_ToString(FBox2D* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	
	/*	FCameraExposureSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FCameraExposureSettings() { return (INT_PTR) new FCameraExposureSettings(); }
	
	DOTNET_EXPORT float E_PROP_FCameraExposureSettings_Bias_GET(INT_PTR Ptr) { return ((FCameraExposureSettings*)Ptr)->Bias; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_Bias_SET(INT_PTR Ptr, float Value) { ((FCameraExposureSettings*)Ptr)->Bias = Value; }
	
	DOTNET_EXPORT float E_PROP_FCameraExposureSettings_HighPercent_GET(INT_PTR Ptr) { return ((FCameraExposureSettings*)Ptr)->HighPercent; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_HighPercent_SET(INT_PTR Ptr, float Value) { ((FCameraExposureSettings*)Ptr)->HighPercent = Value; }
	
	DOTNET_EXPORT float E_PROP_FCameraExposureSettings_HistogramLogMax_GET(INT_PTR Ptr) { return ((FCameraExposureSettings*)Ptr)->HistogramLogMax; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_HistogramLogMax_SET(INT_PTR Ptr, float Value) { ((FCameraExposureSettings*)Ptr)->HistogramLogMax = Value; }
	
	DOTNET_EXPORT float E_PROP_FCameraExposureSettings_HistogramLogMin_GET(INT_PTR Ptr) { return ((FCameraExposureSettings*)Ptr)->HistogramLogMin; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_HistogramLogMin_SET(INT_PTR Ptr, float Value) { ((FCameraExposureSettings*)Ptr)->HistogramLogMin = Value; }
	
	DOTNET_EXPORT float E_PROP_FCameraExposureSettings_LowPercent_GET(INT_PTR Ptr) { return ((FCameraExposureSettings*)Ptr)->LowPercent; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_LowPercent_SET(INT_PTR Ptr, float Value) { ((FCameraExposureSettings*)Ptr)->LowPercent = Value; }
	
	DOTNET_EXPORT float E_PROP_FCameraExposureSettings_MaxBrightness_GET(INT_PTR Ptr) { return ((FCameraExposureSettings*)Ptr)->MaxBrightness; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_MaxBrightness_SET(INT_PTR Ptr, float Value) { ((FCameraExposureSettings*)Ptr)->MaxBrightness = Value; }
	
	DOTNET_EXPORT float E_PROP_FCameraExposureSettings_MinBrightness_GET(INT_PTR Ptr) { return ((FCameraExposureSettings*)Ptr)->MinBrightness; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_MinBrightness_SET(INT_PTR Ptr, float Value) { ((FCameraExposureSettings*)Ptr)->MinBrightness = Value; }
	
	DOTNET_EXPORT float E_PROP_FCameraExposureSettings_SpeedDown_GET(INT_PTR Ptr) { return ((FCameraExposureSettings*)Ptr)->SpeedDown; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_SpeedDown_SET(INT_PTR Ptr, float Value) { ((FCameraExposureSettings*)Ptr)->SpeedDown = Value; }
	
	DOTNET_EXPORT float E_PROP_FCameraExposureSettings_SpeedUp_GET(INT_PTR Ptr) { return ((FCameraExposureSettings*)Ptr)->SpeedUp; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_SpeedUp_SET(INT_PTR Ptr, float Value) { ((FCameraExposureSettings*)Ptr)->SpeedUp = Value; }
	
	DOTNET_EXPORT auto E_FCameraExposureSettings_ExportToPostProcessSettings(FCameraExposureSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FClassRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClassRedirect() { return (INT_PTR) new FClassRedirect(); }
	
	DOTNET_EXPORT bool E_PROP_FClassRedirect_InstanceOnly_GET(INT_PTR Ptr) { return ((FClassRedirect*)Ptr)->InstanceOnly; }
	DOTNET_EXPORT void E_PROP_FClassRedirect_InstanceOnly_SET(INT_PTR Ptr, bool Value) { ((FClassRedirect*)Ptr)->InstanceOnly = Value; }
	
	DOTNET_EXPORT char* E_PROP_FClassRedirect_NewClassClass_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FClassRedirect*)Ptr)->NewClassClass.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FClassRedirect_NewClassClass_SET(INT_PTR Ptr, char* Value) { ((FClassRedirect*)Ptr)->NewClassClass = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FClassRedirect_NewClassName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FClassRedirect*)Ptr)->NewClassName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FClassRedirect_NewClassName_SET(INT_PTR Ptr, char* Value) { ((FClassRedirect*)Ptr)->NewClassName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FClassRedirect_NewClassPackage_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FClassRedirect*)Ptr)->NewClassPackage.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FClassRedirect_NewClassPackage_SET(INT_PTR Ptr, char* Value) { ((FClassRedirect*)Ptr)->NewClassPackage = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FClassRedirect_NewSubobjName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FClassRedirect*)Ptr)->NewSubobjName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FClassRedirect_NewSubobjName_SET(INT_PTR Ptr, char* Value) { ((FClassRedirect*)Ptr)->NewSubobjName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FClassRedirect_ObjectName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FClassRedirect*)Ptr)->ObjectName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FClassRedirect_ObjectName_SET(INT_PTR Ptr, char* Value) { ((FClassRedirect*)Ptr)->ObjectName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FClassRedirect_OldClassName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FClassRedirect*)Ptr)->OldClassName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FClassRedirect_OldClassName_SET(INT_PTR Ptr, char* Value) { ((FClassRedirect*)Ptr)->OldClassName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FClassRedirect_OldSubobjName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FClassRedirect*)Ptr)->OldSubobjName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FClassRedirect_OldSubobjName_SET(INT_PTR Ptr, char* Value) { ((FClassRedirect*)Ptr)->OldSubobjName = FName(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FClosestPointOnPhysicsAsset	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClosestPointOnPhysicsAsset() { return (INT_PTR) new FClosestPointOnPhysicsAsset(); }
	
	DOTNET_EXPORT char* E_PROP_FClosestPointOnPhysicsAsset_BoneName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FClosestPointOnPhysicsAsset*)Ptr)->BoneName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_BoneName_SET(INT_PTR Ptr, char* Value) { ((FClosestPointOnPhysicsAsset*)Ptr)->BoneName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_GET(INT_PTR Ptr) { return (INT_PTR)&((FClosestPointOnPhysicsAsset*)Ptr)->ClosestWorldPosition; }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_SET(INT_PTR Ptr, INT_PTR Value) { ((FClosestPointOnPhysicsAsset*)Ptr)->ClosestWorldPosition = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FClosestPointOnPhysicsAsset_Distance_GET(INT_PTR Ptr) { return ((FClosestPointOnPhysicsAsset*)Ptr)->Distance; }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_Distance_SET(INT_PTR Ptr, float Value) { ((FClosestPointOnPhysicsAsset*)Ptr)->Distance = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FClosestPointOnPhysicsAsset_Normal_GET(INT_PTR Ptr) { return (INT_PTR)&((FClosestPointOnPhysicsAsset*)Ptr)->Normal; }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_Normal_SET(INT_PTR Ptr, INT_PTR Value) { ((FClosestPointOnPhysicsAsset*)Ptr)->Normal = *(FVector*)Value; }
	
	
	/*	FClusterNode	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClusterNode() { return (INT_PTR) new FClusterNode(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FClusterNode_BoundMax_GET(INT_PTR Ptr) { return (INT_PTR)&((FClusterNode*)Ptr)->BoundMax; }
	DOTNET_EXPORT void E_PROP_FClusterNode_BoundMax_SET(INT_PTR Ptr, INT_PTR Value) { ((FClusterNode*)Ptr)->BoundMax = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FClusterNode_BoundMin_GET(INT_PTR Ptr) { return (INT_PTR)&((FClusterNode*)Ptr)->BoundMin; }
	DOTNET_EXPORT void E_PROP_FClusterNode_BoundMin_SET(INT_PTR Ptr, INT_PTR Value) { ((FClusterNode*)Ptr)->BoundMin = *(FVector*)Value; }
	
	DOTNET_EXPORT int32 E_PROP_FClusterNode_FirstChild_GET(INT_PTR Ptr) { return ((FClusterNode*)Ptr)->FirstChild; }
	DOTNET_EXPORT void E_PROP_FClusterNode_FirstChild_SET(INT_PTR Ptr, int32 Value) { ((FClusterNode*)Ptr)->FirstChild = Value; }
	
	DOTNET_EXPORT int32 E_PROP_FClusterNode_FirstInstance_GET(INT_PTR Ptr) { return ((FClusterNode*)Ptr)->FirstInstance; }
	DOTNET_EXPORT void E_PROP_FClusterNode_FirstInstance_SET(INT_PTR Ptr, int32 Value) { ((FClusterNode*)Ptr)->FirstInstance = Value; }
	
	DOTNET_EXPORT int32 E_PROP_FClusterNode_LastChild_GET(INT_PTR Ptr) { return ((FClusterNode*)Ptr)->LastChild; }
	DOTNET_EXPORT void E_PROP_FClusterNode_LastChild_SET(INT_PTR Ptr, int32 Value) { ((FClusterNode*)Ptr)->LastChild = Value; }
	
	DOTNET_EXPORT int32 E_PROP_FClusterNode_LastInstance_GET(INT_PTR Ptr) { return ((FClusterNode*)Ptr)->LastInstance; }
	DOTNET_EXPORT void E_PROP_FClusterNode_LastInstance_SET(INT_PTR Ptr, int32 Value) { ((FClusterNode*)Ptr)->LastInstance = Value; }
	
	
	/*	FColorGradePerRangeSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FColorGradePerRangeSettings() { return (INT_PTR) new FColorGradePerRangeSettings(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Contrast_GET(INT_PTR Ptr) { return (INT_PTR)&((FColorGradePerRangeSettings*)Ptr)->Contrast; }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Contrast_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Contrast = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Gain_GET(INT_PTR Ptr) { return (INT_PTR)&((FColorGradePerRangeSettings*)Ptr)->Gain; }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Gain_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Gain = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Gamma_GET(INT_PTR Ptr) { return (INT_PTR)&((FColorGradePerRangeSettings*)Ptr)->Gamma; }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Gamma_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Gamma = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Offset_GET(INT_PTR Ptr) { return (INT_PTR)&((FColorGradePerRangeSettings*)Ptr)->Offset; }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Offset_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Offset = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Saturation_GET(INT_PTR Ptr) { return (INT_PTR)&((FColorGradePerRangeSettings*)Ptr)->Saturation; }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Saturation_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Saturation = *(FVector4*)Value; }
	
	
	/*	FColorGradingSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FColorGradingSettings() { return (INT_PTR) new FColorGradingSettings(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradingSettings_Global_GET(INT_PTR Ptr) { return (INT_PTR)&((FColorGradingSettings*)Ptr)->Global; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Global_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradingSettings*)Ptr)->Global = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradingSettings_Highlights_GET(INT_PTR Ptr) { return (INT_PTR)&((FColorGradingSettings*)Ptr)->Highlights; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Highlights_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradingSettings*)Ptr)->Highlights = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT float E_PROP_FColorGradingSettings_HighlightsMin_GET(INT_PTR Ptr) { return ((FColorGradingSettings*)Ptr)->HighlightsMin; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_HighlightsMin_SET(INT_PTR Ptr, float Value) { ((FColorGradingSettings*)Ptr)->HighlightsMin = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradingSettings_Midtones_GET(INT_PTR Ptr) { return (INT_PTR)&((FColorGradingSettings*)Ptr)->Midtones; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Midtones_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradingSettings*)Ptr)->Midtones = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradingSettings_Shadows_GET(INT_PTR Ptr) { return (INT_PTR)&((FColorGradingSettings*)Ptr)->Shadows; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Shadows_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradingSettings*)Ptr)->Shadows = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT float E_PROP_FColorGradingSettings_ShadowsMax_GET(INT_PTR Ptr) { return ((FColorGradingSettings*)Ptr)->ShadowsMax; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_ShadowsMax_SET(INT_PTR Ptr, float Value) { ((FColorGradingSettings*)Ptr)->ShadowsMax = Value; }
	
	DOTNET_EXPORT auto E_FColorGradingSettings_ExportToPostProcessSettings(FColorGradingSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FConvolutionBloomSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FConvolutionBloomSettings() { return (INT_PTR) new FConvolutionBloomSettings(); }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_BufferScale_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->BufferScale; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_BufferScale_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->BufferScale = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FConvolutionBloomSettings_CenterUV_GET(INT_PTR Ptr) { return (INT_PTR)&((FConvolutionBloomSettings*)Ptr)->CenterUV; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_CenterUV_SET(INT_PTR Ptr, INT_PTR Value) { ((FConvolutionBloomSettings*)Ptr)->CenterUV = *(FVector2D*)Value; }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_PreFilterMax_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->PreFilterMax; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_PreFilterMax_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->PreFilterMax = Value; }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_PreFilterMin_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->PreFilterMin; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_PreFilterMin_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->PreFilterMin = Value; }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_PreFilterMult_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->PreFilterMult; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_PreFilterMult_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->PreFilterMult = Value; }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_Size_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->Size; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_Size_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->Size = Value; }
	
	DOTNET_EXPORT auto E_FConvolutionBloomSettings_ExportToPostProcessSettings(FConvolutionBloomSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FDestructibleChunkInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDestructibleChunkInfo() { return (INT_PTR) new FDestructibleChunkInfo(); }
	
	DOTNET_EXPORT int32 E_PROP_FDestructibleChunkInfo_ChunkIndex_GET(INT_PTR Ptr) { return ((FDestructibleChunkInfo*)Ptr)->ChunkIndex; }
	DOTNET_EXPORT void E_PROP_FDestructibleChunkInfo_ChunkIndex_SET(INT_PTR Ptr, int32 Value) { ((FDestructibleChunkInfo*)Ptr)->ChunkIndex = Value; }
	
	
	/*	FDetachmentTransformRules	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_bool(EDetachmentRule InRule, bool bInCallModify) { return (INT_PTR) new FDetachmentTransformRules(InRule, bInCallModify); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_EDetachmentRule_EDetachmentRule_bool(EDetachmentRule InLocationRule, EDetachmentRule InRotationRule, EDetachmentRule InScaleRule, bool bInCallModify) { return (INT_PTR) new FDetachmentTransformRules(InLocationRule, InRotationRule, InScaleRule, bInCallModify); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDetachmentTransformRules_FAttachmentTransformRules_bool(INT_PTR AttachmentRules, bool bInCallModify) { return (INT_PTR) new FDetachmentTransformRules(*(FAttachmentTransformRules*)AttachmentRules, bInCallModify); }
	
	DOTNET_EXPORT bool E_PROP_FDetachmentTransformRules_bCallModify_GET(INT_PTR Ptr) { return ((FDetachmentTransformRules*)Ptr)->bCallModify; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_bCallModify_SET(INT_PTR Ptr, bool Value) { ((FDetachmentTransformRules*)Ptr)->bCallModify = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FDetachmentTransformRules_KeepRelativeTransform_GET(INT_PTR Ptr) { return (INT_PTR)&((FDetachmentTransformRules*)Ptr)->KeepRelativeTransform; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_KeepRelativeTransform_SET(INT_PTR Ptr, INT_PTR Value) { ((FDetachmentTransformRules*)Ptr)->KeepRelativeTransform = *(FDetachmentTransformRules*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FDetachmentTransformRules_KeepWorldTransform_GET(INT_PTR Ptr) { return (INT_PTR)&((FDetachmentTransformRules*)Ptr)->KeepWorldTransform; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_KeepWorldTransform_SET(INT_PTR Ptr, INT_PTR Value) { ((FDetachmentTransformRules*)Ptr)->KeepWorldTransform = *(FDetachmentTransformRules*)Value; }
	
	DOTNET_EXPORT EDetachmentRule E_PROP_FDetachmentTransformRules_LocationRule_GET(INT_PTR Ptr) { return ((FDetachmentTransformRules*)Ptr)->LocationRule; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_LocationRule_SET(INT_PTR Ptr, EDetachmentRule Value) { ((FDetachmentTransformRules*)Ptr)->LocationRule = Value; }
	
	DOTNET_EXPORT EDetachmentRule E_PROP_FDetachmentTransformRules_RotationRule_GET(INT_PTR Ptr) { return ((FDetachmentTransformRules*)Ptr)->RotationRule; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_RotationRule_SET(INT_PTR Ptr, EDetachmentRule Value) { ((FDetachmentTransformRules*)Ptr)->RotationRule = Value; }
	
	DOTNET_EXPORT EDetachmentRule E_PROP_FDetachmentTransformRules_ScaleRule_GET(INT_PTR Ptr) { return ((FDetachmentTransformRules*)Ptr)->ScaleRule; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_ScaleRule_SET(INT_PTR Ptr, EDetachmentRule Value) { ((FDetachmentTransformRules*)Ptr)->ScaleRule = Value; }
	
	
	/*	FDirectAttachChildrenAccessor	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDirectAttachChildrenAccessor() { return (INT_PTR) new FDirectAttachChildrenAccessor(); }
	
	
	/*	FDropNoteInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDropNoteInfo() { return (INT_PTR) new FDropNoteInfo(); }
	
	DOTNET_EXPORT char* E_PROP_FDropNoteInfo_Comment_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FDropNoteInfo*)Ptr)->Comment;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FDropNoteInfo_Comment_SET(INT_PTR Ptr, char* Value) { ((FDropNoteInfo*)Ptr)->Comment = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FDropNoteInfo_Location_GET(INT_PTR Ptr) { return (INT_PTR)&((FDropNoteInfo*)Ptr)->Location; }
	DOTNET_EXPORT void E_PROP_FDropNoteInfo_Location_SET(INT_PTR Ptr, INT_PTR Value) { ((FDropNoteInfo*)Ptr)->Location = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FDropNoteInfo_Rotation_GET(INT_PTR Ptr) { return (INT_PTR)&((FDropNoteInfo*)Ptr)->Rotation; }
	DOTNET_EXPORT void E_PROP_FDropNoteInfo_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FDropNoteInfo*)Ptr)->Rotation = *(FRotator*)Value; }
	
	
	/*	FEngineShowFlagsSetting	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FEngineShowFlagsSetting() { return (INT_PTR) new FEngineShowFlagsSetting(); }
	
	DOTNET_EXPORT bool E_PROP_FEngineShowFlagsSetting_Enabled_GET(INT_PTR Ptr) { return ((FEngineShowFlagsSetting*)Ptr)->Enabled; }
	DOTNET_EXPORT void E_PROP_FEngineShowFlagsSetting_Enabled_SET(INT_PTR Ptr, bool Value) { ((FEngineShowFlagsSetting*)Ptr)->Enabled = Value; }
	
	DOTNET_EXPORT char* E_PROP_FEngineShowFlagsSetting_ShowFlagName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FEngineShowFlagsSetting*)Ptr)->ShowFlagName;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FEngineShowFlagsSetting_ShowFlagName_SET(INT_PTR Ptr, char* Value) { ((FEngineShowFlagsSetting*)Ptr)->ShowFlagName = UTF8_TO_TCHAR(Value); }
	
	
	/*	FExposureSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FExposureSettings() { return (INT_PTR) new FExposureSettings(); }
	
	DOTNET_EXPORT bool E_PROP_FExposureSettings_bFixed_GET(INT_PTR Ptr) { return ((FExposureSettings*)Ptr)->bFixed; }
	DOTNET_EXPORT void E_PROP_FExposureSettings_bFixed_SET(INT_PTR Ptr, bool Value) { ((FExposureSettings*)Ptr)->bFixed = Value; }
	
	DOTNET_EXPORT int32 E_PROP_FExposureSettings_LogOffset_GET(INT_PTR Ptr) { return ((FExposureSettings*)Ptr)->LogOffset; }
	DOTNET_EXPORT void E_PROP_FExposureSettings_LogOffset_SET(INT_PTR Ptr, int32 Value) { ((FExposureSettings*)Ptr)->LogOffset = Value; }
	
	DOTNET_EXPORT auto E_FExposureSettings_ToString(FExposureSettings* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	
	/*	FFilmStockSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFilmStockSettings() { return (INT_PTR) new FFilmStockSettings(); }
	
	DOTNET_EXPORT float E_PROP_FFilmStockSettings_BlackClip_GET(INT_PTR Ptr) { return ((FFilmStockSettings*)Ptr)->BlackClip; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_BlackClip_SET(INT_PTR Ptr, float Value) { ((FFilmStockSettings*)Ptr)->BlackClip = Value; }
	
	DOTNET_EXPORT float E_PROP_FFilmStockSettings_Shoulder_GET(INT_PTR Ptr) { return ((FFilmStockSettings*)Ptr)->Shoulder; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_Shoulder_SET(INT_PTR Ptr, float Value) { ((FFilmStockSettings*)Ptr)->Shoulder = Value; }
	
	DOTNET_EXPORT float E_PROP_FFilmStockSettings_Slope_GET(INT_PTR Ptr) { return ((FFilmStockSettings*)Ptr)->Slope; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_Slope_SET(INT_PTR Ptr, float Value) { ((FFilmStockSettings*)Ptr)->Slope = Value; }
	
	DOTNET_EXPORT float E_PROP_FFilmStockSettings_Toe_GET(INT_PTR Ptr) { return ((FFilmStockSettings*)Ptr)->Toe; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_Toe_SET(INT_PTR Ptr, float Value) { ((FFilmStockSettings*)Ptr)->Toe = Value; }
	
	DOTNET_EXPORT float E_PROP_FFilmStockSettings_WhiteClip_GET(INT_PTR Ptr) { return ((FFilmStockSettings*)Ptr)->WhiteClip; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_WhiteClip_SET(INT_PTR Ptr, float Value) { ((FFilmStockSettings*)Ptr)->WhiteClip = Value; }
	
	DOTNET_EXPORT auto E_FFilmStockSettings_ExportToPostProcessSettings(FFilmStockSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FFullyLoadedPackagesInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFullyLoadedPackagesInfo() { return (INT_PTR) new FFullyLoadedPackagesInfo(); }
	
	DOTNET_EXPORT char* E_PROP_FFullyLoadedPackagesInfo_Tag_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FFullyLoadedPackagesInfo*)Ptr)->Tag;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FFullyLoadedPackagesInfo_Tag_SET(INT_PTR Ptr, char* Value) { ((FFullyLoadedPackagesInfo*)Ptr)->Tag = UTF8_TO_TCHAR(Value); }
	
	
	/*	FGameNameRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FGameNameRedirect() { return (INT_PTR) new FGameNameRedirect(); }
	
	DOTNET_EXPORT char* E_PROP_FGameNameRedirect_NewGameName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FGameNameRedirect*)Ptr)->NewGameName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FGameNameRedirect_NewGameName_SET(INT_PTR Ptr, char* Value) { ((FGameNameRedirect*)Ptr)->NewGameName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FGameNameRedirect_OldGameName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FGameNameRedirect*)Ptr)->OldGameName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FGameNameRedirect_OldGameName_SET(INT_PTR Ptr, char* Value) { ((FGameNameRedirect*)Ptr)->OldGameName = FName(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FInstancedStaticMeshInstanceData	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInstancedStaticMeshInstanceData() { return (INT_PTR) new FInstancedStaticMeshInstanceData(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_GET(INT_PTR Ptr) { return (INT_PTR)&((FInstancedStaticMeshInstanceData*)Ptr)->LightmapUVBias_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_SET(INT_PTR Ptr, INT_PTR Value) { ((FInstancedStaticMeshInstanceData*)Ptr)->LightmapUVBias_DEPRECATED = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_GET(INT_PTR Ptr) { return (INT_PTR)&((FInstancedStaticMeshInstanceData*)Ptr)->ShadowmapUVBias_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_SET(INT_PTR Ptr, INT_PTR Value) { ((FInstancedStaticMeshInstanceData*)Ptr)->ShadowmapUVBias_DEPRECATED = *(FVector2D*)Value; }
	
	
	/*	FInstancedStaticMeshMappingInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInstancedStaticMeshMappingInfo() { return (INT_PTR) new FInstancedStaticMeshMappingInfo(); }
	
	
	/*	FInterpControlPoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInterpControlPoint() { return (INT_PTR) new FInterpControlPoint(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInterpControlPoint_FVector_bool(INT_PTR InPosition, bool bIsRelative) { return (INT_PTR) new FInterpControlPoint(*(FVector*)InPosition, bIsRelative); }
	
	DOTNET_EXPORT bool E_PROP_FInterpControlPoint_bPositionIsRelative_GET(INT_PTR Ptr) { return ((FInterpControlPoint*)Ptr)->bPositionIsRelative; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_bPositionIsRelative_SET(INT_PTR Ptr, bool Value) { ((FInterpControlPoint*)Ptr)->bPositionIsRelative = Value; }
	
	DOTNET_EXPORT float E_PROP_FInterpControlPoint_DistanceToNext_GET(INT_PTR Ptr) { return ((FInterpControlPoint*)Ptr)->DistanceToNext; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_DistanceToNext_SET(INT_PTR Ptr, float Value) { ((FInterpControlPoint*)Ptr)->DistanceToNext = Value; }
	
	DOTNET_EXPORT float E_PROP_FInterpControlPoint_Percentage_GET(INT_PTR Ptr) { return ((FInterpControlPoint*)Ptr)->Percentage; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_Percentage_SET(INT_PTR Ptr, float Value) { ((FInterpControlPoint*)Ptr)->Percentage = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FInterpControlPoint_PositionControlPoint_GET(INT_PTR Ptr) { return (INT_PTR)&((FInterpControlPoint*)Ptr)->PositionControlPoint; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_PositionControlPoint_SET(INT_PTR Ptr, INT_PTR Value) { ((FInterpControlPoint*)Ptr)->PositionControlPoint = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FInterpControlPoint_StartTime_GET(INT_PTR Ptr) { return ((FInterpControlPoint*)Ptr)->StartTime; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_StartTime_SET(INT_PTR Ptr, float Value) { ((FInterpControlPoint*)Ptr)->StartTime = Value; }
	
	
	/*	FLensBloomSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensBloomSettings() { return (INT_PTR) new FLensBloomSettings(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLensBloomSettings_Convolution_GET(INT_PTR Ptr) { return (INT_PTR)&((FLensBloomSettings*)Ptr)->Convolution; }
	DOTNET_EXPORT void E_PROP_FLensBloomSettings_Convolution_SET(INT_PTR Ptr, INT_PTR Value) { ((FLensBloomSettings*)Ptr)->Convolution = *(FConvolutionBloomSettings*)Value; }
	
	DOTNET_EXPORT auto E_FLensBloomSettings_ExportToPostProcessSettings(FLensBloomSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FLensImperfectionSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensImperfectionSettings() { return (INT_PTR) new FLensImperfectionSettings(); }
	
	DOTNET_EXPORT float E_PROP_FLensImperfectionSettings_DirtMaskIntensity_GET(INT_PTR Ptr) { return ((FLensImperfectionSettings*)Ptr)->DirtMaskIntensity; }
	DOTNET_EXPORT void E_PROP_FLensImperfectionSettings_DirtMaskIntensity_SET(INT_PTR Ptr, float Value) { ((FLensImperfectionSettings*)Ptr)->DirtMaskIntensity = Value; }
	
	DOTNET_EXPORT auto E_FLensImperfectionSettings_ExportToPostProcessSettings(FLensImperfectionSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FLensSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensSettings() { return (INT_PTR) new FLensSettings(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLensSettings_Bloom_GET(INT_PTR Ptr) { return (INT_PTR)&((FLensSettings*)Ptr)->Bloom; }
	DOTNET_EXPORT void E_PROP_FLensSettings_Bloom_SET(INT_PTR Ptr, INT_PTR Value) { ((FLensSettings*)Ptr)->Bloom = *(FLensBloomSettings*)Value; }
	
	DOTNET_EXPORT float E_PROP_FLensSettings_ChromaticAberration_GET(INT_PTR Ptr) { return ((FLensSettings*)Ptr)->ChromaticAberration; }
	DOTNET_EXPORT void E_PROP_FLensSettings_ChromaticAberration_SET(INT_PTR Ptr, float Value) { ((FLensSettings*)Ptr)->ChromaticAberration = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLensSettings_Imperfections_GET(INT_PTR Ptr) { return (INT_PTR)&((FLensSettings*)Ptr)->Imperfections; }
	DOTNET_EXPORT void E_PROP_FLensSettings_Imperfections_SET(INT_PTR Ptr, INT_PTR Value) { ((FLensSettings*)Ptr)->Imperfections = *(FLensImperfectionSettings*)Value; }
	
	DOTNET_EXPORT auto E_FLensSettings_ExportToPostProcessSettings(FLensSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FLevelStreamingGCHelper	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelStreamingGCHelper() { return (INT_PTR) new FLevelStreamingGCHelper(); }
	
	DOTNET_EXPORT auto E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(FLevelStreamingGCHelper* Self)
	{
		Self->AddGarbageCollectorCallback();
	}

	DOTNET_EXPORT auto E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(FLevelStreamingGCHelper* Self)
	{
		return ConvertForManage(Self->GetNumLevelsPendingPurge());
	}

	DOTNET_EXPORT auto E_FLevelStreamingGCHelper_PrepareStreamedOutLevelsForGC(FLevelStreamingGCHelper* Self)
	{
		Self->PrepareStreamedOutLevelsForGC();
	}

	DOTNET_EXPORT auto E_FLevelStreamingGCHelper_VerifyLevelsGotRemovedByGC(FLevelStreamingGCHelper* Self)
	{
		Self->VerifyLevelsGotRemovedByGC();
	}

	
	/*	FLevelStreamingStatus	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelStreamingStatus_FName_bool_bool_int32(char* InPackageName, bool bInShouldBeLoaded, bool bInShouldBeVisible, int32 InLODIndex) { return (INT_PTR) new FLevelStreamingStatus(ConvertFromManage_FName(InPackageName), bInShouldBeLoaded, bInShouldBeVisible, InLODIndex); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelStreamingStatus() { return (INT_PTR) new FLevelStreamingStatus(); }
	
	DOTNET_EXPORT char* E_PROP_FLevelStreamingStatus_PackageName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FLevelStreamingStatus*)Ptr)->PackageName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FLevelStreamingStatus_PackageName_SET(INT_PTR Ptr, char* Value) { ((FLevelStreamingStatus*)Ptr)->PackageName = FName(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FLevelViewportInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelViewportInfo() { return (INT_PTR) new FLevelViewportInfo(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelViewportInfo_FVector_FRotator_float(INT_PTR InCamPosition, INT_PTR InCamRotation, float InCamOrthoZoom) { return (INT_PTR) new FLevelViewportInfo(*(FVector*)InCamPosition, *(FRotator*)InCamRotation, InCamOrthoZoom); }
	
	DOTNET_EXPORT float E_PROP_FLevelViewportInfo_CamOrthoZoom_GET(INT_PTR Ptr) { return ((FLevelViewportInfo*)Ptr)->CamOrthoZoom; }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamOrthoZoom_SET(INT_PTR Ptr, float Value) { ((FLevelViewportInfo*)Ptr)->CamOrthoZoom = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLevelViewportInfo_CamPosition_GET(INT_PTR Ptr) { return (INT_PTR)&((FLevelViewportInfo*)Ptr)->CamPosition; }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamPosition_SET(INT_PTR Ptr, INT_PTR Value) { ((FLevelViewportInfo*)Ptr)->CamPosition = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLevelViewportInfo_CamRotation_GET(INT_PTR Ptr) { return (INT_PTR)&((FLevelViewportInfo*)Ptr)->CamRotation; }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamRotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FLevelViewportInfo*)Ptr)->CamRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT bool E_PROP_FLevelViewportInfo_CamUpdated_GET(INT_PTR Ptr) { return ((FLevelViewportInfo*)Ptr)->CamUpdated; }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamUpdated_SET(INT_PTR Ptr, bool Value) { ((FLevelViewportInfo*)Ptr)->CamUpdated = Value; }
	
	
	/*	FLightingChannels	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightingChannels() { return (INT_PTR) new FLightingChannels(); }
	
	DOTNET_EXPORT bool E_PROP_FLightingChannels_bChannel0_GET(INT_PTR Ptr) { return ((FLightingChannels*)Ptr)->bChannel0; }
	DOTNET_EXPORT void E_PROP_FLightingChannels_bChannel0_SET(INT_PTR Ptr, bool Value) { ((FLightingChannels*)Ptr)->bChannel0 = Value; }
	
	DOTNET_EXPORT bool E_PROP_FLightingChannels_bChannel1_GET(INT_PTR Ptr) { return ((FLightingChannels*)Ptr)->bChannel1; }
	DOTNET_EXPORT void E_PROP_FLightingChannels_bChannel1_SET(INT_PTR Ptr, bool Value) { ((FLightingChannels*)Ptr)->bChannel1 = Value; }
	
	DOTNET_EXPORT bool E_PROP_FLightingChannels_bChannel2_GET(INT_PTR Ptr) { return ((FLightingChannels*)Ptr)->bChannel2; }
	DOTNET_EXPORT void E_PROP_FLightingChannels_bChannel2_SET(INT_PTR Ptr, bool Value) { ((FLightingChannels*)Ptr)->bChannel2 = Value; }
	
	
	/*	FMaterialSpriteElement	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FMaterialSpriteElement() { return (INT_PTR) new FMaterialSpriteElement(); }
	
	DOTNET_EXPORT float E_PROP_FMaterialSpriteElement_BaseSizeX_GET(INT_PTR Ptr) { return ((FMaterialSpriteElement*)Ptr)->BaseSizeX; }
	DOTNET_EXPORT void E_PROP_FMaterialSpriteElement_BaseSizeX_SET(INT_PTR Ptr, float Value) { ((FMaterialSpriteElement*)Ptr)->BaseSizeX = Value; }
	
	DOTNET_EXPORT float E_PROP_FMaterialSpriteElement_BaseSizeY_GET(INT_PTR Ptr) { return ((FMaterialSpriteElement*)Ptr)->BaseSizeY; }
	DOTNET_EXPORT void E_PROP_FMaterialSpriteElement_BaseSizeY_SET(INT_PTR Ptr, float Value) { ((FMaterialSpriteElement*)Ptr)->BaseSizeY = Value; }
	
	
	/*	FNamedNetDriver	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FNamedNetDriver() { return (INT_PTR) new FNamedNetDriver(); }
	
	
	/*	FNetDriverDefinition	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FNetDriverDefinition() { return (INT_PTR) new FNetDriverDefinition(); }
	
	DOTNET_EXPORT char* E_PROP_FNetDriverDefinition_DefName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FNetDriverDefinition*)Ptr)->DefName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FNetDriverDefinition_DefName_SET(INT_PTR Ptr, char* Value) { ((FNetDriverDefinition*)Ptr)->DefName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FNetDriverDefinition_DriverClassName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FNetDriverDefinition*)Ptr)->DriverClassName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FNetDriverDefinition_DriverClassName_SET(INT_PTR Ptr, char* Value) { ((FNetDriverDefinition*)Ptr)->DriverClassName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FNetDriverDefinition_DriverClassNameFallback_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FNetDriverDefinition*)Ptr)->DriverClassNameFallback.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FNetDriverDefinition_DriverClassNameFallback_SET(INT_PTR Ptr, char* Value) { ((FNetDriverDefinition*)Ptr)->DriverClassNameFallback = FName(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FOverlapInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapInfo() { return (INT_PTR) new FOverlapInfo(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapInfo_UPrimitiveComponent_int32(UPrimitiveComponent* InComponent, int32 InBodyIndex) { return (INT_PTR) new FOverlapInfo(InComponent, InBodyIndex); }
	
	DOTNET_EXPORT bool E_PROP_FOverlapInfo_bFromSweep_GET(INT_PTR Ptr) { return ((FOverlapInfo*)Ptr)->bFromSweep; }
	DOTNET_EXPORT void E_PROP_FOverlapInfo_bFromSweep_SET(INT_PTR Ptr, bool Value) { ((FOverlapInfo*)Ptr)->bFromSweep = Value; }
	
	DOTNET_EXPORT auto E_FOverlapInfo_GetBodyIndex(FOverlapInfo* Self)
	{
		return ConvertForManage(Self->GetBodyIndex());
	}

	
	/*	FPaintedVertex	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPaintedVertex() { return (INT_PTR) new FPaintedVertex(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPaintedVertex_Position_GET(INT_PTR Ptr) { return (INT_PTR)&((FPaintedVertex*)Ptr)->Position; }
	DOTNET_EXPORT void E_PROP_FPaintedVertex_Position_SET(INT_PTR Ptr, INT_PTR Value) { ((FPaintedVertex*)Ptr)->Position = *(FVector*)Value; }
	
	
	/*	FPlane	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane() { return (INT_PTR) new FPlane(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FPlane(INT_PTR P) { return (INT_PTR) new FPlane(*(FPlane*)P); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector4(INT_PTR V) { return (INT_PTR) new FPlane(*(FVector4*)V); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_float_float_float_float(float InX, float InY, float InZ, float InW) { return (INT_PTR) new FPlane(InX, InY, InZ, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector_float(INT_PTR InNormal, float InW) { return (INT_PTR) new FPlane(*(FVector*)InNormal, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector_FVector(INT_PTR InBase, INT_PTR InNormal) { return (INT_PTR) new FPlane(*(FVector*)InBase, *(FVector*)InNormal); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector_FVector_FVector(INT_PTR A, INT_PTR B, INT_PTR C) { return (INT_PTR) new FPlane(*(FVector*)A, *(FVector*)B, *(FVector*)C); }
	
	DOTNET_EXPORT float E_PROP_FPlane_W_GET(INT_PTR Ptr) { return ((FPlane*)Ptr)->W; }
	DOTNET_EXPORT void E_PROP_FPlane_W_SET(INT_PTR Ptr, float Value) { ((FPlane*)Ptr)->W = Value; }
	
	DOTNET_EXPORT auto E_FPlane_Equals(FPlane* Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FPlane*)V;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->Equals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FPlane_Flip(FPlane* Self)
	{
		return (INT_PTR) new FPlane(Self->Flip());
	}

	DOTNET_EXPORT auto E_FPlane_PlaneDot(FPlane* Self, INT_PTR P)
	{
		auto _p0 = *(FVector*)P;
		return ConvertForManage(Self->PlaneDot(_p0));
	}

	
	/*	FPluginRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPluginRedirect() { return (INT_PTR) new FPluginRedirect(); }
	
	DOTNET_EXPORT char* E_PROP_FPluginRedirect_NewPluginName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FPluginRedirect*)Ptr)->NewPluginName;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FPluginRedirect_NewPluginName_SET(INT_PTR Ptr, char* Value) { ((FPluginRedirect*)Ptr)->NewPluginName = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT char* E_PROP_FPluginRedirect_OldPluginName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FPluginRedirect*)Ptr)->OldPluginName;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FPluginRedirect_OldPluginName_SET(INT_PTR Ptr, char* Value) { ((FPluginRedirect*)Ptr)->OldPluginName = UTF8_TO_TCHAR(Value); }
	
	
	/*	FPostProcessSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPostProcessSettings() { return (INT_PTR) new FPostProcessSettings(); }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientCubemapIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientCubemapIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientCubemapIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientCubemapIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionBias_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionBias; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionBias_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionBias = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionDistance_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionDistance_DEPRECATED = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionFadeDistance; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionFadeDistance = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionFadeRadius; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionFadeRadius = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionMipBlend; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionMipBlend = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionMipScale; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionMipScale = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionMipThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionMipThreshold = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionPower_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionPower; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionPower_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionPower = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionQuality_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionQuality; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionQuality_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionQuality = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionRadius_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionRadius; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionRadius_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionRadius = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AmbientOcclusionStaticFraction; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AmbientOcclusionStaticFraction = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AutoExposureBias_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AutoExposureBias; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureBias_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AutoExposureBias = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AutoExposureHighPercent_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AutoExposureHighPercent; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureHighPercent_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AutoExposureHighPercent = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AutoExposureLowPercent_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AutoExposureLowPercent; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureLowPercent_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AutoExposureLowPercent = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AutoExposureMaxBrightness; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AutoExposureMaxBrightness = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AutoExposureMinBrightness_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AutoExposureMinBrightness; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureMinBrightness_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AutoExposureMinBrightness = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AutoExposureSpeedDown_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AutoExposureSpeedDown; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureSpeedDown_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AutoExposureSpeedDown = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_AutoExposureSpeedUp_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->AutoExposureSpeedUp; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureSpeedUp_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->AutoExposureSpeedUp = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_Bloom1Size_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->Bloom1Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom1Size_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->Bloom1Size = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_Bloom2Size_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->Bloom2Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom2Size_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->Bloom2Size = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_Bloom3Size_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->Bloom3Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom3Size_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->Bloom3Size = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_Bloom4Size_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->Bloom4Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom4Size_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->Bloom4Size = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_Bloom5Size_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->Bloom5Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom5Size_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->Bloom5Size = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_Bloom6Size_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->Bloom6Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom6Size_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->Bloom6Size = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->BloomConvolutionBufferScale; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->BloomConvolutionBufferScale = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->BloomConvolutionCenterUV; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->BloomConvolutionCenterUV = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_BloomConvolutionPreFilter_DEPRECATED_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->BloomConvolutionPreFilter_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionPreFilter_DEPRECATED_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->BloomConvolutionPreFilter_DEPRECATED = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->BloomConvolutionPreFilterMax; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->BloomConvolutionPreFilterMax = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->BloomConvolutionPreFilterMin; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->BloomConvolutionPreFilterMin = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->BloomConvolutionPreFilterMult; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->BloomConvolutionPreFilterMult = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_BloomConvolutionSize_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->BloomConvolutionSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionSize_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->BloomConvolutionSize = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->BloomDirtMaskIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->BloomDirtMaskIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_BloomIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->BloomIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->BloomIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_BloomSizeScale_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->BloomSizeScale; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomSizeScale_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->BloomSizeScale = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_BloomThreshold_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->BloomThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomThreshold_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->BloomThreshold = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorContrast_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorContrast; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorContrast_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorContrast = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorContrastHighlights_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorContrastHighlights; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorContrastHighlights_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorContrastHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorContrastMidtones_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorContrastMidtones; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorContrastMidtones_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorContrastMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorContrastShadows_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorContrastShadows; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorContrastShadows_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorContrastShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->ColorCorrectionHighlightsMin; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->ColorCorrectionHighlightsMin = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->ColorCorrectionShadowsMax; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->ColorCorrectionShadowsMax = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorGain_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorGain; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGain_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorGain = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorGainHighlights_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorGainHighlights; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGainHighlights_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorGainHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorGainMidtones_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorGainMidtones; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGainMidtones_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorGainMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorGainShadows_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorGainShadows; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGainShadows_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorGainShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorGamma_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorGamma; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGamma_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorGamma = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorGammaHighlights_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorGammaHighlights; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGammaHighlights_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorGammaHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorGammaMidtones_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorGammaMidtones; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGammaMidtones_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorGammaMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorGammaShadows_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorGammaShadows; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGammaShadows_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorGammaShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_ColorGradingIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->ColorGradingIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGradingIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->ColorGradingIntensity = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorOffset_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorOffset; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorOffset_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorOffset = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorOffsetHighlights_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorOffsetHighlights; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorOffsetHighlights_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorOffsetHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorOffsetMidtones_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorOffsetMidtones; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorOffsetMidtones_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorOffsetMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorOffsetShadows_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorOffsetShadows; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorOffsetShadows_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorOffsetShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorSaturation_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorSaturation; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorSaturation_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorSaturation = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorSaturationHighlights_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorSaturationHighlights; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorSaturationHighlights_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorSaturationHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorSaturationMidtones_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorSaturationMidtones; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorSaturationMidtones_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorSaturationMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_ColorSaturationShadows_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->ColorSaturationShadows; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorSaturationShadows_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->ColorSaturationShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldColorThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldColorThreshold = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldDepthBlurAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldDepthBlurAmount = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldDepthBlurRadius; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldDepthBlurRadius = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldFarBlurSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldFarBlurSize = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldFarTransitionRegion; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldFarTransitionRegion = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldFocalDistance; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldFocalDistance = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldFocalRegion; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldFocalRegion = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldFstop_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldFstop; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFstop_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldFstop = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldMaxBokehSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldMaxBokehSize = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldNearBlurSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldNearBlurSize = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldNearTransitionRegion; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldNearTransitionRegion = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldOcclusion; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldOcclusion = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldScale_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldScale; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldScale_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldScale = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldSensorWidth; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldSensorWidth = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldSizeThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldSizeThreshold = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldSkyFocusDistance; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldSkyFocusDistance = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->DepthOfFieldVignetteSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->DepthOfFieldVignetteSize = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmBlackClip_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmBlackClip; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmBlackClip_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmBlackClip = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmContrast_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmContrast; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmContrast_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmContrast = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmDynamicRange_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmDynamicRange; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmDynamicRange_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmDynamicRange = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmHealAmount_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmHealAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmHealAmount_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmHealAmount = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmSaturation_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmSaturation; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmSaturation_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmSaturation = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmShadowTintAmount_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmShadowTintAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmShadowTintAmount_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmShadowTintAmount = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmShadowTintBlend_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmShadowTintBlend; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmShadowTintBlend_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmShadowTintBlend = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmShoulder_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmShoulder; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmShoulder_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmShoulder = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmSlope_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmSlope; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmSlope_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmSlope = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmToe_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmToe; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmToe_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmToe = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmToeAmount_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmToeAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmToeAmount_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmToeAmount = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_FilmWhiteClip_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->FilmWhiteClip; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmWhiteClip_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->FilmWhiteClip = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_GrainIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->GrainIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_GrainIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->GrainIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_GrainJitter_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->GrainJitter; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_GrainJitter_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->GrainJitter = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_HistogramLogMax_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->HistogramLogMax; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_HistogramLogMax_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->HistogramLogMax = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_HistogramLogMin_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->HistogramLogMin; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_HistogramLogMin_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->HistogramLogMin = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_IndirectLightingIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->IndirectLightingIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_IndirectLightingIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->IndirectLightingIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LensFlareBokehSize_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LensFlareBokehSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LensFlareBokehSize_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LensFlareBokehSize = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LensFlareIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LensFlareIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LensFlareIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LensFlareIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LensFlareThreshold_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LensFlareThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LensFlareThreshold_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LensFlareThreshold = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVDiffuseOcclusionExponent; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVDiffuseOcclusionExponent = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVDiffuseOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVDiffuseOcclusionIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVDirectionalOcclusionFadeRange; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVDirectionalOcclusionFadeRange = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVDirectionalOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVDirectionalOcclusionIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVDirectionalOcclusionRadius; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVDirectionalOcclusionRadius = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVEmissiveInjectionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVEmissiveInjectionIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVFadeRange_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVFadeRange; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVFadeRange_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVFadeRange = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVGeometryVolumeBias; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVGeometryVolumeBias = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVSecondaryBounceIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVSecondaryBounceIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVSecondaryOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVSecondaryOcclusionIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVSize_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSize_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVSize = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVSpecularOcclusionExponent; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVSpecularOcclusionExponent = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVSpecularOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVSpecularOcclusionIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_LPVVplInjectionBias_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->LPVVplInjectionBias; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVVplInjectionBias_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->LPVVplInjectionBias = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_MotionBlurAmount_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->MotionBlurAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_MotionBlurAmount_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->MotionBlurAmount = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_MotionBlurMax_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->MotionBlurMax; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_MotionBlurMax_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->MotionBlurMax = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->MotionBlurPerObjectSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->MotionBlurPerObjectSize = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_SceneFringeIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->SceneFringeIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_SceneFringeIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->SceneFringeIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_ScreenPercentage_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->ScreenPercentage; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ScreenPercentage_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->ScreenPercentage = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->ScreenSpaceReflectionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->ScreenSpaceReflectionIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->ScreenSpaceReflectionMaxRoughness; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->ScreenSpaceReflectionMaxRoughness = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->ScreenSpaceReflectionQuality; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->ScreenSpaceReflectionQuality = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_VignetteIntensity_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->VignetteIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_VignetteIntensity_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->VignetteIntensity = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPostProcessSettings_WeightedBlendables_GET(INT_PTR Ptr) { return (INT_PTR)&((FPostProcessSettings*)Ptr)->WeightedBlendables; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_WeightedBlendables_SET(INT_PTR Ptr, INT_PTR Value) { ((FPostProcessSettings*)Ptr)->WeightedBlendables = *(FWeightedBlendables*)Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_WhiteTemp_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->WhiteTemp; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_WhiteTemp_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->WhiteTemp = Value; }
	
	DOTNET_EXPORT float E_PROP_FPostProcessSettings_WhiteTint_GET(INT_PTR Ptr) { return ((FPostProcessSettings*)Ptr)->WhiteTint; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_WhiteTint_SET(INT_PTR Ptr, float Value) { ((FPostProcessSettings*)Ptr)->WhiteTint = Value; }
	
	DOTNET_EXPORT auto E_FPostProcessSettings_OnAfterLoad(FPostProcessSettings* Self)
	{
		Self->OnAfterLoad();
	}

	DOTNET_EXPORT auto E_FPostProcessSettings_SetBaseValues(FPostProcessSettings* Self)
	{
		Self->SetBaseValues();
	}

	
	/*	FPreCulledStaticMeshSection	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPreCulledStaticMeshSection() { return (INT_PTR) new FPreCulledStaticMeshSection(); }
	
	
	/*	FQuat	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat() { return (INT_PTR) new FQuat(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_float_float_float_float(float InX, float InY, float InZ, float InW) { return (INT_PTR) new FQuat(InX, InY, InZ, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_FQuat(INT_PTR Q) { return (INT_PTR) new FQuat(*(FQuat*)Q); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_FRotator(INT_PTR R) { return (INT_PTR) new FQuat(*(FRotator*)R); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_FVector_float(INT_PTR Axis, float AngleRad) { return (INT_PTR) new FQuat(*(FVector*)Axis, AngleRad); }
	
	DOTNET_EXPORT float E_PROP_FQuat_W_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->W; }
	DOTNET_EXPORT void E_PROP_FQuat_W_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->W = Value; }
	
	DOTNET_EXPORT float E_PROP_FQuat_X_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->X; }
	DOTNET_EXPORT void E_PROP_FQuat_X_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_PROP_FQuat_Y_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->Y; }
	DOTNET_EXPORT void E_PROP_FQuat_Y_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT float E_PROP_FQuat_Z_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->Z; }
	DOTNET_EXPORT void E_PROP_FQuat_Z_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->Z = Value; }
	
	DOTNET_EXPORT auto E_FQuat_AngularDistance(FQuat* Self, INT_PTR Q)
	{
		auto _p0 = *(FQuat*)Q;
		return ConvertForManage(Self->AngularDistance(_p0));
	}

	DOTNET_EXPORT auto E_FQuat_CalcTangents(FQuat* Self, INT_PTR PrevP, INT_PTR P, INT_PTR NextP, float Tension, INT_PTR OutTan)
	{
		auto _p0 = *(FQuat*)PrevP;
		auto _p1 = *(FQuat*)P;
		auto _p2 = *(FQuat*)NextP;
		auto _p3 = Tension;
		auto _p4 = *(FQuat*)OutTan;
		Self->CalcTangents(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_FQuat_ContainsNaN(FQuat* Self)
	{
		return ConvertForManage(Self->ContainsNaN());
	}

	DOTNET_EXPORT auto E_FQuat_EnforceShortestArcWith(FQuat* Self, INT_PTR OtherQuat)
	{
		auto _p0 = *(FQuat*)OtherQuat;
		Self->EnforceShortestArcWith(_p0);
	}

	DOTNET_EXPORT auto E_FQuat_Equals(FQuat* Self, INT_PTR Q, float Tolerance)
	{
		auto _p0 = *(FQuat*)Q;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->Equals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FQuat_Error(FQuat* Self, INT_PTR Q1, INT_PTR Q2)
	{
		auto _p0 = *(FQuat*)Q1;
		auto _p1 = *(FQuat*)Q2;
		return ConvertForManage(Self->Error(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FQuat_ErrorAutoNormalize(FQuat* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		return ConvertForManage(Self->ErrorAutoNormalize(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FQuat_Euler(FQuat* Self)
	{
		return (INT_PTR) new FVector(Self->Euler());
	}

	DOTNET_EXPORT auto E_FQuat_Exp(FQuat* Self)
	{
		return (INT_PTR) new FQuat(Self->Exp());
	}

	DOTNET_EXPORT auto E_FQuat_FastBilerp(FQuat* Self, INT_PTR P00, INT_PTR P10, INT_PTR P01, INT_PTR P11, float FracX, float FracY)
	{
		auto _p0 = *(FQuat*)P00;
		auto _p1 = *(FQuat*)P10;
		auto _p2 = *(FQuat*)P01;
		auto _p3 = *(FQuat*)P11;
		auto _p4 = FracX;
		auto _p5 = FracY;
		return (INT_PTR) new FQuat(Self->FastBilerp(_p0, _p1, _p2, _p3, _p4, _p5));
	}

	DOTNET_EXPORT auto E_FQuat_FastLerp(FQuat* Self, INT_PTR A, INT_PTR B, float Alpha)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = Alpha;
		return (INT_PTR) new FQuat(Self->FastLerp(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FQuat_FindBetween(FQuat* Self, INT_PTR Vector1, INT_PTR Vector2)
	{
		auto _p0 = *(FVector*)Vector1;
		auto _p1 = *(FVector*)Vector2;
		return (INT_PTR) new FQuat(Self->FindBetween(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FQuat_FindBetweenNormals(FQuat* Self, INT_PTR Normal1, INT_PTR Normal2)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		return (INT_PTR) new FQuat(Self->FindBetweenNormals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FQuat_FindBetweenVectors(FQuat* Self, INT_PTR Vector1, INT_PTR Vector2)
	{
		auto _p0 = *(FVector*)Vector1;
		auto _p1 = *(FVector*)Vector2;
		return (INT_PTR) new FQuat(Self->FindBetweenVectors(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FQuat_GetAxisX(FQuat* Self)
	{
		return (INT_PTR) new FVector(Self->GetAxisX());
	}

	DOTNET_EXPORT auto E_FQuat_GetAxisY(FQuat* Self)
	{
		return (INT_PTR) new FVector(Self->GetAxisY());
	}

	DOTNET_EXPORT auto E_FQuat_GetAxisZ(FQuat* Self)
	{
		return (INT_PTR) new FVector(Self->GetAxisZ());
	}

	DOTNET_EXPORT auto E_FQuat_GetForwardVector(FQuat* Self)
	{
		return (INT_PTR) new FVector(Self->GetForwardVector());
	}

	DOTNET_EXPORT auto E_FQuat_GetNormalized(FQuat* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FQuat(Self->GetNormalized(_p0));
	}

	DOTNET_EXPORT auto E_FQuat_GetRightVector(FQuat* Self)
	{
		return (INT_PTR) new FVector(Self->GetRightVector());
	}

	DOTNET_EXPORT auto E_FQuat_GetRotationAxis(FQuat* Self)
	{
		return (INT_PTR) new FVector(Self->GetRotationAxis());
	}

	DOTNET_EXPORT auto E_FQuat_GetUpVector(FQuat* Self)
	{
		return (INT_PTR) new FVector(Self->GetUpVector());
	}

	DOTNET_EXPORT auto E_FQuat_Inverse(FQuat* Self)
	{
		return (INT_PTR) new FQuat(Self->Inverse());
	}

	DOTNET_EXPORT auto E_FQuat_IsIdentity(FQuat* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ConvertForManage(Self->IsIdentity(_p0));
	}

	DOTNET_EXPORT auto E_FQuat_IsNormalized(FQuat* Self)
	{
		return ConvertForManage(Self->IsNormalized());
	}

	DOTNET_EXPORT auto E_FQuat_Log(FQuat* Self)
	{
		return (INT_PTR) new FQuat(Self->Log());
	}

	DOTNET_EXPORT auto E_FQuat_MakeFromEuler(FQuat* Self, INT_PTR Euler)
	{
		auto _p0 = *(FVector*)Euler;
		return (INT_PTR) new FQuat(Self->MakeFromEuler(_p0));
	}

	DOTNET_EXPORT auto E_FQuat_Normalize(FQuat* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		Self->Normalize(_p0);
	}

	DOTNET_EXPORT auto E_FQuat_RotateVector(FQuat* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->RotateVector(_p0));
	}

	DOTNET_EXPORT auto E_FQuat_Rotator(FQuat* Self)
	{
		return (INT_PTR) new FRotator(Self->Rotator());
	}

	DOTNET_EXPORT auto E_FQuat_Size(FQuat* Self)
	{
		return ConvertForManage(Self->Size());
	}

	DOTNET_EXPORT auto E_FQuat_SizeSquared(FQuat* Self)
	{
		return ConvertForManage(Self->SizeSquared());
	}

	DOTNET_EXPORT auto E_FQuat_Slerp(FQuat* Self, INT_PTR Quat1, INT_PTR Quat2, float Slerp)
	{
		auto _p0 = *(FQuat*)Quat1;
		auto _p1 = *(FQuat*)Quat2;
		auto _p2 = Slerp;
		return (INT_PTR) new FQuat(Self->Slerp(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FQuat_Slerp_NotNormalized(FQuat* Self, INT_PTR Quat1, INT_PTR Quat2, float Slerp)
	{
		auto _p0 = *(FQuat*)Quat1;
		auto _p1 = *(FQuat*)Quat2;
		auto _p2 = Slerp;
		return (INT_PTR) new FQuat(Self->Slerp_NotNormalized(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FQuat_SlerpFullPath(FQuat* Self, INT_PTR quat1, INT_PTR quat2, float Alpha)
	{
		auto _p0 = *(FQuat*)quat1;
		auto _p1 = *(FQuat*)quat2;
		auto _p2 = Alpha;
		return (INT_PTR) new FQuat(Self->SlerpFullPath(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FQuat_SlerpFullPath_NotNormalized(FQuat* Self, INT_PTR quat1, INT_PTR quat2, float Alpha)
	{
		auto _p0 = *(FQuat*)quat1;
		auto _p1 = *(FQuat*)quat2;
		auto _p2 = Alpha;
		return (INT_PTR) new FQuat(Self->SlerpFullPath_NotNormalized(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FQuat_Squad(FQuat* Self, INT_PTR quat1, INT_PTR tang1, INT_PTR quat2, INT_PTR tang2, float Alpha)
	{
		auto _p0 = *(FQuat*)quat1;
		auto _p1 = *(FQuat*)tang1;
		auto _p2 = *(FQuat*)quat2;
		auto _p3 = *(FQuat*)tang2;
		auto _p4 = Alpha;
		return (INT_PTR) new FQuat(Self->Squad(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT auto E_FQuat_SquadFullPath(FQuat* Self, INT_PTR quat1, INT_PTR tang1, INT_PTR quat2, INT_PTR tang2, float Alpha)
	{
		auto _p0 = *(FQuat*)quat1;
		auto _p1 = *(FQuat*)tang1;
		auto _p2 = *(FQuat*)quat2;
		auto _p3 = *(FQuat*)tang2;
		auto _p4 = Alpha;
		return (INT_PTR) new FQuat(Self->SquadFullPath(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT auto E_FQuat_ToAxisAndAngle(FQuat* Self, INT_PTR Axis, float Angle)
	{
		auto _p0 = *(FVector*)Axis;
		auto _p1 = Angle;
		Self->ToAxisAndAngle(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FQuat_ToString(FQuat* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FQuat_ToSwingTwist(FQuat* Self, INT_PTR InTwistAxis, INT_PTR OutSwing, INT_PTR OutTwist)
	{
		auto _p0 = *(FVector*)InTwistAxis;
		auto _p1 = *(FQuat*)OutSwing;
		auto _p2 = *(FQuat*)OutTwist;
		Self->ToSwingTwist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FQuat_UnrotateVector(FQuat* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->UnrotateVector(_p0));
	}

	DOTNET_EXPORT auto E_FQuat_Vector(FQuat* Self)
	{
		return (INT_PTR) new FVector(Self->Vector());
	}

	
	/*	FReflectionCaptureFullHDR	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FReflectionCaptureFullHDR() { return (INT_PTR) new FReflectionCaptureFullHDR(); }
	
	DOTNET_EXPORT int32 E_PROP_FReflectionCaptureFullHDR_CubemapSize_GET(INT_PTR Ptr) { return ((FReflectionCaptureFullHDR*)Ptr)->CubemapSize; }
	DOTNET_EXPORT void E_PROP_FReflectionCaptureFullHDR_CubemapSize_SET(INT_PTR Ptr, int32 Value) { ((FReflectionCaptureFullHDR*)Ptr)->CubemapSize = Value; }
	
	DOTNET_EXPORT auto E_FReflectionCaptureFullHDR_HasValidData(FReflectionCaptureFullHDR* Self)
	{
		return ConvertForManage(Self->HasValidData());
	}

	
	/*	FRendererStencilMaskEvaluation	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRendererStencilMaskEvaluation() { return (INT_PTR) new FRendererStencilMaskEvaluation(); }
	
	
	/*	FRepRootMotionMontage	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRepRootMotionMontage() { return (INT_PTR) new FRepRootMotionMontage(); }
	
	DOTNET_EXPORT bool E_PROP_FRepRootMotionMontage_bIsActive_GET(INT_PTR Ptr) { return ((FRepRootMotionMontage*)Ptr)->bIsActive; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_bIsActive_SET(INT_PTR Ptr, bool Value) { ((FRepRootMotionMontage*)Ptr)->bIsActive = Value; }
	
	DOTNET_EXPORT bool E_PROP_FRepRootMotionMontage_bRelativePosition_GET(INT_PTR Ptr) { return ((FRepRootMotionMontage*)Ptr)->bRelativePosition; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_bRelativePosition_SET(INT_PTR Ptr, bool Value) { ((FRepRootMotionMontage*)Ptr)->bRelativePosition = Value; }
	
	DOTNET_EXPORT bool E_PROP_FRepRootMotionMontage_bRelativeRotation_GET(INT_PTR Ptr) { return ((FRepRootMotionMontage*)Ptr)->bRelativeRotation; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_bRelativeRotation_SET(INT_PTR Ptr, bool Value) { ((FRepRootMotionMontage*)Ptr)->bRelativeRotation = Value; }
	
	DOTNET_EXPORT UPrimitiveComponent* E_PROP_FRepRootMotionMontage_MovementBase_GET(INT_PTR Ptr) { return ((FRepRootMotionMontage*)Ptr)->MovementBase; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_MovementBase_SET(INT_PTR Ptr, UPrimitiveComponent* Value) { ((FRepRootMotionMontage*)Ptr)->MovementBase = Value; }
	
	DOTNET_EXPORT char* E_PROP_FRepRootMotionMontage_MovementBaseBoneName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FRepRootMotionMontage*)Ptr)->MovementBaseBoneName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_MovementBaseBoneName_SET(INT_PTR Ptr, char* Value) { ((FRepRootMotionMontage*)Ptr)->MovementBaseBoneName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT float E_PROP_FRepRootMotionMontage_Position_GET(INT_PTR Ptr) { return ((FRepRootMotionMontage*)Ptr)->Position; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_Position_SET(INT_PTR Ptr, float Value) { ((FRepRootMotionMontage*)Ptr)->Position = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FRepRootMotionMontage_Rotation_GET(INT_PTR Ptr) { return (INT_PTR)&((FRepRootMotionMontage*)Ptr)->Rotation; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FRepRootMotionMontage*)Ptr)->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_FRepRootMotionMontage_Clear(FRepRootMotionMontage* Self)
	{
		Self->Clear();
	}

	DOTNET_EXPORT auto E_FRepRootMotionMontage_HasRootMotion(FRepRootMotionMontage* Self)
	{
		return ConvertForManage(Self->HasRootMotion());
	}

	
	/*	FRotator	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator() { return (INT_PTR) new FRotator(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator_float(float InF) { return (INT_PTR) new FRotator(InF); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator_float_float_float(float InPitch, float InYaw, float InRoll) { return (INT_PTR) new FRotator(InPitch, InYaw, InRoll); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator_FQuat(INT_PTR Quat) { return (INT_PTR) new FRotator(*(FQuat*)Quat); }
	
	DOTNET_EXPORT float E_PROP_FRotator_Pitch_GET(INT_PTR Ptr) { return ((FRotator*)Ptr)->Pitch; }
	DOTNET_EXPORT void E_PROP_FRotator_Pitch_SET(INT_PTR Ptr, float Value) { ((FRotator*)Ptr)->Pitch = Value; }
	
	DOTNET_EXPORT float E_PROP_FRotator_Roll_GET(INT_PTR Ptr) { return ((FRotator*)Ptr)->Roll; }
	DOTNET_EXPORT void E_PROP_FRotator_Roll_SET(INT_PTR Ptr, float Value) { ((FRotator*)Ptr)->Roll = Value; }
	
	DOTNET_EXPORT float E_PROP_FRotator_Yaw_GET(INT_PTR Ptr) { return ((FRotator*)Ptr)->Yaw; }
	DOTNET_EXPORT void E_PROP_FRotator_Yaw_SET(INT_PTR Ptr, float Value) { ((FRotator*)Ptr)->Yaw = Value; }
	
	DOTNET_EXPORT auto E_FRotator_Add(FRotator* Self, float DeltaPitch, float DeltaYaw, float DeltaRoll)
	{
		auto _p0 = DeltaPitch;
		auto _p1 = DeltaYaw;
		auto _p2 = DeltaRoll;
		return (INT_PTR) new FRotator(Self->Add(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FRotator_Clamp(FRotator* Self)
	{
		return (INT_PTR) new FRotator(Self->Clamp());
	}

	DOTNET_EXPORT auto E_FRotator_ClampAxis(FRotator* Self, float Angle)
	{
		auto _p0 = Angle;
		return ConvertForManage(Self->ClampAxis(_p0));
	}

	DOTNET_EXPORT auto E_FRotator_CompressAxisToByte(FRotator* Self, float Angle)
	{
		auto _p0 = Angle;
		return ConvertForManage(Self->CompressAxisToByte(_p0));
	}

	DOTNET_EXPORT auto E_FRotator_ContainsNaN(FRotator* Self)
	{
		return ConvertForManage(Self->ContainsNaN());
	}

	DOTNET_EXPORT auto E_FRotator_Equals(FRotator* Self, INT_PTR R, float Tolerance)
	{
		auto _p0 = *(FRotator*)R;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->Equals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FRotator_Euler(FRotator* Self)
	{
		return (INT_PTR) new FVector(Self->Euler());
	}

	DOTNET_EXPORT auto E_FRotator_GetDenormalized(FRotator* Self)
	{
		return (INT_PTR) new FRotator(Self->GetDenormalized());
	}

	DOTNET_EXPORT auto E_FRotator_GetInverse(FRotator* Self)
	{
		return (INT_PTR) new FRotator(Self->GetInverse());
	}

	DOTNET_EXPORT auto E_FRotator_GetNormalized(FRotator* Self)
	{
		return (INT_PTR) new FRotator(Self->GetNormalized());
	}

	DOTNET_EXPORT auto E_FRotator_GetWindingAndRemainder(FRotator* Self, INT_PTR Winding, INT_PTR Remainder)
	{
		auto _p0 = *(FRotator*)Winding;
		auto _p1 = *(FRotator*)Remainder;
		Self->GetWindingAndRemainder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FRotator_GridSnap(FRotator* Self, INT_PTR RotGrid)
	{
		auto _p0 = *(FRotator*)RotGrid;
		return (INT_PTR) new FRotator(Self->GridSnap(_p0));
	}

	DOTNET_EXPORT auto E_FRotator_InitFromString(FRotator* Self, char* InSourceString)
	{
		auto _p0 = ConvertFromManage_FString(InSourceString);
		return ConvertForManage(Self->InitFromString(_p0));
	}

	DOTNET_EXPORT auto E_FRotator_IsNearlyZero(FRotator* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ConvertForManage(Self->IsNearlyZero(_p0));
	}

	DOTNET_EXPORT auto E_FRotator_IsZero(FRotator* Self)
	{
		return ConvertForManage(Self->IsZero());
	}

	DOTNET_EXPORT auto E_FRotator_MakeFromEuler(FRotator* Self, INT_PTR Euler)
	{
		auto _p0 = *(FVector*)Euler;
		return (INT_PTR) new FRotator(Self->MakeFromEuler(_p0));
	}

	DOTNET_EXPORT auto E_FRotator_Normalize(FRotator* Self)
	{
		Self->Normalize();
	}

	DOTNET_EXPORT auto E_FRotator_NormalizeAxis(FRotator* Self, float Angle)
	{
		auto _p0 = Angle;
		return ConvertForManage(Self->NormalizeAxis(_p0));
	}

	DOTNET_EXPORT auto E_FRotator_Quaternion(FRotator* Self)
	{
		return (INT_PTR) new FQuat(Self->Quaternion());
	}

	DOTNET_EXPORT auto E_FRotator_RotateVector(FRotator* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->RotateVector(_p0));
	}

	DOTNET_EXPORT auto E_FRotator_ToCompactString(FRotator* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToCompactString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FRotator_ToString(FRotator* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FRotator_UnrotateVector(FRotator* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->UnrotateVector(_p0));
	}

	DOTNET_EXPORT auto E_FRotator_Vector(FRotator* Self)
	{
		return (INT_PTR) new FVector(Self->Vector());
	}

	
	/*	FSceneCaptureViewInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSceneCaptureViewInfo() { return (INT_PTR) new FSceneCaptureViewInfo(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(INT_PTR Ptr) { return (INT_PTR)&((FSceneCaptureViewInfo*)Ptr)->ViewLocation; }
	DOTNET_EXPORT void E_PROP_FSceneCaptureViewInfo_ViewLocation_SET(INT_PTR Ptr, INT_PTR Value) { ((FSceneCaptureViewInfo*)Ptr)->ViewLocation = *(FVector*)Value; }
	
	
	/*	FScreenMessageString	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FScreenMessageString() { return (INT_PTR) new FScreenMessageString(); }
	
	DOTNET_EXPORT float E_PROP_FScreenMessageString_CurrentTimeDisplayed_GET(INT_PTR Ptr) { return ((FScreenMessageString*)Ptr)->CurrentTimeDisplayed; }
	DOTNET_EXPORT void E_PROP_FScreenMessageString_CurrentTimeDisplayed_SET(INT_PTR Ptr, float Value) { ((FScreenMessageString*)Ptr)->CurrentTimeDisplayed = Value; }
	
	DOTNET_EXPORT char* E_PROP_FScreenMessageString_ScreenMessage_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FScreenMessageString*)Ptr)->ScreenMessage;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FScreenMessageString_ScreenMessage_SET(INT_PTR Ptr, char* Value) { ((FScreenMessageString*)Ptr)->ScreenMessage = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FScreenMessageString_TextScale_GET(INT_PTR Ptr) { return (INT_PTR)&((FScreenMessageString*)Ptr)->TextScale; }
	DOTNET_EXPORT void E_PROP_FScreenMessageString_TextScale_SET(INT_PTR Ptr, INT_PTR Value) { ((FScreenMessageString*)Ptr)->TextScale = *(FVector2D*)Value; }
	
	DOTNET_EXPORT float E_PROP_FScreenMessageString_TimeToDisplay_GET(INT_PTR Ptr) { return ((FScreenMessageString*)Ptr)->TimeToDisplay; }
	DOTNET_EXPORT void E_PROP_FScreenMessageString_TimeToDisplay_SET(INT_PTR Ptr, float Value) { ((FScreenMessageString*)Ptr)->TimeToDisplay = Value; }
	
	
	/*	FSimulatedRootMotionReplicatedMove	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSimulatedRootMotionReplicatedMove() { return (INT_PTR) new FSimulatedRootMotionReplicatedMove(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_GET(INT_PTR Ptr) { return (INT_PTR)&((FSimulatedRootMotionReplicatedMove*)Ptr)->RootMotion; }
	DOTNET_EXPORT void E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_SET(INT_PTR Ptr, INT_PTR Value) { ((FSimulatedRootMotionReplicatedMove*)Ptr)->RootMotion = *(FRepRootMotionMontage*)Value; }
	
	DOTNET_EXPORT float E_PROP_FSimulatedRootMotionReplicatedMove_Time_GET(INT_PTR Ptr) { return ((FSimulatedRootMotionReplicatedMove*)Ptr)->Time; }
	DOTNET_EXPORT void E_PROP_FSimulatedRootMotionReplicatedMove_Time_SET(INT_PTR Ptr, float Value) { ((FSimulatedRootMotionReplicatedMove*)Ptr)->Time = Value; }
	
	
	/*	FSkelMeshComponentLODInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSkelMeshComponentLODInfo() { return (INT_PTR) new FSkelMeshComponentLODInfo(); }
	
	DOTNET_EXPORT auto E_FSkelMeshComponentLODInfo_BeginReleaseOverrideSkinWeights(FSkelMeshComponentLODInfo* Self)
	{
		Self->BeginReleaseOverrideSkinWeights();
	}

	DOTNET_EXPORT auto E_FSkelMeshComponentLODInfo_BeginReleaseOverrideVertexColors(FSkelMeshComponentLODInfo* Self)
	{
		Self->BeginReleaseOverrideVertexColors();
	}

	DOTNET_EXPORT auto E_FSkelMeshComponentLODInfo_CleanUp(FSkelMeshComponentLODInfo* Self)
	{
		Self->CleanUp();
	}

	DOTNET_EXPORT auto E_FSkelMeshComponentLODInfo_ReleaseOverrideSkinWeightsAndBlock(FSkelMeshComponentLODInfo* Self)
	{
		Self->ReleaseOverrideSkinWeightsAndBlock();
	}

	DOTNET_EXPORT auto E_FSkelMeshComponentLODInfo_ReleaseOverrideVertexColorsAndBlock(FSkelMeshComponentLODInfo* Self)
	{
		Self->ReleaseOverrideVertexColorsAndBlock();
	}

	
	/*	FSkelMeshRefPoseOverride	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSkelMeshRefPoseOverride() { return (INT_PTR) new FSkelMeshRefPoseOverride(); }
	
	
	/*	FSplineCurves	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplineCurves() { return (INT_PTR) new FSplineCurves(); }
	
	DOTNET_EXPORT auto E_FSplineCurves_GetSegmentLength(FSplineCurves* Self, int32 Index, float Param, bool bClosedLoop, INT_PTR Scale3D)
	{
		auto _p0 = Index;
		auto _p1 = Param;
		auto _p2 = bClosedLoop;
		auto _p3 = *(FVector*)Scale3D;
		return ConvertForManage(Self->GetSegmentLength(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_FSplineCurves_GetSplineLength(FSplineCurves* Self)
	{
		return ConvertForManage(Self->GetSplineLength());
	}

	DOTNET_EXPORT auto E_FSplineCurves_UpdateSpline(FSplineCurves* Self, bool bClosedLoop, bool bStationaryEndpoints, int32 ReparamStepsPerSegment, bool bLoopPositionOverride, float LoopPosition, INT_PTR Scale3D)
	{
		auto _p0 = bClosedLoop;
		auto _p1 = bStationaryEndpoints;
		auto _p2 = ReparamStepsPerSegment;
		auto _p3 = bLoopPositionOverride;
		auto _p4 = LoopPosition;
		auto _p5 = *(FVector*)Scale3D;
		Self->UpdateSpline(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	
	/*	FSplineMeshParams	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplineMeshParams() { return (INT_PTR) new FSplineMeshParams(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_EndOffset_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplineMeshParams*)Ptr)->EndOffset; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndOffset_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->EndOffset = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_EndPos_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplineMeshParams*)Ptr)->EndPos; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndPos_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->EndPos = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FSplineMeshParams_EndRoll_GET(INT_PTR Ptr) { return ((FSplineMeshParams*)Ptr)->EndRoll; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndRoll_SET(INT_PTR Ptr, float Value) { ((FSplineMeshParams*)Ptr)->EndRoll = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_EndScale_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplineMeshParams*)Ptr)->EndScale; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndScale_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->EndScale = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_EndTangent_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplineMeshParams*)Ptr)->EndTangent; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndTangent_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->EndTangent = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_StartOffset_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplineMeshParams*)Ptr)->StartOffset; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartOffset_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->StartOffset = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_StartPos_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplineMeshParams*)Ptr)->StartPos; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartPos_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->StartPos = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FSplineMeshParams_StartRoll_GET(INT_PTR Ptr) { return ((FSplineMeshParams*)Ptr)->StartRoll; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartRoll_SET(INT_PTR Ptr, float Value) { ((FSplineMeshParams*)Ptr)->StartRoll = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_StartScale_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplineMeshParams*)Ptr)->StartScale; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartScale_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->StartScale = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_StartTangent_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplineMeshParams*)Ptr)->StartTangent; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartTangent_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->StartTangent = *(FVector*)Value; }
	
	
	/*	FSplinePoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplinePoint() { return (INT_PTR) new FSplinePoint(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplinePoint_float_FVector(float InInputKey, INT_PTR InPosition) { return (INT_PTR) new FSplinePoint(InInputKey, *(FVector*)InPosition); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_ArriveTangent_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplinePoint*)Ptr)->ArriveTangent; }
	DOTNET_EXPORT void E_PROP_FSplinePoint_ArriveTangent_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplinePoint*)Ptr)->ArriveTangent = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FSplinePoint_InputKey_GET(INT_PTR Ptr) { return ((FSplinePoint*)Ptr)->InputKey; }
	DOTNET_EXPORT void E_PROP_FSplinePoint_InputKey_SET(INT_PTR Ptr, float Value) { ((FSplinePoint*)Ptr)->InputKey = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_LeaveTangent_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplinePoint*)Ptr)->LeaveTangent; }
	DOTNET_EXPORT void E_PROP_FSplinePoint_LeaveTangent_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplinePoint*)Ptr)->LeaveTangent = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_Position_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplinePoint*)Ptr)->Position; }
	DOTNET_EXPORT void E_PROP_FSplinePoint_Position_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplinePoint*)Ptr)->Position = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_Rotation_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplinePoint*)Ptr)->Rotation; }
	DOTNET_EXPORT void E_PROP_FSplinePoint_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplinePoint*)Ptr)->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_Scale_GET(INT_PTR Ptr) { return (INT_PTR)&((FSplinePoint*)Ptr)->Scale; }
	DOTNET_EXPORT void E_PROP_FSplinePoint_Scale_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplinePoint*)Ptr)->Scale = *(FVector*)Value; }
	
	
	/*	FSpriteCategoryInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSpriteCategoryInfo() { return (INT_PTR) new FSpriteCategoryInfo(); }
	
	DOTNET_EXPORT char* E_PROP_FSpriteCategoryInfo_Category_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FSpriteCategoryInfo*)Ptr)->Category.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FSpriteCategoryInfo_Category_SET(INT_PTR Ptr, char* Value) { ((FSpriteCategoryInfo*)Ptr)->Category = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FSpriteCategoryInfo_Description_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FSpriteCategoryInfo*)Ptr)->Description.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FSpriteCategoryInfo_Description_SET(INT_PTR Ptr, char* Value) { ((FSpriteCategoryInfo*)Ptr)->Description = FText::FromString(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FSpriteCategoryInfo_DisplayName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FSpriteCategoryInfo*)Ptr)->DisplayName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FSpriteCategoryInfo_DisplayName_SET(INT_PTR Ptr, char* Value) { ((FSpriteCategoryInfo*)Ptr)->DisplayName = FText::FromString(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FStatColorMapEntry	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStatColorMapEntry() { return (INT_PTR) new FStatColorMapEntry(); }
	
	DOTNET_EXPORT float E_PROP_FStatColorMapEntry_In_GET(INT_PTR Ptr) { return ((FStatColorMapEntry*)Ptr)->In; }
	DOTNET_EXPORT void E_PROP_FStatColorMapEntry_In_SET(INT_PTR Ptr, float Value) { ((FStatColorMapEntry*)Ptr)->In = Value; }
	
	
	/*	FStatColorMapping	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStatColorMapping() { return (INT_PTR) new FStatColorMapping(); }
	
	DOTNET_EXPORT char* E_PROP_FStatColorMapping_StatName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FStatColorMapping*)Ptr)->StatName;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FStatColorMapping_StatName_SET(INT_PTR Ptr, char* Value) { ((FStatColorMapping*)Ptr)->StatName = UTF8_TO_TCHAR(Value); }
	
	
	/*	FStructRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStructRedirect() { return (INT_PTR) new FStructRedirect(); }
	
	DOTNET_EXPORT char* E_PROP_FStructRedirect_NewStructName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FStructRedirect*)Ptr)->NewStructName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FStructRedirect_NewStructName_SET(INT_PTR Ptr, char* Value) { ((FStructRedirect*)Ptr)->NewStructName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FStructRedirect_OldStructName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FStructRedirect*)Ptr)->OldStructName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FStructRedirect_OldStructName_SET(INT_PTR Ptr, char* Value) { ((FStructRedirect*)Ptr)->OldStructName = FName(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FTickFunction	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTickFunction() { return (INT_PTR) new FTickFunction(); }
	
	DOTNET_EXPORT uint8 E_PROP_FTickFunction_bAllowTickOnDedicatedServer_GET(INT_PTR Ptr) { return ((FTickFunction*)Ptr)->bAllowTickOnDedicatedServer; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bAllowTickOnDedicatedServer_SET(INT_PTR Ptr, uint8 Value) { ((FTickFunction*)Ptr)->bAllowTickOnDedicatedServer = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_FTickFunction_bCanEverTick_GET(INT_PTR Ptr) { return ((FTickFunction*)Ptr)->bCanEverTick; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bCanEverTick_SET(INT_PTR Ptr, uint8 Value) { ((FTickFunction*)Ptr)->bCanEverTick = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_FTickFunction_bHighPriority_GET(INT_PTR Ptr) { return ((FTickFunction*)Ptr)->bHighPriority; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bHighPriority_SET(INT_PTR Ptr, uint8 Value) { ((FTickFunction*)Ptr)->bHighPriority = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_FTickFunction_bRunOnAnyThread_GET(INT_PTR Ptr) { return ((FTickFunction*)Ptr)->bRunOnAnyThread; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bRunOnAnyThread_SET(INT_PTR Ptr, uint8 Value) { ((FTickFunction*)Ptr)->bRunOnAnyThread = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_FTickFunction_bStartWithTickEnabled_GET(INT_PTR Ptr) { return ((FTickFunction*)Ptr)->bStartWithTickEnabled; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bStartWithTickEnabled_SET(INT_PTR Ptr, uint8 Value) { ((FTickFunction*)Ptr)->bStartWithTickEnabled = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_FTickFunction_bTickEvenWhenPaused_GET(INT_PTR Ptr) { return ((FTickFunction*)Ptr)->bTickEvenWhenPaused; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bTickEvenWhenPaused_SET(INT_PTR Ptr, uint8 Value) { ((FTickFunction*)Ptr)->bTickEvenWhenPaused = Value; }
	
	DOTNET_EXPORT float E_PROP_FTickFunction_TickInterval_GET(INT_PTR Ptr) { return ((FTickFunction*)Ptr)->TickInterval; }
	DOTNET_EXPORT void E_PROP_FTickFunction_TickInterval_SET(INT_PTR Ptr, float Value) { ((FTickFunction*)Ptr)->TickInterval = Value; }
	
	DOTNET_EXPORT auto E_FTickFunction_IsCompletionHandleValid(FTickFunction* Self)
	{
		return ConvertForManage(Self->IsCompletionHandleValid());
	}

	DOTNET_EXPORT auto E_FTickFunction_IsTickFunctionEnabled(FTickFunction* Self)
	{
		return ConvertForManage(Self->IsTickFunctionEnabled());
	}

	DOTNET_EXPORT auto E_FTickFunction_IsTickFunctionRegistered(FTickFunction* Self)
	{
		return ConvertForManage(Self->IsTickFunctionRegistered());
	}

	DOTNET_EXPORT auto E_FTickFunction_SetPriorityIncludingPrerequisites(FTickFunction* Self, bool bInHighPriority)
	{
		auto _p0 = bInHighPriority;
		Self->SetPriorityIncludingPrerequisites(_p0);
	}

	DOTNET_EXPORT auto E_FTickFunction_SetTickFunctionEnable(FTickFunction* Self, bool bInEnabled)
	{
		auto _p0 = bInEnabled;
		Self->SetTickFunctionEnable(_p0);
	}

	DOTNET_EXPORT auto E_FTickFunction_UnRegisterTickFunction(FTickFunction* Self)
	{
		Self->UnRegisterTickFunction();
	}

	
	/*	FTickPrerequisite	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTickPrerequisite() { return (INT_PTR) new FTickPrerequisite(); }
	
	
	/*	FTimeline	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimeline() { return (INT_PTR) new FTimeline(); }
	
	DOTNET_EXPORT auto E_FTimeline_GetPlaybackPosition(FTimeline* Self)
	{
		return ConvertForManage(Self->GetPlaybackPosition());
	}

	DOTNET_EXPORT auto E_FTimeline_GetPlayRate(FTimeline* Self)
	{
		return ConvertForManage(Self->GetPlayRate());
	}

	DOTNET_EXPORT auto E_FTimeline_GetTimelineLength(FTimeline* Self)
	{
		return ConvertForManage(Self->GetTimelineLength());
	}

	DOTNET_EXPORT auto E_FTimeline_IsLooping(FTimeline* Self)
	{
		return ConvertForManage(Self->IsLooping());
	}

	DOTNET_EXPORT auto E_FTimeline_IsPlaying(FTimeline* Self)
	{
		return ConvertForManage(Self->IsPlaying());
	}

	DOTNET_EXPORT auto E_FTimeline_IsReversing(FTimeline* Self)
	{
		return ConvertForManage(Self->IsReversing());
	}

	DOTNET_EXPORT auto E_FTimeline_Play(FTimeline* Self)
	{
		Self->Play();
	}

	DOTNET_EXPORT auto E_FTimeline_PlayFromStart(FTimeline* Self)
	{
		Self->PlayFromStart();
	}

	DOTNET_EXPORT auto E_FTimeline_Reverse(FTimeline* Self)
	{
		Self->Reverse();
	}

	DOTNET_EXPORT auto E_FTimeline_ReverseFromEnd(FTimeline* Self)
	{
		Self->ReverseFromEnd();
	}

	DOTNET_EXPORT auto E_FTimeline_SetDirectionPropertyName(FTimeline* Self, char* InDirectionPropertyName)
	{
		auto _p0 = ConvertFromManage_FName(InDirectionPropertyName);
		Self->SetDirectionPropertyName(_p0);
	}

	DOTNET_EXPORT auto E_FTimeline_SetLooping(FTimeline* Self, bool bNewLooping)
	{
		auto _p0 = bNewLooping;
		Self->SetLooping(_p0);
	}

	DOTNET_EXPORT auto E_FTimeline_SetNewTime(FTimeline* Self, float NewTime)
	{
		auto _p0 = NewTime;
		Self->SetNewTime(_p0);
	}

	DOTNET_EXPORT auto E_FTimeline_SetPlaybackPosition(FTimeline* Self, float NewPosition, bool bFireEvents, bool bFireUpdate)
	{
		auto _p0 = NewPosition;
		auto _p1 = bFireEvents;
		auto _p2 = bFireUpdate;
		Self->SetPlaybackPosition(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FTimeline_SetPlayRate(FTimeline* Self, float NewRate)
	{
		auto _p0 = NewRate;
		Self->SetPlayRate(_p0);
	}

	DOTNET_EXPORT auto E_FTimeline_SetPropertySetObject(FTimeline* Self, UObject* NewPropertySetObject)
	{
		auto _p0 = NewPropertySetObject;
		Self->SetPropertySetObject(_p0);
	}

	DOTNET_EXPORT auto E_FTimeline_SetTimelineLength(FTimeline* Self, float NewLength)
	{
		auto _p0 = NewLength;
		Self->SetTimelineLength(_p0);
	}

	DOTNET_EXPORT auto E_FTimeline_SetTimelineLengthMode(FTimeline* Self, ETimelineLengthMode NewMode)
	{
		auto _p0 = NewMode;
		Self->SetTimelineLengthMode(_p0);
	}

	DOTNET_EXPORT auto E_FTimeline_Stop(FTimeline* Self)
	{
		Self->Stop();
	}

	DOTNET_EXPORT auto E_FTimeline_TickTimeline(FTimeline* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		Self->TickTimeline(_p0);
	}

	
	/*	FTimelineEventEntry	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineEventEntry() { return (INT_PTR) new FTimelineEventEntry(); }
	
	DOTNET_EXPORT float E_PROP_FTimelineEventEntry_Time_GET(INT_PTR Ptr) { return ((FTimelineEventEntry*)Ptr)->Time; }
	DOTNET_EXPORT void E_PROP_FTimelineEventEntry_Time_SET(INT_PTR Ptr, float Value) { ((FTimelineEventEntry*)Ptr)->Time = Value; }
	
	
	/*	FTimelineFloatTrack	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineFloatTrack() { return (INT_PTR) new FTimelineFloatTrack(); }
	
	DOTNET_EXPORT char* E_PROP_FTimelineFloatTrack_FloatPropertyName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FTimelineFloatTrack*)Ptr)->FloatPropertyName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FTimelineFloatTrack_FloatPropertyName_SET(INT_PTR Ptr, char* Value) { ((FTimelineFloatTrack*)Ptr)->FloatPropertyName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FTimelineFloatTrack_TrackName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FTimelineFloatTrack*)Ptr)->TrackName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FTimelineFloatTrack_TrackName_SET(INT_PTR Ptr, char* Value) { ((FTimelineFloatTrack*)Ptr)->TrackName = FName(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FTimelineLinearColorTrack	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineLinearColorTrack() { return (INT_PTR) new FTimelineLinearColorTrack(); }
	
	DOTNET_EXPORT char* E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FTimelineLinearColorTrack*)Ptr)->LinearColorPropertyName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_SET(INT_PTR Ptr, char* Value) { ((FTimelineLinearColorTrack*)Ptr)->LinearColorPropertyName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FTimelineLinearColorTrack_TrackName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FTimelineLinearColorTrack*)Ptr)->TrackName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FTimelineLinearColorTrack_TrackName_SET(INT_PTR Ptr, char* Value) { ((FTimelineLinearColorTrack*)Ptr)->TrackName = FName(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FTimelineVectorTrack	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineVectorTrack() { return (INT_PTR) new FTimelineVectorTrack(); }
	
	DOTNET_EXPORT char* E_PROP_FTimelineVectorTrack_TrackName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FTimelineVectorTrack*)Ptr)->TrackName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FTimelineVectorTrack_TrackName_SET(INT_PTR Ptr, char* Value) { ((FTimelineVectorTrack*)Ptr)->TrackName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_FTimelineVectorTrack_VectorPropertyName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FTimelineVectorTrack*)Ptr)->VectorPropertyName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FTimelineVectorTrack_VectorPropertyName_SET(INT_PTR Ptr, char* Value) { ((FTimelineVectorTrack*)Ptr)->VectorPropertyName = FName(UTF8_TO_TCHAR(Value)); }
	
	
	/*	FTransform	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTransform() { return (INT_PTR) new FTransform(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTransform_FVector(INT_PTR InTranslation) { return (INT_PTR) new FTransform(*(FVector*)InTranslation); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTransform_FQuat(INT_PTR InRotation) { return (INT_PTR) new FTransform(*(FQuat*)InRotation); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTransform_FRotator(INT_PTR InRotation) { return (INT_PTR) new FTransform(*(FRotator*)InRotation); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTransform_FQuat_FVector_FVector(INT_PTR InRotation, INT_PTR InTranslation, INT_PTR InScale3D) { return (INT_PTR) new FTransform(*(FQuat*)InRotation, *(FVector*)InTranslation, *(FVector*)InScale3D); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTransform_FRotator_FVector_FVector(INT_PTR InRotation, INT_PTR InTranslation, INT_PTR InScale3D) { return (INT_PTR) new FTransform(*(FRotator*)InRotation, *(FVector*)InTranslation, *(FVector*)InScale3D); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTransform_FTransform(INT_PTR InTransform) { return (INT_PTR) new FTransform(*(FTransform*)InTransform); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTransform_FVector_FVector_FVector_FVector(INT_PTR InX, INT_PTR InY, INT_PTR InZ, INT_PTR InTranslation) { return (INT_PTR) new FTransform(*(FVector*)InX, *(FVector*)InY, *(FVector*)InZ, *(FVector*)InTranslation); }
	
	DOTNET_EXPORT auto E_FTransform_AddToTranslation(FTransform* Self, INT_PTR DeltaTranslation)
	{
		auto _p0 = *(FVector*)DeltaTranslation;
		Self->AddToTranslation(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_AddTranslations(FTransform* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		return (INT_PTR) new FVector(Self->AddTranslations(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FTransform_AnyHasNegativeScale(FTransform* Self, INT_PTR InScale3D, INT_PTR InOtherScale3D)
	{
		auto _p0 = *(FVector*)InScale3D;
		auto _p1 = *(FVector*)InOtherScale3D;
		return ConvertForManage(Self->AnyHasNegativeScale(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FTransform_AreRotationsEqual(FTransform* Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return ConvertForManage(Self->AreRotationsEqual(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FTransform_AreScale3DsEqual(FTransform* Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return ConvertForManage(Self->AreScale3DsEqual(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FTransform_AreTranslationsEqual(FTransform* Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return ConvertForManage(Self->AreTranslationsEqual(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FTransform_Blend(FTransform* Self, INT_PTR Atom1, INT_PTR Atom2, float Alpha)
	{
		auto _p0 = *(FTransform*)Atom1;
		auto _p1 = *(FTransform*)Atom2;
		auto _p2 = Alpha;
		Self->Blend(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FTransform_BlendWith(FTransform* Self, INT_PTR OtherAtom, float Alpha)
	{
		auto _p0 = *(FTransform*)OtherAtom;
		auto _p1 = Alpha;
		Self->BlendWith(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FTransform_ConcatenateRotation(FTransform* Self, INT_PTR DeltaRotation)
	{
		auto _p0 = *(FQuat*)DeltaRotation;
		Self->ConcatenateRotation(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_ContainsNaN(FTransform* Self)
	{
		return ConvertForManage(Self->ContainsNaN());
	}

	DOTNET_EXPORT auto E_FTransform_CopyRotation(FTransform* Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		Self->CopyRotation(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_CopyRotationPart(FTransform* Self, INT_PTR SrcBA)
	{
		auto _p0 = *(FTransform*)SrcBA;
		Self->CopyRotationPart(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_CopyScale3D(FTransform* Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		Self->CopyScale3D(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_CopyTranslation(FTransform* Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		Self->CopyTranslation(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_CopyTranslationAndScale3D(FTransform* Self, INT_PTR SrcBA)
	{
		auto _p0 = *(FTransform*)SrcBA;
		Self->CopyTranslationAndScale3D(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_DebugPrint(FTransform* Self)
	{
		Self->DebugPrint();
	}

	DOTNET_EXPORT auto E_FTransform_DiagnosticCheck_IsValid(FTransform* Self)
	{
		Self->DiagnosticCheck_IsValid();
	}

	DOTNET_EXPORT auto E_FTransform_DiagnosticCheckNaN_All(FTransform* Self)
	{
		Self->DiagnosticCheckNaN_All();
	}

	DOTNET_EXPORT auto E_FTransform_DiagnosticCheckNaN_Rotate(FTransform* Self)
	{
		Self->DiagnosticCheckNaN_Rotate();
	}

	DOTNET_EXPORT auto E_FTransform_DiagnosticCheckNaN_Scale3D(FTransform* Self)
	{
		Self->DiagnosticCheckNaN_Scale3D();
	}

	DOTNET_EXPORT auto E_FTransform_DiagnosticCheckNaN_Translate(FTransform* Self)
	{
		Self->DiagnosticCheckNaN_Translate();
	}

	DOTNET_EXPORT auto E_FTransform_Equals(FTransform* Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->Equals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FTransform_EqualsNoScale(FTransform* Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->EqualsNoScale(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FTransform_GetDeterminant(FTransform* Self)
	{
		return ConvertForManage(Self->GetDeterminant());
	}

	DOTNET_EXPORT auto E_FTransform_GetLocation(FTransform* Self)
	{
		return (INT_PTR) new FVector(Self->GetLocation());
	}

	DOTNET_EXPORT auto E_FTransform_GetMaximumAxisScale(FTransform* Self)
	{
		return ConvertForManage(Self->GetMaximumAxisScale());
	}

	DOTNET_EXPORT auto E_FTransform_GetMinimumAxisScale(FTransform* Self)
	{
		return ConvertForManage(Self->GetMinimumAxisScale());
	}

	DOTNET_EXPORT auto E_FTransform_GetRelativeTransform(FTransform* Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		return (INT_PTR) new FTransform(Self->GetRelativeTransform(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_GetRelativeTransformReverse(FTransform* Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		return (INT_PTR) new FTransform(Self->GetRelativeTransformReverse(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_GetRotation(FTransform* Self)
	{
		return (INT_PTR) new FQuat(Self->GetRotation());
	}

	DOTNET_EXPORT auto E_FTransform_GetRotationV(FTransform* Self)
	{
		return (INT_PTR) new FQuat(Self->GetRotationV());
	}

	DOTNET_EXPORT auto E_FTransform_GetSafeScaleReciprocal(FTransform* Self, INT_PTR InScale, float Tolerance)
	{
		auto _p0 = *(FVector*)InScale;
		auto _p1 = Tolerance;
		return (INT_PTR) new FVector(Self->GetSafeScaleReciprocal(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FTransform_GetScale3D(FTransform* Self)
	{
		return (INT_PTR) new FVector(Self->GetScale3D());
	}

	DOTNET_EXPORT auto E_FTransform_GetScale3DV(FTransform* Self)
	{
		return (INT_PTR) new FVector(Self->GetScale3DV());
	}

	DOTNET_EXPORT auto E_FTransform_GetTranslation(FTransform* Self)
	{
		return (INT_PTR) new FVector(Self->GetTranslation());
	}

	DOTNET_EXPORT auto E_FTransform_GetTranslationV(FTransform* Self)
	{
		return (INT_PTR) new FVector(Self->GetTranslationV());
	}

	DOTNET_EXPORT auto E_FTransform_InitFromString(FTransform* Self, char* InSourceString)
	{
		auto _p0 = ConvertFromManage_FString(InSourceString);
		return ConvertForManage(Self->InitFromString(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_Inverse(FTransform* Self)
	{
		return (INT_PTR) new FTransform(Self->Inverse());
	}

	DOTNET_EXPORT auto E_FTransform_InverseTransformPosition(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->InverseTransformPosition(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_InverseTransformPositionNoScale(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->InverseTransformPositionNoScale(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_InverseTransformVector(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->InverseTransformVector(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_InverseTransformVectorNoScale(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->InverseTransformVectorNoScale(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_IsRotationNormalized(FTransform* Self)
	{
		return ConvertForManage(Self->IsRotationNormalized());
	}

	DOTNET_EXPORT auto E_FTransform_IsValid(FTransform* Self)
	{
		return ConvertForManage(Self->IsValid());
	}

	DOTNET_EXPORT auto E_FTransform_Multiply(FTransform* Self, INT_PTR OutTransform, INT_PTR A, INT_PTR B)
	{
		auto _p0 = (FTransform*)OutTransform;
		auto _p1 = (FTransform*)A;
		auto _p2 = (FTransform*)B;
		Self->Multiply(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FTransform_MultiplyScale3D(FTransform* Self, INT_PTR Scale3DMultiplier)
	{
		auto _p0 = *(FVector*)Scale3DMultiplier;
		Self->MultiplyScale3D(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_NormalizeRotation(FTransform* Self)
	{
		Self->NormalizeRotation();
	}

	DOTNET_EXPORT auto E_FTransform_RemoveScaling(FTransform* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		Self->RemoveScaling(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_RotationEquals(FTransform* Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->RotationEquals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FTransform_Rotator(FTransform* Self)
	{
		return (INT_PTR) new FRotator(Self->Rotator());
	}

	DOTNET_EXPORT auto E_FTransform_Scale3DEquals(FTransform* Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->Scale3DEquals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FTransform_SetComponents(FTransform* Self, INT_PTR InRotation, INT_PTR InTranslation, INT_PTR InScale3D)
	{
		auto _p0 = *(FQuat*)InRotation;
		auto _p1 = *(FVector*)InTranslation;
		auto _p2 = *(FVector*)InScale3D;
		Self->SetComponents(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FTransform_SetIdentity(FTransform* Self)
	{
		Self->SetIdentity();
	}

	DOTNET_EXPORT auto E_FTransform_SetLocation(FTransform* Self, INT_PTR Origin)
	{
		auto _p0 = *(FVector*)Origin;
		Self->SetLocation(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_SetRotation(FTransform* Self, INT_PTR NewRotation)
	{
		auto _p0 = *(FQuat*)NewRotation;
		Self->SetRotation(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_SetScale3D(FTransform* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetScale3D(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_SetToRelativeTransform(FTransform* Self, INT_PTR ParentTransform)
	{
		auto _p0 = *(FTransform*)ParentTransform;
		Self->SetToRelativeTransform(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_SetTranslation(FTransform* Self, INT_PTR NewTranslation)
	{
		auto _p0 = *(FVector*)NewTranslation;
		Self->SetTranslation(_p0);
	}

	DOTNET_EXPORT auto E_FTransform_SetTranslationAndScale3D(FTransform* Self, INT_PTR NewTranslation, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewTranslation;
		auto _p1 = *(FVector*)NewScale3D;
		Self->SetTranslationAndScale3D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FTransform_SubtractTranslations(FTransform* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		return (INT_PTR) new FVector(Self->SubtractTranslations(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FTransform_ToHumanReadableString(FTransform* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToHumanReadableString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FTransform_ToString(FTransform* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FTransform_TransformFVector4(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector4*)V;
		return (INT_PTR) new FVector4(Self->TransformFVector4(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_TransformFVector4NoScale(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector4*)V;
		return (INT_PTR) new FVector4(Self->TransformFVector4NoScale(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_TransformPosition(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->TransformPosition(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_TransformPositionNoScale(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->TransformPositionNoScale(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_TransformVector(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->TransformVector(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_TransformVectorNoScale(FTransform* Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->TransformVectorNoScale(_p0));
	}

	DOTNET_EXPORT auto E_FTransform_TranslationEquals(FTransform* Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->TranslationEquals(_p0, _p1));
	}

	
	/*	FURL	*/
	
	DOTNET_EXPORT bool E_PROP_FURL_bDefaultsInitialized_GET(INT_PTR Ptr) { return ((FURL*)Ptr)->bDefaultsInitialized; }
	DOTNET_EXPORT void E_PROP_FURL_bDefaultsInitialized_SET(INT_PTR Ptr, bool Value) { ((FURL*)Ptr)->bDefaultsInitialized = Value; }
	
	DOTNET_EXPORT char* E_PROP_FURL_Host_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FURL*)Ptr)->Host;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FURL_Host_SET(INT_PTR Ptr, char* Value) { ((FURL*)Ptr)->Host = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT char* E_PROP_FURL_Map_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FURL*)Ptr)->Map;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FURL_Map_SET(INT_PTR Ptr, char* Value) { ((FURL*)Ptr)->Map = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT int32 E_PROP_FURL_Port_GET(INT_PTR Ptr) { return ((FURL*)Ptr)->Port; }
	DOTNET_EXPORT void E_PROP_FURL_Port_SET(INT_PTR Ptr, int32 Value) { ((FURL*)Ptr)->Port = Value; }
	
	DOTNET_EXPORT char* E_PROP_FURL_Portal_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FURL*)Ptr)->Portal;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FURL_Portal_SET(INT_PTR Ptr, char* Value) { ((FURL*)Ptr)->Portal = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT char* E_PROP_FURL_Protocol_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FURL*)Ptr)->Protocol;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FURL_Protocol_SET(INT_PTR Ptr, char* Value) { ((FURL*)Ptr)->Protocol = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT char* E_PROP_FURL_RedirectURL_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FURL*)Ptr)->RedirectURL;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FURL_RedirectURL_SET(INT_PTR Ptr, char* Value) { ((FURL*)Ptr)->RedirectURL = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT int32 E_PROP_FURL_Valid_GET(INT_PTR Ptr) { return ((FURL*)Ptr)->Valid; }
	DOTNET_EXPORT void E_PROP_FURL_Valid_SET(INT_PTR Ptr, int32 Value) { ((FURL*)Ptr)->Valid = Value; }
	
	DOTNET_EXPORT auto E_FURL_FilterURLString(FURL* Self, char* Str)
	{
		auto _p0 = ConvertFromManage_FString(Str);
		Self->FilterURLString(_p0);
	}

	DOTNET_EXPORT auto E_FURL_IsInternal(FURL* Self)
	{
		return ConvertForManage(Self->IsInternal());
	}

	DOTNET_EXPORT auto E_FURL_IsLocalInternal(FURL* Self)
	{
		return ConvertForManage(Self->IsLocalInternal());
	}

	DOTNET_EXPORT auto E_FURL_StaticExit(FURL* Self)
	{
		Self->StaticExit();
	}

	DOTNET_EXPORT auto E_FURL_StaticInit(FURL* Self)
	{
		Self->StaticInit();
	}

	
	/*	FVector	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector() { return (INT_PTR) new FVector(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_float(float InF) { return (INT_PTR) new FVector(InF); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_float_float_float(float InX, float InY, float InZ) { return (INT_PTR) new FVector(InX, InY, InZ); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_FVector2D_float(INT_PTR V, float InZ) { return (INT_PTR) new FVector(*(FVector2D*)V, InZ); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_FVector4(INT_PTR V) { return (INT_PTR) new FVector(*(FVector4*)V); }
	
	DOTNET_EXPORT float E_PROP_FVector_X_GET(INT_PTR Ptr) { return ((FVector*)Ptr)->X; }
	DOTNET_EXPORT void E_PROP_FVector_X_SET(INT_PTR Ptr, float Value) { ((FVector*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector_Y_GET(INT_PTR Ptr) { return ((FVector*)Ptr)->Y; }
	DOTNET_EXPORT void E_PROP_FVector_Y_SET(INT_PTR Ptr, float Value) { ((FVector*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector_Z_GET(INT_PTR Ptr) { return ((FVector*)Ptr)->Z; }
	DOTNET_EXPORT void E_PROP_FVector_Z_SET(INT_PTR Ptr, float Value) { ((FVector*)Ptr)->Z = Value; }
	
	DOTNET_EXPORT auto E_FVector_AddBounded(FVector* Self, INT_PTR V, float Radius)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = Radius;
		Self->AddBounded(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_AllComponentsEqual(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ConvertForManage(Self->AllComponentsEqual(_p0));
	}

	DOTNET_EXPORT auto E_FVector_BoundToCube(FVector* Self, float Radius)
	{
		auto _p0 = Radius;
		return (INT_PTR) new FVector(Self->BoundToCube(_p0));
	}

	DOTNET_EXPORT auto E_FVector_BoxPushOut(FVector* Self, INT_PTR Normal, INT_PTR Size)
	{
		auto _p0 = *(FVector*)Normal;
		auto _p1 = *(FVector*)Size;
		return ConvertForManage(Self->BoxPushOut(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_ClampMaxSize(FVector* Self, float MaxSize)
	{
		auto _p0 = MaxSize;
		return (INT_PTR) new FVector(Self->ClampMaxSize(_p0));
	}

	DOTNET_EXPORT auto E_FVector_ClampMaxSize2D(FVector* Self, float MaxSize)
	{
		auto _p0 = MaxSize;
		return (INT_PTR) new FVector(Self->ClampMaxSize2D(_p0));
	}

	DOTNET_EXPORT auto E_FVector_ClampSize(FVector* Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return (INT_PTR) new FVector(Self->ClampSize(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_ClampSize2D(FVector* Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return (INT_PTR) new FVector(Self->ClampSize2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_Coincident(FVector* Self, INT_PTR Normal1, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		auto _p2 = ParallelCosineThreshold;
		return ConvertForManage(Self->Coincident(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FVector_ComponentMax(FVector* Self, INT_PTR Other)
	{
		auto _p0 = *(FVector*)Other;
		return (INT_PTR) new FVector(Self->ComponentMax(_p0));
	}

	DOTNET_EXPORT auto E_FVector_ComponentMin(FVector* Self, INT_PTR Other)
	{
		auto _p0 = *(FVector*)Other;
		return (INT_PTR) new FVector(Self->ComponentMin(_p0));
	}

	DOTNET_EXPORT auto E_FVector_ContainsNaN(FVector* Self)
	{
		return ConvertForManage(Self->ContainsNaN());
	}

	DOTNET_EXPORT auto E_FVector_Coplanar(FVector* Self, INT_PTR Base1, INT_PTR Normal1, INT_PTR Base2, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Base1;
		auto _p1 = *(FVector*)Normal1;
		auto _p2 = *(FVector*)Base2;
		auto _p3 = *(FVector*)Normal2;
		auto _p4 = ParallelCosineThreshold;
		return ConvertForManage(Self->Coplanar(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT auto E_FVector_CosineAngle2D(FVector* Self, INT_PTR B)
	{
		auto _p0 = *(FVector*)B;
		return ConvertForManage(Self->CosineAngle2D(_p0));
	}

	DOTNET_EXPORT auto E_FVector_CreateOrthonormalBasis(FVector* Self, INT_PTR XAxis, INT_PTR YAxis, INT_PTR ZAxis)
	{
		auto _p0 = *(FVector*)XAxis;
		auto _p1 = *(FVector*)YAxis;
		auto _p2 = *(FVector*)ZAxis;
		Self->CreateOrthonormalBasis(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FVector_CrossProduct(FVector* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(Self->CrossProduct(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_DegreesToRadians(FVector* Self, INT_PTR DegVector)
	{
		auto _p0 = *(FVector*)DegVector;
		return (INT_PTR) new FVector(Self->DegreesToRadians(_p0));
	}

	DOTNET_EXPORT auto E_FVector_Dist(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ConvertForManage(Self->Dist(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_Dist2D(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ConvertForManage(Self->Dist2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_Distance(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ConvertForManage(Self->Distance(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_DistSquared(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ConvertForManage(Self->DistSquared(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_DistSquared2D(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ConvertForManage(Self->DistSquared2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_DistSquaredXY(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ConvertForManage(Self->DistSquaredXY(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_DistXY(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ConvertForManage(Self->DistXY(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_DotProduct(FVector* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return ConvertForManage(Self->DotProduct(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_Equals(FVector* Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->Equals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_FindBestAxisVectors(FVector* Self, INT_PTR Axis1, INT_PTR Axis2)
	{
		auto _p0 = *(FVector*)Axis1;
		auto _p1 = *(FVector*)Axis2;
		Self->FindBestAxisVectors(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_GetAbs(FVector* Self)
	{
		return (INT_PTR) new FVector(Self->GetAbs());
	}

	DOTNET_EXPORT auto E_FVector_GetAbsMax(FVector* Self)
	{
		return ConvertForManage(Self->GetAbsMax());
	}

	DOTNET_EXPORT auto E_FVector_GetAbsMin(FVector* Self)
	{
		return ConvertForManage(Self->GetAbsMin());
	}

	DOTNET_EXPORT auto E_FVector_GetClampedToMaxSize(FVector* Self, float MaxSize)
	{
		auto _p0 = MaxSize;
		return (INT_PTR) new FVector(Self->GetClampedToMaxSize(_p0));
	}

	DOTNET_EXPORT auto E_FVector_GetClampedToMaxSize2D(FVector* Self, float MaxSize)
	{
		auto _p0 = MaxSize;
		return (INT_PTR) new FVector(Self->GetClampedToMaxSize2D(_p0));
	}

	DOTNET_EXPORT auto E_FVector_GetClampedToSize(FVector* Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return (INT_PTR) new FVector(Self->GetClampedToSize(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_GetClampedToSize2D(FVector* Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return (INT_PTR) new FVector(Self->GetClampedToSize2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_GetMax(FVector* Self)
	{
		return ConvertForManage(Self->GetMax());
	}

	DOTNET_EXPORT auto E_FVector_GetMin(FVector* Self)
	{
		return ConvertForManage(Self->GetMin());
	}

	DOTNET_EXPORT auto E_FVector_GetSafeNormal(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector(Self->GetSafeNormal(_p0));
	}

	DOTNET_EXPORT auto E_FVector_GetSafeNormal2D(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector(Self->GetSafeNormal2D(_p0));
	}

	DOTNET_EXPORT auto E_FVector_GetSignVector(FVector* Self)
	{
		return (INT_PTR) new FVector(Self->GetSignVector());
	}

	DOTNET_EXPORT auto E_FVector_GetUnsafeNormal(FVector* Self)
	{
		return (INT_PTR) new FVector(Self->GetUnsafeNormal());
	}

	DOTNET_EXPORT auto E_FVector_GridSnap(FVector* Self, float GridSz)
	{
		auto _p0 = GridSz;
		return (INT_PTR) new FVector(Self->GridSnap(_p0));
	}

	DOTNET_EXPORT auto E_FVector_HeadingAngle(FVector* Self)
	{
		return ConvertForManage(Self->HeadingAngle());
	}

	DOTNET_EXPORT auto E_FVector_InitFromString(FVector* Self, char* InSourceString)
	{
		auto _p0 = ConvertFromManage_FString(InSourceString);
		return ConvertForManage(Self->InitFromString(_p0));
	}

	DOTNET_EXPORT auto E_FVector_IsNearlyZero(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ConvertForManage(Self->IsNearlyZero(_p0));
	}

	DOTNET_EXPORT auto E_FVector_IsNormalized(FVector* Self)
	{
		return ConvertForManage(Self->IsNormalized());
	}

	DOTNET_EXPORT auto E_FVector_IsUniform(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ConvertForManage(Self->IsUniform(_p0));
	}

	DOTNET_EXPORT auto E_FVector_IsUnit(FVector* Self, float LengthSquaredTolerance)
	{
		auto _p0 = LengthSquaredTolerance;
		return ConvertForManage(Self->IsUnit(_p0));
	}

	DOTNET_EXPORT auto E_FVector_IsZero(FVector* Self)
	{
		return ConvertForManage(Self->IsZero());
	}

	DOTNET_EXPORT auto E_FVector_MirrorByPlane(FVector* Self, INT_PTR Plane)
	{
		auto _p0 = *(FPlane*)Plane;
		return (INT_PTR) new FVector(Self->MirrorByPlane(_p0));
	}

	DOTNET_EXPORT auto E_FVector_MirrorByVector(FVector* Self, INT_PTR MirrorNormal)
	{
		auto _p0 = *(FVector*)MirrorNormal;
		return (INT_PTR) new FVector(Self->MirrorByVector(_p0));
	}

	DOTNET_EXPORT auto E_FVector_Normalize(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ConvertForManage(Self->Normalize(_p0));
	}

	DOTNET_EXPORT auto E_FVector_Orthogonal(FVector* Self, INT_PTR Normal1, INT_PTR Normal2, float OrthogonalCosineThreshold)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		auto _p2 = OrthogonalCosineThreshold;
		return ConvertForManage(Self->Orthogonal(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FVector_Parallel(FVector* Self, INT_PTR Normal1, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		auto _p2 = ParallelCosineThreshold;
		return ConvertForManage(Self->Parallel(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FVector_PointPlaneDist(FVector* Self, INT_PTR Point, INT_PTR PlaneBase, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)PlaneBase;
		auto _p2 = *(FVector*)PlaneNormal;
		return ConvertForManage(Self->PointPlaneDist(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FVector_PointsAreNear(FVector* Self, INT_PTR Point1, INT_PTR Point2, float Dist)
	{
		auto _p0 = *(FVector*)Point1;
		auto _p1 = *(FVector*)Point2;
		auto _p2 = Dist;
		return ConvertForManage(Self->PointsAreNear(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FVector_PointsAreSame(FVector* Self, INT_PTR P, INT_PTR Q)
	{
		auto _p0 = *(FVector*)P;
		auto _p1 = *(FVector*)Q;
		return ConvertForManage(Self->PointsAreSame(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_Projection(FVector* Self)
	{
		return (INT_PTR) new FVector(Self->Projection());
	}

	DOTNET_EXPORT auto E_FVector_ProjectOnTo(FVector* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(Self->ProjectOnTo(_p0));
	}

	DOTNET_EXPORT auto E_FVector_ProjectOnToNormal(FVector* Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Normal;
		return (INT_PTR) new FVector(Self->ProjectOnToNormal(_p0));
	}

	DOTNET_EXPORT auto E_FVector_RadiansToDegrees(FVector* Self, INT_PTR RadVector)
	{
		auto _p0 = *(FVector*)RadVector;
		return (INT_PTR) new FVector(Self->RadiansToDegrees(_p0));
	}

	DOTNET_EXPORT auto E_FVector_Reciprocal(FVector* Self)
	{
		return (INT_PTR) new FVector(Self->Reciprocal());
	}

	DOTNET_EXPORT auto E_FVector_RotateAngleAxis(FVector* Self, float AngleDeg, INT_PTR Axis)
	{
		auto _p0 = AngleDeg;
		auto _p1 = *(FVector*)Axis;
		return (INT_PTR) new FVector(Self->RotateAngleAxis(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector_Rotation(FVector* Self)
	{
		return (INT_PTR) new FRotator(Self->Rotation());
	}

	DOTNET_EXPORT auto E_FVector_SafeNormal(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector(Self->SafeNormal(_p0));
	}

	DOTNET_EXPORT auto E_FVector_SafeNormal2D(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector(Self->SafeNormal2D(_p0));
	}

	DOTNET_EXPORT auto E_FVector_Set(FVector* Self, float InX, float InY, float InZ)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		Self->Set(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FVector_Size(FVector* Self)
	{
		return ConvertForManage(Self->Size());
	}

	DOTNET_EXPORT auto E_FVector_Size2D(FVector* Self)
	{
		return ConvertForManage(Self->Size2D());
	}

	DOTNET_EXPORT auto E_FVector_SizeSquared(FVector* Self)
	{
		return ConvertForManage(Self->SizeSquared());
	}

	DOTNET_EXPORT auto E_FVector_SizeSquared2D(FVector* Self)
	{
		return ConvertForManage(Self->SizeSquared2D());
	}

	DOTNET_EXPORT auto E_FVector_ToCompactString(FVector* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToCompactString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FVector_ToCompactText(FVector* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToCompactText().ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FVector_ToDirectionAndLength(FVector* Self, INT_PTR OutDir, float OutLength)
	{
		auto _p0 = *(FVector*)OutDir;
		auto _p1 = OutLength;
		Self->ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_ToOrientationQuat(FVector* Self)
	{
		return (INT_PTR) new FQuat(Self->ToOrientationQuat());
	}

	DOTNET_EXPORT auto E_FVector_ToOrientationRotator(FVector* Self)
	{
		return (INT_PTR) new FRotator(Self->ToOrientationRotator());
	}

	DOTNET_EXPORT auto E_FVector_ToString(FVector* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FVector_ToText(FVector* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToText().ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FVector_Triple(FVector* Self, INT_PTR X, INT_PTR Y, INT_PTR Z)
	{
		auto _p0 = *(FVector*)X;
		auto _p1 = *(FVector*)Y;
		auto _p2 = *(FVector*)Z;
		return ConvertForManage(Self->Triple(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_FVector_UnitCartesianToSpherical(FVector* Self)
	{
		return (INT_PTR) new FVector2D(Self->UnitCartesianToSpherical());
	}

	DOTNET_EXPORT auto E_FVector_UnsafeNormal(FVector* Self)
	{
		return (INT_PTR) new FVector(Self->UnsafeNormal());
	}

	DOTNET_EXPORT auto E_FVector_UnwindEuler(FVector* Self)
	{
		Self->UnwindEuler();
	}

	DOTNET_EXPORT auto E_FVector_VectorPlaneProject(FVector* Self, INT_PTR V, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = *(FVector*)PlaneNormal;
		return (INT_PTR) new FVector(Self->VectorPlaneProject(_p0, _p1));
	}

	
	/*	FVector2D	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector2D() { return (INT_PTR) new FVector2D(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector2D_float_float(float InX, float InY) { return (INT_PTR) new FVector2D(InX, InY); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector2D_FVector(INT_PTR V) { return (INT_PTR) new FVector2D(*(FVector*)V); }
	
	DOTNET_EXPORT float E_PROP_FVector2D_X_GET(INT_PTR Ptr) { return ((FVector2D*)Ptr)->X; }
	DOTNET_EXPORT void E_PROP_FVector2D_X_SET(INT_PTR Ptr, float Value) { ((FVector2D*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector2D_Y_GET(INT_PTR Ptr) { return ((FVector2D*)Ptr)->Y; }
	DOTNET_EXPORT void E_PROP_FVector2D_Y_SET(INT_PTR Ptr, float Value) { ((FVector2D*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT auto E_FVector2D_ClampAxes(FVector2D* Self, float MinAxisVal, float MaxAxisVal)
	{
		auto _p0 = MinAxisVal;
		auto _p1 = MaxAxisVal;
		return (INT_PTR) new FVector2D(Self->ClampAxes(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector2D_ContainsNaN(FVector2D* Self)
	{
		return ConvertForManage(Self->ContainsNaN());
	}

	DOTNET_EXPORT auto E_FVector2D_CrossProduct(FVector2D* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return ConvertForManage(Self->CrossProduct(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector2D_DiagnosticCheckNaN(FVector2D* Self)
	{
		Self->DiagnosticCheckNaN();
	}

	DOTNET_EXPORT auto E_FVector2D_Distance(FVector2D* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector2D*)V1;
		auto _p1 = *(FVector2D*)V2;
		return ConvertForManage(Self->Distance(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector2D_DistSquared(FVector2D* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector2D*)V1;
		auto _p1 = *(FVector2D*)V2;
		return ConvertForManage(Self->DistSquared(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector2D_DotProduct(FVector2D* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return ConvertForManage(Self->DotProduct(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector2D_Equals(FVector2D* Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector2D*)V;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->Equals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector2D_GetAbs(FVector2D* Self)
	{
		return (INT_PTR) new FVector2D(Self->GetAbs());
	}

	DOTNET_EXPORT auto E_FVector2D_GetAbsMax(FVector2D* Self)
	{
		return ConvertForManage(Self->GetAbsMax());
	}

	DOTNET_EXPORT auto E_FVector2D_GetMax(FVector2D* Self)
	{
		return ConvertForManage(Self->GetMax());
	}

	DOTNET_EXPORT auto E_FVector2D_GetMin(FVector2D* Self)
	{
		return ConvertForManage(Self->GetMin());
	}

	DOTNET_EXPORT auto E_FVector2D_GetRotated(FVector2D* Self, float AngleDeg)
	{
		auto _p0 = AngleDeg;
		return (INT_PTR) new FVector2D(Self->GetRotated(_p0));
	}

	DOTNET_EXPORT auto E_FVector2D_GetSafeNormal(FVector2D* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector2D(Self->GetSafeNormal(_p0));
	}

	DOTNET_EXPORT auto E_FVector2D_GetSignVector(FVector2D* Self)
	{
		return (INT_PTR) new FVector2D(Self->GetSignVector());
	}

	DOTNET_EXPORT auto E_FVector2D_InitFromString(FVector2D* Self, char* InSourceString)
	{
		auto _p0 = ConvertFromManage_FString(InSourceString);
		return ConvertForManage(Self->InitFromString(_p0));
	}

	DOTNET_EXPORT auto E_FVector2D_IsNearlyZero(FVector2D* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ConvertForManage(Self->IsNearlyZero(_p0));
	}

	DOTNET_EXPORT auto E_FVector2D_IsZero(FVector2D* Self)
	{
		return ConvertForManage(Self->IsZero());
	}

	DOTNET_EXPORT auto E_FVector2D_Normalize(FVector2D* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		Self->Normalize(_p0);
	}

	DOTNET_EXPORT auto E_FVector2D_RoundToVector(FVector2D* Self)
	{
		return (INT_PTR) new FVector2D(Self->RoundToVector());
	}

	DOTNET_EXPORT auto E_FVector2D_SafeNormal(FVector2D* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector2D(Self->SafeNormal(_p0));
	}

	DOTNET_EXPORT auto E_FVector2D_Set(FVector2D* Self, float InX, float InY)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		Self->Set(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector2D_Size(FVector2D* Self)
	{
		return ConvertForManage(Self->Size());
	}

	DOTNET_EXPORT auto E_FVector2D_SizeSquared(FVector2D* Self)
	{
		return ConvertForManage(Self->SizeSquared());
	}

	DOTNET_EXPORT auto E_FVector2D_SphericalToUnitCartesian(FVector2D* Self)
	{
		return (INT_PTR) new FVector(Self->SphericalToUnitCartesian());
	}

	DOTNET_EXPORT auto E_FVector2D_ToDirectionAndLength(FVector2D* Self, INT_PTR OutDir, float OutLength)
	{
		auto _p0 = *(FVector2D*)OutDir;
		auto _p1 = OutLength;
		Self->ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector2D_ToString(FVector2D* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	
	/*	FVector4	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector4_FVector_float(INT_PTR InVector, float InW) { return (INT_PTR) new FVector4(*(FVector*)InVector, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector4_float_float_float_float(float InX, float InY, float InZ, float InW) { return (INT_PTR) new FVector4(InX, InY, InZ, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector4_FVector2D_FVector2D(INT_PTR InXY, INT_PTR InZW) { return (INT_PTR) new FVector4(*(FVector2D*)InXY, *(FVector2D*)InZW); }
	
	DOTNET_EXPORT float E_PROP_FVector4_W_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->W; }
	DOTNET_EXPORT void E_PROP_FVector4_W_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->W = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector4_X_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->X; }
	DOTNET_EXPORT void E_PROP_FVector4_X_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector4_Y_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->Y; }
	DOTNET_EXPORT void E_PROP_FVector4_Y_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector4_Z_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->Z; }
	DOTNET_EXPORT void E_PROP_FVector4_Z_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->Z = Value; }
	
	DOTNET_EXPORT auto E_FVector4_Component(FVector4* Self, int32 Index)
	{
		auto _p0 = Index;
		return ConvertForManage(Self->Component(_p0));
	}

	DOTNET_EXPORT auto E_FVector4_ContainsNaN(FVector4* Self)
	{
		return ConvertForManage(Self->ContainsNaN());
	}

	DOTNET_EXPORT auto E_FVector4_DiagnosticCheckNaN(FVector4* Self)
	{
		Self->DiagnosticCheckNaN();
	}

	DOTNET_EXPORT auto E_FVector4_Equals(FVector4* Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector4*)V;
		auto _p1 = Tolerance;
		return ConvertForManage(Self->Equals(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector4_FindBestAxisVectors3(FVector4* Self, INT_PTR Axis1, INT_PTR Axis2)
	{
		auto _p0 = *(FVector4*)Axis1;
		auto _p1 = *(FVector4*)Axis2;
		Self->FindBestAxisVectors3(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector4_GetSafeNormal(FVector4* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector4(Self->GetSafeNormal(_p0));
	}

	DOTNET_EXPORT auto E_FVector4_GetUnsafeNormal3(FVector4* Self)
	{
		return (INT_PTR) new FVector4(Self->GetUnsafeNormal3());
	}

	DOTNET_EXPORT auto E_FVector4_InitFromString(FVector4* Self, char* InSourceString)
	{
		auto _p0 = ConvertFromManage_FString(InSourceString);
		return ConvertForManage(Self->InitFromString(_p0));
	}

	DOTNET_EXPORT auto E_FVector4_IsNearlyZero3(FVector4* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ConvertForManage(Self->IsNearlyZero3(_p0));
	}

	DOTNET_EXPORT auto E_FVector4_IsUnit3(FVector4* Self, float LengthSquaredTolerance)
	{
		auto _p0 = LengthSquaredTolerance;
		return ConvertForManage(Self->IsUnit3(_p0));
	}

	DOTNET_EXPORT auto E_FVector4_Reflect3(FVector4* Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector4*)Normal;
		return (INT_PTR) new FVector4(Self->Reflect3(_p0));
	}

	DOTNET_EXPORT auto E_FVector4_Rotation(FVector4* Self)
	{
		return (INT_PTR) new FRotator(Self->Rotation());
	}

	DOTNET_EXPORT auto E_FVector4_SafeNormal(FVector4* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector4(Self->SafeNormal(_p0));
	}

	DOTNET_EXPORT auto E_FVector4_Set(FVector4* Self, float InX, float InY, float InZ, float InW)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		auto _p3 = InW;
		Self->Set(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_FVector4_Size(FVector4* Self)
	{
		return ConvertForManage(Self->Size());
	}

	DOTNET_EXPORT auto E_FVector4_Size3(FVector4* Self)
	{
		return ConvertForManage(Self->Size3());
	}

	DOTNET_EXPORT auto E_FVector4_SizeSquared(FVector4* Self)
	{
		return ConvertForManage(Self->SizeSquared());
	}

	DOTNET_EXPORT auto E_FVector4_SizeSquared3(FVector4* Self)
	{
		return ConvertForManage(Self->SizeSquared3());
	}

	DOTNET_EXPORT auto E_FVector4_ToOrientationQuat(FVector4* Self)
	{
		return (INT_PTR) new FQuat(Self->ToOrientationQuat());
	}

	DOTNET_EXPORT auto E_FVector4_ToOrientationRotator(FVector4* Self)
	{
		return (INT_PTR) new FRotator(Self->ToOrientationRotator());
	}

	DOTNET_EXPORT auto E_FVector4_ToString(FVector4* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_FVector4_UnsafeNormal3(FVector4* Self)
	{
		return (INT_PTR) new FVector4(Self->UnsafeNormal3());
	}

	
	/*	FWeightedBlendable	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWeightedBlendable() { return (INT_PTR) new FWeightedBlendable(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWeightedBlendable_float_UObject(float InWeight, UObject* InObject) { return (INT_PTR) new FWeightedBlendable(InWeight, InObject); }
	
	DOTNET_EXPORT UObject* E_PROP_FWeightedBlendable_Object_GET(INT_PTR Ptr) { return ((FWeightedBlendable*)Ptr)->Object; }
	DOTNET_EXPORT void E_PROP_FWeightedBlendable_Object_SET(INT_PTR Ptr, UObject* Value) { ((FWeightedBlendable*)Ptr)->Object = Value; }
	
	DOTNET_EXPORT float E_PROP_FWeightedBlendable_Weight_GET(INT_PTR Ptr) { return ((FWeightedBlendable*)Ptr)->Weight; }
	DOTNET_EXPORT void E_PROP_FWeightedBlendable_Weight_SET(INT_PTR Ptr, float Value) { ((FWeightedBlendable*)Ptr)->Weight = Value; }
	
	
	/*	FWeightedBlendables	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWeightedBlendables() { return (INT_PTR) new FWeightedBlendables(); }
	
	
	/*	FWorldContext	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWorldContext() { return (INT_PTR) new FWorldContext(); }
	
	DOTNET_EXPORT bool E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_GET(INT_PTR Ptr) { return ((FWorldContext*)Ptr)->bWaitingOnOnlineSubsystem; }
	DOTNET_EXPORT void E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_SET(INT_PTR Ptr, bool Value) { ((FWorldContext*)Ptr)->bWaitingOnOnlineSubsystem = Value; }
	
	DOTNET_EXPORT char* E_PROP_FWorldContext_ContextHandle_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FWorldContext*)Ptr)->ContextHandle.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FWorldContext_ContextHandle_SET(INT_PTR Ptr, char* Value) { ((FWorldContext*)Ptr)->ContextHandle = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FWorldContext_LastRemoteURL_GET(INT_PTR Ptr) { return (INT_PTR)&((FWorldContext*)Ptr)->LastRemoteURL; }
	DOTNET_EXPORT void E_PROP_FWorldContext_LastRemoteURL_SET(INT_PTR Ptr, INT_PTR Value) { ((FWorldContext*)Ptr)->LastRemoteURL = *(FURL*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FWorldContext_LastURL_GET(INT_PTR Ptr) { return (INT_PTR)&((FWorldContext*)Ptr)->LastURL; }
	DOTNET_EXPORT void E_PROP_FWorldContext_LastURL_SET(INT_PTR Ptr, INT_PTR Value) { ((FWorldContext*)Ptr)->LastURL = *(FURL*)Value; }
	
	DOTNET_EXPORT char* E_PROP_FWorldContext_PendingMapChangeFailureDescription_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FWorldContext*)Ptr)->PendingMapChangeFailureDescription;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FWorldContext_PendingMapChangeFailureDescription_SET(INT_PTR Ptr, char* Value) { ((FWorldContext*)Ptr)->PendingMapChangeFailureDescription = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT int32 E_PROP_FWorldContext_PIEInstance_GET(INT_PTR Ptr) { return ((FWorldContext*)Ptr)->PIEInstance; }
	DOTNET_EXPORT void E_PROP_FWorldContext_PIEInstance_SET(INT_PTR Ptr, int32 Value) { ((FWorldContext*)Ptr)->PIEInstance = Value; }
	
	DOTNET_EXPORT char* E_PROP_FWorldContext_PIEPrefix_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FWorldContext*)Ptr)->PIEPrefix;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FWorldContext_PIEPrefix_SET(INT_PTR Ptr, char* Value) { ((FWorldContext*)Ptr)->PIEPrefix = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT char* E_PROP_FWorldContext_PIERemapPrefix_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FWorldContext*)Ptr)->PIERemapPrefix;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FWorldContext_PIERemapPrefix_SET(INT_PTR Ptr, char* Value) { ((FWorldContext*)Ptr)->PIERemapPrefix = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT bool E_PROP_FWorldContext_RunAsDedicated_GET(INT_PTR Ptr) { return ((FWorldContext*)Ptr)->RunAsDedicated; }
	DOTNET_EXPORT void E_PROP_FWorldContext_RunAsDedicated_SET(INT_PTR Ptr, bool Value) { ((FWorldContext*)Ptr)->RunAsDedicated = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_FWorldContext_TravelType_GET(INT_PTR Ptr) { return ((FWorldContext*)Ptr)->TravelType; }
	DOTNET_EXPORT void E_PROP_FWorldContext_TravelType_SET(INT_PTR Ptr, uint8 Value) { ((FWorldContext*)Ptr)->TravelType = Value; }
	
	DOTNET_EXPORT char* E_PROP_FWorldContext_TravelURL_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((FWorldContext*)Ptr)->TravelURL;
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_FWorldContext_TravelURL_SET(INT_PTR Ptr, char* Value) { ((FWorldContext*)Ptr)->TravelURL = UTF8_TO_TCHAR(Value); }
	
	DOTNET_EXPORT auto E_FWorldContext_SetCurrentWorld(FWorldContext* Self, UWorld* World)
	{
		auto _p0 = World;
		Self->SetCurrentWorld(_p0);
	}

	DOTNET_EXPORT auto E_FWorldContext_World(FWorldContext* Self)
	{
		return ConvertForManage(Self->World());
	}

}
