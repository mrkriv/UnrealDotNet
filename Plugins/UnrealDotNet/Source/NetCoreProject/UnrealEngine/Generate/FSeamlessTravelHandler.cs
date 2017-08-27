using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// class that encapsulates seamless world traveling
	/// </summary>
	public partial class FSeamlessTravelHandler
	{
		protected readonly IntPtr NativePointer;
		
		public FSeamlessTravelHandler(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FSeamlessTravelHandler_IsInTransition(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FSeamlessTravelHandler_CancelTravel(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FSeamlessTravelHandler_SetPauseAtMidpoint(IntPtr Self, bool bNowPaused);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern UWorld E_FSeamlessTravelHandler_Tick(IntPtr Self);
		
		#endregion
		
		#region Property
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// @return whether a transition is already in progress
		/// </summary>
		public bool IsInTransition()
			=> E_FSeamlessTravelHandler_IsInTransition(NativePointer);
		
		
		/// <summary>
		/// cancels transition in progress
		/// </summary>
		public void CancelTravel()
			=> E_FSeamlessTravelHandler_CancelTravel(NativePointer);
		
		
		/// <summary>
		/// turns on/off pausing after loading the transition map
		/// only valid during travel, before we've started loading the final destination
		/// @param bNowPaused - whether the transition should now be paused
		/// </summary>
		public void SetPauseAtMidpoint(bool bNowPaused)
			=> E_FSeamlessTravelHandler_SetPauseAtMidpoint(NativePointer, bNowPaused);
		
		
		/// <summary>
		/// Ticks the transition; handles performing the world switch once the required packages have been loaded
		/// @returns	The new primary world if the world has changed, null if it has not
		/// </summary>
		public UWorld Tick()
			=> E_FSeamlessTravelHandler_Tick(NativePointer);
		
		#endregion
		
		public static explicit operator IntPtr(FSeamlessTravelHandler Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSeamlessTravelHandler(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSeamlessTravelHandler(Adress);
		}}}
