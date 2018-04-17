#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/PoseableMeshComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PoseableMeshComponent.h:17

class E_PROTECTED_WRAP_UPoseableMeshComponent : protected UPoseableMeshComponent
{
public:
	void SendRenderDynamicData_Concurrent_WRAP()
	{
		SendRenderDynamicData_Concurrent();
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

	bool ShouldActivate_WRAP()
	{
		return ShouldActivate();
	}

}
;

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPoseableMeshComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPoseableMeshComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_BeginDestroy(UPoseableMeshComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ClearRefPoseOverride(UPoseableMeshComponent* Self)
	{
		Self->ClearRefPoseOverride();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CreateRenderState_Concurrent(UPoseableMeshComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_DestroyRenderState_Concurrent(UPoseableMeshComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_DoesSocketExist(UPoseableMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetDetailedInfoInternal(UPoseableMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetMaterialIndex(UPoseableMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->GetMaterialIndex(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetNumMaterials(UPoseableMeshComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetSocketTransform(UPoseableMeshComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_HasAnySockets(UPoseableMeshComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsMaterialSlotNameValid(UPoseableMeshComponent* Self, char* MaterialSlotName)
	{
		auto _p0 = ConvertFromManage_FName(MaterialSlotName);
		return Self->IsMaterialSlotNameValid(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnRegister(UPoseableMeshComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnUnregister(UPoseableMeshComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_RequiresGameThreadEndOfFrameRecreate(UPoseableMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SendRenderDynamicData_Concurrent(UPoseableMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ShouldCPUSkin(UPoseableMeshComponent* Self)
	{
		return Self->ShouldCPUSkin();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddAngularImpulse(UPoseableMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddAngularImpulseInRadians(UPoseableMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddForce(UPoseableMeshComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddForceAtLocation(UPoseableMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddForceAtLocationLocal(UPoseableMeshComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddImpulse(UPoseableMeshComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddImpulseAtLocation(UPoseableMeshComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddRadialForce(UPoseableMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddRadialImpulse(UPoseableMeshComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AreAllCollideableDescendantsRelative(UPoseableMeshComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AreSymmetricRotations(UPoseableMeshComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_BeginPlay(UPoseableMeshComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CalculateMass(UPoseableMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CanCharacterStepUp(UPoseableMeshComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CanEditSimulatePhysics(UPoseableMeshComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_FinishDestroy(UPoseableMeshComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetAngularDamping(UPoseableMeshComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetCollisionObjectType(UPoseableMeshComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetCollisionResponseToChannel(UPoseableMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetComponentVelocity(UPoseableMeshComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetDiffuseBoost(UPoseableMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetEmissiveBoost(UPoseableMeshComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetInertiaTensor(UPoseableMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetLightAndShadowMapMemoryUsage(UPoseableMeshComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetLightMapResolution(UPoseableMeshComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetLinearDamping(UPoseableMeshComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetMass(UPoseableMeshComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetMassScale(UPoseableMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetNavigationBounds(UPoseableMeshComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetShadowIndirectOnly(UPoseableMeshComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetSquaredDistanceToCollision(UPoseableMeshComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetStaticDepthPriorityGroup(UPoseableMeshComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetStaticLightMapResolution(UPoseableMeshComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_HasValidPhysicsState(UPoseableMeshComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_HasValidSettingsForStaticLighting(UPoseableMeshComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_InvalidateLightingCacheDetailed(UPoseableMeshComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsAnyRigidBodyAwake(UPoseableMeshComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsEditorOnly(UPoseableMeshComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsGravityEnabled(UPoseableMeshComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsNavigationRelevant(UPoseableMeshComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsReadyForFinishDestroy(UPoseableMeshComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsSimulatingPhysics(UPoseableMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsWorldGeometry(UPoseableMeshComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsZeroExtent(UPoseableMeshComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_MoveComponentImpl(UPoseableMeshComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_NeedsLoadForClient(UPoseableMeshComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_NeedsLoadForServer(UPoseableMeshComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnActorEnableCollisionChanged(UPoseableMeshComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnAttachmentChanged(UPoseableMeshComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnComponentCollisionSettingsChanged(UPoseableMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnComponentDestroyed(UPoseableMeshComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnCreatePhysicsState(UPoseableMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnDestroyPhysicsState(UPoseableMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnUpdateTransform(UPoseableMeshComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PostDuplicate(UPoseableMeshComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PostLoad(UPoseableMeshComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PutAllRigidBodiesToSleep(UPoseableMeshComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_RegisterComponentTickFunctions(UPoseableMeshComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ScaleByMomentOfInertia(UPoseableMeshComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SendRenderTransform_Concurrent(UPoseableMeshComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetAllMassScale(UPoseableMeshComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetAllPhysicsAngularVelocity(UPoseableMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetAllPhysicsAngularVelocityInRadians(UPoseableMeshComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetAllPhysicsLinearVelocity(UPoseableMeshComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetAllPhysicsPosition(UPoseableMeshComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetAllUseCCD(UPoseableMeshComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetAngularDamping(UPoseableMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetCollisionObjectType(UPoseableMeshComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetCollisionProfileName(UPoseableMeshComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetCollisionResponseToAllChannels(UPoseableMeshComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetCollisionResponseToChannel(UPoseableMeshComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetCollisionResponseToChannels(UPoseableMeshComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetEnableGravity(UPoseableMeshComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetLinearDamping(UPoseableMeshComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetMassOverrideInKg(UPoseableMeshComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetMassScale(UPoseableMeshComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetNotifyRigidBodyCollision(UPoseableMeshComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetSimulatePhysics(UPoseableMeshComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetUseCCD(UPoseableMeshComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ShouldCreatePhysicsState(UPoseableMeshComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ShouldRecreateProxyOnUpdateTransform(UPoseableMeshComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ShouldRenderSelected(UPoseableMeshComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SupportsStaticLighting(UPoseableMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_UnWeldChildren(UPoseableMeshComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_UnWeldFromParent(UPoseableMeshComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_UpdatePhysicsToRBChannels(UPoseableMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_UpdatePhysicsVolume(UPoseableMeshComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_UsesOnlyUnlitMaterials(UPoseableMeshComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_WakeAllRigidBodies(UPoseableMeshComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_WakeRigidBody(UPoseableMeshComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_WeldTo(UPoseableMeshComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_WeldToImplementation(UPoseableMeshComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ApplyWorldOffset(UPoseableMeshComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CalcBoundingCylinder(UPoseableMeshComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CanAttachAsChild(UPoseableMeshComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_DestroyComponent(UPoseableMeshComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_DetachFromComponent(UPoseableMeshComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_DetachFromParent(UPoseableMeshComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetSocketLocation(UPoseableMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetSocketQuaternion(UPoseableMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetSocketRotation(UPoseableMeshComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsAnySimulatingPhysics(UPoseableMeshComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsPrecomputedLightingValid(UPoseableMeshComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsVisible(UPoseableMeshComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsVisibleInEditor(UPoseableMeshComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnChildAttached(UPoseableMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnChildDetached(UPoseableMeshComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnHiddenInGameChanged(UPoseableMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnVisibilityChanged(UPoseableMeshComponent* Self)
	{
		((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PostNetReceive(UPoseableMeshComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PostRepNotifies(UPoseableMeshComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PreNetReceive(UPoseableMeshComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PropagateLightingScenarioChange(UPoseableMeshComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetRelativeScale3D(UPoseableMeshComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ShouldCollideWhenPlacing(UPoseableMeshComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ShouldCreateRenderState(UPoseableMeshComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_Activate(UPoseableMeshComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddTickPrerequisiteActor(UPoseableMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddTickPrerequisiteComponent(UPoseableMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_Deactivate(UPoseableMeshComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetComponentClassCanReplicate(UPoseableMeshComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetReadableName(UPoseableMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_InitializeComponent(UPoseableMeshComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsActive(UPoseableMeshComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsNameStableForNetworking(UPoseableMeshComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsReadyForOwnerToAutoDestroy(UPoseableMeshComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsSupportedForNetworking(UPoseableMeshComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_MarkAsEditorOnlySubobject(UPoseableMeshComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_NeedsLoadForEditorGame(UPoseableMeshComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnComponentCreated(UPoseableMeshComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PostInitProperties(UPoseableMeshComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PostRename(UPoseableMeshComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_RemoveTickPrerequisiteActor(UPoseableMeshComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_RemoveTickPrerequisiteComponent(UPoseableMeshComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_RequiresGameThreadEndOfFrameUpdates(UPoseableMeshComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetActive(UPoseableMeshComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetAutoActivate(UPoseableMeshComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetComponentTickEnabled(UPoseableMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_SetComponentTickEnabledAsync(UPoseableMeshComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ShouldActivate(UPoseableMeshComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPoseableMeshComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ToggleActive(UPoseableMeshComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_UninitializeComponent(UPoseableMeshComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AreNativePropertiesIdenticalTo(UPoseableMeshComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CheckDefaultSubobjectsInternal(UPoseableMeshComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_GetDesc(UPoseableMeshComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsAsset(UPoseableMeshComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsFullNameStableForNetworking(UPoseableMeshComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsLocalizedResource(UPoseableMeshComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsPostLoadThreadSafe(UPoseableMeshComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_IsSafeForRootSet(UPoseableMeshComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_Modify(UPoseableMeshComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_NotifyObjectReferenceEliminated(UPoseableMeshComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PostCDOContruct(UPoseableMeshComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PostEditImport(UPoseableMeshComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PostSaveRoot(UPoseableMeshComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_PreDestroyFromReplication(UPoseableMeshComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_ShutdownAfterError(UPoseableMeshComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_AddToCluster(UPoseableMeshComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CanBeClusterRoot(UPoseableMeshComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CanBeInCluster(UPoseableMeshComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_CreateCluster(UPoseableMeshComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UPoseableMeshComponent_OnClusterMarkedAsPendingKill(UPoseableMeshComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
