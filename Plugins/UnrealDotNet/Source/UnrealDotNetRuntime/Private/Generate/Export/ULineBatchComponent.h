#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/LineBatchComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

class E_PROTECTED_WRAP_ULineBatchComponent : protected ULineBatchComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULineBatchComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULineBatchComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddAngularImpulse(ULineBatchComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddAngularImpulseInRadians(ULineBatchComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddForce(ULineBatchComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddForceAtLocation(ULineBatchComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddForceAtLocationLocal(ULineBatchComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddImpulse(ULineBatchComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddImpulseAtLocation(ULineBatchComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddRadialForce(ULineBatchComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddRadialImpulse(ULineBatchComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AreAllCollideableDescendantsRelative(ULineBatchComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AreSymmetricRotations(ULineBatchComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_BeginDestroy(ULineBatchComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_BeginPlay(ULineBatchComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CalculateMass(ULineBatchComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CanCharacterStepUp(ULineBatchComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CanEditSimulatePhysics(ULineBatchComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CreateRenderState_Concurrent(ULineBatchComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_DestroyRenderState_Concurrent(ULineBatchComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_FinishDestroy(ULineBatchComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetAngularDamping(ULineBatchComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetCollisionObjectType(ULineBatchComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetCollisionResponseToChannel(ULineBatchComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetComponentVelocity(ULineBatchComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetDiffuseBoost(ULineBatchComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetEmissiveBoost(ULineBatchComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetInertiaTensor(ULineBatchComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetLightAndShadowMapMemoryUsage(ULineBatchComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetLightMapResolution(ULineBatchComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetLinearDamping(ULineBatchComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetMass(ULineBatchComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetMassScale(ULineBatchComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetNavigationBounds(ULineBatchComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetNumMaterials(ULineBatchComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetShadowIndirectOnly(ULineBatchComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetSquaredDistanceToCollision(ULineBatchComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetStaticDepthPriorityGroup(ULineBatchComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetStaticLightMapResolution(ULineBatchComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_HasValidPhysicsState(ULineBatchComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_HasValidSettingsForStaticLighting(ULineBatchComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_InvalidateLightingCacheDetailed(ULineBatchComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsAnyRigidBodyAwake(ULineBatchComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsEditorOnly(ULineBatchComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsGravityEnabled(ULineBatchComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsNavigationRelevant(ULineBatchComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsReadyForFinishDestroy(ULineBatchComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsSimulatingPhysics(ULineBatchComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsWorldGeometry(ULineBatchComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsZeroExtent(ULineBatchComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_MoveComponentImpl(ULineBatchComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_NeedsLoadForClient(ULineBatchComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_NeedsLoadForServer(ULineBatchComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnActorEnableCollisionChanged(ULineBatchComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnAttachmentChanged(ULineBatchComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnComponentCollisionSettingsChanged(ULineBatchComponent* Self)
	{
		((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnComponentDestroyed(ULineBatchComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnCreatePhysicsState(ULineBatchComponent* Self)
	{
		((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnDestroyPhysicsState(ULineBatchComponent* Self)
	{
		((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnRegister(ULineBatchComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnUnregister(ULineBatchComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnUpdateTransform(ULineBatchComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PostDuplicate(ULineBatchComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PostLoad(ULineBatchComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PutAllRigidBodiesToSleep(ULineBatchComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_RegisterComponentTickFunctions(ULineBatchComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ScaleByMomentOfInertia(ULineBatchComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SendRenderTransform_Concurrent(ULineBatchComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetAllMassScale(ULineBatchComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetAllPhysicsAngularVelocity(ULineBatchComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetAllPhysicsAngularVelocityInRadians(ULineBatchComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetAllPhysicsLinearVelocity(ULineBatchComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetAllPhysicsPosition(ULineBatchComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetAllUseCCD(ULineBatchComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetAngularDamping(ULineBatchComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetCollisionObjectType(ULineBatchComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetCollisionProfileName(ULineBatchComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetCollisionResponseToAllChannels(ULineBatchComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetCollisionResponseToChannel(ULineBatchComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetCollisionResponseToChannels(ULineBatchComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetEnableGravity(ULineBatchComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetLinearDamping(ULineBatchComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetMassOverrideInKg(ULineBatchComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetMassScale(ULineBatchComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetNotifyRigidBodyCollision(ULineBatchComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetSimulatePhysics(ULineBatchComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetUseCCD(ULineBatchComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ShouldCreatePhysicsState(ULineBatchComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ShouldRecreateProxyOnUpdateTransform(ULineBatchComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ShouldRenderSelected(ULineBatchComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SupportsStaticLighting(ULineBatchComponent* Self)
	{
		return ((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_UnWeldChildren(ULineBatchComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_UnWeldFromParent(ULineBatchComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_UpdatePhysicsToRBChannels(ULineBatchComponent* Self)
	{
		((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_UpdatePhysicsVolume(ULineBatchComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_UsesOnlyUnlitMaterials(ULineBatchComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_WakeAllRigidBodies(ULineBatchComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_WakeRigidBody(ULineBatchComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_WeldTo(ULineBatchComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_WeldToImplementation(ULineBatchComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ApplyWorldOffset(ULineBatchComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CalcBoundingCylinder(ULineBatchComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CanAttachAsChild(ULineBatchComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_DestroyComponent(ULineBatchComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_DetachFromComponent(ULineBatchComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_DetachFromParent(ULineBatchComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_DoesSocketExist(ULineBatchComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetSocketLocation(ULineBatchComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetSocketQuaternion(ULineBatchComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetSocketRotation(ULineBatchComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetSocketTransform(ULineBatchComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_HasAnySockets(ULineBatchComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsAnySimulatingPhysics(ULineBatchComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsPrecomputedLightingValid(ULineBatchComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsVisible(ULineBatchComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsVisibleInEditor(ULineBatchComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnChildAttached(ULineBatchComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnChildDetached(ULineBatchComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnHiddenInGameChanged(ULineBatchComponent* Self)
	{
		((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnVisibilityChanged(ULineBatchComponent* Self)
	{
		((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PostNetReceive(ULineBatchComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PostRepNotifies(ULineBatchComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PreNetReceive(ULineBatchComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PropagateLightingScenarioChange(ULineBatchComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetRelativeScale3D(ULineBatchComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ShouldCollideWhenPlacing(ULineBatchComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ShouldCreateRenderState(ULineBatchComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_Activate(ULineBatchComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddTickPrerequisiteActor(ULineBatchComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddTickPrerequisiteComponent(ULineBatchComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_Deactivate(ULineBatchComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetComponentClassCanReplicate(ULineBatchComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetReadableName(ULineBatchComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_InitializeComponent(ULineBatchComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsActive(ULineBatchComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsNameStableForNetworking(ULineBatchComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsReadyForOwnerToAutoDestroy(ULineBatchComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsSupportedForNetworking(ULineBatchComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_MarkAsEditorOnlySubobject(ULineBatchComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_NeedsLoadForEditorGame(ULineBatchComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnComponentCreated(ULineBatchComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PostInitProperties(ULineBatchComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PostRename(ULineBatchComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_RemoveTickPrerequisiteActor(ULineBatchComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_RemoveTickPrerequisiteComponent(ULineBatchComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_RequiresGameThreadEndOfFrameRecreate(ULineBatchComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_RequiresGameThreadEndOfFrameUpdates(ULineBatchComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SendRenderDynamicData_Concurrent(ULineBatchComponent* Self)
	{
		((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetActive(ULineBatchComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetAutoActivate(ULineBatchComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetComponentTickEnabled(ULineBatchComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_SetComponentTickEnabledAsync(ULineBatchComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ShouldActivate(ULineBatchComponent* Self)
	{
		return ((E_PROTECTED_WRAP_ULineBatchComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ToggleActive(ULineBatchComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_UninitializeComponent(ULineBatchComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AreNativePropertiesIdenticalTo(ULineBatchComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CheckDefaultSubobjectsInternal(ULineBatchComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetDesc(ULineBatchComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_GetDetailedInfoInternal(ULineBatchComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsAsset(ULineBatchComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsFullNameStableForNetworking(ULineBatchComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsLocalizedResource(ULineBatchComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsPostLoadThreadSafe(ULineBatchComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_IsSafeForRootSet(ULineBatchComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_Modify(ULineBatchComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_NotifyObjectReferenceEliminated(ULineBatchComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PostCDOContruct(ULineBatchComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PostEditImport(ULineBatchComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PostSaveRoot(ULineBatchComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_PreDestroyFromReplication(ULineBatchComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_ShutdownAfterError(ULineBatchComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_AddToCluster(ULineBatchComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CanBeClusterRoot(ULineBatchComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CanBeInCluster(ULineBatchComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_CreateCluster(ULineBatchComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_ULineBatchComponent_OnClusterMarkedAsPendingKill(ULineBatchComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
