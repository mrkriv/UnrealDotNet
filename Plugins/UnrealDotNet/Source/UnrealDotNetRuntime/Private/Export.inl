#ifndef DOTNET_EXPORT
# if defined(WIN32)
#   define DOTNET_EXPORT __declspec(dllexport)
# elif defined(__GNUC__)
#  define DOTNET_EXPORT __attribute__ ((visibility ("default")))
# endif
#endif

#include "ExportUtilites.h"
#include "TypeConvertor.h"

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
