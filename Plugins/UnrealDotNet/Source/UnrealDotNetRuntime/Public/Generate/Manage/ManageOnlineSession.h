#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Engine/Classes/GameFramework/OnlineSession.h"
#include "ManageOnlineSession.generated.h"

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\OnlineSession.h:18

UCLASS()
class UNREALDOTNETRUNTIME_API UManageOnlineSession : public UOnlineSession
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void ClearOnlineDelegates() override;
	
	virtual void EndOnlineSession(FName SessionName) override;
	
	virtual void RegisterOnlineDelegates() override;
	
	virtual void StartOnlineSession(FName SessionName) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
