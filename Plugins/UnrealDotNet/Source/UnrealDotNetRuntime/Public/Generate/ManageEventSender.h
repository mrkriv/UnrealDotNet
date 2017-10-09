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
	void Wrapper_FConstraintBrokenSignature(int32 ConstraintIndex)
	{
		auto _p0 = ConstraintIndex;
		UCoreShell::InvokeEventInObject<int32>(SourceObject, ManageDelegateName, _p0);
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
