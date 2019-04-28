// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:189

namespace UnrealEngine
{
	public  partial class FTimeline : NativeStructWrapper
	{
		internal FTimeline(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Cached property pointer for setting timeline direction
		/// </summary>
		public FTimeline() :
			base(E_CreateStruct_FTimeline(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTimeline();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTimeline_GetPlaybackPosition(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTimeline_GetPlayRate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTimeline_GetTimelineLength(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTimeline_IsLooping(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTimeline_IsPlaying(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTimeline_IsReversing(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_Play(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_PlayFromStart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_Reverse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_ReverseFromEnd(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_SetDirectionPropertyName(IntPtr self, string inDirectionPropertyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_SetLooping(IntPtr self, bool bNewLooping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_SetNewTime(IntPtr self, float newTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_SetPlaybackPosition(IntPtr self, float newPosition, bool bFireEvents, bool bFireUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_SetPlayRate(IntPtr self, float newRate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_SetPropertySetObject(IntPtr self, IntPtr newPropertySetObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_SetTimelineLength(IntPtr self, float newLength);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_SetTimelineLengthMode(IntPtr self, byte newMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_Stop(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTimeline_TickTimeline(IntPtr self, float deltaTime);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Get the current playback position of the Timeline
		/// </summary>
		public float GetPlaybackPosition()
			=> E_FTimeline_GetPlaybackPosition(this);
		
		
		/// <summary>
		/// Get the current play rate for this timeline
		/// </summary>
		public float GetPlayRate()
			=> E_FTimeline_GetPlayRate(this);
		
		
		/// <summary>
		/// Get length of the timeline
		/// </summary>
		public float GetTimelineLength()
			=> E_FTimeline_GetTimelineLength(this);
		
		
		/// <summary>
		/// Get whether we are looping or not
		/// </summary>
		public bool IsLooping()
			=> E_FTimeline_IsLooping(this);
		
		
		/// <summary>
		/// Get whether this timeline is playing or not.
		/// </summary>
		public bool IsPlaying()
			=> E_FTimeline_IsPlaying(this);
		
		
		/// <summary>
		/// Get whether we are reversing or not
		/// </summary>
		public bool IsReversing()
			=> E_FTimeline_IsReversing(this);
		
		
		/// <summary>
		/// Start playback of timeline
		/// </summary>
		public void Play()
			=> E_FTimeline_Play(this);
		
		
		/// <summary>
		/// Start playback of timeline from the start
		/// </summary>
		public void PlayFromStart()
			=> E_FTimeline_PlayFromStart(this);
		
		
		/// <summary>
		/// Start playback of timeline in reverse
		/// </summary>
		public void Reverse()
			=> E_FTimeline_Reverse(this);
		
		
		/// <summary>
		/// Start playback of timeline in reverse from the end
		/// </summary>
		public void ReverseFromEnd()
			=> E_FTimeline_ReverseFromEnd(this);
		
		
		/// <summary>
		/// Set the delegate to call when timeline is finished
		/// </summary>
		public void SetDirectionPropertyName(string inDirectionPropertyName)
			=> E_FTimeline_SetDirectionPropertyName(this, inDirectionPropertyName);
		
		
		/// <summary>
		/// true means we whould loop, false means we should not.
		/// </summary>
		public void SetLooping(bool bNewLooping)
			=> E_FTimeline_SetLooping(this, bNewLooping);
		
		
		/// <summary>
		/// Set the new playback position time to use
		/// </summary>
		public void SetNewTime(float newTime)
			=> E_FTimeline_SetNewTime(this, newTime);
		
		
		/// <summary>
		/// Jump to a position in the timeline. If bFireEvents is true, event functions will fire, otherwise will not.
		/// </summary>
		public void SetPlaybackPosition(float newPosition, bool bFireEvents, bool bFireUpdate = true)
			=> E_FTimeline_SetPlaybackPosition(this, newPosition, bFireEvents, bFireUpdate);
		
		
		/// <summary>
		/// Sets the new play rate for this timeline
		/// </summary>
		public void SetPlayRate(float newRate)
			=> E_FTimeline_SetPlayRate(this, newRate);
		
		
		/// <summary>
		/// Optionally provide an object to automatically update properties on
		/// </summary>
		public void SetPropertySetObject(UObject newPropertySetObject)
			=> E_FTimeline_SetPropertySetObject(this, newPropertySetObject);
		
		
		/// <summary>
		/// Set the length of the timeline
		/// </summary>
		public void SetTimelineLength(float newLength)
			=> E_FTimeline_SetTimelineLength(this, newLength);
		
		
		/// <summary>
		/// Sets the timeline length mode
		/// </summary>
		public void SetTimelineLengthMode(ETimelineLengthMode newMode)
			=> E_FTimeline_SetTimelineLengthMode(this, (byte)newMode);
		
		
		/// <summary>
		/// Stop playback of timeline
		/// </summary>
		public void Stop()
			=> E_FTimeline_Stop(this);
		
		
		/// <summary>
		/// Advance the timeline, if playing, firing delegates
		/// </summary>
		public void TickTimeline(float deltaTime)
			=> E_FTimeline_TickTimeline(this, deltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(FTimeline self)
		{
			return self.NativePointer;
		}

		public static implicit operator FTimeline(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimeline(Adress, false);
		}}}
