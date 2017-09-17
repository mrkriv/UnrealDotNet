#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageSkinnedMeshComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void UManageSkinnedMeshComponent::ClearRefPoseOverride()
{
	Super::ClearRefPoseOverride();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ClearRefPoseOverride");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
