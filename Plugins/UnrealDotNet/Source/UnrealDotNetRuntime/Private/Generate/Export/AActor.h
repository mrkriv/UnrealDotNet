#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
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
	
	DOTNET_EXPORT void E_EVENT_ADD_AActor_OnActorBeginOverlap(AActor* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnActorBeginOverlap";
		wrapper->SourceObject = Obj;
		Obj->OnActorBeginOverlap.AddDynamic(wrapper, &UManageEventSender::Wrapper_FActorBeginOverlapSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_AActor_OnActorBeginOverlap(AActor* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_AActor_OnActorEndOverlap(AActor* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnActorEndOverlap";
		wrapper->SourceObject = Obj;
		Obj->OnActorEndOverlap.AddDynamic(wrapper, &UManageEventSender::Wrapper_FActorEndOverlapSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_AActor_OnActorEndOverlap(AActor* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_AActor_OnBeginCursorOver(AActor* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnBeginCursorOver";
		wrapper->SourceObject = Obj;
		Obj->OnBeginCursorOver.AddDynamic(wrapper, &UManageEventSender::Wrapper_FActorBeginCursorOverSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_AActor_OnBeginCursorOver(AActor* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_AActor_OnDestroyed(AActor* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnDestroyed";
		wrapper->SourceObject = Obj;
		Obj->OnDestroyed.AddDynamic(wrapper, &UManageEventSender::Wrapper_FActorDestroyedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_AActor_OnDestroyed(AActor* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_AActor_OnEndCursorOver(AActor* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnEndCursorOver";
		wrapper->SourceObject = Obj;
		Obj->OnEndCursorOver.AddDynamic(wrapper, &UManageEventSender::Wrapper_FActorEndCursorOverSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_AActor_OnEndCursorOver(AActor* Obj)
	{
	}

	DOTNET_EXPORT INT_PTR E_PROP_AActor_PrimaryActorTick_GET(INT_PTR Ptr) { return (INT_PTR)&((AActor*)Ptr)->PrimaryActorTick; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AActor(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AActor>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AActor_ActorHasTag(AActor* Self, char* Tag)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(Tag));
		return ConvertForManage(Self->ActorHasTag(_p0));
	}

	DOTNET_EXPORT auto E_AActor_ActorToWorld(AActor* Self)
	{
		return (INT_PTR) new FTransform(Self->ActorToWorld());
	}

	DOTNET_EXPORT auto E_AActor_AddComponent(AActor* Self, char* TemplateName, bool bManualAttachment, INT_PTR RelativeTransform, UObject* ComponentTemplateContext)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(TemplateName));
		auto _p1 = bManualAttachment;
		auto _p2 = *(FTransform*)RelativeTransform;
		auto _p3 = ComponentTemplateContext;
		return ConvertForManage(Self->AddComponent(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_AActor_AddTickPrerequisiteActor(AActor* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_AActor_AddTickPrerequisiteComponent(AActor* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_AActor_AllowReceiveTickEventOnDedicatedServer(AActor* Self)
	{
		return ConvertForManage(Self->AllowReceiveTickEventOnDedicatedServer());
	}

	DOTNET_EXPORT auto E_AActor_ApplyWorldOffset(AActor* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AActor_AttachToActor(AActor* Self, AActor* ParentActor, INT_PTR AttachmentRules, char* SocketName)
	{
		auto _p0 = ParentActor;
		auto _p1 = *(FAttachmentTransformRules*)AttachmentRules;
		auto _p2 = FName(UTF8_TO_TCHAR(SocketName));
		Self->AttachToActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AActor_AttachToComponent(AActor* Self, USceneComponent* Parent, INT_PTR AttachmentRules, char* SocketName)
	{
		auto _p0 = Parent;
		auto _p1 = *(FAttachmentTransformRules*)AttachmentRules;
		auto _p2 = FName(UTF8_TO_TCHAR(SocketName));
		Self->AttachToComponent(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AActor_BeginPlay(AActor* Self)
	{
		((E_PROTECTED_WRAP_AActor*)Self)->BeginPlay_WRAP();
	}

	DOTNET_EXPORT auto E_AActor_CanEverTick(AActor* Self)
	{
		return ConvertForManage(Self->CanEverTick());
	}

	DOTNET_EXPORT auto E_AActor_ClearComponentOverlaps(AActor* Self)
	{
		Self->ClearComponentOverlaps();
	}

	DOTNET_EXPORT auto E_AActor_ClearCrossLevelReferences(AActor* Self)
	{
		Self->ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E_AActor_CopyRemoteRoleFrom(AActor* Self, AActor* CopyFromActor)
	{
		auto _p0 = CopyFromActor;
		Self->CopyRemoteRoleFrom(_p0);
	}

	DOTNET_EXPORT auto E_AActor_DebugShowOneComponentHierarchy(AActor* Self, USceneComponent* SceneComp, int32 NestLevel, bool bShowPosition)
	{
		auto _p0 = SceneComp;
		auto _p1 = NestLevel;
		auto _p2 = bShowPosition;
		Self->DebugShowOneComponentHierarchy(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AActor_Destroy(AActor* Self, bool bNetForce, bool bShouldModifyLevel)
	{
		auto _p0 = bNetForce;
		auto _p1 = bShouldModifyLevel;
		return ConvertForManage(Self->Destroy(_p0, _p1));
	}

	DOTNET_EXPORT auto E_AActor_DestroyConstructedComponents(AActor* Self)
	{
		Self->DestroyConstructedComponents();
	}

	DOTNET_EXPORT auto E_AActor_DetachAllSceneComponents(AActor* Self, USceneComponent* InParentComponent, INT_PTR DetachmentRules)
	{
		auto _p0 = InParentComponent;
		auto _p1 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachAllSceneComponents(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AActor_DetachFromActor(AActor* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromActor(_p0);
	}

	DOTNET_EXPORT auto E_AActor_DetachRootComponentFromParent(AActor* Self, bool bMaintainWorldPosition)
	{
		auto _p0 = bMaintainWorldPosition;
		Self->DetachRootComponentFromParent(_p0);
	}

	DOTNET_EXPORT auto E_AActor_DetachSceneComponentsFromParent(AActor* Self, USceneComponent* InParentComponent, bool bMaintainWorldPosition)
	{
		auto _p0 = InParentComponent;
		auto _p1 = bMaintainWorldPosition;
		Self->DetachSceneComponentsFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AActor_DispatchBeginPlay(AActor* Self)
	{
		Self->DispatchBeginPlay();
	}

	DOTNET_EXPORT auto E_AActor_ExchangeNetRoles(AActor* Self, bool bRemoteOwner)
	{
		auto _p0 = bRemoteOwner;
		Self->ExchangeNetRoles(_p0);
	}

	DOTNET_EXPORT auto E_AActor_FinishAndRegisterComponent(AActor* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		Self->FinishAndRegisterComponent(_p0);
	}

	DOTNET_EXPORT auto E_AActor_FlushNetDormancy(AActor* Self)
	{
		Self->FlushNetDormancy();
	}

	DOTNET_EXPORT auto E_AActor_ForcePropertyCompare(AActor* Self)
	{
		Self->ForcePropertyCompare();
	}

	DOTNET_EXPORT auto E_AActor_GatherCurrentMovement(AActor* Self)
	{
		Self->GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E_AActor_GetActorBounds(AActor* Self, bool bOnlyCollidingComponents, INT_PTR Origin, INT_PTR BoxExtent)
	{
		auto _p0 = bOnlyCollidingComponents;
		auto _p1 = *(FVector*)Origin;
		auto _p2 = *(FVector*)BoxExtent;
		Self->GetActorBounds(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AActor_GetActorEnableCollision(AActor* Self)
	{
		return ConvertForManage(Self->GetActorEnableCollision());
	}

	DOTNET_EXPORT auto E_AActor_GetActorForwardVector(AActor* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorForwardVector());
	}

	DOTNET_EXPORT auto E_AActor_GetActorLocation(AActor* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorLocation());
	}

	DOTNET_EXPORT auto E_AActor_GetActorQuat(AActor* Self)
	{
		return (INT_PTR) new FQuat(Self->GetActorQuat());
	}

	DOTNET_EXPORT auto E_AActor_GetActorRelativeScale3D(AActor* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorRelativeScale3D());
	}

	DOTNET_EXPORT auto E_AActor_GetActorRightVector(AActor* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorRightVector());
	}

	DOTNET_EXPORT auto E_AActor_GetActorRotation(AActor* Self)
	{
		return (INT_PTR) new FRotator(Self->GetActorRotation());
	}

	DOTNET_EXPORT auto E_AActor_GetActorScale(AActor* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorScale());
	}

	DOTNET_EXPORT auto E_AActor_GetActorScale3D(AActor* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorScale3D());
	}

	DOTNET_EXPORT auto E_AActor_GetActorTickInterval(AActor* Self)
	{
		return ConvertForManage(Self->GetActorTickInterval());
	}

	DOTNET_EXPORT auto E_AActor_GetActorTimeDilation(AActor* Self)
	{
		return ConvertForManage(Self->GetActorTimeDilation());
	}

	DOTNET_EXPORT auto E_AActor_GetActorTransform(AActor* Self)
	{
		return (INT_PTR) new FTransform(Self->GetActorTransform());
	}

	DOTNET_EXPORT auto E_AActor_GetActorUpVector(AActor* Self)
	{
		return (INT_PTR) new FVector(Self->GetActorUpVector());
	}

	DOTNET_EXPORT auto E_AActor_GetDistanceTo(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ConvertForManage(Self->GetDistanceTo(_p0));
	}

	DOTNET_EXPORT auto E_AActor_GetDotProductTo(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ConvertForManage(Self->GetDotProductTo(_p0));
	}

	DOTNET_EXPORT auto E_AActor_GetGameTimeSinceCreation(AActor* Self)
	{
		return ConvertForManage(Self->GetGameTimeSinceCreation());
	}

	DOTNET_EXPORT auto E_AActor_GetHorizontalDistanceTo(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ConvertForManage(Self->GetHorizontalDistanceTo(_p0));
	}

	DOTNET_EXPORT auto E_AActor_GetHorizontalDotProductTo(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ConvertForManage(Self->GetHorizontalDotProductTo(_p0));
	}

	DOTNET_EXPORT auto E_AActor_GetInputAxisValue(AActor* Self, char* InputAxisName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InputAxisName));
		return ConvertForManage(Self->GetInputAxisValue(_p0));
	}

	DOTNET_EXPORT auto E_AActor_GetNetDriverName(AActor* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->GetNetDriverName().ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_AActor_GetNetMode(AActor* Self)
	{
		return ConvertForManage(Self->GetNetMode());
	}

	DOTNET_EXPORT auto E_AActor_GetOwner(AActor* Self)
	{
		return ConvertForManage(Self->GetOwner());
	}

	DOTNET_EXPORT auto E_AActor_GetParentActor(AActor* Self)
	{
		return ConvertForManage(Self->GetParentActor());
	}

	DOTNET_EXPORT auto E_AActor_GetParentComponent(AActor* Self)
	{
		return ConvertForManage(Self->GetParentComponent());
	}

	DOTNET_EXPORT auto E_AActor_GetPlacementExtent(AActor* Self)
	{
		return (INT_PTR) new FVector(Self->GetPlacementExtent());
	}

	DOTNET_EXPORT auto E_AActor_GetRootComponent(AActor* Self)
	{
		return ConvertForManage(Self->GetRootComponent());
	}

	DOTNET_EXPORT auto E_AActor_GetRootPrimitiveComponent(AActor* Self)
	{
		return ConvertForManage(Self->GetRootPrimitiveComponent());
	}

	DOTNET_EXPORT auto E_AActor_GetSquaredDistanceTo(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ConvertForManage(Self->GetSquaredDistanceTo(_p0));
	}

	DOTNET_EXPORT auto E_AActor_GetTickableWhenPaused(AActor* Self)
	{
		return ConvertForManage(Self->GetTickableWhenPaused());
	}

	DOTNET_EXPORT auto E_AActor_GetTransform(AActor* Self)
	{
		return (INT_PTR) new FTransform(Self->GetTransform());
	}

	DOTNET_EXPORT auto E_AActor_GetVerticalDistanceTo(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		return ConvertForManage(Self->GetVerticalDistanceTo(_p0));
	}

	DOTNET_EXPORT auto E_AActor_HasActorBegunPlay(AActor* Self)
	{
		return ConvertForManage(Self->HasActorBegunPlay());
	}

	DOTNET_EXPORT auto E_AActor_HasAuthority(AActor* Self)
	{
		return ConvertForManage(Self->HasAuthority());
	}

	DOTNET_EXPORT auto E_AActor_HasDeferredComponentRegistration(AActor* Self)
	{
		return ConvertForManage(Self->HasDeferredComponentRegistration());
	}

	DOTNET_EXPORT auto E_AActor_HasValidRootComponent(AActor* Self)
	{
		return ConvertForManage(Self->HasValidRootComponent());
	}

	DOTNET_EXPORT auto E_AActor_IncrementalRegisterComponents(AActor* Self, int32 NumComponentsToRegister)
	{
		auto _p0 = NumComponentsToRegister;
		return ConvertForManage(Self->IncrementalRegisterComponents(_p0));
	}

	DOTNET_EXPORT auto E_AActor_InitializeComponents(AActor* Self)
	{
		Self->InitializeComponents();
	}

	DOTNET_EXPORT auto E_AActor_InvalidateLightingCache(AActor* Self)
	{
		Self->InvalidateLightingCache();
	}

	DOTNET_EXPORT auto E_AActor_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E_AActor_IsActorBeginningPlay(AActor* Self)
	{
		return ConvertForManage(Self->IsActorBeginningPlay());
	}

	DOTNET_EXPORT auto E_AActor_IsActorBeingDestroyed(AActor* Self)
	{
		return ConvertForManage(Self->IsActorBeingDestroyed());
	}

	DOTNET_EXPORT auto E_AActor_IsActorInitialized(AActor* Self)
	{
		return ConvertForManage(Self->IsActorInitialized());
	}

	DOTNET_EXPORT auto E_AActor_IsActorTickEnabled(AActor* Self)
	{
		return ConvertForManage(Self->IsActorTickEnabled());
	}

	DOTNET_EXPORT auto E_AActor_IsChildActor(AActor* Self)
	{
		return ConvertForManage(Self->IsChildActor());
	}

	DOTNET_EXPORT auto E_AActor_IsMatineeControlled(AActor* Self)
	{
		return ConvertForManage(Self->IsMatineeControlled());
	}

	DOTNET_EXPORT auto E_AActor_IsNetMode(AActor* Self, ENetMode Mode)
	{
		auto _p0 = Mode;
		return ConvertForManage(Self->IsNetMode(_p0));
	}

	DOTNET_EXPORT auto E_AActor_IsOverlappingActor(AActor* Self, AActor* Other)
	{
		auto _p0 = Other;
		return ConvertForManage(Self->IsOverlappingActor(_p0));
	}

	DOTNET_EXPORT auto E_AActor_IsOwnedBy(AActor* Self, AActor* TestOwner)
	{
		auto _p0 = TestOwner;
		return ConvertForManage(Self->IsOwnedBy(_p0));
	}

	DOTNET_EXPORT auto E_AActor_IsPendingKillPending(AActor* Self)
	{
		return ConvertForManage(Self->IsPendingKillPending());
	}

	DOTNET_EXPORT auto E_AActor_IsRootComponentMovable(AActor* Self)
	{
		return ConvertForManage(Self->IsRootComponentMovable());
	}

	DOTNET_EXPORT auto E_AActor_IsRootComponentStatic(AActor* Self)
	{
		return ConvertForManage(Self->IsRootComponentStatic());
	}

	DOTNET_EXPORT auto E_AActor_IsRootComponentStationary(AActor* Self)
	{
		return ConvertForManage(Self->IsRootComponentStationary());
	}

	DOTNET_EXPORT auto E_AActor_K2_AttachToActor(AActor* Self, AActor* ParentActor, char* SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
	{
		auto _p0 = ParentActor;
		auto _p1 = FName(UTF8_TO_TCHAR(SocketName));
		auto _p2 = LocationRule;
		auto _p3 = RotationRule;
		auto _p4 = ScaleRule;
		auto _p5 = bWeldSimulatedBodies;
		Self->K2_AttachToActor(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_AActor_K2_AttachToComponent(AActor* Self, USceneComponent* Parent, char* SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
	{
		auto _p0 = Parent;
		auto _p1 = FName(UTF8_TO_TCHAR(SocketName));
		auto _p2 = LocationRule;
		auto _p3 = RotationRule;
		auto _p4 = ScaleRule;
		auto _p5 = bWeldSimulatedBodies;
		Self->K2_AttachToComponent(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_AActor_K2_DestroyActor(AActor* Self)
	{
		Self->K2_DestroyActor();
	}

	DOTNET_EXPORT auto E_AActor_K2_DestroyComponent(AActor* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		Self->K2_DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_AActor_K2_DetachFromActor(AActor* Self, EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule)
	{
		auto _p0 = LocationRule;
		auto _p1 = RotationRule;
		auto _p2 = ScaleRule;
		Self->K2_DetachFromActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AActor_K2_GetActorLocation(AActor* Self)
	{
		return (INT_PTR) new FVector(Self->K2_GetActorLocation());
	}

	DOTNET_EXPORT auto E_AActor_K2_GetActorRotation(AActor* Self)
	{
		return (INT_PTR) new FRotator(Self->K2_GetActorRotation());
	}

	DOTNET_EXPORT auto E_AActor_K2_GetRootComponent(AActor* Self)
	{
		return ConvertForManage(Self->K2_GetRootComponent());
	}

	DOTNET_EXPORT auto E_AActor_K2_SetActorRotation(AActor* Self, INT_PTR NewRotation, bool bTeleportPhysics)
	{
		auto _p0 = *(FRotator*)NewRotation;
		auto _p1 = bTeleportPhysics;
		return ConvertForManage(Self->K2_SetActorRotation(_p0, _p1));
	}

	DOTNET_EXPORT auto E_AActor_K2_TeleportTo(AActor* Self, INT_PTR DestLocation, INT_PTR DestRotation)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		return ConvertForManage(Self->K2_TeleportTo(_p0, _p1));
	}

	DOTNET_EXPORT auto E_AActor_LifeSpanExpired(AActor* Self)
	{
		Self->LifeSpanExpired();
	}

	DOTNET_EXPORT auto E_AActor_MakeNoise(AActor* Self, float Loudness, APawn* NoiseInstigator, INT_PTR NoiseLocation, float MaxRange, char* Tag)
	{
		auto _p0 = Loudness;
		auto _p1 = NoiseInstigator;
		auto _p2 = *(FVector*)NoiseLocation;
		auto _p3 = MaxRange;
		auto _p4 = FName(UTF8_TO_TCHAR(Tag));
		Self->MakeNoise(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_AActor_MarkComponentsAsPendingKill(AActor* Self)
	{
		Self->MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E_AActor_MarkComponentsRenderStateDirty(AActor* Self)
	{
		Self->MarkComponentsRenderStateDirty();
	}

	DOTNET_EXPORT auto E_AActor_NotifyActorBeginCursorOver(AActor* Self)
	{
		Self->NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E_AActor_NotifyActorBeginOverlap(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT auto E_AActor_NotifyActorEndCursorOver(AActor* Self)
	{
		Self->NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E_AActor_NotifyActorEndOverlap(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorEndOverlap(_p0);
	}

	DOTNET_EXPORT auto E_AActor_OnConstruction(AActor* Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		Self->OnConstruction(_p0);
	}

	DOTNET_EXPORT auto E_AActor_OnRep_AttachmentReplication(AActor* Self)
	{
		Self->OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E_AActor_OnRep_Instigator(AActor* Self)
	{
		Self->OnRep_Instigator();
	}

	DOTNET_EXPORT auto E_AActor_OnRep_Owner(AActor* Self)
	{
		((E_PROTECTED_WRAP_AActor*)Self)->OnRep_Owner_WRAP();
	}

	DOTNET_EXPORT auto E_AActor_OnRep_ReplicatedMovement(AActor* Self)
	{
		Self->OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E_AActor_OnRep_ReplicateMovement(AActor* Self)
	{
		Self->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E_AActor_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		Self->OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E_AActor_OnSubobjectCreatedFromReplication(AActor* Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		Self->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_AActor_OnSubobjectDestroyFromReplication(AActor* Self, UObject* Subobject)
	{
		auto _p0 = Subobject;
		Self->OnSubobjectDestroyFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_AActor_PostActorCreated(AActor* Self)
	{
		Self->PostActorCreated();
	}

	DOTNET_EXPORT auto E_AActor_PostInitializeComponents(AActor* Self)
	{
		Self->PostInitializeComponents();
	}

	DOTNET_EXPORT auto E_AActor_PostNetInit(AActor* Self)
	{
		Self->PostNetInit();
	}

	DOTNET_EXPORT auto E_AActor_PostNetReceiveLocation(AActor* Self)
	{
		Self->PostNetReceiveLocation();
	}

	DOTNET_EXPORT auto E_AActor_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		Self->PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E_AActor_PostNetReceivePhysicState(AActor* Self)
	{
		Self->PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E_AActor_PostNetReceiveVelocity(AActor* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		Self->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT auto E_AActor_PostRegisterAllComponents(AActor* Self)
	{
		Self->PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E_AActor_PostSpawnInitialize(AActor* Self, INT_PTR SpawnTransform, AActor* InOwner, APawn* InInstigator, bool bRemoteOwned, bool bNoFail, bool bDeferConstruction)
	{
		auto _p0 = *(FTransform*)SpawnTransform;
		auto _p1 = InOwner;
		auto _p2 = InInstigator;
		auto _p3 = bRemoteOwned;
		auto _p4 = bNoFail;
		auto _p5 = bDeferConstruction;
		Self->PostSpawnInitialize(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_AActor_PostUnregisterAllComponents(AActor* Self)
	{
		Self->PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E_AActor_PreInitializeComponents(AActor* Self)
	{
		Self->PreInitializeComponents();
	}

	DOTNET_EXPORT auto E_AActor_ReceiveActorBeginCursorOver(AActor* Self)
	{
		Self->ReceiveActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E_AActor_ReceiveActorBeginOverlap(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->ReceiveActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT auto E_AActor_ReceiveActorEndCursorOver(AActor* Self)
	{
		Self->ReceiveActorEndCursorOver();
	}

	DOTNET_EXPORT auto E_AActor_ReceiveActorEndOverlap(AActor* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->ReceiveActorEndOverlap(_p0);
	}

	DOTNET_EXPORT auto E_AActor_ReceiveBeginPlay(AActor* Self)
	{
		((E_PROTECTED_WRAP_AActor*)Self)->ReceiveBeginPlay_WRAP();
	}

	DOTNET_EXPORT auto E_AActor_ReceiveDestroyed(AActor* Self)
	{
		Self->ReceiveDestroyed();
	}

	DOTNET_EXPORT auto E_AActor_ReceiveTick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->ReceiveTick(_p0);
	}

	DOTNET_EXPORT auto E_AActor_RegisterAllActorTickFunctions(AActor* Self, bool bRegister, bool bDoComponents)
	{
		auto _p0 = bRegister;
		auto _p1 = bDoComponents;
		Self->RegisterAllActorTickFunctions(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AActor_RegisterAllComponents(AActor* Self)
	{
		Self->RegisterAllComponents();
	}

	DOTNET_EXPORT auto E_AActor_RemoveTickPrerequisiteActor(AActor* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_AActor_RemoveTickPrerequisiteComponent(AActor* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_AActor_ReregisterAllComponents(AActor* Self)
	{
		Self->ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E_AActor_RerunConstructionScripts(AActor* Self)
	{
		Self->RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E_AActor_ResetPropertiesForConstruction(AActor* Self)
	{
		Self->ResetPropertiesForConstruction();
	}

	DOTNET_EXPORT auto E_AActor_SetActorEnableCollision(AActor* Self, bool bNewActorEnableCollision)
	{
		auto _p0 = bNewActorEnableCollision;
		Self->SetActorEnableCollision(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		Self->SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetActorRelativeScale3D(AActor* Self, INT_PTR NewRelativeScale)
	{
		auto _p0 = *(FVector*)NewRelativeScale;
		Self->SetActorRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetActorScale3D(AActor* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetActorScale3D(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetActorTickEnabled(AActor* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetActorTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetActorTickInterval(AActor* Self, float TickInterval)
	{
		auto _p0 = TickInterval;
		Self->SetActorTickInterval(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetAutonomousProxy(AActor* Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare)
	{
		auto _p0 = bInAutonomousProxy;
		auto _p1 = bAllowForcePropertyCompare;
		Self->SetAutonomousProxy(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AActor_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetNetDriverName(AActor* Self, char* NewNetDriverName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(NewNetDriverName));
		Self->SetNetDriverName(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetOwner(AActor* Self, AActor* NewOwner)
	{
		auto _p0 = NewOwner;
		Self->SetOwner(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		Self->SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetReplicates(AActor* Self, bool bInReplicates)
	{
		auto _p0 = bInReplicates;
		Self->SetReplicates(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetRootComponent(AActor* Self, USceneComponent* NewRootComponent)
	{
		auto _p0 = NewRootComponent;
		return ConvertForManage(Self->SetRootComponent(_p0));
	}

	DOTNET_EXPORT auto E_AActor_SetTickableWhenPaused(AActor* Self, bool bTickableWhenPaused)
	{
		auto _p0 = bTickableWhenPaused;
		Self->SetTickableWhenPaused(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SetTickPrerequisite(AActor* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->SetTickPrerequisite(_p0);
	}

	DOTNET_EXPORT auto E_AActor_SnapRootComponentTo(AActor* Self, AActor* InParentActor, char* InSocketName)
	{
		auto _p0 = InParentActor;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		Self->SnapRootComponentTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AActor_SwapRolesForReplay(AActor* Self)
	{
		Self->SwapRolesForReplay();
	}

	DOTNET_EXPORT auto E_AActor_SyncReplicatedPhysicsSimulation(AActor* Self)
	{
		((E_PROTECTED_WRAP_AActor*)Self)->SyncReplicatedPhysicsSimulation_WRAP();
	}

	DOTNET_EXPORT auto E_AActor_TearOff(AActor* Self)
	{
		Self->TearOff();
	}

	DOTNET_EXPORT auto E_AActor_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		Self->TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E_AActor_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->Tick(_p0);
	}

	DOTNET_EXPORT auto E_AActor_TickActor(AActor* Self, float DeltaTime, ELevelTick TickType, INT_PTR ThisTickFunction)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickType;
		auto _p2 = *(FActorTickFunction*)ThisTickFunction;
		Self->TickActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AActor_UninitializeComponents(AActor* Self)
	{
		Self->UninitializeComponents();
	}

	DOTNET_EXPORT auto E_AActor_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		Self->UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E_AActor_UpdateComponentTransforms(AActor* Self)
	{
		Self->UpdateComponentTransforms();
	}

	DOTNET_EXPORT auto E_AActor_UpdateOverlaps(AActor* Self, bool bDoNotifies)
	{
		auto _p0 = bDoNotifies;
		Self->UpdateOverlaps(_p0);
	}

	DOTNET_EXPORT auto E_AActor_UserConstructionScript(AActor* Self)
	{
		Self->UserConstructionScript();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
