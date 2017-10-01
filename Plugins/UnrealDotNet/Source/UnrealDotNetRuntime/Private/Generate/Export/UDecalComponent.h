#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDecalComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDecalComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetTransformIncludingDecalSize(UDecalComponent* Self)
	{
		return (INT_PTR) new FTransform(Self->GetTransformIncludingDecalSize());
	}

	DOTNET_EXPORT auto E_UDecalComponent_LifeSpanCallback(UDecalComponent* Self)
	{
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->LifeSpanCallback_WRAP();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PushSelectionToProxy(UDecalComponent* Self)
	{
		Self->PushSelectionToProxy();
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetLifeSpan(UDecalComponent* Self, float LifeSpan)
	{
		auto _p0 = LifeSpan;
		Self->SetLifeSpan(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
