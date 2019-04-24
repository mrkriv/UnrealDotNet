#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/CheatManager.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

class E_PROTECTED_WRAP_UCheatManager : protected UCheatManager
{
public:
	void DisableDebugCamera_WRAP()
	{
		DisableDebugCamera();
	}

	void EnableDebugCamera_WRAP()
	{
		EnableDebugCamera();
	}

	AActor* GetTarget_WRAP(APlayerController* PlayerController, FHitResult& OutHit)
	{
		return GetTarget(PlayerController, OutHit);
	}

};


extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCheatManager(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCheatManager>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCheatManager_DisableDebugCamera(UCheatManager* Self)
	{
		((E_PROTECTED_WRAP_UCheatManager*)Self)->DisableDebugCamera_WRAP();
	}

	DOTNET_EXPORT auto E_UCheatManager_EnableDebugCamera(UCheatManager* Self)
	{
		((E_PROTECTED_WRAP_UCheatManager*)Self)->EnableDebugCamera_WRAP();
	}

	DOTNET_EXPORT auto E_UCheatManager_GetTarget(UCheatManager* Self, APlayerController* PlayerController, INT_PTR OutHit)
	{
		auto _p0 = PlayerController;
		auto& _p1 = *(FHitResult*)OutHit;
		return ConvertToManage_ObjectPointerDescription(((E_PROTECTED_WRAP_UCheatManager*)Self)->GetTarget_WRAP(_p0, _p1));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
