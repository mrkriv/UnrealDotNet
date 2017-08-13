#include "UnrealDotNet.h"
#include "ManageActor.h"
#include "CoreShell.h"

AManageActor::AManageActor()
{
	PrimaryActorTick.bCanEverTick = true;
}

void AManageActor::BeginPlay()
{
	Super::BeginPlay();

	if (!ManageClassName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool>("UnrealEngine.UObject", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName));
	}
}

void AManageActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

	if(bIsManageAttach)
		UCoreShell::InvokeInObject(this, "OnTick", DeltaTime);
}

void AManageActor::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	if (bIsManageAttach)
		UCoreShell::InvokeInWrapper("UnrealEngine.UObject", "RemoveWrapper", this);

	Super::EndPlay(EndPlayReason);
}