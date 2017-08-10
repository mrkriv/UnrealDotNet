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
		
		/// <summary>
		/// 
		/// <summary>
		public void ForceNetUpdate()
		{
			Call_ForceNetUpdate((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_WasRecentlyRendered(IntPtr Self, float Tolerance);
		
		/// <summary>
		/// 
		/// <summary>
		public bool WasRecentlyRendered(float Tolerance)
		{
			return Call_WasRecentlyRendered((IntPtr)this, Tolerance);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_K2_OnReset(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void K2_OnReset()
		{
			Call_K2_OnReset((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsChildActor(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool IsChildActor()
		{
			return Call_IsChildActor((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_FlushNetDormancy(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void FlushNetDormancy()
		{
			Call_FlushNetDormancy((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_ReplicatedMovement(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void OnRep_ReplicatedMovement()
		{
			Call_OnRep_ReplicatedMovement((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetActorTickInterval(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public float GetActorTickInterval()
		{
			return Call_GetActorTickInterval((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorTickInterval(IntPtr Self, float TickInterval);
		
		/// <summary>
		/// 
		/// <summary>
		public void SetActorTickInterval(float TickInterval)
		{
			Call_SetActorTickInterval((IntPtr)this, TickInterval);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsActorTickEnabled(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool IsActorTickEnabled()
		{
			return Call_IsActorTickEnabled((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorTickEnabled(IntPtr Self, bool bEnabled);
		
		/// <summary>
		/// 
		/// <summary>
		public void SetActorTickEnabled(bool bEnabled)
		{
			Call_SetActorTickEnabled((IntPtr)this, bEnabled);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsSelectable(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool IsSelectable()
		{
			return Call_IsSelectable((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsEditable(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool IsEditable()
		{
			return Call_IsEditable((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsTemporarilyHiddenInEditor(IntPtr Self, bool bIncludeParent);
		
		/// <summary>
		/// 
		/// <summary>
		public bool IsTemporarilyHiddenInEditor(bool bIncludeParent)
		{
			return Call_IsTemporarilyHiddenInEditor((IntPtr)this, bIncludeParent);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetIsTemporarilyHiddenInEditor(IntPtr Self, bool bIsHidden);
		
		/// <summary>
		/// 
		/// <summary>
		public void SetIsTemporarilyHiddenInEditor(bool bIsHidden)
		{
			Call_SetIsTemporarilyHiddenInEditor((IntPtr)this, bIsHidden);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsHiddenEd(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool IsHiddenEd()
		{
			return Call_IsHiddenEd((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsHiddenEdAtStartup(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool IsHiddenEdAtStartup()
		{
			return Call_IsHiddenEdAtStartup((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveDestroyed(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void ReceiveDestroyed()
		{
			Call_ReceiveDestroyed((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_UserConstructionScript(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void UserConstructionScript()
		{
			Call_UserConstructionScript((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetLifeSpan(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public float GetLifeSpan()
		{
			return Call_GetLifeSpan((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetLifeSpan(IntPtr Self, float InLifespan);
		
		/// <summary>
		/// 
		/// <summary>
		public void SetLifeSpan(float InLifespan)
		{
			Call_SetLifeSpan((IntPtr)this, InLifespan);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveActorEndCursorOver(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void ReceiveActorEndCursorOver()
		{
			Call_ReceiveActorEndCursorOver((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveActorBeginCursorOver(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void ReceiveActorBeginCursorOver()
		{
			Call_ReceiveActorBeginCursorOver((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		/// <summary>
		/// 
		/// <summary>
		public void ReceiveTick(float DeltaSeconds)
		{
			Call_ReceiveTick((IntPtr)this, DeltaSeconds);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_IsActorBeingDestroyed(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool IsActorBeingDestroyed()
		{
			return Call_IsActorBeingDestroyed((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_ReceiveBeginPlay(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void ReceiveBeginPlay()
		{
			Call_ReceiveBeginPlay((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetGameTimeSinceCreation(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public float GetGameTimeSinceCreation()
		{
			return Call_GetGameTimeSinceCreation((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetTickableWhenPaused(IntPtr Self, bool bTickableWhenPaused);
		
		/// <summary>
		/// 
		/// <summary>
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
		{
			Call_SetTickableWhenPaused((IntPtr)this, bTickableWhenPaused);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_GetTickableWhenPaused(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool GetTickableWhenPaused()
		{
			return Call_GetTickableWhenPaused((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern float Call_GetActorTimeDilation(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public float GetActorTimeDilation()
		{
			return Call_GetActorTimeDilation((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_DetachRootComponentFromParent(IntPtr Self, bool bMaintainWorldPosition);
		
		/// <summary>
		/// 
		/// <summary>
		public void DetachRootComponentFromParent(bool bMaintainWorldPosition)
		{
			Call_DetachRootComponentFromParent((IntPtr)this, bMaintainWorldPosition);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_HasAuthority(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool HasAuthority()
		{
			return Call_HasAuthority((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_K2_DestroyActor(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void K2_DestroyActor()
		{
			Call_K2_DestroyActor((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool Call_GetActorEnableCollision(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public bool GetActorEnableCollision()
		{
			return Call_GetActorEnableCollision((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorEnableCollision(IntPtr Self, bool bNewActorEnableCollision);
		
		/// <summary>
		/// 
		/// <summary>
		public void SetActorEnableCollision(bool bNewActorEnableCollision)
		{
			Call_SetActorEnableCollision((IntPtr)this, bNewActorEnableCollision);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetActorHiddenInGame(IntPtr Self, bool bNewHidden);
		
		/// <summary>
		/// 
		/// <summary>
		public void SetActorHiddenInGame(bool bNewHidden)
		{
			Call_SetActorHiddenInGame((IntPtr)this, bNewHidden);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_Instigator(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void OnRep_Instigator()
		{
			Call_OnRep_Instigator((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_AttachmentReplication(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void OnRep_AttachmentReplication()
		{
			Call_OnRep_AttachmentReplication((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetReplicateMovement(IntPtr Self, bool bInReplicateMovement);
		
		/// <summary>
		/// 
		/// <summary>
		public void SetReplicateMovement(bool bInReplicateMovement)
		{
			Call_SetReplicateMovement((IntPtr)this, bInReplicateMovement);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_SetReplicates(IntPtr Self, bool bInReplicates);
		
		/// <summary>
		/// 
		/// <summary>
		public void SetReplicates(bool bInReplicates)
		{
			Call_SetReplicates((IntPtr)this, bInReplicates);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_Owner(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void OnRep_Owner()
		{
			Call_OnRep_Owner((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_TearOff(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
		public void TearOff()
		{
			Call_TearOff((IntPtr)this);
		}
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void Call_OnRep_ReplicateMovement(IntPtr Self);
		
		/// <summary>
		/// 
		/// <summary>
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