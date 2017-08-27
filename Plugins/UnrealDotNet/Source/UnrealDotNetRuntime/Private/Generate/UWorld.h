#pragma once

#include "CoreMinimal.h"
#include "Engine/World.h"
#include "Structures.h"

extern "C"
{
	DOTNET_EXPORT void E_UWorld_CreateFXSystem(INT_PTR Self)
	{
		((UWorld*)Self)->CreateFXSystem();
	}

	DOTNET_EXPORT void E_UWorld_SetShouldTick(INT_PTR Self, bool bInShouldTick)
	{
		auto _p0 = bInShouldTick;
		((UWorld*)Self)->SetShouldTick(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_ShouldTick(INT_PTR Self)
	{
		return ((UWorld*)Self)->ShouldTick();
	}

	DOTNET_EXPORT int32 E_UWorld_GetNumPawns(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetNumPawns();
	}

	DOTNET_EXPORT float E_UWorld_GetTimeSeconds(INT_PTR Self)
	{
		return ((UWorld*)Self)->GetTimeSeconds();
	}

	DOTNET_EXPORT float E_UWorld_TimeSince(INT_PTR Self, float Time)
	{
		auto _p0 = Time;
		return ((UWorld*)Self)->TimeSince(_p0);
	}

	DOTNET_EXPORT void E_UWorld_AddNetworkActor(INT_PTR Self, AActor* Actor)
	{
		auto _p0 = Actor;
		((UWorld*)Self)->AddNetworkActor(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_ContainsActor(INT_PTR Self, AActor* Actor)
	{
		auto _p0 = Actor;
		return ((UWorld*)Self)->ContainsActor(_p0);
	}

	DOTNET_EXPORT bool E_UWorld_AllowAudioPlayback(INT_PTR Self)
	{
		return ((UWorld*)Self)->AllowAudioPlayback();
	}

	DOTNET_EXPORT void E_UWorld_UpdateWorldComponents(INT_PTR Self, bool bRerunConstructionScripts, bool bCurrentLevelOnly)
	{
		auto _p0 = bRerunConstructionScripts;
		auto _p1 = bCurrentLevelOnly;
		((UWorld*)Self)->UpdateWorldComponents(_p0, _p1);
	}

	DOTNET_EXPORT void E_UWorld_CleanupWorld(INT_PTR Self, bool bSessionEnded, bool bCleanupResources, UWorld* NewWorld)
	{
		auto _p0 = bSessionEnded;
		auto _p1 = bCleanupResources;
		auto _p2 = NewWorld;
		((UWorld*)Self)->CleanupWorld(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UWorld_InitWorld(INT_PTR Self)
	{
		((UWorld*)Self)->InitWorld();
	}

}
