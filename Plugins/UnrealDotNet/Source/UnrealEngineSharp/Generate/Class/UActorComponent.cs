// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ActorComponent.h:86

namespace UnrealEngine
{
	public  partial class UActorComponent : UObject
	{
		public UActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UActorComponent(UObject Parent = null, string Name = "ActorComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UActorComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bAllowConcurrentTick_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bAllowConcurrentTick_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bAutoActivate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bAutoActivate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bAutoRegister_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bAutoRegister_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bEditableWhenInherited_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bEditableWhenInherited_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bIsActive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bIsActive_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bIsEditorOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bIsEditorOnly_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bNavigationRelevant_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bNavigationRelevant_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bNeverNeedsRenderUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bNeverNeedsRenderUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bTickInEditor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bTickInEditor_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bWantsBeginPlay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bWantsBeginPlay_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bWantsInitializeComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bWantsInitializeComponent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UActorComponent_OnComponentActivated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UActorComponent_OnComponentActivated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UActorComponent_OnComponentDeactivated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UActorComponent_OnComponentDeactivated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UActorComponent_PrimaryComponentTick_GET(IntPtr Ptr);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UActorComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_Activate(IntPtr self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UActorComponent_AdditionalStatObject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_AddTickPrerequisiteActor(IntPtr self, IntPtr prerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_AddTickPrerequisiteComponent(IntPtr self, IntPtr prerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_AllowReregistration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ApplyWorldOffset(IntPtr self, IntPtr inOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_BeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_CanEverAffectNavigation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ClearNeedEndOfFrameUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ComponentHasTag(IntPtr self, string tag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ComponentIsInPersistentLevel(IntPtr self, bool bIncludeLevelStreamingPersistent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_CreatePhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_CreateRenderState_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_Deactivate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DestroyComponent(IntPtr self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DestroyPhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DestroyRenderState_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DetermineUCSModifiedProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DoDeferredRenderUpdates_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_GetComponentClassCanReplicate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UActorComponent_GetComponentTickInterval(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_GetIsReplicated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UActorComponent_GetNetMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UActorComponent_GetOwner(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UActorComponent_GetOwnerRole(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UActorComponent_GetReadableName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_HandleCanEverAffectNavigationChange(IntPtr self, bool bForceUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_HasBeenCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_HasBeenInitialized(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_HasBegunPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_HasValidPhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_InitializeComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_InvalidateLightingCache(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_InvalidateLightingCacheDetailed(IntPtr self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsBeingDestroyed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsComponentTickEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsCreatedByConstructionScript(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsEditableWhenInherited(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsNavigationRelevant(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsNetMode(IntPtr self, byte mode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsNetSimulating(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsNetStartupComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsOwnerRunningUserConstructionScript(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsOwnerSelected(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsPhysicsStateCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsReadyForOwnerToAutoDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsRegistered(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsRenderStateCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsRenderStateDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsRenderTransformDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_K2_DestroyComponent(IntPtr self, IntPtr @object);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkForNeededEndOfFrameRecreate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkForNeededEndOfFrameUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkRenderDynamicDataDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkRenderStateDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkRenderTransformDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnActorEnableCollisionChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnComponentCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnComponentDestroyed(IntPtr self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnCreatePhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnDestroyPhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnRegister(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnRep_IsActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnUnregister(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ReceiveBeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ReceiveTick(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RecreatePhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RecreateRenderState_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RegisterAllComponentTickFunctions(IntPtr self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RegisterComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RegisterComponentTickFunctions(IntPtr self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RemoveTickPrerequisiteActor(IntPtr self, IntPtr prerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RemoveTickPrerequisiteComponent(IntPtr self, IntPtr prerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_RequiresGameThreadEndOfFrameRecreate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_RequiresGameThreadEndOfFrameUpdates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ReregisterComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SendRenderDynamicData_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SendRenderTransform_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetActive(IntPtr self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetAutoActivate(IntPtr self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetCanEverAffectNavigation(IntPtr self, bool bRelevant);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetComponentTickEnabled(IntPtr self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetComponentTickEnabledAsync(IntPtr self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetComponentTickInterval(IntPtr self, float tickInterval);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetIsNetStartupComponent(IntPtr self, bool bInIsNetStartupComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetIsReplicated(IntPtr self, bool shouldReplicate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetNetAddressable(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetTickableWhenPaused(IntPtr self, bool bTickableWhenPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetTickGroup(IntPtr self, byte newTickGroup);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ShouldActivate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ShouldCreatePhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ShouldCreateRenderState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ToggleActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_UninitializeComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_UnregisterComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_UpdateComponentToWorld(IntPtr self, byte updateTransformFlags, byte teleport);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Can this component be destroyed (via K2_DestroyComponent) by any parent </para>
		/// </summary>
		public byte bAllowAnyoneToDestroyMe
		{
			get => E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_GET(NativePointer);
			set => E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Can we tick this concurrently on other threads? </para>
		/// </summary>
		public byte bAllowConcurrentTick
		{
			get => E_PROP_UActorComponent_bAllowConcurrentTick_GET(NativePointer);
			set => E_PROP_UActorComponent_bAllowConcurrentTick_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether the component is activated at creation or must be explicitly activated. </para>
		/// </summary>
		public byte bAutoActivate
		{
			get => E_PROP_UActorComponent_bAutoActivate_GET(NativePointer);
			set => E_PROP_UActorComponent_bAutoActivate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Does this component automatically register with its owner </para>
		/// </summary>
		public byte bAutoRegister
		{
			get => E_PROP_UActorComponent_bAutoRegister_GET(NativePointer);
			set => E_PROP_UActorComponent_bAutoRegister_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>True if this component can be modified when it was inherited from a parent actor class </para>
		/// </summary>
		public byte bEditableWhenInherited
		{
			get => E_PROP_UActorComponent_bEditableWhenInherited_GET(NativePointer);
			set => E_PROP_UActorComponent_bEditableWhenInherited_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether the component is currently active. </para>
		/// </summary>
		public byte bIsActive
		{
			get => E_PROP_UActorComponent_bIsActive_GET(NativePointer);
			set => E_PROP_UActorComponent_bIsActive_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, the component will be excluded from non-editor builds </para>
		/// </summary>
		public byte bIsEditorOnly
		{
			get => E_PROP_UActorComponent_bIsEditorOnly_GET(NativePointer);
			set => E_PROP_UActorComponent_bIsEditorOnly_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Cached navigation relevancy flag for collision updates </para>
		/// </summary>
		public byte bNavigationRelevant
		{
			get => E_PROP_UActorComponent_bNavigationRelevant_GET(NativePointer);
			set => E_PROP_UActorComponent_bNavigationRelevant_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this component never needs a render update. </para>
		/// </summary>
		public byte bNeverNeedsRenderUpdate
		{
			get => E_PROP_UActorComponent_bNeverNeedsRenderUpdate_GET(NativePointer);
			set => E_PROP_UActorComponent_bNeverNeedsRenderUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Should this component be ticked in the editor </para>
		/// </summary>
		public byte bTickInEditor
		{
			get => E_PROP_UActorComponent_bTickInEditor_GET(NativePointer);
			set => E_PROP_UActorComponent_bTickInEditor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, we call the virtual BeginPlay </para>
		/// </summary>
		public byte bWantsBeginPlay
		{
			get => E_PROP_UActorComponent_bWantsBeginPlay_GET(NativePointer);
			set => E_PROP_UActorComponent_bWantsBeginPlay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, we call the virtual InitializeComponent </para>
		/// </summary>
		public byte bWantsInitializeComponent
		{
			get => E_PROP_UActorComponent_bWantsInitializeComponent_GET(NativePointer);
			set => E_PROP_UActorComponent_bWantsInitializeComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Main tick function for the Component </para>
		/// </summary>
		public FActorComponentTickFunction PrimaryComponentTick
		{
			get => E_PROP_UActorComponent_PrimaryComponentTick_GET(NativePointer);
		}

		#endregion
		
		#region Events
		
		/// <summary>
		/// <para>Called when the component has been activated, with parameter indicating if it was from a reset </para>
		/// </summary>
		public event FActorComponentActivatedSignature OnComponentActivated
		{
			add
			{
				E_EVENT_ADD_UActorComponent_OnComponentActivated(NativePointer);
				_Event_OnComponentActivated += value;
			}

			remove
			{
				E_EVENT_DEL_UActorComponent_OnComponentActivated(NativePointer);
				_Event_OnComponentActivated -= value;
			}

		}

		private event FActorComponentActivatedSignature _Event_OnComponentActivated;
		
		internal void InvokeEvent_OnComponentActivated(ObjectPointerDescription component, bool bReset)
		{
			_Event_OnComponentActivated?.Invoke(component, bReset);
		}

		
		/// <summary>
		/// <para>Called when the component has been deactivated </para>
		/// </summary>
		public event FActorComponentDeactivateSignature OnComponentDeactivated
		{
			add
			{
				E_EVENT_ADD_UActorComponent_OnComponentDeactivated(NativePointer);
				_Event_OnComponentDeactivated += value;
			}

			remove
			{
				E_EVENT_DEL_UActorComponent_OnComponentDeactivated(NativePointer);
				_Event_OnComponentDeactivated -= value;
			}

		}

		private event FActorComponentDeactivateSignature _Event_OnComponentDeactivated;
		
		internal void InvokeEvent_OnComponentDeactivated(ObjectPointerDescription component)
		{
			_Event_OnComponentDeactivated?.Invoke(component);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Activates the SceneComponent, should be overridden by native child classes. </para>
		/// <param name="bReset">Whether the activation should happen even if ShouldActivate returns false. </param>
		/// </summary>
		public virtual void Activate(bool bReset)
			=> E_UActorComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// <para>Give a readable name for this component, including asset name if applicable </para>
		/// </summary>
		public virtual UObject AdditionalStatObject()
			=> E_UActorComponent_AdditionalStatObject(this);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public virtual void AddTickPrerequisiteActor(AActor prerequisiteActor)
			=> E_UActorComponent_AddTickPrerequisiteActor(this, prerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public virtual void AddTickPrerequisiteComponent(UActorComponent prerequisiteComponent)
			=> E_UActorComponent_AddTickPrerequisiteComponent(this, prerequisiteComponent);
		
		
		/// <summary>
		/// <para>Check whether the component class allows reregistration during ReregisterAllComponents </para>
		/// </summary>
		public bool AllowReregistration()
			=> E_UActorComponent_AllowReregistration(this);
		
		
		/// <summary>
		/// <para>Called by owner actor on position shifting </para>
		/// <para>Component should update all relevant data structures to reflect new actor location </para>
		/// <param name="InWorldOffset">Offset vector the actor shifted by </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public virtual void ApplyWorldOffset(FVector inOffset, bool bWorldShift)
			=> E_UActorComponent_ApplyWorldOffset(this, inOffset, bWorldShift);
		
		
		/// <summary>
		/// <para>BeginsPlay for the component.  Occurs at level startup or actor spawn. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// <para>Actor/Component gets BeginPlay. </para>
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public virtual void BeginPlay()
			=> E_UActorComponent_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Can this component potentially influence navigation </para>
		/// </summary>
		public bool CanEverAffectNavigation()
			=> E_UActorComponent_CanEverAffectNavigation(this);
		
		
		/// <summary>
		/// <para>If we belong to a world, clear the request to do a deferred update. </para>
		/// </summary>
		public void ClearNeedEndOfFrameUpdate()
			=> E_UActorComponent_ClearNeedEndOfFrameUpdate(this);
		
		
		/// <summary>
		/// <para>See if this component contains the supplied tag </para>
		/// </summary>
		public bool ComponentHasTag(string tag)
			=> E_UActorComponent_ComponentHasTag(this, tag);
		
		
		/// <summary>
		/// <para>See if this component is in the persistent level </para>
		/// </summary>
		public bool ComponentIsInPersistentLevel(bool bIncludeLevelStreamingPersistent)
			=> E_UActorComponent_ComponentIsInPersistentLevel(this, bIncludeLevelStreamingPersistent);
		
		
		/// <summary>
		/// <para>Create any physics engine information for this component </para>
		/// </summary>
		public void CreatePhysicsState()
			=> E_UActorComponent_CreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to create any rendering thread information for this component </para>
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected virtual void CreateRenderState_Concurrent()
			=> E_UActorComponent_CreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>Deactivates the SceneComponent. </para>
		/// </summary>
		public virtual void Deactivate()
			=> E_UActorComponent_Deactivate(this);
		
		
		/// <summary>
		/// <para>Unregister the component, remove it from its outer Actor's Components array and mark for pending kill. </para>
		/// </summary>
		public virtual void DestroyComponent(bool bPromoteChildren)
			=> E_UActorComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// <para>Shut down any physics engine structure for this component </para>
		/// </summary>
		public void DestroyPhysicsState()
			=> E_UActorComponent_DestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected virtual void DestroyRenderState_Concurrent()
			=> E_UActorComponent_DestroyRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>Initializes the list of properties that are modified by the UserConstructionScript </para>
		/// </summary>
		public void DetermineUCSModifiedProperties()
			=> E_UActorComponent_DetermineUCSModifiedProperties(this);
		
		
		/// <summary>
		/// <para>Uses the bRenderStateDirty/bRenderTransformDirty to perform any necessary work on this component. </para>
		/// <para>Do not call this directly, call MarkRenderStateDirty, MarkRenderDynamicDataDirty, </para>
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public void DoDeferredRenderUpdates_Concurrent()
			=> E_UActorComponent_DoDeferredRenderUpdates_Concurrent(this);
		
		
		/// <summary>
		/// <para>Returns true if this type of component can ever replicate, override to disable the default behavior </para>
		/// </summary>
		public virtual bool GetComponentClassCanReplicate()
			=> E_UActorComponent_GetComponentClassCanReplicate(this);
		
		
		/// <summary>
		/// <para>Returns the tick interval for this component's primary tick function, which is the frequency in seconds at which it will be executed </para>
		/// </summary>
		public float GetComponentTickInterval()
			=> E_UActorComponent_GetComponentTickInterval(this);
		
		
		/// <summary>
		/// <para>Returns whether replication is enabled or not. </para>
		/// </summary>
		public bool GetIsReplicated()
			=> E_UActorComponent_GetIsReplicated(this);
		
		
		/// <summary>
		/// <para>Get the network mode (dedicated server, client, standalone, etc) for this component. </para>
		/// <para>@see IsNetMode() </para>
		/// </summary>
		public ENetMode GetNetMode()
			=> (ENetMode)E_UActorComponent_GetNetMode(this);
		
		
		/// <summary>
		/// <para>Follow the Outer chain to get the  AActor  that 'Owns' this component </para>
		/// </summary>
		public AActor GetOwner()
			=> E_UActorComponent_GetOwner(this);
		
		
		/// <summary>
		/// <para>Get the network role of the Owner, or ROLE_None if there is no owner. </para>
		/// </summary>
		public ENetRole GetOwnerRole()
			=> (ENetRole)E_UActorComponent_GetOwnerRole(this);
		
		
		/// <summary>
		/// <para>Returns a readable name for this component, including the asset name if applicable </para>
		/// <para>By default this appends a space plus AdditionalStatObject() </para>
		/// </summary>
		public virtual string GetReadableName()
			=> E_UActorComponent_GetReadableName(this);
		
		
		/// <summary>
		/// <para>Makes sure navigation system has up to date information regarding component's navigation relevancy </para>
		/// <para>and if it can affect navigation at all </para>
		/// <param name="bForceUpdate">by default updating navigation system will take place only if the component has </param>
		/// <para>already been registered. Setting bForceUpdate to true overrides that check </para>
		/// </summary>
		protected void HandleCanEverAffectNavigationChange(bool bForceUpdate = false)
			=> E_UActorComponent_HandleCanEverAffectNavigationChange(this, bForceUpdate);
		
		
		/// <summary>
		/// <para>Indicates that OnCreatedComponent has been called, but OnDestroyedComponent has not yet </para>
		/// </summary>
		public bool HasBeenCreated()
			=> E_UActorComponent_HasBeenCreated(this);
		
		
		/// <summary>
		/// <para>Indicates that InitializeComponent has been called, but UninitializeComponent has not yet </para>
		/// </summary>
		public bool HasBeenInitialized()
			=> E_UActorComponent_HasBeenInitialized(this);
		
		
		/// <summary>
		/// <para>Indicates that BeginPlay has been called, but EndPlay has not yet </para>
		/// </summary>
		public bool HasBegunPlay()
			=> E_UActorComponent_HasBegunPlay(this);
		
		
		/// <summary>
		/// <para>Used to check that DestroyPhysicsState() is working correctly </para>
		/// </summary>
		protected virtual bool HasValidPhysicsState()
			=> E_UActorComponent_HasValidPhysicsState(this);
		
		
		/// <summary>
		/// <para>Initializes the component.  Occurs at level startup or actor spawn. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components in the level will be Initialized on load before any Actor/Component gets BeginPlay </para>
		/// <para>Requires component to be registered, and bWantsInitializeComponent to be true. </para>
		/// </summary>
		public virtual void InitializeComponent()
			=> E_UActorComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// <para>Invalidate lighting cache with default options. </para>
		/// </summary>
		public void InvalidateLightingCache()
			=> E_UActorComponent_InvalidateLightingCache(this);
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E_UActorComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns whether the component is active or not </para>
		/// <return>The active state of the component. </return>
		/// </summary>
		public virtual bool IsActive()
			=> E_UActorComponent_IsActive(this);
		
		
		/// <summary>
		/// <para>Returns whether the component is in the process of being destroyed. </para>
		/// </summary>
		public bool IsComponentBeingDestroyed()
			=> E_UActorComponent_IsBeingDestroyed(this);
		
		
		/// <summary>
		/// <para>Returns whether this component has tick enabled or not </para>
		/// </summary>
		public virtual bool IsComponentTickEnabled()
			=> E_UActorComponent_IsComponentTickEnabled(this);
		
		
		/// <summary>
		/// <para>Returns true if instances of this component are created by either the user or simple construction script </para>
		/// </summary>
		public bool IsCreatedByConstructionScript()
			=> E_UActorComponent_IsCreatedByConstructionScript(this);
		
		
		/// <summary>
		/// <para>True if this component can be modified when it was inherited from a parent actor class </para>
		/// </summary>
		public bool IsEditableWhenInherited()
			=> E_UActorComponent_IsEditableWhenInherited(this);
		
		
		/// <summary>
		/// <para>Override to specify that a component is relevant to the navigation system </para>
		/// </summary>
		public virtual bool IsNavigationRelevant()
			=> E_UActorComponent_IsNavigationRelevant(this);
		
		
		/// <summary>
		/// <para>Test whether net mode is the given mode. </para>
		/// <para>In optimized non-editor builds this can be more efficient than GetNetMode() </para>
		/// <para>because it can check the static build flags without considering PIE. </para>
		/// </summary>
		public bool IsNetMode(ENetMode mode)
			=> E_UActorComponent_IsNetMode(this, (byte)mode);
		
		
		/// <summary>
		/// <para>Returns true if we are replicating and this client is not authoritative </para>
		/// </summary>
		public bool IsNetSimulating()
			=> E_UActorComponent_IsNetSimulating(this);
		
		
		/// <summary>
		/// <para>Returns true if this component was owned by a net startup actor during level load. </para>
		/// </summary>
		public bool IsNetStartupComponent()
			=> E_UActorComponent_IsNetStartupComponent(this);
		
		
		/// <summary>
		/// <para>See if the owning Actor is currently running the UCS </para>
		/// </summary>
		public bool IsOwnerRunningUserConstructionScript()
			=> E_UActorComponent_IsOwnerRunningUserConstructionScript(this);
		
		
		/// <summary>
		/// <para>Returns whether the component's owner is selected in the editor </para>
		/// </summary>
		public bool IsOwnerSelected()
			=> E_UActorComponent_IsOwnerSelected(this);
		
		
		/// <summary>
		/// <para>Returns true if the physics 'state' (e.g. physx bodies) are created for this component </para>
		/// </summary>
		public bool IsPhysicsStateCreated()
			=> E_UActorComponent_IsPhysicsStateCreated(this);
		
		
		/// <summary>
		/// <para>Overridable check for a component to indicate to its Owner that it should prevent the Actor from auto destroying when finished </para>
		/// </summary>
		public virtual bool IsReadyForOwnerToAutoDestroy()
			=> E_UActorComponent_IsReadyForOwnerToAutoDestroy(this);
		
		
		/// <summary>
		/// <para>See if this component is currently registered </para>
		/// </summary>
		public bool IsRegistered()
			=> E_UActorComponent_IsRegistered(this);
		
		
		/// <summary>
		/// <para>Returns true if the render 'state' (e.g. scene proxy) is created for this component </para>
		/// </summary>
		public bool IsRenderStateCreated()
			=> E_UActorComponent_IsRenderStateCreated(this);
		
		
		/// <summary>
		/// <para>Is this component in need of its whole state being sent to the renderer? </para>
		/// </summary>
		public bool IsRenderStateDirty()
			=> E_UActorComponent_IsRenderStateDirty(this);
		
		
		/// <summary>
		/// <para>Is this component's transform in need of sending to the renderer? </para>
		/// </summary>
		public bool IsRenderTransformDirty()
			=> E_UActorComponent_IsRenderTransformDirty(this);
		
		
		/// <summary>
		/// <para>Unregister and mark for pending kill a component.  This may not be used to destroy a component that is owned by an actor unless the owning actor is calling the function. </para>
		/// </summary>
		public void K2_DestroyComponent(UObject @object)
			=> E_UActorComponent_K2_DestroyComponent(this, @object);
		
		
		/// <summary>
		/// <para>If we belong to a world, mark this for a deferred update, otherwise do it now. </para>
		/// </summary>
		public void MarkForNeededEndOfFrameRecreate()
			=> E_UActorComponent_MarkForNeededEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>If we belong to a world, mark this for a deferred update, otherwise do it now. </para>
		/// </summary>
		public void MarkForNeededEndOfFrameUpdate()
			=> E_UActorComponent_MarkForNeededEndOfFrameUpdate(this);
		
		
		/// <summary>
		/// <para>Indicate that dynamic data for this component needs to be sent at the end of the frame. </para>
		/// </summary>
		public void MarkRenderDynamicDataDirty()
			=> E_UActorComponent_MarkRenderDynamicDataDirty(this);
		
		
		/// <summary>
		/// <para>Mark the render state as dirty - will be sent to the render thread at the end of the frame. </para>
		/// </summary>
		public void MarkRenderStateDirty()
			=> E_UActorComponent_MarkRenderStateDirty(this);
		
		
		/// <summary>
		/// <para>Marks the transform as dirty - will be sent to the render thread at the end of the frame </para>
		/// </summary>
		public void MarkRenderTransformDirty()
			=> E_UActorComponent_MarkRenderTransformDirty(this);
		
		
		/// <summary>
		/// <para>Called on each component when the Actor's bEnableCollisionChanged flag changes </para>
		/// </summary>
		public virtual void OnActorEnableCollisionChanged()
			=> E_UActorComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded). This can happen in the editor or during gameplay </para>
		/// </summary>
		public virtual void OnComponentCreated()
			=> E_UActorComponent_OnComponentCreated(this);
		
		
		/// <summary>
		/// <para>Called when a component is destroyed </para>
		/// <param name="bDestroyingHierarchy">True if the entire component hierarchy is being torn down, allows avoiding expensive operations </param>
		/// </summary>
		public virtual void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E_UActorComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		
		/// <summary>
		/// <para>Used to create any physics engine information for this component </para>
		/// </summary>
		protected virtual void OnCreatePhysicsState()
			=> E_UActorComponent_OnCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down and physics engine structure for this component </para>
		/// </summary>
		protected virtual void OnDestroyPhysicsState()
			=> E_UActorComponent_OnDestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Called when a component is registered, after Scene is set, but before CreateRenderState_Concurrent or OnCreatePhysicsState are called. </para>
		/// </summary>
		protected virtual void OnRegister()
			=> E_UActorComponent_OnRegister(this);
		
		public virtual void OnRep_IsActive()
			=> E_UActorComponent_OnRep_IsActive(this);
		
		
		/// <summary>
		/// <para>Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called. </para>
		/// </summary>
		protected virtual void OnUnregister()
			=> E_UActorComponent_OnUnregister(this);
		
		
		/// <summary>
		/// <para>Blueprint implementable event for when the component is beginning play, called before its owning actor's BeginPlay </para>
		/// <para>or when the component is dynamically created if the Actor has already BegunPlay. </para>
		/// </summary>
		public void ReceiveBeginPlay()
			=> E_UActorComponent_ReceiveBeginPlay(this);
		
		
		/// <summary>
		/// <para>Event called every frame if tick is enabled </para>
		/// </summary>
		public void Tick(float deltaSeconds)
			=> E_UActorComponent_ReceiveTick(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>Recreate the physics state right way. </para>
		/// </summary>
		public void RecreatePhysicsState()
			=> E_UActorComponent_RecreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Recreate the render state right away. Generally you always want to call MarkRenderStateDirty instead. </para>
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public void RecreateRenderState_Concurrent()
			=> E_UActorComponent_RecreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>When called, will call the virtual call chain to register all of the tick functions </para>
		/// <para>Do not override this function or make it virtual </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		public void RegisterAllComponentTickFunctions(bool bRegister)
			=> E_UActorComponent_RegisterAllComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Register this component, creating any rendering/physics state. Will also add itself to the outer Actor's Components array, if not already present. </para>
		/// </summary>
		public void RegisterComponent()
			=> E_UActorComponent_RegisterComponent(this);
		
		
		/// <summary>
		/// <para>Virtual call chain to register all tick functions </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		protected virtual void RegisterComponentTickFunctions(bool bRegister)
			=> E_UActorComponent_RegisterComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public virtual void RemoveTickPrerequisiteActor(AActor prerequisiteActor)
			=> E_UActorComponent_RemoveTickPrerequisiteActor(this, prerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public virtual void RemoveTickPrerequisiteComponent(UActorComponent prerequisiteComponent)
			=> E_UActorComponent_RemoveTickPrerequisiteComponent(this, prerequisiteComponent);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame recreates to happen from the game thread. </para>
		/// </summary>
		public virtual bool RequiresGameThreadEndOfFrameRecreate()
			=> E_UActorComponent_RequiresGameThreadEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame updates to happen from the game thread. </para>
		/// </summary>
		public virtual bool RequiresGameThreadEndOfFrameUpdates()
			=> E_UActorComponent_RequiresGameThreadEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Unregisters and immediately re-registers component.  Handles bWillReregister properly. </para>
		/// </summary>
		public void ReregisterComponent()
			=> E_UActorComponent_ReregisterComponent(this);
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected virtual void SendRenderDynamicData_Concurrent()
			=> E_UActorComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the rendering thread </para>
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected virtual void SendRenderTransform_Concurrent()
			=> E_UActorComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// <param name="bReset">Whether the activation should happen even if ShouldActivate returns false. </param>
		/// </summary>
		public virtual void SetActive(bool bNewActive, bool bReset)
			=> E_UActorComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public virtual void SetAutoActivate(bool bNewAutoActivate)
			=> E_UActorComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// <para>set value of bCanEverAffectNavigation flag and update navigation octree if needed </para>
		/// </summary>
		public void SetCanEverAffectNavigation(bool bRelevant)
			=> E_UActorComponent_SetCanEverAffectNavigation(this, bRelevant);
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public virtual void SetComponentTickEnabled(bool bEnabled)
			=> E_UActorComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public virtual void SetComponentTickEnabledAsync(bool bEnabled)
			=> E_UActorComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// <para>Sets the tick interval for this component's primary tick function. Does not enable the tick interval. Takes effect on next tick. </para>
		/// <param name="TickInterval">The duration between ticks for this component's primary tick function </param>
		/// </summary>
		public void SetComponentTickInterval(float tickInterval)
			=> E_UActorComponent_SetComponentTickInterval(this, tickInterval);
		
		
		/// <summary>
		/// <para>This should only be called by the engine in ULevel::InitializeNetworkActors to initialize bIsNetStartupComponent. </para>
		/// </summary>
		public void SetIsNetStartupComponent(bool bInIsNetStartupComponent)
			=> E_UActorComponent_SetIsNetStartupComponent(this, bInIsNetStartupComponent);
		
		
		/// <summary>
		/// <para>Enable or disable replication. This is the equivalent of RemoteRole for actors (only a bool is required for components) </para>
		/// </summary>
		public void SetIsReplicated(bool shouldReplicate)
			=> E_UActorComponent_SetIsReplicated(this, shouldReplicate);
		
		
		/// <summary>
		/// <para>This signifies the component can be ID'd by name over the network. This only needs to be called by engine code when constructing blueprint components. </para>
		/// </summary>
		public void SetNetAddressable()
			=> E_UActorComponent_SetNetAddressable(this);
		
		
		/// <summary>
		/// <para>Sets whether this component can tick when paused. </para>
		/// </summary>
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
			=> E_UActorComponent_SetTickableWhenPaused(this, bTickableWhenPaused);
		
		
		/// <summary>
		/// <para>Changes the ticking group for this component </para>
		/// </summary>
		public void SetTickGroup(ETickingGroup newTickGroup)
			=> E_UActorComponent_SetTickGroup(this, (byte)newTickGroup);
		
		
		/// <summary>
		/// <para>Return true if this component is in a state where it can be activated normally. </para>
		/// </summary>
		protected virtual bool ShouldActivate()
			=> E_UActorComponent_ShouldActivate(this);
		
		
		/// <summary>
		/// <para>Return true if CreatePhysicsState() should be called. </para>
		/// <para>Ideally CreatePhysicsState() should always succeed if this returns true, but this isn't currently the case </para>
		/// </summary>
		protected virtual bool ShouldCreatePhysicsState()
			=> E_UActorComponent_ShouldCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Return true if CreateRenderState() should be called </para>
		/// </summary>
		protected virtual bool ShouldCreateRenderState()
			=> E_UActorComponent_ShouldCreateRenderState(this);
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public virtual void ToggleActive()
			=> E_UActorComponent_ToggleActive(this);
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public virtual void UninitializeComponent()
			=> E_UActorComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// <para>Unregister this component, destroying any rendering/physics state. </para>
		/// </summary>
		public void UnregisterComponent()
			=> E_UActorComponent_UnregisterComponent(this);
		
		
		/// <summary>
		/// <para>Recalculate the value of our component to world transform </para>
		/// </summary>
		public virtual void UpdateComponentToWorld(EUpdateTransformFlags updateTransformFlags, ETeleportType teleport)
			=> E_UActorComponent_UpdateComponentToWorld(this, (byte)updateTransformFlags, (byte)teleport);
		
		#endregion
		
		public static implicit operator IntPtr(UActorComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UActorComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UActorComponent>(PtrDesc);
		}}}
