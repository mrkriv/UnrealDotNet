#include "UnrealDotNetRuntime.h"
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
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName));
	}

	if (bIsManageAttach)
		UCoreShell::InvokeInObject(this, "OnBeginPlay");
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
		UCoreShell::InvokeInObject(this, "OnEndPlay");

	if (bIsManageAttach)
		UCoreShell::InvokeInWrapper("UnrealEngine.NativeManager", "RemoveWrapper", this);

	Super::EndPlay(EndPlayReason);
}