#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManageSkinnedMeshComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:182

void UManageSkinnedMeshComponent::ClearRefPoseOverride()
{
	Super::ClearRefPoseOverride();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearRefPoseOverride");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
