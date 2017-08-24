#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "FVector.h"


extern "C"
{
	DOTNET_EXPORT void E_OnRep_ReplicateMovement(INT_PTR Self)
	{
		((AActor*)Self)->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT void E_SetReplicates(INT_PTR Self, bool bInReplicates)
	{
		auto _p0 = bInReplicates;
		((AActor*)Self)->SetReplicates(_p0);
	}

	DOTNET_EXPORT void E_SetAutonomousProxy(INT_PTR Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare)
	{
		auto _p0 = bInAutonomousProxy;
		auto _p1 = bAllowForcePropertyCompare;
		((AActor*)Self)->SetAutonomousProxy(_p0, _p1);
	}

	DOTNET_EXPORT void E_CopyRemoteRoleFrom(INT_PTR Self, AActor* CopyFromActor)
	{
		auto _p0 = CopyFromActor;
		((AActor*)Self)->CopyRemoteRoleFrom(_p0);
	}

	DOTNET_EXPORT void E_OnSubobjectCreatedFromReplication(INT_PTR Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		((AActor*)Self)->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT bool E_AllowReceiveTickEventOnDedicatedServer(INT_PTR Self)
	{
		return ((AActor*)Self)->AllowReceiveTickEventOnDedicatedServer();
	}

	DOTNET_EXPORT E_ST_FVector E_K2_GetActorLocation(INT_PTR Self)
	{
		return CONV_ST_FVector_IN(((AActor*)Self)->K2_GetActorLocation());
	}

	DOTNET_EXPORT void E_GetActorBounds(INT_PTR Self, bool bOnlyCollidingComponents, E_ST_FVector Origin, E_ST_FVector BoxExtent)
	{
		auto _p0 = bOnlyCollidingComponents;
		auto _p1 = CONV_ST_FVector_TO(Origin);
		auto _p2 = CONV_ST_FVector_TO(BoxExtent);
		((AActor*)Self)->GetActorBounds(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_SetActorScale3D(INT_PTR Self, E_ST_FVector NewScale3D)
	{
		auto _p0 = CONV_ST_FVector_TO(NewScale3D);
		((AActor*)Self)->SetActorScale3D(_p0);
	}

	DOTNET_EXPORT float E_GetDistanceTo(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ((AActor*)Self)->GetDistanceTo(_p0);
	}

	DOTNET_EXPORT float E_GetActorTimeDilation(INT_PTR Self)
	{
		return ((AActor*)Self)->GetActorTimeDilation();
	}

	DOTNET_EXPORT void E_SetTickPrerequisite(INT_PTR Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		((AActor*)Self)->SetTickPrerequisite(_p0);
	}

	DOTNET_EXPORT bool E_GetTickableWhenPaused(INT_PTR Self)
	{
		return ((AActor*)Self)->GetTickableWhenPaused();
	}

	DOTNET_EXPORT float E_GetGameTimeSinceCreation(INT_PTR Self)
	{
		return ((AActor*)Self)->GetGameTimeSinceCreation();
	}

	DOTNET_EXPORT void E_ReceiveTick(INT_PTR Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AActor*)Self)->ReceiveTick(_p0);
	}

	DOTNET_EXPORT bool E_Destroy(INT_PTR Self, bool bNetForce, bool bShouldModifyLevel)
	{
		auto _p0 = bNetForce;
		auto _p1 = bShouldModifyLevel;
		return ((AActor*)Self)->Destroy(_p0, _p1);
	}

	DOTNET_EXPORT bool E_IsOwnedBy(INT_PTR Self, AActor* TestOwner)
	{
		auto _p0 = TestOwner;
		return ((AActor*)Self)->IsOwnedBy(_p0);
	}

	DOTNET_EXPORT void E_ApplyWorldOffset(INT_PTR Self, E_ST_FVector InOffset, bool bWorldShift)
	{
		auto _p0 = CONV_ST_FVector_TO(InOffset);
		auto _p1 = bWorldShift;
		((AActor*)Self)->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT void E_RegisterAllActorTickFunctions(INT_PTR Self, bool bRegister, bool bDoComponents)
	{
		auto _p0 = bRegister;
		auto _p1 = bDoComponents;
		((AActor*)Self)->RegisterAllActorTickFunctions(_p0, _p1);
	}

	DOTNET_EXPORT void E_PostNetReceiveVelocity(INT_PTR Self, E_ST_FVector NewVelocity)
	{
		auto _p0 = CONV_ST_FVector_TO(NewVelocity);
		((AActor*)Self)->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT AActor* E_GetOwner(INT_PTR Self)
	{
		return ((AActor*)Self)->GetOwner();
	}

	DOTNET_EXPORT bool E_IsReplayRelevantFor(INT_PTR Self, AActor* RealViewer, AActor* ViewTarget, E_ST_FVector SrcLocation, float CullDistanceSquared)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = CONV_ST_FVector_TO(SrcLocation);
		auto _p3 = CullDistanceSquared;
		return ((AActor*)Self)->IsReplayRelevantFor(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT bool E_IsRelevancyOwnerFor(INT_PTR Self, AActor* ReplicatedActor, AActor* ActorOwner, AActor* ConnectionActor)
	{
		auto _p0 = ReplicatedActor;
		auto _p1 = ActorOwner;
		auto _p2 = ConnectionActor;
		return ((AActor*)Self)->IsRelevancyOwnerFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_IncrementalRegisterComponents(INT_PTR Self, int32 NumComponentsToRegister)
	{
		auto _p0 = NumComponentsToRegister;
		return ((AActor*)Self)->IncrementalRegisterComponents(_p0);
	}

	DOTNET_EXPORT void E_DebugShowComponentHierarchy(INT_PTR Self, char* Info, bool bShowPosition)
	{
		auto _p0 = UTF8_TO_TCHAR(Info);
		auto _p1 = bShowPosition;
		((AActor*)Self)->DebugShowComponentHierarchy(_p0, _p1);
	}

}
