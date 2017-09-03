#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
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
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_ComponentToWorld_GET(INT_PTR Ptr) { return (INT_PTR) new FTransform(((USceneComponent*)Ptr)->ComponentToWorld); }
	DOTNET_EXPORT void E_PROP_USceneComponent_ComponentToWorld_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->ComponentToWorld = *(FTransform*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_ComponentVelocity_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((USceneComponent*)Ptr)->ComponentVelocity); }
	DOTNET_EXPORT void E_PROP_USceneComponent_ComponentVelocity_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->ComponentVelocity = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeLocation_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((USceneComponent*)Ptr)->RelativeLocation); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeLocation_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeLocation = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeRotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((USceneComponent*)Ptr)->RelativeRotation); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeRotation_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeScale3D_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((USceneComponent*)Ptr)->RelativeScale3D); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeScale3D_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeScale3D = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((USceneComponent*)Ptr)->RelativeTranslation_DEPRECATED); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeTranslation_DEPRECATED = *(FVector*)Value; }
	
	DOTNET_EXPORT bool E_USceneComponent_AreDynamicDataChangesAllowed(INT_PTR Self, bool bIgnoreStationary)
	{
		auto _p0 = bIgnoreStationary;
		return ((E_PROTECTED_WRAP_USceneComponent*)Self)->AreDynamicDataChangesAllowed_WRAP(_p0);
	}

	DOTNET_EXPORT void E_USceneComponent_CalcBoundingCylinder(INT_PTR Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		((USceneComponent*)Self)->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_CalcNewComponentToWorld(INT_PTR Self, INT_PTR NewRelativeTransform, USceneComponent* Parent, char* SocketName)
	{
		auto _p0 = *(FTransform*)NewRelativeTransform;
		auto _p1 = Parent;
		auto _p2 = FName(UTF8_TO_TCHAR(SocketName));
		return (INT_PTR) new FTransform(((E_PROTECTED_WRAP_USceneComponent*)Self)->CalcNewComponentToWorld_WRAP(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_CalcNewComponentToWorld_GeneralCase(INT_PTR Self, INT_PTR NewRelativeTransform, USceneComponent* Parent, char* SocketName)
	{
		auto _p0 = *(FTransform*)NewRelativeTransform;
		auto _p1 = Parent;
		auto _p2 = FName(UTF8_TO_TCHAR(SocketName));
		return (INT_PTR) new FTransform(((E_PROTECTED_WRAP_USceneComponent*)Self)->CalcNewComponentToWorld_GeneralCase_WRAP(_p0, _p1, _p2));
	}

	DOTNET_EXPORT bool E_USceneComponent_CanEverRender(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->CanEverRender();
	}

	DOTNET_EXPORT bool E_USceneComponent_CheckStaticMobilityAndWarn(INT_PTR Self, char* ActionText)
	{
		auto _p0 = FText::FromString(FString(ActionText));
		return ((E_PROTECTED_WRAP_USceneComponent*)Self)->CheckStaticMobilityAndWarn_WRAP(_p0);
	}

	DOTNET_EXPORT void E_USceneComponent_ConditionalUpdateComponentToWorld(INT_PTR Self)
	{
		((USceneComponent*)Self)->ConditionalUpdateComponentToWorld();
	}

	DOTNET_EXPORT void E_USceneComponent_DetachFromParent(INT_PTR Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((USceneComponent*)Self)->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT USceneComponent* E_USceneComponent_GetAttachmentRoot(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->GetAttachmentRoot();
	}

	DOTNET_EXPORT AActor* E_USceneComponent_GetAttachmentRootActor(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->GetAttachmentRootActor();
	}

	DOTNET_EXPORT USceneComponent* E_USceneComponent_GetAttachParent(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->GetAttachParent();
	}

	DOTNET_EXPORT char* E_USceneComponent_GetAttachSocketName(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((USceneComponent*)Self)->GetAttachSocketName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT USceneComponent* E_USceneComponent_GetChildComponent(INT_PTR Self, int32 ChildIndex)
	{
		auto _p0 = ChildIndex;
		return ((USceneComponent*)Self)->GetChildComponent(_p0);
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetComponentLocation(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((USceneComponent*)Self)->GetComponentLocation());
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetComponentQuat(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((USceneComponent*)Self)->GetComponentQuat());
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetComponentRotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((USceneComponent*)Self)->GetComponentRotation());
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetComponentScale(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((USceneComponent*)Self)->GetComponentScale());
	}

	DOTNET_EXPORT char* E_USceneComponent_GetDefaultSceneRootVariableName(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((USceneComponent*)Self)->GetDefaultSceneRootVariableName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetForwardVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((USceneComponent*)Self)->GetForwardVector());
	}

	DOTNET_EXPORT int32 E_USceneComponent_GetNumChildrenComponents(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->GetNumChildrenComponents();
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetRelativeTransform(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((USceneComponent*)Self)->GetRelativeTransform());
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetRightVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((USceneComponent*)Self)->GetRightVector());
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetUpVector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((USceneComponent*)Self)->GetUpVector());
	}

	DOTNET_EXPORT bool E_USceneComponent_IsAttachedTo(INT_PTR Self, USceneComponent* TestComp)
	{
		auto _p0 = TestComp;
		return ((USceneComponent*)Self)->IsAttachedTo(_p0);
	}

	DOTNET_EXPORT bool E_USceneComponent_IsCollisionEnabled(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->IsCollisionEnabled();
	}

	DOTNET_EXPORT bool E_USceneComponent_IsDeferringMovementUpdates(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->IsDeferringMovementUpdates();
	}

	DOTNET_EXPORT bool E_USceneComponent_IsPhysicsCollisionEnabled(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->IsPhysicsCollisionEnabled();
	}

	DOTNET_EXPORT bool E_USceneComponent_IsQueryCollisionEnabled(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->IsQueryCollisionEnabled();
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_K2_GetComponentLocation(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((USceneComponent*)Self)->K2_GetComponentLocation());
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_K2_GetComponentRotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((USceneComponent*)Self)->K2_GetComponentRotation());
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_K2_GetComponentScale(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((USceneComponent*)Self)->K2_GetComponentScale());
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_K2_GetComponentToWorld(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((USceneComponent*)Self)->K2_GetComponentToWorld());
	}

	DOTNET_EXPORT void E_USceneComponent_OnAttachmentChanged(INT_PTR Self)
	{
		((USceneComponent*)Self)->OnAttachmentChanged();
	}

	DOTNET_EXPORT void E_USceneComponent_OnChildAttached(INT_PTR Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT void E_USceneComponent_OnChildDetached(INT_PTR Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT void E_USceneComponent_OnHiddenInGameChanged(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT void E_USceneComponent_OnVisibilityChanged(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT void E_USceneComponent_PostUpdateNavigationData(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_USceneComponent*)Self)->PostUpdateNavigationData_WRAP();
	}

	DOTNET_EXPORT void E_USceneComponent_PropagateLightingScenarioChange(INT_PTR Self)
	{
		((USceneComponent*)Self)->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT void E_USceneComponent_ResetRelativeTransform(INT_PTR Self)
	{
		((USceneComponent*)Self)->ResetRelativeTransform();
	}

	DOTNET_EXPORT void E_USceneComponent_SetAbsolute(INT_PTR Self, bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale)
	{
		auto _p0 = bNewAbsoluteLocation;
		auto _p1 = bNewAbsoluteRotation;
		auto _p2 = bNewAbsoluteScale;
		((USceneComponent*)Self)->SetAbsolute(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_USceneComponent_SetComponentToWorld(INT_PTR Self, INT_PTR NewComponentToWorld)
	{
		auto _p0 = *(FTransform*)NewComponentToWorld;
		((USceneComponent*)Self)->SetComponentToWorld(_p0);
	}

	DOTNET_EXPORT void E_USceneComponent_SetHiddenInGame(INT_PTR Self, bool NewHidden, bool bPropagateToChildren)
	{
		auto _p0 = NewHidden;
		auto _p1 = bPropagateToChildren;
		((USceneComponent*)Self)->SetHiddenInGame(_p0, _p1);
	}

	DOTNET_EXPORT void E_USceneComponent_SetRelativeScale3D(INT_PTR Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		((USceneComponent*)Self)->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT void E_USceneComponent_SetupAttachment(INT_PTR Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		((USceneComponent*)Self)->SetupAttachment(_p0, _p1);
	}

	DOTNET_EXPORT void E_USceneComponent_SetVisibility(INT_PTR Self, bool bNewVisibility, bool bPropagateToChildren)
	{
		auto _p0 = bNewVisibility;
		auto _p1 = bPropagateToChildren;
		((USceneComponent*)Self)->SetVisibility(_p0, _p1);
	}

	DOTNET_EXPORT void E_USceneComponent_SetWorldLocationAndRotationNoPhysics(INT_PTR Self, INT_PTR NewLocation, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = *(FRotator*)NewRotation;
		((USceneComponent*)Self)->SetWorldLocationAndRotationNoPhysics(_p0, _p1);
	}

	DOTNET_EXPORT void E_USceneComponent_SetWorldScale3D(INT_PTR Self, INT_PTR NewScale)
	{
		auto _p0 = *(FVector*)NewScale;
		((USceneComponent*)Self)->SetWorldScale3D(_p0);
	}

	DOTNET_EXPORT bool E_USceneComponent_ShouldComponentAddToScene(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->ShouldComponentAddToScene();
	}

	DOTNET_EXPORT bool E_USceneComponent_ShouldRender(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->ShouldRender();
	}

	DOTNET_EXPORT bool E_USceneComponent_SnapTo(INT_PTR Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		return ((USceneComponent*)Self)->SnapTo(_p0, _p1);
	}

	DOTNET_EXPORT void E_USceneComponent_ToggleVisibility(INT_PTR Self, bool bPropagateToChildren)
	{
		auto _p0 = bPropagateToChildren;
		((USceneComponent*)Self)->ToggleVisibility(_p0);
	}

	DOTNET_EXPORT void E_USceneComponent_UpdateBounds(INT_PTR Self)
	{
		((USceneComponent*)Self)->UpdateBounds();
	}

	DOTNET_EXPORT void E_USceneComponent_UpdateNavigationData(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_USceneComponent*)Self)->UpdateNavigationData_WRAP();
	}

	DOTNET_EXPORT void E_USceneComponent_UpdatePhysicsVolume(INT_PTR Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((USceneComponent*)Self)->UpdatePhysicsVolume(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
