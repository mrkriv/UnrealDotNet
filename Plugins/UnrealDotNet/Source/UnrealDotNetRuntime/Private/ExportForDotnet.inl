#ifndef DOTNET_EXPORT
# if defined(WIN32)
#   define DOTNET_EXPORT __declspec(dllexport)
# elif defined(__GNUC__) && defined(OPUS_BUILD)
#  define DOTNET_EXPORT __attribute__ ((visibility ("default")))
# endif
#endif

#include "Generate/Index.h"

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
	DOTNET_EXPORT void E_UFUNCTION(UObject* Object, char* FunctionName, char* Arguments)
	{
		if (Object == NULL || FunctionName == NULL || Arguments == NULL)
		{
			UE_LOG(DotNetRuntime, Error, TEXT("Invoke UFUNCTION error, argument is null"));
			return;
		}

		auto func = Object->GetClass()->FindFunctionByName(UTF8_TO_TCHAR(FunctionName));
		if (func == NULL)
		{
			UE_LOG(DotNetRuntime, Error, TEXT("Type %s have not %s function"), *Object->GetName(), UTF8_TO_TCHAR(FunctionName));
			return;
		}

		Object->ProcessEvent(func, Arguments);
	}
}