using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FActorSpawnParameters
	{
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FActorSpawnParameters_IsRemoteOwned(FActorSpawnParameters Self);
		
		#endregion
		
		#region Property
		public AActor Template { get; set; } 
		public AActor Owner { get; set; } 
		#endregion
		
		#region ExternMethods
		public bool IsRemoteOwned()
			=> E_FActorSpawnParameters_IsRemoteOwned(this);
		
		#endregion
		
	}}
