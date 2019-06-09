#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageLocalPlayer.h"
#include "Runtime/Engine/Classes/Engine/LocalPlayer.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\LocalPlayer.h:163

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ULocalPlayer_LastViewLocation_GET(ULocalPlayer* Ptr) { return (INT_PTR)&(Ptr->LastViewLocation); }
	DOTNET_EXPORT void E_PROP_ULocalPlayer_LastViewLocation_SET(ULocalPlayer* Ptr, INT_PTR Value) { Ptr->LastViewLocation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_ULocalPlayer_Origin_GET(ULocalPlayer* Ptr) { return (INT_PTR)&(Ptr->Origin); }
	DOTNET_EXPORT void E_PROP_ULocalPlayer_Origin_SET(ULocalPlayer* Ptr, INT_PTR Value) { Ptr->Origin = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_ULocalPlayer_Size_GET(ULocalPlayer* Ptr) { return (INT_PTR)&(Ptr->Size); }
	DOTNET_EXPORT void E_PROP_ULocalPlayer_Size_SET(ULocalPlayer* Ptr, INT_PTR Value) { Ptr->Size = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_ULocalPlayer_ViewportClient_GET(ULocalPlayer* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->ViewportClient); }
	DOTNET_EXPORT void E_PROP_ULocalPlayer_ViewportClient_SET(ULocalPlayer* Ptr, UGameViewportClient* Value) { Ptr->ViewportClient = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULocalPlayer(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULocalPlayer>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULocalPlayer_GetControllerId(ULocalPlayer* Self)
	{
		return Self->GetControllerId();
	}

	DOTNET_EXPORT auto E_ULocalPlayer_GetGameLoginOptions(ULocalPlayer* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetGameLoginOptions());
	}

	DOTNET_EXPORT auto E_ULocalPlayer_GetNickname(ULocalPlayer* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetNickname());
	}

	DOTNET_EXPORT auto E_ULocalPlayer_GetPixelBoundingBox(ULocalPlayer* Self, INT_PTR ActorBox, INT_PTR OutLowerLeft, INT_PTR OutUpperRight, INT_PTR OptionalAllotedSize)
	{
		auto& _p0 = *(FBox*)ActorBox;
		auto& _p1 = *(FVector2D*)OutLowerLeft;
		auto& _p2 = *(FVector2D*)OutUpperRight;
		auto _p3 = (FVector2D*)OptionalAllotedSize;
		return Self->GetPixelBoundingBox(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_ULocalPlayer_GetPixelPoint(ULocalPlayer* Self, INT_PTR InPoint, INT_PTR OutPoint, INT_PTR OptionalAllotedSize)
	{
		auto& _p0 = *(FVector*)InPoint;
		auto& _p1 = *(FVector2D*)OutPoint;
		auto _p2 = (FVector2D*)OptionalAllotedSize;
		return Self->GetPixelPoint(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULocalPlayer_InitOnlineSession(ULocalPlayer* Self)
	{
		Self->InitOnlineSession();
	}

	DOTNET_EXPORT auto E_ULocalPlayer_IsCachedUniqueNetIdPairedWithControllerId(ULocalPlayer* Self)
	{
		return Self->IsCachedUniqueNetIdPairedWithControllerId();
	}

	DOTNET_EXPORT auto E_ULocalPlayer_IsPrimaryPlayer(ULocalPlayer* Self)
	{
		return Self->IsPrimaryPlayer();
	}

	DOTNET_EXPORT auto E_ULocalPlayer_PlayerAdded(ULocalPlayer* Self, UGameViewportClient* InViewportClient, int32 InControllerID)
	{
		auto _p0 = InViewportClient;
		auto _p1 = InControllerID;
		Self->PlayerAdded(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULocalPlayer_PlayerRemoved(ULocalPlayer* Self)
	{
		Self->PlayerRemoved();
	}

	DOTNET_EXPORT auto E_ULocalPlayer_SendSplitJoin(ULocalPlayer* Self)
	{
		Self->SendSplitJoin();
	}

	DOTNET_EXPORT auto E_ULocalPlayer_SetControllerId(ULocalPlayer* Self, int32 NewControllerId)
	{
		auto _p0 = NewControllerId;
		Self->SetControllerId(_p0);
	}

	DOTNET_EXPORT auto E_ULocalPlayer_SpawnPlayActor(ULocalPlayer* Self, char* URL, char* OutError, UWorld* InWorld)
	{
		auto _p0 = ConvertFromManage_FString(URL);
		auto _p1 = ConvertFromManage_FString(OutError);
		auto _p2 = InWorld;
		return Self->SpawnPlayActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_InitOnlineSession(ULocalPlayer* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__InitOnlineSession();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PlayerRemoved(ULocalPlayer* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__PlayerRemoved();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_SendSplitJoin(ULocalPlayer* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__SendSplitJoin();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_SetControllerId(ULocalPlayer* Self, int32 NewControllerId)
	{
		auto _p0 = NewControllerId;
		((UManageLocalPlayer*)Self)->_Supper__SetControllerId(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_BeginDestroy(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_FinishDestroy(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PostCDOContruct(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PostEditImport(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PostInitProperties(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PostLoad(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PostNetReceive(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PostRepNotifies(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageLocalPlayer*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PreDestroyFromReplication(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_PreNetReceive(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_ShutdownAfterError(UObject* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__ULocalPlayer_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageLocalPlayer*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
