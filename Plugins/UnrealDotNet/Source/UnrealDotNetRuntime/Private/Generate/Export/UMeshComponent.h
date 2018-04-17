#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/MeshComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\MeshComponent.h:21

class E_PROTECTED_WRAP_UMeshComponent : protected UMeshComponent
{
public:
	void CacheMaterialParameterNameIndices_WRAP()
	{
		CacheMaterialParameterNameIndices();
	}

	void MarkCachedMaterialParameterNameIndicesDirty_WRAP()
	{
		MarkCachedMaterialParameterNameIndicesDirty();
	}

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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UMeshComponent_CacheMaterialParameterNameIndices(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->CacheMaterialParameterNameIndices_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetScalarParameterDefaultValue(UMeshComponent* Self, char* ParameterName)
	{
		auto _p0 = ConvertFromManage_FName(ParameterName);
		return Self->GetScalarParameterDefaultValue(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_MarkCachedMaterialParameterNameIndicesDirty(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->MarkCachedMaterialParameterNameIndicesDirty_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetScalarParameterValueOnMaterials(UMeshComponent* Self, char* ParameterName, float ParameterValue)
	{
		auto _p0 = ConvertFromManage_FName(ParameterName);
		auto _p1 = ParameterValue;
		Self->SetScalarParameterValueOnMaterials(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetVectorParameterValueOnMaterials(UMeshComponent* Self, char* ParameterName, INT_PTR ParameterValue)
	{
		auto _p0 = ConvertFromManage_FName(ParameterName);
		auto _p1 = *(FVector*)ParameterValue;
		Self->SetVectorParameterValueOnMaterials(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddAngularImpulse(UMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddAngularImpulseInRadians(UMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddForce(UMeshComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddForceAtLocation(UMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddForceAtLocationLocal(UMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddImpulse(UMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddImpulseAtLocation(UMeshComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddRadialForce(UMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddRadialImpulse(UMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AreAllCollideableDescendantsRelative(UMeshComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UMeshComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AreSymmetricRotations(UMeshComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_BeginDestroy(UMeshComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UMeshComponent_BeginPlay(UMeshComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UMeshComponent_CalculateMass(UMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_CanCharacterStepUp(UMeshComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_CanEditSimulatePhysics(UMeshComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UMeshComponent_CreateRenderState_Concurrent(UMeshComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UMeshComponent_DestroyRenderState_Concurrent(UMeshComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UMeshComponent_FinishDestroy(UMeshComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetAngularDamping(UMeshComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetCollisionObjectType(UMeshComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetCollisionResponseToChannel(UMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetComponentVelocity(UMeshComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetDiffuseBoost(UMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetEmissiveBoost(UMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetInertiaTensor(UMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetLightAndShadowMapMemoryUsage(UMeshComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetLightMapResolution(UMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetLinearDamping(UMeshComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetMass(UMeshComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetMassScale(UMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetNavigationBounds(UMeshComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetNumMaterials(UMeshComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetShadowIndirectOnly(UMeshComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetSquaredDistanceToCollision(UMeshComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetStaticDepthPriorityGroup(UMeshComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetStaticLightMapResolution(UMeshComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UMeshComponent_HasValidPhysicsState(UMeshComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UMeshComponent_HasValidSettingsForStaticLighting(UMeshComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_InvalidateLightingCacheDetailed(UMeshComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsAnyRigidBodyAwake(UMeshComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsEditorOnly(UMeshComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsGravityEnabled(UMeshComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsNavigationRelevant(UMeshComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsReadyForFinishDestroy(UMeshComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsSimulatingPhysics(UMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsWorldGeometry(UMeshComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsZeroExtent(UMeshComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UMeshComponent_MoveComponentImpl(UMeshComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UMeshComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UMeshComponent_NeedsLoadForClient(UMeshComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UMeshComponent_NeedsLoadForServer(UMeshComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnActorEnableCollisionChanged(UMeshComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnAttachmentChanged(UMeshComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnComponentCollisionSettingsChanged(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnComponentDestroyed(UMeshComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnCreatePhysicsState(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnDestroyPhysicsState(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnRegister(UMeshComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnUnregister(UMeshComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnUpdateTransform(UMeshComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_PostDuplicate(UMeshComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_PostLoad(UMeshComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PutAllRigidBodiesToSleep(UMeshComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UMeshComponent_RegisterComponentTickFunctions(UMeshComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_ScaleByMomentOfInertia(UMeshComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UMeshComponent_SendRenderTransform_Concurrent(UMeshComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetAllMassScale(UMeshComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetAllPhysicsAngularVelocity(UMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetAllPhysicsAngularVelocityInRadians(UMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetAllPhysicsLinearVelocity(UMeshComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetAllPhysicsPosition(UMeshComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetAllUseCCD(UMeshComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetAngularDamping(UMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetCollisionObjectType(UMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetCollisionProfileName(UMeshComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetCollisionResponseToAllChannels(UMeshComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetCollisionResponseToChannel(UMeshComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetCollisionResponseToChannels(UMeshComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetEnableGravity(UMeshComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetLinearDamping(UMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetMassOverrideInKg(UMeshComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetMassScale(UMeshComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetNotifyRigidBodyCollision(UMeshComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetSimulatePhysics(UMeshComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetUseCCD(UMeshComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_ShouldCreatePhysicsState(UMeshComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UMeshComponent_ShouldRecreateProxyOnUpdateTransform(UMeshComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UMeshComponent_ShouldRenderSelected(UMeshComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UMeshComponent_SupportsStaticLighting(UMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UMeshComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_UnWeldChildren(UMeshComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UMeshComponent_UnWeldFromParent(UMeshComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UMeshComponent_UpdatePhysicsToRBChannels(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_UpdatePhysicsVolume(UMeshComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_UsesOnlyUnlitMaterials(UMeshComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UMeshComponent_WakeAllRigidBodies(UMeshComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UMeshComponent_WakeRigidBody(UMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_WeldTo(UMeshComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_WeldToImplementation(UMeshComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UMeshComponent_ApplyWorldOffset(UMeshComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_CalcBoundingCylinder(UMeshComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_CanAttachAsChild(UMeshComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_DestroyComponent(UMeshComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_DetachFromComponent(UMeshComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_DetachFromParent(UMeshComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_DoesSocketExist(UMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetSocketLocation(UMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetSocketQuaternion(UMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetSocketRotation(UMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetSocketTransform(UMeshComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UMeshComponent_HasAnySockets(UMeshComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsAnySimulatingPhysics(UMeshComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsPrecomputedLightingValid(UMeshComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsVisible(UMeshComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsVisibleInEditor(UMeshComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnChildAttached(UMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnChildDetached(UMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnHiddenInGameChanged(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnVisibilityChanged(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PostNetReceive(UMeshComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PostRepNotifies(UMeshComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PreNetReceive(UMeshComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PropagateLightingScenarioChange(UMeshComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetRelativeScale3D(UMeshComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_ShouldCollideWhenPlacing(UMeshComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UMeshComponent_ShouldCreateRenderState(UMeshComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UMeshComponent_Activate(UMeshComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddTickPrerequisiteActor(UMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddTickPrerequisiteComponent(UMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_Deactivate(UMeshComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetComponentClassCanReplicate(UMeshComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetReadableName(UMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UMeshComponent_InitializeComponent(UMeshComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsActive(UMeshComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsNameStableForNetworking(UMeshComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsReadyForOwnerToAutoDestroy(UMeshComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsSupportedForNetworking(UMeshComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UMeshComponent_MarkAsEditorOnlySubobject(UMeshComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UMeshComponent_NeedsLoadForEditorGame(UMeshComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnComponentCreated(UMeshComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PostInitProperties(UMeshComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PostRename(UMeshComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_RemoveTickPrerequisiteActor(UMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_RemoveTickPrerequisiteComponent(UMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_RequiresGameThreadEndOfFrameRecreate(UMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UMeshComponent_RequiresGameThreadEndOfFrameUpdates(UMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UMeshComponent_SendRenderDynamicData_Concurrent(UMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UMeshComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetActive(UMeshComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetAutoActivate(UMeshComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetComponentTickEnabled(UMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_SetComponentTickEnabledAsync(UMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_ShouldActivate(UMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UMeshComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UMeshComponent_ToggleActive(UMeshComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UMeshComponent_UninitializeComponent(UMeshComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UMeshComponent_AreNativePropertiesIdenticalTo(UMeshComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_CheckDefaultSubobjectsInternal(UMeshComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetDesc(UMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UMeshComponent_GetDetailedInfoInternal(UMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsAsset(UMeshComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsFullNameStableForNetworking(UMeshComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsLocalizedResource(UMeshComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsPostLoadThreadSafe(UMeshComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UMeshComponent_IsSafeForRootSet(UMeshComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UMeshComponent_Modify(UMeshComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_NotifyObjectReferenceEliminated(UMeshComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PostCDOContruct(UMeshComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PostEditImport(UMeshComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UMeshComponent_PostSaveRoot(UMeshComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UMeshComponent_PreDestroyFromReplication(UMeshComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UMeshComponent_ShutdownAfterError(UMeshComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UMeshComponent_AddToCluster(UMeshComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UMeshComponent_CanBeClusterRoot(UMeshComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UMeshComponent_CanBeInCluster(UMeshComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UMeshComponent_CreateCluster(UMeshComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UMeshComponent_OnClusterMarkedAsPendingKill(UMeshComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
