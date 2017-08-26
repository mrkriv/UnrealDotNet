using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FTransform
	{
		
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FTransform_DiagnosticCheckNaN_Scale3D(FTransform Self);
		
		#endregion
		
		#region ExternMethods
		public void DiagnosticCheckNaN_Scale3D()
		{
			E_FTransform_DiagnosticCheckNaN_Scale3D(this);
		}

		#endregion
		
	}}
