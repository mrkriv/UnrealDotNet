#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Engine/Engine.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:637

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UEngine_ActiveClassRedirects_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->ActiveClassRedirects); }
	DOTNET_EXPORT void E_PROP_UEngine_ActiveClassRedirects_SET(UEngine* Ptr, INT_PTR Value) { Ptr->ActiveClassRedirects = *(TArray<FClassRedirect>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ActiveGameNameRedirects_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->ActiveGameNameRedirects); }
	DOTNET_EXPORT void E_PROP_UEngine_ActiveGameNameRedirects_SET(UEngine* Ptr, INT_PTR Value) { Ptr->ActiveGameNameRedirects = *(TArray<FGameNameRedirect>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ActivePluginRedirects_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->ActivePluginRedirects); }
	DOTNET_EXPORT void E_PROP_UEngine_ActivePluginRedirects_SET(UEngine* Ptr, INT_PTR Value) { Ptr->ActivePluginRedirects = *(TArray<FPluginRedirect>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ActiveStructRedirects_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->ActiveStructRedirects); }
	DOTNET_EXPORT void E_PROP_UEngine_ActiveStructRedirects_SET(UEngine* Ptr, INT_PTR Value) { Ptr->ActiveStructRedirects = *(TArray<FStructRedirect>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_AdditionalFontNames_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->AdditionalFontNames); }
	DOTNET_EXPORT void E_PROP_UEngine_AdditionalFontNames_SET(UEngine* Ptr, INT_PTR Value) { Ptr->AdditionalFontNames = *(TArray<FString>*)Value; }
	
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
	
	DOTNET_EXPORT auto E_PROP_UEngine_DeferredCommands_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->DeferredCommands); }
	DOTNET_EXPORT void E_PROP_UEngine_DeferredCommands_SET(UEngine* Ptr, INT_PTR Value) { Ptr->DeferredCommands = *(TArray<FString>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_DisplayGamma_GET(UEngine* Ptr) { return Ptr->DisplayGamma; }
	DOTNET_EXPORT void E_PROP_UEngine_DisplayGamma_SET(UEngine* Ptr, float Value) { Ptr->DisplayGamma = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_FixedFrameRate_GET(UEngine* Ptr) { return Ptr->FixedFrameRate; }
	DOTNET_EXPORT void E_PROP_UEngine_FixedFrameRate_SET(UEngine* Ptr, float Value) { Ptr->FixedFrameRate = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_GameCycles_GET(UEngine* Ptr) { return Ptr->GameCycles; }
	DOTNET_EXPORT void E_PROP_UEngine_GameCycles_SET(UEngine* Ptr, int32 Value) { Ptr->GameCycles = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_GameSingleton_GET(UEngine* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->GameSingleton); }
	DOTNET_EXPORT void E_PROP_UEngine_GameSingleton_SET(UEngine* Ptr, UObject* Value) { Ptr->GameSingleton = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_HLODColorationColors_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->HLODColorationColors); }
	DOTNET_EXPORT void E_PROP_UEngine_HLODColorationColors_SET(UEngine* Ptr, INT_PTR Value) { Ptr->HLODColorationColors = *(TArray<FLinearColor>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_IdealLightMapDensity_GET(UEngine* Ptr) { return Ptr->IdealLightMapDensity; }
	DOTNET_EXPORT void E_PROP_UEngine_IdealLightMapDensity_SET(UEngine* Ptr, float Value) { Ptr->IdealLightMapDensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LevelColorationLitMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->LevelColorationLitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_LevelColorationLitMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->LevelColorationLitMaterialName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LevelColorationUnlitMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->LevelColorationUnlitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_LevelColorationUnlitMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->LevelColorationUnlitMaterialName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LightComplexityColors_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->LightComplexityColors); }
	DOTNET_EXPORT void E_PROP_UEngine_LightComplexityColors_SET(UEngine* Ptr, INT_PTR Value) { Ptr->LightComplexityColors = *(TArray<FLinearColor>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LightingOnlyBrightness_GET(UEngine* Ptr) { return (INT_PTR)&(Ptr->LightingOnlyBrightness); }
	DOTNET_EXPORT void E_PROP_UEngine_LightingOnlyBrightness_SET(UEngine* Ptr, INT_PTR Value) { Ptr->LightingOnlyBrightness = *(FLinearColor*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LightingTexelDensityName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->LightingTexelDensityName); }
	DOTNET_EXPORT void E_PROP_UEngine_LightingTexelDensityName_SET(UEngine* Ptr, char* Value) { Ptr->LightingTexelDensityName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LightMapDensitySelectedColor_GET(UEngine* Ptr) { return (INT_PTR)&(Ptr->LightMapDensitySelectedColor); }
	DOTNET_EXPORT void E_PROP_UEngine_LightMapDensitySelectedColor_SET(UEngine* Ptr, INT_PTR Value) { Ptr->LightMapDensitySelectedColor = *(FLinearColor*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LightMapDensityVertexMappedColor_GET(UEngine* Ptr) { return (INT_PTR)&(Ptr->LightMapDensityVertexMappedColor); }
	DOTNET_EXPORT void E_PROP_UEngine_LightMapDensityVertexMappedColor_SET(UEngine* Ptr, INT_PTR Value) { Ptr->LightMapDensityVertexMappedColor = *(FLinearColor*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_LODColorationColors_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->LODColorationColors); }
	DOTNET_EXPORT void E_PROP_UEngine_LODColorationColors_SET(UEngine* Ptr, INT_PTR Value) { Ptr->LODColorationColors = *(TArray<FLinearColor>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_GET(UEngine* Ptr) { return Ptr->MaxES2PixelShaderAdditiveComplexityCount; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_SET(UEngine* Ptr, float Value) { Ptr->MaxES2PixelShaderAdditiveComplexityCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_MaxES3PixelShaderAdditiveComplexityCount_GET(UEngine* Ptr) { return Ptr->MaxES3PixelShaderAdditiveComplexityCount; }
	DOTNET_EXPORT void E_PROP_UEngine_MaxES3PixelShaderAdditiveComplexityCount_SET(UEngine* Ptr, float Value) { Ptr->MaxES3PixelShaderAdditiveComplexityCount = Value; }
	
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
	
	DOTNET_EXPORT auto E_PROP_UEngine_PendingDroppedNotes_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->PendingDroppedNotes); }
	DOTNET_EXPORT void E_PROP_UEngine_PendingDroppedNotes_SET(UEngine* Ptr, INT_PTR Value) { Ptr->PendingDroppedNotes = *(TArray<FDropNoteInfo>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_PrimitiveProbablyVisibleTime_GET(UEngine* Ptr) { return Ptr->PrimitiveProbablyVisibleTime; }
	DOTNET_EXPORT void E_PROP_UEngine_PrimitiveProbablyVisibleTime_SET(UEngine* Ptr, float Value) { Ptr->PrimitiveProbablyVisibleTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_PriorityScreenMessages_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->PriorityScreenMessages); }
	DOTNET_EXPORT void E_PROP_UEngine_PriorityScreenMessages_SET(UEngine* Ptr, INT_PTR Value) { Ptr->PriorityScreenMessages = *(TArray<FScreenMessageString>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_QuadComplexityColors_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->QuadComplexityColors); }
	DOTNET_EXPORT void E_PROP_UEngine_QuadComplexityColors_SET(UEngine* Ptr, INT_PTR Value) { Ptr->QuadComplexityColors = *(TArray<FLinearColor>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_RenderLightMapDensityColorScale_GET(UEngine* Ptr) { return Ptr->RenderLightMapDensityColorScale; }
	DOTNET_EXPORT void E_PROP_UEngine_RenderLightMapDensityColorScale_SET(UEngine* Ptr, float Value) { Ptr->RenderLightMapDensityColorScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_GET(UEngine* Ptr) { return Ptr->RenderLightMapDensityGrayscaleScale; }
	DOTNET_EXPORT void E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_SET(UEngine* Ptr, float Value) { Ptr->RenderLightMapDensityGrayscaleScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_SelectionHighlightIntensity_GET(UEngine* Ptr) { return Ptr->SelectionHighlightIntensity; }
	DOTNET_EXPORT void E_PROP_UEngine_SelectionHighlightIntensity_SET(UEngine* Ptr, float Value) { Ptr->SelectionHighlightIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_SelectionHighlightIntensityBillboards_GET(UEngine* Ptr) { return Ptr->SelectionHighlightIntensityBillboards; }
	DOTNET_EXPORT void E_PROP_UEngine_SelectionHighlightIntensityBillboards_SET(UEngine* Ptr, float Value) { Ptr->SelectionHighlightIntensityBillboards = Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ShadedLevelColorationLitMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->ShadedLevelColorationLitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_ShadedLevelColorationLitMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->ShadedLevelColorationLitMaterialName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_GET(UEngine* Ptr) { return ConvertToManage_StringWrapper(Ptr->ShadedLevelColorationUnlitMaterialName); }
	DOTNET_EXPORT void E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_SET(UEngine* Ptr, char* Value) { Ptr->ShadedLevelColorationUnlitMaterialName = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngine_ShaderComplexityColors_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->ShaderComplexityColors); }
	DOTNET_EXPORT void E_PROP_UEngine_ShaderComplexityColors_SET(UEngine* Ptr, INT_PTR Value) { Ptr->ShaderComplexityColors = *(TArray<FLinearColor>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_StatColorMappings_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->StatColorMappings); }
	DOTNET_EXPORT void E_PROP_UEngine_StatColorMappings_SET(UEngine* Ptr, INT_PTR Value) { Ptr->StatColorMappings = *(TArray<FStatColorMapping>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_StationaryLightOverlapColors_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->StationaryLightOverlapColors); }
	DOTNET_EXPORT void E_PROP_UEngine_StationaryLightOverlapColors_SET(UEngine* Ptr, INT_PTR Value) { Ptr->StationaryLightOverlapColors = *(TArray<FLinearColor>*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UEngine_StreamingAccuracyColors_GET(UEngine* Ptr) { return ConvertToManage_TemplatePointerDescription(Ptr->StreamingAccuracyColors); }
	DOTNET_EXPORT void E_PROP_UEngine_StreamingAccuracyColors_SET(UEngine* Ptr, INT_PTR Value) { Ptr->StreamingAccuracyColors = *(TArray<FLinearColor>*)Value; }
	
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

	DOTNET_EXPORT auto E_UEngine_GetDynamicResolutionCurrentStateInfos(UEngine* Self, INT_PTR OutInfos)
	{
		auto& _p0 = *(FDynamicResolutionStateInfos*)OutInfos;
		Self->GetDynamicResolutionCurrentStateInfos(_p0);
	}

	DOTNET_EXPORT auto E_UEngine_GetDynamicResolutionUserSetting(UEngine* Self)
	{
		return Self->GetDynamicResolutionUserSetting();
	}

	DOTNET_EXPORT auto E_UEngine_GetHoveredMaterialColor(UEngine* Self)
	{
		return (INT_PTR) const_cast<FLinearColor*>(&(Self->GetHoveredMaterialColor()));
	}

	DOTNET_EXPORT auto E_UEngine_GetSelectedMaterialColor(UEngine* Self)
	{
		return (INT_PTR) const_cast<FLinearColor*>(&(Self->GetSelectedMaterialColor()));
	}

	DOTNET_EXPORT auto E_UEngine_GetSelectionOutlineColor(UEngine* Self)
	{
		return (INT_PTR) const_cast<FLinearColor*>(&(Self->GetSelectionOutlineColor()));
	}

	DOTNET_EXPORT auto E_UEngine_GetSubduedSelectionOutlineColor(UEngine* Self)
	{
		return (INT_PTR) const_cast<FLinearColor*>(&(Self->GetSubduedSelectionOutlineColor()));
	}

	DOTNET_EXPORT auto E_UEngine_IsInitialized(UEngine* Self)
	{
		return Self->IsInitialized();
	}

	DOTNET_EXPORT auto E_UEngine_OverrideSelectedMaterialColor(UEngine* Self, INT_PTR OverrideColor)
	{
		auto& _p0 = *(FLinearColor*)OverrideColor;
		Self->OverrideSelectedMaterialColor(_p0);
	}

	DOTNET_EXPORT auto E_UEngine_ParseCommandline(UEngine* Self)
	{
		Self->ParseCommandline();
	}

	DOTNET_EXPORT auto E_UEngine_PauseDynamicResolution(UEngine* Self)
	{
		Self->PauseDynamicResolution();
	}

	DOTNET_EXPORT auto E_UEngine_PreExit(UEngine* Self)
	{
		Self->PreExit();
	}

	DOTNET_EXPORT auto E_UEngine_RestoreSelectedMaterialColor(UEngine* Self)
	{
		Self->RestoreSelectedMaterialColor();
	}

	DOTNET_EXPORT auto E_UEngine_ResumeDynamicResolution(UEngine* Self)
	{
		Self->ResumeDynamicResolution();
	}

	DOTNET_EXPORT auto E_UEngine_SetDynamicResolutionUserSetting(UEngine* Self, bool Enable)
	{
		auto _p0 = Enable;
		Self->SetDynamicResolutionUserSetting(_p0);
	}

	DOTNET_EXPORT auto E_UEngine_SetSelectedMaterialColor(UEngine* Self, INT_PTR InSelectedMaterialColor)
	{
		auto& _p0 = *(FLinearColor*)InSelectedMaterialColor;
		Self->SetSelectedMaterialColor(_p0);
	}

	DOTNET_EXPORT auto E_UEngine_SetSelectionOutlineColor(UEngine* Self, INT_PTR InSelectionOutlineColor)
	{
		auto& _p0 = *(FLinearColor*)InSelectionOutlineColor;
		Self->SetSelectionOutlineColor(_p0);
	}

	DOTNET_EXPORT auto E_UEngine_SetSubduedSelectionOutlineColor(UEngine* Self, INT_PTR InSubduedSelectionOutlineColor)
	{
		auto& _p0 = *(FLinearColor*)InSubduedSelectionOutlineColor;
		Self->SetSubduedSelectionOutlineColor(_p0);
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
