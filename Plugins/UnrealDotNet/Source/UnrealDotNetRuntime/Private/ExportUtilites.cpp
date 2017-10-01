#include "UnrealDotNetRuntime.h"
#include "ExportUtilites.h"

ObjectPointerDescription MakePrtDesc(UObject* obj)
{
	auto name = obj->GetClass()->GetPrefixCPP() + obj->GetClass()->GetName();
	auto utf8 = TCHAR_TO_UTF8(*name);
	auto string = new char[name.Len()];

	ObjectPointerDescription desc;
	desc.Pointer = (INT_PTR)obj;
	desc.TypeNameLen = name.Len();
	desc.TypeName = (INT_PTR)string;

	FMemory::Memcpy(string, utf8, name.Len());

	// todo: использовать статичный бафер для передачи строк в шарп
	NeedDeleteQueue.Enqueue((INT_PTR)string);

	return desc;
}