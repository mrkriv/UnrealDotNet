#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Engine/Engine.h"
#include "ManageEngine.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:603

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
	
	virtual void WorldAdded(UWorld* World) override;
	
	virtual void WorldDestroyed(UWorld* InWorld) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
