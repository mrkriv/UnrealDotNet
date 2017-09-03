#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/DecalComponent.h"

class E_PROTECTED_WRAP_UDecalComponent : protected UDecalComponent
{
public:
	void LifeSpanCallback_WRAP()
	{
		LifeSpanCallback();
	}

}
;

extern "C"
{
	DOTNET_EXPORT INT_PTR E_UDecalComponent_GetTransformIncludingDecalSize(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((UDecalComponent*)Self)->GetTransformIncludingDecalSize());
	}

	DOTNET_EXPORT void E_UDecalComponent_LifeSpanCallback(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->LifeSpanCallback_WRAP();
	}

	DOTNET_EXPORT void E_UDecalComponent_PushSelectionToProxy(INT_PTR Self)
	{
		((UDecalComponent*)Self)->PushSelectionToProxy();
	}

	DOTNET_EXPORT void E_UDecalComponent_SetLifeSpan(INT_PTR Self, float LifeSpan)
	{
		auto _p0 = LifeSpan;
		((UDecalComponent*)Self)->SetLifeSpan(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
