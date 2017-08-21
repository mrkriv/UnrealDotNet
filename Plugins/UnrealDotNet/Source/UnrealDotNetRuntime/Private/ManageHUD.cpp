#include "UnrealDotNet.h"
#include "ManageHUD.h"
#include "CoreShell.h"

AManageHUD::AManageHUD()
{
	PrimaryActorTick.bCanEverTick = true;
}

void AManageHUD::BeginPlay()
{
	Super::BeginPlay();

	if (!ManageClassName.IsEmpty())
	{
		bIsManageAttach = UCoreShell::InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName));
	}

	if (bIsManageAttach)
		UCoreShell::InvokeInObject(this, "OnBeginPlay");
}

void AManageHUD::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

	if (bIsManageAttach)
		UCoreShell::InvokeInObject(this, "OnTick", DeltaTime);
}

void AManageHUD::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	if (bIsManageAttach)
		UCoreShell::InvokeInObject(this, "OnEndPlay");

	if (bIsManageAttach)
		UCoreShell::InvokeInWrapper("UnrealEngine.NativeManager", "RemoveWrapper", this);

	Super::EndPlay(EndPlayReason);
}