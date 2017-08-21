static char StuructTranferBuffer[1024] = { 0 };
static size_t StuructTranferOffest = 0;

#include "Generate/Index.inl"

extern "C" UNREALDOTNETRUNTIME_API void E_ULOG_E(char* Message) { UE_LOG(NetCoreRuntime, Error, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" UNREALDOTNETRUNTIME_API void E_ULOG_W(char* Message) { UE_LOG(NetCoreRuntime, Warning, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" UNREALDOTNETRUNTIME_API void E_ULOG_L(char* Message) { UE_LOG(NetCoreRuntime, Log, TEXT("%s"), UTF8_TO_TCHAR(Message)); }

extern "C" UNREALDOTNETRUNTIME_API INT_PTR E_GetTranferBufferPtr() { return (INT_PTR)&StuructTranferBuffer[0]; }
extern "C" UNREALDOTNETRUNTIME_API size_t E_GetTranferBufferOffest() { return StuructTranferOffest; }

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
//			UE_LOG(NetCoreRuntime, Error, TEXT("Type %s have not %s function"), *Object->GetName(), UTF8_TO_TCHAR(FunctionName));
//			return;
//		}
//
//		Class->ProcessEvent(func, Arguments);
//	}
//}