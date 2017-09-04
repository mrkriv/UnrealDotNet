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

	public enum EAllowKinematicDeferral : byte
	{
		AllowDeferral,
		DisallowDeferral,
	}

	public enum EAntiAliasingMethod : byte
	{
		AAM_None,
		AAM_FXAA,
		AAM_TemporalAA,
		AAM_MSAA,
		AAM_MAX,
	}

	public enum EAutoExposureMethod : byte
	{
		AEM_Histogram,
		AEM_Basic,
		AEM_MAX,
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

	public enum EDetailMode : byte
	{
		DM_Low,
		DM_Medium,
		DM_High,
		DM_MAX,
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

	public enum ELevelTick : byte
	{
		LEVELTICK_TimeOnly = 0,
		LEVELTICK_ViewportsOnly = 1,
		LEVELTICK_All = 2,
		LEVELTICK_PauseTick = 3,
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

	public enum ENetMode : byte
	{
		NM_Standalone,
		NM_DedicatedServer,
		NM_ListenServer,
		NM_Client,
		NM_MAX,
	}

	public enum EPhysBodyOp : byte
	{
		PBO_None,
		PBO_Term,
		PBO_MAX,
	}

	
	/// <summary>
	/// <para>Encodes the full HDR data of FullHDRData. </para>
	/// </summary>
	public enum EReflectionSourceType : byte
	{
		CapturedScene,
		SpecifiedCubemap,
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

	public enum ESceneCapturePrimitiveRenderMode : byte
	{
		PRM_LegacySceneCapture,
		PRM_RenderScenePrimitives,
		PRM_UseShowOnlyList,
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

	public enum ETravelType : byte
	{
		TRAVEL_Absolute,
		TRAVEL_Partial,
		TRAVEL_Relative,
		TRAVEL_MAX,
	}

	public enum EUpdateTransformFlags : byte
	{
		None = 0x0,
		SkipPhysicsUpdate = 0x1,
		PropagateFromParent = 0x2,
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

	public enum EWindSourceType : byte
	{
		Directional,
		Point,
	}

}
