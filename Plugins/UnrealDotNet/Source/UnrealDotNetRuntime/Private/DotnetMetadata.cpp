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
	bIsManage = json->GetBoolField("IsManage");
	ManageClassName = json->GetStringField("ManageClassName");

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

UClass* FDotnetMetadata_Type::GetCppClass() const
{
	for (TObjectIterator<UClass> itr; itr; ++itr)
	{
		if (itr->GetName() == Base)
		{
			return *itr;
		}
	}

	return NULL;
}