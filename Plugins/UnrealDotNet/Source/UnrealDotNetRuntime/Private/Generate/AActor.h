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
	DOTNET_EXPORT float E_PROP_AActor_CustomTimeDilation_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->CustomTimeDilation; }
	DOTNET_EXPORT void E_PROP_AActor_CustomTimeDilation_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->CustomTimeDilation = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bHidden_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bHidden; }
	DOTNET_EXPORT void E_PROP_AActor_bHidden_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bHidden = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bNetTemporary_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bNetTemporary; }
	DOTNET_EXPORT void E_PROP_AActor_bNetTemporary_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bNetTemporary = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bNetStartup_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bNetStartup; }
	DOTNET_EXPORT void E_PROP_AActor_bNetStartup_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bNetStartup = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bOnlyRelevantToOwner_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bOnlyRelevantToOwner; }
	DOTNET_EXPORT void E_PROP_AActor_bOnlyRelevantToOwner_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bOnlyRelevantToOwner = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bAlwaysRelevant_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bAlwaysRelevant; }
	DOTNET_EXPORT void E_PROP_AActor_bAlwaysRelevant_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bAlwaysRelevant = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bReplicateMovement_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bReplicateMovement; }
	DOTNET_EXPORT void E_PROP_AActor_bReplicateMovement_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bReplicateMovement = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bTearOff_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bTearOff; }
	DOTNET_EXPORT void E_PROP_AActor_bTearOff_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bTearOff = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bExchangedRoles_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bExchangedRoles; }
	DOTNET_EXPORT void E_PROP_AActor_bExchangedRoles_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bExchangedRoles = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bPendingNetUpdate_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bPendingNetUpdate; }
	DOTNET_EXPORT void E_PROP_AActor_bPendingNetUpdate_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bPendingNetUpdate = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bNetLoadOnClient_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bNetLoadOnClient; }
	DOTNET_EXPORT void E_PROP_AActor_bNetLoadOnClient_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bNetLoadOnClient = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bNetUseOwnerRelevancy_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bNetUseOwnerRelevancy; }
	DOTNET_EXPORT void E_PROP_AActor_bNetUseOwnerRelevancy_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bNetUseOwnerRelevancy = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bBlockInput_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bBlockInput; }
	DOTNET_EXPORT void E_PROP_AActor_bBlockInput_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bBlockInput = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bRunningUserConstructionScript_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bRunningUserConstructionScript; }
	DOTNET_EXPORT void E_PROP_AActor_bRunningUserConstructionScript_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bRunningUserConstructionScript = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bAllowTickBeforeBeginPlay_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bAllowTickBeforeBeginPlay; }
	DOTNET_EXPORT void E_PROP_AActor_bAllowTickBeforeBeginPlay_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bAllowTickBeforeBeginPlay = Value; }
	
	DOTNET_EXPORT int32 E_PROP_AActor_InputPriority_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->InputPriority; }
	DOTNET_EXPORT void E_PROP_AActor_InputPriority_SET(INT_PTR Ptr, int32 Value) { ((AActor*)Ptr)->InputPriority = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_NetCullDistanceSquared_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetCullDistanceSquared; }
	DOTNET_EXPORT void E_PROP_AActor_NetCullDistanceSquared_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->NetCullDistanceSquared = Value; }
	
	DOTNET_EXPORT int32 E_PROP_AActor_NetTag_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetTag; }
	DOTNET_EXPORT void E_PROP_AActor_NetTag_SET(INT_PTR Ptr, int32 Value) { ((AActor*)Ptr)->NetTag = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_NetUpdateTime_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetUpdateTime; }
	DOTNET_EXPORT void E_PROP_AActor_NetUpdateTime_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->NetUpdateTime = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_NetUpdateFrequency_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetUpdateFrequency; }
	DOTNET_EXPORT void E_PROP_AActor_NetUpdateFrequency_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->NetUpdateFrequency = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_MinNetUpdateFrequency_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->MinNetUpdateFrequency; }
	DOTNET_EXPORT void E_PROP_AActor_MinNetUpdateFrequency_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->MinNetUpdateFrequency = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_NetPriority_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetPriority; }
	DOTNET_EXPORT void E_PROP_AActor_NetPriority_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->NetPriority = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_LastNetUpdateTime_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->LastNetUpdateTime; }
	DOTNET_EXPORT void E_PROP_AActor_LastNetUpdateTime_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->LastNetUpdateTime = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bAutoDestroyWhenFinished_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bAutoDestroyWhenFinished; }
	DOTNET_EXPORT void E_PROP_AActor_bAutoDestroyWhenFinished_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bAutoDestroyWhenFinished = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bCanBeDamaged_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bCanBeDamaged; }
	DOTNET_EXPORT void E_PROP_AActor_bCanBeDamaged_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bCanBeDamaged = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bCollideWhenPlacing_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bCollideWhenPlacing; }
	DOTNET_EXPORT void E_PROP_AActor_bCollideWhenPlacing_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bCollideWhenPlacing = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bFindCameraComponentWhenViewTarget_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bFindCameraComponentWhenViewTarget; }
	DOTNET_EXPORT void E_PROP_AActor_bFindCameraComponentWhenViewTarget_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bFindCameraComponentWhenViewTarget = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bRelevantForNetworkReplays_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bRelevantForNetworkReplays; }
	DOTNET_EXPORT void E_PROP_AActor_bRelevantForNetworkReplays_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bRelevantForNetworkReplays = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bGenerateOverlapEventsDuringLevelStreaming; }
	DOTNET_EXPORT void E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bGenerateOverlapEventsDuringLevelStreaming = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_CreationTime_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->CreationTime; }
	DOTNET_EXPORT void E_PROP_AActor_CreationTime_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->CreationTime = Value; }
	
	DOTNET_EXPORT APawn* E_PROP_AActor_Instigator_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->Instigator; }
	DOTNET_EXPORT void E_PROP_AActor_Instigator_SET(INT_PTR Ptr, APawn* Value) { ((AActor*)Ptr)->Instigator = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bActorSeamlessTraveled_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bActorSeamlessTraveled; }
	DOTNET_EXPORT void E_PROP_AActor_bActorSeamlessTraveled_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bActorSeamlessTraveled = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bIgnoresOriginShifting_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bIgnoresOriginShifting; }
	DOTNET_EXPORT void E_PROP_AActor_bIgnoresOriginShifting_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bIgnoresOriginShifting = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bEnableAutoLODGeneration_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bEnableAutoLODGeneration; }
	DOTNET_EXPORT void E_PROP_AActor_bEnableAutoLODGeneration_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bEnableAutoLODGeneration = Value; }
	
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

	DOTNET_EXPORT void E_AActor_SetNetDriverName(INT_PTR Self, char* NewNetDriverName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(NewNetDriverName));
		((AActor*)Self)->SetNetDriverName(_p0);
	}

	DOTNET_EXPORT char* E_AActor_GetNetDriverName(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((AActor*)Self)->GetNetDriverName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_AActor_OnSubobjectCreatedFromReplication(INT_PTR Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		((AActor*)Self)->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT float E_AActor_GetInputAxisValue(INT_PTR Self, char* InputAxisName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InputAxisName));
		return ((AActor*)Self)->GetInputAxisValue(_p0);
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

	DOTNET_EXPORT USceneComponent* E_AActor_K2_GetRootComponent(INT_PTR Self)
	{
		return ((AActor*)Self)->K2_GetRootComponent();
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

	DOTNET_EXPORT UActorComponent* E_AActor_AddComponent(INT_PTR Self, char* TemplateName, bool bManualAttachment, INT_PTR RelativeTransform, UObject* ComponentTemplateContext)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(TemplateName));
		auto _p1 = bManualAttachment;
		auto _p2 = *(FTransform*)RelativeTransform;
		auto _p3 = ComponentTemplateContext;
		return ((AActor*)Self)->AddComponent(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_AActor_K2_DestroyComponent(INT_PTR Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		((AActor*)Self)->K2_DestroyComponent(_p0);
	}

	DOTNET_EXPORT void E_AActor_SnapRootComponentTo(INT_PTR Self, AActor* InParentActor, char* InSocketName)
	{
		auto _p0 = InParentActor;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		((AActor*)Self)->SnapRootComponentTo(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_DetachSceneComponentsFromParent(INT_PTR Self, USceneComponent* InParentComponent, bool bMaintainWorldPosition)
	{
		auto _p0 = InParentComponent;
		auto _p1 = bMaintainWorldPosition;
		((AActor*)Self)->DetachSceneComponentsFromParent(_p0, _p1);
	}

	DOTNET_EXPORT bool E_AActor_ActorHasTag(INT_PTR Self, char* Tag)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(Tag));
		return ((AActor*)Self)->ActorHasTag(_p0);
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

	DOTNET_EXPORT void E_AActor_MakeNoise(INT_PTR Self, float Loudness, APawn* NoiseInstigator, INT_PTR NoiseLocation, float MaxRange, char* Tag)
	{
		auto _p0 = Loudness;
		auto _p1 = NoiseInstigator;
		auto _p2 = *(FVector*)NoiseLocation;
		auto _p3 = MaxRange;
		auto _p4 = FName(UTF8_TO_TCHAR(Tag));
		((AActor*)Self)->MakeNoise(_p0, _p1, _p2, _p3, _p4);
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

	DOTNET_EXPORT UPrimitiveComponent* E_AActor_GetRootPrimitiveComponent(INT_PTR Self)
	{
		return ((AActor*)Self)->GetRootPrimitiveComponent();
	}

	DOTNET_EXPORT bool E_AActor_SetRootComponent(INT_PTR Self, USceneComponent* NewRootComponent)
	{
		auto _p0 = NewRootComponent;
		return ((AActor*)Self)->SetRootComponent(_p0);
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

	DOTNET_EXPORT UPlayer* E_AActor_GetNetOwningPlayer(INT_PTR Self)
	{
		return ((AActor*)Self)->GetNetOwningPlayer();
	}

	DOTNET_EXPORT UChildActorComponent* E_AActor_GetParentComponent(INT_PTR Self)
	{
		return ((AActor*)Self)->GetParentComponent();
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

	DOTNET_EXPORT void E_AActor_DebugShowOneComponentHierarchy(INT_PTR Self, USceneComponent* SceneComp, int32 NestLevel, bool bShowPosition)
	{
		auto _p0 = SceneComp;
		auto _p1 = NestLevel;
		auto _p2 = bShowPosition;
		((AActor*)Self)->DebugShowOneComponentHierarchy(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_AActor_OnConstruction(INT_PTR Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		((AActor*)Self)->OnConstruction(_p0);
	}

}
