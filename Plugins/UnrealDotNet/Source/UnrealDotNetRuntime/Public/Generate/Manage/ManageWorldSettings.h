#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/WorldSettings.h"
#include "ManageWorldSettings.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:395

UCLASS()
class UNREALDOTNETRUNTIME_API AManageWorldSettings : public AWorldSettings, public IManageObject
{
	GENERATED_UCLASS_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void NotifyBeginPlay() override;
	virtual void NotifyMatchStarted() override;
	virtual void OnRep_WorldGravityZ() override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
