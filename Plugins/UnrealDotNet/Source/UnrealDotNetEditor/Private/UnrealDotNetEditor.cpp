#include "UnrealDotNetEditor.h"
#include "UnrealDotNetEditorPCH.h"
#include "PropertyEditorModule.h"
#include "DotnetTypeNameCustomization.h"

DEFINE_LOG_CATEGORY(DotNetEditor);

#define LOCTEXT_NAMESPACE "FUnrealDotNetModule"

void FUnrealDotNetEditorModule::StartupModule()
{
	auto& PropertyModule = FModuleManager::LoadModuleChecked<FPropertyEditorModule>("PropertyEditor");

	PropertyModule.RegisterCustomPropertyTypeLayout(TEXT("DotnetTypeName"), FOnGetPropertyTypeCustomizationInstance::CreateStatic(&FDotnetTypeNameCustomization::MakeInstance));
}

void FUnrealDotNetEditorModule::ShutdownModule()
{
	auto& PropertyModule = FModuleManager::LoadModuleChecked<FPropertyEditorModule>("PropertyEditor");

	PropertyModule.UnregisterCustomPropertyTypeLayout("DotnetTypeName");
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FUnrealDotNetEditorModule, UnrealDotNetEditor)
