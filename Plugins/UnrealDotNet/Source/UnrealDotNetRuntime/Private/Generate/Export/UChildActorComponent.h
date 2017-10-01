#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/ChildActorComponent.h"

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
		return ConvertForManage(Self->GetChildActor());
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetChildActorName(UChildActorComponent* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->GetChildActorName().ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_UChildActorComponent_GetChildActorTemplate(UChildActorComponent* Self)
	{
		return ConvertForManage(Self->GetChildActorTemplate());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
