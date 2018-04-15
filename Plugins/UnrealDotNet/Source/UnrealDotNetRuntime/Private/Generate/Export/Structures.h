#pragma once

#include "CoreMinimal.h"
#include "Runtime/Engine/Classes/Components/SkinnedMeshComponent.h"
#include "Runtime/Engine/Classes/Engine/EngineBaseTypes.h"
#include "Runtime/Engine/Classes/Engine/World.h"
#include "Runtime/Engine/Classes/Components/SkeletalMeshComponent.h"
#include "Runtime/Engine/Classes/Engine/EngineTypes.h"
#include "Runtime/Engine/Classes/Components/AudioComponent.h"
#include "Runtime/Engine/Classes/GameFramework/Character.h"
#include "Runtime/Engine/Classes/Components/LineBatchComponent.h"
#include "Runtime/Core/Public/Math/Box.h"
#include "Runtime/Core/Public/Math/Box2D.h"
#include "Runtime/Engine/Classes/Engine/Scene.h"
#include "Runtime/Engine/Classes/Engine/Engine.h"
#include "Runtime/Engine/Classes/Components/HierarchicalInstancedStaticMeshComponent.h"
#include "Runtime/Engine/Classes/Components/SceneComponent.h"
#include "Runtime/Engine/Classes/Components/SceneCaptureComponent.h"
#include "Runtime/Engine/Classes/GameFramework/CharacterMovementComponent.h"
#include "Runtime/CoreUObject/Public/UObject/UObjectArray.h"
#include "Runtime/Engine/Classes/GameFramework/GameModeBase.h"
#include "Runtime/Engine/Classes/Components/InstancedStaticMeshComponent.h"
#include "Runtime/Engine/Classes/Components/InterpToMovementComponent.h"
#include "Runtime/Engine/Classes/Components/MaterialBillboardComponent.h"
#include "Runtime/Engine/Classes/Components/StaticMeshComponent.h"
#include "Runtime/Core/Public/Math/Plane.h"
#include "Runtime/Core/Public/Math/Quat.h"
#include "Runtime/Engine/Classes/Components/PrimitiveComponent.h"
#include "Runtime/Core/Public/Math/Rotator.h"
#include "Runtime/Engine/Classes/Components/SplineComponent.h"
#include "Runtime/Engine/Classes/Components/SplineMeshComponent.h"
#include "Runtime/Engine/Classes/Components/TimelineComponent.h"
#include "Runtime/Core/Public/Math/TransformVectorized.h"
#include "Runtime/Core/Public/Math/Vector.h"
#include "Runtime/Core/Public/Math/Vector2D.h"
#include "Runtime/Core/Public/Math/Vector4.h"

