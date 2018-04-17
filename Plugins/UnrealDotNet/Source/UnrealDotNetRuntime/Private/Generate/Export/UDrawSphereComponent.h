#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/DrawSphereComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\DrawSphereComponent.h:18

class E_PROTECTED_WRAP_UDrawSphereComponent : protected UDrawSphereComponent
{
public:
	bool AreAllCollideableDescendantsRelative_WRAP(bool bAllowCachedValue)
	{
		return AreAllCollideableDescendantsRelative(bAllowCachedValue);
	}

	bool MoveComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		return MoveComponentImpl(Delta, NewRotation, bSweep, OutHit, MoveFlags, Teleport);
	}

	void OnComponentCollisionSettingsChanged_WRAP()
	{
		OnComponentCollisionSettingsChanged();
	}

	void OnCreatePhysicsState_WRAP()
	{
		OnCreatePhysicsState();
	}

	void OnDestroyPhysicsState_WRAP()
	{
		OnDestroyPhysicsState();
	}

	bool SupportsStaticLighting_WRAP()
	{
		return SupportsStaticLighting();
	}

	void UpdatePhysicsToRBChannels_WRAP()
	{
		UpdatePhysicsToRBChannels();
	}

	void OnChildAttached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildAttached(ChildComponent);
	}

	void OnChildDetached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildDetached(ChildComponent);
	}

	void OnHiddenInGameChanged_WRAP()
	{
		OnHiddenInGameChanged();
	}

	void OnVisibilityChanged_WRAP()
	{
		OnVisibilityChanged();
	}

	void SendRenderDynamicData_Concurrent_WRAP()
	{
		SendRenderDynamicData_Concurrent();
	}

	bool ShouldActivate_WRAP()
	{
		return ShouldActivate();
	}

}
;

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDrawSphereComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDrawSphereComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AreSymmetricRotations(UDrawSphereComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CalcBoundingCylinder(UDrawSphereComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsZeroExtent(UDrawSphereComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_UpdateBodySetup(UDrawSphereComponent* Self)
	{
		Self->UpdateBodySetup();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsNavigationRelevant(UDrawSphereComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ShouldCollideWhenPlacing(UDrawSphereComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddAngularImpulse(UDrawSphereComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddAngularImpulseInRadians(UDrawSphereComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddForce(UDrawSphereComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddForceAtLocation(UDrawSphereComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddForceAtLocationLocal(UDrawSphereComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddImpulse(UDrawSphereComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddImpulseAtLocation(UDrawSphereComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddRadialForce(UDrawSphereComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddRadialImpulse(UDrawSphereComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AreAllCollideableDescendantsRelative(UDrawSphereComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_BeginDestroy(UDrawSphereComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_BeginPlay(UDrawSphereComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CalculateMass(UDrawSphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CanCharacterStepUp(UDrawSphereComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CanEditSimulatePhysics(UDrawSphereComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CreateRenderState_Concurrent(UDrawSphereComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_DestroyRenderState_Concurrent(UDrawSphereComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_FinishDestroy(UDrawSphereComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetAngularDamping(UDrawSphereComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetCollisionObjectType(UDrawSphereComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetCollisionResponseToChannel(UDrawSphereComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetComponentVelocity(UDrawSphereComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetDiffuseBoost(UDrawSphereComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetEmissiveBoost(UDrawSphereComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetInertiaTensor(UDrawSphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetLightAndShadowMapMemoryUsage(UDrawSphereComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetLightMapResolution(UDrawSphereComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetLinearDamping(UDrawSphereComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetMass(UDrawSphereComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetMassScale(UDrawSphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetNavigationBounds(UDrawSphereComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetNumMaterials(UDrawSphereComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetShadowIndirectOnly(UDrawSphereComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetSquaredDistanceToCollision(UDrawSphereComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetStaticDepthPriorityGroup(UDrawSphereComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetStaticLightMapResolution(UDrawSphereComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_HasValidPhysicsState(UDrawSphereComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_HasValidSettingsForStaticLighting(UDrawSphereComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_InvalidateLightingCacheDetailed(UDrawSphereComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsAnyRigidBodyAwake(UDrawSphereComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsEditorOnly(UDrawSphereComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsGravityEnabled(UDrawSphereComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsReadyForFinishDestroy(UDrawSphereComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsSimulatingPhysics(UDrawSphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsWorldGeometry(UDrawSphereComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_MoveComponentImpl(UDrawSphereComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_NeedsLoadForClient(UDrawSphereComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_NeedsLoadForServer(UDrawSphereComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnActorEnableCollisionChanged(UDrawSphereComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnAttachmentChanged(UDrawSphereComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnComponentCollisionSettingsChanged(UDrawSphereComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnComponentDestroyed(UDrawSphereComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnCreatePhysicsState(UDrawSphereComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnDestroyPhysicsState(UDrawSphereComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnRegister(UDrawSphereComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnUnregister(UDrawSphereComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnUpdateTransform(UDrawSphereComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PostDuplicate(UDrawSphereComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PostLoad(UDrawSphereComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PutAllRigidBodiesToSleep(UDrawSphereComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_RegisterComponentTickFunctions(UDrawSphereComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ScaleByMomentOfInertia(UDrawSphereComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SendRenderTransform_Concurrent(UDrawSphereComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetAllMassScale(UDrawSphereComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetAllPhysicsAngularVelocity(UDrawSphereComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetAllPhysicsAngularVelocityInRadians(UDrawSphereComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetAllPhysicsLinearVelocity(UDrawSphereComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetAllPhysicsPosition(UDrawSphereComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetAllUseCCD(UDrawSphereComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetAngularDamping(UDrawSphereComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetCollisionObjectType(UDrawSphereComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetCollisionProfileName(UDrawSphereComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetCollisionResponseToAllChannels(UDrawSphereComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetCollisionResponseToChannel(UDrawSphereComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetCollisionResponseToChannels(UDrawSphereComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetEnableGravity(UDrawSphereComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetLinearDamping(UDrawSphereComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetMassOverrideInKg(UDrawSphereComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetMassScale(UDrawSphereComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetNotifyRigidBodyCollision(UDrawSphereComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetSimulatePhysics(UDrawSphereComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetUseCCD(UDrawSphereComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ShouldCreatePhysicsState(UDrawSphereComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ShouldRecreateProxyOnUpdateTransform(UDrawSphereComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ShouldRenderSelected(UDrawSphereComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SupportsStaticLighting(UDrawSphereComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_UnWeldChildren(UDrawSphereComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_UnWeldFromParent(UDrawSphereComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_UpdatePhysicsToRBChannels(UDrawSphereComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_UpdatePhysicsVolume(UDrawSphereComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_UsesOnlyUnlitMaterials(UDrawSphereComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_WakeAllRigidBodies(UDrawSphereComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_WakeRigidBody(UDrawSphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_WeldTo(UDrawSphereComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_WeldToImplementation(UDrawSphereComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ApplyWorldOffset(UDrawSphereComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CanAttachAsChild(UDrawSphereComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_DestroyComponent(UDrawSphereComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_DetachFromComponent(UDrawSphereComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_DetachFromParent(UDrawSphereComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_DoesSocketExist(UDrawSphereComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetSocketLocation(UDrawSphereComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetSocketQuaternion(UDrawSphereComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetSocketRotation(UDrawSphereComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetSocketTransform(UDrawSphereComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_HasAnySockets(UDrawSphereComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsAnySimulatingPhysics(UDrawSphereComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsPrecomputedLightingValid(UDrawSphereComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsVisible(UDrawSphereComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsVisibleInEditor(UDrawSphereComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnChildAttached(UDrawSphereComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnChildDetached(UDrawSphereComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnHiddenInGameChanged(UDrawSphereComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnVisibilityChanged(UDrawSphereComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PostNetReceive(UDrawSphereComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PostRepNotifies(UDrawSphereComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PreNetReceive(UDrawSphereComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PropagateLightingScenarioChange(UDrawSphereComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetRelativeScale3D(UDrawSphereComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ShouldCreateRenderState(UDrawSphereComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_Activate(UDrawSphereComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddTickPrerequisiteActor(UDrawSphereComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddTickPrerequisiteComponent(UDrawSphereComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_Deactivate(UDrawSphereComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetComponentClassCanReplicate(UDrawSphereComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetReadableName(UDrawSphereComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_InitializeComponent(UDrawSphereComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsActive(UDrawSphereComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsNameStableForNetworking(UDrawSphereComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsReadyForOwnerToAutoDestroy(UDrawSphereComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsSupportedForNetworking(UDrawSphereComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_MarkAsEditorOnlySubobject(UDrawSphereComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_NeedsLoadForEditorGame(UDrawSphereComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnComponentCreated(UDrawSphereComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PostInitProperties(UDrawSphereComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PostRename(UDrawSphereComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_RemoveTickPrerequisiteActor(UDrawSphereComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_RemoveTickPrerequisiteComponent(UDrawSphereComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_RequiresGameThreadEndOfFrameRecreate(UDrawSphereComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_RequiresGameThreadEndOfFrameUpdates(UDrawSphereComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SendRenderDynamicData_Concurrent(UDrawSphereComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetActive(UDrawSphereComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetAutoActivate(UDrawSphereComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetComponentTickEnabled(UDrawSphereComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_SetComponentTickEnabledAsync(UDrawSphereComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ShouldActivate(UDrawSphereComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UDrawSphereComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ToggleActive(UDrawSphereComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_UninitializeComponent(UDrawSphereComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AreNativePropertiesIdenticalTo(UDrawSphereComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CheckDefaultSubobjectsInternal(UDrawSphereComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetDesc(UDrawSphereComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_GetDetailedInfoInternal(UDrawSphereComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsAsset(UDrawSphereComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsFullNameStableForNetworking(UDrawSphereComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsLocalizedResource(UDrawSphereComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsPostLoadThreadSafe(UDrawSphereComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_IsSafeForRootSet(UDrawSphereComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_Modify(UDrawSphereComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_NotifyObjectReferenceEliminated(UDrawSphereComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PostCDOContruct(UDrawSphereComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PostEditImport(UDrawSphereComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PostSaveRoot(UDrawSphereComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_PreDestroyFromReplication(UDrawSphereComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_ShutdownAfterError(UDrawSphereComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_AddToCluster(UDrawSphereComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CanBeClusterRoot(UDrawSphereComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CanBeInCluster(UDrawSphereComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_CreateCluster(UDrawSphereComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UDrawSphereComponent_OnClusterMarkedAsPendingKill(UDrawSphereComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
