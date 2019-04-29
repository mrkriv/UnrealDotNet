#pragma once

#include "UnrealDotNetRuntime/Public/CoreShell.h"
#include "IPropertyTypeCustomization.h"
#include "JsonUtilities.h"

class UNREALDOTNETEDITOR_API FDotnetTypeNameCustomization : public IPropertyTypeCustomization
{
	TSharedPtr<IPropertyHandle> FullNamePropertyHandle;
	class IDetailLayoutBuilder* MainLayoutBuilder;
	class UClass* ObjectClass;

public:
	static TSharedRef<IPropertyTypeCustomization> MakeInstance();

	FDotnetTypeNameCustomization();

	virtual void CustomizeHeader(TSharedRef<IPropertyHandle> StructPropertyHandle, class FDetailWidgetRow& HeaderRow, IPropertyTypeCustomizationUtils& StructCustomizationUtils) override;
	virtual void CustomizeChildren(TSharedRef<IPropertyHandle> StructPropertyHandle, class IDetailChildrenBuilder& StructBuilder, IPropertyTypeCustomizationUtils& StructCustomizationUtils) override;

	void OnChangeFullName(const FString& value);
	void GenerateStrings(TArray<TSharedPtr<FString>>& OutComboBoxStrings, TArray<TSharedPtr<class SToolTip>>& OutToolTips, TArray<bool>& OutRestrictedItems);
};