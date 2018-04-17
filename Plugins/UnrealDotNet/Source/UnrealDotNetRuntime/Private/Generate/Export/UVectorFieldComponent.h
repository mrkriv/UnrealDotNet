#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/VectorFieldComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\VectorFieldComponent.h:18

class E_PROTECTED_WRAP_UVectorFieldComponent : protected UVectorFieldComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UVectorFieldComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UVectorFieldComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnRegister(UVectorFieldComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnUnregister(UVectorFieldComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SendRenderTransform_Concurrent(UVectorFieldComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddAngularImpulse(UVectorFieldComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddAngularImpulseInRadians(UVectorFieldComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddForce(UVectorFieldComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddForceAtLocation(UVectorFieldComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddForceAtLocationLocal(UVectorFieldComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddImpulse(UVectorFieldComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddImpulseAtLocation(UVectorFieldComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddRadialForce(UVectorFieldComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddRadialImpulse(UVectorFieldComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AreAllCollideableDescendantsRelative(UVectorFieldComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AreSymmetricRotations(UVectorFieldComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_BeginDestroy(UVectorFieldComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_BeginPlay(UVectorFieldComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CalculateMass(UVectorFieldComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CanCharacterStepUp(UVectorFieldComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CanEditSimulatePhysics(UVectorFieldComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CreateRenderState_Concurrent(UVectorFieldComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_DestroyRenderState_Concurrent(UVectorFieldComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_FinishDestroy(UVectorFieldComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetAngularDamping(UVectorFieldComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetCollisionObjectType(UVectorFieldComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetCollisionResponseToChannel(UVectorFieldComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetComponentVelocity(UVectorFieldComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetDiffuseBoost(UVectorFieldComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetEmissiveBoost(UVectorFieldComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetInertiaTensor(UVectorFieldComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetLightAndShadowMapMemoryUsage(UVectorFieldComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetLightMapResolution(UVectorFieldComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetLinearDamping(UVectorFieldComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetMass(UVectorFieldComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetMassScale(UVectorFieldComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetNavigationBounds(UVectorFieldComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetNumMaterials(UVectorFieldComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetShadowIndirectOnly(UVectorFieldComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetSquaredDistanceToCollision(UVectorFieldComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetStaticDepthPriorityGroup(UVectorFieldComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetStaticLightMapResolution(UVectorFieldComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_HasValidPhysicsState(UVectorFieldComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_HasValidSettingsForStaticLighting(UVectorFieldComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_InvalidateLightingCacheDetailed(UVectorFieldComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsAnyRigidBodyAwake(UVectorFieldComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsEditorOnly(UVectorFieldComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsGravityEnabled(UVectorFieldComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsNavigationRelevant(UVectorFieldComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsReadyForFinishDestroy(UVectorFieldComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsSimulatingPhysics(UVectorFieldComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsWorldGeometry(UVectorFieldComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsZeroExtent(UVectorFieldComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_MoveComponentImpl(UVectorFieldComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_NeedsLoadForClient(UVectorFieldComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_NeedsLoadForServer(UVectorFieldComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnActorEnableCollisionChanged(UVectorFieldComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnAttachmentChanged(UVectorFieldComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnComponentCollisionSettingsChanged(UVectorFieldComponent* Self)
	{
		((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnComponentDestroyed(UVectorFieldComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnCreatePhysicsState(UVectorFieldComponent* Self)
	{
		((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnDestroyPhysicsState(UVectorFieldComponent* Self)
	{
		((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnUpdateTransform(UVectorFieldComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PostDuplicate(UVectorFieldComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PostLoad(UVectorFieldComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PutAllRigidBodiesToSleep(UVectorFieldComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_RegisterComponentTickFunctions(UVectorFieldComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ScaleByMomentOfInertia(UVectorFieldComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetAllMassScale(UVectorFieldComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetAllPhysicsAngularVelocity(UVectorFieldComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetAllPhysicsAngularVelocityInRadians(UVectorFieldComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetAllPhysicsLinearVelocity(UVectorFieldComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetAllPhysicsPosition(UVectorFieldComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetAllUseCCD(UVectorFieldComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetAngularDamping(UVectorFieldComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetCollisionObjectType(UVectorFieldComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetCollisionProfileName(UVectorFieldComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetCollisionResponseToAllChannels(UVectorFieldComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetCollisionResponseToChannel(UVectorFieldComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetCollisionResponseToChannels(UVectorFieldComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetEnableGravity(UVectorFieldComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetLinearDamping(UVectorFieldComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetMassOverrideInKg(UVectorFieldComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetMassScale(UVectorFieldComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetNotifyRigidBodyCollision(UVectorFieldComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetSimulatePhysics(UVectorFieldComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetUseCCD(UVectorFieldComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ShouldCreatePhysicsState(UVectorFieldComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ShouldRecreateProxyOnUpdateTransform(UVectorFieldComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ShouldRenderSelected(UVectorFieldComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SupportsStaticLighting(UVectorFieldComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_UnWeldChildren(UVectorFieldComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_UnWeldFromParent(UVectorFieldComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_UpdatePhysicsToRBChannels(UVectorFieldComponent* Self)
	{
		((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_UpdatePhysicsVolume(UVectorFieldComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_UsesOnlyUnlitMaterials(UVectorFieldComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_WakeAllRigidBodies(UVectorFieldComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_WakeRigidBody(UVectorFieldComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_WeldTo(UVectorFieldComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_WeldToImplementation(UVectorFieldComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ApplyWorldOffset(UVectorFieldComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CalcBoundingCylinder(UVectorFieldComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CanAttachAsChild(UVectorFieldComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_DestroyComponent(UVectorFieldComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_DetachFromComponent(UVectorFieldComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_DetachFromParent(UVectorFieldComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_DoesSocketExist(UVectorFieldComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetSocketLocation(UVectorFieldComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetSocketQuaternion(UVectorFieldComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetSocketRotation(UVectorFieldComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetSocketTransform(UVectorFieldComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_HasAnySockets(UVectorFieldComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsAnySimulatingPhysics(UVectorFieldComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsPrecomputedLightingValid(UVectorFieldComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsVisible(UVectorFieldComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsVisibleInEditor(UVectorFieldComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnChildAttached(UVectorFieldComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnChildDetached(UVectorFieldComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnHiddenInGameChanged(UVectorFieldComponent* Self)
	{
		((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnVisibilityChanged(UVectorFieldComponent* Self)
	{
		((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PostNetReceive(UVectorFieldComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PostRepNotifies(UVectorFieldComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PreNetReceive(UVectorFieldComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PropagateLightingScenarioChange(UVectorFieldComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetRelativeScale3D(UVectorFieldComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ShouldCollideWhenPlacing(UVectorFieldComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ShouldCreateRenderState(UVectorFieldComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_Activate(UVectorFieldComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddTickPrerequisiteActor(UVectorFieldComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddTickPrerequisiteComponent(UVectorFieldComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_Deactivate(UVectorFieldComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetComponentClassCanReplicate(UVectorFieldComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetReadableName(UVectorFieldComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_InitializeComponent(UVectorFieldComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsActive(UVectorFieldComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsNameStableForNetworking(UVectorFieldComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsReadyForOwnerToAutoDestroy(UVectorFieldComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsSupportedForNetworking(UVectorFieldComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_MarkAsEditorOnlySubobject(UVectorFieldComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_NeedsLoadForEditorGame(UVectorFieldComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnComponentCreated(UVectorFieldComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PostInitProperties(UVectorFieldComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PostRename(UVectorFieldComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_RemoveTickPrerequisiteActor(UVectorFieldComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_RemoveTickPrerequisiteComponent(UVectorFieldComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_RequiresGameThreadEndOfFrameRecreate(UVectorFieldComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_RequiresGameThreadEndOfFrameUpdates(UVectorFieldComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SendRenderDynamicData_Concurrent(UVectorFieldComponent* Self)
	{
		((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetActive(UVectorFieldComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetAutoActivate(UVectorFieldComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetComponentTickEnabled(UVectorFieldComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetComponentTickEnabledAsync(UVectorFieldComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ShouldActivate(UVectorFieldComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UVectorFieldComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ToggleActive(UVectorFieldComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_UninitializeComponent(UVectorFieldComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AreNativePropertiesIdenticalTo(UVectorFieldComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CheckDefaultSubobjectsInternal(UVectorFieldComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetDesc(UVectorFieldComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_GetDetailedInfoInternal(UVectorFieldComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsAsset(UVectorFieldComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsFullNameStableForNetworking(UVectorFieldComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsLocalizedResource(UVectorFieldComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsPostLoadThreadSafe(UVectorFieldComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_IsSafeForRootSet(UVectorFieldComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_Modify(UVectorFieldComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_NotifyObjectReferenceEliminated(UVectorFieldComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PostCDOContruct(UVectorFieldComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PostEditImport(UVectorFieldComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PostSaveRoot(UVectorFieldComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_PreDestroyFromReplication(UVectorFieldComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_ShutdownAfterError(UVectorFieldComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_AddToCluster(UVectorFieldComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CanBeClusterRoot(UVectorFieldComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CanBeInCluster(UVectorFieldComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_CreateCluster(UVectorFieldComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_OnClusterMarkedAsPendingKill(UVectorFieldComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
