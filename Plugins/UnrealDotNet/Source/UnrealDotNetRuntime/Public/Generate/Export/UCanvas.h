#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCanvas.h"
#include "Runtime/Engine/Classes/Engine/Canvas.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Canvas.h:154

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UCanvas_CachedDisplayHeight_GET(UCanvas* Ptr) { return Ptr->CachedDisplayHeight; }
	DOTNET_EXPORT void E_PROP_UCanvas_CachedDisplayHeight_SET(UCanvas* Ptr, int32 Value) { Ptr->CachedDisplayHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_CachedDisplayWidth_GET(UCanvas* Ptr) { return Ptr->CachedDisplayWidth; }
	DOTNET_EXPORT void E_PROP_UCanvas_CachedDisplayWidth_SET(UCanvas* Ptr, int32 Value) { Ptr->CachedDisplayWidth = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_ClipX_GET(UCanvas* Ptr) { return Ptr->ClipX; }
	DOTNET_EXPORT void E_PROP_UCanvas_ClipX_SET(UCanvas* Ptr, float Value) { Ptr->ClipX = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_ClipY_GET(UCanvas* Ptr) { return Ptr->ClipY; }
	DOTNET_EXPORT void E_PROP_UCanvas_ClipY_SET(UCanvas* Ptr, float Value) { Ptr->ClipY = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_ColorModulate_GET(UCanvas* Ptr) { return (INT_PTR)&(Ptr->ColorModulate); }
	DOTNET_EXPORT void E_PROP_UCanvas_ColorModulate_SET(UCanvas* Ptr, INT_PTR Value) { Ptr->ColorModulate = *(FPlane*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_HmdOrientation_GET(UCanvas* Ptr) { return (INT_PTR)&(Ptr->HmdOrientation); }
	DOTNET_EXPORT void E_PROP_UCanvas_HmdOrientation_SET(UCanvas* Ptr, INT_PTR Value) { Ptr->HmdOrientation = *(FQuat*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_OrgX_GET(UCanvas* Ptr) { return Ptr->OrgX; }
	DOTNET_EXPORT void E_PROP_UCanvas_OrgX_SET(UCanvas* Ptr, float Value) { Ptr->OrgX = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_OrgY_GET(UCanvas* Ptr) { return Ptr->OrgY; }
	DOTNET_EXPORT void E_PROP_UCanvas_OrgY_SET(UCanvas* Ptr, float Value) { Ptr->OrgY = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_SafeZonePadEX_GET(UCanvas* Ptr) { return Ptr->SafeZonePadEX; }
	DOTNET_EXPORT void E_PROP_UCanvas_SafeZonePadEX_SET(UCanvas* Ptr, int32 Value) { Ptr->SafeZonePadEX = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_SafeZonePadEY_GET(UCanvas* Ptr) { return Ptr->SafeZonePadEY; }
	DOTNET_EXPORT void E_PROP_UCanvas_SafeZonePadEY_SET(UCanvas* Ptr, int32 Value) { Ptr->SafeZonePadEY = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_SafeZonePadX_GET(UCanvas* Ptr) { return Ptr->SafeZonePadX; }
	DOTNET_EXPORT void E_PROP_UCanvas_SafeZonePadX_SET(UCanvas* Ptr, int32 Value) { Ptr->SafeZonePadX = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_SafeZonePadY_GET(UCanvas* Ptr) { return Ptr->SafeZonePadY; }
	DOTNET_EXPORT void E_PROP_UCanvas_SafeZonePadY_SET(UCanvas* Ptr, int32 Value) { Ptr->SafeZonePadY = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_SizeX_GET(UCanvas* Ptr) { return Ptr->SizeX; }
	DOTNET_EXPORT void E_PROP_UCanvas_SizeX_SET(UCanvas* Ptr, int32 Value) { Ptr->SizeX = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_SizeY_GET(UCanvas* Ptr) { return Ptr->SizeY; }
	DOTNET_EXPORT void E_PROP_UCanvas_SizeY_SET(UCanvas* Ptr, int32 Value) { Ptr->SizeY = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_UnsafeSizeX_GET(UCanvas* Ptr) { return Ptr->UnsafeSizeX; }
	DOTNET_EXPORT void E_PROP_UCanvas_UnsafeSizeX_SET(UCanvas* Ptr, int32 Value) { Ptr->UnsafeSizeX = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_UnsafeSizeY_GET(UCanvas* Ptr) { return Ptr->UnsafeSizeY; }
	DOTNET_EXPORT void E_PROP_UCanvas_UnsafeSizeY_SET(UCanvas* Ptr, int32 Value) { Ptr->UnsafeSizeY = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCanvas_ViewProjectionMatrix_GET(UCanvas* Ptr) { return (INT_PTR)&(Ptr->ViewProjectionMatrix); }
	DOTNET_EXPORT void E_PROP_UCanvas_ViewProjectionMatrix_SET(UCanvas* Ptr, INT_PTR Value) { Ptr->ViewProjectionMatrix = *(FMatrix*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCanvas(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCanvas>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCanvas_ApplySafeZoneTransform(UCanvas* Self)
	{
		Self->ApplySafeZoneTransform();
	}

	DOTNET_EXPORT auto E_UCanvas_PopSafeZoneTransform(UCanvas* Self)
	{
		Self->PopSafeZoneTransform();
	}

	DOTNET_EXPORT auto E_UCanvas_Update(UCanvas* Self)
	{
		Self->Update();
	}

	DOTNET_EXPORT auto E_UCanvas_UpdateAllCanvasSafeZoneData(UCanvas* Self)
	{
		Self->UpdateAllCanvasSafeZoneData();
	}

	DOTNET_EXPORT auto E_UCanvas_UpdateSafeZoneData(UCanvas* Self)
	{
		Self->UpdateSafeZoneData();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_BeginDestroy(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_FinishDestroy(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_PostCDOContruct(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_PostEditImport(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_PostInitProperties(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_PostLoad(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_PostNetReceive(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_PostRepNotifies(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageCanvas*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_PreDestroyFromReplication(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_PreNetReceive(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_ShutdownAfterError(UObject* Self)
	{
		((UManageCanvas*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageCanvas*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UCanvas_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageCanvas*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
