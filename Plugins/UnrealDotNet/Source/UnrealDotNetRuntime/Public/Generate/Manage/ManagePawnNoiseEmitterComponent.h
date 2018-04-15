#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Components/PawnNoiseEmitterComponent.h"
#include "ManagePawnNoiseEmitterComponent.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePawnNoiseEmitterComponent : public UPawnNoiseEmitterComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void MakeNoise(AActor* NoiseMaker, float Loudness, const FVector& NoiseLocation) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
