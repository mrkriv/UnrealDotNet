#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManagePawnNoiseEmitterComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\PawnNoiseEmitterComponent.h:19

void UManagePawnNoiseEmitterComponent::MakeNoise(AActor* NoiseMaker, float Loudness, const FVector& NoiseLocation)
{
	Super::MakeNoise(NoiseMaker, Loudness, NoiseLocation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MakeNoise", NoiseMaker, Loudness, NoiseLocation);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
