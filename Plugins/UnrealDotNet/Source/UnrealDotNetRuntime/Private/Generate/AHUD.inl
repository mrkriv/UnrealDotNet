#include "GameFramework/HUD.h"

extern "C"
{
	UNREALDOTNETRUNTIME_API void E_ShowHUD(INT_PTR Self)
	{
		((AHUD*)Self)->ShowHUD();
		
	}

	UNREALDOTNETRUNTIME_API void E_ShowDebug(INT_PTR Self, char* DebugType)
	{
		((AHUD*)Self)->ShowDebug(DebugType);
		
	}

	UNREALDOTNETRUNTIME_API void E_ShowDebugToggleSubCategory(INT_PTR Self, char* Category)
	{
		((AHUD*)Self)->ShowDebugToggleSubCategory(Category);
		
	}

	UNREALDOTNETRUNTIME_API void E_RemoveAllDebugStrings(INT_PTR Self)
	{
		((AHUD*)Self)->RemoveAllDebugStrings();
		
	}

	UNREALDOTNETRUNTIME_API void E_RemoveDebugText(INT_PTR Self, AActor* SrcActor, bool bLeaveDurationText)
	{
		((AHUD*)Self)->RemoveDebugText(SrcActor, bLeaveDurationText);
		
	}

	UNREALDOTNETRUNTIME_API void E_ReceiveDrawHUD(INT_PTR Self, int32 SizeX, int32 SizeY)
	{
		((AHUD*)Self)->ReceiveDrawHUD(SizeX, SizeY);
		
	}

	UNREALDOTNETRUNTIME_API void E_ReceiveHitBoxClick(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->ReceiveHitBoxClick(BoxName);
		
	}

	UNREALDOTNETRUNTIME_API void E_NotifyHitBoxClick(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->NotifyHitBoxClick(BoxName);
		
	}

	UNREALDOTNETRUNTIME_API void E_ReceiveHitBoxRelease(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->ReceiveHitBoxRelease(BoxName);
		
	}

	UNREALDOTNETRUNTIME_API void E_NotifyHitBoxRelease(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->NotifyHitBoxRelease(BoxName);
		
	}

	UNREALDOTNETRUNTIME_API void E_ReceiveHitBoxBeginCursorOver(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->ReceiveHitBoxBeginCursorOver(BoxName);
		
	}

	UNREALDOTNETRUNTIME_API void E_NotifyHitBoxBeginCursorOver(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->NotifyHitBoxBeginCursorOver(BoxName);
		
	}

	UNREALDOTNETRUNTIME_API void E_ReceiveHitBoxEndCursorOver(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->ReceiveHitBoxEndCursorOver(BoxName);
		
	}

	UNREALDOTNETRUNTIME_API void E_NotifyHitBoxEndCursorOver(INT_PTR Self, char* BoxName)
	{
		((AHUD*)Self)->NotifyHitBoxEndCursorOver(BoxName);
		
	}

	UNREALDOTNETRUNTIME_API void E_PostInitializeComponents(INT_PTR Self)
	{
		((AHUD*)Self)->PostInitializeComponents();
		
	}

	UNREALDOTNETRUNTIME_API void E_DrawSafeZoneOverlay(INT_PTR Self)
	{
		((AHUD*)Self)->DrawSafeZoneOverlay();
		
	}

	UNREALDOTNETRUNTIME_API void E_NotifyBindPostProcessEffects(INT_PTR Self)
	{
		((AHUD*)Self)->NotifyBindPostProcessEffects();
		
	}

	UNREALDOTNETRUNTIME_API void E_RemovePostRenderedActor(INT_PTR Self, AActor* A)
	{
		((AHUD*)Self)->RemovePostRenderedActor(A);
		
	}

	UNREALDOTNETRUNTIME_API void E_AddPostRenderedActor(INT_PTR Self, AActor* A)
	{
		((AHUD*)Self)->AddPostRenderedActor(A);
		
	}

	UNREALDOTNETRUNTIME_API bool E_ShouldDisplayDebug(INT_PTR Self, char* DebugType)
	{
		return ((AHUD*)Self)->ShouldDisplayDebug(DebugType);
		
	}

	UNREALDOTNETRUNTIME_API void E_ShowDebugInfo(INT_PTR Self, float YL, float YPos)
	{
		((AHUD*)Self)->ShowDebugInfo(YL, YPos);
		
	}

	UNREALDOTNETRUNTIME_API void E_PostRender(INT_PTR Self)
	{
		((AHUD*)Self)->PostRender();
		
	}

	UNREALDOTNETRUNTIME_API void E_DrawHUD(INT_PTR Self)
	{
		((AHUD*)Self)->DrawHUD();
		
	}

	UNREALDOTNETRUNTIME_API void E_OnLostFocusPause(INT_PTR Self, bool bEnable)
	{
		((AHUD*)Self)->OnLostFocusPause(bEnable);
		
	}

	UNREALDOTNETRUNTIME_API void E_DrawDebugTextList(INT_PTR Self)
	{
		((AHUD*)Self)->DrawDebugTextList();
		
	}

	UNREALDOTNETRUNTIME_API void E_HandleBugScreenShot(INT_PTR Self)
	{
		((AHUD*)Self)->HandleBugScreenShot();
		
	}

	UNREALDOTNETRUNTIME_API bool E_AnyCurrentHitBoxHits(INT_PTR Self)
	{
		return ((AHUD*)Self)->AnyCurrentHitBoxHits();
		
	}

	
}
