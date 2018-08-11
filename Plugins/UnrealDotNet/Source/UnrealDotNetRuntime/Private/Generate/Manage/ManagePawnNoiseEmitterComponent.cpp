#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManagePawnNoiseEmitterComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

void UManagePawnNoiseEmitterComponent::MakeNoise(AActor* NoiseMaker, float Loudness, const FVector& NoiseLocation)
{
	Super::MakeNoise(NoiseMaker, Loudness, NoiseLocation);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "MakeNoise", NoiseMaker, Loudness, NoiseLocation);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
