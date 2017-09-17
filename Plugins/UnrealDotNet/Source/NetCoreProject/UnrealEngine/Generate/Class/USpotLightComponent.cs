using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USpotLightComponent : UPointLightComponent
	{
		public USpotLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USpotLightComponent(UObject Parent = null, string Name = "SpotLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USpotLightComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_USpotLightComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USpotLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USpotLightComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USpotLightComponent ?? new USpotLightComponent(Adress);
		}}}
