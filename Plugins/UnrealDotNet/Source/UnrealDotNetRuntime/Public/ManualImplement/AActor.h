#pragma once

#include "CoreMinimal.h"
#include "DotnetMetadata.h"
#include "Manage/ManageCharacter.h"
#include "Runtime/Engine/Classes/GameFramework/Actor.h"

extern "C"
{
	DOTNET_EXPORT auto E_AActor_CreateDefaultSubobject(AActor* Self, char* ClassName, char* ComponentName)
	{
		auto className = UTF8_TO_TCHAR(ClassName);
		auto componentName = UTF8_TO_TCHAR(ComponentName);

		auto componentClass = FindObject<UClass>(ANY_PACKAGE, className);

		auto compoennt = Self->CreateDefaultSubobject(componentName, componentClass, componentClass, true, false, false);
		return ConvertToManage_ObjectPointerDescription(compoennt);
	}

	DOTNET_EXPORT auto E_AActor_SpawnActor(AActor* Self, char* ClassName, INT_PTR Transform)
	{
		auto className = UTF8_TO_TCHAR(ClassName);
		auto actorClass = FindObject<UClass>(ANY_PACKAGE, className);

		auto actor = Self->GetWorld()->SpawnActor<AActor>(actorClass, FTransform());
		return ConvertToManage_ObjectPointerDescription(actor);
	}

	DOTNET_EXPORT auto E_AActor_SpawnActorManage(AActor* Self, char* ClassName, INT_PTR Transform, char* ManageClassName)
	{
		auto pTransform = *(FTransform*)Transform;

		auto className = UTF8_TO_TCHAR(ClassName);
		auto actorClass = FindObject<UClass>(ANY_PACKAGE, className);

		auto actor = Self->GetWorld()->SpawnActor<AManageCharacter>(actorClass, pTransform); //todo:: replace AManageCharacter to interface
		actor->ManageClassName.FullName = UTF8_TO_TCHAR(ManageClassName);
		actor->AddWrapperIfNotAttach();

		return ConvertToManage_ObjectPointerDescription(actor);
	}
}