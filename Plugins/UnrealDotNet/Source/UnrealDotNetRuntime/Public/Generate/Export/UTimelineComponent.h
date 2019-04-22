#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/TimelineComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:391

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UTimelineComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UTimelineComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetIgnoreTimeDilation(UTimelineComponent* Self)
	{
		return Self->GetIgnoreTimeDilation();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetPlaybackPosition(UTimelineComponent* Self)
	{
		return Self->GetPlaybackPosition();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetPlayRate(UTimelineComponent* Self)
	{
		return Self->GetPlayRate();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetTimelineLength(UTimelineComponent* Self)
	{
		return Self->GetTimelineLength();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsLooping(UTimelineComponent* Self)
	{
		return Self->IsLooping();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsPlaying(UTimelineComponent* Self)
	{
		return Self->IsPlaying();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsReversing(UTimelineComponent* Self)
	{
		return Self->IsReversing();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_Play(UTimelineComponent* Self)
	{
		Self->Play();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PlayFromStart(UTimelineComponent* Self)
	{
		Self->PlayFromStart();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_Reverse(UTimelineComponent* Self)
	{
		Self->Reverse();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_ReverseFromEnd(UTimelineComponent* Self)
	{
		Self->ReverseFromEnd();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetDirectionPropertyName(UTimelineComponent* Self, char* DirectionPropertyName)
	{
		auto _p0 = ConvertFromManage_FName(DirectionPropertyName);
		Self->SetDirectionPropertyName(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetIgnoreTimeDilation(UTimelineComponent* Self, bool bNewIgnoreTimeDilation)
	{
		auto _p0 = bNewIgnoreTimeDilation;
		Self->SetIgnoreTimeDilation(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetLooping(UTimelineComponent* Self, bool bNewLooping)
	{
		auto _p0 = bNewLooping;
		Self->SetLooping(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetNewTime(UTimelineComponent* Self, float NewTime)
	{
		auto _p0 = NewTime;
		Self->SetNewTime(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetPlaybackPosition(UTimelineComponent* Self, float NewPosition, bool bFireEvents, bool bFireUpdate)
	{
		auto _p0 = NewPosition;
		auto _p1 = bFireEvents;
		auto _p2 = bFireUpdate;
		Self->SetPlaybackPosition(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetPlayRate(UTimelineComponent* Self, float NewRate)
	{
		auto _p0 = NewRate;
		Self->SetPlayRate(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetPropertySetObject(UTimelineComponent* Self, UObject* NewPropertySetObject)
	{
		auto _p0 = NewPropertySetObject;
		Self->SetPropertySetObject(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetTimelineLength(UTimelineComponent* Self, float NewLength)
	{
		auto _p0 = NewLength;
		Self->SetTimelineLength(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetTimelineLengthMode(UTimelineComponent* Self, ETimelineLengthMode NewLengthMode)
	{
		auto _p0 = NewLengthMode;
		Self->SetTimelineLengthMode(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_Stop(UTimelineComponent* Self)
	{
		Self->Stop();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
