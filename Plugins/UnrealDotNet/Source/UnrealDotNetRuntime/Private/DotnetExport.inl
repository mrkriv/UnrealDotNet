#ifndef DOTNET_EXPORT
# if defined(WIN32)
#   define DOTNET_EXPORT __declspec(dllexport)
# elif defined(__GNUC__)
#  define DOTNET_EXPORT __attribute__ ((visibility ("default")))
# endif
#endif

TQueue<INT_PTR> NeedDeleteQueue;

typedef struct ObjectPointerDescription
{
	INT_PTR Pointer;
	INT_PTR TypeName;
	int32 TypeNameLen;
}
ObjectPointerDescription;

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


#include "Generate/Export/Index.h"

extern "C" DOTNET_EXPORT void E_ULOG_E(char* Message) { UE_LOG(DotNetRuntime, Error, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" DOTNET_EXPORT void E_ULOG_W(char* Message) { UE_LOG(DotNetRuntime, Warning, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" DOTNET_EXPORT void E_ULOG_L(char* Message) { UE_LOG(DotNetRuntime, Log, TEXT("%s"), UTF8_TO_TCHAR(Message)); }

extern "C" DOTNET_EXPORT void E_DeleteStruct(INT_PTR Adress) { delete (void*)Adress; }

extern "C" DOTNET_EXPORT void E_ScreenDebugMessage(char* Message, float Time, uint8 R, uint8 G, uint8 B)
{
	GEngine->AddOnScreenDebugMessage(-1, Time, FColor(R, G, B), UTF8_TO_TCHAR(Message));
}

extern "C"
{
	DOTNET_EXPORT void E_Call_UFunction(UObject* Object, char* NameWithArguments)
	{
		if (Object == NULL || NameWithArguments == NULL)
		{
			UE_LOG(DotNetRuntime, Error, TEXT("Invoke UFUNCTION error, argument is null"));
			return;
		}

		Object->CallFunctionByNameWithArguments(UTF8_TO_TCHAR(NameWithArguments), *GLog, Object, true);
	}
}
