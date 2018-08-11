#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Components/DecalComponent.h"
#include "ManageDecalComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

UCLASS()
class UNREALDOTNETRUNTIME_API UManageDecalComponent : public UDecalComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
protected:
	
	virtual void LifeSpanCallback() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
