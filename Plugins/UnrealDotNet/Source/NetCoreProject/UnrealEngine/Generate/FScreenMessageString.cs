using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Helper struct for tracking on screen messages.
	/// </summary>
	public partial struct FScreenMessageString
	{
		
		#region DLLInmport
		#endregion
		
		#region Property
		public float TimeToDisplay { get; set; } 
		public float CurrentTimeDisplayed { get; set; } 
		public FVector2D TextScale { get; set; } 
		#endregion
		
		#region ExternMethods
		#endregion
		
	}}
