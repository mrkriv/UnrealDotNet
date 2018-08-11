#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageSpringArmComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

void UManageSpringArmComponent::UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
{
	Super::UpdateDesiredArmLocation(bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "UpdateDesiredArmLocation", bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
