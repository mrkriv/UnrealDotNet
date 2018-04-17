using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\HUD.h:35

namespace UnrealEngine
{
	public  partial class AHUD : AActor
	{
		public AHUD(IntPtr Adress)
			: base(Adress)
		{
		}

		public AHUD(UObject Parent = null, string Name = "HUD")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AHUD(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AHUD(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AHUD_LastHUDRenderTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AHUD_LastHUDRenderTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AHUD_RenderDelta_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AHUD_RenderDelta_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_AddHitBox(IntPtr Self, IntPtr Position, IntPtr Size, string InName, bool bConsumesInput, int Priority);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_AddPostRenderedActor(IntPtr Self, IntPtr A);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_AnyCurrentHitBoxHits(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_Deproject(IntPtr Self, float ScreenX, float ScreenY, IntPtr WorldPosition, IntPtr WorldDirection);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_DrawActorOverlays(IntPtr Self, IntPtr Viewpoint, IntPtr ViewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_DrawDebugTextList(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_DrawHUD(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_DrawSafeZoneOverlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AHUD_GetCurrentDebugTargetActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AHUD_GetOwningPawn(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_HandleBugScreenShot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsCanvasValid_WarnIfNot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NextDebugTarget(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyBindPostProcessEffects(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyHitBoxBeginCursorOver(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyHitBoxClick(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyHitBoxEndCursorOver(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyHitBoxRelease(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnLostFocusPause(IntPtr Self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostInitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostRender(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PreviousDebugTarget(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AHUD_Project(IntPtr Self, IntPtr Location);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveDrawHUD(IntPtr Self, int SizeX, int SizeY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveHitBoxBeginCursorOver(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveHitBoxClick(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveHitBoxEndCursorOver(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReceiveHitBoxRelease(IntPtr Self, string BoxName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RemoveAllDebugStrings(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RemoveDebugText(IntPtr Self, IntPtr SrcActor, bool bLeaveDurationText);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RemovePostRenderedActor(IntPtr Self, IntPtr A);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_ShouldDisplayDebug(IntPtr Self, string DebugType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ShowDebug(IntPtr Self, string DebugType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ShowDebugInfo(IntPtr Self, float YL, float YPos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ShowDebugToggleSubCategory(IntPtr Self, string Category);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ShowHUD(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_UpdateAndDispatchHitBoxClickEvents(IntPtr Self, IntPtr ClickLocation, byte InEventType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AHUD_CalculateComponentsBoundingBoxInLocalSpace(IntPtr Self, bool bNonColliding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_CanBeBaseForCharacter(IntPtr Self, IntPtr Pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_CheckStillInWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ClearCrossLevelReferences(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_Destroyed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_DestroyNetworkActorHandled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ForceNetRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ForceNetUpdate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_GatherCurrentMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_GetActorEyesViewPoint(IntPtr Self, IntPtr OutLocation, IntPtr OutRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AHUD_GetComponentsBoundingBox(IntPtr Self, bool bNonColliding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_GetComponentsBoundingCylinder(IntPtr Self, float CollisionRadius, float CollisionHalfHeight, bool bNonColliding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_AHUD_GetComponentsCollisionResponseToChannel(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AHUD_GetDefaultAttachComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AHUD_GetHumanReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AHUD_GetLastRenderTime(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AHUD_GetLifeSpan(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AHUD_GetNetOwningPlayer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_GetSimpleCollisionCylinder(IntPtr Self, float CollisionRadius, float CollisionHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AHUD_GetTargetLocation(IntPtr Self, IntPtr RequestedBy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AHUD_GetVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AHUD_GetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_HasActiveCameraComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_HasActivePawnControlCameraComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_HasNetOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_InvalidateLightingCacheDetailed(IntPtr Self, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsAttachedTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsBasedOnActor(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsComponentRelevantForNavigation(IntPtr Self, IntPtr Component);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsLevelBoundsRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsNetRelevantFor(IntPtr Self, IntPtr RealViewer, IntPtr ViewTarget, IntPtr SrcLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsRelevancyOwnerFor(IntPtr Self, IntPtr ReplicatedActor, IntPtr ActorOwner, IntPtr ConnectionActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsReplayRelevantFor(IntPtr Self, IntPtr RealViewer, IntPtr ViewTarget, IntPtr SrcLocation, float CullDistanceSquared);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsRootComponentCollisionRegistered(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_K2_DestroyActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_LifeSpanExpired(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_MarkComponentsAsPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyActorBeginCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyActorBeginOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyActorEndCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyActorEndOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyHit(IntPtr Self, IntPtr MyComp, IntPtr Other, IntPtr OtherComp, bool bSelfMoved, IntPtr HitLocation, IntPtr HitNormal, IntPtr NormalImpulse, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnConstruction(IntPtr Self, IntPtr Transform);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnRep_AttachmentReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnRep_Instigator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnRep_Owner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnRep_ReplicatedMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnRep_ReplicateMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnReplicationPausedChanged(IntPtr Self, bool bIsReplicationPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnSubobjectCreatedFromReplication(IntPtr Self, IntPtr NewSubobject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnSubobjectDestroyFromReplication(IntPtr Self, IntPtr Subobject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OutsideWorldBounds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostActorCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostNetInit(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostNetReceiveLocationAndRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostNetReceivePhysicState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostNetReceiveVelocity(IntPtr Self, IntPtr NewVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostRegisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostUnregisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PreInitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PrestreamTextures(IntPtr Self, float Seconds, bool bEnableStreaming, int CinematicTextureGroups);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RegisterActorTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RegisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ReregisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_RerunConstructionScripts(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_Reset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_SetActorHiddenInGame(IntPtr Self, bool bNewHidden);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_SetLifeSpan(IntPtr Self, float InLifespan);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_SetOwner(IntPtr Self, IntPtr NewOwner);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_SetReplicateMovement(IntPtr Self, bool bInReplicateMovement);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_ShouldTickIfViewportsOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_TearOff(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_TeleportSucceeded(IntPtr Self, bool bIsATest);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_TeleportTo(IntPtr Self, IntPtr DestLocation, IntPtr DestRotation, bool bIsATest, bool bNoCheck);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_Tick(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_TickActor(IntPtr Self, float DeltaTime, byte TickType, IntPtr ThisTickFunction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_TornOff(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_UnregisterAllComponents(IntPtr Self, bool bForReregister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_UseShortConnectTimeout(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AHUD_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AHUD_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AHUD_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AHUD_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Used to calculate delta time between HUD rendering. </para>
		/// </summary>
		public float LastHUDRenderTime
		{
			get => E_PROP_AHUD_LastHUDRenderTime_GET(NativePointer);
			set => E_PROP_AHUD_LastHUDRenderTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Time since last HUD render. </para>
		/// </summary>
		public float RenderDelta
		{
			get => E_PROP_AHUD_RenderDelta_GET(NativePointer);
			set => E_PROP_AHUD_RenderDelta_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add a hitbox to the hud </para>
		/// <param name="Position">Coordinates of the top left of the hit box. </param>
		/// <param name="Size">Size of the hit box. </param>
		/// <param name="Name">Name of the hit box. </param>
		/// <param name="bConsumesInput">Whether click processing should continue if this hit box is clicked. </param>
		/// <param name="Priority">The priority of the box used for layering. Larger values are considered first.  Equal values are considered in the order they were added. </param>
		/// </summary>
		public void AddHitBox(FVector2D Position, FVector2D Size, string InName, bool bConsumesInput, int Priority = 0)
			=> E_AHUD_AddHitBox(this, Position, Size, InName, bConsumesInput, Priority);
		
		
		/// <summary>
		/// <para>add an actor to the PostRenderedActors array </para>
		/// </summary>
		public virtual void AddPostRenderedActor(AActor A)
			=> E_AHUD_AddPostRenderedActor(this, A);
		
		
		/// <summary>
		/// <para>Have any hitboxes been hit this frame. </para>
		/// </summary>
		public bool AnyCurrentHitBoxHits()
			=> E_AHUD_AnyCurrentHitBoxHits(this);
		
		
		/// <summary>
		/// <para>Transforms a 2D screen location into a 3D location and direction </para>
		/// </summary>
		public void Deproject(float ScreenX, float ScreenY, FVector WorldPosition, FVector WorldDirection)
			=> E_AHUD_Deproject(this, ScreenX, ScreenY, WorldPosition, WorldDirection);
		
		
		/// <summary>
		/// <para>draw overlays for actors that were rendered this tick and have added themselves to the PostRenderedActors array </para>
		/// </summary>
		public virtual void DrawActorOverlays(FVector Viewpoint, FRotator ViewRotation)
			=> E_AHUD_DrawActorOverlays(this, Viewpoint, ViewRotation);
		
		
		/// <summary>
		/// <para>Iterate through list of debug text and draw it over the associated actors in world space. </para>
		/// <para>Also handles culling null entries, and reducing the duration for timed debug text. </para>
		/// </summary>
		public void DrawDebugTextList()
			=> E_AHUD_DrawDebugTextList(this);
		
		
		/// <summary>
		/// <para>The Main Draw loop for the hud.  Gets called before any messaging.  Should be subclassed </para>
		/// </summary>
		public virtual void DrawHUD()
			=> E_AHUD_DrawHUD(this);
		
		
		/// <summary>
		/// <para>Draw the safe zone debugging overlay when enabled </para>
		/// </summary>
		public virtual void DrawSafeZoneOverlay()
			=> E_AHUD_DrawSafeZoneOverlay(this);
		
		
		/// <summary>
		/// <para>Get Target to view 'showdebug' on </para>
		/// </summary>
		public virtual AActor GetCurrentDebugTargetActor()
			=> E_AHUD_GetCurrentDebugTargetActor(this);
		
		
		/// <summary>
		/// <para>Returns the Pawn for this HUD's player. </para>
		/// </summary>
		public APawn GetOwningPawn()
			=> E_AHUD_GetOwningPawn(this);
		
		
		/// <summary>
		/// <para>Gives the HUD a chance to display project-specific data when taking a "bug" screen shot. </para>
		/// </summary>
		public virtual void HandleBugScreenShot()
			=> E_AHUD_HandleBugScreenShot(this);
		
		protected bool IsCanvasValid_WarnIfNot()
			=> E_AHUD_IsCanvasValid_WarnIfNot(this);
		
		public virtual void NextDebugTarget()
			=> E_AHUD_NextDebugTarget(this);
		
		
		/// <summary>
		/// <para>Called in PostInitializeComponents or postprocessing chain has changed (happens because of the worldproperties can define it's own chain and this one is set late). </para>
		/// </summary>
		public virtual void NotifyBindPostProcessEffects()
			=> E_AHUD_NotifyBindPostProcessEffects(this);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is moused over. </para>
		/// </summary>
		public virtual void NotifyHitBoxBeginCursorOver(string BoxName)
			=> E_AHUD_NotifyHitBoxBeginCursorOver(this, BoxName);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is clicked on. Provides the name associated with that box. </para>
		/// </summary>
		public virtual void NotifyHitBoxClick(string BoxName)
			=> E_AHUD_NotifyHitBoxClick(this, BoxName);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box no longer has the mouse over it. </para>
		/// </summary>
		public virtual void NotifyHitBoxEndCursorOver(string BoxName)
			=> E_AHUD_NotifyHitBoxEndCursorOver(this, BoxName);
		
		
		/// <summary>
		/// <para>Native handler, called when a hit box is unclicked. Provides the name associated with that box. </para>
		/// </summary>
		public virtual void NotifyHitBoxRelease(string BoxName)
			=> E_AHUD_NotifyHitBoxRelease(this, BoxName);
		
		
		/// <summary>
		/// <para>Pauses or unpauses the game due to main window's focus being lost. </para>
		/// <param name="Enable">tells whether to enable or disable the pause state </param>
		/// </summary>
		public virtual void OnLostFocusPause(bool bEnable)
			=> E_AHUD_OnLostFocusPause(this, bEnable);
		
		public override void PostInitializeComponents()
			=> E_AHUD_PostInitializeComponents(this);
		
		
		/// <summary>
		/// <para>PostRender is the main draw loop. </para>
		/// </summary>
		public virtual void PostRender()
			=> E_AHUD_PostRender(this);
		
		public virtual void PreviousDebugTarget()
			=> E_AHUD_PreviousDebugTarget(this);
		
		
		/// <summary>
		/// <para>Transforms a 3D world-space vector into 2D screen coordinates </para>
		/// </summary>
		public FVector Project(FVector Location)
			=> E_AHUD_Project(this, Location);
		
		public void ReceiveDrawHUD(int SizeX, int SizeY)
			=> E_AHUD_ReceiveDrawHUD(this, SizeX, SizeY);
		
		
		/// <summary>
		/// <para>Called when a hit box is moused over. </para>
		/// </summary>
		public void HitBoxBeginCursorOver(string BoxName)
			=> E_AHUD_ReceiveHitBoxBeginCursorOver(this, BoxName);
		
		
		/// <summary>
		/// <para>Called when a hit box is clicked on. Provides the name associated with that box. </para>
		/// </summary>
		public void HitBoxClicked(string BoxName)
			=> E_AHUD_ReceiveHitBoxClick(this, BoxName);
		
		
		/// <summary>
		/// <para>Called when a hit box no longer has the mouse over it. </para>
		/// </summary>
		public void HitBoxEndCursorOver(string BoxName)
			=> E_AHUD_ReceiveHitBoxEndCursorOver(this, BoxName);
		
		
		/// <summary>
		/// <para>Called when a hit box is unclicked. Provides the name associated with that box. </para>
		/// </summary>
		public void HitBoxReleased(string BoxName)
			=> E_AHUD_ReceiveHitBoxRelease(this, BoxName);
		
		public void RemoveAllDebugStrings()
			=> E_AHUD_RemoveAllDebugStrings(this);
		
		public void RemoveDebugText(AActor SrcActor, bool bLeaveDurationText = false)
			=> E_AHUD_RemoveDebugText(this, SrcActor, bLeaveDurationText);
		
		
		/// <summary>
		/// <para>remove an actor from the PostRenderedActors array </para>
		/// </summary>
		public virtual void RemovePostRenderedActor(AActor A)
			=> E_AHUD_RemovePostRenderedActor(this, A);
		
		
		/// <summary>
		/// <para>check if we should be display debug information for particular types of debug messages. </para>
		/// <param name="DebugType">type of debug message. </param>
		/// <return>true if it should be displayed, false otherwise. </return>
		/// </summary>
		public virtual bool ShouldDisplayDebug(string DebugType)
			=> E_AHUD_ShouldDisplayDebug(this, DebugType);
		
		public virtual void ShowDebug(string DebugType)
			=> E_AHUD_ShowDebug(this, DebugType);
		
		
		/// <summary>
		/// <para>Entry point for basic debug rendering on the HUD.  Activated and controlled via the "showdebug" console command. </para>
		/// <para>Can be overridden to display custom debug per-game. </para>
		/// </summary>
		public virtual void ShowDebugInfo(float YL, float YPos)
			=> E_AHUD_ShowDebugInfo(this, YL, YPos);
		
		public void ShowDebugToggleSubCategory(string Category)
			=> E_AHUD_ShowDebugToggleSubCategory(this, Category);
		
		public virtual void ShowHUD()
			=> E_AHUD_ShowHUD(this);
		
		
		/// <summary>
		/// <para>Update the list of hitboxes and dispatch events for any hits. </para>
		/// <param name="ClickLocation">Location of the click event </param>
		/// <param name="InEventType">Type of input event that triggered the call. </param>
		/// </summary>
		public bool UpdateAndDispatchHitBoxClickEvents(FVector2D ClickLocation, EInputEvent InEventType)
			=> E_AHUD_UpdateAndDispatchHitBoxClickEvents(this, ClickLocation, (byte)InEventType);
		
		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteActor. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_AHUD_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteComponent. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_AHUD_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Called by owning level to shift an actor location and all relevant data structures by specified delta </para>
		/// <param name="InWorldOffset">Offset vector to shift actor location </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_AHUD_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		public override void BeginDestroy()
			=> E_AHUD_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Overridable native event for when play begins for this actor. </para>
		/// </summary>
		public override void BeginPlay()
			=> E_AHUD_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Calculates the actor space bounding box of all components in this Actor.  This is slower than GetComponentsBoundingBox(), because the local bounds of the components are not cached -- they are recalculated every time this function is called. </para>
		/// <param name="bNonColliding">Indicates that you want to include non-colliding components in the bounding box </param>
		/// </summary>
		public override FBox CalculateComponentsBoundingBoxInLocalSpace(bool bNonColliding)
			=> E_AHUD_CalculateComponentsBoundingBoxInLocalSpace(this, bNonColliding);
		
		
		/// <summary>
		/// <para>Return true if the given Pawn can be "based" on this actor (ie walk on it). </para>
		/// <param name="Pawn">The pawn that wants to be based on this actor </param>
		/// </summary>
		public override bool CanBeBaseForCharacter(APawn Pawn)
			=> E_AHUD_CanBeBaseForCharacter(this, Pawn);
		
		public override bool CanBeInCluster()
			=> E_AHUD_CanBeInCluster(this);
		
		public override bool CheckDefaultSubobjectsInternal()
			=> E_AHUD_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>This will check to see if the Actor is still in the world.  It will check things like </para>
		/// <para>the KillZ, outside world bounds, etc. and handle the situation. </para>
		/// </summary>
		public override bool CheckStillInWorld()
			=> E_AHUD_CheckStillInWorld(this);
		
		
		/// <summary>
		/// <para>Do anything needed to clear out cross level references; Called from ULevel::PreSave </para>
		/// </summary>
		public override void ClearCrossLevelReferences()
			=> E_AHUD_ClearCrossLevelReferences(this);
		
		
		/// <summary>
		/// <para>Called once this actor has been deleted </para>
		/// </summary>
		public override void Destroyed()
			=> E_AHUD_Destroyed(this);
		
		
		/// <summary>
		/// <para>Called by DestroyActor(), gives actors a chance to op out of actor destruction </para>
		/// <para>Used by network code to have the net connection timeout/cleanup first </para>
		/// <return>true if DestroyActor() should not continue with actor destruction, false otherwise </return>
		/// </summary>
		public override bool DestroyNetworkActorHandled()
			=> E_AHUD_DestroyNetworkActorHandled(this);
		
		
		/// <summary>
		/// <para>Forces this actor to be net relevant if it is not already by default </para>
		/// </summary>
		public override void ForceNetRelevant()
			=> E_AHUD_ForceNetRelevant(this);
		
		
		/// <summary>
		/// <para>Force actor to be updated to clients </para>
		/// </summary>
		public override void ForceNetUpdate()
			=> E_AHUD_ForceNetUpdate(this);
		
		
		/// <summary>
		/// <para>Fills ReplicatedMovement property </para>
		/// </summary>
		public override void GatherCurrentMovement()
			=> E_AHUD_GatherCurrentMovement(this);
		
		
		/// <summary>
		/// <para>Returns the point of view of the actor. </para>
		/// <para>Note that this doesn't mean the camera, but the 'eyes' of the actor. </para>
		/// <para>For example, for a Pawn, this would define the eye height location, </para>
		/// <para>and view rotation (which is different from the pawn rotation which has a zeroed pitch component). </para>
		/// <para>A camera first person view will typically use this view point. Most traces (weapon, AI) will be done from this view point. </para>
		/// <param name="OutLocation">location of view point </param>
		/// <param name="OutRotation">view rotation of actor. </param>
		/// </summary>
		public override void GetActorEyesViewPoint(FVector OutLocation, FRotator OutRotation)
			=> E_AHUD_GetActorEyesViewPoint(this, OutLocation, OutRotation);
		
		
		/// <summary>
		/// <para>Returns the world space bounding box of all components in this Actor. </para>
		/// <param name="bNonColliding">Indicates that you want to include non-colliding components in the bounding box </param>
		/// </summary>
		public override FBox GetComponentsBoundingBox(bool bNonColliding)
			=> E_AHUD_GetComponentsBoundingBox(this, bNonColliding);
		
		
		/// <summary>
		/// <para>Get half-height/radius of a big axis-aligned cylinder around this actors registered colliding components, or all registered components if bNonColliding is false. </para>
		/// </summary>
		public override void GetComponentsBoundingCylinder(float CollisionRadius, float CollisionHalfHeight, bool bNonColliding)
			=> E_AHUD_GetComponentsBoundingCylinder(this, CollisionRadius, CollisionHalfHeight, bNonColliding);
		
		
		/// <summary>
		/// <para>Get Collision Response to the Channel that entered for all components </para>
		/// <para>It returns Max of state - i.e. if Component A overlaps, but if Component B blocks, it will return block as response </para>
		/// <para>if Component A ignores, but if Component B overlaps, it will return overlap </para>
		/// <param name="Channel">The channel to change the response of </param>
		/// </summary>
		public override ECollisionResponse GetComponentsCollisionResponseToChannel(ECollisionChannel Channel)
			=> (ECollisionResponse)E_AHUD_GetComponentsCollisionResponseToChannel(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Returns this actor's default attachment component for attaching children to </para>
		/// <return>The scene component to be used as parent </return>
		/// </summary>
		public override USceneComponent GetDefaultAttachComponent()
			=> E_AHUD_GetDefaultAttachComponent(this);
		
		
		/// <summary>
		/// <para>Returns the human readable string representation of an object. </para>
		/// </summary>
		public override string GetHumanReadableName()
			=> E_AHUD_GetHumanReadableName(this);
		
		
		/// <summary>
		/// <para>Returns the most recent time any of this actor's components were rendered </para>
		/// </summary>
		public override float GetLastRenderTime()
			=> E_AHUD_GetLastRenderTime(this);
		
		
		/// <summary>
		/// <para>Get the remaining lifespan of this actor. If zero is returned the actor lives forever. </para>
		/// </summary>
		public override float GetLifeSpan()
			=> E_AHUD_GetLifeSpan(this);
		
		
		/// <summary>
		/// <return>the owning UPlayer (if any) of this actor. This will be a local player, a net connection, or nullptr. </return>
		/// </summary>
		public override UPlayer GetNetOwningPlayer()
			=> E_AHUD_GetNetOwningPlayer(this);
		
		
		/// <summary>
		/// <para>Get axis-aligned cylinder around this actor, used for simple collision checks (ie Pawns reaching a destination). </para>
		/// <para>If IsRootComponentCollisionRegistered() returns true, just returns its bounding cylinder, otherwise falls back to GetComponentsBoundingCylinder. </para>
		/// </summary>
		public override void GetSimpleCollisionCylinder(float CollisionRadius, float CollisionHalfHeight)
			=> E_AHUD_GetSimpleCollisionCylinder(this, CollisionRadius, CollisionHalfHeight);
		
		
		/// <summary>
		/// <para>Returns the optimal location to fire weapons at this actor </para>
		/// <param name="RequestedBy">the Actor requesting the target location </param>
		/// </summary>
		public override FVector GetTargetLocation(AActor RequestedBy)
			=> E_AHUD_GetTargetLocation(this, RequestedBy);
		
		
		/// <summary>
		/// <para>Returns velocity (in cm/s (Unreal Units/second) of the rootcomponent if it is either using physics or has an associated MovementComponent </para>
		/// </summary>
		public override FVector GetVelocity()
			=> E_AHUD_GetVelocity(this);
		
		
		/// <summary>
		/// <para>Getter for the cached world pointer </para>
		/// </summary>
		public override UWorld GetWorld()
			=> E_AHUD_GetWorld(this);
		
		
		/// <summary>
		/// <para>Returns true if the actor contains an active camera component </para>
		/// </summary>
		public override bool HasActiveCameraComponent()
			=> E_AHUD_HasActiveCameraComponent(this);
		
		
		/// <summary>
		/// <para>Returns true if the actor contains an active locked to HMD camera component </para>
		/// </summary>
		public override bool HasActivePawnControlCameraComponent()
			=> E_AHUD_HasActivePawnControlCameraComponent(this);
		
		
		/// <summary>
		/// <para>Does this actor have an owner responsible for replication? (APlayerController typically) </para>
		/// <return>true if this actor can call RPCs or false if no such owner chain exists </return>
		/// </summary>
		protected override bool HasNetOwner()
			=> E_AHUD_HasNetOwner(this);
		
		
		/// <summary>
		/// <para>Invalidates anything produced by the last lighting build. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bTranslationOnly)
			=> E_AHUD_InvalidateLightingCacheDetailed(this, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Iterates up the Base chain to see whether or not this Actor is attached to the given Actor </para>
		/// <param name="Other">the Actor to test for </param>
		/// <return>true if this Actor is attached on Other Actor </return>
		/// </summary>
		public override bool IsAttachedTo(AActor Other)
			=> E_AHUD_IsAttachedTo(this, Other);
		
		
		/// <summary>
		/// <para>Iterates up the Base chain to see whether or not this Actor is based on the given Actor </para>
		/// <param name="Other">the Actor to test for </param>
		/// <return>true if this Actor is based on Other Actor </return>
		/// </summary>
		public override bool IsBasedOnActor(AActor Other)
			=> E_AHUD_IsBasedOnActor(this, Other);
		
		
		/// <summary>
		/// <para>Check if owned component should be relevant for navigation </para>
		/// <para>Allows implementing master switch to disable e.g. collision export in projectiles </para>
		/// </summary>
		public override bool IsComponentRelevantForNavigation(UActorComponent Component)
			=> E_AHUD_IsComponentRelevantForNavigation(this, Component);
		
		
		/// <summary>
		/// <para>Indicates whether this actor should participate in level bounds calculations </para>
		/// </summary>
		public override bool IsLevelBoundsRelevant()
			=> E_AHUD_IsLevelBoundsRelevant(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_AHUD_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <param name="RealViewer">is the "controlling net object" associated with the client for which network relevancy is being checked (typically player controller) </param>
		/// <param name="ViewTarget">is the Actor being used as the point of view for the RealViewer </param>
		/// <param name="SrcLocation">is the viewing location </param>
		/// <return>bool - true if this actor is network relevant to the client associated with RealViewer </return>
		/// </summary>
		public override bool IsNetRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation)
			=> E_AHUD_IsNetRelevantFor(this, RealViewer, ViewTarget, SrcLocation);
		
		public override bool IsReadyForFinishDestroy()
			=> E_AHUD_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Check if this actor is the owner when doing relevancy checks for actors marked bOnlyRelevantToOwner </para>
		/// <param name="ReplicatedActor">the actor we're doing a relevancy test on </param>
		/// <param name="ActorOwner">the owner of ReplicatedActor </param>
		/// <param name="ConnectionActor">the controller of the connection that we're doing relevancy checks for </param>
		/// <return>bool - true if this actor should be considered the owner </return>
		/// </summary>
		public override bool IsRelevancyOwnerFor(AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor)
			=> E_AHUD_IsRelevancyOwnerFor(this, ReplicatedActor, ActorOwner, ConnectionActor);
		
		
		/// <summary>
		/// <param name="RealViewer">is the "controlling net object" associated with the client for which network relevancy is being checked (typically player controller) </param>
		/// <param name="ViewTarget">is the Actor being used as the point of view for the RealViewer </param>
		/// <param name="SrcLocation">is the viewing location </param>
		/// <return>bool - true if this actor is replay relevant to the client associated with RealViewer </return>
		/// </summary>
		public override bool IsReplayRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared)
			=> E_AHUD_IsReplayRelevantFor(this, RealViewer, ViewTarget, SrcLocation, CullDistanceSquared);
		
		
		/// <summary>
		/// <para>@returns true if the root component is registered and has collision enabled. </para>
		/// </summary>
		public override bool IsRootComponentCollisionRegistered()
			=> E_AHUD_IsRootComponentCollisionRegistered(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_AHUD_IsSupportedForNetworking(this);
		
		
		/// <summary>
		/// <para>Destroy the actor </para>
		/// </summary>
		public override void DestroyActor()
			=> E_AHUD_K2_DestroyActor(this);
		
		
		/// <summary>
		/// <para>Called when the lifespan of an actor expires (if he has one). </para>
		/// </summary>
		public override void LifeSpanExpired()
			=> E_AHUD_LifeSpanExpired(this);
		
		
		/// <summary>
		/// <para>Called to mark all components as pending kill when the actor is being destroyed </para>
		/// </summary>
		public override void MarkComponentsAsPendingKill()
			=> E_AHUD_MarkComponentsAsPendingKill(this);
		
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_AHUD_Modify(this, bAlwaysMarkDirty);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved over it with the clickable interface. </para>
		/// </summary>
		public override void NotifyActorBeginCursorOver()
			=> E_AHUD_NotifyActorBeginCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when this actor overlaps another actor, for example a player walking into a trigger. </para>
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public override void NotifyActorBeginOverlap(AActor OtherActor)
			=> E_AHUD_NotifyActorBeginOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved off of it with the clickable interface. </para>
		/// </summary>
		public override void NotifyActorEndCursorOver()
			=> E_AHUD_NotifyActorEndCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when an actor no longer overlaps another actor, and they have separated. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public override void NotifyActorEndOverlap(AActor OtherActor)
			=> E_AHUD_NotifyActorEndOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when this actor bumps into a blocking object, or blocks another actor that bumps into it. </para>
		/// <para>This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation. </para>
		/// <para>For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event. </para>
		/// <para>@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled. </para>
		/// <para>@note When receiving a hit from another object's movement (bSelfMoved is false), the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// <para>will be adjusted to indicate force from the other object against this object. </para>
		/// </summary>
		public override void NotifyHit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, FHitResult Hit)
			=> E_AHUD_NotifyHit(this, MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
		
		
		/// <summary>
		/// <para>Called when an instance of this class is placed (in editor) or spawned. </para>
		/// <param name="Transform">The transform the actor was constructed at. </param>
		/// </summary>
		public override void OnConstruction(FTransform Transform)
			=> E_AHUD_OnConstruction(this, Transform);
		
		public override void OnRep_AttachmentReplication()
			=> E_AHUD_OnRep_AttachmentReplication(this);
		
		public override void OnRep_Instigator()
			=> E_AHUD_OnRep_Instigator(this);
		
		protected override void OnRep_Owner()
			=> E_AHUD_OnRep_Owner(this);
		
		public override void OnRep_ReplicatedMovement()
			=> E_AHUD_OnRep_ReplicatedMovement(this);
		
		public override void OnRep_ReplicateMovement()
			=> E_AHUD_OnRep_ReplicateMovement(this);
		
		
		/// <summary>
		/// <para>Called on the client when the replication paused value is changed </para>
		/// </summary>
		public override void OnReplicationPausedChanged(bool bIsReplicationPaused)
			=> E_AHUD_OnReplicationPausedChanged(this, bIsReplicationPaused);
		
		
		/// <summary>
		/// <para>Called on the actor when a new subobject is dynamically created via replication </para>
		/// </summary>
		public override void OnSubobjectCreatedFromReplication(UObject NewSubobject)
			=> E_AHUD_OnSubobjectCreatedFromReplication(this, NewSubobject);
		
		
		/// <summary>
		/// <para>Called on the actor when a subobject is dynamically destroyed via replication </para>
		/// </summary>
		public override void OnSubobjectDestroyFromReplication(UObject Subobject)
			=> E_AHUD_OnSubobjectDestroyFromReplication(this, Subobject);
		
		
		/// <summary>
		/// <para>Called when the Actor is outside the hard limit on world bounds </para>
		/// </summary>
		public override void OutsideWorldBounds()
			=> E_AHUD_OutsideWorldBounds(this);
		
		
		/// <summary>
		/// <para>Called when an actor is done spawning into the world (from UWorld::SpawnActor). </para>
		/// <para>For actors with a root component, the location and rotation will have already been set. </para>
		/// <para>Takes place after any construction scripts have been called </para>
		/// </summary>
		public override void PostActorCreated()
			=> E_AHUD_PostActorCreated(this);
		
		public override void PostInitProperties()
			=> E_AHUD_PostInitProperties(this);
		
		public override void PostLoad()
			=> E_AHUD_PostLoad(this);
		
		
		/// <summary>
		/// <para>Always called immediately after spawning and reading in replicated properties </para>
		/// </summary>
		public override void PostNetInit()
			=> E_AHUD_PostNetInit(this);
		
		
		/// <summary>
		/// <para>Always called immediately after properties are received from the remote. </para>
		/// </summary>
		public override void PostNetReceive()
			=> E_AHUD_PostNetReceive(this);
		
		
		/// <summary>
		/// <para>Update location and rotation from ReplicatedMovement. Not called for simulated physics! </para>
		/// </summary>
		public override void PostNetReceiveLocationAndRotation()
			=> E_AHUD_PostNetReceiveLocationAndRotation(this);
		
		
		/// <summary>
		/// <para>Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity() </para>
		/// </summary>
		public override void PostNetReceivePhysicState()
			=> E_AHUD_PostNetReceivePhysicState(this);
		
		
		/// <summary>
		/// <para>Update velocity - typically from ReplicatedMovement, not called for simulated physics! </para>
		/// </summary>
		public override void PostNetReceiveVelocity(FVector NewVelocity)
			=> E_AHUD_PostNetReceiveVelocity(this, NewVelocity);
		
		
		/// <summary>
		/// <para>Called after all the components in the Components array are registered </para>
		/// </summary>
		public override void PostRegisterAllComponents()
			=> E_AHUD_PostRegisterAllComponents(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_AHUD_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Called after all currently registered components are cleared </para>
		/// </summary>
		public override void PostUnregisterAllComponents()
			=> E_AHUD_PostUnregisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Called immediately before gameplay begins. </para>
		/// </summary>
		public override void PreInitializeComponents()
			=> E_AHUD_PreInitializeComponents(this);
		
		
		/// <summary>
		/// <para>Always called immediately before properties are received from the remote. </para>
		/// </summary>
		public override void PreNetReceive()
			=> E_AHUD_PreNetReceive(this);
		
		
		/// <summary>
		/// <para>Calls PrestreamTextures() for all the actor's meshcomponents. </para>
		/// <param name="Seconds">Number of seconds to force all mip-levels to be resident </param>
		/// <param name="bEnableStreaming">Whether to start (true) or stop (false) streaming </param>
		/// <param name="CinematicTextureGroups">Bitfield indicating which texture groups that use extra high-resolution mips </param>
		/// </summary>
		public override void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups)
			=> E_AHUD_PrestreamTextures(this, Seconds, bEnableStreaming, CinematicTextureGroups);
		
		
		/// <summary>
		/// <para>Virtual call chain to register all tick functions for the actor class hierarchy </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		protected override void RegisterActorTickFunctions(bool bRegister)
			=> E_AHUD_RegisterActorTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Ensure that all the components in the Components array are registered </para>
		/// </summary>
		public override void RegisterAllComponents()
			=> E_AHUD_RegisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_AHUD_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_AHUD_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Will reregister all components on this actor. Does a lot of work - should only really be used in editor, generally use UpdateComponentTransforms or MarkComponentsRenderStateDirty. </para>
		/// </summary>
		public override void ReregisterAllComponents()
			=> E_AHUD_ReregisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Rerun construction scripts, destroying all autogenerated components; will attempt to preserve the root component location. </para>
		/// </summary>
		public override void RerunConstructionScripts()
			=> E_AHUD_RerunConstructionScripts(this);
		
		
		/// <summary>
		/// <para>Reset actor to initial state - used when restarting level without reloading. </para>
		/// </summary>
		public override void Reset()
			=> E_AHUD_Reset(this);
		
		
		/// <summary>
		/// <para>Sets the actor to be hidden in the game </para>
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components </param>
		/// </summary>
		public override void SetActorHiddenInGame(bool bNewHidden)
			=> E_AHUD_SetActorHiddenInGame(this, bNewHidden);
		
		
		/// <summary>
		/// <para>Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed. </para>
		/// </summary>
		public override void SetLifeSpan(float InLifespan)
			=> E_AHUD_SetLifeSpan(this, InLifespan);
		
		
		/// <summary>
		/// <para>Set the owner of this Actor, used primarily for network replication. </para>
		/// <param name="NewOwner">The Actor whom takes over ownership of this Actor </param>
		/// </summary>
		public override void SetOwner(AActor NewOwner)
			=> E_AHUD_SetOwner(this, NewOwner);
		
		
		/// <summary>
		/// <para>Set whether this actor's movement replicates to network clients. </para>
		/// <param name="bInReplicateMovement">Whether this Actor's movement replicates to clients. </param>
		/// </summary>
		public override void SetReplicateMovement(bool bInReplicateMovement)
			=> E_AHUD_SetReplicateMovement(this, bInReplicateMovement);
		
		
		/// <summary>
		/// <para>If true, actor is ticked even if TickType==LEVELTICK_ViewportsOnly </para>
		/// </summary>
		public override bool ShouldTickIfViewportsOnly()
			=> E_AHUD_ShouldTickIfViewportsOnly(this);
		
		
		/// <summary>
		/// <para>Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true. </para>
		/// </summary>
		public override void TearOff()
			=> E_AHUD_TearOff(this);
		
		
		/// <summary>
		/// <para>Called from TeleportTo() when teleport succeeds </para>
		/// </summary>
		public override void TeleportSucceeded(bool bIsATest)
			=> E_AHUD_TeleportSucceeded(this, bIsATest);
		
		
		/// <summary>
		/// <para>Used for adding actors to levels or teleporting them to a new location. </para>
		/// <para>The result of this function is independent of the actor's current location and rotation. </para>
		/// <para>If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such if bNoCheck is false. </para>
		/// <param name="DestLocation">The target destination point </param>
		/// <param name="DestRotation">The target rotation at the destination </param>
		/// <param name="bIsATest">is true if this is a test movement, which shouldn't cause any notifications (used by AI pathfinding, for example) </param>
		/// <param name="bNoCheck">is true if we should skip checking for encroachment in the world or other actors </param>
		/// <return>true if the actor has been successfully moved, or false if it couldn't fit. </return>
		/// </summary>
		public override bool TeleportTo(FVector DestLocation, FRotator DestRotation, bool bIsATest, bool bNoCheck)
			=> E_AHUD_TeleportTo(this, DestLocation, DestRotation, bIsATest, bNoCheck);
		
		
		/// <summary>
		/// <para>Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame. </para>
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// <param name="DeltaSeconds">Game time elapsed during last frame modified by the time dilation </param>
		/// </summary>
		public override void Tick(float DeltaSeconds)
			=> E_AHUD_Tick(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>ticks the actor </para>
		/// <param name="DeltaTime">The time slice of this tick </param>
		/// <param name="TickType">The type of tick that is happening </param>
		/// <param name="ThisTickFunction">The tick function that is firing, useful for getting the completion handle </param>
		/// </summary>
		public override void TickActor(float DeltaTime, ELevelTick TickType, FActorTickFunction ThisTickFunction)
			=> E_AHUD_TickActor(this, DeltaTime, (byte)TickType, ThisTickFunction);
		
		
		/// <summary>
		/// <para>Networking - called on client when actor is torn off (bTearOff==true), meaning it's no longer replicated to clients. </para>
		/// <para>@see bTearOff </para>
		/// </summary>
		public override void TornOff()
			=> E_AHUD_TornOff(this);
		
		
		/// <summary>
		/// <para>Unregister all currently registered components </para>
		/// </summary>
		public override void UnregisterAllComponents(bool bForReregister)
			=> E_AHUD_UnregisterAllComponents(this, bForReregister);
		
		
		/// <summary>
		/// <para>Used by the net connection to determine if a net owning actor should switch to using the shortened timeout value </para>
		/// <return>true to switch from InitialConnectTimeout to ConnectionTimeout values on the net driver </return>
		/// </summary>
		public override bool UseShortConnectTimeout()
			=> E_AHUD_UseShortConnectTimeout(this);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_AHUD_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E_AHUD_FinishDestroy(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_AHUD_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_AHUD_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_AHUD_IsAsset(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine if the object is forced to be editor only or not </para>
		/// <return>true if this object should never be loaded outside the editor </return>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_AHUD_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_AHUD_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_AHUD_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_AHUD_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_AHUD_IsSafeForRootSet(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_AHUD_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on clients </para>
		/// <return>true if this object should be loaded on clients </return>
		/// </summary>
		public override bool NeedsLoadForClient()
			=> E_AHUD_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will still get loaded if NeedsLoadForServer/Client are true </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_AHUD_NeedsLoadForEditorGame(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on servers </para>
		/// <return>true if this object should be loaded on servers </return>
		/// </summary>
		public override bool NeedsLoadForServer()
			=> E_AHUD_NeedsLoadForServer(this);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_AHUD_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_AHUD_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_AHUD_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies()
			=> E_AHUD_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_AHUD_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_AHUD_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_AHUD_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_AHUD_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_AHUD_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_AHUD_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_AHUD_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(AHUD Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator AHUD(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AHUD>(PtrDesc);
		}}}
