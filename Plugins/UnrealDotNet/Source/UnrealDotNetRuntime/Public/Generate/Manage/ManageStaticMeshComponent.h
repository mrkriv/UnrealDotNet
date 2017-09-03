#include "CoreShell.h"
#include "ManageStaticMeshComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageStaticMeshComponent : public UStaticMeshComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditDefaultsOnly, Category = "C#")
	FString ManageClassName;
	
	
public:
	
	virtual bool SetStaticLightingMapping(bool bTextureMapping, int32 ResolutionToUse) override;
	
	virtual bool SupportsDefaultCollision() override;
	
	virtual bool SupportsDitheredLODTransitions() override;
	
}
;
