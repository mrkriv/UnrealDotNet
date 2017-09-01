#pragma once

#include "CoreMinimal.h"
#include "Engine/Engine.h"

extern "C"
{
	DOTNET_EXPORT UObject* E_PROP_UEngine_GameSingleton_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->GameSingleton; }
	DOTNET_EXPORT void E_PROP_UEngine_GameSingleton_SET(INT_PTR Ptr, UObject* Value) { ((UEngine*)Ptr)->GameSingleton = Value; }
	
	DOTNET_EXPORT char* E_PROP_UEngine_PlayOnConsoleSaveDir_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->PlayOnConsoleSaveDir); }
	DOTNET_EXPORT void E_PROP_UEngine_PlayOnConsoleSaveDir_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->PlayOnConsoleSaveDir = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_WireframeMaterialName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->WireframeMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_WireframeMaterialName_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->WireframeMaterialName = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_LevelColorationLitMaterialName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->LevelColorationLitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_LevelColorationLitMaterialName_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->LevelColorationLitMaterialName = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_LevelColorationUnlitMaterialName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->LevelColorationUnlitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_LevelColorationUnlitMaterialName_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->LevelColorationUnlitMaterialName = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_LightingTexelDensityName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->LightingTexelDensityName); }
	DOTNET_EXPORT void E_PROP_UEngine_LightingTexelDensityName_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->LightingTexelDensityName = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_ShadedLevelColorationLitMaterialName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->ShadedLevelColorationLitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_ShadedLevelColorationLitMaterialName_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->ShadedLevelColorationLitMaterialName = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->ShadedLevelColorationUnlitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->ShadedLevelColorationUnlitMaterialName = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_VertexColorMaterialName_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->VertexColorMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorMaterialName_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->VertexColorMaterialName = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_VertexColorViewModeMaterialName_ColorOnly_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->VertexColorViewModeMaterialName_ColorOnly); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_ColorOnly_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->VertexColorViewModeMaterialName_ColorOnly = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_VertexColorViewModeMaterialName_AlphaAsColor_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->VertexColorViewModeMaterialName_AlphaAsColor); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_AlphaAsColor_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->VertexColorViewModeMaterialName_AlphaAsColor = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_VertexColorViewModeMaterialName_RedOnly_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->VertexColorViewModeMaterialName_RedOnly); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_RedOnly_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->VertexColorViewModeMaterialName_RedOnly = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_VertexColorViewModeMaterialName_GreenOnly_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->VertexColorViewModeMaterialName_GreenOnly); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_GreenOnly_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->VertexColorViewModeMaterialName_GreenOnly = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_VertexColorViewModeMaterialName_BlueOnly_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->VertexColorViewModeMaterialName_BlueOnly); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_BlueOnly_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->VertexColorViewModeMaterialName_BlueOnly = FString(Value); }
	
	DOTNET_EXPORT float E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MaxPixelShaderAdditiveComplexityCount; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->MaxPixelShaderAdditiveComplexityCount = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MaxES2PixelShaderAdditiveComplexityCount; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->MaxES2PixelShaderAdditiveComplexityCount = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_MinLightMapDensity_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MinLightMapDensity; }
	DOTNET_EXPORT void E_PROP_UEngine_MinLightMapDensity_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->MinLightMapDensity = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_IdealLightMapDensity_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->IdealLightMapDensity; }
	DOTNET_EXPORT void E_PROP_UEngine_IdealLightMapDensity_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->IdealLightMapDensity = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_MaxLightMapDensity_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MaxLightMapDensity; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxLightMapDensity_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->MaxLightMapDensity = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->RenderLightMapDensityGrayscaleScale; }
	DOTNET_EXPORT void E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->RenderLightMapDensityGrayscaleScale = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_RenderLightMapDensityColorScale_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->RenderLightMapDensityColorScale; }
	DOTNET_EXPORT void E_PROP_UEngine_RenderLightMapDensityColorScale_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->RenderLightMapDensityColorScale = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UEngine_TickCycles_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->TickCycles; }
	DOTNET_EXPORT void E_PROP_UEngine_TickCycles_SET(INT_PTR Ptr, int32 Value) { ((UEngine*)Ptr)->TickCycles = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UEngine_GameCycles_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->GameCycles; }
	DOTNET_EXPORT void E_PROP_UEngine_GameCycles_SET(INT_PTR Ptr, int32 Value) { ((UEngine*)Ptr)->GameCycles = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UEngine_ClientCycles_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->ClientCycles; }
	DOTNET_EXPORT void E_PROP_UEngine_ClientCycles_SET(INT_PTR Ptr, int32 Value) { ((UEngine*)Ptr)->ClientCycles = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_NearClipPlane_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->NearClipPlane; }
	DOTNET_EXPORT void E_PROP_UEngine_NearClipPlane_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->NearClipPlane = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UEngine_MaximumLoopIterationCount_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MaximumLoopIterationCount; }
	DOTNET_EXPORT void E_PROP_UEngine_MaximumLoopIterationCount_SET(INT_PTR Ptr, int32 Value) { ((UEngine*)Ptr)->MaximumLoopIterationCount = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_FixedFrameRate_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->FixedFrameRate; }
	DOTNET_EXPORT void E_PROP_UEngine_FixedFrameRate_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->FixedFrameRate = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->NumPawnsAllowedToBeSpawnedInAFrame; }
	DOTNET_EXPORT void E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_SET(INT_PTR Ptr, int32 Value) { ((UEngine*)Ptr)->NumPawnsAllowedToBeSpawnedInAFrame = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_StreamingDistanceFactor_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->StreamingDistanceFactor; }
	DOTNET_EXPORT void E_PROP_UEngine_StreamingDistanceFactor_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->StreamingDistanceFactor = Value; }
	
	DOTNET_EXPORT char* E_PROP_UEngine_TransitionDescription_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->TransitionDescription); }
	DOTNET_EXPORT void E_PROP_UEngine_TransitionDescription_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->TransitionDescription = FString(Value); }
	
	DOTNET_EXPORT char* E_PROP_UEngine_TransitionGameMode_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->TransitionGameMode); }
	DOTNET_EXPORT void E_PROP_UEngine_TransitionGameMode_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->TransitionGameMode = FString(Value); }
	
	DOTNET_EXPORT float E_PROP_UEngine_MeshLODRange_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MeshLODRange; }
	DOTNET_EXPORT void E_PROP_UEngine_MeshLODRange_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->MeshLODRange = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_CameraRotationThreshold_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->CameraRotationThreshold; }
	DOTNET_EXPORT void E_PROP_UEngine_CameraRotationThreshold_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->CameraRotationThreshold = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_CameraTranslationThreshold_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->CameraTranslationThreshold; }
	DOTNET_EXPORT void E_PROP_UEngine_CameraTranslationThreshold_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->CameraTranslationThreshold = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_PrimitiveProbablyVisibleTime_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->PrimitiveProbablyVisibleTime; }
	DOTNET_EXPORT void E_PROP_UEngine_PrimitiveProbablyVisibleTime_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->PrimitiveProbablyVisibleTime = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_MaxOcclusionPixelsFraction_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MaxOcclusionPixelsFraction; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxOcclusionPixelsFraction_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->MaxOcclusionPixelsFraction = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UEngine_MaxParticleResize_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MaxParticleResize; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxParticleResize_SET(INT_PTR Ptr, int32 Value) { ((UEngine*)Ptr)->MaxParticleResize = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UEngine_MaxParticleResizeWarn_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MaxParticleResizeWarn; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxParticleResizeWarn_SET(INT_PTR Ptr, int32 Value) { ((UEngine*)Ptr)->MaxParticleResizeWarn = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_NetClientTicksPerSecond_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->NetClientTicksPerSecond; }
	DOTNET_EXPORT void E_PROP_UEngine_NetClientTicksPerSecond_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->NetClientTicksPerSecond = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_DisplayGamma_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->DisplayGamma; }
	DOTNET_EXPORT void E_PROP_UEngine_DisplayGamma_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->DisplayGamma = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_MinDesiredFrameRate_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->MinDesiredFrameRate; }
	DOTNET_EXPORT void E_PROP_UEngine_MinDesiredFrameRate_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->MinDesiredFrameRate = Value; }
	
	DOTNET_EXPORT char* E_PROP_UEngine_ParticleEventManagerClassPath_GET(INT_PTR Ptr) { return TCHAR_TO_UTF8(*((UEngine*)Ptr)->ParticleEventManagerClassPath); }
	DOTNET_EXPORT void E_PROP_UEngine_ParticleEventManagerClassPath_SET(INT_PTR Ptr, char* Value) { ((UEngine*)Ptr)->ParticleEventManagerClassPath = FString(Value); }
	
	DOTNET_EXPORT float E_PROP_UEngine_SelectionHighlightIntensity_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->SelectionHighlightIntensity; }
	DOTNET_EXPORT void E_PROP_UEngine_SelectionHighlightIntensity_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->SelectionHighlightIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->SelectionMeshSectionHighlightIntensity; }
	DOTNET_EXPORT void E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->SelectionMeshSectionHighlightIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_BSPSelectionHighlightIntensity_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->BSPSelectionHighlightIntensity; }
	DOTNET_EXPORT void E_PROP_UEngine_BSPSelectionHighlightIntensity_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->BSPSelectionHighlightIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_HoverHighlightIntensity_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->HoverHighlightIntensity; }
	DOTNET_EXPORT void E_PROP_UEngine_HoverHighlightIntensity_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->HoverHighlightIntensity = Value; }
	
	DOTNET_EXPORT float E_PROP_UEngine_SelectionHighlightIntensityBillboards_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->SelectionHighlightIntensityBillboards; }
	DOTNET_EXPORT void E_PROP_UEngine_SelectionHighlightIntensityBillboards_SET(INT_PTR Ptr, float Value) { ((UEngine*)Ptr)->SelectionHighlightIntensityBillboards = Value; }
	
	DOTNET_EXPORT bool E_PROP_UEngine_bIsInitialized_GET(INT_PTR Ptr) { return ((UEngine*)Ptr)->bIsInitialized; }
	DOTNET_EXPORT void E_PROP_UEngine_bIsInitialized_SET(INT_PTR Ptr, bool Value) { ((UEngine*)Ptr)->bIsInitialized = Value; }
	
	DOTNET_EXPORT void E_UEngine_RestoreSelectedMaterialColor(INT_PTR Self)
	{
		((UEngine*)Self)->RestoreSelectedMaterialColor();
	}

	DOTNET_EXPORT void E_UEngine_WorldAdded(INT_PTR Self, UWorld* World)
	{
		auto _p0 = World;
		((UEngine*)Self)->WorldAdded(_p0);
	}

	DOTNET_EXPORT bool E_UEngine_IsInitialized(INT_PTR Self)
	{
		return ((UEngine*)Self)->IsInitialized();
	}

	DOTNET_EXPORT void E_UEngine_Tick(INT_PTR Self, float DeltaSeconds, bool bIdleMode)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = bIdleMode;
		((UEngine*)Self)->Tick(_p0, _p1);
	}

}
