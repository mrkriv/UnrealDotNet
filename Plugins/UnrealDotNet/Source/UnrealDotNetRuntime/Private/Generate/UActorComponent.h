#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UActorComponent_DetermineUCSModifiedProperties(INT_PTR Self)
	{
		((UActorComponent*)Self)->DetermineUCSModifiedProperties();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsEditableWhenInherited(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsEditableWhenInherited();
	}

	DOTNET_EXPORT AActor* E_UActorComponent_GetOwner(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->GetOwner();
	}

	DOTNET_EXPORT void E_UActorComponent_Activate(INT_PTR Self, bool bReset)
	{
		auto _p0 = bReset;
		((UActorComponent*)Self)->Activate(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetActive(INT_PTR Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UActorComponent*)Self)->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT void E_UActorComponent_SetIsNetStartupComponent(INT_PTR Self, bool bInIsNetStartupComponent)
	{
		auto _p0 = bInIsNetStartupComponent;
		((UActorComponent*)Self)->SetIsNetStartupComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetComponentTickInterval(INT_PTR Self, float TickInterval)
	{
		auto _p0 = TickInterval;
		((UActorComponent*)Self)->SetComponentTickInterval(_p0);
	}

	DOTNET_EXPORT float E_UActorComponent_GetComponentTickInterval(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->GetComponentTickInterval();
	}

	DOTNET_EXPORT void E_UActorComponent_RegisterComponentWithWorld(INT_PTR Self, UWorld* InWorld)
	{
		auto _p0 = InWorld;
		((UActorComponent*)Self)->RegisterComponentWithWorld(_p0);
	}

	DOTNET_EXPORT bool E_UActorComponent_ComponentIsInPersistentLevel(INT_PTR Self, bool bIncludeLevelStreamingPersistent)
	{
		auto _p0 = bIncludeLevelStreamingPersistent;
		return ((UActorComponent*)Self)->ComponentIsInPersistentLevel(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_AddTickPrerequisiteActor(INT_PTR Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		((UActorComponent*)Self)->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_AddTickPrerequisiteComponent(INT_PTR Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		((UActorComponent*)Self)->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_ApplyWorldOffset(INT_PTR Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		((UActorComponent*)Self)->ApplyWorldOffset(_p0, _p1);
	}

}
