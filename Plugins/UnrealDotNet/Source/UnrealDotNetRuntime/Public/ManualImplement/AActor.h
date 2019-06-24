#pragma once

#include "CoreMinimal.h"
#include "CoreShell.h"
#include "DotnetMetadata.h"
#include "Runtime/Engine/Classes/GameFramework/Actor.h"

extern "C"
{
	DOTNET_EXPORT ObjectPointerDescription E_AActor_CreateDefaultSubobject(AActor* Self, char* ClassName, char* ComponentName);
	DOTNET_EXPORT ObjectPointerDescription E_AActor_SpawnActor(AActor* Self, char* ClassName, INT_PTR Transform);
	DOTNET_EXPORT ObjectPointerDescription E_AActor_SpawnActorManage(AActor* Self, char* ClassName, INT_PTR Transform, char* ManageClassName);
}