#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageHUD.h"
#include "Runtime/Engine/Classes/GameFramework/HUD.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\HUD.h:36

class E_PROTECTED_WRAP_AHUD : protected AHUD
{
public:
	bool IsCanvasValid_WarnIfNot_WRAP()
	{
		return IsCanvasValid_WarnIfNot();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_AHUD_bEnableDebugTextShadow_GET(AHUD* Ptr) { return Ptr->bEnableDebugTextShadow; }
	DOTNET_EXPORT void E_PROP_AHUD_bEnableDebugTextShadow_SET(AHUD* Ptr, uint8 Value) { Ptr->bEnableDebugTextShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_bLostFocusPaused_GET(AHUD* Ptr) { return Ptr->bLostFocusPaused; }
	DOTNET_EXPORT void E_PROP_AHUD_bLostFocusPaused_SET(AHUD* Ptr, uint8 Value) { Ptr->bLostFocusPaused = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_bShowDebugInfo_GET(AHUD* Ptr) { return Ptr->bShowDebugInfo; }
	DOTNET_EXPORT void E_PROP_AHUD_bShowDebugInfo_SET(AHUD* Ptr, uint8 Value) { Ptr->bShowDebugInfo = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_bShowHitBoxDebugInfo_GET(AHUD* Ptr) { return Ptr->bShowHitBoxDebugInfo; }
	DOTNET_EXPORT void E_PROP_AHUD_bShowHitBoxDebugInfo_SET(AHUD* Ptr, uint8 Value) { Ptr->bShowHitBoxDebugInfo = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_bShowHUD_GET(AHUD* Ptr) { return Ptr->bShowHUD; }
	DOTNET_EXPORT void E_PROP_AHUD_bShowHUD_SET(AHUD* Ptr, uint8 Value) { Ptr->bShowHUD = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_bShowOverlays_GET(AHUD* Ptr) { return Ptr->bShowOverlays; }
	DOTNET_EXPORT void E_PROP_AHUD_bShowOverlays_SET(AHUD* Ptr, uint8 Value) { Ptr->bShowOverlays = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_CurrentTargetIndex_GET(AHUD* Ptr) { return Ptr->CurrentTargetIndex; }
	DOTNET_EXPORT void E_PROP_AHUD_CurrentTargetIndex_SET(AHUD* Ptr, int32 Value) { Ptr->CurrentTargetIndex = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_LastHUDRenderTime_GET(AHUD* Ptr) { return Ptr->LastHUDRenderTime; }
	DOTNET_EXPORT void E_PROP_AHUD_LastHUDRenderTime_SET(AHUD* Ptr, float Value) { Ptr->LastHUDRenderTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_PlayerOwner_GET(AHUD* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PlayerOwner); }
	DOTNET_EXPORT void E_PROP_AHUD_PlayerOwner_SET(AHUD* Ptr, APlayerController* Value) { Ptr->PlayerOwner = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_RenderDelta_GET(AHUD* Ptr) { return Ptr->RenderDelta; }
	DOTNET_EXPORT void E_PROP_AHUD_RenderDelta_SET(AHUD* Ptr, float Value) { Ptr->RenderDelta = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AHUD(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AHUD>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AHUD_AddDebugText(AHUD* Self, char* DebugText, AActor* SrcActor, float Duration, INT_PTR Offset, INT_PTR DesiredOffset)
	{
		auto _p0 = ConvertFromManage_FString(DebugText);
		auto _p1 = SrcActor;
		auto _p2 = Duration;
		auto _p3 = *(FVector*)Offset;
		auto _p4 = *(FVector*)DesiredOffset;
		Self->AddDebugText(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_AHUD_AddHitBox(AHUD* Self, INT_PTR Position, INT_PTR Size, char* InName, bool bConsumesInput, int32 Priority)
	{
		auto _p0 = *(FVector2D*)Position;
		auto _p1 = *(FVector2D*)Size;
		auto _p2 = ConvertFromManage_FName(InName);
		auto _p3 = bConsumesInput;
		auto _p4 = Priority;
		Self->AddHitBox(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_AHUD_AddPostRenderedActor(AHUD* Self, AActor* A)
	{
		auto _p0 = A;
		Self->AddPostRenderedActor(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_AnyCurrentHitBoxHits(AHUD* Self)
	{
		return Self->AnyCurrentHitBoxHits();
	}

	DOTNET_EXPORT auto E_AHUD_Deproject(AHUD* Self, float ScreenX, float ScreenY, INT_PTR WorldPosition, INT_PTR WorldDirection)
	{
		auto _p0 = ScreenX;
		auto _p1 = ScreenY;
		auto& _p2 = *(FVector*)WorldPosition;
		auto& _p3 = *(FVector*)WorldDirection;
		Self->Deproject(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_AHUD_DrawActorOverlays(AHUD* Self, INT_PTR Viewpoint, INT_PTR ViewRotation)
	{
		auto _p0 = *(FVector*)Viewpoint;
		auto _p1 = *(FRotator*)ViewRotation;
		Self->DrawActorOverlays(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_DrawDebugTextList(AHUD* Self)
	{
		Self->DrawDebugTextList();
	}

	DOTNET_EXPORT auto E_AHUD_DrawHUD(AHUD* Self)
	{
		Self->DrawHUD();
	}

	DOTNET_EXPORT auto E_AHUD_DrawLine(AHUD* Self, float StartScreenX, float StartScreenY, float EndScreenX, float EndScreenY, INT_PTR LineColor, float LineThickness)
	{
		auto _p0 = StartScreenX;
		auto _p1 = StartScreenY;
		auto _p2 = EndScreenX;
		auto _p3 = EndScreenY;
		auto _p4 = *(FLinearColor*)LineColor;
		auto _p5 = LineThickness;
		Self->DrawLine(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_AHUD_DrawRect(AHUD* Self, INT_PTR RectColor, float ScreenX, float ScreenY, float ScreenW, float ScreenH)
	{
		auto _p0 = *(FLinearColor*)RectColor;
		auto _p1 = ScreenX;
		auto _p2 = ScreenY;
		auto _p3 = ScreenW;
		auto _p4 = ScreenH;
		Self->DrawRect(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_AHUD_DrawSafeZoneOverlay(AHUD* Self)
	{
		Self->DrawSafeZoneOverlay();
	}

	DOTNET_EXPORT auto E_AHUD_DrawText(AHUD* Self, char* Text, INT_PTR TextColor, float ScreenX, float ScreenY)
	{
		auto _p0 = ConvertFromManage_FString(Text);
		auto _p1 = *(FLinearColor*)TextColor;
		auto _p2 = ScreenX;
		auto _p3 = ScreenY;
		Self->DrawText(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_AHUD_GetCurrentDebugTargetActor(AHUD* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCurrentDebugTargetActor());
	}

	DOTNET_EXPORT auto E_AHUD_GetOwningPawn(AHUD* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetOwningPawn());
	}

	DOTNET_EXPORT auto E_AHUD_GetOwningPlayerController(AHUD* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetOwningPlayerController());
	}

	DOTNET_EXPORT auto E_AHUD_GetTextSize(AHUD* Self, char* Text, float OutWidth, float OutHeight)
	{
		auto _p0 = ConvertFromManage_FString(Text);
		auto& _p1 = OutWidth;
		auto& _p2 = OutHeight;
		Self->GetTextSize(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AHUD_HandleBugScreenShot(AHUD* Self)
	{
		Self->HandleBugScreenShot();
	}

	DOTNET_EXPORT auto E_AHUD_IsCanvasValid_WarnIfNot(AHUD* Self)
	{
		return ((E_PROTECTED_WRAP_AHUD*)Self)->IsCanvasValid_WarnIfNot_WRAP();
	}

	DOTNET_EXPORT auto E_AHUD_NextDebugTarget(AHUD* Self)
	{
		Self->NextDebugTarget();
	}

	DOTNET_EXPORT auto E_AHUD_NotifyBindPostProcessEffects(AHUD* Self)
	{
		Self->NotifyBindPostProcessEffects();
	}

	DOTNET_EXPORT auto E_AHUD_NotifyHitBoxBeginCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->NotifyHitBoxBeginCursorOver(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_NotifyHitBoxClick(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->NotifyHitBoxClick(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_NotifyHitBoxEndCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->NotifyHitBoxEndCursorOver(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_NotifyHitBoxRelease(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->NotifyHitBoxRelease(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_OnLostFocusPause(AHUD* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->OnLostFocusPause(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_PostRender(AHUD* Self)
	{
		Self->PostRender();
	}

	DOTNET_EXPORT auto E_AHUD_PreviousDebugTarget(AHUD* Self)
	{
		Self->PreviousDebugTarget();
	}

	DOTNET_EXPORT auto E_AHUD_Project(AHUD* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->Project(_p0));
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveDrawHUD(AHUD* Self, int32 SizeX, int32 SizeY)
	{
		auto _p0 = SizeX;
		auto _p1 = SizeY;
		Self->ReceiveDrawHUD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveHitBoxBeginCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->ReceiveHitBoxBeginCursorOver(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveHitBoxClick(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->ReceiveHitBoxClick(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveHitBoxEndCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->ReceiveHitBoxEndCursorOver(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveHitBoxRelease(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->ReceiveHitBoxRelease(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_RemoveAllDebugStrings(AHUD* Self)
	{
		Self->RemoveAllDebugStrings();
	}

	DOTNET_EXPORT auto E_AHUD_RemoveDebugText(AHUD* Self, AActor* SrcActor, bool bLeaveDurationText)
	{
		auto _p0 = SrcActor;
		auto _p1 = bLeaveDurationText;
		Self->RemoveDebugText(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_RemovePostRenderedActor(AHUD* Self, AActor* A)
	{
		auto _p0 = A;
		Self->RemovePostRenderedActor(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_SetCanvas(AHUD* Self, UCanvas* InCanvas, UCanvas* InDebugCanvas)
	{
		auto _p0 = InCanvas;
		auto _p1 = InDebugCanvas;
		Self->SetCanvas(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_ShouldDisplayDebug(AHUD* Self, char* DebugType)
	{
		auto _p0 = ConvertFromManage_FName(DebugType);
		return Self->ShouldDisplayDebug(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ShowDebug(AHUD* Self, char* DebugType)
	{
		auto _p0 = ConvertFromManage_FName(DebugType);
		Self->ShowDebug(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ShowDebugInfo(AHUD* Self, float YL, float YPos)
	{
		auto& _p0 = YL;
		auto& _p1 = YPos;
		Self->ShowDebugInfo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_ShowDebugToggleSubCategory(AHUD* Self, char* Category)
	{
		auto _p0 = ConvertFromManage_FName(Category);
		Self->ShowDebugToggleSubCategory(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ShowHUD(AHUD* Self)
	{
		Self->ShowHUD();
	}

	DOTNET_EXPORT auto E_AHUD_UpdateAndDispatchHitBoxClickEvents(AHUD* Self, INT_PTR ClickLocation, EInputEvent InEventType)
	{
		auto _p0 = *(FVector2D*)ClickLocation;
		auto _p1 = InEventType;
		return Self->UpdateAndDispatchHitBoxClickEvents(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_DrawHUD(AHUD* Self)
	{
		((AManageHUD*)Self)->_Supper__DrawHUD();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_DrawSafeZoneOverlay(AHUD* Self)
	{
		((AManageHUD*)Self)->_Supper__DrawSafeZoneOverlay();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_HandleBugScreenShot(AHUD* Self)
	{
		((AManageHUD*)Self)->_Supper__HandleBugScreenShot();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_NextDebugTarget(AHUD* Self)
	{
		((AManageHUD*)Self)->_Supper__NextDebugTarget();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_NotifyBindPostProcessEffects(AHUD* Self)
	{
		((AManageHUD*)Self)->_Supper__NotifyBindPostProcessEffects();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_OnLostFocusPause(AHUD* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		((AManageHUD*)Self)->_Supper__OnLostFocusPause(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostRender(AHUD* Self)
	{
		((AManageHUD*)Self)->_Supper__PostRender();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PreviousDebugTarget(AHUD* Self)
	{
		((AManageHUD*)Self)->_Supper__PreviousDebugTarget();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_ShowDebugInfo(AHUD* Self, float YL, float YPos)
	{
		auto& _p0 = YL;
		auto& _p1 = YPos;
		((AManageHUD*)Self)->_Supper__ShowDebugInfo(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_ShowHUD(AHUD* Self)
	{
		((AManageHUD*)Self)->_Supper__ShowHUD();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_BeginPlay(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_ClearCrossLevelReferences(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_Destroyed(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_ForceNetRelevant(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_ForceNetUpdate(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_GatherCurrentMovement(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManageHUD*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_K2_DestroyActor(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_LifeSpanExpired(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_OnRep_Instigator(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_OnRep_Owner(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManageHUD*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_OutsideWorldBounds(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostActorCreated(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostInitializeComponents(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostNetInit(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostNetReceivePhysicState(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostNetReceiveRole(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostRegisterAllComponents(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostUnregisterAllComponents(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PreInitializeComponents(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PreRegisterAllComponents(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManageHUD*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManageHUD*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_RegisterAllComponents(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_ReregisterAllComponents(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_RerunConstructionScripts(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_Reset(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_RewindForReplay(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManageHUD*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManageHUD*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManageHUD*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_TearOff(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManageHUD*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManageHUD*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_TornOff(AActor* Self)
	{
		((AManageHUD*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManageHUD*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_BeginDestroy(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_FinishDestroy(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostCDOContruct(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostEditImport(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostInitProperties(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostLoad(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostNetReceive(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostRepNotifies(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManageHUD*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PreDestroyFromReplication(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_PreNetReceive(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_ShutdownAfterError(UObject* Self)
	{
		((AManageHUD*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManageHUD*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__AHUD_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManageHUD*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
