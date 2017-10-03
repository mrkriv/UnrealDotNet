#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Object.h"

class E_PROTECTED_WRAP_UObject : protected UObject
{
public:
	FString GetDetailedInfoInternal_WRAP()
	{
		return GetDetailedInfoInternal();
	}

}
;

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UObject(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UObject>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UObject_AreNativePropertiesIdenticalTo(UObject* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UObject_BeginDestroy(UObject* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UObject_CanCreateInCurrentContext(UObject* Self, UObject* Template)
	{
		auto _p0 = Template;
		return Self->CanCreateInCurrentContext(_p0);
	}

	DOTNET_EXPORT auto E_UObject_CanModify(UObject* Self)
	{
		return Self->CanModify();
	}

	DOTNET_EXPORT auto E_UObject_FinishDestroy(UObject* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UObject_GetDesc(UObject* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UObject_GetDetailedInfoInternal(UObject* Self)
	{
		return ConvertToManage_StringWrapper(((E_PROTECTED_WRAP_UObject*)Self)->GetDetailedInfoInternal_WRAP());
	}

	DOTNET_EXPORT auto E_UObject_GetWorld(UObject* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_UObject_GetWorldChecked(UObject* Self, bool bSupported)
	{
		auto _p0 = bSupported;
		return ConvertToManage_ObjectPointerDescription(Self->GetWorldChecked(_p0));
	}

	DOTNET_EXPORT auto E_UObject_ImplementsGetWorld(UObject* Self)
	{
		return Self->ImplementsGetWorld();
	}

	DOTNET_EXPORT auto E_UObject_IsAsset(UObject* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UObject_IsEditorOnly(UObject* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UObject_IsFullNameStableForNetworking(UObject* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UObject_IsLocalizedResource(UObject* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UObject_IsNameStableForNetworking(UObject* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UObject_IsPostLoadThreadSafe(UObject* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UObject_IsReadyForFinishDestroy(UObject* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UObject_IsSafeForRootSet(UObject* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UObject_IsSelected(UObject* Self)
	{
		return Self->IsSelected();
	}

	DOTNET_EXPORT auto E_UObject_IsSupportedForNetworking(UObject* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UObject_Modify(UObject* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UObject_NeedsLoadForClient(UObject* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UObject_NeedsLoadForEditorGame(UObject* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UObject_NeedsLoadForServer(UObject* Self)
	{
		return Self->NeedsLoadForServer();
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
