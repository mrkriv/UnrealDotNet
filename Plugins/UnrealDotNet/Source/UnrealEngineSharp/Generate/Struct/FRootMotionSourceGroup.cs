// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:727

namespace UnrealEngine
{
	public  partial class FRootMotionSourceGroup : NativeStructWrapper
	{
		internal FRootMotionSourceGroup(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionSourceGroup() :
			base(E_CreateStruct_FRootMotionSourceGroup(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRootMotionSourceGroup_bHasAdditiveSources_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSourceGroup_bHasAdditiveSources_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRootMotionSourceGroup_bHasOverrideSources_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSourceGroup_bHasOverrideSources_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRootMotionSourceGroup_bIsAdditiveVelocityApplied_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSourceGroup_bIsAdditiveVelocityApplied_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSourceGroup_LastAccumulatedSettings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSourceGroup_LastAccumulatedSettings_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionSourceGroup();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_AccumulateAdditiveRootMotionVelocity(IntPtr self, float deltaTime, IntPtr character, IntPtr moveComponent, IntPtr inOutVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_AccumulateOverrideRootMotionVelocity(IntPtr self, float deltaTime, IntPtr character, IntPtr moveComponent, IntPtr inOutVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_ApplyTimeStampReset(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_CleanUpInvalidRootMotion(IntPtr self, float deltaTime, IntPtr character, IntPtr moveComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_Clear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_CullInvalidSources(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSourceGroup_HasActiveRootMotionSources(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSourceGroup_HasAdditiveVelocity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSourceGroup_HasOverrideVelocity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSourceGroup_HasRootMotionToApply(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSourceGroup_HasVelocity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_PrepareRootMotion(IntPtr self, float deltaTime, IntPtr character, IntPtr inMoveComponent, bool bForcePrepareAll);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_RemoveRootMotionSource(IntPtr self, string instanceName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_SetPendingRootMotionSourceMinStartTimes(IntPtr self, float newStartTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceGroup_UpdateStateFrom(IntPtr self, IntPtr groupToTakeStateFrom, bool bMarkForSimulatedCatchup);
		
		#endregion
		
		#region Property
		public byte bHasAdditiveSources
		{
			get => E_PROP_FRootMotionSourceGroup_bHasAdditiveSources_GET(NativePointer);
			set => E_PROP_FRootMotionSourceGroup_bHasAdditiveSources_SET(NativePointer, value);
		}

		public byte bHasOverrideSources
		{
			get => E_PROP_FRootMotionSourceGroup_bHasOverrideSources_GET(NativePointer);
			set => E_PROP_FRootMotionSourceGroup_bHasOverrideSources_SET(NativePointer, value);
		}

		public byte bIsAdditiveVelocityApplied
		{
			get => E_PROP_FRootMotionSourceGroup_bIsAdditiveVelocityApplied_GET(NativePointer);
			set => E_PROP_FRootMotionSourceGroup_bIsAdditiveVelocityApplied_SET(NativePointer, value);
		}

		public FRootMotionSourceSettings LastAccumulatedSettings
		{
			get => E_PROP_FRootMotionSourceGroup_LastAccumulatedSettings_GET(NativePointer);
			set => E_PROP_FRootMotionSourceGroup_LastAccumulatedSettings_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Helper function for accumulating additive velocity into InOutVelocity
		/// </summary>
		public void AccumulateAdditiveRootMotionVelocity(float deltaTime, ACharacter character, UCharacterMovementComponent moveComponent, FVector inOutVelocity)
			=> E_FRootMotionSourceGroup_AccumulateAdditiveRootMotionVelocity(this, deltaTime, character, moveComponent, inOutVelocity);
		
		
		/// <summary>
		/// Helper function for accumulating override velocity into InOutVelocity
		/// </summary>
		public void AccumulateOverrideRootMotionVelocity(float deltaTime, ACharacter character, UCharacterMovementComponent moveComponent, FVector inOutVelocity)
			=> E_FRootMotionSourceGroup_AccumulateOverrideRootMotionVelocity(this, deltaTime, character, moveComponent, inOutVelocity);
		
		
		/// <summary>
		/// Applies a reset to the start time for each root motion when the time stamp is reset
		/// </summary>
		public void ApplyTimeStampReset(float deltaTime)
			=> E_FRootMotionSourceGroup_ApplyTimeStampReset(this, deltaTime);
		
		public void CleanUpInvalidRootMotion(float deltaTime, ACharacter character, UCharacterMovementComponent moveComponent)
			=> E_FRootMotionSourceGroup_CleanUpInvalidRootMotion(this, deltaTime, character, moveComponent);
		
		
		/// <summary>
		/// Clear the contents to return it to "empty"
		/// </summary>
		public void Clear()
			=> E_FRootMotionSourceGroup_Clear(this);
		
		
		/// <summary>
		/// Removes any Sources without a valid ID
		/// </summary>
		public void CullInvalidSources()
			=> E_FRootMotionSourceGroup_CullInvalidSources(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool HasActiveRootMotionSources()
			=> E_FRootMotionSourceGroup_HasActiveRootMotionSources(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool HasAdditiveVelocity()
			=> E_FRootMotionSourceGroup_HasAdditiveVelocity(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool HasOverrideVelocity()
			=> E_FRootMotionSourceGroup_HasOverrideVelocity(this);
		
		
		/// <summary>
		/// Not valid outside of the scope of that function. Since RootMotion is extracted and used in it.
		/// </summary>
		/// <return>true</return>
		public bool HasRootMotionToApply()
			=> E_FRootMotionSourceGroup_HasRootMotionToApply(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool HasVelocity()
			=> E_FRootMotionSourceGroup_HasVelocity(this);
		
		
		/// <summary>
		/// Generates root motion by accumulating transforms through current root motion sources.
		/// <para>Needed due to SavedMove playback/server correction only applying corrections to </para>
		/// Sources that need updating, so in that case we only Prepare those that need it.
		/// </summary>
		/// <param name="bForcePrepareAll">Used during "live" PerformMovements() to ensure all sources get prepared</param>
		public void PrepareRootMotion(float deltaTime, ACharacter character, UCharacterMovementComponent inMoveComponent, bool bForcePrepareAll = false)
			=> E_FRootMotionSourceGroup_PrepareRootMotion(this, deltaTime, character, inMoveComponent, bForcePrepareAll);
		
		
		/// <summary>
		/// Remove a RootMotionSource from this Group by name
		/// </summary>
		public void RemoveRootMotionSource(string instanceName)
			=> E_FRootMotionSourceGroup_RemoveRootMotionSource(this, instanceName);
		
		
		/// <summary>
		/// Sets the StartTime of all pending root motion sources to be at least this time, can be used on servers to match client-side start times
		/// </summary>
		public void SetPendingRootMotionSourceMinStartTimes(float newStartTime)
			=> E_FRootMotionSourceGroup_SetPendingRootMotionSourceMinStartTimes(this, newStartTime);
		
		
		/// <summary>
		/// Update contained Sources to state in matching sources from other group.
		/// <para>Used for correcting root motion state when receiving authoritative state from server. </para>
		/// </summary>
		/// <param name="groupToTakeStateFrom">the Authoritative Group to take state from</param>
		/// <param name="bMarkForSimulatedCatchup">marks Sources as needing to return to their current Time on next Prepare</param>
		/// <return>whether</return>
		public void UpdateStateFrom(FRootMotionSourceGroup groupToTakeStateFrom, bool bMarkForSimulatedCatchup = false)
			=> E_FRootMotionSourceGroup_UpdateStateFrom(this, groupToTakeStateFrom, bMarkForSimulatedCatchup);
		
		#endregion
		
		public static implicit operator IntPtr(FRootMotionSourceGroup self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRootMotionSourceGroup(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRootMotionSourceGroup(adress, false);
		}}}
