#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Engine/Classes/Components/SkyLightComponent.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\SkyLightComponent.h:99

class E_PROTECTED_WRAP_USkyLightComponent : protected USkyLightComponent
{
public:
	void UpdateLimitedRenderingStateFast_WRAP()
	{
		UpdateLimitedRenderingStateFast();
	}

}
;

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_USkyLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USkyLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USkyLightComponent_RecaptureSky(USkyLightComponent* Self)
	{
		Self->RecaptureSky();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SanitizeCubemapSize(USkyLightComponent* Self)
	{
		Self->SanitizeCubemapSize();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(USkyLightComponent* Self)
	{
		Self->SetBlendDestinationCaptureIsDirty();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetCaptureIsDirty(USkyLightComponent* Self)
	{
		Self->SetCaptureIsDirty();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_UpdateLimitedRenderingStateFast(USkyLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->UpdateLimitedRenderingStateFast_WRAP();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
