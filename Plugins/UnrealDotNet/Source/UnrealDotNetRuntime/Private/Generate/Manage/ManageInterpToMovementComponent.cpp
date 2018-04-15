#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageInterpToMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:60

void UManageInterpToMovementComponent::UpdateControlPoints(bool InForceUpdate)
{
	Super::UpdateControlPoints(InForceUpdate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateControlPoints", InForceUpdate);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
