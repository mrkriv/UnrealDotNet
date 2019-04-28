#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/InputSettings.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\InputSettings.h:20

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UInputSettings_bAltEnterTogglesFullscreen_GET(UInputSettings* Ptr) { return Ptr->bAltEnterTogglesFullscreen; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bAltEnterTogglesFullscreen_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bAltEnterTogglesFullscreen = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bAlwaysShowTouchInterface_GET(UInputSettings* Ptr) { return Ptr->bAlwaysShowTouchInterface; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bAlwaysShowTouchInterface_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bAlwaysShowTouchInterface = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bCaptureMouseOnLaunch_GET(UInputSettings* Ptr) { return Ptr->bCaptureMouseOnLaunch; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bCaptureMouseOnLaunch_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bCaptureMouseOnLaunch = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bDefaultViewportMouseLock_DEPRECATED_GET(UInputSettings* Ptr) { return Ptr->bDefaultViewportMouseLock_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bDefaultViewportMouseLock_DEPRECATED_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bDefaultViewportMouseLock_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bEnableFOVScaling_GET(UInputSettings* Ptr) { return Ptr->bEnableFOVScaling; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bEnableFOVScaling_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bEnableFOVScaling = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bEnableGestureRecognizer_GET(UInputSettings* Ptr) { return Ptr->bEnableGestureRecognizer; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bEnableGestureRecognizer_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bEnableGestureRecognizer = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bEnableMouseSmoothing_GET(UInputSettings* Ptr) { return Ptr->bEnableMouseSmoothing; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bEnableMouseSmoothing_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bEnableMouseSmoothing = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bF11TogglesFullscreen_GET(UInputSettings* Ptr) { return Ptr->bF11TogglesFullscreen; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bF11TogglesFullscreen_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bF11TogglesFullscreen = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bShowConsoleOnFourFingerTap_GET(UInputSettings* Ptr) { return Ptr->bShowConsoleOnFourFingerTap; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bShowConsoleOnFourFingerTap_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bShowConsoleOnFourFingerTap = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bUseAutocorrect_GET(UInputSettings* Ptr) { return Ptr->bUseAutocorrect; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bUseAutocorrect_SET(UInputSettings* Ptr, bool Value) { Ptr->bUseAutocorrect = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_bUseMouseForTouch_GET(UInputSettings* Ptr) { return Ptr->bUseMouseForTouch; }
	DOTNET_EXPORT void E_PROP_UInputSettings_bUseMouseForTouch_SET(UInputSettings* Ptr, uint8 Value) { Ptr->bUseMouseForTouch = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_DefaultViewportMouseCaptureMode_GET(UInputSettings* Ptr) { return Ptr->DefaultViewportMouseCaptureMode; }
	DOTNET_EXPORT void E_PROP_UInputSettings_DefaultViewportMouseCaptureMode_SET(UInputSettings* Ptr, EMouseCaptureMode Value) { Ptr->DefaultViewportMouseCaptureMode = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_DefaultViewportMouseLockMode_GET(UInputSettings* Ptr) { return Ptr->DefaultViewportMouseLockMode; }
	DOTNET_EXPORT void E_PROP_UInputSettings_DefaultViewportMouseLockMode_SET(UInputSettings* Ptr, EMouseLockMode Value) { Ptr->DefaultViewportMouseLockMode = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_DoubleClickTime_GET(UInputSettings* Ptr) { return Ptr->DoubleClickTime; }
	DOTNET_EXPORT void E_PROP_UInputSettings_DoubleClickTime_SET(UInputSettings* Ptr, float Value) { Ptr->DoubleClickTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputSettings_FOVScale_GET(UInputSettings* Ptr) { return Ptr->FOVScale; }
	DOTNET_EXPORT void E_PROP_UInputSettings_FOVScale_SET(UInputSettings* Ptr, float Value) { Ptr->FOVScale = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInputSettings(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInputSettings>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UInputSettings_AddActionMapping(UInputSettings* Self, INT_PTR KeyMapping, bool bForceRebuildKeymaps)
	{
		auto& _p0 = *(FInputActionKeyMapping*)KeyMapping;
		auto _p1 = bForceRebuildKeymaps;
		Self->AddActionMapping(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInputSettings_AddAxisMapping(UInputSettings* Self, INT_PTR KeyMapping, bool bForceRebuildKeymaps)
	{
		auto& _p0 = *(FInputAxisKeyMapping*)KeyMapping;
		auto _p1 = bForceRebuildKeymaps;
		Self->AddAxisMapping(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInputSettings_ForceRebuildKeymaps(UInputSettings* Self)
	{
		Self->ForceRebuildKeymaps();
	}

	DOTNET_EXPORT auto E_UInputSettings_GetInputSettings(UInputSettings* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetInputSettings());
	}

	DOTNET_EXPORT auto E_UInputSettings_RemoveActionMapping(UInputSettings* Self, INT_PTR KeyMapping, bool bForceRebuildKeymaps)
	{
		auto& _p0 = *(FInputActionKeyMapping*)KeyMapping;
		auto _p1 = bForceRebuildKeymaps;
		Self->RemoveActionMapping(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInputSettings_RemoveAxisMapping(UInputSettings* Self, INT_PTR KeyMapping, bool bForceRebuildKeymaps)
	{
		auto& _p0 = *(FInputAxisKeyMapping*)KeyMapping;
		auto _p1 = bForceRebuildKeymaps;
		Self->RemoveAxisMapping(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInputSettings_SaveKeyMappings(UInputSettings* Self)
	{
		Self->SaveKeyMappings();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
