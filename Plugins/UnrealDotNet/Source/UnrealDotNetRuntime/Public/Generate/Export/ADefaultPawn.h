#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/DefaultPawn.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_BaseLookUpRate_GET(ADefaultPawn* Ptr) { return Ptr->BaseLookUpRate; }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_BaseLookUpRate_SET(ADefaultPawn* Ptr, float Value) { Ptr->BaseLookUpRate = Value; }
	
	DOTNET_EXPORT auto E_PROP_ADefaultPawn_BaseTurnRate_GET(ADefaultPawn* Ptr) { return Ptr->BaseTurnRate; }
	DOTNET_EXPORT void E_PROP_ADefaultPawn_BaseTurnRate_SET(ADefaultPawn* Ptr, float Value) { Ptr->BaseTurnRate = Value; }
	
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

	DOTNET_EXPORT auto E_ADefaultPawn_LookUpAtRate(ADefaultPawn* Self, float Rate)
	{
		auto _p0 = Rate;
		Self->LookUpAtRate(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_MoveForward(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->MoveForward(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_MoveRight(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->MoveRight(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_MoveUp_World(ADefaultPawn* Self, float Val)
	{
		auto _p0 = Val;
		Self->MoveUp_World(_p0);
	}

	DOTNET_EXPORT auto E_ADefaultPawn_TurnAtRate(ADefaultPawn* Self, float Rate)
	{
		auto _p0 = Rate;
		Self->TurnAtRate(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
