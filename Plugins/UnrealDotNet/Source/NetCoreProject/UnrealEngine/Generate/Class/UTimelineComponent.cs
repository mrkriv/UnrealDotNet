using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// TimelineComponent holds a series of events, floats, vectors or colors with associated keyframes.
	/// Events can be triggered at keyframes along the timeline.
	/// Floats, vectors, and colors are interpolated between keyframes along the timeline.
	/// </summary>
	public partial class UTimelineComponent : UActorComponent
	{
		public UTimelineComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_Play(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UTimelineComponent_IsPlaying(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetPlaybackPosition(IntPtr Self, float NewPosition, bool bFireEvents, bool bFireUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UTimelineComponent_GetPlaybackPosition(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetLooping(IntPtr Self, bool bNewLooping);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetPlayRate(IntPtr Self, float NewRate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetPropertySetObject(IntPtr Self, IntPtr NewPropertySetObject);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetDirectionPropertyName(IntPtr Self, string DirectionPropertyName);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Start playback of timeline
		/// </summary>
		public void Play()
			=> E_UTimelineComponent_Play(NativePointer);
		
		
		/// <summary>
		/// Get whether this timeline is playing or not.
		/// </summary>
		public bool IsPlaying()
			=> E_UTimelineComponent_IsPlaying(NativePointer);
		
		
		/// <summary>
		/// Jump to a position in the timeline.
		/// @param bFireEvents If true, event functions that are between current position and new playback position will fire.
		/// @param bFireUpdate If true, the update output exec will fire after setting the new playback position.
		/// </summary>
		public void SetPlaybackPosition(float NewPosition, bool bFireEvents, bool bFireUpdate = true)
			=> E_UTimelineComponent_SetPlaybackPosition(NativePointer, NewPosition, bFireEvents, bFireUpdate);
		
		
		/// <summary>
		/// Get the current playback position of the Timeline
		/// </summary>
		public float GetPlaybackPosition()
			=> E_UTimelineComponent_GetPlaybackPosition(NativePointer);
		
		
		/// <summary>
		/// true means we would loop, false means we should not.
		/// </summary>
		public void SetLooping(bool bNewLooping)
			=> E_UTimelineComponent_SetLooping(NativePointer, bNewLooping);
		
		
		/// <summary>
		/// Sets the new play rate for this timeline
		/// </summary>
		public void SetPlayRate(float NewRate)
			=> E_UTimelineComponent_SetPlayRate(NativePointer, NewRate);
		
		
		/// <summary>
		/// Optionally provide an object to automatically update properties on
		/// </summary>
		public void SetPropertySetObject(UObject NewPropertySetObject)
			=> E_UTimelineComponent_SetPropertySetObject(NativePointer, NewPropertySetObject);
		
		
		/// <summary>
		/// Set the delegate to call when timeline is finished
		/// </summary>
		public void SetDirectionPropertyName(string DirectionPropertyName)
			=> E_UTimelineComponent_SetDirectionPropertyName(NativePointer, DirectionPropertyName);
		
		#endregion
		
		public static implicit operator IntPtr(UTimelineComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UTimelineComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UTimelineComponent(Adress);
		}}}
