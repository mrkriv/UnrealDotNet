#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageLight.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void AManageLight::OnRep_bEnabled()
{
	Super::OnRep_bEnabled();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_bEnabled");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
