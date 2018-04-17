#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/MaterialBillboardComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\MaterialBillboardComponent.h:61

class E_PROTECTED_WRAP_UMaterialBillboardComponent : protected UMaterialBillboardComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UMaterialBillboardComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UMaterialBillboardComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddAngularImpulse(UMaterialBillboardComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddAngularImpulseInRadians(UMaterialBillboardComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddForce(UMaterialBillboardComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddForceAtLocation(UMaterialBillboardComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddForceAtLocationLocal(UMaterialBillboardComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddImpulse(UMaterialBillboardComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddImpulseAtLocation(UMaterialBillboardComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddRadialForce(UMaterialBillboardComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddRadialImpulse(UMaterialBillboardComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AreAllCollideableDescendantsRelative(UMaterialBillboardComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AreSymmetricRotations(UMaterialBillboardComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_BeginDestroy(UMaterialBillboardComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_BeginPlay(UMaterialBillboardComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CalculateMass(UMaterialBillboardComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CanCharacterStepUp(UMaterialBillboardComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CanEditSimulatePhysics(UMaterialBillboardComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CreateRenderState_Concurrent(UMaterialBillboardComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_DestroyRenderState_Concurrent(UMaterialBillboardComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_FinishDestroy(UMaterialBillboardComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetAngularDamping(UMaterialBillboardComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetCollisionObjectType(UMaterialBillboardComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetCollisionResponseToChannel(UMaterialBillboardComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetComponentVelocity(UMaterialBillboardComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetDiffuseBoost(UMaterialBillboardComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetEmissiveBoost(UMaterialBillboardComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetInertiaTensor(UMaterialBillboardComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetLightAndShadowMapMemoryUsage(UMaterialBillboardComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetLightMapResolution(UMaterialBillboardComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetLinearDamping(UMaterialBillboardComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetMass(UMaterialBillboardComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetMassScale(UMaterialBillboardComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetNavigationBounds(UMaterialBillboardComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetNumMaterials(UMaterialBillboardComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetShadowIndirectOnly(UMaterialBillboardComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetSquaredDistanceToCollision(UMaterialBillboardComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetStaticDepthPriorityGroup(UMaterialBillboardComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetStaticLightMapResolution(UMaterialBillboardComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_HasValidPhysicsState(UMaterialBillboardComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_HasValidSettingsForStaticLighting(UMaterialBillboardComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_InvalidateLightingCacheDetailed(UMaterialBillboardComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsAnyRigidBodyAwake(UMaterialBillboardComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsEditorOnly(UMaterialBillboardComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsGravityEnabled(UMaterialBillboardComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsNavigationRelevant(UMaterialBillboardComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsReadyForFinishDestroy(UMaterialBillboardComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsSimulatingPhysics(UMaterialBillboardComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsWorldGeometry(UMaterialBillboardComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsZeroExtent(UMaterialBillboardComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_MoveComponentImpl(UMaterialBillboardComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_NeedsLoadForClient(UMaterialBillboardComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_NeedsLoadForServer(UMaterialBillboardComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnActorEnableCollisionChanged(UMaterialBillboardComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnAttachmentChanged(UMaterialBillboardComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnComponentCollisionSettingsChanged(UMaterialBillboardComponent* Self)
	{
		((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnComponentDestroyed(UMaterialBillboardComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnCreatePhysicsState(UMaterialBillboardComponent* Self)
	{
		((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnDestroyPhysicsState(UMaterialBillboardComponent* Self)
	{
		((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnRegister(UMaterialBillboardComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnUnregister(UMaterialBillboardComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnUpdateTransform(UMaterialBillboardComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PostDuplicate(UMaterialBillboardComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PostLoad(UMaterialBillboardComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PutAllRigidBodiesToSleep(UMaterialBillboardComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_RegisterComponentTickFunctions(UMaterialBillboardComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ScaleByMomentOfInertia(UMaterialBillboardComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SendRenderTransform_Concurrent(UMaterialBillboardComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetAllMassScale(UMaterialBillboardComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetAllPhysicsAngularVelocity(UMaterialBillboardComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetAllPhysicsAngularVelocityInRadians(UMaterialBillboardComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetAllPhysicsLinearVelocity(UMaterialBillboardComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetAllPhysicsPosition(UMaterialBillboardComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetAllUseCCD(UMaterialBillboardComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetAngularDamping(UMaterialBillboardComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetCollisionObjectType(UMaterialBillboardComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetCollisionProfileName(UMaterialBillboardComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetCollisionResponseToAllChannels(UMaterialBillboardComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetCollisionResponseToChannel(UMaterialBillboardComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetCollisionResponseToChannels(UMaterialBillboardComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetEnableGravity(UMaterialBillboardComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetLinearDamping(UMaterialBillboardComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetMassOverrideInKg(UMaterialBillboardComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetMassScale(UMaterialBillboardComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetNotifyRigidBodyCollision(UMaterialBillboardComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetSimulatePhysics(UMaterialBillboardComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetUseCCD(UMaterialBillboardComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ShouldCreatePhysicsState(UMaterialBillboardComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ShouldRecreateProxyOnUpdateTransform(UMaterialBillboardComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ShouldRenderSelected(UMaterialBillboardComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SupportsStaticLighting(UMaterialBillboardComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_UnWeldChildren(UMaterialBillboardComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_UnWeldFromParent(UMaterialBillboardComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_UpdatePhysicsToRBChannels(UMaterialBillboardComponent* Self)
	{
		((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_UpdatePhysicsVolume(UMaterialBillboardComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_UsesOnlyUnlitMaterials(UMaterialBillboardComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_WakeAllRigidBodies(UMaterialBillboardComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_WakeRigidBody(UMaterialBillboardComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_WeldTo(UMaterialBillboardComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_WeldToImplementation(UMaterialBillboardComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ApplyWorldOffset(UMaterialBillboardComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CalcBoundingCylinder(UMaterialBillboardComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CanAttachAsChild(UMaterialBillboardComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_DestroyComponent(UMaterialBillboardComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_DetachFromComponent(UMaterialBillboardComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_DetachFromParent(UMaterialBillboardComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_DoesSocketExist(UMaterialBillboardComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetSocketLocation(UMaterialBillboardComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetSocketQuaternion(UMaterialBillboardComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetSocketRotation(UMaterialBillboardComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetSocketTransform(UMaterialBillboardComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_HasAnySockets(UMaterialBillboardComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsAnySimulatingPhysics(UMaterialBillboardComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsPrecomputedLightingValid(UMaterialBillboardComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsVisible(UMaterialBillboardComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsVisibleInEditor(UMaterialBillboardComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnChildAttached(UMaterialBillboardComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnChildDetached(UMaterialBillboardComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnHiddenInGameChanged(UMaterialBillboardComponent* Self)
	{
		((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnVisibilityChanged(UMaterialBillboardComponent* Self)
	{
		((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PostNetReceive(UMaterialBillboardComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PostRepNotifies(UMaterialBillboardComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PreNetReceive(UMaterialBillboardComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PropagateLightingScenarioChange(UMaterialBillboardComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetRelativeScale3D(UMaterialBillboardComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ShouldCollideWhenPlacing(UMaterialBillboardComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ShouldCreateRenderState(UMaterialBillboardComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_Activate(UMaterialBillboardComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddTickPrerequisiteActor(UMaterialBillboardComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddTickPrerequisiteComponent(UMaterialBillboardComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_Deactivate(UMaterialBillboardComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetComponentClassCanReplicate(UMaterialBillboardComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetReadableName(UMaterialBillboardComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_InitializeComponent(UMaterialBillboardComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsActive(UMaterialBillboardComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsNameStableForNetworking(UMaterialBillboardComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsReadyForOwnerToAutoDestroy(UMaterialBillboardComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsSupportedForNetworking(UMaterialBillboardComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_MarkAsEditorOnlySubobject(UMaterialBillboardComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_NeedsLoadForEditorGame(UMaterialBillboardComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnComponentCreated(UMaterialBillboardComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PostInitProperties(UMaterialBillboardComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PostRename(UMaterialBillboardComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_RemoveTickPrerequisiteActor(UMaterialBillboardComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_RemoveTickPrerequisiteComponent(UMaterialBillboardComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_RequiresGameThreadEndOfFrameRecreate(UMaterialBillboardComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_RequiresGameThreadEndOfFrameUpdates(UMaterialBillboardComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SendRenderDynamicData_Concurrent(UMaterialBillboardComponent* Self)
	{
		((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetActive(UMaterialBillboardComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetAutoActivate(UMaterialBillboardComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetComponentTickEnabled(UMaterialBillboardComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_SetComponentTickEnabledAsync(UMaterialBillboardComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ShouldActivate(UMaterialBillboardComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UMaterialBillboardComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ToggleActive(UMaterialBillboardComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_UninitializeComponent(UMaterialBillboardComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AreNativePropertiesIdenticalTo(UMaterialBillboardComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CheckDefaultSubobjectsInternal(UMaterialBillboardComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetDesc(UMaterialBillboardComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_GetDetailedInfoInternal(UMaterialBillboardComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsAsset(UMaterialBillboardComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsFullNameStableForNetworking(UMaterialBillboardComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsLocalizedResource(UMaterialBillboardComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsPostLoadThreadSafe(UMaterialBillboardComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_IsSafeForRootSet(UMaterialBillboardComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_Modify(UMaterialBillboardComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_NotifyObjectReferenceEliminated(UMaterialBillboardComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PostCDOContruct(UMaterialBillboardComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PostEditImport(UMaterialBillboardComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PostSaveRoot(UMaterialBillboardComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_PreDestroyFromReplication(UMaterialBillboardComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_ShutdownAfterError(UMaterialBillboardComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_AddToCluster(UMaterialBillboardComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CanBeClusterRoot(UMaterialBillboardComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CanBeInCluster(UMaterialBillboardComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_CreateCluster(UMaterialBillboardComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UMaterialBillboardComponent_OnClusterMarkedAsPendingKill(UMaterialBillboardComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
