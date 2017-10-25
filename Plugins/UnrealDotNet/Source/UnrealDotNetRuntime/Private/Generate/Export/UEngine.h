#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Engine/Classes/Engine/Engine.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:585

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UEngine_bIsInitialized_GET(UEngine* Ptr) { return Ptr->bIsInitialized; }
	DOTNET_EXPORT void E_PROP_UEngine_bIsInitialized_SET(UEngine* Ptr, bool Value) { Ptr->bIsInitialized = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_BSPSelectionHighlightIntensity_GET(UEngine* Ptr) { return Ptr->BSPSelectionHighlightIntensity; }
	DOTNET_EXPORT void E_PROP_UEngine_BSPSelectionHighlightIntensity_SET(UEngine* Ptr, float Value) { Ptr->BSPSelectionHighlightIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_CameraRotationThreshold_GET(UEngine* Ptr) { return Ptr->CameraRotationThreshold; }
	DOTNET_EXPORT void E_PROP_UEngine_CameraRotationThreshold_SET(UEngine* Ptr, float Value) { Ptr->CameraRotationThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_CameraTranslationThreshold_GET(UEngine* Ptr) { return Ptr->CameraTranslationThreshold; }
	DOTNET_EXPORT void E_PROP_UEngine_CameraTranslationThreshold_SET(UEngine* Ptr, float Value) { Ptr->CameraTranslationThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ClientCycles_GET(UEngine* Ptr) { return Ptr->ClientCycles; }
	DOTNET_EXPORT void E_PROP_UEngine_ClientCycles_SET(UEngine* Ptr, int32 Value) { Ptr->ClientCycles = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_DisplayGamma_GET(UEngine* Ptr) { return Ptr->DisplayGamma; }
	DOTNET_EXPORT void E_PROP_UEngine_DisplayGamma_SET(UEngine* Ptr, float Value) { Ptr->DisplayGamma = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_FixedFrameRate_GET(UEngine* Ptr) { return Ptr->FixedFrameRate; }
	DOTNET_EXPORT void E_PROP_UEngine_FixedFrameRate_SET(UEngine* Ptr, float Value) { Ptr->FixedFrameRate = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_GameCycles_GET(UEngine* Ptr) { return Ptr->GameCycles; }
	DOTNET_EXPORT void E_PROP_UEngine_GameCycles_SET(UEngine* Ptr, int32 Value) { Ptr->GameCycles = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_GameScreenshotSaveDirectory_GET(UEngine* Ptr) { return (INT_PTR)&(Ptr->GameScreenshotSaveDirectory); }
	DOTNET_EXPORT void E_PROP_UEngine_GameScreenshotSaveDirectory_SET(UEngine* Ptr, INT_PTR Value) { Ptr->GameScreenshotSaveDirectory = *(FDirectoryPath*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_GameSingleton_GET(UEngine* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->GameSingleton); }
	DOTNET_EXPORT void E_PROP_UEngine_GameSingleton_SET(UEngine* Ptr, UObject* Value) { Ptr->GameSingleton = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_HoverHighlightIntensity_GET(UEngine* Ptr) { return Ptr->HoverHighlightIntensity; }
	DOTNET_EXPORT void E_PROP_UEngine_HoverHighlightIntensity_SET(UEngine* Ptr, float Value) { Ptr->HoverHighlightIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_IdealLightMapDensity_GET(UEngine* Ptr) { return Ptr->IdealLightMapDensity; }
	DOTNET_EXPORT void E_PROP_UEngine_IdealLightMapDensity_SET(UEngine* Ptr, float Value) { Ptr->IdealLightMapDensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LevelColorationLitMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->LevelColorationLitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_LevelColorationLitMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->LevelColorationLitMaterialName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LevelColorationUnlitMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->LevelColorationUnlitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_LevelColorationUnlitMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->LevelColorationUnlitMaterialName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LightingTexelDensityName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->LightingTexelDensityName); }
	DOTNET_EXPORT void E_PROP_UEngine_LightingTexelDensityName_SET(UEngine* Ptr, char* Value) { Ptr->LightingTexelDensityName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_GET(UEngine* Ptr) { return Ptr->MaxES2PixelShaderAdditiveComplexityCount; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_SET(UEngine* Ptr, float Value) { Ptr->MaxES2PixelShaderAdditiveComplexityCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MaximumLoopIterationCount_GET(UEngine* Ptr) { return Ptr->MaximumLoopIterationCount; }
	DOTNET_EXPORT void E_PROP_UEngine_MaximumLoopIterationCount_SET(UEngine* Ptr, int32 Value) { Ptr->MaximumLoopIterationCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MaxLightMapDensity_GET(UEngine* Ptr) { return Ptr->MaxLightMapDensity; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxLightMapDensity_SET(UEngine* Ptr, float Value) { Ptr->MaxLightMapDensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MaxOcclusionPixelsFraction_GET(UEngine* Ptr) { return Ptr->MaxOcclusionPixelsFraction; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxOcclusionPixelsFraction_SET(UEngine* Ptr, float Value) { Ptr->MaxOcclusionPixelsFraction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MaxParticleResize_GET(UEngine* Ptr) { return Ptr->MaxParticleResize; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxParticleResize_SET(UEngine* Ptr, int32 Value) { Ptr->MaxParticleResize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MaxParticleResizeWarn_GET(UEngine* Ptr) { return Ptr->MaxParticleResizeWarn; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxParticleResizeWarn_SET(UEngine* Ptr, int32 Value) { Ptr->MaxParticleResizeWarn = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_GET(UEngine* Ptr) { return Ptr->MaxPixelShaderAdditiveComplexityCount; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_SET(UEngine* Ptr, float Value) { Ptr->MaxPixelShaderAdditiveComplexityCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MeshLODRange_GET(UEngine* Ptr) { return Ptr->MeshLODRange; }
	DOTNET_EXPORT void E_PROP_UEngine_MeshLODRange_SET(UEngine* Ptr, float Value) { Ptr->MeshLODRange = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MinDesiredFrameRate_GET(UEngine* Ptr) { return Ptr->MinDesiredFrameRate; }
	DOTNET_EXPORT void E_PROP_UEngine_MinDesiredFrameRate_SET(UEngine* Ptr, float Value) { Ptr->MinDesiredFrameRate = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MinLightMapDensity_GET(UEngine* Ptr) { return Ptr->MinLightMapDensity; }
	DOTNET_EXPORT void E_PROP_UEngine_MinLightMapDensity_SET(UEngine* Ptr, float Value) { Ptr->MinLightMapDensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_NearClipPlane_GET(UEngine* Ptr) { return Ptr->NearClipPlane; }
	DOTNET_EXPORT void E_PROP_UEngine_NearClipPlane_SET(UEngine* Ptr, float Value) { Ptr->NearClipPlane = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_NetClientTicksPerSecond_GET(UEngine* Ptr) { return Ptr->NetClientTicksPerSecond; }
	DOTNET_EXPORT void E_PROP_UEngine_NetClientTicksPerSecond_SET(UEngine* Ptr, float Value) { Ptr->NetClientTicksPerSecond = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_GET(UEngine* Ptr) { return Ptr->NumPawnsAllowedToBeSpawnedInAFrame; }
	DOTNET_EXPORT void E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_SET(UEngine* Ptr, int32 Value) { Ptr->NumPawnsAllowedToBeSpawnedInAFrame = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ParticleEventManagerClassPath_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->ParticleEventManagerClassPath); }
	DOTNET_EXPORT void E_PROP_UEngine_ParticleEventManagerClassPath_SET(UEngine* Ptr, char* Value) { Ptr->ParticleEventManagerClassPath = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_PhysicErrorCorrection_GET(UEngine* Ptr) { return (INT_PTR)&(Ptr->PhysicErrorCorrection); }
	DOTNET_EXPORT void E_PROP_UEngine_PhysicErrorCorrection_SET(UEngine* Ptr, INT_PTR Value) { Ptr->PhysicErrorCorrection = *(FRigidBodyErrorCorrection*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_PlayOnConsoleSaveDir_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->PlayOnConsoleSaveDir); }
	DOTNET_EXPORT void E_PROP_UEngine_PlayOnConsoleSaveDir_SET(UEngine* Ptr, char* Value) { Ptr->PlayOnConsoleSaveDir = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_PrimitiveProbablyVisibleTime_GET(UEngine* Ptr) { return Ptr->PrimitiveProbablyVisibleTime; }
	DOTNET_EXPORT void E_PROP_UEngine_PrimitiveProbablyVisibleTime_SET(UEngine* Ptr, float Value) { Ptr->PrimitiveProbablyVisibleTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_RenderLightMapDensityColorScale_GET(UEngine* Ptr) { return Ptr->RenderLightMapDensityColorScale; }
	DOTNET_EXPORT void E_PROP_UEngine_RenderLightMapDensityColorScale_SET(UEngine* Ptr, float Value) { Ptr->RenderLightMapDensityColorScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_GET(UEngine* Ptr) { return Ptr->RenderLightMapDensityGrayscaleScale; }
	DOTNET_EXPORT void E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_SET(UEngine* Ptr, float Value) { Ptr->RenderLightMapDensityGrayscaleScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_SelectionHighlightIntensity_GET(UEngine* Ptr) { return Ptr->SelectionHighlightIntensity; }
	DOTNET_EXPORT void E_PROP_UEngine_SelectionHighlightIntensity_SET(UEngine* Ptr, float Value) { Ptr->SelectionHighlightIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_SelectionHighlightIntensityBillboards_GET(UEngine* Ptr) { return Ptr->SelectionHighlightIntensityBillboards; }
	DOTNET_EXPORT void E_PROP_UEngine_SelectionHighlightIntensityBillboards_SET(UEngine* Ptr, float Value) { Ptr->SelectionHighlightIntensityBillboards = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_GET(UEngine* Ptr) { return Ptr->SelectionMeshSectionHighlightIntensity; }
	DOTNET_EXPORT void E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_SET(UEngine* Ptr, float Value) { Ptr->SelectionMeshSectionHighlightIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ShadedLevelColorationLitMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->ShadedLevelColorationLitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_ShadedLevelColorationLitMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->ShadedLevelColorationLitMaterialName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->ShadedLevelColorationUnlitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->ShadedLevelColorationUnlitMaterialName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_StreamingDistanceFactor_GET(UEngine* Ptr) { return Ptr->StreamingDistanceFactor; }
	DOTNET_EXPORT void E_PROP_UEngine_StreamingDistanceFactor_SET(UEngine* Ptr, float Value) { Ptr->StreamingDistanceFactor = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_TickCycles_GET(UEngine* Ptr) { return Ptr->TickCycles; }
	DOTNET_EXPORT void E_PROP_UEngine_TickCycles_SET(UEngine* Ptr, int32 Value) { Ptr->TickCycles = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_TransitionDescription_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->TransitionDescription); }
	DOTNET_EXPORT void E_PROP_UEngine_TransitionDescription_SET(UEngine* Ptr, char* Value) { Ptr->TransitionDescription = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_TransitionGameMode_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->TransitionGameMode); }
	DOTNET_EXPORT void E_PROP_UEngine_TransitionGameMode_SET(UEngine* Ptr, char* Value) { Ptr->TransitionGameMode = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_VertexColorMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->VertexColorMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->VertexColorMaterialName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_VertexColorViewModeMaterialName_AlphaAsColor_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->VertexColorViewModeMaterialName_AlphaAsColor); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_AlphaAsColor_SET(UEngine* Ptr, char* Value) { Ptr->VertexColorViewModeMaterialName_AlphaAsColor = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_VertexColorViewModeMaterialName_BlueOnly_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->VertexColorViewModeMaterialName_BlueOnly); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_BlueOnly_SET(UEngine* Ptr, char* Value) { Ptr->VertexColorViewModeMaterialName_BlueOnly = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_VertexColorViewModeMaterialName_ColorOnly_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->VertexColorViewModeMaterialName_ColorOnly); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_ColorOnly_SET(UEngine* Ptr, char* Value) { Ptr->VertexColorViewModeMaterialName_ColorOnly = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_VertexColorViewModeMaterialName_GreenOnly_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->VertexColorViewModeMaterialName_GreenOnly); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_GreenOnly_SET(UEngine* Ptr, char* Value) { Ptr->VertexColorViewModeMaterialName_GreenOnly = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_VertexColorViewModeMaterialName_RedOnly_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->VertexColorViewModeMaterialName_RedOnly); }
	DOTNET_EXPORT void E_PROP_UEngine_VertexColorViewModeMaterialName_RedOnly_SET(UEngine* Ptr, char* Value) { Ptr->VertexColorViewModeMaterialName_RedOnly = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_WireframeMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->WireframeMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_WireframeMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->WireframeMaterialName = ConvertFromManage_FString(Value); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UEngine(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UEngine>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UEngine_IsInitialized(UEngine* Self)
	{
		return Self->IsInitialized();
	}

	DOTNET_EXPORT auto E_UEngine_ParseCommandline(UEngine* Self)
	{
		Self->ParseCommandline();
	}

	DOTNET_EXPORT auto E_UEngine_PreExit(UEngine* Self)
	{
		Self->PreExit();
	}

	DOTNET_EXPORT auto E_UEngine_RestoreSelectedMaterialColor(UEngine* Self)
	{
		Self->RestoreSelectedMaterialColor();
	}

	DOTNET_EXPORT auto E_UEngine_ShutdownAudioDeviceManager(UEngine* Self)
	{
		Self->ShutdownAudioDeviceManager();
	}

	DOTNET_EXPORT auto E_UEngine_ShutdownHMD(UEngine* Self)
	{
		Self->ShutdownHMD();
	}

	DOTNET_EXPORT auto E_UEngine_Start(UEngine* Self)
	{
		Self->Start();
	}

	DOTNET_EXPORT auto E_UEngine_Tick(UEngine* Self, float DeltaSeconds, bool bIdleMode)
	{
		auto _p0 = DeltaSeconds;
		auto _p1 = bIdleMode;
		Self->Tick(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UEngine_WorldAdded(UEngine* Self, UWorld* World)
	{
		auto _p0 = World;
		Self->WorldAdded(_p0);
	}

	DOTNET_EXPORT auto E_UEngine_WorldDestroyed(UEngine* Self, UWorld* InWorld)
	{
		auto _p0 = InWorld;
		Self->WorldDestroyed(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
