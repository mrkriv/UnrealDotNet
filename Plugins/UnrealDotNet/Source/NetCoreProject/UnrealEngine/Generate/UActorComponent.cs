using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// ActorComponent is the base class for components that define reusable behavior that can be added to different types of Actors.
	/// ActorComponents that have a transform are known as SceneComponents and those that can be rendered are PrimitiveComponents.
	/// @see [ActorComponent](https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/Components/index.html#actorcomponents)
	/// @see USceneComponent
	/// @see UPrimitiveComponent
	/// </summary>
	public partial class UActorComponent : UObject
	{
		public UActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UActorComponent_DetermineUCSModifiedProperties(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UActorComponent_IsEditableWhenInherited(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern AActor E_UActorComponent_GetOwner(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UActorComponent_Activate(IntPtr Self, bool bReset);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UActorComponent_SetActive(IntPtr Self, bool bNewActive, bool bReset);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UActorComponent_SetIsNetStartupComponent(IntPtr Self, bool bInIsNetStartupComponent);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UActorComponent_SetComponentTickInterval(IntPtr Self, float TickInterval);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_UActorComponent_GetComponentTickInterval(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UActorComponent_RegisterComponentWithWorld(IntPtr Self, UWorld InWorld);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UActorComponent_ComponentIsInPersistentLevel(IntPtr Self, bool bIncludeLevelStreamingPersistent);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UActorComponent_AddTickPrerequisiteActor(IntPtr Self, AActor PrerequisiteActor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UActorComponent_AddTickPrerequisiteComponent(IntPtr Self, UActorComponent PrerequisiteComponent);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UActorComponent_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		#endregion
		
		#region Property
		#endregion
		
		#region ExternMethods
		public void DetermineUCSModifiedProperties()
			=> E_UActorComponent_DetermineUCSModifiedProperties(NativePointer);
		
		public bool IsEditableWhenInherited()
			=> E_UActorComponent_IsEditableWhenInherited(NativePointer);
		
		
		/// <summary>
		/// Follow the Outer chain to get the  AActor  that 'Owns' this component
		/// </summary>
		public AActor GetOwner()
			=> E_UActorComponent_GetOwner(NativePointer);
		
		
		/// <summary>
		/// Activates the SceneComponent
		/// @param bReset - The value to assign to HiddenGame.
		/// </summary>
		public void Activate(bool bReset = false)
			=> E_UActorComponent_Activate(NativePointer, bReset);
		
		
		/// <summary>
		/// Sets whether the component is active or not
		/// @param bNewActive - The new active state of the component
		/// </summary>
		public void SetActive(bool bNewActive, bool bReset = false)
			=> E_UActorComponent_SetActive(NativePointer, bNewActive, bReset);
		
		
		/// <summary>
		/// This should only be called by the engine in ULevel::InitializeNetworkActors to initialize bIsNetStartupComponent.
		/// </summary>
		public void SetIsNetStartupComponent(bool bInIsNetStartupComponent)
			=> E_UActorComponent_SetIsNetStartupComponent(NativePointer, bInIsNetStartupComponent);
		
		
		/// <summary>
		/// Sets the tick interval for this component's primary tick function. Does not enable the tick interval. Takes effect on next tick.
		/// @param TickInterval	The duration between ticks for this component's primary tick function
		/// </summary>
		public void SetComponentTickInterval(float TickInterval)
			=> E_UActorComponent_SetComponentTickInterval(NativePointer, TickInterval);
		
		
		/// <summary>
		/// Returns whether this component has tick enabled or not
		/// </summary>
		public float GetComponentTickInterval()
			=> E_UActorComponent_GetComponentTickInterval(NativePointer);
		
		
		/// <summary>
		/// @param InWorld - The world to register the component with.
		/// </summary>
		public void RegisterComponentWithWorld(UWorld InWorld)
			=> E_UActorComponent_RegisterComponentWithWorld(NativePointer, InWorld);
		
		
		/// <summary>
		/// See if this component is in the persistent level
		/// </summary>
		public bool ComponentIsInPersistentLevel(bool bIncludeLevelStreamingPersistent)
			=> E_UActorComponent_ComponentIsInPersistentLevel(NativePointer, bIncludeLevelStreamingPersistent);
		
		
		/// <summary>
		/// Make this component tick after PrerequisiteActor
		/// </summary>
		public void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UActorComponent_AddTickPrerequisiteActor(NativePointer, PrerequisiteActor);
		
		
		/// <summary>
		/// Make this component tick after PrerequisiteComponent.
		/// </summary>
		public void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UActorComponent_AddTickPrerequisiteComponent(NativePointer, PrerequisiteComponent);
		
		
		/// <summary>
		/// Called by owner actor on position shifting
		/// Component should update all relevant data structures to reflect new actor location
		/// @param InWorldOffset	 Offset vector the actor shifted by
		/// @param bWorldShift	 Whether this call is part of whole world shifting
		/// </summary>
		public void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_UActorComponent_ApplyWorldOffset(NativePointer, InOffset, bWorldShift);
		
		#endregion
		
		public static implicit operator IntPtr(UActorComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UActorComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UActorComponent(Adress);
		}}}
