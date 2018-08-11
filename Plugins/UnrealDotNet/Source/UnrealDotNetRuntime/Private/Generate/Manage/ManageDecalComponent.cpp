#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageDecalComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

void UManageDecalComponent::LifeSpanCallback()
{
	Super::LifeSpanCallback();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "LifeSpanCallback");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
