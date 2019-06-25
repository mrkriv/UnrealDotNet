#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/MeshComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\MeshComponent.h:21

class E_PROTECTED_WRAP_UMeshComponent : protected UMeshComponent
{
public:
	void CacheMaterialParameterNameIndices_WRAP()
	{
		CacheMaterialParameterNameIndices();
	}

	void MarkCachedMaterialParameterNameIndicesDirty_WRAP()
	{
		MarkCachedMaterialParameterNameIndicesDirty();
	}

};


extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UMeshComponent_CacheMaterialParameterNameIndices(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->CacheMaterialParameterNameIndices_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_EmptyOverrideMaterials(UMeshComponent* Self)
	{
		Self->EmptyOverrideMaterials();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetMaterialIndex(UMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->GetMaterialIndex(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetNumOverrideMaterials(UMeshComponent* Self)
	{
		return Self->GetNumOverrideMaterials();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetScalarParameterDefaultValue(UMeshComponent* Self, char* ParameterName)
	{
		auto _p0 = ConvertFromManage_FName(ParameterName);
		return Self->GetScalarParameterDefaultValue(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsMaterialSlotNameValid(UMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->IsMaterialSlotNameValid(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_MarkCachedMaterialParameterNameIndicesDirty(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->MarkCachedMaterialParameterNameIndicesDirty_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PrestreamTextures(UMeshComponent* Self, float Seconds, bool bPrioritizeCharacterTextures, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bPrioritizeCharacterTextures;
		auto _p2 = CinematicTextureGroups;
		Self->PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetScalarParameterValueOnMaterials(UMeshComponent* Self, char* ParameterName, float ParameterValue)
	{
		auto _p0 = ConvertFromManage_FName(ParameterName);
		auto _p1 = ParameterValue;
		Self->SetScalarParameterValueOnMaterials(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetTextureForceResidentFlag(UMeshComponent* Self, bool bForceMiplevelsToBeResident)
	{
		auto _p0 = bForceMiplevelsToBeResident;
		Self->SetTextureForceResidentFlag(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetVectorParameterValueOnMaterials(UMeshComponent* Self, char* ParameterName, INT_PTR ParameterValue)
	{
		auto _p0 = ConvertFromManage_FName(ParameterName);
		auto _p1 = *(FVector*)ParameterValue;
		Self->SetVectorParameterValueOnMaterials(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
