#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/PrimitiveComponent.h"

class E_PROTECTED_WRAP_UPrimitiveComponent : protected UPrimitiveComponent
{
public:
	void ClearComponentOverlaps_WRAP(bool bDoNotifies, bool bSkipNotifySelf)
	{
		ClearComponentOverlaps(bDoNotifies, bSkipNotifySelf);
	}

	void EnsurePhysicsStateCreated_WRAP()
	{
		EnsurePhysicsStateCreated();
	}

	void OnComponentCollisionSettingsChanged_WRAP()
	{
		OnComponentCollisionSettingsChanged();
	}

	void UpdatePhysicsToRBChannels_WRAP()
	{
		UpdatePhysicsToRBChannels();
	}

}
;

extern "C"
{
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_BoundsScale_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->BoundsScale; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_BoundsScale_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->BoundsScale = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->CachedMaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->CachedMaxDrawDistance = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_CurrentTag_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->CurrentTag; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CurrentTag_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->CurrentTag = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->CustomDepthStencilValue; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->CustomDepthStencilValue = Value; }
	
	DOTNET_EXPORT ERendererStencilMask E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->CustomDepthStencilWriteMask; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_SET(INT_PTR Ptr, ERendererStencilMask Value) { ((UPrimitiveComponent*)Ptr)->CustomDepthStencilWriteMask = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LastRenderTime_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LastRenderTime; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastRenderTime_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LastRenderTime = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LastRenderTimeOnScreen; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LastRenderTimeOnScreen = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LastSubmitTime_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LastSubmitTime; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastSubmitTime_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LastSubmitTime = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LDMaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LDMaxDrawDistance = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_UPrimitiveComponent_LightingChannels_GET(INT_PTR Ptr) { return (INT_PTR)&((UPrimitiveComponent*)Ptr)->LightingChannels; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LightingChannels_SET(INT_PTR Ptr, INT_PTR Value) { ((UPrimitiveComponent*)Ptr)->LightingChannels = *(FLightingChannels*)Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LpvBiasMultiplier; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LpvBiasMultiplier = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_MinDrawDistance_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->MinDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_MinDrawDistance_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->MinDrawDistance = Value; }
	
	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnBeginCursorOver(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnBeginCursorOver";
		wrapper->SourceObject = Obj;
		Obj->OnBeginCursorOver.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentBeginCursorOverSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnBeginCursorOver(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentCollisionSettingsChangedEvent";
		wrapper->SourceObject = Obj;
		Obj->OnComponentCollisionSettingsChangedEvent.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentCollisionSettingsChangedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentEndOverlap(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentEndOverlap";
		wrapper->SourceObject = Obj;
		Obj->OnComponentEndOverlap.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentEndOverlapSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentEndOverlap(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentSleep(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentSleep";
		wrapper->SourceObject = Obj;
		Obj->OnComponentSleep.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentSleepSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentSleep(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentWake(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentWake";
		wrapper->SourceObject = Obj;
		Obj->OnComponentWake.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentWakeSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentWake(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnEndCursorOver(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnEndCursorOver";
		wrapper->SourceObject = Obj;
		Obj->OnEndCursorOver.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentEndCursorOverSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnEndCursorOver(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->TranslucencySortPriority; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->TranslucencySortPriority = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_VisibilityId_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->VisibilityId; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_VisibilityId_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->VisibilityId = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPrimitiveComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPrimitiveComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddAngularImpulse(UPrimitiveComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bVelChange;
		(Self)->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddForce(UPrimitiveComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bAccelChange;
		(Self)->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddForceAtLocation(UPrimitiveComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddForceAtLocationLocal(UPrimitiveComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddImpulse(UPrimitiveComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bVelChange;
		(Self)->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddImpulseAtLocation(UPrimitiveComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddTorque(UPrimitiveComponent* Self, INT_PTR Torque, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Torque;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bAccelChange;
		(Self)->AddTorque(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_BeginComponentOverlap(UPrimitiveComponent* Self, INT_PTR OtherOverlap, bool bDoNotifies)
	{
		auto _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		(Self)->BeginComponentOverlap(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_ClearComponentOverlaps(UPrimitiveComponent* Self, bool bDoNotifies, bool bSkipNotifySelf)
	{
		auto _p0 = bDoNotifies;
		auto _p1 = bSkipNotifySelf;
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->ClearComponentOverlaps_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_ClearMoveIgnoreActors(UPrimitiveComponent* Self)
	{
		(Self)->ClearMoveIgnoreActors();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_ClearMoveIgnoreComponents(UPrimitiveComponent* Self)
	{
		(Self)->ClearMoveIgnoreComponents();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_DisableNavigationRelevance(UPrimitiveComponent* Self)
	{
		(Self)->DisableNavigationRelevance();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_DispatchMouseOverEvents(UPrimitiveComponent* Self, UPrimitiveComponent* CurrentComponent, UPrimitiveComponent* NewComponent)
	{
		auto _p0 = CurrentComponent;
		auto _p1 = NewComponent;
		(Self)->DispatchMouseOverEvents(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_DispatchWakeEvents(UPrimitiveComponent* Self, int32 WakeEvent, char* BoneName)
	{
		auto _p0 = WakeEvent;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->DispatchWakeEvents(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_EndComponentOverlap(UPrimitiveComponent* Self, INT_PTR OtherOverlap, bool bDoNotifies, bool bSkipNotifySelf)
	{
		auto _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		auto _p2 = bSkipNotifySelf;
		(Self)->EndComponentOverlap(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_EnsurePhysicsStateCreated(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->EnsurePhysicsStateCreated_WRAP();
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_GetCenterOfMass(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector((Self)->GetCenterOfMass(_p0));
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_GetClosestPointOnCollision(UPrimitiveComponent* Self, INT_PTR Point, INT_PTR OutPointOnBody, char* BoneName)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)OutPointOnBody;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		return (Self)->GetClosestPointOnCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT char* E_UPrimitiveComponent_GetCollisionProfileName(UPrimitiveComponent* Self, int& ResultStringLen)
	{
		auto _result = (Self)->GetCollisionProfileName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_GetDistanceToCollision(UPrimitiveComponent* Self, INT_PTR Point, INT_PTR ClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)ClosestPointOnCollision;
		return (Self)->GetDistanceToCollision(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(UPrimitiveComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		(Self)->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT ObjectPointerDescription E_UPrimitiveComponent_GetLODParentPrimitive(UPrimitiveComponent* Self)
	{
		return MakePrtDesc((Self)->GetLODParentPrimitive());
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_GetPhysicsAngularVelocity(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector((Self)->GetPhysicsAngularVelocity(_p0));
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_GetPhysicsLinearVelocity(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector((Self)->GetPhysicsLinearVelocity(_p0));
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(UPrimitiveComponent* Self, INT_PTR Point, char* BoneName)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector((Self)->GetPhysicsLinearVelocityAtPoint(_p0, _p1));
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_HasStaticLighting(UPrimitiveComponent* Self)
	{
		return (Self)->HasStaticLighting();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_IgnoreActorWhenMoving(UPrimitiveComponent* Self, AActor* Actor, bool bShouldIgnore)
	{
		auto _p0 = Actor;
		auto _p1 = bShouldIgnore;
		(Self)->IgnoreActorWhenMoving(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_IgnoreComponentWhenMoving(UPrimitiveComponent* Self, UPrimitiveComponent* Component, bool bShouldIgnore)
	{
		auto _p0 = Component;
		auto _p1 = bShouldIgnore;
		(Self)->IgnoreComponentWhenMoving(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsAttachedToStreamingManager(UPrimitiveComponent* Self)
	{
		return (Self)->IsAttachedToStreamingManager();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsComponentIndividuallySelected(UPrimitiveComponent* Self)
	{
		return (Self)->IsComponentIndividuallySelected();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsOverlappingActor(UPrimitiveComponent* Self, AActor* Other)
	{
		auto _p0 = Other;
		return (Self)->IsOverlappingActor(_p0);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(UPrimitiveComponent* Self)
	{
		return (Self)->IsPostPhysicsComponentTickEnabled();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsWelded(UPrimitiveComponent* Self)
	{
		return (Self)->IsWelded();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_K2_IsCollisionEnabled(UPrimitiveComponent* Self)
	{
		return (Self)->K2_IsCollisionEnabled();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(UPrimitiveComponent* Self)
	{
		return (Self)->K2_IsPhysicsCollisionEnabled();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(UPrimitiveComponent* Self)
	{
		return (Self)->K2_IsQueryCollisionEnabled();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_PushHoveredToProxy(UPrimitiveComponent* Self, bool bInHovered)
	{
		auto _p0 = bInHovered;
		(Self)->PushHoveredToProxy(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_PushSelectionToProxy(UPrimitiveComponent* Self)
	{
		(Self)->PushSelectionToProxy();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		(Self)->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_PutRigidBodyToSleep(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->PutRigidBodyToSleep(_p0);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_RigidBodyIsAwake(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return (Self)->RigidBodyIsAwake(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		(Self)->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllPhysicsAngularVelocity(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		(Self)->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(UPrimitiveComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		(Self)->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllPhysicsPosition(UPrimitiveComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		(Self)->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		(Self)->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetBoundsScale(UPrimitiveComponent* Self, float NewBoundsScale)
	{
		auto _p0 = NewBoundsScale;
		(Self)->SetBoundsScale(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCachedMaxDrawDistance(UPrimitiveComponent* Self, float NewCachedMaxDrawDistance)
	{
		auto _p0 = NewCachedMaxDrawDistance;
		(Self)->SetCachedMaxDrawDistance(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCastShadow(UPrimitiveComponent* Self, bool NewCastShadow)
	{
		auto _p0 = NewCastShadow;
		(Self)->SetCastShadow(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCenterOfMass(UPrimitiveComponent* Self, INT_PTR CenterOfMassOffset, char* BoneName)
	{
		auto _p0 = *(FVector*)CenterOfMassOffset;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->SetCenterOfMass(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCollisionObjectType(UPrimitiveComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		(Self)->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCollisionProfileName(UPrimitiveComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InCollisionProfileName));
		(Self)->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCullDistance(UPrimitiveComponent* Self, float NewCullDistance)
	{
		auto _p0 = NewCullDistance;
		(Self)->SetCullDistance(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCustomDepthStencilValue(UPrimitiveComponent* Self, int32 Value)
	{
		auto _p0 = Value;
		(Self)->SetCustomDepthStencilValue(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(UPrimitiveComponent* Self, ERendererStencilMask WriteMaskBit)
	{
		auto _p0 = WriteMaskBit;
		(Self)->SetCustomDepthStencilWriteMask(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetDepthPriorityGroup(UPrimitiveComponent* Self, ESceneDepthPriorityGroup NewDepthPriorityGroup)
	{
		auto _p0 = NewDepthPriorityGroup;
		(Self)->SetDepthPriorityGroup(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		(Self)->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		(Self)->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetLODParentPrimitive(UPrimitiveComponent* Self, UPrimitiveComponent* InLODParentPrimitive)
	{
		auto _p0 = InLODParentPrimitive;
		(Self)->SetLODParentPrimitive(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetMassOverrideInKg(UPrimitiveComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		(Self)->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetMassScale(UPrimitiveComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p1 = InMassScale;
		(Self)->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		(Self)->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetOnlyOwnerSee(UPrimitiveComponent* Self, bool bNewOnlyOwnerSee)
	{
		auto _p0 = bNewOnlyOwnerSee;
		(Self)->SetOnlyOwnerSee(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetOwnerNoSee(UPrimitiveComponent* Self, bool bNewOwnerNoSee)
	{
		auto _p0 = bNewOwnerNoSee;
		(Self)->SetOwnerNoSee(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPhysicsAngularVelocity(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->SetPhysicsAngularVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPhysicsLinearVelocity(UPrimitiveComponent* Self, INT_PTR NewVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->SetPhysicsLinearVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(UPrimitiveComponent* Self, float NewMaxAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = NewMaxAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->SetPhysicsMaxAngularVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(UPrimitiveComponent* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		(Self)->SetPostPhysicsComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetReceivesDecals(UPrimitiveComponent* Self, bool bNewReceivesDecals)
	{
		auto _p0 = bNewReceivesDecals;
		(Self)->SetReceivesDecals(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetRenderCustomDepth(UPrimitiveComponent* Self, bool bValue)
	{
		auto _p0 = bValue;
		(Self)->SetRenderCustomDepth(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetRenderInMainPass(UPrimitiveComponent* Self, bool bValue)
	{
		auto _p0 = bValue;
		(Self)->SetRenderInMainPass(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetRenderInMono(UPrimitiveComponent* Self, bool bValue)
	{
		auto _p0 = bValue;
		(Self)->SetRenderInMono(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		(Self)->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(UPrimitiveComponent* Self, bool bNewSingleSampleShadowFromStationaryLights)
	{
		auto _p0 = bNewSingleSampleShadowFromStationaryLights;
		(Self)->SetSingleSampleShadowFromStationaryLights(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetTranslucentSortPriority(UPrimitiveComponent* Self, int32 NewTranslucentSortPriority)
	{
		auto _p0 = NewTranslucentSortPriority;
		(Self)->SetTranslucentSortPriority(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(UPrimitiveComponent* Self, bool bNewUseViewOwnerDepthPriorityGroup, ESceneDepthPriorityGroup NewViewOwnerDepthPriorityGroup)
	{
		auto _p0 = bNewUseViewOwnerDepthPriorityGroup;
		auto _p1 = NewViewOwnerDepthPriorityGroup;
		(Self)->SetViewOwnerDepthPriorityGroup(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_ShouldComponentAddToScene(UPrimitiveComponent* Self)
	{
		return (Self)->ShouldComponentAddToScene();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SyncComponentToRBPhysics(UPrimitiveComponent* Self)
	{
		(Self)->SyncComponentToRBPhysics();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		(Self)->UnWeldChildren();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		(Self)->UnWeldFromParent();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		(Self)->WakeAllRigidBodies();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_WakeRigidBody(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		(Self)->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_WeldTo(UPrimitiveComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		(Self)->WeldTo(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
