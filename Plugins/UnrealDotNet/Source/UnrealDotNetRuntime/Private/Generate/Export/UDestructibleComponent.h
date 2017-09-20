#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/DestructibleComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDestructibleComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDestructibleComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_UDestructibleComponent_SetChunkVisible(UDestructibleComponent* Self, int32 ChunkIndex, bool bInVisible)
	{
		auto _p0 = ChunkIndex;
		auto _p1 = bInVisible;
		(Self)->SetChunkVisible(_p0, _p1);
	}

	DOTNET_EXPORT void E_UDestructibleComponent_SetChunkWorldRT(UDestructibleComponent* Self, int32 ChunkIndex, INT_PTR WorldRotation, INT_PTR WorldTranslation)
	{
		auto _p0 = ChunkIndex;
		auto _p1 = *(FQuat*)WorldRotation;
		auto _p2 = *(FVector*)WorldTranslation;
		(Self)->SetChunkWorldRT(_p0, _p1, _p2);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
