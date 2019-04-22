#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Engine/Engine.h"
#include "ManageEngine.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:637

UCLASS()
class UNREALDOTNETRUNTIME_API UManageEngine : public UEngine, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void PreExit() override;
	virtual void ShutdownAudioDeviceManager() override;
	virtual void Start() override;
	virtual void Tick(float DeltaSeconds, bool bIdleMode) override;
	virtual void WorldAdded(UWorld* World) override;
	virtual void WorldDestroyed(UWorld* InWorld) override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
