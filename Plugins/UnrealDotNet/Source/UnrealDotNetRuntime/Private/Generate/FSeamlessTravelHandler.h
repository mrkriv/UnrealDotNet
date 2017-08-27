#pragma once

#include "CoreMinimal.h"
#include "World.h"

extern "C"
{
	DOTNET_EXPORT bool E_FSeamlessTravelHandler_IsInTransition(INT_PTR Self)
	{
		return ((FSeamlessTravelHandler*)Self)->IsInTransition();
	}

	DOTNET_EXPORT void E_FSeamlessTravelHandler_CancelTravel(INT_PTR Self)
	{
		((FSeamlessTravelHandler*)Self)->CancelTravel();
	}

	DOTNET_EXPORT void E_FSeamlessTravelHandler_SetPauseAtMidpoint(INT_PTR Self, bool bNowPaused)
	{
		auto _p0 = bNowPaused;
		((FSeamlessTravelHandler*)Self)->SetPauseAtMidpoint(_p0);
	}

	DOTNET_EXPORT UWorld* E_FSeamlessTravelHandler_Tick(INT_PTR Self)
	{
		return ((FSeamlessTravelHandler*)Self)->Tick();
	}

}
