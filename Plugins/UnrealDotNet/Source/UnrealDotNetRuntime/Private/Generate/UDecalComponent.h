#pragma once

#include "CoreMinimal.h"
#include "Components/DecalComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UDecalComponent_PushSelectionToProxy(INT_PTR Self)
	{
		((UDecalComponent*)Self)->PushSelectionToProxy();
	}

	DOTNET_EXPORT void E_UDecalComponent_SetLifeSpan(INT_PTR Self, float LifeSpan)
	{
		auto _p0 = LifeSpan;
		((UDecalComponent*)Self)->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT int32 E_UDecalComponent_GetNumMaterials(INT_PTR Self)
	{
		return ((UDecalComponent*)Self)->GetNumMaterials();
	}

	DOTNET_EXPORT INT_PTR E_UDecalComponent_GetTransformIncludingDecalSize(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((UDecalComponent*)Self)->GetTransformIncludingDecalSize());
	}

}
