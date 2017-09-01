#pragma once

#include "CoreMinimal.h"
#include "Components/PrimitiveComponent.h"

class E_PROTECTED_WRAP_UPrimitiveComponent : protected UPrimitiveComponent
{
	public:
	bool AreAllCollideableDescendantsRelative_WRAP(bool bAllowCachedValue)
	{
		return AreAllCollideableDescendantsRelative(bAllowCachedValue);
	}

}
;

extern "C"
{
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_MinDrawDistance_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->MinDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_MinDrawDistance_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->MinDrawDistance = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LDMaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LDMaxDrawDistance = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->CachedMaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->CachedMaxDrawDistance = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->CustomDepthStencilValue; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->CustomDepthStencilValue = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->TranslucencySortPriority; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->TranslucencySortPriority = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_VisibilityId_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->VisibilityId; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_VisibilityId_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->VisibilityId = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LpvBiasMultiplier; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LpvBiasMultiplier = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_BoundsScale_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->BoundsScale; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_BoundsScale_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->BoundsScale = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LastSubmitTime_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LastSubmitTime; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastSubmitTime_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LastSubmitTime = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LastRenderTime_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LastRenderTime; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastRenderTime_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LastRenderTime = Value; }
	
	DOTNET_EXPORT float E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->LastRenderTimeOnScreen; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(INT_PTR Ptr, float Value) { ((UPrimitiveComponent*)Ptr)->LastRenderTimeOnScreen = Value; }
	
	DOTNET_EXPORT int32 E_PROP_UPrimitiveComponent_CurrentTag_GET(INT_PTR Ptr) { return ((UPrimitiveComponent*)Ptr)->CurrentTag; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CurrentTag_SET(INT_PTR Ptr, int32 Value) { ((UPrimitiveComponent*)Ptr)->CurrentTag = Value; }
	
	DOTNET_EXPORT bool E_UPrimitiveComponent_IsAttachedToStreamingManager(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->IsAttachedToStreamingManager();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(INT_PTR Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
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

	DOTNET_EXPORT void E_UPrimitiveComponent_BeginComponentOverlap(INT_PTR Self, INT_PTR OtherOverlap, bool bDoNotifies)
	{
		auto _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		((UPrimitiveComponent*)Self)->BeginComponentOverlap(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_EndComponentOverlap(INT_PTR Self, INT_PTR OtherOverlap, bool bDoNotifies, bool bSkipNotifySelf)
	{
		auto _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		auto _p2 = bSkipNotifySelf;
		((UPrimitiveComponent*)Self)->EndComponentOverlap(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_IsOverlappingActor(INT_PTR Self, AActor* Other)
	{
		auto _p0 = Other;
		return ((UPrimitiveComponent*)Self)->IsOverlappingActor(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetBoundsScale(INT_PTR Self, float NewBoundsScale)
	{
		auto _p0 = NewBoundsScale;
		((UPrimitiveComponent*)Self)->SetBoundsScale(_p0);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_CanEditSimulatePhysics(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->CanEditSimulatePhysics();
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

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPhysicsLinearVelocity(INT_PTR Self, INT_PTR NewVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->SetPhysicsLinearVelocity(_p0, _p1, _p2);
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

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(INT_PTR Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		((UPrimitiveComponent*)Self)->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(INT_PTR Self, float NewMaxAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = NewMaxAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->SetPhysicsMaxAngularVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_GetCenterOfMass(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector(((UPrimitiveComponent*)Self)->GetCenterOfMass(_p0));
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCenterOfMass(INT_PTR Self, INT_PTR CenterOfMassOffset, char* BoneName)
	{
		auto _p0 = *(FVector*)CenterOfMassOffset;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->SetCenterOfMass(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_WakeRigidBody(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetTranslucentSortPriority(INT_PTR Self, int32 NewTranslucentSortPriority)
	{
		auto _p0 = NewTranslucentSortPriority;
		((UPrimitiveComponent*)Self)->SetTranslucentSortPriority(_p0);
	}

	DOTNET_EXPORT char* E_UPrimitiveComponent_GetCollisionProfileName(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((UPrimitiveComponent*)Self)->GetCollisionProfileName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetLODParentPrimitive(INT_PTR Self, UPrimitiveComponent* InLODParentPrimitive)
	{
		auto _p0 = InLODParentPrimitive;
		((UPrimitiveComponent*)Self)->SetLODParentPrimitive(_p0);
	}

	DOTNET_EXPORT UPrimitiveComponent* E_UPrimitiveComponent_GetLODParentPrimitive(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->GetLODParentPrimitive();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_GetLightMapResolution(INT_PTR Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return ((UPrimitiveComponent*)Self)->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT int32 E_UPrimitiveComponent_GetStaticLightMapResolution(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(INT_PTR Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		((UPrimitiveComponent*)Self)->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT uint8 E_UPrimitiveComponent_GetStaticDepthPriorityGroup(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_GetSquaredDistanceToCollision(INT_PTR Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return ((UPrimitiveComponent*)Self)->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_GetDistanceToCollision(INT_PTR Self, INT_PTR Point, INT_PTR ClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)ClosestPointOnCollision;
		return ((UPrimitiveComponent*)Self)->GetDistanceToCollision(_p0, _p1);
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_GetClosestPointOnCollision(INT_PTR Self, INT_PTR Point, INT_PTR OutPointOnBody, char* BoneName)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)OutPointOnBody;
		auto _p2 = FName(UTF8_TO_TCHAR(BoneName));
		return ((UPrimitiveComponent*)Self)->GetClosestPointOnCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_WeldTo(INT_PTR Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		((UPrimitiveComponent*)Self)->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_WeldToImplementation(INT_PTR Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = FName(UTF8_TO_TCHAR(ParentSocketName));
		auto _p2 = bWeldSimulatedChild;
		return ((UPrimitiveComponent*)Self)->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_DispatchWakeEvents(INT_PTR Self, int32 WakeEvent, char* BoneName)
	{
		auto _p0 = WakeEvent;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		((UPrimitiveComponent*)Self)->DispatchWakeEvents(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_AreSymmetricRotations(INT_PTR Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return ((UPrimitiveComponent*)Self)->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_PushHoveredToProxy(INT_PTR Self, bool bInHovered)
	{
		auto _p0 = bInHovered;
		((UPrimitiveComponent*)Self)->PushHoveredToProxy(_p0);
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_GetEmissiveBoost(INT_PTR Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return ((UPrimitiveComponent*)Self)->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllPhysicsAngularVelocity(INT_PTR Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		((UPrimitiveComponent*)Self)->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetAllPhysicsPosition(INT_PTR Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		((UPrimitiveComponent*)Self)->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_GetLinearDamping(INT_PTR Self)
	{
		return ((UPrimitiveComponent*)Self)->GetLinearDamping();
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetMassScale(INT_PTR Self, char* BoneName, float InMassScale)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p1 = InMassScale;
		((UPrimitiveComponent*)Self)->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_GetMassScale(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return ((UPrimitiveComponent*)Self)->GetMassScale(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetMassOverrideInKg(INT_PTR Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		((UPrimitiveComponent*)Self)->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT INT_PTR E_UPrimitiveComponent_ScaleByMomentOfInertia(INT_PTR Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = FName(UTF8_TO_TCHAR(BoneName));
		return (INT_PTR) new FVector(((UPrimitiveComponent*)Self)->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT float E_UPrimitiveComponent_CalculateMass(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return ((UPrimitiveComponent*)Self)->CalculateMass(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_SetCachedMaxDrawDistance(INT_PTR Self, float NewCachedMaxDrawDistance)
	{
		auto _p0 = NewCachedMaxDrawDistance;
		((UPrimitiveComponent*)Self)->SetCachedMaxDrawDistance(_p0);
	}

	DOTNET_EXPORT bool E_UPrimitiveComponent_CanBeBaseForCharacter(INT_PTR Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return ((UPrimitiveComponent*)Self)->CanBeBaseForCharacter(_p0);
	}

	DOTNET_EXPORT void E_UPrimitiveComponent_DispatchMouseOverEvents(INT_PTR Self, UPrimitiveComponent* CurrentComponent, UPrimitiveComponent* NewComponent)
	{
		auto _p0 = CurrentComponent;
		auto _p1 = NewComponent;
		((UPrimitiveComponent*)Self)->DispatchMouseOverEvents(_p0, _p1);
	}

}
