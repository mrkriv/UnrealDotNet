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
	
	DOTNET_EXPORT void E_AHUD_AddHitBox(INT_PTR Self, INT_PTR Position, INT_PTR Size, char* InName, bool bConsumesInput, int32 Priority)
	{
		auto _p0 = *(FVector2D*)Position;
		auto _p1 = *(FVector2D*)Size;
		auto _p2 = FName(UTF8_TO_TCHAR(InName));
		auto _p3 = bConsumesInput;
		auto _p4 = Priority;
		((AHUD*)Self)->AddHitBox(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT void E_AHUD_AddPostRenderedActor(INT_PTR Self, AActor* A)
	{
		auto _p0 = A;
		((AHUD*)Self)->AddPostRenderedActor(_p0);
	}

	DOTNET_EXPORT bool E_AHUD_AnyCurrentHitBoxHits(INT_PTR Self)
	{
		return ((AHUD*)Self)->AnyCurrentHitBoxHits();
	}

	DOTNET_EXPORT void E_AHUD_Deproject(INT_PTR Self, float ScreenX, float ScreenY, INT_PTR WorldPosition, INT_PTR WorldDirection)
	{
		auto _p0 = ScreenX;
		auto _p1 = ScreenY;
		auto _p2 = *(FVector*)WorldPosition;
		auto _p3 = *(FVector*)WorldDirection;
		((AHUD*)Self)->Deproject(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_AHUD_DrawActorOverlays(INT_PTR Self, INT_PTR Viewpoint, INT_PTR ViewRotation)
	{
		auto _p0 = *(FVector*)Viewpoint;
		auto _p1 = *(FRotator*)ViewRotation;
		((AHUD*)Self)->DrawActorOverlays(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_DrawDebugTextList(INT_PTR Self)
	{
		((AHUD*)Self)->DrawDebugTextList();
	}

	DOTNET_EXPORT void E_AHUD_DrawHUD(INT_PTR Self)
	{
		((AHUD*)Self)->DrawHUD();
	}

	DOTNET_EXPORT void E_AHUD_DrawSafeZoneOverlay(INT_PTR Self)
	{
		((AHUD*)Self)->DrawSafeZoneOverlay();
	}

	DOTNET_EXPORT APawn* E_AHUD_GetOwningPawn(INT_PTR Self)
	{
		return ((E_PROTECTED_WRAP_AHUD*)Self)->GetOwningPawn_WRAP();
	}

	DOTNET_EXPORT void E_AHUD_HandleBugScreenShot(INT_PTR Self)
	{
		((AHUD*)Self)->HandleBugScreenShot();
	}

	DOTNET_EXPORT bool E_AHUD_IsCanvasValid_WarnIfNot(INT_PTR Self)
	{
		return ((E_PROTECTED_WRAP_AHUD*)Self)->IsCanvasValid_WarnIfNot_WRAP();
	}

	DOTNET_EXPORT void E_AHUD_NotifyBindPostProcessEffects(INT_PTR Self)
	{
		((AHUD*)Self)->NotifyBindPostProcessEffects();
	}

	DOTNET_EXPORT void E_AHUD_NotifyHitBoxBeginCursorOver(INT_PTR Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		((AHUD*)Self)->NotifyHitBoxBeginCursorOver(_p0);
	}

	DOTNET_EXPORT void E_AHUD_NotifyHitBoxClick(INT_PTR Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		((AHUD*)Self)->NotifyHitBoxClick(_p0);
	}

	DOTNET_EXPORT void E_AHUD_NotifyHitBoxEndCursorOver(INT_PTR Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		((AHUD*)Self)->NotifyHitBoxEndCursorOver(_p0);
	}

	DOTNET_EXPORT void E_AHUD_NotifyHitBoxRelease(INT_PTR Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		((AHUD*)Self)->NotifyHitBoxRelease(_p0);
	}

	DOTNET_EXPORT void E_AHUD_OnLostFocusPause(INT_PTR Self, bool bEnable)
	{
		auto _p0 = bEnable;
		((AHUD*)Self)->OnLostFocusPause(_p0);
	}

	DOTNET_EXPORT void E_AHUD_PostRender(INT_PTR Self)
	{
		((AHUD*)Self)->PostRender();
	}

	DOTNET_EXPORT INT_PTR E_AHUD_Project(INT_PTR Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(((AHUD*)Self)->Project(_p0));
	}

	DOTNET_EXPORT void E_AHUD_ReceiveDrawHUD(INT_PTR Self, int32 SizeX, int32 SizeY)
	{
		auto _p0 = SizeX;
		auto _p1 = SizeY;
		((AHUD*)Self)->ReceiveDrawHUD(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_ReceiveHitBoxBeginCursorOver(INT_PTR Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		((AHUD*)Self)->ReceiveHitBoxBeginCursorOver(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ReceiveHitBoxClick(INT_PTR Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		((AHUD*)Self)->ReceiveHitBoxClick(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ReceiveHitBoxEndCursorOver(INT_PTR Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		((AHUD*)Self)->ReceiveHitBoxEndCursorOver(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ReceiveHitBoxRelease(INT_PTR Self, char* BoxName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoxName));
		((AHUD*)Self)->ReceiveHitBoxRelease(_p0);
	}

	DOTNET_EXPORT void E_AHUD_RemoveAllDebugStrings(INT_PTR Self)
	{
		((AHUD*)Self)->RemoveAllDebugStrings();
	}

	DOTNET_EXPORT void E_AHUD_RemoveDebugText(INT_PTR Self, AActor* SrcActor, bool bLeaveDurationText)
	{
		auto _p0 = SrcActor;
		auto _p1 = bLeaveDurationText;
		((AHUD*)Self)->RemoveDebugText(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_RemovePostRenderedActor(INT_PTR Self, AActor* A)
	{
		auto _p0 = A;
		((AHUD*)Self)->RemovePostRenderedActor(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ShowDebug(INT_PTR Self, char* DebugType)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(DebugType));
		((AHUD*)Self)->ShowDebug(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ShowDebugInfo(INT_PTR Self, float YL, float YPos)
	{
		auto _p0 = YL;
		auto _p1 = YPos;
		((AHUD*)Self)->ShowDebugInfo(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_ShowDebugToggleSubCategory(INT_PTR Self, char* Category)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(Category));
		((AHUD*)Self)->ShowDebugToggleSubCategory(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ShowHUD(INT_PTR Self)
	{
		((AHUD*)Self)->ShowHUD();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS