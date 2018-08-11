#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Components/AudioComponent.h"
#include "ManageAudioComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:108

UCLASS()
class UNREALDOTNETRUNTIME_API UManageAudioComponent : public UAudioComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void FadeIn(float FadeInDuration, float FadeVolumeLevel, float StartTime) override;
	
	virtual void FadeOut(float FadeOutDuration, float FadeVolumeLevel) override;
	
	virtual void Play(float StartTime) override;
	
	virtual void Stop() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
