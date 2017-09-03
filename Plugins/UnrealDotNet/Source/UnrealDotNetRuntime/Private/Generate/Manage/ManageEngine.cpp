#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageEngine.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void UManageEngine::PreExit()
{
	Super::PreExit();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "PreExit");
}

void UManageEngine::ShutdownAudioDeviceManager()
{
	Super::ShutdownAudioDeviceManager();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ShutdownAudioDeviceManager");
}

void UManageEngine::Start()
{
	Super::Start();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Start");
}

void UManageEngine::Tick(float DeltaSeconds, bool bIdleMode)
{
	Super::Tick(DeltaSeconds, bIdleMode);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "Tick", DeltaSeconds, bIdleMode);
}

void UManageEngine::WorldAdded(UWorld* World)
{
	Super::WorldAdded(World);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "WorldAdded", World);
}

void UManageEngine::WorldDestroyed(UWorld* InWorld)
{
	Super::WorldDestroyed(InWorld);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "WorldDestroyed", InWorld);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
