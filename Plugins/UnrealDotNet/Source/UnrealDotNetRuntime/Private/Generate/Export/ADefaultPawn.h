#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/DefaultPawn.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_CollisionComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::CollisionComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MeshComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::MeshComponentName); }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_MovementComponentName_GET() { return ConvertToManage_StringWrapper(ADefaultPawn::MovementComponentName); }
	
	
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
