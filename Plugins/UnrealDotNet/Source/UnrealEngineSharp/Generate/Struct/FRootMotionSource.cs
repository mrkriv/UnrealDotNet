// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:211

namespace UnrealEngine
{
	public  partial class FRootMotionSource : NativeStructWrapper
	{
		internal FRootMotionSource(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionSource() :
			base(E_CreateStruct_FRootMotionSource(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRootMotionSource_AccumulateMode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_AccumulateMode_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRootMotionSource_bInLocalSpace_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_bInLocalSpace_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRootMotionSource_bNeedsSimulatedCatchup_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_bNeedsSimulatedCatchup_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionSource_CurrentTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_CurrentTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionSource_Duration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_Duration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_FinishVelocityParams_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_FinishVelocityParams_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FRootMotionSource_InstanceName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_InstanceName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionSource_PreviousTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_PreviousTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_Settings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_Settings_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionSource_StartTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_StartTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_Status_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_Status_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionSource();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSource_CheckTimeOut(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRootMotionSource_Clone(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRootMotionSource_GetDuration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRootMotionSource_GetStartTime(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRootMotionSource_GetTime(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSource_IsActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSource_IsStartTimeValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSource_IsTimeOutEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSource_Matches(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSource_MatchesAndHasSameState(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSource_PrepareRootMotion(IntPtr self, float simulationTime, float movementTickTime, IntPtr character, IntPtr moveComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSource_SetTime(IntPtr self, float newTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FRootMotionSource_ToSimpleString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSource_UpdateStateFrom(IntPtr self, IntPtr sourceToTakeStateFrom, bool bMarkForSimulatedCatchup);
		
		#endregion
		
		#region Property
		public ERootMotionAccumulateMode AccumulateMode
		{
			get => (ERootMotionAccumulateMode)E_PROP_FRootMotionSource_AccumulateMode_GET(NativePointer);
			set => E_PROP_FRootMotionSource_AccumulateMode_SET(NativePointer, (byte)value);
		}

		public bool bInLocalSpace
		{
			get => E_PROP_FRootMotionSource_bInLocalSpace_GET(NativePointer);
			set => E_PROP_FRootMotionSource_bInLocalSpace_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True when this RootMotionSource has been marked for simulated catchup - this Simulated version
		/// <para>of the Source needs to catch up to where it was before being corrected by authoritative version. </para>
		/// </summary>
		public bool bNeedsSimulatedCatchup
		{
			get => E_PROP_FRootMotionSource_bNeedsSimulatedCatchup_GET(NativePointer);
			set => E_PROP_FRootMotionSource_bNeedsSimulatedCatchup_SET(NativePointer, value);
		}

		public float CurrentTime
		{
			get => E_PROP_FRootMotionSource_CurrentTime_GET(NativePointer);
			set => E_PROP_FRootMotionSource_CurrentTime_SET(NativePointer, value);
		}

		public float Duration
		{
			get => E_PROP_FRootMotionSource_Duration_GET(NativePointer);
			set => E_PROP_FRootMotionSource_Duration_SET(NativePointer, value);
		}

		public FRootMotionFinishVelocitySettings FinishVelocityParams
		{
			get => E_PROP_FRootMotionSource_FinishVelocityParams_GET(NativePointer);
			set => E_PROP_FRootMotionSource_FinishVelocityParams_SET(NativePointer, value);
		}

		public string InstanceName
		{
			get => E_PROP_FRootMotionSource_InstanceName_GET(NativePointer);
			set => E_PROP_FRootMotionSource_InstanceName_SET(NativePointer, value);
		}

		public float PreviousTime
		{
			get => E_PROP_FRootMotionSource_PreviousTime_GET(NativePointer);
			set => E_PROP_FRootMotionSource_PreviousTime_SET(NativePointer, value);
		}

		public FRootMotionSourceSettings Settings
		{
			get => E_PROP_FRootMotionSource_Settings_GET(NativePointer);
			set => E_PROP_FRootMotionSource_Settings_SET(NativePointer, value);
		}

		public float StartTime
		{
			get => E_PROP_FRootMotionSource_StartTime_GET(NativePointer);
			set => E_PROP_FRootMotionSource_StartTime_SET(NativePointer, value);
		}

		public FRootMotionSourceStatus Status
		{
			get => E_PROP_FRootMotionSource_Status_GET(NativePointer);
			set => E_PROP_FRootMotionSource_Status_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Checks if this source has timed out and marks for removal if necessary
		/// </summary>
		public virtual void CheckTimeOut()
			=> E_FRootMotionSource_CheckTimeOut(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>newly</return>
		public virtual FRootMotionSource Clone()
			=> E_FRootMotionSource_Clone(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>the</return>
		public float GetDuration()
			=> E_FRootMotionSource_GetDuration(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>the</return>
		public float GetStartTime()
			=> E_FRootMotionSource_GetStartTime(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>the</return>
		public float GetTime()
			=> E_FRootMotionSource_GetTime(this);
		
		
		/// <summary>
		/// True when this RootMotionSource should be affecting root motion
		/// </summary>
		public virtual bool IsActive()
			=> E_FRootMotionSource_IsActive(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>whether</return>
		public bool IsStartTimeValid()
			=> E_FRootMotionSource_IsStartTimeValid(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>whether</return>
		public virtual bool IsTimeOutEnabled()
			=> E_FRootMotionSource_IsTimeOutEnabled(this);
		
		
		/// <summary>
		/// This is used for networking when clients receive RootMotionSource data from the server and need
		/// <para>to decide which local RootMotionSource to compare and apply the corrections to. </para>
		/// This is required due to RootMotionSources in general being added independently on server and
		/// <para>clients, not needing to know about each other by default. </para>
		/// For well-networked RootMotionSources, any given FRootMotionSource child class could implement
		/// <para>their own unique ID and simply use that in the Matches check. This "heuristic-style" default </para>
		/// was chosen to simplify addition of new RootMotionSources, and assumes that in a networked setting
		/// <para>a given RootMotionSource won't be applied many times in a given frame by the same instigator </para>
		/// to the same target with the exact same parameters.
		/// <para>Guaranteed uniqueness would also require a strict application order ("RootMotionSources can only </para>
		/// be added on Authority") or a prediction-based setup ("Apply on Autonomous and Simulated predictively,
		/// <para>then apply on Authority and confirm, and if Authority doesn't confirm remove them"). We avoid </para>
		/// that synchronization complexity for now.
		/// <para>See UCharacterMovementComponent::ConvertRootMotionServerIDsToLocalIDs </para>
		/// Should be overridden by child classes, as default implementation only contains basic equivalency checks
		/// </summary>
		/// <return>Whether</return>
		public virtual bool Matches(FRootMotionSource other)
			=> E_FRootMotionSource_Matches(this, other);
		
		
		/// <summary>
		/// Checks that it Matches() and has the same state (time, track position, etc.)
		/// </summary>
		public virtual bool MatchesAndHasSameState(FRootMotionSource other)
			=> E_FRootMotionSource_MatchesAndHasSameState(this, other);
		
		
		/// <summary>
		/// Generates the RootMotion for this Source, can be used for both "live" generation
		/// <para>or for playback (client prediction correction, simulated proxies, etc.) </para>
		/// Examples:
		/// <para>- Animation RootMotionSources use Time as track time into AnimMontage and </para>
		/// extract the root motion from AnimMontage chunk of time (Position,Position+DeltaTime)
		/// <para>- ConstantForce source uses Time as the time into the application </para>
		/// so if its duration ends halfway through the frame it knows how much root
		/// <para>motion it should have applied </para>
		/// - Spline/curve-based sources use Time for knowing where on spline/curve to extract
		/// <para>from </para>
		/// </summary>
		/// <param name="simulationTime">How far forward in time to simulate root motion</param>
		/// <param name="movementTickTime">How much time the movement is going to take that this is being prepared for</param>
		public virtual void PrepareRootMotion(float simulationTime, float movementTickTime, ACharacter character, UCharacterMovementComponent moveComponent)
			=> E_FRootMotionSource_PrepareRootMotion(this, simulationTime, movementTickTime, character, moveComponent);
		
		
		/// <summary>
		/// Set the CurrentTime of this source. Use this setter so that sources based on duration can get correctly marked for end
		/// </summary>
		public virtual void SetTime(float newTime)
			=> E_FRootMotionSource_SetTime(this, newTime);
		
		public virtual string ToSimpleString()
			=> E_FRootMotionSource_ToSimpleString(this);
		
		
		/// <summary>
		/// Mainly for server correction purposes - update this Source's state from
		/// <para>another's, usually the authoritative state from the server's version of the Source </para>
		/// denotes a complete failure, and the Source will then be marked for removal.
		/// <para>We need to remove since we don't have a way of reverting partial updates </para>
		/// depending on where the update failed.
		/// </summary>
		/// <param name="bMarkForSimulatedCatchup">sets the source for needing to "catch up" to current state next Prepare</param>
		/// <return>Whether</return>
		public virtual bool UpdateStateFrom(FRootMotionSource sourceToTakeStateFrom, bool bMarkForSimulatedCatchup)
			=> E_FRootMotionSource_UpdateStateFrom(this, sourceToTakeStateFrom, bMarkForSimulatedCatchup);
		
		#endregion
		
		public static implicit operator IntPtr(FRootMotionSource self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRootMotionSource(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRootMotionSource(Adress, false);
		}}}
