#include "UnrealDotNetEditor.h"
#include "UnrealDotNetEditorPCH.h"
#include "PropertyEditorModule.h"
#include "UDNCommands.h"
#include "UDNStyle.h"
#include "DotnetTypeNameCustomization.h"
#include "ActorFactoryManageActor.h"
#include "CoreShell.h"
#include "Misc/MessageDialog.h"
#include "Framework/MultiBox/MultiBoxBuilder.h"

#include "Framework/Notifications/NotificationManager.h"
#include "Widgets/Notifications/SNotificationList.h"

#include "LevelEditor.h"
#include "CoreShell.h"


DEFINE_LOG_CATEGORY(DotNetEditor);

#define LOCTEXT_NAMESPACE "FUnrealDotNetModule"

const FName PlacementCategory = "dotnet";

void FUnrealDotNetEditorModule::StartupModule()
{
	auto& PropertyModule = FModuleManager::LoadModuleChecked<FPropertyEditorModule>("PropertyEditor");
	auto& PlacementModule = FModuleManager::LoadModuleChecked<IPlacementModeModule>("PlacementMode");
	auto& LevelEditorModule = FModuleManager::LoadModuleChecked<FLevelEditorModule>("LevelEditor");

	PropertyModule.RegisterCustomPropertyTypeLayout(TEXT("DotnetTypeName"), FOnGetPropertyTypeCustomizationInstance::CreateStatic(&FDotnetTypeNameCustomization::MakeInstance));

	PlacementModule.RegisterPlacementCategory(FPlacementCategoryInfo(NSLOCTEXT("PlacementMode", "Dotnet", "C#"), PlacementCategory, TEXT("dotnet")));

	UCoreShell::GetInstance()->OnAssembleLoad.BindRaw(this, &FUnrealDotNetEditorModule::OnHostReload);
	OnHostReload();

	FUDNStyle::Initialize();
	FUDNStyle::ReloadTextures();

	FUDNCommands::Register();

	PluginCommands = MakeShareable(new FUICommandList);

	PluginCommands->MapAction(
		FUDNCommands::Get().PluginAction,
		FExecuteAction::CreateRaw(this, &FUnrealDotNetEditorModule::CompileButtonClicked),
		FCanExecuteAction());

	ToolbarCompileButton = MakeShareable(new FExtender);
	ToolbarCompileButton->AddToolBarExtension("Settings", EExtensionHook::After, PluginCommands, FToolBarExtensionDelegate::CreateRaw(this, &FUnrealDotNetEditorModule::AddToolbarExtension));

	LevelEditorModule.GetToolBarExtensibilityManager()->AddExtender(ToolbarCompileButton);
}

void FUnrealDotNetEditorModule::ShutdownModule()
{
	auto& PropertyModule = FModuleManager::LoadModuleChecked<FPropertyEditorModule>("PropertyEditor");
	auto& PlacementModule = FModuleManager::LoadModuleChecked<IPlacementModeModule>("PlacementMode");
	auto& LevelEditorModule = FModuleManager::LoadModuleChecked<FLevelEditorModule>("LevelEditor");

	PropertyModule.UnregisterCustomPropertyTypeLayout("DotnetTypeName");
	PlacementModule.UnregisterPlacementCategory(PlacementCategory);
	LevelEditorModule.GetToolBarExtensibilityManager()->RemoveExtender(ToolbarCompileButton);
	
	FUDNStyle::Shutdown();
	FUDNCommands::Unregister();
}

void FUnrealDotNetEditorModule::OnHostReload()
{
	auto& PlacementModule = FModuleManager::LoadModuleChecked<IPlacementModeModule>("PlacementMode");

	for (auto item : PlacementModeIDs)
		PlacementModule.UnregisterPlaceableItem(item);

	PlacementModeIDs.Reset();

	auto meta = UCoreShell::GetInstance()->Metadata;

	for (auto prop : meta.Types)
	{
		if (!prop.bIsManage)
			continue;

		if (!prop.GetCppClass()->IsChildOf(AActor::StaticClass()))
			continue;

		auto factory = NewObject<UActorFactoryManageActor>(UActorFactoryManageActor::StaticClass()->ClassDefaultObject);
		factory->Metadata = prop;
		factory->AddToRoot();

		auto asset = FAssetData(AActor::StaticClass()->ClassDefaultObject);
		asset.AssetClass = *prop.ManageClassName;
		asset.AssetName = *prop.Name;

		auto placeItem = TSharedRef<FPlaceableItem>(new FPlaceableItem(factory, asset));
		placeItem->DisplayName = FText::FromString(prop.Name);

		auto id = PlacementModule.RegisterPlaceableItem(PlacementCategory, placeItem);

		if (id.IsSet())
			PlacementModeIDs.Add(id.GetValue());
	}

	PlacementModule.RegenerateItemsForCategory(PlacementCategory);
}

void FUnrealDotNetEditorModule::CompileButtonClicked()
{
	FSlateNotificationManager::Get().AddNotification(FNotificationInfo(LOCTEXT("CompileStartMsg", "Compile .net project...")));

	auto projectFile = FPaths::ConvertRelativePathToFull(FPaths::ProjectDir() / "Source" / "GameLogic" / "GameLogic.csproj");
	auto commandLine = FString::Printf(TEXT("build \"%s\""), *projectFile);

	UE_LOG(DotNetEditor, Log, TEXT("dotnet %s"), *commandLine);

	auto dotnet = FPlatformProcess::CreateProc(TEXT("dotnet"), *commandLine, false, true, true, nullptr, 0, nullptr, nullptr);

	//todo:: watch to process
}

void FUnrealDotNetEditorModule::AddMenuExtension(FMenuBuilder& Builder)
{
	Builder.AddMenuEntry(FUDNCommands::Get().PluginAction);
}

void FUnrealDotNetEditorModule::AddToolbarExtension(FToolBarBuilder& Builder)
{
	Builder.AddToolBarButton(FUDNCommands::Get().PluginAction);
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FUnrealDotNetEditorModule, UnrealDotNetEditor)
