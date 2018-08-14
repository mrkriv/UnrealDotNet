#pragma once

#include "Engine.h"
#include "CoreMinimal.h"
#include "IPlacementModeModule.h"

class FUnrealDotNetEditorModule : public IModuleInterface
{
	TArray<FPlacementModeID> PlacementModeIDs;

public:
	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;

	void OnHostReload();
};
