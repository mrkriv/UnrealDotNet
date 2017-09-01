#pragma once

#include "CoreMinimal.h"
#include "Components/SceneComponent.h"

class E_PROTECTED_WRAP_USceneComponent : protected USceneComponent
{
	public:
	bool CheckStaticMobilityAndWarn_WRAP(const FText& ActionText)
	{
		return CheckStaticMobilityAndWarn(ActionText);
	}

	FTransform CalcNewComponentToWorld_WRAP(const FTransform& NewRelativeTransform, const USceneComponent* Parent, FName SocketName)
	{
		return CalcNewComponentToWorld(NewRelativeTransform, Parent, SocketName);
	}

	void OnChildAttached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildAttached(ChildComponent);
	}

	bool AreDynamicDataChangesAllowed_WRAP(bool bIgnoreStationary)
	{
		return AreDynamicDataChangesAllowed(bIgnoreStationary);
	}

}
;

extern "C"
{
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_ComponentToWorld_GET(INT_PTR Ptr) { return (INT_PTR) new FTransform(((USceneComponent*)Ptr)->ComponentToWorld); }
	DOTNET_EXPORT void E_PROP_USceneComponent_ComponentToWorld_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->ComponentToWorld = *(FTransform*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeLocation_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((USceneComponent*)Ptr)->RelativeLocation); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeLocation_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeLocation = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeRotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((USceneComponent*)Ptr)->RelativeRotation); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeRotation_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeScale3D_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((USceneComponent*)Ptr)->RelativeScale3D); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeScale3D_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeScale3D = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((USceneComponent*)Ptr)->RelativeTranslation_DEPRECATED); }
	DOTNET_EXPORT void E_PROP_USceneComponent_RelativeTranslation_DEPRECATED_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->RelativeTranslation_DEPRECATED = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_USceneComponent_ComponentVelocity_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((USceneComponent*)Ptr)->ComponentVelocity); }
	DOTNET_EXPORT void E_PROP_USceneComponent_ComponentVelocity_SET(INT_PTR Ptr, INT_PTR Value) { ((USceneComponent*)Ptr)->ComponentVelocity = *(FVector*)Value; }
	
	DOTNET_EXPORT char* E_USceneComponent_GetDefaultSceneRootVariableName(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((USceneComponent*)Self)->GetDefaultSceneRootVariableName().ToString();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetRelativeTransform(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((USceneComponent*)Self)->GetRelativeTransform());
	}

	DOTNET_EXPORT void E_USceneComponent_SetRelativeScale3D(INT_PTR Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		((USceneComponent*)Self)->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_K2_GetComponentLocation(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((USceneComponent*)Self)->K2_GetComponentLocation());
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_K2_GetComponentRotation(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((USceneComponent*)Self)->K2_GetComponentRotation());
	}

	DOTNET_EXPORT bool E_USceneComponent_IsSimulatingPhysics(INT_PTR Self, char* BoneName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(BoneName));
		return ((USceneComponent*)Self)->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT bool E_USceneComponent_IsAnySimulatingPhysics(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->IsAnySimulatingPhysics();
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

	DOTNET_EXPORT int32 E_USceneComponent_GetNumChildrenComponents(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->GetNumChildrenComponents();
	}

	DOTNET_EXPORT USceneComponent* E_USceneComponent_GetChildComponent(INT_PTR Self, int32 ChildIndex)
	{
		auto _p0 = ChildIndex;
		return ((USceneComponent*)Self)->GetChildComponent(_p0);
	}

	DOTNET_EXPORT void E_USceneComponent_SetupAttachment(INT_PTR Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		((USceneComponent*)Self)->SetupAttachment(_p0, _p1);
	}

	DOTNET_EXPORT bool E_USceneComponent_SnapTo(INT_PTR Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = FName(UTF8_TO_TCHAR(InSocketName));
		return ((USceneComponent*)Self)->SnapTo(_p0, _p1);
	}

	DOTNET_EXPORT void E_USceneComponent_DetachFromParent(INT_PTR Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((USceneComponent*)Self)->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetSocketLocation(INT_PTR Self, char* InSocketName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InSocketName));
		return (INT_PTR) new FVector(((USceneComponent*)Self)->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetSocketRotation(INT_PTR Self, char* InSocketName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InSocketName));
		return (INT_PTR) new FRotator(((USceneComponent*)Self)->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetSocketQuaternion(INT_PTR Self, char* InSocketName)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(InSocketName));
		return (INT_PTR) new FQuat(((USceneComponent*)Self)->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT void E_USceneComponent_ToggleVisibility(INT_PTR Self, bool bPropagateToChildren)
	{
		auto _p0 = bPropagateToChildren;
		((USceneComponent*)Self)->ToggleVisibility(_p0);
	}

	DOTNET_EXPORT bool E_USceneComponent_CheckStaticMobilityAndWarn(INT_PTR Self, char* ActionText)
	{
		auto _p0 = FText::FromString(FString(ActionText));
		return ((E_PROTECTED_WRAP_USceneComponent*)Self)->CheckStaticMobilityAndWarn_WRAP(_p0);
	}

	DOTNET_EXPORT INT_PTR E_USceneComponent_GetComponentQuat(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((USceneComponent*)Self)->GetComponentQuat());
	}

	DOTNET_EXPORT void E_USceneComponent_SetComponentToWorld(INT_PTR Self, INT_PTR NewComponentToWorld)
	{
		auto _p0 = *(FTransform*)NewComponentToWorld;
		((USceneComponent*)Self)->SetComponentToWorld(_p0);
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

	DOTNET_EXPORT void E_USceneComponent_SetAbsolute(INT_PTR Self, bool bNewAbsoluteLocation, bool bNewAbsoluteRotation, bool bNewAbsoluteScale)
	{
		auto _p0 = bNewAbsoluteLocation;
		auto _p1 = bNewAbsoluteRotation;
		auto _p2 = bNewAbsoluteScale;
		((USceneComponent*)Self)->SetAbsolute(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_USceneComponent_SetWorldLocationAndRotationNoPhysics(INT_PTR Self, INT_PTR NewLocation, INT_PTR NewRotation)
	{
		auto _p0 = *(FVector*)NewLocation;
		auto _p1 = *(FRotator*)NewRotation;
		((USceneComponent*)Self)->SetWorldLocationAndRotationNoPhysics(_p0, _p1);
	}

	DOTNET_EXPORT AActor* E_USceneComponent_GetAttachmentRootActor(INT_PTR Self)
	{
		return ((USceneComponent*)Self)->GetAttachmentRootActor();
	}

	DOTNET_EXPORT bool E_USceneComponent_IsAttachedTo(INT_PTR Self, USceneComponent* TestComp)
	{
		auto _p0 = TestComp;
		return ((USceneComponent*)Self)->IsAttachedTo(_p0);
	}

	DOTNET_EXPORT bool E_USceneComponent_CanAttachAsChild(INT_PTR Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = FName(UTF8_TO_TCHAR(SocketName));
		return ((USceneComponent*)Self)->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT void E_USceneComponent_OnChildAttached(INT_PTR Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_USceneComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT bool E_USceneComponent_AreDynamicDataChangesAllowed(INT_PTR Self, bool bIgnoreStationary)
	{
		auto _p0 = bIgnoreStationary;
		return ((E_PROTECTED_WRAP_USceneComponent*)Self)->AreDynamicDataChangesAllowed_WRAP(_p0);
	}

}
