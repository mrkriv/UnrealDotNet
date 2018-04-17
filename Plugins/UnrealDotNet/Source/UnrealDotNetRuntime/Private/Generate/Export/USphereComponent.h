#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/SphereComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SphereComponent.h:17

class E_PROTECTED_WRAP_USphereComponent : protected USphereComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_USphereComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USphereComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USphereComponent_AreSymmetricRotations(USphereComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_CalcBoundingCylinder(USphereComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_GetScaledSphereRadius(USphereComponent* Self)
	{
		return Self->GetScaledSphereRadius();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetShapeScale(USphereComponent* Self)
	{
		return Self->GetShapeScale();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetUnscaledSphereRadius(USphereComponent* Self)
	{
		return Self->GetUnscaledSphereRadius();
	}

	DOTNET_EXPORT auto E_USphereComponent_InitSphereRadius(USphereComponent* Self, float InSphereRadius)
	{
		auto _p0 = InSphereRadius;
		Self->InitSphereRadius(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_IsZeroExtent(USphereComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_USphereComponent_SetSphereRadius(USphereComponent* Self, float InSphereRadius, bool bUpdateOverlaps)
	{
		auto _p0 = InSphereRadius;
		auto _p1 = bUpdateOverlaps;
		Self->SetSphereRadius(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_UpdateBodySetup(USphereComponent* Self)
	{
		Self->UpdateBodySetup();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsNavigationRelevant(USphereComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_USphereComponent_ShouldCollideWhenPlacing(USphereComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USphereComponent_AddAngularImpulse(USphereComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddAngularImpulseInRadians(USphereComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddForce(USphereComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddForceAtLocation(USphereComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddForceAtLocationLocal(USphereComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddImpulse(USphereComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddImpulseAtLocation(USphereComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddRadialForce(USphereComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddRadialImpulse(USphereComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_USphereComponent_AreAllCollideableDescendantsRelative(USphereComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_USphereComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_BeginDestroy(USphereComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_USphereComponent_BeginPlay(USphereComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_USphereComponent_CalculateMass(USphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_CanCharacterStepUp(USphereComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_CanEditSimulatePhysics(USphereComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_USphereComponent_CreateRenderState_Concurrent(USphereComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USphereComponent_DestroyRenderState_Concurrent(USphereComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_USphereComponent_FinishDestroy(USphereComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetAngularDamping(USphereComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetCollisionObjectType(USphereComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetCollisionResponseToChannel(USphereComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_GetComponentVelocity(USphereComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USphereComponent_GetDiffuseBoost(USphereComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_GetEmissiveBoost(USphereComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_GetInertiaTensor(USphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_USphereComponent_GetLightAndShadowMapMemoryUsage(USphereComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_GetLightMapResolution(USphereComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_GetLinearDamping(USphereComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetMass(USphereComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetMassScale(USphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_GetNavigationBounds(USphereComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_USphereComponent_GetNumMaterials(USphereComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetShadowIndirectOnly(USphereComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetSquaredDistanceToCollision(USphereComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_GetStaticDepthPriorityGroup(USphereComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetStaticLightMapResolution(USphereComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_USphereComponent_HasValidPhysicsState(USphereComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_USphereComponent_HasValidSettingsForStaticLighting(USphereComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_InvalidateLightingCacheDetailed(USphereComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_IsAnyRigidBodyAwake(USphereComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsEditorOnly(USphereComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsGravityEnabled(USphereComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsReadyForFinishDestroy(USphereComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsSimulatingPhysics(USphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_IsWorldGeometry(USphereComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USphereComponent_MoveComponentImpl(USphereComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USphereComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USphereComponent_NeedsLoadForClient(USphereComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_USphereComponent_NeedsLoadForServer(USphereComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnActorEnableCollisionChanged(USphereComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnAttachmentChanged(USphereComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnComponentCollisionSettingsChanged(USphereComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnComponentDestroyed(USphereComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_OnCreatePhysicsState(USphereComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnDestroyPhysicsState(USphereComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnRegister(USphereComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnUnregister(USphereComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnUpdateTransform(USphereComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_PostDuplicate(USphereComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_PostLoad(USphereComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_USphereComponent_PutAllRigidBodiesToSleep(USphereComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_USphereComponent_RegisterComponentTickFunctions(USphereComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_ScaleByMomentOfInertia(USphereComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USphereComponent_SendRenderTransform_Concurrent(USphereComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_USphereComponent_SetAllMassScale(USphereComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetAllPhysicsAngularVelocity(USphereComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetAllPhysicsAngularVelocityInRadians(USphereComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetAllPhysicsLinearVelocity(USphereComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetAllPhysicsPosition(USphereComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetAllUseCCD(USphereComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetAngularDamping(USphereComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetCollisionObjectType(USphereComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetCollisionProfileName(USphereComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetCollisionResponseToAllChannels(USphereComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetCollisionResponseToChannel(USphereComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetCollisionResponseToChannels(USphereComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetEnableGravity(USphereComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetLinearDamping(USphereComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetMassOverrideInKg(USphereComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetMassScale(USphereComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetNotifyRigidBodyCollision(USphereComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetSimulatePhysics(USphereComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetUseCCD(USphereComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_ShouldCreatePhysicsState(USphereComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_USphereComponent_ShouldRecreateProxyOnUpdateTransform(USphereComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_USphereComponent_ShouldRenderSelected(USphereComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_USphereComponent_SupportsStaticLighting(USphereComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USphereComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_USphereComponent_UnWeldChildren(USphereComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_USphereComponent_UnWeldFromParent(USphereComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_USphereComponent_UpdatePhysicsToRBChannels(USphereComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_USphereComponent_UpdatePhysicsVolume(USphereComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_UsesOnlyUnlitMaterials(USphereComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_USphereComponent_WakeAllRigidBodies(USphereComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_USphereComponent_WakeRigidBody(USphereComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_WeldTo(USphereComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_WeldToImplementation(USphereComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USphereComponent_ApplyWorldOffset(USphereComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_CanAttachAsChild(USphereComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_DestroyComponent(USphereComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_DetachFromComponent(USphereComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_DetachFromParent(USphereComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_DoesSocketExist(USphereComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_GetSocketLocation(USphereComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USphereComponent_GetSocketQuaternion(USphereComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USphereComponent_GetSocketRotation(USphereComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USphereComponent_GetSocketTransform(USphereComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USphereComponent_HasAnySockets(USphereComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsAnySimulatingPhysics(USphereComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsPrecomputedLightingValid(USphereComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsVisible(USphereComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsVisibleInEditor(USphereComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnChildAttached(USphereComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USphereComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_OnChildDetached(USphereComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USphereComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_OnHiddenInGameChanged(USphereComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnVisibilityChanged(USphereComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USphereComponent_PostNetReceive(USphereComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_USphereComponent_PostRepNotifies(USphereComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_USphereComponent_PreNetReceive(USphereComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_USphereComponent_PropagateLightingScenarioChange(USphereComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USphereComponent_SetRelativeScale3D(USphereComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_ShouldCreateRenderState(USphereComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_USphereComponent_Activate(USphereComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddTickPrerequisiteActor(USphereComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_AddTickPrerequisiteComponent(USphereComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_Deactivate(USphereComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetComponentClassCanReplicate(USphereComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetReadableName(USphereComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_USphereComponent_InitializeComponent(USphereComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsActive(USphereComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsNameStableForNetworking(USphereComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsReadyForOwnerToAutoDestroy(USphereComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsSupportedForNetworking(USphereComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_USphereComponent_MarkAsEditorOnlySubobject(USphereComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_USphereComponent_NeedsLoadForEditorGame(USphereComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnComponentCreated(USphereComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_USphereComponent_PostInitProperties(USphereComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_USphereComponent_PostRename(USphereComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_RemoveTickPrerequisiteActor(USphereComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_RemoveTickPrerequisiteComponent(USphereComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_RequiresGameThreadEndOfFrameRecreate(USphereComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_USphereComponent_RequiresGameThreadEndOfFrameUpdates(USphereComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_USphereComponent_SendRenderDynamicData_Concurrent(USphereComponent* Self)
	{
		((E_PROTECTED_WRAP_USphereComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_USphereComponent_SetActive(USphereComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetAutoActivate(USphereComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetComponentTickEnabled(USphereComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_SetComponentTickEnabledAsync(USphereComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_ShouldActivate(USphereComponent* Self)
	{
		return ((E_PROTECTED_WRAP_USphereComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_USphereComponent_ToggleActive(USphereComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_USphereComponent_UninitializeComponent(USphereComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_USphereComponent_AreNativePropertiesIdenticalTo(USphereComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_CheckDefaultSubobjectsInternal(USphereComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_USphereComponent_GetDesc(USphereComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_USphereComponent_GetDetailedInfoInternal(USphereComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_USphereComponent_IsAsset(USphereComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsFullNameStableForNetworking(USphereComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsLocalizedResource(USphereComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsPostLoadThreadSafe(USphereComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_USphereComponent_IsSafeForRootSet(USphereComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_USphereComponent_Modify(USphereComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_NotifyObjectReferenceEliminated(USphereComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_USphereComponent_PostCDOContruct(USphereComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_USphereComponent_PostEditImport(USphereComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_USphereComponent_PostSaveRoot(USphereComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_USphereComponent_PreDestroyFromReplication(USphereComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_USphereComponent_ShutdownAfterError(USphereComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_USphereComponent_AddToCluster(USphereComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USphereComponent_CanBeClusterRoot(USphereComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_USphereComponent_CanBeInCluster(USphereComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_USphereComponent_CreateCluster(USphereComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_USphereComponent_OnClusterMarkedAsPendingKill(USphereComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
