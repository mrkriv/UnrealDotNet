#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManageWorldSettings.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:278

void AManageWorldSettings::NotifyBeginPlay()
{
	Super::NotifyBeginPlay();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyBeginPlay");
}

void AManageWorldSettings::NotifyMatchStarted()
{
	Super::NotifyMatchStarted();
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "NotifyMatchStarted");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
