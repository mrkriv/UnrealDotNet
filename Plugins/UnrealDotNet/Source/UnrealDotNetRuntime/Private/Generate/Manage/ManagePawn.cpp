// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

#include "UnrealDotNetRuntime.h"
#include "DotnetTypeName.h"
#include "Generate/Manage/ManagePawn.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

AManagePawn::AManagePawn(const FObjectInitializer& ObjectInitializer)
 : Super(ObjectInitializer)
{
	RootComponent = CreateDefaultSubobject<USceneComponent>(USceneComponent::GetDefaultSceneRootVariableName());
	RootComponent->Mobility = EComponentMobility::Movable;
	RootComponent->bVisualizeComponent = true;
	
	AddWrapperIfNotAttach();
}

bool AManagePawn::AddWrapperIfNotAttach()
{
	if (!bIsManageAttach && !ManageClassName.FullName.IsEmpty())
	{
		auto dotnetTypeName = ManageClassName.PackJSON();
		auto core = UCoreShell::GetInstance();
		
		bIsManageAttach = core->InvokeInWrapper<bool, 0>("UnrealEngine.NativeManager", "AddWrapper", this, TCHAR_TO_UTF8(*dotnetTypeName));
	}

	return bIsManageAttach;
}

void AManagePawn::AddControllerPitchInput(float Val)
{
	Super::AddControllerPitchInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerPitchInput", Val);
}

void AManagePawn::AddControllerRollInput(float Val)
{
	Super::AddControllerRollInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerRollInput", Val);
}

void AManagePawn::AddControllerYawInput(float Val)
{
	Super::AddControllerYawInput(Val);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddControllerYawInput", Val);
}

void AManagePawn::AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce)
{
	Super::AddMovementInput(WorldDirection, ScaleValue, bForce);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "AddMovementInput", WorldDirection, ScaleValue, bForce);
}

void AManagePawn::DestroyPlayerInputComponent()
{
	Super::DestroyPlayerInputComponent();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DestroyPlayerInputComponent");
}

void AManagePawn::DetachFromControllerPendingDestroy()
{
	Super::DetachFromControllerPendingDestroy();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "DetachFromControllerPendingDestroy");
}

void AManagePawn::FaceRotation(FRotator NewControlRotation, float DeltaTime)
{
	Super::FaceRotation(NewControlRotation, DeltaTime);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "FaceRotation", NewControlRotation, DeltaTime);
}

void AManagePawn::OnRep_Controller()
{
	Super::OnRep_Controller();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_Controller");
}

void AManagePawn::OnRep_PlayerState()
{
	Super::OnRep_PlayerState();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "OnRep_PlayerState");
}

void AManagePawn::PawnClientRestart()
{
	Super::PawnClientRestart();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnClientRestart");
}

void AManagePawn::PawnStartFire(uint8 FireModeNum)
{
	Super::PawnStartFire(FireModeNum);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PawnStartFire", FireModeNum);
}

void AManagePawn::PossessedBy(AController* NewController)
{
	Super::PossessedBy(NewController);
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "PossessedBy", NewController);
}

void AManagePawn::RecalculateBaseEyeHeight()
{
	Super::RecalculateBaseEyeHeight();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "RecalculateBaseEyeHeight");
}

void AManagePawn::Restart()
{
	Super::Restart();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "Restart");
}

void AManagePawn::SetPlayerDefaults()
{
	Super::SetPlayerDefaults();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SetPlayerDefaults");
}

void AManagePawn::SpawnDefaultController()
{
	Super::SpawnDefaultController();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "SpawnDefaultController");
}

void AManagePawn::TurnOff()
{
	Super::TurnOff();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "TurnOff");
}

void AManagePawn::UnPossessed()
{
	Super::UnPossessed();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UnPossessed");
}

void AManagePawn::UpdateNavigationRelevance()
{
	Super::UpdateNavigationRelevance();
	
	if(AddWrapperIfNotAttach())
		UCoreShell::GetInstance()->InvokeInObject(this, "UpdateNavigationRelevance");
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS
