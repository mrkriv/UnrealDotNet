#pragma once

#include "CoreMinimal.h"
#include "DotnetMetadata.generated.h"

class FJsonObject;

USTRUCT(BlueprintType)
struct UNREALDOTNETRUNTIME_API FDotnetMetadata_Property
{
	GENERATED_BODY()

	FString Name;
	FString Type;
	FString Default;
	bool bCanEdit;

	FDotnetMetadata_Property() {}
	FDotnetMetadata_Property(TSharedPtr<FJsonObject> json);
};

USTRUCT(BlueprintType)
struct UNREALDOTNETRUNTIME_API FDotnetMetadata_Type
{
	GENERATED_BODY()

	FString Name;
	FString Base;
	bool bIsManage;
	FString ManageClassName;
	TArray<FDotnetMetadata_Property> Propertys;

	FDotnetMetadata_Type() {}
	FDotnetMetadata_Type(TSharedPtr<FJsonObject> json);

	class UClass* GetCppClass() const;
};

USTRUCT(BlueprintType)
struct UNREALDOTNETRUNTIME_API FDotnetMetadata
{
	GENERATED_BODY()

	TArray<FDotnetMetadata_Type> Types;

	FDotnetMetadata() {}
	FDotnetMetadata(TSharedPtr<FJsonObject> json);
};
