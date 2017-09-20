#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "GameFramework/HUD.h"

class E_PROTECTED_WRAP_AHUD : protected AHUD
{
public:
	APawn* GetOwningPawn_WRAP()
	{
		return GetOwningPawn();
	}

	bool IsCanvasValid_WarnIfNot_WRAP()
	{
		return IsCanvasValid_WarnIfNot();
	}

}
;

extern "C"
{
	DOTNET_EXPORT float E_PROP_AHUD_LastHUDRenderTime_GET(INT_PTR Ptr) { return ((AHUD*)Ptr)->LastHUDRenderTime; }
	DOTNET_EXPORT void E_PROP_AHUD_LastHUDRenderTime_SET(INT_PTR Ptr, float Value) { ((AHUD*)Ptr)->LastHUDRenderTime = Value; }
	
	DOTNET_EXPORT float E_PROP_AHUD_RenderDelta_GET(INT_PTR Ptr) { return ((AHUD*)Ptr)->RenderDelta; }
	DOTNET_EXPORT void E_PROP_AHUD_RenderDelta_SET(INT_PTR Ptr, float Value) { ((AHUD*)Ptr)->RenderDelta = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AHUD(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AHUD>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_AHUD_AddHitBox(AHUD* Self, INT_PTR Position, INT_PTR Size, char* InName, bool bConsumesInput, int32 Priority)
	{
		auto _p0 = *(FVector2D*)Position;
		auto _p1 = *(FVector2D*)Size;
		auto _p2 = FName(UTF8_TO_TCHAR(InName));
		auto _p3 = bConsumesInput;
		auto _p4 = Priority;
		(Self)->AddHitBox(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT void E_AHUD_AddPostRenderedActor(AHUD* Self, AActor* A)
	{
		auto _p0 = A;
		(Self)->AddPostRenderedActor(_p0);
	}

	DOTNET_EXPORT bool E_AHUD_AnyCurrentHitBoxHits(AHUD* Self)
	{
		return (Self)->AnyCurrentHitBoxHits();
	}

	DOTNET_EXPORT void E_AHUD_Deproject(AHUD* Self, float ScreenX, float ScreenY, INT_PTR WorldPosition, INT_PTR WorldDirection)
	{
		auto _p0 = ScreenX;
		auto _p1 = ScreenY;
		auto _p2 = *(FVector*)WorldPosition;
		auto _p3 = *(FVector*)WorldDirection;
		(Self)->Deproject(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_AHUD_DrawActorOverlays(AHUD* Self, INT_PTR Viewpoint, INT_PTR ViewRotation)
	{
		auto _p0 = *(FVector*)Viewpoint;
		auto _p1 = *(FRotator*)ViewRotation;
		(Self)->DrawActorOverlays(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_DrawDebugTextList(AHUD* Self)
	{
		(Self)->DrawDebugTextList();
	}

	DOTNET_EXPORT void E_AHUD_DrawHUD(AHUD* Self)
	{
		(Self)->DrawHUD();
	}

	DOTNET_EXPORT void E_AHUD_DrawSafeZoneOverlay(AHUD* Self)
	{
		(Self)->DrawSafeZoneOverlay();
	}

	DOTNET_EXPORT ObjectPointerDescription E_AHUD_GetOwningPawn(AHUD* Self)
	{
		return MakePrtDesc(((E_PROTECTED_WRAP_AHUD*)Self)->GetOwningPawn_WRAP());
	}

	DOTNET_EXPORT void E_AHUD_HandleBugScreenShot(AHUD* Self)
	{
		(Self)->HandleBugScreenShot();
	}

	DOTNET_EXPORT bool E_AHUD_IsCanvasValid_WarnIfNot(AHUD* Self)
	{
		return ((E_PROTECTED_WRAP_AHUD*)Self)->IsCanvasValid_WarnIfNot_WRAP();
	}

	DOTNET_EXPORT void E_AHUD_NotifyBindPostProcessEffects(AHUD* Self)
	{
		(Self)->NotifyBindPostProcessEffects();
	}

	DOTNET_EXPORT void E_AHUD_NotifyHitBoxBeginCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		(Self)->NotifyHitBoxBeginCursorOver(_p0);
	}

	DOTNET_EXPORT void E_AHUD_NotifyHitBoxClick(AHUD* Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		(Self)->NotifyHitBoxClick(_p0);
	}

	DOTNET_EXPORT void E_AHUD_NotifyHitBoxEndCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		(Self)->NotifyHitBoxEndCursorOver(_p0);
	}

	DOTNET_EXPORT void E_AHUD_NotifyHitBoxRelease(AHUD* Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		(Self)->NotifyHitBoxRelease(_p0);
	}

	DOTNET_EXPORT void E_AHUD_OnLostFocusPause(AHUD* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		(Self)->OnLostFocusPause(_p0);
	}

	DOTNET_EXPORT void E_AHUD_PostRender(AHUD* Self)
	{
		(Self)->PostRender();
	}

	DOTNET_EXPORT INT_PTR E_AHUD_Project(AHUD* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector((Self)->Project(_p0));
	}

	DOTNET_EXPORT void E_AHUD_ReceiveDrawHUD(AHUD* Self, int32 SizeX, int32 SizeY)
	{
		auto _p0 = SizeX;
		auto _p1 = SizeY;
		(Self)->ReceiveDrawHUD(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_ReceiveHitBoxBeginCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		(Self)->ReceiveHitBoxBeginCursorOver(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ReceiveHitBoxClick(AHUD* Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		(Self)->ReceiveHitBoxClick(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ReceiveHitBoxEndCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		(Self)->ReceiveHitBoxEndCursorOver(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ReceiveHitBoxRelease(AHUD* Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		(Self)->ReceiveHitBoxRelease(_p0);
	}

	DOTNET_EXPORT void E_AHUD_RemoveAllDebugStrings(AHUD* Self)
	{
		(Self)->RemoveAllDebugStrings();
	}

	DOTNET_EXPORT void E_AHUD_RemoveDebugText(AHUD* Self, AActor* SrcActor, bool bLeaveDurationText)
	{
		auto _p0 = SrcActor;
		auto _p1 = bLeaveDurationText;
		(Self)->RemoveDebugText(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_RemovePostRenderedActor(AHUD* Self, AActor* A)
	{
		auto _p0 = A;
		(Self)->RemovePostRenderedActor(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ShowDebug(AHUD* Self, char* DebugType)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(DebugType));
		(Self)->ShowDebug(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ShowDebugInfo(AHUD* Self, float YL, float YPos)
	{
		auto _p0 = YL;
		auto _p1 = YPos;
		(Self)->ShowDebugInfo(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_ShowDebugToggleSubCategory(AHUD* Self, char* Category)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(Category));
		(Self)->ShowDebugToggleSubCategory(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ShowHUD(AHUD* Self)
	{
		(Self)->ShowHUD();
	}

	DOTNET_EXPORT bool E_AHUD_UpdateAndDispatchHitBoxClickEvents(AHUD* Self, INT_PTR ClickLocation, EInputEvent InEventType)
	{
		auto _p0 = *(FVector2D*)ClickLocation;
		auto _p1 = InEventType;
		return (Self)->UpdateAndDispatchHitBoxClickEvents(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
