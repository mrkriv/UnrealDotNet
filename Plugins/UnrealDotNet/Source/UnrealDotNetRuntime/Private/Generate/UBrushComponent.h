#pragma once

#include "CoreMinimal.h"
#include "Components/BrushComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UBrushComponent_BuildSimpleBrushCollision(INT_PTR Self)
	{
		((UBrushComponent*)Self)->BuildSimpleBrushCollision();
	}

}
