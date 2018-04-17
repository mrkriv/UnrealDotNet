#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/CapsuleComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\CapsuleComponent.h:16

class E_PROTECTED_WRAP_UCapsuleComponent : protected UCapsuleComponent
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCapsuleComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCapsuleComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AreSymmetricRotations(UCapsuleComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CalcBoundingCylinder(UCapsuleComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleHalfHeight(UCapsuleComponent* Self)
	{
		return Self->GetScaledCapsuleHalfHeight();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(UCapsuleComponent* Self)
	{
		return Self->GetScaledCapsuleHalfHeight_WithoutHemisphere();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleRadius(UCapsuleComponent* Self)
	{
		return Self->GetScaledCapsuleRadius();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleSize(UCapsuleComponent* Self, float OutRadius, float OutHalfHeight)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeight;
		Self->GetScaledCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(UCapsuleComponent* Self, float OutRadius, float OutHalfHeightWithoutHemisphere)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeightWithoutHemisphere;
		Self->GetScaledCapsuleSize_WithoutHemisphere(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetShapeScale(UCapsuleComponent* Self)
	{
		return Self->GetShapeScale();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(UCapsuleComponent* Self)
	{
		return Self->GetUnscaledCapsuleHalfHeight();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(UCapsuleComponent* Self)
	{
		return Self->GetUnscaledCapsuleHalfHeight_WithoutHemisphere();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleRadius(UCapsuleComponent* Self)
	{
		return Self->GetUnscaledCapsuleRadius();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleSize(UCapsuleComponent* Self, float OutRadius, float OutHalfHeight)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeight;
		Self->GetUnscaledCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(UCapsuleComponent* Self, float OutRadius, float OutHalfHeightWithoutHemisphere)
	{
		auto _p0 = OutRadius;
		auto _p1 = OutHalfHeightWithoutHemisphere;
		Self->GetUnscaledCapsuleSize_WithoutHemisphere(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_InitCapsuleSize(UCapsuleComponent* Self, float InRadius, float InHalfHeight)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		Self->InitCapsuleSize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsZeroExtent(UCapsuleComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PostLoad(UCapsuleComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCapsuleHalfHeight(UCapsuleComponent* Self, float HalfHeight, bool bUpdateOverlaps)
	{
		auto _p0 = HalfHeight;
		auto _p1 = bUpdateOverlaps;
		Self->SetCapsuleHalfHeight(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCapsuleRadius(UCapsuleComponent* Self, float Radius, bool bUpdateOverlaps)
	{
		auto _p0 = Radius;
		auto _p1 = bUpdateOverlaps;
		Self->SetCapsuleRadius(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCapsuleSize(UCapsuleComponent* Self, float InRadius, float InHalfHeight, bool bUpdateOverlaps)
	{
		auto _p0 = InRadius;
		auto _p1 = InHalfHeight;
		auto _p2 = bUpdateOverlaps;
		Self->SetCapsuleSize(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_UpdateBodySetup(UCapsuleComponent* Self)
	{
		Self->UpdateBodySetup();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsNavigationRelevant(UCapsuleComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ShouldCollideWhenPlacing(UCapsuleComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddAngularImpulse(UCapsuleComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddAngularImpulseInRadians(UCapsuleComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddForce(UCapsuleComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddForceAtLocation(UCapsuleComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddForceAtLocationLocal(UCapsuleComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddImpulse(UCapsuleComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddImpulseAtLocation(UCapsuleComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddRadialForce(UCapsuleComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddRadialImpulse(UCapsuleComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AreAllCollideableDescendantsRelative(UCapsuleComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_BeginDestroy(UCapsuleComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_BeginPlay(UCapsuleComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CalculateMass(UCapsuleComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CanCharacterStepUp(UCapsuleComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CanEditSimulatePhysics(UCapsuleComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CreateRenderState_Concurrent(UCapsuleComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_DestroyRenderState_Concurrent(UCapsuleComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_FinishDestroy(UCapsuleComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetAngularDamping(UCapsuleComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetCollisionObjectType(UCapsuleComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetCollisionResponseToChannel(UCapsuleComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetComponentVelocity(UCapsuleComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetDiffuseBoost(UCapsuleComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetEmissiveBoost(UCapsuleComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetInertiaTensor(UCapsuleComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetLightAndShadowMapMemoryUsage(UCapsuleComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetLightMapResolution(UCapsuleComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetLinearDamping(UCapsuleComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetMass(UCapsuleComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetMassScale(UCapsuleComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetNavigationBounds(UCapsuleComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetNumMaterials(UCapsuleComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetShadowIndirectOnly(UCapsuleComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetSquaredDistanceToCollision(UCapsuleComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetStaticDepthPriorityGroup(UCapsuleComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetStaticLightMapResolution(UCapsuleComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_HasValidPhysicsState(UCapsuleComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_HasValidSettingsForStaticLighting(UCapsuleComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_InvalidateLightingCacheDetailed(UCapsuleComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsAnyRigidBodyAwake(UCapsuleComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsEditorOnly(UCapsuleComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsGravityEnabled(UCapsuleComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsReadyForFinishDestroy(UCapsuleComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsSimulatingPhysics(UCapsuleComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsWorldGeometry(UCapsuleComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_MoveComponentImpl(UCapsuleComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_NeedsLoadForClient(UCapsuleComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_NeedsLoadForServer(UCapsuleComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnActorEnableCollisionChanged(UCapsuleComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnAttachmentChanged(UCapsuleComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnComponentCollisionSettingsChanged(UCapsuleComponent* Self)
	{
		((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnComponentDestroyed(UCapsuleComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnCreatePhysicsState(UCapsuleComponent* Self)
	{
		((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnDestroyPhysicsState(UCapsuleComponent* Self)
	{
		((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnRegister(UCapsuleComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnUnregister(UCapsuleComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnUpdateTransform(UCapsuleComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PostDuplicate(UCapsuleComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PutAllRigidBodiesToSleep(UCapsuleComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_RegisterComponentTickFunctions(UCapsuleComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ScaleByMomentOfInertia(UCapsuleComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SendRenderTransform_Concurrent(UCapsuleComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetAllMassScale(UCapsuleComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetAllPhysicsAngularVelocity(UCapsuleComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetAllPhysicsAngularVelocityInRadians(UCapsuleComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetAllPhysicsLinearVelocity(UCapsuleComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetAllPhysicsPosition(UCapsuleComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetAllUseCCD(UCapsuleComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetAngularDamping(UCapsuleComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCollisionObjectType(UCapsuleComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCollisionProfileName(UCapsuleComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCollisionResponseToAllChannels(UCapsuleComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCollisionResponseToChannel(UCapsuleComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetCollisionResponseToChannels(UCapsuleComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetEnableGravity(UCapsuleComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetLinearDamping(UCapsuleComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetMassOverrideInKg(UCapsuleComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetMassScale(UCapsuleComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetNotifyRigidBodyCollision(UCapsuleComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetSimulatePhysics(UCapsuleComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetUseCCD(UCapsuleComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ShouldCreatePhysicsState(UCapsuleComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ShouldRecreateProxyOnUpdateTransform(UCapsuleComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ShouldRenderSelected(UCapsuleComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SupportsStaticLighting(UCapsuleComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_UnWeldChildren(UCapsuleComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_UnWeldFromParent(UCapsuleComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_UpdatePhysicsToRBChannels(UCapsuleComponent* Self)
	{
		((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_UpdatePhysicsVolume(UCapsuleComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_UsesOnlyUnlitMaterials(UCapsuleComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_WakeAllRigidBodies(UCapsuleComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_WakeRigidBody(UCapsuleComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_WeldTo(UCapsuleComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_WeldToImplementation(UCapsuleComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ApplyWorldOffset(UCapsuleComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CanAttachAsChild(UCapsuleComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_DestroyComponent(UCapsuleComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_DetachFromComponent(UCapsuleComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_DetachFromParent(UCapsuleComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_DoesSocketExist(UCapsuleComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetSocketLocation(UCapsuleComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetSocketQuaternion(UCapsuleComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetSocketRotation(UCapsuleComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetSocketTransform(UCapsuleComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_HasAnySockets(UCapsuleComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsAnySimulatingPhysics(UCapsuleComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsPrecomputedLightingValid(UCapsuleComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsVisible(UCapsuleComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsVisibleInEditor(UCapsuleComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnChildAttached(UCapsuleComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnChildDetached(UCapsuleComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnHiddenInGameChanged(UCapsuleComponent* Self)
	{
		((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnVisibilityChanged(UCapsuleComponent* Self)
	{
		((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PostNetReceive(UCapsuleComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PostRepNotifies(UCapsuleComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PreNetReceive(UCapsuleComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PropagateLightingScenarioChange(UCapsuleComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetRelativeScale3D(UCapsuleComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ShouldCreateRenderState(UCapsuleComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_Activate(UCapsuleComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddTickPrerequisiteActor(UCapsuleComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddTickPrerequisiteComponent(UCapsuleComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_Deactivate(UCapsuleComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetComponentClassCanReplicate(UCapsuleComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetReadableName(UCapsuleComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_InitializeComponent(UCapsuleComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsActive(UCapsuleComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsNameStableForNetworking(UCapsuleComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsReadyForOwnerToAutoDestroy(UCapsuleComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsSupportedForNetworking(UCapsuleComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_MarkAsEditorOnlySubobject(UCapsuleComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_NeedsLoadForEditorGame(UCapsuleComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnComponentCreated(UCapsuleComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PostInitProperties(UCapsuleComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PostRename(UCapsuleComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_RemoveTickPrerequisiteActor(UCapsuleComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_RemoveTickPrerequisiteComponent(UCapsuleComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_RequiresGameThreadEndOfFrameRecreate(UCapsuleComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_RequiresGameThreadEndOfFrameUpdates(UCapsuleComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SendRenderDynamicData_Concurrent(UCapsuleComponent* Self)
	{
		((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetActive(UCapsuleComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetAutoActivate(UCapsuleComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetComponentTickEnabled(UCapsuleComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_SetComponentTickEnabledAsync(UCapsuleComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ShouldActivate(UCapsuleComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UCapsuleComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ToggleActive(UCapsuleComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_UninitializeComponent(UCapsuleComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AreNativePropertiesIdenticalTo(UCapsuleComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CheckDefaultSubobjectsInternal(UCapsuleComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetDesc(UCapsuleComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_GetDetailedInfoInternal(UCapsuleComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsAsset(UCapsuleComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsFullNameStableForNetworking(UCapsuleComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsLocalizedResource(UCapsuleComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsPostLoadThreadSafe(UCapsuleComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_IsSafeForRootSet(UCapsuleComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_Modify(UCapsuleComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_NotifyObjectReferenceEliminated(UCapsuleComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PostCDOContruct(UCapsuleComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PostEditImport(UCapsuleComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PostSaveRoot(UCapsuleComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_PreDestroyFromReplication(UCapsuleComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_ShutdownAfterError(UCapsuleComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_AddToCluster(UCapsuleComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CanBeClusterRoot(UCapsuleComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CanBeInCluster(UCapsuleComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_CreateCluster(UCapsuleComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UCapsuleComponent_OnClusterMarkedAsPendingKill(UCapsuleComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
