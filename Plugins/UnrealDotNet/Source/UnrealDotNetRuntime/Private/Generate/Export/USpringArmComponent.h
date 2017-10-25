#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Engine/Classes/GameFramework/SpringArmComponent.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

class E_PROTECTED_WRAP_USpringArmComponent : protected USpringArmComponent
{
public:
	FVector BlendLocations_WRAP(const FVector& DesiredArmLocation, const FVector& TraceHitLocation, bool bHitSomething, float DeltaTime)
	{
		return BlendLocations(DesiredArmLocation, TraceHitLocation, bHitSomething, DeltaTime);
	}

	void UpdateDesiredArmLocation_WRAP(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		UpdateDesiredArmLocation(bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
	}

}
;

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_bUseControllerViewRotation_GET(USpringArmComponent* Ptr) { return Ptr->bUseControllerViewRotation; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_bUseControllerViewRotation_SET(USpringArmComponent* Ptr, bool Value) { Ptr->bUseControllerViewRotation = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USpringArmComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USpringArmComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_BlendLocations(USpringArmComponent* Self, INT_PTR DesiredArmLocation, INT_PTR TraceHitLocation, bool bHitSomething, float DeltaTime)
	{
		auto _p0 = *(FVector*)DesiredArmLocation;
		auto _p1 = *(FVector*)TraceHitLocation;
		auto _p2 = bHitSomething;
		auto _p3 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_USpringArmComponent*)Self)->BlendLocations_WRAP(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_UpdateDesiredArmLocation(USpringArmComponent* Self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		auto _p0 = bDoTrace;
		auto _p1 = bDoLocationLag;
		auto _p2 = bDoRotationLag;
		auto _p3 = DeltaTime;
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->UpdateDesiredArmLocation_WRAP(_p0, _p1, _p2, _p3);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
