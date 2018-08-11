#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageEngine.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:630

void UManageEngine::PreExit()
{
	Super::PreExit();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "PreExit");
}

void UManageEngine::ShutdownAudioDeviceManager()
{
	Super::ShutdownAudioDeviceManager();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ShutdownAudioDeviceManager");
}

void UManageEngine::Start()
{
	Super::Start();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "Start");
}

void UManageEngine::Tick(float DeltaSeconds, bool bIdleMode)
{
	Super::Tick(DeltaSeconds, bIdleMode);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "Tick", DeltaSeconds, bIdleMode);
}

void UManageEngine::WorldAdded(UWorld* World)
{
	Super::WorldAdded(World);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "WorldAdded", World);
}

void UManageEngine::WorldDestroyed(UWorld* InWorld)
{
	Super::WorldDestroyed(InWorld);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "WorldDestroyed", InWorld);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
