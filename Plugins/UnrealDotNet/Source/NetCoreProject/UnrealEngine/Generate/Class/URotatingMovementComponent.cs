using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

namespace UnrealEngine
{
	public  partial class URotatingMovementComponent : UMovementComponent
	{
		public URotatingMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public URotatingMovementComponent(UObject Parent = null, string Name = "RotatingMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_URotatingMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_URotatingMovementComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(URotatingMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator URotatingMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<URotatingMovementComponent>(PtrDesc);
		}}}
