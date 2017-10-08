using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class AActor : UObject
	{
		public AActor(IntPtr Adress)
			: base(Adress)
		{
		}

		public AActor(UObject Parent = null, string Name = "Actor")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AActor(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AActor(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bActorSeamlessTraveled_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bActorSeamlessTraveled_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bAllowReceiveTickEventOnDedicatedServer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bAllowReceiveTickEventOnDedicatedServer_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bAllowTickBeforeBeginPlay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bAllowTickBeforeBeginPlay_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bAlwaysRelevant_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bAlwaysRelevant_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bAutoDestroyWhenFinished_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bAutoDestroyWhenFinished_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bBlockInput_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bBlockInput_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bCanBeDamaged_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bCanBeDamaged_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bCanBeInCluster_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bCanBeInCluster_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bCollideWhenPlacing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bCollideWhenPlacing_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bEnableAutoLODGeneration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bEnableAutoLODGeneration_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bExchangedRoles_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bExchangedRoles_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bFindCameraComponentWhenViewTarget_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bFindCameraComponentWhenViewTarget_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bHidden_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bHidden_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bIgnoresOriginShifting_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bIgnoresOriginShifting_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bNetLoadOnClient_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bNetLoadOnClient_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bNetStartup_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bNetStartup_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bNetTemporary_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bNetTemporary_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bNetUseOwnerRelevancy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bNetUseOwnerRelevancy_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bOnlyRelevantToOwner_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bOnlyRelevantToOwner_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bPendingNetUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bPendingNetUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bRelevantForNetworkReplays_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bRelevantForNetworkReplays_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bReplicateMovement_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bReplicateMovement_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bReplicates_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bReplicates_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bRunningUserConstructionScript_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bRunningUserConstructionScript_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_bTearOff_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_bTearOff_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AActor_CreationTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_CreationTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AActor_CustomTimeDilation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_CustomTimeDilation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AActor_InitialLifeSpan_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_InitialLifeSpan_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AActor_InputPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_InputPriority_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_AActor_Instigator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_Instigator_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AActor_LastNetUpdateTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_LastNetUpdateTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AActor_MinNetUpdateFrequency_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_MinNetUpdateFrequency_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AActor_NetCullDistanceSquared_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_NetCullDistanceSquared_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_AActor_NetDriverName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_NetDriverName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AActor_NetPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_NetPriority_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AActor_NetTag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_NetTag_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AActor_NetUpdateFrequency_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_NetUpdateFrequency_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AActor_NetUpdateTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_NetUpdateTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_AActor_OnActorBeginOverlap(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_AActor_OnActorBeginOverlap(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_AActor_OnActorEndOverlap(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_AActor_OnActorEndOverlap(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_AActor_OnActorHit(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_AActor_OnActorHit(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_AActor_OnBeginCursorOver(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_AActor_OnBeginCursorOver(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_AActor_OnDestroyed(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_AActor_OnDestroyed(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_AActor_OnEndCursorOver(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_AActor_OnEndCursorOver(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_AActor_PrimaryActorTick_GET(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_AActor_ReplicatedMovement_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_ReplicatedMovement_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_AActor_RootComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_RootComponent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AActor_SpawnCollisionHandlingMethod_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AActor_SpawnCollisionHandlingMethod_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_ActorHasTag(IntPtr Self, string Tag);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_ActorToWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_AddActorLocalOffset(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_AddActorLocalTransform(IntPtr Self, IntPtr NewTransform, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_AddActorWorldOffset(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_AddActorWorldTransform(IntPtr Self, IntPtr DeltaTransform, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AActor_AddComponent(IntPtr Self, string TemplateName, bool bManualAttachment, IntPtr RelativeTransform, IntPtr ComponentTemplateContext);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_AllowReceiveTickEventOnDedicatedServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_AttachToActor(IntPtr Self, IntPtr ParentActor, IntPtr AttachmentRules, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_AttachToComponent(IntPtr Self, IntPtr Parent, IntPtr AttachmentRules, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_CanEverTick(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_CheckStillInWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ClearComponentOverlaps(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ClearCrossLevelReferences(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_CopyRemoteRoleFrom(IntPtr Self, IntPtr CopyFromActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_DebugShowOneComponentHierarchy(IntPtr Self, IntPtr SceneComp, int NestLevel, bool bShowPosition);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_Destroy(IntPtr Self, bool bNetForce, bool bShouldModifyLevel);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_DestroyConstructedComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_DestroyNetworkActorHandled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_DetachAllSceneComponents(IntPtr Self, IntPtr InParentComponent, IntPtr DetachmentRules);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_DetachFromActor(IntPtr Self, IntPtr DetachmentRules);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_DetachRootComponentFromParent(IntPtr Self, bool bMaintainWorldPosition);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_DetachSceneComponentsFromParent(IntPtr Self, IntPtr InParentComponent, bool bMaintainWorldPosition);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_DispatchBeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ExchangeNetRoles(IntPtr Self, bool bRemoteOwner);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_FinishAndRegisterComponent(IntPtr Self, IntPtr Component);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_FlushNetDormancy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ForcePropertyCompare(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_GatherCurrentMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_GetActorBounds(IntPtr Self, bool bOnlyCollidingComponents, IntPtr Origin, IntPtr BoxExtent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_GetActorEnableCollision(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorForwardVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorQuat(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorRelativeScale3D(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorRightVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorScale3D(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetActorTickInterval(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetActorTimeDilation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetActorUpVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AActor_GetDefaultAttachComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetDistanceTo(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetDotProductTo(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetGameTimeSinceCreation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetHorizontalDistanceTo(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetHorizontalDotProductTo(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetInputAxisValue(IntPtr Self, string InputAxisName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetLifeSpan(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AActor_GetNetDriverName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_AActor_GetNetMode(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AActor_GetNetOwningPlayer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AActor_GetOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AActor_GetParentActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AActor_GetParentComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetPlacementExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_AActor_GetRemoteRole(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AActor_GetRootComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AActor_GetRootPrimitiveComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetSquaredDistanceTo(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_GetTickableWhenPaused(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_GetVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AActor_GetVerticalDistanceTo(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_HasActorBegunPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_HasAuthority(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_HasDeferredComponentRegistration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_HasNetOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_HasValidRootComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IncrementalRegisterComponents(IntPtr Self, int NumComponentsToRegister);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_InitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_InvalidateLightingCache(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_InvalidateLightingCacheDetailed(IntPtr Self, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsActorBeginningPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsActorBeingDestroyed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsActorInitialized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsActorTickEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsAttachedTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsBasedOnActor(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsLevelBoundsRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsMatineeControlled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsNetMode(IntPtr Self, byte Mode);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsOverlappingActor(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsOwnedBy(IntPtr Self, IntPtr TestOwner);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsPendingKillPending(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsRelevancyOwnerFor(IntPtr Self, IntPtr ReplicatedActor, IntPtr ActorOwner, IntPtr ConnectionActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsReplayRelevantFor(IntPtr Self, IntPtr RealViewer, IntPtr ViewTarget, IntPtr SrcLocation, float CullDistanceSquared);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsRootComponentMovable(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsRootComponentStatic(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_IsRootComponentStationary(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_AddActorLocalOffset(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_AddActorLocalRotation(IntPtr Self, IntPtr DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_AddActorLocalTransform(IntPtr Self, IntPtr NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_AddActorWorldOffset(IntPtr Self, IntPtr DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_AddActorWorldRotation(IntPtr Self, IntPtr DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_AddActorWorldTransform(IntPtr Self, IntPtr DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_AttachToActor(IntPtr Self, IntPtr ParentActor, string SocketName, byte LocationRule, byte RotationRule, byte ScaleRule, bool bWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_AttachToComponent(IntPtr Self, IntPtr Parent, string SocketName, byte LocationRule, byte RotationRule, byte ScaleRule, bool bWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_DestroyActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_DestroyComponent(IntPtr Self, IntPtr Component);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_DetachFromActor(IntPtr Self, byte LocationRule, byte RotationRule, byte ScaleRule);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_K2_GetActorLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AActor_K2_GetActorRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AActor_K2_GetRootComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_K2_SetActorLocation(IntPtr Self, IntPtr NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_K2_SetActorLocationAndRotation(IntPtr Self, IntPtr NewLocation, IntPtr NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_SetActorRelativeLocation(IntPtr Self, IntPtr NewRelativeLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_SetActorRelativeRotation(IntPtr Self, IntPtr NewRelativeRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_K2_SetActorRelativeTransform(IntPtr Self, IntPtr NewRelativeTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_K2_SetActorRotation(IntPtr Self, IntPtr NewRotation, bool bTeleportPhysics);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_K2_SetActorTransform(IntPtr Self, IntPtr NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_K2_TeleportTo(IntPtr Self, IntPtr DestLocation, IntPtr DestRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_LifeSpanExpired(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_MakeNoise(IntPtr Self, float Loudness, IntPtr NoiseInstigator, IntPtr NoiseLocation, float MaxRange, string Tag);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_MarkComponentsAsPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_MarkComponentsRenderStateDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_NotifyActorBeginCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_NotifyActorBeginOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_NotifyActorEndCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_NotifyActorEndOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_NotifyHit(IntPtr Self, IntPtr MyComp, IntPtr Other, IntPtr OtherComp, bool bSelfMoved, IntPtr HitLocation, IntPtr HitNormal, IntPtr NormalImpulse, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_OnConstruction(IntPtr Self, IntPtr Transform);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_OnRep_AttachmentReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_OnRep_Instigator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_OnRep_Owner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_OnRep_ReplicatedMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_OnRep_ReplicateMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_OnReplicationPausedChanged(IntPtr Self, bool bIsReplicationPaused);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_OnSubobjectCreatedFromReplication(IntPtr Self, IntPtr NewSubobject);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_OnSubobjectDestroyFromReplication(IntPtr Self, IntPtr Subobject);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostActorCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostInitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostNetInit(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostNetReceiveLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostNetReceiveLocationAndRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostNetReceivePhysicState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostNetReceiveVelocity(IntPtr Self, IntPtr NewVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostRegisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostSpawnInitialize(IntPtr Self, IntPtr SpawnTransform, IntPtr InOwner, IntPtr InInstigator, bool bRemoteOwned, bool bNoFail, bool bDeferConstruction);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PostUnregisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_PreInitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ReceiveActorBeginCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ReceiveActorBeginOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ReceiveActorEndCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ReceiveActorEndOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ReceiveBeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ReceiveDestroyed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ReceiveHit(IntPtr Self, IntPtr MyComp, IntPtr Other, IntPtr OtherComp, bool bSelfMoved, IntPtr HitLocation, IntPtr HitNormal, IntPtr NormalImpulse, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_RegisterAllActorTickFunctions(IntPtr Self, bool bRegister, bool bDoComponents);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_RegisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ReregisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_RerunConstructionScripts(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_ResetPropertiesForConstruction(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetActorEnableCollision(IntPtr Self, bool bNewActorEnableCollision);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetActorHiddenInGame(IntPtr Self, bool bNewHidden);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_SetActorLocation(IntPtr Self, IntPtr NewLocation, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetActorRelativeLocation(IntPtr Self, IntPtr NewRelativeLocation, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetActorRelativeScale3D(IntPtr Self, IntPtr NewRelativeScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetActorRelativeTransform(IntPtr Self, IntPtr NewRelativeTransform, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetActorScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetActorTickEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetActorTickInterval(IntPtr Self, float TickInterval);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_SetActorTransform(IntPtr Self, IntPtr NewTransform, bool bSweep, IntPtr OutSweepHitResult, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetAutonomousProxy(IntPtr Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetLifeSpan(IntPtr Self, float InLifespan);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetNetDormancy(IntPtr Self, byte NewDormancy);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetNetDriverName(IntPtr Self, string NewNetDriverName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetOwner(IntPtr Self, IntPtr NewOwner);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetRemoteRoleForBackwardsCompat(IntPtr Self, byte InRemoteRole);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetReplicateMovement(IntPtr Self, bool bInReplicateMovement);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetReplicates(IntPtr Self, bool bInReplicates);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_SetRootComponent(IntPtr Self, IntPtr NewRootComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetTickableWhenPaused(IntPtr Self, bool bTickableWhenPaused);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SetTickPrerequisite(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_ShouldTickIfViewportsOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SnapRootComponentTo(IntPtr Self, IntPtr InParentActor, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SwapRolesForReplay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_SyncReplicatedPhysicsSimulation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_TearOff(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_TeleportSucceeded(IntPtr Self, bool bIsATest);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_TeleportTo(IntPtr Self, IntPtr DestLocation, IntPtr DestRotation, bool bIsATest, bool bNoCheck);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_Tick(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_TickActor(IntPtr Self, float DeltaTime, byte TickType, IntPtr ThisTickFunction);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_UninitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_UnregisterAllComponents(IntPtr Self, bool bForReregister);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_UpdateComponentTransforms(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_UpdateOverlaps(IntPtr Self, bool bDoNotifies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AActor_UserConstructionScript(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AActor_UseShortConnectTimeout(IntPtr Self);
		
		#endregion
		
		#region Property
		public byte bActorSeamlessTraveled
		{
			get => E_PROP_AActor_bActorSeamlessTraveled_GET(NativePointer);
			set => E_PROP_AActor_bActorSeamlessTraveled_SET(NativePointer, value);
		}

		protected byte bAllowReceiveTickEventOnDedicatedServer
		{
			get => E_PROP_AActor_bAllowReceiveTickEventOnDedicatedServer_GET(NativePointer);
			set => E_PROP_AActor_bAllowReceiveTickEventOnDedicatedServer_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether we allow this Actor to tick before it receives the BeginPlay event. </para>
		/// <para>Normally we don't tick actors until after BeginPlay; this setting allows this behavior to be overridden. </para>
		/// <para>This Actor must be able to tick for this setting to be relevant. </para>
		/// </summary>
		public byte bAllowTickBeforeBeginPlay
		{
			get => E_PROP_AActor_bAllowTickBeforeBeginPlay_GET(NativePointer);
			set => E_PROP_AActor_bAllowTickBeforeBeginPlay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Always relevant for network (overrides bOnlyRelevantToOwner). </para>
		/// </summary>
		public byte bAlwaysRelevant
		{
			get => E_PROP_AActor_bAlwaysRelevant_GET(NativePointer);
			set => E_PROP_AActor_bAlwaysRelevant_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true then destroy self when "finished", meaning all relevant components report that they are done and no timelines or timers are in flight. </para>
		/// </summary>
		public byte bAutoDestroyWhenFinished
		{
			get => E_PROP_AActor_bAutoDestroyWhenFinished_GET(NativePointer);
			set => E_PROP_AActor_bAutoDestroyWhenFinished_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, all input on the stack below this actor will not be considered </para>
		/// </summary>
		public byte bBlockInput
		{
			get => E_PROP_AActor_bBlockInput_GET(NativePointer);
			set => E_PROP_AActor_bBlockInput_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether this actor can take damage. Must be true for damage events (e.g. ReceiveDamage()) to be called. </para>
		/// <para>@see https://www.unrealengine.com/blog/damage-in-ue4 </para>
		/// <para>@see TakeDamage(), ReceiveDamage() </para>
		/// </summary>
		public byte bCanBeDamaged
		{
			get => E_PROP_AActor_bCanBeDamaged_GET(NativePointer);
			set => E_PROP_AActor_bCanBeDamaged_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this actor can be put inside of a GC Cluster to improve Garbage Collection performance </para>
		/// </summary>
		protected byte bCanBeInCluster
		{
			get => E_PROP_AActor_bCanBeInCluster_GET(NativePointer);
			set => E_PROP_AActor_bCanBeInCluster_SET(NativePointer, value);
		}

		public byte bCollideWhenPlacing
		{
			get => E_PROP_AActor_bCollideWhenPlacing_GET(NativePointer);
			set => E_PROP_AActor_bCollideWhenPlacing_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, and if World setting has bEnableHierarchicalLOD equal to true, then it will generate LODActor from groups of clustered Actor </para>
		/// </summary>
		public byte bEnableAutoLODGeneration
		{
			get => E_PROP_AActor_bEnableAutoLODGeneration_GET(NativePointer);
			set => E_PROP_AActor_bEnableAutoLODGeneration_SET(NativePointer, value);
		}

		public byte bExchangedRoles
		{
			get => E_PROP_AActor_bExchangedRoles_GET(NativePointer);
			set => E_PROP_AActor_bExchangedRoles_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this actor should search for an owned camera component to view through when used as a view target. </para>
		/// </summary>
		public byte bFindCameraComponentWhenViewTarget
		{
			get => E_PROP_AActor_bFindCameraComponentWhenViewTarget_GET(NativePointer);
			set => E_PROP_AActor_bFindCameraComponentWhenViewTarget_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this actor will generate overlap events when spawned as part of level streaming. You might enable this is in the case where a streaming level loads around an actor and you want overlaps to trigger. </para>
		/// </summary>
		public byte bGenerateOverlapEventsDuringLevelStreaming
		{
			get => E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_GET(NativePointer);
			set => E_PROP_AActor_bGenerateOverlapEventsDuringLevelStreaming_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Allows us to only see this Actor in the Editor, and not in the actual game. </para>
		/// <para>@see SetActorHiddenInGame() </para>
		/// </summary>
		public byte ActorHiddenInGame
		{
			get => E_PROP_AActor_bHidden_GET(NativePointer);
			set => E_PROP_AActor_bHidden_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether this actor should not be affected by world origin shifting. </para>
		/// </summary>
		public byte bIgnoresOriginShifting
		{
			get => E_PROP_AActor_bIgnoresOriginShifting_GET(NativePointer);
			set => E_PROP_AActor_bIgnoresOriginShifting_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>This actor will be loaded on network clients during map load </para>
		/// </summary>
		public byte bNetLoadOnClient
		{
			get => E_PROP_AActor_bNetLoadOnClient_GET(NativePointer);
			set => E_PROP_AActor_bNetLoadOnClient_SET(NativePointer, value);
		}

		public byte bNetStartup
		{
			get => E_PROP_AActor_bNetStartup_GET(NativePointer);
			set => E_PROP_AActor_bNetStartup_SET(NativePointer, value);
		}

		public byte bNetTemporary
		{
			get => E_PROP_AActor_bNetTemporary_GET(NativePointer);
			set => E_PROP_AActor_bNetTemporary_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If actor has valid Owner, call Owner's IsNetRelevantFor and GetNetPriority </para>
		/// </summary>
		public byte bNetUseOwnerRelevancy
		{
			get => E_PROP_AActor_bNetUseOwnerRelevancy_GET(NativePointer);
			set => E_PROP_AActor_bNetUseOwnerRelevancy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this actor is only relevant to its owner. If this flag is changed during play, all non-owner channels would need to be explicitly closed. </para>
		/// </summary>
		public byte bOnlyRelevantToOwner
		{
			get => E_PROP_AActor_bOnlyRelevantToOwner_GET(NativePointer);
			set => E_PROP_AActor_bOnlyRelevantToOwner_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Is this actor still pending a full net update due to clients that weren't able to replicate the actor at the time of LastNetUpdateTime </para>
		/// </summary>
		public byte bPendingNetUpdate
		{
			get => E_PROP_AActor_bPendingNetUpdate_GET(NativePointer);
			set => E_PROP_AActor_bPendingNetUpdate_SET(NativePointer, value);
		}

		public byte bRelevantForNetworkReplays
		{
			get => E_PROP_AActor_bRelevantForNetworkReplays_GET(NativePointer);
			set => E_PROP_AActor_bRelevantForNetworkReplays_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, replicate movement/location related properties. </para>
		/// <para>Actor must also be set to replicate. </para>
		/// <para>@see SetReplicates() </para>
		/// <para>@see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication </para>
		/// </summary>
		public byte bReplicateMovement
		{
			get => E_PROP_AActor_bReplicateMovement_GET(NativePointer);
			set => E_PROP_AActor_bReplicateMovement_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this actor will replicate to remote machines </para>
		/// <para>@see SetReplicates() </para>
		/// </summary>
		protected byte bReplicates
		{
			get => E_PROP_AActor_bReplicates_GET(NativePointer);
			set => E_PROP_AActor_bReplicates_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>True if this actor is currently running user construction script (used to defer component registration) </para>
		/// </summary>
		public byte bRunningUserConstructionScript
		{
			get => E_PROP_AActor_bRunningUserConstructionScript_GET(NativePointer);
			set => E_PROP_AActor_bRunningUserConstructionScript_SET(NativePointer, value);
		}

		public byte bTearOff
		{
			get => E_PROP_AActor_bTearOff_GET(NativePointer);
			set => E_PROP_AActor_bTearOff_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The time this actor was created, relative to World->GetTimeSeconds(). </para>
		/// <para>@see UWorld::GetTimeSeconds() </para>
		/// </summary>
		public float CreationTime
		{
			get => E_PROP_AActor_CreationTime_GET(NativePointer);
			set => E_PROP_AActor_CreationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Allow each actor to run at a different time speed. The DeltaTime for a frame is multiplied by the global TimeDilation (in WorldSettings) and this CustomTimeDilation for this actor's tick. </para>
		/// </summary>
		public float CustomTimeDilation
		{
			get => E_PROP_AActor_CustomTimeDilation_GET(NativePointer);
			set => E_PROP_AActor_CustomTimeDilation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>How long this Actor lives before dying, 0=forever. Note this is the INITIAL value and should not be modified once play has begun. </para>
		/// </summary>
		protected float InitialLifeSpan
		{
			get => E_PROP_AActor_InitialLifeSpan_GET(NativePointer);
			set => E_PROP_AActor_InitialLifeSpan_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The priority of this input component when pushed in to the stack. </para>
		/// </summary>
		public int InputPriority
		{
			get => E_PROP_AActor_InputPriority_GET(NativePointer);
			set => E_PROP_AActor_InputPriority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Pawn responsible for damage caused by this actor. </para>
		/// </summary>
		public APawn Instigator
		{
			get => E_PROP_AActor_Instigator_GET(NativePointer);
			set => E_PROP_AActor_Instigator_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Last time this actor was updated for replication via NetUpdateTime </para>
		/// <para>@warning: internal net driver time, not related to WorldSettings.TimeSeconds </para>
		/// </summary>
		public float LastNetUpdateTime
		{
			get => E_PROP_AActor_LastNetUpdateTime_GET(NativePointer);
			set => E_PROP_AActor_LastNetUpdateTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Used to determine what rate to throttle down to when replicated properties are changing infrequently </para>
		/// </summary>
		public float MinNetUpdateFrequency
		{
			get => E_PROP_AActor_MinNetUpdateFrequency_GET(NativePointer);
			set => E_PROP_AActor_MinNetUpdateFrequency_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Square of the max distance from the client's viewpoint that this actor is relevant and will be replicated. </para>
		/// </summary>
		public float NetCullDistanceSquared
		{
			get => E_PROP_AActor_NetCullDistanceSquared_GET(NativePointer);
			set => E_PROP_AActor_NetCullDistanceSquared_SET(NativePointer, value);
		}

		protected string NetDriverName
		{
			get => E_PROP_AActor_NetDriverName_GET(NativePointer);
			set => E_PROP_AActor_NetDriverName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Priority for this actor when checking for replication in a low bandwidth or saturated situation, higher priority means it is more likely to replicate </para>
		/// </summary>
		public float NetPriority
		{
			get => E_PROP_AActor_NetPriority_GET(NativePointer);
			set => E_PROP_AActor_NetPriority_SET(NativePointer, value);
		}

		public int NetTag
		{
			get => E_PROP_AActor_NetTag_GET(NativePointer);
			set => E_PROP_AActor_NetTag_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>How often (per second) this actor will be considered for replication, used to determine NetUpdateTime </para>
		/// </summary>
		public float NetUpdateFrequency
		{
			get => E_PROP_AActor_NetUpdateFrequency_GET(NativePointer);
			set => E_PROP_AActor_NetUpdateFrequency_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Next time this actor will be considered for replication, set by SetNetUpdateTime() </para>
		/// </summary>
		public float NetUpdateTime
		{
			get => E_PROP_AActor_NetUpdateTime_GET(NativePointer);
			set => E_PROP_AActor_NetUpdateTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Primary Actor tick function, which calls TickActor(). </para>
		/// <para>Tick functions can be configured to control whether ticking is enabled, at what time during a frame the update occurs, and to set up tick dependencies. </para>
		/// <para>@see https://docs.unrealengine.com/latest/INT/API/Runtime/Engine/Engine/FTickFunction </para>
		/// <para>@see AddTickPrerequisiteActor(), AddTickPrerequisiteComponent() </para>
		/// </summary>
		public FActorTickFunction PrimaryActorTick
		{
			get => E_PROP_AActor_PrimaryActorTick_GET(NativePointer);
		}

		
		/// <summary>
		/// <para>Used for replication of our RootComponent's position and velocity </para>
		/// </summary>
		public FRepMovement ReplicatedMovement
		{
			get => E_PROP_AActor_ReplicatedMovement_GET(NativePointer);
			set => E_PROP_AActor_ReplicatedMovement_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Collision primitive that defines the transform (location, rotation, scale) of this Actor. </para>
		/// </summary>
		protected USceneComponent RootComponent
		{
			get => E_PROP_AActor_RootComponent_GET(NativePointer);
			set => E_PROP_AActor_RootComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls how to handle spawning this actor in a situation where it's colliding with something else. "Default" means AlwaysSpawn here. </para>
		/// </summary>
		public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingMethod
		{
			get => (ESpawnActorCollisionHandlingMethod)E_PROP_AActor_SpawnCollisionHandlingMethod_GET(NativePointer);
			set => E_PROP_AActor_SpawnCollisionHandlingMethod_SET(NativePointer, (byte)value);
		}

		#endregion
		
		#region Events
		
		/// <summary>
		/// <para>Called when another actor begins to overlap this actor, for example a player walking into a trigger. </para>
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public event FActorBeginOverlapSignature OnActorBeginOverlap
		{
			add
			{
				E_EVENT_ADD_AActor_OnActorBeginOverlap(NativePointer);
				_Event_OnActorBeginOverlap += value;
			}

			remove
			{
				E_EVENT_DEL_AActor_OnActorBeginOverlap(NativePointer);
				_Event_OnActorBeginOverlap -= value;
			}

		}

		private event FActorBeginOverlapSignature _Event_OnActorBeginOverlap;
		
		internal void InvokeEvent_OnActorBeginOverlap(ObjectPointerDescription OverlappedActor, ObjectPointerDescription OtherActor)
		{
			_Event_OnActorBeginOverlap?.Invoke(OverlappedActor, OtherActor);
		}

		
		/// <summary>
		/// <para>Called when another actor stops overlapping this actor. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public event FActorEndOverlapSignature OnActorEndOverlap
		{
			add
			{
				E_EVENT_ADD_AActor_OnActorEndOverlap(NativePointer);
				_Event_OnActorEndOverlap += value;
			}

			remove
			{
				E_EVENT_DEL_AActor_OnActorEndOverlap(NativePointer);
				_Event_OnActorEndOverlap -= value;
			}

		}

		private event FActorEndOverlapSignature _Event_OnActorEndOverlap;
		
		internal void InvokeEvent_OnActorEndOverlap(ObjectPointerDescription OverlappedActor, ObjectPointerDescription OtherActor)
		{
			_Event_OnActorEndOverlap?.Invoke(OverlappedActor, OtherActor);
		}

		
		/// <summary>
		/// <para>Called when this Actor hits (or is hit by) something solid. This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation. </para>
		/// <para>For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event. </para>
		/// <para>@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled. </para>
		/// </summary>
		public event FActorHitSignature OnActorHit
		{
			add
			{
				E_EVENT_ADD_AActor_OnActorHit(NativePointer);
				_Event_OnActorHit += value;
			}

			remove
			{
				E_EVENT_DEL_AActor_OnActorHit(NativePointer);
				_Event_OnActorHit -= value;
			}

		}

		private event FActorHitSignature _Event_OnActorHit;
		
		internal void InvokeEvent_OnActorHit(ObjectPointerDescription SelfActor, ObjectPointerDescription OtherActor, FVector NormalImpulse, FHitResult Hit)
		{
			_Event_OnActorHit?.Invoke(SelfActor, OtherActor, NormalImpulse, Hit);
		}

		
		/// <summary>
		/// <para>Called when the mouse cursor is moved over this actor if mouse over events are enabled in the player controller. </para>
		/// </summary>
		public event FActorBeginCursorOverSignature OnBeginCursorOver
		{
			add
			{
				E_EVENT_ADD_AActor_OnBeginCursorOver(NativePointer);
				_Event_OnBeginCursorOver += value;
			}

			remove
			{
				E_EVENT_DEL_AActor_OnBeginCursorOver(NativePointer);
				_Event_OnBeginCursorOver -= value;
			}

		}

		private event FActorBeginCursorOverSignature _Event_OnBeginCursorOver;
		
		internal void InvokeEvent_OnBeginCursorOver(ObjectPointerDescription TouchedActor)
		{
			_Event_OnBeginCursorOver?.Invoke(TouchedActor);
		}

		
		/// <summary>
		/// <para>Event triggered when the actor is destroyed. </para>
		/// </summary>
		public event FActorDestroyedSignature OnDestroyed
		{
			add
			{
				E_EVENT_ADD_AActor_OnDestroyed(NativePointer);
				_Event_OnDestroyed += value;
			}

			remove
			{
				E_EVENT_DEL_AActor_OnDestroyed(NativePointer);
				_Event_OnDestroyed -= value;
			}

		}

		private event FActorDestroyedSignature _Event_OnDestroyed;
		
		internal void InvokeEvent_OnDestroyed(ObjectPointerDescription DestroyedActor)
		{
			_Event_OnDestroyed?.Invoke(DestroyedActor);
		}

		
		/// <summary>
		/// <para>Called when the mouse cursor is moved off this actor if mouse over events are enabled in the player controller. </para>
		/// </summary>
		public event FActorEndCursorOverSignature OnEndCursorOver
		{
			add
			{
				E_EVENT_ADD_AActor_OnEndCursorOver(NativePointer);
				_Event_OnEndCursorOver += value;
			}

			remove
			{
				E_EVENT_DEL_AActor_OnEndCursorOver(NativePointer);
				_Event_OnEndCursorOver -= value;
			}

		}

		private event FActorEndCursorOverSignature _Event_OnEndCursorOver;
		
		internal void InvokeEvent_OnEndCursorOver(ObjectPointerDescription TouchedActor)
		{
			_Event_OnEndCursorOver?.Invoke(TouchedActor);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>See if this actor contains the supplied tag </para>
		/// </summary>
		public bool ActorHasTag(string Tag)
			=> E_AActor_ActorHasTag(this, Tag);
		
		
		/// <summary>
		/// <para>Get the local-to-world transform of the RootComponent. Identical to GetTransform(). </para>
		/// </summary>
		public FTransform ActorToWorld()
			=> E_AActor_ActorToWorld(this);
		
		public void AddActorLocalOffset(FVector DeltaLocation, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_AActor_AddActorLocalOffset(this, DeltaLocation, bSweep, OutSweepHitResult, (byte)Teleport);
		
		public void AddActorLocalTransform(FTransform NewTransform, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_AActor_AddActorLocalTransform(this, NewTransform, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the location of this actor in world space. </para>
		/// <param name="DeltaLocation">The change in location. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="Teleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If TeleportPhysics, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If None, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// <param name="SweepHitResult">The hit result from the move if swept. </param>
		/// </summary>
		public void AddActorWorldOffset(FVector DeltaLocation, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_AActor_AddActorWorldOffset(this, DeltaLocation, bSweep, OutSweepHitResult, (byte)Teleport);
		
		public void AddActorWorldTransform(FTransform DeltaTransform, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_AActor_AddActorWorldTransform(this, DeltaTransform, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Creates a new component and assigns ownership to the Actor this is </para>
		/// <para>called for. Automatic attachment causes the first component created to </para>
		/// <para>become the root, and all subsequent components to be attached under that </para>
		/// <para>root. When bManualAttachment is set, automatic attachment is </para>
		/// <para>skipped and it is up to the user to attach the resulting component (or </para>
		/// <para>set it up as the root) themselves. </para>
		/// <para>@see UK2Node_AddComponent	DO NOT CALL MANUALLY - BLUEPRINT INTERNAL USE ONLY (for Add Component nodes) </para>
		/// <param name="TemplateName">The name of the Component Template to use. </param>
		/// <param name="bManualAttachment">Whether manual or automatic attachment is to be used </param>
		/// <param name="RelativeTransform">The relative transform between the new component and its attach parent (automatic only) </param>
		/// <param name="ComponentTemplateContext">Optional UBlueprintGeneratedClass reference to use to find the template in. If null (or not a BPGC), component is sought in this Actor's class </param>
		/// </summary>
		public UActorComponent AddComponent(string TemplateName, bool bManualAttachment, FTransform RelativeTransform, UObject ComponentTemplateContext)
			=> E_AActor_AddComponent(this, TemplateName, bManualAttachment, RelativeTransform, ComponentTemplateContext);
		
		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteActor. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public virtual void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_AActor_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteComponent. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public virtual void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_AActor_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Return the value of bAllowReceiveTickEventOnDedicatedServer, indicating whether the Blueprint ReceiveTick() event will occur on dedicated servers. </para>
		/// </summary>
		public bool AllowReceiveTickEventOnDedicatedServer()
			=> E_AActor_AllowReceiveTickEventOnDedicatedServer(this);
		
		
		/// <summary>
		/// <para>Called by owning level to shift an actor location and all relevant data structures by specified delta </para>
		/// <param name="InWorldOffset">Offset vector to shift actor location </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public virtual void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_AActor_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		
		/// <summary>
		/// <para>Attaches the RootComponent of this Actor to the RootComponent of the supplied actor, optionally at a named socket. </para>
		/// <param name="ParentActor">Actor to attach this actor's RootComponent to </param>
		/// <param name="AttachmentRules">How to handle transforms and modification when attaching. </param>
		/// <param name="SocketName">Socket name to attach to, if any </param>
		/// </summary>
		public void AttachToActor(AActor ParentActor, FAttachmentTransformRules AttachmentRules, string SocketName)
			=> E_AActor_AttachToActor(this, ParentActor, AttachmentRules, SocketName);
		
		
		/// <summary>
		/// <para>Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered. </para>
		/// <param name="Parent">Parent to attach to. </param>
		/// <param name="AttachmentRules">How to handle transforms and welding when attaching. </param>
		/// <param name="SocketName">Optional socket to attach to on the parent. </param>
		/// </summary>
		public void AttachToComponent(USceneComponent Parent, FAttachmentTransformRules AttachmentRules, string SocketName)
			=> E_AActor_AttachToComponent(this, Parent, AttachmentRules, SocketName);
		
		
		/// <summary>
		/// <para>Overridable native event for when play begins for this actor. </para>
		/// </summary>
		protected virtual void BeginPlay()
			=> E_AActor_BeginPlay(this);
		
		
		/// <summary>
		/// <para>accessor for the value of bCanEverTick </para>
		/// </summary>
		public bool CanEverTick()
			=> E_AActor_CanEverTick(this);
		
		
		/// <summary>
		/// <para>This will check to see if the Actor is still in the world.  It will check things like </para>
		/// <para>the KillZ, outside world bounds, etc. and handle the situation. </para>
		/// </summary>
		public virtual bool CheckStillInWorld()
			=> E_AActor_CheckStillInWorld(this);
		
		
		/// <summary>
		/// <para>Dispatch all EndOverlap for all of the Actor's PrimitiveComponents. </para>
		/// <para>Generally used when removing the Actor from the world. </para>
		/// </summary>
		public void ClearComponentOverlaps()
			=> E_AActor_ClearComponentOverlaps(this);
		
		
		/// <summary>
		/// <para>Do anything needed to clear out cross level references; Called from ULevel::PreSave </para>
		/// </summary>
		public virtual void ClearCrossLevelReferences()
			=> E_AActor_ClearCrossLevelReferences(this);
		
		
		/// <summary>
		/// <para>Copies RemoteRole from another Actor and adds this actor to the list of network actors if necessary. </para>
		/// </summary>
		public void CopyRemoteRoleFrom(AActor CopyFromActor)
			=> E_AActor_CopyRemoteRoleFrom(this, CopyFromActor);
		
		
		/// <summary>
		/// <para>Debug helper for showing the component hierarchy of one component </para>
		/// <param name="Info">Optional String to display at top of info </param>
		/// </summary>
		public void DebugShowOneComponentHierarchy(USceneComponent SceneComp, int NestLevel, bool bShowPosition)
			=> E_AActor_DebugShowOneComponentHierarchy(this, SceneComp, NestLevel, bShowPosition);
		
		
		/// <summary>
		/// <para>Destroy this actor. Returns true the actor is destroyed or already marked for destruction, false if indestructible. </para>
		/// <para>Destruction is latent. It occurs at the end of the tick. </para>
		/// <param name="bNetForce">opt] Ignored unless called during play.  Default is false. </param>
		/// <param name="bShouldModifyLevel">opt] If true, Modify() the level before removing the actor.  Default is true. </param>
		/// <para>returns	true if destroyed or already marked for destruction, false if indestructible. </para>
		/// </summary>
		public bool Destroy(bool bNetForce = false, bool bShouldModifyLevel = true)
			=> E_AActor_Destroy(this, bNetForce, bShouldModifyLevel);
		
		
		/// <summary>
		/// <para>Destroys the constructed components. </para>
		/// </summary>
		public void DestroyConstructedComponents()
			=> E_AActor_DestroyConstructedComponents(this);
		
		
		/// <summary>
		/// <para>Called by DestroyActor(), gives actors a chance to op out of actor destruction </para>
		/// <para>Used by network code to have the net connection timeout/cleanup first </para>
		/// <return>true if DestroyActor() should not continue with actor destruction, false otherwise </return>
		/// </summary>
		public virtual bool DestroyNetworkActorHandled()
			=> E_AActor_DestroyNetworkActorHandled(this);
		
		
		/// <summary>
		/// <para>Detaches all SceneComponents in this Actor from the supplied parent SceneComponent. </para>
		/// <param name="InParentComponent">SceneComponent to detach this actor's components from </param>
		/// <param name="DetachmentRules">Rules to apply when detaching components </param>
		/// </summary>
		public void DetachAllSceneComponents(USceneComponent InParentComponent, FDetachmentTransformRules DetachmentRules)
			=> E_AActor_DetachAllSceneComponents(this, InParentComponent, DetachmentRules);
		
		
		/// <summary>
		/// <para>Detaches the RootComponent of this Actor from any SceneComponent it is currently attached to. </para>
		/// <param name="DetachmentRules">How to handle transforms when detaching. </param>
		/// </summary>
		public void DetachFromActor(FDetachmentTransformRules DetachmentRules)
			=> E_AActor_DetachFromActor(this, DetachmentRules);
		
		
		/// <summary>
		/// <para>Detaches the RootComponent of this Actor from any SceneComponent it is currently attached to. </para>
		/// <param name="bMaintainWorldTransform">If true, update the relative location/rotation of this component to keep its world position the same </param>
		/// </summary>
		public void DetachActorFromActorDeprecated(bool bMaintainWorldPosition = true)
			=> E_AActor_DetachRootComponentFromParent(this, bMaintainWorldPosition);
		
		
		/// <summary>
		/// <para>DEPRECATED: Detaches all SceneComponents in this Actor from the supplied parent SceneComponent. </para>
		/// <param name="InParentComponent">SceneComponent to detach this actor's components from </param>
		/// <param name="bMaintainWorldTransform">If true, update the relative location/rotation of this component to keep its world position the same </param>
		/// </summary>
		public void DetachSceneComponentsFromParent(USceneComponent InParentComponent, bool bMaintainWorldPosition = true)
			=> E_AActor_DetachSceneComponentsFromParent(this, InParentComponent, bMaintainWorldPosition);
		
		
		/// <summary>
		/// <para>Initiate a begin play call on this Actor, will handle . </para>
		/// </summary>
		public void DispatchBeginPlay()
			=> E_AActor_DispatchBeginPlay(this);
		
		
		/// <summary>
		/// <para>Swaps Role and RemoteRole if client </para>
		/// </summary>
		public void ExchangeNetRoles(bool bRemoteOwner)
			=> E_AActor_ExchangeNetRoles(this, bRemoteOwner);
		
		
		/// <summary>
		/// <para>Helper function to register the specified component, and add it to the serialized components array </para>
		/// <param name="Component">Component to be finalized </param>
		/// </summary>
		public void FinishAndRegisterComponent(UActorComponent Component)
			=> E_AActor_FinishAndRegisterComponent(this, Component);
		
		
		/// <summary>
		/// <para>Forces dormant actor to replicate but doesn't change NetDormancy state (i.e., they will go dormant again if left dormant) </para>
		/// </summary>
		public void FlushNetDormancy()
			=> E_AActor_FlushNetDormancy(this);
		
		
		/// <summary>
		/// <para>Forces properties on this actor to do a compare for one frame (rather than share shadow state) </para>
		/// </summary>
		public void ForcePropertyCompare()
			=> E_AActor_ForcePropertyCompare(this);
		
		
		/// <summary>
		/// <para>fills ReplicatedMovement property </para>
		/// </summary>
		public virtual void GatherCurrentMovement()
			=> E_AActor_GatherCurrentMovement(this);
		
		
		/// <summary>
		/// <para>Returns the bounding box of all components that make up this Actor (excluding ChildActorComponents). </para>
		/// <param name="bOnlyCollidingComponents">If true, will only return the bounding box for components with collision enabled. </param>
		/// </summary>
		public void GetActorBounds(bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent)
			=> E_AActor_GetActorBounds(this, bOnlyCollidingComponents, Origin, BoxExtent);
		
		
		/// <summary>
		/// <para>Get current state of collision for the whole actor </para>
		/// </summary>
		public bool GetActorEnableCollision()
			=> E_AActor_GetActorEnableCollision(this);
		
		
		/// <summary>
		/// <para>Get the forward (X) vector (length 1.0) from this Actor, in world space. </para>
		/// </summary>
		public FVector GetActorForwardVector()
			=> E_AActor_GetActorForwardVector(this);
		
		
		/// <summary>
		/// <para>Returns the location of the RootComponent of this Actor </para>
		/// </summary>
		public FVector GetActorLocation()
			=> E_AActor_GetActorLocation(this);
		
		
		/// <summary>
		/// <para>Returns the quaternion of the RootComponent of this Actor </para>
		/// </summary>
		public FQuat GetActorQuat()
			=> E_AActor_GetActorQuat(this);
		
		
		/// <summary>
		/// <para>Return the actor's relative scale 3d </para>
		/// </summary>
		public FVector GetActorRelativeScale3D()
			=> E_AActor_GetActorRelativeScale3D(this);
		
		
		/// <summary>
		/// <para>Get the right (Y) vector (length 1.0) from this Actor, in world space. </para>
		/// </summary>
		public FVector GetActorRightVector()
			=> E_AActor_GetActorRightVector(this);
		
		
		/// <summary>
		/// <para>Returns the rotation of the RootComponent of this Actor </para>
		/// </summary>
		public FRotator GetActorRotation()
			=> E_AActor_GetActorRotation(this);
		
		
		/// <summary>
		/// <para>Returns the scale of the RootComponent of this Actor </para>
		/// </summary>
		public FVector GetActorScale()
			=> E_AActor_GetActorScale(this);
		
		
		/// <summary>
		/// <para>Returns the Actor's world-space scale. </para>
		/// </summary>
		public FVector GetActorScale3D()
			=> E_AActor_GetActorScale3D(this);
		
		
		/// <summary>
		/// <para>Returns the tick interval of this actor's primary tick function </para>
		/// </summary>
		public float GetActorTickInterval()
			=> E_AActor_GetActorTickInterval(this);
		
		
		/// <summary>
		/// <para>Get CustomTimeDilation - this can be used for input control or speed control for slomo. </para>
		/// <para>We don't want to scale input globally because input can be used for UI, which do not care for TimeDilation. </para>
		/// </summary>
		public float GetActorTimeDilation()
			=> E_AActor_GetActorTimeDilation(this);
		
		
		/// <summary>
		/// <para>Returns the transform of the RootComponent of this Actor </para>
		/// </summary>
		public FTransform GetActorTransform()
			=> E_AActor_GetActorTransform(this);
		
		
		/// <summary>
		/// <para>Get the up (Z) vector (length 1.0) from this Actor, in world space. </para>
		/// </summary>
		public FVector GetActorUpVector()
			=> E_AActor_GetActorUpVector(this);
		
		
		/// <summary>
		/// <para>Returns this actor's default attachment component for attaching children to </para>
		/// <return>The scene component to be used as parent </return>
		/// </summary>
		public virtual USceneComponent GetDefaultAttachComponent()
			=> E_AActor_GetDefaultAttachComponent(this);
		
		
		/// <summary>
		/// <para>Returns the distance from this Actor to OtherActor. </para>
		/// </summary>
		public float GetDistanceTo(AActor OtherActor)
			=> E_AActor_GetDistanceTo(this, OtherActor);
		
		
		/// <summary>
		/// <para>Returns the dot product from this Actor to OtherActor. Returns -2.0 on failure. Returns 0.0 for coincidental actors. </para>
		/// </summary>
		public float GetDotProductTo(AActor OtherActor)
			=> E_AActor_GetDotProductTo(this, OtherActor);
		
		
		/// <summary>
		/// <para>The number of seconds (in game time) since this Actor was created, relative to Get Game Time In Seconds. </para>
		/// </summary>
		public float GetGameTimeSinceCreation()
			=> E_AActor_GetGameTimeSinceCreation(this);
		
		
		/// <summary>
		/// <para>Returns the distance from this Actor to OtherActor, ignoring Z. </para>
		/// </summary>
		public float GetHorizontalDistanceTo(AActor OtherActor)
			=> E_AActor_GetHorizontalDistanceTo(this, OtherActor);
		
		
		/// <summary>
		/// <para>Returns the dot product from this Actor to OtherActor, ignoring Z. Returns -2.0 on failure. Returns 0.0 for coincidental actors. </para>
		/// </summary>
		public float GetHorizontalDotProductTo(AActor OtherActor)
			=> E_AActor_GetHorizontalDotProductTo(this, OtherActor);
		
		
		/// <summary>
		/// <para>Gets the value of the input axis if input is enabled for this actor. </para>
		/// </summary>
		public float GetInputAxisValue(string InputAxisName)
			=> E_AActor_GetInputAxisValue(this, InputAxisName);
		
		
		/// <summary>
		/// <para>Get the remaining lifespan of this actor. If zero is returned the actor lives forever. </para>
		/// </summary>
		public virtual float GetLifeSpan()
			=> E_AActor_GetLifeSpan(this);
		
		
		/// <summary>
		/// <return>name of the net driver associated with this actor (all RPCs will go out via this connection) </return>
		/// </summary>
		public string GetNetDriverName()
			=> E_AActor_GetNetDriverName(this);
		
		
		/// <summary>
		/// <para>Get the network mode (dedicated server, client, standalone, etc) for this actor. </para>
		/// <para>@see IsNetMode() </para>
		/// </summary>
		public ENetMode GetNetMode()
			=> (ENetMode)E_AActor_GetNetMode(this);
		
		
		/// <summary>
		/// <return>the owning UPlayer (if any) of this actor. This will be a local player, a net connection, or NULL. </return>
		/// </summary>
		public virtual UPlayer GetNetOwningPlayer()
			=> E_AActor_GetNetOwningPlayer(this);
		
		
		/// <summary>
		/// <para>Get the owner of this Actor, used primarily for network replication. </para>
		/// <return>Actor that owns this Actor </return>
		/// </summary>
		public AActor GetOwner()
			=> E_AActor_GetOwner(this);
		
		
		/// <summary>
		/// <para>If this Actor was created by a Child Actor Component returns the Actor that owns that Child Actor Component </para>
		/// </summary>
		public AActor GetParentActor()
			=> E_AActor_GetParentActor(this);
		
		
		/// <summary>
		/// <para>If this Actor was created by a Child Actor Component returns that Child Actor Component </para>
		/// </summary>
		public UChildActorComponent GetParentComponent()
			=> E_AActor_GetParentComponent(this);
		
		
		/// <summary>
		/// <para>Get the extent used when placing this actor in the editor, used for 'pulling back' hit. </para>
		/// </summary>
		public FVector GetPlacementExtent()
			=> E_AActor_GetPlacementExtent(this);
		
		
		/// <summary>
		/// <para>Returns how much control the remote machine has over this actor. </para>
		/// </summary>
		public ENetRole GetRemoteRole()
			=> (ENetRole)E_AActor_GetRemoteRole(this);
		
		
		/// <summary>
		/// <para>Returns this actor's root component. </para>
		/// </summary>
		public USceneComponent GetRootComponent()
			=> E_AActor_GetRootComponent(this);
		
		
		/// <summary>
		/// <para>Returns this actor's root component cast to a primitive component </para>
		/// </summary>
		public UPrimitiveComponent GetRootPrimitiveComponent()
			=> E_AActor_GetRootPrimitiveComponent(this);
		
		
		/// <summary>
		/// <para>Returns the squared distance from this Actor to OtherActor. </para>
		/// </summary>
		public float GetSquaredDistanceTo(AActor OtherActor)
			=> E_AActor_GetSquaredDistanceTo(this, OtherActor);
		
		
		/// <summary>
		/// <para>Gets whether this actor can tick when paused. </para>
		/// </summary>
		public bool GetTickableWhenPaused()
			=> E_AActor_GetTickableWhenPaused(this);
		
		
		/// <summary>
		/// <para>Get the actor-to-world transform. </para>
		/// <return>The transform that transforms from actor space to world space. </return>
		/// </summary>
		public FTransform GetTransform()
			=> E_AActor_GetTransform(this);
		
		
		/// <summary>
		/// <para>Returns velocity (in cm/s (Unreal Units/second) of the rootcomponent if it is either using physics or has an associated MovementComponent </para>
		/// </summary>
		public virtual FVector GetVelocity()
			=> E_AActor_GetVelocity(this);
		
		
		/// <summary>
		/// <para>Returns the distance from this Actor to OtherActor, ignoring XY. </para>
		/// </summary>
		public float GetVerticalDistanceTo(AActor OtherActor)
			=> E_AActor_GetVerticalDistanceTo(this, OtherActor);
		
		
		/// <summary>
		/// <para>Returns whether an actor has had BeginPlay called on it (and not subsequently had EndPlay called) </para>
		/// </summary>
		public bool HasActorBegunPlay()
			=> E_AActor_HasActorBegunPlay(this);
		
		
		/// <summary>
		/// <para>Returns whether this actor has network authority </para>
		/// </summary>
		public bool HasAuthority()
			=> E_AActor_HasAuthority(this);
		
		
		/// <summary>
		/// <para>Returns true if Actor has deferred the RegisterAllComponents() call at spawn time (e.g. pending Blueprint SCS execution to set up a scene root component). </para>
		/// </summary>
		public bool HasDeferredComponentRegistration()
			=> E_AActor_HasDeferredComponentRegistration(this);
		
		
		/// <summary>
		/// <para>Does this actor have an owner responsible for replication? (APlayerController typically) </para>
		/// <return>true if this actor can call RPCs or false if no such owner chain exists </return>
		/// </summary>
		protected virtual bool HasNetOwner()
			=> E_AActor_HasNetOwner(this);
		
		
		/// <summary>
		/// <para>Returns true if Actor has a registered root component </para>
		/// </summary>
		public bool HasValidRootComponent()
			=> E_AActor_HasValidRootComponent(this);
		
		
		/// <summary>
		/// <para>Incrementally registers components associated with this actor </para>
		/// <param name="NumComponentsToRegister">Number of components to register in this run, 0 for all </param>
		/// <return>true when all components were registered for this actor </return>
		/// </summary>
		public bool IncrementalRegisterComponents(int NumComponentsToRegister)
			=> E_AActor_IncrementalRegisterComponents(this, NumComponentsToRegister);
		
		
		/// <summary>
		/// <para>Iterate over components array and call InitializeComponent </para>
		/// </summary>
		public void InitializeComponents()
			=> E_AActor_InitializeComponents(this);
		
		
		/// <summary>
		/// <para>Invalidate lighting cache with default options. </para>
		/// </summary>
		public void InvalidateLightingCache()
			=> E_AActor_InvalidateLightingCache(this);
		
		
		/// <summary>
		/// <para>Invalidates anything produced by the last lighting build. </para>
		/// </summary>
		public virtual void InvalidateLightingCacheDetailed(bool bTranslationOnly)
			=> E_AActor_InvalidateLightingCacheDetailed(this, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns whether an actor is in the process of beginning play </para>
		/// </summary>
		public bool IsActorBeginningPlay()
			=> E_AActor_IsActorBeginningPlay(this);
		
		public bool IsActorBeingDestroyed()
			=> E_AActor_IsActorBeingDestroyed(this);
		
		
		/// <summary>
		/// <para>Returns whether an actor has been initialized </para>
		/// </summary>
		public bool IsActorInitialized()
			=> E_AActor_IsActorInitialized(this);
		
		
		/// <summary>
		/// <para>Returns whether this actor has tick enabled or not </para>
		/// </summary>
		public bool IsActorTickEnabled()
			=> E_AActor_IsActorTickEnabled(this);
		
		
		/// <summary>
		/// <para>iterates up the Base chain to see whether or not this Actor is attached to the given Actor </para>
		/// <param name="Other">the Actor to test for </param>
		/// <return>true if this Actor is attached on Other Actor </return>
		/// </summary>
		public virtual bool IsAttachedTo(AActor Other)
			=> E_AActor_IsAttachedTo(this, Other);
		
		
		/// <summary>
		/// <para>iterates up the Base chain to see whether or not this Actor is based on the given Actor </para>
		/// <param name="Other">the Actor to test for </param>
		/// <return>true if this Actor is based on Other Actor </return>
		/// </summary>
		public virtual bool IsBasedOnActor(AActor Other)
			=> E_AActor_IsBasedOnActor(this, Other);
		
		
		/// <summary>
		/// <para>Returns whether this Actor was spawned by a child actor component </para>
		/// </summary>
		public bool IsChildActor()
			=> E_AActor_IsChildActor(this);
		
		
		/// <summary>
		/// <para>Indicates whether this actor should participate in level bounds calculations </para>
		/// </summary>
		public virtual bool IsLevelBoundsRelevant()
			=> E_AActor_IsLevelBoundsRelevant(this);
		
		
		/// <summary>
		/// <para>Returns whether a MatineeActor is currently controlling this Actor </para>
		/// </summary>
		public bool IsMatineeControlled()
			=> E_AActor_IsMatineeControlled(this);
		
		
		/// <summary>
		/// <para>Test whether net mode is the given mode. </para>
		/// <para>In optimized non-editor builds this can be more efficient than GetNetMode() </para>
		/// <para>because it can check the static build flags without considering PIE. </para>
		/// </summary>
		public bool IsNetMode(ENetMode Mode)
			=> E_AActor_IsNetMode(this, (byte)Mode);
		
		
		/// <summary>
		/// <para>Check whether any component of this Actor is overlapping any component of another Actor. </para>
		/// <param name="Other">The other Actor to test against </param>
		/// <return>Whether any component of this Actor is overlapping any component of another Actor. </return>
		/// </summary>
		public bool IsOverlappingActor(AActor Other)
			=> E_AActor_IsOverlappingActor(this, Other);
		
		
		/// <summary>
		/// <para>See if this actor is owned by TestOwner. </para>
		/// </summary>
		public bool IsOwnedBy(AActor TestOwner)
			=> E_AActor_IsOwnedBy(this, TestOwner);
		
		
		/// <summary>
		/// <para>Returns true if this actor has begun the destruction process. </para>
		/// <para>This is set to true in UWorld::DestroyActor, after the network connection has been closed but before any other shutdown has been performed. </para>
		/// <return>true if this actor has begun destruction, or if this actor has been destroyed already. </return>
		/// </summary>
		public bool IsPendingKillPending()
			=> E_AActor_IsPendingKillPending(this);
		
		
		/// <summary>
		/// <para>Check if this actor is the owner when doing relevancy checks for actors marked bOnlyRelevantToOwner </para>
		/// <param name="ReplicatedActor">the actor we're doing a relevancy test on </param>
		/// <param name="ActorOwner">the owner of ReplicatedActor </param>
		/// <param name="ConnectionActor">the controller of the connection that we're doing relevancy checks for </param>
		/// <return>bool - true if this actor should be considered the owner </return>
		/// </summary>
		public virtual bool IsRelevancyOwnerFor(AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor)
			=> E_AActor_IsRelevancyOwnerFor(this, ReplicatedActor, ActorOwner, ConnectionActor);
		
		
		/// <summary>
		/// <param name="RealViewer">is the "controlling net object" associated with the client for which network relevancy is being checked (typically player controller) </param>
		/// <param name="ViewTarget">is the Actor being used as the point of view for the RealViewer </param>
		/// <param name="SrcLocation">is the viewing location </param>
		/// <return>bool - true if this actor is replay relevant to the client associated with RealViewer </return>
		/// </summary>
		public virtual bool IsReplayRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared)
			=> E_AActor_IsReplayRelevantFor(this, RealViewer, ViewTarget, SrcLocation, CullDistanceSquared);
		
		
		/// <summary>
		/// <para>See if the root component has Mobility of EComponentMobility::Movable </para>
		/// </summary>
		public bool IsRootComponentMovable()
			=> E_AActor_IsRootComponentMovable(this);
		
		
		/// <summary>
		/// <para>See if the root component has ModifyFrequency of MF_Static </para>
		/// </summary>
		public bool IsRootComponentStatic()
			=> E_AActor_IsRootComponentStatic(this);
		
		
		/// <summary>
		/// <para>See if the root component has Mobility of EComponentMobility::Stationary </para>
		/// </summary>
		public bool IsRootComponentStationary()
			=> E_AActor_IsRootComponentStationary(this);
		
		
		/// <summary>
		/// <para>Adds a delta to the location of this component in its local reference frame. </para>
		/// <param name="DelatLocation">The change in location in local space. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// </summary>
		public void K2_AddActorLocalOffset(FVector DeltaLocation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_AddActorLocalOffset(this, DeltaLocation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the rotation of this component in its local reference frame </para>
		/// <param name="DeltaRotation">The change in rotation in local space. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// </summary>
		public void AddActorLocalRotation(FRotator DeltaRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_AddActorLocalRotation(this, DeltaRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the transform of this component in its local reference frame </para>
		/// <param name="NewTransform">The change in transform in local space. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// </summary>
		public void K2_AddActorLocalTransform(FTransform NewTransform, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_AddActorLocalTransform(this, NewTransform, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the location of this actor in world space. </para>
		/// <param name="DeltaLocation">The change in location. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// <param name="SweepHitResult">The hit result from the move if swept. </param>
		/// </summary>
		public void K2_AddActorWorldOffset(FVector DeltaLocation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_AddActorWorldOffset(this, DeltaLocation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the rotation of this actor in world space. </para>
		/// <param name="DeltaRotation">The change in rotation. </param>
		/// <param name="bSweep">Whether to sweep to the target rotation (not currently supported for rotation). </param>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// <param name="SweepHitResult">The hit result from the move if swept. </param>
		/// </summary>
		public void AddActorWorldRotation(FRotator DeltaRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_AddActorWorldRotation(this, DeltaRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Adds a delta to the transform of this actor in world space. Scale is unchanged. </para>
		/// </summary>
		public void K2_AddActorWorldTransform(FTransform DeltaTransform, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_AddActorWorldTransform(this, DeltaTransform, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered. </para>
		/// <param name="ParentActor">Actor to attach this actor's RootComponent to </param>
		/// <param name="SocketName">Socket name to attach to, if any </param>
		/// <param name="LocationRule">How to handle translation when attaching. </param>
		/// <param name="RotationRule">How to handle rotation when attaching. </param>
		/// <param name="ScaleRule">How to handle scale when attaching. </param>
		/// <param name="bWeldSimulatedBodies">Whether to weld together simulated physics bodies. </param>
		/// </summary>
		public void K2_AttachToActor(AActor ParentActor, string SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
			=> E_AActor_K2_AttachToActor(this, ParentActor, SocketName, (byte)LocationRule, (byte)RotationRule, (byte)ScaleRule, bWeldSimulatedBodies);
		
		
		/// <summary>
		/// <para>Attaches the RootComponent of this Actor to the supplied component, optionally at a named socket. It is not valid to call this on components that are not Registered. </para>
		/// <param name="Parent">Parent to attach to. </param>
		/// <param name="SocketName">Optional socket to attach to on the parent. </param>
		/// <param name="AttachmentRules">How to handle transforms when attaching. </param>
		/// <param name="bWeldSimulatedBodies">Whether to weld together simulated physics bodies. </param>
		/// </summary>
		public void K2_AttachToComponent(USceneComponent Parent, string SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
			=> E_AActor_K2_AttachToComponent(this, Parent, SocketName, (byte)LocationRule, (byte)RotationRule, (byte)ScaleRule, bWeldSimulatedBodies);
		
		
		/// <summary>
		/// <para>Destroy the actor </para>
		/// </summary>
		public virtual void DestroyActor()
			=> E_AActor_K2_DestroyActor(this);
		
		
		/// <summary>
		/// <para>DEPRECATED - Use Component::DestroyComponent </para>
		/// </summary>
		public void DestroyComponent(UActorComponent Component)
			=> E_AActor_K2_DestroyComponent(this, Component);
		
		
		/// <summary>
		/// <para>Detaches the RootComponent of this Actor from any SceneComponent it is currently attached to. </para>
		/// <param name="LocationRule">How to handle translation when detaching. </param>
		/// <param name="RotationRule">How to handle rotation when detaching. </param>
		/// <param name="ScaleRule">How to handle scale when detaching. </param>
		/// </summary>
		public void K2_DetachFromActor(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule)
			=> E_AActor_K2_DetachFromActor(this, (byte)LocationRule, (byte)RotationRule, (byte)ScaleRule);
		
		
		/// <summary>
		/// <para>Returns the location of the RootComponent of this Actor </para>
		/// </summary>
		public FVector K2_GetActorLocation()
			=> E_AActor_K2_GetActorLocation(this);
		
		
		/// <summary>
		/// <para>Returns rotation of the RootComponent of this Actor. </para>
		/// </summary>
		public FRotator K2_GetActorRotation()
			=> E_AActor_K2_GetActorRotation(this);
		
		public USceneComponent K2_GetRootComponent()
			=> E_AActor_K2_GetRootComponent(this);
		
		
		/// <summary>
		/// <para>Move the Actor to the specified location. </para>
		/// <param name="NewLocation">The new location to move the Actor to. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// <param name="SweepHitResult">The hit result from the move if swept. </param>
		/// <return>Whether the location was successfully set (if not swept), or whether movement occurred at all (if swept). </return>
		/// </summary>
		public bool K2_SetActorLocation(FVector NewLocation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_SetActorLocation(this, NewLocation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Move the actor instantly to the specified location and rotation. </para>
		/// <param name="NewLocation">The new location to teleport the Actor to. </param>
		/// <param name="NewRotation">The new rotation for the Actor. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// <param name="SweepHitResult">The hit result from the move if swept. </param>
		/// <return>Whether the rotation was successfully set. </return>
		/// </summary>
		public bool SetActorLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_SetActorLocationAndRotation(this, NewLocation, NewRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Set the actor's RootComponent to the specified relative location. </para>
		/// <param name="NewRelativeLocation">New relative location of the actor's root component </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// </summary>
		public void K2_SetActorRelativeLocation(FVector NewRelativeLocation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_SetActorRelativeLocation(this, NewRelativeLocation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Set the actor's RootComponent to the specified relative rotation </para>
		/// <param name="NewRelativeRotation">New relative rotation of the actor's root component </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// </summary>
		public void SetActorRelativeRotation(FRotator NewRelativeRotation, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_SetActorRelativeRotation(this, NewRelativeRotation, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Set the actor's RootComponent to the specified relative transform </para>
		/// <param name="NewRelativeTransform">New relative transform of the actor's root component </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// </summary>
		public void K2_SetActorRelativeTransform(FTransform NewRelativeTransform, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_SetActorRelativeTransform(this, NewRelativeTransform, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Set the Actor's rotation instantly to the specified rotation. </para>
		/// <param name="NewRotation">The new rotation for the Actor. </param>
		/// <param name="bTeleportPhysics">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <return>Whether the rotation was successfully set. </return>
		/// </summary>
		public bool SetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
			=> E_AActor_K2_SetActorRotation(this, NewRotation, bTeleportPhysics);
		
		
		/// <summary>
		/// <para>Set the Actors transform to the specified one. </para>
		/// <param name="NewTransform">The new transform. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="bTeleport">Whether we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If true, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If false, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// </summary>
		public bool K2_SetActorTransform(FTransform NewTransform, bool bSweep, FHitResult SweepHitResult, bool bTeleport)
			=> E_AActor_K2_SetActorTransform(this, NewTransform, bSweep, SweepHitResult, bTeleport);
		
		
		/// <summary>
		/// <para>Teleport this actor to a new location. If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such. </para>
		/// <param name="DestLocation">The target destination point </param>
		/// <param name="DestRotation">The target rotation at the destination </param>
		/// <return>true if the actor has been successfully moved, or false if it couldn't fit. </return>
		/// </summary>
		public bool Teleport(FVector DestLocation, FRotator DestRotation)
			=> E_AActor_K2_TeleportTo(this, DestLocation, DestRotation);
		
		
		/// <summary>
		/// <para>Called when the lifespan of an actor expires (if he has one). </para>
		/// </summary>
		public virtual void LifeSpanExpired()
			=> E_AActor_LifeSpanExpired(this);
		
		
		/// <summary>
		/// <para>Trigger a noise caused by a given Pawn, at a given location. </para>
		/// <para>Note that the NoiseInstigator Pawn MUST have a PawnNoiseEmitterComponent for the noise to be detected by a PawnSensingComponent. </para>
		/// <para>Senders of MakeNoise should have an Instigator if they are not pawns, or pass a NoiseInstigator. </para>
		/// <param name="Loudness">The relative loudness of this noise. Usual range is 0 (no noise) to 1 (full volume). If MaxRange is used, this scales the max range, otherwise it affects the hearing range specified by the sensor. </param>
		/// <param name="NoiseInstigator">Pawn responsible for this noise.  Uses the actor's Instigator if NoiseInstigator=NULL </param>
		/// <param name="NoiseLocation">Position of noise source.  If zero vector, use the actor's location. </param>
		/// <param name="MaxRange">Max range at which the sound may be heard. A value of 0 indicates no max range (though perception may have its own range). Loudness scales the range. (Note: not supported for legacy PawnSensingComponent, only for AIPerception) </param>
		/// <param name="Tag">Identifier for the noise. </param>
		/// </summary>
		public void MakeNoise(float Loudness, APawn NoiseInstigator, FVector NoiseLocation, float MaxRange, string Tag)
			=> E_AActor_MakeNoise(this, Loudness, NoiseInstigator, NoiseLocation, MaxRange, Tag);
		
		public virtual void MarkComponentsAsPendingKill()
			=> E_AActor_MarkComponentsAsPendingKill(this);
		
		
		/// <summary>
		/// <para>Flags all component's render state as dirty </para>
		/// </summary>
		public void MarkComponentsRenderStateDirty()
			=> E_AActor_MarkComponentsRenderStateDirty(this);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved over it with the clickable interface. </para>
		/// </summary>
		public virtual void NotifyActorBeginCursorOver()
			=> E_AActor_NotifyActorBeginCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when this actor overlaps another actor, for example a player walking into a trigger. </para>
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public virtual void NotifyActorBeginOverlap(AActor OtherActor)
			=> E_AActor_NotifyActorBeginOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved off of it with the clickable interface. </para>
		/// </summary>
		public virtual void NotifyActorEndCursorOver()
			=> E_AActor_NotifyActorEndCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when an actor no longer overlaps another actor, and they have separated. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public virtual void NotifyActorEndOverlap(AActor OtherActor)
			=> E_AActor_NotifyActorEndOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when this actor bumps into a blocking object, or blocks another actor that bumps into it. </para>
		/// <para>This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation. </para>
		/// <para>For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event. </para>
		/// <para>@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled. </para>
		/// <para>@note When receiving a hit from another object's movement (bSelfMoved is false), the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// <para>will be adjusted to indicate force from the other object against this object. </para>
		/// </summary>
		public virtual void NotifyHit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, FHitResult Hit)
			=> E_AActor_NotifyHit(this, MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
		
		
		/// <summary>
		/// <para>Called when an instance of this class is placed (in editor) or spawned. </para>
		/// <param name="Transform">The transform the actor was constructed at. </param>
		/// </summary>
		public virtual void OnConstruction(FTransform Transform)
			=> E_AActor_OnConstruction(this, Transform);
		
		public virtual void OnRep_AttachmentReplication()
			=> E_AActor_OnRep_AttachmentReplication(this);
		
		public virtual void OnRep_Instigator()
			=> E_AActor_OnRep_Instigator(this);
		
		protected virtual void OnRep_Owner()
			=> E_AActor_OnRep_Owner(this);
		
		public virtual void OnRep_ReplicatedMovement()
			=> E_AActor_OnRep_ReplicatedMovement(this);
		
		public virtual void OnRep_ReplicateMovement()
			=> E_AActor_OnRep_ReplicateMovement(this);
		
		
		/// <summary>
		/// <para>Called on the client when the replication paused value is changed </para>
		/// </summary>
		public virtual void OnReplicationPausedChanged(bool bIsReplicationPaused)
			=> E_AActor_OnReplicationPausedChanged(this, bIsReplicationPaused);
		
		
		/// <summary>
		/// <para>Called on the actor when a new subobject is dynamically created via replication </para>
		/// </summary>
		public virtual void OnSubobjectCreatedFromReplication(UObject NewSubobject)
			=> E_AActor_OnSubobjectCreatedFromReplication(this, NewSubobject);
		
		
		/// <summary>
		/// <para>Called on the actor when a subobject is dynamically destroyed via replication </para>
		/// </summary>
		public virtual void OnSubobjectDestroyFromReplication(UObject Subobject)
			=> E_AActor_OnSubobjectDestroyFromReplication(this, Subobject);
		
		
		/// <summary>
		/// <para>Called when an actor is done spawning into the world (from UWorld::SpawnActor). </para>
		/// <para>For actors with a root component, the location and rotation will have already been set. </para>
		/// <para>Takes place after any construction scripts have been called </para>
		/// </summary>
		public virtual void PostActorCreated()
			=> E_AActor_PostActorCreated(this);
		
		public virtual void PostInitializeComponents()
			=> E_AActor_PostInitializeComponents(this);
		
		public virtual void PostNetInit()
			=> E_AActor_PostNetInit(this);
		
		
		/// <summary>
		/// <para>Update and smooth location, not called for simulated physics! </para>
		/// </summary>
		public virtual void PostNetReceiveLocation()
			=> E_AActor_PostNetReceiveLocation(this);
		
		
		/// <summary>
		/// <para>Update location and rotation from ReplicatedMovement. Not called for simulated physics! </para>
		/// </summary>
		public virtual void PostNetReceiveLocationAndRotation()
			=> E_AActor_PostNetReceiveLocationAndRotation(this);
		
		
		/// <summary>
		/// <para>Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity() </para>
		/// </summary>
		public virtual void PostNetReceivePhysicState()
			=> E_AActor_PostNetReceivePhysicState(this);
		
		
		/// <summary>
		/// <para>Update velocity - typically from ReplicatedMovement, not called for simulated physics! </para>
		/// </summary>
		public virtual void PostNetReceiveVelocity(FVector NewVelocity)
			=> E_AActor_PostNetReceiveVelocity(this, NewVelocity);
		
		
		/// <summary>
		/// <para>Called after all the components in the Components array are registered </para>
		/// </summary>
		public virtual void PostRegisterAllComponents()
			=> E_AActor_PostRegisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Called after the actor is spawned in the world.  Responsible for setting up actor for play. </para>
		/// </summary>
		public void PostSpawnInitialize(FTransform SpawnTransform, AActor InOwner, APawn InInstigator, bool bRemoteOwned, bool bNoFail, bool bDeferConstruction)
			=> E_AActor_PostSpawnInitialize(this, SpawnTransform, InOwner, InInstigator, bRemoteOwned, bNoFail, bDeferConstruction);
		
		
		/// <summary>
		/// <para>Called after all currently registered components are cleared </para>
		/// </summary>
		public virtual void PostUnregisterAllComponents()
			=> E_AActor_PostUnregisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Called immediately before gameplay begins. </para>
		/// </summary>
		public virtual void PreInitializeComponents()
			=> E_AActor_PreInitializeComponents(this);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved over it with the clickable interface. </para>
		/// </summary>
		public void ActorBeginCursorOver()
			=> E_AActor_ReceiveActorBeginCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when this actor overlaps another actor, for example a player walking into a trigger. </para>
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public void ActorBeginOverlap(AActor OtherActor)
			=> E_AActor_ReceiveActorBeginOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved off of it with the clickable interface. </para>
		/// </summary>
		public void ActorEndCursorOver()
			=> E_AActor_ReceiveActorEndCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when an actor no longer overlaps another actor, and they have separated. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public void ActorEndOverlap(AActor OtherActor)
			=> E_AActor_ReceiveActorEndOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when play begins for this actor. </para>
		/// </summary>
		protected void ReceiveBeginPlay()
			=> E_AActor_ReceiveBeginPlay(this);
		
		public void Destroyed()
			=> E_AActor_ReceiveDestroyed(this);
		
		
		/// <summary>
		/// <para>Event when this actor bumps into a blocking object, or blocks another actor that bumps into it. </para>
		/// <para>This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation. </para>
		/// <para>For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event. </para>
		/// <para>@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled. </para>
		/// <para>@note When receiving a hit from another object's movement (bSelfMoved is false), the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// <para>will be adjusted to indicate force from the other object against this object. </para>
		/// <para>@note NormalImpulse will be filled in for physics-simulating bodies, but will be zero for swept-component blocking collisions. </para>
		/// </summary>
		public void Hit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, FHitResult Hit)
			=> E_AActor_ReceiveHit(this, MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
		
		
		/// <summary>
		/// <para>Event called every frame </para>
		/// </summary>
		public void ReceiveTick(float DeltaSeconds)
			=> E_AActor_ReceiveTick(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>When called, will call the virtual call chain to register all of the tick functions for both the actor and optionally all components </para>
		/// <para>Do not override this function or make it virtual </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// <param name="bDoComponents">true to also apply the change to all components </param>
		/// </summary>
		public void RegisterAllActorTickFunctions(bool bRegister, bool bDoComponents)
			=> E_AActor_RegisterAllActorTickFunctions(this, bRegister, bDoComponents);
		
		
		/// <summary>
		/// <para>Ensure that all the components in the Components array are registered </para>
		/// </summary>
		public virtual void RegisterAllComponents()
			=> E_AActor_RegisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public virtual void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_AActor_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public virtual void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_AActor_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Will reregister all components on this actor. Does a lot of work - should only really be used in editor, generally use UpdateComponentTransforms or MarkComponentsRenderStateDirty. </para>
		/// </summary>
		public virtual void ReregisterAllComponents()
			=> E_AActor_ReregisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Rerun construction scripts, destroying all autogenerated components; will attempt to preserve the root component location. </para>
		/// </summary>
		public virtual void RerunConstructionScripts()
			=> E_AActor_RerunConstructionScripts(this);
		
		
		/// <summary>
		/// <para>Reset private properties to defaults, and all FRandomStream structs in this Actor, so they will start their sequence of random numbers again. </para>
		/// </summary>
		public void ResetPropertiesForConstruction()
			=> E_AActor_ResetPropertiesForConstruction(this);
		
		
		/// <summary>
		/// <para>Allows enabling/disabling collision for the whole actor </para>
		/// </summary>
		public void SetActorEnableCollision(bool bNewActorEnableCollision)
			=> E_AActor_SetActorEnableCollision(this, bNewActorEnableCollision);
		
		
		/// <summary>
		/// <para>Sets the actor to be hidden in the game </para>
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components </param>
		/// </summary>
		public virtual void SetActorHiddenInGame(bool bNewHidden)
			=> E_AActor_SetActorHiddenInGame(this, bNewHidden);
		
		
		/// <summary>
		/// <para>Move the actor instantly to the specified location. </para>
		/// <param name="NewLocation">The new location to teleport the Actor to. </param>
		/// <param name="bSweep">Whether we sweep to the destination location, triggering overlaps along the way and stopping short of the target if blocked by something. </param>
		/// <para>Only the root component is swept and checked for blocking collision, child components move without sweeping. If collision is off, this has no effect. </para>
		/// <param name="Teleport">How we teleport the physics state (if physics collision is enabled for this object). </param>
		/// <para>If equal to ETeleportType::TeleportPhysics, physics velocity for this object is unchanged (so ragdoll parts are not affected by change in location). </para>
		/// <para>If equal to ETeleportType::None, physics velocity is updated based on the change in position (affecting ragdoll parts). </para>
		/// <para>If CCD is on and not teleporting, this will affect objects along the entire swept volume. </para>
		/// <param name="OutSweepHitResult">The hit result from the move if swept. </param>
		/// <return>Whether the location was successfully set if not swept, or whether movement occurred if swept. </return>
		/// </summary>
		public bool SetActorLocation(FVector NewLocation, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_AActor_SetActorLocation(this, NewLocation, bSweep, OutSweepHitResult, (byte)Teleport);
		
		public void SetActorRelativeLocation(FVector NewRelativeLocation, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_AActor_SetActorRelativeLocation(this, NewRelativeLocation, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Set the actor's RootComponent to the specified relative scale 3d </para>
		/// <param name="NewRelativeScale">New scale to set the actor's RootComponent to </param>
		/// </summary>
		public void SetActorRelativeScale3D(FVector NewRelativeScale)
			=> E_AActor_SetActorRelativeScale3D(this, NewRelativeScale);
		
		public void SetActorRelativeTransform(FTransform NewRelativeTransform, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_AActor_SetActorRelativeTransform(this, NewRelativeTransform, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Set the Actor's world-space scale. </para>
		/// </summary>
		public void SetActorScale3D(FVector NewScale3D)
			=> E_AActor_SetActorScale3D(this, NewScale3D);
		
		
		/// <summary>
		/// <para>Set this actor's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <para>This only modifies the tick function on actor itself </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public void SetActorTickEnabled(bool bEnabled)
			=> E_AActor_SetActorTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Sets the tick interval of this actor's primary tick function. Will not enable a disabled tick function. Takes effect on next tick. </para>
		/// <param name="TickInterval">The rate at which this actor should be ticking </param>
		/// </summary>
		public void SetActorTickInterval(float TickInterval)
			=> E_AActor_SetActorTickInterval(this, TickInterval);
		
		public bool SetActorTransform(FTransform NewTransform, bool bSweep, FHitResult OutSweepHitResult, ETeleportType Teleport)
			=> E_AActor_SetActorTransform(this, NewTransform, bSweep, OutSweepHitResult, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Sets whether or not this Actor is an autonomous proxy, which is an actor on a network client that is controlled by a user on that client. </para>
		/// </summary>
		public void SetAutonomousProxy(bool bInAutonomousProxy, bool bAllowForcePropertyCompare = true)
			=> E_AActor_SetAutonomousProxy(this, bInAutonomousProxy, bAllowForcePropertyCompare);
		
		
		/// <summary>
		/// <para>Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed. </para>
		/// </summary>
		public virtual void SetLifeSpan(float InLifespan)
			=> E_AActor_SetLifeSpan(this, InLifespan);
		
		
		/// <summary>
		/// <para>Puts actor in dormant networking state </para>
		/// </summary>
		public void SetNetDormancy(ENetDormancy NewDormancy)
			=> E_AActor_SetNetDormancy(this, (byte)NewDormancy);
		
		
		/// <summary>
		/// <para>Set the name of the net driver associated with this actor.  Will move the actor out of the list of network actors from the old net driver and add it to the new list </para>
		/// <param name="NewNetDriverName">name of the new net driver association </param>
		/// </summary>
		public void SetNetDriverName(string NewNetDriverName)
			=> E_AActor_SetNetDriverName(this, NewNetDriverName);
		
		
		/// <summary>
		/// <para>Set the owner of this Actor, used primarily for network replication. </para>
		/// <param name="NewOwner">The Actor whom takes over ownership of this Actor </param>
		/// </summary>
		public virtual void SetOwner(AActor NewOwner)
			=> E_AActor_SetOwner(this, NewOwner);
		
		
		/// <summary>
		/// <para>This function should only be used in the constructor of classes that need to set the RemoteRole for backwards compatibility purposes </para>
		/// </summary>
		protected void SetRemoteRoleForBackwardsCompat(ENetRole InRemoteRole)
			=> E_AActor_SetRemoteRoleForBackwardsCompat(this, (byte)InRemoteRole);
		
		
		/// <summary>
		/// <para>Set whether this actor's movement replicates to network clients. </para>
		/// <param name="bInReplicateMovement">Whether this Actor's movement replicates to clients. </param>
		/// </summary>
		public virtual void SetReplicateMovement(bool bInReplicateMovement)
			=> E_AActor_SetReplicateMovement(this, bInReplicateMovement);
		
		
		/// <summary>
		/// <para>Set whether this actor replicates to network clients. When this actor is spawned on the server it will be sent to clients as well. </para>
		/// <para>Properties flagged for replication will update on clients if they change on the server. </para>
		/// <para>Internally changes the RemoteRole property and handles the cases where the actor needs to be added to the network actor list. </para>
		/// <param name="bInReplicates">Whether this Actor replicates to network clients. </param>
		/// <para>@see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication </para>
		/// </summary>
		public void SetReplicates(bool bInReplicates)
			=> E_AActor_SetReplicates(this, bInReplicates);
		
		
		/// <summary>
		/// <para>Sets root component to be the specified component.  NewRootComponent's owner should be this actor. </para>
		/// <return>true if successful </return>
		/// </summary>
		public bool SetRootComponent(USceneComponent NewRootComponent)
			=> E_AActor_SetRootComponent(this, NewRootComponent);
		
		
		/// <summary>
		/// <para>Sets whether this actor can tick when paused. </para>
		/// </summary>
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
			=> E_AActor_SetTickableWhenPaused(this, bTickableWhenPaused);
		
		public void SetTickPrerequisite(AActor PrerequisiteActor)
			=> E_AActor_SetTickPrerequisite(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>If true, actor is ticked even if TickType==LEVELTICK_ViewportsOnly </para>
		/// </summary>
		public virtual bool ShouldTickIfViewportsOnly()
			=> E_AActor_ShouldTickIfViewportsOnly(this);
		
		
		/// <summary>
		/// <para>Snap the RootComponent of this Actor to the supplied Actor's root component, optionally at a named socket. It is not valid to call this on components that are not Registered. </para>
		/// <para>If InSocketName == NAME_None, it will attach to origin of the InParentActor. </para>
		/// </summary>
		public void SnapActorTo(AActor InParentActor, string InSocketName)
			=> E_AActor_SnapRootComponentTo(this, InParentActor, InSocketName);
		
		
		/// <summary>
		/// <para>The replay system calls this to hack the Role and RemoteRole while recording replays on a client. Only call this if you know what you're doing! </para>
		/// </summary>
		public void SwapRolesForReplay()
			=> E_AActor_SwapRolesForReplay(this);
		
		
		/// <summary>
		/// <para>Sync IsSimulatingPhysics() with ReplicatedMovement.bRepPhysics </para>
		/// </summary>
		protected void SyncReplicatedPhysicsSimulation()
			=> E_AActor_SyncReplicatedPhysicsSimulation(this);
		
		
		/// <summary>
		/// <para>Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true. </para>
		/// </summary>
		public virtual void TearOff()
			=> E_AActor_TearOff(this);
		
		
		/// <summary>
		/// <para>Called from TeleportTo() when teleport succeeds </para>
		/// </summary>
		public virtual void TeleportSucceeded(bool bIsATest)
			=> E_AActor_TeleportSucceeded(this, bIsATest);
		
		
		/// <summary>
		/// <para>Used for adding actors to levels or teleporting them to a new location. </para>
		/// <para>The result of this function is independent of the actor's current location and rotation. </para>
		/// <para>If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such if bNoCheck is false. </para>
		/// <param name="DestLocation">The target destination point </param>
		/// <param name="DestRotation">The target rotation at the destination </param>
		/// <param name="bIsATest">is true if this is a test movement, which shouldn't cause any notifications (used by AI pathfinding, for example) </param>
		/// <param name="bNoCheck">is true if we should skip checking for encroachment in the world or other actors </param>
		/// <return>true if the actor has been successfully moved, or false if it couldn't fit. </return>
		/// </summary>
		public virtual bool TeleportTo(FVector DestLocation, FRotator DestRotation, bool bIsATest, bool bNoCheck)
			=> E_AActor_TeleportTo(this, DestLocation, DestRotation, bIsATest, bNoCheck);
		
		
		/// <summary>
		/// <para>Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame. </para>
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// <param name="DeltaSeconds">Game time elapsed during last frame modified by the time dilation </param>
		/// </summary>
		public virtual void Tick(float DeltaSeconds)
			=> E_AActor_Tick(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>ticks the actor </para>
		/// <param name="DeltaTime">The time slice of this tick </param>
		/// <param name="TickType">The type of tick that is happening </param>
		/// <param name="ThisTickFunction">The tick function that is firing, useful for getting the completion handle </param>
		/// </summary>
		public virtual void TickActor(float DeltaTime, ELevelTick TickType, FActorTickFunction ThisTickFunction)
			=> E_AActor_TickActor(this, DeltaTime, (byte)TickType, ThisTickFunction);
		
		
		/// <summary>
		/// <para>Iterate over components array and call UninitializeComponent </para>
		/// </summary>
		public void UninitializeComponents()
			=> E_AActor_UninitializeComponents(this);
		
		
		/// <summary>
		/// <para>Unregister all currently registered components </para>
		/// </summary>
		public virtual void UnregisterAllComponents(bool bForReregister)
			=> E_AActor_UnregisterAllComponents(this, bForReregister);
		
		
		/// <summary>
		/// <para>Update all components transforms </para>
		/// </summary>
		public void UpdateComponentTransforms()
			=> E_AActor_UpdateComponentTransforms(this);
		
		
		/// <summary>
		/// <para>Queries world and updates overlap detection state for this actor. </para>
		/// <param name="bDoNotifies">True to dispatch being/end overlap notifications when these events occur. </param>
		/// </summary>
		public void UpdateOverlaps(bool bDoNotifies = true)
			=> E_AActor_UpdateOverlaps(this, bDoNotifies);
		
		
		/// <summary>
		/// <para>Construction script, the place to spawn components and do other setup. </para>
		/// <para>@note Name used in CreateBlueprint function </para>
		/// <param name="Location">The location. </param>
		/// <param name="Rotation">The rotation. </param>
		/// </summary>
		public void ConstructionScript()
			=> E_AActor_UserConstructionScript(this);
		
		
		/// <summary>
		/// <para>Used by the net connection to determine if a net owning actor should switch to using the shortened timeout value </para>
		/// <return>true to switch from InitialConnectTimeout to ConnectionTimeout values on the net driver </return>
		/// </summary>
		public virtual bool UseShortConnectTimeout()
			=> E_AActor_UseShortConnectTimeout(this);
		
		#endregion
		
		public static implicit operator IntPtr(AActor Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator AActor(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AActor>(PtrDesc);
		}}}
