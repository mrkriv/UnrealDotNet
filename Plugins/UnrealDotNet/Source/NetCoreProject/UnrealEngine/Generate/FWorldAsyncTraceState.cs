using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// This encapsulate World's async trace functionality. This contains two buffers of trace data buffer and alternates it for each tick.
	/// You can use async trace using following APIs : AsyncLineTrace, AsyncSweep, AsyncOverlap
	/// When you use those APIs, it will be saved to AsyncTraceData
	/// FWorldAsyncTraceState contains two buffers to rotate each frame as you might need the result in the next frame
	/// However, if you do not get the result by next frame, the result will be discarded.
	/// Use Delegate if you would like to get the result right away when available.
	/// </summary>
	public partial struct FWorldAsyncTraceState
	{
		
		#region DLLInmport
		#endregion
		
		#region Property
		
		/// <summary>
		/// Used as counter for Buffer swap for DataBuffer. Right now it's only 2, but it can change.
		/// </summary>
		public int CurrentFrame { get; set; } 
		#endregion
		
		#region ExternMethods
		#endregion
		
	}}
