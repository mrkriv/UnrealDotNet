using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPoseableMeshComponent : USkinnedMeshComponent
	{
		public UPoseableMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPoseableMeshComponent(UObject Parent = null, string Name = "PoseableMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPoseableMeshComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPoseableMeshComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UPoseableMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPoseableMeshComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UPoseableMeshComponent ?? new UPoseableMeshComponent(Adress);
		}
}
}
