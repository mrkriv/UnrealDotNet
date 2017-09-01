using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FTimeline
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FTimeline()
		{
			NativePointer = E_CreateStruct_FTimeline();
			IsRef = false;
		}

		internal FTimeline(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FTimeline();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FTimeline_Play(FTimeline Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FTimeline_IsPlaying(FTimeline Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FTimeline_SetPlaybackPosition(FTimeline Self, float NewPosition, bool bFireEvents, bool bFireUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FTimeline_GetPlaybackPosition(FTimeline Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FTimeline_SetLooping(FTimeline Self, bool bNewLooping);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FTimeline_SetPlayRate(FTimeline Self, float NewRate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FTimeline_SetPropertySetObject(FTimeline Self, IntPtr NewPropertySetObject);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FTimeline_SetDirectionPropertyName(FTimeline Self, string InDirectionPropertyName);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Start playback of timeline
		/// </summary>
		public void Play()
			=> E_FTimeline_Play(this);
		
		
		/// <summary>
		/// Get whether this timeline is playing or not.
		/// </summary>
		public bool IsPlaying()
			=> E_FTimeline_IsPlaying(this);
		
		
		/// <summary>
		/// Jump to a position in the timeline. If bFireEvents is true, event functions will fire, otherwise will not.
		/// </summary>
		public void SetPlaybackPosition(float NewPosition, bool bFireEvents, bool bFireUpdate = true)
			=> E_FTimeline_SetPlaybackPosition(this, NewPosition, bFireEvents, bFireUpdate);
		
		
		/// <summary>
		/// Get the current playback position of the Timeline
		/// </summary>
		public float GetPlaybackPosition()
			=> E_FTimeline_GetPlaybackPosition(this);
		
		
		/// <summary>
		/// true means we whould loop, false means we should not.
		/// </summary>
		public void SetLooping(bool bNewLooping)
			=> E_FTimeline_SetLooping(this, bNewLooping);
		
		
		/// <summary>
		/// Sets the new play rate for this timeline
		/// </summary>
		public void SetPlayRate(float NewRate)
			=> E_FTimeline_SetPlayRate(this, NewRate);
		
		
		/// <summary>
		/// Optionally provide an object to automatically update properties on
		/// </summary>
		public void SetPropertySetObject(UObject NewPropertySetObject)
			=> E_FTimeline_SetPropertySetObject(this, NewPropertySetObject);
		
		
		/// <summary>
		/// Set the delegate to call when timeline is finished
		/// </summary>
		public void SetDirectionPropertyName(string InDirectionPropertyName)
			=> E_FTimeline_SetDirectionPropertyName(this, InDirectionPropertyName);
		
		#endregion
		
		public static implicit operator IntPtr(FTimeline Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTimeline(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTimeline(Adress, false);
		}}}
