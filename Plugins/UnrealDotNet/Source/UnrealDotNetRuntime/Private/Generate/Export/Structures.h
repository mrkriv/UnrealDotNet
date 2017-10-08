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
#include "UObject/UObjectArray.h"
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
	
	
	/*	FActorComponentTickFunction	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActorComponentTickFunction() { return (INT_PTR) new FActorComponentTickFunction(); }
	
	
	/*	FActorSpawnParameters	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActorSpawnParameters() { return (INT_PTR) new FActorSpawnParameters(); }
	
	DOTNET_EXPORT auto E_FActorSpawnParameters_IsRemoteOwned(FActorSpawnParameters* Self)
	{
		return Self->IsRemoteOwned();
	}

	
	/*	FActorTickFunction	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FActorTickFunction() { return (INT_PTR) new FActorTickFunction(); }
	
	
	/*	FAnimationEvaluationContext	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAnimationEvaluationContext() { return (INT_PTR) new FAnimationEvaluationContext(); }
	
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
	
	
	/*	FAnimSlotInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAnimSlotInfo() { return (INT_PTR) new FAnimSlotInfo(); }
	
	
	/*	FAttachmentTransformRules	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool(EAttachmentRule InRule, bool bInWeldSimulatedBodies) { return (INT_PTR) new FAttachmentTransformRules(InRule, bInWeldSimulatedBodies); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool(EAttachmentRule InLocationRule, EAttachmentRule InRotationRule, EAttachmentRule InScaleRule, bool bInWeldSimulatedBodies) { return (INT_PTR) new FAttachmentTransformRules(InLocationRule, InRotationRule, InScaleRule, bInWeldSimulatedBodies); }
	
	
	/*	FAudioComponentParam	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAudioComponentParam_FName(char* Name) { return (INT_PTR) new FAudioComponentParam(ConvertFromManage_FName(Name)); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FAudioComponentParam() { return (INT_PTR) new FAudioComponentParam(); }
	
	
	/*	FBasedMovementInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBasedMovementInfo() { return (INT_PTR) new FBasedMovementInfo(); }
	
	DOTNET_EXPORT auto E_FBasedMovementInfo_HasRelativeLocation(FBasedMovementInfo* Self)
	{
		return Self->HasRelativeLocation();
	}

	DOTNET_EXPORT auto E_FBasedMovementInfo_HasRelativePosition(FBasedMovementInfo* Self)
	{
		return Self->HasRelativePosition();
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
	
	
	/*	FBatchedMesh	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBatchedMesh() { return (INT_PTR) new FBatchedMesh(); }
	
	
	/*	FBatchedPoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBatchedPoint() { return (INT_PTR) new FBatchedPoint(); }
	
	
	/*	FBox	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox() { return (INT_PTR) new FBox(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox_int32(int32 _p0) { return (INT_PTR) new FBox(_p0); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox_FVector_FVector(INT_PTR InMin, INT_PTR InMax) { return (INT_PTR) new FBox(*(FVector*)InMin, *(FVector*)InMax); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox_FVector_int32(INT_PTR Points, int32 Count) { return (INT_PTR) new FBox((FVector*)Points, Count); }
	
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
	
	DOTNET_EXPORT auto E_FCameraExposureSettings_ExportToPostProcessSettings(FCameraExposureSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FCanvasUVTri	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FCanvasUVTri() { return (INT_PTR) new FCanvasUVTri(); }
	
	
	/*	FClassRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClassRedirect() { return (INT_PTR) new FClassRedirect(); }
	
	
	/*	FClosestPointOnPhysicsAsset	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClosestPointOnPhysicsAsset() { return (INT_PTR) new FClosestPointOnPhysicsAsset(); }
	
	
	/*	FClusterNode	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClusterNode() { return (INT_PTR) new FClusterNode(); }
	
	
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
	
	
	/*	FColorGradingSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FColorGradingSettings() { return (INT_PTR) new FColorGradingSettings(); }
	
	DOTNET_EXPORT auto E_FColorGradingSettings_ExportToPostProcessSettings(FColorGradingSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FComponentReference	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FComponentReference() { return (INT_PTR) new FComponentReference(); }
	
	DOTNET_EXPORT auto E_FComponentReference_GetComponent(FComponentReference* Self, AActor* OwningActor)
	{
		auto _p0 = OwningActor;
		return ConvertToManage_ObjectPointerDescription(Self->GetComponent(_p0));
	}

	
	/*	FComponentSocketDescription	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FComponentSocketDescription() { return (INT_PTR) new FComponentSocketDescription(); }
	
	
	/*	FConstrainComponentPropName	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FConstrainComponentPropName() { return (INT_PTR) new FConstrainComponentPropName(); }
	
	
	/*	FConvolutionBloomSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FConvolutionBloomSettings() { return (INT_PTR) new FConvolutionBloomSettings(); }
	
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
	
	
	/*	FDestructibleChunkInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDestructibleChunkInfo() { return (INT_PTR) new FDestructibleChunkInfo(); }
	
	
	/*	FDetachmentTransformRules	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_bool(EDetachmentRule InRule, bool bInCallModify) { return (INT_PTR) new FDetachmentTransformRules(InRule, bInCallModify); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_EDetachmentRule_EDetachmentRule_bool(EDetachmentRule InLocationRule, EDetachmentRule InRotationRule, EDetachmentRule InScaleRule, bool bInCallModify) { return (INT_PTR) new FDetachmentTransformRules(InLocationRule, InRotationRule, InScaleRule, bInCallModify); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDetachmentTransformRules_FAttachmentTransformRules_bool(INT_PTR AttachmentRules, bool bInCallModify) { return (INT_PTR) new FDetachmentTransformRules(*(FAttachmentTransformRules*)AttachmentRules, bInCallModify); }
	
	
	/*	FDirectAttachChildrenAccessor	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDirectAttachChildrenAccessor() { return (INT_PTR) new FDirectAttachChildrenAccessor(); }
	
	
	/*	FDirectoryPath	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDirectoryPath() { return (INT_PTR) new FDirectoryPath(); }
	
	
	/*	FDropNoteInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDropNoteInfo() { return (INT_PTR) new FDropNoteInfo(); }
	
	
	/*	FEngineShowFlagsSetting	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FEngineShowFlagsSetting() { return (INT_PTR) new FEngineShowFlagsSetting(); }
	
	
	/*	FExposureSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FExposureSettings() { return (INT_PTR) new FExposureSettings(); }
	
	DOTNET_EXPORT auto E_FExposureSettings_ToString(FExposureSettings* Self)
	{
		return ConvertToManage_StringWrapper(Self->ToString());
	}

	
	/*	FFilePath	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFilePath() { return (INT_PTR) new FFilePath(); }
	
	
	/*	FFilmStockSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFilmStockSettings() { return (INT_PTR) new FFilmStockSettings(); }
	
	DOTNET_EXPORT auto E_FFilmStockSettings_ExportToPostProcessSettings(FFilmStockSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FFixedUObjectArray	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFixedUObjectArray() { return (INT_PTR) new FFixedUObjectArray(); }
	
	DOTNET_EXPORT auto E_FFixedUObjectArray_AddRange(FFixedUObjectArray* Self, int32 Count)
	{
		auto _p0 = Count;
		return Self->AddRange(_p0);
	}

	DOTNET_EXPORT auto E_FFixedUObjectArray_AddSingle(FFixedUObjectArray* Self)
	{
		return Self->AddSingle();
	}

	DOTNET_EXPORT auto E_FFixedUObjectArray_IsValidIndex(FFixedUObjectArray* Self, int32 Index)
	{
		auto _p0 = Index;
		return Self->IsValidIndex(_p0);
	}

	DOTNET_EXPORT auto E_FFixedUObjectArray_Num(FFixedUObjectArray* Self)
	{
		return Self->Num();
	}

	DOTNET_EXPORT auto E_FFixedUObjectArray_PreAllocate(FFixedUObjectArray* Self, int32 InMaxElements)
	{
		auto _p0 = InMaxElements;
		Self->PreAllocate(_p0);
	}

	
	/*	FFontRenderInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFontRenderInfo() { return (INT_PTR) new FFontRenderInfo(); }
	
	
	/*	FFractureEffect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFractureEffect() { return (INT_PTR) new FFractureEffect(); }
	
	
	/*	FFullyLoadedPackagesInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFullyLoadedPackagesInfo() { return (INT_PTR) new FFullyLoadedPackagesInfo(); }
	
	
	/*	FGameNameRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FGameNameRedirect() { return (INT_PTR) new FGameNameRedirect(); }
	
	
	/*	FHitResult	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FHitResult() { return (INT_PTR) new FHitResult(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FHitResult_float(float InTime) { return (INT_PTR) new FHitResult(InTime); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FHitResult_FVector_FVector(INT_PTR Start, INT_PTR End) { return (INT_PTR) new FHitResult(*(FVector*)Start, *(FVector*)End); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FHitResult_AActor_UPrimitiveComponent_FVector_FVector(AActor* InActor, UPrimitiveComponent* InComponent, INT_PTR HitLoc, INT_PTR HitNorm) { return (INT_PTR) new FHitResult(InActor, InComponent, *(FVector*)HitLoc, *(FVector*)HitNorm); }
	
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
	
	
	/*	FLensBloomSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensBloomSettings() { return (INT_PTR) new FLensBloomSettings(); }
	
	DOTNET_EXPORT auto E_FLensBloomSettings_ExportToPostProcessSettings(FLensBloomSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FLensImperfectionSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensImperfectionSettings() { return (INT_PTR) new FLensImperfectionSettings(); }
	
	DOTNET_EXPORT auto E_FLensImperfectionSettings_ExportToPostProcessSettings(FLensImperfectionSettings* Self, INT_PTR OutPostProcessSettings)
	{
		auto _p0 = (FPostProcessSettings*)OutPostProcessSettings;
		Self->ExportToPostProcessSettings(_p0);
	}

	
	/*	FLensSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLensSettings() { return (INT_PTR) new FLensSettings(); }
	
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
	
	
	/*	FLevelViewportInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelViewportInfo() { return (INT_PTR) new FLevelViewportInfo(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelViewportInfo_FVector_FRotator_float(INT_PTR InCamPosition, INT_PTR InCamRotation, float InCamOrthoZoom) { return (INT_PTR) new FLevelViewportInfo(*(FVector*)InCamPosition, *(FRotator*)InCamRotation, InCamOrthoZoom); }
	
	
	/*	FLightingChannels	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightingChannels() { return (INT_PTR) new FLightingChannels(); }
	
	
	/*	FLightmassDebugOptions	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassDebugOptions() { return (INT_PTR) new FLightmassDebugOptions(); }
	
	
	/*	FLightmassDirectionalLightSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassDirectionalLightSettings() { return (INT_PTR) new FLightmassDirectionalLightSettings(); }
	
	
	/*	FLightmassLightSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassLightSettings() { return (INT_PTR) new FLightmassLightSettings(); }
	
	
	/*	FLightmassPointLightSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassPointLightSettings() { return (INT_PTR) new FLightmassPointLightSettings(); }
	
	
	/*	FLightmassPrimitiveSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLightmassPrimitiveSettings() { return (INT_PTR) new FLightmassPrimitiveSettings(); }
	
	
	/*	FLocalizedSubtitle	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLocalizedSubtitle() { return (INT_PTR) new FLocalizedSubtitle(); }
	
	
	/*	FMaterialSpriteElement	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FMaterialSpriteElement() { return (INT_PTR) new FMaterialSpriteElement(); }
	
	
	/*	FMeshBuildSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FMeshBuildSettings() { return (INT_PTR) new FMeshBuildSettings(); }
	
	
	/*	FMTDResult	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FMTDResult() { return (INT_PTR) new FMTDResult(); }
	
	
	/*	FNetDriverDefinition	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FNetDriverDefinition() { return (INT_PTR) new FNetDriverDefinition(); }
	
	
	/*	FOverlapInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapInfo() { return (INT_PTR) new FOverlapInfo(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapInfo_FHitResult(INT_PTR InSweepResult) { return (INT_PTR) new FOverlapInfo(*(FHitResult*)InSweepResult); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapInfo_UPrimitiveComponent_int32(UPrimitiveComponent* InComponent, int32 InBodyIndex) { return (INT_PTR) new FOverlapInfo(InComponent, InBodyIndex); }
	
	DOTNET_EXPORT auto E_FOverlapInfo_GetBodyIndex(FOverlapInfo* Self)
	{
		return Self->GetBodyIndex();
	}

	
	/*	FOverlapResult	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FOverlapResult() { return (INT_PTR) new FOverlapResult(); }
	
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
	
	
	/*	FPlane	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane() { return (INT_PTR) new FPlane(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FPlane(INT_PTR P) { return (INT_PTR) new FPlane(*(FPlane*)P); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector4(INT_PTR V) { return (INT_PTR) new FPlane(*(FVector4*)V); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_float_float_float_float(float InX, float InY, float InZ, float InW) { return (INT_PTR) new FPlane(InX, InY, InZ, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector_float(INT_PTR InNormal, float InW) { return (INT_PTR) new FPlane(*(FVector*)InNormal, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector_FVector(INT_PTR InBase, INT_PTR InNormal) { return (INT_PTR) new FPlane(*(FVector*)InBase, *(FVector*)InNormal); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPlane_FVector_FVector_FVector(INT_PTR A, INT_PTR B, INT_PTR C) { return (INT_PTR) new FPlane(*(FVector*)A, *(FVector*)B, *(FVector*)C); }
	
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

	DOTNET_EXPORT auto E_FPlane_PlaneDot(FPlane* Self, INT_PTR P)
	{
		auto _p0 = *(FVector*)P;
		return Self->PlaneDot(_p0);
	}

	
	/*	FPluginRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPluginRedirect() { return (INT_PTR) new FPluginRedirect(); }
	
	
	/*	FPointDamageEvent	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPointDamageEvent() { return (INT_PTR) new FPointDamageEvent(); }
	
	
	/*	FPostProcessSettings	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPostProcessSettings() { return (INT_PTR) new FPostProcessSettings(); }
	
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
	
	
	/*	FPreCulledStaticMeshSection	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPreCulledStaticMeshSection() { return (INT_PTR) new FPreCulledStaticMeshSection(); }
	
	
	/*	FPrimitiveMaterialRef	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPrimitiveMaterialRef() { return (INT_PTR) new FPrimitiveMaterialRef(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPrimitiveMaterialRef_UPrimitiveComponent_int32(UPrimitiveComponent* InPrimitive, int32 InElementIndex) { return (INT_PTR) new FPrimitiveMaterialRef(InPrimitive, InElementIndex); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPrimitiveMaterialRef_UDecalComponent_int32(UDecalComponent* InDecal, int32 InElementIndex) { return (INT_PTR) new FPrimitiveMaterialRef(InDecal, InElementIndex); }
	
	
	/*	FQuat	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat() { return (INT_PTR) new FQuat(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_float_float_float_float(float InX, float InY, float InZ, float InW) { return (INT_PTR) new FQuat(InX, InY, InZ, InW); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_FQuat(INT_PTR Q) { return (INT_PTR) new FQuat(*(FQuat*)Q); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_FRotator(INT_PTR R) { return (INT_PTR) new FQuat(*(FRotator*)R); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat_FVector_float(INT_PTR Axis, float AngleRad) { return (INT_PTR) new FQuat(*(FVector*)Axis, AngleRad); }
	
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
	
	
	/*	FRadialDamageParams	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRadialDamageParams() { return (INT_PTR) new FRadialDamageParams(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRadialDamageParams_float_float_float_float(float InBaseDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff) { return (INT_PTR) new FRadialDamageParams(InBaseDamage, InInnerRadius, InOuterRadius, InDamageFalloff); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRadialDamageParams_float_float_float_float_float(float InBaseDamage, float InMinimumDamage, float InInnerRadius, float InOuterRadius, float InDamageFalloff) { return (INT_PTR) new FRadialDamageParams(InBaseDamage, InMinimumDamage, InInnerRadius, InOuterRadius, InDamageFalloff); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRadialDamageParams_float_float(float InBaseDamage, float InRadius) { return (INT_PTR) new FRadialDamageParams(InBaseDamage, InRadius); }
	
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
	
	
	/*	FReflectionCaptureFullHDR	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FReflectionCaptureFullHDR() { return (INT_PTR) new FReflectionCaptureFullHDR(); }
	
	DOTNET_EXPORT auto E_FReflectionCaptureFullHDR_HasValidData(FReflectionCaptureFullHDR* Self)
	{
		return Self->HasValidData();
	}

	
	/*	FRendererStencilMaskEvaluation	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRendererStencilMaskEvaluation() { return (INT_PTR) new FRendererStencilMaskEvaluation(); }
	
	
	/*	FRepAttachment	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRepAttachment() { return (INT_PTR) new FRepAttachment(); }
	
	
	/*	FReplicationFlags	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FReplicationFlags() { return (INT_PTR) new FReplicationFlags(); }
	
	
	/*	FRepMovement	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRepMovement() { return (INT_PTR) new FRepMovement(); }
	
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
	
	
	/*	FRigidBodyErrorCorrection	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRigidBodyErrorCorrection() { return (INT_PTR) new FRigidBodyErrorCorrection(); }
	
	
	/*	FRigidBodyState	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRigidBodyState() { return (INT_PTR) new FRigidBodyState(); }
	
	
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
	
	
	/*	FScopedLevelCollectionContextSwitch	*/
	
	
	/*	FScreenMessageString	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FScreenMessageString() { return (INT_PTR) new FScreenMessageString(); }
	
	
	/*	FSimulatedRootMotionReplicatedMove	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSimulatedRootMotionReplicatedMove() { return (INT_PTR) new FSimulatedRootMotionReplicatedMove(); }
	
	
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
	
	
	/*	FSplinePoint	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplinePoint() { return (INT_PTR) new FSplinePoint(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSplinePoint_float_FVector(float InInputKey, INT_PTR InPosition) { return (INT_PTR) new FSplinePoint(InInputKey, *(FVector*)InPosition); }
	
	
	/*	FSpriteCategoryInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSpriteCategoryInfo() { return (INT_PTR) new FSpriteCategoryInfo(); }
	
	
	/*	FStatColorMapEntry	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStatColorMapEntry() { return (INT_PTR) new FStatColorMapEntry(); }
	
	
	/*	FStatColorMapping	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStatColorMapping() { return (INT_PTR) new FStatColorMapping(); }
	
	
	/*	FStructRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStructRedirect() { return (INT_PTR) new FStructRedirect(); }
	
	
	/*	FSubtitleCue	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSubtitleCue() { return (INT_PTR) new FSubtitleCue(); }
	
	
	/*	FTickFunction	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTickFunction() { return (INT_PTR) new FTickFunction(); }
	
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
	
	
	/*	FTimelineFloatTrack	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineFloatTrack() { return (INT_PTR) new FTimelineFloatTrack(); }
	
	
	/*	FTimelineLinearColorTrack	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineLinearColorTrack() { return (INT_PTR) new FTimelineLinearColorTrack(); }
	
	
	/*	FTimelineVectorTrack	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTimelineVectorTrack() { return (INT_PTR) new FTimelineVectorTrack(); }
	
	
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
	
	
	/*	FVector	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector() { return (INT_PTR) new FVector(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_float(float InF) { return (INT_PTR) new FVector(InF); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_float_float_float(float InX, float InY, float InZ) { return (INT_PTR) new FVector(InX, InY, InZ); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_FVector2D_float(INT_PTR V, float InZ) { return (INT_PTR) new FVector(*(FVector2D*)V, InZ); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector_FVector4(INT_PTR V) { return (INT_PTR) new FVector(*(FVector4*)V); }
	
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
	
	DOTNET_EXPORT auto E_FVector4_Component(FVector4* Self, int32 Index)
	{
		auto _p0 = Index;
		return Self->Component(_p0);
	}

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

	DOTNET_EXPORT auto E_FVector4_UnsafeNormal3(FVector4* Self)
	{
		return (INT_PTR) new FVector4(Self->UnsafeNormal3());
	}

	
	/*	FWalkableSlopeOverride	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWalkableSlopeOverride() { return (INT_PTR) new FWalkableSlopeOverride(); }
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWalkableSlopeOverride_EWalkableSlopeBehavior_float(EWalkableSlopeBehavior NewSlopeBehavior, float NewSlopeAngle) { return (INT_PTR) new FWalkableSlopeOverride(NewSlopeBehavior, NewSlopeAngle); }
	
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
	
	
	/*	FWeightedBlendables	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWeightedBlendables() { return (INT_PTR) new FWeightedBlendables(); }
	
	
	/*	FWorldContext	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWorldContext() { return (INT_PTR) new FWorldContext(); }
	
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
