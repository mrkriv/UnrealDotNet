#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageInterpToMovementComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:60

void UManageInterpToMovementComponent::UpdateControlPoints(bool InForceUpdate)
{
	Super::UpdateControlPoints(InForceUpdate);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateControlPoints", InForceUpdate);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
