#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Object.h"

extern "C"
{
	DOTNET_EXPORT void E_UObject_BeginDestroy(INT_PTR Self)
	{
		((UObject*)Self)->BeginDestroy();
	}

	DOTNET_EXPORT bool E_UObject_CanCreateInCurrentContext(INT_PTR Self, UObject* Template)
	{
		auto _p0 = Template;
		return ((UObject*)Self)->CanCreateInCurrentContext(_p0);
	}

	DOTNET_EXPORT bool E_UObject_CanModify(INT_PTR Self)
	{
		return ((UObject*)Self)->CanModify();
	}

	DOTNET_EXPORT void E_UObject_FinishDestroy(INT_PTR Self)
	{
		((UObject*)Self)->FinishDestroy();
	}

	DOTNET_EXPORT UWorld* E_UObject_GetWorldChecked(INT_PTR Self, bool bSupported)
	{
		auto _p0 = bSupported;
		return ((UObject*)Self)->GetWorldChecked(_p0);
	}

	DOTNET_EXPORT bool E_UObject_ImplementsGetWorld(INT_PTR Self)
	{
		return ((UObject*)Self)->ImplementsGetWorld();
	}

	DOTNET_EXPORT bool E_UObject_IsSelected(INT_PTR Self)
	{
		return ((UObject*)Self)->IsSelected();
	}

	DOTNET_EXPORT void E_UObject_PostCDOContruct(INT_PTR Self)
	{
		((UObject*)Self)->PostCDOContruct();
	}

	DOTNET_EXPORT void E_UObject_PostEditImport(INT_PTR Self)
	{
		((UObject*)Self)->PostEditImport();
	}

	DOTNET_EXPORT void E_UObject_PostInitProperties(INT_PTR Self)
	{
		((UObject*)Self)->PostInitProperties();
	}

	DOTNET_EXPORT void E_UObject_PostLoad(INT_PTR Self)
	{
		((UObject*)Self)->PostLoad();
	}

	DOTNET_EXPORT void E_UObject_PostNetReceive(INT_PTR Self)
	{
		((UObject*)Self)->PostNetReceive();
	}

	DOTNET_EXPORT void E_UObject_PostRename(INT_PTR Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = FName(UTF8_TO_TCHAR(OldName));
		((UObject*)Self)->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT void E_UObject_PostRepNotifies(INT_PTR Self)
	{
		((UObject*)Self)->PostRepNotifies();
	}

	DOTNET_EXPORT void E_UObject_PostSaveRoot(INT_PTR Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UObject*)Self)->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT void E_UObject_PreDestroyFromReplication(INT_PTR Self)
	{
		((UObject*)Self)->PreDestroyFromReplication();
	}

	DOTNET_EXPORT void E_UObject_PreNetReceive(INT_PTR Self)
	{
		((UObject*)Self)->PreNetReceive();
	}

	DOTNET_EXPORT void E_UObject_ShutdownAfterError(INT_PTR Self)
	{
		((UObject*)Self)->ShutdownAfterError();
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UArrowComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UArrowComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UAudioComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UAudioComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UBillboardComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UBillboardComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UBoxComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UBoxComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UCapsuleComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UCapsuleComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UChildActorComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UChildActorComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UDecalComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UDecalComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UDirectionalLightComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UDirectionalLightComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UExponentialHeightFogComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UExponentialHeightFogComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UInstancedStaticMeshComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UInstancedStaticMeshComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UMaterialBillboardComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UMaterialBillboardComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UPawnNoiseEmitterComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UPawnNoiseEmitterComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UPlanarReflectionComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UPlanarReflectionComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UPointLightComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UPointLightComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UPostProcessComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UPostProcessComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USceneCaptureComponent2D(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USceneCaptureComponent2D>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USceneCaptureComponentCube(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USceneCaptureComponentCube>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USceneComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USceneComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UShapeComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UShapeComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USkyLightComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USkyLightComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USphereComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USphereComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USpotLightComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USpotLightComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_USpringArmComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class USpringArmComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UStaticMeshComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UStaticMeshComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UTextRenderComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UTextRenderComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT INT_PTR E_CreateOptionalDefaultSubobject_UVectorFieldComponent(INT_PTR Self, char* Name)
	{
		return (INT_PTR)((UObject*)Self)->CreateOptionalDefaultSubobject<class UVectorFieldComponent>(FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
