#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "ManageActor.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API AManageActor : public AActor
{
	GENERATED_BODY()

	bool bIsManageAttach;
public:	
	AManageActor();

protected:
	virtual void BeginPlay() override;

public:
	UPROPERTY(EditDefaultsOnly, Category = Item)
	FString ManageClassName;

	virtual void Tick(float DeltaTime) override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
};
