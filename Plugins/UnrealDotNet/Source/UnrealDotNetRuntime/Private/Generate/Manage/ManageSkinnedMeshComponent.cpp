#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageSkinnedMeshComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:182

void UManageSkinnedMeshComponent::ClearRefPoseOverride()
{
	Super::ClearRefPoseOverride();
	if(bIsManageAttach) UCoreShell::GetInstance()->InvokeInObject(this, "ClearRefPoseOverride");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
