#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageSpringArmComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSpringArmComponent : public USpringArmComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
protected:
	
	virtual void UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime) override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
