#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/MeshComponent.h"

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

}
;

extern "C"
{
	DOTNET_EXPORT void E_UMeshComponent_CacheMaterialParameterNameIndices(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->CacheMaterialParameterNameIndices_WRAP();
	}

	DOTNET_EXPORT float E_UMeshComponent_GetScalarParameterDefaultValue(INT_PTR Self, char* ParameterName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(ParameterName));
		return ((UMeshComponent*)Self)->GetScalarParameterDefaultValue(_p0);
	}

	DOTNET_EXPORT void E_UMeshComponent_MarkCachedMaterialParameterNameIndicesDirty(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->MarkCachedMaterialParameterNameIndicesDirty_WRAP();
	}

	DOTNET_EXPORT void E_UMeshComponent_SetScalarParameterValueOnMaterials(INT_PTR Self, char* ParameterName, float ParameterValue)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(ParameterName));
		auto _p1 = ParameterValue;
		((UMeshComponent*)Self)->SetScalarParameterValueOnMaterials(_p0, _p1);
	}

	DOTNET_EXPORT void E_UMeshComponent_SetVectorParameterValueOnMaterials(INT_PTR Self, char* ParameterName, INT_PTR ParameterValue)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(ParameterName));
		auto _p1 = *(FVector*)ParameterValue;
		((UMeshComponent*)Self)->SetVectorParameterValueOnMaterials(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
