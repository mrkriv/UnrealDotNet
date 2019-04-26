// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:395

namespace UnrealEngine
{
	public  partial class AWorldSettings : AInfo
	{
		public AWorldSettings(IntPtr Adress)
			: base(Adress)
		{
		}

		public AWorldSettings(UObject Parent = null, string Name = "WorldSettings")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AWorldSettings(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bEnableAISystem_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bEnableAISystem_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bEnableWorldComposition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bEnableWorldComposition_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bEnableWorldOriginRebasing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bEnableWorldOriginRebasing_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bForceNoPrecomputedLighting_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bForceNoPrecomputedLighting_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bGlobalGravitySet_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bGlobalGravitySet_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bHighPriorityLoading_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bHighPriorityLoading_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bHighPriorityLoadingLocal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bHighPriorityLoadingLocal_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bMinimizeBSPSections_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bMinimizeBSPSections_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bOverrideDefaultBroadphaseSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bOverrideDefaultBroadphaseSettings_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_AWorldSettings_BroadphaseSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_BroadphaseSettings_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bUseClientSideLevelStreamingVolumes_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bUseClientSideLevelStreamingVolumes_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AWorldSettings_bWorldGravitySet_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_bWorldGravitySet_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_AWorldSettings_DefaultColorScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_DefaultColorScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_DefaultMaxDistanceFieldOcclusionDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_DefaultMaxDistanceFieldOcclusionDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_DemoPlayTimeDilation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_DemoPlayTimeDilation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_DynamicIndirectShadowsSelfShadowingIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_DynamicIndirectShadowsSelfShadowingIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_GlobalDistanceFieldViewDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_GlobalDistanceFieldViewDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_GlobalGravityZ_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_GlobalGravityZ_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_KillZ_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_KillZ_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_MatineeTimeDilation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_MatineeTimeDilation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_MaxGlobalTimeDilation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_MaxGlobalTimeDilation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_MaxUndilatedFrameTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_MaxUndilatedFrameTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_MinGlobalTimeDilation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_MinGlobalTimeDilation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_MinUndilatedFrameTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_MinUndilatedFrameTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_MonoCullingDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_MonoCullingDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AWorldSettings_PackedLightAndShadowMapTextureSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_PackedLightAndShadowMapTextureSize_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_AWorldSettings_Pauser_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_Pauser_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_TimeDilation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_TimeDilation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_WorldGravityZ_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_WorldGravityZ_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AWorldSettings_WorldToMeters_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AWorldSettings_WorldToMeters_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AWorldSettings(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AWorldSettings_ClearAllBookmarks(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AWorldSettings_CompactBookmarks(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AWorldSettings_FixupDeltaSeconds(IntPtr self, float deltaSeconds, float realDeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AWorldSettings_GetEffectiveTimeDilation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AWorldSettings_GetGravityZ(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_AWorldSettings_GetMaxNumberOfBookmarks(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AWorldSettings_IsNavigationSystemEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AWorldSettings_NotifyBeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AWorldSettings_NotifyMatchStarted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AWorldSettings_OnRep_WorldGravityZ(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AWorldSettings_SetTimeDilation(IntPtr self, float newTimeDilation);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>if set to false AI system will not get created. Use it to disable all AI-related activity on a map </para>
		/// </summary>
		public byte bEnableAISystem
		{
			get => E_PROP_AWorldSettings_bEnableAISystem_GET(NativePointer);
			set => E_PROP_AWorldSettings_bEnableAISystem_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Enables tools for composing a tiled world. </para>
		/// <para>Level has to be saved and all sub-levels removed before enabling this option. </para>
		/// </summary>
		public byte bEnableWorldComposition
		{
			get => E_PROP_AWorldSettings_bEnableWorldComposition_GET(NativePointer);
			set => E_PROP_AWorldSettings_bEnableWorldComposition_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>World origin will shift to a camera position when camera goes far away from current origin </para>
		/// </summary>
		public byte bEnableWorldOriginRebasing
		{
			get => E_PROP_AWorldSettings_bEnableWorldOriginRebasing_GET(NativePointer);
			set => E_PROP_AWorldSettings_bEnableWorldOriginRebasing_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to force lightmaps and other precomputed lighting to not be created even when the engine thinks they are needed. </para>
		/// <para>This is useful for improving iteration in levels with fully dynamic lighting and shadowing. </para>
		/// <para>Note that any lighting and shadowing interactions that are usually precomputed will be lost if this is enabled. </para>
		/// </summary>
		public byte bForceNoPrecomputedLighting
		{
			get => E_PROP_AWorldSettings_bForceNoPrecomputedLighting_GET(NativePointer);
			set => E_PROP_AWorldSettings_bForceNoPrecomputedLighting_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If set to true we will use GlobalGravityZ instead of project setting DefaultGravityZ </para>
		/// </summary>
		public byte OverrideWorldGravity
		{
			get => E_PROP_AWorldSettings_bGlobalGravitySet_GET(NativePointer);
			set => E_PROP_AWorldSettings_bGlobalGravitySet_SET(NativePointer, value);
		}

		public byte bHighPriorityLoading
		{
			get => E_PROP_AWorldSettings_bHighPriorityLoading_GET(NativePointer);
			set => E_PROP_AWorldSettings_bHighPriorityLoading_SET(NativePointer, value);
		}

		public byte bHighPriorityLoadingLocal
		{
			get => E_PROP_AWorldSettings_bHighPriorityLoadingLocal_GET(NativePointer);
			set => E_PROP_AWorldSettings_bHighPriorityLoadingLocal_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Causes the BSP build to generate as few sections as possible. </para>
		/// <para>This is useful when you need to reduce draw calls but can reduce texture streaming efficiency and effective lightmap resolution. </para>
		/// <para>Note - changes require a rebuild to propagate.  Also, be sure to select all surfaces and make sure they all have the same flags to minimize section count. </para>
		/// </summary>
		public byte bMinimizeBSPSections
		{
			get => E_PROP_AWorldSettings_bMinimizeBSPSections_GET(NativePointer);
			set => E_PROP_AWorldSettings_bMinimizeBSPSections_SET(NativePointer, value);
		}

		public byte bOverrideDefaultBroadphaseSettings
		{
			get => E_PROP_AWorldSettings_bOverrideDefaultBroadphaseSettings_GET(NativePointer);
			set => E_PROP_AWorldSettings_bOverrideDefaultBroadphaseSettings_SET(NativePointer, value);
		}

		public FBroadphaseSettings BroadphaseSettings
		{
			get => E_PROP_AWorldSettings_BroadphaseSettings_GET(NativePointer);
			set => E_PROP_AWorldSettings_BroadphaseSettings_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Enables client-side streaming volumes instead of server-side. </para>
		/// <para>Expected usage scenario: server has all streaming levels always loaded, clients independently stream levels in/out based on streaming volumes. </para>
		/// </summary>
		public byte bUseClientSideLevelStreamingVolumes
		{
			get => E_PROP_AWorldSettings_bUseClientSideLevelStreamingVolumes_GET(NativePointer);
			set => E_PROP_AWorldSettings_bUseClientSideLevelStreamingVolumes_SET(NativePointer, value);
		}

		public byte bWorldGravitySet
		{
			get => E_PROP_AWorldSettings_bWorldGravitySet_GET(NativePointer);
			set => E_PROP_AWorldSettings_bWorldGravitySet_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Default color scale for the level </para>
		/// </summary>
		public FVector DefaultColorScale
		{
			get => E_PROP_AWorldSettings_DefaultColorScale_GET(NativePointer);
			set => E_PROP_AWorldSettings_DefaultColorScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max occlusion distance used by mesh distance fields, overridden if there is a movable skylight. </para>
		/// </summary>
		public float DefaultMaxDistanceFieldOcclusionDistance
		{
			get => E_PROP_AWorldSettings_DefaultMaxDistanceFieldOcclusionDistance_GET(NativePointer);
			set => E_PROP_AWorldSettings_DefaultMaxDistanceFieldOcclusionDistance_SET(NativePointer, value);
		}

		public float DemoPlayTimeDilation
		{
			get => E_PROP_AWorldSettings_DemoPlayTimeDilation_GET(NativePointer);
			set => E_PROP_AWorldSettings_DemoPlayTimeDilation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls the intensity of self-shadowing from capsule indirect shadows. </para>
		/// <para>These types of shadows use approximate occluder representations, so reducing self-shadowing intensity can hide those artifacts. </para>
		/// </summary>
		public float DynamicIndirectShadowsSelfShadowingIntensity
		{
			get => E_PROP_AWorldSettings_DynamicIndirectShadowsSelfShadowingIntensity_GET(NativePointer);
			set => E_PROP_AWorldSettings_DynamicIndirectShadowsSelfShadowingIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Distance from the camera that the global distance field should cover. </para>
		/// </summary>
		public float GlobalDistanceFieldViewDistance
		{
			get => E_PROP_AWorldSettings_GlobalDistanceFieldViewDistance_GET(NativePointer);
			set => E_PROP_AWorldSettings_GlobalDistanceFieldViewDistance_SET(NativePointer, value);
		}

		public float GlobalGravityZ
		{
			get => E_PROP_AWorldSettings_GlobalGravityZ_GET(NativePointer);
			set => E_PROP_AWorldSettings_GlobalGravityZ_SET(NativePointer, value);
		}

		public float KillZ
		{
			get => E_PROP_AWorldSettings_KillZ_GET(NativePointer);
			set => E_PROP_AWorldSettings_KillZ_SET(NativePointer, value);
		}

		public float MatineeTimeDilation
		{
			get => E_PROP_AWorldSettings_MatineeTimeDilation_GET(NativePointer);
			set => E_PROP_AWorldSettings_MatineeTimeDilation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Highest acceptable global time dilation. </para>
		/// </summary>
		public float MaxGlobalTimeDilation
		{
			get => E_PROP_AWorldSettings_MaxGlobalTimeDilation_GET(NativePointer);
			set => E_PROP_AWorldSettings_MaxGlobalTimeDilation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Largest possible frametime, not considering dilation. Equiv to 1/SlowestFPS. </para>
		/// </summary>
		public float MaxUndilatedFrameTime
		{
			get => E_PROP_AWorldSettings_MaxUndilatedFrameTime_GET(NativePointer);
			set => E_PROP_AWorldSettings_MaxUndilatedFrameTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Lowest acceptable global time dilation. </para>
		/// </summary>
		public float MinGlobalTimeDilation
		{
			get => E_PROP_AWorldSettings_MinGlobalTimeDilation_GET(NativePointer);
			set => E_PROP_AWorldSettings_MinGlobalTimeDilation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Smallest possible frametime, not considering dilation. Equiv to 1/FastestFPS. </para>
		/// </summary>
		public float MinUndilatedFrameTime
		{
			get => E_PROP_AWorldSettings_MinUndilatedFrameTime_GET(NativePointer);
			set => E_PROP_AWorldSettings_MinUndilatedFrameTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Distance from the player after which content will be rendered in mono if monoscopic far field rendering is activated </para>
		/// </summary>
		public float MonoCullingDistance
		{
			get => E_PROP_AWorldSettings_MonoCullingDistance_GET(NativePointer);
			set => E_PROP_AWorldSettings_MonoCullingDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Maximum size of textures for packed light and shadow maps </para>
		/// </summary>
		public int PackedLightAndShadowMapTextureSize
		{
			get => E_PROP_AWorldSettings_PackedLightAndShadowMapTextureSize_GET(NativePointer);
			set => E_PROP_AWorldSettings_PackedLightAndShadowMapTextureSize_SET(NativePointer, value);
		}

		public APlayerState Pauser
		{
			get => E_PROP_AWorldSettings_Pauser_GET(NativePointer);
			set => E_PROP_AWorldSettings_Pauser_SET(NativePointer, value);
		}

		public float TimeDilation
		{
			get => E_PROP_AWorldSettings_TimeDilation_GET(NativePointer);
			set => E_PROP_AWorldSettings_TimeDilation_SET(NativePointer, value);
		}

		public float WorldGravityZ
		{
			get => E_PROP_AWorldSettings_WorldGravityZ_GET(NativePointer);
			set => E_PROP_AWorldSettings_WorldGravityZ_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>scale of 1uu to 1m in real world measurements, for HMD and other physically tracked devices (e.g. 1uu = 1cm would be 100.0) </para>
		/// </summary>
		public float WorldToMeters
		{
			get => E_PROP_AWorldSettings_WorldToMeters_GET(NativePointer);
			set => E_PROP_AWorldSettings_WorldToMeters_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Clears all references to current bookmarks. </para>
		/// </summary>
		public void ClearAllBookmarks()
			=> E_AWorldSettings_ClearAllBookmarks(this);
		
		
		/// <summary>
		/// <para>Attempts to move bookmarks such that all bookmarks are adjacent in memory. </para>
		/// <para>Note, this will not rearrange any valid Bookmarks inside the mapped range, but </para>
		/// <para>may move bookmarks outside that range to fill up mapped bookmarks. </para>
		/// </summary>
		public void CompactBookmarks()
			=> E_AWorldSettings_CompactBookmarks(this);
		
		
		/// <summary>
		/// <para>Returns the delta time to be used by the tick. Can be overridden if game specific logic is needed. </para>
		/// </summary>
		public virtual float FixupDeltaSeconds(float deltaSeconds, float realDeltaSeconds)
			=> E_AWorldSettings_FixupDeltaSeconds(this, deltaSeconds, realDeltaSeconds);
		
		public virtual float GetEffectiveTimeDilation()
			=> E_AWorldSettings_GetEffectiveTimeDilation(this);
		
		
		/// <summary>
		/// <para>Returns the Z component of the current world gravity and initializes it to the default </para>
		/// <para>gravity if called for the first time. </para>
		/// <return>Z component of current world gravity. </return>
		/// </summary>
		public virtual float GetGravityZ()
			=> E_AWorldSettings_GetGravityZ(this);
		
		public int GetMaxNumberOfBookmarks()
			=> E_AWorldSettings_GetMaxNumberOfBookmarks(this);
		
		
		/// <summary>
		/// <return>whether given world is configured to host any NavigationSystem </return>
		/// </summary>
		public bool IsNavigationSystemEnabled()
			=> E_AWorldSettings_IsNavigationSystemEnabled(this);
		
		
		/// <summary>
		/// <para>Called from GameStateBase, calls BeginPlay on all actors </para>
		/// </summary>
		public virtual void NotifyBeginPlay()
			=> E_AWorldSettings_NotifyBeginPlay(this);
		
		
		/// <summary>
		/// <para>Called from GameStateBase, used to notify native classes of match startup (such as level scripting) </para>
		/// </summary>
		public virtual void NotifyMatchStarted()
			=> E_AWorldSettings_NotifyMatchStarted(this);
		
		public virtual void OnRep_WorldGravityZ()
			=> E_AWorldSettings_OnRep_WorldGravityZ(this);
		
		
		/// <summary>
		/// <para>Sets the global time dilation value (subject to clamping). Returns the final value that was set. </para>
		/// </summary>
		public virtual float SetTimeDilation(float newTimeDilation)
			=> E_AWorldSettings_SetTimeDilation(this, newTimeDilation);
		
		#endregion
		
		public static implicit operator IntPtr(AWorldSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator AWorldSettings(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AWorldSettings>(PtrDesc);
		}}}
