#include "UnrealDotNetRuntime.h"
#include "CoreShell.h"

#define LOCTEXT_NAMESPACE "FUnrealDotNetModule"

void FUnrealDotNetRuntimeModule::StartupModule()
{
	UCoreShell::Initialize();
}

void FUnrealDotNetRuntimeModule::ShutdownModule()
{
	UCoreShell::Uninitialize();
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FUnrealDotNetRuntimeModule, UnrealDotNetRuntime)
