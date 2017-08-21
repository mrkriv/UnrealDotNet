#include "GameFramework/HUD.h"

extern "C"
{
	DOTNET_EXPORT void E_ShowHUD(INT_PTR Self)
	{
		((AHUD*)Self)->ShowHUD();
		
	}

	DOTNET_EXPORT void E_ShowDebug(INT_PTR Self, char* DebugType)
	{
		((AHUD*)Self)->ShowDebug(DebugType);
		
	}

	DOTNET_EXPORT void E_ShowDebugToggleSubCategory(INT_PTR Self, char* Category)
	{
		((AHUD*)Self)->ShowDebugToggleSubCategory(Category);
		
	}

	DOTNET_EXPORT void E_RemoveAllDebugStrings(INT_PTR Self)
	{
		((AHUD*)Self)->RemoveAllDebugStrings();
		
	}

	DOTNET_EXPORT void E_RemoveDebugText(INT_PTR Self, AActor* SrcActor, bool bLeaveDurationText)
	{
		((AHUD*)Self)->RemoveDebugText(SrcActor, bLeaveDurationText);
		
	}

	DOTNET_EXPORT void E_ReceiveDrawHUD(INT_PTR Self, int32 SizeX, int32 SizeY)
	{
		((AHUD*)Self)->ReceiveDrawHUD(SizeX, SizeY);
		
	}

	DOTNET_EXPORT void E_ReceiveHitBoxClick(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->ReceiveHitBoxClick(BoxName);
		
	}

	DOTNET_EXPORT void E_NotifyHitBoxClick(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->NotifyHitBoxClick(BoxName);
		
	}

	DOTNET_EXPORT void E_ReceiveHitBoxRelease(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->ReceiveHitBoxRelease(BoxName);
		
	}

	DOTNET_EXPORT void E_NotifyHitBoxRelease(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->NotifyHitBoxRelease(BoxName);
		
	}

	DOTNET_EXPORT void E_ReceiveHitBoxBeginCursorOver(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->ReceiveHitBoxBeginCursorOver(BoxName);
		
	}

	DOTNET_EXPORT void E_NotifyHitBoxBeginCursorOver(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->NotifyHitBoxBeginCursorOver(BoxName);
		
	}

	DOTNET_EXPORT void E_ReceiveHitBoxEndCursorOver(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->ReceiveHitBoxEndCursorOver(BoxName);
		
	}

	DOTNET_EXPORT void E_NotifyHitBoxEndCursorOver(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->NotifyHitBoxEndCursorOver(BoxName);
		
	}

	DOTNET_EXPORT void E_PostInitializeComponents(INT_PTR Self)
	{
		((AHUD*)Self)->PostInitializeComponents();
		
	}

	DOTNET_EXPORT void E_DrawSafeZoneOverlay(INT_PTR Self)
	{
		((AHUD*)Self)->DrawSafeZoneOverlay();
		
	}

	DOTNET_EXPORT void E_NotifyBindPostProcessEffects(INT_PTR Self)
	{
		((AHUD*)Self)->NotifyBindPostProcessEffects();
		
	}

	DOTNET_EXPORT void E_RemovePostRenderedActor(INT_PTR Self, AActor* A)
	{
		((AHUD*)Self)->RemovePostRenderedActor(A);
		
	}

	DOTNET_EXPORT void E_AddPostRenderedActor(INT_PTR Self, AActor* A)
	{
		((AHUD*)Self)->AddPostRenderedActor(A);
		
	}

	DOTNET_EXPORT bool E_ShouldDisplayDebug(INT_PTR Self, char* DebugType)
	{
		return ((AHUD*)Self)->ShouldDisplayDebug(DebugType);
		
	}

	DOTNET_EXPORT void E_ShowDebugInfo(INT_PTR Self, float YL, float YPos)
	{
		((AHUD*)Self)->ShowDebugInfo(YL, YPos);
		
	}

	DOTNET_EXPORT void E_PostRender(INT_PTR Self)
	{
		((AHUD*)Self)->PostRender();
		
	}

	DOTNET_EXPORT void E_DrawHUD(INT_PTR Self)
	{
		((AHUD*)Self)->DrawHUD();
		
	}

	DOTNET_EXPORT void E_OnLostFocusPause(INT_PTR Self, bool bEnable)
	{
		((AHUD*)Self)->OnLostFocusPause(bEnable);
		
	}

	DOTNET_EXPORT void E_DrawDebugTextList(INT_PTR Self)
	{
		((AHUD*)Self)->DrawDebugTextList();
		
	}

	DOTNET_EXPORT void E_HandleBugScreenShot(INT_PTR Self)
	{
		((AHUD*)Self)->HandleBugScreenShot();
		
	}

	DOTNET_EXPORT bool E_AnyCurrentHitBoxHits(INT_PTR Self)
	{
		return ((AHUD*)Self)->AnyCurrentHitBoxHits();
		
	}

	
}
