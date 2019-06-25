// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\PawnSensingComponent.h:21

namespace UnrealEngine
{
	public partial class UPawnSensingComponent : UActorComponent
	{
		public UPawnSensingComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UPawnSensingComponent(UObject Parent = null, string Name = "PawnSensingComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnSensingComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPawnSensingComponent_HearingMaxSoundAge_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnSensingComponent_HearingMaxSoundAge_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPawnSensingComponent_HearingThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnSensingComponent_HearingThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPawnSensingComponent_LOSHearingThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnSensingComponent_LOSHearingThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPawnSensingComponent_SensingInterval_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnSensingComponent_SensingInterval_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPawnSensingComponent_SightRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnSensingComponent_SightRadius_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnSensingComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_BroadcastOnHearLocalNoise(IntPtr self, IntPtr instigator, IntPtr location, float volume);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_BroadcastOnHearRemoteNoise(IntPtr self, IntPtr instigator, IntPtr location, float volume);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_BroadcastOnSeePawn(IntPtr self, IntPtr pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnSensingComponent_CanHear(IntPtr self, IntPtr noiseLoc, float loudness, bool bFailedLOS);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnSensingComponent_CanSenseAnything(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnSensingComponent_CouldSeePawn(IntPtr self, IntPtr other, bool bMaySkipChecks);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPawnSensingComponent_GetPeripheralVisionAngle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPawnSensingComponent_GetPeripheralVisionCosine(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnSensingComponent_GetSensorActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnSensingComponent_GetSensorController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnSensingComponent_GetSensorLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnSensingComponent_GetSensorRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnSensingComponent_HasLineOfSightTo(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnSensingComponent_IsNoiseRelevant(IntPtr self, IntPtr pawn, IntPtr noiseEmitterComponent, bool bSourceWithinNoiseEmitter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnSensingComponent_IsSensorActor(IntPtr self, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_OnTimer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_SensePawn(IntPtr self, IntPtr pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_SetPeripheralVisionAngle(IntPtr self, float newPeripheralVisionAngle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_SetSensingInterval(IntPtr self, float newSensingInterval);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_SetSensingUpdatesEnabled(IntPtr self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_SetTimer(IntPtr self, float timeDelay);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnSensingComponent_ShouldCheckAudibilityOf(IntPtr self, IntPtr pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnSensingComponent_ShouldCheckVisibilityOf(IntPtr self, IntPtr pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnSensingComponent_UpdateAISensing(IntPtr self);
		
		#endregion
		
		#region Property
		public float HearingMaxSoundAge
		{
			get => E_PROP_UPawnSensingComponent_HearingMaxSoundAge_GET(NativePointer);
			set => E_PROP_UPawnSensingComponent_HearingMaxSoundAge_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance at which a makenoise(1.0) loudness sound can be heard, regardless of occlusion
		/// </summary>
		public float HearingThreshold
		{
			get => E_PROP_UPawnSensingComponent_HearingThreshold_GET(NativePointer);
			set => E_PROP_UPawnSensingComponent_HearingThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance at which a makenoise(1.0) loudness sound can be heard if unoccluded (LOSHearingThreshold should be > HearingThreshold)
		/// </summary>
		public float LOSHearingThreshold
		{
			get => E_PROP_UPawnSensingComponent_LOSHearingThreshold_GET(NativePointer);
			set => E_PROP_UPawnSensingComponent_LOSHearingThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Amount of time between pawn sensing updates. Use SetSensingInterval() to adjust this at runtime. A value <= 0 prevents any updates.
		/// </summary>
		public float SensingInterval
		{
			get => E_PROP_UPawnSensingComponent_SensingInterval_GET(NativePointer);
			set => E_PROP_UPawnSensingComponent_SensingInterval_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum sight distance.
		/// </summary>
		public float SightRadius
		{
			get => E_PROP_UPawnSensingComponent_SightRadius_GET(NativePointer);
			set => E_PROP_UPawnSensingComponent_SightRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected virtual void BroadcastOnHearLocalNoise(APawn instigator, FVector location, float volume)
			=> E_UPawnSensingComponent_BroadcastOnHearLocalNoise(this, instigator, location, volume);
		
		protected virtual void BroadcastOnHearRemoteNoise(APawn instigator, FVector location, float volume)
			=> E_UPawnSensingComponent_BroadcastOnHearRemoteNoise(this, instigator, location, volume);
		
		protected virtual void BroadcastOnSeePawn(APawn pawn)
			=> E_UPawnSensingComponent_BroadcastOnSeePawn(this, pawn);
		
		
		/// <summary>
		/// @Returns true if sensor can hear this noise. Only executed if the noise has been determined to be relevant (via IsNoiseRelevant)
		/// </summary>
		public virtual bool CanHear(FVector noiseLoc, float loudness, bool bFailedLOS)
			=> E_UPawnSensingComponent_CanHear(this, noiseLoc, loudness, bFailedLOS);
		
		
		/// <summary>
		/// Are we capable of sensing anything (and do we have any callbacks that care about sensing)? If so UpdateAISensing() will be called every sensing interval.
		/// </summary>
		public virtual bool CanSenseAnything()
			=> E_UPawnSensingComponent_CanSenseAnything(this);
		
		
		/// <summary>
		/// Chance of seeing other pawn decreases with increasing distance or angle in peripheral vision
		/// </summary>
		/// <param name="bMaySkipChecks">if true allows checks to be sometimes skipped if target is far away (used by periodic automatic visibility checks)</param>
		/// <return>true</return>
		public virtual bool CouldSeePawn(APawn other, bool bMaySkipChecks)
			=> E_UPawnSensingComponent_CouldSeePawn(this, other, bMaySkipChecks);
		
		public float GetPeripheralVisionAngle()
			=> E_UPawnSensingComponent_GetPeripheralVisionAngle(this);
		
		public float GetPeripheralVisionCosine()
			=> E_UPawnSensingComponent_GetPeripheralVisionCosine(this);
		
		protected AActor GetSensorActor()
			=> E_UPawnSensingComponent_GetSensorActor(this);
		
		protected AController GetSensorController()
			=> E_UPawnSensingComponent_GetSensorController(this);
		
		
		/// <summary>
		/// Get position where hearing/seeing occurs (i.e. ear/eye position).  If we ever need different positions for hearing/seeing, we'll deal with that then!
		/// </summary>
		public virtual FVector GetSensorLocation()
			=> E_UPawnSensingComponent_GetSensorLocation(this);
		
		
		/// <summary>
		/// Get the rotation of this sensor. We need this for the sight component
		/// </summary>
		public virtual FRotator GetSensorRotation()
			=> E_UPawnSensingComponent_GetSensorRotation(this);
		
		
		/// <summary>
		/// Check line to other actor.
		/// </summary>
		/// <param name="other">is the actor whose visibility is being checked.</param>
		/// <param name="viewPoint">is eye position visibility is being checked from.</param>
		/// <return>true</return>
		public virtual bool HasLineOfSightTo(AActor other)
			=> E_UPawnSensingComponent_HasLineOfSightTo(this, other);
		
		
		/// <summary>
		/// Test whether the noise is loud enough and recent enough to care about.  bSourceWithinNoiseEmitter is true iff the
		/// <para>noise was made by the pawn itself or within close proximity (its collision volume).  Otherwise the noise was made </para>
		/// at significant distance from the pawn.
		/// </summary>
		public bool IsNoiseRelevant(APawn pawn, UPawnNoiseEmitterComponent noiseEmitterComponent, bool bSourceWithinNoiseEmitter)
			=> E_UPawnSensingComponent_IsNoiseRelevant(this, pawn, noiseEmitterComponent, bSourceWithinNoiseEmitter);
		
		
		/// <summary>
		/// Is the given actor our owner? Used to ensure that we are not trying to sense our self / our owner.
		/// </summary>
		public virtual bool IsSensorActor(AActor actor)
			=> E_UPawnSensingComponent_IsSensorActor(this, actor);
		
		
		/// <summary>
		/// Update function called on timer intervals.
		/// </summary>
		protected virtual void OnTimer()
			=> E_UPawnSensingComponent_OnTimer(this);
		
		
		/// <summary>
		/// See if there are interesting sounds and sights that we want to detect, and respond to them if so.
		/// </summary>
		protected virtual void SensePawn(APawn pawn)
			=> E_UPawnSensingComponent_SensePawn(this, pawn);
		
		
		/// <summary>
		/// Sets PeripheralVisionAngle. Calculates PeripheralVisionCosine from PeripheralVisionAngle
		/// </summary>
		public virtual void SetPeripheralVisionAngle(float newPeripheralVisionAngle)
			=> E_UPawnSensingComponent_SetPeripheralVisionAngle(this, newPeripheralVisionAngle);
		
		
		/// <summary>
		/// Changes the SensingInterval.
		/// <para>If we are currently waiting for an interval, this can either extend or shorten that interval. </para>
		/// A value <= 0 prevents any updates.
		/// </summary>
		public virtual void SetSensingInterval(float newSensingInterval)
			=> E_UPawnSensingComponent_SetSensingInterval(this, newSensingInterval);
		
		
		/// <summary>
		/// Enables or disables sensing updates. The timer is reset in either case.
		/// </summary>
		public virtual void SetSensingUpdatesEnabled(bool bEnabled)
			=> E_UPawnSensingComponent_SetSensingUpdatesEnabled(this, bEnabled);
		
		
		/// <summary>
		/// Modify the timer to fire in TimeDelay seconds. A value <= 0 disables the timer.
		/// </summary>
		protected virtual void SetTimer(float timeDelay)
			=> E_UPawnSensingComponent_SetTimer(this, timeDelay);
		
		
		/// <summary>
		/// Returns true if we should check whether we can hear the given Pawn (because we are able to hear, and the Pawn has the correct team relationship to us)
		/// </summary>
		public virtual bool ShouldCheckAudibilityOf(APawn pawn)
			=> E_UPawnSensingComponent_ShouldCheckAudibilityOf(this, pawn);
		
		
		/// <summary>
		/// Returns true if we should check whether the given Pawn is visible (because we can see things, the Pawn is not hidden, and if the Pawn is a player and we only see players)
		/// </summary>
		public virtual bool ShouldCheckVisibilityOf(APawn pawn)
			=> E_UPawnSensingComponent_ShouldCheckVisibilityOf(this, pawn);
		
		
		/// <summary>
		/// Calls SensePawn on any Pawns that we are allowed to sense.
		/// </summary>
		protected virtual void UpdateAISensing()
			=> E_UPawnSensingComponent_UpdateAISensing(this);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnSensingComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPawnSensingComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnSensingComponent>(PtrDesc);
		}}}
