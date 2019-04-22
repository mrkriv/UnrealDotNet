// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageAudioComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:110

bool UManageAudioComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageAudioComponent::FadeIn(float FadeInDuration, float FadeVolumeLevel, float StartTime)
{
	Super::FadeIn(FadeInDuration, FadeVolumeLevel, StartTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FadeIn", FadeInDuration, FadeVolumeLevel, StartTime);
}

void UManageAudioComponent::FadeOut(float FadeOutDuration, float FadeVolumeLevel)
{
	Super::FadeOut(FadeOutDuration, FadeVolumeLevel);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FadeOut", FadeOutDuration, FadeVolumeLevel);
}

void UManageAudioComponent::Play(float StartTime)
{
	Super::Play(StartTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Play", StartTime);
}

void UManageAudioComponent::Stop()
{
	Super::Stop();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Stop");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
