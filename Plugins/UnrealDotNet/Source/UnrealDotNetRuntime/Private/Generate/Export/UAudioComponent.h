#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/AudioComponent.h"

class E_PROTECTED_WRAP_UAudioComponent : protected UAudioComponent
{
public:
	void PlayInternal_WRAP(const float StartTime, const float FadeInDuration, const float FadeVolumeLevel)
	{
		PlayInternal(StartTime, FadeInDuration, FadeVolumeLevel);
	}

}
;

extern "C"
{
	DOTNET_EXPORT char* E_UAudioComponent_GetAudioComponentUserID(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((UAudioComponent*)Self)->GetAudioComponentUserID().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UAudioComponent_PlayInternal(INT_PTR Self, float StartTime, float FadeInDuration, float FadeVolumeLevel)
	{
		auto _p0 = StartTime;
		auto _p1 = FadeInDuration;
		auto _p2 = FadeVolumeLevel;
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->PlayInternal_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UAudioComponent_SetSoundParameter(INT_PTR Self, INT_PTR Param)
	{
		auto _p0 = *(FAudioComponentParam*)Param;
		((UAudioComponent*)Self)->SetSoundParameter(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
