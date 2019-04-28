#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/TextRenderComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TextRenderComponent.h:44

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_HorizSpacingAdjust_GET(UTextRenderComponent* Ptr) { return Ptr->HorizSpacingAdjust; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_HorizSpacingAdjust_SET(UTextRenderComponent* Ptr, float Value) { Ptr->HorizSpacingAdjust = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_InvDefaultSize_GET(UTextRenderComponent* Ptr) { return Ptr->InvDefaultSize; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_InvDefaultSize_SET(UTextRenderComponent* Ptr, float Value) { Ptr->InvDefaultSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_Text_GET(UTextRenderComponent* Ptr) { return ConvertToManage_StringWrapper(Ptr->Text); }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_Text_SET(UTextRenderComponent* Ptr, char* Value) { Ptr->Text = ConvertFromManage_FText(Value); }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_VertSpacingAdjust_GET(UTextRenderComponent* Ptr) { return Ptr->VertSpacingAdjust; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_VertSpacingAdjust_SET(UTextRenderComponent* Ptr, float Value) { Ptr->VertSpacingAdjust = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_WorldSize_GET(UTextRenderComponent* Ptr) { return Ptr->WorldSize; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_WorldSize_SET(UTextRenderComponent* Ptr, float Value) { Ptr->WorldSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_XScale_GET(UTextRenderComponent* Ptr) { return Ptr->XScale; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_XScale_SET(UTextRenderComponent* Ptr, float Value) { Ptr->XScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_YScale_GET(UTextRenderComponent* Ptr) { return Ptr->YScale; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_YScale_SET(UTextRenderComponent* Ptr, float Value) { Ptr->YScale = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UTextRenderComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UTextRenderComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetTextLocalSize(UTextRenderComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetTextLocalSize());
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetTextWorldSize(UTextRenderComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetTextWorldSize());
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_InitializeMIDCache(UTextRenderComponent* Self)
	{
		Self->InitializeMIDCache();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_K2_SetText(UTextRenderComponent* Self, char* Value)
	{
		auto _p0 = ConvertFromManage_FText(Value);
		Self->K2_SetText(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetHorizontalAlignment(UTextRenderComponent* Self, EHorizTextAligment Value)
	{
		auto _p0 = Value;
		Self->SetHorizontalAlignment(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetHorizSpacingAdjust(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetHorizSpacingAdjust(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetText(UTextRenderComponent* Self, char* Value)
	{
		auto _p0 = ConvertFromManage_FString(Value);
		Self->SetText(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetText_o1(UTextRenderComponent* Self, char* Value)
	{
		auto _p0 = ConvertFromManage_FText(Value);
		Self->SetText(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetVerticalAlignment(UTextRenderComponent* Self, EVerticalTextAligment Value)
	{
		auto _p0 = Value;
		Self->SetVerticalAlignment(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetVertSpacingAdjust(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetVertSpacingAdjust(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetWorldSize(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetWorldSize(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetXScale(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetXScale(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetYScale(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetYScale(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ShutdownMIDCache(UTextRenderComponent* Self)
	{
		Self->ShutdownMIDCache();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
