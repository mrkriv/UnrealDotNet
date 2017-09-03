#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageStaticMeshComponent.h"

bool UManageStaticMeshComponent::SetStaticLightingMapping(bool bTextureMapping, int32 ResolutionToUse)
{
	if (bIsManageAttach) UCoreShell::InvokeInObject(this, "SetStaticLightingMapping");
	return Super::SetStaticLightingMapping(bTextureMapping, ResolutionToUse);
}

bool UManageStaticMeshComponent::SupportsDefaultCollision()
{
	if (bIsManageAttach) UCoreShell::InvokeInObject(this, "SupportsDefaultCollision");
	return Super::SupportsDefaultCollision();
}

bool UManageStaticMeshComponent::SupportsDitheredLODTransitions()
{
	if (bIsManageAttach) UCoreShell::InvokeInObject(this, "SupportsDitheredLODTransitions");
	return Super::SupportsDitheredLODTransitions();
}

