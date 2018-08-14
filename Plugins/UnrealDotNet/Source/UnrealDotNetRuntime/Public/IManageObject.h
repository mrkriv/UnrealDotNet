#pragma once

#include "CoreMinimal.h"

class IManageObject {

public:
	virtual void SetManageClassName(FString name) = 0;
	virtual FString GetManageClassName() = 0;
};
