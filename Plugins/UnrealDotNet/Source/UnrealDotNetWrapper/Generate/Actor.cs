using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public class AActor : UObject
	{
		private readonly IntPtr NativePointer;
		
		internal AActor(IntPtr Adress)
		{
			NativePointer = Adress;
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ForceNetUpdate(IntPtr Self);
		
		public void ForceNetUpdate()
		{
			Call_ForceNetUpdate((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_WasRecentlyRendered(IntPtr Self, float Tolerance);
		
		public bool WasRecentlyRendered(float Tolerance)
		{
			return Call_WasRecentlyRendered((IntPtr)this, Tolerance);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_K2_OnReset(IntPtr Self);
		
		public void K2_OnReset()
		{
			Call_K2_OnReset((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_K2_OnEndViewTarget(IntPtr Self, IntPtr PC);
		
		public void K2_OnEndViewTarget(APlayerController PC)
		{
			Call_K2_OnEndViewTarget((IntPtr)this, (IntPtr)PC);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_K2_OnBecomeViewTarget(IntPtr Self, IntPtr PC);
		
		public void K2_OnBecomeViewTarget(APlayerController PC)
		{
			Call_K2_OnBecomeViewTarget((IntPtr)this, (IntPtr)PC);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern IntPtr Call_GetAttachParentActor(IntPtr Self);
		
		public AActor GetAttachParentActor()
		{
			return new AActor(Call_GetAttachParentActor((IntPtr)this));
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern IntPtr Call_GetParentActor(IntPtr Self);
		
		public AActor GetParentActor()
		{
			return new AActor(Call_GetParentActor((IntPtr)this));
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern IntPtr Call_GetParentComponent(IntPtr Self);
		
		public UChildActorComponent GetParentComponent()
		{
			return new UChildActorComponent(Call_GetParentComponent((IntPtr)this));
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsChildActor(IntPtr Self);
		
		public bool IsChildActor()
		{
			return Call_IsChildActor((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_FlushNetDormancy(IntPtr Self);
		
		public void FlushNetDormancy()
		{
			Call_FlushNetDormancy((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsOverlappingActor(IntPtr Self, IntPtr Other);
		
		public bool IsOverlappingActor(AActor Other)
		{
			return Call_IsOverlappingActor((IntPtr)this, (IntPtr)Other);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern IntPtr Call_GetOwner(IntPtr Self);
		
		public AActor GetOwner()
		{
			return new AActor(Call_GetOwner((IntPtr)this));
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetOwner(IntPtr Self, IntPtr NewOwner);
		
		public void SetOwner(AActor NewOwner)
		{
			Call_SetOwner((IntPtr)this, (IntPtr)NewOwner);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_ReplicatedMovement(IntPtr Self);
		
		public void OnRep_ReplicatedMovement()
		{
			Call_OnRep_ReplicatedMovement((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetActorTickInterval(IntPtr Self);
		
		public float GetActorTickInterval()
		{
			return Call_GetActorTickInterval((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorTickInterval(IntPtr Self, float TickInterval);
		
		public void SetActorTickInterval(float TickInterval)
		{
			Call_SetActorTickInterval((IntPtr)this, TickInterval);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsActorTickEnabled(IntPtr Self);
		
		public bool IsActorTickEnabled()
		{
			return Call_IsActorTickEnabled((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorTickEnabled(IntPtr Self, bool bEnabled);
		
		public void SetActorTickEnabled(bool bEnabled)
		{
			Call_SetActorTickEnabled((IntPtr)this, bEnabled);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsSelectable(IntPtr Self);
		
		public bool IsSelectable()
		{
			return Call_IsSelectable((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsEditable(IntPtr Self);
		
		public bool IsEditable()
		{
			return Call_IsEditable((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsTemporarilyHiddenInEditor(IntPtr Self, bool bIncludeParent);
		
		public bool IsTemporarilyHiddenInEditor(bool bIncludeParent)
		{
			return Call_IsTemporarilyHiddenInEditor((IntPtr)this, bIncludeParent);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetIsTemporarilyHiddenInEditor(IntPtr Self, bool bIsHidden);
		
		public void SetIsTemporarilyHiddenInEditor(bool bIsHidden)
		{
			Call_SetIsTemporarilyHiddenInEditor((IntPtr)this, bIsHidden);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsHiddenEd(IntPtr Self);
		
		public bool IsHiddenEd()
		{
			return Call_IsHiddenEd((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsHiddenEdAtStartup(IntPtr Self);
		
		public bool IsHiddenEdAtStartup()
		{
			return Call_IsHiddenEdAtStartup((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveDestroyed(IntPtr Self);
		
		public void ReceiveDestroyed()
		{
			Call_ReceiveDestroyed((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_UserConstructionScript(IntPtr Self);
		
		public void UserConstructionScript()
		{
			Call_UserConstructionScript((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetLifeSpan(IntPtr Self);
		
		public float GetLifeSpan()
		{
			return Call_GetLifeSpan((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetLifeSpan(IntPtr Self, float InLifespan);
		
		public void SetLifeSpan(float InLifespan)
		{
			Call_SetLifeSpan((IntPtr)this, InLifespan);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveActorEndCursorOver(IntPtr Self);
		
		public void ReceiveActorEndCursorOver()
		{
			Call_ReceiveActorEndCursorOver((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveActorBeginCursorOver(IntPtr Self);
		
		public void ReceiveActorBeginCursorOver()
		{
			Call_ReceiveActorBeginCursorOver((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveActorEndOverlap(IntPtr Self, IntPtr OtherActor);
		
		public void ReceiveActorEndOverlap(AActor OtherActor)
		{
			Call_ReceiveActorEndOverlap((IntPtr)this, (IntPtr)OtherActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveActorBeginOverlap(IntPtr Self, IntPtr OtherActor);
		
		public void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			Call_ReceiveActorBeginOverlap((IntPtr)this, (IntPtr)OtherActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		public void ReceiveTick(float DeltaSeconds)
		{
			Call_ReceiveTick((IntPtr)this, DeltaSeconds);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveAnyDamage(IntPtr Self, float Damage, IntPtr DamageType, IntPtr InstigatedBy, IntPtr DamageCauser);
		
		public void ReceiveAnyDamage(float Damage, UDamageType DamageType, AController InstigatedBy, AActor DamageCauser)
		{
			Call_ReceiveAnyDamage((IntPtr)this, Damage, (IntPtr)DamageType, (IntPtr)InstigatedBy, (IntPtr)DamageCauser);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsActorBeingDestroyed(IntPtr Self);
		
		public bool IsActorBeingDestroyed()
		{
			return Call_IsActorBeingDestroyed((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveBeginPlay(IntPtr Self);
		
		public void ReceiveBeginPlay()
		{
			Call_ReceiveBeginPlay((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetGameTimeSinceCreation(IntPtr Self);
		
		public float GetGameTimeSinceCreation()
		{
			return Call_GetGameTimeSinceCreation((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern IntPtr Call_MakeMIDForMaterial(IntPtr Self, IntPtr Parent);
		
		public UMaterialInstanceDynamic MakeMIDForMaterial(UMaterialInterface Parent)
		{
			return new UMaterialInstanceDynamic(Call_MakeMIDForMaterial((IntPtr)this, (IntPtr)Parent));
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetTickableWhenPaused(IntPtr Self, bool bTickableWhenPaused);
		
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
		{
			Call_SetTickableWhenPaused((IntPtr)this, bTickableWhenPaused);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_GetTickableWhenPaused(IntPtr Self);
		
		public bool GetTickableWhenPaused()
		{
			return Call_GetTickableWhenPaused((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		public void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			Call_RemoveTickPrerequisiteComponent((IntPtr)this, (IntPtr)PrerequisiteComponent);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		public void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			Call_RemoveTickPrerequisiteActor((IntPtr)this, (IntPtr)PrerequisiteActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		public void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			Call_AddTickPrerequisiteComponent((IntPtr)this, (IntPtr)PrerequisiteComponent);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		public void AddTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			Call_AddTickPrerequisiteActor((IntPtr)this, (IntPtr)PrerequisiteActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetActorTimeDilation(IntPtr Self);
		
		public float GetActorTimeDilation()
		{
			return Call_GetActorTimeDilation((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_DetachRootComponentFromParent(IntPtr Self, bool bMaintainWorldPosition);
		
		public void DetachRootComponentFromParent(bool bMaintainWorldPosition)
		{
			Call_DetachRootComponentFromParent((IntPtr)this, bMaintainWorldPosition);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_K2_DestroyComponent(IntPtr Self, IntPtr Component);
		
		public void K2_DestroyComponent(UActorComponent Component)
		{
			Call_K2_DestroyComponent((IntPtr)this, (IntPtr)Component);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_HasAuthority(IntPtr Self);
		
		public bool HasAuthority()
		{
			return Call_HasAuthority((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_K2_DestroyActor(IntPtr Self);
		
		public void K2_DestroyActor()
		{
			Call_K2_DestroyActor((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_GetActorEnableCollision(IntPtr Self);
		
		public bool GetActorEnableCollision()
		{
			return Call_GetActorEnableCollision((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorEnableCollision(IntPtr Self, bool bNewActorEnableCollision);
		
		public void SetActorEnableCollision(bool bNewActorEnableCollision)
		{
			Call_SetActorEnableCollision((IntPtr)this, bNewActorEnableCollision);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorHiddenInGame(IntPtr Self, bool bNewHidden);
		
		public void SetActorHiddenInGame(bool bNewHidden)
		{
			Call_SetActorHiddenInGame((IntPtr)this, bNewHidden);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetHorizontalDotProductTo(IntPtr Self, IntPtr OtherActor);
		
		public float GetHorizontalDotProductTo(AActor OtherActor)
		{
			return Call_GetHorizontalDotProductTo((IntPtr)this, (IntPtr)OtherActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetDotProductTo(IntPtr Self, IntPtr OtherActor);
		
		public float GetDotProductTo(AActor OtherActor)
		{
			return Call_GetDotProductTo((IntPtr)this, (IntPtr)OtherActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetVerticalDistanceTo(IntPtr Self, IntPtr OtherActor);
		
		public float GetVerticalDistanceTo(AActor OtherActor)
		{
			return Call_GetVerticalDistanceTo((IntPtr)this, (IntPtr)OtherActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetHorizontalDistanceTo(IntPtr Self, IntPtr OtherActor);
		
		public float GetHorizontalDistanceTo(AActor OtherActor)
		{
			return Call_GetHorizontalDistanceTo((IntPtr)this, (IntPtr)OtherActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetSquaredDistanceTo(IntPtr Self, IntPtr OtherActor);
		
		public float GetSquaredDistanceTo(AActor OtherActor)
		{
			return Call_GetSquaredDistanceTo((IntPtr)this, (IntPtr)OtherActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetDistanceTo(IntPtr Self, IntPtr OtherActor);
		
		public float GetDistanceTo(AActor OtherActor)
		{
			return Call_GetDistanceTo((IntPtr)this, (IntPtr)OtherActor);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern IntPtr Call_K2_GetRootComponent(IntPtr Self);
		
		public USceneComponent K2_GetRootComponent()
		{
			return new USceneComponent(Call_K2_GetRootComponent((IntPtr)this));
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern IntPtr Call_GetInstigatorController(IntPtr Self);
		
		public AController GetInstigatorController()
		{
			return new AController(Call_GetInstigatorController((IntPtr)this));
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_DisableInput(IntPtr Self, IntPtr PlayerController);
		
		public void DisableInput(APlayerController PlayerController)
		{
			Call_DisableInput((IntPtr)this, (IntPtr)PlayerController);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_EnableInput(IntPtr Self, IntPtr PlayerController);
		
		public void EnableInput(APlayerController PlayerController)
		{
			Call_EnableInput((IntPtr)this, (IntPtr)PlayerController);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_Instigator(IntPtr Self);
		
		public void OnRep_Instigator()
		{
			Call_OnRep_Instigator((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_AttachmentReplication(IntPtr Self);
		
		public void OnRep_AttachmentReplication()
		{
			Call_OnRep_AttachmentReplication((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetReplicateMovement(IntPtr Self, bool bInReplicateMovement);
		
		public void SetReplicateMovement(bool bInReplicateMovement)
		{
			Call_SetReplicateMovement((IntPtr)this, bInReplicateMovement);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetReplicates(IntPtr Self, bool bInReplicates);
		
		public void SetReplicates(bool bInReplicates)
		{
			Call_SetReplicates((IntPtr)this, bInReplicates);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_Owner(IntPtr Self);
		
		public void OnRep_Owner()
		{
			Call_OnRep_Owner((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_TearOff(IntPtr Self);
		
		public void TearOff()
		{
			Call_TearOff((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_ReplicateMovement(IntPtr Self);
		
		public void OnRep_ReplicateMovement()
		{
			Call_OnRep_ReplicateMovement((IntPtr)this);
		}
		
		public static explicit operator IntPtr(AActor Self)
		{
			return Self.NativePointer;
		}
	}
}