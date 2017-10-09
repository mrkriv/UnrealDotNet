#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "GameFramework/DefaultPawn.h"

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_CollisionComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::CollisionComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MeshComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::MeshComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MovementComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::MovementComponentName); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ADefaultPawn(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ADefaultPawn>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
