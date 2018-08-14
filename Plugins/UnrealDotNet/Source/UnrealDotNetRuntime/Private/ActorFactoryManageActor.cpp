#include "UnrealDotNetRuntime.h"
#include "ActorFactoryManageActor.h"
#include "Generate/Manage/ManageActor.h"
#include "CoreShell.h"
#include "AssetRegistryModule.h"

#if WITH_EDITOR
#include "LevelEditorViewport.h"
#include "Editor/EditorEngine.h"
#include "Editor.h"
#endif

bool UActorFactoryManageActor::CanCreateActorFrom(const FAssetData& AssetData, FText& OutErrorMsg)
{
	return Metadata.GetCppClass() != NULL;
}

AActor* UActorFactoryManageActor::GetDefaultActor(const FAssetData& AssetData)
{
	auto actorClass = Metadata.GetCppClass();

	if (actorClass == NULL)
	{
		UE_LOG(LogActorFactory, Error, TEXT("Failed load cpp class %s for manage type %s"), *Metadata.Base, *Metadata.Name);
		return NULL;
	}

	return actorClass->GetDefaultObject<AActor>();
}

AActor* UActorFactoryManageActor::SpawnActor(UObject* Asset, ULevel* InLevel, const FTransform& Transform, EObjectFlags InObjectFlags, const FName Name)
{
	FActorSpawnParameters SpawnInfo;
	SpawnInfo.OverrideLevel = InLevel;
	SpawnInfo.ObjectFlags = InObjectFlags;
	SpawnInfo.Name = Name;

#if WITH_EDITOR
	SpawnInfo.bTemporaryEditorActor = GEditor->bIsSimulatingInEditor ? FLevelEditorViewportClient::IsDroppingPreviewActor() : true;
#endif

	auto actorClass = Metadata.GetCppClass();
	auto actor = InLevel->OwningWorld->SpawnActor(actorClass, &Transform, SpawnInfo);
	auto prop = actorClass->FindPropertyByName(FName("ManageClassName"));

	auto valuePtr = prop->ContainerPtrToValuePtr<FDotnetTypeName>(actor);
	valuePtr->FullName = Metadata.Name;

	return actor;
}