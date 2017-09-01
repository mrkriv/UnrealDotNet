#pragma once

#include "CoreMinimal.h"
#include "Components/ForceFeedbackComponent.h"

extern "C"
{
	DOTNET_EXPORT uint8 E_PROP_UForceFeedbackComponent_bAutoDestroy_GET(INT_PTR Ptr) { return ((UForceFeedbackComponent*)Ptr)->bAutoDestroy; }
	DOTNET_EXPORT void E_PROP_UForceFeedbackComponent_bAutoDestroy_SET(INT_PTR Ptr, uint8 Value) { ((UForceFeedbackComponent*)Ptr)->bAutoDestroy = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_UForceFeedbackComponent_bStopWhenOwnerDestroyed_GET(INT_PTR Ptr) { return ((UForceFeedbackComponent*)Ptr)->bStopWhenOwnerDestroyed; }
	DOTNET_EXPORT void E_PROP_UForceFeedbackComponent_bStopWhenOwnerDestroyed_SET(INT_PTR Ptr, uint8 Value) { ((UForceFeedbackComponent*)Ptr)->bStopWhenOwnerDestroyed = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_UForceFeedbackComponent_bLooping_GET(INT_PTR Ptr) { return ((UForceFeedbackComponent*)Ptr)->bLooping; }
	DOTNET_EXPORT void E_PROP_UForceFeedbackComponent_bLooping_SET(INT_PTR Ptr, uint8 Value) { ((UForceFeedbackComponent*)Ptr)->bLooping = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_UForceFeedbackComponent_bOverrideAttenuation_GET(INT_PTR Ptr) { return ((UForceFeedbackComponent*)Ptr)->bOverrideAttenuation; }
	DOTNET_EXPORT void E_PROP_UForceFeedbackComponent_bOverrideAttenuation_SET(INT_PTR Ptr, uint8 Value) { ((UForceFeedbackComponent*)Ptr)->bOverrideAttenuation = Value; }
	
	DOTNET_EXPORT float E_PROP_UForceFeedbackComponent_IntensityMultiplier_GET(INT_PTR Ptr) { return ((UForceFeedbackComponent*)Ptr)->IntensityMultiplier; }
	DOTNET_EXPORT void E_PROP_UForceFeedbackComponent_IntensityMultiplier_SET(INT_PTR Ptr, float Value) { ((UForceFeedbackComponent*)Ptr)->IntensityMultiplier = Value; }
	
	DOTNET_EXPORT void E_UForceFeedbackComponent_Play(INT_PTR Self, float StartTime)
	{
		auto _p0 = StartTime;
		((UForceFeedbackComponent*)Self)->Play(_p0);
	}

	DOTNET_EXPORT void E_UForceFeedbackComponent_Stop(INT_PTR Self)
	{
		((UForceFeedbackComponent*)Self)->Stop();
	}

}
