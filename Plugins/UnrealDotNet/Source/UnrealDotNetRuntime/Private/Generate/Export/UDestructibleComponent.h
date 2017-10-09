#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/DestructibleComponent.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\DestructibleComponent.h:57

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDestructibleComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDestructibleComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDestructibleComponent_SetChunkVisible(UDestructibleComponent* Self, int32 ChunkIndex, bool bInVisible)
	{
		auto _p0 = ChunkIndex;
		auto _p1 = bInVisible;
		Self->SetChunkVisible(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
