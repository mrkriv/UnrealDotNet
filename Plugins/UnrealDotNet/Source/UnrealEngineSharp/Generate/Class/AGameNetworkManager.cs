// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameNetworkManager.h:27

namespace UnrealEngine
{
	public  partial class AGameNetworkManager : AInfo
	{
		public AGameNetworkManager(IntPtr adress)
			: base(adress)
		{
		}

		public AGameNetworkManager(UObject Parent = null, string Name = "GameNetworkManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AGameNetworkManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameNetworkManager_AdjustedNetSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_AdjustedNetSpeed_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameNetworkManager_BadPingThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_BadPingThreshold_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyDetection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyDetection_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyForceCorrectionsDuringResolution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyForceCorrectionsDuringResolution_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyResolution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyResolution_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_AGameNetworkManager_bUseDistanceBasedRelevancy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_bUseDistanceBasedRelevancy_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_CLIENTADJUSTUPDATECOST_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_CLIENTADJUSTUPDATECOST_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_AGameNetworkManager_ClientAuthorativePosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_ClientAuthorativePosition_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_ClientErrorUpdateRateLimit_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_ClientErrorUpdateRateLimit_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeStationary_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeStationary_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeThrottled_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeThrottled_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleAtNetSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleAtNetSpeed_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleOverPlayerCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleOverPlayerCount_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_JoinInProgressStandbyWaitTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_JoinInProgressStandbyWaitTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_LastNetSpeedUpdateTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_LastNetSpeedUpdateTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MaxClientForcedUpdateDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MaxClientForcedUpdateDuration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MaxClientSmoothingDeltaTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MaxClientSmoothingDeltaTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MAXCLIENTUPDATEINTERVAL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MAXCLIENTUPDATEINTERVAL_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameNetworkManager_MaxDynamicBandwidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MaxDynamicBandwidth_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MaxMoveDeltaTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MaxMoveDeltaTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MAXNEARZEROVELOCITYSQUARED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MAXNEARZEROVELOCITYSQUARED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MAXPOSITIONERRORSQUARED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MAXPOSITIONERRORSQUARED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameNetworkManager_MinDynamicBandwidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MinDynamicBandwidth_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MovementTimeDiscrepancyDriftAllowance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MovementTimeDiscrepancyDriftAllowance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMaxTimeMargin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMaxTimeMargin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMinTimeMargin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMinTimeMargin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MovementTimeDiscrepancyResolutionRate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MovementTimeDiscrepancyResolutionRate_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_MoveRepSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_MoveRepSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_PercentForBadPing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_PercentForBadPing_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_PercentMissingForRxStandby_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_PercentMissingForRxStandby_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_PercentMissingForTxStandby_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_PercentMissingForTxStandby_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_StandbyRxCheatTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_StandbyRxCheatTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameNetworkManager_StandbyTxCheatTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_StandbyTxCheatTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameNetworkManager_TotalNetBandwidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameNetworkManager_TotalNetBandwidth_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AGameNetworkManager(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_AGameNetworkManager_CalculatedNetSpeed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameNetworkManager_EnableStandbyCheatDetection(IntPtr self, bool bIsEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameNetworkManager_ExceedsAllowablePositionError(IntPtr self, IntPtr locDiff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameNetworkManager_IsInLowBandwidthMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameNetworkManager_NetworkVelocityNearZero(IntPtr self, IntPtr inVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameNetworkManager_StandbyCheatDetected(IntPtr self, byte standbyType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameNetworkManager_UpdateNetSpeeds(IntPtr self, bool bIsLanMatch);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameNetworkManager_UpdateNetSpeedsTimer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameNetworkManager_WithinUpdateDelayBounds(IntPtr self, IntPtr pC, float lastUpdateTime);
		
		#endregion
		
		#region Property
		public int AdjustedNetSpeed
		{
			get => E_PROP_AGameNetworkManager_AdjustedNetSpeed_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_AdjustedNetSpeed_SET(NativePointer, value);
		}

		public int BadPingThreshold
		{
			get => E_PROP_AGameNetworkManager_BadPingThreshold_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_BadPingThreshold_SET(NativePointer, value);
		}

		public bool bMovementTimeDiscrepancyDetection
		{
			get => E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyDetection_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyDetection_SET(NativePointer, value);
		}

		public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution
		{
			get => E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyForceCorrectionsDuringResolution_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyForceCorrectionsDuringResolution_SET(NativePointer, value);
		}

		public bool bMovementTimeDiscrepancyResolution
		{
			get => E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyResolution_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_bMovementTimeDiscrepancyResolution_SET(NativePointer, value);
		}

		public bool bUseDistanceBasedRelevancy
		{
			get => E_PROP_AGameNetworkManager_bUseDistanceBasedRelevancy_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_bUseDistanceBasedRelevancy_SET(NativePointer, value);
		}

		public float CLIENTADJUSTUPDATECOST
		{
			get => E_PROP_AGameNetworkManager_CLIENTADJUSTUPDATECOST_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_CLIENTADJUSTUPDATECOST_SET(NativePointer, value);
		}

		public bool ClientAuthorativePosition
		{
			get => E_PROP_AGameNetworkManager_ClientAuthorativePosition_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_ClientAuthorativePosition_SET(NativePointer, value);
		}

		public float ClientErrorUpdateRateLimit
		{
			get => E_PROP_AGameNetworkManager_ClientErrorUpdateRateLimit_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_ClientErrorUpdateRateLimit_SET(NativePointer, value);
		}

		public float ClientNetSendMoveDeltaTime
		{
			get => E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTime_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTime_SET(NativePointer, value);
		}

		public float ClientNetSendMoveDeltaTimeStationary
		{
			get => E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeStationary_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeStationary_SET(NativePointer, value);
		}

		public float ClientNetSendMoveDeltaTimeThrottled
		{
			get => E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeThrottled_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_ClientNetSendMoveDeltaTimeThrottled_SET(NativePointer, value);
		}

		public int ClientNetSendMoveThrottleAtNetSpeed
		{
			get => E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleAtNetSpeed_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleAtNetSpeed_SET(NativePointer, value);
		}

		public int ClientNetSendMoveThrottleOverPlayerCount
		{
			get => E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleOverPlayerCount_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_ClientNetSendMoveThrottleOverPlayerCount_SET(NativePointer, value);
		}

		public float JoinInProgressStandbyWaitTime
		{
			get => E_PROP_AGameNetworkManager_JoinInProgressStandbyWaitTime_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_JoinInProgressStandbyWaitTime_SET(NativePointer, value);
		}

		public float LastNetSpeedUpdateTime
		{
			get => E_PROP_AGameNetworkManager_LastNetSpeedUpdateTime_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_LastNetSpeedUpdateTime_SET(NativePointer, value);
		}

		public float MaxClientForcedUpdateDuration
		{
			get => E_PROP_AGameNetworkManager_MaxClientForcedUpdateDuration_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MaxClientForcedUpdateDuration_SET(NativePointer, value);
		}

		public float MaxClientSmoothingDeltaTime
		{
			get => E_PROP_AGameNetworkManager_MaxClientSmoothingDeltaTime_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MaxClientSmoothingDeltaTime_SET(NativePointer, value);
		}

		public float MAXCLIENTUPDATEINTERVAL
		{
			get => E_PROP_AGameNetworkManager_MAXCLIENTUPDATEINTERVAL_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MAXCLIENTUPDATEINTERVAL_SET(NativePointer, value);
		}

		public int MaxDynamicBandwidth
		{
			get => E_PROP_AGameNetworkManager_MaxDynamicBandwidth_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MaxDynamicBandwidth_SET(NativePointer, value);
		}

		public float MaxMoveDeltaTime
		{
			get => E_PROP_AGameNetworkManager_MaxMoveDeltaTime_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MaxMoveDeltaTime_SET(NativePointer, value);
		}

		public float MAXNEARZEROVELOCITYSQUARED
		{
			get => E_PROP_AGameNetworkManager_MAXNEARZEROVELOCITYSQUARED_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MAXNEARZEROVELOCITYSQUARED_SET(NativePointer, value);
		}

		public float MAXPOSITIONERRORSQUARED
		{
			get => E_PROP_AGameNetworkManager_MAXPOSITIONERRORSQUARED_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MAXPOSITIONERRORSQUARED_SET(NativePointer, value);
		}

		public int MinDynamicBandwidth
		{
			get => E_PROP_AGameNetworkManager_MinDynamicBandwidth_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MinDynamicBandwidth_SET(NativePointer, value);
		}

		public float MovementTimeDiscrepancyDriftAllowance
		{
			get => E_PROP_AGameNetworkManager_MovementTimeDiscrepancyDriftAllowance_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MovementTimeDiscrepancyDriftAllowance_SET(NativePointer, value);
		}

		public float MovementTimeDiscrepancyMaxTimeMargin
		{
			get => E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMaxTimeMargin_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMaxTimeMargin_SET(NativePointer, value);
		}

		public float MovementTimeDiscrepancyMinTimeMargin
		{
			get => E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMinTimeMargin_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MovementTimeDiscrepancyMinTimeMargin_SET(NativePointer, value);
		}

		public float MovementTimeDiscrepancyResolutionRate
		{
			get => E_PROP_AGameNetworkManager_MovementTimeDiscrepancyResolutionRate_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MovementTimeDiscrepancyResolutionRate_SET(NativePointer, value);
		}

		public float MoveRepSize
		{
			get => E_PROP_AGameNetworkManager_MoveRepSize_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_MoveRepSize_SET(NativePointer, value);
		}

		public float PercentForBadPing
		{
			get => E_PROP_AGameNetworkManager_PercentForBadPing_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_PercentForBadPing_SET(NativePointer, value);
		}

		public float PercentMissingForRxStandby
		{
			get => E_PROP_AGameNetworkManager_PercentMissingForRxStandby_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_PercentMissingForRxStandby_SET(NativePointer, value);
		}

		public float PercentMissingForTxStandby
		{
			get => E_PROP_AGameNetworkManager_PercentMissingForTxStandby_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_PercentMissingForTxStandby_SET(NativePointer, value);
		}

		public float StandbyRxCheatTime
		{
			get => E_PROP_AGameNetworkManager_StandbyRxCheatTime_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_StandbyRxCheatTime_SET(NativePointer, value);
		}

		public float StandbyTxCheatTime
		{
			get => E_PROP_AGameNetworkManager_StandbyTxCheatTime_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_StandbyTxCheatTime_SET(NativePointer, value);
		}

		public int TotalNetBandwidth
		{
			get => E_PROP_AGameNetworkManager_TotalNetBandwidth_GET(NativePointer);
			set => E_PROP_AGameNetworkManager_TotalNetBandwidth_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// @RETURN new per/client bandwidth given number of players in the game
		/// </summary>
		public virtual int CalculatedNetSpeed()
			=> E_AGameNetworkManager_CalculatedNetSpeed(this);
		
		
		/// <summary>
		/// Turns standby detection on/off
		/// </summary>
		/// <param name="bIsEnabled">true to turn it on, false to disable it</param>
		public virtual void EnableStandbyCheatDetection(bool bIsEnabled)
			=> E_AGameNetworkManager_EnableStandbyCheatDetection(this, bIsEnabled);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public virtual bool ExceedsAllowablePositionError(FVector locDiff)
			=> E_AGameNetworkManager_ExceedsAllowablePositionError(this, locDiff);
		
		
		/// <summary>
		/// Returns true if we should be in low bandwidth mode
		/// </summary>
		public virtual bool IsInLowBandwidthMode()
			=> E_AGameNetworkManager_IsInLowBandwidthMode(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public virtual bool NetworkVelocityNearZero(FVector inVelocity)
			=> E_AGameNetworkManager_NetworkVelocityNearZero(this, inVelocity);
		
		
		/// <summary>
		/// Notifies the game code that a standby cheat was detected
		/// </summary>
		/// <param name="standbyType">the type of cheat detected</param>
		public virtual void StandbyCheatDetected(EStandbyType standbyType)
			=> E_AGameNetworkManager_StandbyCheatDetected(this, (byte)standbyType);
		
		
		/// <summary>
		/// Update network speeds for listen servers based on number of connected players.
		/// </summary>
		public virtual void UpdateNetSpeeds(bool bIsLanMatch)
			=> E_AGameNetworkManager_UpdateNetSpeeds(this, bIsLanMatch);
		
		
		/// <summary>
		/// Timer which calls UpdateNetSpeeds() once a second.
		/// </summary>
		public virtual void UpdateNetSpeedsTimer()
			=> E_AGameNetworkManager_UpdateNetSpeedsTimer(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public virtual bool WithinUpdateDelayBounds(APlayerController pC, float lastUpdateTime)
			=> E_AGameNetworkManager_WithinUpdateDelayBounds(this, pC, lastUpdateTime);
		
		#endregion
		
		public static implicit operator IntPtr(AGameNetworkManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AGameNetworkManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AGameNetworkManager>(PtrDesc);
		}}}
