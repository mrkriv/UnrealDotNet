#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"

class E_PROTECTED_WRAP_AActor : protected AActor
{
public:
	void BeginPlay_WRAP()
	{
		BeginPlay();
	}

	void OnRep_Owner_WRAP()
	{
		OnRep_Owner();
	}

	void ReceiveBeginPlay_WRAP()
	{
		ReceiveBeginPlay();
	}

	void SyncReplicatedPhysicsSimulation_WRAP()
	{
		SyncReplicatedPhysicsSimulation();
	}

}
;

extern "C"
{
	DOTNET_EXPORT uint8 E_PROP_AActor_bActorSeamlessTraveled_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bActorSeamlessTraveled; }
	DOTNET_EXPORT void E_PROP_AActor_bActorSeamlessTraveled_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bActorSeamlessTraveled = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bAllowTickBeforeBeginPlay_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bAllowTickBeforeBeginPlay; }
	DOTNET_EXPORT void E_PROP_AActor_bAllowTickBeforeBeginPlay_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bAllowTickBeforeBeginPlay = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bAlwaysRelevant_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bAlwaysRelevant; }
	DOTNET_EXPORT void E_PROP_AActor_bAlwaysRelevant_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bAlwaysRelevant = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bAutoDestroyWhenFinished_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bAutoDestroyWhenFinished; }
	DOTNET_EXPORT void E_PROP_AActor_bAutoDestroyWhenFinished_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bAutoDestroyWhenFinished = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bBlockInput_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bBlockInput; }
	DOTNET_EXPORT void E_PROP_AActor_bBlockInput_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bBlockInput = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bCanBeDamaged_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bCanBeDamaged; }
	DOTNET_EXPORT void E_PROP_AActor_bCanBeDamaged_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bCanBeDamaged = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bCollideWhenPlacing_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bCollideWhenPlacing; }
	DOTNET_EXPORT void E_PROP_AActor_bCollideWhenPlacing_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bCollideWhenPlacing = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bEnableAutoLODGeneration_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bEnableAutoLODGeneration; }
	DOTNET_EXPORT void E_PROP_AActor_bEnableAutoLODGeneration_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bEnableAutoLODGeneration = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bExchangedRoles_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bExchangedRoles; }
	DOTNET_EXPORT void E_PROP_AActor_bExchangedRoles_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bExchangedRoles = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bFindCameraComponentWhenViewTarget_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bFindCameraComponentWhenViewTarget; }
	DOTNET_EXPORT void E_PROP_AActor_bFindCameraComponentWhenViewTarget_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bFindCameraComponentWhenViewTarget = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bGenerateOverlapEventsDuringLevelStreaming; }
	DOTNET_EXPORT void E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bGenerateOverlapEventsDuringLevelStreaming = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bHidden_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bHidden; }
	DOTNET_EXPORT void E_PROP_AActor_bHidden_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bHidden = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bIgnoresOriginShifting_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bIgnoresOriginShifting; }
	DOTNET_EXPORT void E_PROP_AActor_bIgnoresOriginShifting_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bIgnoresOriginShifting = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bNetLoadOnClient_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bNetLoadOnClient; }
	DOTNET_EXPORT void E_PROP_AActor_bNetLoadOnClient_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bNetLoadOnClient = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bNetStartup_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bNetStartup; }
	DOTNET_EXPORT void E_PROP_AActor_bNetStartup_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bNetStartup = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bNetTemporary_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bNetTemporary; }
	DOTNET_EXPORT void E_PROP_AActor_bNetTemporary_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bNetTemporary = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bNetUseOwnerRelevancy_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bNetUseOwnerRelevancy; }
	DOTNET_EXPORT void E_PROP_AActor_bNetUseOwnerRelevancy_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bNetUseOwnerRelevancy = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bOnlyRelevantToOwner_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bOnlyRelevantToOwner; }
	DOTNET_EXPORT void E_PROP_AActor_bOnlyRelevantToOwner_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bOnlyRelevantToOwner = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bPendingNetUpdate_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bPendingNetUpdate; }
	DOTNET_EXPORT void E_PROP_AActor_bPendingNetUpdate_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bPendingNetUpdate = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bRelevantForNetworkReplays_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bRelevantForNetworkReplays; }
	DOTNET_EXPORT void E_PROP_AActor_bRelevantForNetworkReplays_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bRelevantForNetworkReplays = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bReplicateMovement_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bReplicateMovement; }
	DOTNET_EXPORT void E_PROP_AActor_bReplicateMovement_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bReplicateMovement = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bRunningUserConstructionScript_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bRunningUserConstructionScript; }
	DOTNET_EXPORT void E_PROP_AActor_bRunningUserConstructionScript_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bRunningUserConstructionScript = Value; }
	
	DOTNET_EXPORT uint8 E_PROP_AActor_bTearOff_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->bTearOff; }
	DOTNET_EXPORT void E_PROP_AActor_bTearOff_SET(INT_PTR Ptr, uint8 Value) { ((AActor*)Ptr)->bTearOff = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_CreationTime_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->CreationTime; }
	DOTNET_EXPORT void E_PROP_AActor_CreationTime_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->CreationTime = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_CustomTimeDilation_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->CustomTimeDilation; }
	DOTNET_EXPORT void E_PROP_AActor_CustomTimeDilation_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->CustomTimeDilation = Value; }
	
	DOTNET_EXPORT int32 E_PROP_AActor_InputPriority_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->InputPriority; }
	DOTNET_EXPORT void E_PROP_AActor_InputPriority_SET(INT_PTR Ptr, int32 Value) { ((AActor*)Ptr)->InputPriority = Value; }
	
	DOTNET_EXPORT APawn* E_PROP_AActor_Instigator_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->Instigator; }
	DOTNET_EXPORT void E_PROP_AActor_Instigator_SET(INT_PTR Ptr, APawn* Value) { ((AActor*)Ptr)->Instigator = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_LastNetUpdateTime_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->LastNetUpdateTime; }
	DOTNET_EXPORT void E_PROP_AActor_LastNetUpdateTime_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->LastNetUpdateTime = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_MinNetUpdateFrequency_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->MinNetUpdateFrequency; }
	DOTNET_EXPORT void E_PROP_AActor_MinNetUpdateFrequency_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->MinNetUpdateFrequency = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_NetCullDistanceSquared_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetCullDistanceSquared; }
	DOTNET_EXPORT void E_PROP_AActor_NetCullDistanceSquared_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->NetCullDistanceSquared = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_NetPriority_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetPriority; }
	DOTNET_EXPORT void E_PROP_AActor_NetPriority_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->NetPriority = Value; }
	
	DOTNET_EXPORT int32 E_PROP_AActor_NetTag_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetTag; }
	DOTNET_EXPORT void E_PROP_AActor_NetTag_SET(INT_PTR Ptr, int32 Value) { ((AActor*)Ptr)->NetTag = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_NetUpdateFrequency_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetUpdateFrequency; }
	DOTNET_EXPORT void E_PROP_AActor_NetUpdateFrequency_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->NetUpdateFrequency = Value; }
	
	DOTNET_EXPORT float E_PROP_AActor_NetUpdateTime_GET(INT_PTR Ptr) { return ((AActor*)Ptr)->NetUpdateTime; }
	DOTNET_EXPORT void E_PROP_AActor_NetUpdateTime_SET(INT_PTR Ptr, float Value) { ((AActor*)Ptr)->NetUpdateTime = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_AActor_PrimaryActorTick_GET(INT_PTR Ptr) { return (INT_PTR)&((AActor*)Ptr)->PrimaryActorTick; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AActor(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AActor>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT bool E_AActor_ActorHasTag(INT_PTR Self, char* Tag)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(Tag));
		return ((AActor*)Self)->ActorHasTag(_p0);
	}

	DOTNET_EXPORT INT_PTR E_AActor_ActorToWorld(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((AActor*)Self)->ActorToWorld());
	}

	DOTNET_EXPORT UActorComponent* E_AActor_AddComponent(INT_PTR Self, char* TemplateName, bool bManualAttachment, INT_PTR RelativeTransform, UObject* ComponentTemplateContext)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(TemplateName));
		auto _p1 = bManualAttachment;
		auto _p2 = *(FTransform*)RelativeTransform;
		auto _p3 = ComponentTemplateContext;
		return ((AActor*)Self)->AddComponent(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT void E_AActor_AddTickPrerequisiteActor(INT_PTR Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		((AActor*)Self)->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT void E_AActor_AddTickPrerequisiteComponent(INT_PTR Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		((AActor*)Self)->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT bool E_AActor_AllowReceiveTickEventOnDedicatedServer(INT_PTR Self)
	{
		return ((AActor*)Self)->AllowReceiveTickEventOnDedicatedServer();
	}

	DOTNET_EXPORT void E_AActor_ApplyWorldOffset(INT_PTR Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		((AActor*)Self)->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_AttachToActor(INT_PTR Self, AActor* ParentActor, INT_PTR AttachmentRules, char* SocketName)
	{
		auto _p0 = ParentActor;
		auto _p1 = *(FAttachmentTransformRules*)AttachmentRules;
		auto _p2 = FName(UTF8_TO_TCHAR(SocketName));
		((AActor*)Self)->AttachToActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_AActor_AttachToComponent(INT_PTR Self, USceneComponent* Parent, INT_PTR AttachmentRules, char* SocketName)
	{
		auto _p0 = Parent;
		auto _p1 = *(FAttachmentTransformRules*)AttachmentRules;
		auto _p2 = FName(UTF8_TO_TCHAR(SocketName));
		((AActor*)Self)->AttachToComponent(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_AActor_BeginPlay(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_AActor*)Self)->BeginPlay_WRAP();
	}

	DOTNET_EXPORT bool E_AActor_CanEverTick(INT_PTR Self)
	{
		return ((AActor*)Self)->CanEverTick();
	}

	DOTNET_EXPORT void E_AActor_ClearComponentOverlaps(INT_PTR Self)
	{
		((AActor*)Self)->ClearComponentOverlaps();
	}

	DOTNET_EXPORT void E_AActor_ClearCrossLevelReferences(INT_PTR Self)
	{
		((AActor*)Self)->ClearCrossLevelReferences();
	}

	DOTNET_EXPORT void E_AActor_CopyRemoteRoleFrom(INT_PTR Self, AActor* CopyFromActor)
	{
		auto _p0 = CopyFromActor;
		((AActor*)Self)->CopyRemoteRoleFrom(_p0);
	}

	DOTNET_EXPORT void E_AActor_DebugShowOneComponentHierarchy(INT_PTR Self, USceneComponent* SceneComp, int32 NestLevel, bool bShowPosition)
	{
		auto _p0 = SceneComp;
		auto _p1 = NestLevel;
		auto _p2 = bShowPosition;
		((AActor*)Self)->DebugShowOneComponentHierarchy(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_AActor_Destroy(INT_PTR Self, bool bNetForce, bool bShouldModifyLevel)
	{
		auto _p0 = bNetForce;
		auto _p1 = bShouldModifyLevel;
		return ((AActor*)Self)->Destroy(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_DestroyConstructedComponents(INT_PTR Self)
	{
		((AActor*)Self)->DestroyConstructedComponents();
	}

	DOTNET_EXPORT void E_AActor_DetachAllSceneComponents(INT_PTR Self, USceneComponent* InParentComponent, INT_PTR DetachmentRules)
	{
		auto _p0 = InParentComponent;
		auto _p1 = *(FDetachmentTransformRules*)DetachmentRules;
		((AActor*)Self)->DetachAllSceneComponents(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_DetachFromActor(INT_PTR Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		((AActor*)Self)->DetachFromActor(_p0);
	}

	DOTNET_EXPORT void E_AActor_DetachRootComponentFromParent(INT_PTR Self, bool bMaintainWorldPosition)
	{
		auto _p0 = bMaintainWorldPosition;
		((AActor*)Self)->DetachRootComponentFromParent(_p0);
	}

	DOTNET_EXPORT void E_AActor_DetachSceneComponentsFromParent(INT_PTR Self, USceneComponent* InParentComponent, bool bMaintainWorldPosition)
	{
		auto _p0 = InParentComponent;
		auto _p1 = bMaintainWorldPosition;
		((AActor*)Self)->DetachSceneComponentsFromParent(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_DispatchBeginPlay(INT_PTR Self)
	{
		((AActor*)Self)->DispatchBeginPlay();
	}

	DOTNET_EXPORT void E_AActor_ExchangeNetRoles(INT_PTR Self, bool bRemoteOwner)
	{
		auto _p0 = bRemoteOwner;
		((AActor*)Self)->ExchangeNetRoles(_p0);
	}

	DOTNET_EXPORT void E_AActor_FinishAndRegisterComponent(INT_PTR Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		((AActor*)Self)->FinishAndRegisterComponent(_p0);
	}

	DOTNET_EXPORT void E_AActor_FlushNetDormancy(INT_PTR Self)
	{
		((AActor*)Self)->FlushNetDormancy();
	}

	DOTNET_EXPORT void E_AActor_ForcePropertyCompare(INT_PTR Self)
	{
		((AActor*)Self)->ForcePropertyCompare();
	}

	DOTNET_EXPORT void E_AActor_GatherCurrentMovement(INT_PTR Self)
	{
		((AActor*)Self)->GatherCurrentMovement();
	}

	DOTNET_EXPORT void E_AActor_GetActorBounds(INT_PTR Self, bool bOnlyCollidingComponents, INT_PTR Origin, INT_PTR BoxExtent)
	{
		auto _p0 = bOnlyCollidingComponents;
		auto _p1 = *(FVector*)Origin;
		auto _p2 = *(FVector*)BoxExtent;
		((AActor*)Self)->GetActorBounds(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_AActor_GetActorEnableCollision(INT_PTR Self)
	{
		return ((AActor*)Self)->GetActorEnableCollision();
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorForwardVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->GetActorForwardVector());
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorLocation(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->GetActorLocation());
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorQuat(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((AActor*)Self)->GetActorQuat());
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorRelativeScale3D(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->GetActorRelativeScale3D());
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorRightVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->GetActorRightVector());
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorRotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((AActor*)Self)->GetActorRotation());
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorScale(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->GetActorScale());
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorScale3D(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->GetActorScale3D());
	}

	DOTNET_EXPORT float E_AActor_GetActorTickInterval(INT_PTR Self)
	{
		return ((AActor*)Self)->GetActorTickInterval();
	}

	DOTNET_EXPORT float E_AActor_GetActorTimeDilation(INT_PTR Self)
	{
		return ((AActor*)Self)->GetActorTimeDilation();
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorTransform(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((AActor*)Self)->GetActorTransform());
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetActorUpVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->GetActorUpVector());
	}

	DOTNET_EXPORT float E_AActor_GetDistanceTo(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ((AActor*)Self)->GetDistanceTo(_p0);
	}

	DOTNET_EXPORT float E_AActor_GetDotProductTo(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ((AActor*)Self)->GetDotProductTo(_p0);
	}

	DOTNET_EXPORT float E_AActor_GetGameTimeSinceCreation(INT_PTR Self)
	{
		return ((AActor*)Self)->GetGameTimeSinceCreation();
	}

	DOTNET_EXPORT float E_AActor_GetHorizontalDistanceTo(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ((AActor*)Self)->GetHorizontalDistanceTo(_p0);
	}

	DOTNET_EXPORT float E_AActor_GetHorizontalDotProductTo(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ((AActor*)Self)->GetHorizontalDotProductTo(_p0);
	}

	DOTNET_EXPORT float E_AActor_GetInputAxisValue(INT_PTR Self, char* InputAxisName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InputAxisName));
		return ((AActor*)Self)->GetInputAxisValue(_p0);
	}

	DOTNET_EXPORT char* E_AActor_GetNetDriverName(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((AActor*)Self)->GetNetDriverName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT ENetMode E_AActor_GetNetMode(INT_PTR Self)
	{
		return ((AActor*)Self)->GetNetMode();
	}

	DOTNET_EXPORT AActor* E_AActor_GetOwner(INT_PTR Self)
	{
		return ((AActor*)Self)->GetOwner();
	}

	DOTNET_EXPORT AActor* E_AActor_GetParentActor(INT_PTR Self)
	{
		return ((AActor*)Self)->GetParentActor();
	}

	DOTNET_EXPORT UChildActorComponent* E_AActor_GetParentComponent(INT_PTR Self)
	{
		return ((AActor*)Self)->GetParentComponent();
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetPlacementExtent(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->GetPlacementExtent());
	}

	DOTNET_EXPORT USceneComponent* E_AActor_GetRootComponent(INT_PTR Self)
	{
		return ((AActor*)Self)->GetRootComponent();
	}

	DOTNET_EXPORT UPrimitiveComponent* E_AActor_GetRootPrimitiveComponent(INT_PTR Self)
	{
		return ((AActor*)Self)->GetRootPrimitiveComponent();
	}

	DOTNET_EXPORT float E_AActor_GetSquaredDistanceTo(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ((AActor*)Self)->GetSquaredDistanceTo(_p0);
	}

	DOTNET_EXPORT bool E_AActor_GetTickableWhenPaused(INT_PTR Self)
	{
		return ((AActor*)Self)->GetTickableWhenPaused();
	}

	DOTNET_EXPORT INT_PTR E_AActor_GetTransform(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((AActor*)Self)->GetTransform());
	}

	DOTNET_EXPORT float E_AActor_GetVerticalDistanceTo(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ((AActor*)Self)->GetVerticalDistanceTo(_p0);
	}

	DOTNET_EXPORT bool E_AActor_HasActorBegunPlay(INT_PTR Self)
	{
		return ((AActor*)Self)->HasActorBegunPlay();
	}

	DOTNET_EXPORT bool E_AActor_HasAuthority(INT_PTR Self)
	{
		return ((AActor*)Self)->HasAuthority();
	}

	DOTNET_EXPORT bool E_AActor_HasDeferredComponentRegistration(INT_PTR Self)
	{
		return ((AActor*)Self)->HasDeferredComponentRegistration();
	}

	DOTNET_EXPORT bool E_AActor_HasValidRootComponent(INT_PTR Self)
	{
		return ((AActor*)Self)->HasValidRootComponent();
	}

	DOTNET_EXPORT bool E_AActor_IncrementalRegisterComponents(INT_PTR Self, int32 NumComponentsToRegister)
	{
		auto _p0 = NumComponentsToRegister;
		return ((AActor*)Self)->IncrementalRegisterComponents(_p0);
	}

	DOTNET_EXPORT void E_AActor_InitializeComponents(INT_PTR Self)
	{
		((AActor*)Self)->InitializeComponents();
	}

	DOTNET_EXPORT void E_AActor_InvalidateLightingCache(INT_PTR Self)
	{
		((AActor*)Self)->InvalidateLightingCache();
	}

	DOTNET_EXPORT void E_AActor_InvalidateLightingCacheDetailed(INT_PTR Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AActor*)Self)->InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT bool E_AActor_IsActorBeginningPlay(INT_PTR Self)
	{
		return ((AActor*)Self)->IsActorBeginningPlay();
	}

	DOTNET_EXPORT bool E_AActor_IsActorBeingDestroyed(INT_PTR Self)
	{
		return ((AActor*)Self)->IsActorBeingDestroyed();
	}

	DOTNET_EXPORT bool E_AActor_IsActorInitialized(INT_PTR Self)
	{
		return ((AActor*)Self)->IsActorInitialized();
	}

	DOTNET_EXPORT bool E_AActor_IsActorTickEnabled(INT_PTR Self)
	{
		return ((AActor*)Self)->IsActorTickEnabled();
	}

	DOTNET_EXPORT bool E_AActor_IsChildActor(INT_PTR Self)
	{
		return ((AActor*)Self)->IsChildActor();
	}

	DOTNET_EXPORT bool E_AActor_IsMatineeControlled(INT_PTR Self)
	{
		return ((AActor*)Self)->IsMatineeControlled();
	}

	DOTNET_EXPORT bool E_AActor_IsNetMode(INT_PTR Self, ENetMode Mode)
	{
		auto _p0 = Mode;
		return ((AActor*)Self)->IsNetMode(_p0);
	}

	DOTNET_EXPORT bool E_AActor_IsOverlappingActor(INT_PTR Self, AActor* Other)
	{
		auto _p0 = Other;
		return ((AActor*)Self)->IsOverlappingActor(_p0);
	}

	DOTNET_EXPORT bool E_AActor_IsOwnedBy(INT_PTR Self, AActor* TestOwner)
	{
		auto _p0 = TestOwner;
		return ((AActor*)Self)->IsOwnedBy(_p0);
	}

	DOTNET_EXPORT bool E_AActor_IsPendingKillPending(INT_PTR Self)
	{
		return ((AActor*)Self)->IsPendingKillPending();
	}

	DOTNET_EXPORT bool E_AActor_IsRootComponentMovable(INT_PTR Self)
	{
		return ((AActor*)Self)->IsRootComponentMovable();
	}

	DOTNET_EXPORT bool E_AActor_IsRootComponentStatic(INT_PTR Self)
	{
		return ((AActor*)Self)->IsRootComponentStatic();
	}

	DOTNET_EXPORT bool E_AActor_IsRootComponentStationary(INT_PTR Self)
	{
		return ((AActor*)Self)->IsRootComponentStationary();
	}

	DOTNET_EXPORT void E_AActor_K2_AttachToActor(INT_PTR Self, AActor* ParentActor, char* SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
	{
		auto _p0 = ParentActor;
		auto _p1 = FName(UTF8_TO_TCHAR(SocketName));
		auto _p2 = LocationRule;
		auto _p3 = RotationRule;
		auto _p4 = ScaleRule;
		auto _p5 = bWeldSimulatedBodies;
		((AActor*)Self)->K2_AttachToActor(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT void E_AActor_K2_AttachToComponent(INT_PTR Self, USceneComponent* Parent, char* SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
	{
		auto _p0 = Parent;
		auto _p1 = FName(UTF8_TO_TCHAR(SocketName));
		auto _p2 = LocationRule;
		auto _p3 = RotationRule;
		auto _p4 = ScaleRule;
		auto _p5 = bWeldSimulatedBodies;
		((AActor*)Self)->K2_AttachToComponent(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT void E_AActor_K2_DestroyActor(INT_PTR Self)
	{
		((AActor*)Self)->K2_DestroyActor();
	}

	DOTNET_EXPORT void E_AActor_K2_DestroyComponent(INT_PTR Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		((AActor*)Self)->K2_DestroyComponent(_p0);
	}

	DOTNET_EXPORT void E_AActor_K2_DetachFromActor(INT_PTR Self, EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule)
	{
		auto _p0 = LocationRule;
		auto _p1 = RotationRule;
		auto _p2 = ScaleRule;
		((AActor*)Self)->K2_DetachFromActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT INT_PTR E_AActor_K2_GetActorLocation(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((AActor*)Self)->K2_GetActorLocation());
	}

	DOTNET_EXPORT INT_PTR E_AActor_K2_GetActorRotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((AActor*)Self)->K2_GetActorRotation());
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

	DOTNET_EXPORT bool E_AActor_K2_TeleportTo(INT_PTR Self, INT_PTR DestLocation, INT_PTR DestRotation)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		return ((AActor*)Self)->K2_TeleportTo(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_LifeSpanExpired(INT_PTR Self)
	{
		((AActor*)Self)->LifeSpanExpired();
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

	DOTNET_EXPORT void E_AActor_MarkComponentsAsPendingKill(INT_PTR Self)
	{
		((AActor*)Self)->MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT void E_AActor_MarkComponentsRenderStateDirty(INT_PTR Self)
	{
		((AActor*)Self)->MarkComponentsRenderStateDirty();
	}

	DOTNET_EXPORT void E_AActor_NotifyActorBeginCursorOver(INT_PTR Self)
	{
		((AActor*)Self)->NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT void E_AActor_NotifyActorBeginOverlap(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		((AActor*)Self)->NotifyActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT void E_AActor_NotifyActorEndCursorOver(INT_PTR Self)
	{
		((AActor*)Self)->NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT void E_AActor_NotifyActorEndOverlap(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		((AActor*)Self)->NotifyActorEndOverlap(_p0);
	}

	DOTNET_EXPORT void E_AActor_OnConstruction(INT_PTR Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		((AActor*)Self)->OnConstruction(_p0);
	}

	DOTNET_EXPORT void E_AActor_OnRep_AttachmentReplication(INT_PTR Self)
	{
		((AActor*)Self)->OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT void E_AActor_OnRep_Instigator(INT_PTR Self)
	{
		((AActor*)Self)->OnRep_Instigator();
	}

	DOTNET_EXPORT void E_AActor_OnRep_Owner(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_AActor*)Self)->OnRep_Owner_WRAP();
	}

	DOTNET_EXPORT void E_AActor_OnRep_ReplicatedMovement(INT_PTR Self)
	{
		((AActor*)Self)->OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT void E_AActor_OnRep_ReplicateMovement(INT_PTR Self)
	{
		((AActor*)Self)->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT void E_AActor_OnReplicationPausedChanged(INT_PTR Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AActor*)Self)->OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT void E_AActor_OnSubobjectCreatedFromReplication(INT_PTR Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		((AActor*)Self)->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT void E_AActor_OnSubobjectDestroyFromReplication(INT_PTR Self, UObject* Subobject)
	{
		auto _p0 = Subobject;
		((AActor*)Self)->OnSubobjectDestroyFromReplication(_p0);
	}

	DOTNET_EXPORT void E_AActor_PostActorCreated(INT_PTR Self)
	{
		((AActor*)Self)->PostActorCreated();
	}

	DOTNET_EXPORT void E_AActor_PostInitializeComponents(INT_PTR Self)
	{
		((AActor*)Self)->PostInitializeComponents();
	}

	DOTNET_EXPORT void E_AActor_PostNetInit(INT_PTR Self)
	{
		((AActor*)Self)->PostNetInit();
	}

	DOTNET_EXPORT void E_AActor_PostNetReceiveLocation(INT_PTR Self)
	{
		((AActor*)Self)->PostNetReceiveLocation();
	}

	DOTNET_EXPORT void E_AActor_PostNetReceiveLocationAndRotation(INT_PTR Self)
	{
		((AActor*)Self)->PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT void E_AActor_PostNetReceivePhysicState(INT_PTR Self)
	{
		((AActor*)Self)->PostNetReceivePhysicState();
	}

	DOTNET_EXPORT void E_AActor_PostNetReceiveVelocity(INT_PTR Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		((AActor*)Self)->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT void E_AActor_PostRegisterAllComponents(INT_PTR Self)
	{
		((AActor*)Self)->PostRegisterAllComponents();
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

	DOTNET_EXPORT void E_AActor_PostUnregisterAllComponents(INT_PTR Self)
	{
		((AActor*)Self)->PostUnregisterAllComponents();
	}

	DOTNET_EXPORT void E_AActor_PreInitializeComponents(INT_PTR Self)
	{
		((AActor*)Self)->PreInitializeComponents();
	}

	DOTNET_EXPORT void E_AActor_ReceiveActorBeginCursorOver(INT_PTR Self)
	{
		((AActor*)Self)->ReceiveActorBeginCursorOver();
	}

	DOTNET_EXPORT void E_AActor_ReceiveActorBeginOverlap(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		((AActor*)Self)->ReceiveActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT void E_AActor_ReceiveActorEndCursorOver(INT_PTR Self)
	{
		((AActor*)Self)->ReceiveActorEndCursorOver();
	}

	DOTNET_EXPORT void E_AActor_ReceiveActorEndOverlap(INT_PTR Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		((AActor*)Self)->ReceiveActorEndOverlap(_p0);
	}

	DOTNET_EXPORT void E_AActor_ReceiveBeginPlay(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_AActor*)Self)->ReceiveBeginPlay_WRAP();
	}

	DOTNET_EXPORT void E_AActor_ReceiveDestroyed(INT_PTR Self)
	{
		((AActor*)Self)->ReceiveDestroyed();
	}

	DOTNET_EXPORT void E_AActor_ReceiveTick(INT_PTR Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AActor*)Self)->ReceiveTick(_p0);
	}

	DOTNET_EXPORT void E_AActor_RegisterAllActorTickFunctions(INT_PTR Self, bool bRegister, bool bDoComponents)
	{
		auto _p0 = bRegister;
		auto _p1 = bDoComponents;
		((AActor*)Self)->RegisterAllActorTickFunctions(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_RegisterAllComponents(INT_PTR Self)
	{
		((AActor*)Self)->RegisterAllComponents();
	}

	DOTNET_EXPORT void E_AActor_RemoveTickPrerequisiteActor(INT_PTR Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		((AActor*)Self)->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT void E_AActor_RemoveTickPrerequisiteComponent(INT_PTR Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		((AActor*)Self)->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT void E_AActor_ReregisterAllComponents(INT_PTR Self)
	{
		((AActor*)Self)->ReregisterAllComponents();
	}

	DOTNET_EXPORT void E_AActor_RerunConstructionScripts(INT_PTR Self)
	{
		((AActor*)Self)->RerunConstructionScripts();
	}

	DOTNET_EXPORT void E_AActor_ResetPropertiesForConstruction(INT_PTR Self)
	{
		((AActor*)Self)->ResetPropertiesForConstruction();
	}

	DOTNET_EXPORT void E_AActor_SetActorEnableCollision(INT_PTR Self, bool bNewActorEnableCollision)
	{
		auto _p0 = bNewActorEnableCollision;
		((AActor*)Self)->SetActorEnableCollision(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetActorHiddenInGame(INT_PTR Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AActor*)Self)->SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetActorRelativeScale3D(INT_PTR Self, INT_PTR NewRelativeScale)
	{
		auto _p0 = *(FVector*)NewRelativeScale;
		((AActor*)Self)->SetActorRelativeScale3D(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetActorScale3D(INT_PTR Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		((AActor*)Self)->SetActorScale3D(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetActorTickEnabled(INT_PTR Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((AActor*)Self)->SetActorTickEnabled(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetActorTickInterval(INT_PTR Self, float TickInterval)
	{
		auto _p0 = TickInterval;
		((AActor*)Self)->SetActorTickInterval(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetAutonomousProxy(INT_PTR Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare)
	{
		auto _p0 = bInAutonomousProxy;
		auto _p1 = bAllowForcePropertyCompare;
		((AActor*)Self)->SetAutonomousProxy(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_SetLifeSpan(INT_PTR Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AActor*)Self)->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetNetDriverName(INT_PTR Self, char* NewNetDriverName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(NewNetDriverName));
		((AActor*)Self)->SetNetDriverName(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetOwner(INT_PTR Self, AActor* NewOwner)
	{
		auto _p0 = NewOwner;
		((AActor*)Self)->SetOwner(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetReplicateMovement(INT_PTR Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AActor*)Self)->SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetReplicates(INT_PTR Self, bool bInReplicates)
	{
		auto _p0 = bInReplicates;
		((AActor*)Self)->SetReplicates(_p0);
	}

	DOTNET_EXPORT bool E_AActor_SetRootComponent(INT_PTR Self, USceneComponent* NewRootComponent)
	{
		auto _p0 = NewRootComponent;
		return ((AActor*)Self)->SetRootComponent(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetTickableWhenPaused(INT_PTR Self, bool bTickableWhenPaused)
	{
		auto _p0 = bTickableWhenPaused;
		((AActor*)Self)->SetTickableWhenPaused(_p0);
	}

	DOTNET_EXPORT void E_AActor_SetTickPrerequisite(INT_PTR Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		((AActor*)Self)->SetTickPrerequisite(_p0);
	}

	DOTNET_EXPORT void E_AActor_SnapRootComponentTo(INT_PTR Self, AActor* InParentActor, char* InSocketName)
	{
		auto _p0 = InParentActor;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		((AActor*)Self)->SnapRootComponentTo(_p0, _p1);
	}

	DOTNET_EXPORT void E_AActor_SwapRolesForReplay(INT_PTR Self)
	{
		((AActor*)Self)->SwapRolesForReplay();
	}

	DOTNET_EXPORT void E_AActor_SyncReplicatedPhysicsSimulation(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_AActor*)Self)->SyncReplicatedPhysicsSimulation_WRAP();
	}

	DOTNET_EXPORT void E_AActor_TearOff(INT_PTR Self)
	{
		((AActor*)Self)->TearOff();
	}

	DOTNET_EXPORT void E_AActor_TeleportSucceeded(INT_PTR Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AActor*)Self)->TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT void E_AActor_Tick(INT_PTR Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AActor*)Self)->Tick(_p0);
	}

	DOTNET_EXPORT void E_AActor_TickActor(INT_PTR Self, float DeltaTime, ELevelTick TickType, INT_PTR ThisTickFunction)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickType;
		auto _p2 = *(FActorTickFunction*)ThisTickFunction;
		((AActor*)Self)->TickActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_AActor_UninitializeComponents(INT_PTR Self)
	{
		((AActor*)Self)->UninitializeComponents();
	}

	DOTNET_EXPORT void E_AActor_UnregisterAllComponents(INT_PTR Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AActor*)Self)->UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT void E_AActor_UpdateComponentTransforms(INT_PTR Self)
	{
		((AActor*)Self)->UpdateComponentTransforms();
	}

	DOTNET_EXPORT void E_AActor_UpdateOverlaps(INT_PTR Self, bool bDoNotifies)
	{
		auto _p0 = bDoNotifies;
		((AActor*)Self)->UpdateOverlaps(_p0);
	}

	DOTNET_EXPORT void E_AActor_UserConstructionScript(INT_PTR Self)
	{
		((AActor*)Self)->UserConstructionScript();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
