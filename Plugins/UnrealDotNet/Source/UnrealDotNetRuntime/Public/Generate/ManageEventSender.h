#pragma once

#include "CoreShell.h"
#include "ManageEventSender.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageEventSender : public UObject
{
	GENERATED_BODY()
	
	public:
	
	UPROPERTY()
	UObject* SourceObject;
	
	UPROPERTY()
	FString ManageDelegateName;
	
	UFUNCTION()
	void Wrapper_FActorBeginCursorOverSignature(AActor* TouchedActor)
	{
		UCoreShell::InvokeEventInObject<AActor*>(SourceObject, ManageDelegateName, TouchedActor);
	}

	UFUNCTION()
	void Wrapper_FActorBeginOverlapSignature(AActor* OverlappedActor, AActor* OtherActor)
	{
		UCoreShell::InvokeEventInObject<AActor*, AActor*>(SourceObject, ManageDelegateName, OverlappedActor, OtherActor);
	}

	UFUNCTION()
	void Wrapper_FActorComponentActivatedSignature(UActorComponent* Component, bool bReset)
	{
		UCoreShell::InvokeEventInObject<UActorComponent*, bool>(SourceObject, ManageDelegateName, Component, bReset);
	}

	UFUNCTION()
	void Wrapper_FActorComponentDeactivateSignature(UActorComponent* Component)
	{
		UCoreShell::InvokeEventInObject<UActorComponent*>(SourceObject, ManageDelegateName, Component);
	}

	UFUNCTION()
	void Wrapper_FActorDestroyedSignature(AActor* DestroyedActor)
	{
		UCoreShell::InvokeEventInObject<AActor*>(SourceObject, ManageDelegateName, DestroyedActor);
	}

	UFUNCTION()
	void Wrapper_FActorEndCursorOverSignature(AActor* TouchedActor)
	{
		UCoreShell::InvokeEventInObject<AActor*>(SourceObject, ManageDelegateName, TouchedActor);
	}

	UFUNCTION()
	void Wrapper_FActorEndOverlapSignature(AActor* OverlappedActor, AActor* OtherActor)
	{
		UCoreShell::InvokeEventInObject<AActor*, AActor*>(SourceObject, ManageDelegateName, OverlappedActor, OtherActor);
	}

	UFUNCTION()
	void Wrapper_FCharacterMovementUpdatedSignature(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
	{
		UCoreShell::InvokeEventInObject<float, FVector, FVector>(SourceObject, ManageDelegateName, DeltaSeconds, OldLocation, OldVelocity);
	}

	UFUNCTION()
	void Wrapper_FCharacterReachedApexSignature()
	{
		UCoreShell::InvokeEventInObject(SourceObject, ManageDelegateName);
	}

	UFUNCTION()
	void Wrapper_FComponentBeginCursorOverSignature(UPrimitiveComponent* TouchedComponent)
	{
		UCoreShell::InvokeEventInObject<UPrimitiveComponent*>(SourceObject, ManageDelegateName, TouchedComponent);
	}

	UFUNCTION()
	void Wrapper_FComponentCollisionSettingsChangedSignature(UPrimitiveComponent* ChangedComponent)
	{
		UCoreShell::InvokeEventInObject<UPrimitiveComponent*>(SourceObject, ManageDelegateName, ChangedComponent);
	}

	UFUNCTION()
	void Wrapper_FComponentEndCursorOverSignature(UPrimitiveComponent* TouchedComponent)
	{
		UCoreShell::InvokeEventInObject<UPrimitiveComponent*>(SourceObject, ManageDelegateName, TouchedComponent);
	}

	UFUNCTION()
	void Wrapper_FComponentEndOverlapSignature(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex)
	{
		UCoreShell::InvokeEventInObject<UPrimitiveComponent*, AActor*, UPrimitiveComponent*, int32>(SourceObject, ManageDelegateName, OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
	}

	UFUNCTION()
	void Wrapper_FComponentFractureSignature(const FVector& HitPoint, const FVector& HitDirection)
	{
		UCoreShell::InvokeEventInObject<const FVector&, const FVector&>(SourceObject, ManageDelegateName, HitPoint, HitDirection);
	}

	UFUNCTION()
	void Wrapper_FComponentSleepSignature(UPrimitiveComponent* SleepingComponent, FName BoneName)
	{
		UCoreShell::InvokeEventInObject<UPrimitiveComponent*, FName>(SourceObject, ManageDelegateName, SleepingComponent, BoneName);
	}

	UFUNCTION()
	void Wrapper_FComponentWakeSignature(UPrimitiveComponent* WakingComponent, FName BoneName)
	{
		UCoreShell::InvokeEventInObject<UPrimitiveComponent*, FName>(SourceObject, ManageDelegateName, WakingComponent, BoneName);
	}

	UFUNCTION()
	void Wrapper_FMovementModeChangedSignature(ACharacter* Character, EMovementMode PrevMovementMode, uint8 PreviousCustomMode)
	{
		UCoreShell::InvokeEventInObject<ACharacter*, EMovementMode, uint8>(SourceObject, ManageDelegateName, Character, PrevMovementMode, PreviousCustomMode);
	}

	UFUNCTION()
	void Wrapper_FOnAnimInitialized()
	{
		UCoreShell::InvokeEventInObject(SourceObject, ManageDelegateName);
	}

	UFUNCTION()
	void Wrapper_FOnAudioFinished()
	{
		UCoreShell::InvokeEventInObject(SourceObject, ManageDelegateName);
	}

}
;
