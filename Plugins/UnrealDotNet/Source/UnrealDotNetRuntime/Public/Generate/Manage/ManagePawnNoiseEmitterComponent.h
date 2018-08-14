#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Components/PawnNoiseEmitterComponent.h"
#include "ManagePawnNoiseEmitterComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePawnNoiseEmitterComponent : public UPawnNoiseEmitterComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void SetManageClassName(FString name) override { ManageClassName.FullName = name; }
	virtual FString GetManageClassName() override { return ManageClassName.FullName; }
	
	virtual void MakeNoise(AActor* NoiseMaker, float Loudness, const FVector& NoiseLocation) override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
