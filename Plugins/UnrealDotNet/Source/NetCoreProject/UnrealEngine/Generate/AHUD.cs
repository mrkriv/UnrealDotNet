using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class AHUD : AActor
	{
		public AHUD(IntPtr Adress)
			: base(Adress)
		{
			
		}

		#region DLLInmport
		#endregion
		
		#region ExternMethods
		#endregion
		
		public static explicit operator IntPtr(AHUD Self)
		{
			return Self.NativePointer;
			
		}

		public static implicit operator AHUD(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new AHUD(Adress);
			
		}

	}

}
