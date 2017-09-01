#pragma once

#include "CoreMinimal.h"
#include "Components/ModelComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UModelComponent_CopyElementsFrom(INT_PTR Self, UModelComponent* OtherModelComponent)
	{
		auto _p0 = OtherModelComponent;
		((UModelComponent*)Self)->CopyElementsFrom(_p0);
	}

	DOTNET_EXPORT void E_UModelComponent_ApplyTempElements(INT_PTR Self, bool bLightingWasSuccessful)
	{
		auto _p0 = bLightingWasSuccessful;
		((UModelComponent*)Self)->ApplyTempElements(_p0);
	}

}
