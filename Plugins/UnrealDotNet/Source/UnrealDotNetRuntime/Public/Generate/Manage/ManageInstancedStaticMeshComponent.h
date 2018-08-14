#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Components/InstancedStaticMeshComponent.h"
#include "ManageInstancedStaticMeshComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:114

UCLASS()
class UNREALDOTNETRUNTIME_API UManageInstancedStaticMeshComponent : public UInstancedStaticMeshComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void SetManageClassName(FString name) override { ManageClassName.FullName = name; }
	virtual FString GetManageClassName() override { return ManageClassName.FullName; }
	
	
protected:
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
