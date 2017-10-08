#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/SkeletalMeshComponent.h"

extern "C"
{
	
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

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
