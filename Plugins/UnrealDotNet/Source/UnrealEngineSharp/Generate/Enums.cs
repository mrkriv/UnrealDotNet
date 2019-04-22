// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

namespace UnrealEngine
{
	
	/// <summary>
	/// <para>Enum defining if BeginPlay has started or finished </para>
	/// </summary>
	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:349
	
	public enum EActorBeginPlayState : byte
	{
		HasNotBegunPlay,
		BeginningPlay,
		HasBegunPlay,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:175
	
	public enum EAllowKinematicDeferral : byte
	{
		AllowDeferral,
		DisallowDeferral,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:58
	
	public enum EAnimCurveType : byte
	{
		AttributeCurve,
		MaterialCurve,
		MorphTargetCurve,
		MaxAnimCurveType,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:32
	
	public enum EAntiAliasingMethod : byte
	{
		AAM_None,
		AAM_FXAA,
		AAM_TemporalAA,
		AAM_MSAA,
		AAM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:32
	
	public enum EAspectRatioAxisConstraint : byte
	{
		AspectRatio_MaintainYFOV,
		AspectRatio_MaintainXFOV,
		AspectRatio_MajorAxisFOV,
		AspectRatio_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:56
	
	public enum EAttachmentRule : byte
	{
		KeepRelative,
		KeepWorld,
		SnapToTarget,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:44
	
	public enum EAutoExposureMethod : byte
	{
		AEM_Histogram,
		AEM_Basic,
		AEM_Manual,
		AEM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2777
	
	public enum EAutoPossessAI : byte
	{
		Disabled,
		PlacedInWorld,
		Spawned,
		PlacedInWorldOrSpawned,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:239
	
	public enum EBlendMode : byte
	{
		BLEND_Opaque,
		BLEND_Masked,
		BLEND_Translucent,
		BLEND_Additive,
		BLEND_Modulate,
		BLEND_AlphaComposite,
		BLEND_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:56
	
	public enum EBloomMethod : byte
	{
		BM_SOG,
		BM_FFT,
		BM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:32
	
	public enum EBoneVisibilityStatus : byte
	{
		BVS_HiddenByParent,
		BVS_Visible,
		BVS_ExplicitlyHidden,
		BVS_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:36
	
	public enum ECanBeCharacterBase : byte
	{
		ECB_No,
		ECB_Yes,
		ECB_Owner,
		ECB_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:605
	
	public enum ECollisionChannel : byte
	{
		ECC_WorldStatic,
		ECC_WorldDynamic,
		ECC_Pawn,
		ECC_Visibility,
		ECC_Camera,
		ECC_PhysicsBody,
		ECC_Vehicle,
		ECC_Destructible,
		ECC_EngineTraceChannel1,
		ECC_EngineTraceChannel2,
		ECC_EngineTraceChannel3,
		ECC_EngineTraceChannel4,
		ECC_EngineTraceChannel5,
		ECC_EngineTraceChannel6,
		ECC_GameTraceChannel1,
		ECC_GameTraceChannel2,
		ECC_GameTraceChannel3,
		ECC_GameTraceChannel4,
		ECC_GameTraceChannel5,
		ECC_GameTraceChannel6,
		ECC_GameTraceChannel7,
		ECC_GameTraceChannel8,
		ECC_GameTraceChannel9,
		ECC_GameTraceChannel10,
		ECC_GameTraceChannel11,
		ECC_GameTraceChannel12,
		ECC_GameTraceChannel13,
		ECC_GameTraceChannel14,
		ECC_GameTraceChannel15,
		ECC_GameTraceChannel16,
		ECC_GameTraceChannel17,
		ECC_GameTraceChannel18,
		ECC_OverlapAll_Deprecated,
		ECC_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:755
	
	public enum ECollisionResponse : byte
	{
		ECR_Ignore,
		ECR_Overlap,
		ECR_Block,
		ECR_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:106
	
	public enum EConsoleType : byte
	{
		CONSOLE_Any,
		CONSOLE_Mobile,
		CONSOLE_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:22
	
	public enum EDepthOfFieldMethod : byte
	{
		DOFM_BokehDOF,
		DOFM_Gaussian,
		DOFM_CircleDOF,
		DOFM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:106
	
	public enum EDetachmentRule : byte
	{
		KeepRelative,
		KeepWorld,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:50
	
	public enum EDetailMode : byte
	{
		DM_Low,
		DM_Medium,
		DM_High,
		DM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:114
	
	public enum EDynamicResolutionStatus : byte
	{
		Unsupported,
		Disabled,
		Paused,
		Enabled,
		DebugForceEnabled,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:765
	
