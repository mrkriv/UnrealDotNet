using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A Level is a collection of Actors (lights, volumes, mesh instances etc.).
	/// Multiple Levels can be loaded and unloaded into the World to create a streaming experience.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Levels
	/// @see UActor
	/// </summary>
	public partial class ULevel : UObject
	{
		public ULevel(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern UWorld E_PROP_ULevel_OwningWorld_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_OwningWorld_SET(IntPtr Ptr, UWorld Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_ULevel_NumTextureStreamingUnbuiltComponents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_NumTextureStreamingUnbuiltComponents_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_ULevel_NumTextureStreamingDirtyResources_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_NumTextureStreamingDirtyResources_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_ULevel_LightmapTotalSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_LightmapTotalSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_ULevel_ShadowmapTotalSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_ShadowmapTotalSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FPrecomputedVisibilityHandler E_PROP_ULevel_PrecomputedVisibilityHandler_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_PrecomputedVisibilityHandler_SET(IntPtr Ptr, FPrecomputedVisibilityHandler Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FPrecomputedVolumeDistanceField E_PROP_ULevel_PrecomputedVolumeDistanceField_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_PrecomputedVolumeDistanceField_SET(IntPtr Ptr, FPrecomputedVolumeDistanceField Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_ULevel_bIsLightingScenario_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bIsLightingScenario_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bAreComponentsCurrentlyRegistered_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bAreComponentsCurrentlyRegistered_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bGeometryDirtyForLighting_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bGeometryDirtyForLighting_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bTextureStreamingRotationChanged_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bTextureStreamingRotationChanged_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bIsVisible_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bIsVisible_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bLocked_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bLocked_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bAlreadyMovedActors_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bAlreadyMovedActors_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bAlreadyShiftedActors_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bAlreadyShiftedActors_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bAlreadyUpdatedComponents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bAlreadyUpdatedComponents_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bAlreadyAssociatedStreamableResources_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bAlreadyAssociatedStreamableResources_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bAlreadyInitializedNetworkActors_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bAlreadyInitializedNetworkActors_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bAlreadyRoutedActorInitialize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bAlreadyRoutedActorInitialize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bAlreadySortedActorList_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bAlreadySortedActorList_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bIsAssociatingLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bIsAssociatingLevel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bRequireFullVisibilityToRender_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bRequireFullVisibilityToRender_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bClientOnlyVisible_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bClientOnlyVisible_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bWasDuplicatedForPIE_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bWasDuplicatedForPIE_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bIsBeingRemoved_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bIsBeingRemoved_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bHasRerunConstructionScripts_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bHasRerunConstructionScripts_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_ULevel_bActorClusterCreated_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_bActorClusterCreated_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_ULevel_CurrentActorIndexForUpdateComponents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_CurrentActorIndexForUpdateComponents_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_ULevel_CurrentActorIndexForUnregisterComponents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ULevel_CurrentActorIndexForUnregisterComponents_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_ULevel_HasVisibilityRequestPending(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ULevel_BroadcastLevelBoundsActorUpdated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_ULevel_IsNetActor(IntPtr Self, IntPtr Actor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ULevel_IncrementalUpdateComponents(IntPtr Self, int NumComponentsToUpdate, bool bRerunConstructionScripts);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_ULevel_IncrementalUnregisterComponents(IntPtr Self, int NumComponentsToUnregister);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ULevel_ApplyWorldOffset(IntPtr Self, IntPtr InWorldOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_ULevel_RegisterActorForAutoReceiveInput(IntPtr Self, IntPtr Actor, int PlayerIndex);
		
		#endregion
		
		#region Property
		public UWorld OwningWorld
		{
			get => E_PROP_ULevel_OwningWorld_GET(NativePointer);
			set => E_PROP_ULevel_OwningWorld_SET(NativePointer, value);
		}

		public int NumTextureStreamingUnbuiltComponents
		{
			get => E_PROP_ULevel_NumTextureStreamingUnbuiltComponents_GET(NativePointer);
			set => E_PROP_ULevel_NumTextureStreamingUnbuiltComponents_SET(NativePointer, value);
		}

		public int NumTextureStreamingDirtyResources
		{
			get => E_PROP_ULevel_NumTextureStreamingDirtyResources_GET(NativePointer);
			set => E_PROP_ULevel_NumTextureStreamingDirtyResources_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Total number of KB used for lightmap textures in the level.
		/// </summary>
		public float LightmapTotalSize
		{
			get => E_PROP_ULevel_LightmapTotalSize_GET(NativePointer);
			set => E_PROP_ULevel_LightmapTotalSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Total number of KB used for shadowmap textures in the level.
		/// </summary>
		public float ShadowmapTotalSize
		{
			get => E_PROP_ULevel_ShadowmapTotalSize_GET(NativePointer);
			set => E_PROP_ULevel_ShadowmapTotalSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Contains precomputed visibility data for this level.
		/// </summary>
		public FPrecomputedVisibilityHandler PrecomputedVisibilityHandler
		{
			get => E_PROP_ULevel_PrecomputedVisibilityHandler_GET(NativePointer);
			set => E_PROP_ULevel_PrecomputedVisibilityHandler_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Precomputed volume distance field for this level.
		/// </summary>
		public FPrecomputedVolumeDistanceField PrecomputedVolumeDistanceField
		{
			get => E_PROP_ULevel_PrecomputedVolumeDistanceField_GET(NativePointer);
			set => E_PROP_ULevel_PrecomputedVolumeDistanceField_SET(NativePointer, value);
		}

		public bool bIsLightingScenario
		{
			get => E_PROP_ULevel_bIsLightingScenario_GET(NativePointer);
			set => E_PROP_ULevel_bIsLightingScenario_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether components are currently registered or not.
		/// </summary>
		public byte bAreComponentsCurrentlyRegistered
		{
			get => E_PROP_ULevel_bAreComponentsCurrentlyRegistered_GET(NativePointer);
			set => E_PROP_ULevel_bAreComponentsCurrentlyRegistered_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the geometry needs to be rebuilt for correct lighting
		/// </summary>
		public byte bGeometryDirtyForLighting
		{
			get => E_PROP_ULevel_bGeometryDirtyForLighting_GET(NativePointer);
			set => E_PROP_ULevel_bGeometryDirtyForLighting_SET(NativePointer, value);
		}

		public byte bTextureStreamingRotationChanged
		{
			get => E_PROP_ULevel_bTextureStreamingRotationChanged_GET(NativePointer);
			set => E_PROP_ULevel_bTextureStreamingRotationChanged_SET(NativePointer, value);
		}

		public byte bIsVisible
		{
			get => E_PROP_ULevel_bIsVisible_GET(NativePointer);
			set => E_PROP_ULevel_bIsVisible_SET(NativePointer, value);
		}

		public byte bLocked
		{
			get => E_PROP_ULevel_bLocked_GET(NativePointer);
			set => E_PROP_ULevel_bLocked_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we already moved actors.
		/// </summary>
		public byte bAlreadyMovedActors
		{
			get => E_PROP_ULevel_bAlreadyMovedActors_GET(NativePointer);
			set => E_PROP_ULevel_bAlreadyMovedActors_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we already shift actors positions according to world composition.
		/// </summary>
		public byte bAlreadyShiftedActors
		{
			get => E_PROP_ULevel_bAlreadyShiftedActors_GET(NativePointer);
			set => E_PROP_ULevel_bAlreadyShiftedActors_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we already updated components.
		/// </summary>
		public byte bAlreadyUpdatedComponents
		{
			get => E_PROP_ULevel_bAlreadyUpdatedComponents_GET(NativePointer);
			set => E_PROP_ULevel_bAlreadyUpdatedComponents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we already associated streamable resources.
		/// </summary>
		public byte bAlreadyAssociatedStreamableResources
		{
			get => E_PROP_ULevel_bAlreadyAssociatedStreamableResources_GET(NativePointer);
			set => E_PROP_ULevel_bAlreadyAssociatedStreamableResources_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we already initialized network actors.
		/// </summary>
		public byte bAlreadyInitializedNetworkActors
		{
			get => E_PROP_ULevel_bAlreadyInitializedNetworkActors_GET(NativePointer);
			set => E_PROP_ULevel_bAlreadyInitializedNetworkActors_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we already routed initialize on actors.
		/// </summary>
		public byte bAlreadyRoutedActorInitialize
		{
			get => E_PROP_ULevel_bAlreadyRoutedActorInitialize_GET(NativePointer);
			set => E_PROP_ULevel_bAlreadyRoutedActorInitialize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we already sorted the actor list.
		/// </summary>
		public byte bAlreadySortedActorList
		{
			get => E_PROP_ULevel_bAlreadySortedActorList_GET(NativePointer);
			set => E_PROP_ULevel_bAlreadySortedActorList_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this level is in the process of being associated with its world
		/// </summary>
		public byte bIsAssociatingLevel
		{
			get => E_PROP_ULevel_bIsAssociatingLevel_GET(NativePointer);
			set => E_PROP_ULevel_bIsAssociatingLevel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this level should be fully added to the world before rendering his components
		/// </summary>
		public byte bRequireFullVisibilityToRender
		{
			get => E_PROP_ULevel_bRequireFullVisibilityToRender_GET(NativePointer);
			set => E_PROP_ULevel_bRequireFullVisibilityToRender_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this level is specific to client, visibility state will not be replicated to server
		/// </summary>
		public byte bClientOnlyVisible
		{
			get => E_PROP_ULevel_bClientOnlyVisible_GET(NativePointer);
			set => E_PROP_ULevel_bClientOnlyVisible_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this level was duplicated for PIE
		/// </summary>
		public byte bWasDuplicatedForPIE
		{
			get => E_PROP_ULevel_bWasDuplicatedForPIE_GET(NativePointer);
			set => E_PROP_ULevel_bWasDuplicatedForPIE_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the level is currently being removed from the world
		/// </summary>
		public byte bIsBeingRemoved
		{
			get => E_PROP_ULevel_bIsBeingRemoved_GET(NativePointer);
			set => E_PROP_ULevel_bIsBeingRemoved_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this level has gone through a complete rerun construction script pass.
		/// </summary>
		public byte bHasRerunConstructionScripts
		{
			get => E_PROP_ULevel_bHasRerunConstructionScripts_GET(NativePointer);
			set => E_PROP_ULevel_bHasRerunConstructionScripts_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the level had its actor cluster created. This doesn't mean that the creation was successful.
		/// </summary>
		public byte bActorClusterCreated
		{
			get => E_PROP_ULevel_bActorClusterCreated_GET(NativePointer);
			set => E_PROP_ULevel_bActorClusterCreated_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current index into actors array for updating components.
		/// </summary>
		public int CurrentActorIndexForUpdateComponents
		{
			get => E_PROP_ULevel_CurrentActorIndexForUpdateComponents_GET(NativePointer);
			set => E_PROP_ULevel_CurrentActorIndexForUpdateComponents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current index into actors array for updating components.
		/// </summary>
		public int CurrentActorIndexForUnregisterComponents
		{
			get => E_PROP_ULevel_CurrentActorIndexForUnregisterComponents_GET(NativePointer);
			set => E_PROP_ULevel_CurrentActorIndexForUnregisterComponents_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Whether the level is currently pending being made visible.
		/// </summary>
		public bool HasVisibilityRequestPending()
			=> E_ULevel_HasVisibilityRequestPending(NativePointer);
		
		
		/// <summary>
		/// Broadcasts that Level bounds actor has been updated
		/// </summary>
		public void BroadcastLevelBoundsActorUpdated()
			=> E_ULevel_BroadcastLevelBoundsActorUpdated(NativePointer);
		
		public bool IsNetActor(AActor Actor)
			=> E_ULevel_IsNetActor(NativePointer, Actor);
		
		
		/// <summary>
		/// Incrementally updates all components of actors associated with this level.
		/// @param NumComponentsToUpdate		Number of components to update in this run, 0 for all
		/// @param bRerunConstructionScripts	If we want to rerun construction scripts on actors in level
		/// </summary>
		public void IncrementalUpdateComponents(int NumComponentsToUpdate, bool bRerunConstructionScripts)
			=> E_ULevel_IncrementalUpdateComponents(NativePointer, NumComponentsToUpdate, bRerunConstructionScripts);
		
		
		/// <summary>
		/// Incrementally unregisters all components of actors associated with this level.
		/// This is done at the granularity of actors (individual actors have all of their components unregistered)
		/// @param NumComponentsToUnregister		Minimum number of components to unregister in this run, 0 for all
		/// </summary>
		public bool IncrementalUnregisterComponents(int NumComponentsToUnregister)
			=> E_ULevel_IncrementalUnregisterComponents(NativePointer, NumComponentsToUnregister);
		
		
		/// <summary>
		/// Shift level actors by specified offset
		/// The offset vector will get subtracted from all actors positions and corresponding data structures
		/// @param InWorldOffset	 Vector to shift all actors by
		/// @param bWorldShift	 Whether this call is part of whole world shifting
		/// </summary>
		public void ApplyWorldOffset(FVector InWorldOffset, bool bWorldShift)
			=> E_ULevel_ApplyWorldOffset(NativePointer, InWorldOffset, bWorldShift);
		
		
		/// <summary>
		/// Register an actor that should be added to a player's input stack when they are created
		/// </summary>
		public void RegisterActorForAutoReceiveInput(AActor Actor, int PlayerIndex)
			=> E_ULevel_RegisterActorForAutoReceiveInput(NativePointer, Actor, PlayerIndex);
		
		#endregion
		
		public static implicit operator IntPtr(ULevel Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULevel(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new ULevel(Adress);
		}}}
