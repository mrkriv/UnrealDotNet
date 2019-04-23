#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

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
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FActorBeginOverlapSignature(AActor* OverlappedActor, AActor* OtherActor)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(OverlappedActor);
		auto _p1 = ConvertToManage_ObjectPointerDescription(OtherActor);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FActorComponentActivatedSignature(UActorComponent* Component, bool bReset)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(Component);
		auto _p1 = bReset;
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, bool>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FActorComponentDeactivateSignature(UActorComponent* Component)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(Component);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FActorDestroyedSignature(AActor* DestroyedActor)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(DestroyedActor);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FActorEndCursorOverSignature(AActor* TouchedActor)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(TouchedActor);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FActorEndOverlapSignature(AActor* OverlappedActor, AActor* OtherActor)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(OverlappedActor);
		auto _p1 = ConvertToManage_ObjectPointerDescription(OtherActor);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FActorHitSignature(AActor* SelfActor, AActor* OtherActor, FVector NormalImpulse, const FHitResult& Hit)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(SelfActor);
		auto _p1 = ConvertToManage_ObjectPointerDescription(OtherActor);
		auto _p2 = NormalImpulse;
		auto _p3 = Hit;
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, ObjectPointerDescription, FVector, const FHitResult&>(SourceObject, ManageDelegateName, _p0, _p1, _p2, _p3);
	}

	UFUNCTION()
	void Wrapper_FCharacterMovementUpdatedSignature(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = OldLocation;
		auto _p2 = OldVelocity;
		UCoreShell::GetInstance()->InvokeEventInObject<float, FVector, FVector>(SourceObject, ManageDelegateName, _p0, _p1, _p2);
	}

	UFUNCTION()
	void Wrapper_FCharacterReachedApexSignature()
	{
		UCoreShell::GetInstance()->InvokeEventInObject(SourceObject, ManageDelegateName);
	}

	UFUNCTION()
	void Wrapper_FComponentBeginCursorOverSignature(UPrimitiveComponent* TouchedComponent)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(TouchedComponent);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FComponentBeginOverlapSignature(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex, bool bFromSweep, const FHitResult& SweepResult)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(OverlappedComponent);
		auto _p1 = ConvertToManage_ObjectPointerDescription(OtherActor);
		auto _p2 = ConvertToManage_ObjectPointerDescription(OtherComp);
		auto _p3 = OtherBodyIndex;
		auto _p4 = bFromSweep;
		auto _p5 = SweepResult;
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, ObjectPointerDescription, ObjectPointerDescription, int32, bool, const FHitResult&>(SourceObject, ManageDelegateName, _p0, _p1, _p2, _p3, _p4, _p5);
	}

	UFUNCTION()
	void Wrapper_FComponentCollisionSettingsChangedSignature(UPrimitiveComponent* ChangedComponent)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(ChangedComponent);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FComponentEndCursorOverSignature(UPrimitiveComponent* TouchedComponent)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(TouchedComponent);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FComponentEndOverlapSignature(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, int32 OtherBodyIndex)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(OverlappedComponent);
		auto _p1 = ConvertToManage_ObjectPointerDescription(OtherActor);
		auto _p2 = ConvertToManage_ObjectPointerDescription(OtherComp);
		auto _p3 = OtherBodyIndex;
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, ObjectPointerDescription, ObjectPointerDescription, int32>(SourceObject, ManageDelegateName, _p0, _p1, _p2, _p3);
	}

	UFUNCTION()
	void Wrapper_FComponentHitSignature(UPrimitiveComponent* HitComponent, AActor* OtherActor, UPrimitiveComponent* OtherComp, FVector NormalImpulse, const FHitResult& Hit)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(HitComponent);
		auto _p1 = ConvertToManage_ObjectPointerDescription(OtherActor);
		auto _p2 = ConvertToManage_ObjectPointerDescription(OtherComp);
		auto _p3 = NormalImpulse;
		auto _p4 = Hit;
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, ObjectPointerDescription, ObjectPointerDescription, FVector, const FHitResult&>(SourceObject, ManageDelegateName, _p0, _p1, _p2, _p3, _p4);
	}

	UFUNCTION()
	void Wrapper_FComponentSleepSignature(UPrimitiveComponent* SleepingComponent, FName BoneName)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(SleepingComponent);
		auto _p1 = ConvertToManage_StringWrapper(BoneName);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, StringWrapper>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FComponentWakeSignature(UPrimitiveComponent* WakingComponent, FName BoneName)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(WakingComponent);
		auto _p1 = ConvertToManage_StringWrapper(BoneName);
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, StringWrapper>(SourceObject, ManageDelegateName, _p0, _p1);
	}

	UFUNCTION()
	void Wrapper_FLandedSignature(const FHitResult& Hit)
	{
		auto _p0 = Hit;
		UCoreShell::GetInstance()->InvokeEventInObject<const FHitResult&>(SourceObject, ManageDelegateName, _p0);
	}

	UFUNCTION()
	void Wrapper_FMovementModeChangedSignature(ACharacter* Character, EMovementMode PrevMovementMode, uint8 PreviousCustomMode)
	{
		auto _p0 = ConvertToManage_ObjectPointerDescription(Character);
		auto _p1 = PrevMovementMode;
		auto _p2 = PreviousCustomMode;
		UCoreShell::GetInstance()->InvokeEventInObject<ObjectPointerDescription, EMovementMode, uint8>(SourceObject, ManageDelegateName, _p0, _p1, _p2);
	}

	UFUNCTION()
	void Wrapper_FOnAnimInitialized()
	{
		UCoreShell::GetInstance()->InvokeEventInObject(SourceObject, ManageDelegateName);
	}

	UFUNCTION()
	void Wrapper_FOnAudioFinished()
	{
		UCoreShell::GetInstance()->InvokeEventInObject(SourceObject, ManageDelegateName);
	}

	UFUNCTION()
	void Wrapper_FOnAudioMultiEnvelopeValue(const float AverageEnvelopeValue, const float MaxEnvelope, const int32 NumWaveInstances)
	{
		auto _p0 = AverageEnvelopeValue;
		auto _p1 = MaxEnvelope;
		auto _p2 = NumWaveInstances;
		UCoreShell::GetInstance()->InvokeEventInObject<const float, const float, const int32>(SourceObject, ManageDelegateName, _p0, _p1, _p2);
	}

	UFUNCTION()
	void Wrapper_FOnBoneTransformsFinalized()
	{
		UCoreShell::GetInstance()->InvokeEventInObject(SourceObject, ManageDelegateName);
	}

	UFUNCTION()
	void Wrapper_FOnGameUserSettingsUINeedsUpdate()
	{
		UCoreShell::GetInstance()->InvokeEventInObject(SourceObject, ManageDelegateName);
	}

}
;
