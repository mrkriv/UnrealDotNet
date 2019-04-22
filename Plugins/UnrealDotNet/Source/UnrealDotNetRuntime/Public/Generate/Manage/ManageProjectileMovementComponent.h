#pragma once

// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/ProjectileMovementComponent.h"
#include "ManageProjectileMovementComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

UCLASS()
class UNREALDOTNETRUNTIME_API UManageProjectileMovementComponent : public UProjectileMovementComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void MoveInterpolationTarget(const FVector& NewLocation, const FRotator& NewRotation) override;
	virtual void ResetInterpolation() override;
	virtual void SetInterpolatedComponent(USceneComponent* Component) override;
	virtual void SetVelocityInLocalSpace(FVector NewVelocity) override;
	virtual void StopSimulating(const FHitResult& HitResult) override;
	
protected:
	virtual void TickInterpolation(float DeltaTime) override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
