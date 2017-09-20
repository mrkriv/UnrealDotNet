#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
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
	
	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->TranslucencySortPriority; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->TranslucencySortPriority = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_VisibilityId_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->VisibilityId; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_VisibilityId_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->VisibilityId = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPrimitiveComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPrimitiveComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddAngularImpulse(INT_PTR Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bVelChange;
		((UPrimitiveComponent*)Self)->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddForce(INT_PTR Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bAccelChange;
		((UPrimitiveComponent*)Self)->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddForceAtLocation(INT_PTR Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddForceAtLocationLocal(INT_PTR Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddImpulse(INT_PTR Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bVelChange;
		((UPrimitiveComponent*)Self)->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddImpulseAtLocation(INT_PTR Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_AddTorque(INT_PTR Self, INT_PTR Torque, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Torque;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p2 = bAccelChange;
		((UPrimitiveComponent*)Self)->AddTorque(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_BeginComponentOverlap(INT_PTR Self, INT_PTR OtherOverlap, bool bDoNotifies)
	{
		auto _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		((UPrimitiveComponent*)Self)->BeginComponentOverlap(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_ClearComponentOverlaps(INT_PTR Self, bool bDoNotifies, bool bSkipNotifySelf)
	{
		auto _p0 = bDoNotifies;
		auto _p1 = bSkipNotifySelf;
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->ClearComponentOverlaps_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_ClearMoveIgnoreActors(INT_PTR Self)
	{
		((UPrimitiveComponent*)Self)->ClearMoveIgnoreActors();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_ClearMoveIgnoreComponents(INT_PTR Self)
	{
		((UPrimitiveComponent*)Self)->ClearMoveIgnoreComponents();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_DisableNavigationRelevance(INT_PTR Self)
	{
		((UPrimitiveComponent*)Self)->DisableNavigationRelevance();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_DispatchMouseOverEvents(INT_PTR Self, UPrimitiveComponent* CurrentComponent, UPrimitiveComponent* NewComponent)
	{
		auto _p0 = CurrentComponent;
		auto _p1 = NewComponent;
		((UPrimitiveComponent*)Self)->DispatchMouseOverEvents(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_DispatchWakeEvents(INT_PTR Self, int32 WakeEvent, char* BoneName)
	{
		auto _p0 = WakeEvent;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->DispatchWakeEvents(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_EndComponentOverlap(INT_PTR Self, INT_PTR OtherOverlap, bool bDoNotifies, bool bSkipNotifySelf)
	{
		auto _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		auto _p2 = bSkipNotifySelf;
		((UPrimitiveComponent*)Self)->EndComponentOverlap(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_EnsurePhysicsStateCreated(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->EnsurePhysicsStateCreated_WRAP();
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_GetCenterOfMass(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector(((UPrimitiveComponent*)Self)->GetCenterOfMass(_p0));
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_GetClosestPointOnCollision(INT_PTR Self, INT_PTR Point, INT_PTR OutPointOnBody, char* BoneName)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)OutPointOnBody;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		return ((UPrimitiveComponent*)Self)->GetClosestPointOnCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT char* E_UPrimitiveComponent_GetCollisionProfileName(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((UPrimitiveComponent*)Self)->GetCollisionProfileName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_GetDistanceToCollision(INT_PTR Self, INT_PTR Point, INT_PTR ClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)ClosestPointOnCollision;
		return ((UPrimitiveComponent*)Self)->GetDistanceToCollision(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(INT_PTR Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		((UPrimitiveComponent*)Self)->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT UPrimitiveComponent* E_UPrimitiveComponent_GetLODParentPrimitive(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->GetLODParentPrimitive();
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_GetPhysicsAngularVelocity(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector(((UPrimitiveComponent*)Self)->GetPhysicsAngularVelocity(_p0));
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_GetPhysicsLinearVelocity(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector(((UPrimitiveComponent*)Self)->GetPhysicsLinearVelocity(_p0));
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(INT_PTR Self, INT_PTR Point, char* BoneName)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector(((UPrimitiveComponent*)Self)->GetPhysicsLinearVelocityAtPoint(_p0, _p1));
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_HasStaticLighting(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->HasStaticLighting();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_IgnoreActorWhenMoving(INT_PTR Self, AActor* Actor, bool bShouldIgnore)
	{
		auto _p0 = Actor;
		auto _p1 = bShouldIgnore;
		((UPrimitiveComponent*)Self)->IgnoreActorWhenMoving(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_IgnoreComponentWhenMoving(INT_PTR Self, UPrimitiveComponent* Component, bool bShouldIgnore)
	{
		auto _p0 = Component;
		auto _p1 = bShouldIgnore;
		((UPrimitiveComponent*)Self)->IgnoreComponentWhenMoving(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsAttachedToStreamingManager(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->IsAttachedToStreamingManager();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsComponentIndividuallySelected(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->IsComponentIndividuallySelected();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsOverlappingActor(INT_PTR Self, AActor* Other)
	{
		auto _p0 = Other;
		return ((UPrimitiveComponent*)Self)->IsOverlappingActor(_p0);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->IsPostPhysicsComponentTickEnabled();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsWelded(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->IsWelded();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_K2_IsCollisionEnabled(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->K2_IsCollisionEnabled();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->K2_IsPhysicsCollisionEnabled();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->K2_IsQueryCollisionEnabled();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_PushHoveredToProxy(INT_PTR Self, bool bInHovered)
	{
		auto _p0 = bInHovered;
		((UPrimitiveComponent*)Self)->PushHoveredToProxy(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_PushSelectionToProxy(INT_PTR Self)
	{
		((UPrimitiveComponent*)Self)->PushSelectionToProxy();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_PutAllRigidBodiesToSleep(INT_PTR Self)
	{
		((UPrimitiveComponent*)Self)->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_PutRigidBodyToSleep(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->PutRigidBodyToSleep(_p0);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_RigidBodyIsAwake(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return ((UPrimitiveComponent*)Self)->RigidBodyIsAwake(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllMassScale(INT_PTR Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UPrimitiveComponent*)Self)->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllPhysicsAngularVelocity(INT_PTR Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		((UPrimitiveComponent*)Self)->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(INT_PTR Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		((UPrimitiveComponent*)Self)->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllPhysicsPosition(INT_PTR Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		((UPrimitiveComponent*)Self)->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAngularDamping(INT_PTR Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UPrimitiveComponent*)Self)->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetBoundsScale(INT_PTR Self, float NewBoundsScale)
	{
		auto _p0 = NewBoundsScale;
		((UPrimitiveComponent*)Self)->SetBoundsScale(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCachedMaxDrawDistance(INT_PTR Self, float NewCachedMaxDrawDistance)
	{
		auto _p0 = NewCachedMaxDrawDistance;
		((UPrimitiveComponent*)Self)->SetCachedMaxDrawDistance(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCastShadow(INT_PTR Self, bool NewCastShadow)
	{
		auto _p0 = NewCastShadow;
		((UPrimitiveComponent*)Self)->SetCastShadow(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCenterOfMass(INT_PTR Self, INT_PTR CenterOfMassOffset, char* BoneName)
	{
		auto _p0 = *(FVector*)CenterOfMassOffset;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->SetCenterOfMass(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCollisionObjectType(INT_PTR Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		((UPrimitiveComponent*)Self)->SetCollisionObjectType(_p0);
	}

#pragma optimize("", off)
	DOTNET_EXPORT void E_UPrimitiveComponent_SetCollisionProfileName(INT_PTR Self, char* InCollisionProfileName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InCollisionProfileName));
		((UPrimitiveComponent*)Self)->SetCollisionProfileName(_p0);
	}
#pragma optimize("", on)

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCullDistance(INT_PTR Self, float NewCullDistance)
	{
		auto _p0 = NewCullDistance;
		((UPrimitiveComponent*)Self)->SetCullDistance(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCustomDepthStencilValue(INT_PTR Self, int32 Value)
	{
		auto _p0 = Value;
		((UPrimitiveComponent*)Self)->SetCustomDepthStencilValue(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(INT_PTR Self, ERendererStencilMask WriteMaskBit)
	{
		auto _p0 = WriteMaskBit;
		((UPrimitiveComponent*)Self)->SetCustomDepthStencilWriteMask(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetDepthPriorityGroup(INT_PTR Self, ESceneDepthPriorityGroup NewDepthPriorityGroup)
	{
		auto _p0 = NewDepthPriorityGroup;
		((UPrimitiveComponent*)Self)->SetDepthPriorityGroup(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetEnableGravity(INT_PTR Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UPrimitiveComponent*)Self)->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetLinearDamping(INT_PTR Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UPrimitiveComponent*)Self)->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetLODParentPrimitive(INT_PTR Self, UPrimitiveComponent* InLODParentPrimitive)
	{
		auto _p0 = InLODParentPrimitive;
		((UPrimitiveComponent*)Self)->SetLODParentPrimitive(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetMassOverrideInKg(INT_PTR Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		((UPrimitiveComponent*)Self)->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetMassScale(INT_PTR Self, char* BoneName, float InMassScale)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p1 = InMassScale;
		((UPrimitiveComponent*)Self)->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetNotifyRigidBodyCollision(INT_PTR Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UPrimitiveComponent*)Self)->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetOnlyOwnerSee(INT_PTR Self, bool bNewOnlyOwnerSee)
	{
		auto _p0 = bNewOnlyOwnerSee;
		((UPrimitiveComponent*)Self)->SetOnlyOwnerSee(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetOwnerNoSee(INT_PTR Self, bool bNewOwnerNoSee)
	{
		auto _p0 = bNewOwnerNoSee;
		((UPrimitiveComponent*)Self)->SetOwnerNoSee(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPhysicsAngularVelocity(INT_PTR Self, INT_PTR NewAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->SetPhysicsAngularVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPhysicsLinearVelocity(INT_PTR Self, INT_PTR NewVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->SetPhysicsLinearVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(INT_PTR Self, float NewMaxAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = NewMaxAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->SetPhysicsMaxAngularVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(INT_PTR Self, bool bEnable)
	{
		auto _p0 = bEnable;
		((UPrimitiveComponent*)Self)->SetPostPhysicsComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetReceivesDecals(INT_PTR Self, bool bNewReceivesDecals)
	{
		auto _p0 = bNewReceivesDecals;
		((UPrimitiveComponent*)Self)->SetReceivesDecals(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetRenderCustomDepth(INT_PTR Self, bool bValue)
	{
		auto _p0 = bValue;
		((UPrimitiveComponent*)Self)->SetRenderCustomDepth(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetRenderInMainPass(INT_PTR Self, bool bValue)
	{
		auto _p0 = bValue;
		((UPrimitiveComponent*)Self)->SetRenderInMainPass(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetRenderInMono(INT_PTR Self, bool bValue)
	{
		auto _p0 = bValue;
		((UPrimitiveComponent*)Self)->SetRenderInMono(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetSimulatePhysics(INT_PTR Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UPrimitiveComponent*)Self)->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(INT_PTR Self, bool bNewSingleSampleShadowFromStationaryLights)
	{
		auto _p0 = bNewSingleSampleShadowFromStationaryLights;
		((UPrimitiveComponent*)Self)->SetSingleSampleShadowFromStationaryLights(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetTranslucentSortPriority(INT_PTR Self, int32 NewTranslucentSortPriority)
	{
		auto _p0 = NewTranslucentSortPriority;
		((UPrimitiveComponent*)Self)->SetTranslucentSortPriority(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(INT_PTR Self, bool bNewUseViewOwnerDepthPriorityGroup, ESceneDepthPriorityGroup NewViewOwnerDepthPriorityGroup)
	{
		auto _p0 = bNewUseViewOwnerDepthPriorityGroup;
		auto _p1 = NewViewOwnerDepthPriorityGroup;
		((UPrimitiveComponent*)Self)->SetViewOwnerDepthPriorityGroup(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_ShouldComponentAddToScene(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->ShouldComponentAddToScene();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SyncComponentToRBPhysics(INT_PTR Self)
	{
		((UPrimitiveComponent*)Self)->SyncComponentToRBPhysics();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_UnWeldChildren(INT_PTR Self)
	{
		((UPrimitiveComponent*)Self)->UnWeldChildren();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_UnWeldFromParent(INT_PTR Self)
	{
		((UPrimitiveComponent*)Self)->UnWeldFromParent();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_UpdatePhysicsToRBChannels(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_WakeAllRigidBodies(INT_PTR Self)
	{
		((UPrimitiveComponent*)Self)->WakeAllRigidBodies();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_WakeRigidBody(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_WeldTo(INT_PTR Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		((UPrimitiveComponent*)Self)->WeldTo(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
