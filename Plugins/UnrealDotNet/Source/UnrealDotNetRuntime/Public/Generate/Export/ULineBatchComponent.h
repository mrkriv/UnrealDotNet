#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/LineBatchComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ULineBatchComponent_DefaultLifeTime_GET(ULineBatchComponent* Ptr) { return Ptr->DefaultLifeTime; }
	DOTNET_EXPORT void E_PROP_ULineBatchComponent_DefaultLifeTime_SET(ULineBatchComponent* Ptr, float Value) { Ptr->DefaultLifeTime = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULineBatchComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULineBatchComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_DrawLine(ULineBatchComponent* Self, INT_PTR Start, INT_PTR End, INT_PTR Color, uint8 DepthPriority, float Thickness, float LifeTime)
	{
		auto& _p0 = *(FVector*)Start;
		auto& _p1 = *(FVector*)End;
		auto& _p2 = *(FLinearColor*)Color;
		auto _p3 = DepthPriority;
		auto _p4 = Thickness;
		auto _p5 = LifeTime;
		Self->ULineBatchComponent::DrawLine(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_DrawPoint(ULineBatchComponent* Self, INT_PTR Position, INT_PTR Color, float PointSize, uint8 DepthPriority, float LifeTime)
	{
		auto& _p0 = *(FVector*)Position;
		auto& _p1 = *(FLinearColor*)Color;
		auto _p2 = PointSize;
		auto _p3 = DepthPriority;
		auto _p4 = LifeTime;
		Self->ULineBatchComponent::DrawPoint(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_Flush(ULineBatchComponent* Self)
	{
		Self->Flush();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
