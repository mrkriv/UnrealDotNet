#pragma once

#include "CoreMinimal.h"
#include "Components/TimelineComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UTimelineComponent_Play(INT_PTR Self)
	{
		((UTimelineComponent*)Self)->Play();
	}

	DOTNET_EXPORT bool E_UTimelineComponent_IsPlaying(INT_PTR Self)
	{
		return ((UTimelineComponent*)Self)->IsPlaying();
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetPlaybackPosition(INT_PTR Self, float NewPosition, bool bFireEvents, bool bFireUpdate)
	{
		auto _p0 = NewPosition;
		auto _p1 = bFireEvents;
		auto _p2 = bFireUpdate;
		((UTimelineComponent*)Self)->SetPlaybackPosition(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_UTimelineComponent_GetPlaybackPosition(INT_PTR Self)
	{
		return ((UTimelineComponent*)Self)->GetPlaybackPosition();
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetLooping(INT_PTR Self, bool bNewLooping)
	{
		auto _p0 = bNewLooping;
		((UTimelineComponent*)Self)->SetLooping(_p0);
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetPlayRate(INT_PTR Self, float NewRate)
	{
		auto _p0 = NewRate;
		((UTimelineComponent*)Self)->SetPlayRate(_p0);
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetPropertySetObject(INT_PTR Self, UObject* NewPropertySetObject)
	{
		auto _p0 = NewPropertySetObject;
		((UTimelineComponent*)Self)->SetPropertySetObject(_p0);
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetDirectionPropertyName(INT_PTR Self, char* DirectionPropertyName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(DirectionPropertyName));
		((UTimelineComponent*)Self)->SetDirectionPropertyName(_p0);
	}

}
