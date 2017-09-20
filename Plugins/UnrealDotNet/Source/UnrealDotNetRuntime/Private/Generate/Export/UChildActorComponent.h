#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/ChildActorComponent.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UChildActorComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UChildActorComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_UChildActorComponent_CreateChildActor(INT_PTR Self)
	{
		((UChildActorComponent*)Self)->CreateChildActor();
	}

	DOTNET_EXPORT void E_UChildActorComponent_DestroyChildActor(INT_PTR Self)
	{
		((UChildActorComponent*)Self)->DestroyChildActor();
	}

	DOTNET_EXPORT ObjectPointerDescription E_UChildActorComponent_GetChildActor(INT_PTR Self)
	{
		return MakePrtDesc(((UChildActorComponent*)Self)->GetChildActor());
	}

	DOTNET_EXPORT char* E_UChildActorComponent_GetChildActorName(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((UChildActorComponent*)Self)->GetChildActorName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT ObjectPointerDescription E_UChildActorComponent_GetChildActorTemplate(INT_PTR Self)
	{
		return MakePrtDesc(((UChildActorComponent*)Self)->GetChildActorTemplate());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
