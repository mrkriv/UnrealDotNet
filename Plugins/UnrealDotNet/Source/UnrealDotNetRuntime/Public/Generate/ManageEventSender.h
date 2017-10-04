#pragma once

#include "TypeConvertor.h"
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
		auto _p0 = ConvertToManage_ObjectPointerDescription(TouchedActor);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FActorBeginOverlapSignature(AActor* OverlappedActor, AActor* OtherActor)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(OverlappedActor);
		auto _p1 = ConvertToManage_ObjectPointerDescription(OtherActor);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription, ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FActorComponentActivatedSignature(UActorComponent* Component, bool bReset)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(Component);
		auto _p1 = bReset;
		UCoreShell::InvokeEventInObject<ObjectPointerDescription, bool>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FActorComponentDeactivateSignature(UActorComponent* Component)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(Component);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FActorDestroyedSignature(AActor* DestroyedActor)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(DestroyedActor);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FActorEndCursorOverSignature(AActor* TouchedActor)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(TouchedActor);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FActorEndOverlapSignature(AActor* OverlappedActor, AActor* OtherActor)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(OverlappedActor);
		auto _p1 = ConvertToManage_ObjectPointerDescription(OtherActor);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription, ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FCharacterMovementUpdatedSignature(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = OldLocation;
		auto _p2 = OldVelocity;
		UCoreShell::InvokeEventInObject<float, FVector, FVector>(SourceObject, ManageDelegateName, _p0, _p1, _p2);
	}

	UFUNCTION()
	void Wrapper_FCharacterReachedApexSignature()
	{
		UCoreShell::InvokeEventInObject(SourceObject, ManageDelegateName);
	}

	UFUNCTION()
	void Wrapper_FComponentBeginCursorOverSignature(UPrimitiveComponent* TouchedComponent)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(TouchedComponent);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FComponentCollisionSettingsChangedSignature(UPrimitiveComponent* ChangedComponent)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(ChangedComponent);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FComponentEndCursorOverSignature(UPrimitiveComponent* TouchedComponent)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(TouchedComponent);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FComponentEndOverlapSignature(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(OverlappedComponent);
		auto _p1 = ConvertToManage_ObjectPointerDescription(OtherActor);
		auto _p2 = ConvertToManage_ObjectPointerDescription(OtherComp);
		auto _p3 = OtherBodyIndex;
		UCoreShell::InvokeEventInObject<ObjectPointerDescription, ObjectPointerDescription, ObjectPointerDescription, int32>(SourceObject, ManageDelegateName, _p0, _p1, _p2, _p3);
	}

	UFUNCTION()
	void Wrapper_FComponentFractureSignature(const FVector& HitPoint, const FVector& HitDirection)
	{
		auto _p0 = HitPoint;
		auto _p1 = HitDirection;
		UCoreShell::InvokeEventInObject<const FVector&, const FVector&>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FComponentSleepSignature(UPrimitiveComponent* SleepingComponent, FName BoneName)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(SleepingComponent);
		auto _p1 = ConvertToManage_StringWrapper(BoneName);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription, StringWrapper>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FComponentWakeSignature(UPrimitiveComponent* WakingComponent, FName BoneName)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(WakingComponent);
		auto _p1 = ConvertToManage_StringWrapper(BoneName);
		UCoreShell::InvokeEventInObject<ObjectPointerDescription, StringWrapper>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FMovementModeChangedSignature(ACharacter* Character, EMovementMode PrevMovementMode, uint8 PreviousCustomMode)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(Character);
		auto _p1 = PrevMovementMode;
		auto _p2 = PreviousCustomMode;
		UCoreShell::InvokeEventInObject<ObjectPointerDescription, EMovementMode, uint8>(SourceObject, ManageDelegateName, _p0, _p1, _p2);
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
