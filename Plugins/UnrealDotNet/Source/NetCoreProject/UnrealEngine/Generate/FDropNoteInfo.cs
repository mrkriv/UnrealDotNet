using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Info about one note dropped in the map during PIE.
	/// </summary>
	public partial struct FDropNoteInfo
	{
		
		#region DLLInmport
		#endregion
		
		#region Property
		public FVector Location { get; set; } 
		public FRotator Rotation { get; set; } 
		#endregion
		
		#region ExternMethods
		#endregion
		
	}}
