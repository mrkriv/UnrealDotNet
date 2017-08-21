static char StuructTranferBuffer[1024] = { 0 };
static size_t StuructTranferOffest = 0;

#ifndef DOTNET_EXPORT
# if defined(WIN32)
#   define DOTNET_EXPORT __declspec(dllexport)
# elif defined(__GNUC__) && defined(OPUS_BUILD)
#  define DOTNET_EXPORT __attribute__ ((visibility ("default")))
# endif
#endif

#include "Generate/Index.inl"

extern "C" DOTNET_EXPORT void E_ULOG_E(char* Message) { UE_LOG(DotNetRuntime, Error, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" DOTNET_EXPORT void E_ULOG_W(char* Message) { UE_LOG(DotNetRuntime, Warning, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" DOTNET_EXPORT void E_ULOG_L(char* Message) { UE_LOG(DotNetRuntime, Log, TEXT("%s"), UTF8_TO_TCHAR(Message)); }

extern "C" DOTNET_EXPORT INT_PTR E_GetTranferBufferPtr() { return (INT_PTR)&StuructTranferBuffer[0]; }
extern "C" DOTNET_EXPORT size_t E_GetTranferBufferOffest() { return StuructTranferOffest; }

//extern "C"
//{
//	UNREALDOTNETRUNTIME_API void E_UFUNCTION(UObject* Object, char* FunctionName, char* Arguments)
//	{
//		if (Object == NULL || FunctionName == NULL || Arguments == NULL)
//		{
//			UE_LOG(NetCoreRuntime, Error, TEXT("Invoke UFUNCTION error, argument is null"));
//			return;
//		}
//
//		auto func = Object->FindFunctionByName(UTF8_TO_TCHAR(FunctionName));
//		if (func == NULL)
//		{
//			UE_LOG(DotNetRuntime, Error, TEXT("Type %s have not %s function"), *Object->GetName(), UTF8_TO_TCHAR(FunctionName));
//			return;
//		}
//
//		Class->ProcessEvent(func, Arguments);
//	}
//}