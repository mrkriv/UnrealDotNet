#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/TextRenderComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\TextRenderComponent.h:44

class E_PROTECTED_WRAP_UTextRenderComponent : protected UTextRenderComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UTextRenderComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UTextRenderComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddAngularImpulse(UTextRenderComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddAngularImpulseInRadians(UTextRenderComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddForce(UTextRenderComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddForceAtLocation(UTextRenderComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddForceAtLocationLocal(UTextRenderComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddImpulse(UTextRenderComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddImpulseAtLocation(UTextRenderComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddRadialForce(UTextRenderComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddRadialImpulse(UTextRenderComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AreAllCollideableDescendantsRelative(UTextRenderComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AreSymmetricRotations(UTextRenderComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_BeginDestroy(UTextRenderComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_BeginPlay(UTextRenderComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CalculateMass(UTextRenderComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CanCharacterStepUp(UTextRenderComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CanEditSimulatePhysics(UTextRenderComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CreateRenderState_Concurrent(UTextRenderComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_DestroyRenderState_Concurrent(UTextRenderComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_FinishDestroy(UTextRenderComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetAngularDamping(UTextRenderComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetCollisionObjectType(UTextRenderComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetCollisionResponseToChannel(UTextRenderComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetComponentVelocity(UTextRenderComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetDiffuseBoost(UTextRenderComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetEmissiveBoost(UTextRenderComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetInertiaTensor(UTextRenderComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetLightAndShadowMapMemoryUsage(UTextRenderComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetLightMapResolution(UTextRenderComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetLinearDamping(UTextRenderComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetMass(UTextRenderComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetMassScale(UTextRenderComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetNavigationBounds(UTextRenderComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetNumMaterials(UTextRenderComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetShadowIndirectOnly(UTextRenderComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetSquaredDistanceToCollision(UTextRenderComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetStaticDepthPriorityGroup(UTextRenderComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetStaticLightMapResolution(UTextRenderComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_HasValidPhysicsState(UTextRenderComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_HasValidSettingsForStaticLighting(UTextRenderComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_InvalidateLightingCacheDetailed(UTextRenderComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsAnyRigidBodyAwake(UTextRenderComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsEditorOnly(UTextRenderComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsGravityEnabled(UTextRenderComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsNavigationRelevant(UTextRenderComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsReadyForFinishDestroy(UTextRenderComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsSimulatingPhysics(UTextRenderComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsWorldGeometry(UTextRenderComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsZeroExtent(UTextRenderComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_MoveComponentImpl(UTextRenderComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_NeedsLoadForClient(UTextRenderComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_NeedsLoadForServer(UTextRenderComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnActorEnableCollisionChanged(UTextRenderComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnAttachmentChanged(UTextRenderComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnComponentCollisionSettingsChanged(UTextRenderComponent* Self)
	{
		((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnComponentDestroyed(UTextRenderComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnCreatePhysicsState(UTextRenderComponent* Self)
	{
		((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnDestroyPhysicsState(UTextRenderComponent* Self)
	{
		((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnRegister(UTextRenderComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnUnregister(UTextRenderComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnUpdateTransform(UTextRenderComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PostDuplicate(UTextRenderComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PostLoad(UTextRenderComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PutAllRigidBodiesToSleep(UTextRenderComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_RegisterComponentTickFunctions(UTextRenderComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ScaleByMomentOfInertia(UTextRenderComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SendRenderTransform_Concurrent(UTextRenderComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetAllMassScale(UTextRenderComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetAllPhysicsAngularVelocity(UTextRenderComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetAllPhysicsAngularVelocityInRadians(UTextRenderComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetAllPhysicsLinearVelocity(UTextRenderComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetAllPhysicsPosition(UTextRenderComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetAllUseCCD(UTextRenderComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetAngularDamping(UTextRenderComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetCollisionObjectType(UTextRenderComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetCollisionProfileName(UTextRenderComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetCollisionResponseToAllChannels(UTextRenderComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetCollisionResponseToChannel(UTextRenderComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetCollisionResponseToChannels(UTextRenderComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetEnableGravity(UTextRenderComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetLinearDamping(UTextRenderComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetMassOverrideInKg(UTextRenderComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetMassScale(UTextRenderComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetNotifyRigidBodyCollision(UTextRenderComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetSimulatePhysics(UTextRenderComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetUseCCD(UTextRenderComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ShouldCreatePhysicsState(UTextRenderComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ShouldRecreateProxyOnUpdateTransform(UTextRenderComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ShouldRenderSelected(UTextRenderComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SupportsStaticLighting(UTextRenderComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_UnWeldChildren(UTextRenderComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_UnWeldFromParent(UTextRenderComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_UpdatePhysicsToRBChannels(UTextRenderComponent* Self)
	{
		((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_UpdatePhysicsVolume(UTextRenderComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_UsesOnlyUnlitMaterials(UTextRenderComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_WakeAllRigidBodies(UTextRenderComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_WakeRigidBody(UTextRenderComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_WeldTo(UTextRenderComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_WeldToImplementation(UTextRenderComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ApplyWorldOffset(UTextRenderComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CalcBoundingCylinder(UTextRenderComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CanAttachAsChild(UTextRenderComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_DestroyComponent(UTextRenderComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_DetachFromComponent(UTextRenderComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_DetachFromParent(UTextRenderComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_DoesSocketExist(UTextRenderComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetSocketLocation(UTextRenderComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetSocketQuaternion(UTextRenderComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetSocketRotation(UTextRenderComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetSocketTransform(UTextRenderComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_HasAnySockets(UTextRenderComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsAnySimulatingPhysics(UTextRenderComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsPrecomputedLightingValid(UTextRenderComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsVisible(UTextRenderComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsVisibleInEditor(UTextRenderComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnChildAttached(UTextRenderComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnChildDetached(UTextRenderComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnHiddenInGameChanged(UTextRenderComponent* Self)
	{
		((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnVisibilityChanged(UTextRenderComponent* Self)
	{
		((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PostNetReceive(UTextRenderComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PostRepNotifies(UTextRenderComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PreNetReceive(UTextRenderComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PropagateLightingScenarioChange(UTextRenderComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetRelativeScale3D(UTextRenderComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ShouldCollideWhenPlacing(UTextRenderComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ShouldCreateRenderState(UTextRenderComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_Activate(UTextRenderComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddTickPrerequisiteActor(UTextRenderComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddTickPrerequisiteComponent(UTextRenderComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_Deactivate(UTextRenderComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetComponentClassCanReplicate(UTextRenderComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetReadableName(UTextRenderComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_InitializeComponent(UTextRenderComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsActive(UTextRenderComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsNameStableForNetworking(UTextRenderComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsReadyForOwnerToAutoDestroy(UTextRenderComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsSupportedForNetworking(UTextRenderComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_MarkAsEditorOnlySubobject(UTextRenderComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_NeedsLoadForEditorGame(UTextRenderComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnComponentCreated(UTextRenderComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PostInitProperties(UTextRenderComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PostRename(UTextRenderComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_RemoveTickPrerequisiteActor(UTextRenderComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_RemoveTickPrerequisiteComponent(UTextRenderComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_RequiresGameThreadEndOfFrameRecreate(UTextRenderComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_RequiresGameThreadEndOfFrameUpdates(UTextRenderComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SendRenderDynamicData_Concurrent(UTextRenderComponent* Self)
	{
		((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetActive(UTextRenderComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetAutoActivate(UTextRenderComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetComponentTickEnabled(UTextRenderComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetComponentTickEnabledAsync(UTextRenderComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ShouldActivate(UTextRenderComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UTextRenderComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ToggleActive(UTextRenderComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_UninitializeComponent(UTextRenderComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AreNativePropertiesIdenticalTo(UTextRenderComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CheckDefaultSubobjectsInternal(UTextRenderComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetDesc(UTextRenderComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetDetailedInfoInternal(UTextRenderComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsAsset(UTextRenderComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsFullNameStableForNetworking(UTextRenderComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsLocalizedResource(UTextRenderComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsPostLoadThreadSafe(UTextRenderComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_IsSafeForRootSet(UTextRenderComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_Modify(UTextRenderComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_NotifyObjectReferenceEliminated(UTextRenderComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PostCDOContruct(UTextRenderComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PostEditImport(UTextRenderComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PostSaveRoot(UTextRenderComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_PreDestroyFromReplication(UTextRenderComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ShutdownAfterError(UTextRenderComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_AddToCluster(UTextRenderComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CanBeClusterRoot(UTextRenderComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CanBeInCluster(UTextRenderComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_CreateCluster(UTextRenderComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_OnClusterMarkedAsPendingKill(UTextRenderComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
