#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/PoseableMeshComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PoseableMeshComponent.h:17

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPoseableMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPoseableMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CopyPoseFromSkeletalComponent(UPoseableMeshComponent* Self, USkeletalMeshComponent* InComponentToCopy)
	{
		auto _p0 = InComponentToCopy;
		Self->CopyPoseFromSkeletalComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_FillComponentSpaceTransforms(UPoseableMeshComponent* Self)
	{
		Self->FillComponentSpaceTransforms();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsRunningParallelEvaluation(UPoseableMeshComponent* Self)
	{
		return Self->IsRunningParallelEvaluation();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_MarkRefreshTransformDirty(UPoseableMeshComponent* Self)
	{
		Self->MarkRefreshTransformDirty();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ResetBoneTransformByName(UPoseableMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->ResetBoneTransformByName(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
