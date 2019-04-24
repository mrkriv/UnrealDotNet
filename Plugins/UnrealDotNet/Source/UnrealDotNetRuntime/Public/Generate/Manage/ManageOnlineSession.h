#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/GameFramework/OnlineSession.h"
#include "ManageOnlineSession.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\OnlineSession.h:18

UCLASS()
class UNREALDOTNETRUNTIME_API UManageOnlineSession : public UOnlineSession, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void ClearOnlineDelegates() override;
	virtual void EndOnlineSession(FName SessionName) override;
	virtual void RegisterOnlineDelegates() override;
	virtual void StartOnlineSession(FName SessionName) override;
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
