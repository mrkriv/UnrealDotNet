#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Object.h"

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UObject(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UObject>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UObject_BeginDestroy(UObject* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UObject_CanCreateInCurrentContext(UObject* Self, UObject* Template)
	{
		auto _p0 = Template;
		return ConvertForManage(Self->CanCreateInCurrentContext(_p0));
	}

	DOTNET_EXPORT auto E_UObject_CanModify(UObject* Self)
	{
		return ConvertForManage(Self->CanModify());
	}

	DOTNET_EXPORT auto E_UObject_FinishDestroy(UObject* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UObject_GetWorldChecked(UObject* Self, bool bSupported)
	{
		auto _p0 = bSupported;
		return ConvertForManage(Self->GetWorldChecked(_p0));
	}

	DOTNET_EXPORT auto E_UObject_ImplementsGetWorld(UObject* Self)
	{
		return ConvertForManage(Self->ImplementsGetWorld());
	}

	DOTNET_EXPORT auto E_UObject_IsSelected(UObject* Self)
	{
		return ConvertForManage(Self->IsSelected());
	}

	DOTNET_EXPORT auto E_UObject_PostCDOContruct(UObject* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UObject_PostEditImport(UObject* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UObject_PostInitProperties(UObject* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UObject_PostLoad(UObject* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UObject_PostNetReceive(UObject* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UObject_PostRename(UObject* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UObject_PostRepNotifies(UObject* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UObject_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UObject_PreDestroyFromReplication(UObject* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UObject_PreNetReceive(UObject* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UObject_ShutdownAfterError(UObject* Self)
	{
		Self->ShutdownAfterError();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
