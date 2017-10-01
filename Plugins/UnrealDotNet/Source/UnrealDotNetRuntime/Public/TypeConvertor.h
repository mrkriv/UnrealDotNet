#pragma once

#include "ExportUtilites.h"
#include "CoreShell.h"

#define GENEGATE_SIMPLE(TYPE) \
TYPE ConvertForManage(TYPE object)	 \
{									 \
	return object;					 \
}									 

//template<typename T>
//T ConvertForManage(T object)
//{
//	return object;
//}

// todo:: подучить с++ и убрать этот костыль

GENEGATE_SIMPLE(bool)
GENEGATE_SIMPLE(int8)
GENEGATE_SIMPLE(int32)
GENEGATE_SIMPLE(int64)
GENEGATE_SIMPLE(uint8)
GENEGATE_SIMPLE(uint32)
GENEGATE_SIMPLE(uint64)
GENEGATE_SIMPLE(long)
GENEGATE_SIMPLE(char*)
GENEGATE_SIMPLE(float)
GENEGATE_SIMPLE(double)
GENEGATE_SIMPLE(FString)

ObjectPointerDescription ConvertForManage(UObject* object)
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