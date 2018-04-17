using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

namespace UnrealEngine
{
	public  partial class ALight : AActor
	{
		public ALight(IntPtr Adress)
			: base(Adress)
		{
		}

		public ALight(UObject Parent = null, string Name = "Light")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ALight(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ALight(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_Destroyed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ALight_GetBrightness(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ALight_GetLightComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsLevelBoundsRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsToggleable(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnRep_bEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetAffectTranslucentLighting(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetBrightness(IntPtr Self, float NewBrightness);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetCastShadows(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetEnabled(IntPtr Self, bool bSetEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetLightFunctionFadeDistance(IntPtr Self, float NewLightFunctionFadeDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetLightFunctionScale(IntPtr Self, IntPtr NewLightFunctionScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_ToggleEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ALight_CalculateComponentsBoundingBoxInLocalSpace(IntPtr Self, bool bNonColliding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_CanBeBaseForCharacter(IntPtr Self, IntPtr Pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_CheckStillInWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_ClearCrossLevelReferences(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_DestroyNetworkActorHandled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_ForceNetRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_ForceNetUpdate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_GatherCurrentMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_GetActorEyesViewPoint(IntPtr Self, IntPtr OutLocation, IntPtr OutRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ALight_GetComponentsBoundingBox(IntPtr Self, bool bNonColliding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_GetComponentsBoundingCylinder(IntPtr Self, float CollisionRadius, float CollisionHalfHeight, bool bNonColliding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_ALight_GetComponentsCollisionResponseToChannel(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ALight_GetDefaultAttachComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_ALight_GetHumanReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ALight_GetLastRenderTime(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ALight_GetLifeSpan(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ALight_GetNetOwningPlayer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_GetSimpleCollisionCylinder(IntPtr Self, float CollisionRadius, float CollisionHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ALight_GetTargetLocation(IntPtr Self, IntPtr RequestedBy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ALight_GetVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ALight_GetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_HasActiveCameraComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_HasActivePawnControlCameraComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_HasNetOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_InvalidateLightingCacheDetailed(IntPtr Self, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsAttachedTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsBasedOnActor(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsComponentRelevantForNavigation(IntPtr Self, IntPtr Component);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsNetRelevantFor(IntPtr Self, IntPtr RealViewer, IntPtr ViewTarget, IntPtr SrcLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsRelevancyOwnerFor(IntPtr Self, IntPtr ReplicatedActor, IntPtr ActorOwner, IntPtr ConnectionActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsReplayRelevantFor(IntPtr Self, IntPtr RealViewer, IntPtr ViewTarget, IntPtr SrcLocation, float CullDistanceSquared);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsRootComponentCollisionRegistered(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_K2_DestroyActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_LifeSpanExpired(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_MarkComponentsAsPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_NotifyActorBeginCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_NotifyActorBeginOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_NotifyActorEndCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_NotifyActorEndOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_NotifyHit(IntPtr Self, IntPtr MyComp, IntPtr Other, IntPtr OtherComp, bool bSelfMoved, IntPtr HitLocation, IntPtr HitNormal, IntPtr NormalImpulse, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnConstruction(IntPtr Self, IntPtr Transform);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnRep_AttachmentReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnRep_Instigator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnRep_Owner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnRep_ReplicatedMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnRep_ReplicateMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnReplicationPausedChanged(IntPtr Self, bool bIsReplicationPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnSubobjectCreatedFromReplication(IntPtr Self, IntPtr NewSubobject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnSubobjectDestroyFromReplication(IntPtr Self, IntPtr Subobject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OutsideWorldBounds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostActorCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostInitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostNetInit(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostNetReceiveLocationAndRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostNetReceivePhysicState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostNetReceiveVelocity(IntPtr Self, IntPtr NewVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostRegisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostUnregisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PreInitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PrestreamTextures(IntPtr Self, float Seconds, bool bEnableStreaming, int CinematicTextureGroups);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_RegisterActorTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_RegisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_ReregisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_RerunConstructionScripts(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_Reset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetActorHiddenInGame(IntPtr Self, bool bNewHidden);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetLifeSpan(IntPtr Self, float InLifespan);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetOwner(IntPtr Self, IntPtr NewOwner);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_SetReplicateMovement(IntPtr Self, bool bInReplicateMovement);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_ShouldTickIfViewportsOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_TearOff(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_TeleportSucceeded(IntPtr Self, bool bIsATest);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_TeleportTo(IntPtr Self, IntPtr DestLocation, IntPtr DestRotation, bool bIsATest, bool bNoCheck);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_Tick(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_TickActor(IntPtr Self, float DeltaTime, byte TickType, IntPtr ThisTickFunction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_TornOff(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_UnregisterAllComponents(IntPtr Self, bool bForReregister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_UseShortConnectTimeout(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_ALight_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_ALight_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ALight_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ALight_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public override void Destroyed()
			=> E_ALight_Destroyed(this);
		
		public float GetBrightness()
			=> E_ALight_GetBrightness(this);
		
		
		/// <summary>
		/// <para>Returns LightComponent subobject </para>
		/// </summary>
		public ULightComponent GetLightComponent()
			=> E_ALight_GetLightComponent(this);
		
		public bool IsEnabled()
			=> E_ALight_IsEnabled(this);
		
		public override bool IsLevelBoundsRelevant()
			=> E_ALight_IsLevelBoundsRelevant(this);
		
		
		/// <summary>
		/// <para>Return whether the light supports being toggled off and on on-the-fly. </para>
		/// </summary>
		public bool IsToggleable()
			=> E_ALight_IsToggleable(this);
		
		public virtual void OnRep_bEnabled()
			=> E_ALight_OnRep_bEnabled(this);
		
		public void SetAffectTranslucentLighting(bool bNewValue)
			=> E_ALight_SetAffectTranslucentLighting(this, bNewValue);
		
		public void SetBrightness(float NewBrightness)
			=> E_ALight_SetBrightness(this, NewBrightness);
		
		public void SetCastShadows(bool bNewValue)
			=> E_ALight_SetCastShadows(this, bNewValue);
		
		public void SetEnabled(bool bSetEnabled)
			=> E_ALight_SetEnabled(this, bSetEnabled);
		
		public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
			=> E_ALight_SetLightFunctionFadeDistance(this, NewLightFunctionFadeDistance);
		
		public void SetLightFunctionScale(FVector NewLightFunctionScale)
			=> E_ALight_SetLightFunctionScale(this, NewLightFunctionScale);
		
		public void ToggleEnabled()
			=> E_ALight_ToggleEnabled(this);
		
		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteActor. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_ALight_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteComponent. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_ALight_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Called by owning level to shift an actor location and all relevant data structures by specified delta </para>
		/// <param name="InWorldOffset">Offset vector to shift actor location </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_ALight_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		public override void BeginDestroy()
			=> E_ALight_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Overridable native event for when play begins for this actor. </para>
		/// </summary>
		public override void BeginPlay()
			=> E_ALight_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Calculates the actor space bounding box of all components in this Actor.  This is slower than GetComponentsBoundingBox(), because the local bounds of the components are not cached -- they are recalculated every time this function is called. </para>
		/// <param name="bNonColliding">Indicates that you want to include non-colliding components in the bounding box </param>
		/// </summary>
		public override FBox CalculateComponentsBoundingBoxInLocalSpace(bool bNonColliding)
			=> E_ALight_CalculateComponentsBoundingBoxInLocalSpace(this, bNonColliding);
		
		
		/// <summary>
		/// <para>Return true if the given Pawn can be "based" on this actor (ie walk on it). </para>
		/// <param name="Pawn">The pawn that wants to be based on this actor </param>
		/// </summary>
		public override bool CanBeBaseForCharacter(APawn Pawn)
			=> E_ALight_CanBeBaseForCharacter(this, Pawn);
		
		public override bool CanBeInCluster()
			=> E_ALight_CanBeInCluster(this);
		
		public override bool CheckDefaultSubobjectsInternal()
			=> E_ALight_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>This will check to see if the Actor is still in the world.  It will check things like </para>
		/// <para>the KillZ, outside world bounds, etc. and handle the situation. </para>
		/// </summary>
		public override bool CheckStillInWorld()
			=> E_ALight_CheckStillInWorld(this);
		
		
		/// <summary>
		/// <para>Do anything needed to clear out cross level references; Called from ULevel::PreSave </para>
		/// </summary>
		public override void ClearCrossLevelReferences()
			=> E_ALight_ClearCrossLevelReferences(this);
		
		
		/// <summary>
		/// <para>Called by DestroyActor(), gives actors a chance to op out of actor destruction </para>
		/// <para>Used by network code to have the net connection timeout/cleanup first </para>
		/// <return>true if DestroyActor() should not continue with actor destruction, false otherwise </return>
		/// </summary>
		public override bool DestroyNetworkActorHandled()
			=> E_ALight_DestroyNetworkActorHandled(this);
		
		
		/// <summary>
		/// <para>Forces this actor to be net relevant if it is not already by default </para>
		/// </summary>
		public override void ForceNetRelevant()
			=> E_ALight_ForceNetRelevant(this);
		
		
		/// <summary>
		/// <para>Force actor to be updated to clients </para>
		/// </summary>
		public override void ForceNetUpdate()
			=> E_ALight_ForceNetUpdate(this);
		
		
		/// <summary>
		/// <para>Fills ReplicatedMovement property </para>
		/// </summary>
		public override void GatherCurrentMovement()
			=> E_ALight_GatherCurrentMovement(this);
		
		
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
			=> E_ALight_GetActorEyesViewPoint(this, OutLocation, OutRotation);
		
		
		/// <summary>
		/// <para>Returns the world space bounding box of all components in this Actor. </para>
		/// <param name="bNonColliding">Indicates that you want to include non-colliding components in the bounding box </param>
		/// </summary>
		public override FBox GetComponentsBoundingBox(bool bNonColliding)
			=> E_ALight_GetComponentsBoundingBox(this, bNonColliding);
		
		
		/// <summary>
		/// <para>Get half-height/radius of a big axis-aligned cylinder around this actors registered colliding components, or all registered components if bNonColliding is false. </para>
		/// </summary>
		public override void GetComponentsBoundingCylinder(float CollisionRadius, float CollisionHalfHeight, bool bNonColliding)
			=> E_ALight_GetComponentsBoundingCylinder(this, CollisionRadius, CollisionHalfHeight, bNonColliding);
		
		
		/// <summary>
		/// <para>Get Collision Response to the Channel that entered for all components </para>
		/// <para>It returns Max of state - i.e. if Component A overlaps, but if Component B blocks, it will return block as response </para>
		/// <para>if Component A ignores, but if Component B overlaps, it will return overlap </para>
		/// <param name="Channel">The channel to change the response of </param>
		/// </summary>
		public override ECollisionResponse GetComponentsCollisionResponseToChannel(ECollisionChannel Channel)
			=> (ECollisionResponse)E_ALight_GetComponentsCollisionResponseToChannel(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Returns this actor's default attachment component for attaching children to </para>
		/// <return>The scene component to be used as parent </return>
		/// </summary>
		public override USceneComponent GetDefaultAttachComponent()
			=> E_ALight_GetDefaultAttachComponent(this);
		
		
		/// <summary>
		/// <para>Returns the human readable string representation of an object. </para>
		/// </summary>
		public override string GetHumanReadableName()
			=> E_ALight_GetHumanReadableName(this);
		
		
		/// <summary>
		/// <para>Returns the most recent time any of this actor's components were rendered </para>
		/// </summary>
		public override float GetLastRenderTime()
			=> E_ALight_GetLastRenderTime(this);
		
		
		/// <summary>
		/// <para>Get the remaining lifespan of this actor. If zero is returned the actor lives forever. </para>
		/// </summary>
		public override float GetLifeSpan()
			=> E_ALight_GetLifeSpan(this);
		
		
		/// <summary>
		/// <return>the owning UPlayer (if any) of this actor. This will be a local player, a net connection, or nullptr. </return>
		/// </summary>
		public override UPlayer GetNetOwningPlayer()
			=> E_ALight_GetNetOwningPlayer(this);
		
		
		/// <summary>
		/// <para>Get axis-aligned cylinder around this actor, used for simple collision checks (ie Pawns reaching a destination). </para>
		/// <para>If IsRootComponentCollisionRegistered() returns true, just returns its bounding cylinder, otherwise falls back to GetComponentsBoundingCylinder. </para>
		/// </summary>
		public override void GetSimpleCollisionCylinder(float CollisionRadius, float CollisionHalfHeight)
			=> E_ALight_GetSimpleCollisionCylinder(this, CollisionRadius, CollisionHalfHeight);
		
		
		/// <summary>
		/// <para>Returns the optimal location to fire weapons at this actor </para>
		/// <param name="RequestedBy">the Actor requesting the target location </param>
		/// </summary>
		public override FVector GetTargetLocation(AActor RequestedBy)
			=> E_ALight_GetTargetLocation(this, RequestedBy);
		
		
		/// <summary>
		/// <para>Returns velocity (in cm/s (Unreal Units/second) of the rootcomponent if it is either using physics or has an associated MovementComponent </para>
		/// </summary>
		public override FVector GetVelocity()
			=> E_ALight_GetVelocity(this);
		
		
		/// <summary>
		/// <para>Getter for the cached world pointer </para>
		/// </summary>
		public override UWorld GetWorld()
			=> E_ALight_GetWorld(this);
		
		
		/// <summary>
		/// <para>Returns true if the actor contains an active camera component </para>
		/// </summary>
		public override bool HasActiveCameraComponent()
			=> E_ALight_HasActiveCameraComponent(this);
		
		
		/// <summary>
		/// <para>Returns true if the actor contains an active locked to HMD camera component </para>
		/// </summary>
		public override bool HasActivePawnControlCameraComponent()
			=> E_ALight_HasActivePawnControlCameraComponent(this);
		
		
		/// <summary>
		/// <para>Does this actor have an owner responsible for replication? (APlayerController typically) </para>
		/// <return>true if this actor can call RPCs or false if no such owner chain exists </return>
		/// </summary>
		protected override bool HasNetOwner()
			=> E_ALight_HasNetOwner(this);
		
		
		/// <summary>
		/// <para>Invalidates anything produced by the last lighting build. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bTranslationOnly)
			=> E_ALight_InvalidateLightingCacheDetailed(this, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Iterates up the Base chain to see whether or not this Actor is attached to the given Actor </para>
		/// <param name="Other">the Actor to test for </param>
		/// <return>true if this Actor is attached on Other Actor </return>
		/// </summary>
		public override bool IsAttachedTo(AActor Other)
			=> E_ALight_IsAttachedTo(this, Other);
		
		
		/// <summary>
		/// <para>Iterates up the Base chain to see whether or not this Actor is based on the given Actor </para>
		/// <param name="Other">the Actor to test for </param>
		/// <return>true if this Actor is based on Other Actor </return>
		/// </summary>
		public override bool IsBasedOnActor(AActor Other)
			=> E_ALight_IsBasedOnActor(this, Other);
		
		
		/// <summary>
		/// <para>Check if owned component should be relevant for navigation </para>
		/// <para>Allows implementing master switch to disable e.g. collision export in projectiles </para>
		/// </summary>
		public override bool IsComponentRelevantForNavigation(UActorComponent Component)
			=> E_ALight_IsComponentRelevantForNavigation(this, Component);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_ALight_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <param name="RealViewer">is the "controlling net object" associated with the client for which network relevancy is being checked (typically player controller) </param>
		/// <param name="ViewTarget">is the Actor being used as the point of view for the RealViewer </param>
		/// <param name="SrcLocation">is the viewing location </param>
		/// <return>bool - true if this actor is network relevant to the client associated with RealViewer </return>
		/// </summary>
		public override bool IsNetRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation)
			=> E_ALight_IsNetRelevantFor(this, RealViewer, ViewTarget, SrcLocation);
		
		public override bool IsReadyForFinishDestroy()
			=> E_ALight_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Check if this actor is the owner when doing relevancy checks for actors marked bOnlyRelevantToOwner </para>
		/// <param name="ReplicatedActor">the actor we're doing a relevancy test on </param>
		/// <param name="ActorOwner">the owner of ReplicatedActor </param>
		/// <param name="ConnectionActor">the controller of the connection that we're doing relevancy checks for </param>
		/// <return>bool - true if this actor should be considered the owner </return>
		/// </summary>
		public override bool IsRelevancyOwnerFor(AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor)
			=> E_ALight_IsRelevancyOwnerFor(this, ReplicatedActor, ActorOwner, ConnectionActor);
		
		
		/// <summary>
		/// <param name="RealViewer">is the "controlling net object" associated with the client for which network relevancy is being checked (typically player controller) </param>
		/// <param name="ViewTarget">is the Actor being used as the point of view for the RealViewer </param>
		/// <param name="SrcLocation">is the viewing location </param>
		/// <return>bool - true if this actor is replay relevant to the client associated with RealViewer </return>
		/// </summary>
		public override bool IsReplayRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared)
			=> E_ALight_IsReplayRelevantFor(this, RealViewer, ViewTarget, SrcLocation, CullDistanceSquared);
		
		
		/// <summary>
		/// <para>@returns true if the root component is registered and has collision enabled. </para>
		/// </summary>
		public override bool IsRootComponentCollisionRegistered()
			=> E_ALight_IsRootComponentCollisionRegistered(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_ALight_IsSupportedForNetworking(this);
		
		
		/// <summary>
		/// <para>Destroy the actor </para>
		/// </summary>
		public override void DestroyActor()
			=> E_ALight_K2_DestroyActor(this);
		
		
		/// <summary>
		/// <para>Called when the lifespan of an actor expires (if he has one). </para>
		/// </summary>
		public override void LifeSpanExpired()
			=> E_ALight_LifeSpanExpired(this);
		
		
		/// <summary>
		/// <para>Called to mark all components as pending kill when the actor is being destroyed </para>
		/// </summary>
		public override void MarkComponentsAsPendingKill()
			=> E_ALight_MarkComponentsAsPendingKill(this);
		
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_ALight_Modify(this, bAlwaysMarkDirty);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved over it with the clickable interface. </para>
		/// </summary>
		public override void NotifyActorBeginCursorOver()
			=> E_ALight_NotifyActorBeginCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when this actor overlaps another actor, for example a player walking into a trigger. </para>
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public override void NotifyActorBeginOverlap(AActor OtherActor)
			=> E_ALight_NotifyActorBeginOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved off of it with the clickable interface. </para>
		/// </summary>
		public override void NotifyActorEndCursorOver()
			=> E_ALight_NotifyActorEndCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when an actor no longer overlaps another actor, and they have separated. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public override void NotifyActorEndOverlap(AActor OtherActor)
			=> E_ALight_NotifyActorEndOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when this actor bumps into a blocking object, or blocks another actor that bumps into it. </para>
		/// <para>This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation. </para>
		/// <para>For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event. </para>
		/// <para>@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled. </para>
		/// <para>@note When receiving a hit from another object's movement (bSelfMoved is false), the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// <para>will be adjusted to indicate force from the other object against this object. </para>
		/// </summary>
		public override void NotifyHit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, FHitResult Hit)
			=> E_ALight_NotifyHit(this, MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
		
		
		/// <summary>
		/// <para>Called when an instance of this class is placed (in editor) or spawned. </para>
		/// <param name="Transform">The transform the actor was constructed at. </param>
		/// </summary>
		public override void OnConstruction(FTransform Transform)
			=> E_ALight_OnConstruction(this, Transform);
		
		public override void OnRep_AttachmentReplication()
			=> E_ALight_OnRep_AttachmentReplication(this);
		
		public override void OnRep_Instigator()
			=> E_ALight_OnRep_Instigator(this);
		
		protected override void OnRep_Owner()
			=> E_ALight_OnRep_Owner(this);
		
		public override void OnRep_ReplicatedMovement()
			=> E_ALight_OnRep_ReplicatedMovement(this);
		
		public override void OnRep_ReplicateMovement()
			=> E_ALight_OnRep_ReplicateMovement(this);
		
		
		/// <summary>
		/// <para>Called on the client when the replication paused value is changed </para>
		/// </summary>
		public override void OnReplicationPausedChanged(bool bIsReplicationPaused)
			=> E_ALight_OnReplicationPausedChanged(this, bIsReplicationPaused);
		
		
		/// <summary>
		/// <para>Called on the actor when a new subobject is dynamically created via replication </para>
		/// </summary>
		public override void OnSubobjectCreatedFromReplication(UObject NewSubobject)
			=> E_ALight_OnSubobjectCreatedFromReplication(this, NewSubobject);
		
		
		/// <summary>
		/// <para>Called on the actor when a subobject is dynamically destroyed via replication </para>
		/// </summary>
		public override void OnSubobjectDestroyFromReplication(UObject Subobject)
			=> E_ALight_OnSubobjectDestroyFromReplication(this, Subobject);
		
		
		/// <summary>
		/// <para>Called when the Actor is outside the hard limit on world bounds </para>
		/// </summary>
		public override void OutsideWorldBounds()
			=> E_ALight_OutsideWorldBounds(this);
		
		
		/// <summary>
		/// <para>Called when an actor is done spawning into the world (from UWorld::SpawnActor). </para>
		/// <para>For actors with a root component, the location and rotation will have already been set. </para>
		/// <para>Takes place after any construction scripts have been called </para>
		/// </summary>
		public override void PostActorCreated()
			=> E_ALight_PostActorCreated(this);
		
		
		/// <summary>
		/// <para>Allow actors to initialize themselves on the C++ side </para>
		/// </summary>
		public override void PostInitializeComponents()
			=> E_ALight_PostInitializeComponents(this);
		
		public override void PostInitProperties()
			=> E_ALight_PostInitProperties(this);
		
		public override void PostLoad()
			=> E_ALight_PostLoad(this);
		
		
		/// <summary>
		/// <para>Always called immediately after spawning and reading in replicated properties </para>
		/// </summary>
		public override void PostNetInit()
			=> E_ALight_PostNetInit(this);
		
		
		/// <summary>
		/// <para>Always called immediately after properties are received from the remote. </para>
		/// </summary>
		public override void PostNetReceive()
			=> E_ALight_PostNetReceive(this);
		
		
		/// <summary>
		/// <para>Update location and rotation from ReplicatedMovement. Not called for simulated physics! </para>
		/// </summary>
		public override void PostNetReceiveLocationAndRotation()
			=> E_ALight_PostNetReceiveLocationAndRotation(this);
		
		
		/// <summary>
		/// <para>Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity() </para>
		/// </summary>
		public override void PostNetReceivePhysicState()
			=> E_ALight_PostNetReceivePhysicState(this);
		
		
		/// <summary>
		/// <para>Update velocity - typically from ReplicatedMovement, not called for simulated physics! </para>
		/// </summary>
		public override void PostNetReceiveVelocity(FVector NewVelocity)
			=> E_ALight_PostNetReceiveVelocity(this, NewVelocity);
		
		
		/// <summary>
		/// <para>Called after all the components in the Components array are registered </para>
		/// </summary>
		public override void PostRegisterAllComponents()
			=> E_ALight_PostRegisterAllComponents(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_ALight_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Called after all currently registered components are cleared </para>
		/// </summary>
		public override void PostUnregisterAllComponents()
			=> E_ALight_PostUnregisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Called immediately before gameplay begins. </para>
		/// </summary>
		public override void PreInitializeComponents()
			=> E_ALight_PreInitializeComponents(this);
		
		
		/// <summary>
		/// <para>Always called immediately before properties are received from the remote. </para>
		/// </summary>
		public override void PreNetReceive()
			=> E_ALight_PreNetReceive(this);
		
		
		/// <summary>
		/// <para>Calls PrestreamTextures() for all the actor's meshcomponents. </para>
		/// <param name="Seconds">Number of seconds to force all mip-levels to be resident </param>
		/// <param name="bEnableStreaming">Whether to start (true) or stop (false) streaming </param>
		/// <param name="CinematicTextureGroups">Bitfield indicating which texture groups that use extra high-resolution mips </param>
		/// </summary>
		public override void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups)
			=> E_ALight_PrestreamTextures(this, Seconds, bEnableStreaming, CinematicTextureGroups);
		
		
		/// <summary>
		/// <para>Virtual call chain to register all tick functions for the actor class hierarchy </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		protected override void RegisterActorTickFunctions(bool bRegister)
			=> E_ALight_RegisterActorTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Ensure that all the components in the Components array are registered </para>
		/// </summary>
		public override void RegisterAllComponents()
			=> E_ALight_RegisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_ALight_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_ALight_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Will reregister all components on this actor. Does a lot of work - should only really be used in editor, generally use UpdateComponentTransforms or MarkComponentsRenderStateDirty. </para>
		/// </summary>
		public override void ReregisterAllComponents()
			=> E_ALight_ReregisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Rerun construction scripts, destroying all autogenerated components; will attempt to preserve the root component location. </para>
		/// </summary>
		public override void RerunConstructionScripts()
			=> E_ALight_RerunConstructionScripts(this);
		
		
		/// <summary>
		/// <para>Reset actor to initial state - used when restarting level without reloading. </para>
		/// </summary>
		public override void Reset()
			=> E_ALight_Reset(this);
		
		
		/// <summary>
		/// <para>Sets the actor to be hidden in the game </para>
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components </param>
		/// </summary>
		public override void SetActorHiddenInGame(bool bNewHidden)
			=> E_ALight_SetActorHiddenInGame(this, bNewHidden);
		
		
		/// <summary>
		/// <para>Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed. </para>
		/// </summary>
		public override void SetLifeSpan(float InLifespan)
			=> E_ALight_SetLifeSpan(this, InLifespan);
		
		
		/// <summary>
		/// <para>Set the owner of this Actor, used primarily for network replication. </para>
		/// <param name="NewOwner">The Actor whom takes over ownership of this Actor </param>
		/// </summary>
		public override void SetOwner(AActor NewOwner)
			=> E_ALight_SetOwner(this, NewOwner);
		
		
		/// <summary>
		/// <para>Set whether this actor's movement replicates to network clients. </para>
		/// <param name="bInReplicateMovement">Whether this Actor's movement replicates to clients. </param>
		/// </summary>
		public override void SetReplicateMovement(bool bInReplicateMovement)
			=> E_ALight_SetReplicateMovement(this, bInReplicateMovement);
		
		
		/// <summary>
		/// <para>If true, actor is ticked even if TickType==LEVELTICK_ViewportsOnly </para>
		/// </summary>
		public override bool ShouldTickIfViewportsOnly()
			=> E_ALight_ShouldTickIfViewportsOnly(this);
		
		
		/// <summary>
		/// <para>Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true. </para>
		/// </summary>
		public override void TearOff()
			=> E_ALight_TearOff(this);
		
		
		/// <summary>
		/// <para>Called from TeleportTo() when teleport succeeds </para>
		/// </summary>
		public override void TeleportSucceeded(bool bIsATest)
			=> E_ALight_TeleportSucceeded(this, bIsATest);
		
		
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
			=> E_ALight_TeleportTo(this, DestLocation, DestRotation, bIsATest, bNoCheck);
		
		
		/// <summary>
		/// <para>Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame. </para>
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// <param name="DeltaSeconds">Game time elapsed during last frame modified by the time dilation </param>
		/// </summary>
		public override void Tick(float DeltaSeconds)
			=> E_ALight_Tick(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>ticks the actor </para>
		/// <param name="DeltaTime">The time slice of this tick </param>
		/// <param name="TickType">The type of tick that is happening </param>
		/// <param name="ThisTickFunction">The tick function that is firing, useful for getting the completion handle </param>
		/// </summary>
		public override void TickActor(float DeltaTime, ELevelTick TickType, FActorTickFunction ThisTickFunction)
			=> E_ALight_TickActor(this, DeltaTime, (byte)TickType, ThisTickFunction);
		
		
		/// <summary>
		/// <para>Networking - called on client when actor is torn off (bTearOff==true), meaning it's no longer replicated to clients. </para>
		/// <para>@see bTearOff </para>
		/// </summary>
		public override void TornOff()
			=> E_ALight_TornOff(this);
		
		
		/// <summary>
		/// <para>Unregister all currently registered components </para>
		/// </summary>
		public override void UnregisterAllComponents(bool bForReregister)
			=> E_ALight_UnregisterAllComponents(this, bForReregister);
		
		
		/// <summary>
		/// <para>Used by the net connection to determine if a net owning actor should switch to using the shortened timeout value </para>
		/// <return>true to switch from InitialConnectTimeout to ConnectionTimeout values on the net driver </return>
		/// </summary>
		public override bool UseShortConnectTimeout()
			=> E_ALight_UseShortConnectTimeout(this);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_ALight_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E_ALight_FinishDestroy(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_ALight_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_ALight_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_ALight_IsAsset(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine if the object is forced to be editor only or not </para>
		/// <return>true if this object should never be loaded outside the editor </return>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_ALight_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_ALight_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_ALight_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_ALight_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_ALight_IsSafeForRootSet(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_ALight_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on clients </para>
		/// <return>true if this object should be loaded on clients </return>
		/// </summary>
		public override bool NeedsLoadForClient()
			=> E_ALight_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will still get loaded if NeedsLoadForServer/Client are true </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_ALight_NeedsLoadForEditorGame(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on servers </para>
		/// <return>true if this object should be loaded on servers </return>
		/// </summary>
		public override bool NeedsLoadForServer()
			=> E_ALight_NeedsLoadForServer(this);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_ALight_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_ALight_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_ALight_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies()
			=> E_ALight_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_ALight_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_ALight_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_ALight_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_ALight_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_ALight_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_ALight_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_ALight_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(ALight Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ALight(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ALight>(PtrDesc);
		}}}