	public enum EFilterInterpolationType : byte
	{
		BSIT_Average,
		BSIT_Linear,
		BSIT_Cubic,
		BSIT_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:808
	
	public enum EFlushLevelStreamingType : byte
	{
		None,
		Full,
		Visibility,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:72
	
	public enum EFullyLoadPackageType : byte
	{
		FULLYLOAD_Map,
		FULLYLOAD_Game_PreLoadClass,
		FULLYLOAD_Game_PostLoadClass,
		FULLYLOAD_Always,
		FULLYLOAD_Mutator,
		FULLYLOAD_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:56
	
	public enum EGetWorldErrorMode : byte
	{
		ReturnNull,
		LogAndReturnNull,
		Assert,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:342
	
	public enum EHandleBlockingHitResult : byte
	{
		Deflect,
		AdvanceNextSubstep,
		Abort,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TextRenderComponent.h:17
	
	public enum EHorizTextAligment : byte
	{
		EHTA_Left,
		EHTA_Center,
		EHTA_Right,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:192
	
	public enum EIndirectLightingCacheQuality : byte
	{
		ILCQ_Off,
		ILCQ_Point,
		ILCQ_Volume,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:26
	
	public enum EInputEvent : byte
	{
		IE_Pressed = 0,
		IE_Released = 1,
		IE_Repeat = 2,
		IE_DoubleClick = 3,
		IE_Axis = 4,
		IE_MAX = 5,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:14
	
	public enum EInterpToBehaviourType : byte
	{
		OneShot,
		OneShot_Reverse,
		Loop_Reset,
		PingPong,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:65
	
	public enum ELevelTick : byte
	{
		LEVELTICK_TimeOnly = 0,
		LEVELTICK_ViewportsOnly = 1,
		LEVELTICK_All = 2,
		LEVELTICK_PauseTick = 3,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:507
	
	public enum ELightingBuildQuality : byte
	{
		Quality_Preview,
		Quality_Medium,
		Quality_High,
		Quality_Production,
		Quality_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1775
	
	public enum ELightMapPaddingType : byte
	{
		LMPT_NormalPadding,
		LMPT_PrePadding,
		LMPT_NoPadding,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:204
	
	public enum ELightmapType : byte
	{
		Default,
		ForceSurface,
		ForceVolumetric,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:66
	
	public enum ELightUnits : byte
	{
		Unitless,
		Candelas,
		Lumens,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:491
	
	public enum EMaterialSamplerType : byte
	{
		SAMPLERTYPE_Color,
		SAMPLERTYPE_Grayscale,
		SAMPLERTYPE_Alpha,
		SAMPLERTYPE_Normal,
		SAMPLERTYPE_Masks,
		SAMPLERTYPE_DistanceFieldFont,
		SAMPLERTYPE_LinearColor,
		SAMPLERTYPE_LinearGrayscale,
		SAMPLERTYPE_External,
		SAMPLERTYPE_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:461
	
	public enum EMaterialShadingModel : byte
	{
		MSM_Unlit,
		MSM_DefaultLit,
		MSM_Subsurface,
		MSM_PreintegratedSkin,
		MSM_ClearCoat,
		MSM_SubsurfaceProfile,
		MSM_TwoSidedFoliage,
		MSM_Hair,
		MSM_Cloth,
		MSM_Eye,
		MSM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:478
	
	public enum EMaterialTessellationMode : byte
	{
		MTM_NoTessellation,
		MTM_FlatTessellation,
		MTM_PNTriangles,
		MTM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:37
	
	public enum EMouseCaptureMode : byte
	{
		NoCapture,
		CapturePermanently,
		CapturePermanently_IncludingInitialMouseDown,
		CaptureDuringMouseDown,
		CaptureDuringRightMouseDown,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:52
	
	public enum EMouseLockMode : byte
	{
		DoNotLock,
		LockOnCapture,
		LockAlways,
		LockInFullscreen,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:73
	
	public enum EMoveComponentFlags : byte
	{
		MOVECOMP_NoFlags = 0x0000,
		MOVECOMP_IgnoreBases = 0x0001,
		MOVECOMP_SkipPhysicsMove = 0x0002,
		MOVECOMP_NeverIgnoreBlockingOverlaps = 0x0004,
		MOVECOMP_DisableBlockingOverlapDispatch = 0x0008,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:518
	
	public enum EMovementMode : byte
	{
		MOVE_None,
		MOVE_Walking,
		MOVE_NavWalking,
		MOVE_Falling,
		MOVE_Swimming,
		MOVE_Flying,
		MOVE_Custom,
		MOVE_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2741
	
