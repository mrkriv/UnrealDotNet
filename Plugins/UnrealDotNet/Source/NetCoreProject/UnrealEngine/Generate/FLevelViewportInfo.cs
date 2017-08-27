using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Saved editor viewport state information
	/// </summary>
	public partial struct FLevelViewportInfo
	{
		
		#region DLLInmport
		#endregion
		
		#region Property
		public FVector CamPosition { get; set; } 
		public FRotator CamRotation { get; set; } 
		public float CamOrthoZoom { get; set; } 
		public bool CamUpdated { get; set; } 
		#endregion
		
		#region ExternMethods
		#endregion
		
	}}
