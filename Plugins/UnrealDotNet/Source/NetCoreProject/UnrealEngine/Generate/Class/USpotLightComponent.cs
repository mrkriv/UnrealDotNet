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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USpotLightComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USpotLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USpotLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USpotLightComponent>(PtrDesc);
		}}}
