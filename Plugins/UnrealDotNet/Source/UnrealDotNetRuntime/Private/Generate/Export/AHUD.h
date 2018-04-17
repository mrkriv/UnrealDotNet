#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/GameFramework/HUD.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\HUD.h:35

class E_PROTECTED_WRAP_AHUD : protected AHUD
{
public:
	bool IsCanvasValid_WarnIfNot_WRAP()
	{
		return IsCanvasValid_WarnIfNot();
	}

	bool HasNetOwner_WRAP()
	{
		return HasNetOwner();
	}

	void OnRep_Owner_WRAP()
	{
		OnRep_Owner();
	}

	void RegisterActorTickFunctions_WRAP(bool bRegister)
	{
		RegisterActorTickFunctions(bRegister);
	}

}
;

extern "C"
{
	DOTNET_EXPORT auto E_PROP_AHUD_LastHUDRenderTime_GET(AHUD* Ptr) { return Ptr->LastHUDRenderTime; }
	DOTNET_EXPORT void E_PROP_AHUD_LastHUDRenderTime_SET(AHUD* Ptr, float Value) { Ptr->LastHUDRenderTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_AHUD_RenderDelta_GET(AHUD* Ptr) { return Ptr->RenderDelta; }
	DOTNET_EXPORT void E_PROP_AHUD_RenderDelta_SET(AHUD* Ptr, float Value) { Ptr->RenderDelta = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_AHUD(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<AHUD>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_AHUD_AddHitBox(AHUD* Self, INT_PTR Position, INT_PTR Size, char* InName, bool bConsumesInput, int32 Priority)
	{
		auto _p0 = *(FVector2D*)Position;
		auto _p1 = *(FVector2D*)Size;
		auto _p2 = ConvertFromManage_FName(InName);
		auto _p3 = bConsumesInput;
		auto _p4 = Priority;
		Self->AddHitBox(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_AHUD_AddPostRenderedActor(AHUD* Self, AActor* A)
	{
		auto _p0 = A;
		Self->AddPostRenderedActor(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_AnyCurrentHitBoxHits(AHUD* Self)
	{
		return Self->AnyCurrentHitBoxHits();
	}

	DOTNET_EXPORT auto E_AHUD_Deproject(AHUD* Self, float ScreenX, float ScreenY, INT_PTR WorldPosition, INT_PTR WorldDirection)
	{
		auto _p0 = ScreenX;
		auto _p1 = ScreenY;
		auto _p2 = *(FVector*)WorldPosition;
		auto _p3 = *(FVector*)WorldDirection;
		Self->Deproject(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_AHUD_DrawActorOverlays(AHUD* Self, INT_PTR Viewpoint, INT_PTR ViewRotation)
	{
		auto _p0 = *(FVector*)Viewpoint;
		auto _p1 = *(FRotator*)ViewRotation;
		Self->DrawActorOverlays(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_DrawDebugTextList(AHUD* Self)
	{
		Self->DrawDebugTextList();
	}

	DOTNET_EXPORT auto E_AHUD_DrawHUD(AHUD* Self)
	{
		Self->DrawHUD();
	}

	DOTNET_EXPORT auto E_AHUD_DrawSafeZoneOverlay(AHUD* Self)
	{
		Self->DrawSafeZoneOverlay();
	}

	DOTNET_EXPORT auto E_AHUD_GetCurrentDebugTargetActor(AHUD* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCurrentDebugTargetActor());
	}

	DOTNET_EXPORT auto E_AHUD_GetOwningPawn(AHUD* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetOwningPawn());
	}

	DOTNET_EXPORT auto E_AHUD_HandleBugScreenShot(AHUD* Self)
	{
		Self->HandleBugScreenShot();
	}

	DOTNET_EXPORT auto E_AHUD_IsCanvasValid_WarnIfNot(AHUD* Self)
	{
		return ((E_PROTECTED_WRAP_AHUD*)Self)->IsCanvasValid_WarnIfNot_WRAP();
	}

	DOTNET_EXPORT auto E_AHUD_NextDebugTarget(AHUD* Self)
	{
		Self->NextDebugTarget();
	}

	DOTNET_EXPORT auto E_AHUD_NotifyBindPostProcessEffects(AHUD* Self)
	{
		Self->NotifyBindPostProcessEffects();
	}

	DOTNET_EXPORT auto E_AHUD_NotifyHitBoxBeginCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->NotifyHitBoxBeginCursorOver(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_NotifyHitBoxClick(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->NotifyHitBoxClick(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_NotifyHitBoxEndCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->NotifyHitBoxEndCursorOver(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_NotifyHitBoxRelease(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->NotifyHitBoxRelease(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_OnLostFocusPause(AHUD* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->OnLostFocusPause(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_PostInitializeComponents(AHUD* Self)
	{
		Self->PostInitializeComponents();
	}

	DOTNET_EXPORT auto E_AHUD_PostRender(AHUD* Self)
	{
		Self->PostRender();
	}

	DOTNET_EXPORT auto E_AHUD_PreviousDebugTarget(AHUD* Self)
	{
		Self->PreviousDebugTarget();
	}

	DOTNET_EXPORT auto E_AHUD_Project(AHUD* Self, INT_PTR Location)
	{
		auto _p0 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->Project(_p0));
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveDrawHUD(AHUD* Self, int32 SizeX, int32 SizeY)
	{
		auto _p0 = SizeX;
		auto _p1 = SizeY;
		Self->ReceiveDrawHUD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveHitBoxBeginCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->ReceiveHitBoxBeginCursorOver(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveHitBoxClick(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->ReceiveHitBoxClick(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveHitBoxEndCursorOver(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->ReceiveHitBoxEndCursorOver(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ReceiveHitBoxRelease(AHUD* Self, char* BoxName)
	{
		auto _p0 = ConvertFromManage_FName(BoxName);
		Self->ReceiveHitBoxRelease(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_RemoveAllDebugStrings(AHUD* Self)
	{
		Self->RemoveAllDebugStrings();
	}

	DOTNET_EXPORT auto E_AHUD_RemoveDebugText(AHUD* Self, AActor* SrcActor, bool bLeaveDurationText)
	{
		auto _p0 = SrcActor;
		auto _p1 = bLeaveDurationText;
		Self->RemoveDebugText(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_RemovePostRenderedActor(AHUD* Self, AActor* A)
	{
		auto _p0 = A;
		Self->RemovePostRenderedActor(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ShouldDisplayDebug(AHUD* Self, char* DebugType)
	{
		auto _p0 = ConvertFromManage_FName(DebugType);
		return Self->ShouldDisplayDebug(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ShowDebug(AHUD* Self, char* DebugType)
	{
		auto _p0 = ConvertFromManage_FName(DebugType);
		Self->ShowDebug(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ShowDebugInfo(AHUD* Self, float YL, float YPos)
	{
		auto _p0 = YL;
		auto _p1 = YPos;
		Self->ShowDebugInfo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_ShowDebugToggleSubCategory(AHUD* Self, char* Category)
	{
		auto _p0 = ConvertFromManage_FName(Category);
		Self->ShowDebugToggleSubCategory(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ShowHUD(AHUD* Self)
	{
		Self->ShowHUD();
	}

	DOTNET_EXPORT auto E_AHUD_UpdateAndDispatchHitBoxClickEvents(AHUD* Self, INT_PTR ClickLocation, EInputEvent InEventType)
	{
		auto _p0 = *(FVector2D*)ClickLocation;
		auto _p1 = InEventType;
		return Self->UpdateAndDispatchHitBoxClickEvents(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_AddTickPrerequisiteActor(AHUD* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_AddTickPrerequisiteComponent(AHUD* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ApplyWorldOffset(AHUD* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_BeginDestroy(AHUD* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_AHUD_BeginPlay(AHUD* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_AHUD_CalculateComponentsBoundingBoxInLocalSpace(AHUD* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->CalculateComponentsBoundingBoxInLocalSpace(_p0));
	}

	DOTNET_EXPORT auto E_AHUD_CanBeBaseForCharacter(AHUD* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanBeBaseForCharacter(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_CanBeInCluster(AHUD* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_AHUD_CheckDefaultSubobjectsInternal(AHUD* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_AHUD_CheckStillInWorld(AHUD* Self)
	{
		return Self->CheckStillInWorld();
	}

	DOTNET_EXPORT auto E_AHUD_ClearCrossLevelReferences(AHUD* Self)
	{
		Self->ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E_AHUD_Destroyed(AHUD* Self)
	{
		Self->Destroyed();
	}

	DOTNET_EXPORT auto E_AHUD_DestroyNetworkActorHandled(AHUD* Self)
	{
		return Self->DestroyNetworkActorHandled();
	}

	DOTNET_EXPORT auto E_AHUD_ForceNetRelevant(AHUD* Self)
	{
		Self->ForceNetRelevant();
	}

	DOTNET_EXPORT auto E_AHUD_ForceNetUpdate(AHUD* Self)
	{
		Self->ForceNetUpdate();
	}

	DOTNET_EXPORT auto E_AHUD_GatherCurrentMovement(AHUD* Self)
	{
		Self->GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E_AHUD_GetActorEyesViewPoint(AHUD* Self, INT_PTR OutLocation, INT_PTR OutRotation)
	{
		auto _p0 = *(FVector*)OutLocation;
		auto _p1 = *(FRotator*)OutRotation;
		Self->GetActorEyesViewPoint(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_GetComponentsBoundingBox(AHUD* Self, bool bNonColliding)
	{
		auto _p0 = bNonColliding;
		return (INT_PTR) new FBox(Self->GetComponentsBoundingBox(_p0));
	}

	DOTNET_EXPORT auto E_AHUD_GetComponentsBoundingCylinder(AHUD* Self, float CollisionRadius, float CollisionHalfHeight, bool bNonColliding)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		auto _p2 = bNonColliding;
		Self->GetComponentsBoundingCylinder(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AHUD_GetComponentsCollisionResponseToChannel(AHUD* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetComponentsCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_GetDefaultAttachComponent(AHUD* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetDefaultAttachComponent());
	}

	DOTNET_EXPORT auto E_AHUD_GetHumanReadableName(AHUD* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetHumanReadableName());
	}

	DOTNET_EXPORT auto E_AHUD_GetLastRenderTime(AHUD* Self)
	{
		return Self->GetLastRenderTime();
	}

	DOTNET_EXPORT auto E_AHUD_GetLifeSpan(AHUD* Self)
	{
		return Self->GetLifeSpan();
	}

	DOTNET_EXPORT auto E_AHUD_GetNetOwningPlayer(AHUD* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetNetOwningPlayer());
	}

	DOTNET_EXPORT auto E_AHUD_GetSimpleCollisionCylinder(AHUD* Self, float CollisionRadius, float CollisionHalfHeight)
	{
		auto _p0 = CollisionRadius;
		auto _p1 = CollisionHalfHeight;
		Self->GetSimpleCollisionCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_GetTargetLocation(AHUD* Self, AActor* RequestedBy)
	{
		auto _p0 = RequestedBy;
		return (INT_PTR) new FVector(Self->GetTargetLocation(_p0));
	}

	DOTNET_EXPORT auto E_AHUD_GetVelocity(AHUD* Self)
	{
		return (INT_PTR) new FVector(Self->GetVelocity());
	}

	DOTNET_EXPORT auto E_AHUD_GetWorld(AHUD* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_AHUD_HasActiveCameraComponent(AHUD* Self)
	{
		return Self->HasActiveCameraComponent();
	}

	DOTNET_EXPORT auto E_AHUD_HasActivePawnControlCameraComponent(AHUD* Self)
	{
		return Self->HasActivePawnControlCameraComponent();
	}

	DOTNET_EXPORT auto E_AHUD_HasNetOwner(AHUD* Self)
	{
		return ((E_PROTECTED_WRAP_AHUD*)Self)->HasNetOwner_WRAP();
	}

	DOTNET_EXPORT auto E_AHUD_InvalidateLightingCacheDetailed(AHUD* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_IsAttachedTo(AHUD* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsAttachedTo(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_IsBasedOnActor(AHUD* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsBasedOnActor(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_IsComponentRelevantForNavigation(AHUD* Self, UActorComponent* Component)
	{
		auto _p0 = Component;
		return Self->IsComponentRelevantForNavigation(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_IsLevelBoundsRelevant(AHUD* Self)
	{
		return Self->IsLevelBoundsRelevant();
	}

	DOTNET_EXPORT auto E_AHUD_IsNameStableForNetworking(AHUD* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_AHUD_IsNetRelevantFor(AHUD* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		return Self->IsNetRelevantFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AHUD_IsReadyForFinishDestroy(AHUD* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_AHUD_IsRelevancyOwnerFor(AHUD* Self, AActor* ReplicatedActor, AActor* ActorOwner, AActor* ConnectionActor)
	{
		auto _p0 = ReplicatedActor;
		auto _p1 = ActorOwner;
		auto _p2 = ConnectionActor;
		return Self->IsRelevancyOwnerFor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AHUD_IsReplayRelevantFor(AHUD* Self, AActor* RealViewer, AActor* ViewTarget, INT_PTR SrcLocation, float CullDistanceSquared)
	{
		auto _p0 = RealViewer;
		auto _p1 = ViewTarget;
		auto _p2 = *(FVector*)SrcLocation;
		auto _p3 = CullDistanceSquared;
		return Self->IsReplayRelevantFor(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_AHUD_IsRootComponentCollisionRegistered(AHUD* Self)
	{
		return Self->IsRootComponentCollisionRegistered();
	}

	DOTNET_EXPORT auto E_AHUD_IsSupportedForNetworking(AHUD* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_AHUD_K2_DestroyActor(AHUD* Self)
	{
		Self->K2_DestroyActor();
	}

	DOTNET_EXPORT auto E_AHUD_LifeSpanExpired(AHUD* Self)
	{
		Self->LifeSpanExpired();
	}

	DOTNET_EXPORT auto E_AHUD_MarkComponentsAsPendingKill(AHUD* Self)
	{
		Self->MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E_AHUD_Modify(AHUD* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_NotifyActorBeginCursorOver(AHUD* Self)
	{
		Self->NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E_AHUD_NotifyActorBeginOverlap(AHUD* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorBeginOverlap(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_NotifyActorEndCursorOver(AHUD* Self)
	{
		Self->NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E_AHUD_NotifyActorEndOverlap(AHUD* Self, AActor* OtherActor)
	{
		auto _p0 = OtherActor;
		Self->NotifyActorEndOverlap(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_NotifyHit(AHUD* Self, UPrimitiveComponent* MyComp, AActor* Other, UPrimitiveComponent* OtherComp, bool bSelfMoved, INT_PTR HitLocation, INT_PTR HitNormal, INT_PTR NormalImpulse, INT_PTR Hit)
	{
		auto _p0 = MyComp;
		auto _p1 = Other;
		auto _p2 = OtherComp;
		auto _p3 = bSelfMoved;
		auto _p4 = *(FVector*)HitLocation;
		auto _p5 = *(FVector*)HitNormal;
		auto _p6 = *(FVector*)NormalImpulse;
		auto _p7 = *(FHitResult*)Hit;
		Self->NotifyHit(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_AHUD_OnConstruction(AHUD* Self, INT_PTR Transform)
	{
		auto _p0 = *(FTransform*)Transform;
		Self->OnConstruction(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_OnRep_AttachmentReplication(AHUD* Self)
	{
		Self->OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E_AHUD_OnRep_Instigator(AHUD* Self)
	{
		Self->OnRep_Instigator();
	}

	DOTNET_EXPORT auto E_AHUD_OnRep_Owner(AHUD* Self)
	{
		((E_PROTECTED_WRAP_AHUD*)Self)->OnRep_Owner_WRAP();
	}

	DOTNET_EXPORT auto E_AHUD_OnRep_ReplicatedMovement(AHUD* Self)
	{
		Self->OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E_AHUD_OnRep_ReplicateMovement(AHUD* Self)
	{
		Self->OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E_AHUD_OnReplicationPausedChanged(AHUD* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		Self->OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_OnSubobjectCreatedFromReplication(AHUD* Self, UObject* NewSubobject)
	{
		auto _p0 = NewSubobject;
		Self->OnSubobjectCreatedFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_OnSubobjectDestroyFromReplication(AHUD* Self, UObject* Subobject)
	{
		auto _p0 = Subobject;
		Self->OnSubobjectDestroyFromReplication(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_OutsideWorldBounds(AHUD* Self)
	{
		Self->OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E_AHUD_PostActorCreated(AHUD* Self)
	{
		Self->PostActorCreated();
	}

	DOTNET_EXPORT auto E_AHUD_PostInitProperties(AHUD* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_AHUD_PostLoad(AHUD* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_AHUD_PostNetInit(AHUD* Self)
	{
		Self->PostNetInit();
	}

	DOTNET_EXPORT auto E_AHUD_PostNetReceive(AHUD* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_AHUD_PostNetReceiveLocationAndRotation(AHUD* Self)
	{
		Self->PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E_AHUD_PostNetReceivePhysicState(AHUD* Self)
	{
		Self->PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E_AHUD_PostNetReceiveVelocity(AHUD* Self, INT_PTR NewVelocity)
	{
		auto _p0 = *(FVector*)NewVelocity;
		Self->PostNetReceiveVelocity(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_PostRegisterAllComponents(AHUD* Self)
	{
		Self->PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E_AHUD_PostRename(AHUD* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_PostUnregisterAllComponents(AHUD* Self)
	{
		Self->PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E_AHUD_PreInitializeComponents(AHUD* Self)
	{
		Self->PreInitializeComponents();
	}

	DOTNET_EXPORT auto E_AHUD_PreNetReceive(AHUD* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_AHUD_PrestreamTextures(AHUD* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		Self->PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AHUD_RegisterActorTickFunctions(AHUD* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((E_PROTECTED_WRAP_AHUD*)Self)->RegisterActorTickFunctions_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_RegisterAllComponents(AHUD* Self)
	{
		Self->RegisterAllComponents();
	}

	DOTNET_EXPORT auto E_AHUD_RemoveTickPrerequisiteActor(AHUD* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_RemoveTickPrerequisiteComponent(AHUD* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ReregisterAllComponents(AHUD* Self)
	{
		Self->ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E_AHUD_RerunConstructionScripts(AHUD* Self)
	{
		Self->RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E_AHUD_Reset(AHUD* Self)
	{
		Self->Reset();
	}

	DOTNET_EXPORT auto E_AHUD_SetActorHiddenInGame(AHUD* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		Self->SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_SetLifeSpan(AHUD* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_SetOwner(AHUD* Self, AActor* NewOwner)
	{
		auto _p0 = NewOwner;
		Self->SetOwner(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_SetReplicateMovement(AHUD* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		Self->SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_ShouldTickIfViewportsOnly(AHUD* Self)
	{
		return Self->ShouldTickIfViewportsOnly();
	}

	DOTNET_EXPORT auto E_AHUD_TearOff(AHUD* Self)
	{
		Self->TearOff();
	}

	DOTNET_EXPORT auto E_AHUD_TeleportSucceeded(AHUD* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		Self->TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_TeleportTo(AHUD* Self, INT_PTR DestLocation, INT_PTR DestRotation, bool bIsATest, bool bNoCheck)
	{
		auto _p0 = *(FVector*)DestLocation;
		auto _p1 = *(FRotator*)DestRotation;
		auto _p2 = bIsATest;
		auto _p3 = bNoCheck;
		return Self->TeleportTo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_AHUD_Tick(AHUD* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->Tick(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_TickActor(AHUD* Self, float DeltaTime, ELevelTick TickType, INT_PTR ThisTickFunction)
	{
		auto _p0 = DeltaTime;
		auto _p1 = TickType;
		auto _p2 = *(FActorTickFunction*)ThisTickFunction;
		Self->TickActor(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_AHUD_TornOff(AHUD* Self)
	{
		Self->TornOff();
	}

	DOTNET_EXPORT auto E_AHUD_UnregisterAllComponents(AHUD* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		Self->UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_UseShortConnectTimeout(AHUD* Self)
	{
		return Self->UseShortConnectTimeout();
	}

	DOTNET_EXPORT auto E_AHUD_AreNativePropertiesIdenticalTo(AHUD* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_FinishDestroy(AHUD* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_AHUD_GetDesc(AHUD* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_AHUD_GetDetailedInfoInternal(AHUD* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_AHUD_IsAsset(AHUD* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_AHUD_IsEditorOnly(AHUD* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_AHUD_IsFullNameStableForNetworking(AHUD* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_AHUD_IsLocalizedResource(AHUD* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_AHUD_IsPostLoadThreadSafe(AHUD* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_AHUD_IsSafeForRootSet(AHUD* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_AHUD_MarkAsEditorOnlySubobject(AHUD* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_AHUD_NeedsLoadForClient(AHUD* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_AHUD_NeedsLoadForEditorGame(AHUD* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_AHUD_NeedsLoadForServer(AHUD* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_AHUD_NotifyObjectReferenceEliminated(AHUD* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_AHUD_PostCDOContruct(AHUD* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_AHUD_PostEditImport(AHUD* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_AHUD_PostRepNotifies(AHUD* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_AHUD_PostSaveRoot(AHUD* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_AHUD_PreDestroyFromReplication(AHUD* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_AHUD_ShutdownAfterError(AHUD* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_AHUD_AddToCluster(AHUD* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_AHUD_CanBeClusterRoot(AHUD* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_AHUD_CreateCluster(AHUD* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_AHUD_OnClusterMarkedAsPendingKill(AHUD* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
