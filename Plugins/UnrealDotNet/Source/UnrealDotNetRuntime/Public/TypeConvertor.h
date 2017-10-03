#pragma once

#include "ExportUtilites.h"
#include "CoreShell.h"
#include <mutex>

#define TRANSFER_BEFFER_SIZE 8*1024

uint8 TransferBuffer[TRANSFER_BEFFER_SIZE];

INT_PTR TransferBuffer_Index = (INT_PTR)&TransferBuffer[0];
INT_PTR TransferBuffer_End = (INT_PTR)&TransferBuffer[TRANSFER_BEFFER_SIZE - 1];
std::mutex TransferBufferMutex;

INT_PTR PushToTransferBeffer(INT_PTR source, size_t len);


StringWrapper ConvertToManage_StringWrapper(FString string);
StringWrapper ConvertToManage_StringWrapper(FText text);
StringWrapper ConvertToManage_StringWrapper(FName name);
ObjectPointerDescription ConvertToManage_ObjectPointerDescription(UObject* object);

TCHAR* ConvertFromManage_TCHAR(char* String);
FString ConvertFromManage_FString(char* String);
FName ConvertFromManage_FName(char* String);
FText ConvertFromManage_FText(char* String);