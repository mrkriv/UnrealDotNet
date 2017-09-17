#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/TimelineComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UTimelineComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UTimelineComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT bool E_UTimelineComponent_GetIgnoreTimeDilation(INT_PTR Self)
	{
		return ((UTimelineComponent*)Self)->GetIgnoreTimeDilation();
	}

	DOTNET_EXPORT float E_UTimelineComponent_GetPlaybackPosition(INT_PTR Self)
	{
		return ((UTimelineComponent*)Self)->GetPlaybackPosition();
	}

	DOTNET_EXPORT float E_UTimelineComponent_GetPlayRate(INT_PTR Self)
	{
		return ((UTimelineComponent*)Self)->GetPlayRate();
	}

	DOTNET_EXPORT float E_UTimelineComponent_GetTimelineLength(INT_PTR Self)
	{
		return ((UTimelineComponent*)Self)->GetTimelineLength();
	}

	DOTNET_EXPORT bool E_UTimelineComponent_IsLooping(INT_PTR Self)
	{
		return ((UTimelineComponent*)Self)->IsLooping();
	}

	DOTNET_EXPORT bool E_UTimelineComponent_IsPlaying(INT_PTR Self)
	{
		return ((UTimelineComponent*)Self)->IsPlaying();
	}

	DOTNET_EXPORT bool E_UTimelineComponent_IsReversing(INT_PTR Self)
	{
		return ((UTimelineComponent*)Self)->IsReversing();
	}

	DOTNET_EXPORT void E_UTimelineComponent_Play(INT_PTR Self)
	{
		((UTimelineComponent*)Self)->Play();
	}

	DOTNET_EXPORT void E_UTimelineComponent_PlayFromStart(INT_PTR Self)
	{
		((UTimelineComponent*)Self)->PlayFromStart();
	}

	DOTNET_EXPORT void E_UTimelineComponent_Reverse(INT_PTR Self)
	{
		((UTimelineComponent*)Self)->Reverse();
	}

	DOTNET_EXPORT void E_UTimelineComponent_ReverseFromEnd(INT_PTR Self)
	{
		((UTimelineComponent*)Self)->ReverseFromEnd();
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetDirectionPropertyName(INT_PTR Self, char* DirectionPropertyName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(DirectionPropertyName));
		((UTimelineComponent*)Self)->SetDirectionPropertyName(_p0);
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetIgnoreTimeDilation(INT_PTR Self, bool bNewIgnoreTimeDilation)
	{
		auto _p0 = bNewIgnoreTimeDilation;
		((UTimelineComponent*)Self)->SetIgnoreTimeDilation(_p0);
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetLooping(INT_PTR Self, bool bNewLooping)
	{
		auto _p0 = bNewLooping;
		((UTimelineComponent*)Self)->SetLooping(_p0);
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetNewTime(INT_PTR Self, float NewTime)
	{
		auto _p0 = NewTime;
		((UTimelineComponent*)Self)->SetNewTime(_p0);
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetPlaybackPosition(INT_PTR Self, float NewPosition, bool bFireEvents, bool bFireUpdate)
	{
		auto _p0 = NewPosition;
		auto _p1 = bFireEvents;
		auto _p2 = bFireUpdate;
		((UTimelineComponent*)Self)->SetPlaybackPosition(_p0, _p1, _p2);
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

	DOTNET_EXPORT void E_UTimelineComponent_SetTimelineLength(INT_PTR Self, float NewLength)
	{
		auto _p0 = NewLength;
		((UTimelineComponent*)Self)->SetTimelineLength(_p0);
	}

	DOTNET_EXPORT void E_UTimelineComponent_SetTimelineLengthMode(INT_PTR Self, ETimelineLengthMode NewLengthMode)
	{
		auto _p0 = NewLengthMode;
		((UTimelineComponent*)Self)->SetTimelineLengthMode(_p0);
	}

	DOTNET_EXPORT void E_UTimelineComponent_Stop(INT_PTR Self)
	{
		((UTimelineComponent*)Self)->Stop();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
