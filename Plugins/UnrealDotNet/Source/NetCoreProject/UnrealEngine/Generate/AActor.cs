using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class AActor : UObject
	{
		public AActor(IntPtr Adress)
			: base(Adress)
		{
			
		}

		#region DLLInmport
		#endregion
		
		#region ExternMethods
		#endregion
		
		public static explicit operator IntPtr(AActor Self)
		{
			return Self.NativePointer;
			
		}

		public static implicit operator AActor(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new AActor(Adress);
			
		}

	}

}
