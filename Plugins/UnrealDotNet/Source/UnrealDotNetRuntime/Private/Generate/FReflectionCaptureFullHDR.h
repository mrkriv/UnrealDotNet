#pragma once

#include "CoreMinimal.h"
#include "Components/ReflectionCaptureComponent.h"

extern "C"
{
	DOTNET_EXPORT int32 E_PROP_FReflectionCaptureFullHDR_CubemapSize_GET(INT_PTR Ptr) { return ((FReflectionCaptureFullHDR*)Ptr)->CubemapSize; }
	DOTNET_EXPORT void E_PROP_FReflectionCaptureFullHDR_CubemapSize_SET(INT_PTR Ptr, int32 Value) { ((FReflectionCaptureFullHDR*)Ptr)->CubemapSize = Value; }
	
	DOTNET_EXPORT bool E_FReflectionCaptureFullHDR_HasValidData(INT_PTR Self)
	{
		return ((FReflectionCaptureFullHDR*)Self)->HasValidData();
	}

}
