#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/GameUserSettings.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameUserSettings.h:38

class E_PROTECTED_WRAP_UGameUserSettings : protected UGameUserSettings
{
public:
	float FindResolutionQualityForScreenSize_WRAP(float Width, float Height)
	{
		return FindResolutionQualityForScreenSize(Width, Height);
	}

	float GetEffectiveFrameRateLimit_WRAP()
	{
		return GetEffectiveFrameRateLimit();
	}

	bool IsVersionValid_WRAP()
	{
		return IsVersionValid();
	}

	void SetFrameRateLimitCVar_WRAP(float InLimit)
	{
		SetFrameRateLimitCVar(InLimit);
	}

	void SetSyncIntervalCVar_WRAP(int32 InInterval)
	{
		SetSyncIntervalCVar(InInterval);
	}

	void SetSyncTypeCVar_WRAP(int32 InInterval)
	{
		SetSyncTypeCVar(InInterval);
	}

	void UpdateResolutionQuality_WRAP()
	{
		UpdateResolutionQuality();
	}

	void UpdateVersion_WRAP()
	{
		UpdateVersion();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UGameUserSettings_bUseDynamicResolution_GET(UGameUserSettings* Ptr) { return Ptr->bUseDynamicResolution; }
	DOTNET_EXPORT void E_PROP_UGameUserSettings_bUseDynamicResolution_SET(UGameUserSettings* Ptr, bool Value) { Ptr->bUseDynamicResolution = Value; }
	
	DOTNET_EXPORT auto E_PROP_UGameUserSettings_bUseVSync_GET(UGameUserSettings* Ptr) { return Ptr->bUseVSync; }
	DOTNET_EXPORT void E_PROP_UGameUserSettings_bUseVSync_SET(UGameUserSettings* Ptr, bool Value) { Ptr->bUseVSync = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UGameUserSettings(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UGameUserSettings>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UGameUserSettings_ApplyHardwareBenchmarkResults(UGameUserSettings* Self)
	{
		Self->UGameUserSettings::ApplyHardwareBenchmarkResults();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_ApplyNonResolutionSettings(UGameUserSettings* Self)
	{
		Self->UGameUserSettings::ApplyNonResolutionSettings();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_ApplyResolutionSettings(UGameUserSettings* Self, bool bCheckForCommandLineOverrides)
	{
		auto _p0 = bCheckForCommandLineOverrides;
		Self->ApplyResolutionSettings(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_ApplySettings(UGameUserSettings* Self, bool bCheckForCommandLineOverrides)
	{
		auto _p0 = bCheckForCommandLineOverrides;
		Self->UGameUserSettings::ApplySettings(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_ConfirmVideoMode(UGameUserSettings* Self)
	{
		Self->UGameUserSettings::ConfirmVideoMode();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_EnableHDRDisplayOutput(UGameUserSettings* Self, bool bEnable, int32 DisplayNits)
	{
		auto _p0 = bEnable;
		auto _p1 = DisplayNits;
		Self->EnableHDRDisplayOutput(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_FindResolutionQualityForScreenSize(UGameUserSettings* Self, float Width, float Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return ((E_PROTECTED_WRAP_UGameUserSettings*)Self)->FindResolutionQualityForScreenSize_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetAntiAliasingQuality(UGameUserSettings* Self)
	{
		return Self->GetAntiAliasingQuality();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetAudioQualityLevel(UGameUserSettings* Self)
	{
		return Self->GetAudioQualityLevel();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetCurrentHDRDisplayNits(UGameUserSettings* Self)
	{
		return Self->GetCurrentHDRDisplayNits();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetDefaultResolution(UGameUserSettings* Self)
	{
		return (INT_PTR) new FIntPoint(Self->GetDefaultResolution());
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetDefaultResolutionScale(UGameUserSettings* Self)
	{
		return Self->GetDefaultResolutionScale();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetDefaultWindowPosition(UGameUserSettings* Self)
	{
		return (INT_PTR) new FIntPoint(Self->GetDefaultWindowPosition());
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetDesktopResolution(UGameUserSettings* Self)
	{
		return (INT_PTR) new FIntPoint(Self->GetDesktopResolution());
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetEffectiveFrameRateLimit(UGameUserSettings* Self)
	{
		return ((E_PROTECTED_WRAP_UGameUserSettings*)Self)->GetEffectiveFrameRateLimit_WRAP();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetFoliageQuality(UGameUserSettings* Self)
	{
		return Self->GetFoliageQuality();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetFrameRateLimit(UGameUserSettings* Self)
	{
		return Self->GetFrameRateLimit();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetGameUserSettings(UGameUserSettings* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetGameUserSettings());
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetLastConfirmedScreenResolution(UGameUserSettings* Self)
	{
		return (INT_PTR) new FIntPoint(Self->GetLastConfirmedScreenResolution());
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetLastCPUBenchmarkResult(UGameUserSettings* Self)
	{
		return Self->GetLastCPUBenchmarkResult();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetLastGPUBenchmarkResult(UGameUserSettings* Self)
	{
		return Self->GetLastGPUBenchmarkResult();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetOverallScalabilityLevel(UGameUserSettings* Self)
	{
		return Self->GetOverallScalabilityLevel();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetPostProcessingQuality(UGameUserSettings* Self)
	{
		return Self->GetPostProcessingQuality();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetRecommendedResolutionScale(UGameUserSettings* Self)
	{
		return Self->GetRecommendedResolutionScale();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetResolutionScaleInformation(UGameUserSettings* Self, float CurrentScaleNormalized, int32 CurrentScaleValue, int32 MinScaleValue, int32 MaxScaleValue)
	{
		auto& _p0 = CurrentScaleNormalized;
		auto& _p1 = CurrentScaleValue;
		auto& _p2 = MinScaleValue;
		auto& _p3 = MaxScaleValue;
		Self->GetResolutionScaleInformation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetResolutionScaleInformationEx(UGameUserSettings* Self, float CurrentScaleNormalized, float CurrentScaleValue, float MinScaleValue, float MaxScaleValue)
	{
		auto& _p0 = CurrentScaleNormalized;
		auto& _p1 = CurrentScaleValue;
		auto& _p2 = MinScaleValue;
		auto& _p3 = MaxScaleValue;
		Self->GetResolutionScaleInformationEx(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetScreenResolution(UGameUserSettings* Self)
	{
		return (INT_PTR) new FIntPoint(Self->GetScreenResolution());
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetShadowQuality(UGameUserSettings* Self)
	{
		return Self->GetShadowQuality();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetSyncInterval(UGameUserSettings* Self)
	{
		return Self->GetSyncInterval();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetTextureQuality(UGameUserSettings* Self)
	{
		return Self->GetTextureQuality();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetViewDistanceQuality(UGameUserSettings* Self)
	{
		return Self->GetViewDistanceQuality();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetVisualEffectQuality(UGameUserSettings* Self)
	{
		return Self->GetVisualEffectQuality();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_GetWindowPosition(UGameUserSettings* Self)
	{
		return (INT_PTR) new FIntPoint(Self->GetWindowPosition());
	}

	DOTNET_EXPORT auto E_UGameUserSettings_IsDirty(UGameUserSettings* Self)
	{
		return Self->IsDirty();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_IsDynamicResolutionDirty(UGameUserSettings* Self)
	{
		return Self->IsDynamicResolutionDirty();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_IsDynamicResolutionEnabled(UGameUserSettings* Self)
	{
		return Self->IsDynamicResolutionEnabled();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_IsFullscreenModeDirty(UGameUserSettings* Self)
	{
		return Self->IsFullscreenModeDirty();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_IsHDREnabled(UGameUserSettings* Self)
	{
		return Self->IsHDREnabled();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_IsScreenResolutionDirty(UGameUserSettings* Self)
	{
		return Self->IsScreenResolutionDirty();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_IsVersionValid(UGameUserSettings* Self)
	{
		return ((E_PROTECTED_WRAP_UGameUserSettings*)Self)->IsVersionValid_WRAP();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_IsVSyncDirty(UGameUserSettings* Self)
	{
		return Self->IsVSyncDirty();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_IsVSyncEnabled(UGameUserSettings* Self)
	{
		return Self->IsVSyncEnabled();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_LoadConfigIni(UGameUserSettings* Self, bool bForceReload)
	{
		auto _p0 = bForceReload;
		Self->LoadConfigIni(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_LoadSettings(UGameUserSettings* Self, bool bForceReload)
	{
		auto _p0 = bForceReload;
		Self->UGameUserSettings::LoadSettings(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_PreloadResolutionSettings(UGameUserSettings* Self)
	{
		Self->PreloadResolutionSettings();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_RequestUIUpdate(UGameUserSettings* Self)
	{
		Self->RequestUIUpdate();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_ResetToCurrentSettings(UGameUserSettings* Self)
	{
		Self->UGameUserSettings::ResetToCurrentSettings();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_RevertVideoMode(UGameUserSettings* Self)
	{
		Self->RevertVideoMode();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_RunHardwareBenchmark(UGameUserSettings* Self, int32 WorkScale, float CPUMultiplier, float GPUMultiplier)
	{
		auto _p0 = WorkScale;
		auto _p1 = CPUMultiplier;
		auto _p2 = GPUMultiplier;
		Self->UGameUserSettings::RunHardwareBenchmark(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SaveSettings(UGameUserSettings* Self)
	{
		Self->UGameUserSettings::SaveSettings();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetAntiAliasingQuality(UGameUserSettings* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetAntiAliasingQuality(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetAudioQualityLevel(UGameUserSettings* Self, int32 QualityLevel)
	{
		auto _p0 = QualityLevel;
		Self->SetAudioQualityLevel(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetBenchmarkFallbackValues(UGameUserSettings* Self)
	{
		Self->SetBenchmarkFallbackValues();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetDynamicResolutionEnabled(UGameUserSettings* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->SetDynamicResolutionEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetFoliageQuality(UGameUserSettings* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetFoliageQuality(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetFrameRateLimit(UGameUserSettings* Self, float NewLimit)
	{
		auto _p0 = NewLimit;
		Self->SetFrameRateLimit(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetFrameRateLimitCVar(UGameUserSettings* Self, float InLimit)
	{
		auto _p0 = InLimit;
		((E_PROTECTED_WRAP_UGameUserSettings*)Self)->SetFrameRateLimitCVar_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetOverallScalabilityLevel(UGameUserSettings* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->UGameUserSettings::SetOverallScalabilityLevel(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetPostProcessingQuality(UGameUserSettings* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetPostProcessingQuality(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetResolutionScaleNormalized(UGameUserSettings* Self, float NewScaleNormalized)
	{
		auto _p0 = NewScaleNormalized;
		Self->SetResolutionScaleNormalized(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetResolutionScaleValue(UGameUserSettings* Self, int32 NewScaleValue)
	{
		auto _p0 = NewScaleValue;
		Self->SetResolutionScaleValue(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetResolutionScaleValueEx(UGameUserSettings* Self, float NewScaleValue)
	{
		auto _p0 = NewScaleValue;
		Self->SetResolutionScaleValueEx(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetScreenResolution(UGameUserSettings* Self, INT_PTR Resolution)
	{
		auto _p0 = *(FIntPoint*)Resolution;
		Self->SetScreenResolution(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetShadowQuality(UGameUserSettings* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetShadowQuality(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetSyncIntervalCVar(UGameUserSettings* Self, int32 InInterval)
	{
		auto _p0 = InInterval;
		((E_PROTECTED_WRAP_UGameUserSettings*)Self)->SetSyncIntervalCVar_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetSyncTypeCVar(UGameUserSettings* Self, int32 InInterval)
	{
		auto _p0 = InInterval;
		((E_PROTECTED_WRAP_UGameUserSettings*)Self)->SetSyncTypeCVar_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetTextureQuality(UGameUserSettings* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetTextureQuality(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetToDefaults(UGameUserSettings* Self)
	{
		Self->UGameUserSettings::SetToDefaults();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetViewDistanceQuality(UGameUserSettings* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetViewDistanceQuality(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetVisualEffectQuality(UGameUserSettings* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetVisualEffectQuality(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetVSyncEnabled(UGameUserSettings* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->SetVSyncEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SetWindowPosition(UGameUserSettings* Self, int32 WindowPosX, int32 WindowPosY)
	{
		auto _p0 = WindowPosX;
		auto _p1 = WindowPosY;
		Self->UGameUserSettings::SetWindowPosition(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UGameUserSettings_SupportsHDRDisplayOutput(UGameUserSettings* Self)
	{
		return Self->SupportsHDRDisplayOutput();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_UpdateResolutionQuality(UGameUserSettings* Self)
	{
		((E_PROTECTED_WRAP_UGameUserSettings*)Self)->UpdateResolutionQuality_WRAP();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_UpdateVersion(UGameUserSettings* Self)
	{
		((E_PROTECTED_WRAP_UGameUserSettings*)Self)->UGameUserSettings::UpdateVersion_WRAP();
	}

	DOTNET_EXPORT auto E_UGameUserSettings_ValidateSettings(UGameUserSettings* Self)
	{
		Self->UGameUserSettings::ValidateSettings();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
