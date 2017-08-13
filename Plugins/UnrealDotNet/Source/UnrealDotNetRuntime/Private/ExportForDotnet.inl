#include "ExportForDotnetGenerated.inl"

extern "C" UNREALDOTNETRUNTIME_API void Call_ULOG_E(char* Message) { UE_LOG(NetCoreRuntime, Error, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" UNREALDOTNETRUNTIME_API void Call_ULOG_W(char* Message) { UE_LOG(NetCoreRuntime, Warning, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" UNREALDOTNETRUNTIME_API void Call_ULOG_L(char* Message) { UE_LOG(NetCoreRuntime, Log, TEXT("%s"), UTF8_TO_TCHAR(Message)); }

extern "C" UNREALDOTNETRUNTIME_API void Call_UFUNCTION(UObejct* Object, char* FunctionName, char* Arguments) 
{
	if (Object == NULL || FunctionName == NULL || Arguments == NULL)
	{
		UE_LOG(NetCoreRuntime, Error, TEXT("Invoke UFUNCTION error, argument is null"));
		return;
	}

	auto func = Object->FindFunctionByName(UTF8_TO_TCHAR(FunctionName));
	if (func == NULL)
	{
		UE_LOG(NetCoreRuntime, Error, TEXT("Type %s have not %s function"), *Object->GetName(), UTF8_TO_TCHAR(FunctionName));
		return;
	}

	Class->ProcessEvent(func, Arguments);
}
