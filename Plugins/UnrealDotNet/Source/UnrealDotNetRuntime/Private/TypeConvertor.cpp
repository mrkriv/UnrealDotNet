#include "UnrealDotNetRuntime.h"
#include "EngineMinimal.h"
#include "TypeConvertor.h"
#include <mutex>

#define TRANSFER_BEFFER_SIZE 8*1024

uint8 TransferBuffer[TRANSFER_BEFFER_SIZE];

INT_PTR TransferBuffer_Index = (INT_PTR)&TransferBuffer[0];
INT_PTR TransferBuffer_End = (INT_PTR)&TransferBuffer[TRANSFER_BEFFER_SIZE - 1];
std::mutex TransferBufferMutex;

INT_PTR PushToTransferBeffer(INT_PTR source, size_t len)
{
	TransferBufferMutex.lock();

	check((INT_PTR)len <= TransferBuffer_End);

	if (TransferBuffer_Index + (INT_PTR)len > TransferBuffer_End)
	{
		TransferBuffer_Index = (INT_PTR)& TransferBuffer[0];
	}

	FMemory::Memcpy((void*)TransferBuffer_Index, (void*)source, len);

	auto ptr = TransferBuffer_Index;
	TransferBuffer_Index += len;

	TransferBufferMutex.unlock();

	return ptr;
}

StringWrapper ConvertToManage_StringWrapper(FString string)
{
	auto utf8 = TCHAR_TO_UTF8(*string);

	StringWrapper wraper;
	wraper.Pointer = PushToTransferBeffer((INT_PTR)utf8, string.Len());
	wraper.Len = string.Len();

	return wraper;
}

StringWrapper ConvertToManage_StringWrapper(FText text)
{
	return ConvertToManage_StringWrapper(text.ToString());
}

StringWrapper ConvertToManage_StringWrapper(FName name)
{
	return ConvertToManage_StringWrapper(name.ToString());
}

UClassWrapper ConvertToManage_UClassWrapper(UClass* Class)
{
	auto name = Class->GetFName().ToString();
	auto utf8 = TCHAR_TO_UTF8(*name);

	UClassWrapper wraper;
	wraper.Pointer = PushToTransferBeffer((INT_PTR)utf8, name.Len());
	wraper.Len = name.Len();
	
	return wraper;
}

ObjectPointerDescription ConvertToManage_ObjectPointerDescription(UObject* object)
{
	FString name;
	if (object != NULL)
	{
		name = object->GetClass()->GetPrefixCPP() + object->GetClass()->GetName();
	}
	else
	{
		name = "UObject";
	}

	auto utf8 = TCHAR_TO_UTF8(*name);

	ObjectPointerDescription desc;
	desc.Pointer = (INT_PTR)object;
	desc.TypeNameLen = name.Len();
	desc.TypeName = PushToTransferBeffer((INT_PTR)utf8, name.Len());

	return desc;
}

ObjectPointerDescription ConvertToManage_ObjectPointerDescription(const UObject* object)
{
	FString name;
	if (object != NULL)
	{
		name = object->GetClass()->GetPrefixCPP() + object->GetClass()->GetName();
	}
	else
	{
		name = "UObject";
	}

	auto utf8 = TCHAR_TO_UTF8(*name);

	ObjectPointerDescription desc;
	desc.Pointer = (INT_PTR)object;
	desc.TypeNameLen = name.Len();
	desc.TypeName = PushToTransferBeffer((INT_PTR)utf8, name.Len());

	return desc;
}

TCHAR* ConvertFromManage_TCHAR(char* String)
{
	return UTF8_TO_TCHAR(String);
}

FString ConvertFromManage_FString(char* String)
{
	return FString(UTF8_TO_TCHAR(String));
}

FName ConvertFromManage_FName(char* String)
{
	return FName(UTF8_TO_TCHAR(String));
}

FText ConvertFromManage_FText(char* String)
{
	return FText::FromString(FString(UTF8_TO_TCHAR(String)));
}

UClass* ConvertFromManage_UClass(char* ClassName)
{
	//return FindObject<UClass>(ANY_PACKAGE, ClassName);
	//UClass* Result = StaticLoadClass(UObject::StaticClass(), nullptr, ClassName, nullptr, LOAD_None, nullptr);
	return NULL;
}