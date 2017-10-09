#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageShapeComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ShapeComponent.h:24

void UManageShapeComponent::UpdateBodySetup()
{
	Super::UpdateBodySetup();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateBodySetup");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
