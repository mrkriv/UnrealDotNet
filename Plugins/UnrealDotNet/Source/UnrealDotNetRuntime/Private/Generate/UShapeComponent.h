#pragma once

#include "CoreMinimal.h"
#include "Components/ShapeComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UShapeComponent_UpdateBodySetup(INT_PTR Self)
	{
		((UShapeComponent*)Self)->UpdateBodySetup();
	}

}
