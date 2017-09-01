#pragma once

#include "CoreMinimal.h"
#include "Object.h"

class E_PROTECTED_WRAP_UObject : protected UObject
{
	public:
	FString GetDetailedInfoInternal_WRAP()
	{
		return GetDetailedInfoInternal();
	}

}
;

extern "C"
{
	DOTNET_EXPORT char* E_UObject_GetDetailedInfoInternal(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((E_PROTECTED_WRAP_UObject*)Self)->GetDetailedInfoInternal_WRAP();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT void E_UObject_PostInitProperties(INT_PTR Self)
	{
		((UObject*)Self)->PostInitProperties();
	}

	DOTNET_EXPORT void E_UObject_PostSaveRoot(INT_PTR Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UObject*)Self)->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT bool E_UObject_Modify(INT_PTR Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return ((UObject*)Self)->Modify(_p0);
	}

	DOTNET_EXPORT bool E_UObject_CanModify(INT_PTR Self)
	{
		return ((UObject*)Self)->CanModify();
	}

	DOTNET_EXPORT bool E_UObject_IsReadyForFinishDestroy(INT_PTR Self)
	{
		return ((UObject*)Self)->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT void E_UObject_PostRename(INT_PTR Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = FName(UTF8_TO_TCHAR(OldName));
		((UObject*)Self)->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UObject_CanCreateInCurrentContext(INT_PTR Self, UObject* Template)
	{
		auto _p0 = Template;
		return ((UObject*)Self)->CanCreateInCurrentContext(_p0);
	}

	DOTNET_EXPORT char* E_UObject_GetDesc(INT_PTR Self, int& ResultStringLen)
	{
		auto _result = ((UObject*)Self)->GetDesc();
		ResultStringLen = _result.Len();
		return TCHAR_TO_UTF8(*_result);
	}

	DOTNET_EXPORT UWorld* E_UObject_GetWorld(INT_PTR Self)
	{
		return ((UObject*)Self)->GetWorld();
	}

	DOTNET_EXPORT UWorld* E_UObject_GetWorldChecked(INT_PTR Self, bool bSupported)
	{
		auto _p0 = bSupported;
		return ((UObject*)Self)->GetWorldChecked(_p0);
	}

	DOTNET_EXPORT bool E_UObject_AreNativePropertiesIdenticalTo(INT_PTR Self, UObject* Other)
	{
		auto _p0 = Other;
		return ((UObject*)Self)->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT void E_UObject_ExecuteUbergraph(INT_PTR Self, int32 EntryPoint)
	{
		auto _p0 = EntryPoint;
		((UObject*)Self)->ExecuteUbergraph(_p0);
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UCapsuleComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UCapsuleComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UBrushComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UBrushComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USplineComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USplineComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UBillboardComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UBillboardComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UArrowComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UArrowComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UModelComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UModelComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UMaterialBillboardComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UMaterialBillboardComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UShapeComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UShapeComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UDrawSphereComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UDrawSphereComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UDrawFrustumComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UDrawFrustumComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UTextRenderComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UTextRenderComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UMeshComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UMeshComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UVectorFieldComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UVectorFieldComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UInstancedStaticMeshComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UInstancedStaticMeshComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UBoxComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UBoxComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USplineMeshComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USplineMeshComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UStaticMeshComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UStaticMeshComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_ULineBatchComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class ULineBatchComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USphereComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USphereComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

}
