// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:391

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageTimelineComponent
	/// <para>Returns the time value of the last keyframe in any of the timeline's curves </para>
	/// </summary>
	public  partial class UTimelineComponent : UActorComponent
	{
		public UTimelineComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UTimelineComponent(UObject Parent = null, string Name = "TimelineComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UTimelineComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UTimelineComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UTimelineComponent_GetIgnoreTimeDilation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UTimelineComponent_GetPlaybackPosition(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UTimelineComponent_GetPlayRate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UTimelineComponent_GetTimelineLength(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UTimelineComponent_IsLooping(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UTimelineComponent_IsPlaying(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UTimelineComponent_IsReversing(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_Play(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_PlayFromStart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_Reverse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_ReverseFromEnd(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_SetDirectionPropertyName(IntPtr self, string directionPropertyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_SetIgnoreTimeDilation(IntPtr self, bool bNewIgnoreTimeDilation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_SetLooping(IntPtr self, bool bNewLooping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_SetNewTime(IntPtr self, float newTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_SetPlaybackPosition(IntPtr self, float newPosition, bool bFireEvents, bool bFireUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_SetPlayRate(IntPtr self, float newRate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_SetPropertySetObject(IntPtr self, IntPtr newPropertySetObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_SetTimelineLength(IntPtr self, float newLength);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_SetTimelineLengthMode(IntPtr self, byte newLengthMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTimelineComponent_Stop(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Get whether to ignore time dilation. </para>
		/// </summary>
		public bool GetIgnoreTimeDilation()
			=> E_UTimelineComponent_GetIgnoreTimeDilation(this);
		
		
		/// <summary>
		/// <para>Get the current playback position of the Timeline </para>
		/// </summary>
		public float GetPlaybackPosition()
			=> E_UTimelineComponent_GetPlaybackPosition(this);
		
		
		/// <summary>
		/// <para>Get the current play rate for this timeline </para>
		/// </summary>
		public float GetPlayRate()
			=> E_UTimelineComponent_GetPlayRate(this);
		
		
		/// <summary>
		/// <para>Get length of the timeline </para>
		/// </summary>
		public float GetTimelineLength()
			=> E_UTimelineComponent_GetTimelineLength(this);
		
		
		/// <summary>
		/// <para>Get whether we are looping or not </para>
		/// </summary>
		public bool IsLooping()
			=> E_UTimelineComponent_IsLooping(this);
		
		
		/// <summary>
		/// <para>Get whether this timeline is playing or not. </para>
		/// </summary>
		public bool IsPlaying()
			=> E_UTimelineComponent_IsPlaying(this);
		
		
		/// <summary>
		/// <para>Get whether we are reversing or not </para>
		/// </summary>
		public bool IsReversing()
			=> E_UTimelineComponent_IsReversing(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline </para>
		/// </summary>
		public void Play()
			=> E_UTimelineComponent_Play(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline from the start </para>
		/// </summary>
		public void PlayFromStart()
			=> E_UTimelineComponent_PlayFromStart(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline in reverse </para>
		/// </summary>
		public void Reverse()
			=> E_UTimelineComponent_Reverse(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline in reverse from the end </para>
		/// </summary>
		public void ReverseFromEnd()
			=> E_UTimelineComponent_ReverseFromEnd(this);
		
		
		/// <summary>
		/// <para>Set the delegate to call when timeline is finished </para>
		/// </summary>
		public void SetDirectionPropertyName(string directionPropertyName)
			=> E_UTimelineComponent_SetDirectionPropertyName(this, directionPropertyName);
		
		
		/// <summary>
		/// <para>Set whether to ignore time dilation. </para>
		/// </summary>
		public void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation)
			=> E_UTimelineComponent_SetIgnoreTimeDilation(this, bNewIgnoreTimeDilation);
		
		
		/// <summary>
		/// <para>true means we would loop, false means we should not. </para>
		/// </summary>
		public void SetLooping(bool bNewLooping)
			=> E_UTimelineComponent_SetLooping(this, bNewLooping);
		
		
		/// <summary>
		/// <para>Set the new playback position time to use </para>
		/// </summary>
		public void SetNewTime(float newTime)
			=> E_UTimelineComponent_SetNewTime(this, newTime);
		
		
		/// <summary>
		/// <para>Jump to a position in the timeline. </para>
		/// <param name="bFireEvents">If true, event functions that are between current position and new playback position will fire. </param>
		/// <param name="bFireUpdate">If true, the update output exec will fire after setting the new playback position. </param>
		/// </summary>
		public void SetPlaybackPosition(float newPosition, bool bFireEvents, bool bFireUpdate = true)
			=> E_UTimelineComponent_SetPlaybackPosition(this, newPosition, bFireEvents, bFireUpdate);
		
		
		/// <summary>
		/// <para>Sets the new play rate for this timeline </para>
		/// </summary>
		public void SetPlayRate(float newRate)
			=> E_UTimelineComponent_SetPlayRate(this, newRate);
		
		
		/// <summary>
		/// <para>Optionally provide an object to automatically update properties on </para>
		/// </summary>
		public void SetPropertySetObject(UObject newPropertySetObject)
			=> E_UTimelineComponent_SetPropertySetObject(this, newPropertySetObject);
		
		
		/// <summary>
		/// <para>Set length of the timeline </para>
		/// </summary>
		public void SetTimelineLength(float newLength)
			=> E_UTimelineComponent_SetTimelineLength(this, newLength);
		
		
		/// <summary>
		/// <para>Sets the length mode of the timeline </para>
		/// </summary>
		public void SetTimelineLengthMode(ETimelineLengthMode newLengthMode)
			=> E_UTimelineComponent_SetTimelineLengthMode(this, (byte)newLengthMode);
		
		
		/// <summary>
		/// <para>Stop playback of timeline </para>
		/// </summary>
		public void Stop()
			=> E_UTimelineComponent_Stop(this);
		
		#endregion
		
		public static implicit operator IntPtr(UTimelineComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UTimelineComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UTimelineComponent>(PtrDesc);
		}}}
