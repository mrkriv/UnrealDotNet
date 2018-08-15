#include "UDNCommands.h"

#define LOCTEXT_NAMESPACE "FUDNModule"

void FUDNCommands::RegisterCommands()
{
	UI_COMMAND(PluginAction, "Compile C#", "Compile C# project", EUserInterfaceActionType::Button, FInputGesture());
}

#undef LOCTEXT_NAMESPACE