extern "C"
{
	
	/*	FActiveMorphTarget	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActiveMorphTarget() { return (INT_PTR) new FActiveMorphTarget(); }
	
	DOTNET_EXPORT auto E_PROP_FActiveMorphTarget_WeightIndex_GET(FActiveMorphTarget* Ptr) { return Ptr->WeightIndex; }
	DOTNET_EXPORT void E_PROP_FActiveMorphTarget_WeightIndex_SET(FActiveMorphTarget* Ptr, int32 Value) { Ptr->WeightIndex = Value; }
	
	
	/*	FActorComponentTickFunction	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActorComponentTickFunction() { return (INT_PTR) new FActorComponentTickFunction(); }
	
	DOTNET_EXPORT auto E_PROP_FActorComponentTickFunction_Target_GET(FActorComponentTickFunction* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Target); }
	DOTNET_EXPORT void E_PROP_FActorComponentTickFunction_Target_SET(FActorComponentTickFunction* Ptr, UActorComponent* Value) { Ptr->Target = Value; }
	
	
	/*	FActorSpawnParameters	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActorSpawnParameters() { return (INT_PTR) new FActorSpawnParameters(); }
	
	DOTNET_EXPORT auto E_PROP_FActorSpawnParameters_Instigator_GET(FActorSpawnParameters* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Instigator); }
	DOTNET_EXPORT void E_PROP_FActorSpawnParameters_Instigator_SET(FActorSpawnParameters* Ptr, APawn* Value) { Ptr->Instigator = Value; }
	
	DOTNET_EXPORT auto E_PROP_FActorSpawnParameters_Name_GET(FActorSpawnParameters* Ptr) { return ConvertToManage_StringWrapper(Ptr->Name); }
	DOTNET_EXPORT void E_PROP_FActorSpawnParameters_Name_SET(FActorSpawnParameters* Ptr, char* Value) { Ptr->Name = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FActorSpawnParameters_Owner_GET(FActorSpawnParameters* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Owner); }
	DOTNET_EXPORT void E_PROP_FActorSpawnParameters_Owner_SET(FActorSpawnParameters* Ptr, AActor* Value) { Ptr->Owner = Value; }
	
	DOTNET_EXPORT auto E_PROP_FActorSpawnParameters_SpawnCollisionHandlingOverride_GET(FActorSpawnParameters* Ptr) { return Ptr->SpawnCollisionHandlingOverride; }
	DOTNET_EXPORT void E_PROP_FActorSpawnParameters_SpawnCollisionHandlingOverride_SET(FActorSpawnParameters* Ptr, ESpawnActorCollisionHandlingMethod Value) { Ptr->SpawnCollisionHandlingOverride = Value; }
	
	DOTNET_EXPORT auto E_PROP_FActorSpawnParameters_Template_GET(FActorSpawnParameters* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Template); }
	DOTNET_EXPORT void E_PROP_FActorSpawnParameters_Template_SET(FActorSpawnParameters* Ptr, AActor* Value) { Ptr->Template = Value; }
	
	DOTNET_EXPORT auto E_FActorSpawnParameters_IsRemoteOwned(FActorSpawnParameters* Self)
	{
		return Self->IsRemoteOwned();
	}

	
	/*	FActorTickFunction	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActorTickFunction() { return (INT_PTR) new FActorTickFunction(); }
	
	DOTNET_EXPORT auto E_PROP_FActorTickFunction_Target_GET(FActorTickFunction* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Target); }
	DOTNET_EXPORT void E_PROP_FActorTickFunction_Target_SET(FActorTickFunction* Ptr, AActor* Value) { Ptr->Target = Value; }
	
	
	/*	FAnimationEvaluationContext	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAnimationEvaluationContext() { return (INT_PTR) new FAnimationEvaluationContext(); }
	
	DOTNET_EXPORT auto E_PROP_FAnimationEvaluationContext_bDoEvaluation_GET(FAnimationEvaluationContext* Ptr) { return Ptr->bDoEvaluation; }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_bDoEvaluation_SET(FAnimationEvaluationContext* Ptr, bool Value) { Ptr->bDoEvaluation = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAnimationEvaluationContext_bDoInterpolation_GET(FAnimationEvaluationContext* Ptr) { return Ptr->bDoInterpolation; }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_bDoInterpolation_SET(FAnimationEvaluationContext* Ptr, bool Value) { Ptr->bDoInterpolation = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_GET(FAnimationEvaluationContext* Ptr) { return Ptr->bDuplicateToCacheBones; }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_SET(FAnimationEvaluationContext* Ptr, bool Value) { Ptr->bDuplicateToCacheBones = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_GET(FAnimationEvaluationContext* Ptr) { return Ptr->bDuplicateToCacheCurve; }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_SET(FAnimationEvaluationContext* Ptr, bool Value) { Ptr->bDuplicateToCacheCurve = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAnimationEvaluationContext_RootBoneTranslation_GET(FAnimationEvaluationContext* Ptr) { return (INT_PTR)&(Ptr->RootBoneTranslation); }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_RootBoneTranslation_SET(FAnimationEvaluationContext* Ptr, INT_PTR Value) { Ptr->RootBoneTranslation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_FAnimationEvaluationContext_Clear(FAnimationEvaluationContext* Self)
	{
		Self->Clear();
	}

	DOTNET_EXPORT auto E_FAnimationEvaluationContext_Copy(FAnimationEvaluationContext* Self, INT_PTR Other)
	{
		auto _p0 = *(FAnimationEvaluationContext*)Other;
		Self->Copy(_p0);
	}

	
	/*	FAnimSlotDesc	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAnimSlotDesc() { return (INT_PTR) new FAnimSlotDesc(); }
	
	DOTNET_EXPORT auto E_PROP_FAnimSlotDesc_NumChannels_GET(FAnimSlotDesc* Ptr) { return Ptr->NumChannels; }
	DOTNET_EXPORT void E_PROP_FAnimSlotDesc_NumChannels_SET(FAnimSlotDesc* Ptr, int32 Value) { Ptr->NumChannels = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAnimSlotDesc_SlotName_GET(FAnimSlotDesc* Ptr) { return ConvertToManage_StringWrapper(Ptr->SlotName); }
	DOTNET_EXPORT void E_PROP_FAnimSlotDesc_SlotName_SET(FAnimSlotDesc* Ptr, char* Value) { Ptr->SlotName = ConvertFromManage_FName(Value); }
	
	
	/*	FAnimSlotInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAnimSlotInfo() { return (INT_PTR) new FAnimSlotInfo(); }
	
	DOTNET_EXPORT auto E_PROP_FAnimSlotInfo_SlotName_GET(FAnimSlotInfo* Ptr) { return ConvertToManage_StringWrapper(Ptr->SlotName); }
	DOTNET_EXPORT void E_PROP_FAnimSlotInfo_SlotName_SET(FAnimSlotInfo* Ptr, char* Value) { Ptr->SlotName = ConvertFromManage_FName(Value); }
	
	
	/*	FAttachmentTransformRules	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool(EAttachmentRule InRule, bool bInWeldSimulatedBodies) { return (INT_PTR) new FAttachmentTransformRules(InRule, bInWeldSimulatedBodies); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool(EAttachmentRule InLocationRule, EAttachmentRule InRotationRule, EAttachmentRule InScaleRule, bool bInWeldSimulatedBodies) { return (INT_PTR) new FAttachmentTransformRules(InLocationRule, InRotationRule, InScaleRule, bInWeldSimulatedBodies); }
	
	DOTNET_EXPORT auto E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_GET(FAttachmentTransformRules* Ptr) { return Ptr->bWeldSimulatedBodies; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_bWeldSimulatedBodies_SET(FAttachmentTransformRules* Ptr, bool Value) { Ptr->bWeldSimulatedBodies = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAttachmentTransformRules_KeepRelativeTransform_GET() { return (INT_PTR)&(FAttachmentTransformRules::KeepRelativeTransform); }
	
	DOTNET_EXPORT auto E_PROP_FAttachmentTransformRules_KeepWorldTransform_GET() { return (INT_PTR)&(FAttachmentTransformRules::KeepWorldTransform); }
	
	DOTNET_EXPORT auto E_PROP_FAttachmentTransformRules_LocationRule_GET(FAttachmentTransformRules* Ptr) { return Ptr->LocationRule; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_LocationRule_SET(FAttachmentTransformRules* Ptr, EAttachmentRule Value) { Ptr->LocationRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAttachmentTransformRules_RotationRule_GET(FAttachmentTransformRules* Ptr) { return Ptr->RotationRule; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_RotationRule_SET(FAttachmentTransformRules* Ptr, EAttachmentRule Value) { Ptr->RotationRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAttachmentTransformRules_ScaleRule_GET(FAttachmentTransformRules* Ptr) { return Ptr->ScaleRule; }
	DOTNET_EXPORT void E_PROP_FAttachmentTransformRules_ScaleRule_SET(FAttachmentTransformRules* Ptr, EAttachmentRule Value) { Ptr->ScaleRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAttachmentTransformRules_SnapToTargetIncludingScale_GET() { return (INT_PTR)&(FAttachmentTransformRules::SnapToTargetIncludingScale); }
	
	DOTNET_EXPORT auto E_PROP_FAttachmentTransformRules_SnapToTargetNotIncludingScale_GET() { return (INT_PTR)&(FAttachmentTransformRules::SnapToTargetNotIncludingScale); }
	
	
	/*	FAudioComponentParam	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAudioComponentParam_FName(char* Name) { return (INT_PTR) new FAudioComponentParam(ConvertFromManage_FName(Name)); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAudioComponentParam() { return (INT_PTR) new FAudioComponentParam(); }
	
	DOTNET_EXPORT auto E_PROP_FAudioComponentParam_BoolParam_GET(FAudioComponentParam* Ptr) { return Ptr->BoolParam; }
	DOTNET_EXPORT void E_PROP_FAudioComponentParam_BoolParam_SET(FAudioComponentParam* Ptr, bool Value) { Ptr->BoolParam = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAudioComponentParam_FloatParam_GET(FAudioComponentParam* Ptr) { return Ptr->FloatParam; }
	DOTNET_EXPORT void E_PROP_FAudioComponentParam_FloatParam_SET(FAudioComponentParam* Ptr, float Value) { Ptr->FloatParam = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAudioComponentParam_IntParam_GET(FAudioComponentParam* Ptr) { return Ptr->IntParam; }
	DOTNET_EXPORT void E_PROP_FAudioComponentParam_IntParam_SET(FAudioComponentParam* Ptr, int32 Value) { Ptr->IntParam = Value; }
	
	DOTNET_EXPORT auto E_PROP_FAudioComponentParam_ParamName_GET(FAudioComponentParam* Ptr) { return ConvertToManage_StringWrapper(Ptr->ParamName); }
	DOTNET_EXPORT void E_PROP_FAudioComponentParam_ParamName_SET(FAudioComponentParam* Ptr, char* Value) { Ptr->ParamName = ConvertFromManage_FName(Value); }
	
	
	/*	FBasedMovementInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBasedMovementInfo() { return (INT_PTR) new FBasedMovementInfo(); }
	
	DOTNET_EXPORT auto E_PROP_FBasedMovementInfo_BoneName_GET(FBasedMovementInfo* Ptr) { return ConvertToManage_StringWrapper(Ptr->BoneName); }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_BoneName_SET(FBasedMovementInfo* Ptr, char* Value) { Ptr->BoneName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FBasedMovementInfo_bRelativeRotation_GET(FBasedMovementInfo* Ptr) { return Ptr->bRelativeRotation; }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_bRelativeRotation_SET(FBasedMovementInfo* Ptr, bool Value) { Ptr->bRelativeRotation = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBasedMovementInfo_bServerHasBaseComponent_GET(FBasedMovementInfo* Ptr) { return Ptr->bServerHasBaseComponent; }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_bServerHasBaseComponent_SET(FBasedMovementInfo* Ptr, bool Value) { Ptr->bServerHasBaseComponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBasedMovementInfo_bServerHasVelocity_GET(FBasedMovementInfo* Ptr) { return Ptr->bServerHasVelocity; }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_bServerHasVelocity_SET(FBasedMovementInfo* Ptr, bool Value) { Ptr->bServerHasVelocity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBasedMovementInfo_MovementBase_GET(FBasedMovementInfo* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->MovementBase); }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_MovementBase_SET(FBasedMovementInfo* Ptr, UPrimitiveComponent* Value) { Ptr->MovementBase = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBasedMovementInfo_Rotation_GET(FBasedMovementInfo* Ptr) { return (INT_PTR)&(Ptr->Rotation); }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_Rotation_SET(FBasedMovementInfo* Ptr, INT_PTR Value) { Ptr->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_FBasedMovementInfo_HasRelativeLocation(FBasedMovementInfo* Self)
	{
		return Self->HasRelativeLocation();
	}

	DOTNET_EXPORT auto E_FBasedMovementInfo_HasRelativeRotation(FBasedMovementInfo* Self)
	{
		return Self->HasRelativeRotation();
	}

	DOTNET_EXPORT auto E_FBasedMovementInfo_IsBaseUnresolved(FBasedMovementInfo* Self)
	{
		return Self->IsBaseUnresolved();
	}

	
	/*	FBasedPosition	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBasedPosition() { return (INT_PTR) new FBasedPosition(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBasedPosition_AActor_FVector(AActor* InBase, INT_PTR InPosition) { return (INT_PTR) new FBasedPosition(InBase, *(FVector*)InPosition); }
	
	DOTNET_EXPORT auto E_PROP_FBasedPosition_Base_GET(FBasedPosition* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Base); }
	DOTNET_EXPORT void E_PROP_FBasedPosition_Base_SET(FBasedPosition* Ptr, AActor* Value) { Ptr->Base = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBasedPosition_CachedBaseLocation_GET(FBasedPosition* Ptr) { return (INT_PTR)&(Ptr->CachedBaseLocation); }
	DOTNET_EXPORT void E_PROP_FBasedPosition_CachedBaseLocation_SET(FBasedPosition* Ptr, INT_PTR Value) { Ptr->CachedBaseLocation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FBasedPosition_CachedBaseRotation_GET(FBasedPosition* Ptr) { return (INT_PTR)&(Ptr->CachedBaseRotation); }
	DOTNET_EXPORT void E_PROP_FBasedPosition_CachedBaseRotation_SET(FBasedPosition* Ptr, INT_PTR Value) { Ptr->CachedBaseRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FBasedPosition_CachedTransPosition_GET(FBasedPosition* Ptr) { return (INT_PTR)&(Ptr->CachedTransPosition); }
	DOTNET_EXPORT void E_PROP_FBasedPosition_CachedTransPosition_SET(FBasedPosition* Ptr, INT_PTR Value) { Ptr->CachedTransPosition = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FBasedPosition_Position_GET(FBasedPosition* Ptr) { return (INT_PTR)&(Ptr->Position); }
	DOTNET_EXPORT void E_PROP_FBasedPosition_Position_SET(FBasedPosition* Ptr, INT_PTR Value) { Ptr->Position = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_FBasedPosition_Clear(FBasedPosition* Self)
	{
		Self->Clear();
	}

	DOTNET_EXPORT auto E_FBasedPosition_Set(FBasedPosition* Self, AActor* InBase, INT_PTR InPosition)
	{
		auto _p0 = InBase;
		auto _p1 = *(FVector*)InPosition;
		Self->Set(_p0, _p1);
	}

	
	/*	FBatchedLine	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBatchedLine() { return (INT_PTR) new FBatchedLine(); }
	
	DOTNET_EXPORT auto E_PROP_FBatchedLine_DepthPriority_GET(FBatchedLine* Ptr) { return Ptr->DepthPriority; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_DepthPriority_SET(FBatchedLine* Ptr, uint8 Value) { Ptr->DepthPriority = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBatchedLine_End_GET(FBatchedLine* Ptr) { return (INT_PTR)&(Ptr->End); }
	DOTNET_EXPORT void E_PROP_FBatchedLine_End_SET(FBatchedLine* Ptr, INT_PTR Value) { Ptr->End = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FBatchedLine_RemainingLifeTime_GET(FBatchedLine* Ptr) { return Ptr->RemainingLifeTime; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_RemainingLifeTime_SET(FBatchedLine* Ptr, float Value) { Ptr->RemainingLifeTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBatchedLine_Start_GET(FBatchedLine* Ptr) { return (INT_PTR)&(Ptr->Start); }
	DOTNET_EXPORT void E_PROP_FBatchedLine_Start_SET(FBatchedLine* Ptr, INT_PTR Value) { Ptr->Start = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FBatchedLine_Thickness_GET(FBatchedLine* Ptr) { return Ptr->Thickness; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_Thickness_SET(FBatchedLine* Ptr, float Value) { Ptr->Thickness = Value; }
	
	
	/*	FBatchedMesh	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBatchedMesh() { return (INT_PTR) new FBatchedMesh(); }
	
	DOTNET_EXPORT auto E_PROP_FBatchedMesh_DepthPriority_GET(FBatchedMesh* Ptr) { return Ptr->DepthPriority; }
	DOTNET_EXPORT void E_PROP_FBatchedMesh_DepthPriority_SET(FBatchedMesh* Ptr, uint8 Value) { Ptr->DepthPriority = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBatchedMesh_RemainingLifeTime_GET(FBatchedMesh* Ptr) { return Ptr->RemainingLifeTime; }
	DOTNET_EXPORT void E_PROP_FBatchedMesh_RemainingLifeTime_SET(FBatchedMesh* Ptr, float Value) { Ptr->RemainingLifeTime = Value; }
	
	
	/*	FBatchedPoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBatchedPoint() { return (INT_PTR) new FBatchedPoint(); }
	
	DOTNET_EXPORT auto E_PROP_FBatchedPoint_DepthPriority_GET(FBatchedPoint* Ptr) { return Ptr->DepthPriority; }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_DepthPriority_SET(FBatchedPoint* Ptr, uint8 Value) { Ptr->DepthPriority = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBatchedPoint_PointSize_GET(FBatchedPoint* Ptr) { return Ptr->PointSize; }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_PointSize_SET(FBatchedPoint* Ptr, float Value) { Ptr->PointSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBatchedPoint_Position_GET(FBatchedPoint* Ptr) { return (INT_PTR)&(Ptr->Position); }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_Position_SET(FBatchedPoint* Ptr, INT_PTR Value) { Ptr->Position = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FBatchedPoint_RemainingLifeTime_GET(FBatchedPoint* Ptr) { return Ptr->RemainingLifeTime; }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_RemainingLifeTime_SET(FBatchedPoint* Ptr, float Value) { Ptr->RemainingLifeTime = Value; }
	
	
	/*	FBox	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox() { return (INT_PTR) new FBox(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox_int32(int32 _p0) { return (INT_PTR) new FBox(_p0); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox_FVector_FVector(INT_PTR InMin, INT_PTR InMax) { return (INT_PTR) new FBox(*(FVector*)InMin, *(FVector*)InMax); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox_FVector_int32(INT_PTR Points, int32 Count) { return (INT_PTR) new FBox((FVector*)Points, Count); }
	
	DOTNET_EXPORT auto E_PROP_FBox_IsValid_GET(FBox* Ptr) { return Ptr->IsValid; }
	DOTNET_EXPORT void E_PROP_FBox_IsValid_SET(FBox* Ptr, uint8 Value) { Ptr->IsValid = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBox_Max_GET(FBox* Ptr) { return (INT_PTR)&(Ptr->Max); }
	DOTNET_EXPORT void E_PROP_FBox_Max_SET(FBox* Ptr, INT_PTR Value) { Ptr->Max = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FBox_Min_GET(FBox* Ptr) { return (INT_PTR)&(Ptr->Min); }
	DOTNET_EXPORT void E_PROP_FBox_Min_SET(FBox* Ptr, INT_PTR Value) { Ptr->Min = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_FBox_BuildAABB(FBox* Self, INT_PTR Origin, INT_PTR Extent)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = *(FVector*)Extent;
		return (INT_PTR) new FBox(Self->BuildAABB(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FBox_ComputeSquaredDistanceToPoint(FBox* Self, INT_PTR Point)
	{
		auto _p0 = *(FVector*)Point;
		return Self->ComputeSquaredDistanceToPoint(_p0);
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
		return Self->GetVolume();
	}

	DOTNET_EXPORT auto E_FBox_Init(FBox* Self)
	{
		Self->Init();
	}

	DOTNET_EXPORT auto E_FBox_Intersect(FBox* Self, INT_PTR other)
	{
		auto _p0 = *(FBox*)other;
		return Self->Intersect(_p0);
	}

	DOTNET_EXPORT auto E_FBox_IntersectXY(FBox* Self, INT_PTR Other)
	{
		auto _p0 = *(FBox*)Other;
		return Self->IntersectXY(_p0);
	}

	DOTNET_EXPORT auto E_FBox_InverseTransformBy(FBox* Self, INT_PTR M)
	{
		auto _p0 = *(FTransform*)M;
		return (INT_PTR) new FBox(Self->InverseTransformBy(_p0));
	}

	DOTNET_EXPORT auto E_FBox_IsInsideOrOn(FBox* Self, INT_PTR In)
	{
		auto _p0 = *(FVector*)In;
		return Self->IsInsideOrOn(_p0);
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

	DOTNET_EXPORT auto E_FBox_ToString(FBox* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
	}

	
	/*	FBox2D	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D() { return (INT_PTR) new FBox2D(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D_int32(int32 _p0) { return (INT_PTR) new FBox2D(_p0); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D_FVector2D_FVector2D(INT_PTR InMin, INT_PTR InMax) { return (INT_PTR) new FBox2D(*(FVector2D*)InMin, *(FVector2D*)InMax); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D_FVector2D_int32(INT_PTR Points, int32 Count) { return (INT_PTR) new FBox2D((FVector2D*)Points, Count); }
	
	DOTNET_EXPORT auto E_PROP_FBox2D_bIsValid_GET(FBox2D* Ptr) { return Ptr->bIsValid; }
	DOTNET_EXPORT void E_PROP_FBox2D_bIsValid_SET(FBox2D* Ptr, bool Value) { Ptr->bIsValid = Value; }
	
	DOTNET_EXPORT auto E_PROP_FBox2D_Max_GET(FBox2D* Ptr) { return (INT_PTR)&(Ptr->Max); }
	DOTNET_EXPORT void E_PROP_FBox2D_Max_SET(FBox2D* Ptr, INT_PTR Value) { Ptr->Max = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FBox2D_Min_GET(FBox2D* Ptr) { return (INT_PTR)&(Ptr->Min); }
	DOTNET_EXPORT void E_PROP_FBox2D_Min_SET(FBox2D* Ptr, INT_PTR Value) { Ptr->Min = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_FBox2D_ComputeSquaredDistanceToPoint(FBox2D* Self, INT_PTR Point)
	{
		auto _p0 = *(FVector2D*)Point;
		return Self->ComputeSquaredDistanceToPoint(_p0);
	}

	DOTNET_EXPORT auto E_FBox2D_ExpandBy(FBox2D* Self, float W)
	{
		auto _p0 = W;
		return (INT_PTR) new FBox2D(Self->ExpandBy(_p0));
	}

	DOTNET_EXPORT auto E_FBox2D_GetArea(FBox2D* Self)
	{
		return Self->GetArea();
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
		return Self->Intersect(_p0);
	}

	DOTNET_EXPORT auto E_FBox2D_ShiftBy(FBox2D* Self, INT_PTR Offset)
	{
		auto _p0 = *(FVector2D*)Offset;
		return (INT_PTR) new FBox2D(Self->ShiftBy(_p0));
	}

	DOTNET_EXPORT auto E_FBox2D_ToString(FBox2D* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
	}

	
	/*	FCameraExposureSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FCameraExposureSettings() { return (INT_PTR) new FCameraExposureSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_Bias_GET(FCameraExposureSettings* Ptr) { return Ptr->Bias; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_Bias_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->Bias = Value; }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_CalibrationConstant_GET(FCameraExposureSettings* Ptr) { return Ptr->CalibrationConstant; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_CalibrationConstant_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->CalibrationConstant = Value; }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_HighPercent_GET(FCameraExposureSettings* Ptr) { return Ptr->HighPercent; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_HighPercent_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->HighPercent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_HistogramLogMax_GET(FCameraExposureSettings* Ptr) { return Ptr->HistogramLogMax; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_HistogramLogMax_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->HistogramLogMax = Value; }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_HistogramLogMin_GET(FCameraExposureSettings* Ptr) { return Ptr->HistogramLogMin; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_HistogramLogMin_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->HistogramLogMin = Value; }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_LowPercent_GET(FCameraExposureSettings* Ptr) { return Ptr->LowPercent; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_LowPercent_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->LowPercent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_MaxBrightness_GET(FCameraExposureSettings* Ptr) { return Ptr->MaxBrightness; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_MaxBrightness_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->MaxBrightness = Value; }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_MinBrightness_GET(FCameraExposureSettings* Ptr) { return Ptr->MinBrightness; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_MinBrightness_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->MinBrightness = Value; }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_SpeedDown_GET(FCameraExposureSettings* Ptr) { return Ptr->SpeedDown; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_SpeedDown_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->SpeedDown = Value; }
	
	DOTNET_EXPORT auto E_PROP_FCameraExposureSettings_SpeedUp_GET(FCameraExposureSettings* Ptr) { return Ptr->SpeedUp; }
	DOTNET_EXPORT void E_PROP_FCameraExposureSettings_SpeedUp_SET(FCameraExposureSettings* Ptr, float Value) { Ptr->SpeedUp = Value; }
	
	DOTNET_EXPORT auto E_FCameraExposureSettings_ExportToPostProcessSettings(FCameraExposureSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FCanvasUVTri	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FCanvasUVTri() { return (INT_PTR) new FCanvasUVTri(); }
	
	DOTNET_EXPORT auto E_PROP_FCanvasUVTri_V0_Pos_GET(FCanvasUVTri* Ptr) { return (INT_PTR)&(Ptr->V0_Pos); }
	DOTNET_EXPORT void E_PROP_FCanvasUVTri_V0_Pos_SET(FCanvasUVTri* Ptr, INT_PTR Value) { Ptr->V0_Pos = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FCanvasUVTri_V0_UV_GET(FCanvasUVTri* Ptr) { return (INT_PTR)&(Ptr->V0_UV); }
	DOTNET_EXPORT void E_PROP_FCanvasUVTri_V0_UV_SET(FCanvasUVTri* Ptr, INT_PTR Value) { Ptr->V0_UV = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FCanvasUVTri_V1_Pos_GET(FCanvasUVTri* Ptr) { return (INT_PTR)&(Ptr->V1_Pos); }
	DOTNET_EXPORT void E_PROP_FCanvasUVTri_V1_Pos_SET(FCanvasUVTri* Ptr, INT_PTR Value) { Ptr->V1_Pos = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FCanvasUVTri_V1_UV_GET(FCanvasUVTri* Ptr) { return (INT_PTR)&(Ptr->V1_UV); }
	DOTNET_EXPORT void E_PROP_FCanvasUVTri_V1_UV_SET(FCanvasUVTri* Ptr, INT_PTR Value) { Ptr->V1_UV = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FCanvasUVTri_V2_Pos_GET(FCanvasUVTri* Ptr) { return (INT_PTR)&(Ptr->V2_Pos); }
	DOTNET_EXPORT void E_PROP_FCanvasUVTri_V2_Pos_SET(FCanvasUVTri* Ptr, INT_PTR Value) { Ptr->V2_Pos = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FCanvasUVTri_V2_UV_GET(FCanvasUVTri* Ptr) { return (INT_PTR)&(Ptr->V2_UV); }
	DOTNET_EXPORT void E_PROP_FCanvasUVTri_V2_UV_SET(FCanvasUVTri* Ptr, INT_PTR Value) { Ptr->V2_UV = *(FVector2D*)Value; }
	
	
	/*	FClassRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClassRedirect() { return (INT_PTR) new FClassRedirect(); }
	
	DOTNET_EXPORT auto E_PROP_FClassRedirect_InstanceOnly_GET(FClassRedirect* Ptr) { return Ptr->InstanceOnly; }
	DOTNET_EXPORT void E_PROP_FClassRedirect_InstanceOnly_SET(FClassRedirect* Ptr, bool Value) { Ptr->InstanceOnly = Value; }
	
	DOTNET_EXPORT auto E_PROP_FClassRedirect_NewClassClass_GET(FClassRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewClassClass); }
	DOTNET_EXPORT void E_PROP_FClassRedirect_NewClassClass_SET(FClassRedirect* Ptr, char* Value) { Ptr->NewClassClass = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FClassRedirect_NewClassName_GET(FClassRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewClassName); }
	DOTNET_EXPORT void E_PROP_FClassRedirect_NewClassName_SET(FClassRedirect* Ptr, char* Value) { Ptr->NewClassName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FClassRedirect_NewClassPackage_GET(FClassRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewClassPackage); }
	DOTNET_EXPORT void E_PROP_FClassRedirect_NewClassPackage_SET(FClassRedirect* Ptr, char* Value) { Ptr->NewClassPackage = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FClassRedirect_NewSubobjName_GET(FClassRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewSubobjName); }
	DOTNET_EXPORT void E_PROP_FClassRedirect_NewSubobjName_SET(FClassRedirect* Ptr, char* Value) { Ptr->NewSubobjName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FClassRedirect_ObjectName_GET(FClassRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->ObjectName); }
	DOTNET_EXPORT void E_PROP_FClassRedirect_ObjectName_SET(FClassRedirect* Ptr, char* Value) { Ptr->ObjectName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FClassRedirect_OldClassName_GET(FClassRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->OldClassName); }
	DOTNET_EXPORT void E_PROP_FClassRedirect_OldClassName_SET(FClassRedirect* Ptr, char* Value) { Ptr->OldClassName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FClassRedirect_OldSubobjName_GET(FClassRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->OldSubobjName); }
	DOTNET_EXPORT void E_PROP_FClassRedirect_OldSubobjName_SET(FClassRedirect* Ptr, char* Value) { Ptr->OldSubobjName = ConvertFromManage_FName(Value); }
	
	
	/*	FClosestPointOnPhysicsAsset	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClosestPointOnPhysicsAsset() { return (INT_PTR) new FClosestPointOnPhysicsAsset(); }
	
	DOTNET_EXPORT auto E_PROP_FClosestPointOnPhysicsAsset_BoneName_GET(FClosestPointOnPhysicsAsset* Ptr) { return ConvertToManage_StringWrapper(Ptr->BoneName); }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_BoneName_SET(FClosestPointOnPhysicsAsset* Ptr, char* Value) { Ptr->BoneName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_GET(FClosestPointOnPhysicsAsset* Ptr) { return (INT_PTR)&(Ptr->ClosestWorldPosition); }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_SET(FClosestPointOnPhysicsAsset* Ptr, INT_PTR Value) { Ptr->ClosestWorldPosition = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FClosestPointOnPhysicsAsset_Distance_GET(FClosestPointOnPhysicsAsset* Ptr) { return Ptr->Distance; }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_Distance_SET(FClosestPointOnPhysicsAsset* Ptr, float Value) { Ptr->Distance = Value; }
	
	DOTNET_EXPORT auto E_PROP_FClosestPointOnPhysicsAsset_Normal_GET(FClosestPointOnPhysicsAsset* Ptr) { return (INT_PTR)&(Ptr->Normal); }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_Normal_SET(FClosestPointOnPhysicsAsset* Ptr, INT_PTR Value) { Ptr->Normal = *(FVector*)Value; }
	
	
	/*	FClusterNode	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClusterNode() { return (INT_PTR) new FClusterNode(); }
	
	DOTNET_EXPORT auto E_PROP_FClusterNode_BoundMax_GET(FClusterNode* Ptr) { return (INT_PTR)&(Ptr->BoundMax); }
	DOTNET_EXPORT void E_PROP_FClusterNode_BoundMax_SET(FClusterNode* Ptr, INT_PTR Value) { Ptr->BoundMax = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FClusterNode_BoundMin_GET(FClusterNode* Ptr) { return (INT_PTR)&(Ptr->BoundMin); }
	DOTNET_EXPORT void E_PROP_FClusterNode_BoundMin_SET(FClusterNode* Ptr, INT_PTR Value) { Ptr->BoundMin = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FClusterNode_FirstChild_GET(FClusterNode* Ptr) { return Ptr->FirstChild; }
	DOTNET_EXPORT void E_PROP_FClusterNode_FirstChild_SET(FClusterNode* Ptr, int32 Value) { Ptr->FirstChild = Value; }
	
	DOTNET_EXPORT auto E_PROP_FClusterNode_FirstInstance_GET(FClusterNode* Ptr) { return Ptr->FirstInstance; }
	DOTNET_EXPORT void E_PROP_FClusterNode_FirstInstance_SET(FClusterNode* Ptr, int32 Value) { Ptr->FirstInstance = Value; }
	
	DOTNET_EXPORT auto E_PROP_FClusterNode_LastChild_GET(FClusterNode* Ptr) { return Ptr->LastChild; }
	DOTNET_EXPORT void E_PROP_FClusterNode_LastChild_SET(FClusterNode* Ptr, int32 Value) { Ptr->LastChild = Value; }
	
	DOTNET_EXPORT auto E_PROP_FClusterNode_LastInstance_GET(FClusterNode* Ptr) { return Ptr->LastInstance; }
	DOTNET_EXPORT void E_PROP_FClusterNode_LastInstance_SET(FClusterNode* Ptr, int32 Value) { Ptr->LastInstance = Value; }
	
	
	/*	FCollectionReference	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FCollectionReference() { return (INT_PTR) new FCollectionReference(); }
	
	DOTNET_EXPORT auto E_PROP_FCollectionReference_CollectionName_GET(FCollectionReference* Ptr) { return ConvertToManage_StringWrapper(Ptr->CollectionName); }
	DOTNET_EXPORT void E_PROP_FCollectionReference_CollectionName_SET(FCollectionReference* Ptr, char* Value) { Ptr->CollectionName = ConvertFromManage_FName(Value); }
	
	
	/*	FCollisionResponseContainer	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FCollisionResponseContainer() { return (INT_PTR) new FCollisionResponseContainer(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FCollisionResponseContainer_ECollisionResponse(ECollisionResponse DefaultResponse) { return (INT_PTR) new FCollisionResponseContainer(DefaultResponse); }
	
	DOTNET_EXPORT auto E_FCollisionResponseContainer_CreateMinContainer(FCollisionResponseContainer* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FCollisionResponseContainer*)A;
		auto _p1 = *(FCollisionResponseContainer*)B;
		return (INT_PTR) new FCollisionResponseContainer(Self->CreateMinContainer(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FCollisionResponseContainer_GetResponse(FCollisionResponseContainer* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetResponse(_p0);
	}

	DOTNET_EXPORT auto E_FCollisionResponseContainer_ReplaceChannels(FCollisionResponseContainer* Self, ECollisionResponse OldResponse, ECollisionResponse NewResponse)
	{
		auto _p0 = OldResponse;
		auto _p1 = NewResponse;
		Self->ReplaceChannels(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FCollisionResponseContainer_SetAllChannels(FCollisionResponseContainer* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_FCollisionResponseContainer_SetResponse(FCollisionResponseContainer* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetResponse(_p0, _p1);
	}

	
	/*	FColorGradePerRangeSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FColorGradePerRangeSettings() { return (INT_PTR) new FColorGradePerRangeSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FColorGradePerRangeSettings_Contrast_GET(FColorGradePerRangeSettings* Ptr) { return (INT_PTR)&(Ptr->Contrast); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Contrast_SET(FColorGradePerRangeSettings* Ptr, INT_PTR Value) { Ptr->Contrast = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FColorGradePerRangeSettings_Gain_GET(FColorGradePerRangeSettings* Ptr) { return (INT_PTR)&(Ptr->Gain); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Gain_SET(FColorGradePerRangeSettings* Ptr, INT_PTR Value) { Ptr->Gain = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FColorGradePerRangeSettings_Gamma_GET(FColorGradePerRangeSettings* Ptr) { return (INT_PTR)&(Ptr->Gamma); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Gamma_SET(FColorGradePerRangeSettings* Ptr, INT_PTR Value) { Ptr->Gamma = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FColorGradePerRangeSettings_Offset_GET(FColorGradePerRangeSettings* Ptr) { return (INT_PTR)&(Ptr->Offset); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Offset_SET(FColorGradePerRangeSettings* Ptr, INT_PTR Value) { Ptr->Offset = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FColorGradePerRangeSettings_Saturation_GET(FColorGradePerRangeSettings* Ptr) { return (INT_PTR)&(Ptr->Saturation); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Saturation_SET(FColorGradePerRangeSettings* Ptr, INT_PTR Value) { Ptr->Saturation = *(FVector4*)Value; }
	
	
	/*	FColorGradingSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FColorGradingSettings() { return (INT_PTR) new FColorGradingSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FColorGradingSettings_Global_GET(FColorGradingSettings* Ptr) { return (INT_PTR)&(Ptr->Global); }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Global_SET(FColorGradingSettings* Ptr, INT_PTR Value) { Ptr->Global = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FColorGradingSettings_Highlights_GET(FColorGradingSettings* Ptr) { return (INT_PTR)&(Ptr->Highlights); }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Highlights_SET(FColorGradingSettings* Ptr, INT_PTR Value) { Ptr->Highlights = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FColorGradingSettings_HighlightsMin_GET(FColorGradingSettings* Ptr) { return Ptr->HighlightsMin; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_HighlightsMin_SET(FColorGradingSettings* Ptr, float Value) { Ptr->HighlightsMin = Value; }
	
	DOTNET_EXPORT auto E_PROP_FColorGradingSettings_Midtones_GET(FColorGradingSettings* Ptr) { return (INT_PTR)&(Ptr->Midtones); }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Midtones_SET(FColorGradingSettings* Ptr, INT_PTR Value) { Ptr->Midtones = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FColorGradingSettings_Shadows_GET(FColorGradingSettings* Ptr) { return (INT_PTR)&(Ptr->Shadows); }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Shadows_SET(FColorGradingSettings* Ptr, INT_PTR Value) { Ptr->Shadows = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FColorGradingSettings_ShadowsMax_GET(FColorGradingSettings* Ptr) { return Ptr->ShadowsMax; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_ShadowsMax_SET(FColorGradingSettings* Ptr, float Value) { Ptr->ShadowsMax = Value; }
	
	DOTNET_EXPORT auto E_FColorGradingSettings_ExportToPostProcessSettings(FColorGradingSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FComponentReference	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FComponentReference() { return (INT_PTR) new FComponentReference(); }
	
	DOTNET_EXPORT auto E_PROP_FComponentReference_ComponentProperty_GET(FComponentReference* Ptr) { return ConvertToManage_StringWrapper(Ptr->ComponentProperty); }
	DOTNET_EXPORT void E_PROP_FComponentReference_ComponentProperty_SET(FComponentReference* Ptr, char* Value) { Ptr->ComponentProperty = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FComponentReference_OtherActor_GET(FComponentReference* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->OtherActor); }
	DOTNET_EXPORT void E_PROP_FComponentReference_OtherActor_SET(FComponentReference* Ptr, AActor* Value) { Ptr->OtherActor = Value; }
	
	DOTNET_EXPORT auto E_FComponentReference_GetComponent(FComponentReference* Self, AActor* OwningActor)
	{
		auto _p0 = OwningActor;
		return ConvertToManage_ObjectPointerDescription(Self->GetComponent(_p0));
	}

	
	/*	FComponentSocketDescription	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FComponentSocketDescription() { return (INT_PTR) new FComponentSocketDescription(); }
	
	DOTNET_EXPORT auto E_PROP_FComponentSocketDescription_Name_GET(FComponentSocketDescription* Ptr) { return ConvertToManage_StringWrapper(Ptr->Name); }
	DOTNET_EXPORT void E_PROP_FComponentSocketDescription_Name_SET(FComponentSocketDescription* Ptr, char* Value) { Ptr->Name = ConvertFromManage_FName(Value); }
	
	
	/*	FConstrainComponentPropName	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FConstrainComponentPropName() { return (INT_PTR) new FConstrainComponentPropName(); }
	
	DOTNET_EXPORT auto E_PROP_FConstrainComponentPropName_ComponentName_GET(FConstrainComponentPropName* Ptr) { return ConvertToManage_StringWrapper(Ptr->ComponentName); }
	DOTNET_EXPORT void E_PROP_FConstrainComponentPropName_ComponentName_SET(FConstrainComponentPropName* Ptr, char* Value) { Ptr->ComponentName = ConvertFromManage_FName(Value); }
	
	
	/*	FConvolutionBloomSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FConvolutionBloomSettings() { return (INT_PTR) new FConvolutionBloomSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FConvolutionBloomSettings_BufferScale_GET(FConvolutionBloomSettings* Ptr) { return Ptr->BufferScale; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_BufferScale_SET(FConvolutionBloomSettings* Ptr, float Value) { Ptr->BufferScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_FConvolutionBloomSettings_CenterUV_GET(FConvolutionBloomSettings* Ptr) { return (INT_PTR)&(Ptr->CenterUV); }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_CenterUV_SET(FConvolutionBloomSettings* Ptr, INT_PTR Value) { Ptr->CenterUV = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FConvolutionBloomSettings_PreFilterMax_GET(FConvolutionBloomSettings* Ptr) { return Ptr->PreFilterMax; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_PreFilterMax_SET(FConvolutionBloomSettings* Ptr, float Value) { Ptr->PreFilterMax = Value; }
	
	DOTNET_EXPORT auto E_PROP_FConvolutionBloomSettings_PreFilterMin_GET(FConvolutionBloomSettings* Ptr) { return Ptr->PreFilterMin; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_PreFilterMin_SET(FConvolutionBloomSettings* Ptr, float Value) { Ptr->PreFilterMin = Value; }
	
	DOTNET_EXPORT auto E_PROP_FConvolutionBloomSettings_PreFilterMult_GET(FConvolutionBloomSettings* Ptr) { return Ptr->PreFilterMult; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_PreFilterMult_SET(FConvolutionBloomSettings* Ptr, float Value) { Ptr->PreFilterMult = Value; }
	
	DOTNET_EXPORT auto E_PROP_FConvolutionBloomSettings_Size_GET(FConvolutionBloomSettings* Ptr) { return Ptr->Size; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_Size_SET(FConvolutionBloomSettings* Ptr, float Value) { Ptr->Size = Value; }
	
	DOTNET_EXPORT auto E_FConvolutionBloomSettings_ExportToPostProcessSettings(FConvolutionBloomSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FDamageEvent	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDamageEvent() { return (INT_PTR) new FDamageEvent(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDamageEvent_FDamageEvent(INT_PTR InDamageEvent) { return (INT_PTR) new FDamageEvent(*(FDamageEvent*)InDamageEvent); }
	
	DOTNET_EXPORT auto E_FDamageEvent_GetBestHitInfo(FDamageEvent* Self, AActor* HitActor, AActor* HitInstigator, INT_PTR OutHitInfo, INT_PTR OutImpulseDir)
	{
		auto _p0 = HitActor;
		auto _p1 = HitInstigator;
		auto _p2 = *(FHitResult*)OutHitInfo;
		auto _p3 = *(FVector*)OutImpulseDir;
		Self->GetBestHitInfo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_FDamageEvent_GetTypeID(FDamageEvent* Self)
	{
		return Self->GetTypeID();
	}

	DOTNET_EXPORT auto E_FDamageEvent_IsOfType(FDamageEvent* Self, int32 InID)
	{
		auto _p0 = InID;
		return Self->IsOfType(_p0);
	}

	
	/*	FDebugFloatHistory	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDebugFloatHistory() { return (INT_PTR) new FDebugFloatHistory(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDebugFloatHistory_float_float_float_bool(float InMaxSamples, float InMinValue, float InMaxValue, bool InbAutoAdjustMinMax) { return (INT_PTR) new FDebugFloatHistory(InMaxSamples, InMinValue, InMaxValue, InbAutoAdjustMinMax); }
	
	DOTNET_EXPORT auto E_PROP_FDebugFloatHistory_bAutoAdjustMinMax_GET(FDebugFloatHistory* Ptr) { return Ptr->bAutoAdjustMinMax; }
	DOTNET_EXPORT void E_PROP_FDebugFloatHistory_bAutoAdjustMinMax_SET(FDebugFloatHistory* Ptr, bool Value) { Ptr->bAutoAdjustMinMax = Value; }
	
	DOTNET_EXPORT auto E_PROP_FDebugFloatHistory_MaxSamples_GET(FDebugFloatHistory* Ptr) { return Ptr->MaxSamples; }
	DOTNET_EXPORT void E_PROP_FDebugFloatHistory_MaxSamples_SET(FDebugFloatHistory* Ptr, float Value) { Ptr->MaxSamples = Value; }
	
	DOTNET_EXPORT auto E_PROP_FDebugFloatHistory_MaxValue_GET(FDebugFloatHistory* Ptr) { return Ptr->MaxValue; }
	DOTNET_EXPORT void E_PROP_FDebugFloatHistory_MaxValue_SET(FDebugFloatHistory* Ptr, float Value) { Ptr->MaxValue = Value; }
	
	DOTNET_EXPORT auto E_PROP_FDebugFloatHistory_MinValue_GET(FDebugFloatHistory* Ptr) { return Ptr->MinValue; }
	DOTNET_EXPORT void E_PROP_FDebugFloatHistory_MinValue_SET(FDebugFloatHistory* Ptr, float Value) { Ptr->MinValue = Value; }
	
	DOTNET_EXPORT auto E_FDebugFloatHistory_AddSample(FDebugFloatHistory* Self, float FloatValue)
	{
		auto _p0 = FloatValue;
		Self->AddSample(_p0);
	}

	DOTNET_EXPORT auto E_FDebugFloatHistory_GetMaxValue(FDebugFloatHistory* Self)
	{
		return Self->GetMaxValue();
	}

	DOTNET_EXPORT auto E_FDebugFloatHistory_GetMinMaxRange(FDebugFloatHistory* Self)
	{
		return Self->GetMinMaxRange();
	}

	DOTNET_EXPORT auto E_FDebugFloatHistory_GetMinValue(FDebugFloatHistory* Self)
	{
		return Self->GetMinValue();
	}

	DOTNET_EXPORT auto E_FDebugFloatHistory_GetNumSamples(FDebugFloatHistory* Self)
	{
		return Self->GetNumSamples();
	}

	
	/*	FDepthFieldGlowInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDepthFieldGlowInfo() { return (INT_PTR) new FDepthFieldGlowInfo(); }
	
	DOTNET_EXPORT auto E_PROP_FDepthFieldGlowInfo_GlowInnerRadius_GET(FDepthFieldGlowInfo* Ptr) { return (INT_PTR)&(Ptr->GlowInnerRadius); }
	DOTNET_EXPORT void E_PROP_FDepthFieldGlowInfo_GlowInnerRadius_SET(FDepthFieldGlowInfo* Ptr, INT_PTR Value) { Ptr->GlowInnerRadius = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FDepthFieldGlowInfo_GlowOuterRadius_GET(FDepthFieldGlowInfo* Ptr) { return (INT_PTR)&(Ptr->GlowOuterRadius); }
	DOTNET_EXPORT void E_PROP_FDepthFieldGlowInfo_GlowOuterRadius_SET(FDepthFieldGlowInfo* Ptr, INT_PTR Value) { Ptr->GlowOuterRadius = *(FVector2D*)Value; }
	
	
	/*	FDetachmentTransformRules	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_bool(EDetachmentRule InRule, bool bInCallModify) { return (INT_PTR) new FDetachmentTransformRules(InRule, bInCallModify); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_EDetachmentRule_EDetachmentRule_bool(EDetachmentRule InLocationRule, EDetachmentRule InRotationRule, EDetachmentRule InScaleRule, bool bInCallModify) { return (INT_PTR) new FDetachmentTransformRules(InLocationRule, InRotationRule, InScaleRule, bInCallModify); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDetachmentTransformRules_FAttachmentTransformRules_bool(INT_PTR AttachmentRules, bool bInCallModify) { return (INT_PTR) new FDetachmentTransformRules(*(FAttachmentTransformRules*)AttachmentRules, bInCallModify); }
	
	DOTNET_EXPORT auto E_PROP_FDetachmentTransformRules_bCallModify_GET(FDetachmentTransformRules* Ptr) { return Ptr->bCallModify; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_bCallModify_SET(FDetachmentTransformRules* Ptr, bool Value) { Ptr->bCallModify = Value; }
	
	DOTNET_EXPORT auto E_PROP_FDetachmentTransformRules_KeepRelativeTransform_GET() { return (INT_PTR)&(FDetachmentTransformRules::KeepRelativeTransform); }
	
	DOTNET_EXPORT auto E_PROP_FDetachmentTransformRules_KeepWorldTransform_GET() { return (INT_PTR)&(FDetachmentTransformRules::KeepWorldTransform); }
	
	DOTNET_EXPORT auto E_PROP_FDetachmentTransformRules_LocationRule_GET(FDetachmentTransformRules* Ptr) { return Ptr->LocationRule; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_LocationRule_SET(FDetachmentTransformRules* Ptr, EDetachmentRule Value) { Ptr->LocationRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_FDetachmentTransformRules_RotationRule_GET(FDetachmentTransformRules* Ptr) { return Ptr->RotationRule; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_RotationRule_SET(FDetachmentTransformRules* Ptr, EDetachmentRule Value) { Ptr->RotationRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_FDetachmentTransformRules_ScaleRule_GET(FDetachmentTransformRules* Ptr) { return Ptr->ScaleRule; }
	DOTNET_EXPORT void E_PROP_FDetachmentTransformRules_ScaleRule_SET(FDetachmentTransformRules* Ptr, EDetachmentRule Value) { Ptr->ScaleRule = Value; }
	
	
	/*	FDirectAttachChildrenAccessor	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDirectAttachChildrenAccessor() { return (INT_PTR) new FDirectAttachChildrenAccessor(); }
	
	
	/*	FDirectoryPath	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDirectoryPath() { return (INT_PTR) new FDirectoryPath(); }
	
	DOTNET_EXPORT auto E_PROP_FDirectoryPath_Path_GET(FDirectoryPath* Ptr) { return ConvertToManage_StringWrapper(Ptr->Path); }
	DOTNET_EXPORT void E_PROP_FDirectoryPath_Path_SET(FDirectoryPath* Ptr, char* Value) { Ptr->Path = ConvertFromManage_FString(Value); }
	
	
	/*	FDropNoteInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDropNoteInfo() { return (INT_PTR) new FDropNoteInfo(); }
	
	DOTNET_EXPORT auto E_PROP_FDropNoteInfo_Comment_GET(FDropNoteInfo* Ptr) { return ConvertToManage_StringWrapper(Ptr->Comment); }
	DOTNET_EXPORT void E_PROP_FDropNoteInfo_Comment_SET(FDropNoteInfo* Ptr, char* Value) { Ptr->Comment = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FDropNoteInfo_Location_GET(FDropNoteInfo* Ptr) { return (INT_PTR)&(Ptr->Location); }
	DOTNET_EXPORT void E_PROP_FDropNoteInfo_Location_SET(FDropNoteInfo* Ptr, INT_PTR Value) { Ptr->Location = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FDropNoteInfo_Rotation_GET(FDropNoteInfo* Ptr) { return (INT_PTR)&(Ptr->Rotation); }
	DOTNET_EXPORT void E_PROP_FDropNoteInfo_Rotation_SET(FDropNoteInfo* Ptr, INT_PTR Value) { Ptr->Rotation = *(FRotator*)Value; }
	
	
	/*	FEngineShowFlagsSetting	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FEngineShowFlagsSetting() { return (INT_PTR) new FEngineShowFlagsSetting(); }
	
	DOTNET_EXPORT auto E_PROP_FEngineShowFlagsSetting_Enabled_GET(FEngineShowFlagsSetting* Ptr) { return Ptr->Enabled; }
	DOTNET_EXPORT void E_PROP_FEngineShowFlagsSetting_Enabled_SET(FEngineShowFlagsSetting* Ptr, bool Value) { Ptr->Enabled = Value; }
	
	DOTNET_EXPORT auto E_PROP_FEngineShowFlagsSetting_ShowFlagName_GET(FEngineShowFlagsSetting* Ptr) { return ConvertToManage_StringWrapper(Ptr->ShowFlagName); }
	DOTNET_EXPORT void E_PROP_FEngineShowFlagsSetting_ShowFlagName_SET(FEngineShowFlagsSetting* Ptr, char* Value) { Ptr->ShowFlagName = ConvertFromManage_FString(Value); }
	
	
	/*	FExposureSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FExposureSettings() { return (INT_PTR) new FExposureSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FExposureSettings_bFixed_GET(FExposureSettings* Ptr) { return Ptr->bFixed; }
	DOTNET_EXPORT void E_PROP_FExposureSettings_bFixed_SET(FExposureSettings* Ptr, bool Value) { Ptr->bFixed = Value; }
	
	DOTNET_EXPORT auto E_PROP_FExposureSettings_FixedEV100_GET(FExposureSettings* Ptr) { return Ptr->FixedEV100; }
	DOTNET_EXPORT void E_PROP_FExposureSettings_FixedEV100_SET(FExposureSettings* Ptr, float Value) { Ptr->FixedEV100 = Value; }
	
	DOTNET_EXPORT auto E_FExposureSettings_ToString(FExposureSettings* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
	}

	
	/*	FFilePath	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFilePath() { return (INT_PTR) new FFilePath(); }
	
	DOTNET_EXPORT auto E_PROP_FFilePath_FilePath_GET(FFilePath* Ptr) { return ConvertToManage_StringWrapper(Ptr->FilePath); }
	DOTNET_EXPORT void E_PROP_FFilePath_FilePath_SET(FFilePath* Ptr, char* Value) { Ptr->FilePath = ConvertFromManage_FString(Value); }
	
	
	/*	FFilmStockSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFilmStockSettings() { return (INT_PTR) new FFilmStockSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FFilmStockSettings_BlackClip_GET(FFilmStockSettings* Ptr) { return Ptr->BlackClip; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_BlackClip_SET(FFilmStockSettings* Ptr, float Value) { Ptr->BlackClip = Value; }
	
	DOTNET_EXPORT auto E_PROP_FFilmStockSettings_Shoulder_GET(FFilmStockSettings* Ptr) { return Ptr->Shoulder; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_Shoulder_SET(FFilmStockSettings* Ptr, float Value) { Ptr->Shoulder = Value; }
	
	DOTNET_EXPORT auto E_PROP_FFilmStockSettings_Slope_GET(FFilmStockSettings* Ptr) { return Ptr->Slope; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_Slope_SET(FFilmStockSettings* Ptr, float Value) { Ptr->Slope = Value; }
	
	DOTNET_EXPORT auto E_PROP_FFilmStockSettings_Toe_GET(FFilmStockSettings* Ptr) { return Ptr->Toe; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_Toe_SET(FFilmStockSettings* Ptr, float Value) { Ptr->Toe = Value; }
	
	DOTNET_EXPORT auto E_PROP_FFilmStockSettings_WhiteClip_GET(FFilmStockSettings* Ptr) { return Ptr->WhiteClip; }
	DOTNET_EXPORT void E_PROP_FFilmStockSettings_WhiteClip_SET(FFilmStockSettings* Ptr, float Value) { Ptr->WhiteClip = Value; }
	
	DOTNET_EXPORT auto E_FFilmStockSettings_ExportToPostProcessSettings(FFilmStockSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FFindFloorResult	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFindFloorResult() { return (INT_PTR) new FFindFloorResult(); }
	
	DOTNET_EXPORT auto E_PROP_FFindFloorResult_FloorDist_GET(FFindFloorResult* Ptr) { return Ptr->FloorDist; }
	DOTNET_EXPORT void E_PROP_FFindFloorResult_FloorDist_SET(FFindFloorResult* Ptr, float Value) { Ptr->FloorDist = Value; }
	
	DOTNET_EXPORT auto E_PROP_FFindFloorResult_HitResult_GET(FFindFloorResult* Ptr) { return (INT_PTR)&(Ptr->HitResult); }
	DOTNET_EXPORT void E_PROP_FFindFloorResult_HitResult_SET(FFindFloorResult* Ptr, INT_PTR Value) { Ptr->HitResult = *(FHitResult*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FFindFloorResult_LineDist_GET(FFindFloorResult* Ptr) { return Ptr->LineDist; }
	DOTNET_EXPORT void E_PROP_FFindFloorResult_LineDist_SET(FFindFloorResult* Ptr, float Value) { Ptr->LineDist = Value; }
	
	DOTNET_EXPORT auto E_FFindFloorResult_Clear(FFindFloorResult* Self)
	{
		Self->Clear();
	}

	DOTNET_EXPORT auto E_FFindFloorResult_GetDistanceToFloor(FFindFloorResult* Self)
	{
		return Self->GetDistanceToFloor();
	}

	DOTNET_EXPORT auto E_FFindFloorResult_IsWalkableFloor(FFindFloorResult* Self)
	{
		return Self->IsWalkableFloor();
	}

	DOTNET_EXPORT auto E_FFindFloorResult_SetFromLineTrace(FFindFloorResult* Self, INT_PTR InHit, float InSweepFloorDist, float InLineDist, bool bIsWalkableFloor)
	{
		auto _p0 = *(FHitResult*)InHit;
		auto _p1 = InSweepFloorDist;
		auto _p2 = InLineDist;
		auto _p3 = bIsWalkableFloor;
		Self->SetFromLineTrace(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_FFindFloorResult_SetFromSweep(FFindFloorResult* Self, INT_PTR InHit, float InSweepFloorDist, bool bIsWalkableFloor)
	{
		auto _p0 = *(FHitResult*)InHit;
		auto _p1 = InSweepFloorDist;
		auto _p2 = bIsWalkableFloor;
		Self->SetFromSweep(_p0, _p1, _p2);
	}

	
	/*	FFixedUObjectArray	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFixedUObjectArray() { return (INT_PTR) new FFixedUObjectArray(); }
	
	
	/*	FFontRenderInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFontRenderInfo() { return (INT_PTR) new FFontRenderInfo(); }
	
	DOTNET_EXPORT auto E_PROP_FFontRenderInfo_GlowInfo_GET(FFontRenderInfo* Ptr) { return (INT_PTR)&(Ptr->GlowInfo); }
	DOTNET_EXPORT void E_PROP_FFontRenderInfo_GlowInfo_SET(FFontRenderInfo* Ptr, INT_PTR Value) { Ptr->GlowInfo = *(FDepthFieldGlowInfo*)Value; }
	
	
	/*	FFractureEffect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFractureEffect() { return (INT_PTR) new FFractureEffect(); }
	
	
	/*	FFullyLoadedPackagesInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFullyLoadedPackagesInfo() { return (INT_PTR) new FFullyLoadedPackagesInfo(); }
	
	DOTNET_EXPORT auto E_PROP_FFullyLoadedPackagesInfo_Tag_GET(FFullyLoadedPackagesInfo* Ptr) { return ConvertToManage_StringWrapper(Ptr->Tag); }
	DOTNET_EXPORT void E_PROP_FFullyLoadedPackagesInfo_Tag_SET(FFullyLoadedPackagesInfo* Ptr, char* Value) { Ptr->Tag = ConvertFromManage_FString(Value); }
	
	
	/*	FGameModeEvents	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FGameModeEvents() { return (INT_PTR) new FGameModeEvents(); }
	
	
	/*	FGameNameRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FGameNameRedirect() { return (INT_PTR) new FGameNameRedirect(); }
	
	DOTNET_EXPORT auto E_PROP_FGameNameRedirect_NewGameName_GET(FGameNameRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewGameName); }
	DOTNET_EXPORT void E_PROP_FGameNameRedirect_NewGameName_SET(FGameNameRedirect* Ptr, char* Value) { Ptr->NewGameName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FGameNameRedirect_OldGameName_GET(FGameNameRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->OldGameName); }
	DOTNET_EXPORT void E_PROP_FGameNameRedirect_OldGameName_SET(FGameNameRedirect* Ptr, char* Value) { Ptr->OldGameName = ConvertFromManage_FName(Value); }
	
	
	/*	FHitResult	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FHitResult() { return (INT_PTR) new FHitResult(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FHitResult_float(float InTime) { return (INT_PTR) new FHitResult(InTime); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FHitResult_FVector_FVector(INT_PTR Start, INT_PTR End) { return (INT_PTR) new FHitResult(*(FVector*)Start, *(FVector*)End); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FHitResult_AActor_UPrimitiveComponent_FVector_FVector(AActor* InActor, UPrimitiveComponent* InComponent, INT_PTR HitLoc, INT_PTR HitNorm) { return (INT_PTR) new FHitResult(InActor, InComponent, *(FVector*)HitLoc, *(FVector*)HitNorm); }
	
	DOTNET_EXPORT auto E_PROP_FHitResult_bBlockingHit_GET(FHitResult* Ptr) { return Ptr->bBlockingHit; }
	DOTNET_EXPORT void E_PROP_FHitResult_bBlockingHit_SET(FHitResult* Ptr, uint8 Value) { Ptr->bBlockingHit = Value; }
	
	DOTNET_EXPORT auto E_PROP_FHitResult_BoneName_GET(FHitResult* Ptr) { return ConvertToManage_StringWrapper(Ptr->BoneName); }
	DOTNET_EXPORT void E_PROP_FHitResult_BoneName_SET(FHitResult* Ptr, char* Value) { Ptr->BoneName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FHitResult_bStartPenetrating_GET(FHitResult* Ptr) { return Ptr->bStartPenetrating; }
	DOTNET_EXPORT void E_PROP_FHitResult_bStartPenetrating_SET(FHitResult* Ptr, uint8 Value) { Ptr->bStartPenetrating = Value; }
	
	DOTNET_EXPORT auto E_PROP_FHitResult_Distance_GET(FHitResult* Ptr) { return Ptr->Distance; }
	DOTNET_EXPORT void E_PROP_FHitResult_Distance_SET(FHitResult* Ptr, float Value) { Ptr->Distance = Value; }
	
	DOTNET_EXPORT auto E_PROP_FHitResult_FaceIndex_GET(FHitResult* Ptr) { return Ptr->FaceIndex; }
	DOTNET_EXPORT void E_PROP_FHitResult_FaceIndex_SET(FHitResult* Ptr, int32 Value) { Ptr->FaceIndex = Value; }
	
	DOTNET_EXPORT auto E_PROP_FHitResult_Item_GET(FHitResult* Ptr) { return Ptr->Item; }
	DOTNET_EXPORT void E_PROP_FHitResult_Item_SET(FHitResult* Ptr, int32 Value) { Ptr->Item = Value; }
	
	DOTNET_EXPORT auto E_PROP_FHitResult_MyBoneName_GET(FHitResult* Ptr) { return ConvertToManage_StringWrapper(Ptr->MyBoneName); }
	DOTNET_EXPORT void E_PROP_FHitResult_MyBoneName_SET(FHitResult* Ptr, char* Value) { Ptr->MyBoneName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FHitResult_PenetrationDepth_GET(FHitResult* Ptr) { return Ptr->PenetrationDepth; }
	DOTNET_EXPORT void E_PROP_FHitResult_PenetrationDepth_SET(FHitResult* Ptr, float Value) { Ptr->PenetrationDepth = Value; }
	
	DOTNET_EXPORT auto E_PROP_FHitResult_Time_GET(FHitResult* Ptr) { return Ptr->Time; }
	DOTNET_EXPORT void E_PROP_FHitResult_Time_SET(FHitResult* Ptr, float Value) { Ptr->Time = Value; }
	
	DOTNET_EXPORT auto E_FHitResult_GetActor(FHitResult* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetActor());
	}

	DOTNET_EXPORT auto E_FHitResult_GetComponent(FHitResult* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetComponent());
	}

	DOTNET_EXPORT auto E_FHitResult_GetReversedHit(FHitResult* Self, INT_PTR Hit)
	{
		auto _p0 = *(FHitResult*)Hit;
		return (INT_PTR) new FHitResult(Self->GetReversedHit(_p0));
	}

	DOTNET_EXPORT auto E_FHitResult_IsValidBlockingHit(FHitResult* Self)
	{
		return Self->IsValidBlockingHit();
	}

	DOTNET_EXPORT auto E_FHitResult_Reset(FHitResult* Self, float InTime, bool bPreserveTraceData)
	{
		auto _p0 = InTime;
		auto _p1 = bPreserveTraceData;
		Self->Reset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FHitResult_ToString(FHitResult* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
	}

	
	/*	FInstancedStaticMeshInstanceData	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInstancedStaticMeshInstanceData() { return (INT_PTR) new FInstancedStaticMeshInstanceData(); }
	
	
	/*	FInstancedStaticMeshMappingInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInstancedStaticMeshMappingInfo() { return (INT_PTR) new FInstancedStaticMeshMappingInfo(); }
	
	
	/*	FInterpControlPoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInterpControlPoint() { return (INT_PTR) new FInterpControlPoint(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInterpControlPoint_FVector_bool(INT_PTR InPosition, bool bIsRelative) { return (INT_PTR) new FInterpControlPoint(*(FVector*)InPosition, bIsRelative); }
	
	DOTNET_EXPORT auto E_PROP_FInterpControlPoint_bPositionIsRelative_GET(FInterpControlPoint* Ptr) { return Ptr->bPositionIsRelative; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_bPositionIsRelative_SET(FInterpControlPoint* Ptr, bool Value) { Ptr->bPositionIsRelative = Value; }
	
	DOTNET_EXPORT auto E_PROP_FInterpControlPoint_DistanceToNext_GET(FInterpControlPoint* Ptr) { return Ptr->DistanceToNext; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_DistanceToNext_SET(FInterpControlPoint* Ptr, float Value) { Ptr->DistanceToNext = Value; }
	
	DOTNET_EXPORT auto E_PROP_FInterpControlPoint_Percentage_GET(FInterpControlPoint* Ptr) { return Ptr->Percentage; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_Percentage_SET(FInterpControlPoint* Ptr, float Value) { Ptr->Percentage = Value; }
	
	DOTNET_EXPORT auto E_PROP_FInterpControlPoint_PositionControlPoint_GET(FInterpControlPoint* Ptr) { return (INT_PTR)&(Ptr->PositionControlPoint); }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_PositionControlPoint_SET(FInterpControlPoint* Ptr, INT_PTR Value) { Ptr->PositionControlPoint = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FInterpControlPoint_StartTime_GET(FInterpControlPoint* Ptr) { return Ptr->StartTime; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_StartTime_SET(FInterpControlPoint* Ptr, float Value) { Ptr->StartTime = Value; }
	
	
	/*	FLensBloomSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensBloomSettings() { return (INT_PTR) new FLensBloomSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FLensBloomSettings_Convolution_GET(FLensBloomSettings* Ptr) { return (INT_PTR)&(Ptr->Convolution); }
	DOTNET_EXPORT void E_PROP_FLensBloomSettings_Convolution_SET(FLensBloomSettings* Ptr, INT_PTR Value) { Ptr->Convolution = *(FConvolutionBloomSettings*)Value; }
	
	DOTNET_EXPORT auto E_FLensBloomSettings_ExportToPostProcessSettings(FLensBloomSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FLensImperfectionSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensImperfectionSettings() { return (INT_PTR) new FLensImperfectionSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FLensImperfectionSettings_DirtMaskIntensity_GET(FLensImperfectionSettings* Ptr) { return Ptr->DirtMaskIntensity; }
	DOTNET_EXPORT void E_PROP_FLensImperfectionSettings_DirtMaskIntensity_SET(FLensImperfectionSettings* Ptr, float Value) { Ptr->DirtMaskIntensity = Value; }
	
	DOTNET_EXPORT auto E_FLensImperfectionSettings_ExportToPostProcessSettings(FLensImperfectionSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FLensSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensSettings() { return (INT_PTR) new FLensSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FLensSettings_Bloom_GET(FLensSettings* Ptr) { return (INT_PTR)&(Ptr->Bloom); }
	DOTNET_EXPORT void E_PROP_FLensSettings_Bloom_SET(FLensSettings* Ptr, INT_PTR Value) { Ptr->Bloom = *(FLensBloomSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FLensSettings_ChromaticAberration_GET(FLensSettings* Ptr) { return Ptr->ChromaticAberration; }
	DOTNET_EXPORT void E_PROP_FLensSettings_ChromaticAberration_SET(FLensSettings* Ptr, float Value) { Ptr->ChromaticAberration = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLensSettings_Imperfections_GET(FLensSettings* Ptr) { return (INT_PTR)&(Ptr->Imperfections); }
	DOTNET_EXPORT void E_PROP_FLensSettings_Imperfections_SET(FLensSettings* Ptr, INT_PTR Value) { Ptr->Imperfections = *(FLensImperfectionSettings*)Value; }
	
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
		return Self->GetNumLevelsPendingPurge();
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
	
	DOTNET_EXPORT auto E_PROP_FLevelStreamingStatus_PackageName_GET(FLevelStreamingStatus* Ptr) { return ConvertToManage_StringWrapper(Ptr->PackageName); }
	DOTNET_EXPORT void E_PROP_FLevelStreamingStatus_PackageName_SET(FLevelStreamingStatus* Ptr, char* Value) { Ptr->PackageName = ConvertFromManage_FName(Value); }
	
	
	/*	FLevelViewportInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelViewportInfo() { return (INT_PTR) new FLevelViewportInfo(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelViewportInfo_FVector_FRotator_float(INT_PTR InCamPosition, INT_PTR InCamRotation, float InCamOrthoZoom) { return (INT_PTR) new FLevelViewportInfo(*(FVector*)InCamPosition, *(FRotator*)InCamRotation, InCamOrthoZoom); }
	
	DOTNET_EXPORT auto E_PROP_FLevelViewportInfo_CamOrthoZoom_GET(FLevelViewportInfo* Ptr) { return Ptr->CamOrthoZoom; }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamOrthoZoom_SET(FLevelViewportInfo* Ptr, float Value) { Ptr->CamOrthoZoom = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLevelViewportInfo_CamPosition_GET(FLevelViewportInfo* Ptr) { return (INT_PTR)&(Ptr->CamPosition); }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamPosition_SET(FLevelViewportInfo* Ptr, INT_PTR Value) { Ptr->CamPosition = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FLevelViewportInfo_CamRotation_GET(FLevelViewportInfo* Ptr) { return (INT_PTR)&(Ptr->CamRotation); }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamRotation_SET(FLevelViewportInfo* Ptr, INT_PTR Value) { Ptr->CamRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FLevelViewportInfo_CamUpdated_GET(FLevelViewportInfo* Ptr) { return Ptr->CamUpdated; }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamUpdated_SET(FLevelViewportInfo* Ptr, bool Value) { Ptr->CamUpdated = Value; }
	
	
	/*	FLightingChannels	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightingChannels() { return (INT_PTR) new FLightingChannels(); }
	
	DOTNET_EXPORT auto E_PROP_FLightingChannels_bChannel0_GET(FLightingChannels* Ptr) { return Ptr->bChannel0; }
	DOTNET_EXPORT void E_PROP_FLightingChannels_bChannel0_SET(FLightingChannels* Ptr, uint8 Value) { Ptr->bChannel0 = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLightingChannels_bChannel1_GET(FLightingChannels* Ptr) { return Ptr->bChannel1; }
	DOTNET_EXPORT void E_PROP_FLightingChannels_bChannel1_SET(FLightingChannels* Ptr, uint8 Value) { Ptr->bChannel1 = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLightingChannels_bChannel2_GET(FLightingChannels* Ptr) { return Ptr->bChannel2; }
	DOTNET_EXPORT void E_PROP_FLightingChannels_bChannel2_SET(FLightingChannels* Ptr, uint8 Value) { Ptr->bChannel2 = Value; }
	
	
	/*	FLightmassDebugOptions	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassDebugOptions() { return (INT_PTR) new FLightmassDebugOptions(); }
	
	DOTNET_EXPORT auto E_PROP_FLightmassDebugOptions_CoplanarTolerance_GET(FLightmassDebugOptions* Ptr) { return Ptr->CoplanarTolerance; }
	DOTNET_EXPORT void E_PROP_FLightmassDebugOptions_CoplanarTolerance_SET(FLightmassDebugOptions* Ptr, float Value) { Ptr->CoplanarTolerance = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_GET(FLightmassDebugOptions* Ptr) { return Ptr->ExecutionTimeDivisor; }
	DOTNET_EXPORT void E_PROP_FLightmassDebugOptions_ExecutionTimeDivisor_SET(FLightmassDebugOptions* Ptr, float Value) { Ptr->ExecutionTimeDivisor = Value; }
	
	
	/*	FLightmassDirectionalLightSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassDirectionalLightSettings() { return (INT_PTR) new FLightmassDirectionalLightSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FLightmassDirectionalLightSettings_LightSourceAngle_GET(FLightmassDirectionalLightSettings* Ptr) { return Ptr->LightSourceAngle; }
	DOTNET_EXPORT void E_PROP_FLightmassDirectionalLightSettings_LightSourceAngle_SET(FLightmassDirectionalLightSettings* Ptr, float Value) { Ptr->LightSourceAngle = Value; }
	
	
	/*	FLightmassLightSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassLightSettings() { return (INT_PTR) new FLightmassLightSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FLightmassLightSettings_bUseAreaShadowsForStationaryLight_GET(FLightmassLightSettings* Ptr) { return Ptr->bUseAreaShadowsForStationaryLight; }
	DOTNET_EXPORT void E_PROP_FLightmassLightSettings_bUseAreaShadowsForStationaryLight_SET(FLightmassLightSettings* Ptr, bool Value) { Ptr->bUseAreaShadowsForStationaryLight = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLightmassLightSettings_IndirectLightingSaturation_GET(FLightmassLightSettings* Ptr) { return Ptr->IndirectLightingSaturation; }
	DOTNET_EXPORT void E_PROP_FLightmassLightSettings_IndirectLightingSaturation_SET(FLightmassLightSettings* Ptr, float Value) { Ptr->IndirectLightingSaturation = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLightmassLightSettings_ShadowExponent_GET(FLightmassLightSettings* Ptr) { return Ptr->ShadowExponent; }
	DOTNET_EXPORT void E_PROP_FLightmassLightSettings_ShadowExponent_SET(FLightmassLightSettings* Ptr, float Value) { Ptr->ShadowExponent = Value; }
	
	
	/*	FLightmassPointLightSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassPointLightSettings() { return (INT_PTR) new FLightmassPointLightSettings(); }
	
	
	/*	FLightmassPrimitiveSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassPrimitiveSettings() { return (INT_PTR) new FLightmassPrimitiveSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FLightmassPrimitiveSettings_DiffuseBoost_GET(FLightmassPrimitiveSettings* Ptr) { return Ptr->DiffuseBoost; }
	DOTNET_EXPORT void E_PROP_FLightmassPrimitiveSettings_DiffuseBoost_SET(FLightmassPrimitiveSettings* Ptr, float Value) { Ptr->DiffuseBoost = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLightmassPrimitiveSettings_EmissiveBoost_GET(FLightmassPrimitiveSettings* Ptr) { return Ptr->EmissiveBoost; }
	DOTNET_EXPORT void E_PROP_FLightmassPrimitiveSettings_EmissiveBoost_SET(FLightmassPrimitiveSettings* Ptr, float Value) { Ptr->EmissiveBoost = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLightmassPrimitiveSettings_EmissiveLightExplicitInfluenceRadius_GET(FLightmassPrimitiveSettings* Ptr) { return Ptr->EmissiveLightExplicitInfluenceRadius; }
	DOTNET_EXPORT void E_PROP_FLightmassPrimitiveSettings_EmissiveLightExplicitInfluenceRadius_SET(FLightmassPrimitiveSettings* Ptr, float Value) { Ptr->EmissiveLightExplicitInfluenceRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLightmassPrimitiveSettings_EmissiveLightFalloffExponent_GET(FLightmassPrimitiveSettings* Ptr) { return Ptr->EmissiveLightFalloffExponent; }
	DOTNET_EXPORT void E_PROP_FLightmassPrimitiveSettings_EmissiveLightFalloffExponent_SET(FLightmassPrimitiveSettings* Ptr, float Value) { Ptr->EmissiveLightFalloffExponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FLightmassPrimitiveSettings_FullyOccludedSamplesFraction_GET(FLightmassPrimitiveSettings* Ptr) { return Ptr->FullyOccludedSamplesFraction; }
	DOTNET_EXPORT void E_PROP_FLightmassPrimitiveSettings_FullyOccludedSamplesFraction_SET(FLightmassPrimitiveSettings* Ptr, float Value) { Ptr->FullyOccludedSamplesFraction = Value; }
	
	
	/*	FLocalizedSubtitle	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLocalizedSubtitle() { return (INT_PTR) new FLocalizedSubtitle(); }
	
	DOTNET_EXPORT auto E_PROP_FLocalizedSubtitle_LanguageExt_GET(FLocalizedSubtitle* Ptr) { return ConvertToManage_StringWrapper(Ptr->LanguageExt); }
	DOTNET_EXPORT void E_PROP_FLocalizedSubtitle_LanguageExt_SET(FLocalizedSubtitle* Ptr, char* Value) { Ptr->LanguageExt = ConvertFromManage_FString(Value); }
	
	
	/*	FMaterialSpriteElement	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FMaterialSpriteElement() { return (INT_PTR) new FMaterialSpriteElement(); }
	
	DOTNET_EXPORT auto E_PROP_FMaterialSpriteElement_BaseSizeX_GET(FMaterialSpriteElement* Ptr) { return Ptr->BaseSizeX; }
	DOTNET_EXPORT void E_PROP_FMaterialSpriteElement_BaseSizeX_SET(FMaterialSpriteElement* Ptr, float Value) { Ptr->BaseSizeX = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMaterialSpriteElement_BaseSizeY_GET(FMaterialSpriteElement* Ptr) { return Ptr->BaseSizeY; }
	DOTNET_EXPORT void E_PROP_FMaterialSpriteElement_BaseSizeY_SET(FMaterialSpriteElement* Ptr, float Value) { Ptr->BaseSizeY = Value; }
	
	
	/*	FMeshBuildSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FMeshBuildSettings() { return (INT_PTR) new FMeshBuildSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_GET(FMeshBuildSettings* Ptr) { return Ptr->bBuildAdjacencyBuffer; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bBuildAdjacencyBuffer_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bBuildAdjacencyBuffer = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_GET(FMeshBuildSettings* Ptr) { return Ptr->bBuildReversedIndexBuffer; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bBuildReversedIndexBuffer_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bBuildReversedIndexBuffer = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_GET(FMeshBuildSettings* Ptr) { return Ptr->bGenerateDistanceFieldAsIfTwoSided; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bGenerateDistanceFieldAsIfTwoSided_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bGenerateDistanceFieldAsIfTwoSided = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_GET(FMeshBuildSettings* Ptr) { return Ptr->bGenerateLightmapUVs; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bGenerateLightmapUVs_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bGenerateLightmapUVs = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bRecomputeNormals_GET(FMeshBuildSettings* Ptr) { return Ptr->bRecomputeNormals; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bRecomputeNormals_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bRecomputeNormals = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bRecomputeTangents_GET(FMeshBuildSettings* Ptr) { return Ptr->bRecomputeTangents; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bRecomputeTangents_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bRecomputeTangents = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bRemoveDegenerates_GET(FMeshBuildSettings* Ptr) { return Ptr->bRemoveDegenerates; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bRemoveDegenerates_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bRemoveDegenerates = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_BuildScale_DEPRECATED_GET(FMeshBuildSettings* Ptr) { return Ptr->BuildScale_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_BuildScale_DEPRECATED_SET(FMeshBuildSettings* Ptr, float Value) { Ptr->BuildScale_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_BuildScale3D_GET(FMeshBuildSettings* Ptr) { return (INT_PTR)&(Ptr->BuildScale3D); }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_BuildScale3D_SET(FMeshBuildSettings* Ptr, INT_PTR Value) { Ptr->BuildScale3D = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_GET(FMeshBuildSettings* Ptr) { return Ptr->bUseFullPrecisionUVs; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bUseFullPrecisionUVs_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bUseFullPrecisionUVs = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_GET(FMeshBuildSettings* Ptr) { return Ptr->bUseHighPrecisionTangentBasis; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bUseHighPrecisionTangentBasis_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bUseHighPrecisionTangentBasis = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_bUseMikkTSpace_GET(FMeshBuildSettings* Ptr) { return Ptr->bUseMikkTSpace; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_bUseMikkTSpace_SET(FMeshBuildSettings* Ptr, uint8 Value) { Ptr->bUseMikkTSpace = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_DistanceFieldResolutionScale_GET(FMeshBuildSettings* Ptr) { return Ptr->DistanceFieldResolutionScale; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_DistanceFieldResolutionScale_SET(FMeshBuildSettings* Ptr, float Value) { Ptr->DistanceFieldResolutionScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_DstLightmapIndex_GET(FMeshBuildSettings* Ptr) { return Ptr->DstLightmapIndex; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_DstLightmapIndex_SET(FMeshBuildSettings* Ptr, int32 Value) { Ptr->DstLightmapIndex = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_MinLightmapResolution_GET(FMeshBuildSettings* Ptr) { return Ptr->MinLightmapResolution; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_MinLightmapResolution_SET(FMeshBuildSettings* Ptr, int32 Value) { Ptr->MinLightmapResolution = Value; }
	
	DOTNET_EXPORT auto E_PROP_FMeshBuildSettings_SrcLightmapIndex_GET(FMeshBuildSettings* Ptr) { return Ptr->SrcLightmapIndex; }
	DOTNET_EXPORT void E_PROP_FMeshBuildSettings_SrcLightmapIndex_SET(FMeshBuildSettings* Ptr, int32 Value) { Ptr->SrcLightmapIndex = Value; }
	
	
	/*	FMTDResult	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FMTDResult() { return (INT_PTR) new FMTDResult(); }
	
	DOTNET_EXPORT auto E_PROP_FMTDResult_Direction_GET(FMTDResult* Ptr) { return (INT_PTR)&(Ptr->Direction); }
	DOTNET_EXPORT void E_PROP_FMTDResult_Direction_SET(FMTDResult* Ptr, INT_PTR Value) { Ptr->Direction = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FMTDResult_Distance_GET(FMTDResult* Ptr) { return Ptr->Distance; }
	DOTNET_EXPORT void E_PROP_FMTDResult_Distance_SET(FMTDResult* Ptr, float Value) { Ptr->Distance = Value; }
	
	
	/*	FNetDriverDefinition	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FNetDriverDefinition() { return (INT_PTR) new FNetDriverDefinition(); }
	
	DOTNET_EXPORT auto E_PROP_FNetDriverDefinition_DefName_GET(FNetDriverDefinition* Ptr) { return ConvertToManage_StringWrapper(Ptr->DefName); }
	DOTNET_EXPORT void E_PROP_FNetDriverDefinition_DefName_SET(FNetDriverDefinition* Ptr, char* Value) { Ptr->DefName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FNetDriverDefinition_DriverClassName_GET(FNetDriverDefinition* Ptr) { return ConvertToManage_StringWrapper(Ptr->DriverClassName); }
	DOTNET_EXPORT void E_PROP_FNetDriverDefinition_DriverClassName_SET(FNetDriverDefinition* Ptr, char* Value) { Ptr->DriverClassName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FNetDriverDefinition_DriverClassNameFallback_GET(FNetDriverDefinition* Ptr) { return ConvertToManage_StringWrapper(Ptr->DriverClassNameFallback); }
	DOTNET_EXPORT void E_PROP_FNetDriverDefinition_DriverClassNameFallback_SET(FNetDriverDefinition* Ptr, char* Value) { Ptr->DriverClassNameFallback = ConvertFromManage_FName(Value); }
	
	
	/*	FOverlapInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapInfo() { return (INT_PTR) new FOverlapInfo(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapInfo_FHitResult(INT_PTR InSweepResult) { return (INT_PTR) new FOverlapInfo(*(FHitResult*)InSweepResult); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapInfo_UPrimitiveComponent_int32(UPrimitiveComponent* InComponent, int32 InBodyIndex) { return (INT_PTR) new FOverlapInfo(InComponent, InBodyIndex); }
	
	DOTNET_EXPORT auto E_PROP_FOverlapInfo_bFromSweep_GET(FOverlapInfo* Ptr) { return Ptr->bFromSweep; }
	DOTNET_EXPORT void E_PROP_FOverlapInfo_bFromSweep_SET(FOverlapInfo* Ptr, bool Value) { Ptr->bFromSweep = Value; }
	
	DOTNET_EXPORT auto E_PROP_FOverlapInfo_OverlapInfo_GET(FOverlapInfo* Ptr) { return (INT_PTR)&(Ptr->OverlapInfo); }
	DOTNET_EXPORT void E_PROP_FOverlapInfo_OverlapInfo_SET(FOverlapInfo* Ptr, INT_PTR Value) { Ptr->OverlapInfo = *(FHitResult*)Value; }
	
	DOTNET_EXPORT auto E_FOverlapInfo_GetBodyIndex(FOverlapInfo* Self)
	{
		return Self->GetBodyIndex();
	}

	
	/*	FOverlapResult	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapResult() { return (INT_PTR) new FOverlapResult(); }
	
	DOTNET_EXPORT auto E_PROP_FOverlapResult_ItemIndex_GET(FOverlapResult* Ptr) { return Ptr->ItemIndex; }
	DOTNET_EXPORT void E_PROP_FOverlapResult_ItemIndex_SET(FOverlapResult* Ptr, int32 Value) { Ptr->ItemIndex = Value; }
	
	DOTNET_EXPORT auto E_FOverlapResult_GetActor(FOverlapResult* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetActor());
	}

	DOTNET_EXPORT auto E_FOverlapResult_GetComponent(FOverlapResult* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetComponent());
	}

	
	/*	FPaintedVertex	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPaintedVertex() { return (INT_PTR) new FPaintedVertex(); }
	
	DOTNET_EXPORT auto E_PROP_FPaintedVertex_Position_GET(FPaintedVertex* Ptr) { return (INT_PTR)&(Ptr->Position); }
	DOTNET_EXPORT void E_PROP_FPaintedVertex_Position_SET(FPaintedVertex* Ptr, INT_PTR Value) { Ptr->Position = *(FVector*)Value; }
	
	
	/*	FPlane	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane() { return (INT_PTR) new FPlane(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FPlane(INT_PTR P) { return (INT_PTR) new FPlane(*(FPlane*)P); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector4(INT_PTR V) { return (INT_PTR) new FPlane(*(FVector4*)V); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_float_float_float_float(float InX, float InY, float InZ, float InW) { return (INT_PTR) new FPlane(InX, InY, InZ, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector_float(INT_PTR InNormal, float InW) { return (INT_PTR) new FPlane(*(FVector*)InNormal, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector_FVector(INT_PTR InBase, INT_PTR InNormal) { return (INT_PTR) new FPlane(*(FVector*)InBase, *(FVector*)InNormal); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector_FVector_FVector(INT_PTR A, INT_PTR B, INT_PTR C) { return (INT_PTR) new FPlane(*(FVector*)A, *(FVector*)B, *(FVector*)C); }
	
	DOTNET_EXPORT auto E_PROP_FPlane_W_GET(FPlane* Ptr) { return Ptr->W; }
	DOTNET_EXPORT void E_PROP_FPlane_W_SET(FPlane* Ptr, float Value) { Ptr->W = Value; }
	
	DOTNET_EXPORT auto E_FPlane_Equals(FPlane* Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FPlane*)V;
		auto _p1 = Tolerance;
		return Self->Equals(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FPlane_Flip(FPlane* Self)
	{
		return (INT_PTR) new FPlane(Self->Flip());
	}

	DOTNET_EXPORT auto E_FPlane_Normalize(FPlane* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return Self->Normalize(_p0);
	}

	DOTNET_EXPORT auto E_FPlane_PlaneDot(FPlane* Self, INT_PTR P)
	{
		auto _p0 = *(FVector*)P;
		return Self->PlaneDot(_p0);
	}

	
	/*	FPluginRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPluginRedirect() { return (INT_PTR) new FPluginRedirect(); }
	
	DOTNET_EXPORT auto E_PROP_FPluginRedirect_NewPluginName_GET(FPluginRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewPluginName); }
	DOTNET_EXPORT void E_PROP_FPluginRedirect_NewPluginName_SET(FPluginRedirect* Ptr, char* Value) { Ptr->NewPluginName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FPluginRedirect_OldPluginName_GET(FPluginRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->OldPluginName); }
	DOTNET_EXPORT void E_PROP_FPluginRedirect_OldPluginName_SET(FPluginRedirect* Ptr, char* Value) { Ptr->OldPluginName = ConvertFromManage_FString(Value); }
	
	
	/*	FPointDamageEvent	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPointDamageEvent() { return (INT_PTR) new FPointDamageEvent(); }
	
	DOTNET_EXPORT auto E_PROP_FPointDamageEvent_Damage_GET(FPointDamageEvent* Ptr) { return Ptr->Damage; }
	DOTNET_EXPORT void E_PROP_FPointDamageEvent_Damage_SET(FPointDamageEvent* Ptr, float Value) { Ptr->Damage = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPointDamageEvent_HitInfo_GET(FPointDamageEvent* Ptr) { return (INT_PTR)&(Ptr->HitInfo); }
	DOTNET_EXPORT void E_PROP_FPointDamageEvent_HitInfo_SET(FPointDamageEvent* Ptr, INT_PTR Value) { Ptr->HitInfo = *(FHitResult*)Value; }
	
	
	/*	FPostProcessSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPostProcessSettings() { return (INT_PTR) new FPostProcessSettings(); }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientCubemapIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientCubemapIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientCubemapIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientCubemapIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionBias_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionBias; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionBias_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionBias = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionDistance_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionDistance_DEPRECATED_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionDistance_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionFadeDistance; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionFadeDistance_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionFadeDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionFadeRadius; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionFadeRadius_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionFadeRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionMipBlend; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionMipBlend_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionMipBlend = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionMipScale; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionMipScale_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionMipScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionMipThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionMipThreshold_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionMipThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionPower_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionPower; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionPower_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionPower = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionQuality_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionQuality; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionQuality_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionQuality = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionRadius_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionRadius; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionRadius_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_GET(FPostProcessSettings* Ptr) { return Ptr->AmbientOcclusionStaticFraction; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AmbientOcclusionStaticFraction_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AmbientOcclusionStaticFraction = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AutoExposureBias_GET(FPostProcessSettings* Ptr) { return Ptr->AutoExposureBias; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureBias_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AutoExposureBias = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AutoExposureCalibrationConstant_GET(FPostProcessSettings* Ptr) { return Ptr->AutoExposureCalibrationConstant; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureCalibrationConstant_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AutoExposureCalibrationConstant = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AutoExposureHighPercent_GET(FPostProcessSettings* Ptr) { return Ptr->AutoExposureHighPercent; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureHighPercent_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AutoExposureHighPercent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AutoExposureLowPercent_GET(FPostProcessSettings* Ptr) { return Ptr->AutoExposureLowPercent; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureLowPercent_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AutoExposureLowPercent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_GET(FPostProcessSettings* Ptr) { return Ptr->AutoExposureMaxBrightness; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureMaxBrightness_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AutoExposureMaxBrightness = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AutoExposureMinBrightness_GET(FPostProcessSettings* Ptr) { return Ptr->AutoExposureMinBrightness; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureMinBrightness_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AutoExposureMinBrightness = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AutoExposureSpeedDown_GET(FPostProcessSettings* Ptr) { return Ptr->AutoExposureSpeedDown; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureSpeedDown_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AutoExposureSpeedDown = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_AutoExposureSpeedUp_GET(FPostProcessSettings* Ptr) { return Ptr->AutoExposureSpeedUp; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_AutoExposureSpeedUp_SET(FPostProcessSettings* Ptr, float Value) { Ptr->AutoExposureSpeedUp = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_Bloom1Size_GET(FPostProcessSettings* Ptr) { return Ptr->Bloom1Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom1Size_SET(FPostProcessSettings* Ptr, float Value) { Ptr->Bloom1Size = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_Bloom2Size_GET(FPostProcessSettings* Ptr) { return Ptr->Bloom2Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom2Size_SET(FPostProcessSettings* Ptr, float Value) { Ptr->Bloom2Size = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_Bloom3Size_GET(FPostProcessSettings* Ptr) { return Ptr->Bloom3Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom3Size_SET(FPostProcessSettings* Ptr, float Value) { Ptr->Bloom3Size = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_Bloom4Size_GET(FPostProcessSettings* Ptr) { return Ptr->Bloom4Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom4Size_SET(FPostProcessSettings* Ptr, float Value) { Ptr->Bloom4Size = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_Bloom5Size_GET(FPostProcessSettings* Ptr) { return Ptr->Bloom5Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom5Size_SET(FPostProcessSettings* Ptr, float Value) { Ptr->Bloom5Size = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_Bloom6Size_GET(FPostProcessSettings* Ptr) { return Ptr->Bloom6Size; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_Bloom6Size_SET(FPostProcessSettings* Ptr, float Value) { Ptr->Bloom6Size = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_GET(FPostProcessSettings* Ptr) { return Ptr->BloomConvolutionBufferScale; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionBufferScale_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BloomConvolutionBufferScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->BloomConvolutionCenterUV); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionCenterUV_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->BloomConvolutionCenterUV = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomConvolutionPreFilter_DEPRECATED_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->BloomConvolutionPreFilter_DEPRECATED); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionPreFilter_DEPRECATED_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->BloomConvolutionPreFilter_DEPRECATED = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_GET(FPostProcessSettings* Ptr) { return Ptr->BloomConvolutionPreFilterMax; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMax_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BloomConvolutionPreFilterMax = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_GET(FPostProcessSettings* Ptr) { return Ptr->BloomConvolutionPreFilterMin; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMin_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BloomConvolutionPreFilterMin = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_GET(FPostProcessSettings* Ptr) { return Ptr->BloomConvolutionPreFilterMult; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionPreFilterMult_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BloomConvolutionPreFilterMult = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomConvolutionSize_GET(FPostProcessSettings* Ptr) { return Ptr->BloomConvolutionSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomConvolutionSize_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BloomConvolutionSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->BloomDirtMaskIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomDirtMaskIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BloomDirtMaskIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->BloomIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BloomIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomSizeScale_GET(FPostProcessSettings* Ptr) { return Ptr->BloomSizeScale; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomSizeScale_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BloomSizeScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BloomThreshold_GET(FPostProcessSettings* Ptr) { return Ptr->BloomThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BloomThreshold_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BloomThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_BlueCorrection_GET(FPostProcessSettings* Ptr) { return Ptr->BlueCorrection; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_BlueCorrection_SET(FPostProcessSettings* Ptr, float Value) { Ptr->BlueCorrection = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_CameraISO_GET(FPostProcessSettings* Ptr) { return Ptr->CameraISO; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_CameraISO_SET(FPostProcessSettings* Ptr, float Value) { Ptr->CameraISO = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_CameraShutterSpeed_GET(FPostProcessSettings* Ptr) { return Ptr->CameraShutterSpeed; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_CameraShutterSpeed_SET(FPostProcessSettings* Ptr, float Value) { Ptr->CameraShutterSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ChromaticAberrationStartOffset_GET(FPostProcessSettings* Ptr) { return Ptr->ChromaticAberrationStartOffset; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ChromaticAberrationStartOffset_SET(FPostProcessSettings* Ptr, float Value) { Ptr->ChromaticAberrationStartOffset = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorContrast_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorContrast); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorContrast_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorContrast = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorContrastHighlights_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorContrastHighlights); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorContrastHighlights_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorContrastHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorContrastMidtones_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorContrastMidtones); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorContrastMidtones_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorContrastMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorContrastShadows_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorContrastShadows); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorContrastShadows_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorContrastShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_GET(FPostProcessSettings* Ptr) { return Ptr->ColorCorrectionHighlightsMin; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorCorrectionHighlightsMin_SET(FPostProcessSettings* Ptr, float Value) { Ptr->ColorCorrectionHighlightsMin = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_GET(FPostProcessSettings* Ptr) { return Ptr->ColorCorrectionShadowsMax; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorCorrectionShadowsMax_SET(FPostProcessSettings* Ptr, float Value) { Ptr->ColorCorrectionShadowsMax = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorGain_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorGain); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGain_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorGain = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorGainHighlights_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorGainHighlights); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGainHighlights_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorGainHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorGainMidtones_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorGainMidtones); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGainMidtones_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorGainMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorGainShadows_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorGainShadows); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGainShadows_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorGainShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorGamma_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorGamma); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGamma_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorGamma = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorGammaHighlights_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorGammaHighlights); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGammaHighlights_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorGammaHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorGammaMidtones_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorGammaMidtones); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGammaMidtones_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorGammaMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorGammaShadows_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorGammaShadows); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGammaShadows_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorGammaShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorGradingIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->ColorGradingIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorGradingIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->ColorGradingIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorOffset_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorOffset); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorOffset_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorOffset = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorOffsetHighlights_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorOffsetHighlights); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorOffsetHighlights_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorOffsetHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorOffsetMidtones_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorOffsetMidtones); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorOffsetMidtones_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorOffsetMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorOffsetShadows_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorOffsetShadows); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorOffsetShadows_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorOffsetShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorSaturation_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorSaturation); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorSaturation_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorSaturation = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorSaturationHighlights_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorSaturationHighlights); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorSaturationHighlights_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorSaturationHighlights = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorSaturationMidtones_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorSaturationMidtones); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorSaturationMidtones_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorSaturationMidtones = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ColorSaturationShadows_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->ColorSaturationShadows); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ColorSaturationShadows_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->ColorSaturationShadows = *(FVector4*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldColorThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldColorThreshold_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldColorThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldDepthBlurAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurAmount_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldDepthBlurAmount = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldDepthBlurRadius; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldDepthBlurRadius_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldDepthBlurRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldFarBlurSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFarBlurSize_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldFarBlurSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldFarTransitionRegion; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFarTransitionRegion_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldFarTransitionRegion = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldFocalDistance; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFocalDistance_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldFocalDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldFocalRegion; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFocalRegion_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldFocalRegion = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldFstop_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldFstop; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldFstop_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldFstop = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldMaxBokehSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldMaxBokehSize_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldMaxBokehSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldNearBlurSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldNearBlurSize_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldNearBlurSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldNearTransitionRegion; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldNearTransitionRegion_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldNearTransitionRegion = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldOcclusion; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldOcclusion_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldOcclusion = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldScale_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldScale; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldScale_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldSensorWidth; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldSensorWidth_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldSensorWidth = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldSizeThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldSizeThreshold_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldSizeThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldSkyFocusDistance; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldSkyFocusDistance_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldSkyFocusDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_GET(FPostProcessSettings* Ptr) { return Ptr->DepthOfFieldVignetteSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_DepthOfFieldVignetteSize_SET(FPostProcessSettings* Ptr, float Value) { Ptr->DepthOfFieldVignetteSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ExpandGamut_GET(FPostProcessSettings* Ptr) { return Ptr->ExpandGamut; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ExpandGamut_SET(FPostProcessSettings* Ptr, float Value) { Ptr->ExpandGamut = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmBlackClip_GET(FPostProcessSettings* Ptr) { return Ptr->FilmBlackClip; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmBlackClip_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmBlackClip = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmContrast_GET(FPostProcessSettings* Ptr) { return Ptr->FilmContrast; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmContrast_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmContrast = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmDynamicRange_GET(FPostProcessSettings* Ptr) { return Ptr->FilmDynamicRange; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmDynamicRange_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmDynamicRange = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmHealAmount_GET(FPostProcessSettings* Ptr) { return Ptr->FilmHealAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmHealAmount_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmHealAmount = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmSaturation_GET(FPostProcessSettings* Ptr) { return Ptr->FilmSaturation; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmSaturation_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmSaturation = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmShadowTintAmount_GET(FPostProcessSettings* Ptr) { return Ptr->FilmShadowTintAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmShadowTintAmount_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmShadowTintAmount = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmShadowTintBlend_GET(FPostProcessSettings* Ptr) { return Ptr->FilmShadowTintBlend; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmShadowTintBlend_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmShadowTintBlend = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmShoulder_GET(FPostProcessSettings* Ptr) { return Ptr->FilmShoulder; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmShoulder_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmShoulder = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmSlope_GET(FPostProcessSettings* Ptr) { return Ptr->FilmSlope; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmSlope_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmSlope = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmToe_GET(FPostProcessSettings* Ptr) { return Ptr->FilmToe; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmToe_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmToe = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmToeAmount_GET(FPostProcessSettings* Ptr) { return Ptr->FilmToeAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmToeAmount_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmToeAmount = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_FilmWhiteClip_GET(FPostProcessSettings* Ptr) { return Ptr->FilmWhiteClip; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_FilmWhiteClip_SET(FPostProcessSettings* Ptr, float Value) { Ptr->FilmWhiteClip = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_GrainIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->GrainIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_GrainIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->GrainIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_GrainJitter_GET(FPostProcessSettings* Ptr) { return Ptr->GrainJitter; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_GrainJitter_SET(FPostProcessSettings* Ptr, float Value) { Ptr->GrainJitter = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_HistogramLogMax_GET(FPostProcessSettings* Ptr) { return Ptr->HistogramLogMax; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_HistogramLogMax_SET(FPostProcessSettings* Ptr, float Value) { Ptr->HistogramLogMax = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_HistogramLogMin_GET(FPostProcessSettings* Ptr) { return Ptr->HistogramLogMin; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_HistogramLogMin_SET(FPostProcessSettings* Ptr, float Value) { Ptr->HistogramLogMin = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_IndirectLightingIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->IndirectLightingIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_IndirectLightingIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->IndirectLightingIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LensFlareBokehSize_GET(FPostProcessSettings* Ptr) { return Ptr->LensFlareBokehSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LensFlareBokehSize_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LensFlareBokehSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LensFlareIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->LensFlareIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LensFlareIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LensFlareIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LensFlareThreshold_GET(FPostProcessSettings* Ptr) { return Ptr->LensFlareThreshold; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LensFlareThreshold_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LensFlareThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_GET(FPostProcessSettings* Ptr) { return Ptr->LPVDiffuseOcclusionExponent; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDiffuseOcclusionExponent_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVDiffuseOcclusionExponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->LPVDiffuseOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDiffuseOcclusionIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVDiffuseOcclusionIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_GET(FPostProcessSettings* Ptr) { return Ptr->LPVDirectionalOcclusionFadeRange; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionFadeRange_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVDirectionalOcclusionFadeRange = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->LPVDirectionalOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVDirectionalOcclusionIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_GET(FPostProcessSettings* Ptr) { return Ptr->LPVDirectionalOcclusionRadius; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVDirectionalOcclusionRadius_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVDirectionalOcclusionRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->LPVEmissiveInjectionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVEmissiveInjectionIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVEmissiveInjectionIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVFadeRange_GET(FPostProcessSettings* Ptr) { return Ptr->LPVFadeRange; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVFadeRange_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVFadeRange = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_GET(FPostProcessSettings* Ptr) { return Ptr->LPVGeometryVolumeBias; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVGeometryVolumeBias_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVGeometryVolumeBias = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->LPVIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->LPVSecondaryBounceIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSecondaryBounceIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVSecondaryBounceIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->LPVSecondaryOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSecondaryOcclusionIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVSecondaryOcclusionIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVSize_GET(FPostProcessSettings* Ptr) { return Ptr->LPVSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSize_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_GET(FPostProcessSettings* Ptr) { return Ptr->LPVSpecularOcclusionExponent; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSpecularOcclusionExponent_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVSpecularOcclusionExponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->LPVSpecularOcclusionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVSpecularOcclusionIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVSpecularOcclusionIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_LPVVplInjectionBias_GET(FPostProcessSettings* Ptr) { return Ptr->LPVVplInjectionBias; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_LPVVplInjectionBias_SET(FPostProcessSettings* Ptr, float Value) { Ptr->LPVVplInjectionBias = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_MotionBlurAmount_GET(FPostProcessSettings* Ptr) { return Ptr->MotionBlurAmount; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_MotionBlurAmount_SET(FPostProcessSettings* Ptr, float Value) { Ptr->MotionBlurAmount = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_MotionBlurMax_GET(FPostProcessSettings* Ptr) { return Ptr->MotionBlurMax; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_MotionBlurMax_SET(FPostProcessSettings* Ptr, float Value) { Ptr->MotionBlurMax = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_GET(FPostProcessSettings* Ptr) { return Ptr->MotionBlurPerObjectSize; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_MotionBlurPerObjectSize_SET(FPostProcessSettings* Ptr, float Value) { Ptr->MotionBlurPerObjectSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_SceneFringeIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->SceneFringeIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_SceneFringeIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->SceneFringeIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ScreenPercentage_GET(FPostProcessSettings* Ptr) { return Ptr->ScreenPercentage; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ScreenPercentage_SET(FPostProcessSettings* Ptr, float Value) { Ptr->ScreenPercentage = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->ScreenSpaceReflectionIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ScreenSpaceReflectionIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->ScreenSpaceReflectionIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_GET(FPostProcessSettings* Ptr) { return Ptr->ScreenSpaceReflectionMaxRoughness; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ScreenSpaceReflectionMaxRoughness_SET(FPostProcessSettings* Ptr, float Value) { Ptr->ScreenSpaceReflectionMaxRoughness = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_GET(FPostProcessSettings* Ptr) { return Ptr->ScreenSpaceReflectionQuality; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_ScreenSpaceReflectionQuality_SET(FPostProcessSettings* Ptr, float Value) { Ptr->ScreenSpaceReflectionQuality = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_VignetteIntensity_GET(FPostProcessSettings* Ptr) { return Ptr->VignetteIntensity; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_VignetteIntensity_SET(FPostProcessSettings* Ptr, float Value) { Ptr->VignetteIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_WeightedBlendables_GET(FPostProcessSettings* Ptr) { return (INT_PTR)&(Ptr->WeightedBlendables); }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_WeightedBlendables_SET(FPostProcessSettings* Ptr, INT_PTR Value) { Ptr->WeightedBlendables = *(FWeightedBlendables*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_WhiteTemp_GET(FPostProcessSettings* Ptr) { return Ptr->WhiteTemp; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_WhiteTemp_SET(FPostProcessSettings* Ptr, float Value) { Ptr->WhiteTemp = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPostProcessSettings_WhiteTint_GET(FPostProcessSettings* Ptr) { return Ptr->WhiteTint; }
	DOTNET_EXPORT void E_PROP_FPostProcessSettings_WhiteTint_SET(FPostProcessSettings* Ptr, float Value) { Ptr->WhiteTint = Value; }
	
	DOTNET_EXPORT auto E_FPostProcessSettings_OnAfterLoad(FPostProcessSettings* Self)
	{
		Self->OnAfterLoad();
	}

	DOTNET_EXPORT auto E_FPostProcessSettings_SetBaseValues(FPostProcessSettings* Self)
	{
		Self->SetBaseValues();
	}

	
	/*	FPOV	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPOV() { return (INT_PTR) new FPOV(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPOV_FVector_FRotator_float(INT_PTR InLocation, INT_PTR InRotation, float InFOV) { return (INT_PTR) new FPOV(*(FVector*)InLocation, *(FRotator*)InRotation, InFOV); }
	
	DOTNET_EXPORT auto E_PROP_FPOV_FOV_GET(FPOV* Ptr) { return Ptr->FOV; }
	DOTNET_EXPORT void E_PROP_FPOV_FOV_SET(FPOV* Ptr, float Value) { Ptr->FOV = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPOV_Location_GET(FPOV* Ptr) { return (INT_PTR)&(Ptr->Location); }
	DOTNET_EXPORT void E_PROP_FPOV_Location_SET(FPOV* Ptr, INT_PTR Value) { Ptr->Location = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FPOV_Rotation_GET(FPOV* Ptr) { return (INT_PTR)&(Ptr->Rotation); }
	DOTNET_EXPORT void E_PROP_FPOV_Rotation_SET(FPOV* Ptr, INT_PTR Value) { Ptr->Rotation = *(FRotator*)Value; }
	
	
	/*	FPreCulledStaticMeshSection	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPreCulledStaticMeshSection() { return (INT_PTR) new FPreCulledStaticMeshSection(); }
	
	
	/*	FPrimitiveMaterialRef	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPrimitiveMaterialRef() { return (INT_PTR) new FPrimitiveMaterialRef(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPrimitiveMaterialRef_UPrimitiveComponent_int32(UPrimitiveComponent* InPrimitive, int32 InElementIndex) { return (INT_PTR) new FPrimitiveMaterialRef(InPrimitive, InElementIndex); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPrimitiveMaterialRef_UDecalComponent_int32(UDecalComponent* InDecal, int32 InElementIndex) { return (INT_PTR) new FPrimitiveMaterialRef(InDecal, InElementIndex); }
	
	DOTNET_EXPORT auto E_PROP_FPrimitiveMaterialRef_Decal_GET(FPrimitiveMaterialRef* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Decal); }
	DOTNET_EXPORT void E_PROP_FPrimitiveMaterialRef_Decal_SET(FPrimitiveMaterialRef* Ptr, UDecalComponent* Value) { Ptr->Decal = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPrimitiveMaterialRef_ElementIndex_GET(FPrimitiveMaterialRef* Ptr) { return Ptr->ElementIndex; }
	DOTNET_EXPORT void E_PROP_FPrimitiveMaterialRef_ElementIndex_SET(FPrimitiveMaterialRef* Ptr, int32 Value) { Ptr->ElementIndex = Value; }
	
	DOTNET_EXPORT auto E_PROP_FPrimitiveMaterialRef_Primitive_GET(FPrimitiveMaterialRef* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Primitive); }
	DOTNET_EXPORT void E_PROP_FPrimitiveMaterialRef_Primitive_SET(FPrimitiveMaterialRef* Ptr, UPrimitiveComponent* Value) { Ptr->Primitive = Value; }
	
	
	/*	FQuat	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat() { return (INT_PTR) new FQuat(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_float_float_float_float(float InX, float InY, float InZ, float InW) { return (INT_PTR) new FQuat(InX, InY, InZ, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_FQuat(INT_PTR Q) { return (INT_PTR) new FQuat(*(FQuat*)Q); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_FRotator(INT_PTR R) { return (INT_PTR) new FQuat(*(FRotator*)R); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_FVector_float(INT_PTR Axis, float AngleRad) { return (INT_PTR) new FQuat(*(FVector*)Axis, AngleRad); }
	
	DOTNET_EXPORT auto E_PROP_FQuat_W_GET(FQuat* Ptr) { return Ptr->W; }
	DOTNET_EXPORT void E_PROP_FQuat_W_SET(FQuat* Ptr, float Value) { Ptr->W = Value; }
	
	DOTNET_EXPORT auto E_PROP_FQuat_X_GET(FQuat* Ptr) { return Ptr->X; }
	DOTNET_EXPORT void E_PROP_FQuat_X_SET(FQuat* Ptr, float Value) { Ptr->X = Value; }
	
	DOTNET_EXPORT auto E_PROP_FQuat_Y_GET(FQuat* Ptr) { return Ptr->Y; }
	DOTNET_EXPORT void E_PROP_FQuat_Y_SET(FQuat* Ptr, float Value) { Ptr->Y = Value; }
	
	DOTNET_EXPORT auto E_PROP_FQuat_Z_GET(FQuat* Ptr) { return Ptr->Z; }
	DOTNET_EXPORT void E_PROP_FQuat_Z_SET(FQuat* Ptr, float Value) { Ptr->Z = Value; }
	
	DOTNET_EXPORT auto E_FQuat_AngularDistance(FQuat* Self, INT_PTR Q)
	{
		auto _p0 = *(FQuat*)Q;
		return Self->AngularDistance(_p0);
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
		return Self->ContainsNaN();
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
		return Self->Equals(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FQuat_Error(FQuat* Self, INT_PTR Q1, INT_PTR Q2)
	{
		auto _p0 = *(FQuat*)Q1;
		auto _p1 = *(FQuat*)Q2;
		return Self->Error(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FQuat_ErrorAutoNormalize(FQuat* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		return Self->ErrorAutoNormalize(_p0, _p1);
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

	DOTNET_EXPORT auto E_FQuat_GetAngle(FQuat* Self)
	{
		return Self->GetAngle();
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

	DOTNET_EXPORT auto E_FQuat_InitFromString(FQuat* Self, char* InSourceString)
	{
		auto _p0 = ConvertFromManage_FString(InSourceString);
		return Self->InitFromString(_p0);
	}

	DOTNET_EXPORT auto E_FQuat_Inverse(FQuat* Self)
	{
		return (INT_PTR) new FQuat(Self->Inverse());
	}

	DOTNET_EXPORT auto E_FQuat_IsIdentity(FQuat* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return Self->IsIdentity(_p0);
	}

	DOTNET_EXPORT auto E_FQuat_IsNormalized(FQuat* Self)
	{
		return Self->IsNormalized();
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
		return Self->Size();
	}

	DOTNET_EXPORT auto E_FQuat_SizeSquared(FQuat* Self)
	{
		return Self->SizeSquared();
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

	DOTNET_EXPORT auto E_FQuat_ToString(FQuat* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
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

	
	/*	FRadialDamageEvent	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRadialDamageEvent() { return (INT_PTR) new FRadialDamageEvent(); }
	
	DOTNET_EXPORT auto E_PROP_FRadialDamageEvent_Origin_GET(FRadialDamageEvent* Ptr) { return (INT_PTR)&(Ptr->Origin); }
	DOTNET_EXPORT void E_PROP_FRadialDamageEvent_Origin_SET(FRadialDamageEvent* Ptr, INT_PTR Value) { Ptr->Origin = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FRadialDamageEvent_Params_GET(FRadialDamageEvent* Ptr) { return (INT_PTR)&(Ptr->Params); }
	DOTNET_EXPORT void E_PROP_FRadialDamageEvent_Params_SET(FRadialDamageEvent* Ptr, INT_PTR Value) { Ptr->Params = *(FRadialDamageParams*)Value; }
	
	
	/*	FRadialDamageParams	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRadialDamageParams() { return (INT_PTR) new FRadialDamageParams(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRadialDamageParams_float_float_float_float(float InBaseDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff) { return (INT_PTR) new FRadialDamageParams(InBaseDamage, InInnerRadius, InOuterRadius, InDamageFalloff); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRadialDamageParams_float_float_float_float_float(float InBaseDamage, float InMinimumDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff) { return (INT_PTR) new FRadialDamageParams(InBaseDamage, InMinimumDamage, InInnerRadius, InOuterRadius, InDamageFalloff); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRadialDamageParams_float_float(float InBaseDamage, float InRadius) { return (INT_PTR) new FRadialDamageParams(InBaseDamage, InRadius); }
	
	DOTNET_EXPORT auto E_PROP_FRadialDamageParams_BaseDamage_GET(FRadialDamageParams* Ptr) { return Ptr->BaseDamage; }
	DOTNET_EXPORT void E_PROP_FRadialDamageParams_BaseDamage_SET(FRadialDamageParams* Ptr, float Value) { Ptr->BaseDamage = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRadialDamageParams_DamageFalloff_GET(FRadialDamageParams* Ptr) { return Ptr->DamageFalloff; }
	DOTNET_EXPORT void E_PROP_FRadialDamageParams_DamageFalloff_SET(FRadialDamageParams* Ptr, float Value) { Ptr->DamageFalloff = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRadialDamageParams_InnerRadius_GET(FRadialDamageParams* Ptr) { return Ptr->InnerRadius; }
	DOTNET_EXPORT void E_PROP_FRadialDamageParams_InnerRadius_SET(FRadialDamageParams* Ptr, float Value) { Ptr->InnerRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRadialDamageParams_MinimumDamage_GET(FRadialDamageParams* Ptr) { return Ptr->MinimumDamage; }
	DOTNET_EXPORT void E_PROP_FRadialDamageParams_MinimumDamage_SET(FRadialDamageParams* Ptr, float Value) { Ptr->MinimumDamage = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRadialDamageParams_OuterRadius_GET(FRadialDamageParams* Ptr) { return Ptr->OuterRadius; }
	DOTNET_EXPORT void E_PROP_FRadialDamageParams_OuterRadius_SET(FRadialDamageParams* Ptr, float Value) { Ptr->OuterRadius = Value; }
	
	DOTNET_EXPORT auto E_FRadialDamageParams_GetDamageScale(FRadialDamageParams* Self, float DistanceFromEpicenter)
	{
		auto _p0 = DistanceFromEpicenter;
		return Self->GetDamageScale(_p0);
	}

	DOTNET_EXPORT auto E_FRadialDamageParams_GetMaxRadius(FRadialDamageParams* Self)
	{
		return Self->GetMaxRadius();
	}

	
	/*	FRedirector	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRedirector() { return (INT_PTR) new FRedirector(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRedirector_FName_FName(char* InOldName, char* InNewName) { return (INT_PTR) new FRedirector(ConvertFromManage_FName(InOldName), ConvertFromManage_FName(InNewName)); }
	
	DOTNET_EXPORT auto E_PROP_FRedirector_NewName_GET(FRedirector* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewName); }
	DOTNET_EXPORT void E_PROP_FRedirector_NewName_SET(FRedirector* Ptr, char* Value) { Ptr->NewName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FRedirector_OldName_GET(FRedirector* Ptr) { return ConvertToManage_StringWrapper(Ptr->OldName); }
	DOTNET_EXPORT void E_PROP_FRedirector_OldName_SET(FRedirector* Ptr, char* Value) { Ptr->OldName = ConvertFromManage_FName(Value); }
	
	
	/*	FRendererStencilMaskEvaluation	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRendererStencilMaskEvaluation() { return (INT_PTR) new FRendererStencilMaskEvaluation(); }
	
	
	/*	FRepAttachment	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRepAttachment() { return (INT_PTR) new FRepAttachment(); }
	
	DOTNET_EXPORT auto E_PROP_FRepAttachment_AttachComponent_GET(FRepAttachment* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->AttachComponent); }
	DOTNET_EXPORT void E_PROP_FRepAttachment_AttachComponent_SET(FRepAttachment* Ptr, USceneComponent* Value) { Ptr->AttachComponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepAttachment_AttachParent_GET(FRepAttachment* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->AttachParent); }
	DOTNET_EXPORT void E_PROP_FRepAttachment_AttachParent_SET(FRepAttachment* Ptr, AActor* Value) { Ptr->AttachParent = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepAttachment_AttachSocket_GET(FRepAttachment* Ptr) { return ConvertToManage_StringWrapper(Ptr->AttachSocket); }
	DOTNET_EXPORT void E_PROP_FRepAttachment_AttachSocket_SET(FRepAttachment* Ptr, char* Value) { Ptr->AttachSocket = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FRepAttachment_RotationOffset_GET(FRepAttachment* Ptr) { return (INT_PTR)&(Ptr->RotationOffset); }
	DOTNET_EXPORT void E_PROP_FRepAttachment_RotationOffset_SET(FRepAttachment* Ptr, INT_PTR Value) { Ptr->RotationOffset = *(FRotator*)Value; }
	
	
	/*	FReplicationFlags	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FReplicationFlags() { return (INT_PTR) new FReplicationFlags(); }
	
	
	/*	FRepMovement	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRepMovement() { return (INT_PTR) new FRepMovement(); }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_AngularVelocity_GET(FRepMovement* Ptr) { return (INT_PTR)&(Ptr->AngularVelocity); }
	DOTNET_EXPORT void E_PROP_FRepMovement_AngularVelocity_SET(FRepMovement* Ptr, INT_PTR Value) { Ptr->AngularVelocity = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_bRepPhysics_GET(FRepMovement* Ptr) { return Ptr->bRepPhysics; }
	DOTNET_EXPORT void E_PROP_FRepMovement_bRepPhysics_SET(FRepMovement* Ptr, uint8 Value) { Ptr->bRepPhysics = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_bSimulatedPhysicSleep_GET(FRepMovement* Ptr) { return Ptr->bSimulatedPhysicSleep; }
	DOTNET_EXPORT void E_PROP_FRepMovement_bSimulatedPhysicSleep_SET(FRepMovement* Ptr, uint8 Value) { Ptr->bSimulatedPhysicSleep = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_EnableMultiplayerWorldOriginRebasing_GET() { return FRepMovement::EnableMultiplayerWorldOriginRebasing; }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_LinearVelocity_GET(FRepMovement* Ptr) { return (INT_PTR)&(Ptr->LinearVelocity); }
	DOTNET_EXPORT void E_PROP_FRepMovement_LinearVelocity_SET(FRepMovement* Ptr, INT_PTR Value) { Ptr->LinearVelocity = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_Location_GET(FRepMovement* Ptr) { return (INT_PTR)&(Ptr->Location); }
	DOTNET_EXPORT void E_PROP_FRepMovement_Location_SET(FRepMovement* Ptr, INT_PTR Value) { Ptr->Location = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_LocationQuantizationLevel_GET(FRepMovement* Ptr) { return Ptr->LocationQuantizationLevel; }
	DOTNET_EXPORT void E_PROP_FRepMovement_LocationQuantizationLevel_SET(FRepMovement* Ptr, EVectorQuantization Value) { Ptr->LocationQuantizationLevel = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_Rotation_GET(FRepMovement* Ptr) { return (INT_PTR)&(Ptr->Rotation); }
	DOTNET_EXPORT void E_PROP_FRepMovement_Rotation_SET(FRepMovement* Ptr, INT_PTR Value) { Ptr->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_RotationQuantizationLevel_GET(FRepMovement* Ptr) { return Ptr->RotationQuantizationLevel; }
	DOTNET_EXPORT void E_PROP_FRepMovement_RotationQuantizationLevel_SET(FRepMovement* Ptr, ERotatorQuantization Value) { Ptr->RotationQuantizationLevel = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepMovement_VelocityQuantizationLevel_GET(FRepMovement* Ptr) { return Ptr->VelocityQuantizationLevel; }
	DOTNET_EXPORT void E_PROP_FRepMovement_VelocityQuantizationLevel_SET(FRepMovement* Ptr, EVectorQuantization Value) { Ptr->VelocityQuantizationLevel = Value; }
	
	DOTNET_EXPORT auto E_FRepMovement_CopyTo(FRepMovement* Self, INT_PTR RBState, AActor* Actor)
	{
		auto _p0 = *(FRigidBodyState*)RBState;
		auto _p1 = Actor;
		Self->CopyTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FRepMovement_FillFrom(FRepMovement* Self, INT_PTR RBState, AActor* Actor)
	{
		auto _p0 = *(FRigidBodyState*)RBState;
		auto _p1 = Actor;
		Self->FillFrom(_p0, _p1);
	}

	
	/*	FRepRootMotionMontage	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRepRootMotionMontage() { return (INT_PTR) new FRepRootMotionMontage(); }
	
	DOTNET_EXPORT auto E_PROP_FRepRootMotionMontage_bIsActive_GET(FRepRootMotionMontage* Ptr) { return Ptr->bIsActive; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_bIsActive_SET(FRepRootMotionMontage* Ptr, bool Value) { Ptr->bIsActive = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepRootMotionMontage_bRelativePosition_GET(FRepRootMotionMontage* Ptr) { return Ptr->bRelativePosition; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_bRelativePosition_SET(FRepRootMotionMontage* Ptr, bool Value) { Ptr->bRelativePosition = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepRootMotionMontage_bRelativeRotation_GET(FRepRootMotionMontage* Ptr) { return Ptr->bRelativeRotation; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_bRelativeRotation_SET(FRepRootMotionMontage* Ptr, bool Value) { Ptr->bRelativeRotation = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepRootMotionMontage_MovementBase_GET(FRepRootMotionMontage* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->MovementBase); }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_MovementBase_SET(FRepRootMotionMontage* Ptr, UPrimitiveComponent* Value) { Ptr->MovementBase = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepRootMotionMontage_MovementBaseBoneName_GET(FRepRootMotionMontage* Ptr) { return ConvertToManage_StringWrapper(Ptr->MovementBaseBoneName); }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_MovementBaseBoneName_SET(FRepRootMotionMontage* Ptr, char* Value) { Ptr->MovementBaseBoneName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FRepRootMotionMontage_Position_GET(FRepRootMotionMontage* Ptr) { return Ptr->Position; }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_Position_SET(FRepRootMotionMontage* Ptr, float Value) { Ptr->Position = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRepRootMotionMontage_Rotation_GET(FRepRootMotionMontage* Ptr) { return (INT_PTR)&(Ptr->Rotation); }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_Rotation_SET(FRepRootMotionMontage* Ptr, INT_PTR Value) { Ptr->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_FRepRootMotionMontage_Clear(FRepRootMotionMontage* Self)
	{
		Self->Clear();
	}

	DOTNET_EXPORT auto E_FRepRootMotionMontage_HasRootMotion(FRepRootMotionMontage* Self)
	{
		return Self->HasRootMotion();
	}

	
	/*	FResponseChannel	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FResponseChannel() { return (INT_PTR) new FResponseChannel(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FResponseChannel_FName_ECollisionResponse(char* InChannel, ECollisionResponse InResponse) { return (INT_PTR) new FResponseChannel(ConvertFromManage_FName(InChannel), InResponse); }
	
	DOTNET_EXPORT auto E_PROP_FResponseChannel_Channel_GET(FResponseChannel* Ptr) { return ConvertToManage_StringWrapper(Ptr->Channel); }
	DOTNET_EXPORT void E_PROP_FResponseChannel_Channel_SET(FResponseChannel* Ptr, char* Value) { Ptr->Channel = ConvertFromManage_FName(Value); }
	
	
	/*	FRigidBodyErrorCorrection	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRigidBodyErrorCorrection() { return (INT_PTR) new FRigidBodyErrorCorrection(); }
	
	DOTNET_EXPORT auto E_PROP_FRigidBodyErrorCorrection_AngularDeltaThreshold_GET(FRigidBodyErrorCorrection* Ptr) { return Ptr->AngularDeltaThreshold; }
	DOTNET_EXPORT void E_PROP_FRigidBodyErrorCorrection_AngularDeltaThreshold_SET(FRigidBodyErrorCorrection* Ptr, float Value) { Ptr->AngularDeltaThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRigidBodyErrorCorrection_AngularInterpAlpha_GET(FRigidBodyErrorCorrection* Ptr) { return Ptr->AngularInterpAlpha; }
	DOTNET_EXPORT void E_PROP_FRigidBodyErrorCorrection_AngularInterpAlpha_SET(FRigidBodyErrorCorrection* Ptr, float Value) { Ptr->AngularInterpAlpha = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRigidBodyErrorCorrection_AngularRecipFixTime_GET(FRigidBodyErrorCorrection* Ptr) { return Ptr->AngularRecipFixTime; }
	DOTNET_EXPORT void E_PROP_FRigidBodyErrorCorrection_AngularRecipFixTime_SET(FRigidBodyErrorCorrection* Ptr, float Value) { Ptr->AngularRecipFixTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRigidBodyErrorCorrection_BodySpeedThresholdSq_GET(FRigidBodyErrorCorrection* Ptr) { return Ptr->BodySpeedThresholdSq; }
	DOTNET_EXPORT void E_PROP_FRigidBodyErrorCorrection_BodySpeedThresholdSq_SET(FRigidBodyErrorCorrection* Ptr, float Value) { Ptr->BodySpeedThresholdSq = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRigidBodyErrorCorrection_LinearDeltaThresholdSq_GET(FRigidBodyErrorCorrection* Ptr) { return Ptr->LinearDeltaThresholdSq; }
	DOTNET_EXPORT void E_PROP_FRigidBodyErrorCorrection_LinearDeltaThresholdSq_SET(FRigidBodyErrorCorrection* Ptr, float Value) { Ptr->LinearDeltaThresholdSq = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRigidBodyErrorCorrection_LinearInterpAlpha_GET(FRigidBodyErrorCorrection* Ptr) { return Ptr->LinearInterpAlpha; }
	DOTNET_EXPORT void E_PROP_FRigidBodyErrorCorrection_LinearInterpAlpha_SET(FRigidBodyErrorCorrection* Ptr, float Value) { Ptr->LinearInterpAlpha = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRigidBodyErrorCorrection_LinearRecipFixTime_GET(FRigidBodyErrorCorrection* Ptr) { return Ptr->LinearRecipFixTime; }
	DOTNET_EXPORT void E_PROP_FRigidBodyErrorCorrection_LinearRecipFixTime_SET(FRigidBodyErrorCorrection* Ptr, float Value) { Ptr->LinearRecipFixTime = Value; }
	
	
	/*	FRigidBodyState	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRigidBodyState() { return (INT_PTR) new FRigidBodyState(); }
	
	DOTNET_EXPORT auto E_PROP_FRigidBodyState_Flags_GET(FRigidBodyState* Ptr) { return Ptr->Flags; }
	DOTNET_EXPORT void E_PROP_FRigidBodyState_Flags_SET(FRigidBodyState* Ptr, uint8 Value) { Ptr->Flags = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRigidBodyState_Quaternion_GET(FRigidBodyState* Ptr) { return (INT_PTR)&(Ptr->Quaternion); }
	DOTNET_EXPORT void E_PROP_FRigidBodyState_Quaternion_SET(FRigidBodyState* Ptr, INT_PTR Value) { Ptr->Quaternion = *(FQuat*)Value; }
	
	
	/*	FRotationConversionCache	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotationConversionCache() { return (INT_PTR) new FRotationConversionCache(); }
	
	DOTNET_EXPORT auto E_FRotationConversionCache_GetCachedQuat(FRotationConversionCache* Self)
	{
		return (INT_PTR) new FQuat(Self->GetCachedQuat());
	}

	DOTNET_EXPORT auto E_FRotationConversionCache_GetCachedRotator(FRotationConversionCache* Self)
	{
		return (INT_PTR) new FRotator(Self->GetCachedRotator());
	}

	DOTNET_EXPORT auto E_FRotationConversionCache_NormalizedQuatToRotator(FRotationConversionCache* Self, INT_PTR InNormalizedQuat)
	{
		auto _p0 = *(FQuat*)InNormalizedQuat;
		return (INT_PTR) new FRotator(Self->NormalizedQuatToRotator(_p0));
	}

	DOTNET_EXPORT auto E_FRotationConversionCache_NormalizedQuatToRotator_ReadOnly(FRotationConversionCache* Self, INT_PTR InNormalizedQuat)
	{
		auto _p0 = *(FQuat*)InNormalizedQuat;
		return (INT_PTR) new FRotator(Self->NormalizedQuatToRotator_ReadOnly(_p0));
	}

	DOTNET_EXPORT auto E_FRotationConversionCache_QuatToRotator(FRotationConversionCache* Self, INT_PTR InQuat)
	{
		auto _p0 = *(FQuat*)InQuat;
		return (INT_PTR) new FRotator(Self->QuatToRotator(_p0));
	}

	DOTNET_EXPORT auto E_FRotationConversionCache_QuatToRotator_ReadOnly(FRotationConversionCache* Self, INT_PTR InQuat)
	{
		auto _p0 = *(FQuat*)InQuat;
		return (INT_PTR) new FRotator(Self->QuatToRotator_ReadOnly(_p0));
	}

	DOTNET_EXPORT auto E_FRotationConversionCache_RotatorToQuat(FRotationConversionCache* Self, INT_PTR InRotator)
	{
		auto _p0 = *(FRotator*)InRotator;
		return (INT_PTR) new FQuat(Self->RotatorToQuat(_p0));
	}

	DOTNET_EXPORT auto E_FRotationConversionCache_RotatorToQuat_ReadOnly(FRotationConversionCache* Self, INT_PTR InRotator)
	{
		auto _p0 = *(FRotator*)InRotator;
		return (INT_PTR) new FQuat(Self->RotatorToQuat_ReadOnly(_p0));
	}

	
	/*	FRotator	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator() { return (INT_PTR) new FRotator(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator_float(float InF) { return (INT_PTR) new FRotator(InF); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator_float_float_float(float InPitch, float InYaw, float InRoll) { return (INT_PTR) new FRotator(InPitch, InYaw, InRoll); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator_FQuat(INT_PTR Quat) { return (INT_PTR) new FRotator(*(FQuat*)Quat); }
	
	DOTNET_EXPORT auto E_PROP_FRotator_Pitch_GET(FRotator* Ptr) { return Ptr->Pitch; }
	DOTNET_EXPORT void E_PROP_FRotator_Pitch_SET(FRotator* Ptr, float Value) { Ptr->Pitch = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRotator_Roll_GET(FRotator* Ptr) { return Ptr->Roll; }
	DOTNET_EXPORT void E_PROP_FRotator_Roll_SET(FRotator* Ptr, float Value) { Ptr->Roll = Value; }
	
	DOTNET_EXPORT auto E_PROP_FRotator_Yaw_GET(FRotator* Ptr) { return Ptr->Yaw; }
	DOTNET_EXPORT void E_PROP_FRotator_Yaw_SET(FRotator* Ptr, float Value) { Ptr->Yaw = Value; }
	
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
		return Self->ClampAxis(_p0);
	}

	DOTNET_EXPORT auto E_FRotator_CompressAxisToByte(FRotator* Self, float Angle)
	{
		auto _p0 = Angle;
		return Self->CompressAxisToByte(_p0);
	}

	DOTNET_EXPORT auto E_FRotator_ContainsNaN(FRotator* Self)
	{
		return Self->ContainsNaN();
	}

	DOTNET_EXPORT auto E_FRotator_Equals(FRotator* Self, INT_PTR R, float Tolerance)
	{
		auto _p0 = *(FRotator*)R;
		auto _p1 = Tolerance;
		return Self->Equals(_p0, _p1);
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
		return Self->InitFromString(_p0);
	}

	DOTNET_EXPORT auto E_FRotator_IsNearlyZero(FRotator* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return Self->IsNearlyZero(_p0);
	}

	DOTNET_EXPORT auto E_FRotator_IsZero(FRotator* Self)
	{
		return Self->IsZero();
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
		return Self->NormalizeAxis(_p0);
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

	DOTNET_EXPORT auto E_FRotator_ToCompactString(FRotator* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToCompactString());
	}

	DOTNET_EXPORT auto E_FRotator_ToString(FRotator* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
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
	
	DOTNET_EXPORT auto E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(FSceneCaptureViewInfo* Ptr) { return (INT_PTR)&(Ptr->ViewLocation); }
	DOTNET_EXPORT void E_PROP_FSceneCaptureViewInfo_ViewLocation_SET(FSceneCaptureViewInfo* Ptr, INT_PTR Value) { Ptr->ViewLocation = *(FVector*)Value; }
	
	
	/*	FScopedLevelCollectionContextSwitch	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FScopedLevelCollectionContextSwitch_int32_UWorld(int32 InLevelCollectionIndex, UWorld* InWorld) { return (INT_PTR) new FScopedLevelCollectionContextSwitch(InLevelCollectionIndex, InWorld); }
	
	
	/*	FScreenMessageString	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FScreenMessageString() { return (INT_PTR) new FScreenMessageString(); }
	
	DOTNET_EXPORT auto E_PROP_FScreenMessageString_CurrentTimeDisplayed_GET(FScreenMessageString* Ptr) { return Ptr->CurrentTimeDisplayed; }
	DOTNET_EXPORT void E_PROP_FScreenMessageString_CurrentTimeDisplayed_SET(FScreenMessageString* Ptr, float Value) { Ptr->CurrentTimeDisplayed = Value; }
	
	DOTNET_EXPORT auto E_PROP_FScreenMessageString_ScreenMessage_GET(FScreenMessageString* Ptr) { return ConvertToManage_StringWrapper(Ptr->ScreenMessage); }
	DOTNET_EXPORT void E_PROP_FScreenMessageString_ScreenMessage_SET(FScreenMessageString* Ptr, char* Value) { Ptr->ScreenMessage = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FScreenMessageString_TextScale_GET(FScreenMessageString* Ptr) { return (INT_PTR)&(Ptr->TextScale); }
	DOTNET_EXPORT void E_PROP_FScreenMessageString_TextScale_SET(FScreenMessageString* Ptr, INT_PTR Value) { Ptr->TextScale = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FScreenMessageString_TimeToDisplay_GET(FScreenMessageString* Ptr) { return Ptr->TimeToDisplay; }
	DOTNET_EXPORT void E_PROP_FScreenMessageString_TimeToDisplay_SET(FScreenMessageString* Ptr, float Value) { Ptr->TimeToDisplay = Value; }
	
	
	/*	FSimulatedRootMotionReplicatedMove	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSimulatedRootMotionReplicatedMove() { return (INT_PTR) new FSimulatedRootMotionReplicatedMove(); }
	
	DOTNET_EXPORT auto E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_GET(FSimulatedRootMotionReplicatedMove* Ptr) { return (INT_PTR)&(Ptr->RootMotion); }
	DOTNET_EXPORT void E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_SET(FSimulatedRootMotionReplicatedMove* Ptr, INT_PTR Value) { Ptr->RootMotion = *(FRepRootMotionMontage*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSimulatedRootMotionReplicatedMove_Time_GET(FSimulatedRootMotionReplicatedMove* Ptr) { return Ptr->Time; }
	DOTNET_EXPORT void E_PROP_FSimulatedRootMotionReplicatedMove_Time_SET(FSimulatedRootMotionReplicatedMove* Ptr, float Value) { Ptr->Time = Value; }
	
	
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
		return Self->GetSegmentLength(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_FSplineCurves_GetSplineLength(FSplineCurves* Self)
	{
		return Self->GetSplineLength();
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
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_EndOffset_GET(FSplineMeshParams* Ptr) { return (INT_PTR)&(Ptr->EndOffset); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndOffset_SET(FSplineMeshParams* Ptr, INT_PTR Value) { Ptr->EndOffset = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_EndPos_GET(FSplineMeshParams* Ptr) { return (INT_PTR)&(Ptr->EndPos); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndPos_SET(FSplineMeshParams* Ptr, INT_PTR Value) { Ptr->EndPos = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_EndRoll_GET(FSplineMeshParams* Ptr) { return Ptr->EndRoll; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndRoll_SET(FSplineMeshParams* Ptr, float Value) { Ptr->EndRoll = Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_EndScale_GET(FSplineMeshParams* Ptr) { return (INT_PTR)&(Ptr->EndScale); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndScale_SET(FSplineMeshParams* Ptr, INT_PTR Value) { Ptr->EndScale = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_EndTangent_GET(FSplineMeshParams* Ptr) { return (INT_PTR)&(Ptr->EndTangent); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndTangent_SET(FSplineMeshParams* Ptr, INT_PTR Value) { Ptr->EndTangent = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_StartOffset_GET(FSplineMeshParams* Ptr) { return (INT_PTR)&(Ptr->StartOffset); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartOffset_SET(FSplineMeshParams* Ptr, INT_PTR Value) { Ptr->StartOffset = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_StartPos_GET(FSplineMeshParams* Ptr) { return (INT_PTR)&(Ptr->StartPos); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartPos_SET(FSplineMeshParams* Ptr, INT_PTR Value) { Ptr->StartPos = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_StartRoll_GET(FSplineMeshParams* Ptr) { return Ptr->StartRoll; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartRoll_SET(FSplineMeshParams* Ptr, float Value) { Ptr->StartRoll = Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_StartScale_GET(FSplineMeshParams* Ptr) { return (INT_PTR)&(Ptr->StartScale); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartScale_SET(FSplineMeshParams* Ptr, INT_PTR Value) { Ptr->StartScale = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplineMeshParams_StartTangent_GET(FSplineMeshParams* Ptr) { return (INT_PTR)&(Ptr->StartTangent); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartTangent_SET(FSplineMeshParams* Ptr, INT_PTR Value) { Ptr->StartTangent = *(FVector*)Value; }
	
	
	/*	FSplinePoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplinePoint() { return (INT_PTR) new FSplinePoint(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplinePoint_float_FVector(float InInputKey, INT_PTR InPosition) { return (INT_PTR) new FSplinePoint(InInputKey, *(FVector*)InPosition); }
	
	DOTNET_EXPORT auto E_PROP_FSplinePoint_ArriveTangent_GET(FSplinePoint* Ptr) { return (INT_PTR)&(Ptr->ArriveTangent); }
	DOTNET_EXPORT void E_PROP_FSplinePoint_ArriveTangent_SET(FSplinePoint* Ptr, INT_PTR Value) { Ptr->ArriveTangent = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplinePoint_InputKey_GET(FSplinePoint* Ptr) { return Ptr->InputKey; }
	DOTNET_EXPORT void E_PROP_FSplinePoint_InputKey_SET(FSplinePoint* Ptr, float Value) { Ptr->InputKey = Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplinePoint_LeaveTangent_GET(FSplinePoint* Ptr) { return (INT_PTR)&(Ptr->LeaveTangent); }
	DOTNET_EXPORT void E_PROP_FSplinePoint_LeaveTangent_SET(FSplinePoint* Ptr, INT_PTR Value) { Ptr->LeaveTangent = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplinePoint_Position_GET(FSplinePoint* Ptr) { return (INT_PTR)&(Ptr->Position); }
	DOTNET_EXPORT void E_PROP_FSplinePoint_Position_SET(FSplinePoint* Ptr, INT_PTR Value) { Ptr->Position = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplinePoint_Rotation_GET(FSplinePoint* Ptr) { return (INT_PTR)&(Ptr->Rotation); }
	DOTNET_EXPORT void E_PROP_FSplinePoint_Rotation_SET(FSplinePoint* Ptr, INT_PTR Value) { Ptr->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FSplinePoint_Scale_GET(FSplinePoint* Ptr) { return (INT_PTR)&(Ptr->Scale); }
	DOTNET_EXPORT void E_PROP_FSplinePoint_Scale_SET(FSplinePoint* Ptr, INT_PTR Value) { Ptr->Scale = *(FVector*)Value; }
	
	
	/*	FSpriteCategoryInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSpriteCategoryInfo() { return (INT_PTR) new FSpriteCategoryInfo(); }
	
	DOTNET_EXPORT auto E_PROP_FSpriteCategoryInfo_Category_GET(FSpriteCategoryInfo* Ptr) { return ConvertToManage_StringWrapper(Ptr->Category); }
	DOTNET_EXPORT void E_PROP_FSpriteCategoryInfo_Category_SET(FSpriteCategoryInfo* Ptr, char* Value) { Ptr->Category = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FSpriteCategoryInfo_Description_GET(FSpriteCategoryInfo* Ptr) { return ConvertToManage_StringWrapper(Ptr->Description); }
	DOTNET_EXPORT void E_PROP_FSpriteCategoryInfo_Description_SET(FSpriteCategoryInfo* Ptr, char* Value) { Ptr->Description = ConvertFromManage_FText(Value); }
	
	DOTNET_EXPORT auto E_PROP_FSpriteCategoryInfo_DisplayName_GET(FSpriteCategoryInfo* Ptr) { return ConvertToManage_StringWrapper(Ptr->DisplayName); }
	DOTNET_EXPORT void E_PROP_FSpriteCategoryInfo_DisplayName_SET(FSpriteCategoryInfo* Ptr, char* Value) { Ptr->DisplayName = ConvertFromManage_FText(Value); }
	
	
	/*	FStatColorMapEntry	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStatColorMapEntry() { return (INT_PTR) new FStatColorMapEntry(); }
	
	DOTNET_EXPORT auto E_PROP_FStatColorMapEntry_In_GET(FStatColorMapEntry* Ptr) { return Ptr->In; }
	DOTNET_EXPORT void E_PROP_FStatColorMapEntry_In_SET(FStatColorMapEntry* Ptr, float Value) { Ptr->In = Value; }
	
	
	/*	FStatColorMapping	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStatColorMapping() { return (INT_PTR) new FStatColorMapping(); }
	
	DOTNET_EXPORT auto E_PROP_FStatColorMapping_StatName_GET(FStatColorMapping* Ptr) { return ConvertToManage_StringWrapper(Ptr->StatName); }
	DOTNET_EXPORT void E_PROP_FStatColorMapping_StatName_SET(FStatColorMapping* Ptr, char* Value) { Ptr->StatName = ConvertFromManage_FString(Value); }
	
	
	/*	FStructRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStructRedirect() { return (INT_PTR) new FStructRedirect(); }
	
	DOTNET_EXPORT auto E_PROP_FStructRedirect_NewStructName_GET(FStructRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewStructName); }
	DOTNET_EXPORT void E_PROP_FStructRedirect_NewStructName_SET(FStructRedirect* Ptr, char* Value) { Ptr->NewStructName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FStructRedirect_OldStructName_GET(FStructRedirect* Ptr) { return ConvertToManage_StringWrapper(Ptr->OldStructName); }
	DOTNET_EXPORT void E_PROP_FStructRedirect_OldStructName_SET(FStructRedirect* Ptr, char* Value) { Ptr->OldStructName = ConvertFromManage_FName(Value); }
	
	
	/*	FSubtitleCue	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSubtitleCue() { return (INT_PTR) new FSubtitleCue(); }
	
	DOTNET_EXPORT auto E_PROP_FSubtitleCue_Text_GET(FSubtitleCue* Ptr) { return ConvertToManage_StringWrapper(Ptr->Text); }
	DOTNET_EXPORT void E_PROP_FSubtitleCue_Text_SET(FSubtitleCue* Ptr, char* Value) { Ptr->Text = ConvertFromManage_FText(Value); }
	
	DOTNET_EXPORT auto E_PROP_FSubtitleCue_Time_GET(FSubtitleCue* Ptr) { return Ptr->Time; }
	DOTNET_EXPORT void E_PROP_FSubtitleCue_Time_SET(FSubtitleCue* Ptr, float Value) { Ptr->Time = Value; }
	
	
	/*	FTickFunction	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTickFunction() { return (INT_PTR) new FTickFunction(); }
	
	DOTNET_EXPORT auto E_PROP_FTickFunction_bAllowTickOnDedicatedServer_GET(FTickFunction* Ptr) { return Ptr->bAllowTickOnDedicatedServer; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bAllowTickOnDedicatedServer_SET(FTickFunction* Ptr, uint8 Value) { Ptr->bAllowTickOnDedicatedServer = Value; }
	
	DOTNET_EXPORT auto E_PROP_FTickFunction_bCanEverTick_GET(FTickFunction* Ptr) { return Ptr->bCanEverTick; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bCanEverTick_SET(FTickFunction* Ptr, uint8 Value) { Ptr->bCanEverTick = Value; }
	
	DOTNET_EXPORT auto E_PROP_FTickFunction_bHighPriority_GET(FTickFunction* Ptr) { return Ptr->bHighPriority; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bHighPriority_SET(FTickFunction* Ptr, uint8 Value) { Ptr->bHighPriority = Value; }
	
	DOTNET_EXPORT auto E_PROP_FTickFunction_bRunOnAnyThread_GET(FTickFunction* Ptr) { return Ptr->bRunOnAnyThread; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bRunOnAnyThread_SET(FTickFunction* Ptr, uint8 Value) { Ptr->bRunOnAnyThread = Value; }
	
	DOTNET_EXPORT auto E_PROP_FTickFunction_bStartWithTickEnabled_GET(FTickFunction* Ptr) { return Ptr->bStartWithTickEnabled; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bStartWithTickEnabled_SET(FTickFunction* Ptr, uint8 Value) { Ptr->bStartWithTickEnabled = Value; }
	
	DOTNET_EXPORT auto E_PROP_FTickFunction_bTickEvenWhenPaused_GET(FTickFunction* Ptr) { return Ptr->bTickEvenWhenPaused; }
	DOTNET_EXPORT void E_PROP_FTickFunction_bTickEvenWhenPaused_SET(FTickFunction* Ptr, uint8 Value) { Ptr->bTickEvenWhenPaused = Value; }
	
	DOTNET_EXPORT auto E_PROP_FTickFunction_TickInterval_GET(FTickFunction* Ptr) { return Ptr->TickInterval; }
	DOTNET_EXPORT void E_PROP_FTickFunction_TickInterval_SET(FTickFunction* Ptr, float Value) { Ptr->TickInterval = Value; }
	
	DOTNET_EXPORT auto E_FTickFunction_IsCompletionHandleValid(FTickFunction* Self)
	{
		return Self->IsCompletionHandleValid();
	}

	DOTNET_EXPORT auto E_FTickFunction_IsTickFunctionEnabled(FTickFunction* Self)
	{
		return Self->IsTickFunctionEnabled();
	}

	DOTNET_EXPORT auto E_FTickFunction_IsTickFunctionRegistered(FTickFunction* Self)
	{
		return Self->IsTickFunctionRegistered();
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

	
	/*	FTimeline	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimeline() { return (INT_PTR) new FTimeline(); }
	
	DOTNET_EXPORT auto E_FTimeline_GetPlaybackPosition(FTimeline* Self)
	{
		return Self->GetPlaybackPosition();
	}

	DOTNET_EXPORT auto E_FTimeline_GetPlayRate(FTimeline* Self)
	{
		return Self->GetPlayRate();
	}

	DOTNET_EXPORT auto E_FTimeline_GetTimelineLength(FTimeline* Self)
	{
		return Self->GetTimelineLength();
	}

	DOTNET_EXPORT auto E_FTimeline_IsLooping(FTimeline* Self)
	{
		return Self->IsLooping();
	}

	DOTNET_EXPORT auto E_FTimeline_IsPlaying(FTimeline* Self)
	{
		return Self->IsPlaying();
	}

	DOTNET_EXPORT auto E_FTimeline_IsReversing(FTimeline* Self)
	{
		return Self->IsReversing();
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
	
	DOTNET_EXPORT auto E_PROP_FTimelineEventEntry_Time_GET(FTimelineEventEntry* Ptr) { return Ptr->Time; }
	DOTNET_EXPORT void E_PROP_FTimelineEventEntry_Time_SET(FTimelineEventEntry* Ptr, float Value) { Ptr->Time = Value; }
	
	
	/*	FTimelineFloatTrack	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineFloatTrack() { return (INT_PTR) new FTimelineFloatTrack(); }
	
	DOTNET_EXPORT auto E_PROP_FTimelineFloatTrack_FloatPropertyName_GET(FTimelineFloatTrack* Ptr) { return ConvertToManage_StringWrapper(Ptr->FloatPropertyName); }
	DOTNET_EXPORT void E_PROP_FTimelineFloatTrack_FloatPropertyName_SET(FTimelineFloatTrack* Ptr, char* Value) { Ptr->FloatPropertyName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FTimelineFloatTrack_TrackName_GET(FTimelineFloatTrack* Ptr) { return ConvertToManage_StringWrapper(Ptr->TrackName); }
	DOTNET_EXPORT void E_PROP_FTimelineFloatTrack_TrackName_SET(FTimelineFloatTrack* Ptr, char* Value) { Ptr->TrackName = ConvertFromManage_FName(Value); }
	
	
	/*	FTimelineLinearColorTrack	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineLinearColorTrack() { return (INT_PTR) new FTimelineLinearColorTrack(); }
	
	DOTNET_EXPORT auto E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_GET(FTimelineLinearColorTrack* Ptr) { return ConvertToManage_StringWrapper(Ptr->LinearColorPropertyName); }
	DOTNET_EXPORT void E_PROP_FTimelineLinearColorTrack_LinearColorPropertyName_SET(FTimelineLinearColorTrack* Ptr, char* Value) { Ptr->LinearColorPropertyName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FTimelineLinearColorTrack_TrackName_GET(FTimelineLinearColorTrack* Ptr) { return ConvertToManage_StringWrapper(Ptr->TrackName); }
	DOTNET_EXPORT void E_PROP_FTimelineLinearColorTrack_TrackName_SET(FTimelineLinearColorTrack* Ptr, char* Value) { Ptr->TrackName = ConvertFromManage_FName(Value); }
	
	
	/*	FTimelineVectorTrack	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineVectorTrack() { return (INT_PTR) new FTimelineVectorTrack(); }
	
	DOTNET_EXPORT auto E_PROP_FTimelineVectorTrack_TrackName_GET(FTimelineVectorTrack* Ptr) { return ConvertToManage_StringWrapper(Ptr->TrackName); }
	DOTNET_EXPORT void E_PROP_FTimelineVectorTrack_TrackName_SET(FTimelineVectorTrack* Ptr, char* Value) { Ptr->TrackName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FTimelineVectorTrack_VectorPropertyName_GET(FTimelineVectorTrack* Ptr) { return ConvertToManage_StringWrapper(Ptr->VectorPropertyName); }
	DOTNET_EXPORT void E_PROP_FTimelineVectorTrack_VectorPropertyName_SET(FTimelineVectorTrack* Ptr, char* Value) { Ptr->VectorPropertyName = ConvertFromManage_FName(Value); }
	
	
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
		return Self->AnyHasNegativeScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FTransform_AreRotationsEqual(FTransform* Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return Self->AreRotationsEqual(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FTransform_AreScale3DsEqual(FTransform* Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return Self->AreScale3DsEqual(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FTransform_AreTranslationsEqual(FTransform* Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return Self->AreTranslationsEqual(_p0, _p1, _p2);
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
		return Self->ContainsNaN();
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
		return Self->Equals(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FTransform_EqualsNoScale(FTransform* Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return Self->EqualsNoScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FTransform_GetDeterminant(FTransform* Self)
	{
		return Self->GetDeterminant();
	}

	DOTNET_EXPORT auto E_FTransform_GetLocation(FTransform* Self)
	{
		return (INT_PTR) new FVector(Self->GetLocation());
	}

	DOTNET_EXPORT auto E_FTransform_GetMaximumAxisScale(FTransform* Self)
	{
		return Self->GetMaximumAxisScale();
	}

	DOTNET_EXPORT auto E_FTransform_GetMinimumAxisScale(FTransform* Self)
	{
		return Self->GetMinimumAxisScale();
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

	DOTNET_EXPORT auto E_FTransform_GetTranslation(FTransform* Self)
	{
		return (INT_PTR) new FVector(Self->GetTranslation());
	}

	DOTNET_EXPORT auto E_FTransform_InitFromString(FTransform* Self, char* InSourceString)
	{
		auto _p0 = ConvertFromManage_FString(InSourceString);
		return Self->InitFromString(_p0);
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

	DOTNET_EXPORT auto E_FTransform_InverseTransformRotation(FTransform* Self, INT_PTR Q)
	{
		auto _p0 = *(FQuat*)Q;
		return (INT_PTR) new FQuat(Self->InverseTransformRotation(_p0));
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
		return Self->IsRotationNormalized();
	}

	DOTNET_EXPORT auto E_FTransform_IsValid(FTransform* Self)
	{
		return Self->IsValid();
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
		return Self->RotationEquals(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FTransform_Rotator(FTransform* Self)
	{
		return (INT_PTR) new FRotator(Self->Rotator());
	}

	DOTNET_EXPORT auto E_FTransform_Scale3DEquals(FTransform* Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return Self->Scale3DEquals(_p0, _p1);
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

	DOTNET_EXPORT auto E_FTransform_ToHumanReadableString(FTransform* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToHumanReadableString());
	}

	DOTNET_EXPORT auto E_FTransform_ToString(FTransform* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
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

	DOTNET_EXPORT auto E_FTransform_TransformRotation(FTransform* Self, INT_PTR Q)
	{
		auto _p0 = *(FQuat*)Q;
		return (INT_PTR) new FQuat(Self->TransformRotation(_p0));
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
		return Self->TranslationEquals(_p0, _p1);
	}

	
	/*	FURL	*/
	
	DOTNET_EXPORT auto E_PROP_FURL_bDefaultsInitialized_GET() { return FURL::bDefaultsInitialized; }
	
	DOTNET_EXPORT auto E_PROP_FURL_Host_GET(FURL* Ptr) { return ConvertToManage_StringWrapper(Ptr->Host); }
	DOTNET_EXPORT void E_PROP_FURL_Host_SET(FURL* Ptr, char* Value) { Ptr->Host = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FURL_Map_GET(FURL* Ptr) { return ConvertToManage_StringWrapper(Ptr->Map); }
	DOTNET_EXPORT void E_PROP_FURL_Map_SET(FURL* Ptr, char* Value) { Ptr->Map = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FURL_Port_GET(FURL* Ptr) { return Ptr->Port; }
	DOTNET_EXPORT void E_PROP_FURL_Port_SET(FURL* Ptr, int32 Value) { Ptr->Port = Value; }
	
	DOTNET_EXPORT auto E_PROP_FURL_Portal_GET(FURL* Ptr) { return ConvertToManage_StringWrapper(Ptr->Portal); }
	DOTNET_EXPORT void E_PROP_FURL_Portal_SET(FURL* Ptr, char* Value) { Ptr->Portal = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FURL_Protocol_GET(FURL* Ptr) { return ConvertToManage_StringWrapper(Ptr->Protocol); }
	DOTNET_EXPORT void E_PROP_FURL_Protocol_SET(FURL* Ptr, char* Value) { Ptr->Protocol = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FURL_RedirectURL_GET(FURL* Ptr) { return ConvertToManage_StringWrapper(Ptr->RedirectURL); }
	DOTNET_EXPORT void E_PROP_FURL_RedirectURL_SET(FURL* Ptr, char* Value) { Ptr->RedirectURL = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FURL_Valid_GET(FURL* Ptr) { return Ptr->Valid; }
	DOTNET_EXPORT void E_PROP_FURL_Valid_SET(FURL* Ptr, int32 Value) { Ptr->Valid = Value; }
	
	DOTNET_EXPORT auto E_FURL_FilterURLString(FURL* Self, char* Str)
	{
		auto _p0 = ConvertFromManage_FString(Str);
		Self->FilterURLString(_p0);
	}

	DOTNET_EXPORT auto E_FURL_IsInternal(FURL* Self)
	{
		return Self->IsInternal();
	}

	DOTNET_EXPORT auto E_FURL_IsLocalInternal(FURL* Self)
	{
		return Self->IsLocalInternal();
	}

	DOTNET_EXPORT auto E_FURL_StaticExit(FURL* Self)
	{
		Self->StaticExit();
	}

	DOTNET_EXPORT auto E_FURL_StaticInit(FURL* Self)
	{
		Self->StaticInit();
	}

	
	/*	FUserActivity	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FUserActivity() { return (INT_PTR) new FUserActivity(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FUserActivity_FString(char* InActionName) { return (INT_PTR) new FUserActivity(ConvertFromManage_FString(InActionName)); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FUserActivity_FString_EUserActivityContext(char* InActionName, EUserActivityContext InContext) { return (INT_PTR) new FUserActivity(ConvertFromManage_FString(InActionName), InContext); }
	
	DOTNET_EXPORT auto E_PROP_FUserActivity_ActionName_GET(FUserActivity* Ptr) { return ConvertToManage_StringWrapper(Ptr->ActionName); }
	DOTNET_EXPORT void E_PROP_FUserActivity_ActionName_SET(FUserActivity* Ptr, char* Value) { Ptr->ActionName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FUserActivity_Context_GET(FUserActivity* Ptr) { return Ptr->Context; }
	DOTNET_EXPORT void E_PROP_FUserActivity_Context_SET(FUserActivity* Ptr, EUserActivityContext Value) { Ptr->Context = Value; }
	
	
	/*	FVector	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector() { return (INT_PTR) new FVector(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_float(float InF) { return (INT_PTR) new FVector(InF); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_float_float_float(float InX, float InY, float InZ) { return (INT_PTR) new FVector(InX, InY, InZ); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_FVector2D_float(INT_PTR V, float InZ) { return (INT_PTR) new FVector(*(FVector2D*)V, InZ); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_FVector4(INT_PTR V) { return (INT_PTR) new FVector(*(FVector4*)V); }
	
	DOTNET_EXPORT auto E_PROP_FVector_X_GET(FVector* Ptr) { return Ptr->X; }
	DOTNET_EXPORT void E_PROP_FVector_X_SET(FVector* Ptr, float Value) { Ptr->X = Value; }
	
	DOTNET_EXPORT auto E_PROP_FVector_Y_GET(FVector* Ptr) { return Ptr->Y; }
	DOTNET_EXPORT void E_PROP_FVector_Y_SET(FVector* Ptr, float Value) { Ptr->Y = Value; }
	
	DOTNET_EXPORT auto E_PROP_FVector_Z_GET(FVector* Ptr) { return Ptr->Z; }
	DOTNET_EXPORT void E_PROP_FVector_Z_SET(FVector* Ptr, float Value) { Ptr->Z = Value; }
	
	DOTNET_EXPORT auto E_FVector_AddBounded(FVector* Self, INT_PTR V, float Radius)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = Radius;
		Self->AddBounded(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_AllComponentsEqual(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return Self->AllComponentsEqual(_p0);
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
		return Self->BoxPushOut(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_Coincident(FVector* Self, INT_PTR Normal1, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		auto _p2 = ParallelCosineThreshold;
		return Self->Coincident(_p0, _p1, _p2);
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
		return Self->ContainsNaN();
	}

	DOTNET_EXPORT auto E_FVector_Coplanar(FVector* Self, INT_PTR Base1, INT_PTR Normal1, INT_PTR Base2, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Base1;
		auto _p1 = *(FVector*)Normal1;
		auto _p2 = *(FVector*)Base2;
		auto _p3 = *(FVector*)Normal2;
		auto _p4 = ParallelCosineThreshold;
		return Self->Coplanar(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_FVector_CosineAngle2D(FVector* Self, INT_PTR B)
	{
		auto _p0 = *(FVector*)B;
		return Self->CosineAngle2D(_p0);
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
		return Self->Dist(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_Dist2D(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->Dist2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_Distance(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->Distance(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_DistSquared(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->DistSquared(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_DistSquared2D(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->DistSquared2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_DistSquaredXY(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->DistSquaredXY(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_DistXY(FVector* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->DistXY(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_DotProduct(FVector* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return Self->DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector_Equals(FVector* Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = Tolerance;
		return Self->Equals(_p0, _p1);
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
		return Self->GetAbsMax();
	}

	DOTNET_EXPORT auto E_FVector_GetAbsMin(FVector* Self)
	{
		return Self->GetAbsMin();
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
		return Self->GetMax();
	}

	DOTNET_EXPORT auto E_FVector_GetMin(FVector* Self)
	{
		return Self->GetMin();
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
		return Self->HeadingAngle();
	}

	DOTNET_EXPORT auto E_FVector_InitFromString(FVector* Self, char* InSourceString)
	{
		auto _p0 = ConvertFromManage_FString(InSourceString);
		return Self->InitFromString(_p0);
	}

	DOTNET_EXPORT auto E_FVector_IsNearlyZero(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return Self->IsNearlyZero(_p0);
	}

	DOTNET_EXPORT auto E_FVector_IsNormalized(FVector* Self)
	{
		return Self->IsNormalized();
	}

	DOTNET_EXPORT auto E_FVector_IsUniform(FVector* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return Self->IsUniform(_p0);
	}

	DOTNET_EXPORT auto E_FVector_IsUnit(FVector* Self, float LengthSquaredTolerance)
	{
		auto _p0 = LengthSquaredTolerance;
		return Self->IsUnit(_p0);
	}

	DOTNET_EXPORT auto E_FVector_IsZero(FVector* Self)
	{
		return Self->IsZero();
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
		return Self->Normalize(_p0);
	}

	DOTNET_EXPORT auto E_FVector_Orthogonal(FVector* Self, INT_PTR Normal1, INT_PTR Normal2, float OrthogonalCosineThreshold)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		auto _p2 = OrthogonalCosineThreshold;
		return Self->Orthogonal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FVector_Parallel(FVector* Self, INT_PTR Normal1, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		auto _p2 = ParallelCosineThreshold;
		return Self->Parallel(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FVector_PointPlaneDist(FVector* Self, INT_PTR Point, INT_PTR PlaneBase, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)PlaneBase;
		auto _p2 = *(FVector*)PlaneNormal;
		return Self->PointPlaneDist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FVector_PointsAreNear(FVector* Self, INT_PTR Point1, INT_PTR Point2, float Dist)
	{
		auto _p0 = *(FVector*)Point1;
		auto _p1 = *(FVector*)Point2;
		auto _p2 = Dist;
		return Self->PointsAreNear(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FVector_PointsAreSame(FVector* Self, INT_PTR P, INT_PTR Q)
	{
		auto _p0 = *(FVector*)P;
		auto _p1 = *(FVector*)Q;
		return Self->PointsAreSame(_p0, _p1);
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

	DOTNET_EXPORT auto E_FVector_Set(FVector* Self, float InX, float InY, float InZ)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		Self->Set(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FVector_Size(FVector* Self)
	{
		return Self->Size();
	}

	DOTNET_EXPORT auto E_FVector_Size2D(FVector* Self)
	{
		return Self->Size2D();
	}

	DOTNET_EXPORT auto E_FVector_SizeSquared(FVector* Self)
	{
		return Self->SizeSquared();
	}

	DOTNET_EXPORT auto E_FVector_SizeSquared2D(FVector* Self)
	{
		return Self->SizeSquared2D();
	}

	DOTNET_EXPORT auto E_FVector_ToCompactString(FVector* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToCompactString());
	}

	DOTNET_EXPORT auto E_FVector_ToCompactText(FVector* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToCompactText());
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

	DOTNET_EXPORT auto E_FVector_ToString(FVector* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
	}

	DOTNET_EXPORT auto E_FVector_ToText(FVector* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToText());
	}

	DOTNET_EXPORT auto E_FVector_Triple(FVector* Self, INT_PTR X, INT_PTR Y, INT_PTR Z)
	{
		auto _p0 = *(FVector*)X;
		auto _p1 = *(FVector*)Y;
		auto _p2 = *(FVector*)Z;
		return Self->Triple(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_FVector_UnitCartesianToSpherical(FVector* Self)
	{
		return (INT_PTR) new FVector2D(Self->UnitCartesianToSpherical());
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
	
	DOTNET_EXPORT auto E_PROP_FVector2D_X_GET(FVector2D* Ptr) { return Ptr->X; }
	DOTNET_EXPORT void E_PROP_FVector2D_X_SET(FVector2D* Ptr, float Value) { Ptr->X = Value; }
	
	DOTNET_EXPORT auto E_PROP_FVector2D_Y_GET(FVector2D* Ptr) { return Ptr->Y; }
	DOTNET_EXPORT void E_PROP_FVector2D_Y_SET(FVector2D* Ptr, float Value) { Ptr->Y = Value; }
	
	DOTNET_EXPORT auto E_FVector2D_ClampAxes(FVector2D* Self, float MinAxisVal, float MaxAxisVal)
	{
		auto _p0 = MinAxisVal;
		auto _p1 = MaxAxisVal;
		return (INT_PTR) new FVector2D(Self->ClampAxes(_p0, _p1));
	}

	DOTNET_EXPORT auto E_FVector2D_ContainsNaN(FVector2D* Self)
	{
		return Self->ContainsNaN();
	}

	DOTNET_EXPORT auto E_FVector2D_CrossProduct(FVector2D* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return Self->CrossProduct(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector2D_DiagnosticCheckNaN(FVector2D* Self)
	{
		Self->DiagnosticCheckNaN();
	}

	DOTNET_EXPORT auto E_FVector2D_Distance(FVector2D* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector2D*)V1;
		auto _p1 = *(FVector2D*)V2;
		return Self->Distance(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector2D_DistSquared(FVector2D* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector2D*)V1;
		auto _p1 = *(FVector2D*)V2;
		return Self->DistSquared(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector2D_DotProduct(FVector2D* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return Self->DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector2D_Equals(FVector2D* Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector2D*)V;
		auto _p1 = Tolerance;
		return Self->Equals(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector2D_GetAbs(FVector2D* Self)
	{
		return (INT_PTR) new FVector2D(Self->GetAbs());
	}

	DOTNET_EXPORT auto E_FVector2D_GetAbsMax(FVector2D* Self)
	{
		return Self->GetAbsMax();
	}

	DOTNET_EXPORT auto E_FVector2D_GetMax(FVector2D* Self)
	{
		return Self->GetMax();
	}

	DOTNET_EXPORT auto E_FVector2D_GetMin(FVector2D* Self)
	{
		return Self->GetMin();
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
		return Self->InitFromString(_p0);
	}

	DOTNET_EXPORT auto E_FVector2D_IsNearlyZero(FVector2D* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return Self->IsNearlyZero(_p0);
	}

	DOTNET_EXPORT auto E_FVector2D_IsZero(FVector2D* Self)
	{
		return Self->IsZero();
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

	DOTNET_EXPORT auto E_FVector2D_Set(FVector2D* Self, float InX, float InY)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		Self->Set(_p0, _p1);
	}

	DOTNET_EXPORT auto E_FVector2D_Size(FVector2D* Self)
	{
		return Self->Size();
	}

	DOTNET_EXPORT auto E_FVector2D_SizeSquared(FVector2D* Self)
	{
		return Self->SizeSquared();
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

	DOTNET_EXPORT auto E_FVector2D_ToString(FVector2D* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
	}

	
	/*	FVector4	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector4_FVector_float(INT_PTR InVector, float InW) { return (INT_PTR) new FVector4(*(FVector*)InVector, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector4_float_float_float_float(float InX, float InY, float InZ, float InW) { return (INT_PTR) new FVector4(InX, InY, InZ, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector4_FVector2D_FVector2D(INT_PTR InXY, INT_PTR InZW) { return (INT_PTR) new FVector4(*(FVector2D*)InXY, *(FVector2D*)InZW); }
	
	DOTNET_EXPORT auto E_PROP_FVector4_W_GET(FVector4* Ptr) { return Ptr->W; }
	DOTNET_EXPORT void E_PROP_FVector4_W_SET(FVector4* Ptr, float Value) { Ptr->W = Value; }
	
	DOTNET_EXPORT auto E_PROP_FVector4_X_GET(FVector4* Ptr) { return Ptr->X; }
	DOTNET_EXPORT void E_PROP_FVector4_X_SET(FVector4* Ptr, float Value) { Ptr->X = Value; }
	
	DOTNET_EXPORT auto E_PROP_FVector4_Y_GET(FVector4* Ptr) { return Ptr->Y; }
	DOTNET_EXPORT void E_PROP_FVector4_Y_SET(FVector4* Ptr, float Value) { Ptr->Y = Value; }
	
	DOTNET_EXPORT auto E_PROP_FVector4_Z_GET(FVector4* Ptr) { return Ptr->Z; }
	DOTNET_EXPORT void E_PROP_FVector4_Z_SET(FVector4* Ptr, float Value) { Ptr->Z = Value; }
	
	DOTNET_EXPORT auto E_FVector4_ContainsNaN(FVector4* Self)
	{
		return Self->ContainsNaN();
	}

	DOTNET_EXPORT auto E_FVector4_DiagnosticCheckNaN(FVector4* Self)
	{
		Self->DiagnosticCheckNaN();
	}

	DOTNET_EXPORT auto E_FVector4_Equals(FVector4* Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector4*)V;
		auto _p1 = Tolerance;
		return Self->Equals(_p0, _p1);
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
		return Self->InitFromString(_p0);
	}

	DOTNET_EXPORT auto E_FVector4_IsNearlyZero3(FVector4* Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return Self->IsNearlyZero3(_p0);
	}

	DOTNET_EXPORT auto E_FVector4_IsUnit3(FVector4* Self, float LengthSquaredTolerance)
	{
		auto _p0 = LengthSquaredTolerance;
		return Self->IsUnit3(_p0);
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
		return Self->Size();
	}

	DOTNET_EXPORT auto E_FVector4_Size3(FVector4* Self)
	{
		return Self->Size3();
	}

	DOTNET_EXPORT auto E_FVector4_SizeSquared(FVector4* Self)
	{
		return Self->SizeSquared();
	}

	DOTNET_EXPORT auto E_FVector4_SizeSquared3(FVector4* Self)
	{
		return Self->SizeSquared3();
	}

	DOTNET_EXPORT auto E_FVector4_ToOrientationQuat(FVector4* Self)
	{
		return (INT_PTR) new FQuat(Self->ToOrientationQuat());
	}

	DOTNET_EXPORT auto E_FVector4_ToOrientationRotator(FVector4* Self)
	{
		return (INT_PTR) new FRotator(Self->ToOrientationRotator());
	}

	DOTNET_EXPORT auto E_FVector4_ToString(FVector4* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
	}

	
	/*	FWalkableSlopeOverride	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWalkableSlopeOverride() { return (INT_PTR) new FWalkableSlopeOverride(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWalkableSlopeOverride_EWalkableSlopeBehavior_float(EWalkableSlopeBehavior NewSlopeBehavior, float NewSlopeAngle) { return (INT_PTR) new FWalkableSlopeOverride(NewSlopeBehavior, NewSlopeAngle); }
	
	DOTNET_EXPORT auto E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_GET(FWalkableSlopeOverride* Ptr) { return Ptr->WalkableSlopeAngle; }
	DOTNET_EXPORT void E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_SET(FWalkableSlopeOverride* Ptr, float Value) { Ptr->WalkableSlopeAngle = Value; }
	
	DOTNET_EXPORT auto E_FWalkableSlopeOverride_GetWalkableSlopeAngle(FWalkableSlopeOverride* Self)
	{
		return Self->GetWalkableSlopeAngle();
	}

	DOTNET_EXPORT auto E_FWalkableSlopeOverride_GetWalkableSlopeBehavior(FWalkableSlopeOverride* Self)
	{
		return Self->GetWalkableSlopeBehavior();
	}

	DOTNET_EXPORT auto E_FWalkableSlopeOverride_ModifyWalkableFloorZ(FWalkableSlopeOverride* Self, float InWalkableFloorZ)
	{
		auto _p0 = InWalkableFloorZ;
		return Self->ModifyWalkableFloorZ(_p0);
	}

	DOTNET_EXPORT auto E_FWalkableSlopeOverride_SetWalkableSlopeAngle(FWalkableSlopeOverride* Self, float NewSlopeAngle)
	{
		auto _p0 = NewSlopeAngle;
		Self->SetWalkableSlopeAngle(_p0);
	}

	DOTNET_EXPORT auto E_FWalkableSlopeOverride_SetWalkableSlopeBehavior(FWalkableSlopeOverride* Self, EWalkableSlopeBehavior NewSlopeBehavior)
	{
		auto _p0 = NewSlopeBehavior;
		Self->SetWalkableSlopeBehavior(_p0);
	}

	
	/*	FWeightedBlendable	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWeightedBlendable() { return (INT_PTR) new FWeightedBlendable(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWeightedBlendable_float_UObject(float InWeight, UObject* InObject) { return (INT_PTR) new FWeightedBlendable(InWeight, InObject); }
	
	DOTNET_EXPORT auto E_PROP_FWeightedBlendable_Object_GET(FWeightedBlendable* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->Object); }
	DOTNET_EXPORT void E_PROP_FWeightedBlendable_Object_SET(FWeightedBlendable* Ptr, UObject* Value) { Ptr->Object = Value; }
	
	DOTNET_EXPORT auto E_PROP_FWeightedBlendable_Weight_GET(FWeightedBlendable* Ptr) { return Ptr->Weight; }
	DOTNET_EXPORT void E_PROP_FWeightedBlendable_Weight_SET(FWeightedBlendable* Ptr, float Value) { Ptr->Weight = Value; }
	
	
	/*	FWeightedBlendables	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWeightedBlendables() { return (INT_PTR) new FWeightedBlendables(); }
	
	
	/*	FWorldContext	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWorldContext() { return (INT_PTR) new FWorldContext(); }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_GET(FWorldContext* Ptr) { return Ptr->bWaitingOnOnlineSubsystem; }
	DOTNET_EXPORT void E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_SET(FWorldContext* Ptr, bool Value) { Ptr->bWaitingOnOnlineSubsystem = Value; }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_ContextHandle_GET(FWorldContext* Ptr) { return ConvertToManage_StringWrapper(Ptr->ContextHandle); }
	DOTNET_EXPORT void E_PROP_FWorldContext_ContextHandle_SET(FWorldContext* Ptr, char* Value) { Ptr->ContextHandle = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_LastRemoteURL_GET(FWorldContext* Ptr) { return (INT_PTR)&(Ptr->LastRemoteURL); }
	DOTNET_EXPORT void E_PROP_FWorldContext_LastRemoteURL_SET(FWorldContext* Ptr, INT_PTR Value) { Ptr->LastRemoteURL = *(FURL*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_LastURL_GET(FWorldContext* Ptr) { return (INT_PTR)&(Ptr->LastURL); }
	DOTNET_EXPORT void E_PROP_FWorldContext_LastURL_SET(FWorldContext* Ptr, INT_PTR Value) { Ptr->LastURL = *(FURL*)Value; }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_PendingMapChangeFailureDescription_GET(FWorldContext* Ptr) { return ConvertToManage_StringWrapper(Ptr->PendingMapChangeFailureDescription); }
	DOTNET_EXPORT void E_PROP_FWorldContext_PendingMapChangeFailureDescription_SET(FWorldContext* Ptr, char* Value) { Ptr->PendingMapChangeFailureDescription = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_PIEInstance_GET(FWorldContext* Ptr) { return Ptr->PIEInstance; }
	DOTNET_EXPORT void E_PROP_FWorldContext_PIEInstance_SET(FWorldContext* Ptr, int32 Value) { Ptr->PIEInstance = Value; }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_PIEPrefix_GET(FWorldContext* Ptr) { return ConvertToManage_StringWrapper(Ptr->PIEPrefix); }
	DOTNET_EXPORT void E_PROP_FWorldContext_PIEPrefix_SET(FWorldContext* Ptr, char* Value) { Ptr->PIEPrefix = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_RunAsDedicated_GET(FWorldContext* Ptr) { return Ptr->RunAsDedicated; }
	DOTNET_EXPORT void E_PROP_FWorldContext_RunAsDedicated_SET(FWorldContext* Ptr, bool Value) { Ptr->RunAsDedicated = Value; }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_TravelType_GET(FWorldContext* Ptr) { return Ptr->TravelType; }
	DOTNET_EXPORT void E_PROP_FWorldContext_TravelType_SET(FWorldContext* Ptr, uint8 Value) { Ptr->TravelType = Value; }
	
	DOTNET_EXPORT auto E_PROP_FWorldContext_TravelURL_GET(FWorldContext* Ptr) { return ConvertToManage_StringWrapper(Ptr->TravelURL); }
	DOTNET_EXPORT void E_PROP_FWorldContext_TravelURL_SET(FWorldContext* Ptr, char* Value) { Ptr->TravelURL = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_FWorldContext_SetCurrentWorld(FWorldContext* Self, UWorld* World)
	{
		auto _p0 = World;
		Self->SetCurrentWorld(_p0);
	}

	DOTNET_EXPORT auto E_FWorldContext_World(FWorldContext* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->World());
	}

}
