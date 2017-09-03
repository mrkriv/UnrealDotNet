#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageSpringArmComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void UManageSpringArmComponent::UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
{
	Super::UpdateDesiredArmLocation(bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "UpdateDesiredArmLocation", bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
