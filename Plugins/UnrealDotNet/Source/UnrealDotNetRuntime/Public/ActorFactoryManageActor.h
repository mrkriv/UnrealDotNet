#pragma once

#include "CoreMinimal.h"
#include "DotnetMetadata.h"
#include "ActorFactories/ActorFactory.h"
#include "ActorFactories/ActorFactoryBlueprint.h"
#include "ActorFactoryManageActor.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UActorFactoryManageActor : public UActorFactory
{
	GENERATED_BODY()

	virtual bool CanCreateActorFrom( const FAssetData& AssetData, FText& OutErrorMsg ) override;
	virtual AActor* GetDefaultActor( const FAssetData& AssetData ) override;
	AActor* SpawnActor(UObject* Asset, ULevel* InLevel, const FTransform& Transform, EObjectFlags InObjectFlags, const FName Name) override;

public:
	FDotnetMetadata_Type Metadata;
};