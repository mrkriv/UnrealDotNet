using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPostProcessComponent : USceneComponent
	{
		public UPostProcessComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPostProcessComponent(UObject Parent = null, string Name = "PostProcessComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPostProcessComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UPostProcessComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UPostProcessComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPostProcessComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UPostProcessComponent ?? new UPostProcessComponent(Adress);
		}}}
