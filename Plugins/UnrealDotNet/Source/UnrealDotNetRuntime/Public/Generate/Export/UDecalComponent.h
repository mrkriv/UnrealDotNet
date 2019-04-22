#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/DecalComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

class E_PROTECTED_WRAP_UDecalComponent : protected UDecalComponent
{
public:
	void LifeSpanCallback_WRAP()
	{
		LifeSpanCallback();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UDecalComponent_bDestroyOwnerAfterFade_GET(UDecalComponent* Ptr) { return Ptr->bDestroyOwnerAfterFade; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_bDestroyOwnerAfterFade_SET(UDecalComponent* Ptr, uint8 Value) { Ptr->bDestroyOwnerAfterFade = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_DecalSize_GET(UDecalComponent* Ptr) { return (INT_PTR)&(Ptr->DecalSize); }
	DOTNET_EXPORT void E_PROP_UDecalComponent_DecalSize_SET(UDecalComponent* Ptr, INT_PTR Value) { Ptr->DecalSize = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeDuration_GET(UDecalComponent* Ptr) { return Ptr->FadeDuration; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeDuration_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeDuration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeInDuration_GET(UDecalComponent* Ptr) { return Ptr->FadeInDuration; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeInDuration_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeInDuration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeInStartDelay_GET(UDecalComponent* Ptr) { return Ptr->FadeInStartDelay; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeInStartDelay_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeInStartDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeScreenSize_GET(UDecalComponent* Ptr) { return Ptr->FadeScreenSize; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeScreenSize_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeScreenSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeStartDelay_GET(UDecalComponent* Ptr) { return Ptr->FadeStartDelay; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeStartDelay_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeStartDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_SortOrder_GET(UDecalComponent* Ptr) { return Ptr->SortOrder; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_SortOrder_SET(UDecalComponent* Ptr, int32 Value) { Ptr->SortOrder = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDecalComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDecalComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeDuration(UDecalComponent* Self)
	{
		return Self->GetFadeDuration();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeInDuration(UDecalComponent* Self)
	{
		return Self->GetFadeInDuration();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeInStartDelay(UDecalComponent* Self)
	{
		return Self->GetFadeInStartDelay();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeStartDelay(UDecalComponent* Self)
	{
		return Self->GetFadeStartDelay();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetNumMaterials(UDecalComponent* Self)
	{
		return Self->GetNumMaterials();
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

	DOTNET_EXPORT auto E_UDecalComponent_SetFadeIn(UDecalComponent* Self, float StartDelay, float Duaration)
	{
		auto _p0 = StartDelay;
		auto _p1 = Duaration;
		Self->SetFadeIn(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetFadeOut(UDecalComponent* Self, float StartDelay, float Duration, bool DestroyOwnerAfterFade)
	{
		auto _p0 = StartDelay;
		auto _p1 = Duration;
		auto _p2 = DestroyOwnerAfterFade;
		Self->SetFadeOut(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetFadeScreenSize(UDecalComponent* Self, float NewFadeScreenSize)
	{
		auto _p0 = NewFadeScreenSize;
		Self->SetFadeScreenSize(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetLifeSpan(UDecalComponent* Self, float LifeSpan)
	{
		auto _p0 = LifeSpan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetSortOrder(UDecalComponent* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetSortOrder(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
