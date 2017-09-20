#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "GameFramework/DefaultPawn.h"

extern "C"
{
	DOTNET_EXPORT char* E_PROP_ADefaultPawn_CollisionComponentName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((ADefaultPawn*)Ptr)->CollisionComponentName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_ADefaultPawn_CollisionComponentName_SET(INT_PTR Ptr, char* Value) { ((ADefaultPawn*)Ptr)->CollisionComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_ADefaultPawn_MeshComponentName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((ADefaultPawn*)Ptr)->MeshComponentName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_ADefaultPawn_MeshComponentName_SET(INT_PTR Ptr, char* Value) { ((ADefaultPawn*)Ptr)->MeshComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	DOTNET_EXPORT char* E_PROP_ADefaultPawn_MovementComponentName_GET(INT_PTR Ptr, int& ResultStringLen)
	{
		auto _result = ((ADefaultPawn*)Ptr)->MovementComponentName.ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}
	DOTNET_EXPORT void E_PROP_ADefaultPawn_MovementComponentName_SET(INT_PTR Ptr, char* Value) { ((ADefaultPawn*)Ptr)->MovementComponentName = FName(UTF8_TO_TCHAR(Value)); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ADefaultPawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ADefaultPawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT ObjectPointerDescription E_ADefaultPawn_GetCollisionComponent(ADefaultPawn* Self)
	{
		return MakePrtDesc((Self)->GetCollisionComponent());
	}

	DOTNET_EXPORT ObjectPointerDescription E_ADefaultPawn_GetMeshComponent(ADefaultPawn* Self)
	{
		return MakePrtDesc((Self)->GetMeshComponent());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
