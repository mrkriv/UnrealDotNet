#pragma once

#include "ExportUtilites.h"
#include "CoreShell.h"


INT_PTR PushToTransferBeffer(INT_PTR source, size_t len);

StringWrapper ConvertToManage_StringWrapper(FString string);
StringWrapper ConvertToManage_StringWrapper(FText text);
StringWrapper ConvertToManage_StringWrapper(FName name);
UClassWrapper ConvertToManage_UClassWrapper(UClass* Class);
ObjectPointerDescription ConvertToManage_ObjectPointerDescription(UObject* object);
ObjectPointerDescription ConvertToManage_ObjectPointerDescription(const UObject* object);

template<class T>
TemplatePointerDescription ConvertToManage_TemplatePointerDescription(T sourceTemplate)
{
	return TemplatePointerDescription();
}

TCHAR* ConvertFromManage_TCHAR(char* String);
FString ConvertFromManage_FString(char* String);
FName ConvertFromManage_FName(char* String);
FText ConvertFromManage_FText(char* String);
UClass* ConvertFromManage_UClass(char* ClassName);