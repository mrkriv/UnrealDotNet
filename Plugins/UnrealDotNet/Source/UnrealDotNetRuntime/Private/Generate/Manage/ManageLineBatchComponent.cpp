// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageLineBatchComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

bool UManageLineBatchComponent::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void UManageLineBatchComponent::DrawLine(const FVector& Start, const FVector& End, const FLinearColor& Color, uint8 DepthPriority, float Thickness, float LifeTime)
{
	Super::DrawLine(Start, End, Color, DepthPriority, Thickness, LifeTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DrawLine", Start, End, Color, DepthPriority, Thickness, LifeTime);
}

void UManageLineBatchComponent::DrawPoint(const FVector& Position, const FLinearColor& Color, float PointSize, uint8 DepthPriority, float LifeTime)
{
	Super::DrawPoint(Position, Color, PointSize, DepthPriority, LifeTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DrawPoint", Position, Color, PointSize, DepthPriority, LifeTime);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
