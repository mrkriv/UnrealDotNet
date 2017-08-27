using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Contains a group of levels of a particular ELevelCollectionType within a UWorld
	/// and the context required to properly tick/update those levels. This object is move-only.
	/// </summary>
	public partial struct FLevelCollection
	{
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FLevelCollection_IsVisible(FLevelCollection Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FLevelCollection_SetIsVisible(FLevelCollection Self, bool bInIsVisible);
		
		#endregion
		
		#region Property
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Gets whether this collection is currently visible.
		/// </summary>
		public bool IsVisible()
			=> E_FLevelCollection_IsVisible(this);
		
		
		/// <summary>
		/// Sets whether this collection is currently visible.
		/// </summary>
		public void SetIsVisible(bool bInIsVisible)
			=> E_FLevelCollection_SetIsVisible(this, bInIsVisible);
		
		#endregion
		
	}}
