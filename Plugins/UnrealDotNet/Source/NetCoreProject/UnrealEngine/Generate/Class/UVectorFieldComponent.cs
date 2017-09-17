using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UVectorFieldComponent : UPrimitiveComponent
	{
		public UVectorFieldComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UVectorFieldComponent(UObject Parent = null, string Name = "VectorFieldComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UVectorFieldComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UVectorFieldComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UVectorFieldComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UVectorFieldComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UVectorFieldComponent ?? new UVectorFieldComponent(Adress);
		}}}
