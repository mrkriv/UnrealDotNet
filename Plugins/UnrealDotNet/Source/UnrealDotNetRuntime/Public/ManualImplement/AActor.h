#pragma once

#include "CoreMinimal.h"
#include "DotnetMetadata.h"
#include "Runtime/Engine/Classes/GameFramework/Actor.h"

extern "C"
{
	DOTNET_EXPORT INT_PTR E_AActor_CreateDefaultSubobject(AActor* Self, char* bb, char* ClassName, char* ComponentName)
	{
		auto className = UTF8_TO_TCHAR(ClassName);
		auto componentName = UTF8_TO_TCHAR(ComponentName);

		auto componentClass = FindObject<UClass>(ANY_PACKAGE, className);

		return (INT_PTR) Self->CreateDefaultSubobject(componentName, componentClass, componentClass, true, false, false);
	}
}