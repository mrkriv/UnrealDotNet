#pragma once

#include "CoreShell.h"
#include "Generate/ManageEventSender.h"
#include "ManagerObject.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManagerObject : public UObject
{
	GENERATED_BODY()

	FTimerHandle GCTimerHandle;

public:

	UManagerObject();
};
