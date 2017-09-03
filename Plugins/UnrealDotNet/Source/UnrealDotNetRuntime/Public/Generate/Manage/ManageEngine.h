#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageEngine.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageEngine : public UEngine
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditDefaultsOnly, Category = "C#")
	FString ManageClassName;
	
	
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
