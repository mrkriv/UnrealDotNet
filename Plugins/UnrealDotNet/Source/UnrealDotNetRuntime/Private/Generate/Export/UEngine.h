#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Engine/Engine.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UEngine(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UEngine>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UEngine_IsInitialized(UEngine* Self)
	{
		return Self->IsInitialized();
	}

	DOTNET_EXPORT auto E_UEngine_ParseCommandline(UEngine* Self)
	{
		Self->ParseCommandline();
	}

	DOTNET_EXPORT auto E_UEngine_PreExit(UEngine* Self)
	{
		Self->PreExit();
	}

	DOTNET_EXPORT auto E_UEngine_RestoreSelectedMaterialColor(UEngine* Self)
	{
		Self->RestoreSelectedMaterialColor();
	}

	DOTNET_EXPORT auto E_UEngine_ShutdownAudioDeviceManager(UEngine* Self)
	{
		Self->ShutdownAudioDeviceManager();
	}

	DOTNET_EXPORT auto E_UEngine_ShutdownHMD(UEngine* Self)
	{
		Self->ShutdownHMD();
	}

	DOTNET_EXPORT auto E_UEngine_Start(UEngine* Self)
	{
		Self->Start();
	}

	DOTNET_EXPORT auto E_UEngine_Tick(UEngine* Self, float DeltaSeconds, bool bIdleMode)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = bIdleMode;
		Self->Tick(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UEngine_WorldAdded(UEngine* Self, UWorld* World)
	{
		auto _p0 = World;
		Self->WorldAdded(_p0);
	}

	DOTNET_EXPORT auto E_UEngine_WorldDestroyed(UEngine* Self, UWorld* InWorld)
	{
		auto _p0 = InWorld;
		Self->WorldDestroyed(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
