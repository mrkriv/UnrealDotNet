// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:110

namespace UnrealEngine
{
	[ManageType("ManageAudioComponent")]
	public partial class ManageAudioComponent : UAudioComponent, IManageWrapper
	{
		public ManageAudioComponent(IntPtr adress)
			: base(adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_FadeIn(IntPtr self, float fadeInDuration, float fadeVolumeLevel, float startTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_FadeOut(IntPtr self, float fadeOutDuration, float fadeVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_Play(IntPtr self, float startTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_Stop(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_DetachFromParent(IntPtr self, bool bMaintainWorldPosition, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnAttachmentChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnHiddenInGameChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnVisibilityChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PropagateLightingScenarioChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_UpdateBounds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_UpdatePhysicsVolume(IntPtr self, bool bTriggerNotifiers);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_Activate(IntPtr self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_BeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_CreateRenderState_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_Deactivate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_DestroyComponent(IntPtr self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_DestroyRenderState_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_InitializeComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_InvalidateLightingCacheDetailed(IntPtr self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnActorEnableCollisionChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnComponentCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnComponentDestroyed(IntPtr self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnCreatePhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnDestroyPhysicsState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnRegister(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnRep_IsActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnUnregister(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_RegisterComponentTickFunctions(IntPtr self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_SendRenderDynamicData_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_SendRenderTransform_Concurrent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_SetActive(IntPtr self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_SetAutoActivate(IntPtr self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_SetComponentTickEnabled(IntPtr self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_SetComponentTickEnabledAsync(IntPtr self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_ToggleActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_UninitializeComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_BeginDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_FinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_MarkAsEditorOnlySubobject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PostCDOContruct(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PostEditImport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PostInitProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PostNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PostRepNotifies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PostSaveRoot(IntPtr self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PreDestroyFromReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_PreNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_ShutdownAfterError(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_CreateCluster(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__UAudioComponent_OnClusterMarkedAsPendingKill(IntPtr self);
		
		#endregion
		
		#region Methods
		
		/// <summary>
		/// This can be used in place of "play" when it is desired to fade in the sound over time.
		/// <para>If FadeTime is 0.0, the change in volume is instant. </para>
		/// If FadeTime is > 0.0, the multiplier will be increased from 0 to FadeVolumeLevel over FadeIn seconds.
		/// </summary>
		/// <param name="fadeInDuration">how long it should take to reach the FadeVolumeLevel</param>
		/// <param name="fadeVolumeLevel">the percentage of the AudioComponents's calculated volume to fade to</param>
		public override void FadeIn(float fadeInDuration, float fadeVolumeLevel, float startTime)
			=> E__Supper__UAudioComponent_FadeIn(this, fadeInDuration, fadeVolumeLevel, startTime);
		
		
		/// <summary>
		/// This is used in place of "stop" when it is desired to fade the volume of the sound before stopping.
		/// <para>If FadeTime is 0.0, this is the same as calling Stop(). </para>
		/// If FadeTime is > 0.0, this will adjust the volume multiplier to FadeVolumeLevel over FadeInTime seconds
		/// <para>and then stop the sound. </para>
		/// </summary>
		/// <param name="fadeOutDuration">how long it should take to reach the FadeVolumeLevel</param>
		/// <param name="fadeVolumeLevel">the percentage of the AudioComponents's calculated volume in which to fade to</param>
		public override void FadeOut(float fadeOutDuration, float fadeVolumeLevel)
			=> E__Supper__UAudioComponent_FadeOut(this, fadeOutDuration, fadeVolumeLevel);
		
		
		/// <summary>
		/// Start a sound playing on an audio component
		/// </summary>
		public override void Play(float startTime)
			=> E__Supper__UAudioComponent_Play(this, startTime);
		
		
		/// <summary>
		/// Stop an audio component playing its sound cue, issue any delegates if needed
		/// </summary>
		public override void Stop()
			=> E__Supper__UAudioComponent_Stop(this);
		
		
		/// <summary>
		/// DEPRECATED - Use DetachFromComponent() instead
		/// </summary>
		public override void DetachFromParentDeprecated(bool bMaintainWorldPosition, bool bCallModify)
			=> E__Supper__UAudioComponent_DetachFromParent(this, bMaintainWorldPosition, bCallModify);
		
		
		/// <summary>
		/// Called when AttachParent changes, to allow the scene to update its attachment state.
		/// </summary>
		public override void OnAttachmentChanged()
			=> E__Supper__UAudioComponent_OnAttachmentChanged(this);
		
		
		/// <summary>
		/// Overridable internal function to respond to changes in the hidden in game value of the component.
		/// </summary>
		protected override void OnHiddenInGameChanged()
			=> E__Supper__UAudioComponent_OnHiddenInGameChanged(this);
		
		
		/// <summary>
		/// Overridable internal function to respond to changes in the visibility of the component.
		/// </summary>
		protected override void OnVisibilityChanged()
			=> E__Supper__UAudioComponent_OnVisibilityChanged(this);
		
		
		/// <summary>
		/// Updates any visuals after the lighting has changed
		/// </summary>
		public override void PropagateLightingScenarioChange()
			=> E__Supper__UAudioComponent_PropagateLightingScenarioChange(this);
		
		
		/// <summary>
		/// Update the Bounds of the component.
		/// </summary>
		public override void UpdateBounds()
			=> E__Supper__UAudioComponent_UpdateBounds(this);
		
		
		/// <summary>
		/// Updates the PhysicsVolume of this SceneComponent, if bShouldUpdatePhysicsVolume is true.
		/// </summary>
		/// <param name="bTriggerNotifiers">if true, send zone/volume change events</param>
		public override void UpdatePhysicsVolume(bool bTriggerNotifiers)
			=> E__Supper__UAudioComponent_UpdatePhysicsVolume(this, bTriggerNotifiers);
		
		
		/// <summary>
		/// Activates the SceneComponent, should be overridden by native child classes.
		/// </summary>
		/// <param name="bReset">Whether the activation should happen even if ShouldActivate returns false.</param>
		public override void Activate(bool bReset)
			=> E__Supper__UAudioComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// BeginsPlay for the component.  Occurs at level startup or actor spawn. This is before BeginPlay (Actor or Component).
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// Actor/Component gets BeginPlay.
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public override void BeginPlay()
			=> E__Supper__UAudioComponent_BeginPlay(this);
		
		
		/// <summary>
		/// Used to create any rendering thread information for this component
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected override void CreateRenderState_Concurrent()
			=> E__Supper__UAudioComponent_CreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// Deactivates the SceneComponent.
		/// </summary>
		public override void Deactivate()
			=> E__Supper__UAudioComponent_Deactivate(this);
		
		
		/// <summary>
		/// Unregister the component, remove it from its outer Actor's Components array and mark for pending kill.
		/// </summary>
		public override void DestroyComponent(bool bPromoteChildren)
			=> E__Supper__UAudioComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// Used to shut down any rendering thread structure for this component
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected override void DestroyRenderState_Concurrent()
			=> E__Supper__UAudioComponent_DestroyRenderState_Concurrent(this);
		
		
		/// <summary>
		/// Initializes the component.  Occurs at level startup or actor spawn. This is before BeginPlay (Actor or Component).
		/// <para>All Components in the level will be Initialized on load before any Actor/Component gets BeginPlay </para>
		/// Requires component to be registered, and bWantsInitializeComponent to be true.
		/// </summary>
		public override void InitializeComponent()
			=> E__Supper__UAudioComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// Called when this actor component has moved, allowing it to discard statically cached lighting information.
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E__Supper__UAudioComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// Called on each component when the Actor's bEnableCollisionChanged flag changes
		/// </summary>
		public override void OnActorEnableCollisionChanged()
			=> E__Supper__UAudioComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// Called when a component is created (not loaded). This can happen in the editor or during gameplay
		/// </summary>
		public override void OnComponentCreated()
			=> E__Supper__UAudioComponent_OnComponentCreated(this);
		
		
		/// <summary>
		/// Called when a component is destroyed
		/// </summary>
		/// <param name="bDestroyingHierarchy">True if the entire component hierarchy is being torn down, allows avoiding expensive operations</param>
		public override void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E__Supper__UAudioComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		
		/// <summary>
		/// Used to create any physics engine information for this component
		/// </summary>
		protected override void OnCreatePhysicsState()
			=> E__Supper__UAudioComponent_OnCreatePhysicsState(this);
		
		
		/// <summary>
		/// Used to shut down and physics engine structure for this component
		/// </summary>
		protected override void OnDestroyPhysicsState()
			=> E__Supper__UAudioComponent_OnDestroyPhysicsState(this);
		
		
		/// <summary>
		/// Called when a component is registered, after Scene is set, but before CreateRenderState_Concurrent or OnCreatePhysicsState are called.
		/// </summary>
		protected override void OnRegister()
			=> E__Supper__UAudioComponent_OnRegister(this);
		
		public override void OnRep_IsActive()
			=> E__Supper__UAudioComponent_OnRep_IsActive(this);
		
		
		/// <summary>
		/// Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called.
		/// </summary>
		protected override void OnUnregister()
			=> E__Supper__UAudioComponent_OnUnregister(this);
		
		
		/// <summary>
		/// Virtual call chain to register all tick functions
		/// </summary>
		/// <param name="bRegister">true to register, false, to unregister</param>
		protected override void RegisterComponentTickFunctions(bool bRegister)
			=> E__Supper__UAudioComponent_RegisterComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// Called to send dynamic data for this component to the rendering thread
		/// </summary>
		protected override void SendRenderDynamicData_Concurrent()
			=> E__Supper__UAudioComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// Called to send a transform update for this component to the rendering thread
		/// <para>@warning This is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		protected override void SendRenderTransform_Concurrent()
			=> E__Supper__UAudioComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// Sets whether the component is active or not
		/// </summary>
		/// <param name="bNewActive">The new active state of the component</param>
		/// <param name="bReset">Whether the activation should happen even if ShouldActivate returns false.</param>
		public override void SetActive(bool bNewActive, bool bReset)
			=> E__Supper__UAudioComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// Sets whether the component should be auto activate or not. Only safe during construction scripts.
		/// </summary>
		/// <param name="bNewAutoActivate">The new auto activate state of the component</param>
		public override void SetAutoActivate(bool bNewAutoActivate)
			=> E__Supper__UAudioComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered
		/// </summary>
		/// <param name="bEnabled">Whether it should be enabled or not</param>
		public override void SetComponentTickEnabled(bool bEnabled)
			=> E__Supper__UAudioComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// Spawns a task on GameThread that will call SetComponentTickEnabled
		/// </summary>
		/// <param name="bEnabled">Whether it should be enabled or not</param>
		public override void SetComponentTickEnabledAsync(bool bEnabled)
			=> E__Supper__UAudioComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// Toggles the active state of the component
		/// </summary>
		public override void ToggleActive()
			=> E__Supper__UAudioComponent_ToggleActive(this);
		
		
		/// <summary>
		/// Handle this component being Uninitialized.
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent()
			=> E__Supper__UAudioComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy()
			=> E__Supper__UAudioComponent_BeginDestroy(this);
		
		
		/// <summary>
		/// Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed.
		/// <para>@warning Because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E__Supper__UAudioComponent_FinishDestroy(this);
		
		
		/// <summary>
		/// Called during subobject creation to mark this component as editor only, which causes it to get stripped in packaged builds
		/// </summary>
		public override void MarkAsEditorOnlySubobject()
			=> E__Supper__UAudioComponent_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E__Supper__UAudioComponent_PostCDOContruct(this);
		
		
		/// <summary>
		/// Called after importing property values for this object (paste, duplicate or .t3d import)
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// are unsupported by the script serialization
		/// </summary>
		public override void PostEditImport()
			=> E__Supper__UAudioComponent_PostEditImport(this);
		
		
		/// <summary>
		/// Called after the C++ constructor and after the properties have been initialized, including those loaded from config.
		/// <para>This is called before any serialization or other setup has happened. </para>
		/// </summary>
		public override void PostInitProperties()
			=> E__Supper__UAudioComponent_PostInitProperties(this);
		
		
		/// <summary>
		/// Do any object-specific cleanup required immediately after loading an object.
		/// <para>This is not called for newly-created objects, and by default will always execute on the game thread. </para>
		/// </summary>
		public override void PostLoad()
			=> E__Supper__UAudioComponent_PostLoad(this);
		
		
		/// <summary>
		/// Called right after receiving a bunch
		/// </summary>
		public override void PostNetReceive()
			=> E__Supper__UAudioComponent_PostNetReceive(this);
		
		
		/// <summary>
		/// Called right after calling all OnRep notifies (called even when there are no notifies)
		/// </summary>
		public override void PostRepNotifies()
			=> E__Supper__UAudioComponent_PostRepNotifies(this);
		
		
		/// <summary>
		/// Called from within SavePackage on the passed in base/root object.
		/// <para>This function is called after the package has been saved and can perform cleanup. </para>
		/// </summary>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up</param>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E__Supper__UAudioComponent_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// Called right before being marked for destruction due to network replication
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E__Supper__UAudioComponent_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// Called right before receiving a bunch
		/// </summary>
		public override void PreNetReceive()
			=> E__Supper__UAudioComponent_PreNetReceive(this);
		
		
		/// <summary>
		/// After a critical error, perform any mission-critical cleanup, such as restoring the video mode orreleasing hardware resources.
		/// </summary>
		public override void ShutdownAfterError()
			=> E__Supper__UAudioComponent_ShutdownAfterError(this);
		
		
		/// <summary>
		/// Called after PostLoad to create UObject cluster
		/// </summary>
		public override void CreateCluster()
			=> E__Supper__UAudioComponent_CreateCluster(this);
		
		
		/// <summary>
		/// Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it.
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E__Supper__UAudioComponent_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(ManageAudioComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageAudioComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageAudioComponent>(PtrDesc);
		}}}
