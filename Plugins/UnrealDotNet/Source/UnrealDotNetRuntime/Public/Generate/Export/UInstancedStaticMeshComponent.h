#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/InstancedStaticMeshComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:120

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UInstancedStaticMeshComponent_InstanceEndCullDistance_GET(UInstancedStaticMeshComponent* Ptr) { return Ptr->InstanceEndCullDistance; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_InstanceEndCullDistance_SET(UInstancedStaticMeshComponent* Ptr, int32 Value) { Ptr->InstanceEndCullDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInstancedStaticMeshComponent_InstanceStartCullDistance_GET(UInstancedStaticMeshComponent* Ptr) { return Ptr->InstanceStartCullDistance; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_InstanceStartCullDistance_SET(UInstancedStaticMeshComponent* Ptr, int32 Value) { Ptr->InstanceStartCullDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInstancedStaticMeshComponent_InstancingRandomSeed_GET(UInstancedStaticMeshComponent* Ptr) { return Ptr->InstancingRandomSeed; }
	DOTNET_EXPORT void E_PROP_UInstancedStaticMeshComponent_InstancingRandomSeed_SET(UInstancedStaticMeshComponent* Ptr, int32 Value) { Ptr->InstancingRandomSeed = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInstancedStaticMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInstancedStaticMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddInstance(UInstancedStaticMeshComponent* Self, INT_PTR InstanceTransform)
	{
		auto& _p0 = *(FTransform*)InstanceTransform;
		return Self->AddInstance(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_AddInstanceWorldSpace(UInstancedStaticMeshComponent* Self, INT_PTR WorldTransform)
	{
		auto& _p0 = *(FTransform*)WorldTransform;
		return Self->AddInstanceWorldSpace(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_ClearInstances(UInstancedStaticMeshComponent* Self)
	{
		Self->UInstancedStaticMeshComponent::ClearInstances();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetInstanceCount(UInstancedStaticMeshComponent* Self)
	{
		return Self->GetInstanceCount();
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_GetInstanceTransform(UInstancedStaticMeshComponent* Self, int32 InstanceIndex, INT_PTR OutInstanceTransform, bool bWorldSpace)
	{
		auto _p0 = InstanceIndex;
		auto& _p1 = *(FTransform*)OutInstanceTransform;
		auto _p2 = bWorldSpace;
		return Self->GetInstanceTransform(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_PreAllocateInstancesMemory(UInstancedStaticMeshComponent* Self, int32 AddedInstanceCount)
	{
		auto _p0 = AddedInstanceCount;
		Self->UInstancedStaticMeshComponent::PreAllocateInstancesMemory(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_RemoveInstance(UInstancedStaticMeshComponent* Self, int32 InstanceIndex)
	{
		auto _p0 = InstanceIndex;
		return Self->RemoveInstance(_p0);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_SetCullDistances(UInstancedStaticMeshComponent* Self, int32 StartCullDistance, int32 EndCullDistance)
	{
		auto _p0 = StartCullDistance;
		auto _p1 = EndCullDistance;
		Self->SetCullDistances(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInstancedStaticMeshComponent_UpdateInstanceTransform(UInstancedStaticMeshComponent* Self, int32 InstanceIndex, INT_PTR NewInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport)
	{
		auto _p0 = InstanceIndex;
		auto& _p1 = *(FTransform*)NewInstanceTransform;
		auto _p2 = bWorldSpace;
		auto _p3 = bMarkRenderStateDirty;
		auto _p4 = bTeleport;
		return Self->UpdateInstanceTransform(_p0, _p1, _p2, _p3, _p4);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
