#include "UnrealDotNet.h"
#include "ManageActorComponent.h"
#include "CoreShell.h"


UManageActorComponent::UManageActorComponent()
{
	PrimaryComponentTick.bCanEverTick = true;
}

void UManageActorComponent::BeginPlay()
{
	Super::BeginPlay();
}

void UManageActorComponent::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);
}
