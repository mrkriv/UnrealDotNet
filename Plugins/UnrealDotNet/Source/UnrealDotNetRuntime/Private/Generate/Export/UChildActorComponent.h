#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/ChildActorComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ChildActorComponent.h:44

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

	DOTNET_EXPORT auto E_UChildActorComponent_GetChildActor(UChildActorComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetChildActor());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetChildActorName(UChildActorComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetChildActorName());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetChildActorTemplate(UChildActorComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetChildActorTemplate());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
