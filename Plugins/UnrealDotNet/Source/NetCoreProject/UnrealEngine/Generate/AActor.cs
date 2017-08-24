using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class AActor : UObject
	{
		public AActor(IntPtr Adress)
			: base(Adress)
		{
		}

		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_OnRep_ReplicateMovement(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_SetReplicates(IntPtr Self, bool bInReplicates);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_SetAutonomousProxy(IntPtr Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_CopyRemoteRoleFrom(IntPtr Self, AActor CopyFromActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_OnSubobjectCreatedFromReplication(IntPtr Self, UObject NewSubobject);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AllowReceiveTickEventOnDedicatedServer(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_K2_GetActorLocation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_GetActorBounds(IntPtr Self, bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_SetActorScale3D(IntPtr Self, FVector NewScale3D);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_GetDistanceTo(IntPtr Self, AActor OtherActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_GetActorTimeDilation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_SetTickPrerequisite(IntPtr Self, AActor PrerequisiteActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_GetTickableWhenPaused(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_GetGameTimeSinceCreation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Destroy(IntPtr Self, bool bNetForce, bool bShouldModifyLevel);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_IsOwnedBy(IntPtr Self, AActor TestOwner);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ApplyWorldOffset(IntPtr Self, FVector InOffset, bool bWorldShift);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_RegisterAllActorTickFunctions(IntPtr Self, bool bRegister, bool bDoComponents);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PostNetReceiveVelocity(IntPtr Self, FVector NewVelocity);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern AActor E_GetOwner(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_IsReplayRelevantFor(IntPtr Self, AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_IsRelevancyOwnerFor(IntPtr Self, AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_IncrementalRegisterComponents(IntPtr Self, int NumComponentsToRegister);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DebugShowComponentHierarchy(IntPtr Self, string Info, bool bShowPosition);
		
		#endregion
		
		#region ExternMethods
		public void OnRep_ReplicateMovement()
		{
			E_OnRep_ReplicateMovement(NativePointer);
		}

		public void SetReplicates(bool bInReplicates)
		{
			E_SetReplicates(NativePointer, bInReplicates);
		}

		public void SetAutonomousProxy(bool bInAutonomousProxy, bool bAllowForcePropertyCompare)
		{
			E_SetAutonomousProxy(NativePointer, bInAutonomousProxy, bAllowForcePropertyCompare);
		}

		public void CopyRemoteRoleFrom(AActor CopyFromActor)
		{
			E_CopyRemoteRoleFrom(NativePointer, CopyFromActor);
		}

		public void OnSubobjectCreatedFromReplication(UObject NewSubobject)
		{
			E_OnSubobjectCreatedFromReplication(NativePointer, NewSubobject);
		}

		public bool AllowReceiveTickEventOnDedicatedServer()
		{
			return E_AllowReceiveTickEventOnDedicatedServer(NativePointer);
		}

		public FVector K2_GetActorLocation()
		{
			return E_K2_GetActorLocation(NativePointer);
		}

		public void GetActorBounds(bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent)
		{
			E_GetActorBounds(NativePointer, bOnlyCollidingComponents, Origin, BoxExtent);
		}

		public void SetActorScale3D(FVector NewScale3D)
		{
			E_SetActorScale3D(NativePointer, NewScale3D);
		}

		public float GetDistanceTo(AActor OtherActor)
		{
			return E_GetDistanceTo(NativePointer, OtherActor);
		}

		public float GetActorTimeDilation()
		{
			return E_GetActorTimeDilation(NativePointer);
		}

		public void SetTickPrerequisite(AActor PrerequisiteActor)
		{
			E_SetTickPrerequisite(NativePointer, PrerequisiteActor);
		}

		public bool GetTickableWhenPaused()
		{
			return E_GetTickableWhenPaused(NativePointer);
		}

		public float GetGameTimeSinceCreation()
		{
			return E_GetGameTimeSinceCreation(NativePointer);
		}

		public void ReceiveTick(float DeltaSeconds)
		{
			E_ReceiveTick(NativePointer, DeltaSeconds);
		}

		public bool Destroy(bool bNetForce, bool bShouldModifyLevel)
		{
			return E_Destroy(NativePointer, bNetForce, bShouldModifyLevel);
		}

		public bool IsOwnedBy(AActor TestOwner)
		{
			return E_IsOwnedBy(NativePointer, TestOwner);
		}

		public void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
		{
			E_ApplyWorldOffset(NativePointer, InOffset, bWorldShift);
		}

		public void RegisterAllActorTickFunctions(bool bRegister, bool bDoComponents)
		{
			E_RegisterAllActorTickFunctions(NativePointer, bRegister, bDoComponents);
		}

		public void PostNetReceiveVelocity(FVector NewVelocity)
		{
			E_PostNetReceiveVelocity(NativePointer, NewVelocity);
		}

		public AActor GetOwner()
		{
			return E_GetOwner(NativePointer);
		}

		public bool IsReplayRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared)
		{
			return E_IsReplayRelevantFor(NativePointer, RealViewer, ViewTarget, SrcLocation, CullDistanceSquared);
		}

		public bool IsRelevancyOwnerFor(AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor)
		{
			return E_IsRelevancyOwnerFor(NativePointer, ReplicatedActor, ActorOwner, ConnectionActor);
		}

		public bool IncrementalRegisterComponents(int NumComponentsToRegister)
		{
			return E_IncrementalRegisterComponents(NativePointer, NumComponentsToRegister);
		}

		public void DebugShowComponentHierarchy(string Info, bool bShowPosition)
		{
			E_DebugShowComponentHierarchy(NativePointer, Info, bShowPosition);
		}

		#endregion
		
		public static explicit operator IntPtr(AActor Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator AActor(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new AActor(Adress);
		}}}
