#pragma once

#include "CoreMinimal.h"
#include "Components/StereoLayerComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UStereoLayerComponent_SetQuadSize(INT_PTR Self, INT_PTR InQuadSize)
	{
		auto _p0 = *(FVector2D*)InQuadSize;
		((UStereoLayerComponent*)Self)->SetQuadSize(_p0);
	}

	DOTNET_EXPORT INT_PTR E_UStereoLayerComponent_GetQuadSize(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((UStereoLayerComponent*)Self)->GetQuadSize());
	}

	DOTNET_EXPORT void E_UStereoLayerComponent_SetUVRect(INT_PTR Self, INT_PTR InUVRect)
	{
		auto _p0 = *(FBox2D*)InUVRect;
		((UStereoLayerComponent*)Self)->SetUVRect(_p0);
	}

	DOTNET_EXPORT INT_PTR E_UStereoLayerComponent_GetUVRect(INT_PTR Self)
	{
		return (INT_PTR) new FBox2D(((UStereoLayerComponent*)Self)->GetUVRect());
	}

	DOTNET_EXPORT void E_UStereoLayerComponent_SetPriority(INT_PTR Self, int32 InPriority)
	{
		auto _p0 = InPriority;
		((UStereoLayerComponent*)Self)->SetPriority(_p0);
	}

	DOTNET_EXPORT int32 E_UStereoLayerComponent_GetPriority(INT_PTR Self)
	{
		return ((UStereoLayerComponent*)Self)->GetPriority();
	}

}
