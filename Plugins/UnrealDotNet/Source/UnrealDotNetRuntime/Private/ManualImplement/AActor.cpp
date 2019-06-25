#include "UnrealDotNetRuntime.h"
#include "Manage/ManageActor.h"
#include "ManageObject.h"
#include "CoreMinimal.h"
#include "DotnetMetadata.h"
#include "ManualImplement/AActor.h"

AActor* SpawnManageActor(UWorld* World, UClass* Class, FDotnetTypeName ManageType, FTransform* UserTransformPtr, const FActorSpawnParameters& SpawnParameters)
{
	CSV_SCOPED_TIMING_STAT_EXCLUSIVE(ActorSpawning);
	SCOPE_TIME_GUARD_NAMED_MS(TEXT("SpawnActor Of Type"), Class->GetFName(), 2);

	check(World);

	auto CurrentLevel = World->GetCurrentLevel();

	if (!Class)
	{
		UE_LOG(DotNetShell, Warning, TEXT("SpawnActor failed because no class was specified"));
		return NULL;
	}

	if (Class->HasAnyClassFlags(CLASS_Deprecated))
	{
		UE_LOG(DotNetShell, Warning, TEXT("SpawnActor failed because class %s is deprecated"), *Class->GetName());
		return NULL;
	}
	if (Class->HasAnyClassFlags(CLASS_Abstract))
	{
		UE_LOG(DotNetShell, Warning, TEXT("SpawnActor failed because class %s is abstract"), *Class->GetName());
		return NULL;
	}
	else if (!Class->IsChildOf(AActor::StaticClass()))
	{
		UE_LOG(DotNetShell, Warning, TEXT("SpawnActor failed because %s is not an actor class"), *Class->GetName());
		return NULL;
	}
	else if (SpawnParameters.Template != NULL && SpawnParameters.Template->GetClass() != Class)
	{
		UE_LOG(DotNetShell, Warning, TEXT("SpawnActor failed because template class (%s) does not match spawn class (%s)"), *SpawnParameters.Template->GetClass()->GetName(), *Class->GetName());
		if (!SpawnParameters.bNoFail)
		{
			return NULL;
		}
	}
	else if (UserTransformPtr && UserTransformPtr->ContainsNaN())
	{
		UE_LOG(DotNetShell, Warning, TEXT("SpawnActor failed because the given transform (%s) is invalid"), *(UserTransformPtr->ToString()));
		return NULL;
	}

	auto LevelToSpawnIn = SpawnParameters.OverrideLevel;
	if (LevelToSpawnIn == NULL)
	{
		LevelToSpawnIn = (SpawnParameters.Owner != NULL) ? CastChecked<ULevel>(SpawnParameters.Owner->GetOuter()) : CurrentLevel;
	}

	auto NewActorName = SpawnParameters.Name;
	auto Template = SpawnParameters.Template;

	if (!Template)
	{
		Template = Class->GetDefaultObject<AActor>();
	}
	else if (NewActorName.IsNone() && !Template->HasAnyFlags(RF_ClassDefaultObject))
	{
		NewActorName = MakeUniqueObjectName(LevelToSpawnIn, Template->GetClass(), *Template->GetFName().GetPlainNameString());
	}
	check(Template);

	auto UserTransform = UserTransformPtr ? *UserTransformPtr : FTransform::Identity;
	auto CollisionHandlingOverride = SpawnParameters.SpawnCollisionHandlingOverride;

	if (SpawnParameters.bNoFail)
	{
		if (CollisionHandlingOverride == ESpawnActorCollisionHandlingMethod::AdjustIfPossibleButDontSpawnIfColliding)
		{
			CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod::AdjustIfPossibleButAlwaysSpawn;
		}
		else if (CollisionHandlingOverride == ESpawnActorCollisionHandlingMethod::DontSpawnIfColliding)
		{
			CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod::AlwaysSpawn;
		}
	}

	auto CollisionHandlingMethod = (CollisionHandlingOverride == ESpawnActorCollisionHandlingMethod::Undefined) ? Template->SpawnCollisionHandlingMethod : CollisionHandlingOverride;

	if (CollisionHandlingMethod == ESpawnActorCollisionHandlingMethod::DontSpawnIfColliding)
	{
		auto TemplateRootComponent = Template->GetRootComponent();

		auto FinalRootComponentTransform =
			TemplateRootComponent
			? FTransform(TemplateRootComponent->RelativeRotation, TemplateRootComponent->RelativeLocation, TemplateRootComponent->RelativeScale3D) * UserTransform
			: UserTransform;

		auto FinalRootLocation = FinalRootComponentTransform.GetLocation();
		auto FinalRootRotation = FinalRootComponentTransform.Rotator();

		if (World->EncroachingBlockingGeometry(Template, FinalRootLocation, FinalRootRotation))
		{
			UE_LOG(DotNetShell, Log, TEXT("SpawnActor failed because of collision at the spawn location [%s] for [%s]"), *FinalRootLocation.ToString(), *Class->GetName());
			return nullptr;
		}
	}

	auto Actor = NewObject<AActor>(LevelToSpawnIn, Class, NewActorName, SpawnParameters.ObjectFlags, Template);
	check(Actor);

	auto manageActor = Cast<IManageObject>(Actor);
	if (manageActor)
	{
		manageActor->SetManageType(ManageType);
	}
	
#if WITH_EDITOR
	Actor->ClearActorLabel();
#endif

	if (GUndo)
	{
		World->ModifyLevel(LevelToSpawnIn);
	}
	LevelToSpawnIn->Actors.Add(Actor);
	LevelToSpawnIn->ActorsForGC.Add(Actor);
	
	Actor->SpawnCollisionHandlingMethod = CollisionHandlingMethod;

#if WITH_EDITOR
	Actor->bIsEditorPreviewActor = SpawnParameters.bTemporaryEditorActor;
#endif

	Actor->PostSpawnInitialize(UserTransform, SpawnParameters.Owner, SpawnParameters.Instigator, SpawnParameters.IsRemoteOwned(), SpawnParameters.bNoFail, SpawnParameters.bDeferConstruction);

	if (Actor->IsPendingKill() && !SpawnParameters.bNoFail)
	{
		UE_LOG(DotNetShell, Log, TEXT("SpawnActor failed because the spawned actor %s IsPendingKill"), *Actor->GetPathName());
		return NULL;
	}

	Actor->CheckDefaultSubobjects();

	//World->OnActorSpawned.Broadcast(Actor);

#if WITH_EDITOR
	if (GIsEditor)
	{
		GEngine->BroadcastLevelActorAdded(Actor);
	}
#endif

	World->AddNetworkActor(Actor);
	return Actor;
}

