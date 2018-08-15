#pragma once

#include "Engine.h"
#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"
#include "IPlacementModeModule.h"

class FUICommandList;
class FToolBarBuilder;
class FMenuBuilder;
class FExtender;

class FUnrealDotNetEditorModule : public IModuleInterface
{
	TSharedPtr<FUICommandList> PluginCommands;
	TArray<FPlacementModeID> PlacementModeIDs;
	TSharedPtr<FExtender> ToolbarCompileButton;

public:
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;

	void CompileButtonClicked();
	void OnHostReload();
	void AddToolbarExtension(FToolBarBuilder& Builder);
	void AddMenuExtension(FMenuBuilder& Builder);
};
