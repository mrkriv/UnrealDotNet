#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Object.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Object.h:35

class E_PROTECTED_WRAP_UObject : protected UObject
{
public:
	bool CanCheckDefaultSubObjects_WRAP(bool bForceCheck, bool& bResult)
	{
		return CanCheckDefaultSubObjects(bForceCheck, bResult);
	}

	bool CheckDefaultSubobjectsInternal_WRAP()
	{
		return CheckDefaultSubobjectsInternal();
	}

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

	DOTNET_EXPORT auto E_UObject_CanCheckDefaultSubObjects(UObject* Self, bool bForceCheck, bool bResult)
	{
		auto _p0 = bForceCheck;
		auto _p1 = bResult;
		return ((E_PROTECTED_WRAP_UObject*)Self)->CanCheckDefaultSubObjects_WRAP(_p0, _p1);
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

	DOTNET_EXPORT auto E_UObject_CheckDefaultSubobjects(UObject* Self, bool bForceCheck)
	{
		auto _p0 = bForceCheck;
		return Self->CheckDefaultSubobjects(_p0);
	}

	DOTNET_EXPORT auto E_UObject_CheckDefaultSubobjectsInternal(UObject* Self)
	{
		return ((E_PROTECTED_WRAP_UObject*)Self)->CheckDefaultSubobjectsInternal_WRAP();
	}

	DOTNET_EXPORT auto E_UObject_ConditionalBeginDestroy(UObject* Self)
	{
		return Self->ConditionalBeginDestroy();
	}

	DOTNET_EXPORT auto E_UObject_ConditionalFinishDestroy(UObject* Self)
	{
		return Self->ConditionalFinishDestroy();
	}

	DOTNET_EXPORT auto E_UObject_ConditionalPostLoad(UObject* Self)
	{
		Self->ConditionalPostLoad();
	}

	DOTNET_EXPORT auto E_UObject_DestroyNonNativeProperties(UObject* Self)
	{
		Self->DestroyNonNativeProperties();
	}

	DOTNET_EXPORT auto E_UObject_ExecuteUbergraph(UObject* Self, int32 EntryPoint)
	{
		auto _p0 = EntryPoint;
		Self->ExecuteUbergraph(_p0);
	}

	DOTNET_EXPORT auto E_UObject_FinishDestroy(UObject* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UObject_GetArchetype(UObject* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetArchetype());
	}

	DOTNET_EXPORT auto E_UObject_GetDefaultConfigFilename(UObject* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDefaultConfigFilename());
	}

	DOTNET_EXPORT auto E_UObject_GetDesc(UObject* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UObject_GetDetailedInfo(UObject* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfo());
	}

	DOTNET_EXPORT auto E_UObject_GetDetailedInfoInternal(UObject* Self)
	{
		return ConvertToManage_StringWrapper(((E_PROTECTED_WRAP_UObject*)Self)->GetDetailedInfoInternal_WRAP());
	}

	DOTNET_EXPORT auto E_UObject_GetGlobalUserConfigFilename(UObject* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetGlobalUserConfigFilename());
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

	DOTNET_EXPORT auto E_UObject_Implements(UObject* Self)
	{
		return Self->Implements();
	}

	DOTNET_EXPORT auto E_UObject_ImplementsGetWorld(UObject* Self)
	{
		return Self->ImplementsGetWorld();
	}

	DOTNET_EXPORT auto E_UObject_IsAsset(UObject* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UObject_IsBasedOnArchetype(UObject* Self, UObject* SomeObject)
	{
		auto _p0 = SomeObject;
		return Self->IsBasedOnArchetype(_p0);
	}

	DOTNET_EXPORT auto E_UObject_IsEditorOnly(UObject* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UObject_IsFullNameStableForNetworking(UObject* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UObject_IsInBlueprint(UObject* Self)
	{
		return Self->IsInBlueprint();
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

	DOTNET_EXPORT auto E_UObject_MarkAsEditorOnlySubobject(UObject* Self)
	{
		Self->MarkAsEditorOnlySubobject();
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

	DOTNET_EXPORT auto E_UObject_UpdateDefaultConfigFile(UObject* Self, char* SpecificFileLocation)
	{
		auto _p0 = ConvertFromManage_FString(SpecificFileLocation);
		Self->UpdateDefaultConfigFile(_p0);
	}

	DOTNET_EXPORT auto E_UObject_UpdateGlobalUserConfigFile(UObject* Self)
	{
		Self->UpdateGlobalUserConfigFile();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