	public enum ENetDormancy : byte
	{
		DORM_Never,
		DORM_Awake,
		DORM_DormantAll,
		DORM_DormantPartial,
		DORM_Initial,
		DORM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:904
	
	public enum ENetMode : byte
	{
		NM_Standalone,
		NM_DedicatedServer,
		NM_ListenServer,
		NM_Client,
		NM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2726
	
	public enum ENetRole : byte
	{
		ROLE_None,
		ROLE_SimulatedProxy,
		ROLE_AutonomousProxy,
		ROLE_Authority,
		ROLE_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:550
	
	public enum ENetworkSmoothingMode : byte
	{
		Disabled,
		Linear,
		Exponential,
		Replay,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:675
	
	public enum EObjectTypeQuery : byte
	{
		ObjectTypeQuery1,
		ObjectTypeQuery2,
		ObjectTypeQuery3,
		ObjectTypeQuery4,
		ObjectTypeQuery5,
		ObjectTypeQuery6,
		ObjectTypeQuery7,
		ObjectTypeQuery8,
		ObjectTypeQuery9,
		ObjectTypeQuery10,
		ObjectTypeQuery11,
		ObjectTypeQuery12,
		ObjectTypeQuery13,
		ObjectTypeQuery14,
		ObjectTypeQuery15,
		ObjectTypeQuery16,
		ObjectTypeQuery17,
		ObjectTypeQuery18,
		ObjectTypeQuery19,
		ObjectTypeQuery20,
		ObjectTypeQuery21,
		ObjectTypeQuery22,
		ObjectTypeQuery23,
		ObjectTypeQuery24,
		ObjectTypeQuery25,
		ObjectTypeQuery26,
		ObjectTypeQuery27,
		ObjectTypeQuery28,
		ObjectTypeQuery29,
		ObjectTypeQuery30,
		ObjectTypeQuery31,
		ObjectTypeQuery32,
		ObjectTypeQuery_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:220
	
	public enum EOcclusionCombineMode : byte
	{
		OCM_Minimum,
		OCM_Multiply,
		OCM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2220
	
	public enum EOptimizeMode : byte
	{
		TrailMode,
		LookAheadMode,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:663
	
	public enum EOverlapFilterOption : byte
	{
		OverlapFilter_All,
		OverlapFilter_DynamicOnly,
		OverlapFilter_StaticOnly,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:45
	
	public enum EPhysBodyOp : byte
	{
		PBO_None,
		PBO_Term,
		PBO_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\MovementComponent.h:28
	
	public enum EPlaneConstraintAxisSetting : byte
	{
		Custom,
		X,
		Y,
		Z,
		UseGlobalPhysicsSetting,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\World.h:730
	
	public enum EProcessReason : byte
	{
		Add,
		Reevaluate,
	}

	
	/// <summary>
	/// <para>static variable for default data to be used without reconstructing everytime </para>
	/// </summary>
	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1063
	
	public enum ERadialImpulseFalloff : byte
	{
		RIF_Constant,
		RIF_Linear,
		RIF_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:88
	
	public enum EReflectedAndRefractedRayTracedShadows : byte
	{
		Disabled,
		Hard_shadows,
		Area_shadows,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ReflectionCaptureComponent.h:18
	
	public enum EReflectionSourceType : byte
	{
		CapturedScene,
		SpecifiedCubemap,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:74
	
	public enum EReflectionsType : byte
	{
		ScreenSpace,
		RayTracing,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:309
	
	public enum ERefractionMode : byte
	{
		RM_IndexOfRefraction,
		RM_PixelNormalOffset,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:60
	
	public enum ERelativeTransformSpace : byte
	{
		RTS_World,
		RTS_Actor,
		RTS_Component,
		RTS_ParentBoneSpace,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:91
	
	public enum ERendererStencilMask : byte
	{
		ERSM_Default,
		ERSM_255,
		ERSM_1,
		ERSM_2,
		ERSM_4,
		ERSM_8,
		ERSM_16,
		ERSM_32,
		ERSM_64,
		ERSM_128,
	}

	
	/// <summary>
	/// <para>Collection of the most recent ID mappings </para>
	/// </summary>
	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:2327
	
	public enum ERootMotionMapping : byte
	{
		MapSize = 16,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:252
	
	public enum ESamplerSourceMode : byte
	{
		SSM_FromTextureAsset,
		SSM_Wrap_WorldGroupSettings,
		SSM_Clamp_WorldGroupSettings,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:362
	
	public enum ESceneCaptureCompositeMode : byte
	{
		SCCM_Overwrite,
		SCCM_Additive,
		SCCM_Composite,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:48
	
