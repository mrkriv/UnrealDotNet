#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageAudioComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:108

void UManageAudioComponent::FadeIn(float FadeInDuration, float FadeVolumeLevel, float StartTime)
{
	Super::FadeIn(FadeInDuration, FadeVolumeLevel, StartTime);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "FadeIn", FadeInDuration, FadeVolumeLevel, StartTime);
}

void UManageAudioComponent::FadeOut(float FadeOutDuration, float FadeVolumeLevel)
{
	Super::FadeOut(FadeOutDuration, FadeVolumeLevel);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "FadeOut", FadeOutDuration, FadeVolumeLevel);
}

void UManageAudioComponent::Play(float StartTime)
{
	Super::Play(StartTime);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "Play", StartTime);
}

void UManageAudioComponent::Stop()
{
	Super::Stop();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "Stop");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
