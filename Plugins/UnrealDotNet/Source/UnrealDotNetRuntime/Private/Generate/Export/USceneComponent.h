#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Components/SceneComponent.h"

class E_PROTECTED_WRAP_USceneComponent : protected USceneComponent
{
public:
	bool AreDynamicDataChangesAllowed_WRAP(bool bIgnoreStationary)
	{
		return AreDynamicDataChangesAllowed(bIgnoreStationary);
	}

	bool CheckStaticMobilityAndWarn_WRAP(const FText& ActionText)
	{
		return CheckStaticMobilityAndWarn(ActionText);
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
	DOTNET_EXPORT auto E_PROP_USceneComponent_ComponentToWorld_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->ComponentToWorld); }
	DOTNET_EXPORT void E_PROP_USceneComponent_ComponentToWorld_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->ComponentToWorld = *(FTransform*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_ComponentVelocity_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->ComponentVelocity); }
	DOTNET_EXPORT void E_PROP_USceneComponent_ComponentVelocity_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->ComponentVelocity = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_RelativeLocation_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->RelativeLocation); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeLocation_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->RelativeLocation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_RelativeRotation_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->RelativeRotation); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeRotation_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->RelativeRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_RelativeScale3D_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->RelativeScale3D); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeScale3D_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->RelativeScale3D = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_GET(USceneComponent* Ptr) { return (INT_PTR)&(Ptr->RelativeTranslation_DEPRECATED); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_SET(USceneComponent* Ptr, INT_PTR Value) { Ptr->RelativeTranslation_DEPRECATED = *(FVector*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneComponent_AreDynamicDataChangesAllowed(USceneComponent* Self, bool bIgnoreStationary)
	{
		auto _p0 = bIgnoreStationary;
		return ((E_PROTECTED_WRAP_USceneComponent*)Self)->AreDynamicDataChangesAllowed_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_CalcBoundingCylinder(USceneComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
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

	DOTNET_EXPORT auto E_USceneComponent_ConditionalUpdateComponentToWorld(USceneComponent* Self)
	{
		Self->ConditionalUpdateComponentToWorld();
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

	DOTNET_EXPORT auto E_USceneComponent_GetAttachSocketName(USceneComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetAttachSocketName());
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

	DOTNET_EXPORT auto E_USceneComponent_GetRelativeTransform(USceneComponent* Self)
	{
		return (INT_PTR) new FTransform(Self->GetRelativeTransform());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetRightVector(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetRightVector());
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

	DOTNET_EXPORT auto E_USceneComponent_IsAnySimulatingPhysics(USceneComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
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

	DOTNET_EXPORT auto E_USceneComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		Self->OnAttachmentChanged();
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

	DOTNET_EXPORT auto E_USceneComponent_SetHiddenInGame(USceneComponent* Self, bool NewHidden, bool bPropagateToChildren)
	{
		auto _p0 = NewHidden;
		auto _p1 = bPropagateToChildren;
		Self->SetHiddenInGame(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetRelativeScale3D(USceneComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetVisibility(USceneComponent* Self, bool bNewVisibility, bool bPropagateToChildren)
	{
		auto _p0 = bNewVisibility;
		auto _p1 = bPropagateToChildren;
		Self->SetVisibility(_p0, _p1);
	}

	DOTNET_EXPORT auto E_USceneComponent_SetWorldScale3D(USceneComponent* Self, INT_PTR NewScale)
	{
		auto _p0 = *(FVector*)NewScale;
		Self->SetWorldScale3D(_p0);
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
