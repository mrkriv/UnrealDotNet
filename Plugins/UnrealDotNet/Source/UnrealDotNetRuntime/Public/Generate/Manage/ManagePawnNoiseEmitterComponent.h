#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Components/PawnNoiseEmitterComponent.h"
#include "ManagePawnNoiseEmitterComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePawnNoiseEmitterComponent : public UPawnNoiseEmitterComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void MakeNoise(AActor* NoiseMaker, float Loudness, const FVector& NoiseLocation) override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
