#pragma once

#include "CoreMinimal.h"
#include "Components/SkinnedMeshComponent.h"
#include "Engine/EngineBaseTypes.h"
#include "Engine/World.h"
#include "Components/SkeletalMeshComponent.h"
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
	
	DOTNET_EXPORT bool E_FActorSpawnParameters_IsRemoteOwned(INT_PTR Self)
	{
		return ((FActorSpawnParameters*)Self)->IsRemoteOwned();
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FAnimationEvaluationContext_RootBoneTranslation_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FAnimationEvaluationContext*)Ptr)->RootBoneTranslation); }
	DOTNET_EXPORT void E_PROP_FAnimationEvaluationContext_RootBoneTranslation_SET(INT_PTR Ptr, INT_PTR Value) { ((FAnimationEvaluationContext*)Ptr)->RootBoneTranslation = *(FVector*)Value; }
	
	DOTNET_EXPORT void E_FAnimationEvaluationContext_Clear(INT_PTR Self)
	{
		((FAnimationEvaluationContext*)Self)->Clear();
	}

	DOTNET_EXPORT void E_FAnimationEvaluationContext_Copy(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FAnimationEvaluationContext*)Other;
		((FAnimationEvaluationContext*)Self)->Copy(_p0);
	}

	
	/*	FAudioComponentParam	*/
	
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FBasedMovementInfo_Rotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((FBasedMovementInfo*)Ptr)->Rotation); }
	DOTNET_EXPORT void E_PROP_FBasedMovementInfo_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FBasedMovementInfo*)Ptr)->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT bool E_FBasedMovementInfo_HasRelativeLocation(INT_PTR Self)
	{
		return ((FBasedMovementInfo*)Self)->HasRelativeLocation();
	}

	DOTNET_EXPORT bool E_FBasedMovementInfo_HasRelativePosition(INT_PTR Self)
	{
		return ((FBasedMovementInfo*)Self)->HasRelativePosition();
	}

	DOTNET_EXPORT bool E_FBasedMovementInfo_HasRelativeRotation(INT_PTR Self)
	{
		return ((FBasedMovementInfo*)Self)->HasRelativeRotation();
	}

	DOTNET_EXPORT bool E_FBasedMovementInfo_IsBaseUnresolved(INT_PTR Self)
	{
		return ((FBasedMovementInfo*)Self)->IsBaseUnresolved();
	}

	
	/*	FBatchedLine	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBatchedLine() { return (INT_PTR) new FBatchedLine(); }
	
	DOTNET_EXPORT uint8 E_PROP_FBatchedLine_DepthPriority_GET(INT_PTR Ptr) { return ((FBatchedLine*)Ptr)->DepthPriority; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_DepthPriority_SET(INT_PTR Ptr, uint8 Value) { ((FBatchedLine*)Ptr)->DepthPriority = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBatchedLine_End_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FBatchedLine*)Ptr)->End); }
	DOTNET_EXPORT void E_PROP_FBatchedLine_End_SET(INT_PTR Ptr, INT_PTR Value) { ((FBatchedLine*)Ptr)->End = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FBatchedLine_RemainingLifeTime_GET(INT_PTR Ptr) { return ((FBatchedLine*)Ptr)->RemainingLifeTime; }
	DOTNET_EXPORT void E_PROP_FBatchedLine_RemainingLifeTime_SET(INT_PTR Ptr, float Value) { ((FBatchedLine*)Ptr)->RemainingLifeTime = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBatchedLine_Start_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FBatchedLine*)Ptr)->Start); }
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FBatchedPoint_Position_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FBatchedPoint*)Ptr)->Position); }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_Position_SET(INT_PTR Ptr, INT_PTR Value) { ((FBatchedPoint*)Ptr)->Position = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FBatchedPoint_RemainingLifeTime_GET(INT_PTR Ptr) { return ((FBatchedPoint*)Ptr)->RemainingLifeTime; }
	DOTNET_EXPORT void E_PROP_FBatchedPoint_RemainingLifeTime_SET(INT_PTR Ptr, float Value) { ((FBatchedPoint*)Ptr)->RemainingLifeTime = Value; }
	
	
	/*	FBox	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox() { return (INT_PTR) new FBox(); }
	
	DOTNET_EXPORT uint8 E_PROP_FBox_IsValid_GET(INT_PTR Ptr) { return ((FBox*)Ptr)->IsValid; }
	DOTNET_EXPORT void E_PROP_FBox_IsValid_SET(INT_PTR Ptr, uint8 Value) { ((FBox*)Ptr)->IsValid = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBox_Max_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FBox*)Ptr)->Max); }
	DOTNET_EXPORT void E_PROP_FBox_Max_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox*)Ptr)->Max = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBox_Min_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FBox*)Ptr)->Min); }
	DOTNET_EXPORT void E_PROP_FBox_Min_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox*)Ptr)->Min = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_FBox_BuildAABB(INT_PTR Self, INT_PTR Origin, INT_PTR Extent)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = *(FVector*)Extent;
		return (INT_PTR) new FBox(((FBox*)Self)->BuildAABB(_p0, _p1));
	}

	DOTNET_EXPORT float E_FBox_ComputeSquaredDistanceToPoint(INT_PTR Self, INT_PTR Point)
	{
		auto _p0 = *(FVector*)Point;
		return ((FBox*)Self)->ComputeSquaredDistanceToPoint(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FBox_GetCenter(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FBox*)Self)->GetCenter());
	}

	DOTNET_EXPORT void E_FBox_GetCenterAndExtents(INT_PTR Self, INT_PTR center, INT_PTR Extents)
	{
		auto _p0 = *(FVector*)center;
		auto _p1 = *(FVector*)Extents;
		((FBox*)Self)->GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FBox_GetClosestPointTo(INT_PTR Self, INT_PTR Point)
	{
		auto _p0 = *(FVector*)Point;
		return (INT_PTR) new FVector(((FBox*)Self)->GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FBox_GetExtent(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FBox*)Self)->GetExtent());
	}

	DOTNET_EXPORT INT_PTR E_FBox_GetSize(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FBox*)Self)->GetSize());
	}

	DOTNET_EXPORT float E_FBox_GetVolume(INT_PTR Self)
	{
		return ((FBox*)Self)->GetVolume();
	}

	DOTNET_EXPORT void E_FBox_Init(INT_PTR Self)
	{
		((FBox*)Self)->Init();
	}

	DOTNET_EXPORT bool E_FBox_Intersect(INT_PTR Self, INT_PTR other)
	{
		auto _p0 = *(FBox*)other;
		return ((FBox*)Self)->Intersect(_p0);
	}

	DOTNET_EXPORT bool E_FBox_IntersectXY(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FBox*)Other;
		return ((FBox*)Self)->IntersectXY(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FBox_InverseTransformBy(INT_PTR Self, INT_PTR M)
	{
		auto _p0 = *(FTransform*)M;
		return (INT_PTR) new FBox(((FBox*)Self)->InverseTransformBy(_p0));
	}

	DOTNET_EXPORT bool E_FBox_IsInsideOrOn(INT_PTR Self, INT_PTR In)
	{
		auto _p0 = *(FVector*)In;
		return ((FBox*)Self)->IsInsideOrOn(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FBox_MoveTo(INT_PTR Self, INT_PTR Destination)
	{
		auto _p0 = *(FVector*)Destination;
		return (INT_PTR) new FBox(((FBox*)Self)->MoveTo(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FBox_Overlap(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FBox*)Other;
		return (INT_PTR) new FBox(((FBox*)Self)->Overlap(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FBox_ShiftBy(INT_PTR Self, INT_PTR Offset)
	{
		auto _p0 = *(FVector*)Offset;
		return (INT_PTR) new FBox(((FBox*)Self)->ShiftBy(_p0));
	}

	DOTNET_EXPORT char* E_FBox_ToString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FBox*)Self)->ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	
	/*	FBox2D	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D() { return (INT_PTR) new FBox2D(); }
	
	DOTNET_EXPORT bool E_PROP_FBox2D_bIsValid_GET(INT_PTR Ptr) { return ((FBox2D*)Ptr)->bIsValid; }
	DOTNET_EXPORT void E_PROP_FBox2D_bIsValid_SET(INT_PTR Ptr, bool Value) { ((FBox2D*)Ptr)->bIsValid = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBox2D_Max_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FBox2D*)Ptr)->Max); }
	DOTNET_EXPORT void E_PROP_FBox2D_Max_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox2D*)Ptr)->Max = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FBox2D_Min_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FBox2D*)Ptr)->Min); }
	DOTNET_EXPORT void E_PROP_FBox2D_Min_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox2D*)Ptr)->Min = *(FVector2D*)Value; }
	
	DOTNET_EXPORT float E_FBox2D_ComputeSquaredDistanceToPoint(INT_PTR Self, INT_PTR Point)
	{
		auto _p0 = *(FVector2D*)Point;
		return ((FBox2D*)Self)->ComputeSquaredDistanceToPoint(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FBox2D_ExpandBy(INT_PTR Self, float W)
	{
		auto _p0 = W;
		return (INT_PTR) new FBox2D(((FBox2D*)Self)->ExpandBy(_p0));
	}

	DOTNET_EXPORT float E_FBox2D_GetArea(INT_PTR Self)
	{
		return ((FBox2D*)Self)->GetArea();
	}

	DOTNET_EXPORT INT_PTR E_FBox2D_GetCenter(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((FBox2D*)Self)->GetCenter());
	}

	DOTNET_EXPORT void E_FBox2D_GetCenterAndExtents(INT_PTR Self, INT_PTR center, INT_PTR Extents)
	{
		auto _p0 = *(FVector2D*)center;
		auto _p1 = *(FVector2D*)Extents;
		((FBox2D*)Self)->GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FBox2D_GetClosestPointTo(INT_PTR Self, INT_PTR Point)
	{
		auto _p0 = *(FVector2D*)Point;
		return (INT_PTR) new FVector2D(((FBox2D*)Self)->GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FBox2D_GetExtent(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((FBox2D*)Self)->GetExtent());
	}

	DOTNET_EXPORT INT_PTR E_FBox2D_GetSize(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((FBox2D*)Self)->GetSize());
	}

	DOTNET_EXPORT void E_FBox2D_Init(INT_PTR Self)
	{
		((FBox2D*)Self)->Init();
	}

	DOTNET_EXPORT bool E_FBox2D_Intersect(INT_PTR Self, INT_PTR other)
	{
		auto _p0 = *(FBox2D*)other;
		return ((FBox2D*)Self)->Intersect(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FBox2D_ShiftBy(INT_PTR Self, INT_PTR Offset)
	{
		auto _p0 = *(FVector2D*)Offset;
		return (INT_PTR) new FBox2D(((FBox2D*)Self)->ShiftBy(_p0));
	}

	DOTNET_EXPORT char* E_FBox2D_ToString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FBox2D*)Self)->ToString();
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FClosestPointOnPhysicsAsset*)Ptr)->ClosestWorldPosition); }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_SET(INT_PTR Ptr, INT_PTR Value) { ((FClosestPointOnPhysicsAsset*)Ptr)->ClosestWorldPosition = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FClosestPointOnPhysicsAsset_Distance_GET(INT_PTR Ptr) { return ((FClosestPointOnPhysicsAsset*)Ptr)->Distance; }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_Distance_SET(INT_PTR Ptr, float Value) { ((FClosestPointOnPhysicsAsset*)Ptr)->Distance = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FClosestPointOnPhysicsAsset_Normal_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FClosestPointOnPhysicsAsset*)Ptr)->Normal); }
	DOTNET_EXPORT void E_PROP_FClosestPointOnPhysicsAsset_Normal_SET(INT_PTR Ptr, INT_PTR Value) { ((FClosestPointOnPhysicsAsset*)Ptr)->Normal = *(FVector*)Value; }
	
	
	/*	FClusterNode	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClusterNode() { return (INT_PTR) new FClusterNode(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FClusterNode_BoundMax_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FClusterNode*)Ptr)->BoundMax); }
	DOTNET_EXPORT void E_PROP_FClusterNode_BoundMax_SET(INT_PTR Ptr, INT_PTR Value) { ((FClusterNode*)Ptr)->BoundMax = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FClusterNode_BoundMin_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FClusterNode*)Ptr)->BoundMin); }
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Contrast_GET(INT_PTR Ptr) { return (INT_PTR) new FVector4(((FColorGradePerRangeSettings*)Ptr)->Contrast); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Contrast_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Contrast = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Gain_GET(INT_PTR Ptr) { return (INT_PTR) new FVector4(((FColorGradePerRangeSettings*)Ptr)->Gain); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Gain_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Gain = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Gamma_GET(INT_PTR Ptr) { return (INT_PTR) new FVector4(((FColorGradePerRangeSettings*)Ptr)->Gamma); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Gamma_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Gamma = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Offset_GET(INT_PTR Ptr) { return (INT_PTR) new FVector4(((FColorGradePerRangeSettings*)Ptr)->Offset); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Offset_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Offset = *(FVector4*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradePerRangeSettings_Saturation_GET(INT_PTR Ptr) { return (INT_PTR) new FVector4(((FColorGradePerRangeSettings*)Ptr)->Saturation); }
	DOTNET_EXPORT void E_PROP_FColorGradePerRangeSettings_Saturation_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradePerRangeSettings*)Ptr)->Saturation = *(FVector4*)Value; }
	
	
	/*	FColorGradingSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FColorGradingSettings() { return (INT_PTR) new FColorGradingSettings(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradingSettings_Global_GET(INT_PTR Ptr) { return (INT_PTR) new FColorGradePerRangeSettings(((FColorGradingSettings*)Ptr)->Global); }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Global_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradingSettings*)Ptr)->Global = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradingSettings_Highlights_GET(INT_PTR Ptr) { return (INT_PTR) new FColorGradePerRangeSettings(((FColorGradingSettings*)Ptr)->Highlights); }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Highlights_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradingSettings*)Ptr)->Highlights = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT float E_PROP_FColorGradingSettings_HighlightsMin_GET(INT_PTR Ptr) { return ((FColorGradingSettings*)Ptr)->HighlightsMin; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_HighlightsMin_SET(INT_PTR Ptr, float Value) { ((FColorGradingSettings*)Ptr)->HighlightsMin = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradingSettings_Midtones_GET(INT_PTR Ptr) { return (INT_PTR) new FColorGradePerRangeSettings(((FColorGradingSettings*)Ptr)->Midtones); }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Midtones_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradingSettings*)Ptr)->Midtones = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FColorGradingSettings_Shadows_GET(INT_PTR Ptr) { return (INT_PTR) new FColorGradePerRangeSettings(((FColorGradingSettings*)Ptr)->Shadows); }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_Shadows_SET(INT_PTR Ptr, INT_PTR Value) { ((FColorGradingSettings*)Ptr)->Shadows = *(FColorGradePerRangeSettings*)Value; }
	
	DOTNET_EXPORT float E_PROP_FColorGradingSettings_ShadowsMax_GET(INT_PTR Ptr) { return ((FColorGradingSettings*)Ptr)->ShadowsMax; }
	DOTNET_EXPORT void E_PROP_FColorGradingSettings_ShadowsMax_SET(INT_PTR Ptr, float Value) { ((FColorGradingSettings*)Ptr)->ShadowsMax = Value; }
	
	
	/*	FConvolutionBloomSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FConvolutionBloomSettings() { return (INT_PTR) new FConvolutionBloomSettings(); }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_BufferScale_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->BufferScale; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_BufferScale_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->BufferScale = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FConvolutionBloomSettings_CenterUV_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FConvolutionBloomSettings*)Ptr)->CenterUV); }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_CenterUV_SET(INT_PTR Ptr, INT_PTR Value) { ((FConvolutionBloomSettings*)Ptr)->CenterUV = *(FVector2D*)Value; }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_PreFilterMax_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->PreFilterMax; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_PreFilterMax_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->PreFilterMax = Value; }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_PreFilterMin_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->PreFilterMin; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_PreFilterMin_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->PreFilterMin = Value; }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_PreFilterMult_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->PreFilterMult; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_PreFilterMult_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->PreFilterMult = Value; }
	
	DOTNET_EXPORT float E_PROP_FConvolutionBloomSettings_Size_GET(INT_PTR Ptr) { return ((FConvolutionBloomSettings*)Ptr)->Size; }
	DOTNET_EXPORT void E_PROP_FConvolutionBloomSettings_Size_SET(INT_PTR Ptr, float Value) { ((FConvolutionBloomSettings*)Ptr)->Size = Value; }
	
	
	/*	FDestructibleChunkInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDestructibleChunkInfo() { return (INT_PTR) new FDestructibleChunkInfo(); }
	
	DOTNET_EXPORT int32 E_PROP_FDestructibleChunkInfo_ChunkIndex_GET(INT_PTR Ptr) { return ((FDestructibleChunkInfo*)Ptr)->ChunkIndex; }
	DOTNET_EXPORT void E_PROP_FDestructibleChunkInfo_ChunkIndex_SET(INT_PTR Ptr, int32 Value) { ((FDestructibleChunkInfo*)Ptr)->ChunkIndex = Value; }
	
	
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FDropNoteInfo_Location_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FDropNoteInfo*)Ptr)->Location); }
	DOTNET_EXPORT void E_PROP_FDropNoteInfo_Location_SET(INT_PTR Ptr, INT_PTR Value) { ((FDropNoteInfo*)Ptr)->Location = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FDropNoteInfo_Rotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((FDropNoteInfo*)Ptr)->Rotation); }
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
	
	DOTNET_EXPORT char* E_FExposureSettings_ToString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FExposureSettings*)Self)->ToString();
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FInstancedStaticMeshInstanceData*)Ptr)->LightmapUVBias_DEPRECATED); }
	DOTNET_EXPORT void E_PROP_FInstancedStaticMeshInstanceData_LightmapUVBias_DEPRECATED_SET(INT_PTR Ptr, INT_PTR Value) { ((FInstancedStaticMeshInstanceData*)Ptr)->LightmapUVBias_DEPRECATED = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FInstancedStaticMeshInstanceData*)Ptr)->ShadowmapUVBias_DEPRECATED); }
	DOTNET_EXPORT void E_PROP_FInstancedStaticMeshInstanceData_ShadowmapUVBias_DEPRECATED_SET(INT_PTR Ptr, INT_PTR Value) { ((FInstancedStaticMeshInstanceData*)Ptr)->ShadowmapUVBias_DEPRECATED = *(FVector2D*)Value; }
	
	
	/*	FInstancedStaticMeshMappingInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInstancedStaticMeshMappingInfo() { return (INT_PTR) new FInstancedStaticMeshMappingInfo(); }
	
	
	/*	FInterpControlPoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FInterpControlPoint() { return (INT_PTR) new FInterpControlPoint(); }
	
	DOTNET_EXPORT bool E_PROP_FInterpControlPoint_bPositionIsRelative_GET(INT_PTR Ptr) { return ((FInterpControlPoint*)Ptr)->bPositionIsRelative; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_bPositionIsRelative_SET(INT_PTR Ptr, bool Value) { ((FInterpControlPoint*)Ptr)->bPositionIsRelative = Value; }
	
	DOTNET_EXPORT float E_PROP_FInterpControlPoint_DistanceToNext_GET(INT_PTR Ptr) { return ((FInterpControlPoint*)Ptr)->DistanceToNext; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_DistanceToNext_SET(INT_PTR Ptr, float Value) { ((FInterpControlPoint*)Ptr)->DistanceToNext = Value; }
	
	DOTNET_EXPORT float E_PROP_FInterpControlPoint_Percentage_GET(INT_PTR Ptr) { return ((FInterpControlPoint*)Ptr)->Percentage; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_Percentage_SET(INT_PTR Ptr, float Value) { ((FInterpControlPoint*)Ptr)->Percentage = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FInterpControlPoint_PositionControlPoint_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FInterpControlPoint*)Ptr)->PositionControlPoint); }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_PositionControlPoint_SET(INT_PTR Ptr, INT_PTR Value) { ((FInterpControlPoint*)Ptr)->PositionControlPoint = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FInterpControlPoint_StartTime_GET(INT_PTR Ptr) { return ((FInterpControlPoint*)Ptr)->StartTime; }
	DOTNET_EXPORT void E_PROP_FInterpControlPoint_StartTime_SET(INT_PTR Ptr, float Value) { ((FInterpControlPoint*)Ptr)->StartTime = Value; }
	
	
	/*	FLensBloomSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensBloomSettings() { return (INT_PTR) new FLensBloomSettings(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLensBloomSettings_Convolution_GET(INT_PTR Ptr) { return (INT_PTR) new FConvolutionBloomSettings(((FLensBloomSettings*)Ptr)->Convolution); }
	DOTNET_EXPORT void E_PROP_FLensBloomSettings_Convolution_SET(INT_PTR Ptr, INT_PTR Value) { ((FLensBloomSettings*)Ptr)->Convolution = *(FConvolutionBloomSettings*)Value; }
	
	
	/*	FLensImperfectionSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensImperfectionSettings() { return (INT_PTR) new FLensImperfectionSettings(); }
	
	DOTNET_EXPORT float E_PROP_FLensImperfectionSettings_DirtMaskIntensity_GET(INT_PTR Ptr) { return ((FLensImperfectionSettings*)Ptr)->DirtMaskIntensity; }
	DOTNET_EXPORT void E_PROP_FLensImperfectionSettings_DirtMaskIntensity_SET(INT_PTR Ptr, float Value) { ((FLensImperfectionSettings*)Ptr)->DirtMaskIntensity = Value; }
	
	
	/*	FLensSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensSettings() { return (INT_PTR) new FLensSettings(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLensSettings_Bloom_GET(INT_PTR Ptr) { return (INT_PTR) new FLensBloomSettings(((FLensSettings*)Ptr)->Bloom); }
	DOTNET_EXPORT void E_PROP_FLensSettings_Bloom_SET(INT_PTR Ptr, INT_PTR Value) { ((FLensSettings*)Ptr)->Bloom = *(FLensBloomSettings*)Value; }
	
	DOTNET_EXPORT float E_PROP_FLensSettings_ChromaticAberration_GET(INT_PTR Ptr) { return ((FLensSettings*)Ptr)->ChromaticAberration; }
	DOTNET_EXPORT void E_PROP_FLensSettings_ChromaticAberration_SET(INT_PTR Ptr, float Value) { ((FLensSettings*)Ptr)->ChromaticAberration = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLensSettings_Imperfections_GET(INT_PTR Ptr) { return (INT_PTR) new FLensImperfectionSettings(((FLensSettings*)Ptr)->Imperfections); }
	DOTNET_EXPORT void E_PROP_FLensSettings_Imperfections_SET(INT_PTR Ptr, INT_PTR Value) { ((FLensSettings*)Ptr)->Imperfections = *(FLensImperfectionSettings*)Value; }
	
	
	/*	FLevelStreamingGCHelper	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelStreamingGCHelper() { return (INT_PTR) new FLevelStreamingGCHelper(); }
	
	DOTNET_EXPORT void E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(INT_PTR Self)
	{
		((FLevelStreamingGCHelper*)Self)->AddGarbageCollectorCallback();
	}

	DOTNET_EXPORT int32 E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(INT_PTR Self)
	{
		return ((FLevelStreamingGCHelper*)Self)->GetNumLevelsPendingPurge();
	}

	DOTNET_EXPORT void E_FLevelStreamingGCHelper_PrepareStreamedOutLevelsForGC(INT_PTR Self)
	{
		((FLevelStreamingGCHelper*)Self)->PrepareStreamedOutLevelsForGC();
	}

	DOTNET_EXPORT void E_FLevelStreamingGCHelper_VerifyLevelsGotRemovedByGC(INT_PTR Self)
	{
		((FLevelStreamingGCHelper*)Self)->VerifyLevelsGotRemovedByGC();
	}

	
	/*	FLevelStreamingStatus	*/
	
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
	
	DOTNET_EXPORT float E_PROP_FLevelViewportInfo_CamOrthoZoom_GET(INT_PTR Ptr) { return ((FLevelViewportInfo*)Ptr)->CamOrthoZoom; }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamOrthoZoom_SET(INT_PTR Ptr, float Value) { ((FLevelViewportInfo*)Ptr)->CamOrthoZoom = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLevelViewportInfo_CamPosition_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FLevelViewportInfo*)Ptr)->CamPosition); }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamPosition_SET(INT_PTR Ptr, INT_PTR Value) { ((FLevelViewportInfo*)Ptr)->CamPosition = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FLevelViewportInfo_CamRotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((FLevelViewportInfo*)Ptr)->CamRotation); }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamRotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FLevelViewportInfo*)Ptr)->CamRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT bool E_PROP_FLevelViewportInfo_CamUpdated_GET(INT_PTR Ptr) { return ((FLevelViewportInfo*)Ptr)->CamUpdated; }
	DOTNET_EXPORT void E_PROP_FLevelViewportInfo_CamUpdated_SET(INT_PTR Ptr, bool Value) { ((FLevelViewportInfo*)Ptr)->CamUpdated = Value; }
	
	
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
	
	DOTNET_EXPORT bool E_PROP_FOverlapInfo_bFromSweep_GET(INT_PTR Ptr) { return ((FOverlapInfo*)Ptr)->bFromSweep; }
	DOTNET_EXPORT void E_PROP_FOverlapInfo_bFromSweep_SET(INT_PTR Ptr, bool Value) { ((FOverlapInfo*)Ptr)->bFromSweep = Value; }
	
	DOTNET_EXPORT int32 E_FOverlapInfo_GetBodyIndex(INT_PTR Self)
	{
		return ((FOverlapInfo*)Self)->GetBodyIndex();
	}

	
	/*	FPaintedVertex	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPaintedVertex() { return (INT_PTR) new FPaintedVertex(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FPaintedVertex_Position_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FPaintedVertex*)Ptr)->Position); }
	DOTNET_EXPORT void E_PROP_FPaintedVertex_Position_SET(INT_PTR Ptr, INT_PTR Value) { ((FPaintedVertex*)Ptr)->Position = *(FVector*)Value; }
	
	
	/*	FPlane	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane() { return (INT_PTR) new FPlane(); }
	
	DOTNET_EXPORT float E_PROP_FPlane_W_GET(INT_PTR Ptr) { return ((FPlane*)Ptr)->W; }
	DOTNET_EXPORT void E_PROP_FPlane_W_SET(INT_PTR Ptr, float Value) { ((FPlane*)Ptr)->W = Value; }
	
	DOTNET_EXPORT bool E_FPlane_Equals(INT_PTR Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FPlane*)V;
		auto _p1 = Tolerance;
		return ((FPlane*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FPlane_Flip(INT_PTR Self)
	{
		return (INT_PTR) new FPlane(((FPlane*)Self)->Flip());
	}

	DOTNET_EXPORT float E_FPlane_PlaneDot(INT_PTR Self, INT_PTR P)
	{
		auto _p0 = *(FVector*)P;
		return ((FPlane*)Self)->PlaneDot(_p0);
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
	
	
	/*	FPreCulledStaticMeshSection	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPreCulledStaticMeshSection() { return (INT_PTR) new FPreCulledStaticMeshSection(); }
	
	
	/*	FQuat	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat() { return (INT_PTR) new FQuat(); }
	
	DOTNET_EXPORT float E_PROP_FQuat_W_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->W; }
	DOTNET_EXPORT void E_PROP_FQuat_W_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->W = Value; }
	
	DOTNET_EXPORT float E_PROP_FQuat_X_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->X; }
	DOTNET_EXPORT void E_PROP_FQuat_X_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_PROP_FQuat_Y_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->Y; }
	DOTNET_EXPORT void E_PROP_FQuat_Y_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT float E_PROP_FQuat_Z_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->Z; }
	DOTNET_EXPORT void E_PROP_FQuat_Z_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->Z = Value; }
	
	DOTNET_EXPORT float E_FQuat_AngularDistance(INT_PTR Self, INT_PTR Q)
	{
		auto _p0 = *(FQuat*)Q;
		return ((FQuat*)Self)->AngularDistance(_p0);
	}

	DOTNET_EXPORT void E_FQuat_CalcTangents(INT_PTR Self, INT_PTR PrevP, INT_PTR P, INT_PTR NextP, float Tension, INT_PTR OutTan)
	{
		auto _p0 = *(FQuat*)PrevP;
		auto _p1 = *(FQuat*)P;
		auto _p2 = *(FQuat*)NextP;
		auto _p3 = Tension;
		auto _p4 = *(FQuat*)OutTan;
		((FQuat*)Self)->CalcTangents(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT bool E_FQuat_ContainsNaN(INT_PTR Self)
	{
		return ((FQuat*)Self)->ContainsNaN();
	}

	DOTNET_EXPORT void E_FQuat_EnforceShortestArcWith(INT_PTR Self, INT_PTR OtherQuat)
	{
		auto _p0 = *(FQuat*)OtherQuat;
		((FQuat*)Self)->EnforceShortestArcWith(_p0);
	}

	DOTNET_EXPORT bool E_FQuat_Equals(INT_PTR Self, INT_PTR Q, float Tolerance)
	{
		auto _p0 = *(FQuat*)Q;
		auto _p1 = Tolerance;
		return ((FQuat*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT float E_FQuat_Error(INT_PTR Self, INT_PTR Q1, INT_PTR Q2)
	{
		auto _p0 = *(FQuat*)Q1;
		auto _p1 = *(FQuat*)Q2;
		return ((FQuat*)Self)->Error(_p0, _p1);
	}

	DOTNET_EXPORT float E_FQuat_ErrorAutoNormalize(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		return ((FQuat*)Self)->ErrorAutoNormalize(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Euler(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->Euler());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Exp(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FQuat*)Self)->Exp());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_FastBilerp(INT_PTR Self, INT_PTR P00, INT_PTR P10, INT_PTR P01, INT_PTR P11, float FracX, float FracY)
	{
		auto _p0 = *(FQuat*)P00;
		auto _p1 = *(FQuat*)P10;
		auto _p2 = *(FQuat*)P01;
		auto _p3 = *(FQuat*)P11;
		auto _p4 = FracX;
		auto _p5 = FracY;
		return (INT_PTR) new FQuat(((FQuat*)Self)->FastBilerp(_p0, _p1, _p2, _p3, _p4, _p5));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_FastLerp(INT_PTR Self, INT_PTR A, INT_PTR B, float Alpha)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = Alpha;
		return (INT_PTR) new FQuat(((FQuat*)Self)->FastLerp(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_FindBetween(INT_PTR Self, INT_PTR Vector1, INT_PTR Vector2)
	{
		auto _p0 = *(FVector*)Vector1;
		auto _p1 = *(FVector*)Vector2;
		return (INT_PTR) new FQuat(((FQuat*)Self)->FindBetween(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_FindBetweenNormals(INT_PTR Self, INT_PTR Normal1, INT_PTR Normal2)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		return (INT_PTR) new FQuat(((FQuat*)Self)->FindBetweenNormals(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_FindBetweenVectors(INT_PTR Self, INT_PTR Vector1, INT_PTR Vector2)
	{
		auto _p0 = *(FVector*)Vector1;
		auto _p1 = *(FVector*)Vector2;
		return (INT_PTR) new FQuat(((FQuat*)Self)->FindBetweenVectors(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_GetAxisX(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->GetAxisX());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_GetAxisY(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->GetAxisY());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_GetAxisZ(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->GetAxisZ());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_GetForwardVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->GetForwardVector());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_GetNormalized(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FQuat(((FQuat*)Self)->GetNormalized(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_GetRightVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->GetRightVector());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_GetRotationAxis(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->GetRotationAxis());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_GetUpVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->GetUpVector());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Inverse(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FQuat*)Self)->Inverse());
	}

	DOTNET_EXPORT bool E_FQuat_IsIdentity(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FQuat*)Self)->IsIdentity(_p0);
	}

	DOTNET_EXPORT bool E_FQuat_IsNormalized(INT_PTR Self)
	{
		return ((FQuat*)Self)->IsNormalized();
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Log(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FQuat*)Self)->Log());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_MakeFromEuler(INT_PTR Self, INT_PTR Euler)
	{
		auto _p0 = *(FVector*)Euler;
		return (INT_PTR) new FQuat(((FQuat*)Self)->MakeFromEuler(_p0));
	}

	DOTNET_EXPORT void E_FQuat_Normalize(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		((FQuat*)Self)->Normalize(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FQuat_RotateVector(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FQuat*)Self)->RotateVector(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Rotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FQuat*)Self)->Rotator());
	}

	DOTNET_EXPORT float E_FQuat_Size(INT_PTR Self)
	{
		return ((FQuat*)Self)->Size();
	}

	DOTNET_EXPORT float E_FQuat_SizeSquared(INT_PTR Self)
	{
		return ((FQuat*)Self)->SizeSquared();
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Slerp(INT_PTR Self, INT_PTR Quat1, INT_PTR Quat2, float Slerp)
	{
		auto _p0 = *(FQuat*)Quat1;
		auto _p1 = *(FQuat*)Quat2;
		auto _p2 = Slerp;
		return (INT_PTR) new FQuat(((FQuat*)Self)->Slerp(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Slerp_NotNormalized(INT_PTR Self, INT_PTR Quat1, INT_PTR Quat2, float Slerp)
	{
		auto _p0 = *(FQuat*)Quat1;
		auto _p1 = *(FQuat*)Quat2;
		auto _p2 = Slerp;
		return (INT_PTR) new FQuat(((FQuat*)Self)->Slerp_NotNormalized(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_SlerpFullPath(INT_PTR Self, INT_PTR quat1, INT_PTR quat2, float Alpha)
	{
		auto _p0 = *(FQuat*)quat1;
		auto _p1 = *(FQuat*)quat2;
		auto _p2 = Alpha;
		return (INT_PTR) new FQuat(((FQuat*)Self)->SlerpFullPath(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_SlerpFullPath_NotNormalized(INT_PTR Self, INT_PTR quat1, INT_PTR quat2, float Alpha)
	{
		auto _p0 = *(FQuat*)quat1;
		auto _p1 = *(FQuat*)quat2;
		auto _p2 = Alpha;
		return (INT_PTR) new FQuat(((FQuat*)Self)->SlerpFullPath_NotNormalized(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Squad(INT_PTR Self, INT_PTR quat1, INT_PTR tang1, INT_PTR quat2, INT_PTR tang2, float Alpha)
	{
		auto _p0 = *(FQuat*)quat1;
		auto _p1 = *(FQuat*)tang1;
		auto _p2 = *(FQuat*)quat2;
		auto _p3 = *(FQuat*)tang2;
		auto _p4 = Alpha;
		return (INT_PTR) new FQuat(((FQuat*)Self)->Squad(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_SquadFullPath(INT_PTR Self, INT_PTR quat1, INT_PTR tang1, INT_PTR quat2, INT_PTR tang2, float Alpha)
	{
		auto _p0 = *(FQuat*)quat1;
		auto _p1 = *(FQuat*)tang1;
		auto _p2 = *(FQuat*)quat2;
		auto _p3 = *(FQuat*)tang2;
		auto _p4 = Alpha;
		return (INT_PTR) new FQuat(((FQuat*)Self)->SquadFullPath(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT void E_FQuat_ToAxisAndAngle(INT_PTR Self, INT_PTR Axis, float Angle)
	{
		auto _p0 = *(FVector*)Axis;
		auto _p1 = Angle;
		((FQuat*)Self)->ToAxisAndAngle(_p0, _p1);
	}

	DOTNET_EXPORT char* E_FQuat_ToString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FQuat*)Self)->ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_FQuat_ToSwingTwist(INT_PTR Self, INT_PTR InTwistAxis, INT_PTR OutSwing, INT_PTR OutTwist)
	{
		auto _p0 = *(FVector*)InTwistAxis;
		auto _p1 = *(FQuat*)OutSwing;
		auto _p2 = *(FQuat*)OutTwist;
		((FQuat*)Self)->ToSwingTwist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT INT_PTR E_FQuat_UnrotateVector(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FQuat*)Self)->UnrotateVector(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Vector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->Vector());
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FRepRootMotionMontage_Rotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((FRepRootMotionMontage*)Ptr)->Rotation); }
	DOTNET_EXPORT void E_PROP_FRepRootMotionMontage_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FRepRootMotionMontage*)Ptr)->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT void E_FRepRootMotionMontage_Clear(INT_PTR Self)
	{
		((FRepRootMotionMontage*)Self)->Clear();
	}

	DOTNET_EXPORT bool E_FRepRootMotionMontage_HasRootMotion(INT_PTR Self)
	{
		return ((FRepRootMotionMontage*)Self)->HasRootMotion();
	}

	
	/*	FRotator	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator() { return (INT_PTR) new FRotator(); }
	
	DOTNET_EXPORT float E_PROP_FRotator_Pitch_GET(INT_PTR Ptr) { return ((FRotator*)Ptr)->Pitch; }
	DOTNET_EXPORT void E_PROP_FRotator_Pitch_SET(INT_PTR Ptr, float Value) { ((FRotator*)Ptr)->Pitch = Value; }
	
	DOTNET_EXPORT float E_PROP_FRotator_Roll_GET(INT_PTR Ptr) { return ((FRotator*)Ptr)->Roll; }
	DOTNET_EXPORT void E_PROP_FRotator_Roll_SET(INT_PTR Ptr, float Value) { ((FRotator*)Ptr)->Roll = Value; }
	
	DOTNET_EXPORT float E_PROP_FRotator_Yaw_GET(INT_PTR Ptr) { return ((FRotator*)Ptr)->Yaw; }
	DOTNET_EXPORT void E_PROP_FRotator_Yaw_SET(INT_PTR Ptr, float Value) { ((FRotator*)Ptr)->Yaw = Value; }
	
	DOTNET_EXPORT INT_PTR E_FRotator_Add(INT_PTR Self, float DeltaPitch, float DeltaYaw, float DeltaRoll)
	{
		auto _p0 = DeltaPitch;
		auto _p1 = DeltaYaw;
		auto _p2 = DeltaRoll;
		return (INT_PTR) new FRotator(((FRotator*)Self)->Add(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_FRotator_Clamp(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FRotator*)Self)->Clamp());
	}

	DOTNET_EXPORT float E_FRotator_ClampAxis(INT_PTR Self, float Angle)
	{
		auto _p0 = Angle;
		return ((FRotator*)Self)->ClampAxis(_p0);
	}

	DOTNET_EXPORT uint8 E_FRotator_CompressAxisToByte(INT_PTR Self, float Angle)
	{
		auto _p0 = Angle;
		return ((FRotator*)Self)->CompressAxisToByte(_p0);
	}

	DOTNET_EXPORT bool E_FRotator_ContainsNaN(INT_PTR Self)
	{
		return ((FRotator*)Self)->ContainsNaN();
	}

	DOTNET_EXPORT bool E_FRotator_Equals(INT_PTR Self, INT_PTR R, float Tolerance)
	{
		auto _p0 = *(FRotator*)R;
		auto _p1 = Tolerance;
		return ((FRotator*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FRotator_Euler(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FRotator*)Self)->Euler());
	}

	DOTNET_EXPORT INT_PTR E_FRotator_GetDenormalized(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FRotator*)Self)->GetDenormalized());
	}

	DOTNET_EXPORT INT_PTR E_FRotator_GetInverse(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FRotator*)Self)->GetInverse());
	}

	DOTNET_EXPORT INT_PTR E_FRotator_GetNormalized(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FRotator*)Self)->GetNormalized());
	}

	DOTNET_EXPORT void E_FRotator_GetWindingAndRemainder(INT_PTR Self, INT_PTR Winding, INT_PTR Remainder)
	{
		auto _p0 = *(FRotator*)Winding;
		auto _p1 = *(FRotator*)Remainder;
		((FRotator*)Self)->GetWindingAndRemainder(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FRotator_GridSnap(INT_PTR Self, INT_PTR RotGrid)
	{
		auto _p0 = *(FRotator*)RotGrid;
		return (INT_PTR) new FRotator(((FRotator*)Self)->GridSnap(_p0));
	}

	DOTNET_EXPORT bool E_FRotator_InitFromString(INT_PTR Self, char* InSourceString)
	{
		auto _p0 = FString(InSourceString);
		return ((FRotator*)Self)->InitFromString(_p0);
	}

	DOTNET_EXPORT bool E_FRotator_IsNearlyZero(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FRotator*)Self)->IsNearlyZero(_p0);
	}

	DOTNET_EXPORT bool E_FRotator_IsZero(INT_PTR Self)
	{
		return ((FRotator*)Self)->IsZero();
	}

	DOTNET_EXPORT INT_PTR E_FRotator_MakeFromEuler(INT_PTR Self, INT_PTR Euler)
	{
		auto _p0 = *(FVector*)Euler;
		return (INT_PTR) new FRotator(((FRotator*)Self)->MakeFromEuler(_p0));
	}

	DOTNET_EXPORT void E_FRotator_Normalize(INT_PTR Self)
	{
		((FRotator*)Self)->Normalize();
	}

	DOTNET_EXPORT float E_FRotator_NormalizeAxis(INT_PTR Self, float Angle)
	{
		auto _p0 = Angle;
		return ((FRotator*)Self)->NormalizeAxis(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FRotator_Quaternion(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FRotator*)Self)->Quaternion());
	}

	DOTNET_EXPORT INT_PTR E_FRotator_RotateVector(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FRotator*)Self)->RotateVector(_p0));
	}

	DOTNET_EXPORT char* E_FRotator_ToCompactString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FRotator*)Self)->ToCompactString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT char* E_FRotator_ToString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FRotator*)Self)->ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT INT_PTR E_FRotator_UnrotateVector(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FRotator*)Self)->UnrotateVector(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FRotator_Vector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FRotator*)Self)->Vector());
	}

	
	/*	FSceneCaptureViewInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSceneCaptureViewInfo() { return (INT_PTR) new FSceneCaptureViewInfo(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSceneCaptureViewInfo_ViewLocation_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FSceneCaptureViewInfo*)Ptr)->ViewLocation); }
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FScreenMessageString_TextScale_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FScreenMessageString*)Ptr)->TextScale); }
	DOTNET_EXPORT void E_PROP_FScreenMessageString_TextScale_SET(INT_PTR Ptr, INT_PTR Value) { ((FScreenMessageString*)Ptr)->TextScale = *(FVector2D*)Value; }
	
	DOTNET_EXPORT float E_PROP_FScreenMessageString_TimeToDisplay_GET(INT_PTR Ptr) { return ((FScreenMessageString*)Ptr)->TimeToDisplay; }
	DOTNET_EXPORT void E_PROP_FScreenMessageString_TimeToDisplay_SET(INT_PTR Ptr, float Value) { ((FScreenMessageString*)Ptr)->TimeToDisplay = Value; }
	
	
	/*	FSimulatedRootMotionReplicatedMove	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSimulatedRootMotionReplicatedMove() { return (INT_PTR) new FSimulatedRootMotionReplicatedMove(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_GET(INT_PTR Ptr) { return (INT_PTR) new FRepRootMotionMontage(((FSimulatedRootMotionReplicatedMove*)Ptr)->RootMotion); }
	DOTNET_EXPORT void E_PROP_FSimulatedRootMotionReplicatedMove_RootMotion_SET(INT_PTR Ptr, INT_PTR Value) { ((FSimulatedRootMotionReplicatedMove*)Ptr)->RootMotion = *(FRepRootMotionMontage*)Value; }
	
	DOTNET_EXPORT float E_PROP_FSimulatedRootMotionReplicatedMove_Time_GET(INT_PTR Ptr) { return ((FSimulatedRootMotionReplicatedMove*)Ptr)->Time; }
	DOTNET_EXPORT void E_PROP_FSimulatedRootMotionReplicatedMove_Time_SET(INT_PTR Ptr, float Value) { ((FSimulatedRootMotionReplicatedMove*)Ptr)->Time = Value; }
	
	
	/*	FSplineCurves	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplineCurves() { return (INT_PTR) new FSplineCurves(); }
	
	DOTNET_EXPORT float E_FSplineCurves_GetSegmentLength(INT_PTR Self, int32 Index, float Param, bool bClosedLoop, INT_PTR Scale3D)
	{
		auto _p0 = Index;
		auto _p1 = Param;
		auto _p2 = bClosedLoop;
		auto _p3 = *(FVector*)Scale3D;
		return ((FSplineCurves*)Self)->GetSegmentLength(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT float E_FSplineCurves_GetSplineLength(INT_PTR Self)
	{
		return ((FSplineCurves*)Self)->GetSplineLength();
	}

	DOTNET_EXPORT void E_FSplineCurves_UpdateSpline(INT_PTR Self, bool bClosedLoop, bool bStationaryEndpoints, int32 ReparamStepsPerSegment, bool bLoopPositionOverride, float LoopPosition, INT_PTR Scale3D)
	{
		auto _p0 = bClosedLoop;
		auto _p1 = bStationaryEndpoints;
		auto _p2 = ReparamStepsPerSegment;
		auto _p3 = bLoopPositionOverride;
		auto _p4 = LoopPosition;
		auto _p5 = *(FVector*)Scale3D;
		((FSplineCurves*)Self)->UpdateSpline(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	
	/*	FSplineMeshParams	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplineMeshParams() { return (INT_PTR) new FSplineMeshParams(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_EndOffset_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FSplineMeshParams*)Ptr)->EndOffset); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndOffset_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->EndOffset = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_EndPos_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FSplineMeshParams*)Ptr)->EndPos); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndPos_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->EndPos = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FSplineMeshParams_EndRoll_GET(INT_PTR Ptr) { return ((FSplineMeshParams*)Ptr)->EndRoll; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndRoll_SET(INT_PTR Ptr, float Value) { ((FSplineMeshParams*)Ptr)->EndRoll = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_EndScale_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FSplineMeshParams*)Ptr)->EndScale); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndScale_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->EndScale = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_EndTangent_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FSplineMeshParams*)Ptr)->EndTangent); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_EndTangent_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->EndTangent = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_StartOffset_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FSplineMeshParams*)Ptr)->StartOffset); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartOffset_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->StartOffset = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_StartPos_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FSplineMeshParams*)Ptr)->StartPos); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartPos_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->StartPos = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FSplineMeshParams_StartRoll_GET(INT_PTR Ptr) { return ((FSplineMeshParams*)Ptr)->StartRoll; }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartRoll_SET(INT_PTR Ptr, float Value) { ((FSplineMeshParams*)Ptr)->StartRoll = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_StartScale_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FSplineMeshParams*)Ptr)->StartScale); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartScale_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->StartScale = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplineMeshParams_StartTangent_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FSplineMeshParams*)Ptr)->StartTangent); }
	DOTNET_EXPORT void E_PROP_FSplineMeshParams_StartTangent_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplineMeshParams*)Ptr)->StartTangent = *(FVector*)Value; }
	
	
	/*	FSplinePoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplinePoint() { return (INT_PTR) new FSplinePoint(); }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_ArriveTangent_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FSplinePoint*)Ptr)->ArriveTangent); }
	DOTNET_EXPORT void E_PROP_FSplinePoint_ArriveTangent_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplinePoint*)Ptr)->ArriveTangent = *(FVector*)Value; }
	
	DOTNET_EXPORT float E_PROP_FSplinePoint_InputKey_GET(INT_PTR Ptr) { return ((FSplinePoint*)Ptr)->InputKey; }
	DOTNET_EXPORT void E_PROP_FSplinePoint_InputKey_SET(INT_PTR Ptr, float Value) { ((FSplinePoint*)Ptr)->InputKey = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_LeaveTangent_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FSplinePoint*)Ptr)->LeaveTangent); }
	DOTNET_EXPORT void E_PROP_FSplinePoint_LeaveTangent_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplinePoint*)Ptr)->LeaveTangent = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_Position_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FSplinePoint*)Ptr)->Position); }
	DOTNET_EXPORT void E_PROP_FSplinePoint_Position_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplinePoint*)Ptr)->Position = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_Rotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((FSplinePoint*)Ptr)->Rotation); }
	DOTNET_EXPORT void E_PROP_FSplinePoint_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FSplinePoint*)Ptr)->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FSplinePoint_Scale_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FSplinePoint*)Ptr)->Scale); }
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
	
	DOTNET_EXPORT bool E_FTickFunction_IsCompletionHandleValid(INT_PTR Self)
	{
		return ((FTickFunction*)Self)->IsCompletionHandleValid();
	}

	DOTNET_EXPORT bool E_FTickFunction_IsTickFunctionEnabled(INT_PTR Self)
	{
		return ((FTickFunction*)Self)->IsTickFunctionEnabled();
	}

	DOTNET_EXPORT bool E_FTickFunction_IsTickFunctionRegistered(INT_PTR Self)
	{
		return ((FTickFunction*)Self)->IsTickFunctionRegistered();
	}

	DOTNET_EXPORT void E_FTickFunction_SetPriorityIncludingPrerequisites(INT_PTR Self, bool bInHighPriority)
	{
		auto _p0 = bInHighPriority;
		((FTickFunction*)Self)->SetPriorityIncludingPrerequisites(_p0);
	}

	DOTNET_EXPORT void E_FTickFunction_SetTickFunctionEnable(INT_PTR Self, bool bInEnabled)
	{
		auto _p0 = bInEnabled;
		((FTickFunction*)Self)->SetTickFunctionEnable(_p0);
	}

	DOTNET_EXPORT void E_FTickFunction_UnRegisterTickFunction(INT_PTR Self)
	{
		((FTickFunction*)Self)->UnRegisterTickFunction();
	}

	
	/*	FTickPrerequisite	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTickPrerequisite() { return (INT_PTR) new FTickPrerequisite(); }
	
	
	/*	FTimeline	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimeline() { return (INT_PTR) new FTimeline(); }
	
	DOTNET_EXPORT float E_FTimeline_GetPlaybackPosition(INT_PTR Self)
	{
		return ((FTimeline*)Self)->GetPlaybackPosition();
	}

	DOTNET_EXPORT float E_FTimeline_GetPlayRate(INT_PTR Self)
	{
		return ((FTimeline*)Self)->GetPlayRate();
	}

	DOTNET_EXPORT float E_FTimeline_GetTimelineLength(INT_PTR Self)
	{
		return ((FTimeline*)Self)->GetTimelineLength();
	}

	DOTNET_EXPORT bool E_FTimeline_IsLooping(INT_PTR Self)
	{
		return ((FTimeline*)Self)->IsLooping();
	}

	DOTNET_EXPORT bool E_FTimeline_IsPlaying(INT_PTR Self)
	{
		return ((FTimeline*)Self)->IsPlaying();
	}

	DOTNET_EXPORT bool E_FTimeline_IsReversing(INT_PTR Self)
	{
		return ((FTimeline*)Self)->IsReversing();
	}

	DOTNET_EXPORT void E_FTimeline_Play(INT_PTR Self)
	{
		((FTimeline*)Self)->Play();
	}

	DOTNET_EXPORT void E_FTimeline_PlayFromStart(INT_PTR Self)
	{
		((FTimeline*)Self)->PlayFromStart();
	}

	DOTNET_EXPORT void E_FTimeline_Reverse(INT_PTR Self)
	{
		((FTimeline*)Self)->Reverse();
	}

	DOTNET_EXPORT void E_FTimeline_ReverseFromEnd(INT_PTR Self)
	{
		((FTimeline*)Self)->ReverseFromEnd();
	}

	DOTNET_EXPORT void E_FTimeline_SetDirectionPropertyName(INT_PTR Self, char* InDirectionPropertyName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InDirectionPropertyName));
		((FTimeline*)Self)->SetDirectionPropertyName(_p0);
	}

	DOTNET_EXPORT void E_FTimeline_SetLooping(INT_PTR Self, bool bNewLooping)
	{
		auto _p0 = bNewLooping;
		((FTimeline*)Self)->SetLooping(_p0);
	}

	DOTNET_EXPORT void E_FTimeline_SetNewTime(INT_PTR Self, float NewTime)
	{
		auto _p0 = NewTime;
		((FTimeline*)Self)->SetNewTime(_p0);
	}

	DOTNET_EXPORT void E_FTimeline_SetPlaybackPosition(INT_PTR Self, float NewPosition, bool bFireEvents, bool bFireUpdate)
	{
		auto _p0 = NewPosition;
		auto _p1 = bFireEvents;
		auto _p2 = bFireUpdate;
		((FTimeline*)Self)->SetPlaybackPosition(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_FTimeline_SetPlayRate(INT_PTR Self, float NewRate)
	{
		auto _p0 = NewRate;
		((FTimeline*)Self)->SetPlayRate(_p0);
	}

	DOTNET_EXPORT void E_FTimeline_SetPropertySetObject(INT_PTR Self, UObject* NewPropertySetObject)
	{
		auto _p0 = NewPropertySetObject;
		((FTimeline*)Self)->SetPropertySetObject(_p0);
	}

	DOTNET_EXPORT void E_FTimeline_SetTimelineLength(INT_PTR Self, float NewLength)
	{
		auto _p0 = NewLength;
		((FTimeline*)Self)->SetTimelineLength(_p0);
	}

	DOTNET_EXPORT void E_FTimeline_Stop(INT_PTR Self)
	{
		((FTimeline*)Self)->Stop();
	}

	DOTNET_EXPORT void E_FTimeline_TickTimeline(INT_PTR Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((FTimeline*)Self)->TickTimeline(_p0);
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
	
	DOTNET_EXPORT void E_FTransform_AddToTranslation(INT_PTR Self, INT_PTR DeltaTranslation)
	{
		auto _p0 = *(FVector*)DeltaTranslation;
		((FTransform*)Self)->AddToTranslation(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FTransform_AddTranslations(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		return (INT_PTR) new FVector(((FTransform*)Self)->AddTranslations(_p0, _p1));
	}

	DOTNET_EXPORT bool E_FTransform_AnyHasNegativeScale(INT_PTR Self, INT_PTR InScale3D, INT_PTR InOtherScale3D)
	{
		auto _p0 = *(FVector*)InScale3D;
		auto _p1 = *(FVector*)InOtherScale3D;
		return ((FTransform*)Self)->AnyHasNegativeScale(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FTransform_AreRotationsEqual(INT_PTR Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return ((FTransform*)Self)->AreRotationsEqual(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FTransform_AreScale3DsEqual(INT_PTR Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return ((FTransform*)Self)->AreScale3DsEqual(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FTransform_AreTranslationsEqual(INT_PTR Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return ((FTransform*)Self)->AreTranslationsEqual(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_FTransform_Blend(INT_PTR Self, INT_PTR Atom1, INT_PTR Atom2, float Alpha)
	{
		auto _p0 = *(FTransform*)Atom1;
		auto _p1 = *(FTransform*)Atom2;
		auto _p2 = Alpha;
		((FTransform*)Self)->Blend(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_FTransform_BlendWith(INT_PTR Self, INT_PTR OtherAtom, float Alpha)
	{
		auto _p0 = *(FTransform*)OtherAtom;
		auto _p1 = Alpha;
		((FTransform*)Self)->BlendWith(_p0, _p1);
	}

	DOTNET_EXPORT void E_FTransform_ConcatenateRotation(INT_PTR Self, INT_PTR DeltaRotation)
	{
		auto _p0 = *(FQuat*)DeltaRotation;
		((FTransform*)Self)->ConcatenateRotation(_p0);
	}

	DOTNET_EXPORT bool E_FTransform_ContainsNaN(INT_PTR Self)
	{
		return ((FTransform*)Self)->ContainsNaN();
	}

	DOTNET_EXPORT void E_FTransform_CopyRotation(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		((FTransform*)Self)->CopyRotation(_p0);
	}

	DOTNET_EXPORT void E_FTransform_CopyRotationPart(INT_PTR Self, INT_PTR SrcBA)
	{
		auto _p0 = *(FTransform*)SrcBA;
		((FTransform*)Self)->CopyRotationPart(_p0);
	}

	DOTNET_EXPORT void E_FTransform_CopyScale3D(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		((FTransform*)Self)->CopyScale3D(_p0);
	}

	DOTNET_EXPORT void E_FTransform_CopyTranslation(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		((FTransform*)Self)->CopyTranslation(_p0);
	}

	DOTNET_EXPORT void E_FTransform_CopyTranslationAndScale3D(INT_PTR Self, INT_PTR SrcBA)
	{
		auto _p0 = *(FTransform*)SrcBA;
		((FTransform*)Self)->CopyTranslationAndScale3D(_p0);
	}

	DOTNET_EXPORT void E_FTransform_DebugPrint(INT_PTR Self)
	{
		((FTransform*)Self)->DebugPrint();
	}

	DOTNET_EXPORT void E_FTransform_DiagnosticCheck_IsValid(INT_PTR Self)
	{
		((FTransform*)Self)->DiagnosticCheck_IsValid();
	}

	DOTNET_EXPORT void E_FTransform_DiagnosticCheckNaN_All(INT_PTR Self)
	{
		((FTransform*)Self)->DiagnosticCheckNaN_All();
	}

	DOTNET_EXPORT void E_FTransform_DiagnosticCheckNaN_Rotate(INT_PTR Self)
	{
		((FTransform*)Self)->DiagnosticCheckNaN_Rotate();
	}

	DOTNET_EXPORT void E_FTransform_DiagnosticCheckNaN_Scale3D(INT_PTR Self)
	{
		((FTransform*)Self)->DiagnosticCheckNaN_Scale3D();
	}

	DOTNET_EXPORT void E_FTransform_DiagnosticCheckNaN_Translate(INT_PTR Self)
	{
		((FTransform*)Self)->DiagnosticCheckNaN_Translate();
	}

	DOTNET_EXPORT bool E_FTransform_Equals(INT_PTR Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ((FTransform*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FTransform_EqualsNoScale(INT_PTR Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ((FTransform*)Self)->EqualsNoScale(_p0, _p1);
	}

	DOTNET_EXPORT float E_FTransform_GetDeterminant(INT_PTR Self)
	{
		return ((FTransform*)Self)->GetDeterminant();
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetLocation(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FTransform*)Self)->GetLocation());
	}

	DOTNET_EXPORT float E_FTransform_GetMaximumAxisScale(INT_PTR Self)
	{
		return ((FTransform*)Self)->GetMaximumAxisScale();
	}

	DOTNET_EXPORT float E_FTransform_GetMinimumAxisScale(INT_PTR Self)
	{
		return ((FTransform*)Self)->GetMinimumAxisScale();
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetRelativeTransform(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		return (INT_PTR) new FTransform(((FTransform*)Self)->GetRelativeTransform(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetRelativeTransformReverse(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FTransform*)Other;
		return (INT_PTR) new FTransform(((FTransform*)Self)->GetRelativeTransformReverse(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetRotation(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FTransform*)Self)->GetRotation());
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetRotationV(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FTransform*)Self)->GetRotationV());
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetSafeScaleReciprocal(INT_PTR Self, INT_PTR InScale, float Tolerance)
	{
		auto _p0 = *(FVector*)InScale;
		auto _p1 = Tolerance;
		return (INT_PTR) new FVector(((FTransform*)Self)->GetSafeScaleReciprocal(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetScale3D(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FTransform*)Self)->GetScale3D());
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetScale3DV(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FTransform*)Self)->GetScale3DV());
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetTranslation(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FTransform*)Self)->GetTranslation());
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetTranslationV(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FTransform*)Self)->GetTranslationV());
	}

	DOTNET_EXPORT bool E_FTransform_InitFromString(INT_PTR Self, char* InSourceString)
	{
		auto _p0 = FString(InSourceString);
		return ((FTransform*)Self)->InitFromString(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FTransform_Inverse(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((FTransform*)Self)->Inverse());
	}

	DOTNET_EXPORT INT_PTR E_FTransform_InverseTransformPosition(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FTransform*)Self)->InverseTransformPosition(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_InverseTransformPositionNoScale(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FTransform*)Self)->InverseTransformPositionNoScale(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_InverseTransformVector(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FTransform*)Self)->InverseTransformVector(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_InverseTransformVectorNoScale(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FTransform*)Self)->InverseTransformVectorNoScale(_p0));
	}

	DOTNET_EXPORT bool E_FTransform_IsRotationNormalized(INT_PTR Self)
	{
		return ((FTransform*)Self)->IsRotationNormalized();
	}

	DOTNET_EXPORT bool E_FTransform_IsValid(INT_PTR Self)
	{
		return ((FTransform*)Self)->IsValid();
	}

	DOTNET_EXPORT void E_FTransform_Multiply(INT_PTR Self, INT_PTR OutTransform, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FTransform*)OutTransform;
		auto _p1 = *(FTransform*)A;
		auto _p2 = *(FTransform*)B;
		((FTransform*)Self)->Multiply(&_p0, &_p1, &_p2);
	}

	DOTNET_EXPORT void E_FTransform_MultiplyScale3D(INT_PTR Self, INT_PTR Scale3DMultiplier)
	{
		auto _p0 = *(FVector*)Scale3DMultiplier;
		((FTransform*)Self)->MultiplyScale3D(_p0);
	}

	DOTNET_EXPORT void E_FTransform_NormalizeRotation(INT_PTR Self)
	{
		((FTransform*)Self)->NormalizeRotation();
	}

	DOTNET_EXPORT void E_FTransform_RemoveScaling(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		((FTransform*)Self)->RemoveScaling(_p0);
	}

	DOTNET_EXPORT bool E_FTransform_RotationEquals(INT_PTR Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ((FTransform*)Self)->RotationEquals(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FTransform_Rotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FTransform*)Self)->Rotator());
	}

	DOTNET_EXPORT bool E_FTransform_Scale3DEquals(INT_PTR Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ((FTransform*)Self)->Scale3DEquals(_p0, _p1);
	}

	DOTNET_EXPORT void E_FTransform_SetComponents(INT_PTR Self, INT_PTR InRotation, INT_PTR InTranslation, INT_PTR InScale3D)
	{
		auto _p0 = *(FQuat*)InRotation;
		auto _p1 = *(FVector*)InTranslation;
		auto _p2 = *(FVector*)InScale3D;
		((FTransform*)Self)->SetComponents(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_FTransform_SetIdentity(INT_PTR Self)
	{
		((FTransform*)Self)->SetIdentity();
	}

	DOTNET_EXPORT void E_FTransform_SetLocation(INT_PTR Self, INT_PTR Origin)
	{
		auto _p0 = *(FVector*)Origin;
		((FTransform*)Self)->SetLocation(_p0);
	}

	DOTNET_EXPORT void E_FTransform_SetRotation(INT_PTR Self, INT_PTR NewRotation)
	{
		auto _p0 = *(FQuat*)NewRotation;
		((FTransform*)Self)->SetRotation(_p0);
	}

	DOTNET_EXPORT void E_FTransform_SetScale3D(INT_PTR Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		((FTransform*)Self)->SetScale3D(_p0);
	}

	DOTNET_EXPORT void E_FTransform_SetToRelativeTransform(INT_PTR Self, INT_PTR ParentTransform)
	{
		auto _p0 = *(FTransform*)ParentTransform;
		((FTransform*)Self)->SetToRelativeTransform(_p0);
	}

	DOTNET_EXPORT void E_FTransform_SetTranslation(INT_PTR Self, INT_PTR NewTranslation)
	{
		auto _p0 = *(FVector*)NewTranslation;
		((FTransform*)Self)->SetTranslation(_p0);
	}

	DOTNET_EXPORT void E_FTransform_SetTranslationAndScale3D(INT_PTR Self, INT_PTR NewTranslation, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewTranslation;
		auto _p1 = *(FVector*)NewScale3D;
		((FTransform*)Self)->SetTranslationAndScale3D(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FTransform_SubtractTranslations(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		return (INT_PTR) new FVector(((FTransform*)Self)->SubtractTranslations(_p0, _p1));
	}

	DOTNET_EXPORT char* E_FTransform_ToHumanReadableString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FTransform*)Self)->ToHumanReadableString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT char* E_FTransform_ToString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FTransform*)Self)->ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT INT_PTR E_FTransform_TransformFVector4(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector4*)V;
		return (INT_PTR) new FVector4(((FTransform*)Self)->TransformFVector4(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_TransformFVector4NoScale(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector4*)V;
		return (INT_PTR) new FVector4(((FTransform*)Self)->TransformFVector4NoScale(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_TransformPosition(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FTransform*)Self)->TransformPosition(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_TransformPositionNoScale(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FTransform*)Self)->TransformPositionNoScale(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_TransformVector(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FTransform*)Self)->TransformVector(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_TransformVectorNoScale(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FTransform*)Self)->TransformVectorNoScale(_p0));
	}

	DOTNET_EXPORT bool E_FTransform_TranslationEquals(INT_PTR Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ((FTransform*)Self)->TranslationEquals(_p0, _p1);
	}

	
	/*	FURL	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FURL() { return (INT_PTR) new FURL(); }
	
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
	
	DOTNET_EXPORT void E_FURL_FilterURLString(INT_PTR Self, char* Str)
	{
		auto _p0 = FString(Str);
		((FURL*)Self)->FilterURLString(_p0);
	}

	DOTNET_EXPORT bool E_FURL_IsInternal(INT_PTR Self)
	{
		return ((FURL*)Self)->IsInternal();
	}

	DOTNET_EXPORT bool E_FURL_IsLocalInternal(INT_PTR Self)
	{
		return ((FURL*)Self)->IsLocalInternal();
	}

	DOTNET_EXPORT void E_FURL_StaticExit(INT_PTR Self)
	{
		((FURL*)Self)->StaticExit();
	}

	DOTNET_EXPORT void E_FURL_StaticInit(INT_PTR Self)
	{
		((FURL*)Self)->StaticInit();
	}

	
	/*	FVector	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector() { return (INT_PTR) new FVector(); }
	
	DOTNET_EXPORT float E_PROP_FVector_X_GET(INT_PTR Ptr) { return ((FVector*)Ptr)->X; }
	DOTNET_EXPORT void E_PROP_FVector_X_SET(INT_PTR Ptr, float Value) { ((FVector*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector_Y_GET(INT_PTR Ptr) { return ((FVector*)Ptr)->Y; }
	DOTNET_EXPORT void E_PROP_FVector_Y_SET(INT_PTR Ptr, float Value) { ((FVector*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector_Z_GET(INT_PTR Ptr) { return ((FVector*)Ptr)->Z; }
	DOTNET_EXPORT void E_PROP_FVector_Z_SET(INT_PTR Ptr, float Value) { ((FVector*)Ptr)->Z = Value; }
	
	DOTNET_EXPORT void E_FVector_AddBounded(INT_PTR Self, INT_PTR V, float Radius)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = Radius;
		((FVector*)Self)->AddBounded(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_AllComponentsEqual(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FVector*)Self)->AllComponentsEqual(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FVector_BoundToCube(INT_PTR Self, float Radius)
	{
		auto _p0 = Radius;
		return (INT_PTR) new FVector(((FVector*)Self)->BoundToCube(_p0));
	}

	DOTNET_EXPORT float E_FVector_BoxPushOut(INT_PTR Self, INT_PTR Normal, INT_PTR Size)
	{
		auto _p0 = *(FVector*)Normal;
		auto _p1 = *(FVector*)Size;
		return ((FVector*)Self)->BoxPushOut(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FVector_ClampMaxSize(INT_PTR Self, float MaxSize)
	{
		auto _p0 = MaxSize;
		return (INT_PTR) new FVector(((FVector*)Self)->ClampMaxSize(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_ClampMaxSize2D(INT_PTR Self, float MaxSize)
	{
		auto _p0 = MaxSize;
		return (INT_PTR) new FVector(((FVector*)Self)->ClampMaxSize2D(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_ClampSize(INT_PTR Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return (INT_PTR) new FVector(((FVector*)Self)->ClampSize(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_FVector_ClampSize2D(INT_PTR Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return (INT_PTR) new FVector(((FVector*)Self)->ClampSize2D(_p0, _p1));
	}

	DOTNET_EXPORT bool E_FVector_Coincident(INT_PTR Self, INT_PTR Normal1, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		auto _p2 = ParallelCosineThreshold;
		return ((FVector*)Self)->Coincident(_p0, _p1, _p2);
	}

	DOTNET_EXPORT INT_PTR E_FVector_ComponentMax(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FVector*)Other;
		return (INT_PTR) new FVector(((FVector*)Self)->ComponentMax(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_ComponentMin(INT_PTR Self, INT_PTR Other)
	{
		auto _p0 = *(FVector*)Other;
		return (INT_PTR) new FVector(((FVector*)Self)->ComponentMin(_p0));
	}

	DOTNET_EXPORT bool E_FVector_ContainsNaN(INT_PTR Self)
	{
		return ((FVector*)Self)->ContainsNaN();
	}

	DOTNET_EXPORT bool E_FVector_Coplanar(INT_PTR Self, INT_PTR Base1, INT_PTR Normal1, INT_PTR Base2, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Base1;
		auto _p1 = *(FVector*)Normal1;
		auto _p2 = *(FVector*)Base2;
		auto _p3 = *(FVector*)Normal2;
		auto _p4 = ParallelCosineThreshold;
		return ((FVector*)Self)->Coplanar(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT float E_FVector_CosineAngle2D(INT_PTR Self, INT_PTR B)
	{
		auto _p0 = *(FVector*)B;
		return ((FVector*)Self)->CosineAngle2D(_p0);
	}

	DOTNET_EXPORT void E_FVector_CreateOrthonormalBasis(INT_PTR Self, INT_PTR XAxis, INT_PTR YAxis, INT_PTR ZAxis)
	{
		auto _p0 = *(FVector*)XAxis;
		auto _p1 = *(FVector*)YAxis;
		auto _p2 = *(FVector*)ZAxis;
		((FVector*)Self)->CreateOrthonormalBasis(_p0, _p1, _p2);
	}

	DOTNET_EXPORT INT_PTR E_FVector_CrossProduct(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(((FVector*)Self)->CrossProduct(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_FVector_DegreesToRadians(INT_PTR Self, INT_PTR DegVector)
	{
		auto _p0 = *(FVector*)DegVector;
		return (INT_PTR) new FVector(((FVector*)Self)->DegreesToRadians(_p0));
	}

	DOTNET_EXPORT float E_FVector_Dist(INT_PTR Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ((FVector*)Self)->Dist(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector_Dist2D(INT_PTR Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ((FVector*)Self)->Dist2D(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector_Distance(INT_PTR Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ((FVector*)Self)->Distance(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector_DistSquared(INT_PTR Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ((FVector*)Self)->DistSquared(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector_DistSquared2D(INT_PTR Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ((FVector*)Self)->DistSquared2D(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector_DistSquaredXY(INT_PTR Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ((FVector*)Self)->DistSquaredXY(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector_DistXY(INT_PTR Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return ((FVector*)Self)->DistXY(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector_DotProduct(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return ((FVector*)Self)->DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_Equals(INT_PTR Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = Tolerance;
		return ((FVector*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector_FindBestAxisVectors(INT_PTR Self, INT_PTR Axis1, INT_PTR Axis2)
	{
		auto _p0 = *(FVector*)Axis1;
		auto _p1 = *(FVector*)Axis2;
		((FVector*)Self)->FindBestAxisVectors(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetAbs(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FVector*)Self)->GetAbs());
	}

	DOTNET_EXPORT float E_FVector_GetAbsMax(INT_PTR Self)
	{
		return ((FVector*)Self)->GetAbsMax();
	}

	DOTNET_EXPORT float E_FVector_GetAbsMin(INT_PTR Self)
	{
		return ((FVector*)Self)->GetAbsMin();
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetClampedToMaxSize(INT_PTR Self, float MaxSize)
	{
		auto _p0 = MaxSize;
		return (INT_PTR) new FVector(((FVector*)Self)->GetClampedToMaxSize(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetClampedToMaxSize2D(INT_PTR Self, float MaxSize)
	{
		auto _p0 = MaxSize;
		return (INT_PTR) new FVector(((FVector*)Self)->GetClampedToMaxSize2D(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetClampedToSize(INT_PTR Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return (INT_PTR) new FVector(((FVector*)Self)->GetClampedToSize(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetClampedToSize2D(INT_PTR Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return (INT_PTR) new FVector(((FVector*)Self)->GetClampedToSize2D(_p0, _p1));
	}

	DOTNET_EXPORT float E_FVector_GetMax(INT_PTR Self)
	{
		return ((FVector*)Self)->GetMax();
	}

	DOTNET_EXPORT float E_FVector_GetMin(INT_PTR Self)
	{
		return ((FVector*)Self)->GetMin();
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetSafeNormal(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector(((FVector*)Self)->GetSafeNormal(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetSafeNormal2D(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector(((FVector*)Self)->GetSafeNormal2D(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetSignVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FVector*)Self)->GetSignVector());
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetUnsafeNormal(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FVector*)Self)->GetUnsafeNormal());
	}

	DOTNET_EXPORT INT_PTR E_FVector_GridSnap(INT_PTR Self, float GridSz)
	{
		auto _p0 = GridSz;
		return (INT_PTR) new FVector(((FVector*)Self)->GridSnap(_p0));
	}

	DOTNET_EXPORT float E_FVector_HeadingAngle(INT_PTR Self)
	{
		return ((FVector*)Self)->HeadingAngle();
	}

	DOTNET_EXPORT bool E_FVector_InitFromString(INT_PTR Self, char* InSourceString)
	{
		auto _p0 = FString(InSourceString);
		return ((FVector*)Self)->InitFromString(_p0);
	}

	DOTNET_EXPORT bool E_FVector_IsNearlyZero(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FVector*)Self)->IsNearlyZero(_p0);
	}

	DOTNET_EXPORT bool E_FVector_IsNormalized(INT_PTR Self)
	{
		return ((FVector*)Self)->IsNormalized();
	}

	DOTNET_EXPORT bool E_FVector_IsUniform(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FVector*)Self)->IsUniform(_p0);
	}

	DOTNET_EXPORT bool E_FVector_IsUnit(INT_PTR Self, float LengthSquaredTolerance)
	{
		auto _p0 = LengthSquaredTolerance;
		return ((FVector*)Self)->IsUnit(_p0);
	}

	DOTNET_EXPORT bool E_FVector_IsZero(INT_PTR Self)
	{
		return ((FVector*)Self)->IsZero();
	}

	DOTNET_EXPORT INT_PTR E_FVector_MirrorByPlane(INT_PTR Self, INT_PTR Plane)
	{
		auto _p0 = *(FPlane*)Plane;
		return (INT_PTR) new FVector(((FVector*)Self)->MirrorByPlane(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_MirrorByVector(INT_PTR Self, INT_PTR MirrorNormal)
	{
		auto _p0 = *(FVector*)MirrorNormal;
		return (INT_PTR) new FVector(((FVector*)Self)->MirrorByVector(_p0));
	}

	DOTNET_EXPORT bool E_FVector_Normalize(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FVector*)Self)->Normalize(_p0);
	}

	DOTNET_EXPORT bool E_FVector_Orthogonal(INT_PTR Self, INT_PTR Normal1, INT_PTR Normal2, float OrthogonalCosineThreshold)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		auto _p2 = OrthogonalCosineThreshold;
		return ((FVector*)Self)->Orthogonal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FVector_Parallel(INT_PTR Self, INT_PTR Normal1, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Normal1;
		auto _p1 = *(FVector*)Normal2;
		auto _p2 = ParallelCosineThreshold;
		return ((FVector*)Self)->Parallel(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_FVector_PointPlaneDist(INT_PTR Self, INT_PTR Point, INT_PTR PlaneBase, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)PlaneBase;
		auto _p2 = *(FVector*)PlaneNormal;
		return ((FVector*)Self)->PointPlaneDist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FVector_PointsAreNear(INT_PTR Self, INT_PTR Point1, INT_PTR Point2, float Dist)
	{
		auto _p0 = *(FVector*)Point1;
		auto _p1 = *(FVector*)Point2;
		auto _p2 = Dist;
		return ((FVector*)Self)->PointsAreNear(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FVector_PointsAreSame(INT_PTR Self, INT_PTR P, INT_PTR Q)
	{
		auto _p0 = *(FVector*)P;
		auto _p1 = *(FVector*)Q;
		return ((FVector*)Self)->PointsAreSame(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FVector_Projection(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FVector*)Self)->Projection());
	}

	DOTNET_EXPORT INT_PTR E_FVector_ProjectOnTo(INT_PTR Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(((FVector*)Self)->ProjectOnTo(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_ProjectOnToNormal(INT_PTR Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Normal;
		return (INT_PTR) new FVector(((FVector*)Self)->ProjectOnToNormal(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_RadiansToDegrees(INT_PTR Self, INT_PTR RadVector)
	{
		auto _p0 = *(FVector*)RadVector;
		return (INT_PTR) new FVector(((FVector*)Self)->RadiansToDegrees(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_Reciprocal(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FVector*)Self)->Reciprocal());
	}

	DOTNET_EXPORT INT_PTR E_FVector_RotateAngleAxis(INT_PTR Self, float AngleDeg, INT_PTR Axis)
	{
		auto _p0 = AngleDeg;
		auto _p1 = *(FVector*)Axis;
		return (INT_PTR) new FVector(((FVector*)Self)->RotateAngleAxis(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_FVector_Rotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FVector*)Self)->Rotation());
	}

	DOTNET_EXPORT INT_PTR E_FVector_SafeNormal(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector(((FVector*)Self)->SafeNormal(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_SafeNormal2D(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector(((FVector*)Self)->SafeNormal2D(_p0));
	}

	DOTNET_EXPORT void E_FVector_Set(INT_PTR Self, float InX, float InY, float InZ)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		((FVector*)Self)->Set(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_FVector_Size(INT_PTR Self)
	{
		return ((FVector*)Self)->Size();
	}

	DOTNET_EXPORT float E_FVector_Size2D(INT_PTR Self)
	{
		return ((FVector*)Self)->Size2D();
	}

	DOTNET_EXPORT float E_FVector_SizeSquared(INT_PTR Self)
	{
		return ((FVector*)Self)->SizeSquared();
	}

	DOTNET_EXPORT float E_FVector_SizeSquared2D(INT_PTR Self)
	{
		return ((FVector*)Self)->SizeSquared2D();
	}

	DOTNET_EXPORT char* E_FVector_ToCompactString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FVector*)Self)->ToCompactString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT char* E_FVector_ToCompactText(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FVector*)Self)->ToCompactText().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_FVector_ToDirectionAndLength(INT_PTR Self, INT_PTR OutDir, float OutLength)
	{
		auto _p0 = *(FVector*)OutDir;
		auto _p1 = OutLength;
		((FVector*)Self)->ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FVector_ToOrientationQuat(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FVector*)Self)->ToOrientationQuat());
	}

	DOTNET_EXPORT INT_PTR E_FVector_ToOrientationRotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FVector*)Self)->ToOrientationRotator());
	}

	DOTNET_EXPORT char* E_FVector_ToString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FVector*)Self)->ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT char* E_FVector_ToText(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FVector*)Self)->ToText().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT float E_FVector_Triple(INT_PTR Self, INT_PTR X, INT_PTR Y, INT_PTR Z)
	{
		auto _p0 = *(FVector*)X;
		auto _p1 = *(FVector*)Y;
		auto _p2 = *(FVector*)Z;
		return ((FVector*)Self)->Triple(_p0, _p1, _p2);
	}

	DOTNET_EXPORT INT_PTR E_FVector_UnitCartesianToSpherical(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((FVector*)Self)->UnitCartesianToSpherical());
	}

	DOTNET_EXPORT INT_PTR E_FVector_UnsafeNormal(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FVector*)Self)->UnsafeNormal());
	}

	DOTNET_EXPORT void E_FVector_UnwindEuler(INT_PTR Self)
	{
		((FVector*)Self)->UnwindEuler();
	}

	DOTNET_EXPORT INT_PTR E_FVector_VectorPlaneProject(INT_PTR Self, INT_PTR V, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = *(FVector*)PlaneNormal;
		return (INT_PTR) new FVector(((FVector*)Self)->VectorPlaneProject(_p0, _p1));
	}

	
	/*	FVector2D	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector2D() { return (INT_PTR) new FVector2D(); }
	
	DOTNET_EXPORT float E_PROP_FVector2D_X_GET(INT_PTR Ptr) { return ((FVector2D*)Ptr)->X; }
	DOTNET_EXPORT void E_PROP_FVector2D_X_SET(INT_PTR Ptr, float Value) { ((FVector2D*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector2D_Y_GET(INT_PTR Ptr) { return ((FVector2D*)Ptr)->Y; }
	DOTNET_EXPORT void E_PROP_FVector2D_Y_SET(INT_PTR Ptr, float Value) { ((FVector2D*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT INT_PTR E_FVector2D_ClampAxes(INT_PTR Self, float MinAxisVal, float MaxAxisVal)
	{
		auto _p0 = MinAxisVal;
		auto _p1 = MaxAxisVal;
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->ClampAxes(_p0, _p1));
	}

	DOTNET_EXPORT bool E_FVector2D_ContainsNaN(INT_PTR Self)
	{
		return ((FVector2D*)Self)->ContainsNaN();
	}

	DOTNET_EXPORT float E_FVector2D_CrossProduct(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return ((FVector2D*)Self)->CrossProduct(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector2D_DiagnosticCheckNaN(INT_PTR Self)
	{
		((FVector2D*)Self)->DiagnosticCheckNaN();
	}

	DOTNET_EXPORT float E_FVector2D_Distance(INT_PTR Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector2D*)V1;
		auto _p1 = *(FVector2D*)V2;
		return ((FVector2D*)Self)->Distance(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector2D_DistSquared(INT_PTR Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector2D*)V1;
		auto _p1 = *(FVector2D*)V2;
		return ((FVector2D*)Self)->DistSquared(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector2D_DotProduct(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return ((FVector2D*)Self)->DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector2D_Equals(INT_PTR Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector2D*)V;
		auto _p1 = Tolerance;
		return ((FVector2D*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FVector2D_GetAbs(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->GetAbs());
	}

	DOTNET_EXPORT float E_FVector2D_GetAbsMax(INT_PTR Self)
	{
		return ((FVector2D*)Self)->GetAbsMax();
	}

	DOTNET_EXPORT float E_FVector2D_GetMax(INT_PTR Self)
	{
		return ((FVector2D*)Self)->GetMax();
	}

	DOTNET_EXPORT float E_FVector2D_GetMin(INT_PTR Self)
	{
		return ((FVector2D*)Self)->GetMin();
	}

	DOTNET_EXPORT INT_PTR E_FVector2D_GetRotated(INT_PTR Self, float AngleDeg)
	{
		auto _p0 = AngleDeg;
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->GetRotated(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector2D_GetSafeNormal(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->GetSafeNormal(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector2D_GetSignVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->GetSignVector());
	}

	DOTNET_EXPORT bool E_FVector2D_InitFromString(INT_PTR Self, char* InSourceString)
	{
		auto _p0 = FString(InSourceString);
		return ((FVector2D*)Self)->InitFromString(_p0);
	}

	DOTNET_EXPORT bool E_FVector2D_IsNearlyZero(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FVector2D*)Self)->IsNearlyZero(_p0);
	}

	DOTNET_EXPORT bool E_FVector2D_IsZero(INT_PTR Self)
	{
		return ((FVector2D*)Self)->IsZero();
	}

	DOTNET_EXPORT void E_FVector2D_Normalize(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		((FVector2D*)Self)->Normalize(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FVector2D_RoundToVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->RoundToVector());
	}

	DOTNET_EXPORT INT_PTR E_FVector2D_SafeNormal(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->SafeNormal(_p0));
	}

	DOTNET_EXPORT void E_FVector2D_Set(INT_PTR Self, float InX, float InY)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		((FVector2D*)Self)->Set(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector2D_Size(INT_PTR Self)
	{
		return ((FVector2D*)Self)->Size();
	}

	DOTNET_EXPORT float E_FVector2D_SizeSquared(INT_PTR Self)
	{
		return ((FVector2D*)Self)->SizeSquared();
	}

	DOTNET_EXPORT INT_PTR E_FVector2D_SphericalToUnitCartesian(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FVector2D*)Self)->SphericalToUnitCartesian());
	}

	DOTNET_EXPORT void E_FVector2D_ToDirectionAndLength(INT_PTR Self, INT_PTR OutDir, float OutLength)
	{
		auto _p0 = *(FVector2D*)OutDir;
		auto _p1 = OutLength;
		((FVector2D*)Self)->ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT char* E_FVector2D_ToString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FVector2D*)Self)->ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	
	/*	FVector4	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector4() { return (INT_PTR) new FVector4(); }
	
	DOTNET_EXPORT float E_PROP_FVector4_W_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->W; }
	DOTNET_EXPORT void E_PROP_FVector4_W_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->W = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector4_X_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->X; }
	DOTNET_EXPORT void E_PROP_FVector4_X_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector4_Y_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->Y; }
	DOTNET_EXPORT void E_PROP_FVector4_Y_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT float E_PROP_FVector4_Z_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->Z; }
	DOTNET_EXPORT void E_PROP_FVector4_Z_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->Z = Value; }
	
	DOTNET_EXPORT float E_FVector4_Component(INT_PTR Self, int32 Index)
	{
		auto _p0 = Index;
		return ((FVector4*)Self)->Component(_p0);
	}

	DOTNET_EXPORT bool E_FVector4_ContainsNaN(INT_PTR Self)
	{
		return ((FVector4*)Self)->ContainsNaN();
	}

	DOTNET_EXPORT void E_FVector4_DiagnosticCheckNaN(INT_PTR Self)
	{
		((FVector4*)Self)->DiagnosticCheckNaN();
	}

	DOTNET_EXPORT bool E_FVector4_Equals(INT_PTR Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector4*)V;
		auto _p1 = Tolerance;
		return ((FVector4*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector4_FindBestAxisVectors3(INT_PTR Self, INT_PTR Axis1, INT_PTR Axis2)
	{
		auto _p0 = *(FVector4*)Axis1;
		auto _p1 = *(FVector4*)Axis2;
		((FVector4*)Self)->FindBestAxisVectors3(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FVector4_GetSafeNormal(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector4(((FVector4*)Self)->GetSafeNormal(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector4_GetUnsafeNormal3(INT_PTR Self)
	{
		return (INT_PTR) new FVector4(((FVector4*)Self)->GetUnsafeNormal3());
	}

	DOTNET_EXPORT bool E_FVector4_InitFromString(INT_PTR Self, char* InSourceString)
	{
		auto _p0 = FString(InSourceString);
		return ((FVector4*)Self)->InitFromString(_p0);
	}

	DOTNET_EXPORT bool E_FVector4_IsNearlyZero3(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FVector4*)Self)->IsNearlyZero3(_p0);
	}

	DOTNET_EXPORT bool E_FVector4_IsUnit3(INT_PTR Self, float LengthSquaredTolerance)
	{
		auto _p0 = LengthSquaredTolerance;
		return ((FVector4*)Self)->IsUnit3(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FVector4_Reflect3(INT_PTR Self, INT_PTR Normal)
	{
		auto _p0 = *(FVector4*)Normal;
		return (INT_PTR) new FVector4(((FVector4*)Self)->Reflect3(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector4_Rotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FVector4*)Self)->Rotation());
	}

	DOTNET_EXPORT INT_PTR E_FVector4_SafeNormal(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FVector4(((FVector4*)Self)->SafeNormal(_p0));
	}

	DOTNET_EXPORT void E_FVector4_Set(INT_PTR Self, float InX, float InY, float InZ, float InW)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		auto _p3 = InW;
		((FVector4*)Self)->Set(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT float E_FVector4_Size(INT_PTR Self)
	{
		return ((FVector4*)Self)->Size();
	}

	DOTNET_EXPORT float E_FVector4_Size3(INT_PTR Self)
	{
		return ((FVector4*)Self)->Size3();
	}

	DOTNET_EXPORT float E_FVector4_SizeSquared(INT_PTR Self)
	{
		return ((FVector4*)Self)->SizeSquared();
	}

	DOTNET_EXPORT float E_FVector4_SizeSquared3(INT_PTR Self)
	{
		return ((FVector4*)Self)->SizeSquared3();
	}

	DOTNET_EXPORT INT_PTR E_FVector4_ToOrientationQuat(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FVector4*)Self)->ToOrientationQuat());
	}

	DOTNET_EXPORT INT_PTR E_FVector4_ToOrientationRotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FVector4*)Self)->ToOrientationRotator());
	}

	DOTNET_EXPORT char* E_FVector4_ToString(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((FVector4*)Self)->ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT INT_PTR E_FVector4_UnsafeNormal3(INT_PTR Self)
	{
		return (INT_PTR) new FVector4(((FVector4*)Self)->UnsafeNormal3());
	}

	
	/*	FWeightedBlendable	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWeightedBlendable() { return (INT_PTR) new FWeightedBlendable(); }
	
	DOTNET_EXPORT UObject* E_PROP_FWeightedBlendable_Object_GET(INT_PTR Ptr) { return ((FWeightedBlendable*)Ptr)->Object; }
	DOTNET_EXPORT void E_PROP_FWeightedBlendable_Object_SET(INT_PTR Ptr, UObject* Value) { ((FWeightedBlendable*)Ptr)->Object = Value; }
	
	DOTNET_EXPORT float E_PROP_FWeightedBlendable_Weight_GET(INT_PTR Ptr) { return ((FWeightedBlendable*)Ptr)->Weight; }
	DOTNET_EXPORT void E_PROP_FWeightedBlendable_Weight_SET(INT_PTR Ptr, float Value) { ((FWeightedBlendable*)Ptr)->Weight = Value; }
	
	
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
	
	DOTNET_EXPORT INT_PTR E_PROP_FWorldContext_LastRemoteURL_GET(INT_PTR Ptr) { return (INT_PTR) new FURL(((FWorldContext*)Ptr)->LastRemoteURL); }
	DOTNET_EXPORT void E_PROP_FWorldContext_LastRemoteURL_SET(INT_PTR Ptr, INT_PTR Value) { ((FWorldContext*)Ptr)->LastRemoteURL = *(FURL*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_FWorldContext_LastURL_GET(INT_PTR Ptr) { return (INT_PTR) new FURL(((FWorldContext*)Ptr)->LastURL); }
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
	
	DOTNET_EXPORT void E_FWorldContext_SetCurrentWorld(INT_PTR Self, UWorld* World)
	{
		auto _p0 = World;
		((FWorldContext*)Self)->SetCurrentWorld(_p0);
	}

	DOTNET_EXPORT UWorld* E_FWorldContext_World(INT_PTR Self)
	{
		return ((FWorldContext*)Self)->World();
	}

}
