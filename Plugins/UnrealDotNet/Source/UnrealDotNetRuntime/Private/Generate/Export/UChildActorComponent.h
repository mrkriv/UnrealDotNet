#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/ChildActorComponent.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ChildActorComponent.h:44

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UChildActorComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UChildActorComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UChildActorComponent_CreateChildActor(UChildActorComponent* Self)
	{
		Self->CreateChildActor();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_DestroyChildActor(UChildActorComponent* Self)
	{
		Self->DestroyChildActor();
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetChildActorName(UChildActorComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetChildActorName());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
