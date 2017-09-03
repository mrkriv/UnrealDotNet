#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/BrushComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UBrushComponent_BuildSimpleBrushCollision(INT_PTR Self)
	{
		((UBrushComponent*)Self)->BuildSimpleBrushCollision();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
