#include "UnrealDotNetEditor.h"
#include "UnrealDotNetEditorPCH.h"

DEFINE_LOG_CATEGORY(DotNetEditor);

#define LOCTEXT_NAMESPACE "FUnrealDotNetModule"

void FUnrealDotNetEditorModule::StartupModule()
{
}

void FUnrealDotNetEditorModule::ShutdownModule()
{
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FUnrealDotNetEditorModule, UnrealDotNetEditor)
