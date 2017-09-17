#pragma once

#include "JsonUtilities.h"
#include "DotnetTypeName.generated.h"

USTRUCT(BlueprintType)
struct FDotnetPropertyValue
{
	GENERATED_BODY()

public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	FString Name;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	FString Value;
};

USTRUCT(BlueprintType)
struct FDotnetTypeName
{
	GENERATED_BODY()

public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Meta = (DisplayName = "Manage Class"))
	FString FullName;

	UPROPERTY(EditAnywhere)
	TArray<FDotnetPropertyValue> PropertyValue;

	FString PackJSON() const
	{
		FString result;
		FJsonObjectConverter::UStructToJsonObjectString(*this, result);

		return result;
	}

	void SetPropertyValue(const FString& Propery, const FString& Value)
	{
		PropertyValue.RemoveAll([Propery](auto prop) { return prop.Name == Propery; });

		auto prop = FDotnetPropertyValue();
		prop.Name = Propery;
		prop.Value = Value;

		PropertyValue.Add(prop);
	}

	FString GetPropertyValueOrDefault(const FString& Propery, const FString& DefaultValue)
	{
		auto ptr = PropertyValue.FindByPredicate([Propery](auto prop) { return prop.Name == Propery; });

		return ptr ? ptr->Value : DefaultValue;
	}

	void RemoveOtherProperys(const TArray<FString>& Properys)
	{
		PropertyValue.RemoveAll([Properys](auto prop) { return !Properys.Contains(prop.Name); });
	}
};
