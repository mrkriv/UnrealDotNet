#include "UnrealDotNetRuntime.h"
#include "DotnetMetadata.h"

FDotnetMetadata::FDotnetMetadata(TSharedPtr<FJsonObject> json)
{
	for (auto type : json->GetArrayField("Types"))
	{
		Types.Add(FDotnetMetadata_Type(type->AsObject()));
	}
}

FDotnetMetadata_Type::FDotnetMetadata_Type(TSharedPtr<FJsonObject> json)
{
	Name = json->GetStringField("Name");
	Base = json->GetStringField("Base");

	for (auto type : json->GetArrayField("Propertys"))
	{
		Propertys.Add(FDotnetMetadata_Property(type->AsObject()));
	}
}

FDotnetMetadata_Property::FDotnetMetadata_Property(TSharedPtr<FJsonObject> json)
{
	Name = json->GetStringField("Name");
	Type = json->GetStringField("Type");
	bCanEdit = json->GetBoolField("CanEdit");
	Default = json->GetStringField("Default");
}