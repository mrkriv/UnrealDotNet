#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageDecalComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

void UManageDecalComponent::LifeSpanCallback()
{
	Super::LifeSpanCallback();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "LifeSpanCallback");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
