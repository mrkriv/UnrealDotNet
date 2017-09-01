#pragma once

#include "CoreMinimal.h"
#include "Components/LightComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_ULightComponent_SetIntensity(INT_PTR Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		((ULightComponent*)Self)->SetIntensity(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetLightFunctionScale(INT_PTR Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		((ULightComponent*)Self)->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT void E_ULightComponent_SetAffectDynamicIndirectLighting(INT_PTR Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		((ULightComponent*)Self)->SetAffectDynamicIndirectLighting(_p0);
	}

	DOTNET_EXPORT bool E_ULightComponent_AffectsPrimitive(INT_PTR Self, UPrimitiveComponent* Primitive)
	{
		auto _p0 = Primitive;
		return ((ULightComponent*)Self)->AffectsPrimitive(_p0);
	}

	DOTNET_EXPORT INT_PTR E_ULightComponent_GetBoundingBox(INT_PTR Self)
	{
		return (INT_PTR) new FBox(((ULightComponent*)Self)->GetBoundingBox());
	}

	DOTNET_EXPORT INT_PTR E_ULightComponent_GetLightPosition(INT_PTR Self)
	{
		return (INT_PTR) new FVector4(((ULightComponent*)Self)->GetLightPosition());
	}

}
