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

	auto metadata = UCoreShell::GetInstance()->Metadata;

	for (auto type : metadata.Types)
	{
		if (type.Name != DotnetTypeName->FullName)
			continue;

		for (auto prop : type.Propertys)
		{
			auto onChange = [StructPropertyHandle, prop](const FText& NewText)
			{
				TArray<void*> RowData;
				StructPropertyHandle->AccessRawData(RowData);
				auto DotnetTypeName = ((FDotnetTypeName*)RowData[0]);

				DotnetTypeName->SetPropertyValue(prop.Name, NewText.ToString());
			};

			StructBuilder.AddCustomRow(FText::FromString(prop.Name)).NameContent()
			[
				StructPropertyHandle->CreatePropertyNameWidget(FText::FromString(prop.Name))
			]
			.ValueContent()
			[
				SNew(SEditableTextBox)
				.Text(FText::FromString(DotnetTypeName->GetPropertyValueOrDefault(prop.Name, prop.Default)))
				.OnTextChanged_Lambda(onChange)
				.IsEnabled(prop.bCanEdit)
			];

			propertys.Add(prop.Name);
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
	auto metadata = UCoreShell::GetInstance()->Metadata;

	for (auto type : metadata.Types)
	{
		OutComboBoxStrings.Add(MakeShared<FString>(type.Name));
		OutToolTips.Add(SNew(SToolTip).Text(FText::FromString(type.Name)));
		OutRestrictedItems.Add(false);
	}
}