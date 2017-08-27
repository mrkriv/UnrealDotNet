#pragma once

#include "CoreMinimal.h"
#include "Engine.h"

extern "C"
{
	DOTNET_EXPORT void E_UEngine_RestoreSelectedMaterialColor(INT_PTR Self)
	{
		((UEngine*)Self)->RestoreSelectedMaterialColor();
	}

	DOTNET_EXPORT void E_UEngine_WorldAdded(INT_PTR Self, UWorld* World)
	{
		auto _p0 = World;
		((UEngine*)Self)->WorldAdded(_p0);
	}

	DOTNET_EXPORT bool E_UEngine_IsInitialized(INT_PTR Self)
	{
		return ((UEngine*)Self)->IsInitialized();
	}

	DOTNET_EXPORT void E_UEngine_Tick(INT_PTR Self, float DeltaSeconds, bool bIdleMode)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = bIdleMode;
		((UEngine*)Self)->Tick(_p0, _p1);
	}

}
