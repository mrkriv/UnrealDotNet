#include "UnrealDotNetRuntime.h"
#include "TypeConvertor.h"


INT_PTR PushToTransferBeffer(INT_PTR source, size_t len)
{
	TransferBufferMutex.lock();

	if (TransferBuffer_Index + (INT_PTR)len > TransferBuffer_End)
	{
		TransferBuffer_Index = 0;
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

ObjectPointerDescription ConvertToManage_ObjectPointerDescription(UObject* object)
{
	auto name = object->GetClass()->GetPrefixCPP() + object->GetClass()->GetName();
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
