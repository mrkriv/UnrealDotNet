namespace UnrealEngine
{
	
	/// <summary>
	/// <para>Indicates that PreInitializeComponents/PostInitializeComponents have been called on this Actor </para>
	/// <para>Prevents re-initializing of actors spawned during level startup </para>
	/// </summary>
	public enum EActorBeginPlayState : byte
	{
		HasNotBegunPlay,
		BeginningPlay,
		HasBegunPlay,
	}

	public enum EActorMetricsType : byte
	{
		METRICS_VERTS,
		METRICS_TRIS,
		METRICS_SECTIONS,
		METRICS_MAX,
	}

	public enum EAllowKinematicDeferral : byte
	{
		AllowDeferral,
		DisallowDeferral,
	}

	public enum EAngularConstraintMotion : byte
	{
		ACM_Free,
		ACM_Limited,
		ACM_Locked,
		ACM_MAX,
	}

	public enum EAntiAliasingMethod : byte
	{
		AAM_None,
		AAM_FXAA,
		AAM_TemporalAA,
		AAM_MSAA,
		AAM_MAX,
	}

	public enum EAspectRatioAxisConstraint : byte
	{
		AspectRatio_MaintainYFOV,
		AspectRatio_MaintainXFOV,
		AspectRatio_MajorAxisFOV,
		AspectRatio_MAX,
	}

	public enum EAttachmentRule : byte
	{
		KeepRelative,
		KeepWorld,
		SnapToTarget,
	}

	public enum EAutoExposureMethod : byte
	{
		AEM_Histogram,
		AEM_Basic,
		AEM_MAX,
	}

	public enum EAutoPossessAI : byte
	{
		Disabled,
		PlacedInWorld,
		Spawned,
		PlacedInWorldOrSpawned,
	}

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

	public enum EBloomMethod : byte
	{
		BM_SOG,
		BM_FFT,
		BM_MAX,
	}

	public enum EBoneVisibilityStatus : byte
	{
		BVS_HiddenByParent,
		BVS_Visible,
		BVS_ExplicitlyHidden,
		BVS_MAX,
	}

	public enum ECanBeCharacterBase : byte
	{
		ECB_No,
		ECB_Yes,
		ECB_Owner,
		ECB_MAX,
	}

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

	public enum ECollisionResponse : byte
	{
		ECR_Ignore,
		ECR_Overlap,
		ECR_Block,
		ECR_MAX,
	}

	public enum EComponentCreationMethod : byte
	{
		Native,
		SimpleConstructionScript,
		UserConstructionScript,
		Instance,
	}

	public enum EConsoleType : byte
	{
		CONSOLE_Any,
		CONSOLE_Mobile,
		CONSOLE_MAX,
	}

	public enum EDepthOfFieldMethod : byte
	{
		DOFM_BokehDOF,
		DOFM_Gaussian,
		DOFM_CircleDOF,
		DOFM_MAX,
	}

	public enum EDetachmentRule : byte
	{
		KeepRelative,
		KeepWorld,
	}

	public enum EDetailMode : byte
	{
		DM_Low,
		DM_Medium,
		DM_High,
		DM_MAX,
	}

	public enum EFilterInterpolationType : byte
	{
		BSIT_Average,
		BSIT_Linear,
		BSIT_Cubic,
		BSIT_MAX,
	}

	public enum EFlushLevelStreamingType : byte
	{
		None,
		Full,
		Visibility,
	}

	public enum EFullyLoadPackageType : byte
	{
		FULLYLOAD_Map,
		FULLYLOAD_Game_PreLoadClass,
		FULLYLOAD_Game_PostLoadClass,
		FULLYLOAD_Always,
		FULLYLOAD_Mutator,
		FULLYLOAD_MAX,
	}

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
	public enum EHandleBlockingHitResult : byte
	{
		Deflect,
		AdvanceNextSubstep,
		Abort,
	}

	public enum EHorizTextAligment : byte
	{
		EHTA_Left,
		EHTA_Center,
		EHTA_Right,
	}

	public enum EIndirectLightingCacheQuality : byte
	{
		ILCQ_Off,
		ILCQ_Point,
		ILCQ_Volume,
	}

	public enum EInputConsumeOptions : byte
	{
		ICO_ConsumeAll = 0,
		ICO_ConsumeBoundKeys,
		ICO_ConsumeNone,
		ICO_MAX,
	}

	public enum EInputEvent : byte
	{
		IE_Pressed = 0,
		IE_Released = 1,
		IE_Repeat = 2,
		IE_DoubleClick = 3,
		IE_Axis = 4,
		IE_MAX = 5,
	}

	public enum EInterpToBehaviourType : byte
	{
		OneShot,
		OneShot_Reverse,
		Loop_Reset,
		PingPong,
	}

	public enum ELevelCollectionType : byte
	{
		DynamicSourceLevels,
		DynamicDuplicatedLevels,
		StaticLevels,
	}

	public enum ELevelTick : byte
	{
		LEVELTICK_TimeOnly = 0,
		LEVELTICK_ViewportsOnly = 1,
		LEVELTICK_All = 2,
		LEVELTICK_PauseTick = 3,
	}

	public enum ELightingBuildQuality : byte
	{
		Quality_Preview,
		Quality_Medium,
		Quality_High,
		Quality_Production,
		Quality_MAX,
	}

	public enum ELightMapPaddingType : byte
	{
		LMPT_NormalPadding,
		LMPT_PrePadding,
		LMPT_NoPadding,
	}

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

	public enum EMaterialTessellationMode : byte
	{
		MTM_NoTessellation,
		MTM_FlatTessellation,
		MTM_PNTriangles,
		MTM_MAX,
	}

	public enum EMeshBufferAccess : byte
	{
		Default,
		ForceCPUAndGPU,
	}

	public enum EMouseCaptureMode : byte
	{
		NoCapture,
		CapturePermanently,
		CapturePermanently_IncludingInitialMouseDown,
		CaptureDuringMouseDown,
		CaptureDuringRightMouseDown,
	}

	public enum EMouseLockMode : byte
	{
		DoNotLock,
		LockOnCapture,
		LockAlways,
	}

	public enum EMoveComponentFlags : byte
	{
		MOVECOMP_NoFlags = 0x0000,
		MOVECOMP_IgnoreBases = 0x0001,
		MOVECOMP_SkipPhysicsMove = 0x0002,
		MOVECOMP_NeverIgnoreBlockingOverlaps = 0x0004,
		MOVECOMP_DisableBlockingOverlapDispatch = 0x0008,
	}

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

	public enum ENetDormancy : byte
	{
		DORM_Never,
		DORM_Awake,
		DORM_DormantAll,
		DORM_DormantPartial,
		DORM_Initial,
		DORN_MAX,
	}

	public enum ENetMode : byte
	{
		NM_Standalone,
		NM_DedicatedServer,
		NM_ListenServer,
		NM_Client,
		NM_MAX,
	}

	public enum ENetRole : byte
	{
		ROLE_None,
		ROLE_SimulatedProxy,
		ROLE_AutonomousProxy,
		ROLE_Authority,
		ROLE_MAX,
	}

	public enum ENetworkSmoothingMode : byte
	{
		Disabled,
		Linear,
		Exponential,
		Replay,
	}

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

	public enum EOcclusionCombineMode : byte
	{
		OCM_Minimum,
		OCM_Multiply,
		OCM_MAX,
	}

	public enum EOptimizeMode : byte
	{
		TrailMode,
		LookAheadMode,
	}

	public enum EOverlapFilterOption : byte
	{
		OverlapFilter_All,
		OverlapFilter_DynamicOnly,
		OverlapFilter_StaticOnly,
	}

	public enum EPhysBodyOp : byte
	{
		PBO_None,
		PBO_Term,
		PBO_MAX,
	}

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
	public enum ERadialImpulseFalloff : byte
	{
		RIF_Constant,
		RIF_Linear,
		RIF_MAX,
	}

	
	/// <summary>
	/// <para>Encodes the full HDR data of FullHDRData. </para>
	/// </summary>
	public enum EReflectionSourceType : byte
	{
		CapturedScene,
		SpecifiedCubemap,
	}

	public enum ERefractionMode : byte
	{
		RM_IndexOfRefraction,
		RM_PixelNormalOffset,
	}

	public enum ERelativeTransformSpace : byte
	{
		RTS_World,
		RTS_Actor,
		RTS_Component,
		RTS_ParentBoneSpace,
	}

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

	public enum ERotatorQuantization : byte
	{
		ByteComponents,
		ShortComponents,
	}

	public enum ESamplerSourceMode : byte
	{
		SSM_FromTextureAsset,
		SSM_Wrap_WorldGroupSettings,
		SSM_Clamp_WorldGroupSettings,
	}

	public enum ESceneCaptureCompositeMode : byte
	{
		SCCM_Overwrite,
		SCCM_Additive,
		SCCM_Composite,
	}

	public enum ESceneCapturePrimitiveRenderMode : byte
	{
		PRM_LegacySceneCapture,
		PRM_RenderScenePrimitives,
		PRM_UseShowOnlyList,
	}

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

	public enum ESceneDepthPriorityGroup : byte
	{
		SDPG_World,
		SDPG_Foreground,
		SDPG_MAX,
	}

	public enum EShadowMapFlags : byte
	{
		SMF_None = 0,
		SMF_Streamed = 0x00000001,
	}

	public enum EShapeBodySetupHelper : byte
	{
		InvalidateSharingIfStale,
		UpdateBodySetup,
	}

	public enum ESkyLightSourceType : byte
	{
		SLS_CapturedScene,
		SLS_SpecifiedCubemap,
		SLS_MAX,
	}

	public enum ESleepFamily : byte
	{
		Normal,
		Sensitive,
		Custom,
	}

	public enum ESpawnActorCollisionHandlingMethod : byte
	{
		Undefined,
		AlwaysSpawn,
		AdjustIfPossibleButAlwaysSpawn,
		AdjustIfPossibleButDontSpawnIfColliding,
		DontSpawnIfColliding,
	}

	public enum EStereoLayerShape : byte
	{
		SLSH_QuadLayer,
		SLSH_CylinderLayer,
		SLSH_CubemapLayer,
		SLSH_MAX,
	}

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
	public enum ETagType : byte
	{
		TT_Hidden,
		TT_Alphabetical,
		TT_Numerical,
		TT_Dimensional,
		TT_Chronological,
	}

	public enum ETeleportType : byte
	{
		None,
		TeleportPhysics,
	}

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
	public enum ETickState : byte
	{
		Disabled,
		Enabled,
		CoolingDown,
	}

	public enum ETimelineLengthMode : byte
	{
		TL_TimelineLength,
		TL_LastKeyFrame,
	}

	public enum ETimelineSigType : byte
	{
		ETS_EventSignature,
		ETS_FloatSignature,
		ETS_VectorSignature,
		ETS_LinearColorSignature,
		ETS_InvalidSignature,
		ETS_MAX,
	}

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

	public enum ETrailWidthMode : byte
	{
		ETrailWidthMode_FromCentre,
		ETrailWidthMode_FromFirst,
		ETrailWidthMode_FromSecond,
	}

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

	public enum ETravelType : byte
	{
		TRAVEL_Absolute,
		TRAVEL_Partial,
		TRAVEL_Relative,
		TRAVEL_MAX,
	}

	public enum ETriangleSortAxis : byte
	{
		TSA_X_Axis,
		TSA_Y_Axis,
		TSA_Z_Axis,
		TSA_MAX,
	}

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

	public enum EUpdateTransformFlags : byte
	{
		None = 0x0,
		SkipPhysicsUpdate = 0x1,
		PropagateFromParent = 0x2,
	}

	public enum EUserActivityContext : byte
	{
		Game,
		Editor,
		Other,
	}

	public enum EVectorQuantization : byte
	{
		RoundWholeNumber,
		RoundOneDecimal,
		RoundTwoDecimals,
	}

	public enum EVerticalTextAligment : byte
	{
		EVRTA_TextTop,
		EVRTA_TextCenter,
		EVRTA_TextBottom,
		EVRTA_QuadTop,
	}

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
	public enum EVisibilityPropagation : byte
	{
		NoPropagation,
		DirtyOnly,
		Propagate,
	}

	public enum EWalkableSlopeBehavior : byte
	{
		WalkableSlope_Default,
		WalkableSlope_Increase,
		WalkableSlope_Decrease,
		WalkableSlope_Unwalkable,
		WalkableSlope_Max,
	}

	public enum EWindSourceType : byte
	{
		Directional,
		Point,
	}

}
