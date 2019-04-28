#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Components/LineBatchComponent.h"
#include "ManageLineBatchComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

UCLASS()
class UNREALDOTNETRUNTIME_API UManageLineBatchComponent : public ULineBatchComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void DrawLine(const FVector& Start, const FVector& End, const FLinearColor& Color, uint8 DepthPriority, float Thickness, float LifeTime) override;
	virtual void DrawPoint(const FVector& Position, const FLinearColor& Color, float PointSize, uint8 DepthPriority, float LifeTime) override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
