// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AITypes.h:489

namespace UnrealEngine
{
	public partial class FAIMoveRequest : NativeStructWrapper
	{
		public FAIMoveRequest(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIMoveRequest() :
			base(E_CreateStruct_FAIMoveRequest(), false)
		{
		}

		public FAIMoveRequest(AActor inGoalActor) :
			base(E_CreateStruct_FAIMoveRequest_AActor(inGoalActor), false)
		{
		}

		public FAIMoveRequest(FVector inGoalLocation) :
			base(E_CreateStruct_FAIMoveRequest_FVector(inGoalLocation), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIMoveRequest();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIMoveRequest_AActor(IntPtr inGoalActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIMoveRequest_FVector(IntPtr inGoalLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_CanStopOnOverlap(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_CanStrafe(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FAIMoveRequest_GetAcceptanceRadius(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_GetDestination(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FAIMoveRequest_GetGoalActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_GetGoalLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FAIMoveRequest_GetUserFlags(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_IsMoveToActorRequest(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_IsProjectingGoal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_IsReachTestIncludingAgentRadius(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_IsReachTestIncludingGoalRadius(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_IsUsingPartialPaths(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_IsUsingPathfinding(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_IsValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_SetAcceptanceRadius(IntPtr self, float radius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_SetAllowPartialPath(IntPtr self, bool bAllowPartial);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_SetCanStrafe(IntPtr self, bool bStrafe);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIMoveRequest_SetGoalActor(IntPtr self, IntPtr inGoalActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIMoveRequest_SetGoalLocation(IntPtr self, IntPtr inGoalLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_SetProjectGoalLocation(IntPtr self, bool bProject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_SetReachTestIncludesAgentRadius(IntPtr self, bool bIncludeRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_SetReachTestIncludesGoalRadius(IntPtr self, bool bIncludeRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_SetStopOnOverlap(IntPtr self, bool bStop);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_SetUsePathfinding(IntPtr self, bool bPathfinding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIMoveRequest_SetUserFlags(IntPtr self, int inUserFlags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FAIMoveRequest_ToString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMoveRequest_UpdateGoalLocation(IntPtr self, IntPtr newLocation);
		
		#endregion
		
		#region ExternMethods
		public bool CanStopOnOverlap()
			=> E_FAIMoveRequest_CanStopOnOverlap(this);
		
		public bool CanStrafe()
			=> E_FAIMoveRequest_CanStrafe(this);
		
		public float GetAcceptanceRadius()
			=> E_FAIMoveRequest_GetAcceptanceRadius(this);
		
		
		/// <summary>
		/// retrieves request's requested destination location, GoalActor's location
		/// <para>or GoalLocation, depending on the request itself </para>
		/// </summary>
		public FVector GetDestination()
			=> E_FAIMoveRequest_GetDestination(this);
		
		public AActor GetGoalActor()
			=> E_FAIMoveRequest_GetGoalActor(this);
		
		public FVector GetGoalLocation()
			=> E_FAIMoveRequest_GetGoalLocation(this);
		
		public int GetUserFlags()
			=> E_FAIMoveRequest_GetUserFlags(this);
		
		public bool IsMoveToActorRequest()
			=> E_FAIMoveRequest_IsMoveToActorRequest(this);
		
		public bool IsProjectingGoal()
			=> E_FAIMoveRequest_IsProjectingGoal(this);
		
		public bool IsReachTestIncludingAgentRadius()
			=> E_FAIMoveRequest_IsReachTestIncludingAgentRadius(this);
		
		public bool IsReachTestIncludingGoalRadius()
			=> E_FAIMoveRequest_IsReachTestIncludingGoalRadius(this);
		
		public bool IsUsingPartialPaths()
			=> E_FAIMoveRequest_IsUsingPartialPaths(this);
		
		public bool IsUsingPathfinding()
			=> E_FAIMoveRequest_IsUsingPathfinding(this);
		
		
		/// <summary>
		/// the request should be either set up to move to a location, of go to a valid actor
		/// </summary>
		public bool IsValid()
			=> E_FAIMoveRequest_IsValid(this);
		
		public FAIMoveRequest SetAcceptanceRadius(float radius)
			=> E_FAIMoveRequest_SetAcceptanceRadius(this, radius);
		
		public FAIMoveRequest SetAllowPartialPath(bool bAllowPartial)
			=> E_FAIMoveRequest_SetAllowPartialPath(this, bAllowPartial);
		
		public FAIMoveRequest SetCanStrafe(bool bStrafe)
			=> E_FAIMoveRequest_SetCanStrafe(this, bStrafe);
		
		public void SetGoalActor(AActor inGoalActor)
			=> E_FAIMoveRequest_SetGoalActor(this, inGoalActor);
		
		public void SetGoalLocation(FVector inGoalLocation)
			=> E_FAIMoveRequest_SetGoalLocation(this, inGoalLocation);
		
		public FAIMoveRequest SetProjectGoalLocation(bool bProject)
			=> E_FAIMoveRequest_SetProjectGoalLocation(this, bProject);
		
		public FAIMoveRequest SetReachTestIncludesAgentRadius(bool bIncludeRadius)
			=> E_FAIMoveRequest_SetReachTestIncludesAgentRadius(this, bIncludeRadius);
		
		public FAIMoveRequest SetReachTestIncludesGoalRadius(bool bIncludeRadius)
			=> E_FAIMoveRequest_SetReachTestIncludesGoalRadius(this, bIncludeRadius);
		
		public FAIMoveRequest SetStopOnOverlap(bool bStop)
			=> E_FAIMoveRequest_SetStopOnOverlap(this, bStop);
		
		public FAIMoveRequest SetUsePathfinding(bool bPathfinding)
			=> E_FAIMoveRequest_SetUsePathfinding(this, bPathfinding);
		
		public FAIMoveRequest SetUserFlags(int inUserFlags)
			=> E_FAIMoveRequest_SetUserFlags(this, inUserFlags);
		
		public override string ToString()
			=> E_FAIMoveRequest_ToString(this);
		
		public bool UpdateGoalLocation(FVector newLocation)
			=> E_FAIMoveRequest_UpdateGoalLocation(this, newLocation);
		
		#endregion
		
		public static implicit operator IntPtr(FAIMoveRequest self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIMoveRequest(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIMoveRequest(adress, false);
		}}}
