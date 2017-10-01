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
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_ComponentToWorld_GET(INT_PTR Ptr) { return (INT_PTR)&((USceneComponent*)Ptr)->ComponentToWorld; }
	DOTNET_EXPORT void E_PROP_USceneComponent_ComponentToWorld_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->ComponentToWorld = *(FTransform*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_ComponentVelocity_GET(INT_PTR Ptr) { return (INT_PTR)&((USceneComponent*)Ptr)->ComponentVelocity; }
	DOTNET_EXPORT void E_PROP_USceneComponent_ComponentVelocity_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->ComponentVelocity = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeLocation_GET(INT_PTR Ptr) { return (INT_PTR)&((USceneComponent*)Ptr)->RelativeLocation; }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeLocation_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeLocation = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeRotation_GET(INT_PTR Ptr) { return (INT_PTR)&((USceneComponent*)Ptr)->RelativeRotation; }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeRotation_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeScale3D_GET(INT_PTR Ptr) { return (INT_PTR)&((USceneComponent*)Ptr)->RelativeScale3D; }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeScale3D_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeScale3D = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_GET(INT_PTR Ptr) { return (INT_PTR)&((USceneComponent*)Ptr)->RelativeTranslation_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeTranslation_DEPRECATED = *(FVector*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USceneComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USceneComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USceneComponent_AreDynamicDataChangesAllowed(USceneComponent* Self, bool bIgnoreStationary)
	{
		auto _p0 = bIgnoreStationary;
		return ConvertForManage(((E_PROTECTED_WRAP_USceneComponent*)Self)->AreDynamicDataChangesAllowed_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_USceneComponent_AttachToComponent(USceneComponent* Self, USceneComponent* InParent, INT_PTR AttachmentRules, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = *(FAttachmentTransformRules*)AttachmentRules;
		auto _p2 = ConvertFromManage_FName(InSocketName);
		return ConvertForManage(Self->AttachToComponent(_p0, _p1, _p2));
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

	DOTNET_EXPORT auto E_USceneComponent_CanEverRender(USceneComponent* Self)
	{
		return ConvertForManage(Self->CanEverRender());
	}

	DOTNET_EXPORT auto E_USceneComponent_CheckStaticMobilityAndWarn(USceneComponent* Self, char* ActionText)
	{
		auto _p0 = ConvertFromManage_FText(ActionText);
		return ConvertForManage(((E_PROTECTED_WRAP_USceneComponent*)Self)->CheckStaticMobilityAndWarn_WRAP(_p0));
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

	DOTNET_EXPORT auto E_USceneComponent_GetAttachmentRoot(USceneComponent* Self)
	{
		return ConvertForManage(Self->GetAttachmentRoot());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetAttachmentRootActor(USceneComponent* Self)
	{
		return ConvertForManage(Self->GetAttachmentRootActor());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetAttachParent(USceneComponent* Self)
	{
		return ConvertForManage(Self->GetAttachParent());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetAttachSocketName(USceneComponent* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->GetAttachSocketName().ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_USceneComponent_GetChildComponent(USceneComponent* Self, int32 ChildIndex)
	{
		auto _p0 = ChildIndex;
		return ConvertForManage(Self->GetChildComponent(_p0));
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

	DOTNET_EXPORT auto E_USceneComponent_GetDefaultSceneRootVariableName(USceneComponent* Self, int& ResultStringLen)
	{
		auto _result = ConvertForManage(Self->GetDefaultSceneRootVariableName().ToString());
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT auto E_USceneComponent_GetForwardVector(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetForwardVector());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetNumChildrenComponents(USceneComponent* Self)
	{
		return ConvertForManage(Self->GetNumChildrenComponents());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetRelativeTransform(USceneComponent* Self)
	{
		return (INT_PTR) new FTransform(Self->GetRelativeTransform());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetRightVector(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetRightVector());
	}

	DOTNET_EXPORT auto E_USceneComponent_GetUpVector(USceneComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetUpVector());
	}

	DOTNET_EXPORT auto E_USceneComponent_IsAttachedTo(USceneComponent* Self, USceneComponent* TestComp)
	{
		auto _p0 = TestComp;
		return ConvertForManage(Self->IsAttachedTo(_p0));
	}

	DOTNET_EXPORT auto E_USceneComponent_IsCollisionEnabled(USceneComponent* Self)
	{
		return ConvertForManage(Self->IsCollisionEnabled());
	}

	DOTNET_EXPORT auto E_USceneComponent_IsDeferringMovementUpdates(USceneComponent* Self)
	{
		return ConvertForManage(Self->IsDeferringMovementUpdates());
	}

	DOTNET_EXPORT auto E_USceneComponent_IsPhysicsCollisionEnabled(USceneComponent* Self)
	{
		return ConvertForManage(Self->IsPhysicsCollisionEnabled());
	}

	DOTNET_EXPORT auto E_USceneComponent_IsQueryCollisionEnabled(USceneComponent* Self)
	{
		return ConvertForManage(Self->IsQueryCollisionEnabled());
	}

	DOTNET_EXPORT auto E_USceneComponent_K2_AttachToComponent(USceneComponent* Self, USceneComponent* Parent, char* SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
	{
		auto _p0 = Parent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		auto _p2 = LocationRule;
		auto _p3 = RotationRule;
		auto _p4 = ScaleRule;
		auto _p5 = bWeldSimulatedBodies;
		return ConvertForManage(Self->K2_AttachToComponent(_p0, _p1, _p2, _p3, _p4, _p5));
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

	DOTNET_EXPORT auto E_USceneComponent_SetRelativeScale3D(USceneComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
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

	DOTNET_EXPORT auto E_USceneComponent_ShouldComponentAddToScene(USceneComponent* Self)
	{
		return ConvertForManage(Self->ShouldComponentAddToScene());
	}

	DOTNET_EXPORT auto E_USceneComponent_ShouldRender(USceneComponent* Self)
	{
		return ConvertForManage(Self->ShouldRender());
	}

	DOTNET_EXPORT auto E_USceneComponent_SnapTo(USceneComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		return ConvertForManage(Self->SnapTo(_p0, _p1));
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