	public enum ESceneCapturePrimitiveRenderMode : byte
	{
		PRM_LegacySceneCapture,
		PRM_RenderScenePrimitives,
		PRM_UseShowOnlyList,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:348
	
	public enum ESceneCaptureSource : byte
	{
		SCS_SceneColorHDR,
		SCS_SceneColorHDRNoAlpha,
		SCS_FinalColorLDR,
		SCS_SceneColorSceneDepth,
		SCS_SceneDepth,
		SCS_DeviceDepth,
		SCS_Normal,
		SCS_BaseColor,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:181
	
	public enum ESceneDepthPriorityGroup : byte
	{
		SDPG_World,
		SDPG_Foreground,
		SDPG_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1784
	
	public enum EShadowMapFlags : byte
	{
		SMF_None = 0,
		SMF_Streamed = 0x00000001,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ShapeComponent.h:105
	
	public enum EShapeBodySetupHelper : byte
	{
		InvalidateSharingIfStale,
		UpdateBodySetup,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkyLightComponent.h:86
	
	public enum ESkyLightSourceType : byte
	{
		SLS_CapturedScene,
		SLS_SpecifiedCubemap,
		SLS_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1167
	
	public enum ESleepEvent : byte
	{
		SET_Wakeup,
		SET_Sleep,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1074
	
	public enum ESleepFamily : byte
	{
		Normal,
		Sensitive,
		Custom,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\StereoLayerComponent.h:30
	
	public enum EStereoLayerShape : byte
	{
		SLSH_QuadLayer,
		SLSH_CylinderLayer,
		SLSH_CubemapLayer,
		SLSH_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\StereoLayerComponent.h:14
	
	public enum EStereoLayerType : byte
	{
		SLT_WorldLocked,
		SLT_TrackerLocked,
		SLT_FaceLocked,
		SLT_MAX,
	}

	
	/// <summary>
	/// <para>Flags controlling how this tag should be shown in the UI </para>
	/// </summary>
	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\CoreUObject\Public\UObject\Object.h:641
	
	public enum ETagDisplay : byte
	{
		TD_None = 0,
		TD_Date = 1<<0,
		TD_Time = 1<<1,
		TD_InvariantTz = 1<<2,
		TD_Memory = 1<<3,
	}

	
	/// <summary>
	/// <para>Enum specifying the type of this tag </para>
	/// </summary>
	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\CoreUObject\Public\UObject\Object.h:626
	
	public enum ETagType : byte
	{
		TT_Hidden,
		TT_Alphabetical,
		TT_Numerical,
		TT_Dimensional,
		TT_Chronological,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2089
	
	public enum ETeleportType : byte
	{
		None,
		TeleportPhysics,
		ResetPhysics,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ApplicationLifecycleComponent.h:15
	
	public enum ETemperatureSeverityType : byte
	{
		Unknown,
		Good,
		Bad,
		Serious,
		Critical,
		NumSeverities,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:79
	
	public enum ETickingGroup : byte
	{
		TG_PrePhysics,
		TG_StartPhysics,
		TG_DuringPhysics,
		TG_EndPhysics,
		TG_PostPhysics,
		TG_PostUpdateWork,
		TG_LastDemotable,
		TG_NewlySpawned,
		TG_MAX,
	}

	
	/// <summary>
	/// <para>Cache whether this function was rescheduled as an interval function during StartParallel </para>
	/// </summary>
	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:230
	
	public enum ETickState : byte
	{
		Disabled,
		Enabled,
		CoolingDown,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:34
	
	public enum ETimelineLengthMode : byte
	{
		TL_TimelineLength,
		TL_LastKeyFrame,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1086
	
	public enum ETimelineSigType : byte
	{
		ETS_EventSignature,
		ETS_FloatSignature,
		ETS_VectorSignature,
		ETS_LinearColorSignature,
		ETS_InvalidSignature,
		ETS_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:715
	
	public enum ETraceTypeQuery : byte
	{
		TraceTypeQuery1,
		TraceTypeQuery2,
		TraceTypeQuery3,
		TraceTypeQuery4,
		TraceTypeQuery5,
		TraceTypeQuery6,
		TraceTypeQuery7,
		TraceTypeQuery8,
		TraceTypeQuery9,
		TraceTypeQuery10,
		TraceTypeQuery11,
		TraceTypeQuery12,
		TraceTypeQuery13,
		TraceTypeQuery14,
		TraceTypeQuery15,
		TraceTypeQuery16,
		TraceTypeQuery17,
		TraceTypeQuery18,
		TraceTypeQuery19,
		TraceTypeQuery20,
		TraceTypeQuery21,
		TraceTypeQuery22,
		TraceTypeQuery23,
		TraceTypeQuery24,
		TraceTypeQuery25,
		TraceTypeQuery26,
		TraceTypeQuery27,
		TraceTypeQuery28,
		TraceTypeQuery29,
		TraceTypeQuery30,
		TraceTypeQuery31,
		TraceTypeQuery32,
		TraceTypeQuery_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:438
	
