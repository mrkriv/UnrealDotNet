#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/PrimitiveComponent.h"

class E_PROTECTED_WRAP_UPrimitiveComponent : protected UPrimitiveComponent
{
public:
	bool AreAllCollideableDescendantsRelative_WRAP(bool bAllowCachedValue)
	{
		return AreAllCollideableDescendantsRelative(bAllowCachedValue);
	}

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

	void SendPhysicsTransform_WRAP(ETeleportType Teleport)
	{
		SendPhysicsTransform(Teleport);
	}

	bool SupportsStaticLighting_WRAP()
	{
		return SupportsStaticLighting();
	}

	void UpdatePhysicsToRBChannels_WRAP()
	{
		UpdatePhysicsToRBChannels();
	}

}
;

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_BoundsScale_GET(UPrimitiveComponent* Ptr) { return Ptr->BoundsScale; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_BoundsScale_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->BoundsScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(UPrimitiveComponent* Ptr) { return Ptr->CachedMaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->CachedMaxDrawDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CurrentTag_GET() { return UPrimitiveComponent::CurrentTag; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(UPrimitiveComponent* Ptr) { return Ptr->CustomDepthStencilValue; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(UPrimitiveComponent* Ptr, int32 Value) { Ptr->CustomDepthStencilValue = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_GET(UPrimitiveComponent* Ptr) { return Ptr->CustomDepthStencilWriteMask; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_SET(UPrimitiveComponent* Ptr, ERendererStencilMask Value) { Ptr->CustomDepthStencilWriteMask = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LastRenderTime_GET(UPrimitiveComponent* Ptr) { return Ptr->LastRenderTime; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastRenderTime_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LastRenderTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(UPrimitiveComponent* Ptr) { return Ptr->LastRenderTimeOnScreen; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LastRenderTimeOnScreen = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LastSubmitTime_GET(UPrimitiveComponent* Ptr) { return Ptr->LastSubmitTime; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastSubmitTime_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LastSubmitTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(UPrimitiveComponent* Ptr) { return Ptr->LDMaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LDMaxDrawDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LightingChannels_GET(UPrimitiveComponent* Ptr) { return (INT_PTR)&(Ptr->LightingChannels); }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LightingChannels_SET(UPrimitiveComponent* Ptr, INT_PTR Value) { Ptr->LightingChannels = *(FLightingChannels*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(UPrimitiveComponent* Ptr) { return Ptr->LpvBiasMultiplier; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LpvBiasMultiplier = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_MinDrawDistance_GET(UPrimitiveComponent* Ptr) { return Ptr->MinDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_MinDrawDistance_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->MinDrawDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(UPrimitiveComponent* Ptr) { return Ptr->TranslucencySortPriority; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(UPrimitiveComponent* Ptr, int32 Value) { Ptr->TranslucencySortPriority = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_VisibilityId_GET(UPrimitiveComponent* Ptr) { return Ptr->VisibilityId; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_VisibilityId_SET(UPrimitiveComponent* Ptr, int32 Value) { Ptr->VisibilityId = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPrimitiveComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPrimitiveComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddAngularImpulse(UPrimitiveComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddForce(UPrimitiveComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddForceAtLocation(UPrimitiveComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddForceAtLocationLocal(UPrimitiveComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddImpulse(UPrimitiveComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddImpulseAtLocation(UPrimitiveComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddTorque(UPrimitiveComponent* Self, INT_PTR Torque, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Torque;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddTorque(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(UPrimitiveComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CalculateMass(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CanEditSimulatePhysics(UPrimitiveComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ClearComponentOverlaps(UPrimitiveComponent* Self, bool bDoNotifies, bool bSkipNotifySelf)
	{
		auto _p0 = bDoNotifies;
		auto _p1 = bSkipNotifySelf;
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->ClearComponentOverlaps_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ClearMoveIgnoreActors(UPrimitiveComponent* Self)
	{
		Self->ClearMoveIgnoreActors();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ClearMoveIgnoreComponents(UPrimitiveComponent* Self)
	{
		Self->ClearMoveIgnoreComponents();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DisableNavigationRelevance(UPrimitiveComponent* Self)
	{
		Self->DisableNavigationRelevance();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DispatchWakeEvents(UPrimitiveComponent* Self, int32 WakeEvent, char* BoneName)
	{
		auto _p0 = WakeEvent;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->DispatchWakeEvents(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_EnsurePhysicsStateCreated(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->EnsurePhysicsStateCreated_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetAngularDamping(UPrimitiveComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetCenterOfMass(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetCenterOfMass(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetCollisionProfileName(UPrimitiveComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetCollisionProfileName());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetDiffuseBoost(UPrimitiveComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetEmissiveBoost(UPrimitiveComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetInertiaTensor(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(UPrimitiveComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetLightMapResolution(UPrimitiveComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetLinearDamping(UPrimitiveComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetMass(UPrimitiveComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetMassScale(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetNumMaterials(UPrimitiveComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetPhysicsAngularVelocity(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetPhysicsAngularVelocity(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetPhysicsLinearVelocity(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetPhysicsLinearVelocity(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(UPrimitiveComponent* Self, INT_PTR Point, char* BoneName)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetPhysicsLinearVelocityAtPoint(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetShadowIndirectOnly(UPrimitiveComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetStaticDepthPriorityGroup(UPrimitiveComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetStaticLightMapResolution(UPrimitiveComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_HasStaticLighting(UPrimitiveComponent* Self)
	{
		return Self->HasStaticLighting();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_HasValidSettingsForStaticLighting(UPrimitiveComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsAnyRigidBodyAwake(UPrimitiveComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsAttachedToStreamingManager(UPrimitiveComponent* Self)
	{
		return Self->IsAttachedToStreamingManager();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsComponentIndividuallySelected(UPrimitiveComponent* Self)
	{
		return Self->IsComponentIndividuallySelected();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsGravityEnabled(UPrimitiveComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(UPrimitiveComponent* Self)
	{
		return Self->IsPostPhysicsComponentTickEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsWelded(UPrimitiveComponent* Self)
	{
		return Self->IsWelded();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsZeroExtent(UPrimitiveComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_IsCollisionEnabled(UPrimitiveComponent* Self)
	{
		return Self->K2_IsCollisionEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(UPrimitiveComponent* Self)
	{
		return Self->K2_IsPhysicsCollisionEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(UPrimitiveComponent* Self)
	{
		return Self->K2_IsQueryCollisionEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PushHoveredToProxy(UPrimitiveComponent* Self, bool bInHovered)
	{
		auto _p0 = bInHovered;
		Self->PushHoveredToProxy(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PushSelectionToProxy(UPrimitiveComponent* Self)
	{
		Self->PushSelectionToProxy();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PutRigidBodyToSleep(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->PutRigidBodyToSleep(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_RigidBodyIsAwake(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->RigidBodyIsAwake(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ScaleByMomentOfInertia(UPrimitiveComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SendPhysicsTransform(UPrimitiveComponent* Self, ETeleportType Teleport)
	{
		auto _p0 = Teleport;
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->SendPhysicsTransform_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(UPrimitiveComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsPosition(UPrimitiveComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetBoundsScale(UPrimitiveComponent* Self, float NewBoundsScale)
	{
		auto _p0 = NewBoundsScale;
		Self->SetBoundsScale(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCachedMaxDrawDistance(UPrimitiveComponent* Self, float NewCachedMaxDrawDistance)
	{
		auto _p0 = NewCachedMaxDrawDistance;
		Self->SetCachedMaxDrawDistance(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCastShadow(UPrimitiveComponent* Self, bool NewCastShadow)
	{
		auto _p0 = NewCastShadow;
		Self->SetCastShadow(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCenterOfMass(UPrimitiveComponent* Self, INT_PTR CenterOfMassOffset, char* BoneName)
	{
		auto _p0 = *(FVector*)CenterOfMassOffset;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetCenterOfMass(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCollisionObjectType(UPrimitiveComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCollisionProfileName(UPrimitiveComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCollisionResponseToAllChannels(UPrimitiveComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCollisionResponseToChannel(UPrimitiveComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCullDistance(UPrimitiveComponent* Self, float NewCullDistance)
	{
		auto _p0 = NewCullDistance;
		Self->SetCullDistance(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCustomDepthStencilValue(UPrimitiveComponent* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetCustomDepthStencilValue(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(UPrimitiveComponent* Self, ERendererStencilMask WriteMaskBit)
	{
		auto _p0 = WriteMaskBit;
		Self->SetCustomDepthStencilWriteMask(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetDepthPriorityGroup(UPrimitiveComponent* Self, ESceneDepthPriorityGroup NewDepthPriorityGroup)
	{
		auto _p0 = NewDepthPriorityGroup;
		Self->SetDepthPriorityGroup(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetMassOverrideInKg(UPrimitiveComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetMassScale(UPrimitiveComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetOnlyOwnerSee(UPrimitiveComponent* Self, bool bNewOnlyOwnerSee)
	{
		auto _p0 = bNewOnlyOwnerSee;
		Self->SetOnlyOwnerSee(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetOwnerNoSee(UPrimitiveComponent* Self, bool bNewOwnerNoSee)
	{
		auto _p0 = bNewOwnerNoSee;
		Self->SetOwnerNoSee(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsAngularVelocity(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsAngularVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsLinearVelocity(UPrimitiveComponent* Self, INT_PTR NewVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsLinearVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(UPrimitiveComponent* Self, float NewMaxAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = NewMaxAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsMaxAngularVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(UPrimitiveComponent* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->SetPostPhysicsComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetReceivesDecals(UPrimitiveComponent* Self, bool bNewReceivesDecals)
	{
		auto _p0 = bNewReceivesDecals;
		Self->SetReceivesDecals(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetRenderCustomDepth(UPrimitiveComponent* Self, bool bValue)
	{
		auto _p0 = bValue;
		Self->SetRenderCustomDepth(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetRenderInMainPass(UPrimitiveComponent* Self, bool bValue)
	{
		auto _p0 = bValue;
		Self->SetRenderInMainPass(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetRenderInMono(UPrimitiveComponent* Self, bool bValue)
	{
		auto _p0 = bValue;
		Self->SetRenderInMono(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(UPrimitiveComponent* Self, bool bNewSingleSampleShadowFromStationaryLights)
	{
		auto _p0 = bNewSingleSampleShadowFromStationaryLights;
		Self->SetSingleSampleShadowFromStationaryLights(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetTranslucentSortPriority(UPrimitiveComponent* Self, int32 NewTranslucentSortPriority)
	{
		auto _p0 = NewTranslucentSortPriority;
		Self->SetTranslucentSortPriority(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(UPrimitiveComponent* Self, bool bNewUseViewOwnerDepthPriorityGroup, ESceneDepthPriorityGroup NewViewOwnerDepthPriorityGroup)
	{
		auto _p0 = bNewUseViewOwnerDepthPriorityGroup;
		auto _p1 = NewViewOwnerDepthPriorityGroup;
		Self->SetViewOwnerDepthPriorityGroup(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldComponentAddToScene(UPrimitiveComponent* Self)
	{
		return Self->ShouldComponentAddToScene();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldRecreateProxyOnUpdateTransform(UPrimitiveComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldRenderSelected(UPrimitiveComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SupportsStaticLighting(UPrimitiveComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SyncComponentToRBPhysics(UPrimitiveComponent* Self)
	{
		Self->SyncComponentToRBPhysics();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UsesOnlyUnlitMaterials(UPrimitiveComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_WakeRigidBody(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
