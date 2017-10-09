#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Engine.h"
#include "ManageEngine.generated.h"

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Engine.h:585

UCLASS()
class UNREALDOTNETRUNTIME_API UManageEngine : public UEngine
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void PreExit() override;
	
	virtual void ShutdownAudioDeviceManager() override;
	
	virtual void Start() override;
	
	virtual void Tick(float DeltaSeconds, bool bIdleMode) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
