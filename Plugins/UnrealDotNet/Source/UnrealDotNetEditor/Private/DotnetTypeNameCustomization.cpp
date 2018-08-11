#include "DotnetTypeNameCustomization.h"
#include "UnrealDotNetEditorPCH.h"
#include "DotnetTypeName.h"

#include "Engine.h"
#include "UObject/NoExportTypes.h"

#include "UObject/UnrealType.h"
#include "Widgets/Layout/SBorder.h"
#include "Widgets/Layout/SSpacer.h"
#include "Widgets/Images/SImage.h"
#include "Widgets/Text/STextBlock.h"
#include "Widgets/Layout/SBox.h"
#include "Widgets/Layout/SUniformGridPanel.h"
#include "Widgets/Input/SComboBox.h"
#include "IDetailGroup.h"
#include "IDetailPropertyRow.h"
#include "DetailLayoutBuilder.h"
#include "DetailCategoryBuilder.h"
#include "IDetailChildrenBuilder.h"
#include "PropertyCustomizationHelpers.h"
#include "Widgets/Input/SHyperlink.h"
#include "ScopedTransaction.h"
#include "Slate/SlateTextureAtlasInterface.h"
#include "Kismet2/BlueprintEditorUtils.h"
#include "Editor/UnrealEd/Public/Toolkits/AssetEditorManager.h"

TSharedRef<IPropertyTypeCustomization> FDotnetTypeNameCustomization::MakeInstance()
{
	return MakeShareable(new FDotnetTypeNameCustomization());
}

FDotnetTypeNameCustomization::FDotnetTypeNameCustomization()
{
}

void FDotnetTypeNameCustomization::CustomizeHeader(TSharedRef<IPropertyHandle> StructPropertyHandle, FDetailWidgetRow& HeaderRow, IPropertyTypeCustomizationUtils& StructCustomizationUtils)
{
	static const FName PropertyName_FullName = GET_MEMBER_NAME_CHECKED(FDotnetTypeName, FullName);
	FullNamePropertyHandle = StructPropertyHandle->GetChildHandle(PropertyName_FullName);

	auto onGenerateStrings = FOnGetPropertyComboBoxStrings::CreateStatic(&FDotnetTypeNameCustomization::GenerateStrings);
	auto onChangeFullName = FOnPropertyComboBoxValueSelected::CreateRaw(this, &FDotnetTypeNameCustomization::OnChangeFullName);

	HeaderRow.NameContent()
		[
			StructPropertyHandle->CreatePropertyNameWidget(StructPropertyHandle->GetPropertyDisplayName())
		]
		.ValueContent()
		.MinDesiredWidth(250)
		[
			PropertyCustomizationHelpers::MakePropertyComboBox(FullNamePropertyHandle, onGenerateStrings, nullptr, onChangeFullName)
		];
}

void FDotnetTypeNameCustomization::CustomizeChildren(TSharedRef<IPropertyHandle> StructPropertyHandle, IDetailChildrenBuilder& StructBuilder, IPropertyTypeCustomizationUtils& StructCustomizationUtils)
{
	TArray<void*> RowData;
	StructPropertyHandle->AccessRawData(RowData);
	auto DotnetTypeName = ((FDotnetTypeName*)RowData[0]);

	MainLayoutBuilder = &StructBuilder.GetParentCategory().GetParentLayout();

	TArray<FString> propertys;
	auto types = GetMetadata()->GetArrayField("Types");

	for (auto type : types)
	{
		if (type->AsObject()->GetStringField("Name") != DotnetTypeName->FullName)
			continue;

		auto props = type->AsObject()->GetArrayField("Propertys");
		for (auto prop : props)
		{
			auto name = prop->AsObject()->GetStringField("Name");
			auto type = prop->AsObject()->GetStringField("Type");
			auto def = prop->AsObject()->GetStringField("Default");
			auto canEdit = prop->AsObject()->GetBoolField("CanEdit");

			auto onChange = [StructPropertyHandle, name](const FText& NewText)
			{
				TArray<void*> RowData;
				StructPropertyHandle->AccessRawData(RowData);
				auto DotnetTypeName = ((FDotnetTypeName*)RowData[0]);

				DotnetTypeName->SetPropertyValue(name, NewText.ToString());
			};

			StructBuilder.AddCustomRow(FText::FromString(name)).NameContent()
				[
					StructPropertyHandle->CreatePropertyNameWidget(FText::FromString(name))
				]
			.ValueContent()
				[
					SNew(SEditableTextBox)
					.Text(FText::FromString(DotnetTypeName->GetPropertyValueOrDefault(name, def)))
					.OnTextChanged_Lambda(onChange)
					.IsEnabled(canEdit)
				];

			propertys.Add(name);
		}
	}

	DotnetTypeName->RemoveOtherProperys(propertys);

	//UCoreShell::GetInstance()->OnAssembleLoad.BindLambda([&StructBuilder]()
	//{
	//	StructBuilder.GetParentCategory().GetParentLayout().ForceRefreshDetails();
	//});
}

void FDotnetTypeNameCustomization::OnChangeFullName(const FString& value)
{
	FString currentValue;
	FullNamePropertyHandle->GetValue(currentValue);

	if (value != currentValue && MainLayoutBuilder != NULL)
	{
		FullNamePropertyHandle->SetValue(value);
		MainLayoutBuilder->ForceRefreshDetails();
	}
}

void FDotnetTypeNameCustomization::GenerateStrings(TArray<TSharedPtr<FString>>& OutComboBoxStrings, TArray<TSharedPtr<class SToolTip>>& OutToolTips, TArray<bool>& OutRestrictedItems)
{
	auto Data = GetMetadata();

	const TArray<TSharedPtr<FJsonValue>> *arrayPtr;
	if (Data->TryGetArrayField("Types", arrayPtr))
	{
		for (int32 i = 0; i < arrayPtr->Num(); i++)
		{
			const TSharedPtr<FJsonObject>* ptr;
			(*arrayPtr)[i]->TryGetObject(ptr);

			auto item = ptr->Get()->GetStringField("Name");

			OutComboBoxStrings.Add(MakeShared<FString>(item));
			OutToolTips.Add(SNew(SToolTip).Text(FText::FromString(item)));
			OutRestrictedItems.Add(false);
		}
	}
}

TSharedPtr<FJsonObject> FDotnetTypeNameCustomization::GetMetadata()
{
	auto json_source = UCoreShell::GetInstance()->InvokeInWrapper<char*, 0>("UnrealEngine.NativeManager", "GetMetadata");
	auto json = FString(UTF8_TO_TCHAR(json_source));

	TSharedPtr<FJsonObject> Data;
	TSharedRef<TJsonReader<TCHAR>> JsonReader = TJsonReaderFactory<TCHAR>::Create(json);

	FJsonSerializer::Deserialize(JsonReader, Data);

	return Data;
}