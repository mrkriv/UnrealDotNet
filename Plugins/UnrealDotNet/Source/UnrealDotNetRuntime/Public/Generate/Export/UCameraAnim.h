#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Camera/CameraAnim.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraAnim.h:17

class E_PROTECTED_WRAP_UCameraAnim : protected UCameraAnim
{
public:
	void CalcLocalAABB_WRAP()
	{
		CalcLocalAABB();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UCameraAnim_AnimLength_GET(UCameraAnim* Ptr) { return Ptr->AnimLength; }
	DOTNET_EXPORT void E_PROP_UCameraAnim_AnimLength_SET(UCameraAnim* Ptr, float Value) { Ptr->AnimLength = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnim_BaseFOV_GET(UCameraAnim* Ptr) { return Ptr->BaseFOV; }
	DOTNET_EXPORT void E_PROP_UCameraAnim_BaseFOV_SET(UCameraAnim* Ptr, float Value) { Ptr->BaseFOV = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnim_BasePostProcessBlendWeight_GET(UCameraAnim* Ptr) { return Ptr->BasePostProcessBlendWeight; }
	DOTNET_EXPORT void E_PROP_UCameraAnim_BasePostProcessBlendWeight_SET(UCameraAnim* Ptr, float Value) { Ptr->BasePostProcessBlendWeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnim_BasePostProcessSettings_GET(UCameraAnim* Ptr) { return (INT_PTR)&(Ptr->BasePostProcessSettings); }
	DOTNET_EXPORT void E_PROP_UCameraAnim_BasePostProcessSettings_SET(UCameraAnim* Ptr, INT_PTR Value) { Ptr->BasePostProcessSettings = *(FPostProcessSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnim_BoundingBox_GET(UCameraAnim* Ptr) { return (INT_PTR)&(Ptr->BoundingBox); }
	DOTNET_EXPORT void E_PROP_UCameraAnim_BoundingBox_SET(UCameraAnim* Ptr, INT_PTR Value) { Ptr->BoundingBox = *(FBox*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnim_bRelativeToInitialFOV_GET(UCameraAnim* Ptr) { return Ptr->bRelativeToInitialFOV; }
	DOTNET_EXPORT void E_PROP_UCameraAnim_bRelativeToInitialFOV_SET(UCameraAnim* Ptr, uint8 Value) { Ptr->bRelativeToInitialFOV = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnim_bRelativeToInitialTransform_GET(UCameraAnim* Ptr) { return Ptr->bRelativeToInitialTransform; }
	DOTNET_EXPORT void E_PROP_UCameraAnim_bRelativeToInitialTransform_SET(UCameraAnim* Ptr, uint8 Value) { Ptr->bRelativeToInitialTransform = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCameraAnim(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCameraAnim>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCameraAnim_CalcLocalAABB(UCameraAnim* Self)
	{
		((E_PROTECTED_WRAP_UCameraAnim*)Self)->CalcLocalAABB_WRAP();
	}

	DOTNET_EXPORT auto E_UCameraAnim_GetAABB(UCameraAnim* Self, INT_PTR BaseLoc, INT_PTR BaseRot, float Scale)
	{
		auto& _p0 = *(FVector*)BaseLoc;
		auto& _p1 = *(FRotator*)BaseRot;
		auto _p2 = Scale;
		return (INT_PTR) new FBox(Self->GetAABB(_p0, _p1, _p2));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
