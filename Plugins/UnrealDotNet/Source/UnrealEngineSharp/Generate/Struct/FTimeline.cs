// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:189

namespace UnrealEngine
{
	public  partial class FTimeline : NativeStructWrapper
	{
		internal FTimeline(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Cached property pointer for setting timeline direction </para>
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
		/// <para>Get the current playback position of the Timeline </para>
		/// </summary>
		public float GetPlaybackPosition()
			=> E_FTimeline_GetPlaybackPosition(this);
		
		
		/// <summary>
		/// <para>Get the current play rate for this timeline </para>
		/// </summary>
		public float GetPlayRate()
			=> E_FTimeline_GetPlayRate(this);
		
		
		/// <summary>
		/// <para>Get length of the timeline </para>
		/// </summary>
		public float GetTimelineLength()
			=> E_FTimeline_GetTimelineLength(this);
		
		
		/// <summary>
		/// <para>Get whether we are looping or not </para>
		/// </summary>
		public bool IsLooping()
			=> E_FTimeline_IsLooping(this);
		
		
		/// <summary>
		/// <para>Get whether this timeline is playing or not. </para>
		/// </summary>
		public bool IsPlaying()
			=> E_FTimeline_IsPlaying(this);
		
		
		/// <summary>
		/// <para>Get whether we are reversing or not </para>
		/// </summary>
		public bool IsReversing()
			=> E_FTimeline_IsReversing(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline </para>
		/// </summary>
		public void Play()
			=> E_FTimeline_Play(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline from the start </para>
		/// </summary>
		public void PlayFromStart()
			=> E_FTimeline_PlayFromStart(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline in reverse </para>
		/// </summary>
		public void Reverse()
			=> E_FTimeline_Reverse(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline in reverse from the end </para>
		/// </summary>
		public void ReverseFromEnd()
			=> E_FTimeline_ReverseFromEnd(this);
		
		
		/// <summary>
		/// <para>Set the delegate to call when timeline is finished </para>
		/// </summary>
		public void SetDirectionPropertyName(string inDirectionPropertyName)
			=> E_FTimeline_SetDirectionPropertyName(this, inDirectionPropertyName);
		
		
		/// <summary>
		/// <para>true means we whould loop, false means we should not. </para>
		/// </summary>
		public void SetLooping(bool bNewLooping)
			=> E_FTimeline_SetLooping(this, bNewLooping);
		
		
		/// <summary>
		/// <para>Set the new playback position time to use </para>
		/// </summary>
		public void SetNewTime(float newTime)
			=> E_FTimeline_SetNewTime(this, newTime);
		
		
		/// <summary>
		/// <para>Jump to a position in the timeline. If bFireEvents is true, event functions will fire, otherwise will not. </para>
		/// </summary>
		public void SetPlaybackPosition(float newPosition, bool bFireEvents, bool bFireUpdate = true)
			=> E_FTimeline_SetPlaybackPosition(this, newPosition, bFireEvents, bFireUpdate);
		
		
		/// <summary>
		/// <para>Sets the new play rate for this timeline </para>
		/// </summary>
		public void SetPlayRate(float newRate)
			=> E_FTimeline_SetPlayRate(this, newRate);
		
		
		/// <summary>
		/// <para>Optionally provide an object to automatically update properties on </para>
		/// </summary>
		public void SetPropertySetObject(UObject newPropertySetObject)
			=> E_FTimeline_SetPropertySetObject(this, newPropertySetObject);
		
		
		/// <summary>
		/// <para>Set the length of the timeline </para>
		/// </summary>
		public void SetTimelineLength(float newLength)
			=> E_FTimeline_SetTimelineLength(this, newLength);
		
		
		/// <summary>
		/// <para>Sets the timeline length mode </para>
		/// </summary>
		public void SetTimelineLengthMode(ETimelineLengthMode newMode)
			=> E_FTimeline_SetTimelineLengthMode(this, (byte)newMode);
		
		
		/// <summary>
		/// <para>Stop playback of timeline </para>
		/// </summary>
		public void Stop()
			=> E_FTimeline_Stop(this);
		
		
		/// <summary>
		/// <para>Advance the timeline, if playing, firing delegates </para>
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
