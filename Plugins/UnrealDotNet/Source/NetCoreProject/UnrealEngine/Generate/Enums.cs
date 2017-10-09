namespace UnrealEngine
{
	
	/// <summary>
	/// <para>Indicates that PreInitializeComponents/PostInitializeComponents have been called on this Actor </para>
	/// <para>Prevents re-initializing of actors spawned during level startup </para>
	/// </summary>
	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\GameFramework\Actor.h:597
	
	public enum EActorBeginPlayState : byte
	{
		HasNotBegunPlay,
		BeginningPlay,
		HasBegunPlay,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:42
	
	public enum EActorMetricsType : byte
	{
		METRICS_VERTS,
		METRICS_TRIS,
		METRICS_SECTIONS,
		METRICS_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SkeletalMeshComponent.h:153
	
	public enum EAllowKinematicDeferral : byte
	{
		AllowDeferral,
		DisallowDeferral,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3486
	
	public enum EAngularConstraintMotion : byte
	{
		ACM_Free,
		ACM_Limited,
		ACM_Locked,
		ACM_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Scene.h:32
	
	public enum EAntiAliasingMethod : byte
	{
		AAM_None,
		AAM_FXAA,
		AAM_TemporalAA,
		AAM_MSAA,
		AAM_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:31
	
	public enum EAspectRatioAxisConstraint : byte
	{
		AspectRatio_MaintainYFOV,
		AspectRatio_MaintainXFOV,
		AspectRatio_MajorAxisFOV,
		AspectRatio_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:67
	
	public enum EAttachmentRule : byte
	{
		KeepRelative,
		KeepWorld,
		SnapToTarget,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Scene.h:44
	
	public enum EAutoExposureMethod : byte
	{
		AEM_Histogram,
		AEM_Basic,
		AEM_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2762
	
	public enum EAutoPossessAI : byte
	{
		Disabled,
		PlacedInWorld,
		Spawned,
		PlacedInWorldOrSpawned,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:230
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Scene.h:54
	
	public enum EBloomMethod : byte
	{
		BM_SOG,
		BM_FFT,
		BM_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SkinnedMeshComponent.h:35
	
	public enum EBoneVisibilityStatus : byte
	{
		BVS_HiddenByParent,
		BVS_Visible,
		BVS_ExplicitlyHidden,
		BVS_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\PrimitiveComponent.h:35
	
	public enum ECanBeCharacterBase : byte
	{
		ECB_No,
		ECB_Yes,
		ECB_Owner,
		ECB_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:609
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:773
	
	public enum ECollisionResponse : byte
	{
		ECR_Ignore,
		ECR_Overlap,
		ECR_Block,
		ECR_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ActorComponent.h:30
	
	public enum EComponentCreationMethod : byte
	{
		Native,
		SimpleConstructionScript,
		UserConstructionScript,
		Instance,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Engine.h:99
	
	public enum EConsoleType : byte
	{
		CONSOLE_Any,
		CONSOLE_Mobile,
		CONSOLE_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Scene.h:22
	
	public enum EDepthOfFieldMethod : byte
	{
		DOFM_BokehDOF,
		DOFM_Gaussian,
		DOFM_CircleDOF,
		DOFM_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:117
	
	public enum EDetachmentRule : byte
	{
		KeepRelative,
		KeepWorld,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SceneComponent.h:51
	
	public enum EDetailMode : byte
	{
		DM_Low,
		DM_Medium,
		DM_High,
		DM_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:783
	
	public enum EFilterInterpolationType : byte
	{
		BSIT_Average,
		BSIT_Linear,
		BSIT_Cubic,
		BSIT_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:836
	
	public enum EFlushLevelStreamingType : byte
	{
		None,
		Full,
		Visibility,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Engine.h:65
	
	public enum EFullyLoadPackageType : byte
	{
		FULLYLOAD_Map,
		FULLYLOAD_Game_PreLoadClass,
		FULLYLOAD_Game_PostLoadClass,
		FULLYLOAD_Always,
		FULLYLOAD_Mutator,
		FULLYLOAD_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Engine.h:49
	
	public enum EGetWorldErrorMode : byte
	{
		ReturnNull,
		LogAndReturnNull,
		Assert,
	}

	
	/// <summary>
	/// <para>Max number of iterations used for each discrete simulation step. </para>
	/// <para>Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance. </para>
	/// <para>WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation. </para>
	/// <para>@see MaxSimulationTimeStep, bForceSubStepping </para>
	/// </summary>
	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\GameFramework\ProjectileMovementComponent.h:230
	
	public enum EHandleBlockingHitResult : byte
	{
		Deflect,
		AdvanceNextSubstep,
		Abort,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\TextRenderComponent.h:17
	
	public enum EHorizTextAligment : byte
	{
		EHTA_Left,
		EHTA_Center,
		EHTA_Right,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:203
	
	public enum EIndirectLightingCacheQuality : byte
	{
		ILCQ_Off,
		ILCQ_Point,
		ILCQ_Volume,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:793
	
	public enum EInputConsumeOptions : byte
	{
		ICO_ConsumeAll = 0,
		ICO_ConsumeBoundKeys,
		ICO_ConsumeNone,
		ICO_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:26
	
	public enum EInputEvent : byte
	{
		IE_Pressed = 0,
		IE_Released = 1,
		IE_Repeat = 2,
		IE_DoubleClick = 3,
		IE_Axis = 4,
		IE_MAX = 5,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\InterpToMovementComponent.h:14
	
	public enum EInterpToBehaviourType : byte
	{
		OneShot,
		OneShot_Reverse,
		Loop_Reset,
		PingPong,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3885
	
	public enum ELevelCollectionType : byte
	{
		DynamicSourceLevels,
		DynamicDuplicatedLevels,
		StaticLevels,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:63
	
	public enum ELevelTick : byte
	{
		LEVELTICK_TimeOnly = 0,
		LEVELTICK_ViewportsOnly = 1,
		LEVELTICK_All = 2,
		LEVELTICK_PauseTick = 3,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:485
	
	public enum ELightingBuildQuality : byte
	{
		Quality_Preview,
		Quality_Medium,
		Quality_High,
		Quality_Production,
		Quality_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:1793
	
	public enum ELightMapPaddingType : byte
	{
		LMPT_NormalPadding,
		LMPT_PrePadding,
		LMPT_NoPadding,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:469
	
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
		SAMPLERTYPE_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:438
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:456
	
	public enum EMaterialTessellationMode : byte
	{
		MTM_NoTessellation,
		MTM_FlatTessellation,
		MTM_PNTriangles,
		MTM_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3875
	
	public enum EMeshBufferAccess : byte
	{
		Default,
		ForceCPUAndGPU,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:37
	
	public enum EMouseCaptureMode : byte
	{
		NoCapture,
		CapturePermanently,
		CapturePermanently_IncludingInitialMouseDown,
		CaptureDuringMouseDown,
		CaptureDuringRightMouseDown,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:52
	
	public enum EMouseLockMode : byte
	{
		DoNotLock,
		LockOnCapture,
		LockAlways,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SceneComponent.h:76
	
	public enum EMoveComponentFlags : byte
	{
		MOVECOMP_NoFlags = 0x0000,
		MOVECOMP_IgnoreBases = 0x0001,
		MOVECOMP_SkipPhysicsMove = 0x0002,
		MOVECOMP_NeverIgnoreBlockingOverlaps = 0x0004,
		MOVECOMP_DisableBlockingOverlapDispatch = 0x0008,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:521
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2727
	
	public enum ENetDormancy : byte
	{
		DORM_Never,
		DORM_Awake,
		DORM_DormantAll,
		DORM_DormantPartial,
		DORM_Initial,
		DORN_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:876
	
	public enum ENetMode : byte
	{
		NM_Standalone,
		NM_DedicatedServer,
		NM_ListenServer,
		NM_Client,
		NM_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2712
	
	public enum ENetRole : byte
	{
		ROLE_None,
		ROLE_SimulatedProxy,
		ROLE_AutonomousProxy,
		ROLE_Authority,
		ROLE_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:554
	
	public enum ENetworkSmoothingMode : byte
	{
		Disabled,
		Linear,
		Exponential,
		Replay,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:678
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:214
	
	public enum EOcclusionCombineMode : byte
	{
		OCM_Minimum,
		OCM_Multiply,
		OCM_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2233
	
	public enum EOptimizeMode : byte
	{
		TrailMode,
		LookAheadMode,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:666
	
	public enum EOverlapFilterOption : byte
	{
		OverlapFilter_All,
		OverlapFilter_DynamicOnly,
		OverlapFilter_StaticOnly,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SkinnedMeshComponent.h:48
	
	public enum EPhysBodyOp : byte
	{
		PBO_None,
		PBO_Term,
		PBO_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3319
	
	public enum EPhysicalSurface : byte
	{
		SurfaceType_Default,
		SurfaceType1,
		SurfaceType2,
		SurfaceType3,
		SurfaceType4,
		SurfaceType5,
		SurfaceType6,
		SurfaceType7,
		SurfaceType8,
		SurfaceType9,
		SurfaceType10,
		SurfaceType11,
		SurfaceType12,
		SurfaceType13,
		SurfaceType14,
		SurfaceType15,
		SurfaceType16,
		SurfaceType17,
		SurfaceType18,
		SurfaceType19,
		SurfaceType20,
		SurfaceType21,
		SurfaceType22,
		SurfaceType23,
		SurfaceType24,
		SurfaceType25,
		SurfaceType26,
		SurfaceType27,
		SurfaceType28,
		SurfaceType29,
		SurfaceType30,
		SurfaceType31,
		SurfaceType32,
		SurfaceType33,
		SurfaceType34,
		SurfaceType35,
		SurfaceType36,
		SurfaceType37,
		SurfaceType38,
		SurfaceType39,
		SurfaceType40,
		SurfaceType41,
		SurfaceType42,
		SurfaceType43,
		SurfaceType44,
		SurfaceType45,
		SurfaceType46,
		SurfaceType47,
		SurfaceType48,
		SurfaceType49,
		SurfaceType50,
		SurfaceType51,
		SurfaceType52,
		SurfaceType53,
		SurfaceType54,
		SurfaceType55,
		SurfaceType56,
		SurfaceType57,
		SurfaceType58,
		SurfaceType59,
		SurfaceType60,
		SurfaceType61,
		SurfaceType62,
		SurfaceType_Max,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:759
	
	public enum EPhysicsSceneType : byte
	{
		PST_Sync,
		PST_Cloth,
		PST_Async,
		PST_MAX,
	}

	
	/// <summary>
	/// <para>static variable for default data to be used without reconstructing everytime </para>
	/// </summary>
	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:1087
	
	public enum ERadialImpulseFalloff : byte
	{
		RIF_Constant,
		RIF_Linear,
		RIF_MAX,
	}

	
	/// <summary>
	/// <para>Encodes the full HDR data of FullHDRData. </para>
	/// </summary>
	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ReflectionCaptureComponent.h:146
	
	public enum EReflectionSourceType : byte
	{
		CapturedScene,
		SpecifiedCubemap,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:300
	
	public enum ERefractionMode : byte
	{
		RM_IndexOfRefraction,
		RM_PixelNormalOffset,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SceneComponent.h:61
	
	public enum ERelativeTransformSpace : byte
	{
		RTS_World,
		RTS_Actor,
		RTS_Component,
		RTS_ParentBoneSpace,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\PrimitiveComponent.h:89
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2854
	
	public enum ERotatorQuantization : byte
	{
		ByteComponents,
		ShortComponents,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:243
	
	public enum ESamplerSourceMode : byte
	{
		SSM_FromTextureAsset,
		SSM_Wrap_WorldGroupSettings,
		SSM_Clamp_WorldGroupSettings,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:351
	
	public enum ESceneCaptureCompositeMode : byte
	{
		SCCM_Overwrite,
		SCCM_Additive,
		SCCM_Composite,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SceneCaptureComponent.h:47
	
	public enum ESceneCapturePrimitiveRenderMode : byte
	{
		PRM_LegacySceneCapture,
		PRM_RenderScenePrimitives,
		PRM_UseShowOnlyList,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:338
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:192
	
	public enum ESceneDepthPriorityGroup : byte
	{
		SDPG_World,
		SDPG_Foreground,
		SDPG_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:1803
	
	public enum EShadowMapFlags : byte
	{
		SMF_None = 0,
		SMF_Streamed = 0x00000001,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ShapeComponent.h:105
	
	public enum EShapeBodySetupHelper : byte
	{
		InvalidateSharingIfStale,
		UpdateBodySetup,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SkyLightComponent.h:89
	
	public enum ESkyLightSourceType : byte
	{
		SLS_CapturedScene,
		SLS_SpecifiedCubemap,
		SLS_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:1099
	
	public enum ESleepFamily : byte
	{
		Normal,
		Sensitive,
		Custom,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3818
	
	public enum ESpawnActorCollisionHandlingMethod : byte
	{
		Undefined,
		AlwaysSpawn,
		AdjustIfPossibleButAlwaysSpawn,
		AdjustIfPossibleButDontSpawnIfColliding,
		DontSpawnIfColliding,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\StereoLayerComponent.h:30
	
	public enum EStereoLayerShape : byte
	{
		SLSH_QuadLayer,
		SLSH_CylinderLayer,
		SLSH_CubemapLayer,
		SLSH_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\StereoLayerComponent.h:14
	
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
	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Object.h:605
	
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
	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Object.h:590
	
	public enum ETagType : byte
	{
		TT_Hidden,
		TT_Alphabetical,
		TT_Numerical,
		TT_Dimensional,
		TT_Chronological,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2102
	
	public enum ETeleportType : byte
	{
		None,
		TeleportPhysics,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:77
	
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
	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:228
	
	public enum ETickState : byte
	{
		Disabled,
		Enabled,
		CoolingDown,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\TimelineComponent.h:34
	
	public enum ETimelineLengthMode : byte
	{
		TL_TimelineLength,
		TL_LastKeyFrame,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:1112
	
	public enum ETimelineSigType : byte
	{
		ETS_EventSignature,
		ETS_FloatSignature,
		ETS_VectorSignature,
		ETS_LinearColorSignature,
		ETS_InvalidSignature,
		ETS_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:718
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:417
	
	public enum ETrailWidthMode : byte
	{
		ETrailWidthMode_FromCentre,
		ETrailWidthMode_FromFirst,
		ETrailWidthMode_FromSecond,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Engine.h:85
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:255
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:693
	
	public enum ETravelType : byte
	{
		TRAVEL_Absolute,
		TRAVEL_Partial,
		TRAVEL_Relative,
		TRAVEL_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:510
	
	public enum ETriangleSortAxis : byte
	{
		TSA_X_Axis,
		TSA_Y_Axis,
		TSA_Z_Axis,
		TSA_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:496
	
	public enum ETriangleSortOption : byte
	{
		TRISORT_None,
		TRISORT_CenterRadialDistance,
		TRISORT_Random,
		TRISORT_MergeContiguous,
		TRISORT_Custom,
		TRISORT_CustomLeftRight,
		TRISORT_MAX,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2214
	
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

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ActorComponent.h:44
	
	public enum EUpdateTransformFlags : byte
	{
		None = 0x0,
		SkipPhysicsUpdate = 0x1,
		PropagateFromParent = 0x2,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3833
	
	public enum EUserActivityContext : byte
	{
		Game,
		Editor,
		Other,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:2843
	
	public enum EVectorQuantization : byte
	{
		RoundWholeNumber,
		RoundOneDecimal,
		RoundTwoDecimals,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\TextRenderComponent.h:28
	
	public enum EVerticalTextAligment : byte
	{
		EVRTA_TextTop,
		EVRTA_TextCenter,
		EVRTA_TextBottom,
		EVRTA_QuadTop,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:901
	
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
		VMI_Max,
		VMI_Unknown = 255,
	}

	
	/// <summary>
	/// <para>Enum that dictates what propagation policy to follow when calling SetVisibility or SetHiddenInGame recursively </para>
	/// </summary>
	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SceneComponent.h:767
	
	public enum EVisibilityPropagation : byte
	{
		NoPropagation,
		DirtyOnly,
		Propagate,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3093
	
	public enum EWalkableSlopeBehavior : byte
	{
		WalkableSlope_Default,
		WalkableSlope_Increase,
		WalkableSlope_Decrease,
		WalkableSlope_Unwalkable,
		WalkableSlope_Max,
	}

	// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\WindDirectionalSourceComponent.h:12
	
	public enum EWindSourceType : byte
	{
		Directional,
		Point,
	}

}
