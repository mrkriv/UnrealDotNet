#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "Structures.h"

extern "C"
{
	DOTNET_EXPORT void E_AActor_OnRep_ReplicateMovement(INT_PTR Self)
	{
		((AActor*)Self)->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT void E_AActor_SetReplicates(INT_PTR Self, bool bInReplicates)
	{
		auto _p0 = bInReplicates;
		((AActor*)Self)->SetReplicates(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetAutonomousProxy(INT_PTR Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare)
	{
		auto _p0 = bInAutonomousProxy;
		auto _p1 = bAllowForcePropertyCompare;
		((AActor*)Self)->SetAutonomousProxy(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_CopyRemoteRoleFrom(INT_PTR Self, AActor* CopyFromActor)
	{
		auto _p0 = CopyFromActor;
		((AActor*)Self)->CopyRemoteRoleFrom(_p0);
	}

	DOTNET_EXPORT bool E_AActor_AllowReceiveTickEventOnDedicatedServer(INT_PTR Self)
	{
		return ((AActor*)Self)->AllowReceiveTickEventOnDedicatedServer();
	}

	DOTNET_EXPORT E_ST_FTransform E_AActor_GetTransform(INT_PTR Self)
	{
		return CONV_ST_FTransform_IN(((AActor*)Self)->GetTransform());
	}

	DOTNET_EXPORT E_ST_FVector E_AActor_K2_GetActorLocation(INT_PTR Self)
	{
		return CONV_ST_FVector_IN(((AActor*)Self)->K2_GetActorLocation());
	}

	DOTNET_EXPORT E_ST_FRotator E_AActor_K2_GetActorRotation(INT_PTR Self)
	{
		return CONV_ST_FRotator_IN(((AActor*)Self)->K2_GetActorRotation());
	}

	DOTNET_EXPORT void E_AActor_GetActorBounds(INT_PTR Self, bool bOnlyCollidingComponents, E_ST_FVector Origin, E_ST_FVector BoxExtent)
	{
		auto _p0 = bOnlyCollidingComponents;
		auto _p1 = CONV_ST_FVector_TO(Origin);
		auto _p2 = CONV_ST_FVector_TO(BoxExtent);
		((AActor*)Self)->GetActorBounds(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_AActor_K2_SetActorRotation(INT_PTR Self, E_ST_FRotator NewRotation, bool bTeleportPhysics)
	{
		auto _p0 = CONV_ST_FRotator_TO(NewRotation);
		auto _p1 = bTeleportPhysics;
		return ((AActor*)Self)->K2_SetActorRotation(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_SetActorScale3D(INT_PTR Self, E_ST_FVector NewScale3D)
	{
		auto _p0 = CONV_ST_FVector_TO(NewScale3D);
		((AActor*)Self)->SetActorScale3D(_p0);
	}

	DOTNET_EXPORT float E_AActor_GetDistanceTo(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ((AActor*)Self)->GetDistanceTo(_p0);
	}

	DOTNET_EXPORT float E_AActor_GetActorTimeDilation(INT_PTR Self)
	{
		return ((AActor*)Self)->GetActorTimeDilation();
	}

	DOTNET_EXPORT void E_AActor_SetTickPrerequisite(INT_PTR Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		((AActor*)Self)->SetTickPrerequisite(_p0);
	}

	DOTNET_EXPORT bool E_AActor_GetTickableWhenPaused(INT_PTR Self)
	{
		return ((AActor*)Self)->GetTickableWhenPaused();
	}

	DOTNET_EXPORT float E_AActor_GetGameTimeSinceCreation(INT_PTR Self)
	{
		return ((AActor*)Self)->GetGameTimeSinceCreation();
	}

	DOTNET_EXPORT void E_AActor_ReceiveTick(INT_PTR Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AActor*)Self)->ReceiveTick(_p0);
	}

	DOTNET_EXPORT bool E_AActor_Destroy(INT_PTR Self, bool bNetForce, bool bShouldModifyLevel)
	{
		auto _p0 = bNetForce;
		auto _p1 = bShouldModifyLevel;
		return ((AActor*)Self)->Destroy(_p0, _p1);
	}

	DOTNET_EXPORT bool E_AActor_IsOwnedBy(INT_PTR Self, AActor* TestOwner)
	{
		auto _p0 = TestOwner;
		return ((AActor*)Self)->IsOwnedBy(_p0);
	}

	DOTNET_EXPORT E_ST_FQuat E_AActor_GetActorQuat(INT_PTR Self)
	{
		return CONV_ST_FQuat_IN(((AActor*)Self)->GetActorQuat());
	}

	DOTNET_EXPORT void E_AActor_ApplyWorldOffset(INT_PTR Self, E_ST_FVector InOffset, bool bWorldShift)
	{
		auto _p0 = CONV_ST_FVector_TO(InOffset);
		auto _p1 = bWorldShift;
		((AActor*)Self)->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_RegisterAllActorTickFunctions(INT_PTR Self, bool bRegister, bool bDoComponents)
	{
		auto _p0 = bRegister;
		auto _p1 = bDoComponents;
		((AActor*)Self)->RegisterAllActorTickFunctions(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_PostNetReceiveVelocity(INT_PTR Self, E_ST_FVector NewVelocity)
	{
		auto _p0 = CONV_ST_FVector_TO(NewVelocity);
		((AActor*)Self)->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT AActor* E_AActor_GetOwner(INT_PTR Self)
	{
		return ((AActor*)Self)->GetOwner();
	}

	DOTNET_EXPORT bool E_AActor_IsReplayRelevantFor(INT_PTR Self, AActor* RealViewer, AActor* ViewTarget, E_ST_FVector SrcLocation, float CullDistanceSquared)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = CONV_ST_FVector_TO(SrcLocation);
		auto _p3 = CullDistanceSquared;
		return ((AActor*)Self)->IsReplayRelevantFor(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT bool E_AActor_IsRelevancyOwnerFor(INT_PTR Self, AActor* ReplicatedActor, AActor* ActorOwner, AActor* ConnectionActor)
	{
		auto _p0 = ReplicatedActor;
		auto _p1 = ActorOwner;
		auto _p2 = ConnectionActor;
		return ((AActor*)Self)->IsRelevancyOwnerFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_AActor_IncrementalRegisterComponents(INT_PTR Self, int32 NumComponentsToRegister)
	{
		auto _p0 = NumComponentsToRegister;
		return ((AActor*)Self)->IncrementalRegisterComponents(_p0);
	}

	DOTNET_EXPORT bool E_AActor_TeleportTo(INT_PTR Self, E_ST_FVector DestLocation, E_ST_FRotator DestRotation, bool bIsATest, bool bNoCheck)
	{
		auto _p0 = CONV_ST_FVector_TO(DestLocation);
		auto _p1 = CONV_ST_FRotator_TO(DestRotation);
		auto _p2 = bIsATest;
		auto _p3 = bNoCheck;
		return ((AActor*)Self)->TeleportTo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT bool E_AActor_K2_TeleportTo(INT_PTR Self, E_ST_FVector DestLocation, E_ST_FRotator DestRotation)
	{
		auto _p0 = CONV_ST_FVector_TO(DestLocation);
		auto _p1 = CONV_ST_FRotator_TO(DestRotation);
		return ((AActor*)Self)->K2_TeleportTo(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_DebugShowComponentHierarchy(INT_PTR Self, char* Info, bool bShowPosition)
	{
		auto _p0 = UTF8_TO_TCHAR(Info);
		auto _p1 = bShowPosition;
		((AActor*)Self)->DebugShowComponentHierarchy(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_OnConstruction(INT_PTR Self, E_ST_FTransform Transform)
	{
		auto _p0 = CONV_ST_FTransform_TO(Transform);
		((AActor*)Self)->OnConstruction(_p0);
	}

}
