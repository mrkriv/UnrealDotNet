#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Components/SceneComponent.h"
#include "ManageSceneComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:106

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSceneComponent : public USceneComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void DetachFromComponent(const FDetachmentTransformRules& DetachmentRules) override;
	virtual void DetachFromParent(bool bMaintainWorldPosition, bool bCallModify) override;
	virtual void OnAttachmentChanged() override;
	virtual void PropagateLightingScenarioChange() override;
	virtual void SetRelativeScale3D(FVector NewScale3D) override;
	virtual void UpdateBounds() override;
	virtual void UpdatePhysicsVolume(bool bTriggerNotifiers) override;
	
protected:
	virtual void OnChildAttached(USceneComponent* ChildComponent) override;
	virtual void OnChildDetached(USceneComponent* ChildComponent) override;
	virtual void OnHiddenInGameChanged() override;
	virtual void OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport) override;
	virtual void OnVisibilityChanged() override;
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
