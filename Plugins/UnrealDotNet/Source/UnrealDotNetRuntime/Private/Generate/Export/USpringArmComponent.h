#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "GameFramework/SpringArmComponent.h"

class E_PROTECTED_WRAP_USpringArmComponent : protected USpringArmComponent
{
public:
	void UpdateDesiredArmLocation_WRAP(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		UpdateDesiredArmLocation(bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
	}

}
;

extern "C"
{
	DOTNET_EXPORT bool E_PROP_USpringArmComponent_bUseControllerViewRotation_GET(INT_PTR Ptr) { return ((USpringArmComponent*)Ptr)->bUseControllerViewRotation; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_bUseControllerViewRotation_SET(INT_PTR Ptr, bool Value) { ((USpringArmComponent*)Ptr)->bUseControllerViewRotation = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USpringArmComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USpringArmComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_USpringArmComponent_UpdateDesiredArmLocation(USpringArmComponent* Self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		auto _p0 = bDoTrace;
		auto _p1 = bDoLocationLag;
		auto _p2 = bDoRotationLag;
		auto _p3 = DeltaTime;
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->UpdateDesiredArmLocation_WRAP(_p0, _p1, _p2, _p3);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
