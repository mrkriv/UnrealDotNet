#include "UnrealDotNet.h"
#include "CoreShell.h"

#define LOCTEXT_NAMESPACE "FUnrealDotNetModule"

void FUnrealDotNetModule::StartupModule()
{
	UCoreShell::Initialize();
}

void FUnrealDotNetModule::ShutdownModule()
{
	UCoreShell::Uninitialize();
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FUnrealDotNetModule, UnrealDotNet)
