using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:108

namespace UnrealEngine
{
	public  partial class UAudioComponent : USceneComponent
	{
		public UAudioComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UAudioComponent(UObject Parent = null, string Name = "AudioComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAudioComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAudioComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_AutoAttachLocationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachLocationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_AutoAttachRotationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachRotationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_AutoAttachScaleRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachScaleRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UAudioComponent_AutoAttachSocketName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachSocketName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bAutoManageAttachment_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bAutoManageAttachment_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_Activate(IntPtr Self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_Deactivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAudioComponent_GetAudioComponentUserID(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAudioComponent_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsReadyForOwnerToAutoDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnRegister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnUnregister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnUpdateTransform(IntPtr Self, byte UpdateTransformFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PlayInternal(IntPtr Self, float StartTime, float FadeInDuration, float FadeVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetSoundParameter(IntPtr Self, IntPtr Param);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_CalcBoundingCylinder(IntPtr Self, float CylinderRadius, float CylinderHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_CanAttachAsChild(IntPtr Self, IntPtr ChildComponent, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_DestroyComponent(IntPtr Self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_DetachFromComponent(IntPtr Self, IntPtr DetachmentRules);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_DetachFromParent(IntPtr Self, bool bMaintainWorldPosition, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_DoesSocketExist(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UAudioComponent_GetCollisionObjectType(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UAudioComponent_GetCollisionResponseToChannel(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAudioComponent_GetComponentVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAudioComponent_GetSocketLocation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAudioComponent_GetSocketQuaternion(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAudioComponent_GetSocketRotation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAudioComponent_GetSocketTransform(IntPtr Self, string InSocketName, byte TransformSpace);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_HasAnySockets(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsAnySimulatingPhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsPrecomputedLightingValid(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsSimulatingPhysics(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsVisible(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsVisibleInEditor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsWorldGeometry(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_MoveComponentImpl(IntPtr Self, IntPtr Delta, IntPtr NewRotation, bool bSweep, IntPtr Hit, byte MoveFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnAttachmentChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnChildAttached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnChildDetached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnComponentDestroyed(IntPtr Self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnHiddenInGameChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnVisibilityChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PropagateLightingScenarioChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetRelativeScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_ShouldCollideWhenPlacing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_ShouldCreateRenderState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_UpdatePhysicsVolume(IntPtr Self, bool bTriggerNotifiers);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_CreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_DestroyRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_GetComponentClassCanReplicate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAudioComponent_GetReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_HasValidPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_InitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_InvalidateLightingCacheDetailed(IntPtr Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsNavigationRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnActorEnableCollisionChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnComponentCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnDestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_RegisterComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_RequiresGameThreadEndOfFrameRecreate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_RequiresGameThreadEndOfFrameUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SendRenderDynamicData_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SendRenderTransform_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetActive(IntPtr Self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetAutoActivate(IntPtr Self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetComponentTickEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetComponentTickEnabledAsync(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_ShouldActivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_ShouldCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_ToggleActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_UninitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAudioComponent_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAudioComponent_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Options for how we handle our location when we attach to the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment, EAttachmentRule </para>
		/// </summary>
		public EAttachmentRule AutoAttachLocationRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachLocationRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachLocationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Options for how we handle our rotation when we attach to the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment, EAttachmentRule </para>
		/// </summary>
		public EAttachmentRule AutoAttachRotationRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachRotationRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachRotationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Options for how we handle our scale when we attach to the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment, EAttachmentRule </para>
		/// </summary>
		public EAttachmentRule AutoAttachScaleRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachScaleRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachScaleRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment </para>
		/// </summary>
		public string AutoAttachSocketName
		{
			get => E_PROP_UAudioComponent_AutoAttachSocketName_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachSocketName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>True if we should automatically attach to AutoAttachParent when Played, and detach from our parent when playback is completed. </para>
		/// <para>This overrides any current attachment that may be present at the time of activation (deferring initial attachment until activation, if AutoAttachParent is null). </para>
		/// <para>If enabled, this AudioComponent's WorldLocation will no longer be reliable when not currently playing audio, and any attach children will also be detached/attached along with it. </para>
		/// <para>When enabled, detachment occurs regardless of whether AutoAttachParent is assigned, and the relative transform from the time of activation is restored. </para>
		/// <para>This also disables attachment on dedicated servers, where we don't actually activate even if bAutoActivate is true. </para>
		/// <para>@see AutoAttachParent, AutoAttachSocketName, AutoAttachLocationType </para>
		/// </summary>
		public byte bAutoManageAttachment
		{
			get => E_PROP_UAudioComponent_bAutoManageAttachment_GET(NativePointer);
			set => E_PROP_UAudioComponent_bAutoManageAttachment_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public override void Activate(bool bReset)
			=> E_UAudioComponent_Activate(this, bReset);
		
		public override void BeginDestroy()
			=> E_UAudioComponent_BeginDestroy(this);
		
		public override void Deactivate()
			=> E_UAudioComponent_Deactivate(this);
		
		public string GetAudioComponentUserID()
			=> E_UAudioComponent_GetAudioComponentUserID(this);
		
		public override string GetDetailedInfoInternal()
			=> E_UAudioComponent_GetDetailedInfoInternal(this);
		
		public override bool IsReadyForOwnerToAutoDestroy()
			=> E_UAudioComponent_IsReadyForOwnerToAutoDestroy(this);
		
		public override void OnRegister()
			=> E_UAudioComponent_OnRegister(this);
		
		public override void OnUnregister()
			=> E_UAudioComponent_OnUnregister(this);
		
		public override void OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
			=> E_UAudioComponent_OnUpdateTransform(this, (byte)UpdateTransformFlags, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Utility function called by Play and FadeIn to start a sound playing. </para>
		/// </summary>
		protected void PlayInternal(float StartTime, float FadeInDuration, float FadeVolumeLevel)
			=> E_UAudioComponent_PlayInternal(this, StartTime, FadeInDuration, FadeVolumeLevel);
		
		public override void PostLoad()
			=> E_UAudioComponent_PostLoad(this);
		
		
		/// <summary>
		/// <para>Sets the sound instance parameter. </para>
		/// </summary>
		public void SetSoundParameter(FAudioComponentParam Param)
			=> E_UAudioComponent_SetSoundParameter(this, Param);
		
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_UAudioComponent_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		
		/// <summary>
		/// <para>Calculate the axis-aligned bounding cylinder of the component (radius in X-Y, half-height along Z axis). </para>
		/// <para>Default behavior is just a cylinder around the box of the cached BoxSphereBounds. </para>
		/// </summary>
		public override void CalcBoundingCylinder(float CylinderRadius, float CylinderHalfHeight)
			=> E_UAudioComponent_CalcBoundingCylinder(this, CylinderRadius, CylinderHalfHeight);
		
		
		/// <summary>
		/// <para>Called to see if it's possible to attach another scene component as a child. </para>
		/// <para>Note: This can be called on template component as well! </para>
		/// </summary>
		public override bool CanAttachAsChild(USceneComponent ChildComponent, string SocketName)
			=> E_UAudioComponent_CanAttachAsChild(this, ChildComponent, SocketName);
		
		public override void DestroyComponent(bool bPromoteChildren)
			=> E_UAudioComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="DetachmentRules">How to handle transforms & modification when detaching. </param>
		/// </summary>
		public override void DetachFromComponent(FDetachmentTransformRules DetachmentRules)
			=> E_UAudioComponent_DetachFromComponent(this, DetachmentRules);
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="bMaintainWorldPosition">If true, update the relative location of the component to keep its world position the same </param>
		/// <param name="bCallModify">If true, call Modify() on the component and the current attach parent component </param>
		/// </summary>
		public override void DetachFromParentDeprecated(bool bMaintainWorldPosition, bool bCallModify)
			=> E_UAudioComponent_DetachFromParent(this, bMaintainWorldPosition, bCallModify);
		
		
		/// <summary>
		/// <para>return true if socket with the given name exists </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>true if the socket with the given name exists. Otherwise, return false </return>
		/// </summary>
		public override bool DoesSocketExist(string InSocketName)
			=> E_UAudioComponent_DoesSocketExist(this, InSocketName);
		
		
		/// <summary>
		/// <para>Returns the channel that this component belongs to when it moves. </para>
		/// </summary>
		public override ECollisionChannel GetCollisionObjectType()
			=> (ECollisionChannel)E_UAudioComponent_GetCollisionObjectType(this);
		
		
		/// <summary>
		/// <para>Returns the response that this component has to a specific collision channel. </para>
		/// </summary>
		public override ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel)
			=> (ECollisionResponse)E_UAudioComponent_GetCollisionResponseToChannel(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Get velocity of the component: either ComponentVelocity, or the velocity of the physics body if simulating physics. </para>
		/// <return>Velocity of the component </return>
		/// </summary>
		public override FVector GetComponentVelocity()
			=> E_UAudioComponent_GetComponentVelocity(this);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone location. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FVector GetSocketLocation(string InSocketName)
			=> E_UAudioComponent_GetSocketLocation(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone FQuat rotation. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FQuat GetSocketQuaternion(string InSocketName)
			=> E_UAudioComponent_GetSocketQuaternion(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone  FRotator rotation. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FRotator GetSocketRotation(string InSocketName)
			=> E_UAudioComponent_GetSocketRotation(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket transform. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FTransform GetSocketTransform(string InSocketName, ERelativeTransformSpace TransformSpace)
			=> E_UAudioComponent_GetSocketTransform(this, InSocketName, (byte)TransformSpace);
		
		
		/// <summary>
		/// <para>Returns true if this component has any sockets </para>
		/// </summary>
		public override bool HasAnySockets()
			=> E_UAudioComponent_HasAnySockets(this);
		
		
		/// <summary>
		/// <para>Returns whether the specified body is currently using physics simulation </para>
		/// </summary>
		public override bool IsAnySimulatingPhysics()
			=> E_UAudioComponent_IsAnySimulatingPhysics(this);
		
		public override bool IsPrecomputedLightingValid()
			=> E_UAudioComponent_IsPrecomputedLightingValid(this);
		
		
		/// <summary>
		/// <para>Returns whether the specified body is currently using physics simulation </para>
		/// </summary>
		public override bool IsSimulatingPhysics(string BoneName)
			=> E_UAudioComponent_IsSimulatingPhysics(this, BoneName);
		
		
		/// <summary>
		/// <para>Is this component visible or not in game </para>
		/// <return>true if visible </return>
		/// </summary>
		public override bool IsVisible()
			=> E_UAudioComponent_IsVisible(this);
		
		
		/// <summary>
		/// <para>Return true if visible in editor </para>
		/// </summary>
		public override bool IsVisibleInEditor()
			=> E_UAudioComponent_IsVisibleInEditor(this);
		
		
		/// <summary>
		/// <para>Is this component considered 'world' geometry </para>
		/// </summary>
		public override bool IsWorldGeometry()
			=> E_UAudioComponent_IsWorldGeometry(this);
		
		protected override bool MoveComponentImpl(FVector Delta, FQuat NewRotation, bool bSweep, FHitResult Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
			=> E_UAudioComponent_MoveComponentImpl(this, Delta, NewRotation, bSweep, Hit, (byte)MoveFlags, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Called when AttachParent changes, to allow the scene to update its attachment state. </para>
		/// </summary>
		public override void OnAttachmentChanged()
			=> E_UAudioComponent_OnAttachmentChanged(this);
		
		
		/// <summary>
		/// <para>Called after a child scene component is attached to this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildAttached(USceneComponent ChildComponent)
			=> E_UAudioComponent_OnChildAttached(this, ChildComponent);
		
		
		/// <summary>
		/// <para>Called after a child scene component is detached from this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildDetached(USceneComponent ChildComponent)
			=> E_UAudioComponent_OnChildDetached(this, ChildComponent);
		
		public override void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E_UAudioComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the hidden in game value of the component. </para>
		/// </summary>
		protected override void OnHiddenInGameChanged()
			=> E_UAudioComponent_OnHiddenInGameChanged(this);
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the visibility of the component. </para>
		/// </summary>
		protected override void OnVisibilityChanged()
			=> E_UAudioComponent_OnVisibilityChanged(this);
		
		public override void PostNetReceive()
			=> E_UAudioComponent_PostNetReceive(this);
		
		public override void PostRepNotifies()
			=> E_UAudioComponent_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Stack of current movement scopes. </para>
		/// </summary>
		public override void PreNetReceive()
			=> E_UAudioComponent_PreNetReceive(this);
		
		public override void PropagateLightingScenarioChange()
			=> E_UAudioComponent_PropagateLightingScenarioChange(this);
		
		
		/// <summary>
		/// <para>Set the non-uniform scale of the component relative to its parent </para>
		/// </summary>
		public override void SetRelativeScale3D(FVector NewScale3D)
			=> E_UAudioComponent_SetRelativeScale3D(this, NewScale3D);
		
		
		/// <summary>
		/// <para>If true, bounds should be used when placing component/actor in level. Does not affect spawning. </para>
		/// </summary>
		public override bool ShouldCollideWhenPlacing()
			=> E_UAudioComponent_ShouldCollideWhenPlacing(this);
		
		
		/// <summary>
		/// <para>Return true if CreateRenderState() should be called </para>
		/// </summary>
		public override bool ShouldCreateRenderState()
			=> E_UAudioComponent_ShouldCreateRenderState(this);
		
		
		/// <summary>
		/// <para>Updates the PhysicsVolume of this SceneComponent, if bShouldUpdatePhysicsVolume is true. </para>
		/// <param name="bTriggerNotifiers">if true, send zone/volume change events </param>
		/// </summary>
		public override void UpdatePhysicsVolume(bool bTriggerNotifiers)
			=> E_UAudioComponent_UpdatePhysicsVolume(this, bTriggerNotifiers);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UAudioComponent_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UAudioComponent_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>BeginsPlay for the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// <para>Actor/Component gets BeginPlay. </para>
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public override void BeginPlay()
			=> E_UAudioComponent_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Used to create any rendering thread information for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void CreateRenderState_Concurrent()
			=> E_UAudioComponent_CreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void DestroyRenderState_Concurrent()
			=> E_UAudioComponent_DestroyRenderState_Concurrent(this);
		
		public override bool GetComponentClassCanReplicate()
			=> E_UAudioComponent_GetComponentClassCanReplicate(this);
		
		
		/// <summary>
		/// <para>Returns a readable name for this component, including the asset name if applicable </para>
		/// <para>By default this appends a space plus AdditionalStatObject() </para>
		/// </summary>
		public override string GetReadableName()
			=> E_UAudioComponent_GetReadableName(this);
		
		
		/// <summary>
		/// <para>Used to check that DestroyPhysicsState() is working correctly </para>
		/// </summary>
		public override bool HasValidPhysicsState()
			=> E_UAudioComponent_HasValidPhysicsState(this);
		
		
		/// <summary>
		/// <para>Initializes the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components in the level will be Initialized on load before any Actor/Component gets BeginPlay </para>
		/// <para>Requires component to be registered, and bWantsInitializeComponent to be true. </para>
		/// </summary>
		public override void InitializeComponent()
			=> E_UAudioComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E_UAudioComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns whether the component is active or not </para>
		/// <return>The active state of the component. </return>
		/// </summary>
		public override bool IsActive()
			=> E_UAudioComponent_IsActive(this);
		
		
		/// <summary>
		/// <para>Returns whether this component is an editor-only object or not </para>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_UAudioComponent_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_UAudioComponent_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>override to supply actual logic </para>
		/// </summary>
		public override bool IsNavigationRelevant()
			=> E_UAudioComponent_IsNavigationRelevant(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_UAudioComponent_IsSupportedForNetworking(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_UAudioComponent_MarkAsEditorOnlySubobject(this);
		
		public override bool NeedsLoadForClient()
			=> E_UAudioComponent_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_UAudioComponent_NeedsLoadForEditorGame(this);
		
		public override bool NeedsLoadForServer()
			=> E_UAudioComponent_NeedsLoadForServer(this);
		
		
		/// <summary>
		/// <para>Called on each component when the Actor's bEnableCollisionChanged flag changes </para>
		/// </summary>
		public override void OnActorEnableCollisionChanged()
			=> E_UAudioComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public override void OnComponentCreated()
			=> E_UAudioComponent_OnComponentCreated(this);
		
		
		/// <summary>
		/// <para>Used to create any physics engine information for this component </para>
		/// </summary>
		protected override void OnCreatePhysicsState()
			=> E_UAudioComponent_OnCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down and physics engine structure for this component </para>
		/// </summary>
		protected override void OnDestroyPhysicsState()
			=> E_UAudioComponent_OnDestroyPhysicsState(this);
		
		public override void PostInitProperties()
			=> E_UAudioComponent_PostInitProperties(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_UAudioComponent_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Virtual call chain to register all tick functions </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		public override void RegisterComponentTickFunctions(bool bRegister)
			=> E_UAudioComponent_RegisterComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UAudioComponent_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UAudioComponent_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame recreates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameRecreate()
			=> E_UAudioComponent_RequiresGameThreadEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame updates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameUpdates()
			=> E_UAudioComponent_RequiresGameThreadEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected override void SendRenderDynamicData_Concurrent()
			=> E_UAudioComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the rendering thread </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void SendRenderTransform_Concurrent()
			=> E_UAudioComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// </summary>
		public override void SetActive(bool bNewActive, bool bReset)
			=> E_UAudioComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public override void SetAutoActivate(bool bNewAutoActivate)
			=> E_UAudioComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabled(bool bEnabled)
			=> E_UAudioComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabledAsync(bool bEnabled)
			=> E_UAudioComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// <para>"Trigger" related function. Return true if it should activate </para>
		/// </summary>
		protected override bool ShouldActivate()
			=> E_UAudioComponent_ShouldActivate(this);
		
		
		/// <summary>
		/// <para>Return true if CreatePhysicsState() should be called. </para>
		/// <para>Ideally CreatePhysicsState() should always succeed if this returns true, but this isn't currently the case </para>
		/// </summary>
		public override bool ShouldCreatePhysicsState()
			=> E_UAudioComponent_ShouldCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public override void ToggleActive()
			=> E_UAudioComponent_ToggleActive(this);
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent()
			=> E_UAudioComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_UAudioComponent_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public override bool CheckDefaultSubobjectsInternal()
			=> E_UAudioComponent_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E_UAudioComponent_FinishDestroy(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_UAudioComponent_GetDesc(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_UAudioComponent_IsAsset(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_UAudioComponent_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_UAudioComponent_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_UAudioComponent_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the </para>
		/// <para>potentially asynchronous object cleanup. </para>
		/// <return>True if the object's asynchronous cleanup has completed and it is ready for FinishDestroy to be called. </return>
		/// </summary>
		public override bool IsReadyForFinishDestroy()
			=> E_UAudioComponent_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_UAudioComponent_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_UAudioComponent_Modify(this, bAlwaysMarkDirty);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_UAudioComponent_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_UAudioComponent_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_UAudioComponent_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UAudioComponent_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_UAudioComponent_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_UAudioComponent_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_UAudioComponent_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_UAudioComponent_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public override bool CanBeInCluster()
			=> E_UAudioComponent_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_UAudioComponent_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_UAudioComponent_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(UAudioComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UAudioComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAudioComponent>(PtrDesc);
		}}}
