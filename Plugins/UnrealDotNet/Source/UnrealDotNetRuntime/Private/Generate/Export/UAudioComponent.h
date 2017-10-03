#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UAudioComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UAudioComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetAudioComponentUserID(UAudioComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetAudioComponentUserID());
	}

	DOTNET_EXPORT auto E_UAudioComponent_PlayInternal(UAudioComponent* Self, float StartTime, float FadeInDuration, float FadeVolumeLevel)
	{
		auto _p0 = StartTime;
		auto _p1 = FadeInDuration;
		auto _p2 = FadeVolumeLevel;
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->PlayInternal_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetSoundParameter(UAudioComponent* Self, INT_PTR Param)
	{
		auto _p0 = *(FAudioComponentParam*)Param;
		Self->SetSoundParameter(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
