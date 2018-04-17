#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/DrawFrustumComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\DrawFrustumComponent.h:18

class E_PROTECTED_WRAP_UDrawFrustumComponent : protected UDrawFrustumComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDrawFrustumComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDrawFrustumComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddAngularImpulse(UDrawFrustumComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddAngularImpulseInRadians(UDrawFrustumComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddForce(UDrawFrustumComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddForceAtLocation(UDrawFrustumComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddForceAtLocationLocal(UDrawFrustumComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddImpulse(UDrawFrustumComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddImpulseAtLocation(UDrawFrustumComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddRadialForce(UDrawFrustumComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddRadialImpulse(UDrawFrustumComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AreAllCollideableDescendantsRelative(UDrawFrustumComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AreSymmetricRotations(UDrawFrustumComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_BeginDestroy(UDrawFrustumComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_BeginPlay(UDrawFrustumComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CalculateMass(UDrawFrustumComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CanCharacterStepUp(UDrawFrustumComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CanEditSimulatePhysics(UDrawFrustumComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CreateRenderState_Concurrent(UDrawFrustumComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_DestroyRenderState_Concurrent(UDrawFrustumComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_FinishDestroy(UDrawFrustumComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetAngularDamping(UDrawFrustumComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetCollisionObjectType(UDrawFrustumComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetCollisionResponseToChannel(UDrawFrustumComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetComponentVelocity(UDrawFrustumComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetDiffuseBoost(UDrawFrustumComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetEmissiveBoost(UDrawFrustumComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetInertiaTensor(UDrawFrustumComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetLightAndShadowMapMemoryUsage(UDrawFrustumComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetLightMapResolution(UDrawFrustumComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetLinearDamping(UDrawFrustumComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetMass(UDrawFrustumComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetMassScale(UDrawFrustumComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetNavigationBounds(UDrawFrustumComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetNumMaterials(UDrawFrustumComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetShadowIndirectOnly(UDrawFrustumComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetSquaredDistanceToCollision(UDrawFrustumComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetStaticDepthPriorityGroup(UDrawFrustumComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetStaticLightMapResolution(UDrawFrustumComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_HasValidPhysicsState(UDrawFrustumComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_HasValidSettingsForStaticLighting(UDrawFrustumComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_InvalidateLightingCacheDetailed(UDrawFrustumComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsAnyRigidBodyAwake(UDrawFrustumComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsEditorOnly(UDrawFrustumComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsGravityEnabled(UDrawFrustumComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsNavigationRelevant(UDrawFrustumComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsReadyForFinishDestroy(UDrawFrustumComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsSimulatingPhysics(UDrawFrustumComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsWorldGeometry(UDrawFrustumComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsZeroExtent(UDrawFrustumComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_MoveComponentImpl(UDrawFrustumComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_NeedsLoadForClient(UDrawFrustumComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_NeedsLoadForServer(UDrawFrustumComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnActorEnableCollisionChanged(UDrawFrustumComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnAttachmentChanged(UDrawFrustumComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnComponentCollisionSettingsChanged(UDrawFrustumComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnComponentDestroyed(UDrawFrustumComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnCreatePhysicsState(UDrawFrustumComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnDestroyPhysicsState(UDrawFrustumComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnRegister(UDrawFrustumComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnUnregister(UDrawFrustumComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnUpdateTransform(UDrawFrustumComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PostDuplicate(UDrawFrustumComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PostLoad(UDrawFrustumComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PutAllRigidBodiesToSleep(UDrawFrustumComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_RegisterComponentTickFunctions(UDrawFrustumComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ScaleByMomentOfInertia(UDrawFrustumComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SendRenderTransform_Concurrent(UDrawFrustumComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetAllMassScale(UDrawFrustumComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetAllPhysicsAngularVelocity(UDrawFrustumComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetAllPhysicsAngularVelocityInRadians(UDrawFrustumComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetAllPhysicsLinearVelocity(UDrawFrustumComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetAllPhysicsPosition(UDrawFrustumComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetAllUseCCD(UDrawFrustumComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetAngularDamping(UDrawFrustumComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetCollisionObjectType(UDrawFrustumComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetCollisionProfileName(UDrawFrustumComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetCollisionResponseToAllChannels(UDrawFrustumComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetCollisionResponseToChannel(UDrawFrustumComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetCollisionResponseToChannels(UDrawFrustumComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetEnableGravity(UDrawFrustumComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetLinearDamping(UDrawFrustumComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetMassOverrideInKg(UDrawFrustumComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetMassScale(UDrawFrustumComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetNotifyRigidBodyCollision(UDrawFrustumComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetSimulatePhysics(UDrawFrustumComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetUseCCD(UDrawFrustumComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ShouldCreatePhysicsState(UDrawFrustumComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ShouldRecreateProxyOnUpdateTransform(UDrawFrustumComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ShouldRenderSelected(UDrawFrustumComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SupportsStaticLighting(UDrawFrustumComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_UnWeldChildren(UDrawFrustumComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_UnWeldFromParent(UDrawFrustumComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_UpdatePhysicsToRBChannels(UDrawFrustumComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_UpdatePhysicsVolume(UDrawFrustumComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_UsesOnlyUnlitMaterials(UDrawFrustumComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_WakeAllRigidBodies(UDrawFrustumComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_WakeRigidBody(UDrawFrustumComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_WeldTo(UDrawFrustumComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_WeldToImplementation(UDrawFrustumComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ApplyWorldOffset(UDrawFrustumComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CalcBoundingCylinder(UDrawFrustumComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CanAttachAsChild(UDrawFrustumComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_DestroyComponent(UDrawFrustumComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_DetachFromComponent(UDrawFrustumComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_DetachFromParent(UDrawFrustumComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_DoesSocketExist(UDrawFrustumComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetSocketLocation(UDrawFrustumComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetSocketQuaternion(UDrawFrustumComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetSocketRotation(UDrawFrustumComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetSocketTransform(UDrawFrustumComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_HasAnySockets(UDrawFrustumComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsAnySimulatingPhysics(UDrawFrustumComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsPrecomputedLightingValid(UDrawFrustumComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsVisible(UDrawFrustumComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsVisibleInEditor(UDrawFrustumComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnChildAttached(UDrawFrustumComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnChildDetached(UDrawFrustumComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnHiddenInGameChanged(UDrawFrustumComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnVisibilityChanged(UDrawFrustumComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PostNetReceive(UDrawFrustumComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PostRepNotifies(UDrawFrustumComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PreNetReceive(UDrawFrustumComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PropagateLightingScenarioChange(UDrawFrustumComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetRelativeScale3D(UDrawFrustumComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ShouldCollideWhenPlacing(UDrawFrustumComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ShouldCreateRenderState(UDrawFrustumComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_Activate(UDrawFrustumComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddTickPrerequisiteActor(UDrawFrustumComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddTickPrerequisiteComponent(UDrawFrustumComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_Deactivate(UDrawFrustumComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetComponentClassCanReplicate(UDrawFrustumComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetReadableName(UDrawFrustumComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_InitializeComponent(UDrawFrustumComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsActive(UDrawFrustumComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsNameStableForNetworking(UDrawFrustumComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsReadyForOwnerToAutoDestroy(UDrawFrustumComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsSupportedForNetworking(UDrawFrustumComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_MarkAsEditorOnlySubobject(UDrawFrustumComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_NeedsLoadForEditorGame(UDrawFrustumComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnComponentCreated(UDrawFrustumComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PostInitProperties(UDrawFrustumComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PostRename(UDrawFrustumComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_RemoveTickPrerequisiteActor(UDrawFrustumComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_RemoveTickPrerequisiteComponent(UDrawFrustumComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_RequiresGameThreadEndOfFrameRecreate(UDrawFrustumComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_RequiresGameThreadEndOfFrameUpdates(UDrawFrustumComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SendRenderDynamicData_Concurrent(UDrawFrustumComponent* Self)
	{
		((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetActive(UDrawFrustumComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetAutoActivate(UDrawFrustumComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetComponentTickEnabled(UDrawFrustumComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_SetComponentTickEnabledAsync(UDrawFrustumComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ShouldActivate(UDrawFrustumComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UDrawFrustumComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ToggleActive(UDrawFrustumComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_UninitializeComponent(UDrawFrustumComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AreNativePropertiesIdenticalTo(UDrawFrustumComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CheckDefaultSubobjectsInternal(UDrawFrustumComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetDesc(UDrawFrustumComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_GetDetailedInfoInternal(UDrawFrustumComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsAsset(UDrawFrustumComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsFullNameStableForNetworking(UDrawFrustumComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsLocalizedResource(UDrawFrustumComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsPostLoadThreadSafe(UDrawFrustumComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_IsSafeForRootSet(UDrawFrustumComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_Modify(UDrawFrustumComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_NotifyObjectReferenceEliminated(UDrawFrustumComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PostCDOContruct(UDrawFrustumComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PostEditImport(UDrawFrustumComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PostSaveRoot(UDrawFrustumComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_PreDestroyFromReplication(UDrawFrustumComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_ShutdownAfterError(UDrawFrustumComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_AddToCluster(UDrawFrustumComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CanBeClusterRoot(UDrawFrustumComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CanBeInCluster(UDrawFrustumComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_CreateCluster(UDrawFrustumComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UDrawFrustumComponent_OnClusterMarkedAsPendingKill(UDrawFrustumComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
