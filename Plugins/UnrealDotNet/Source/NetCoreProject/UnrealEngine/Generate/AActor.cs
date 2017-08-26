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
		private static extern void E_AActor_OnRep_ReplicateMovement(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetReplicates(IntPtr Self, bool bInReplicates);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetAutonomousProxy(IntPtr Self, bool bInAutonomousProxy, bool bAllowForcePropertyCompare);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_CopyRemoteRoleFrom(IntPtr Self, AActor CopyFromActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_OnSubobjectCreatedFromReplication(IntPtr Self, UObject NewSubobject);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_AllowReceiveTickEventOnDedicatedServer(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FTransform E_AActor_GetTransform(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_AActor_K2_GetActorLocation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_AActor_K2_GetActorRotation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_GetActorBounds(IntPtr Self, bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_K2_SetActorRotation(IntPtr Self, FRotator NewRotation, bool bTeleportPhysics);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetActorScale3D(IntPtr Self, FVector NewScale3D);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_AActor_GetDistanceTo(IntPtr Self, AActor OtherActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_AActor_GetActorTimeDilation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_SetTickPrerequisite(IntPtr Self, AActor PrerequisiteActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_GetTickableWhenPaused(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_AActor_GetGameTimeSinceCreation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_Destroy(IntPtr Self, bool bNetForce, bool bShouldModifyLevel);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IsOwnedBy(IntPtr Self, AActor TestOwner);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_AActor_GetActorQuat(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_ApplyWorldOffset(IntPtr Self, FVector InOffset, bool bWorldShift);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_RegisterAllActorTickFunctions(IntPtr Self, bool bRegister, bool bDoComponents);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_PostNetReceiveVelocity(IntPtr Self, FVector NewVelocity);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern AActor E_AActor_GetOwner(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IsReplayRelevantFor(IntPtr Self, AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IsRelevancyOwnerFor(IntPtr Self, AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_IncrementalRegisterComponents(IntPtr Self, int NumComponentsToRegister);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_TeleportTo(IntPtr Self, FVector DestLocation, FRotator DestRotation, bool bIsATest, bool bNoCheck);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AActor_K2_TeleportTo(IntPtr Self, FVector DestLocation, FRotator DestRotation);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_DebugShowComponentHierarchy(IntPtr Self, string Info, bool bShowPosition);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AActor_OnConstruction(IntPtr Self, FTransform Transform);
		
		#endregion
		
		#region ExternMethods
		public void OnRep_ReplicateMovement()
		{
			E_AActor_OnRep_ReplicateMovement(NativePointer);
		}

		public void SetReplicates(bool bInReplicates)
		{
			E_AActor_SetReplicates(NativePointer, bInReplicates);
		}

		public void SetAutonomousProxy(bool bInAutonomousProxy, bool bAllowForcePropertyCompare)
		{
			E_AActor_SetAutonomousProxy(NativePointer, bInAutonomousProxy, bAllowForcePropertyCompare);
		}

		public void CopyRemoteRoleFrom(AActor CopyFromActor)
		{
			E_AActor_CopyRemoteRoleFrom(NativePointer, CopyFromActor);
		}

		public void OnSubobjectCreatedFromReplication(UObject NewSubobject)
		{
			E_AActor_OnSubobjectCreatedFromReplication(NativePointer, NewSubobject);
		}

		public bool AllowReceiveTickEventOnDedicatedServer()
		{
			return E_AActor_AllowReceiveTickEventOnDedicatedServer(NativePointer);
		}

		public FTransform GetTransform()
		{
			return E_AActor_GetTransform(NativePointer);
		}

		public FVector K2_GetActorLocation()
		{
			return E_AActor_K2_GetActorLocation(NativePointer);
		}

		public FRotator K2_GetActorRotation()
		{
			return E_AActor_K2_GetActorRotation(NativePointer);
		}

		public void GetActorBounds(bool bOnlyCollidingComponents, FVector Origin, FVector BoxExtent)
		{
			E_AActor_GetActorBounds(NativePointer, bOnlyCollidingComponents, Origin, BoxExtent);
		}

		public bool K2_SetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
		{
			return E_AActor_K2_SetActorRotation(NativePointer, NewRotation, bTeleportPhysics);
		}

		public void SetActorScale3D(FVector NewScale3D)
		{
			E_AActor_SetActorScale3D(NativePointer, NewScale3D);
		}

		public float GetDistanceTo(AActor OtherActor)
		{
			return E_AActor_GetDistanceTo(NativePointer, OtherActor);
		}

		public float GetActorTimeDilation()
		{
			return E_AActor_GetActorTimeDilation(NativePointer);
		}

		public void SetTickPrerequisite(AActor PrerequisiteActor)
		{
			E_AActor_SetTickPrerequisite(NativePointer, PrerequisiteActor);
		}

		public bool GetTickableWhenPaused()
		{
			return E_AActor_GetTickableWhenPaused(NativePointer);
		}

		public float GetGameTimeSinceCreation()
		{
			return E_AActor_GetGameTimeSinceCreation(NativePointer);
		}

		public void ReceiveTick(float DeltaSeconds)
		{
			E_AActor_ReceiveTick(NativePointer, DeltaSeconds);
		}

		public bool Destroy(bool bNetForce, bool bShouldModifyLevel)
		{
			return E_AActor_Destroy(NativePointer, bNetForce, bShouldModifyLevel);
		}

		public bool IsOwnedBy(AActor TestOwner)
		{
			return E_AActor_IsOwnedBy(NativePointer, TestOwner);
		}

		public FQuat GetActorQuat()
		{
			return E_AActor_GetActorQuat(NativePointer);
		}

		public void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
		{
			E_AActor_ApplyWorldOffset(NativePointer, InOffset, bWorldShift);
		}

		public void RegisterAllActorTickFunctions(bool bRegister, bool bDoComponents)
		{
			E_AActor_RegisterAllActorTickFunctions(NativePointer, bRegister, bDoComponents);
		}

		public void PostNetReceiveVelocity(FVector NewVelocity)
		{
			E_AActor_PostNetReceiveVelocity(NativePointer, NewVelocity);
		}

		public AActor GetOwner()
		{
			return E_AActor_GetOwner(NativePointer);
		}

		public bool IsReplayRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared)
		{
			return E_AActor_IsReplayRelevantFor(NativePointer, RealViewer, ViewTarget, SrcLocation, CullDistanceSquared);
		}

		public bool IsRelevancyOwnerFor(AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor)
		{
			return E_AActor_IsRelevancyOwnerFor(NativePointer, ReplicatedActor, ActorOwner, ConnectionActor);
		}

		public bool IncrementalRegisterComponents(int NumComponentsToRegister)
		{
			return E_AActor_IncrementalRegisterComponents(NativePointer, NumComponentsToRegister);
		}

		public bool TeleportTo(FVector DestLocation, FRotator DestRotation, bool bIsATest, bool bNoCheck)
		{
			return E_AActor_TeleportTo(NativePointer, DestLocation, DestRotation, bIsATest, bNoCheck);
		}

		public bool K2_TeleportTo(FVector DestLocation, FRotator DestRotation)
		{
			return E_AActor_K2_TeleportTo(NativePointer, DestLocation, DestRotation);
		}

		public void DebugShowComponentHierarchy(string Info, bool bShowPosition)
		{
			E_AActor_DebugShowComponentHierarchy(NativePointer, Info, bShowPosition);
		}

		public void OnConstruction(FTransform Transform)
		{
			E_AActor_OnConstruction(NativePointer, Transform);
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
