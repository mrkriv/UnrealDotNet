using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UDrawSphereComponent : USphereComponent
	{
		public UDrawSphereComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UDrawSphereComponent(UObject Parent = null, string Name = "DrawSphereComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDrawSphereComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDrawSphereComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UDrawSphereComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDrawSphereComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UDrawSphereComponent>(PtrDesc);
		}}}
