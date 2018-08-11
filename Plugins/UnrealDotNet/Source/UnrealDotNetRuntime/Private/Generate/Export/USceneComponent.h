#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/SceneComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:103

class E_PROTECTED_WRAP_USceneComponent : protected USceneComponent
{
public:
	bool AreDynamicDataChangesAllowed_WRAP(bool bIgnoreStationary)
	{
		return AreDynamicDataChangesAllowed(bIgnoreStationary);
	}

	FTransform CalcNewComponentToWorld_WRAP(const FTransform& NewRelativeTransform, const USceneComponent* Parent, FName SocketName)
	{
		return CalcNewComponentToWorld(NewRelativeTransform, Parent, SocketName);
	}

	FTransform CalcNewComponentToWorld_GeneralCase_WRAP(const FTransform& NewRelativeTransform, const USceneComponent* Parent, FName SocketName)
	{
		return CalcNewComponentToWorld_GeneralCase(NewRelativeTransform, Parent, SocketName);
	}

	bool CheckStaticMobilityAndWarn_WRAP(const FText& ActionText)
	{
		return CheckStaticMobilityAndWarn(ActionText);
	}

	bool InternalSetWorldLocationAndRotation_WRAP(FVector NewLocation, const FQuat& NewQuat, bool bNoPhysics, ETeleportType Teleport)
	{
		return InternalSetWorldLocationAndRotation(NewLocation, NewQuat, bNoPhysics, Teleport);
	}

	bool MoveComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		return MoveComponentImpl(Delta, NewRotation, bSweep, Hit, MoveFlags, Teleport);
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

	void OnUpdateTransform_WRAP(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		OnUpdateTransform(UpdateTransformFlags, Teleport);
	}

	void OnVisibilityChanged_WRAP()
	{
		OnVisibilityChanged();
	}

	void PostUpdateNavigationData_WRAP()
	{
		PostUpdateNavigationData();
	}

