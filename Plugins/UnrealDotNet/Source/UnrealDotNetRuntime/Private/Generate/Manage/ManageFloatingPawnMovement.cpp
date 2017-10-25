#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageFloatingPawnMovement.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\FloatingPawnMovement.h:22

void UManageFloatingPawnMovement::ApplyControlInputToVelocity(float DeltaTime)
{
	Super::ApplyControlInputToVelocity(DeltaTime);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "ApplyControlInputToVelocity", DeltaTime);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
