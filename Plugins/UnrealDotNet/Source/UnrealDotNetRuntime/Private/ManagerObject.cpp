#include "UnrealDotNetRuntime.h"
#include "ManagerObject.h"

static const float GC_TickTime = .5f;

UManagerObject::UManagerObject()
{
	if (GetWorld() == NULL)
		return;

	auto dlg = FTimerDelegate::CreateStatic(&UCoreShell::GC);
	GetWorld()->GetTimerManager().SetTimer(GCTimerHandle, dlg, GC_TickTime, true, 0);
}

