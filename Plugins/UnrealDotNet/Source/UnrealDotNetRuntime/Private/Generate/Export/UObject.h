#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Object.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UObject(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UObject>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_UObject_BeginDestroy(INT_PTR Self)
	{
		((UObject*)Self)->BeginDestroy();
	}

	DOTNET_EXPORT bool E_UObject_CanCreateInCurrentContext(INT_PTR Self, UObject* Template)
	{
		auto _p0 = Template;
		return ((UObject*)Self)->CanCreateInCurrentContext(_p0);
	}

	DOTNET_EXPORT bool E_UObject_CanModify(INT_PTR Self)
	{
		return ((UObject*)Self)->CanModify();
	}

	DOTNET_EXPORT void E_UObject_FinishDestroy(INT_PTR Self)
	{
		((UObject*)Self)->FinishDestroy();
	}

	DOTNET_EXPORT UWorld* E_UObject_GetWorldChecked(INT_PTR Self, bool bSupported)
	{
		auto _p0 = bSupported;
		return ((UObject*)Self)->GetWorldChecked(_p0);
	}

	DOTNET_EXPORT bool E_UObject_ImplementsGetWorld(INT_PTR Self)
	{
		return ((UObject*)Self)->ImplementsGetWorld();
	}

	DOTNET_EXPORT bool E_UObject_IsSelected(INT_PTR Self)
	{
		return ((UObject*)Self)->IsSelected();
	}

	DOTNET_EXPORT void E_UObject_PostCDOContruct(INT_PTR Self)
	{
		((UObject*)Self)->PostCDOContruct();
	}

	DOTNET_EXPORT void E_UObject_PostEditImport(INT_PTR Self)
	{
		((UObject*)Self)->PostEditImport();
	}

	DOTNET_EXPORT void E_UObject_PostInitProperties(INT_PTR Self)
	{
		((UObject*)Self)->PostInitProperties();
	}

	DOTNET_EXPORT void E_UObject_PostLoad(INT_PTR Self)
	{
		((UObject*)Self)->PostLoad();
	}

	DOTNET_EXPORT void E_UObject_PostNetReceive(INT_PTR Self)
	{
		((UObject*)Self)->PostNetReceive();
	}

	DOTNET_EXPORT void E_UObject_PostRename(INT_PTR Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = FName(UTF8_TO_TCHAR(OldName));
		((UObject*)Self)->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT void E_UObject_PostRepNotifies(INT_PTR Self)
	{
		((UObject*)Self)->PostRepNotifies();
	}

	DOTNET_EXPORT void E_UObject_PostSaveRoot(INT_PTR Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UObject*)Self)->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT void E_UObject_PreDestroyFromReplication(INT_PTR Self)
	{
		((UObject*)Self)->PreDestroyFromReplication();
	}

	DOTNET_EXPORT void E_UObject_PreNetReceive(INT_PTR Self)
	{
		((UObject*)Self)->PreNetReceive();
	}

	DOTNET_EXPORT void E_UObject_ShutdownAfterError(INT_PTR Self)
	{
		((UObject*)Self)->ShutdownAfterError();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
