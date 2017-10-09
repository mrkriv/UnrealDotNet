#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageLight.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Light.h:13

void AManageLight::OnRep_bEnabled()
{
	Super::OnRep_bEnabled();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "OnRep_bEnabled");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
