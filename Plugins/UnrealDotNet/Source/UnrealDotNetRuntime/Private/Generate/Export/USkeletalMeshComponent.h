#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/SkeletalMeshComponent.h"

extern "C"
{
	DOTNET_EXPORT bool E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_GET(INT_PTR Ptr) { return ((USkeletalMeshComponent*)Ptr)->bLocalSpaceKinematics; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_SET(INT_PTR Ptr, bool Value) { ((USkeletalMeshComponent*)Ptr)->bLocalSpaceKinematics = Value; }
	
	DOTNET_EXPORT bool E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_GET(INT_PTR Ptr) { return ((USkeletalMeshComponent*)Ptr)->bUseRefPoseOnInitAnim; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_SET(INT_PTR Ptr, bool Value) { ((USkeletalMeshComponent*)Ptr)->bUseRefPoseOnInitAnim = Value; }
	
	DOTNET_EXPORT float E_PROP_USkeletalMeshComponent_ClothBlendWeight_GET(INT_PTR Ptr) { return ((USkeletalMeshComponent*)Ptr)->ClothBlendWeight; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_ClothBlendWeight_SET(INT_PTR Ptr, float Value) { ((USkeletalMeshComponent*)Ptr)->ClothBlendWeight = Value; }
	
	DOTNET_EXPORT float E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_GET(INT_PTR Ptr) { return ((USkeletalMeshComponent*)Ptr)->GlobalAnimRateScale; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_SET(INT_PTR Ptr, float Value) { ((USkeletalMeshComponent*)Ptr)->GlobalAnimRateScale = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_GET(INT_PTR Ptr) { return (INT_PTR)&((USkeletalMeshComponent*)Ptr)->LineCheckBoundsScale; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_SET(INT_PTR Ptr, INT_PTR Value) { ((USkeletalMeshComponent*)Ptr)->LineCheckBoundsScale = *(FVector*)Value; }
	
	DOTNET_EXPORT int32 E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_GET(INT_PTR Ptr) { return ((USkeletalMeshComponent*)Ptr)->RagdollAggregateThreshold; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_SET(INT_PTR Ptr, int32 Value) { ((USkeletalMeshComponent*)Ptr)->RagdollAggregateThreshold = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USkeletalMeshComponent_RootBoneTranslation_GET(INT_PTR Ptr) { return (INT_PTR)&((USkeletalMeshComponent*)Ptr)->RootBoneTranslation; }
	DOTNET_EXPORT void E_PROP_USkeletalMeshComponent_RootBoneTranslation_SET(INT_PTR Ptr, INT_PTR Value) { ((USkeletalMeshComponent*)Ptr)->RootBoneTranslation = *(FVector*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USkeletalMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USkeletalMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_USkeletalMeshComponent_ClearMorphTargets(INT_PTR Self)
	{
		((USkeletalMeshComponent*)Self)->ClearMorphTargets();
	}

	DOTNET_EXPORT void E_USkeletalMeshComponent_CreateBodySetup(INT_PTR Self)
	{
		((USkeletalMeshComponent*)Self)->CreateBodySetup();
	}

	DOTNET_EXPORT float E_USkeletalMeshComponent_GetMorphTarget(INT_PTR Self, char* MorphTargetName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(MorphTargetName));
		return ((USkeletalMeshComponent*)Self)->GetMorphTarget(_p0);
	}

	DOTNET_EXPORT float E_USkeletalMeshComponent_GetPlayRate(INT_PTR Self)
	{
		return ((USkeletalMeshComponent*)Self)->GetPlayRate();
	}

	DOTNET_EXPORT float E_USkeletalMeshComponent_GetPosition(INT_PTR Self)
	{
		return ((USkeletalMeshComponent*)Self)->GetPosition();
	}

	DOTNET_EXPORT bool E_USkeletalMeshComponent_IsPlaying(INT_PTR Self)
	{
		return ((USkeletalMeshComponent*)Self)->IsPlaying();
	}

	DOTNET_EXPORT void E_USkeletalMeshComponent_Play(INT_PTR Self, bool bLooping)
	{
		auto _p0 = bLooping;
		((USkeletalMeshComponent*)Self)->Play(_p0);
	}

	DOTNET_EXPORT void E_USkeletalMeshComponent_SetMorphTarget(INT_PTR Self, char* MorphTargetName, float Value, bool bRemoveZeroWeight)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(MorphTargetName));
		auto _p1 = Value;
		auto _p2 = bRemoveZeroWeight;
		((USkeletalMeshComponent*)Self)->SetMorphTarget(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_USkeletalMeshComponent_SetPlayRate(INT_PTR Self, float Rate)
	{
		auto _p0 = Rate;
		((USkeletalMeshComponent*)Self)->SetPlayRate(_p0);
	}

	DOTNET_EXPORT void E_USkeletalMeshComponent_SetPosition(INT_PTR Self, float InPos, bool bFireNotifies)
	{
		auto _p0 = InPos;
		auto _p1 = bFireNotifies;
		((USkeletalMeshComponent*)Self)->SetPosition(_p0, _p1);
	}

	DOTNET_EXPORT void E_USkeletalMeshComponent_Stop(INT_PTR Self)
	{
		((USkeletalMeshComponent*)Self)->Stop();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
