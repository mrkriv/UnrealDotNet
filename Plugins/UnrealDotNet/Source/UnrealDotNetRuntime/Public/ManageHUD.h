#pragma once

#include "CoreMinimal.h"
#include "GameFramework/HUD.h"
#include "ManageHUD.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API AManageHUD : public AHUD
{
	GENERATED_BODY()

	bool bIsManageAttach;
public:
	AManageHUD();

protected:
	virtual void BeginPlay() override;

public:
	UPROPERTY(EditDefaultsOnly, Category = Item)
	FString ManageClassName;

	virtual void Tick(float DeltaTime) override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
};
