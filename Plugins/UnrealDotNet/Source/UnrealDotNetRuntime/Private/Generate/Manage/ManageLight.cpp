#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageLight.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

void AManageLight::OnRep_bEnabled()
{
	Super::OnRep_bEnabled();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_bEnabled");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
