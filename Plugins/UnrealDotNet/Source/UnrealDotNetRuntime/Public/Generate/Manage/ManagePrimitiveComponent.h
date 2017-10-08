#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/PrimitiveComponent.h"
#include "ManagePrimitiveComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePrimitiveComponent : public UPrimitiveComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void AddAngularImpulse(FVector Impulse, FName BoneName, bool bVelChange) override;
	
	virtual void AddForce(FVector Force, FName BoneName, bool bAccelChange) override;
	
	virtual void AddForceAtLocation(FVector Force, FVector Location, FName BoneName) override;
	
	virtual void AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName) override;
	
	virtual void AddImpulse(FVector Impulse, FName BoneName, bool bVelChange) override;
	
	virtual void AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName) override;
	
	virtual void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange) override;
	
	virtual void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange) override;
	
	virtual void PutAllRigidBodiesToSleep() override;
	
	virtual void SetAllMassScale(float InMassScale) override;
	
	virtual void SetAllPhysicsAngularVelocity(const FVector& NewAngVel, bool bAddToCurrent) override;
	
	virtual void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent) override;
	
	virtual void SetAllPhysicsPosition(FVector NewPos) override;
	
	virtual void SetAngularDamping(float InDamping) override;
	
	virtual void SetCollisionObjectType(ECollisionChannel Channel) override;
	
	virtual void SetCollisionProfileName(FName InCollisionProfileName) override;
	
	virtual void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse) override;
	
	virtual void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse) override;
	
	virtual void SetCollisionResponseToChannels(const FCollisionResponseContainer& NewReponses) override;
	
	virtual void SetEnableGravity(bool bGravityEnabled) override;
	
	virtual void SetLinearDamping(float InDamping) override;
	
	virtual void SetMassOverrideInKg(FName BoneName, float MassInKg, bool bOverrideMass) override;
	
	virtual void SetMassScale(FName BoneName, float InMassScale) override;
	
	virtual void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision) override;
	
	virtual void SetSimulatePhysics(bool bSimulate) override;
	
	virtual void UnWeldChildren() override;
	
	virtual void UnWeldFromParent() override;
	
	virtual void WakeAllRigidBodies() override;
	
	virtual void WakeRigidBody(FName BoneName) override;
	
	virtual void WeldTo(USceneComponent* InParent, FName InSocketName) override;
	
protected:
	
	virtual void OnComponentCollisionSettingsChanged() override;
	
	virtual void UpdatePhysicsToRBChannels() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
