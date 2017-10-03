#pragma once

#include "ExportUtilites.h"
#include "CoreShell.h"

auto ConvertToManage_StringWrapper(FString string)
{
	auto utf8 = TCHAR_TO_UTF8(*string);
	auto str = new char[string.Len()];

	StringWrapper wraper;
	wraper.Pointer = (INT_PTR)str;
	wraper.Len = string.Len();

	FMemory::Memcpy(str, utf8, string.Len());

	// todo: использовать статичный буфер для передачи строк в шарп
	NeedDeleteQueue.Enqueue((INT_PTR)str);

	return wraper;
}

auto ConvertToManage_StringWrapper(FText text)
{
	return ConvertToManage_StringWrapper(text.ToString());
}

auto ConvertToManage_StringWrapper(FName name)
{
	return ConvertToManage_StringWrapper(name.ToString());
}

auto ConvertToManage_ObjectPointerDescription(UObject* object)
{
	auto name = object->GetClass()->GetPrefixCPP() + object->GetClass()->GetName();
	auto utf8 = TCHAR_TO_UTF8(*name);
	auto string = new char[name.Len()];

	ObjectPointerDescription desc;
	desc.Pointer = (INT_PTR)object;
	desc.TypeNameLen = name.Len();
	desc.TypeName = (INT_PTR)string;

	FMemory::Memcpy(string, utf8, name.Len());

	// todo: использовать статичный буфер для передачи строк в шарп
	NeedDeleteQueue.Enqueue((INT_PTR)string);

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