	public enum ETrailWidthMode : byte
	{
		ETrailWidthMode_FromCentre,
		ETrailWidthMode_FromFirst,
		ETrailWidthMode_FromSecond,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:92
	
	public enum ETransitionType : byte
	{
		TT_None,
		TT_Paused,
		TT_Loading,
		TT_Saving,
		TT_Connecting,
		TT_Precaching,
		TT_WaitingToConnect,
		TT_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:264
	
	public enum ETranslucencyLightingMode : byte
	{
		TLM_VolumetricNonDirectional,
		TLM_VolumetricDirectional,
		TLM_VolumetricPerVertexNonDirectional,
		TLM_VolumetricPerVertexDirectional,
		TLM_Surface,
		TLM_SurfacePerPixelLighting,
		TLM_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:81
	
	public enum ETranslucencyType : byte
	{
		Raster,
		RayTracing,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:701
	
	public enum ETravelType : byte
	{
		TRAVEL_Absolute,
		TRAVEL_Partial,
		TRAVEL_Relative,
		TRAVEL_MAX,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:671
	
	public enum EType : byte
	{
		AddImpulse,
		AddForce,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:34
	
	public enum EUpdateCommandType : byte
	{
		Add,
		Update,
		Hide,
		EditorData,
		LightmapData,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2201
	
	public enum EUpdateRateShiftBucket : byte
	{
		ShiftBucket0 = 0,
		ShiftBucket1,
		ShiftBucket2,
		ShiftBucket3,
		ShiftBucket4,
		ShiftBucket5,
		ShiftBucketMax,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ActorComponent.h:35
	
	public enum EUpdateTransformFlags : byte
	{
		None = 0x0,
		SkipPhysicsUpdate = 0x1,
		PropagateFromParent = 0x2,
		OnlyUpdateIfUsingSocket = 0x4,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TextRenderComponent.h:28
	
	public enum EVerticalTextAligment : byte
	{
		EVRTA_TextTop,
		EVRTA_TextCenter,
		EVRTA_TextBottom,
		EVRTA_QuadTop,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:929
	
	public enum EViewModeIndex : byte
	{
		VMI_BrushWireframe = 0,
		VMI_Wireframe = 1,
		VMI_Unlit = 2,
		VMI_Lit = 3,
		VMI_Lit_DetailLighting = 4,
		VMI_LightingOnly = 5,
		VMI_LightComplexity = 6,
		VMI_ShaderComplexity = 8,
		VMI_LightmapDensity = 9,
		VMI_LitLightmapDensity = 10,
		VMI_ReflectionOverride = 11,
		VMI_VisualizeBuffer = 12,
		VMI_StationaryLightOverlap = 14,
		VMI_CollisionPawn = 15,
		VMI_CollisionVisibility = 16,
		VMI_LODColoration = 18,
		VMI_QuadOverdraw = 19,
		VMI_PrimitiveDistanceAccuracy = 20,
		VMI_MeshUVDensityAccuracy = 21,
		VMI_ShaderComplexityWithQuadOverdraw = 22,
		VMI_HLODColoration = 23,
		VMI_GroupLODColoration = 24,
		VMI_MaterialTextureScaleAccuracy = 25,
		VMI_RequiredTextureResolution = 26,
		VMI_PathTracing = 27,
		VMI_RayTracingDebug = 28,
		VMI_Max,
		VMI_Unknown = 255,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:56
	
	public enum EVisibilityBasedAnimTickOption : byte
	{
		AlwaysTickPoseAndRefreshBones,
		AlwaysTickPose,
		OnlyTickMontagesWhenNotRendered,
		OnlyTickPoseWhenRendered,
	}

	
	/// <summary>
	/// <para>Enum that dictates what propagation policy to follow when calling SetVisibility or SetHiddenInGame recursively </para>
	/// </summary>
	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:797
	
	public enum EVisibilityPropagation : byte
	{
		NoPropagation,
		DirtyOnly,
		Propagate,
	}

	// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\WindDirectionalSourceComponent.h:12
	
	public enum EWindSourceType : byte
	{
		Directional,
		Point,
	}

}
