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

PRAGMA_ENABLE_DEPRECATION_WARNINGS
