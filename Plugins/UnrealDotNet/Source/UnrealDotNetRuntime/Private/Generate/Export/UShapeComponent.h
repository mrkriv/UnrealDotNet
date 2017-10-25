#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Engine/Classes/Components/ShapeComponent.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\ShapeComponent.h:24

class E_PROTECTED_WRAP_UShapeComponent : protected UShapeComponent
{
public:
	void AddShapeToGeomArray_WRAP()
	{
		AddShapeToGeomArray();
	}

	void CreateShapeBodySetupIfNeeded_WRAP()
	{
		CreateShapeBodySetupIfNeeded();
	}

	bool PrepareSharedBodySetup_WRAP()
	{
		return PrepareSharedBodySetup();
	}

}
;

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UShapeComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UShapeComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UShapeComponent_AddShapeToGeomArray(UShapeComponent* Self)
	{
		((E_PROTECTED_WRAP_UShapeComponent*)Self)->AddShapeToGeomArray_WRAP();
	}

	DOTNET_EXPORT auto E_UShapeComponent_CreateShapeBodySetupIfNeeded(UShapeComponent* Self)
	{
		((E_PROTECTED_WRAP_UShapeComponent*)Self)->CreateShapeBodySetupIfNeeded_WRAP();
	}

	DOTNET_EXPORT auto E_UShapeComponent_PrepareSharedBodySetup(UShapeComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UShapeComponent*)Self)->PrepareSharedBodySetup_WRAP();
	}

	DOTNET_EXPORT auto E_UShapeComponent_UpdateBodySetup(UShapeComponent* Self)
	{
		Self->UpdateBodySetup();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
