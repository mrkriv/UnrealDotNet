#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "GameFramework/DefaultPawn.h"

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_CollisionComponentName_GET(ADefaultPawn* Ptr) { return ConvertToManage_StringWrapper(Ptr->CollisionComponentName); }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_CollisionComponentName_SET(ADefaultPawn* Ptr, char* Value) { Ptr->CollisionComponentName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MeshComponentName_GET(ADefaultPawn* Ptr) { return ConvertToManage_StringWrapper(Ptr->MeshComponentName); }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_MeshComponentName_SET(ADefaultPawn* Ptr, char* Value) { Ptr->MeshComponentName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MovementComponentName_GET(ADefaultPawn* Ptr) { return ConvertToManage_StringWrapper(Ptr->MovementComponentName); }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_MovementComponentName_SET(ADefaultPawn* Ptr, char* Value) { Ptr->MovementComponentName = ConvertFromManage_FName(Value); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ADefaultPawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ADefaultPawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetCollisionComponent(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCollisionComponent());
	}

	DOTNET_EXPORT auto E_ADefaultPawn_GetMeshComponent(ADefaultPawn* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetMeshComponent());
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
