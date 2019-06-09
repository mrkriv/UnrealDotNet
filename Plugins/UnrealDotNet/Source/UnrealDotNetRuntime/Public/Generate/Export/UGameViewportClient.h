#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageGameViewportClient.h"
#include "Runtime/Engine/Classes/Engine/GameViewportClient.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\GameViewportClient.h:55

class E_PROTECTED_WRAP_UGameViewportClient : protected UGameViewportClient
{
public:
	bool GetUseMouseForTouch_WRAP()
	{
		return GetUseMouseForTouch();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UGameViewportClient_MaxSplitscreenPlayers_GET(UGameViewportClient* Ptr) { return Ptr->MaxSplitscreenPlayers; }
	DOTNET_EXPORT void E_PROP_UGameViewportClient_MaxSplitscreenPlayers_SET(UGameViewportClient* Ptr, int32 Value) { Ptr->MaxSplitscreenPlayers = Value; }
	
	DOTNET_EXPORT auto E_PROP_UGameViewportClient_ViewModeIndex_GET(UGameViewportClient* Ptr) { return Ptr->ViewModeIndex; }
	DOTNET_EXPORT void E_PROP_UGameViewportClient_ViewModeIndex_SET(UGameViewportClient* Ptr, int32 Value) { Ptr->ViewModeIndex = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UGameViewportClient(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UGameViewportClient>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UGameViewportClient_CalculateDeadZoneForAllSides(UGameViewportClient* Self, ULocalPlayer* LPlayer, UCanvas* Canvas, float fTopSafeZone, float fBottomSafeZone, float fLeftSafeZone, float fRightSafeZone, bool bUseMaxPercent)
	{
		auto _p0 = LPlayer;
		auto _p1 = Canvas;
		auto& _p2 = fTopSafeZone;
		auto& _p3 = fBottomSafeZone;
		auto& _p4 = fLeftSafeZone;
		auto& _p5 = fRightSafeZone;
		auto _p6 = bUseMaxPercent;
		return Self->CalculateDeadZoneForAllSides(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_ConsoleCommand(UGameViewportClient* Self, char* Command)
	{
		auto _p0 = ConvertFromManage_FString(Command);
		return ConvertToManage_StringWrapper(Self->ConsoleCommand(_p0));
	}

	DOTNET_EXPORT auto E_UGameViewportClient_ConvertLocalPlayerToGamePlayerIndex(UGameViewportClient* Self, ULocalPlayer* LPlayer)
	{
		auto _p0 = LPlayer;
		return Self->ConvertLocalPlayerToGamePlayerIndex(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_DetachViewportClient(UGameViewportClient* Self)
	{
		Self->DetachViewportClient();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_DrawTitleSafeArea(UGameViewportClient* Self, UCanvas* Canvas)
	{
		auto _p0 = Canvas;
		Self->DrawTitleSafeArea(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_DrawTransition(UGameViewportClient* Self, UCanvas* Canvas)
	{
		auto _p0 = Canvas;
		Self->DrawTransition(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_DrawTransitionMessage(UGameViewportClient* Self, UCanvas* Canvas, char* Message)
	{
		auto _p0 = Canvas;
		auto _p1 = ConvertFromManage_FString(Message);
		Self->DrawTransitionMessage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_GetDisableSplitscreenOverride(UGameViewportClient* Self)
	{
		return Self->GetDisableSplitscreenOverride();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_GetMousePosition(UGameViewportClient* Self, INT_PTR MousePosition)
	{
		auto& _p0 = *(FVector2D*)MousePosition;
		return Self->GetMousePosition(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_GetPixelSizeOfScreen(UGameViewportClient* Self, float Width, float Height, UCanvas* Canvas, int32 LocalPlayerIndex)
	{
		auto& _p0 = Width;
		auto& _p1 = Height;
		auto _p2 = Canvas;
		auto _p3 = LocalPlayerIndex;
		Self->GetPixelSizeOfScreen(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_GetSubtitleRegion(UGameViewportClient* Self, INT_PTR MinPos, INT_PTR MaxPos)
	{
		auto& _p0 = *(FVector2D*)MinPos;
		auto& _p1 = *(FVector2D*)MaxPos;
		Self->GetSubtitleRegion(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_GetUseMouseForTouch(UGameViewportClient* Self)
	{
		return ((E_PROTECTED_WRAP_UGameViewportClient*)Self)->GetUseMouseForTouch_WRAP();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_GetViewportSize(UGameViewportClient* Self, INT_PTR ViewportSize)
	{
		auto& _p0 = *(FVector2D*)ViewportSize;
		Self->GetViewportSize(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_HandleToggleFullscreenCommand(UGameViewportClient* Self)
	{
		return Self->HandleToggleFullscreenCommand();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_HasBottomSafeZone(UGameViewportClient* Self, int32 LocalPlayerIndex)
	{
		auto _p0 = LocalPlayerIndex;
		return Self->HasBottomSafeZone(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_HasLeftSafeZone(UGameViewportClient* Self, int32 LocalPlayerIndex)
	{
		auto _p0 = LocalPlayerIndex;
		return Self->HasLeftSafeZone(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_HasRightSafeZone(UGameViewportClient* Self, int32 LocalPlayerIndex)
	{
		auto _p0 = LocalPlayerIndex;
		return Self->HasRightSafeZone(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_HasTopSafeZone(UGameViewportClient* Self, int32 LocalPlayerIndex)
	{
		auto _p0 = LocalPlayerIndex;
		return Self->HasTopSafeZone(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_IsExclusiveFullscreenViewport(UGameViewportClient* Self)
	{
		return Self->IsExclusiveFullscreenViewport();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_IsFullScreenViewport(UGameViewportClient* Self)
	{
		return Self->IsFullScreenViewport();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_IsSimulateInEditorViewport(UGameViewportClient* Self)
	{
		return Self->IsSimulateInEditorViewport();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_LayoutPlayers(UGameViewportClient* Self)
	{
		Self->LayoutPlayers();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_NotifyPlayerAdded(UGameViewportClient* Self, int32 PlayerIndex, ULocalPlayer* AddedPlayer)
	{
		auto _p0 = PlayerIndex;
		auto _p1 = AddedPlayer;
		Self->NotifyPlayerAdded(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_NotifyPlayerRemoved(UGameViewportClient* Self, int32 PlayerIndex, ULocalPlayer* RemovedPlayer)
	{
		auto _p0 = PlayerIndex;
		auto _p1 = RemovedPlayer;
		Self->NotifyPlayerRemoved(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_PostRender(UGameViewportClient* Self, UCanvas* Canvas)
	{
		auto _p0 = Canvas;
		Self->PostRender(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_RebuildCursors(UGameViewportClient* Self)
	{
		Self->RebuildCursors();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_RemoveAllViewportWidgets(UGameViewportClient* Self)
	{
		Self->RemoveAllViewportWidgets();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetCaptureMouseOnClick(UGameViewportClient* Self, EMouseCaptureMode Mode)
	{
		auto _p0 = Mode;
		Self->SetCaptureMouseOnClick(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetConsoleTarget(UGameViewportClient* Self, int32 PlayerIndex)
	{
		auto _p0 = PlayerIndex;
		Self->SetConsoleTarget(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetDisableSplitscreenOverride(UGameViewportClient* Self, bool bDisabled)
	{
		auto _p0 = bDisabled;
		Self->SetDisableSplitscreenOverride(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetDropDetail(UGameViewportClient* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->SetDropDetail(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetHideCursorDuringCapture(UGameViewportClient* Self, bool InHideCursorDuringCapture)
	{
		auto _p0 = InHideCursorDuringCapture;
		Self->SetHideCursorDuringCapture(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetIgnoreInput(UGameViewportClient* Self, bool Ignore)
	{
		auto _p0 = Ignore;
		Self->SetIgnoreInput(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetLockDuringCapture(UGameViewportClient* Self, bool InLockDuringCapture)
	{
		auto _p0 = InLockDuringCapture;
		Self->SetLockDuringCapture(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetMouseLockMode(UGameViewportClient* Self, EMouseLockMode InMouseLockMode)
	{
		auto _p0 = InMouseLockMode;
		Self->SetMouseLockMode(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetSuppressTransitionMessage(UGameViewportClient* Self, bool bSuppress)
	{
		auto _p0 = bSuppress;
		Self->SetSuppressTransitionMessage(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetupInitialLocalPlayer(UGameViewportClient* Self, char* OutError)
	{
		auto _p0 = ConvertFromManage_FString(OutError);
		return ConvertToManage_ObjectPointerDescription(Self->SetupInitialLocalPlayer(_p0));
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SetUseSoftwareCursorWidgets(UGameViewportClient* Self, bool bInUseSoftwareCursorWidgets)
	{
		auto _p0 = bInUseSoftwareCursorWidgets;
		Self->SetUseSoftwareCursorWidgets(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_ShouldForceFullscreenViewport(UGameViewportClient* Self)
	{
		return Self->ShouldForceFullscreenViewport();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_ShowTitleSafeArea(UGameViewportClient* Self)
	{
		Self->ShowTitleSafeArea();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_SSSwapControllers(UGameViewportClient* Self)
	{
		Self->SSSwapControllers();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_Tick(UGameViewportClient* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		Self->Tick(_p0);
	}

	DOTNET_EXPORT auto E_UGameViewportClient_UpdateActiveSplitscreenType(UGameViewportClient* Self)
	{
		Self->UpdateActiveSplitscreenType();
	}

	DOTNET_EXPORT auto E_UGameViewportClient_VerifyPathRenderingComponents(UGameViewportClient* Self)
	{
		Self->VerifyPathRenderingComponents();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_DetachViewportClient(UGameViewportClient* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__DetachViewportClient();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_LayoutPlayers(UGameViewportClient* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__LayoutPlayers();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_SetConsoleTarget(UGameViewportClient* Self, int32 PlayerIndex)
	{
		auto _p0 = PlayerIndex;
		((UManageGameViewportClient*)Self)->_Supper__SetConsoleTarget(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_SetDropDetail(UGameViewportClient* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((UManageGameViewportClient*)Self)->_Supper__SetDropDetail(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_ShowTitleSafeArea(UGameViewportClient* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__ShowTitleSafeArea();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_SSSwapControllers(UGameViewportClient* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__SSSwapControllers();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_Tick(UGameViewportClient* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManageGameViewportClient*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_UpdateActiveSplitscreenType(UGameViewportClient* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__UpdateActiveSplitscreenType();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_VerifyPathRenderingComponents(UGameViewportClient* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__VerifyPathRenderingComponents();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_BeginDestroy(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_FinishDestroy(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_PostCDOContruct(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_PostEditImport(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_PostInitProperties(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_PostLoad(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_PostNetReceive(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_PostRepNotifies(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageGameViewportClient*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_PreDestroyFromReplication(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_PreNetReceive(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_ShutdownAfterError(UObject* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UGameViewportClient_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageGameViewportClient*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