UClass* GetClassByName(FString className)
{
	auto result = FindObject<UClass>(ANY_PACKAGE, *className);

	if (result == NULL && !className.EndsWith("_C"))
	{
		return GetClassByName(className + "_C");
	}

	return result;
}

ObjectPointerDescription E_AActor_CreateDefaultSubobject(AActor* Self, char* ClassName, char* ComponentName)
{
	auto className = UTF8_TO_TCHAR(ClassName);
	auto componentName = UTF8_TO_TCHAR(ComponentName);

	auto componentClass = GetClassByName(className);

	auto compoennt = Self->CreateDefaultSubobject(componentName, componentClass, componentClass, true, false, false);
	return ConvertToManage_ObjectPointerDescription(compoennt);
}

ObjectPointerDescription E_AActor_SpawnActor(AActor* Self, char* ClassName, INT_PTR Transform)
{
	auto className = UTF8_TO_TCHAR(ClassName);
	auto actorClass = GetClassByName(className);

	auto pTransform = (FTransform*)Transform;

	FActorSpawnParameters params;
	params.SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod::AlwaysSpawn;

	auto actor = Self->GetWorld()->SpawnActor(actorClass, pTransform, params);
	return ConvertToManage_ObjectPointerDescription(actor);
}

ObjectPointerDescription E_AActor_SpawnActorManage(AActor* Self, char* ClassName, INT_PTR Transform, char* ManageClassName)
{
	auto manageClassName = UTF8_TO_TCHAR(ManageClassName);
	auto className = UTF8_TO_TCHAR(ClassName);
	auto actorClass = GetClassByName(className);

	auto pTransform = (FTransform*)Transform;

	FActorSpawnParameters params;
	params.SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod::AlwaysSpawn;

	if (actorClass == NULL)
	{
		return ConvertToManage_ObjectPointerDescription((UObject*)NULL);
	}

	FDotnetTypeName manageType;
	manageType.FullName = manageClassName;

	auto actor = SpawnManageActor(Self->GetWorld(), actorClass, manageType, pTransform, params);
	return ConvertToManage_ObjectPointerDescription(actor);
}