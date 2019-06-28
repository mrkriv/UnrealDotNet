// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AIController.h:85

namespace UnrealEngine
{
	public partial class AAIController : AController
	{
		public AAIController(IntPtr adress)
			: base(adress)
		{
		}

		public AAIController(UObject Parent = null, string Name = "AIController")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AAIController(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_AAIController_bAIIgnorePlayers_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_AAIController_BrainComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AAIController_BrainComponent_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AAIController(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AAIController_AreAIIgnoringPlayers(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AAIController_GetActionsComp(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AAIController_GetBrainComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AAIController_GetCurrentMoveRequestID(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AAIController_GetDebugIcon(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AAIController_GetFocalPoint(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AAIController_GetFocalPointOnActor(IntPtr self, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AAIController_GetFocusActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_AAIController_GetGameplayTaskDefaultPriority(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_AAIController_GetImmediateMoveDestination(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AAIController_HasPartialPath(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AAIController_K2_ClearFocus(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AAIController_K2_SetFocalPoint(IntPtr self, IntPtr fP);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AAIController_K2_SetFocus(IntPtr self, IntPtr newFocus);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AAIController_PauseMove(IntPtr self, IntPtr requestToPause);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AAIController_ResumeMove(IntPtr self, IntPtr requestToResume);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AAIController_SetFocalPoint(IntPtr self, IntPtr newFocus);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AAIController_SetFocus(IntPtr self, IntPtr newFocus);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AAIController_SetMoveBlockDetection(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AAIController_SuggestTossVelocity(IntPtr self, IntPtr outTossVelocity, IntPtr start, IntPtr end, float tossSpeed, bool bPreferHighArc, float collisionRadius, bool bOnlyTraceUp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AAIController_ToggleAIIgnorePlayers(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AAIController_UpdateControlRotation(IntPtr self, float deltaTime, bool bUpdatePawn);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// If true, AI controllers will ignore players.
		/// </summary>
		public static bool bAIIgnorePlayers
		{
			get => E_PROP_AAIController_bAIIgnorePlayers_GET();
		}

		
		/// <summary>
		/// Component responsible for behaviors.
		/// </summary>
		public UBrainComponent BrainComponent
		{
			get => E_PROP_AAIController_BrainComponent_GET(NativePointer);
			set => E_PROP_AAIController_BrainComponent_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool AreAIIgnoringPlayers()
			=> E_AAIController_AreAIIgnoringPlayers(this);
		
		
		/// <summary>
		/// Returns ActionsComp subobject
		/// </summary>
		public UPawnActionsComponent GetActionsComp()
			=> E_AAIController_GetActionsComp(this);
		
		public UBrainComponent GetBrainComponent()
			=> E_AAIController_GetBrainComponent(this);
		
		
		/// <summary>
		/// Returns the Move Request ID for the current move
		/// </summary>
		public FAIRequestID GetCurrentMoveRequestID()
			=> E_AAIController_GetCurrentMoveRequestID(this);
		
		public virtual string GetDebugIcon()
			=> E_AAIController_GetDebugIcon(this);
		
		
		/// <summary>
		/// Retrieve the final position that controller should be looking at.
		/// </summary>
		public FVector GetFocalPoint()
			=> E_AAIController_GetFocalPoint(this);
		
		
		/// <summary>
		/// Retrieve the focal point this controller should focus to on given actor.
		/// </summary>
		public virtual FVector GetFocalPointOnActor(AActor actor)
			=> E_AAIController_GetFocalPointOnActor(this, actor);
		
		
		/// <summary>
		/// Get the focused actor.
		/// </summary>
		public AActor GetFocusActor()
			=> E_AAIController_GetFocusActor(this);
		
		public virtual byte GetGameplayTaskDefaultPriority()
			=> E_AAIController_GetGameplayTaskDefaultPriority(this);
		
		
		/// <summary>
		/// Returns position of current path segment's end.
		/// </summary>
		public FVector GetImmediateMoveDestination()
			=> E_AAIController_GetImmediateMoveDestination(this);
		
		
		/// <summary>
		/// Returns true if the current PathFollowingComponent's path is partial (does not reach desired destination).
		/// </summary>
		public bool HasPartialPath()
			=> E_AAIController_HasPartialPath(this);
		
		
		/// <summary>
		/// Clears Focus, will also clear FocalPoint as a result
		/// </summary>
		public void ClearFocus()
			=> E_AAIController_K2_ClearFocus(this);
		
		
		/// <summary>
		/// Set the position that controller should be looking at.
		/// </summary>
		public void K2_SetFocalPoint(FVector fP)
			=> E_AAIController_K2_SetFocalPoint(this, fP);
		
		
		/// <summary>
		/// Set Focus for actor, will set FocalPoint as a result.
		/// </summary>
		public void K2_SetFocus(AActor newFocus)
			=> E_AAIController_K2_SetFocus(this, newFocus);
		
		
		/// <summary>
		/// if AI is currently moving due to request given by RequestToPause, then the move will be paused
		/// </summary>
		public bool PauseMove(FAIRequestID requestToPause)
			=> E_AAIController_PauseMove(this, requestToPause);
		
		
		/// <summary>
		/// resumes last AI-performed, paused request provided it's ID was equivalent to RequestToResume
		/// </summary>
		public bool ResumeMove(FAIRequestID requestToResume)
			=> E_AAIController_ResumeMove(this, requestToResume);
		
		
		/// <summary>
		/// Set FocalPoint for given priority as absolute position or offset from base.
		/// </summary>
		public virtual void SetFocalPoint(FVector newFocus)
			=> E_AAIController_SetFocalPoint(this, newFocus);
		
		public virtual void SetFocus(AActor newFocus)
			=> E_AAIController_SetFocus(this, newFocus);
		
		
		/// <summary>
		/// Updates state of movement block detection.
		/// </summary>
		public void SetMoveBlockDetection(bool bEnable)
			=> E_AAIController_SetMoveBlockDetection(this, bEnable);
		
		
		/// <summary>
		/// Computes a launch velocity vector to toss a projectile and hit the given destination.
		/// <para>Performance note: Potentially expensive. Nonzero CollisionRadius and bOnlyTraceUp=false are the more expensive options. </para>
		/// </summary>
		/// <param name="outTossVelocity">out param stuffed with the computed velocity to use</param>
		/// <param name="start">desired start point of arc</param>
		/// <param name="end">desired end point of arc</param>
		/// <param name="tossSpeed">Initial speed of the theoretical projectile. Assumed to only change due to gravity for the entire lifetime of the projectile</param>
		/// <param name="collisionSize">optional) - is the size of bounding box of the tossed actor (defaults to (0,0,0)</param>
		/// <param name="bOnlyTraceUp">optional) - when true collision checks verifying the arc will only be done along the upward portion of the arc</param>
		/// <return>true</return>
		public bool SuggestTossVelocity(FVector outTossVelocity, FVector start, FVector end, float tossSpeed, bool bPreferHighArc, float collisionRadius = 0, bool bOnlyTraceUp = false)
			=> E_AAIController_SuggestTossVelocity(this, outTossVelocity, start, end, tossSpeed, bPreferHighArc, collisionRadius, bOnlyTraceUp);
		
		public void ToggleAIIgnorePlayers()
			=> E_AAIController_ToggleAIIgnorePlayers(this);
		
		
		/// <summary>
		/// Update direction AI is looking based on FocalPoint
		/// </summary>
		public virtual void UpdateControlRotation(float deltaTime, bool bUpdatePawn)
			=> E_AAIController_UpdateControlRotation(this, deltaTime, bUpdatePawn);
		
		#endregion
		
		public static implicit operator IntPtr(AAIController self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AAIController(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AAIController>(PtrDesc);
		}}}
