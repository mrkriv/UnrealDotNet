#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageLight.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API AManageLight : public ALight
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditDefaultsOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void OnRep_bEnabled() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
