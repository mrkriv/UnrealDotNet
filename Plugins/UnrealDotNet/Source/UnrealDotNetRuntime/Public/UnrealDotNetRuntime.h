#pragma once

#include "Engine.h"
#include "CoreMinimal.h"

class FUnrealDotNetRuntimeModule : public IModuleInterface
{
public:
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
