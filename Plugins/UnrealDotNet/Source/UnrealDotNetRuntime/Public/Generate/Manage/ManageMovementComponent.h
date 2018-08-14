#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/MovementComponent.h"
#include "ManageMovementComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\MovementComponent.h:54

UCLASS()
class UNREALDOTNETRUNTIME_API UManageMovementComponent : public UMovementComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void SetManageClassName(FString name) override { ManageClassName.FullName = name; }
	virtual FString GetManageClassName() override { return ManageClassName.FullName; }
	
	virtual void AddRadialForce(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff) override;
	virtual void AddRadialImpulse(const FVector& Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange) override;
	virtual void HandleImpact(const FHitResult& Hit, float TimeSlice, const FVector& MoveDelta) override;
	virtual void OnTeleported() override;
	virtual void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting) override;
	virtual void SetPlaneConstraintEnabled(bool bEnabled) override;
	virtual void SetPlaneConstraintFromVectors(FVector Forward, FVector Up) override;
	virtual void SetPlaneConstraintNormal(FVector PlaneNormal) override;
	virtual void SetPlaneConstraintOrigin(FVector PlaneOrigin) override;
	virtual void SetUpdatedComponent(USceneComponent* NewUpdatedComponent) override;
	virtual void SnapUpdatedComponentToPlane() override;
	virtual void StopMovementImmediately() override;
	virtual void UpdateComponentVelocity() override;
	virtual void UpdateTickRegistration() override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
