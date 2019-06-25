// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionComponent.h:162

namespace UnrealEngine
{
	public partial class UAIPerceptionComponent : UActorComponent
	{
		public UAIPerceptionComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UAIPerceptionComponent(UObject Parent = null, string Name = "AIPerceptionComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAIPerceptionComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAIPerceptionComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAIPerceptionComponent_AgeStimuli(IntPtr self, float constPerceptionAgingRate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionComponent_CleanUp(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionComponent_ConfigureSense(IntPtr self, IntPtr senseConfig);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionComponent_ForgetActor(IntPtr self, IntPtr actorToForget);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionComponent_ForgetAll(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAIPerceptionComponent_GetActorInfo(IntPtr self, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAIPerceptionComponent_GetActorLocation(IntPtr self, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAIPerceptionComponent_GetActorsPerception(IntPtr self, IntPtr actor, IntPtr info);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UAIPerceptionComponent_GetBodyActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionComponent_GetLocationAndDirection(IntPtr self, IntPtr location, IntPtr direction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UAIPerceptionComponent_GetMutableBodyActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAIPerceptionComponent_GetPerceptionFilter(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAIPerceptionComponent_GetTeamIdentifier(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UAIPerceptionComponent_GetYoungestStimulusAge(IntPtr self, IntPtr source);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAIPerceptionComponent_HasAnyActiveStimulus(IntPtr self, IntPtr source);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAIPerceptionComponent_HasAnyCurrentStimulus(IntPtr self, IntPtr source);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionComponent_ProcessStimuli(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionComponent_RemoveDeadData(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionComponent_RequestStimuliListenerUpdate(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns true if, as result of stimuli aging, this listener needs an update (like if some stimuli expired)
		/// </summary>
		public bool AgeStimuli(float constPerceptionAgingRate)
			=> E_UAIPerceptionComponent_AgeStimuli(this, constPerceptionAgingRate);
		
		
		/// <summary>
		/// called to clean up on owner's end play or destruction
		/// </summary>
		protected virtual void CleanUp()
			=> E_UAIPerceptionComponent_CleanUp(this);
		
		public void ConfigureSense(UAISenseConfig senseConfig)
			=> E_UAIPerceptionComponent_ConfigureSense(this, senseConfig);
		
		public void ForgetActor(AActor actorToForget)
			=> E_UAIPerceptionComponent_ForgetActor(this, actorToForget);
		
		
		/// <summary>
		/// basically cleans up PerceptualData, resulting in loss of all previous perception
		/// </summary>
		public void ForgetAll()
			=> E_UAIPerceptionComponent_ForgetAll(this);
		
		public FActorPerceptionInfo GetActorInfo(AActor actor)
			=> E_UAIPerceptionComponent_GetActorInfo(this, actor);
		
		public FVector GetActorLocation(AActor actor)
			=> E_UAIPerceptionComponent_GetActorLocation(this, actor);
		
		
		/// <summary>
		/// Retrieves whatever has been sensed about given actor
		/// </summary>
		public bool GetActorsPerception(AActor actor, FActorPerceptionBlueprintInfo info)
			=> E_UAIPerceptionComponent_GetActorsPerception(this, actor, info);
		
		public AActor GetBodyActor()
			=> E_UAIPerceptionComponent_GetBodyActor(this);
		
		public void GetLocationAndDirection(FVector location, FVector direction)
			=> E_UAIPerceptionComponent_GetLocationAndDirection(this, location, direction);
		
		public AActor GetMutableBodyActor()
			=> E_UAIPerceptionComponent_GetMutableBodyActor(this);
		
		public FPerceptionChannelWhitelist GetPerceptionFilter()
			=> E_UAIPerceptionComponent_GetPerceptionFilter(this);
		
		public FGenericTeamId GetTeamIdentifier()
			=> E_UAIPerceptionComponent_GetTeamIdentifier(this);
		
		public float GetYoungestStimulusAge(AActor source)
			=> E_UAIPerceptionComponent_GetYoungestStimulusAge(this, source);
		
		public bool HasAnyActiveStimulus(AActor source)
			=> E_UAIPerceptionComponent_HasAnyActiveStimulus(this, source);
		
		public bool HasAnyCurrentStimulus(AActor source)
			=> E_UAIPerceptionComponent_HasAnyCurrentStimulus(this, source);
		
		public void ProcessStimuli()
			=> E_UAIPerceptionComponent_ProcessStimuli(this);
		
		protected void RemoveDeadData()
			=> E_UAIPerceptionComponent_RemoveDeadData(this);
		
		
		/// <summary>
		/// Notifies AIPerceptionSystem to update properties for this "stimuli listener"
		/// </summary>
		public void RequestStimuliListenerUpdate()
			=> E_UAIPerceptionComponent_RequestStimuliListenerUpdate(this);
		
		#endregion
		
		public static implicit operator IntPtr(UAIPerceptionComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAIPerceptionComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAIPerceptionComponent>(PtrDesc);
		}}}
