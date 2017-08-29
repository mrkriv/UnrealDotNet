#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"

class E_PROTECTED_WRAP_AActor : protected AActor
{
public:
	bool HasNetOwner_WRAP()
	{
		return HasNetOwner();
	}
}
;

extern "C"
{
	DOTNET_EXPORT void E_AActor_OnRep_ReplicateMovement(INT_PTR Self)
	{
		((AActor*)Self)->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT bool E_AActor_HasNetOwner(INT_PTR Self)
	{
		return ((E_PROTECTED_WRAP_AActor*)Self)->HasNetOwner_WRAP();
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

	DOTNET_EXPORT INT_PTR E_AActor_GetTransform(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((AActor*)Self)->GetTransform());
	}

	DOTNET_EXPORT INT_PTR E_AActor_K2_GetActorLocation(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->K2_GetActorLocation());
	}

	DOTNET_EXPORT INT_PTR E_AActor_K2_GetActorRotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((AActor*)Self)->K2_GetActorRotation());
	}

	DOTNET_EXPORT void E_AActor_GetActorBounds(INT_PTR Self, bool bOnlyCollidingComponents, INT_PTR Origin, INT_PTR BoxExtent)
	{
		auto _p0 = bOnlyCollidingComponents;
		auto _p1 = *(FVector*)Origin;
		auto _p2 = *(FVector*)BoxExtent;
		((AActor*)Self)->GetActorBounds(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_AActor_K2_SetActorRotation(INT_PTR Self, INT_PTR NewRotation, bool bTeleportPhysics)
	{
		auto _p0 = *(FRotator*)NewRotation;
		auto _p1 = bTeleportPhysics;
		return ((AActor*)Self)->K2_SetActorRotation(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_SetActorScale3D(INT_PTR Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		((AActor*)Self)->SetActorScale3D(_p0);
	}

	DOTNET_EXPORT float E_AActor_GetDistanceTo(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ((AActor*)Self)->GetDistanceTo(_p0);
	}

	DOTNET_EXPORT void E_AActor_K2_DestroyComponent(INT_PTR Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		((AActor*)Self)->K2_DestroyComponent(_p0);
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

	DOTNET_EXPORT INT_PTR E_AActor_GetActorQuat(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((AActor*)Self)->GetActorQuat());
	}

	DOTNET_EXPORT void E_AActor_ApplyWorldOffset(INT_PTR Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		((AActor*)Self)->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_RegisterAllActorTickFunctions(INT_PTR Self, bool bRegister, bool bDoComponents)
	{
		auto _p0 = bRegister;
		auto _p1 = bDoComponents;
		((AActor*)Self)->RegisterAllActorTickFunctions(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_PostNetReceiveVelocity(INT_PTR Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		((AActor*)Self)->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT AActor* E_AActor_GetOwner(INT_PTR Self)
	{
		return ((AActor*)Self)->GetOwner();
	}

	DOTNET_EXPORT bool E_AActor_IsReplayRelevantFor(INT_PTR Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation, float CullDistanceSquared)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
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

	DOTNET_EXPORT void E_AActor_PostSpawnInitialize(INT_PTR Self, INT_PTR SpawnTransform, AActor* InOwner, APawn* InInstigator, bool bRemoteOwned, bool bNoFail, bool bDeferConstruction)
	{
		auto _p0 = *(FTransform*)SpawnTransform;
		auto _p1 = InOwner;
		auto _p2 = InInstigator;
		auto _p3 = bRemoteOwned;
		auto _p4 = bNoFail;
		auto _p5 = bDeferConstruction;
		((AActor*)Self)->PostSpawnInitialize(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT bool E_AActor_IncrementalRegisterComponents(INT_PTR Self, int32 NumComponentsToRegister)
	{
		auto _p0 = NumComponentsToRegister;
		return ((AActor*)Self)->IncrementalRegisterComponents(_p0);
	}

	DOTNET_EXPORT bool E_AActor_TeleportTo(INT_PTR Self, INT_PTR DestLocation, INT_PTR DestRotation, bool bIsATest, bool bNoCheck)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		auto _p2 = bIsATest;
		auto _p3 = bNoCheck;
		return ((AActor*)Self)->TeleportTo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT bool E_AActor_K2_TeleportTo(INT_PTR Self, INT_PTR DestLocation, INT_PTR DestRotation)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		return ((AActor*)Self)->K2_TeleportTo(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_DebugShowComponentHierarchy(INT_PTR Self, char* Info, bool bShowPosition)
	{
		auto _p0 = UTF8_TO_TCHAR(Info);
		auto _p1 = bShowPosition;
		((AActor*)Self)->DebugShowComponentHierarchy(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_OnConstruction(INT_PTR Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		((AActor*)Self)->OnConstruction(_p0);
	}
}
