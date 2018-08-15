#pragma once

#include "CoreMinimal.h"
#include "Framework/Commands/Commands.h"
#include "UDNStyle.h"

class FUDNCommands : public TCommands<FUDNCommands>
{
public:

	FUDNCommands()
		: TCommands<FUDNCommands>(TEXT("UnrealDotNet"), NSLOCTEXT("Contexts", "UnrealDotNet", "wtf?"), NAME_None, FUDNStyle::GetStyleSetName())
	{
	}

	virtual void RegisterCommands() override;

public:
	TSharedPtr<FUICommandInfo> PluginAction;
};
