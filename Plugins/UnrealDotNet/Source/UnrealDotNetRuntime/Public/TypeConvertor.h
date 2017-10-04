#pragma once

#include "ExportUtilites.h"
#include "CoreShell.h"


INT_PTR PushToTransferBeffer(INT_PTR source, size_t len);

StringWrapper ConvertToManage_StringWrapper(FString string);
StringWrapper ConvertToManage_StringWrapper(FText text);
StringWrapper ConvertToManage_StringWrapper(FName name);
ObjectPointerDescription ConvertToManage_ObjectPointerDescription(UObject* object);

TCHAR* ConvertFromManage_TCHAR(char* String);
FString ConvertFromManage_FString(char* String);
FName ConvertFromManage_FName(char* String);
FText ConvertFromManage_FText(char* String);