#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/SpringArmComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

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

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_bIsCameraFixed_GET(USpringArmComponent* Ptr) { return Ptr->bIsCameraFixed; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_bIsCameraFixed_SET(USpringArmComponent* Ptr, bool Value) { Ptr->bIsCameraFixed = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_CameraLagMaxDistance_GET(USpringArmComponent* Ptr) { return Ptr->CameraLagMaxDistance; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_CameraLagMaxDistance_SET(USpringArmComponent* Ptr, float Value) { Ptr->CameraLagMaxDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_CameraLagMaxTimeStep_GET(USpringArmComponent* Ptr) { return Ptr->CameraLagMaxTimeStep; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_CameraLagMaxTimeStep_SET(USpringArmComponent* Ptr, float Value) { Ptr->CameraLagMaxTimeStep = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_CameraLagSpeed_GET(USpringArmComponent* Ptr) { return Ptr->CameraLagSpeed; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_CameraLagSpeed_SET(USpringArmComponent* Ptr, float Value) { Ptr->CameraLagSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_CameraRotationLagSpeed_GET(USpringArmComponent* Ptr) { return Ptr->CameraRotationLagSpeed; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_CameraRotationLagSpeed_SET(USpringArmComponent* Ptr, float Value) { Ptr->CameraRotationLagSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_PreviousArmOrigin_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->PreviousArmOrigin); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_PreviousArmOrigin_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->PreviousArmOrigin = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_PreviousDesiredLoc_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->PreviousDesiredLoc); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_PreviousDesiredLoc_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->PreviousDesiredLoc = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_PreviousDesiredRot_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->PreviousDesiredRot); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_PreviousDesiredRot_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->PreviousDesiredRot = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_ProbeSize_GET(USpringArmComponent* Ptr) { return Ptr->ProbeSize; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_ProbeSize_SET(USpringArmComponent* Ptr, float Value) { Ptr->ProbeSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_SocketOffset_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->SocketOffset); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_SocketOffset_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->SocketOffset = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_TargetArmLength_GET(USpringArmComponent* Ptr) { return Ptr->TargetArmLength; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_TargetArmLength_SET(USpringArmComponent* Ptr, float Value) { Ptr->TargetArmLength = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_TargetOffset_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->TargetOffset); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_TargetOffset_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->TargetOffset = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_UnfixedCameraPosition_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->UnfixedCameraPosition); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_UnfixedCameraPosition_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->UnfixedCameraPosition = *(FVector*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USpringArmComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USpringArmComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_BlendLocations(USpringArmComponent* Self, INT_PTR DesiredArmLocation, INT_PTR TraceHitLocation, bool bHitSomething, float DeltaTime)
	{
		auto& _p0 = *(FVector*)DesiredArmLocation;
		auto& _p1 = *(FVector*)TraceHitLocation;
		auto _p2 = bHitSomething;
		auto _p3 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_USpringArmComponent*)Self)->BlendLocations_WRAP(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetTargetRotation(USpringArmComponent* Self)
	{
		return (INT_PTR) new FRotator(Self->GetTargetRotation());
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetUnfixedCameraPosition(USpringArmComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetUnfixedCameraPosition());
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsCollisionFixApplied(USpringArmComponent* Self)
	{
		return Self->IsCollisionFixApplied();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_UpdateDesiredArmLocation(USpringArmComponent* Self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		auto _p0 = bDoTrace;
		auto _p1 = bDoLocationLag;
		auto _p2 = bDoRotationLag;
		auto _p3 = DeltaTime;
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->USpringArmComponent::UpdateDesiredArmLocation_WRAP(_p0, _p1, _p2, _p3);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
