#include "UnrealDotNetEditor.h"
#include "UnrealDotNetEditorPCH.h"
#include "PropertyEditorModule.h"
#include "DotnetTypeNameCustomization.h"
#include "ActorFactoryManageActor.h"
#include "CoreShell.h"

DEFINE_LOG_CATEGORY(DotNetEditor);

#define LOCTEXT_NAMESPACE "FUnrealDotNetModule"

const FName PlacementCategory = "dotnet";

void FUnrealDotNetEditorModule::StartupModule()
{
	auto& PropertyModule = FModuleManager::LoadModuleChecked<FPropertyEditorModule>("PropertyEditor");
	auto& PlacementModule = FModuleManager::LoadModuleChecked<IPlacementModeModule>("PlacementMode");

	PropertyModule.RegisterCustomPropertyTypeLayout(TEXT("DotnetTypeName"), FOnGetPropertyTypeCustomizationInstance::CreateStatic(&FDotnetTypeNameCustomization::MakeInstance));

	PlacementModule.RegisterPlacementCategory(FPlacementCategoryInfo(NSLOCTEXT("PlacementMode", "Dotnet", "C#"), PlacementCategory, TEXT("dotnet")));

	UCoreShell::GetInstance()->OnAssembleLoad.BindRaw(this, &FUnrealDotNetEditorModule::OnHostReload);
	OnHostReload();
}

void FUnrealDotNetEditorModule::ShutdownModule()
{
	auto& PropertyModule = FModuleManager::LoadModuleChecked<FPropertyEditorModule>("PropertyEditor");
	auto& PlacementModule = FModuleManager::LoadModuleChecked<IPlacementModeModule>("PlacementMode");

	PropertyModule.UnregisterCustomPropertyTypeLayout("DotnetTypeName");
	PlacementModule.UnregisterPlacementCategory(FName("dotnet"));
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

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FUnrealDotNetEditorModule, UnrealDotNetEditor)
