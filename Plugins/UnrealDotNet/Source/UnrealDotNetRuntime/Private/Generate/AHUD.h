#pragma once

#include "CoreMinimal.h"
#include "GameFramework/HUD.h"

extern "C"
{
	DOTNET_EXPORT void E_AHUD_ShowHUD(INT_PTR Self)
	{
		((AHUD*)Self)->ShowHUD();
	}

	DOTNET_EXPORT void E_AHUD_RemoveDebugText(INT_PTR Self, AActor* SrcActor, bool bLeaveDurationText)
	{
		auto _p0 = SrcActor;
		auto _p1 = bLeaveDurationText;
		((AHUD*)Self)->RemoveDebugText(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_ReceiveDrawHUD(INT_PTR Self, int32 SizeX, int32 SizeY)
	{
		auto _p0 = SizeX;
		auto _p1 = SizeY;
		((AHUD*)Self)->ReceiveDrawHUD(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_AHUD_Project(INT_PTR Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(((AHUD*)Self)->Project(_p0));
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

	DOTNET_EXPORT void E_AHUD_RemovePostRenderedActor(INT_PTR Self, AActor* A)
	{
		auto _p0 = A;
		((AHUD*)Self)->RemovePostRenderedActor(_p0);
	}

	DOTNET_EXPORT void E_AHUD_ShowDebugInfo(INT_PTR Self, float YL, float YPos)
	{
		auto _p0 = YL;
		auto _p1 = YPos;
		((AHUD*)Self)->ShowDebugInfo(_p0, _p1);
	}

	DOTNET_EXPORT void E_AHUD_OnLostFocusPause(INT_PTR Self, bool bEnable)
	{
		auto _p0 = bEnable;
		((AHUD*)Self)->OnLostFocusPause(_p0);
	}

	DOTNET_EXPORT bool E_AHUD_AnyCurrentHitBoxHits(INT_PTR Self)
	{
		return ((AHUD*)Self)->AnyCurrentHitBoxHits();
	}

}