	void UpdateNavigationData_WRAP()
	{
		UpdateNavigationData();
	}

}
;

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USceneComponent_bAbsoluteLocation_GET(USceneComponent* Ptr) { return Ptr->bAbsoluteLocation; }
	DOTNET_EXPORT void E_PROP_USceneComponent_bAbsoluteLocation_SET(USceneComponent* Ptr, uint8 Value) { Ptr->bAbsoluteLocation = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_bAbsoluteRotation_GET(USceneComponent* Ptr) { return Ptr->bAbsoluteRotation; }
	DOTNET_EXPORT void E_PROP_USceneComponent_bAbsoluteRotation_SET(USceneComponent* Ptr, uint8 Value) { Ptr->bAbsoluteRotation = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_bAbsoluteScale_GET(USceneComponent* Ptr) { return Ptr->bAbsoluteScale; }
	DOTNET_EXPORT void E_PROP_USceneComponent_bAbsoluteScale_SET(USceneComponent* Ptr, uint8 Value) { Ptr->bAbsoluteScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_bBoundsChangeTriggersStreamingDataRebuild_GET(USceneComponent* Ptr) { return Ptr->bBoundsChangeTriggersStreamingDataRebuild; }
	DOTNET_EXPORT void E_PROP_USceneComponent_bBoundsChangeTriggersStreamingDataRebuild_SET(USceneComponent* Ptr, uint8 Value) { Ptr->bBoundsChangeTriggersStreamingDataRebuild = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_bHiddenInGame_GET(USceneComponent* Ptr) { return Ptr->bHiddenInGame; }
	DOTNET_EXPORT void E_PROP_USceneComponent_bHiddenInGame_SET(USceneComponent* Ptr, uint8 Value) { Ptr->bHiddenInGame = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_bUseAttachParentBound_GET(USceneComponent* Ptr) { return Ptr->bUseAttachParentBound; }
	DOTNET_EXPORT void E_PROP_USceneComponent_bUseAttachParentBound_SET(USceneComponent* Ptr, uint8 Value) { Ptr->bUseAttachParentBound = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_bVisible_GET(USceneComponent* Ptr) { return Ptr->bVisible; }
	DOTNET_EXPORT void E_PROP_USceneComponent_bVisible_SET(USceneComponent* Ptr, uint8 Value) { Ptr->bVisible = Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_ComponentVelocity_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->ComponentVelocity); }
	DOTNET_EXPORT void E_PROP_USceneComponent_ComponentVelocity_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->ComponentVelocity = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_RelativeLocation_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->RelativeLocation); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeLocation_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->RelativeLocation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_RelativeRotation_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->RelativeRotation); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeRotation_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->RelativeRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_RelativeScale3D_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->RelativeScale3D); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeScale3D_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->RelativeScale3D = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_SkipUpdateOverlapsOptimEnabled_GET() { return USceneComponent::SkipUpdateOverlapsOptimEnabled; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneComponent_AddLocalOffset(USceneComponent* Self, INT_PTR DeltaLocation, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)DeltaLocation;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->AddLocalOffset(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_AddLocalTransform(USceneComponent* Self, INT_PTR DeltaTransform, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FTransform*)DeltaTransform;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->AddLocalTransform(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_AddRelativeLocation(USceneComponent* Self, INT_PTR DeltaLocation, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)DeltaLocation;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->AddRelativeLocation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_AddWorldOffset(USceneComponent* Self, INT_PTR DeltaLocation, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)DeltaLocation;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->AddWorldOffset(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_AddWorldTransform(USceneComponent* Self, INT_PTR DeltaTransform, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FTransform*)DeltaTransform;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->AddWorldTransform(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_AreDynamicDataChangesAllowed(USceneComponent* Self, bool bIgnoreStationary)
	{
		auto _p0 = bIgnoreStationary;
		return ((E_PROTECTED_WRAP_USceneComponent*)Self)->AreDynamicDataChangesAllowed_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_AttachToComponent(USceneComponent* Self, USceneComponent* InParent, INT_PTR AttachmentRules, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = *(FAttachmentTransformRules*)AttachmentRules;
		auto _p2 = ConvertFromManage_FName(InSocketName);
		return Self->AttachToComponent(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USceneComponent_CalcBoundingCylinder(USceneComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_CalcNewComponentToWorld(USceneComponent* Self, INT_PTR NewRelativeTransform, USceneComponent* Parent, char* SocketName)
	{
		auto _p0 = *(FTransform*)NewRelativeTransform;
		auto _p1 = Parent;
		auto _p2 = ConvertFromManage_FName(SocketName);
		return (INT_PTR) new FTransform(((E_PROTECTED_WRAP_USceneComponent*)Self)->CalcNewComponentToWorld_WRAP(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_USceneComponent_CalcNewComponentToWorld_GeneralCase(USceneComponent* Self, INT_PTR NewRelativeTransform, USceneComponent* Parent, char* SocketName)
	{
		auto _p0 = *(FTransform*)NewRelativeTransform;
		auto _p1 = Parent;
		auto _p2 = ConvertFromManage_FName(SocketName);
		return (INT_PTR) new FTransform(((E_PROTECTED_WRAP_USceneComponent*)Self)->CalcNewComponentToWorld_GeneralCase_WRAP(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_USceneComponent_CanAttachAsChild(USceneComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_CanEverRender(USceneComponent* Self)
	{
		return Self->CanEverRender();
	}

	DOTNET_EXPORT auto E_USceneComponent_CheckStaticMobilityAndWarn(USceneComponent* Self, char* ActionText)
	{
		auto _p0 = ConvertFromManage_FText(ActionText);
		return ((E_PROTECTED_WRAP_USceneComponent*)Self)->CheckStaticMobilityAndWarn_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_ClearSkipUpdateOverlaps(USceneComponent* Self)
	{
		Self->ClearSkipUpdateOverlaps();
	}

	DOTNET_EXPORT auto E_USceneComponent_ConditionalUpdateComponentToWorld(USceneComponent* Self)
	{
		Self->ConditionalUpdateComponentToWorld();
	}

	DOTNET_EXPORT auto E_USceneComponent_DetachFromComponent(USceneComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_DoesSocketExist(USceneComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_GetAttachmentRoot(USceneComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetAttachmentRoot());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetAttachmentRootActor(USceneComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetAttachmentRootActor());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetAttachParent(USceneComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetAttachParent());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetAttachSocketName(USceneComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetAttachSocketName());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetChildComponent(USceneComponent* Self, int32 ChildIndex)
	{
		auto _p0 = ChildIndex;
		return ConvertToManage_ObjectPointerDescription(Self->GetChildComponent(_p0));
	}

	DOTNET_EXPORT auto E_USceneComponent_GetCollisionObjectType(USceneComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_USceneComponent_GetCollisionResponseToChannel(USceneComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_GetCollisionResponseToComponent(USceneComponent* Self, USceneComponent* OtherComponent)
	{
		auto _p0 = OtherComponent;
		return Self->GetCollisionResponseToComponent(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_GetComponentLocation(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentLocation());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetComponentQuat(USceneComponent* Self)
	{
		return (INT_PTR) new FQuat(Self->GetComponentQuat());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetComponentRotation(USceneComponent* Self)
	{
		return (INT_PTR) new FRotator(Self->GetComponentRotation());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetComponentScale(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentScale());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetComponentVelocity(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetDefaultSceneRootVariableName(USceneComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDefaultSceneRootVariableName());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetForwardVector(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetForwardVector());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetNumChildrenComponents(USceneComponent* Self)
	{
		return Self->GetNumChildrenComponents();
	}

	DOTNET_EXPORT auto E_USceneComponent_GetRelativeRotationFromWorld(USceneComponent* Self, INT_PTR WorldRotation)
	{
		auto _p0 = *(FQuat*)WorldRotation;
		return (INT_PTR) new FQuat(Self->GetRelativeRotationFromWorld(_p0));
	}

	DOTNET_EXPORT auto E_USceneComponent_GetRelativeTransform(USceneComponent* Self)
	{
		return (INT_PTR) new FTransform(Self->GetRelativeTransform());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetRightVector(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetRightVector());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetShouldUpdatePhysicsVolume(USceneComponent* Self)
	{
		return Self->GetShouldUpdatePhysicsVolume();
	}

	DOTNET_EXPORT auto E_USceneComponent_GetSocketLocation(USceneComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_USceneComponent_GetSocketQuaternion(USceneComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_USceneComponent_GetSocketRotation(USceneComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_USceneComponent_GetSocketTransform(USceneComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_USceneComponent_GetUpVector(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetUpVector());
	}

	DOTNET_EXPORT auto E_USceneComponent_HasAnySockets(USceneComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_USceneComponent_InternalSetWorldLocationAndRotation(USceneComponent* Self, INT_PTR NewLocation, INT_PTR NewQuat, bool bNoPhysics, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = *(FQuat*)NewQuat;
		auto _p2 = bNoPhysics;
		auto _p3 = Teleport;
		return ((E_PROTECTED_WRAP_USceneComponent*)Self)->InternalSetWorldLocationAndRotation_WRAP(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_IsAnySimulatingPhysics(USceneComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_USceneComponent_IsAttachedTo(USceneComponent* Self, USceneComponent* TestComp)
	{
		auto _p0 = TestComp;
		return Self->IsAttachedTo(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_IsCollisionEnabled(USceneComponent* Self)
	{
		return Self->IsCollisionEnabled();
	}

	DOTNET_EXPORT auto E_USceneComponent_IsDeferringMovementUpdates(USceneComponent* Self)
	{
		return Self->IsDeferringMovementUpdates();
	}

	DOTNET_EXPORT auto E_USceneComponent_IsPhysicsCollisionEnabled(USceneComponent* Self)
	{
		return Self->IsPhysicsCollisionEnabled();
	}

	DOTNET_EXPORT auto E_USceneComponent_IsPrecomputedLightingValid(USceneComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_USceneComponent_IsQueryCollisionEnabled(USceneComponent* Self)
	{
		return Self->IsQueryCollisionEnabled();
	}

	DOTNET_EXPORT auto E_USceneComponent_IsSimulatingPhysics(USceneComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_IsVisible(USceneComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_USceneComponent_IsVisibleInEditor(USceneComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_USceneComponent_IsWorldGeometry(USceneComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AddLocalOffset(USceneComponent* Self, INT_PTR DeltaLocation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FVector*)DeltaLocation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_AddLocalOffset(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AddLocalRotation(USceneComponent* Self, INT_PTR DeltaRotation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FRotator*)DeltaRotation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_AddLocalRotation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AddLocalTransform(USceneComponent* Self, INT_PTR DeltaTransform, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FTransform*)DeltaTransform;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_AddLocalTransform(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AddRelativeLocation(USceneComponent* Self, INT_PTR DeltaLocation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FVector*)DeltaLocation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_AddRelativeLocation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AddRelativeRotation(USceneComponent* Self, INT_PTR DeltaRotation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FRotator*)DeltaRotation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_AddRelativeRotation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AddWorldOffset(USceneComponent* Self, INT_PTR DeltaLocation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FVector*)DeltaLocation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_AddWorldOffset(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AddWorldRotation(USceneComponent* Self, INT_PTR DeltaRotation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FRotator*)DeltaRotation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_AddWorldRotation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AddWorldTransform(USceneComponent* Self, INT_PTR DeltaTransform, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FTransform*)DeltaTransform;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_AddWorldTransform(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AttachToComponent(USceneComponent* Self, USceneComponent* Parent, char* SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
	{
		auto _p0 = Parent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		auto _p2 = LocationRule;
		auto _p3 = RotationRule;
		auto _p4 = ScaleRule;
		auto _p5 = bWeldSimulatedBodies;
		return Self->K2_AttachToComponent(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_DetachFromComponent(USceneComponent* Self, EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, bool bCallModify)
	{
		auto _p0 = LocationRule;
		auto _p1 = RotationRule;
		auto _p2 = ScaleRule;
		auto _p3 = bCallModify;
		Self->K2_DetachFromComponent(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_GetComponentLocation(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->K2_GetComponentLocation());
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_GetComponentRotation(USceneComponent* Self)
	{
		return (INT_PTR) new FRotator(Self->K2_GetComponentRotation());
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_GetComponentScale(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->K2_GetComponentScale());
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_GetComponentToWorld(USceneComponent* Self)
	{
		return (INT_PTR) new FTransform(Self->K2_GetComponentToWorld());
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_SetRelativeLocation(USceneComponent* Self, INT_PTR NewLocation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_SetRelativeLocation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_SetRelativeLocationAndRotation(USceneComponent* Self, INT_PTR NewLocation, INT_PTR NewRotation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = *(FRotator*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = *(FHitResult*)SweepHitResult;
		auto _p4 = bTeleport;
		Self->K2_SetRelativeLocationAndRotation(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_SetRelativeRotation(USceneComponent* Self, INT_PTR NewRotation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FRotator*)NewRotation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_SetRelativeRotation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_SetRelativeTransform(USceneComponent* Self, INT_PTR NewTransform, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FTransform*)NewTransform;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_SetRelativeTransform(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_SetWorldLocation(USceneComponent* Self, INT_PTR NewLocation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_SetWorldLocation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_SetWorldLocationAndRotation(USceneComponent* Self, INT_PTR NewLocation, INT_PTR NewRotation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = *(FRotator*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = *(FHitResult*)SweepHitResult;
		auto _p4 = bTeleport;
		Self->K2_SetWorldLocationAndRotation(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_SetWorldRotation(USceneComponent* Self, INT_PTR NewRotation, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FRotator*)NewRotation;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_SetWorldRotation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_SetWorldTransform(USceneComponent* Self, INT_PTR NewTransform, bool bSweep, INT_PTR SweepHitResult, bool bTeleport)
	{
		auto _p0 = *(FTransform*)NewTransform;
		auto _p1 = bSweep;
		auto _p2 = *(FHitResult*)SweepHitResult;
		auto _p3 = bTeleport;
		Self->K2_SetWorldTransform(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_MoveComponentImpl(USceneComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_USceneComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_USceneComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_USceneComponent_OnChildAttached(USceneComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_OnChildDetached(USceneComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USceneComponent_OnUpdateTransform(USceneComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnUpdateTransform_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_USceneComponent_PostUpdateNavigationData(USceneComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneComponent*)Self)->PostUpdateNavigationData_WRAP();
	}

	DOTNET_EXPORT auto E_USceneComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_USceneComponent_ResetRelativeTransform(USceneComponent* Self)
	{
		Self->ResetRelativeTransform();
	}

	DOTNET_EXPORT auto E_USceneComponent_SetAbsolute(USceneComponent* Self, bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale)
	{
		auto _p0 = bNewAbsoluteLocation;
		auto _p1 = bNewAbsoluteRotation;
		auto _p2 = bNewAbsoluteScale;
		Self->SetAbsolute(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetComponentToWorld(USceneComponent* Self, INT_PTR NewComponentToWorld)
	{
		auto _p0 = *(FTransform*)NewComponentToWorld;
		Self->SetComponentToWorld(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetHiddenInGame(USceneComponent* Self, bool NewHidden, bool bPropagateToChildren)
	{
		auto _p0 = NewHidden;
		auto _p1 = bPropagateToChildren;
		Self->SetHiddenInGame(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetRelativeLocation(USceneComponent* Self, INT_PTR NewLocation, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->SetRelativeLocation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetRelativeRotationCache(USceneComponent* Self, INT_PTR InCache)
	{
		auto _p0 = *(FRotationConversionCache*)InCache;
		Self->SetRelativeRotationCache(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetRelativeRotationExact(USceneComponent* Self, INT_PTR NewRotation, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FRotator*)NewRotation;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->SetRelativeRotationExact(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetRelativeScale3D(USceneComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetRelativeTransform(USceneComponent* Self, INT_PTR NewTransform, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FTransform*)NewTransform;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->SetRelativeTransform(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetShouldUpdatePhysicsVolume(USceneComponent* Self, bool bInShouldUpdatePhysicsVolume)
	{
		auto _p0 = bInShouldUpdatePhysicsVolume;
		Self->SetShouldUpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetupAttachment(USceneComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->SetupAttachment(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetVisibility(USceneComponent* Self, bool bNewVisibility, bool bPropagateToChildren)
	{
		auto _p0 = bNewVisibility;
		auto _p1 = bPropagateToChildren;
		Self->SetVisibility(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetWorldLocation(USceneComponent* Self, INT_PTR NewLocation, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->SetWorldLocation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetWorldLocationAndRotationNoPhysics(USceneComponent* Self, INT_PTR NewLocation, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = *(FRotator*)NewRotation;
		Self->SetWorldLocationAndRotationNoPhysics(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetWorldScale3D(USceneComponent* Self, INT_PTR NewScale)
	{
		auto _p0 = *(FVector*)NewScale;
		Self->SetWorldScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetWorldTransform(USceneComponent* Self, INT_PTR NewTransform, bool bSweep, INT_PTR OutSweepHitResult, ETeleportType Teleport)
	{
		auto _p0 = *(FTransform*)NewTransform;
		auto _p1 = bSweep;
		auto _p2 = (FHitResult*)OutSweepHitResult;
		auto _p3 = Teleport;
		Self->SetWorldTransform(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_USceneComponent_ShouldCollideWhenPlacing(USceneComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_USceneComponent_ShouldComponentAddToScene(USceneComponent* Self)
	{
		return Self->ShouldComponentAddToScene();
	}

	DOTNET_EXPORT auto E_USceneComponent_ShouldRender(USceneComponent* Self)
	{
		return Self->ShouldRender();
	}

	DOTNET_EXPORT auto E_USceneComponent_ShouldSkipUpdateOverlaps(USceneComponent* Self)
	{
		return Self->ShouldSkipUpdateOverlaps();
	}

	DOTNET_EXPORT auto E_USceneComponent_SnapTo(USceneComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		return Self->SnapTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_ToggleVisibility(USceneComponent* Self, bool bPropagateToChildren)
	{
		auto _p0 = bPropagateToChildren;
		Self->ToggleVisibility(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_UpdateBounds(USceneComponent* Self)
	{
		Self->UpdateBounds();
	}

	DOTNET_EXPORT auto E_USceneComponent_UpdateChildTransforms(USceneComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateChildTransforms(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_UpdateNavigationData(USceneComponent* Self)
	{
		((E_PROTECTED_WRAP_USceneComponent*)Self)->UpdateNavigationData_WRAP();
	}

	DOTNET_EXPORT auto E_USceneComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
